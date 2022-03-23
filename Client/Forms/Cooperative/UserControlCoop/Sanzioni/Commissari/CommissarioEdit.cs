using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.Services;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.Configurations;
using OeF.Utility;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Sanzioni.Commissari
{
    public partial class CommissarioEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {
        #region Instant Variable

        private CompensoFDT itemLocal;

        #endregion

        #region Constructor (1)

        public CommissarioEdit()
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
                lookUpEdit1.Properties.ReadOnly = true;
                textEdit3.Properties.ReadOnly = true;
                dateEdit3.Properties.ReadOnly = true;
                lookUpEdit2.Properties.ReadOnly = true;
                textEdit5.Properties.ReadOnly = true;
                dateEdit1.Properties.ReadOnly = true;
                txtImportoTotale.Properties.ReadOnly = true;
                this.btnViewSubject.Enabled = true;
            }
        }

        #endregion Constructor

        #region Public Methods (3)
        
        public void SetBindableData(ProceduraCoattaFDT itemProcCoatta, CompensoFDT item)
        {
            itemLocal = item;

            this.bindingSourceForcedProcedures.DataSource = itemProcCoatta;
            this.bindingSourceProceduresTypes.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_PROCEDURE_COATTE);
            this.bindingSourceCompensoCommissario.DataSource = itemLocal;
            this.bindingSourceTipoContributo.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_CONTRIBUTO_COMPENSO);

            this.pnlDetailProceduraCoatta.Visible = true;
            this.pnlDetailLiquidazioneCoatta.Visible = false;
        }

        public void SetBindableData(LiquidazioneCoattaFDT itemLiqCoatta, CompensoFDT item)
        {
            itemLocal = item;

            this.bindingSourceForcedLiquidations.DataSource = itemLiqCoatta;
            this.bindingSourceLiquidationsTypes.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_LIQUIDAZIONI_COATTE);
            this.bindingSourceCompensoCommissario.DataSource = itemLocal;
            this.bindingSourceTipoContributo.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_CONTRIBUTO_COMPENSO);

            this.pnlDetailProceduraCoatta.Visible = false;
            this.pnlDetailLiquidazioneCoatta.Visible = true;
        }

        public void SetLiquidazioneCoattaCaption()
        {
            lblCommissarioLiquidazioneCoatta.Visible = true;
            lblCommissarioProceduraCoatta.Visible = false;            
        }

        public void SetProceduraCoattaCaption()
        {
            lblCommissarioLiquidazioneCoatta.Visible = false;
            lblCommissarioProceduraCoatta.Visible = true;            
        }


        #endregion Public Methods (3)

        #region Private Methods (3)

        private void SetImages()
        {
            this.btnSearchCommissario.Image = GVCResourcesUtility.Get_16x16(GVCResources.Businessman_24x24);
            this.btnViewSubject.Image = GVCResourcesUtility.Get_16x16(GVCResources.Businessman_24x24);
            this.btnRemoveSubject.Image = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
            simpleButtonAggiornaImporti.Image = GVCResourcesUtility.Get_16x16(GVCResources.Money2_24x24);
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

        private void CalcolaImporti(Boolean calcolaCassa, Boolean calcolaIVA)
        {
            Double cassa;
            Double compenso;
            Double iva;
            Double spese;
            Double percCNP;
            Double percIVA;

            this.bindingSourceCompensoCommissario.EndEdit();

            spese = itemLocal.ImportoSpese;
            iva = itemLocal.ImportoIVA;
            cassa = itemLocal.ImportoCassa;
            compenso = itemLocal.ImportoCompenso;
            percCNP = itemLocal.PercentualeCNP;
            percIVA = itemLocal.PercentualeIVA;

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

            itemLocal.ImportoSpese = spese;
            itemLocal.ImportoIVA = iva;
            itemLocal.ImportoCassa = cassa;
            itemLocal.ImportoCompenso = compenso;
            itemLocal.PercentualeCNP = percCNP;
            itemLocal.PercentualeIVA = percIVA;

            itemLocal.ImportoTotale = tot;

            this.bindingSourceCompensoCommissario.ResetBindings(false);
        }

        #endregion Private Methods

        #region Event Handler (3)

        private void btnSearchCommissario_Click(object sender, EventArgs e)
        {
            SoggettoFDT item = new PersonaFisicaFDT();

            Expression expression = (FieldName)SearchParameters.ID_TIPO_SOGGETTO == TipiSoggettiSpecifici.Commissari;
            if (OpenSubjectSearch(ref item, expression))
            {
                if (itemLocal != null)
                {
                    itemLocal.Revisore = item as PersonaFisicaFDT;
                    this.textEdit8.Text = itemLocal.Revisore.ToString();
                    this.bindingSourceCompensoCommissario.ResetBindings(false);
                }
                //else
                //{
                //    this.textEdit8.Text = ((PersonaFisicaFDT)item).NomeCompleto;
            }
        }

        private void btnViewSubject_Click(object sender, EventArgs e)
        {
            SoggettoFDT sj = null;
            if (this.itemLocal != null)
            {
                if (itemLocal.Revisore != null)
                {
                    sj = itemLocal.Revisore;
                }
                else
                {
                    if (itemLocal.IdRevisore > 0)
                    {

                        SoggettoFDT ss =
                        GVCSystemEngine.InvokeService<ICooperatives, SoggettoFDT>
                            (delegate()
                        {
                            return GVCSystemEngine.Cooperatives.GetSoggettoById(itemLocal.IdRevisore);
                        },
                         true);

                        if (ss is PersonaFisicaFDT)
                        {
                            itemLocal.Revisore = ss as PersonaFisicaFDT;

                            if (itemLocal.Revisore != null)
                            {
                                sj = itemLocal.Revisore;
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
            OpenNewProcess();
        }

        private void txtImportoCompenso_EditValueChanged(object sender, EventArgs e)
        {
            itemLocal.ImportoCompenso = Convert.ToDouble(txtImportoCompenso.Text);
            CalcolaImporti(false, false);
        }

        private void txtImportoSpese_EditValueChanged(object sender, EventArgs e)
        {
            itemLocal.ImportoSpese = Convert.ToDouble(txtImportoSpese.Text);
            CalcolaImporti(false, false);
        }

        private void txtImportoCassa_EditValueChanged(object sender, EventArgs e)
        {
            itemLocal.ImportoCassa = Convert.ToDouble(txtImportoCassa.Text);
            CalcolaImporti(false, false);
        }

        private void txtImportoIVA_EditValueChanged(object sender, EventArgs e)
        {
            itemLocal.ImportoIVA = Convert.ToDouble(txtImportoIVA.Text);
            CalcolaImporti(false, false);
        }

        private void simpleButtonAggiornaImporti_Click(object sender, EventArgs e)
        {
            CalcolaImporti(true, true);
        }

        private void btnRemoveSubject_Click(object sender, EventArgs e)
        {
            if (itemLocal != null)
            {
                if (itemLocal.Revisore != null)
                {
                    itemLocal.Revisore = null;
                    itemLocal.IdRevisore = -1;

                    this.bindingSourceCompensoCommissario.ResetBindings(false);
                }
            }
        }

        #endregion Event Handler

       


    }
}
