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
    public partial class DebugLogin : DevExpress.XtraEditors.XtraForm
    {


        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginForm"/> class.
        /// </summary>
        public DebugLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds the roles.
        /// </summary>
        /// <param name="roles">The roles.</param>
        public void AddRoles(OeF.Configurations.DictionaryEntryList roles)
        {
            if (roles != null &&
                roles.Count > 0)
            {
                int item = 0;
                foreach (OeF.Configurations.DictionaryEntry role in roles)
                {
                    item++;

                    String controlID = String.Concat("simpleButtonRole", item.ToString());
                    Control[] controls = this.Controls.Find(controlID, true);

                    if (controls != null &&
                        controls.Length > 0)
                    {
                        SimpleButton simpleButton = controls[0] as SimpleButton;
                        if (simpleButton != null)
                        {
                            simpleButton.Text = role.Value.ToString();
                            simpleButton.Tag = role.Key;
                            simpleButton.Visible = true;
                        }
                    }
                }
            }
        }

        #endregion Constructors


        #region Events Handling

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void simpleButtonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SimpleButton sbutton = sender as SimpleButton;
                this.userName = sbutton.Tag.ToString();
            }
            catch
            {
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private String userName;

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>The name of the user.</value>
        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        /// <summary>
        /// Gets the password.
        /// </summary>
        /// <value>The password.</value>
        public String Password
        {
            get
            {
                return "pwd";
            }
        }


        #endregion Events Handling

    }
}