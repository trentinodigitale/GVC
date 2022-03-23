using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Statuto.Assemblea.ModificheStatutarie;
using it.dedagroup.GVC.Repository.Common.Configurations;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Statuto.Assemblea
{
    public partial class ModificaStatutariaEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {
        #region Instance Variables (6)

        private CooperativaFDT itemCoop = null;
        private ModificaStatutariaFDT itemLocal = null;

        private NuovaDenominazione DenominazioneEdit;
        private NuovaDurata DurataEdit;
        private NuovaFormaGiuridica FormaGiuridicaEdit;
        private NuovaScadenzaEsercizi ScadenzaEserciziEdit;
        private NuovoScioglimentoVolontario ScioglimentoVolontarioEdit;
        private TrasferimentoFuoriProv TrasferimentoFuoriProvEdit;
        private ModificaGenerica ModificaGenericaEdit;
        private AttoFusioneScissione AttoFusioneScissioneEdit;
        private Fusione FusioneEdit;
        private FusioneIncorporante FusioneIncorporanteEdit;
        private Scissione ScissioneEdit;
        private AttoFusioneScissione ScioglimentoScissioneEdit;
        
        #endregion Instance Variables

        #region Constructors (1)

        public ModificaStatutariaEdit()
        {
            InitializeComponent();
        }

        public override bool ReadOnlyControls
        {
            get
            {
                return base.ReadOnlyControls;
            }
            set
            {
                base.ReadOnlyControls = value;
                dateEdit1.Properties.ReadOnly = true;
                lookUpEditType.Properties.ReadOnly = true;

                Filter();
            }
        }

        #endregion Constructors

        #region Event Handlers

        #endregion Event Handlers

        #region Private Methods

        internal void SetBindableData(ModificaStatutariaFDT item, CooperativaFDT coop, DeliberaAssembleaFDT assemblea)
        {
            this.bindingSourceBaseTipoModificaStatutaria.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_TIPI_MODIFICA);

            //if (item != null)
            {
                itemLocal = item;
                this.bindingSourceBaseModificaStatutaria.DataSource = item;
            }

            if (coop != null)
            {
                itemCoop = coop;
            }

            if (assemblea != null)
            {
                this.bindingSourceBaseAssemblea.DataSource = assemblea;
                this.bindingSourceBaseTipoAssemblea.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_ASSEMBLEA);
            }

            Filter();
        }

        private void Filter()
        {
            if (this.ReadOnlyControls)
            {
                DropDownFilter(gridViewTipoModifica, colAttivo, false);
            }
            else
            {
                DropDownFilter(gridViewTipoModifica, colAttivo, true);
            }
        }

        private ComunicazioneCaricaSocialeFDT ultimaComunicazione()
        {
            //ComunicazioneCaricaSocialeFDT toReturn = null;
            //int posizione = 0;

            //if (itemCoop != null && itemCoop.RegistroCooperativa != null)
            //{
            //    if (itemCoop.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale != null &&
            //        itemCoop.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale.Length > 0)
            //    {
            //        posizione = itemCoop.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale.Length;
            //        toReturn = itemCoop.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale[posizione-1];
            //    }
            //}

            //return toReturn;

            ComunicazioneCaricaSocialeFDT toReturn = null;

            if (itemCoop != null && itemCoop.RegistroCooperativa != null)
            {
                if (itemCoop.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale != null &&
                    itemCoop.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale.Length > 0)
                {
                    if (itemCoop.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale.Length == 1)
                    {
                        if (itemCoop.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale[0].Status != ObjectStatus.ToCancel)
                            toReturn = itemCoop.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale[0];
                    }
                    else
                    {
                        int contatore = 0;
                        DateTime dataRif = DateTime.MinValue;
                        int indice = -1;

                        foreach (ComunicazioneCaricaSocialeFDT itemCS in itemCoop.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale)
                        {
                            if (itemCS.Status != ObjectStatus.ToCancel &&
                                itemCS.DataSituazione > dataRif)
                            {
                                dataRif = itemCS.DataSituazione;
                                indice = contatore;
                            }

                            contatore++;
                        }

                        if (indice > -1)
                        {
                            toReturn = itemCoop.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale[indice];
                        }
                    }
                }
            }

            return toReturn;
        }

        #region Show Data

        private void AddUserControlNew(int tipo)
        {
            switch (tipo)
            {
                case TipoModificaStatutaria.DENOMINAZIONE:
                    ShowDenominazione();
                    break;

                case TipoModificaStatutaria.DURATA:
                    ShowDurata();
                    break;

                case TipoModificaStatutaria.FORMA_GIURIDICA:
                    ShowFormaGiuridica();
                    break;

                case TipoModificaStatutaria.SCIOGLIMENTO:
                    ShowScioglimentoVolontario();
                    break;

                case TipoModificaStatutaria.REVOCA_SCIOGLIMENTO:
                    ShowRevocaScioglimentoVolontario();
                    break;

                case TipoModificaStatutaria.SCADENZA_ESERCIZI:
                    ShowScadenzaEsercizi();
                    break;

                case TipoModificaStatutaria.TRASFERIM_FUORI_PROV:
                    ShowTrasferimento();
                    break;

                case TipoModificaStatutaria.ATTO_FUSIONE_SCISSIONE:
                    ShowAttoFusioneScissione();
                    break;

                case TipoModificaStatutaria.FUSIONE_INCORPORANTE:
                    ShowFusioneIncorporante();
                    break;

                case TipoModificaStatutaria.FUSIONE_INCORPORATA:
                    ShowFusione();
                    break;

                case TipoModificaStatutaria.SCISSIONE:
                    ShowScissione();
                    break;

                case TipoModificaStatutaria.SCIOGLIMENTO_SCISSIONE:
                    ShowScioglimentoScissione();
                    break;

                default:
                    ShowModificaGenerica();
                    break;

            }
        }

        private void ShowDenominazione()
        {
            this.panelControl2.Controls.Clear();
            DenominazioneEdit = CreatePage<NuovaDenominazione>();
            DenominazioneEdit.SetBindableData(itemLocal);

            this.ParentForm.Size = new Size(DenominazioneEdit.Width, DenominazioneEdit.Height + 240);
            this.ParentForm.MinimumSize = this.ParentForm.Size;
           
            this.panelControl2.Controls.Add(DenominazioneEdit);

            this.ScrollableContent.Controls.Add(DenominazioneEdit);

            DenominazioneEdit.ReadOnlyControls = this.ReadOnlyControls;

            DenominazioneEdit.BringToFront();
        }

        private void ShowDurata()
        {
            this.panelControl2.Controls.Clear();
            DurataEdit = CreatePage<NuovaDurata>();
            DurataEdit.SetBindableData(itemLocal);

            this.ParentForm.Size = new Size(DurataEdit.Width, DurataEdit.Height + 240); //+ this.PanelButtons.Height + 20
            this.ParentForm.MinimumSize = this.ParentForm.Size;
           
            this.panelControl2.Controls.Add(DurataEdit);

            this.ScrollableContent.Controls.Add(DurataEdit);

            DurataEdit.ReadOnlyControls = this.ReadOnlyControls;

            DurataEdit.BringToFront();
        }

        private void ShowFormaGiuridica()
        {
            this.panelControl2.Controls.Clear();
            FormaGiuridicaEdit = CreatePage<NuovaFormaGiuridica>();
            itemLocal.IdNuovoStatoIscrizione = TipoStatoIscrizione.TRASFORMAZIONE_FORMA_GIURIDICA;
            if (itemCoop.RegistroCooperativa.NumeroScioglimento == null ||
                itemCoop.RegistroCooperativa.NumeroScioglimento < 1)
                itemLocal.AggiornaNrScioglimento = true;
            FormaGiuridicaEdit.SetBindableData(itemLocal);

            this.ParentForm.Size = new Size(FormaGiuridicaEdit.Width, FormaGiuridicaEdit.Height + 240); //+ this.PanelButtons.Height + 20
            this.ParentForm.MinimumSize = this.ParentForm.Size;

            this.panelControl2.Controls.Add(FormaGiuridicaEdit);

            this.ScrollableContent.Controls.Add(FormaGiuridicaEdit);

            FormaGiuridicaEdit.ReadOnlyControls = this.ReadOnlyControls;

            FormaGiuridicaEdit.BringToFront();
        }

        private void ShowScadenzaEsercizi()
        {
            this.panelControl2.Controls.Clear();
            ScadenzaEserciziEdit = CreatePage<NuovaScadenzaEsercizi>();
            ScadenzaEserciziEdit.SetBindableData(itemLocal);

            this.ParentForm.Size = new Size(ScadenzaEserciziEdit.Width, ScadenzaEserciziEdit.Height + 240); //+ this.PanelButtons.Height + 20
            this.ParentForm.MinimumSize = this.ParentForm.Size;

            this.panelControl2.Controls.Add(ScadenzaEserciziEdit);

            this.ScrollableContent.Controls.Add(ScadenzaEserciziEdit);

            ScadenzaEserciziEdit.ReadOnlyControls = this.ReadOnlyControls;

            ScadenzaEserciziEdit.BringToFront();
        }

        private void ShowScioglimentoVolontario()
        {
            this.panelControl2.Controls.Clear();
            ScioglimentoVolontarioEdit = CreatePage<NuovoScioglimentoVolontario>();

            itemLocal.IdNuovoStatoIscrizione = TipoStatoIscrizione.SCIOGLIMENTO_VOLONTARIO;
            if (itemCoop.RegistroCooperativa.NumeroScioglimento == null ||
                itemCoop.RegistroCooperativa.NumeroScioglimento < 1)
                itemLocal.AggiornaNrScioglimento = true;
            ScioglimentoVolontarioEdit.ShowNumeroScioglimento(true);
            ScioglimentoVolontarioEdit.SetBindableData(itemLocal, ultimaComunicazione());

            this.ParentForm.Size = new Size(ScioglimentoVolontarioEdit.Width, ScioglimentoVolontarioEdit.Height + 240); //+ this.PanelButtons.Height + 20
            this.ParentForm.MinimumSize = this.ParentForm.Size;

            this.panelControl2.Controls.Add(ScioglimentoVolontarioEdit);
                        
            this.ScrollableContent.Controls.Add(ScioglimentoVolontarioEdit);

            ScioglimentoVolontarioEdit.ReadOnlyControls = this.ReadOnlyControls;

            ScioglimentoVolontarioEdit.BringToFront();

        }

        private void ShowRevocaScioglimentoVolontario()
        {
            this.panelControl2.Controls.Clear();
            ScioglimentoVolontarioEdit = CreatePage<NuovoScioglimentoVolontario>();
            itemLocal.IdNuovoStatoIscrizione = TipoStatoIscrizione.NORMALE;
            //if (itemCoop.RegistroCooperativa.NumeroScioglimento == null ||
            //    itemCoop.RegistroCooperativa.NumeroScioglimento < 1)
            //    itemLocal.AggiornaNrScioglimento = true;
            ScioglimentoVolontarioEdit.ShowNumeroScioglimento(false);
            ScioglimentoVolontarioEdit.SetBindableData(itemLocal, ultimaComunicazione());

            this.ParentForm.Size = new Size(ScioglimentoVolontarioEdit.Width, ScioglimentoVolontarioEdit.Height + 240); //+ this.PanelButtons.Height + 20
            this.ParentForm.MinimumSize = this.ParentForm.Size;

            this.panelControl2.Controls.Add(ScioglimentoVolontarioEdit);

            this.ScrollableContent.Controls.Add(ScioglimentoVolontarioEdit);

            ScioglimentoVolontarioEdit.ReadOnlyControls = this.ReadOnlyControls;

            ScioglimentoVolontarioEdit.BringToFront();

        }

        private void ShowTrasferimento()
        {
            this.panelControl2.Controls.Clear();
            TrasferimentoFuoriProvEdit = CreatePage<TrasferimentoFuoriProv>();
            itemLocal.IdNuovoStatoIscrizione = TipoStatoIscrizione.TRASFERIMENTO_FUORI_PROV;
            if (itemCoop.RegistroCooperativa.NumeroScioglimento == null ||
                itemCoop.RegistroCooperativa.NumeroScioglimento < 1)
                itemLocal.AggiornaNrScioglimento = true;
            TrasferimentoFuoriProvEdit.SetBindableData(itemLocal);

            this.ParentForm.Size = new Size(TrasferimentoFuoriProvEdit.Width, TrasferimentoFuoriProvEdit.Height + 240); //+ this.PanelButtons.Height + 20
            this.ParentForm.MinimumSize = this.ParentForm.Size;

            this.panelControl2.Controls.Add(TrasferimentoFuoriProvEdit);

            this.ScrollableContent.Controls.Add(TrasferimentoFuoriProvEdit);

            TrasferimentoFuoriProvEdit.ReadOnlyControls = this.ReadOnlyControls;

            TrasferimentoFuoriProvEdit.BringToFront();
        }

        private void ShowModificaGenerica()
        {
            this.panelControl2.Controls.Clear();
            ModificaGenericaEdit = CreatePage<ModificaGenerica>();
            ModificaGenericaEdit.SetBindableData(itemLocal);

            this.ParentForm.Size = new Size(ModificaGenericaEdit.Width, ModificaGenericaEdit.Height + 240); //+ this.PanelButtons.Height + 20
            this.ParentForm.MinimumSize = this.ParentForm.Size;

            this.panelControl2.Controls.Add(ModificaGenericaEdit);

            this.ScrollableContent.Controls.Add(ModificaGenericaEdit);

            ModificaGenericaEdit.ReadOnlyControls = this.ReadOnlyControls;

            ModificaGenericaEdit.BringToFront();
        }

        private void ShowAttoFusioneScissione()
        {
            this.panelControl2.Controls.Clear();
            AttoFusioneScissioneEdit = CreatePage<AttoFusioneScissione>();
            AttoFusioneScissioneEdit.SetBindableData(itemLocal);

            this.ParentForm.Size = new Size(AttoFusioneScissioneEdit.Width, AttoFusioneScissioneEdit.Height + 240); //+ this.PanelButtons.Height + 20
            this.ParentForm.MinimumSize = this.ParentForm.Size;

            this.panelControl2.Controls.Add(AttoFusioneScissioneEdit);

            this.ScrollableContent.Controls.Add(AttoFusioneScissioneEdit);

            AttoFusioneScissioneEdit.ReadOnlyControls = this.ReadOnlyControls;

            AttoFusioneScissioneEdit.BringToFront();
        }

        private void ShowFusione()
        {
            this.panelControl2.Controls.Clear();
            FusioneEdit = CreatePage<Fusione>();
            itemLocal.IdNuovoStatoIscrizione = TipoStatoIscrizione.CESSATA_INCORPORAZIONE;
            FusioneEdit.SetBindableData(itemLocal);

            this.ParentForm.Size = new Size(FusioneEdit.Width, FusioneEdit.Height + 240); //+ this.PanelButtons.Height + 20
            this.ParentForm.MinimumSize = this.ParentForm.Size;

            this.panelControl2.Controls.Add(FusioneEdit);

            this.ScrollableContent.Controls.Add(FusioneEdit);

            FusioneEdit.ReadOnlyControls = this.ReadOnlyControls;

            FusioneEdit.BringToFront();
        }

        private void ShowFusioneIncorporante()
        {
            this.panelControl2.Controls.Clear();
            FusioneIncorporanteEdit = CreatePage<FusioneIncorporante>();
            FusioneIncorporanteEdit.SetBindableData(itemLocal);

            this.ParentForm.Size = new Size(FusioneIncorporanteEdit.Width, FusioneIncorporanteEdit.Height + 240); //+ this.PanelButtons.Height + 20
            this.ParentForm.MinimumSize = this.ParentForm.Size;

            this.panelControl2.Controls.Add(FusioneIncorporanteEdit);

            this.ScrollableContent.Controls.Add(FusioneIncorporanteEdit);

            FusioneIncorporanteEdit.ReadOnlyControls = this.ReadOnlyControls;

            FusioneIncorporanteEdit.BringToFront();
        }

        private void ShowScissione()
        {
            this.panelControl2.Controls.Clear();
            ScissioneEdit = CreatePage<Scissione>();
            ScissioneEdit.SetBindableData(itemLocal);

            this.ParentForm.Size = new Size(ScissioneEdit.Width, ScissioneEdit.Height + 240); //+ this.PanelButtons.Height + 20
            this.ParentForm.MinimumSize = this.ParentForm.Size;

            this.panelControl2.Controls.Add(ScissioneEdit);

            this.ScrollableContent.Controls.Add(ScissioneEdit);

            ScissioneEdit.ReadOnlyControls = this.ReadOnlyControls;

            ScissioneEdit.BringToFront();
        }

        private void ShowScioglimentoScissione()
        {
            this.panelControl2.Controls.Clear();
            ScioglimentoScissioneEdit = CreatePage<AttoFusioneScissione>();
            itemLocal.IdNuovoStatoIscrizione = TipoStatoIscrizione.SCIOGLIMENTO_SCISSIONE;
            if (itemCoop.RegistroCooperativa.NumeroScioglimento == null ||
               itemCoop.RegistroCooperativa.NumeroScioglimento < 1)
                itemLocal.AggiornaNrScioglimento = true;
            ScioglimentoScissioneEdit.SetBindableData(itemLocal);

            this.ParentForm.Size = new Size(ScioglimentoScissioneEdit.Width, ScioglimentoScissioneEdit.Height + 240); //+ this.PanelButtons.Height + 20
            this.ParentForm.MinimumSize = this.ParentForm.Size;

            this.panelControl2.Controls.Add(ScioglimentoScissioneEdit);

            this.ScrollableContent.Controls.Add(ScioglimentoScissioneEdit);

            ScioglimentoScissioneEdit.ReadOnlyControls = this.ReadOnlyControls;

            ScioglimentoScissioneEdit.BringToFront();
        }

        #endregion Show Data

        private void gridLookUpEditTipoModifica_EditValueChanged(object sender, EventArgs e)
        {
            if (gridLookUpEditTipoModifica != null)
            {
                if (gridLookUpEditTipoModifica.EditValue is int)
                {
                    AddUserControlNew(Convert.ToInt32(gridLookUpEditTipoModifica.EditValue));
                }
            }
        }

        #endregion Private Methods
    }
}
