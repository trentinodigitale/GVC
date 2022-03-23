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
using it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Revisione;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;


namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Revisione
{
    public partial class LiquidazioneRevisoreDetail : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        #region Instance Variables

        RevisioneFDT itemRev = null;
        DatiFDT dati = null;

        public event EventHandler NuovoProcedimento;

        #endregion Instance Variables

        #region Constructors

        public LiquidazioneRevisoreDetail()
        {
            InitializeComponent();

            SetImages();

            EnableControlAutoSize(new object[] { this }, gridControlCommissionerPayments, 200);

        }

        #endregion Constructors

        #region Event Handlers (3)

        private void barButtonItemAddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddLiquidazione();
        }

        private void barButtonItemRemove_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteLiquidazione();
        }

        private void gridControlCommissionerPayments_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifyLiquidazione();
        }

        private void barButtonItemModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ModifyLiquidazione();
        }

        private void liquidazioneRevisoreEdit_NuovoProcedimento(object sender, EventArgs e)
        {
            EventHandler temp = NuovoProcedimento;
            if (temp != null)
                NuovoProcedimento(null, new EventArgs());
        }

        #endregion Event Handlers

        #region Public Methods (1)

        public void ResetBindings()
        {
            this.bindingSourceLiquidazioneCompensi.ResetBindings(false);
        }

        public void SetBindableData(RevisioneFDT item, DatiFDT d)
        {
            itemRev = item;

            if (itemRev != null)
            {
                this.bindingSourceLiquidazioneCompensi.DataSource = itemRev.Liquidazioni;
            }
            else
            {
                this.bindingSourceLiquidazioneCompensi.DataSource = null;
            }

            dati = d;
        }

        #endregion Public Methods (1)

        #region Private Methods

        private void HandleCurrentItemChange()
        {
            if (this.bindingSourceLiquidazioneCompensi.Current != null)
            {
                CompensoLiquidazioneFDT liq = this.bindingSourceLiquidazioneCompensi.Current as CompensoLiquidazioneFDT;
                if (liq != null)
                {
                    SetVisibilityBarButton(liq);
                }
            }
        }

        private DialogResult OpenForEdit(CompensoLiquidazioneFDT item)
        {
            LiquidazioneRevisoreEdit page = CreatePage<LiquidazioneRevisoreEdit>();
            if (page != null)
            {
                page.NuovoProcedimento += new EventHandler(liquidazioneRevisoreEdit_NuovoProcedimento);

                page.SetFormTitle("Gestione dati della liquidazione");
                page.SetBindableData(itemRev, item, dati);
                return page.BaseForm.ShowDialog(this, this.ReadOnlyControls);
            }
            else
                return DialogResult.None;
        }

        private CompensoLiquidazioneFDT GetCurrentItem()
        {
            CompensoLiquidazioneFDT toReturn = null;

            if (this.bindingSourceLiquidazioneCompensi.Current != null)
            {
                toReturn = this.bindingSourceLiquidazioneCompensi.Current as CompensoLiquidazioneFDT;
            }
            return toReturn;
        }

        private void AddLiquidazione()
        {
            if (itemRev != null && itemRev.Status < 100)
            {
                CompensoLiquidazioneFDT item = new CompensoLiquidazioneFDT();
                item.IdRevisione = itemRev.IdRevisione;

                if (OpenForEdit(item) == DialogResult.OK)
                {
                    itemRev.Status = ObjectStatus.ToUpdate;
                    item.Status = ObjectStatus.ToInsert;

                    //if (item != null && item.IdRevisione > 0)
                    //{
                    gridViewCommissionerPayments.BeginDataUpdate();
                    itemRev.Addliquidazione(item);
                    this.bindingSourceLiquidazioneCompensi.DataSource = itemRev.Liquidazioni;
                    gridViewCommissionerPayments.EndDataUpdate();
                    //}
                    //else
                    //{
                    //    ShowProblemsMessage();
                    //}
                    SetVisibilityBarButton(GetCurrentItem());
                }
            }
            else
            {
                ShowInformationMessage("Nessuna revisione selezionata", "Per inserire una liquidazione è necessario selezionare la relativa revisione");
            }
        }
        

        private void ModifyLiquidazione()
        {
            CompensoLiquidazioneFDT item = GetCurrentItem();

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
                            this.bindingSourceLiquidazioneCompensi.EndEdit();
                            gridViewCommissionerPayments.RefreshData();
                        }
                        else
                        {
                            this.bindingSourceLiquidazioneCompensi.CancelEdit();
                            ShowProblemsMessage();
                        }
                    }
                    else
                    {
                        item.CancelEdit();
                        this.bindingSourceLiquidazioneCompensi.CancelEdit();
                    }
                }
            }
        }

        private void DeleteLiquidazione()
        {
            CompensoLiquidazioneFDT item = GetCurrentItem();

            if (item != null)
            {
                if (ShowConfirmMessage("Cancellazione", "Confermi la cancellazione dell'elemento selezionato?", string.Empty) == DialogResult.Yes)
                {
                    //item.Status = ObjectStatus.ToCancel;
                    //this.bindingSourceLiquidazioneCompensi.EndEdit();
                    //gridViewCommissionerPayments.RefreshData();
                    if (item.IdCompensoLiquidazione > 0)
                    {
                        item.Status = ObjectStatus.ToCancel;
                    }
                    else
                    {
                        CompensoLiquidazioneFDT[] listActual = this.bindingSourceLiquidazioneCompensi.DataSource as CompensoLiquidazioneFDT[];

                        if (listActual != null)
                        {
                            List<CompensoLiquidazioneFDT> lTemp = new List<CompensoLiquidazioneFDT>();
                            foreach (CompensoLiquidazioneFDT ind in listActual)
                            {
                                if (ind != item)
                                {
                                    lTemp.Add(ind);
                                }
                            }
                            if (itemRev != null)
                            {
                                itemRev.Liquidazioni = lTemp.ToArray();
                                this.bindingSourceLiquidazioneCompensi.DataSource = itemRev.Liquidazioni;
                            }
                        }
                    }

                    gridViewCommissionerPayments.RefreshData();
                    SetVisibilityBarButton(item);
                }
            }
        }

        private void SetVisibilityBarButton(CompensoLiquidazioneFDT item)
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

        private void SetImages()
        {
            this.barButtonItemAddNew.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Document_Add_24x24);
            this.barButtonItemModify.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Edit_24x24);
            this.barButtonItemRemove.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
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
                    popupMenuLiquidazione.ShowPopup(BarManager,
                            gridControlCommissionerPayments.PointToScreen(e.Point));
                }
            }
        }

        private void bindingSourceLiquidazioneCompensi_CurrentChanged(object sender, EventArgs e)
        {
            HandleCurrentItemChange();
        }
    }
}
