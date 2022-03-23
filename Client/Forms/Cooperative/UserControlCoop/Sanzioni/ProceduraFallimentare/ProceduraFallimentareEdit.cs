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
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using it.dedagroup.GVC.Repository.Common.Services;
using OeF.Utility;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Sanzioni.ProceduraFallimentare
{
    public partial class ProceduraFallimentareEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {
        ProceduraFallimentareFDT itemLocal;

        #region Constructors (1)
        
        public ProceduraFallimentareEdit()
        {
            InitializeComponent();
            SetImages();
        }

        #endregion Constructors

        #region Event Handlers

        private void simpleButtonNotarySearch_Click(object sender, EventArgs e)
        {
            SoggettoFDT item = new PersonaFisicaFDT();

            Expression expression = (FieldName)SearchParameters.ID_TIPO_SOGGETTO == TipiSoggettiSpecifici.Commissari;
            if (OpenSubjectSearch(ref item, expression))
            {
                if (itemLocal != null)
                {
                    itemLocal.Curatore = item as PersonaFisicaFDT;
                    itemLocal.IdCuratore = item.IdSoggetto;
                    this.bindingSourceProceduraFallimentare.ResetBindings(false);
                }
            }
        }

        private void btnRemoveSubject_Click(object sender, EventArgs e)
        {
            if (itemLocal != null)
            {
                itemLocal.BeginEdit();

                itemLocal.Curatore = null;
                itemLocal.IdCuratore = -1;

                itemLocal.EndEdit();

                this.bindingSourceProceduraFallimentare.ResetBindings(false);
            }
        }

        private void btnViewSubject_Click(object sender, EventArgs e)
        {
            SoggettoFDT sj = null;
            if (this.itemLocal != null)
            {
                if (itemLocal.Curatore != null)
                {
                    sj = itemLocal.Curatore;
                }
                else
                {
                    if (itemLocal.IdCuratore > 0)
                    {

                        SoggettoFDT ss =
                        GVCSystemEngine.InvokeService<ICooperatives, SoggettoFDT>
                            (delegate()
                        {
                            return GVCSystemEngine.Cooperatives.GetSoggettoById(itemLocal.IdCuratore);
                        },
                         true);

                        if (ss is PersonaFisicaFDT)
                        {
                            itemLocal.Curatore = ss as PersonaFisicaFDT;

                            if (itemLocal.Curatore != null)
                            {
                                sj = itemLocal.Curatore;
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

        #endregion Event Handlers

        #region Private Methods (1)

        private void SetImages()
        {
            this.simpleButtonNotarySearch.Image = GVCResourcesUtility.Get_16x16(GVCResources.Businessman_24x24);
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

        #region Public Methods

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
            }
        }

        public void SetBindableData(ProceduraFallimentareFDT item, DizionarioFDT[] listTipi)
        {
            itemLocal = item;

            this.bindingSourceProceduraFallimentare.DataSource = itemLocal;
            
            this.bindingSourceTipiStato.DataSource = listTipi;
        }

        #endregion Public Methods
    }
}
