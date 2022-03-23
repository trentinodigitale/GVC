using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Client.Forms.Common;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using it.dedagroup.GVC.Repository.Common.Configurations;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Sanzioni.ProceduraCoatta
{
    public partial class ProceduraCoattaDetail : UserControlSplitContainer
    {
        #region Instance Variables (1)
        
        private DizionarioFDT[] listTipiProceduraCoatta = null;
        private CooperativaFDT itemCoop = null;
        private DatiFDT dati = null;

        public event EventHandler NuovoProcedimento;

        #endregion Instance Variables

        #region Event Handlers (4)

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddItem();
        }    

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteItem();
        }

        private void barButtonItemModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ModifyItem();
        }

        private void gridControlForcedProcedure_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifyItem();
        }

        private void bindingSourceForcedProcedure_CurrentChanged(object sender, EventArgs e)
        {
            HandleCurrentItemChange();
        }

        private void proceduraCoattaEdit_NuovoProcedimento(object sender, EventArgs e)
        {
            EventHandler temp = NuovoProcedimento;
            if (temp != null)
                NuovoProcedimento(null, new EventArgs());
        }

		#endregion Event Handlers 

		#region Constructors (1) 

        public ProceduraCoattaDetail()
        {
            InitializeComponent();

            commissionerDetail1.SetProceduraCoattaCaption();
            
            SetImages();
            commissionerLiquidationDetail1.NuovoProcedimento += new EventHandler(proceduraCoattaEdit_NuovoProcedimento);

        }

		#endregion Constructors 

		#region Public Methods (1) 

        public void SetBindableData(CooperativaFDT item, DatiFDT d)
        {
            itemCoop = item;

            listTipiProceduraCoatta = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_PROCEDURE_COATTE);

            if (itemCoop != null && itemCoop.RegistroCooperativa != null && itemCoop.RegistroCooperativa.ProcedureCoatte != null)
            {
                this.bindingSourceForcedProcedure.DataSource = itemCoop.RegistroCooperativa.ProcedureCoatte;
                this.bindingSourceProceduresTypes.DataSource = listTipiProceduraCoatta;

                this.documentazioneFileSystemDetail1.SetBindableData(itemCoop, new int[] { 8 });
            }

            dati = d;
        }

		#endregion Public Methods 

		#region Private Methods (6) 

        private void HandleCurrentItemChange()
        {
            if (this.bindingSourceForcedProcedure.Current != null)
            {
                ProceduraCoattaFDT pc = this.bindingSourceForcedProcedure.Current as ProceduraCoattaFDT;
                if (pc != null)
                {
                    commissionerDetail1.SetBindableData(pc, dati);
                    commissionerLiquidationDetail1.SetBindableData(pc);

                    this.documentationDetail1.SetBindableData(pc); 
                
                    SetVisibilityBarButton(pc);
                }
            }
        }

        private void AddItem()
        {
            ProceduraCoattaFDT item = new ProceduraCoattaFDT();
            item.BeginEdit();

            item.IdRegistro = (item != null) ? itemCoop.RegistroCooperativa.IdRegistro : -1;
            item.IdProceduraCoatta = -1;
            item.CompensiCommissari = new CompensoFDT[0];
            item.Liquidazioni = new CompensoLiquidazioneFDT[0];

            if (OpenForEdit(item) == DialogResult.OK)
            {
                item.Status = ObjectStatus.ToInsert;
                item.EndEdit();

                gridViewForcedProcedure.BeginDataUpdate();
                itemCoop.RegistroCooperativa.AddProceduraCoatta(item);
                this.bindingSourceForcedProcedure.DataSource = itemCoop.RegistroCooperativa.ProcedureCoatte;
                gridViewForcedProcedure.EndDataUpdate();
            }
            else
            {
                item.CancelEdit();
            }
        }
        
        private void ModifyItem()
        {
            ProceduraCoattaFDT item = GetCurrentItem();

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
                    gridViewForcedProcedure.RefreshData();
                }
            }            
        }

        private void DeleteItem()
        {
            ProceduraCoattaFDT item = GetCurrentItem();
            if (item != null)
            {
                if (ShowConfirmMessage("GVC", "Confermi la cancellazione dell'elemento selezionato?", string.Empty) == DialogResult.Yes)
                {
                    if (item.IdProceduraCoatta > 0)
                    {
                        item.BeginEdit();
                        item.Status = ObjectStatus.ToCancel;
                        item.EndEdit();

                        if (item.CompensiCommissari != null &&
                            item.CompensiCommissari.Length > 0)
                        {
                            foreach (CompensoFDT compenso in item.CompensiCommissari)
                            {
                                compenso.BeginEdit();
                                compenso.Status = ObjectStatus.ToCancel;
                                compenso.EndEdit();
                            }
                        }

                        if (item.Liquidazioni != null &&
                            item.Liquidazioni.Length > 0)
                        {
                            foreach (CompensoLiquidazioneFDT liquidazione in item.Liquidazioni)
                            {
                                liquidazione.BeginEdit();
                                liquidazione.Status = ObjectStatus.ToCancel;
                                liquidazione.EndEdit();
                            }
                        }

                        commissionerDetail1.ResetBindings();
                        commissionerLiquidationDetail1.ResetBindings();
                    }
                    else
                    {
                        ProceduraCoattaFDT[] listActual = this.bindingSourceForcedProcedure.DataSource as ProceduraCoattaFDT[];

                        if (listActual != null)
                        {
                            List<ProceduraCoattaFDT> lTemp = new List<ProceduraCoattaFDT>(listActual);
                            lTemp.Remove(item);

                            if (itemCoop != null && itemCoop.RegistroCooperativa != null)
                            {
                                itemCoop.RegistroCooperativa.ProcedureCoatte = lTemp.ToArray();
                                this.bindingSourceForcedProcedure.DataSource = itemCoop.RegistroCooperativa.ProcedureCoatte;
                            }
                        }
                    }

                    gridViewForcedProcedure.RefreshData();
                    SetVisibilityBarButton(item);
                }
            }
        }

        private ProceduraCoattaFDT GetCurrentItem()
        {
            ProceduraCoattaFDT toReturn = null;

            if (this.bindingSourceForcedProcedure.Current != null)
            {
                toReturn = this.bindingSourceForcedProcedure.Current as ProceduraCoattaFDT;
            }

            return toReturn;
        }

        private DialogResult OpenForEdit(ProceduraCoattaFDT item)
        {
            if (item != null)
            {
                ProceduraCoattaEdit page = CreatePage<ProceduraCoattaEdit>();
                if (page != null)
                {
                    page.NuovoProcedimento += new EventHandler(proceduraCoattaEdit_NuovoProcedimento);

                    page.SetFormTitle("Procedura coatta");
                    page.SetBindableData(item, listTipiProceduraCoatta);

                    DialogResult dr = DialogResult.OK;
                    while (dr == DialogResult.OK)
                    {
                        page.ErrorProviderProceduraCoatta.ClearErrors();

                        dr = page.BaseForm.ShowDialog(this, this.ReadOnlyControls);

                        if (dr == DialogResult.OK)
                        {
                            if (!page.ErrorProviderProceduraCoatta.HasErrors)
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

        private void SetVisibilityBarButton(ProceduraCoattaFDT item)
        {
            if (!this.ReadOnlyControls)
            {
                this.barButtonItemDelete.Enabled = true;
                this.barButtonItemModify.Enabled = true;

                if (item != null)
                {
                    if (item.Status >= ObjectStatus.ToHide)
                    {
                        this.barButtonItemDelete.Enabled = false;
                        this.barButtonItemModify.Enabled = false;
                    }
                }
            }
        }
        
        private void SetImages()
        {
            this.barButtonItemAdd.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Document_Add_24x24);
            this.barButtonItemModify.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Edit_24x24);
            this.barButtonItemDelete.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
        }

		#endregion Private Methods       

        private void gridViewForcedProcedure_ShowGridMenu(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs e)
        {
            ProceduraCoattaFDT item = GetCurrentItem();
            if (item != null)
            {
                GridView view = sender as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
                if (hitInfo.InRow)
                {
                    view.FocusedRowHandle = hitInfo.RowHandle;
                    popupMenuProcedureCoatte.ShowPopup(BarManager,
                            gridControlForcedProcedure.PointToScreen(e.Point));
                }
            }
        }

    }
}
