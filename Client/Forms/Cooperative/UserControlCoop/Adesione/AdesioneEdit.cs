using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.Services;
using it.dedagroup.GVC.Repository.Common.Configurations;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Adesione
{
    public partial class AdesioneEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {
        AdesioneFDT adesione = null;

		#region Constructors (1) 

        public AdesioneEdit()
        {
            InitializeComponent();
            
            SetImages();
        }

		#endregion Constructors 

        #region Event Handlers

        private void btnSearchAssociation_Click(object sender, EventArgs e)
        {
            SoggettoFDT item = new PersonaGiuridicaFDT();

            OeF.Utility.Expression expression = (OeF.Utility.FieldName)SearchParameters.ASSOCIAZIONE == 1;
            if (OpenSubjectSearch(ref item, expression))
            {
                if (adesione != null)
                {
                    adesione.Associazione = item as PersonaGiuridicaFDT;
                    adesione.IdAssociazione = item.IdSoggetto;
                    this.bindingSourceBaseAdesione.ResetBindings(false);
                }
                //else
                //{
                //    this.memoEdit2.Text = ((PersonaGiuridicaFDT)item).DescrizioneBreve;
            }
        }

        #endregion Event Handlers

        #region Private Methods (1)

        private void SetImages()
        {
            this.btnSearchAssociation.Image = GVCResourcesUtility.Get_16x16(GVCResources.Businessman_Find_24x24);
            this.btnViewSubject.Image = GVCResourcesUtility.Get_16x16(GVCResources.Businessman_24x24);
        }

        #endregion Private Methods
        
        #region Public Methods (3)

        public void BindingSourceEndInit()
        {
            this.bindingSourceBaseAdesione.EndEdit();
        }

        public void BindingSourceResetBindings()
        {
            this.bindingSourceBaseAdesione.ResetBindings(false);
        }

        public void SetBindableData(AdesioneFDT item)
        {
            if (item != null)
            {
                adesione = item;
                this.bindingSourceBaseAdesione.DataSource = adesione;
            }
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
            }
        }
		#endregion Public Methods 

        private void btnViewSubject_Click(object sender, EventArgs e)
        {
            SoggettoFDT sj = null;
            if (this.adesione != null)
            {
                if (adesione.Associazione != null)
                {
                    sj = adesione.Associazione;
                }
                else
                {
                    if (adesione.IdAssociazione > 0)
                    {
                        SoggettoFDT ss =
                        GVCSystemEngine.InvokeService<ICooperatives, SoggettoFDT>
                            (delegate()
                        {
                            return GVCSystemEngine.Cooperatives.GetSoggettoById(adesione.IdAssociazione);
                        },
                         true);

                        if (ss is PersonaGiuridicaFDT)
                        {
                            adesione.Associazione = ss as PersonaGiuridicaFDT;

                            if (adesione.Associazione != null)
                            {
                                sj = adesione.Associazione;
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
