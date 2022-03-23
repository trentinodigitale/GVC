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

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Procedimento
{
    public partial class ProcedimentoEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {
        ProcedimentoFDT ItemLocal = null;

        #region Constructors (1)
        
        public ProcedimentoEdit()
        {
            InitializeComponent();
            SetImages();
        }

        #endregion Constructors

        #region Public Methods

        public void SetBindableData(ProcedimentoFDT ItemProc,
                                    DizionarioFDT[] listaConclusioni,
                                    DizionarioFDT[] listaIniziative,
                                    DizionarioFDT[] listaProcedimenti,
                                    DizionarioFDT[] listaSospensioni)
        {

            

            this.bindingSourceTipiConclusioni.DataSource = listaConclusioni;
            this.bindingSourceTipiIniziative.DataSource = listaIniziative;
            this.bindingSourceTipiProcedimenti.DataSource = listaProcedimenti;
            this.bindingSourceTipiSospensioni.DataSource = listaSospensioni;

            ItemLocal = ItemProc;
            this.bindingSourceProcedimenti.DataSource = ItemProc;

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

                this.memoEditNoteTipo.Properties.ReadOnly = true;
            }
        }

        #endregion Public Methods

        #region Private Methods

        private void SetImages()
        {
            this.simpleButtonAggiornadataFine.Image = GVCResourcesUtility.Get_16x16(GVCResources.Calendar_24x24);
        }

        private void AggiornamentoDataFine()
        {
            int gg = 0;

            this.bindingSourceProcedimenti.EndEdit();

            if (ItemLocal.Tempi > 0)
            {
                gg = ItemLocal.Tempi;
            }

            //!ItemLocal.DataFineTeorica.HasValue &&
            if (ItemLocal.DataInizioProcedimento.HasValue
                && gg > 0)
            {
                ItemLocal.DataFineTeorica = ItemLocal.DataInizioProcedimento.Value.AddDays(Convert.ToDouble(gg));
            }

            this.bindingSourceProcedimenti.ResetBindings(false);
        }

        private void AggiornamentoDataTermine()
        {
            int gg = 0;

            this.bindingSourceProcedimenti.EndEdit();

            if (ItemLocal.GiorniSospensione > 0)
            {
                gg = ItemLocal.GiorniSospensione;
            }

            if (ItemLocal.DataFineTeorica.HasValue)
            {
                ItemLocal.DataTermineFinale = ItemLocal.DataFineTeorica.Value.AddDays(Convert.ToDouble(gg));
            }

            this.bindingSourceProcedimenti.ResetBindings(false);
        }

        #endregion Private Methods

        #region Event Handler

        private void Filter()
        {
            if (this.ReadOnlyControls)
            {
                DropDownFilter(gridViewTipoProcedimento, colAttivo, false);
                DropDownFilter(gridViewTipoIniziativa, colAttivo, false);
                DropDownFilter(gridViewTipoSospensione, colAttivo, false);
                DropDownFilter(gridViewTipoConclusione, colAttivo, false);
            }
            else
            {
                DropDownFilter(gridViewTipoProcedimento, colAttivo, true);
                DropDownFilter(gridViewTipoIniziativa, colAttivo, true);
                DropDownFilter(gridViewTipoSospensione, colAttivo, true);
                DropDownFilter(gridViewTipoConclusione, colAttivo, true);
            }
        }

        private void AggionrnaDatiTipoProcedura()
        {
            if (this.gridLookUpEditTipoProc.EditValue is int)
            {
                Dizionari items = new Dizionari();
                items.AddRange(this.bindingSourceTipiProcedimenti.DataSource);
                DizionarioFDT tipoSelezionato = items.FindByID(Convert.ToInt32(this.gridLookUpEditTipoProc.EditValue));

                if (tipoSelezionato != null &&
                    tipoSelezionato.IdElemento > 0)
                {
                    this.bindingSourceProcedimenti.EndEdit();

                    ItemLocal.NoteTipologia = tipoSelezionato.Dettaglio.Note;

                    //if (ItemLocal.Tempi)
                    //{
                    if (tipoSelezionato.Dettaglio.Tempi.HasValue)
                    {
                        ItemLocal.Tempi = tipoSelezionato.Dettaglio.Tempi.Value;
                    }
                    //}

                    ItemLocal.IdTipoProcedimento = tipoSelezionato.IdElemento;

                    this.bindingSourceProcedimenti.ResetBindings(false);
                }
            }
        }

        //private void gridLookUpEditTipoProc_EditValueChanged(object sender, EventArgs e)
        //{
        //    AggionrnaDatiTipoProcedura();
            //if (this.gridLookUpEditTipoProc.EditValue is int)
            //{
            //    Dizionari items = new Dizionari();
            //    items.AddRange(this.bindingSourceTipiProcedimenti.DataSource);
            //    DizionarioFDT tipoSelezionato = items.FindByID(Convert.ToInt32(this.gridLookUpEditTipoProc.EditValue));

            //    if (tipoSelezionato != null &&
            //        tipoSelezionato.IdElemento > 0)
            //    {
            //        this.bindingSourceProcedimenti.EndEdit();

            //        ItemLocal.NoteTipologia = tipoSelezionato.Dettaglio.Note;

            //        if (ItemLocal.Tempi <= 0)
            //        {
            //            ItemLocal.Tempi = tipoSelezionato.Dettaglio.Tempi;
            //        }

            //        ItemLocal.IdTipoProcedimento = tipoSelezionato.IdElemento;

            //        this.bindingSourceProcedimenti.ResetBindings(false);
            //    }
            //}
        //}

        private void textEditTempiProc_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textEditTempiProc.Text))
            {
                Int32 nr;
                if (Int32.TryParse(textEditTempiProc.Text, out nr))
                {
                    ItemLocal.Tempi = nr;
                    AggiornamentoDataFine();
                }
            }
        }

        private void dateEdit6_Leave(object sender, EventArgs e)
        {
            //Data inizio
            if (!String.IsNullOrEmpty(dateEdit6.Text))
            {
                ItemLocal.DataInizioProcedimento = dateEdit6.DateTime;
                AggiornamentoDataFine();
            }
        }

        private void gridLookUpEditTipoProc_Leave(object sender, EventArgs e)
        {
            AggionrnaDatiTipoProcedura();
            AggiornamentoDataFine();
        }

        private void simpleButtonAggiornadataFine_Click(object sender, EventArgs e)
        {
            AggiornamentoDataTermine();
        }

        #endregion Event Handler
    }
}
