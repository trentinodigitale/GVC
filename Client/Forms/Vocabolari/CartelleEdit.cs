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
    public partial class CartelleEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {
        public CartelleEdit()
        {
            InitializeComponent();
        }

        public void SetBindableData(CartellaFDT item)
        {
            this.bindingSourceBaseDizionario.DataSource = item;
        }

        private void CartelleEdit_Shown(object sender, EventArgs e)
        {
            //textEdit2.Focus();
        }
    }
}
