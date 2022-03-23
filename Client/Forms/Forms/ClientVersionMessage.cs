using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace it.dedagroup.GVC.Client.Forms.Forms
{
    /// <summary>
    /// Debug login form
    /// </summary>
    public partial class ClientVersionMessage : DevExpress.XtraEditors.XtraForm
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginForm"/> class.
        /// </summary>
        public ClientVersionMessage(string version)
        {
            InitializeComponent();

            lblVersion.Text = version;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "http://update.GVC.infotn.it/setup.exe";
            System.Diagnostics.Process.Start(url);
            this.Close();
        }
    }
}
