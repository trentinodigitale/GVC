using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.Services;
using OeF.Utility;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.BaseCariche.ComunicazioneCaricaSoc
{
    public partial class CaricaSocialeEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {
        CaricaSocialeFDT caricaSoc = null;

        #region Constructors (1)
        
        public CaricaSocialeEdit()
        {
            InitializeComponent();

            SetImages();
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
                dateEdit3.Properties.ReadOnly = true;
                memoEdit2.Properties.ReadOnly = true;
                this.btnViewSubject.Enabled = true;

                Filter();
            }
        }

        #endregion Constructors

        #region Public Methods (3)

        public void EndInitBindingSource()
        {
            this.bindingSourceCariche.EndEdit();
        }

        public void ResetBindingsBindingSource()
        {
            this.bindingSourceCariche.ResetBindings(false);
        }

        public void SetBindableData(ComunicazioneCaricaSocialeFDT comunicazione, CaricaSocialeFDT item, DizionarioFDT[] listaTipiCarica)
        {
            this.bindingSourceTipiCarica.DataSource = listaTipiCarica;

            if (comunicazione != null)
                this.bindingSourceCommunicazioni.DataSource = comunicazione;

            if (item != null)
            {
                caricaSoc = item;
                this.bindingSourceCariche.DataSource = caricaSoc;
            }

            Filter();
        }

        #endregion Public Methods 

        #region Private Methods

        private void SetImages()
        {
            btnRicercaSoggetto.Image = GVCResourcesUtility.Get_16x16(GVCResources.Businessman_Find_24x24);
            this.btnViewSubject.Image = GVCResourcesUtility.Get_16x16(GVCResources.Businessman_24x24);
            this.btnRemoveSubject.Image = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
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

        private void Filter()
        {
            if (this.ReadOnlyControls)
            {
                DropDownFilter(gridViewTipoCarica, colAttivo, false);
            }
            else
            {
                DropDownFilter(gridViewTipoCarica, colAttivo, true);
            }
        }

        #endregion Private Methods

        #region Event Handlers

        private void btnRemoveSubject_Click(object sender, EventArgs e)
        {
            if (caricaSoc != null)
            {
                caricaSoc.BeginEdit();

                caricaSoc.PersonaFisica = null;
                caricaSoc.IdSoggetto = -1;
                caricaSoc.DescrizioneGSC = String.Empty;

                caricaSoc.EndEdit();

                this.bindingSourceCariche.ResetBindings(false);
            }
        }

        private void btnRicercaSoggetto_Click(object sender, EventArgs e)
        {
            SoggettoFDT item = new PersonaFisicaFDT();
            item.IdTipoSoggetto = 1;

            Expression expression = (FieldName)SearchParameters.ID_TIPO_SOGGETTO == TipiSoggettiSpecifici.Socio;
            if (OpenSubjectSearch(ref item, expression))
            {
                if (caricaSoc != null)
                {
                    caricaSoc.PersonaFisica = item as PersonaFisicaFDT;
                    caricaSoc.IdSoggetto = item.IdSoggetto;
                    this.bindingSourceCariche.ResetBindings(false);
                }
                //else
                //{
                //    this.memoEdit2.Text = ((PersonaFisicaFDT)item).DescrizioneBreve;
            }
        }

        private void btnViewSubject_Click(object sender, EventArgs e)
        {
            SoggettoFDT sj = null;
            if (caricaSoc != null)
            {
                if (caricaSoc.PersonaFisica != null)
                {
                    sj = caricaSoc.PersonaFisica;
                }
                else
                {
                    if (caricaSoc.IdSoggetto > 0)
                    {

                        SoggettoFDT ss =
                        GVCSystemEngine.InvokeService<ICooperatives, SoggettoFDT>
                            (delegate()
                        {
                            return GVCSystemEngine.Cooperatives.GetSoggettoById(caricaSoc.IdSoggetto);
                        },
                         true);

                        if (ss is PersonaFisicaFDT)
                        {
                            caricaSoc.PersonaFisica = ss as PersonaFisicaFDT;

                            if (caricaSoc.PersonaFisica != null)
                            {
                                sj = caricaSoc.PersonaFisica;
                            }
                        }
                    }
                    else
                    {
                        ShowInformationMessage("Dettaglio soggetto non trovato", "Non è stato trovato il dettaglio associato al soggetto");
                    }
                }
            }
            if (sj != null)
            {
                OpenViewSubject(sj);
            }
        }

        #endregion Event Handlers
    }
}
