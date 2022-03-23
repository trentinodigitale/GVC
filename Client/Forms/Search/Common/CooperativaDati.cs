using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OeF.Utility;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.FDT;

namespace it.dedagroup.GVC.Client.Forms.Search.Common
{
    public partial class CooperativaDati : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        #region Instance Variables

        private CooperativaFDT parametri_coop = null;
        private RevisioneFDT parametri_rev = null;
        
        //private PersonaGiuridicaFDT parametri_adesione = null;

        #endregion Instance Variables

        #region Constructors (1)

        public CooperativaDati()
        {
            InitializeComponent();

            SetImages();
        }

        #endregion Constructors (1)

        #region Event Handlers

        private void simpleButtonCoopRicerca_Click(object sender, EventArgs e)
        {
            CooperativaFDT itemSogg = null;

            Search.CoopTemplateSearch page = CreatePageDialog<Search.CoopTemplateSearch>();
            if (page != null)
            {
                page.BaseForm.StartPosition = FormStartPosition.CenterScreen;

                DialogResult dr = DialogResult.OK;
                page.NotToOpen = true;

                while (dr == DialogResult.OK)
                {
                    itemSogg = null;

                    dr = page.BaseForm.ShowDialog(null, false);

                    if (dr != DialogResult.OK)
                    {
                        itemSogg = null;
                        break;
                    }

                    if (dr == DialogResult.OK)
                    {
                        itemSogg = page.SelectedItem;
                    }

                    if (itemSogg != null)
                        break;
                }

                if (itemSogg != null &&
                    itemSogg.RegistroCooperativa != null)
                {
                    bindingSourceParametriCoop.EndEdit();

                    parametri_coop.RegistroCooperativa.IdRegistro = itemSogg.RegistroCooperativa.IdRegistro;
                    parametri_coop.RegistroCooperativa.NumeroREA = itemSogg.RegistroCooperativa.NumeroREA;

                    bindingSourceParametriCoop.ResetBindings(false);
                }
            }
        }

        private void simpleButtonSearchAss_Click(object sender, EventArgs e)
        {
            SoggettoFDT item = new PersonaGiuridicaFDT();
            item.Note = this.textEditAssociazione.Text;

            Expression expression = (FieldName)SearchParameters.ASSOCIAZIONE == 1;
            if (OpenSubjectSearch(ref item, expression))
            {
                if (parametri_rev != null)
                {
                    parametri_rev.Revisore = item as PersonaGiuridicaFDT;
                    parametri_rev.IdOrganoRevisore = item.IdSoggetto;
                    this.bindingSourceRevisione.ResetBindings(false);
                }
            }
        }

        private void btnRemoveSubject_Click(object sender, EventArgs e)
        {
            if (parametri_rev != null)
            {
                parametri_rev.BeginEdit();

                parametri_rev.Revisore = null;
                parametri_rev.IdOrganoRevisore = -1;

                parametri_rev.EndEdit();

                this.bindingSourceRevisione.ResetBindings(false);
            }
        }

