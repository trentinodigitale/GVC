using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.Services;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;

namespace it.dedagroup.GVC.Client.Forms.Vocabolari
{
    public partial class DatiEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {
        public DatiEdit()
        {
            InitializeComponent();
        }

        public void SetBindableData(DatiFDT item)
        {
            this.bindingSourceBaseDizionario.DataSource = item;            
        }

        private void DatiEdit_Shown(object sender, EventArgs e)
        {
            textEdit1.Focus();
        }

        private void textEdit1_Leave(object sender, EventArgs e)
        {
            textEdit2.Focus();
        }
    }
}
