using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using OeF.Configurations;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using it.dedagroup.GVC.Client.Forms.Common;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.Configurations;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Sanzioni.LiquidazioneCoatta
{
    public partial class LiquidazioneCoattaDetail : UserControlSplitContainer
    {
        
		#region Instance Variables (3) 

        private DizionarioFDT[] listTipiLiquidazioneCoatta;
        private CooperativaFDT itemCoop = null;
        private DatiFDT dati = null;

        public event EventHandler NuovoProcedimento;

		#endregion Instance Variables 

		#region Constructors (1) 

        public LiquidazioneCoattaDetail()
        {
            InitializeComponent();

            commissionerDetail1.SetLiquidazioneCoattaCaption();

            SetImages();

            authorizationDetail1.NuovoProcedimento += new EventHandler(liquidazioneCoattaEdit_NuovoProcedimento);
            procedurePaymentDetail1.NuovoProcedimento += new EventHandler(liquidazioneCoattaEdit_NuovoProcedimento);
        }

		#endregion Constructors 

        #region Event Handlers (4)

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddItem();
        }

        private void barButtonItemModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ModifyItem();
        }

        private void gridControlForcedLiquidation_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifyItem();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteItem();
        }

        private void bindingSourceForcedLiquidation_CurrentChanged(object sender, EventArgs e)
        {
            HandleCurrentItemChange();
        }

        private void liquidazioneCoattaEdit_NuovoProcedimento(object sender, EventArgs e)
        {
            EventHandler temp = NuovoProcedimento;
            if (temp != null)
                NuovoProcedimento(null, new EventArgs());
        }

        #endregion Event Handlers 

		#region Public Methods (1) 

        public void SetBindableData(CooperativaFDT item, DatiFDT d)
        {
            itemCoop = item;
            listTipiLiquidazioneCoatta = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_LIQUIDAZIONI_COATTE);

            if (itemCoop != null && itemCoop.RegistroCooperativa != null && itemCoop.RegistroCooperativa.LiquidazioniCoatte != null)
            {
                this.bindingSourceForcedLiquidation.DataSource = itemCoop.RegistroCooperativa.LiquidazioniCoatte;
                this.bindingSourceLiquidationsTypes.DataSource = listTipiLiquidazioneCoatta;

                this.documentazioneFileSystemDetail1.SetBindableData(itemCoop, new int[] { 9 });
            }

            dati = d;
        }

		#endregion Public Methods 

        #region Private Methods (6)
                
        private void HandleCurrentItemChange()
        {
            if (this.bindingSourceForcedLiquidation.Current != null)
            {
                LiquidazioneCoattaFDT f = this.bindingSourceForcedLiquidation.Current as LiquidazioneCoattaFDT;
                if (f != null)
                {
                    commissionerDetail1.SetBindableDataLiquidazione(f, dati);
                    procedurePaymentDetail1.SetBindableData(f);
                    sixMonthReportDetail1.SetBindableData(f);
                    authorizationDetail1.SetBindableData(f);
                    acquistoCreditFiscDetail1.SetBindableData(f);

                    this.documentationDetail1.SetBindableData(f);

                    SetVisibilityBarButton(f);
                }
            }
        }


        private void AddItem()
        {
            LiquidazioneCoattaFDT item = new LiquidazioneCoattaFDT();
            item.BeginEdit();
            item.IdRegistro = (item != null) ? itemCoop.RegistroCooperativa.IdRegistro : -1;
            item.IdLiquidazioneCoatta = -1;
            item.CompensiCommissari = new CompensoFDT[0];
            item.Autorizzazioni = new AutorizzazioneFDT[0];
            item.Liquidazioni = new CompensoLiquidazioneFDT[0];
            item.RelazioniSemestrali = new RelazioneSemestraleFDT[0];
            

            if (OpenForEdit(item) == DialogResult.OK)
            {
                item.Status = ObjectStatus.ToInsert;
                item.EndEdit();

                gridViewForcedLiquidation.BeginDataUpdate();
                itemCoop.RegistroCooperativa.AddLiquidazioneCoatta(item);
                this.bindingSourceForcedLiquidation.DataSource = itemCoop.RegistroCooperativa.LiquidazioniCoatte;
                gridViewForcedLiquidation.EndDataUpdate();
            }
            else
            {
                item.CancelEdit();
            }
        }

        private void ModifyItem()
        {
            LiquidazioneCoattaFDT item = GetCurrentItem();

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
                    gridViewForcedLiquidation.RefreshData();
                }
            }   
        }

        private void DeleteItem()
        {
            LiquidazioneCoattaFDT item = GetCurrentItem();
            if (item != null)
            {
                if (ShowConfirmMessage("GVC", "Confermi la cancellazione dell'elemento selezionato?", string.Empty) == DialogResult.Yes)
                {
                    if (item.IdLiquidazioneCoatta > 0)
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

                        if (item.DelibereAcquistoCreditiFisc != null &&
                            item.DelibereAcquistoCreditiFisc.Length > 0)
                        {
                            foreach (DeliberaAcquistoCreditiFiscFDT acquistoCreditoFiscale in item.DelibereAcquistoCreditiFisc)
                            {
                                acquistoCreditoFiscale.BeginEdit();
                                acquistoCreditoFiscale.Status = ObjectStatus.ToCancel;
                                acquistoCreditoFiscale.EndEdit();
                            }
                        }

                        if (item.Autorizzazioni != null &&
                            item.Autorizzazioni.Length > 0)
                        {
                            foreach (AutorizzazioneFDT autorizzazione in item.Autorizzazioni)
                            {
                                autorizzazione.BeginEdit();
                                autorizzazione.Status = ObjectStatus.ToCancel;
                                autorizzazione.EndEdit();
                            }
                        }

                        if (item.RelazioniSemestrali != null &&
                            item.RelazioniSemestrali.Length > 0)
                        {
                            foreach (RelazioneSemestraleFDT relazioneSemestrale in item.RelazioniSemestrali)
                            {
                                relazioneSemestrale.BeginEdit();
                                relazioneSemestrale.Status = ObjectStatus.ToCancel;
                                relazioneSemestrale.EndEdit();
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
                        acquistoCreditFiscDetail1.ResetBindings();
                        authorizationDetail1.ResetBindings();
                        procedurePaymentDetail1.ResetBindings();
                        sixMonthReportDetail1.ResetBindings();

                    }
                    else
                    {
                        LiquidazioneCoattaFDT[] listActual = this.bindingSourceForcedLiquidation.DataSource as LiquidazioneCoattaFDT[];

                        if (listActual != null)
                        {
                            List<LiquidazioneCoattaFDT> lTemp = new List<LiquidazioneCoattaFDT>(listActual);
                            lTemp.Remove(item);

                            if (itemCoop != null && itemCoop.RegistroCooperativa != null)
                            {
                                itemCoop.RegistroCooperativa.LiquidazioniCoatte = lTemp.ToArray();
                                this.bindingSourceForcedLiquidation.DataSource = itemCoop.RegistroCooperativa.LiquidazioniCoatte;
                            }
                        }
                    }

                    gridViewForcedLiquidation.RefreshData();
                    HandleCurrentItemChange();                   
                }
            }
        }

        private LiquidazioneCoattaFDT GetCurrentItem()
        {
            LiquidazioneCoattaFDT toReturn = null;

            if (this.bindingSourceForcedLiquidation.Current != null)
            {
                toReturn = this.bindingSourceForcedLiquidation.Current as LiquidazioneCoattaFDT;
            }

            return toReturn;
        }

        private DialogResult OpenForEdit(LiquidazioneCoattaFDT item)
        {
            if (item != null)
            {
                LiquidazioneCoattaEdit page = CreatePage<LiquidazioneCoattaEdit>();
                if (page != null)
                {
                    page.NuovoProcedimento += new EventHandler(liquidazioneCoattaEdit_NuovoProcedimento);

                    page.SetFormTitle("Gestione liquidazione coatta amministrativa");
                    page.SetBindableData(item, listTipiLiquidazioneCoatta);

                    DialogResult dr = DialogResult.OK;
                    while (dr == DialogResult.OK)
                    {
                        page.ErrorProviderForcedLiquidations.ClearErrors();

                        dr = page.BaseForm.ShowDialog(this, this.ReadOnlyControls);

                        if (dr == DialogResult.OK)
                        {
                            if (!page.ErrorProviderForcedLiquidations.HasErrors)
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

        private void SetVisibilityBarButton(LiquidazioneCoattaFDT item)
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

        private void gridViewForcedLiquidation_ShowGridMenu(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs e)
        {
            LiquidazioneCoattaFDT item = GetCurrentItem();
            if (item != null)
            {
                GridView view = sender as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
                if (hitInfo.InRow)
                {
                    view.FocusedRowHandle = hitInfo.RowHandle;
                    popupMenuLiquidazioneCoatta.ShowPopup(BarManager,
                            gridControlForcedLiquidation.PointToScreen(e.Point));
                }
            }
        }

        
    }
}
