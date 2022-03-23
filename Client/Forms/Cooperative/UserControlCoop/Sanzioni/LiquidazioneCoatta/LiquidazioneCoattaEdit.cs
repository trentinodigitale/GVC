using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Sanzioni.LiquidazioneCoatta
{
    public partial class LiquidazioneCoattaEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {
        public event EventHandler NuovoProcedimento;

        public override bool ReadOnlyControls
        {
            get
            {
                return base.ReadOnlyControls;
            }
            set
            {
                base.ReadOnlyControls = value;

                simpleButtonNewProcess1.Enabled = !value;

                Filter();
            }
        }

        private void Filter()
        {
            if (this.ReadOnlyControls)
            {
                DropDownFilter(gridViewTipoLiquidazione, colAttivo, false);
            }
            else
            {
                DropDownFilter(gridViewTipoLiquidazione, colAttivo, true);
            }
        }

		#region Constructors (1) 

        public LiquidazioneCoattaEdit()
        {
            InitializeComponent();
        }

		#endregion Constructors 

		#region Public Methods (3) 

        public void BindingSourceEndInit()
        {
            this.bindingSourceForcedLiquidations.EndEdit();
        }

        public void BindingSourceResetBindings()
        {
            this.bindingSourceForcedLiquidations.ResetBindings(false);
        }

        public void SetBindableData(LiquidazioneCoattaFDT item, DizionarioFDT[] tipiLiquidazCoatta)
        {
            this.bindingSourceForcedLiquidations.DataSource = item;
            this.bindingSourceLiquidationsTypes.DataSource = tipiLiquidazCoatta;

            if (item != null)
            {
                this.bindingSourceTaxCreditBuy.DataSource = item.DelibereAcquistoCreditiFisc;
            }

            Filter();
        }

		#endregion Public Methods 

        //#region Event Handler (2)

        //private void btnAddTaxCreditBuy_Click(object sender, EventArgs e)
        //{
        //    List<DeliberaAcquistoCreditiFiscFDT> items = null;
        //    if (this.bindingSourceTaxCreditBuy.DataSource != null &&
        //        this.bindingSourceTaxCreditBuy.DataSource.GetType() == typeof(DeliberaAcquistoCreditiFiscFDT[]) &&
        //        this.bindingSourceTaxCreditBuy.DataSource != null)
        //    {
        //        items = new List<DeliberaAcquistoCreditiFiscFDT>(this.bindingSourceTaxCreditBuy.DataSource as DeliberaAcquistoCreditiFiscFDT[]);
        //    }
        //    if (items == null)
        //        items = new List<DeliberaAcquistoCreditiFiscFDT>();
        //    DeliberaAcquistoCreditiFiscFDT item = new DeliberaAcquistoCreditiFiscFDT();
        //    if (OpenForEdit(item) == DialogResult.OK)
        //    {
        //        items.Add(item);
        //    }
        //    this.bindingSourceTaxCreditBuy.DataSource = items.ToArray();
        //}

        //private void gridControlTaxCreditBuy_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    OpenForEdit(this.bindingSourceTaxCreditBuy.Current as DeliberaAcquistoCreditiFiscFDT);
        //}

        //#endregion Event Handler

        //#region Private Methods (1)

        //private DialogResult OpenForEdit(DeliberaAcquistoCreditiFiscFDT item)
        //{
        //    AcquistoCreditiFiscEdit page = CreatePage<AcquistoCreditiFiscEdit>();
        //    if (page != null)
        //    {
        //        page.SetFormTitle("Gestione acquisto crediti fiscali");
        //        page.SetBindableData(item);
        //        return page.BaseForm.ShowDialog(this, this.ReadOnlyControls);
        //    }
        //    else
        //        return DialogResult.None;
        //}

        //#endregion Private Methods 

        void simpleButtonNewProcess1_Click(object sender, EventArgs e)
        {
            //OpenNewProcess();
            EventHandler temp = NuovoProcedimento;
            if (temp != null)
                NuovoProcedimento(null, new EventArgs());
        }
                
    }
}
