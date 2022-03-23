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
    public partial class DurataSocietaComparer : ComparerPattern
    {
        public DurataSocietaComparer()
        {
            InitializeComponent();
        }

        public override void SetComparables(Object[] actualAttValues, Object[] updatedAttValues)
       {
           if (Convert.ToInt32(actualAttValues[1]) == 0)
           {
               chckDurataIllimitata1.Checked = false;
               tbxDtTermine1.Text = ((DateTime)actualAttValues[0]).ToShortDateString();
           }
           else
           {
               chckDurataIllimitata1.Checked = true;
               tbxDtTermine1.Enabled = false;
           }

           if (Convert.ToInt32(updatedAttValues[1]) == 0)
           {
               chckDurataIllimitata2.Checked = false;
               tbxDtTermine2.Text = ((DateTime)updatedAttValues[0]).ToShortDateString();
           }
           else
           {
               chckDurataIllimitata2.Checked = true;
               tbxDtTermine2.Enabled = false;
           }            
        }
    }
}
