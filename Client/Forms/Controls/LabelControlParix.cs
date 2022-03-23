using System;
using System.Collections.Generic;

using System.Text;

namespace it.dedagroup.GVC.Client.Forms.Controls
{
    /// <summary>
    /// 
    /// </summary>
    public class LabelControlParix : DevExpress.XtraEditors.LabelControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LabelControl"/> class.
        /// </summary>
        public LabelControlParix()
            : base()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // LabelControlParix
            // 
            this.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.Appearance.Options.UseForeColor = true;
            this.ResumeLayout(false);

        }
    }
}
