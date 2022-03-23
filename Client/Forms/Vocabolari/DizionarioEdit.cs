﻿using System;
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
    public partial class DizionarioEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog, IDizionarioEdit
    {
        public DizionarioEdit()
        {
            InitializeComponent();
        }

        public void SetBindableData(DizionarioFDT item, string titolo, Boolean showCodice, Boolean showAltroFlag, string titoloAltroFlag)
        {
            lblTitle.Text = titolo;

            this.panelControlCodice.Visible = showCodice;
            this.panelControlAltroFlag.Visible = showAltroFlag;
            if (showAltroFlag)
                this.lblAltroFlag.Text = titoloAltroFlag;

            this.bindingSourceBaseDizionario.DataSource = item;
        }
    }
}
