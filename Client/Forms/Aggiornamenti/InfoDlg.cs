using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace it.dedagroup.GVC.Client.Forms.Aggiornamenti
{
    public partial class InfoDlg : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    { 
        public InfoDlg()
        {
            InitializeComponent();
        }

        public void SetMessage(String message) {
            txaMessage.Text = message;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.BaseForm.Close();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnOk_Click(this, null);
                return true;
            }
            else
                return base.ProcessDialogKey(keyData);
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
                this.btnOk.Enabled = true;
            }
        }
    }
}
