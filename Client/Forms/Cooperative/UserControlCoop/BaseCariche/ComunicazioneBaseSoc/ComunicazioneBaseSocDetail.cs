using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Client.Forms.Common;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.Services;
using OeF.Validation;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.PositionAndBase.ComunicazioneBaseSoc
{
    public partial class ComunicazioneBaseSocDetail : UserControlSplitContainer
    {
        #region Instance Variables (5)

        private CooperativaFDT itemCoop = null;
        private ComunicazioneBaseSocialeFDT itemComunicazione = null;
        private ComunicazioneBaseSocEdit comBaseSocEdit1;
        private DatiFDT dati = null;
        DizionarioFDT[] listaTipiConferimento = null;

        #endregion Instance Variables 

		#region Event Handlers (3) 

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddComunicazione();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteComunicazione();
        }

        private void bindingSourceBaseCommunicationBase_CurrentChanged(object sender, EventArgs e)
        {
            HandleCurrentItemChange();
        }

        private void gridControlCommunicationBase_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifyComunicazione();
        }

        private void baseSocEdit_VerificaSoci(object sender, EventArgs e)
        {
            VerificaSoci();
        }

        private void baseSocEdit_ModificaTipoConferimento(object sender, EventArgs e)
        {
            ModificaTipoConferimento();
        }
        
        private void barButtonItemModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ModifyComunicazione();
        }

		#endregion Event Handlers 

		#region Constructors (1) 

        public ComunicazioneBaseSocDetail()
        {
            InitializeComponent();

            SetImages();
        }

		#endregion Constructors 

		#region Public Methods (1) 

        public void SetBindableData(CooperativaFDT item, DatiFDT d)
        {
            //this.TipiDocumentazione = tipiDocumentazione;
            if (item != null)
            {
                itemCoop = item;

                if (item.RegistroCooperativa != null && item.RegistroCooperativa.ComunicazioniBaseSociale != null)
                {
                    this.bindingSourceBaseComunicazioneBase.DataSource = item.RegistroCooperativa.ComunicazioniBaseSociale;

                    this.documentazioneFileSystemDetail1.SetBindableData(item, new int[] { 4 });
                }
            }

            listaTipiConferimento = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.CONFERIMENTO_CAPITALE);
            this.bindingSourceBaseTipiConferimentoCapitale.DataSource = listaTipiConferimento;

            dati = d;
        }

		#endregion Public Methods 

		#region Private Methods (3) 

        private DialogResult OpenForEdit(ComunicazioneBaseSocialeFDT comBS)
        {
            comBaseSocEdit1 = CreatePage<ComunicazioneBaseSocEdit>();

            if (comBaseSocEdit1 != null)
            {
                comBaseSocEdit1.VerificaSoci += new EventHandler(baseSocEdit_VerificaSoci);
                comBaseSocEdit1.ModificaTipoConferimento += new EventHandler(baseSocEdit_ModificaTipoConferimento);

                comBaseSocEdit1.SetFormTitle("Gestione comunicazione base sociale");
                comBaseSocEdit1.SetBindableData(comBS, listaTipiConferimento, dati);
                return comBaseSocEdit1.BaseForm.ShowDialog(this, this.ReadOnlyControls);
            }
            else
                return DialogResult.None;
        }

        private ComunicazioneBaseSocialeFDT GetCurrentItem()
        {
            ComunicazioneBaseSocialeFDT toReturn = null;

            if (this.bindingSourceBaseComunicazioneBase.Current != null)
            {
                toReturn = this.bindingSourceBaseComunicazioneBase.Current as ComunicazioneBaseSocialeFDT;
            }
            return toReturn;
        }

        private void AddComunicazione()
        {
            itemComunicazione = new ComunicazioneBaseSocialeFDT();
            itemComunicazione.IdRegistro = (itemComunicazione != null) ? itemCoop.RegistroCooperativa.IdRegistro : -1;
            itemComunicazione.IdComunicazioneBaseSociale = -1;

            if (OpenForEdit(itemComunicazione) == DialogResult.OK)
            {
                itemComunicazione.Status = ObjectStatus.ToInsert;

                gridViewCommunicationBase.BeginDataUpdate();
                itemCoop.RegistroCooperativa.AddComunicazioneBS(itemComunicazione);
                this.bindingSourceBaseComunicazioneBase.DataSource = itemCoop.RegistroCooperativa.ComunicazioniBaseSociale;
                gridViewCommunicationBase.EndDataUpdate();

                SetVisibilityBarButton(GetCurrentItem());
            }
        }

        private void ModifyComunicazione()
        {
            itemComunicazione = GetCurrentItem();

            if (itemComunicazione != null)
            {
                Boolean goOn = true;
                if (itemComunicazione.Status >= ObjectStatus.ToHide)
                {
                    goOn = false;
                }

                if (goOn)
                {
                    itemComunicazione.EndEdit();
                    itemComunicazione.BeginEdit();

                    if (OpenForEdit(itemComunicazione) == DialogResult.OK)
                    {
                        itemComunicazione.EndEdit();

                        if (itemComunicazione != null)
                        {
                            if (itemComunicazione.Status != ObjectStatus.ToInsert)
                                itemComunicazione.Status = ObjectStatus.ToUpdate;
                            this.bindingSourceBaseComunicazioneBase.EndEdit();
                            gridViewCommunicationBase.RefreshData();
                        }
                        else
                        {
                            this.bindingSourceBaseComunicazioneBase.CancelEdit();
                            ShowProblemsMessage();
                        }
                    }
                    else
                    {
                        itemComunicazione.CancelEdit();
                        this.bindingSourceBaseComunicazioneBase.CancelEdit();
                    }
                }
            }
        }

        private void DeleteComunicazione()
        {
            itemComunicazione = GetCurrentItem();

            if (itemComunicazione != null)
            {
                if (ShowConfirmMessage("Cancellazione", "Confermi la cancellazione dell'elemento selezionato?", string.Empty) == DialogResult.Yes)
                {
                    if (itemComunicazione.IdComunicazioneBaseSociale > 0)
                    {
                        itemComunicazione.Status = ObjectStatus.ToCancel;
                    }
                    else
                    {
                        ComunicazioneBaseSocialeFDT[] listActual = this.bindingSourceBaseComunicazioneBase.DataSource as ComunicazioneBaseSocialeFDT[];

                        if (listActual != null)
                        {
                            List<ComunicazioneBaseSocialeFDT> lTemp = new List<ComunicazioneBaseSocialeFDT>();
                            foreach (ComunicazioneBaseSocialeFDT ind in listActual)
                            {
                                if (ind != itemComunicazione)
                                {
                                    lTemp.Add(ind);
                                }
                            }
                            if (itemCoop != null && itemCoop.RegistroCooperativa != null)
                            {
                                itemCoop.RegistroCooperativa.ComunicazioniBaseSociale = lTemp.ToArray();
                                this.bindingSourceBaseComunicazioneBase.DataSource = itemCoop.RegistroCooperativa.ComunicazioniBaseSociale;
                            }
                        }
                    }

                    gridViewCommunicationBase.RefreshData();
                    SetVisibilityBarButton(itemComunicazione);
                }
            }
        }

        private void SetVisibilityBarButton(ComunicazioneBaseSocialeFDT item)
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

        private int CategoriaAttuale()
        {
            int idCat = -1;

            if (itemCoop != null)
            {
                if (itemCoop.RegistroCooperativa.CambioPosizioni != null && itemCoop.RegistroCooperativa.CambioPosizioni.Length > 0)
                {
                    for (int i = itemCoop.RegistroCooperativa.CambioPosizioni.Length - 1; i >= 0; i--)
                    {
                        if (itemCoop.RegistroCooperativa.CambioPosizioni[i].Status < ObjectStatus.ToHide)
                        {
                            idCat = itemCoop.RegistroCooperativa.CambioPosizioni[i].IdCategoria;
                            break;
                        }
                    }
                }
            }

            return idCat;
        }

        private void VerificaSoci()
        {
            ViolatedRule[] tmpViol = null;

            int idCategoriaAttuale = CategoriaAttuale();

            if (itemComunicazione != null)
            {
                tmpViol = GVCSystemEngine.InvokeService<ICooperatives, ViolatedRule[]>
                          (delegate() { return GVCSystemEngine.Cooperatives.VerifyNumeroSoci(itemComunicazione.SociCooperatori, idCategoriaAttuale, itemCoop.RegistroCooperativa.IdFormaGiu); },
                          true);
            }

            if (tmpViol != null && tmpViol.Length > 0)
            {
                comBaseSocEdit1.SetErrors(tmpViol);
            }
        }

        private void ModificaTipoConferimento()
        {
            if (comBaseSocEdit1.lookUpEditConferimentoCapitale.EditValue is int)
            {
                if (dati != null)
                {
                    if (Convert.ToInt32(comBaseSocEdit1.lookUpEditConferimentoCapitale.EditValue) == TipoConferimentoCapitale.IDAzioni)
                    {
                        dati.DisplayValMin = dati.ValAzioneMin;
                        dati.DisplayValMax = dati.ValAzioneMax;

                        //cambio binding source
                        //comBaseSocEdit1.textEditValoreConferimento.DataBindings.Clear();
                        //comBaseSocEdit1.textEditValoreConferimento.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", comBaseSocEdit1.bindingSourceBaseComunicazioneBase, "ValoreMinimoAzioni", true));
                    }
                    else if (Convert.ToInt32(comBaseSocEdit1.lookUpEditConferimentoCapitale.EditValue) == TipoConferimentoCapitale.IDQuote)
                    {
                        dati.DisplayValMin = dati.ValQuotaMin;
                        dati.DisplayValMax = dati.ValQuotaMax;

                        //cambio binding source
                        //comBaseSocEdit1.textEditValoreConferimento.DataBindings.Clear();
                        //comBaseSocEdit1.textEditValoreConferimento.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", comBaseSocEdit1.bindingSourceBaseComunicazioneBase, "ValoreMinimoQuote", true));

                    }

                    comBaseSocEdit1.bindingSourceBaseDati.ResetBindings(false);
                }

                //Verifica conferimenti
                if (Convert.ToInt32(comBaseSocEdit1.lookUpEditConferimentoCapitale.EditValue) ==
                  it.dedagroup.GVC.Repository.Common.Configurations.TipoConferimentoCapitale.IDAzioni)
                {
                    if (itemComunicazione.ValoreQuote != 0 &&
                        itemComunicazione.ValoreAzione == 0)
                    {
                        itemComunicazione.ValoreAzione = itemComunicazione.ValoreQuote;
                        itemComunicazione.ValoreQuote = 0;
                    }
                }
                else
                {
                    if (itemComunicazione.ValoreAzione != 0 &&
                        itemComunicazione.ValoreQuote == 0)
                    {
                        itemComunicazione.ValoreQuote = itemComunicazione.ValoreAzione;
                        itemComunicazione.ValoreAzione = 0;
                    }
                }
            }
        }

        private void HandleCurrentItemChange()
        {
            ComunicazioneBaseSocialeFDT item = GetCurrentItem();
            SetVisibilityBarButton(item);
            if (item != null )
            {
                this.documentationDetail1.SetBindableData(item);
            }
            else
            {
                this.documentationDetail1.SetBindableData(null);
            }
        }

        private void SetImages()
        {
            this.barButtonItemAdd.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Document_Add_24x24);
            this.barButtonItemModify.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Edit_24x24);
            this.barButtonItemDelete.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
        }

        

		#endregion Private Methods

        private void gridViewCommunicationBase_ShowGridMenu(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs e)
        {
            ComunicazioneBaseSocialeFDT item = GetCurrentItem();
            if (item != null)
            {
                GridView view = sender as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
                if (hitInfo.InRow)
                {
                    view.FocusedRowHandle = hitInfo.RowHandle;
                    popupMenuComunicazioneBase.ShowPopup(BarManager,
                            gridControlCommunicationBase.PointToScreen(e.Point));
                }
            }
        }

    }
}
