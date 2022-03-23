using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.Configurations;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Sanzioni.LiquidazioneCoatta
{
    public partial class RelazioneSemestraleEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {
        public RelazioneSemestraleEdit()
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
                dateEdit3.Properties.ReadOnly = true;
            }
        }

        public void SetBindableData(LiquidazioneCoattaFDT itemLiqCoatta, RelazioneSemestraleFDT item)
        {
            this.bindingSourceForcedLiquidations.DataSource = itemLiqCoatta;
            this.bindingSourceLiquidationsTypes.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_LIQUIDAZIONI_COATTE);
            this.bindingSourceRelazioneSemestrale.DataSource = item;
        }
    }
}
