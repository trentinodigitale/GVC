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

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Data
{
    public partial class RicercaAttivita : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        public RicercaAttivita()
        {
            InitializeComponent();

            if (!DesignMode)
            {
                EnableControlAutoSize(new object[] { this, gridControlAttivita }, gridControlAttivita, 50);
            }
        }

        internal void SetBindableData()
        {
            this.bindingSourceBaseTipoAttivita.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.ATTIVITA);
           // this.bindingSourceBaseAttività.DataSource = item;
        }

        private void Filtro_EditValueChanged(object sender, EventArgs e)
        {
            string s = (Filtro.EditValue != null) ? Filtro.EditValue.ToString() : string.Empty;
            ApplyFilter(s);
        }

        internal DizionarioFDT GetSelectedItem()
        {
            return this.bindingSourceBaseTipoAttivita.Current as DizionarioFDT;
        }

        private void ApplyFilter(string filter)
        {
            string cond = string.Empty;

            if (!String.IsNullOrEmpty(filter))
            {
                cond = string.Format("[{0}] LIKE '%{1}%'",
                                               colCodiceEdescrizione.FieldName,
                                               filter);
            }

            if (!String.IsNullOrEmpty(cond))
            {
                this.gridViewAttivita.ActiveFilterEnabled = true;
                this.gridViewAttivita.ActiveFilterString = cond;

            }
            else
            {
                this.gridViewAttivita.ActiveFilterEnabled = false;
                this.gridViewAttivita.ActiveFilterString = string.Empty;
            }
        }

        private void RicercaAttivita_Shown(object sender, EventArgs e)
        {
            Filtro.Focus();
        }
    }
}
