using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;

namespace it.dedagroup.GVC.Client.Forms.Vocabolari
{
    public partial class CadenzaRevisioneEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {
        public CadenzaRevisioneEdit()
        {
            InitializeComponent();
        }

        public void SetBindableData(DizionarioFDT item, string formTitle, string parentTitle)
        {
            this.bindingSourceBaseDizionario.DataSource = item;

            if (item != null)
            {
                if (item.Dettaglio == null)
                    item.Dettaglio = new DettaglioDizionarioFDT();
                this.bindingSourceBaseDettaglio.DataSource = item.Dettaglio;
            }
        }
    }
}
