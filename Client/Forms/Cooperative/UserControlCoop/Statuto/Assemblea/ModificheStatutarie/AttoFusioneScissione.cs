using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.Services;
using OeF.Utility;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Statuto.Assemblea.ModificheStatutarie
{
    public partial class AttoFusioneScissione : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        #region Instance Variables (1)
        
        private ModificaStatutariaFDT itemLocal = null;

        #endregion Instance Variables

        #region Constructors (2)

        public AttoFusioneScissione()
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
                lookUpEditStato.Properties.ReadOnly = true;
                this.btnViewSubject.Enabled = true;
            }
        }

        #endregion Constructors

        #region Event Handlers

        private void btnSearchNotary_Click(object sender, EventArgs e)
        {
            SoggettoFDT item = new PersonaFisicaFDT();

            Expression expression = (FieldName)SearchParameters.ID_TIPO_SOGGETTO == TipiSoggettiSpecifici.Notaio;
            if (OpenSubjectSearch(ref item, expression))
            {
                if (itemLocal != null)
                {
                    itemLocal.Notaio = item as PersonaFisicaFDT;
                    itemLocal.IdNotaio = item.IdSoggetto;
                    this.bindingSourceBaseModificaStatutaria.ResetBindings(false);
                }
                //else
                //{
                //    this.textEdit6.Text = ((PersonaFisicaFDT)item).DescrizioneBreve;
            }
        }

        private void btnViewSubject_Click(object sender, EventArgs e)
        {
            SoggettoFDT sj = null;
            if (this.itemLocal != null)
            {
                if (itemLocal.Notaio != null)
                {
                    sj = itemLocal.Notaio;
                }
                else
                {
                    if (itemLocal.IdNotaio > 0)
                    {

                        SoggettoFDT ss =
                        GVCSystemEngine.InvokeService<ICooperatives, SoggettoFDT>
                            (delegate()
                            {
                                return GVCSystemEngine.Cooperatives.GetSoggettoById(itemLocal.IdNotaio);
                            },
                         true);

                        if (ss is PersonaFisicaFDT)
                        {
                            itemLocal.Notaio = ss as PersonaFisicaFDT;

                            if (itemLocal.Notaio != null)
                            {
                                sj = itemLocal.Notaio;
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

        private void btnRemoveSubject_Click(object sender, EventArgs e)
        {
            if (itemLocal != null)
            {
                itemLocal.BeginEdit();

                itemLocal.Notaio = null;
                itemLocal.IdNotaio = -1;

                itemLocal.EndEdit();

                this.bindingSourceBaseModificaStatutaria.ResetBindings(false);
            }
        }

        #endregion Event Handlers

        #region Public Methods

        public void SetBindableData(ModificaStatutariaFDT item)
        {
            if (item != null)
            {
                itemLocal = item;
                this.bindingSourceBaseModificaStatutaria.DataSource = itemLocal;
            }
            this.bindingSourceBaseStato.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.STATI_ISCRIZIONE);
        }

        #endregion Public Methods

        #region Private Methods

        private void SetImages()
        {
            this.btnSearchNotary.Image = GVCResourcesUtility.Get_16x16(GVCResources.Businessman_Find_24x24);
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

        #endregion Private Methods

    }
}
