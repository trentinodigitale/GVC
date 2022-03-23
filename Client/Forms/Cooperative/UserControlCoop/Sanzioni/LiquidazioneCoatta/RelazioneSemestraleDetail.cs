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
    public partial class RelazioneSemestraleDetail : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {

        #region Instance Variables (1)

        private LiquidazioneCoattaFDT itemLiquiCoatta = null;

        #endregion Instance Variables

		#region Constructors (1) 

        public RelazioneSemestraleDetail()
        {
            InitializeComponent();

            EnableControlAutoSize(new object[] { this }, gridControlSixMonthReports, 200);

            SetImages();
        }

		#endregion Constructors 

		#region Public Methods (1) 

        public void SetBindableData(LiquidazioneCoattaFDT item)
        {
            itemLiquiCoatta = item;

            if (itemLiquiCoatta.RelazioniSemestrali != null)
            {
                this.bindingSourceSixMonthReports.DataSource = itemLiquiCoatta.RelazioniSemestrali;
            }    
        }

        public void ResetBindings()
        {
            this.bindingSourceSixMonthReports.ResetBindings(false);
        }

		#endregion Public Methods 

		#region Private Methods (6)
                
        private void HandleCurrentItemChange()
        {
            if (this.bindingSourceSixMonthReports.Current != null)
            {
                RelazioneSemestraleFDT r = this.bindingSourceSixMonthReports.Current as RelazioneSemestraleFDT;
                if (r != null)
                {
                    SetVisibilityBarButton(r);
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
                RelazioneSemestraleFDT item = new RelazioneSemestraleFDT();
                item.BeginEdit();

                item.IdLiquidazione = (item != null) ? itemLiquiCoatta.IdLiquidazioneCoatta : -1;
                item.IdRelazioneSemestrale = -1;

                if (OpenForEdit(item) == DialogResult.OK)
                {
                    item.Status = ObjectStatus.ToInsert;
                    item.EndEdit();

                    SetStatusPadre();

                    gridViewSixMonthReports.BeginDataUpdate();
                    itemLiquiCoatta.AddRelazioneSemestrale(item);
                    this.bindingSourceSixMonthReports.DataSource = itemLiquiCoatta.RelazioniSemestrali;
                    gridViewSixMonthReports.EndDataUpdate();
                }
                else
                {
                    item.CancelEdit();
                }
            }
            else
            {
                ShowInformationMessage("Nessuna liquidazione coatta selezionata", "Per inserire una relazione semestrale è necessario selezionare la relativa liquidazione coatta");
            }
        }

        private void ModifyItem()
        {
            RelazioneSemestraleFDT item = GetCurrentItem();

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

                    gridViewSixMonthReports.RefreshData();
                }
            }
        }

        private void DeleteItem()
        {
            RelazioneSemestraleFDT item = GetCurrentItem();
            if (item != null)
            {
                if (ShowConfirmMessage("GVC", "Confermi la cancellazione dell'elemento selezionato?", string.Empty) == DialogResult.Yes)
                {
                    if (item.Status == ObjectStatus.ToInsert)
                    {
                        itemLiquiCoatta.RemoveRelazioneSemestrale(item);
                        this.bindingSourceSixMonthReports.DataSource = itemLiquiCoatta.RelazioniSemestrali;
                    }
                    else
                    {
                        item.BeginEdit();
                        item.Status = ObjectStatus.ToCancel;
                        item.EndEdit();
                    }
                    SetStatusPadre();

                    SetVisibilityBarButton(item);
                    gridViewSixMonthReports.RefreshData();
                }
            }
        }

        private RelazioneSemestraleFDT GetCurrentItem()
        {
            RelazioneSemestraleFDT toReturn = null;

            if (this.bindingSourceSixMonthReports.Current != null)
            {
                toReturn = this.bindingSourceSixMonthReports.Current as RelazioneSemestraleFDT;
            }

            return toReturn;
        }

        private DialogResult OpenForEdit(RelazioneSemestraleFDT item)
        {
            if (item != null)
            {
                RelazioneSemestraleEdit page = CreatePage<RelazioneSemestraleEdit>();
                if (page != null)
                {
                    page.SetFormTitle("Relazione semestrale");
                    page.SetBindableData(itemLiquiCoatta, item);
                    
                    DialogResult dr = DialogResult.OK;
                    while (dr == DialogResult.OK)
                    {
                        page.ErrorProviderRelazioneSemestrale.ClearErrors();

                        dr = page.BaseForm.ShowDialog(this, this.ReadOnlyControls);

                        if (dr == DialogResult.OK)
                        {
                            if (!page.ErrorProviderRelazioneSemestrale.HasErrors)
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

        private void SetImages()
        {
            this.barButtonItemAdd.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Document_Add_24x24);
            this.barButtonItemModify.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Edit_24x24);
            this.barButtonItemDelete.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
        }

        private void SetVisibilityBarButton(RelazioneSemestraleFDT item)
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

        private void gridControlSixMonthReports_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifyItem();
        }

        #endregion Event Handler

        private void gridViewSixMonthReports_ShowGridMenu(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs e)
        {
            RelazioneSemestraleFDT item = GetCurrentItem();
            if (item != null)
            {
                GridView view = sender as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
                if (hitInfo.InRow)
                {
                    view.FocusedRowHandle = hitInfo.RowHandle;
                    popupMenuRelazioneSemestrale.ShowPopup(BarManager,
                            gridControlSixMonthReports.PointToScreen(e.Point));
                }
            }
        }

        private void bindingSourceSixMonthReports_CurrentChanged(object sender, EventArgs e)
        {
            HandleCurrentItemChange();
        }

    }
}
