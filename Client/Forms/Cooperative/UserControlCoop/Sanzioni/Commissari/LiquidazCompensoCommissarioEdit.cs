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

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Sanzioni.Commissari
{
    public partial class LiquidazCompensoCommissarioEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {
        private ProceduraCoattaFDT itemProceduraCoatta;

        public event EventHandler NuovoProcedimento;

        #region Constructors (1)

        public LiquidazCompensoCommissarioEdit()
        {
            InitializeComponent();
        }

        void simpleButtonNewProcess1_Click(object sender, EventArgs e)
        {
            //OpenNewProcess();
            EventHandler temp = NuovoProcedimento;
            if (temp != null)
                NuovoProcedimento(null, new EventArgs());
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
                lookUpEdit2.Properties.ReadOnly = true;
                textEdit5.Properties.ReadOnly = true;
                dateEdit1.Properties.ReadOnly = true;

                simpleButtonNewProcess1.Enabled = !value;
            }
        }

        #endregion Constructors

        #region Public Methods (3)

        public void BindingSourceEndInit()
        {
            this.bindingSourceCommissionerPayment.EndEdit();
        }

        public void BindingSourceResetBindings()
        {
            this.bindingSourceCommissionerPayment.ResetBindings(false);
        }

        public void SetBindableData(ProceduraCoattaFDT itemProcCoatta, CompensoLiquidazioneFDT item, DizionarioFDT[] listaTipiCompensi)
        {
            itemProceduraCoatta = itemProcCoatta;

            if (itemProceduraCoatta != null)
            {
                //Totale importo compensi
                if (item.ImportoDeterminato == 0)
                {
                    item.ImportoDeterminato = CompensoTotaleProceduraCoatta();
                }
            }

            this.bindingSourceForcedProcedures.DataSource = itemProceduraCoatta;
            this.bindingSourceProceduresTypes.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_PROCEDURE_COATTE);
            this.bindingSourceCommissionerPayment.DataSource = item;
            this.bindingSourcePaymentType.DataSource = listaTipiCompensi;
        }

        #endregion Public Methods (3)

        #region Private Methods

        private double CompensoTotaleProceduraCoatta()
        {
            double tot = 0;

            if (itemProceduraCoatta != null)
            {
                if (itemProceduraCoatta.CompensiCommissari != null &&
                    itemProceduraCoatta.CompensiCommissari.Length > 0)
                {
                    foreach (CompensoFDT commissario in itemProceduraCoatta.CompensiCommissari)
                    {
                        if (commissario != null)
                        {
                            double totCommissario = commissario.ImportoCompenso + commissario.ImportoCassa + commissario.ImportoSpese;
                            tot = tot + totCommissario;
                        }
                    }
                }
            }

            return tot;
        }

#endregion Private Methods

    }
}
