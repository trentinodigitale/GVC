using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Registro
{
    public partial class Cancellazione : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        #region Instance Variables

        private CancellazioneFDT itemLocal = null;
        public event EventHandler ModifyCancellazione;
        public event EventHandler DeleteCancellazione;
        public event EventHandler NuovoProcedimento;

        #endregion Instance Variables

        #region Constructors

        public Cancellazione()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Event Handlers

        void simpleButtonNewProcess1_Click(object sender, EventArgs e)
        {
            //OpenNewProcess();
            EventHandler temp = NuovoProcedimento;
            if (temp != null)
                NuovoProcedimento(null, new EventArgs());
        }

        private void checkEditSecond_CheckedChanged(object sender, EventArgs e)
        {
            SetCancellazioneType();
        }

        private void checkEditThird_CheckedChanged(object sender, EventArgs e)
        {
            SetCancellazioneType();

            DataAlbo.Visible = checkEditThird.Checked;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EventHandler temp = DeleteCancellazione;
            if (temp != null)
                DeleteCancellazione(this, new EventArgs());
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            EventHandler temp = ModifyCancellazione;
            if (temp != null)
                ModifyCancellazione(this, new EventArgs());
        }

        #endregion Event Handlers

        #region Public Methods

        public void EnableField()
        {
            if (btnModify != null)
                btnModify.Enabled = true;
            if (btnDelete != null)
                btnDelete.Enabled = true;
        }

        public void SetBindableData(CancellazioneFDT item)
        {
            itemLocal = item;

            this.bindingSourceBaseCancellazione.DataSource = itemLocal;

            if (itemLocal != null)
            {
                if (itemLocal.IdTipoCancellazione < 111)
                    itemLocal.IdTipoCancellazione = 111;

                int vTemp = itemLocal.IdTipoCancellazione;
               // if (Int32.TryParse(itemLocal.IdTipoCancellazione, out vTemp))
                {
                    int third = vTemp % 10;
                    int second = (vTemp / 10) % 10;
                    int first = (vTemp / 100) % 10;

                    if (first > 1)
                    {
                        checkEditFirst.Checked = true;
                    }
                    else
                    {
                        DataRegistroImprese.Visible = false;
                    }
                    if (second > 1)
                    {
                        checkEditSecond.Checked = true;
                    }
                    if (third > 1)
                    {
                        checkEditThird.Checked = true;
                    }
                    else
                    {
                        DataAlbo.Visible = false;
                    }
                }
            }
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

                //Parere commissione
                textEdit7.Properties.ReadOnly = true;
                dateEdit9.Properties.ReadOnly = true;
            }
        }

        public void HideButtons()
        {
            this.panelControl1.Visible = false;
        }

        #endregion Public Methods

        #region Private Methods

        internal void ShowButtons()
        {
            this.panelControl1.Visible = true;
        }

        internal void ToggleButtons(Boolean enabled)
        {
            this.simpleButtonNewProcess1.Enabled = 
            this.btnModify.Enabled =
                this.btnDelete.Enabled = enabled;
        }

        private void checkEditFirst_CheckedChanged(object sender, EventArgs e)
        {
            SetCancellazioneType();

            DataRegistroImprese.Visible = checkEditFirst.Checked;
        }

        private void SetCancellazioneType()
        {
            if (itemLocal != null)
            {
                itemLocal.IdTipoCancellazione = Int32.Parse(
                    String.Concat(
                    (checkEditFirst.Checked) ? "2" : "1",
                    (checkEditSecond.Checked) ? "2" : "1",
                    (checkEditThird.Checked) ? "2" : "1"
                    ));
            }
        }

        #endregion Private Methods
    }
}
