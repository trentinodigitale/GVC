using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;

namespace it.dedagroup.GVC.Client.Forms.Vocabolari
{
    public partial class NumeroSociEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {
        public NumeroSociEdit()
        {
            InitializeComponent();
        }

        public void SetBindableData(ControlloNumeroSociFDT item, string formTitle, string parentTitle)
        {
            lblTitle.Text = formTitle;
            lblParent.Text = parentTitle;         

            this.bindingSourceBaseNumeroSoci.DataSource = item;
        }
    }
}
