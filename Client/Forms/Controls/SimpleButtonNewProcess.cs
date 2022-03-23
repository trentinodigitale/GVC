using System;
using System.Collections.Generic;

using System.Text;
using it.dedagroup.GVC.Repository.Common;

namespace it.dedagroup.GVC.Client.Forms.Controls
{
    /// <summary>
    /// 
    /// </summary>
    public class SimpleButtonNewProcess : DevExpress.XtraEditors.SimpleButton
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleButton"/> class.
        /// </summary>
        public SimpleButtonNewProcess()
            : base()
        {
            InitializeComponent();

            //this.Click += new EventHandler(SimpleButtonNewProcess_Click);

            this.Image = GVCResourcesUtility.Get_16x16(GVCResources.Contract_24x24);

        
            
        }

        //public event EventHandler OpenNewProcess;

        //void SimpleButtonNewProcess_Click(object sender, EventArgs e)
        //{
        //    EventHandler temp = OpenNewProcess;
        //    if (temp != null)
        //        OpenNewProcess(this, e);
        //}

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SimpleButtonNewProcess
            // 
            this.Size = new System.Drawing.Size(108, 23);
            this.Text = "Procedimento";
            this.ResumeLayout(false);

        }


    }
}
