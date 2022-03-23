using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using it.dedagroup.GVC.Repository.Common.Configurations;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Data.Indirizzo
{
    public partial class IndirizzoEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {

		#region Constructors (1) 

        public IndirizzoEdit()
        {
            InitializeComponent();
        }

		#endregion Constructors 

        public override bool ReadOnlyControls
        {
            get
            {
                return base.ReadOnlyControls;
            }
            set
            {
                base.ReadOnlyControls = value;

                Filter();
            }
        }

		#region Public Methods (3) 

        public void BindingSourceEndInit()
        {
            this.bindingSourceAddress.EndEdit();
        }

        public void BindingSourceResetBindings()
        {
            this.bindingSourceAddress.ResetBindings(false);
        }

        public void SetBindableData(IndirizzoFDT item)
        {
            this.bindingSourceAddress.DataSource = item;
            this.bindingSourceAddressTypes.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_INDIRIZZO);

            Filter();
        }

        private void Filter()
        {
            if (this.ReadOnlyControls)
            {
                DropDownFilter(gridViewTipoIndirizzo, colAttivo, false);
            }
            else
            {
                DropDownFilter(gridViewTipoIndirizzo, colAttivo, true);
            }
        }

		#endregion Public Methods 

       
       
        internal void AddSedeError()
        {
            
            this.ErrorProviderAddress.SetErrorType(
                checkEditSede,
                 DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical);

           

           
        }

        internal void SetSedeError()
        {
            
            this.ErrorProviderAddress.SetErrorType(
                checkEditSede,
                 DevExpress.XtraEditors.DXErrorProvider.ErrorType.None);



            
        }

        private void c()
        {
            
        }
        
        private void textEditEmail_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void textEditUrl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string url = textEditUrl.Text;
            if (!string.IsNullOrEmpty(url))
                OpenBrowser(url);
        }

        #region Url
        Boolean pressedUrl = false;
        private void textEditUrl_Properties_Click(object sender, EventArgs e)
        {
            if (pressedUrl)
            {
                string url = textEditUrl.Text;
                if (!string.IsNullOrEmpty(url))
                    OpenBrowser(url);
            }
            pressedUrl = false;
        }

        private void textEditUrl_Properties_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
                pressedUrl = true;
        }

        private void textEditUrl_Properties_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
                pressedUrl = false;
        }
        #endregion Url

        #region Mail
        Boolean pressedEmail = false;
        private void textEditEmail_Properties_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
                pressedEmail = true;
        }

        private void textEditEmail_Properties_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
                pressedEmail = false;
        }

        private void textEditEmail_Properties_Click(object sender, EventArgs e)
        {
            if (pressedEmail)
            {
                string mail = textEditEmail.Text;
                if (!string.IsNullOrEmpty(mail))
                    OpenMail(mail);
            }
            pressedEmail = false;
        }
        #endregion Mail

    }
}
