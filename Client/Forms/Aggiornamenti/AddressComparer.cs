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
    public partial class AddressComparer : ComparerPattern
    {
        public AddressComparer()
        {
            InitializeComponent();
        }

        public override void SetComparables(Object[] actualAttValues, Object[] updatedAttValues) 
        {
            if (actualAttValues != null) 
            {
                IndirizzoFDT[] addresses = (IndirizzoFDT[])actualAttValues[0];
                for (int i = 0; i < addresses.Length; i++) 
                {
                    if (addresses[i].Sede)
                    {
                        addressInfo1.SetAddress(addresses[i]);
                        break;
                    }
                }
            }
            if (updatedAttValues != null)
            {
                IndirizzoFDT[] addresses = (IndirizzoFDT[])updatedAttValues[0];
                for (int i = 0; i < addresses.Length; i++)
                {
                    if (addresses[i].Sede)
                    {
                        addressInfo2.SetAddress(addresses[i]);
                        break;
                    }
                }
            }
        }
    }
}
