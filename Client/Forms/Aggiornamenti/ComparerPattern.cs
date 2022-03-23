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
using DevExpress.XtraEditors;

namespace it.dedagroup.GVC.Client.Forms.Aggiornamenti
{
    public partial class ComparerPattern : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        public ComparerPattern()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.BaseForm.Close();
        }

        public static ComparerPattern CreateComparer(SegnalazioneFDT segnalazione, AggiornamentiMain parent) 
        {
            if (segnalazione.IdTipoSegnalazione == TipoSegnalazione.CODICE_FISCALE  || 
                segnalazione.IdTipoSegnalazione ==TipoSegnalazione.DENOMINAZIONE || 
                segnalazione.IdTipoSegnalazione == TipoSegnalazione.FORMA_GIURIDICA||
                segnalazione.IdTipoSegnalazione == TipoSegnalazione.FORMA_AMMINISTRATIVA)
                return parent.CreatePage<Aggiornamenti.StringComparer>();
            if (segnalazione.IdTipoSegnalazione == TipoSegnalazione.DURATA)
                return parent.CreatePage<Aggiornamenti.DurataSocietaComparer>();
            if (segnalazione.IdTipoSegnalazione == TipoSegnalazione.ATTIVITA_ISTAT)
                 return parent.CreatePage<Aggiornamenti.ActivityComparer>();
            if (segnalazione.IdTipoSegnalazione == TipoSegnalazione.INDIRIZZO_SEDE)
                return parent.CreatePage<Aggiornamenti.AddressComparer>();
            if (segnalazione.IdTipoSegnalazione == TipoSegnalazione.DATI_COSTITUZIONE)
            {
                DateComparer datiCostCom = parent.CreatePage<Aggiornamenti.DateComparer>();
                datiCostCom.SetLabels("Data costituzione:");
                return datiCostCom;
            }
            if (segnalazione.IdTipoSegnalazione == TipoSegnalazione.SCADENZA_ESERCIZI)
            {
                DateComparer datiCostCom = parent.CreatePage<Aggiornamenti.DateComparer>();
                datiCostCom.SetLabels("Bilancio esercizio:");
                return datiCostCom;
            }
            return null;
        }

        public virtual void SetComparables(Object[] actualAttValues, Object[] updatedAttValues) { }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                simpleButton1_Click(this, null); 
                return true;
            }
            else
                return base.ProcessDialogKey(keyData);
        }

        public override bool ReadOnlyControls
        {
            get
            {
                return base.ReadOnlyControls;
            }
            set
            {
                base.ReadOnlyControls = value;
                this.simpleButton1.Enabled = true;
            }
        }
    }
}
