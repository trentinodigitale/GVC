using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.Services;
using OeF.Utility;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Revisione
{
    public partial class IncaricoRevisioneEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {
        private RevisioneIncaricoFDT itemIncarico;

        public event EventHandler NuovoProcedimento;

        #region Constructors (1)

        public IncaricoRevisioneEdit()
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
                textEditAnnoRevisione.Properties.ReadOnly = true;
                lookUpEdit1.Properties.ReadOnly = true;
                txtImportoTotale.Properties.ReadOnly = true;
                memoEdit1.Properties.ReadOnly = true;
                this.btnViewSubject.Enabled = true;

                simpleButtonNewProcess1.Enabled = !value;
            }
        }

        #endregion Constructors

        #region Event Handlers(7)

        private void txtCNP_EditValueChanged(object sender, EventArgs e)
        {
            //CalcolaImporti(true, false);
        }

        private void txtIVA_EditValueChanged(object sender, EventArgs e)
        {
            //CalcolaImporti(false, true);
        }

        private void simpleButtonNewProcess1_Click(object sender, EventArgs e)
        {
            //OpenNewProcess();
            EventHandler temp = NuovoProcedimento;
            if (temp != null)
                NuovoProcedimento(null, new EventArgs());
        }

        private void txtImportoCompenso_EditValueChanged(object sender, EventArgs e)
        {
            itemIncarico.CompensoRevisore.ImportoCompenso = Convert.ToDouble(txtImportoCompenso.Text);
            CalcolaImporti(false, false);
        }

        private void txtImportoSpese_EditValueChanged(object sender, EventArgs e)
        {
            itemIncarico.CompensoRevisore.ImportoSpese = Convert.ToDouble(txtImportoSpese.Text);
            CalcolaImporti(false, false);
        }

        private void txtImportoCassa_EditValueChanged(object sender, EventArgs e)
        {
            itemIncarico.CompensoRevisore.ImportoCassa = Convert.ToDouble(txtImportoCassa.Text);
            CalcolaImporti(false, false);
        }

        private void txtImportoIVA_EditValueChanged(object sender, EventArgs e)
        {
            itemIncarico.CompensoRevisore.ImportoIVA = Convert.ToDouble(txtImportoIVA.Text);
            CalcolaImporti(false, false);
        }

        private void simpleButtonAggiornaImporti_Click(object sender, EventArgs e)
        {
            CalcolaImporti(true, true);
        }

        private void btnRicercaRevisore_Click(object sender, EventArgs e)
        {
            SoggettoFDT item = null;

            Expression expression = (FieldName)SearchParameters.ID_TIPO_SOGGETTO == TipiSoggettiSpecifici.Revisore |
                                    (FieldName)SearchParameters.ID_TIPO_SOGGETTO == 2;
            if (OpenSubjectSearch(ref item, expression))
            {
                if (itemIncarico != null && itemIncarico.CompensoRevisore != null)
                {
                    itemIncarico.CompensoRevisore.Revisore = item;
                    itemIncarico.CompensoRevisore.IdRevisore = item.IdSoggetto;
                    this.bindingSourceIncarico.ResetBindings(false);
                }
                //else
                //{
                //    this.memoEdit1.Text = ((PersonaGiuridicaFDT)item).DescrizioneBreve;
            }
        }

        #endregion Event Handlers

        #region Private Methods (1)

        private void CalcolaImporti(Boolean calcolaCassa, Boolean calcolaIVA)
        {
            Double cassa;
            Double compenso;
            Double iva;
            Double spese;
            Double percCNP;
            Double percIVA;

            this.bindingSourceIncarico.EndEdit();
            //this.bindingSourceRevisione.EndEdit();

            //itemIncarico.EndEdit();
            //itemIncarico.CompensoRevisore.EndEdit();

            spese = itemIncarico.CompensoRevisore.ImportoSpese;
            iva = itemIncarico.CompensoRevisore.ImportoIVA;
            cassa = itemIncarico.CompensoRevisore.ImportoCassa;
            compenso = itemIncarico.CompensoRevisore.ImportoCompenso;
            percCNP = itemIncarico.CompensoRevisore.PercentualeCNP;
            percIVA = itemIncarico.CompensoRevisore.PercentualeIVA;

            if (calcolaCassa)
            {
                cassa = compenso * percCNP / 100;
            }

            if (calcolaIVA)
            {
                iva = (compenso + cassa) * percIVA / 100;
            }

            Double tot = cassa + compenso + iva + spese;

            //if (tot > 0)
            //    txtImportoTotale.Text = tot.ToString();

            itemIncarico.CompensoRevisore.ImportoSpese = spese;
            itemIncarico.CompensoRevisore.ImportoIVA = iva;
            itemIncarico.CompensoRevisore.ImportoCassa = cassa;
            itemIncarico.CompensoRevisore.ImportoCompenso = compenso;
            itemIncarico.CompensoRevisore.PercentualeCNP = percCNP;
            itemIncarico.CompensoRevisore.PercentualeIVA = percIVA;

            itemIncarico.CompensoRevisore.ImportoTotale = tot;

            this.bindingSourceIncarico.ResetBindings(false);
        }

        private void SetImages()
        {
            btnRicercaRevisore.Image = GVCResourcesUtility.Get_16x16(GVCResources.Businessman_Find_24x24);
            simpleButtonAggiornaImporti.Image = GVCResourcesUtility.Get_16x16(GVCResources.Money2_24x24);
            this.btnViewSubject.Image = GVCResourcesUtility.Get_16x16(GVCResources.Businessman_24x24);
        }

        #endregion Private Methods

        #region Public Methods (3)

        public void SetBindableData(RevisioneFDT revisione, RevisioneIncaricoFDT item, DatiFDT d)
        {
            itemIncarico = item;

            if (itemIncarico != null)
            {
                //if (itemIncarico.IdRevisioneIncarico < 1)
                //{
                //    if (itemIncarico.CompensoRevisore.PercentualeCNP == 0)
                //    {
                //        itemIncarico.CompensoRevisore.PercentualeCNP = d.PercentualeCNP;
                //    }

                //    if (itemIncarico.CompensoRevisore.PercentualeIVA == 0)
                //    {
                //        itemIncarico.CompensoRevisore.PercentualeIVA = d.PercentualeIVA;
                //    }
                //}

                this.bindingSourceIncarico.DataSource = itemIncarico;
            }

             //this.bindingSourceBaseDati.DataSource = d;
            this.bindingSourceRevisione.DataSource = revisione;

            this.bindingSourceTipoRevisione.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_REVISIONE);
            
        }

        public void ResetBindingsBindingSource()
        {
            this.bindingSourceIncarico.ResetBindings(false);
        }

        public void EndInitBindingSource()
        {
            this.bindingSourceIncarico.EndEdit();
        }

        #endregion Public Methods

        private void btnViewSubject_Click(object sender, EventArgs e)
        {
            SoggettoFDT sj = null;
            if (this.itemIncarico != null &&
                itemIncarico.CompensoRevisore != null)
            {
                if (itemIncarico.CompensoRevisore.Revisore != null)
                {
                    sj = itemIncarico.CompensoRevisore.Revisore;
                }
                else
                {
                    if (itemIncarico.CompensoRevisore.IdRevisore > 0)
                    {

                        SoggettoFDT ss =
                        GVCSystemEngine.InvokeService<ICooperatives, SoggettoFDT>
                            (delegate()
                        {
                            return GVCSystemEngine.Cooperatives.GetSoggettoById(itemIncarico.CompensoRevisore.IdRevisore);
                        },
                         true);

                        if (ss is PersonaFisicaFDT)
                        {
                            itemIncarico.CompensoRevisore.Revisore = ss as PersonaFisicaFDT;

                            if (itemIncarico.CompensoRevisore.Revisore != null)
                            {
                                sj = itemIncarico.CompensoRevisore.Revisore;
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
