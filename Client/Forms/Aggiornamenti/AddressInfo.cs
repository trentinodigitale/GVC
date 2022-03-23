using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using DevExpress.XtraEditors;

namespace it.dedagroup.GVC.Client.Forms.Aggiornamenti
{
    public partial class AddressInfo : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        public AddressInfo()
        {
            InitializeComponent();
        }

        public void SetAddress(IndirizzoFDT address)
        {
            this.txeVia.Text = address.Via;
            this.txeNrCivico.Text = address.NumeroCivico;
            this.txeCap.Text = address.Cap;
            this.txeCodStrad.Text = address.CodiceStradario;
            this.txeAltreInd.Text = address.Altro;
            this.txeTelefono.Text = address.Telefono;
            this.txeFax.Text = address.Fax;
            this.txeEmail.Text = address.Email;
            this.txeComune.Text = address.Comune; 
        }

    }
}
