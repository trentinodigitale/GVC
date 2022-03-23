using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Revisione
{
    public partial class IncaricoLiquidazioneDetail : it.dedagroup.GVC.Client.Forms.Common.UserControlSplitContainer
    {
        public event EventHandler NuovoProcedimento;

        DizionarioFDT dettCadenzaRev;

        public IncaricoLiquidazioneDetail()
        {
            InitializeComponent();

            incaricoDetail1.NuovoProcedimento += new EventHandler(incaricoDetail1_NuovoProcedimento);
            compensoRevisoreDetail1.NuovoProcedimento += new EventHandler(incaricoDetail1_NuovoProcedimento);
        }

        void incaricoDetail1_NuovoProcedimento(object sender, EventArgs e)
        {
            EventHandler temp = NuovoProcedimento;
            if (temp != null)
                NuovoProcedimento(null, new EventArgs());
        }

        public void ResetBindings()
        {
            incaricoDetail1.ResetBindings();
            compensoRevisoreDetail1.ResetBindings();
        }

        public void SetBindableData(CooperativaFDT itemCoop, 
                                    RevisioneFDT revisione,
                                    DizionarioFDT[] listaEsitiRevisioni,
                                    it.dedagroup.GVC.Repository.Common.FDT.Dictionaries.DatiFDT dati,
                                    DizionarioFDT dettCadenzaRev)
        {
            if (incaricoDetail1 != null)
            {
                incaricoDetail1.SetBindableData(itemCoop, revisione, listaEsitiRevisioni, dati, dettCadenzaRev);
            }
            if (compensoRevisoreDetail1 != null)
            {
                compensoRevisoreDetail1.SetBindableData(revisione, dati);
            }
        }
    }
}