        private void radioGroupAdesione_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroupAdesione.SelectedIndex == 1)
            {
                AbilitaAssociazione(true);
            }
            else
            {
                AbilitaAssociazione(false);
            }
        }

        #endregion Event Handlers

        #region Public Methods

        public void SelectDefault(int indexAdesione, int indexIscrizione)
        {
            this.radioGroupAdesione.SelectedIndex = indexAdesione;
            this.radioGroupIscrizione.SelectedIndex = indexIscrizione;
        }

        public Boolean DefineParametrs()
        {
            return (this.radioGroupAdesione.SelectedIndex > 0 || this.radioGroupIscrizione.SelectedIndex > 0);
        }

        public void SetBindableData(CooperativaFDT item)
        {
            parametri_coop = item;
            parametri_coop.DataUltimaModifica = DateTime.Today;
            parametri_coop.RegistroCooperativa.DataUltimaModifica = DateTime.Today;

            this.bindingSourceParametriCoop.DataSource = parametri_coop;

            parametri_rev = new RevisioneFDT();

            this.bindingSourceRevisione.DataSource = parametri_rev;
        }

        public void BindingSourceEndInit()
        {
            this.bindingSourceParametriCoop.EndEdit();
            this.bindingSourceParametriAdesione.EndEdit();
        }

        public void BindingSourceResetBindings()
        {
            this.bindingSourceParametriCoop.ResetBindings(false);
            this.bindingSourceParametriAdesione.ResetBindings(false);
        }

        public int GetIndexIscrizione()
        {
            return this.radioGroupIscrizione.SelectedIndex;
        }

        public int GetIndexAdesione()
        {
            return this.radioGroupAdesione.SelectedIndex;
        }

        public DateTime GetDataIscrizione()
        {
            DateTime toReturn = DateTime.Today;

            if (parametri_coop.DataUltimaModifica.HasValue)
            {
                toReturn = parametri_coop.DataUltimaModifica.Value;
            }

            return toReturn;
        }

        public int GetIDAssociazione()
        {
            int toReturn = 0;
            if (parametri_rev != null)
            {
                toReturn = parametri_rev.IdOrganoRevisore;
            }

            return toReturn;
        }

        public DateTime GetDataAdesione()
        {
            DateTime toReturn = DateTime.Today;

            if (parametri_coop.RegistroCooperativa != null &&
                parametri_coop.RegistroCooperativa.DataUltimaModifica.HasValue)
            {
                toReturn = parametri_coop.RegistroCooperativa.DataUltimaModifica.Value;
            }

            return toReturn;
        }

        public Expression GetQueryCoop()
        {
            Expression query = null;

            this.bindingSourceParametriCoop.EndEdit();

            if (parametri_coop.RegistroCooperativa.IdRegistro > 0)
                query &= (FieldName)SearchParameters.CODICE_COOPERATIVA == parametri_coop.RegistroCooperativa.IdRegistro;
            if (!String.IsNullOrEmpty(parametri_coop.RegistroCooperativa.NumeroREA))
                query &= (FieldName)SearchParameters.NUMERO_REA == parametri_coop.RegistroCooperativa.NumeroREA;
        
            return query;
        }

        public override bool ReadOnlyControls
        {
            get
            {
                return base.ReadOnlyControls;
            }
            set
            {
                base.ReadOnlyControls = false;

                AbilitaAssociazione(false);
            }
        }

        public void ResetParameters()
        {
            parametri_coop = new CooperativaFDT();
            parametri_coop.RegistroCooperativa = new RegistroCooperativaFDT();
            parametri_coop.DataUltimaModifica = null; //DateTime.Today;
            parametri_coop.RegistroCooperativa.DataUltimaModifica = null; //DateTime.Today;

            this.bindingSourceParametriCoop.DataSource = parametri_coop;

            parametri_rev = new RevisioneFDT();

            this.bindingSourceRevisione.DataSource = parametri_rev;

            this.radioGroupAdesione.SelectedIndex = 0;
            this.radioGroupIscrizione.SelectedIndex = 0;
        }

        #endregion Public Methods

        #region Private Methods

        private void SetImages()
        {
            this.btnRemoveSubject.Image = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
        }

        private void AbilitaAssociazione(Boolean abilita)
        {
            this.textEditAssociazione.Properties.ReadOnly = !abilita;
            this.btnRemoveSubject.Enabled = abilita;
            this.simpleButtonSearchAss.Enabled = abilita;

            if (!abilita)
            {
                if (parametri_rev != null &&
                    parametri_rev.Revisore != null)
                {
                    parametri_rev.Revisore = null;
                    this.bindingSourceRevisione.DataSource = parametri_rev;
                }

                this.textEditAssociazione.Text = String.Empty;
            }
        }

        #endregion Private Methods
    }
}
