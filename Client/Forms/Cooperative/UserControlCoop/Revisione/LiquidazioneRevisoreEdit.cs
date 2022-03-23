using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using it.dedagroup.GVC.Repository.Common.Configurations;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Revisione
{
    public partial class LiquidazioneRevisoreEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {
        CompensoLiquidazioneFDT itemLiquidazione;
        RevisioneFDT itemRev;
        Boolean RevisioneOrdinaria = true;
        double totCompensi = 0;

        public event EventHandler NuovoProcedimento;

        #region Constructors (1)

        public LiquidazioneRevisoreEdit()
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
                textEditAnnoRevisione.Properties.ReadOnly = true;
                lookUpEdit1.Properties.ReadOnly = true;

                simpleButtonNewProcess1.Enabled = !value;
            }
        }

        #endregion Constructors

        #region Event Handlers (3)

        void simpleButtonNewProcess1_Click(object sender, EventArgs e)
        {
            //OpenNewProcess();
            EventHandler temp = NuovoProcedimento;
            if (temp != null)
                NuovoProcedimento(null, new EventArgs());
        }

        //private void checkEditLiquidated_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkEditLiquidated.Checked)
        //    {
        //        this.panelControlMandato.Visible = true;
        //    }
        //    else
        //    {
        //        this.panelControlMandato.Visible = false;
        //    }
        //}

        private void txtPercentualePAT_EditValueChanged(object sender, EventArgs e)
        {
            //CalcolaImporti();
        }

        private void ImportoDeterminato_EditValueChanged(object sender, EventArgs e)
        {
            //CalcolaImporti();
        }

        private void ImportoRichiesto_EditValueChanged(object sender, EventArgs e)
        {
            //CalcolaImporti();
        }

        private void ImportoErogato_EditValueChanged(object sender, EventArgs e)
        {
            //CalcolaImporti();
        }

        #endregion Event Handlers

        #region Public Methods (3)

        public void BindingSourceEndInit()
        {
            this.bindingSourceBaseLiquidazionecompensi.EndEdit();
        }

        public void BindingSourceResetBindings()
        {
            this.bindingSourceBaseLiquidazionecompensi.ResetBindings(false);
        }

        public void SetBindableData(RevisioneFDT rev, CompensoLiquidazioneFDT item, DatiFDT d)
        {
            itemRev = rev;
            itemLiquidazione = item;

            if (itemRev != null)
            {
                //Totale importo compensi
                totCompensi = CompensoTotaleRevisone();

                //Tipo revisione
                RevisioneOrdinaria = itemRev.IdTipoRevisione != TipoRevisione.STRAORDINARIA;

                if (RevisioneOrdinaria)
                {
                    //Revisione Ordinaria
                }
                else
                {
                    //Revisione Straordinaria
                    VisibilitaPercContributo(false);
                    VisibilitaImportoRich(false);
                    labelIVA.Visible = false;
                }

                this.bindingSourceRevisione.DataSource = itemRev;
            }
            
            if (itemLiquidazione != null)
            {
                if (itemLiquidazione.IdCompensoLiquidazione < 1)
                {
                    if (itemLiquidazione.PercentualeContributoPAT == 0)
                    {
                        itemLiquidazione.PercentualeContributoPAT = d.PercentualePAT;
                    }

                    if (itemLiquidazione.ImportoDeterminato == 0)
                    {
                        itemLiquidazione.ImportoDeterminato = totCompensi;
                    }
                }

                this.bindingSourceBaseLiquidazionecompensi.DataSource = itemLiquidazione;
                this.bindingSourceBaseLiquidazionecompensi.ResetBindings(false);
            }

            this.bindingSourceTipoRevisione.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_REVISIONE);
        }

        #endregion Public Methods

        #region Private Methods

        private void VisibilitaPercContributo(Boolean visibile)
        {
            this.txtPercentualePAT.Properties.ReadOnly = !visibile;
        }

        private void VisibilitaImportoRich(Boolean visibile)
        {
            this.ImportoRichiesto.Properties.ReadOnly = !visibile;
        }

        private double CompensoTotaleRevisone()
        {
            double tot = 0;

            if (itemRev != null)
            {
                if (itemRev.RevisioniIncarichi != null &&
                    itemRev.RevisioniIncarichi.Length > 0)
                {
                    foreach (RevisioneIncaricoFDT incarico in itemRev.RevisioniIncarichi)
                    {
                        if (incarico.CompensoRevisore != null)
                        {
                            double totRevisore = incarico.CompensoRevisore.ImportoCompenso + incarico.CompensoRevisore.ImportoCassa + incarico.CompensoRevisore.ImportoSpese;
                            tot = tot + totRevisore;
                        }
                    }
                }
            }

            return tot;
        }

        private void CalcolaImporti()
        {
            double percPAT;
            double impDet;
            double impRich;
            double impErogato;

            this.bindingSourceBaseLiquidazionecompensi.EndEdit();

            percPAT = itemLiquidazione.PercentualeContributoPAT;
            impDet = itemLiquidazione.ImportoDeterminato;
            impErogato = itemLiquidazione.ImportoErogato;
            impRich = itemLiquidazione.ImportoRichiesto;

            if (RevisioneOrdinaria)
            {
                if (impDet == 0)
                {
                    impDet = totCompensi * percPAT / 100;
                }

                if (impErogato == 0)
                {
                    if (impDet < impRich)
                    {
                        impErogato = impDet;
                    }
                    else
                    {
                        impErogato = impRich;
                    }
                }
            }
            else
            {
                if (impDet == 0)
                {
                    impDet = totCompensi;
                }

                if (impErogato == 0)
                {
                    impErogato = impDet;
                }
            }

            itemLiquidazione.PercentualeContributoPAT = percPAT;
            itemLiquidazione.ImportoDeterminato = impDet;
            itemLiquidazione.ImportoErogato = impErogato;
            itemLiquidazione.ImportoRichiesto = impRich;

            this.bindingSourceBaseLiquidazionecompensi.ResetBindings(false);
        }

        #endregion Private Methods

    }
}
