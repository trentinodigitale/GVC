using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common;

namespace it.dedagroup.GVC.Client.Forms.Common
{
    public partial class UserControlDialog : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        public override bool ReadOnlyControls
        {
            get
            {
                return base.ReadOnlyControls;
            }
            set
            {
                base.ReadOnlyControls = value;
                this.Cancel.Enabled = true;

                if (value)
                {
                    this.OK.Visible = false;
                }
                else
                {
                    this.OK.Visible = true;
                    this.OK.Enabled = true;
                }
            }
        }

		#region Constructors (1) 

        public UserControlDialog()
        {
            InitializeComponent();

            this.ParentChanged += new EventHandler(UserControlDialog_ParentChanged);
        }

		#endregion Constructors 

		#region Methods (2) 


		// Public Methods (1) 

        public void AddUserControl(UserControlBase ucb)
        {
            if (ucb != null)
            {
                Form f = this.FindForm();
                if (f != null)
                {
                    f.Size = new Size(ucb.Size.Width, ucb.Size.Height + this.PanelButtons.Height + 20);
                    f.MinimumSize = f.Size;
                }

                this.ScrollableContent.Controls.Add(ucb);
                ucb.Dock = DockStyle.Fill;
                ucb.BringToFront();
                
            }
        }



		// Private Methods (1) 

        private void UserControlDialog_ParentChanged(object sender, EventArgs e)
        {
            if (this.ParentForm != null)
            {
                this.ParentForm.AcceptButton = this.OK;
                this.ParentForm.CancelButton = this.Cancel;
            }
        }


		#endregion Methods 

    }
}
