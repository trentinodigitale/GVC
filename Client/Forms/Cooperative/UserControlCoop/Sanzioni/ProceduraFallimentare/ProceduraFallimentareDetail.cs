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
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Sanzioni.ProceduraFallimentare
{
    public partial class ProceduraFallimentareDetail : it.dedagroup.GVC.Client.Forms.Common.UserControlSplitContainer
    {
        #region Instance Variables (1)

        private CooperativaFDT itemCoop = null;
        private DizionarioFDT[] tipiStati = null;

        #endregion Instance Variables (1)

        #region Constructors (1)

        public ProceduraFallimentareDetail()
        {
            InitializeComponent();

            if (!DesignMode)
            {
                EnableControlAutoSize(new object[] { this }, xtraTabControl1, 200);

                SetImages();
            }
        }

        #endregion Constructors

        #region Private Methods

        private void SetImages()
        {
            this.barButtonItemAddNew.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Document_Add_24x24);
            this.barButtonItemModify.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Edit_24x24);
            this.barButtonItemRemove.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
        }

        private void HandleCurrentItemChange()
        {
            if (this.bindingSourceFailureProcedurs.Current != null)
            {
                ProceduraFallimentareFDT fallimento = this.bindingSourceFailureProcedurs.Current as ProceduraFallimentareFDT;
                if (fallimento != null)
                {
                    this.documentationDetail1.SetBindableData(fallimento);

                    SetVisibilityBarButton(fallimento);
                }
            }
        }

        private void AddItem()
        {
            ProceduraFallimentareFDT item = new ProceduraFallimentareFDT();
            item.BeginEdit();

            item.IdRegistro = (item != null) ? itemCoop.RegistroCooperativa.IdRegistro : -1;
            item.IdProceduraFallimentare = -1;

            if (OpenForEdit(item) == DialogResult.OK)
            {
                item.Status = ObjectStatus.ToInsert;
                item.EndEdit();

                gridViewFailureProcedures.BeginDataUpdate();
                itemCoop.RegistroCooperativa.AddProceduraFallimentare(item);
                this.bindingSourceFailureProcedurs.DataSource = itemCoop.RegistroCooperativa.ProcedureFallimentari;
                gridViewFailureProcedures.EndDataUpdate();
            }
            else
            {
                item.CancelEdit();
            }
        }

        private ProceduraFallimentareFDT GetCurrentItem()
        {
            ProceduraFallimentareFDT toReturn = null;

            if (this.bindingSourceFailureProcedurs.Current != null)
            {
                toReturn = this.bindingSourceFailureProcedurs.Current as ProceduraFallimentareFDT;
            }

            return toReturn;
        }

        private DialogResult OpenForEdit(ProceduraFallimentareFDT item)
        {
            if (item != null)
            {
                ProceduraFallimentareEdit page = CreatePage<ProceduraFallimentareEdit>();
                if (page != null)
                {
                    page.SetFormTitle("Gestione procedura fallimentare");
                    page.SetBindableData(item, tipiStati);

                    DialogResult dr = DialogResult.OK;
                    while (dr == DialogResult.OK)
                    {
                        page.ErrorProviderProceduraFallimentare.ClearErrors();

                        dr = page.BaseForm.ShowDialog(this, this.ReadOnlyControls);

                        if (dr == DialogResult.OK)
                        {
                            if (!page.ErrorProviderProceduraFallimentare.HasErrors)
                                break;
                        }
                    }
                    return dr;
                }
                else
                    return DialogResult.None;
            }
            return DialogResult.None;
        }

        private void ModifyItem()
        {
            ProceduraFallimentareFDT item = GetCurrentItem();

            if (item != null)
            {
                Boolean goOn = true;

                if (item.Status >= ObjectStatus.ToHide)
                {
                    goOn = false;
                }

                if (goOn)
                {
                    item.BeginEdit();
                    if (OpenForEdit(item) == DialogResult.OK)
                    {
                        if (item.Status != ObjectStatus.ToInsert)
                            item.Status = ObjectStatus.ToUpdate;

                        item.EndEdit();
                    }
                    else
                    {
                        item.CancelEdit();
                    }
                    gridViewFailureProcedures.RefreshData();
                }
            }
        }

        private void DeleteItem()
        {
            ProceduraFallimentareFDT item = GetCurrentItem();
            if (item != null)
            {
                if (ShowConfirmMessage("GVC", "Confermi la cancellazione dell'elemento selezionato?", string.Empty) == DialogResult.Yes)
                {
                    if (item.IdProceduraFallimentare > 0)
                    {
                        item.BeginEdit();
                        item.Status = ObjectStatus.ToCancel;
                        item.EndEdit();
                    }
                    else
                    {
                        ProceduraFallimentareFDT[] listActual = this.bindingSourceFailureProcedurs.DataSource as ProceduraFallimentareFDT[];

                        if (listActual != null)
                        {
                            List<ProceduraFallimentareFDT> lTemp = new List<ProceduraFallimentareFDT>(listActual);
                            lTemp.Remove(item);

                            if (itemCoop != null && itemCoop.RegistroCooperativa != null)
                            {
                                itemCoop.RegistroCooperativa.ProcedureFallimentari = lTemp.ToArray();
                                this.bindingSourceFailureProcedurs.DataSource = itemCoop.RegistroCooperativa.ProcedureFallimentari;
                            }
                        }
                    }

                    gridViewFailureProcedures.RefreshData();
                    SetVisibilityBarButton(item);
                }
            }
        }

        private void SetVisibilityBarButton(ProceduraFallimentareFDT item)
        {
            if (!this.ReadOnlyControls)
            {
                this.barButtonItemRemove.Enabled = true;
                this.barButtonItemModify.Enabled = true;

                if (item != null)
                {
                    if (item.Status >= ObjectStatus.ToHide)
                    {
                        this.barButtonItemRemove.Enabled = false;
                        this.barButtonItemModify.Enabled = false;
                    }
                }
            }
        }
        #endregion Private Methods

        #region Public Methods (1)

        public void SetBindableData(CooperativaFDT item)
        {
            itemCoop = item;
            
            this.bindingSourceFailureProcedurs.DataSource = item.RegistroCooperativa.ProcedureFallimentari;

            tipiStati = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_ESITO_FALLIMENTI);
            this.bindingSourceFailureType.DataSource = tipiStati;

            this.documentazioneFileSystemDetail1.SetBindableData(item, new int[] { 11 });
        }

        #endregion Public Methods 

        #region Event Handlers

        private void barButtonItemAddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddItem();
        }

        private void barButtonItemModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ModifyItem();
        }

        private void barButtonItemRemove_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteItem();
        }

        private void gridControlFailureProcedures_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifyItem();
        }

        private void bindingSourceFailureProcedurs_CurrentChanged(object sender, EventArgs e)
        {
            HandleCurrentItemChange();
        }

        private void gridViewFailureProcedures_ShowGridMenu(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs e)
        {
            ProceduraFallimentareFDT item = GetCurrentItem();
            if (item != null)
            {
                GridView view = sender as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
                if (hitInfo.InRow)
                {
                    view.FocusedRowHandle = hitInfo.RowHandle;
                    popupMenuFallimenti.ShowPopup(BarManager,
                            gridControlFailureProcedures.PointToScreen(e.Point));
                }
            }
        }

        #endregion Event Handlers

    }
}
