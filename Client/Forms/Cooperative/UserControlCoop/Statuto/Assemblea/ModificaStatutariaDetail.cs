using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Client.Forms.Common;
using it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Statuto.Assemblea.ModificheStatutarie;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using it.dedagroup.GVC.Repository.Common.Configurations;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Statuto.Assemblea
{
    public partial class ModificaStatutariaDetail : UserControlBase
    {
        #region Instance Variables (3)

        private DeliberaAssembleaFDT itemLocal = null;
        private CooperativaFDT itemCoop = null;
        private Boolean isReadOnly = true;

        public event EventHandler ModificaStatutaria;

        #endregion Instance Variables

        #region Constructors (1)

        public ModificaStatutariaDetail()
        {
            InitializeComponent();

            EnableControlAutoSize(new object[] { this }, gridControlModificheStatutarie, 100);

            SetImages();
        }

		#endregion Constructors 

        #region Event Handlers

        private void barButtonItemModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ModifyModificaStatutaria();
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddModificaStatutaria();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteModificaStatutaria();
        }

        private void gridViewStatutaryChange_ShowGridMenu(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs e)
        {
            ModificaStatutariaFDT item = GetCurrentItem();
            if (item != null)
            {
                GridView view = sender as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
                if (hitInfo.InRow)
                {
                    view.FocusedRowHandle = hitInfo.RowHandle;
                    popupMenuModificheStatutarie.ShowPopup(BarManager,
                            gridControlModificheStatutarie.PointToScreen(e.Point));
                }
            }
        }

        private void HandleCurrentItemChanged()
        {
            if (this.bindingSourceBaseModificheStatutarie.Current != null)
            {
                ModificaStatutariaFDT modifica = this.bindingSourceBaseModificheStatutarie.Current as ModificaStatutariaFDT;
                if (modifica != null)
                {
                    SetVisibilityBarButton(modifica);
                }
            }
        }

        private void gridControlModificheStatutarie_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifyModificaStatutaria();
        }

        private void barButtonItemCollegamento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenModificaCollegamento();
        }

        #endregion Event Handlers

        #region Public Methods (2)

        public void ResetBindings()
        {
            this.bindingSourceBaseModificheStatutarie.ResetBindings(false);
        }

        public void SetBindableData(DeliberaAssembleaFDT item, CooperativaFDT coop)
        {
            this.bindingSourceBaseTipiModificaStatutaria.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_TIPI_MODIFICA);

            itemLocal = item;
            if (item != null)
            {
                this.bindingSourceBaseModificheStatutarie.DataSource = item.ModificheStatutarie;
            }
            else
            {
                this.bindingSourceBaseModificheStatutarie.DataSource = null;
            }

            if (coop != null)
            {
                itemCoop = coop;
            }
        }

        public void SetReadOnlyButtons(Boolean readOnly)
        {
            isReadOnly = readOnly;
            this.barButtonItemAdd.Enabled = !readOnly;
            this.barButtonItemModify.Enabled = !readOnly;
            this.barButtonItemDelete.Enabled = !readOnly;
        }

		#endregion Public Methods 

		#region Private Methods

        private void SetImages()
        {
            this.barButtonItemAdd.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Document_Add_24x24);
            this.barButtonItemModify.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Edit_24x24);
            this.barButtonItemDelete.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
            this.barButtonItemCollegamento.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Add_24x24);
        }

        private ModificaStatutariaFDT GetCurrentItem()
        {
            ModificaStatutariaFDT toReturn = null;

            if (this.bindingSourceBaseModificheStatutarie.Current != null)
                toReturn = this.bindingSourceBaseModificheStatutarie.Current as ModificaStatutariaFDT;

            return toReturn;
        }

        private Boolean UltimaAssemblea(DeliberaAssembleaFDT assembleaRif)
        {
            Boolean toReturn = true;

            if (itemCoop.RegistroCooperativa.Assemblee.Length > 1)
            {
                foreach (DeliberaAssembleaFDT assemblea in itemCoop.RegistroCooperativa.Assemblee)
                {
                    if (assemblea.DataAssemblea > assembleaRif.DataAssemblea)
                    {
                        toReturn = false;
                    }
                }
            }

            return toReturn;
        }

        private void OpenModificaCollegamento()
        {
            ModificaStatutariaFDT item = GetCurrentItem();

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

                    if (OpenForEditCollegamento(item, false) == DialogResult.OK)
                    {
                        item.EndEdit();
                        ModificaStatutariaFDT newItem = SaveModificaStatutaria(item, true, false);

                        if (newItem != null)
                        {
                            if (newItem.Status != ObjectStatus.ToInsert)
                                newItem.Status = ObjectStatus.ToUpdate;
                            this.bindingSourceBaseModificheStatutarie.EndEdit();
                            //gridViewModificheStatutarie.RefreshData();
                        }
                        else
                        {
                            this.bindingSourceBaseModificheStatutarie.CancelEdit();
                            ShowProblemsMessage();
                        }
                    }
                    else
                    {
                        item.CancelEdit();
                        this.bindingSourceBaseModificheStatutarie.CancelEdit();
                    }
                }
            }
        }

        private void AddModificaStatutaria()
        {
            if (itemLocal != null && itemLocal.Status < 100)
            {
                ModificaStatutariaFDT item = new ModificaStatutariaFDT();
                item.IdAssemblea = (itemLocal != null) ? itemLocal.IdDeliberaAssemblea : -1;
                InizializeItem(item);

                if (OpenForEdit(item, true) == DialogResult.OK)
                {
                    ModificaStatutariaFDT newItem = SaveModificaStatutaria(item, false, false);
                    if (newItem != null)
                    {
                        String dettaglioModifiche = String.Empty;

                        this.gridViewModificheStatutarie.BeginDataUpdate();

                        if (itemLocal != null)
                        {
                            itemLocal.AddModificaStatutaria(newItem);

                            if (UltimaAssemblea(itemLocal))
                            {
                                //Aggiorna dati registro e restiuisce stringa modifiche effettuate
                                dettaglioModifiche = ModificaDatiRegistro(newItem);

                                CallTheEvent();
                            }
                        }

                        this.bindingSourceBaseModificheStatutarie.DataSource = itemLocal.ModificheStatutarie;
                        gridViewModificheStatutarie.EndDataUpdate();

                        ShowInformationMessage("Modifiche effettuate, per ulteriori informazioni vedere il dettaglio", String.Concat("Sono state modificate le seguenti informazioni:", Environment.NewLine, dettaglioModifiche));
                    }
                    else
                    {
                        ShowProblemsMessage();
                    }
                }
            }
            else
            {
                ShowInformationMessage("Nessuna assemblea selezionata", "Per inserire una modifica statutaria è necessario selezionare la relativa assemblea");
            }
        }

        private void CallTheEvent()
        {
            EventHandler temp = ModificaStatutaria;
            if (temp != null)
                ModificaStatutaria(null, new EventArgs());
        }

        private String ModificaDatiRegistro(ModificaStatutariaFDT itemModifica)
        {
            String dettaglioModifiche = String.Empty;

            if (itemModifica != null)
            {
                switch (itemModifica.IdTipoModifica)
                {
                    case TipoModificaStatutaria.DENOMINAZIONE:

                        if (!String.IsNullOrEmpty(itemModifica.NuovaDenominazione))
                        {
                            itemCoop.Denominazione = itemModifica.NuovaDenominazione;

                            dettaglioModifiche = String.Concat("Denominazione");
                        }
                        break;

                    case TipoModificaStatutaria.DURATA:

                        itemCoop.RegistroCooperativa.Durata = itemModifica.NuovaDurata;
                        itemCoop.RegistroCooperativa.DurataIllimitata = itemModifica.NuovaDurataIllimitata;

                        dettaglioModifiche = String.Concat("Durata");
                        break;

                    case TipoModificaStatutaria.FORMA_GIURIDICA:

                        if (itemModifica.IdNuovaFormaGiuridica >= 0)
                        {
                            itemCoop.RegistroCooperativa.IdFormaGiu = itemModifica.IdNuovaFormaGiuridica;

                            dettaglioModifiche = String.Concat("Forma giuridica");
                        }
                        break;

                    case TipoModificaStatutaria.SCADENZA_ESERCIZI:

                        if (itemModifica.NuovoBilancioEsercizioAl != null)
                        {
                            itemCoop.RegistroCooperativa.BilancioEsercizioAl = itemModifica.NuovoBilancioEsercizioAl;

                            dettaglioModifiche = String.Concat("Scadenza esercizio");
                        }
                        break;

                    case TipoModificaStatutaria.SCIOGLIMENTO:

                        itemCoop.RegistroCooperativa.IdStatoIscrizione = itemModifica.IdNuovoStatoIscrizione;

                        dettaglioModifiche = String.Concat("Stato");

                        break;

                    case TipoModificaStatutaria.REVOCA_SCIOGLIMENTO:

                        itemCoop.RegistroCooperativa.IdStatoIscrizione = itemModifica.IdNuovoStatoIscrizione;
                        itemCoop.RegistroCooperativa.NumeroScioglimento = null;

                        dettaglioModifiche = String.Concat("Stato", Environment.NewLine, "Eliminazione numero scioglimento");

                        break;

                    case TipoModificaStatutaria.TRASFERIM_FUORI_PROV:

                        itemCoop.RegistroCooperativa.IdStatoIscrizione = itemModifica.IdNuovoStatoIscrizione;

                        dettaglioModifiche = String.Concat("Stato");

                        break;

                    case TipoModificaStatutaria.FUSIONE_INCORPORANTE:

                        dettaglioModifiche = String.Concat("Creato collegamento tra società");

                        break;

                    case TipoModificaStatutaria.FUSIONE_INCORPORATA:

                        itemCoop.RegistroCooperativa.IdStatoIscrizione = itemModifica.IdNuovoStatoIscrizione;

                        dettaglioModifiche = String.Concat("Stato", Environment.NewLine, "Creato collegamento tra società");

                        break;

                    case TipoModificaStatutaria.SCISSIONE:

                        dettaglioModifiche = String.Concat("Creato collegamento tra società");

                        break;

                    case TipoModificaStatutaria.SCIOGLIMENTO_SCISSIONE:

                        itemCoop.RegistroCooperativa.IdStatoIscrizione = itemModifica.IdNuovoStatoIscrizione;

                        dettaglioModifiche = String.Concat("Stato");

                        break;
                }

                //Aggiornamento numero scioglimento
                itemCoop.RegistroCooperativa.AggiornaNrScioglimento = itemModifica.AggiornaNrScioglimento;

                if (itemModifica.AggiornaNrScioglimento)
                    dettaglioModifiche = String.Concat(dettaglioModifiche, Environment.NewLine, "Numero scioglimento");
            }

            return dettaglioModifiche;
        }

        private void InizializeItem(ModificaStatutariaFDT item)
        {
            if (itemCoop != null && itemCoop.RegistroCooperativa != null)
            {
                if (itemLocal != null)
                {
                    item.IdAssemblea = itemLocal.IdDeliberaAssemblea;
                    item.IdVecchiaFormaGiuridica = itemCoop.RegistroCooperativa.IdFormaGiu;
                    item.IdVecchioStatoIscrizione = itemCoop.RegistroCooperativa.IdStatoIscrizione;
                    item.VecchiaDenominazione = itemCoop.Denominazione;
                    item.VecchioBilancioEsercizioAl = itemCoop.RegistroCooperativa.BilancioEsercizioAl;
                    item.VecchiaDurataDisplay = itemCoop.RegistroCooperativa.Durata;
                    item.VecchiaDurataIllimitata = itemCoop.RegistroCooperativa.DurataIllimitata;

                    item.AggiornaNrScioglimento = false;
                    
                }
            }
        }

        private DialogResult OpenForEdit(ModificaStatutariaFDT item, Boolean addNew)
        {
            ModificaStatutariaEdit page = CreatePage<ModificaStatutariaEdit>();
            if (page != null)
            {
                page.SetFormTitle("Gestione modifica statutaria");
                page.SetBindableData(item, itemCoop, itemLocal);

                DialogResult dr = DialogResult.OK;
                while (dr == DialogResult.OK)
                {
                    page.ErrorProviderModificaStatutaria.ClearErrors();

                    Boolean readOnly = true;

                    if (addNew)
                        readOnly = false;

                    dr = page.BaseForm.ShowDialog(this, readOnly);

                    if (dr == DialogResult.OK)
                    {
                        if (!page.ErrorProviderModificaStatutaria.HasErrors)
                            break;
                    }
                }
                return dr;
            }
            else
                return DialogResult.None;
        }

        private DialogResult OpenForEditCollegamento(ModificaStatutariaFDT item, Boolean addNew)
        {
            CollegamentoEdit page = CreatePage<CollegamentoEdit>();
            if (page != null)
            {
                page.SetFormTitle("Gestione collegamento modifica statutaria");
                page.SetBindableData(item, itemCoop);

                return page.BaseForm.ShowDialog(this, this.ReadOnlyControls);
            }
            else
                return DialogResult.None;
        }

        private void ModifyModificaStatutaria()
        {
            ModificaStatutariaFDT item = GetCurrentItem();

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

                    if (OpenForEdit(item, false) == DialogResult.OK)
                    {
                        item.EndEdit();
                        ModificaStatutariaFDT newItem = SaveModificaStatutaria(item, true, false);

                        if (newItem != null)
                        {
                            if (newItem.Status != ObjectStatus.ToInsert)
                                newItem.Status = ObjectStatus.ToUpdate;
                            this.bindingSourceBaseModificheStatutarie.EndEdit();
                            gridViewModificheStatutarie.RefreshData();
                        }
                        else
                        {
                            this.bindingSourceBaseModificheStatutarie.CancelEdit();
                            ShowProblemsMessage();
                        }
                    }
                    else
                    {
                        item.CancelEdit();
                        this.bindingSourceBaseModificheStatutarie.CancelEdit();
                    }
                }
            }
        }

        private void DeleteModificaStatutaria()
        {
            ModificaStatutariaFDT item = GetCurrentItem();

            if (item != null)
            {
                if (ShowConfirmMessage("Cancellazione", String.Concat("Confermi la cancellazione dell'elemento selezionato?", Environment.NewLine, "Attenzione: le informazioni a video non verranno modificate, per ulteriore informazioni vedere il dettaglio..."), "Non verranno ripristinate le informazioni a video precedenti alla modifica statutaria, dovranno quindi essere aggiornate manualmente.") == DialogResult.Yes)
                {
                    if (item.IdModificaStatutaria > 0)
                    {
                        item.Status = ObjectStatus.ToCancel;
                    }
                    else
                    {
                        ModificaStatutariaFDT[] listActual = this.bindingSourceBaseModificheStatutarie.DataSource as ModificaStatutariaFDT[];

                        if (listActual != null)
                        {
                            List<ModificaStatutariaFDT> lTemp = new List<ModificaStatutariaFDT>();
                            foreach (ModificaStatutariaFDT ind in listActual)
                            {
                                if (ind != item)
                                {
                                    lTemp.Add(ind);
                                }
                            }
                            if (itemLocal != null)
                            {
                                itemLocal.ModificheStatutarie = lTemp.ToArray();
                                this.bindingSourceBaseModificheStatutarie.DataSource = itemLocal.ModificheStatutarie;
                            }
                        }
                    }

                    gridViewModificheStatutarie.RefreshData();
                    SetVisibilityBarButton(item);
                }
            }
        }

        private void SetVisibilityBarButton(ModificaStatutariaFDT item)
        {
            this.barButtonItemCollegamento.Enabled = false;

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
                        this.barButtonItemCollegamento.Enabled = false;
                    }
                    else
                    {
                        if (item.IdTipoModifica == TipoModificaStatutaria.FUSIONE_INCORPORANTE ||
                            item.IdTipoModifica == TipoModificaStatutaria.FUSIONE_INCORPORATA ||
                            item.IdTipoModifica == TipoModificaStatutaria.SCISSIONE)
                        {
                            this.barButtonItemCollegamento.Enabled = true;
                        }
                        else
                        {
                            this.barButtonItemCollegamento.Enabled = false;
                        }
                    }
                }
            }
        }

        private ModificaStatutariaFDT SaveModificaStatutaria(ModificaStatutariaFDT item, Boolean isAnUpdate, Boolean onDB)
        {
            ModificaStatutariaFDT toReturn = null;

            if (item != null)
            {
                if (onDB)
                {
                    // chiamata al servizio
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

        private void bindingSourceBaseModificheStatutarie_CurrentChanged(object sender, EventArgs e)
        {
            HandleCurrentItemChanged();
        }

		#endregion Private Methods
    }
}
