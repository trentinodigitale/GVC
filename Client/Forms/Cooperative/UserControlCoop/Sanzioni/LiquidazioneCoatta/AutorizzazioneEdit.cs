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
    public partial class AutorizzazioneEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {
        public event EventHandler NuovoProcedimento;

        public AutorizzazioneEdit()
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
                lookUpEdit2.Properties.ReadOnly = true;
                textEdit3.Properties.ReadOnly = true;
                dateEdit1.Properties.ReadOnly = true;

                simpleButtonNewProcess1.Enabled = !value;
            }
        }

        void simpleButtonNewProcess1_Click(object sender, EventArgs e)
        {
            //OpenNewProcess();
            EventHandler temp = NuovoProcedimento;
            if (temp != null)
                NuovoProcedimento(null, new EventArgs());
        }

        public void BindingSourceEndInit()
        {
            this.bindingSourceAuthorizations.EndEdit();
        }

        public void BindingSourceResetBindings()
        {
            this.bindingSourceAuthorizations.ResetBindings(false);
        }

        public void SetBindableData(LiquidazioneCoattaFDT itemLiqCoatta, AutorizzazioneFDT item, DizionarioFDT[] tipiAutorizzazione)
        {

            this.bindingSourceForcedLiquidations.DataSource = itemLiqCoatta;
            this.bindingSourceLiquidationsTypes.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_LIQUIDAZIONI_COATTE);
            this.bindingSourceAuthorizations.DataSource = item;
            this.bindingSourceAuthorizationType.DataSource = tipiAutorizzazione;

            if (!string.IsNullOrEmpty(item.DescrizioneDatoStorico))
            {
                lblDescrizioneDatoStorico.Visible = true;
            }
            else
            {
                lblDescrizioneDatoStorico.Visible = false;
            }
        }

        
    }
}
