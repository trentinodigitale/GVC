using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace it.dedagroup.GVC.Client.Forms.Aggiornamenti
{
    public partial class DateComparer : ComparerPattern
    {
        public DateComparer()
        {
            InitializeComponent();
        }

        public void SetLabels(String labelCaption) 
        {
            this.labelControl1.Text = labelCaption;
            this.labelControl2.Text = labelCaption;
        }

        public override void SetComparables(Object[] actualAttValues, Object[] updatedAttValues)
        {
            if (actualAttValues[0] != null)
            {
                this.txeDataCost1.Text = ((DateTime)actualAttValues[0]).ToShortDateString();
                if (this.txeDataCost1.Text.EndsWith("/1900"))
                    this.txeDataCost1.Text = this.txeDataCost1.Text.Replace("/1900", "");
            }
            if (updatedAttValues[0] != null)
            {
                this.txeDataCost2.Text = ((DateTime)updatedAttValues[0]).ToShortDateString();
                if (this.txeDataCost2.Text.EndsWith("/1900"))
                    this.txeDataCost2.Text = this.txeDataCost2.Text.Replace("/1900", "");
            }
        }

        
    }
}
