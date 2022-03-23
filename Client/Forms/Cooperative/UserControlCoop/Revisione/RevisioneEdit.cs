using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.Services;
using OeF.Utility;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Revisione
{
    public partial class RevisioneEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {
        RevisioneFDT revisione = null;

        #region Constructors (1)
        
        public RevisioneEdit()
        {
            InitializeComponent();

            SetImages();
        }

        #endregion Constructors

        private void Filter()
        {
            if (this.ReadOnlyControls)
            {
                DropDownFilter(gridViewTipoRevisione, colAttivo, false);
            }
            else
            {
                DropDownFilter(gridViewTipoRevisione, colAttivo, true);
            }
        }


        #region Public Methods (3)

        public void BindingSourceEndInit()
        {
            this.bindingSourceRevisione.EndEdit();
        }

        public void BindingSourceResetBindings()
        {
            this.bindingSourceRevisione.ResetBindings(false);
        }

        public void SetBindableData(RevisioneFDT item)
        {
            if (item != null)
            {
                revisione = item;
                this.bindingSourceRevisione.DataSource = revisione;
            }
            this.bindingSourceTipoRevisione.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_REVISIONE);
            this.bindingSourceEsitiRevisione.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.ESITI_REVISIONE);
            this.bindingSourceLimitiCosto.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.LIMITI_COSTO);

            Filter();
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
                memoEdit2.Properties.ReadOnly = true;
                this.btnViewSubject.Enabled = true;

                Filter();
            }
        }
        #endregion Public Methods 

        #region Private Methods

        private void SetImages()
        {
            btnRicercaSoggetto.Image = GVCResourcesUtility.Get_16x16(GVCResources.Businessman_Find_24x24);
            this.btnViewSubject.Image = GVCResourcesUtility.Get_16x16(GVCResources.Businessman_24x24);
            this.btnRemoveSubject.Image = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
        }

        #endregion Private Methods

        #region Event Handlers

        private void btnRemoveSubject_Click(object sender, EventArgs e)
        {
            if (revisione != null)
            {
                revisione.BeginEdit();

                revisione.Revisore = null;
                revisione.IdOrganoRevisore = -1;

                revisione.EndEdit();

                this.bindingSourceRevisione.ResetBindings(false);
            }
        }

        private void btnSearchAssociation_Click(object sender, EventArgs e)
        {
            SoggettoFDT item = new PersonaGiuridicaFDT();

            Expression expression = (FieldName)SearchParameters.ASSOCIAZIONE == 1;
            if (OpenSubjectSearch(ref item, expression))
            {
                if (revisione != null)
                {
                    revisione.Revisore = item as PersonaGiuridicaFDT;
                    revisione.IdOrganoRevisore = item.IdSoggetto;
                    this.bindingSourceRevisione.ResetBindings(false);
                }
                //else
                //{
                //    this.memoEdit2.Text = ((PersonaGiuridicaFDT)item).DescrizioneBreve;
            }
        }

        #endregion Event Handlers

        private void btnViewSubject_Click(object sender, EventArgs e)
        {
            SoggettoFDT sj = null;
            if (this.revisione != null)
            {
                if (revisione.Revisore != null)
                {
                    sj = revisione.Revisore;
                }
                else
                {
                    if (revisione.IdOrganoRevisore > 0)
                    {

                        SoggettoFDT ss =
                        GVCSystemEngine.InvokeService<ICooperatives, SoggettoFDT>
                            (delegate()
                        {
                            return GVCSystemEngine.Cooperatives.GetSoggettoById(revisione.IdOrganoRevisore);
                        },
                         true);

                        if (ss is PersonaGiuridicaFDT)
                        {
                            revisione.Revisore = ss as PersonaGiuridicaFDT;

                            if (revisione.Revisore != null)
                            {
                                sj = revisione.Revisore;
                            }
                        }
                    }
                }
            }
            if (sj != null)
            {
                OpenViewSubject(sj);
            }
        }

        private void OpenViewSubject(SoggettoFDT subject)
        {
            it.dedagroup.GVC.Client.Forms.Registry.AnagraficaEdit page =
                CreatePage<it.dedagroup.GVC.Client.Forms.Registry.AnagraficaEdit>();

            if (page != null)
            {
                page.SetBindableData(subject);
                page.SetFormTitle("Dettagli soggetto");
                page.BaseForm.ShowDialog(this, true);
            }
        }
    }
}
