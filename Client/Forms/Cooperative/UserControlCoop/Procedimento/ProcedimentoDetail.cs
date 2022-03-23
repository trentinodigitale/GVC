using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Client.Forms.Common;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Procedimento
{
    public partial class ProcedimentoDetail : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        #region Instance Variables (5)

        private CooperativaFDT itemCoop = null;
        DizionarioFDT[] listaTipiConclusioni;
        DizionarioFDT[] listaTipiIniziative;
        DizionarioFDT[] listaTipiProcedimenti;
        DizionarioFDT[] listaTipiSospensioni;

        private int TipoProcedimentoFilter = 0;
        private int TipoIniziativaFilter = 0;
        private int TipoStatoFilter = 0;


        #endregion Instance Variables

        public override bool ReadOnlyControls
        {
            get
            {
                return base.ReadOnlyControls;
            }
            set
            {
                base.ReadOnlyControls = value;

                if (panelControl3 != null)
                {
                    SetReadOnlyControls(panelControl3.Controls, false);
                }
            }
        }

        #region Constructors (1)
        
        public ProcedimentoDetail()
        {
            InitializeComponent();

            SetImages();

            EnableControlAutoSize(new object[] { this }, gridControlProcess, 100);
        }

        #endregion Constructors (1)

        #region Private Methods

        private ProcedimentoFDT GetCurrentItem()
        {
            ProcedimentoFDT toReturn = null;

            if (this.bindingSourceProcedimenti.Current != null)
            {
                toReturn = this.bindingSourceProcedimenti.Current as ProcedimentoFDT;
            }
            return toReturn;
        }

        private DialogResult OpenForEdit(ProcedimentoFDT Procedimento)
        {
            ProcedimentoEdit page = CreatePage<ProcedimentoEdit>();

            if (page != null)
            {
                page.SetFormTitle("Gestione procedimenti");
                page.SetBindableData(Procedimento, listaTipiConclusioni, listaTipiIniziative, listaTipiProcedimenti, listaTipiSospensioni);

                DialogResult dr = DialogResult.OK;
                while (dr == DialogResult.OK)
                {
                    page.ErrorProviderProcedimento.ClearErrors();

                    dr = page.BaseForm.ShowDialog(this, this.ReadOnlyControls);

                    if (dr == DialogResult.OK)
                    {
                        if (!page.ErrorProviderProcedimento.HasErrors)
                            break;
                    }
                }
                return dr;
            }
            else
                return DialogResult.None;
        }

        private void AddProcedimento()
        {
            ProcedimentoFDT item = new ProcedimentoFDT();

            item.IdRegistro = (item != null) ? itemCoop.RegistroCooperativa.IdRegistro : -1;
            item.IdProcedimento = -1;

            if (OpenForEdit(item) == DialogResult.OK)
            {
                item.Status = ObjectStatus.ToInsert;

                gridViewProcess.BeginDataUpdate();
                itemCoop.RegistroCooperativa.AddProcedimento(item);
                this.bindingSourceProcedimenti.DataSource = itemCoop.RegistroCooperativa.Procedimenti;
                gridViewProcess.EndDataUpdate();
            }
        }

        private void ModifyProcedimento()
        {
            ProcedimentoFDT item = GetCurrentItem();

            if (item != null)
            {
                Boolean goOn = true;
                if (item.Status >= ObjectStatus.ToHide)
                {
                    goOn = false;
                }

                if (goOn)
                {
                    item.EndEdit();
                    item.BeginEdit();

                    if (OpenForEdit(item) == DialogResult.OK)
                    {
                        item.EndEdit();

                        if (item != null)
                        {
                            if (item.Status != ObjectStatus.ToInsert)
                                item.Status = ObjectStatus.ToUpdate;
                            this.bindingSourceProcedimenti.EndEdit();
                            gridViewProcess.RefreshData();
                        }
                        else
                        {
                            this.bindingSourceProcedimenti.CancelEdit();
                            ShowProblemsMessage();
                        }
                    }
                    else
                    {
                        item.CancelEdit();
                        this.bindingSourceProcedimenti.CancelEdit();
                    }
                }
            }
        }

        private void DeleteProcedimento()
        {
            ProcedimentoFDT item = GetCurrentItem();

            if (item != null)
            {
                if (ShowConfirmMessage("Cancellazione", "Confermi la cancellazione dell'elemento selezionato?", string.Empty) == DialogResult.Yes)
                {
                    if (item.IdProcedimento > 0)
                    {
                        item.Status = ObjectStatus.ToCancel;
                    }
                    else
                    {
                        ProcedimentoFDT[] listActual = this.bindingSourceProcedimenti.DataSource as ProcedimentoFDT[];

                        if (listActual != null)
                        {
                            List<ProcedimentoFDT> lTemp = new List<ProcedimentoFDT>();
                            foreach (ProcedimentoFDT ind in listActual)
                            {
                                if (ind != item)
                                {
                                    lTemp.Add(ind);
                                }
                            }
                            if (itemCoop != null && itemCoop.RegistroCooperativa != null)
                            {
                                itemCoop.RegistroCooperativa.Procedimenti = lTemp.ToArray();
                                this.bindingSourceProcedimenti.DataSource = itemCoop.RegistroCooperativa.Procedimenti;
                            }
                        }
                    }

                    gridViewProcess.RefreshData();
                    SetVisibilityBarButton(item);
                }
            }
        }

        private void HandleCurrentItemChange()
        {
            if (this.bindingSourceProcedimenti.Current != null)
            {
                ProcedimentoFDT procedimento = this.bindingSourceProcedimenti.Current as ProcedimentoFDT;
                if (procedimento != null)
                {
                    SetVisibilityBarButton(procedimento);
                }
            }
        }

        private void SetImages()
        {
            this.barButtonItemAdd.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Document_Add_24x24);
            this.barButtonItemEdit.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Edit_24x24);
            this.barButtonItemDelete.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
        }

        private void SetVisibilityBarButton()
        {
            ProcedimentoFDT item = GetCurrentItem();
            SetVisibilityBarButton(item);
        }

        private void SetVisibilityBarButton(ProcedimentoFDT item)
        {
            if (!this.ReadOnlyControls)
            {
                this.barButtonItemDelete.Enabled = true;
                this.barButtonItemEdit.Enabled = true;

                if (item != null)
                {
                    if (item.Status >= ObjectStatus.ToHide)
                    {
                        this.barButtonItemDelete.Enabled = false;
                        this.barButtonItemEdit.Enabled = false;
                    }
                }
            }
        }

        #endregion Private Methods

        #region Public Methods (1)

        public void SetBindableData(CooperativaFDT item)
        {          
            itemCoop = item;

            if (itemCoop != null && item.RegistroCooperativa != null)
            {
                this.bindingSourceProcedimenti.DataSource = itemCoop.RegistroCooperativa.Procedimenti;
            }
            
            listaTipiConclusioni = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_CONCLUSIONE);
            this.bindingSourceTipiConclusioni.DataSource = listaTipiConclusioni;

            
            listaTipiIniziative = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_INIZIATIVA);
            this.bindingSourceTipiIniziative.DataSource = listaTipiIniziative;

            
            listaTipiProcedimenti = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_PROCEDIMENTO);
            this.bindingSourceTipiProcedimenti.DataSource = listaTipiProcedimenti;

            
            listaTipiSospensioni = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_SOSPENSIONE);
            this.bindingSourceTipiSospensioni.DataSource = listaTipiSospensioni;

            this.bindingSourceBaseStati.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_STATO_PROCEDIMENTO);
        }

        public void UpdateProcedimento()
        {
            AddProcedimento();
        }

        #endregion Public Methods

        #region Event Handlers

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddProcedimento();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteProcedimento();
        }

        private void barButtonItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ModifyProcedimento();
        }

        private void gridControlProcess_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifyProcedimento();
        }

        private void gridViewProcess_ShowGridMenu(object sender, GridMenuEventArgs e)
        {
            ProcedimentoFDT item = GetCurrentItem();
            if (item != null)
            {
                GridView view = sender as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
                if (hitInfo.InRow)
                {
                    view.FocusedRowHandle = hitInfo.RowHandle;
                    popupMenuProcedimenti.ShowPopup(BarManager,
                            gridControlProcess.PointToScreen(e.Point));
                }
            }
        }

        private void bindingSourceProcedimenti_CurrentChanged(object sender, EventArgs e)
        {
            HandleCurrentItemChange();
        }

        #endregion Event Handlers

        private void ApplyFilter()
        {
            StringBuilder condition = new StringBuilder();

            if (TipoProcedimentoFilter > 0)
            {
                if (condition.Length > 0)
                {
                    condition.Append(" And ");
                }
                colIdTipoProcedimento.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
                condition.Append(string.Format("[{0}] = {1}",
                                            colIdTipoProcedimento.FieldName,
                                            TipoProcedimentoFilter));

            }
            if (TipoIniziativaFilter > 0)
            {
                if (condition.Length > 0)
                {
                    condition.Append(" And ");
                }
                colIdTipoIniziativa.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
                condition.Append(string.Format("[{0}] = {1}",
                                            colIdTipoIniziativa.FieldName,
                                            TipoIniziativaFilter));

            }
            if (TipoStatoFilter > 0)
            {
                if (condition.Length > 0)
                {
                    condition.Append(" And ");
                }
                colStatoProcedimento.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
                condition.Append(string.Format("[{0}] = {1}",
                                            colStatoProcedimento.FieldName,
                                            TipoStatoFilter));

            }


            Boolean toControl = false;
            ProcedimentoFDT[] listTemp = bindingSourceProcedimenti.DataSource as ProcedimentoFDT[];
            if (listTemp != null && listTemp.Length > 0)
                toControl = true;

            if (condition.Length > 0 && toControl)
            {
                try
                {
                    this.gridViewProcess.ActiveFilterEnabled = true;
                    this.gridViewProcess.ActiveFilterString = condition.ToString();
                }
                catch (Exception ex)
                {
                    ShowInformationMessage("Problema nella gestione del filtro di ricerca", string.Empty);
                }

            }
            else
            {
                this.gridViewProcess.ActiveFilterEnabled = false;
                this.gridViewProcess.ActiveFilterString = string.Empty;
            }
        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            // tipo procedimento

            TipoProcedimentoFilter = 0;

            if (lookUpEdit2 != null)
            {
                if (lookUpEdit2.EditValue != null)
                {
                    int idTipo = -1;
                    if (Int32.TryParse(lookUpEdit2.EditValue.ToString(), out idTipo))
                    {
                        TipoProcedimentoFilter = idTipo;
                    }
                }
            }

            ApplyFilter();
        }

        private void lookUpEdit3_EditValueChanged(object sender, EventArgs e)
        {
            // iniziativa

            TipoIniziativaFilter = 0;

            if (lookUpEdit3 != null)
            {
                if (lookUpEdit3.EditValue != null)
                {
                    int idTipo = -1;
                    if (Int32.TryParse(lookUpEdit3.EditValue.ToString(), out idTipo))
                    {
                        TipoIniziativaFilter = idTipo;
                    }
                }
            }
            ApplyFilter();
        }

        private void lookUpEditStatus_EditValueChanged(object sender, EventArgs e)
        {
            TipoStatoFilter = 0;

            if (lookUpEditStatus != null)
            {
                if (lookUpEditStatus.EditValue != null)
                {
                    int idTipo = -1;
                    if (Int32.TryParse(lookUpEditStatus.EditValue.ToString(), out idTipo))
                    {
                        TipoStatoFilter = idTipo;
                    }
                }
            }
            ApplyFilter();
        }
    }
}
