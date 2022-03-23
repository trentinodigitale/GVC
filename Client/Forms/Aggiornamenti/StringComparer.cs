using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;

namespace it.dedagroup.GVC.Client.Forms.Aggiornamenti
{
    public partial class StringComparer : ComparerPattern
    {
        public StringComparer()
        {
            InitializeComponent();
        }

        public override void SetComparables(Object[] actualAttValues, Object[] updatedAttValues)
        {
            if (actualAttValues != null)
                this.memoEdit1.Text = actualAttValues[0].ToString();
            if (updatedAttValues != null)
                this.memoEdit2.Text = updatedAttValues[0].ToString();
        }
    }
}
