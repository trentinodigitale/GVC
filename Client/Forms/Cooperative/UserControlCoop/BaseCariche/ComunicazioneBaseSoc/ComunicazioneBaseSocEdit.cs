using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using OeF.Validation;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.PositionAndBase.ComunicazioneBaseSoc
{
    public partial class ComunicazioneBaseSocEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {
        public event EventHandler VerificaSoci;
        public event EventHandler ModificaTipoConferimento;

        private ComunicazioneBaseSocialeFDT itemLocal;

		#region Constructors (1) 

        public ComunicazioneBaseSocEdit()
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
                TotaleSoci.Properties.ReadOnly = true;
                ValoreMinimo.Properties.ReadOnly = true;
                ValoreMassimo.Properties.ReadOnly = true;
            }
        }

		#endregion Constructors 

		#region Public Methods (3) 

        public void EndInitBindingSource()
        {
            this.bindingSourceBaseComunicazioneBase.EndEdit();
        }

        public void ResetBindingsBindingSource()
        {
            this.bindingSourceBaseComunicazioneBase.ResetBindings(false);
        }

        public void SetBindableData(ComunicazioneBaseSocialeFDT item, DizionarioFDT[] listaTipiConferimento ,DatiFDT dati)
        {
            itemLocal = item;
            this.bindingSourceBaseTipoConferimentoCapitale.DataSource = listaTipiConferimento;
            this.bindingSourceBaseComunicazioneBase.DataSource = item;
            this.bindingSourceBaseDati.DataSource = dati;
        }

        public void SetErrors(ViolatedRule[] rules)
        {
            ErrorProviderComunicazioneBase.ClearErrors();

            foreach (ViolatedRule rule in rules)
            {
                if (!String.IsNullOrEmpty(rule.PropertyName))
                {
                    ErrorProviderComunicazioneBase.SetError(this.SociCooperatori,
                                                rule.Message,
                                                rule.ErrorType);
                }
            }
        }

		#endregion Public Methods 

        #region Private Methods (1)

        private void CalcolaTotSoci()
        {
            Int32 cooperatori = 0;
            Int32 sovventori = 0;
            Int32 altro = 0;

            this.bindingSourceBaseComunicazioneBase.EndEdit();

            cooperatori = itemLocal.SociCooperatori;
            sovventori = itemLocal.SociSovventori;
            altro = itemLocal.SociAltreTipologie;

            Int32 tot = cooperatori + sovventori + altro;

            itemLocal.SociCooperatori = cooperatori;
            itemLocal.SociSovventori = sovventori;
            itemLocal.SociAltreTipologie = altro;

            itemLocal.TotaleSoci = tot;

            this.bindingSourceBaseComunicazioneBase.ResetBindings(false);
        }

        #endregion Private Methods

        #region Event Handlers

        private void btnVerificaSoci_Click(object sender, EventArgs e)
        {
            EventHandler temp = VerificaSoci;
            if (temp != null)
                VerificaSoci(this, new EventArgs());
        }

        private void lookUpEditCommunicationCapital_EditValueChanged(object sender, EventArgs e)
        {
            EventHandler temp = ModificaTipoConferimento;
            if (temp != null)
                ModificaTipoConferimento(this, new EventArgs());
        }

        private void SociCooperatori_EditValueChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(SociCooperatori.Text))
            {
                Int32 nr;
                if (Int32.TryParse(SociCooperatori.Text, out nr))
                {
                    itemLocal.SociCooperatori = nr;
                    CalcolaTotSoci();
                }
            }
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textEdit1.Text))
            {
                Int32 nr;
                if (Int32.TryParse(textEdit1.Text, out nr))
                {
                    itemLocal.SociSovventori = nr;
                    CalcolaTotSoci();
                }
            }
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textEdit2.Text))
            {
                Int32 nr;
                if (Int32.TryParse(textEdit2.Text, out nr))
                {
                    itemLocal.SociAltreTipologie = nr;
                    CalcolaTotSoci();
                }
            }
        }

        #endregion Event Handlers
    }
}
