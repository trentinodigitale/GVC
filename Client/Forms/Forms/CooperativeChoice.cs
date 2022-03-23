using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;

namespace it.dedagroup.GVC.Client.Forms.Forms
{
    public partial class CooperativeChoice : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {
        public CooperativeChoice()
        {
            InitializeComponent();

            SetBindableData();

        }

        private void SetBindableData()
        {
            List<CooperativaFDT> l = new List<CooperativaFDT>();

            CooperativaFDT c1 = new CooperativaFDT();
            c1.RegistroCooperativa = new RegistroCooperativaFDT();
            c1.RegistroCooperativa.CodiceCooperativa = 1010;
            c1.Denominazione = "COOPERATIVA MURATORI TRIDENTINI Piccola Società Cooperativa a Responsabilità Limitata - (in L.C.A.)";
            l.Add(c1);


            CooperativaFDT c2 = new CooperativaFDT();
            c2.RegistroCooperativa = new RegistroCooperativaFDT();
            c2.RegistroCooperativa.CodiceCooperativa = 1011;
            c2.Denominazione = "Cooperativa idraulici";
            l.Add(c2);

            this.bindingSourceBaseCooperative.DataSource = l;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            
        }

        private void CooperativeChoice_Shown(object sender, EventArgs e)
        {
            this.gridControlCooperative.Focus();
        }
    }
}
