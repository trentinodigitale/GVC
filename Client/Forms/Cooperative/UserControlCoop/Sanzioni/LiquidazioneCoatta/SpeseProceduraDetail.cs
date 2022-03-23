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

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Sanzioni.LiquidazioneCoatta
{
    public partial class SpeseProceduraDetail : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {

        #region Instance Variables (1)

        private LiquidazioneCoattaFDT itemLiquiCoatta = null;

        public event EventHandler NuovoProcedimento;
        
        #endregion Instance Variables

        #region Constructors (1)

        public SpeseProceduraDetail()
        {
            InitializeComponent();

            EnableControlAutoSize(new object[] { this }, gridControlCommissionerPayments, 200);

            SetImages();
        }

        #endregion Constructors

        #region Public Methods (1)
        
        public void SetBindableData(LiquidazioneCoattaFDT item)
        {

            itemLiquiCoatta = item;
            if (item.Liquidazioni != null)
            {
                this.bindingSourceProcedurePayments.DataSource = item.Liquidazioni;
            }

        }

        public void ResetBindings()
        {
            this.bindingSourceProcedurePayments.ResetBindings(false);
        }

        #endregion Public Methods 

        #region Private Methods (6)
              
        private void HandleCurrentItemChange()
        {
            if (this.bindingSourceProcedurePayments.Current != null)
            {
                CompensoLiquidazioneFDT cl = this.bindingSourceProcedurePayments.Current as CompensoLiquidazioneFDT;
                if (cl != null)
                {
                    SetVisibilityBarButton(cl);
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
            if ((itemLiquiCoatta != null) && (itemLiquiCoatta.Status < ObjectStatus.ToHide))
            {
                CompensoLiquidazioneFDT item = new CompensoLiquidazioneFDT();
                item.BeginEdit();
                item.IdLiquidazione = (item != null) ? itemLiquiCoatta.IdLiquidazioneCoatta : -1;
                item.IdCompensoLiquidazione = -1;

                if (OpenForEdit(item) == DialogResult.OK)
                {
                    item.Status = ObjectStatus.ToInsert;
                    item.EndEdit();

                    SetStatusPadre();

                    gridViewCommissionerPayments.BeginDataUpdate();
                    itemLiquiCoatta.AddLiquidazione(item);
                    this.bindingSourceProcedurePayments.DataSource = itemLiquiCoatta.Liquidazioni;
                    gridViewCommissionerPayments.EndDataUpdate();
                }
                else
                {
                    item.CancelEdit();
                }
            }
            else
            {
                ShowInformationMessage("Nessuna liquidazione coatta selezionata", "Per inserire una spesa procedura è necessario selezionare la relativa liquidazione coatta");
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
                        itemLiquiCoatta.RemoveLiquidazione(item);
                        this.bindingSourceProcedurePayments.DataSource = itemLiquiCoatta.Liquidazioni;
                    }
                    else
                    {
                        item.BeginEdit();
                        item.Status = ObjectStatus.ToCancel;
                        item.EndEdit();
                    }
                    SetStatusPadre();
                
                    gridViewCommissionerPayments.RefreshData();
                    SetVisibilityBarButton(item);
                }
            }
        }

        private CompensoLiquidazioneFDT GetCurrentItem()
        {
            CompensoLiquidazioneFDT toReturn = null;

            if (this.bindingSourceProcedurePayments.Current != null)
            {
                toReturn = this.bindingSourceProcedurePayments.Current as CompensoLiquidazioneFDT;
            }

            return toReturn;
        }

        private DialogResult OpenForEdit(CompensoLiquidazioneFDT item)
        {
            if (item != null)
            {
                SpeseProceduraEdit page = CreatePage<SpeseProceduraEdit>();
                if (page != null)
                {
                    page.NuovoProcedimento += new EventHandler(speseProceduraEdit_NuovoProcedimento);

                    page.SetFormTitle("Gestione liquidazione spese di procedura");
                    page.SetBindableData(itemLiquiCoatta, item);
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

        #region Event Handler (3)

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

        private void speseProceduraEdit_NuovoProcedimento(object sender, EventArgs e)
        {
            EventHandler temp = NuovoProcedimento;
            if (temp != null)
                NuovoProcedimento(null, new EventArgs());
        }

        #endregion Event Handler

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
                    popupMenuSpeseProcedura.ShowPopup(BarManager,
                            gridControlCommissionerPayments.PointToScreen(e.Point));
                }
            }
        }

        private void bindingSourceProcedurePayments_CurrentChanged(object sender, EventArgs e)
        {
            HandleCurrentItemChange();
        }

        
    }
}
