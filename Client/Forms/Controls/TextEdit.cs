using System;
using System.Collections.Generic;

using System.Text;

namespace it.dedagroup.GVC.Client.Forms.Controls
{
    /// <summary>
    /// 
    /// </summary>
    public class TextEdit : DevExpress.XtraEditors.TextEdit
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextEdit"/> class.
        /// </summary>
        public TextEdit()
            : base()
        {
            this.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.TextEdit_Properties_Spin);
        }

        private void TextEdit_Properties_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
            if (this.Parent != null && this.Parent.Parent != null && this.Parent.Parent.Parent != null
                && this.Parent.Parent.Parent is DevExpress.XtraEditors.XtraScrollableControl)
            {
                this.Parent.Parent.Parent.Focus();
            }
            else if (this.Parent != null && this.Parent.Parent != null && this.Parent.Parent is DevExpress.XtraEditors.XtraScrollableControl)
            {
                this.Parent.Parent.Focus();
            }
            else if (this.Parent != null)
            {
                this.Parent.Focus();
            }
        }
    }
}
