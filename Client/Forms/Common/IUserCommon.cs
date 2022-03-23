using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Client.Forms.Common
{
    public interface IUserCommon
    {
        DevExpress.XtraBars.BarManager GetBarManager();

        Boolean ReadOnlyControls
        {
            get;
            set;
        }
    }
}
