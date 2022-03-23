using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Sanzioni.LiquidazioneCoatta
{
    public partial class AcquistoCreditFiscDetail : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        #region Instance Variables (1)

        private LiquidazioneCoattaFDT itemLiquiCoatta;

        #endregion Instance Variables

        #region Constructor

        public AcquistoCreditFiscDetail()
        {
            InitializeComponent();

            EnableControlAutoSize(new object[] { this }, gridControlAcquistoCreditFisc, 200);

            SetImages();
        }

        private void SetImages()
        {
            this.barButtonItemAdd.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Document_Add_24x24);
            this.barButtonItemModify.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Edit_24x24);
            this.barButtonItemDelete.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
        }

        #endregion Constructor

        #region Public Methods

        public void SetBindableData(LiquidazioneCoattaFDT item)
        {
            itemLiquiCoatta = item;
            if (itemLiquiCoatta.DelibereAcquistoCreditiFisc == null)
            {
                itemLiquiCoatta.DelibereAcquistoCreditiFisc = new DeliberaAcquistoCreditiFiscFDT[0];
            }
                        
            this.bindingSourceTaxCreditBuy.DataSource = itemLiquiCoatta.DelibereAcquistoCreditiFisc;
            
        }

        public void ResetBindings()
        {
            this.bindingSourceTaxCreditBuy.ResetBindings(false);
        }

        #endregion Public Methods 

        #region Private Methods (6)
                
        private void HandleCurrentItemChange()
        {
            if (this.bindingSourceTaxCreditBuy.Current != null)
            {
                DeliberaAcquistoCreditiFiscFDT d = this.bindingSourceTaxCreditBuy.Current as DeliberaAcquistoCreditiFiscFDT;
                if (d != null)
                {
                    SetVisibilityBarButton(d);
                }
            }
        }

        private void SetStatusPadre()
        {
            if (itemLiquiCoatta != null)
            {
                if (!(itemLiquiCoatta.Status == ObjectStatus.ToInsert))
                {
                    itemLiquiCoatta.BeginEdit();
                    itemLiquiCoatta.Status = ObjectStatus.ToUpdate;
                    itemLiquiCoatta.EndEdit();
                }
            }
        }

        private void AddItem()
        {
            if ((itemLiquiCoatta != null)  && (itemLiquiCoatta.Status < ObjectStatus.ToHide))
            {
                DeliberaAcquistoCreditiFiscFDT item = new DeliberaAcquistoCreditiFiscFDT();
                item.BeginEdit();
                item.IdLiquidazione = (item != null) ? itemLiquiCoatta.IdLiquidazioneCoatta : -1;
                item.IdDeliberaAcquistoCreditiFisc = -1;

                if (OpenForEdit(item) == DialogResult.OK)
                {
                    item.Status = ObjectStatus.ToInsert;
                    item.EndEdit();

                    SetStatusPadre();

                    gridViewAcquistoCreditFisc.BeginDataUpdate();
                    itemLiquiCoatta.AddDelibereAcquistoCreditiFisc(item);
                    this.bindingSourceTaxCreditBuy.DataSource = itemLiquiCoatta.DelibereAcquistoCreditiFisc;
                    gridViewAcquistoCreditFisc.EndDataUpdate();
                }
                else
                {
                    item.CancelEdit();
                }
            }
            else
            {
                ShowInformationMessage("Nessuna liquidazione coatta selezionata", "Per inserire un acquisto credito fiscale è necessario selezionare la relativa liquidazione coatta");
            }
        }

        private void ModifyItem()
        {
            DeliberaAcquistoCreditiFiscFDT item = GetCurrentItem();

            if (item != null)
            {

                 Boolean goOn = true;

                if (item.Status >= ObjectStatus.ToHide)
                {
                    goOn = false;
                }

                if ((itemLiquiCoatta != null) && (itemLiquiCoatta.Status >= ObjectStatus.ToHide))
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
                    gridViewAcquistoCreditFisc.RefreshData();
                }

            }
        }

        private void DeleteItem()
        {
            DeliberaAcquistoCreditiFiscFDT item = GetCurrentItem();
            if (item != null)
            {
                if (ShowConfirmMessage("GVC", "Confermi la cancellazione dell'elemento selezionato?", string.Empty) == DialogResult.Yes)
                {
                    if (item.Status == ObjectStatus.ToInsert)
                    {
                        itemLiquiCoatta.RemoveDelibereAcquistoCreditiFisc(item);
                        this.bindingSourceTaxCreditBuy.DataSource = itemLiquiCoatta.DelibereAcquistoCreditiFisc;
                    }
                    else
                    {
                        item.BeginEdit();
                        item.Status = ObjectStatus.ToCancel;
                        item.EndEdit();
                    }
                    SetStatusPadre();

                    SetVisibilityBarButton(item);
                    gridViewAcquistoCreditFisc.RefreshData();
                }
            }
        }

        private DeliberaAcquistoCreditiFiscFDT GetCurrentItem()
        {
            DeliberaAcquistoCreditiFiscFDT toReturn = null;

            if (this.bindingSourceTaxCreditBuy.Current != null)
            {
                toReturn = this.bindingSourceTaxCreditBuy.Current as DeliberaAcquistoCreditiFiscFDT;
            }

            return toReturn;
        }

        private DialogResult OpenForEdit(DeliberaAcquistoCreditiFiscFDT item)
        {
            if (item != null)
            {
                AcquistoCreditiFiscEdit page = CreatePage<AcquistoCreditiFiscEdit>();
                if (page != null)
                {
                    page.SetFormTitle("Gestione Acquisto Crediti Fiscali");
                    page.SetBindableData(itemLiquiCoatta, item);
                    return page.BaseForm.ShowDialog(this, this.ReadOnlyControls);
                }
                else
                    return DialogResult.None;
            }
            return DialogResult.None;
        }

        private void SetVisibilityBarButton(DeliberaAcquistoCreditiFiscFDT item)
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

        #region Event Handler (4)

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddItem();
        }

        private void barButtonItemModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ModifyItem();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteItem();
        }

        private void gridControlAcquistoCreditFisc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifyItem();
        }

        #endregion Event Handler

        private void gridViewAcquistoCreditFisc_ShowGridMenu(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs e)
        {
            DeliberaAcquistoCreditiFiscFDT item = GetCurrentItem();
            if (item != null)
            {
                GridView view = sender as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
                if (hitInfo.InRow)
                {
                    view.FocusedRowHandle = hitInfo.RowHandle;
                    popupMenuAcquistoCreditFisc.ShowPopup(BarManager,
                            gridControlAcquistoCreditFisc.PointToScreen(e.Point));
                }
            }
        }

        private void bindingSourceTaxCreditBuy_CurrentChanged(object sender, EventArgs e)
        {
            HandleCurrentItemChange();
        }
    }
}
