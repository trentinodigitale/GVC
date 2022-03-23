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
    public partial class LeggiTrasgressioneEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {
        public LeggiTrasgressioneEdit()
        {
            InitializeComponent();
        }

        public void SetBindableData(LeggiTrasgressioneFDT item, DizionarioFDT[] listaNature)
        {
            this.bindingSourceBaseNatura.DataSource = listaNature;
            this.bindingSourceBaseDizionario.DataSource = item;
        }
    }
}
