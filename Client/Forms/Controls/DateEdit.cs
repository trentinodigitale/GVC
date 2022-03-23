using System;
using System.Collections.Generic;

using System.Text;

namespace it.dedagroup.GVC.Client.Forms.Controls
{
    /// <summary>
    /// 
    /// </summary>
    public class DateEdit : OeF.Forms.Controls.DateEdit
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateEdit"/> class.
        /// </summary>
        public DateEdit()
            : base()
        {
            this.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
        }
    }
}
