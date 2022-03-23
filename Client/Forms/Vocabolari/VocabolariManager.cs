using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace it.dedagroup.GVC.Client.Forms.Vocabolari
{
    public partial class VocabolariManager : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        public VocabolariManager()
        {
            InitializeComponent();
        }

        private void VocabolariManager_Load(object sender, EventArgs e)
        {
            SetFormTitle("Gestione vocabolari");
        }
    }
}
