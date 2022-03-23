using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Annotazione
{
    public partial class ScadenziarioEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {
        ScadenziarioFDT itemLocal = null;

		#region Constructors (1) 

        public ScadenziarioEdit()
        {
            InitializeComponent();
        }

		#endregion Constructors 

        #region Public Methods (3)

        public void BindingSourceEndInit()
        {
            this.bindingSourceAnnotazioni.EndEdit();
        }

        public void BindingSourceResetBindings()
        {
            this.bindingSourceAnnotazioni.ResetBindings(false);
        }

        public void SetBindableData(ScadenziarioFDT item, DizionarioFDT[] tipiScadenza)
        {
            if (item != null)
            {
                this.bindingSourceAnnotazioni.DataSource = item;
            }

            itemLocal = item;

            this.bindingSourceTipiAnnotazione.DataSource = tipiScadenza;

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
            }
        }

		#endregion Public Methods

        private void Filter()
        {
            if (this.ReadOnlyControls)
            {
                DropDownFilter(gridViewTipoAnnotazione, colAttivo, false);
            }
            else
            {
                DropDownFilter(gridViewTipoAnnotazione, colAttivo, true);
            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (itemLocal != null)
            {
                this.bindingSourceAnnotazioni.EndEdit();

                if (checkEdit1.Checked)
                {
                    if (!itemLocal.DataEvasione.HasValue)
                        itemLocal.DataEvasione = System.DateTime.Now;
                }
                else
                {
                    if (itemLocal.DataEvasione.HasValue)
                        itemLocal.DataEvasione = null;
                }

                this.bindingSourceAnnotazioni.ResetBindings(false);
            }
        }

    }
}
