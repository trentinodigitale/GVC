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

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Sanzioni.Commissari
{
    public partial class LiquidazCompensoCommissarioDetail : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {

        #region Instance Variables (1)

        private ProceduraCoattaFDT itemProcCoatta = null;
        private DizionarioFDT[] listTipiCompensi = null;

        public event EventHandler NuovoProcedimento;

        #endregion Instance Variables
        
        #region Constructors (1)

        public LiquidazCompensoCommissarioDetail()
        {
            InitializeComponent();

            EnableControlAutoSize(new object[] { this }, gridControlCommissionerPayments, 200);

            SetImages();
        }

        #endregion Constructors

        #region Public Methods (1)

        public void SetBindableData(ProceduraCoattaFDT item)
        {
            itemProcCoatta = item;

            if (itemProcCoatta.Liquidazioni != null)
            {
                this.bindingSourceCommissionerPayment.DataSource = itemProcCoatta.Liquidazioni;
            }

            listTipiCompensi = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_CONTRIBUTO);            
        }

        public void ResetBindings()
        {
            this.bindingSourceCommissionerPayment.ResetBindings(false);
        }
        
        #endregion Public Methods 

        #region Event Handlers (2)

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddItem();
        }

        private void barButtonItemModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ModifyItem();
        }

        private void gridControlCommissionerPayments_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifyItem();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteItem();
        }

        private void liquidazioneCompensoEdit_NuovoProcedimento(object sender, EventArgs e)
        {
            EventHandler temp = NuovoProcedimento;
            if (temp != null)
                NuovoProcedimento(null, new EventArgs());
        }

        #endregion Event Handlers

        #region Private Methods (6)
                
        private void HandleCurrentItemChange()
        {
            if (this.bindingSourceCommissionerPayment.Current != null)
            {
                CompensoLiquidazioneFDT d = this.bindingSourceCommissionerPayment.Current as CompensoLiquidazioneFDT;
                if (d != null)
                {
                    SetVisibilityBarButton(d);
                }
            }
        }

        private void SetStatusPadre()
        {
            if (itemProcCoatta != null)
            {
                if (!(itemProcCoatta.Status == ObjectStatus.ToInsert))
                {
                    itemProcCoatta.BeginEdit();
                    itemProcCoatta.Status = ObjectStatus.ToUpdate;
                    itemProcCoatta.EndEdit();
                }
            }            
        }

        private void AddItem()
        {
            if ((itemProcCoatta != null) && (itemProcCoatta.Status < ObjectStatus.ToHide))
            {
                CompensoLiquidazioneFDT item = new CompensoLiquidazioneFDT();
                item.BeginEdit();

                item.IdProcedura = (item != null) ? itemProcCoatta.IdProceduraCoatta : -1;
                item.IdLiquidazione = -1;

                if (OpenForEdit(item) == DialogResult.OK)
                {
                    item.Status = ObjectStatus.ToInsert;
                    item.EndEdit();

                    SetStatusPadre();

                    gridViewCommissionerPayments.BeginDataUpdate();
                    itemProcCoatta.AddLiquidazione(item);
                    this.bindingSourceCommissionerPayment.DataSource = itemProcCoatta.Liquidazioni;
                    gridViewCommissionerPayments.EndDataUpdate();
                }
                else
                {
                    item.CancelEdit();
                }
            }
            else
            {
                ShowInformationMessage("Nessuna procedura coatta selezionata", "Per inserire un liquidazione compenso commissario è necessario selezionare la relativa procedura coatta");            
            }
        }

        private void ModifyItem()
        {
            CompensoLiquidazioneFDT item = GetCurrentItem();

            if (item != null)
            {
                Boolean goOn = true;

                if (item.Status >= ObjectStatus.ToHide)
                {
                    goOn = false;
                }

                if ((itemProcCoatta != null) && (itemProcCoatta.Status >= ObjectStatus.ToHide))
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

                        SetStatusPadre();
                    }
                    else
                    {
                        item.CancelEdit();
                    }

                    gridViewCommissionerPayments.RefreshData();
                }
            }              
        }

        private void DeleteItem()
        {
            CompensoLiquidazioneFDT item = GetCurrentItem();
            if (item != null)
            {
                if (ShowConfirmMessage("GVC", "Confermi la cancellazione dell'elemento selezionato?", string.Empty) == DialogResult.Yes)
                {
                    if (item.Status == ObjectStatus.ToInsert)
                    {
                        itemProcCoatta.RemoveLiquidazione(item);
                        this.bindingSourceCommissionerPayment.DataSource = itemProcCoatta.Liquidazioni;                        
                    }
                    else
                    {
                        item.BeginEdit();
                        item.Status = ObjectStatus.ToCancel;
                        item.EndEdit();
                    }
                    SetStatusPadre();

                    SetVisibilityBarButton(item);
                    gridViewCommissionerPayments.RefreshData();
                }
            }
        }

        private CompensoLiquidazioneFDT GetCurrentItem()
        {
            CompensoLiquidazioneFDT toReturn = null;

            if (this.bindingSourceCommissionerPayment.Current != null)
            {
                toReturn = this.bindingSourceCommissionerPayment.Current as CompensoLiquidazioneFDT;
            }

            return toReturn;
        }

        private DialogResult OpenForEdit(CompensoLiquidazioneFDT item)
        {
            if (item != null)
            {
                LiquidazCompensoCommissarioEdit page = CreatePage<LiquidazCompensoCommissarioEdit>();
                if (page != null)
                {
                    page.NuovoProcedimento += new EventHandler(liquidazioneCompensoEdit_NuovoProcedimento);

                    page.SetFormTitle("Liquidazione compensi commissari");
                    page.SetBindableData(itemProcCoatta, item, listTipiCompensi);
                    return page.BaseForm.ShowDialog(this, this.ReadOnlyControls);
                }
                else
                    return DialogResult.None;
            }
            return DialogResult.None;
        }

        private void SetImages()
        {
            this.barButtonItemAdd.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Document_Add_24x24);
            this.barButtonItemModify.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Edit_24x24);
            this.barButtonItemDelete.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
        }

        private void SetVisibilityBarButton(CompensoLiquidazioneFDT item)
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

        #endregion Private Methods                         

        private void gridViewCommissionerPayments_ShowGridMenu(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs e)
        {
            CompensoLiquidazioneFDT item = GetCurrentItem();
            if (item != null)
            {
                GridView view = sender as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
                if (hitInfo.InRow)
                {
                    view.FocusedRowHandle = hitInfo.RowHandle;
                    popupMenuLiquidazCompensoCommissario.ShowPopup(BarManager,
                            gridControlCommissionerPayments.PointToScreen(e.Point));
                }
            }
        }

        private void bindingSourceCommissionerPayment_CurrentChanged(object sender, EventArgs e)
        {
            HandleCurrentItemChange();
        }

       
    }
}
