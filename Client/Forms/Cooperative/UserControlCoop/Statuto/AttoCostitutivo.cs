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
using OeF.Utility;
using it.dedagroup.GVC.Repository.Common.Configurations;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Statuto
{
    public partial class AttoCostitutivo : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        private CooperativaFDT itemLocal = null;

        public override bool ReadOnlyControls
        {
            get
            {
                return base.ReadOnlyControls;
            }
            set
            {
                base.ReadOnlyControls = value;
                this.btnViewSubject.Enabled = true;
                this.textEdit6.Enabled = false;
            }
        }

        public AttoCostitutivo()
        {
            InitializeComponent();

            if (!this.DesignMode)
                SetImages();
        }

        private void SetImages()
        {
            this.btnSearchNotary.Image = GVCResourcesUtility.Get_16x16(GVCResources.Businessman_24x24);
            this.btnViewSubject.Image = GVCResourcesUtility.Get_16x16(GVCResources.Businessman_24x24);
            this.btnRemoveSubject.Image = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
        }

        public void SetBindableData(CooperativaFDT item)
        {
            itemLocal = item;

            this.bindingSourceBaseCooperativa.DataSource = itemLocal;
            this.bindingSourceBaseCooperativa.ResetBindings(false);
        }

       

        private void btnSearchNotary_Click(object sender, EventArgs e)
        {
            SoggettoFDT item = new PersonaFisicaFDT();

            Expression expression = (FieldName)SearchParameters.ID_TIPO_SOGGETTO == TipiSoggettiSpecifici.Notaio;
            if (OpenSubjectSearch(ref item, expression))
            {
                if (itemLocal != null && itemLocal.RegistroCooperativa != null)
                {
                    itemLocal.RegistroCooperativa.Notaio = item as PersonaFisicaFDT;
                    itemLocal.RegistroCooperativa.IdNotaio = item.IdSoggetto;
                    this.bindingSourceBaseCooperativa.ResetBindings(false);
                }
            }
        }

        private void btnViewSubject_Click(object sender, EventArgs e)
        {
            SoggettoFDT sj = null;
            if (this.itemLocal != null &&
                itemLocal.RegistroCooperativa != null)
            {
                if (itemLocal.RegistroCooperativa.Notaio != null)
                {
                    sj = itemLocal.RegistroCooperativa.Notaio;
                }
                else
                {
                    if (itemLocal.RegistroCooperativa.IdNotaio > 0)
                    {
                        
                            SoggettoFDT ss = 
                            GVCSystemEngine.InvokeService<ICooperatives, SoggettoFDT>
                                (delegate() { 
                                    return GVCSystemEngine.Cooperatives.GetSoggettoById(itemLocal.RegistroCooperativa.IdNotaio); 
                                },
                             true);

                            if (ss is PersonaFisicaFDT)
                            {
                                itemLocal.RegistroCooperativa.Notaio = ss as PersonaFisicaFDT;

                                if (itemLocal.RegistroCooperativa.Notaio != null)
                                {
                                    sj = itemLocal.RegistroCooperativa.Notaio;
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

        private void btnRemoveSubject_Click(object sender, EventArgs e)
        {

            if (itemLocal != null)
            {
                if (itemLocal.RegistroCooperativa != null)
                {
                    itemLocal.RegistroCooperativa.BeginEdit();

                    itemLocal.RegistroCooperativa.Notaio = null;
                    itemLocal.RegistroCooperativa.IdNotaio = -1;

                    itemLocal.RegistroCooperativa.EndEdit();

                    this.bindingSourceBaseCooperativa.ResetBindings(false);
                }
            }
        }

    }
}
