using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.Configurations;

namespace it.dedagroup.GVC.Client.Forms.Aggiornamenti
{
    public partial class ActivityComparer : ComparerPattern
    {
        public ActivityComparer()
        {
            InitializeComponent();
        }

        public override void SetComparables(Object[] actualAttValues, Object[] updatedAttValues)
        {
            this.bindingSourceActivityTypes.DataSource =
                GVCSystemEngine.GetDizionarioByType(DictionaryTypes.ATTIVITA);

            if (actualAttValues != null)
                this.bindingSourceBaseCurrentActivitiesParix.DataSource = (AttivitaFDT[])actualAttValues[0];

            if (updatedAttValues != null)
                this.bindingSourceBaseUpdatedActivitiesParix.DataSource = (AttivitaFDT[])updatedAttValues[0];

        }
    }
}
