using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.Configurations;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Sanzioni.LiquidazioneCoatta
{
    public partial class AcquistoCreditiFiscEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {

        #region Constructor

        public AcquistoCreditiFiscEdit()
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
                dateEdit2.Properties.ReadOnly = true;
            }
        }

        #endregion Constructor
        
        #region Public Methods (3)

        public void SetBindableData(LiquidazioneCoattaFDT itemLiqCoatta, DeliberaAcquistoCreditiFiscFDT item)
        {
            this.bindingSourceForcedLiquidations.DataSource = itemLiqCoatta;
            this.bindingSourceLiquidationsTypes.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_LIQUIDAZIONI_COATTE);
            this.bindingSourceTaxCreditBuy.DataSource = item;
        }

		#endregion Public Methods 

    }
}
