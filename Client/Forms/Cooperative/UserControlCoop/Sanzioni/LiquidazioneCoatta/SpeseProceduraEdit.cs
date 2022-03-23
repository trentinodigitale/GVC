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

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Sanzioni.LiquidazioneCoatta
{
    public partial class SpeseProceduraEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {
        public event EventHandler NuovoProcedimento;

        public SpeseProceduraEdit()
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
                lookUpEdit1.Properties.ReadOnly = true;
                textEdit3.Properties.ReadOnly = true;
                dateEdit1.Properties.ReadOnly = true;

                simpleButtonNewProcess1.Enabled = !value;
            }
        }

        public void BindingSourceEndInit()
        {
            this.bindingSourceBaseCounterBalanceLiquidation.EndEdit();
        }

        public void BindingSourceResetBindings()
        {
            this.bindingSourceBaseCounterBalanceLiquidation.ResetBindings(false);
        }

        public void SetBindableData(LiquidazioneCoattaFDT itemLiqCoatta, CompensoLiquidazioneFDT item)
        {
            this.bindingSourceForcedLiquidations.DataSource = itemLiqCoatta;
            this.bindingSourceLiquidationsTypes.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_LIQUIDAZIONI_COATTE);
            this.bindingSourceBaseCounterBalanceLiquidation.DataSource = item;            
        }

        private void simpleButtonNewProcess1_Click(object sender, EventArgs e)
        {
            //OpenNewProcess();
            EventHandler temp = NuovoProcedimento;
            if (temp != null)
                NuovoProcedimento(null, new EventArgs());
        }
    }
}
