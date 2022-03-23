using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace it.dedagroup.GVC.Client.Forms.Controls
{
    public partial class ExpandiblePanel : PanelControl
    {
        private Boolean toExpand = false;

        public ExpandiblePanel()
        {
            InitializeComponent();
        }

        

        private void btnExpandCollapse_Click(object sender, EventArgs e)
        {
            if (toExpand)
            {
                this.panelControlFill.Visible = true;
                toExpand = false;
                this.btnExpandCollapse.Text = "Comprimi";
                this.btnExpandCollapse.Image = OeF.OeFResources.Delete_16x16;
            }
            else
            {
                this.panelControlFill.Visible = false;
                toExpand = true;
                this.btnExpandCollapse.Text = "Espandi";
                this.btnExpandCollapse.Image = OeF.OeFResources.Add_16x16;
            }
        }
    }
}
