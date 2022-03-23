using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace it.dedagroup.GVC.Client.Forms.Forms
{
    public partial class Login : OeF.Forms.LoginForm
    {

		#region Event Handlers (1) 

        private void Login_Load(object sender, EventArgs e)
        {
            Culture.Visible = false;
        }

		#endregion Event Handlers 

		#region Constructors (1) 

        public Login()
        {
            InitializeComponent();
        }

		#endregion Constructors 

    }
}

