using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using OeF.Configurations;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.Services;
using it.dedagroup.GVC.Repository.Common.Configurations;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Budget
{
    public partial class BilancioDetail : it.dedagroup.GVC.Client.Forms.Common.UserControlSplitContainer
    {
        private CooperativaFDT itemLocal = null;

        public BilancioDetail()
        {
            InitializeComponent();

            if (!DesignMode)
            {
                EnableControlAutoSize(new object[] { this }, xtraTabControl1, 200);

                SetImages();
            }
        }

        private void SetImages()
        {
            barButtonItemAdd.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Document_Add_24x24);
            barButtonItemModify.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Edit_24x24);
            barButtonItemDelete.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
        }

        public void SetBindableData(CooperativaFDT item)
        {
            this.bindingSourceBaseBudgetTypes.DataSource =
                GVCSystemEngine.GetDizionarioByType(it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.TIPI_BILANCIO);

            this.bindingSourceTipoVerificaBilancio.DataSource =
             GVCSystemEngine.GetDizionarioByType(it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.TIPI_VERIFICA_BILANCIO);


            itemLocal = item;

            this.bindingSourceBaseRequisitiPrevalenza.DataSource =
                GVCSystemEngine.GetDizionarioByType(it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.REQUISITI_PREVALENZA);

            if (item != null && item.RegistroCooperativa != null)
            {
                this.bindingSourceBaseBudgets.DataSource = item.RegistroCooperativa.Bilanci;

                this.documentazioneFileSystemDetail1.SetBindableData(item, new int[] { 7 });
            }
        }

        #region Events

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddBilancio();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteBilancio();
        }

        private void barButtonItemModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ModifyBilancio();
        }

        private void bindingSourceBaseBudgets_CurrentItemChanged(object sender, EventArgs e)
        {
            HandleCurrentItemChanged();
        }

        private void gridControlBudgets_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifyBilancio();
        }

        private void gridViewBudgets_ShowGridMenu(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs e)
        {
            BilancioFDT item = GetCurrentItem();
            if (item != null)
            {
                GridView view = sender as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
                if (hitInfo.InRow)
                {
                    view.FocusedRowHandle = hitInfo.RowHandle;
                    popupMenuBilanci.ShowPopup(BarManager,
                            gridControlBudgets.PointToScreen(e.Point));
                }
            }
        }

        #endregion Events

        #region Private methods

        private void HandleCurrentItemChanged()
        {
            BilancioFDT item = GetCurrentItem();
            if (item != null)
            {
                this.documentationDetail1.SetBindableData(item);

                SetVisibilityBarButton(item);
            }
        }

        private void SetVisibilityBarButton()
        {
            BilancioFDT item = GetCurrentItem();
            SetVisibilityBarButton(item);
        }

        private void SetVisibilityBarButton(BilancioFDT item)
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

        private void AddBilancio()
        {
            BilancioFDT item = new BilancioFDT();
            item.IdRegistro = -1;
            if (itemLocal != null && itemLocal.RegistroCooperativa != null)
            {
                item.IdRegistro = itemLocal.RegistroCooperativa.IdRegistro;
            }

            item.Anno = GetYear();
            if (itemLocal != null &&
                itemLocal.RegistroCooperativa != null)
            {
                item.DataEsercizio = itemLocal.RegistroCooperativa.BilancioEsercizioAl;
            }

            if (OpenForEdit(item, true) == DialogResult.OK)
            {
                BilancioFDT newItem = SaveBilancio(item, false, false);
                if (newItem != null)
                {
                    gridViewBudgets.BeginDataUpdate();
                    if (itemLocal != null && itemLocal.RegistroCooperativa != null)
                    {
                        itemLocal.RegistroCooperativa.AddBilancio(newItem);
                        this.bindingSourceBaseBudgets.DataSource = itemLocal.RegistroCooperativa.Bilanci;
                    }
                    gridViewBudgets.EndDataUpdate();
                }
                else
                {
                    ShowProblemsMessage();
                }
            }
        }

        private void DeleteBilancio()
        {
            BilancioFDT item = GetCurrentItem();
            if (item != null)
            {
                if (ShowConfirmMessage("Cancellazione", "Confermi la cancellazione dell'elemento selezionato?", string.Empty) == DialogResult.Yes)
                {
                    if (item.IdBilancio > 0)
                    {
                        item.Status = ObjectStatus.ToCancel;
                    }
                    else
                    {
                        BilancioFDT[] listActual = this.bindingSourceBaseBudgets.DataSource as BilancioFDT[];

                        if (listActual != null)
                        {
                            List<BilancioFDT> lTemp = new List<BilancioFDT>();
                            foreach (BilancioFDT ind in listActual)
                            {
                                if (ind != item)
                                {
                                    lTemp.Add(ind);
                                }
                            }

                            if (itemLocal != null && itemLocal.RegistroCooperativa != null)
                            {
                                itemLocal.RegistroCooperativa.Bilanci = lTemp.ToArray();
                            }
                        }
                    }

                    if (itemLocal != null && itemLocal.RegistroCooperativa != null)
                    {
                        this.bindingSourceBaseBudgets.DataSource = itemLocal.RegistroCooperativa.Bilanci;
                    }
                    gridViewBudgets.RefreshData();
                    SetVisibilityBarButton(item);
                }
            }
        }

        private BilancioFDT GetCurrentItem()
        {
            BilancioFDT toReturn = null;

            if (this.bindingSourceBaseBudgets.Current != null)
            {
                toReturn = this.bindingSourceBaseBudgets.Current as BilancioFDT;
            }
            return toReturn;
        }

        private void ModifyBilancio()
        {
            BilancioFDT item = GetCurrentItem();
            if (item != null)
            {
                Boolean goOn = true;
                if (item.Status >= it.dedagroup.GVC.Repository.Common.Configurations.ObjectStatus.ToHide)
                {
                    goOn = false;
                }

                if (goOn)
                {
                    item.EndEdit();
                    item.BeginEdit();
                    if (OpenForEdit(item, false) == DialogResult.OK)
                    {
                        item.EndEdit();
                        BilancioFDT updatedItem = SaveBilancio(item, false, true);
                        if (updatedItem != null)
                        {
                            this.bindingSourceBaseBudgets.EndEdit();
                            gridViewBudgets.RefreshData();
                        }
                        else
                        {
                            item.CancelEdit();
                            ShowProblemsMessage();
                        }
                    }
                    else
                    {
                        item.CancelEdit();
                        gridViewBudgets.RefreshData();
                    }
                }
            }
        }

        private DialogResult OpenForEdit(BilancioFDT bilancio, Boolean isNew)
        {
            BilancioEdit page = CreatePage<BilancioEdit>();
            if (page != null)
            {
                page.SetFormTitle("Gestione bilancio");
                page.SetBindableData(bilancio);
                DialogResult dr = DialogResult.OK;
                while (dr == DialogResult.OK)
                {
                    page.ErrorProviderBilancio.ClearErrors();

                    dr = page.BaseForm.ShowDialog(this, this.ReadOnlyControls);

                    if (dr == DialogResult.OK)
                    {
                        if (!page.ErrorProviderBilancio.HasErrors)
                            break;
                    }
                }
                return dr;
            }
            else
                return DialogResult.None;
        }

        private BilancioFDT SaveBilancio(BilancioFDT item, Boolean onDB, Boolean isAnUpdate)
        {
            BilancioFDT toReturn = null;
            if (item != null)
            {
                if (onDB)
                {
                    //toReturn = GVCSystemEngine.InvokeService<ICooperatives, BilancioFDT>
                    //    (delegate() { return GVCSystemEngine.Cooperatives.SaveBilancio(item); },
                    //    true);
                }
                else
                {
                    if (isAnUpdate)
                        item.Status = ObjectStatus.ToUpdate;
                    else
                        item.Status = ObjectStatus.ToInsert;

                    toReturn = item;
                }

            }
            return toReturn;
        }

        private int GetYear()
        {
            int toReturn = System.DateTime.Now.Year;

            int year = -1;

            if (itemLocal != null &&
                itemLocal.RegistroCooperativa != null &&
                itemLocal.RegistroCooperativa.Bilanci != null)
            {
               
                foreach (BilancioFDT item in itemLocal.RegistroCooperativa.Bilanci)
                {
                    if (item.Anno > year)
                    {
                        year = item.Anno;
                    }
                }
            }

            if (year > 0)
                toReturn = year + 1;

            return toReturn;
        }


        #endregion Private methods

    }
}