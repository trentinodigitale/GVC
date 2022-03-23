using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.FDT;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.BaseCariche.ComunicazioneCaricaSoc
{
    public partial class ComunicazioneEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {

        #region Fields (1)
        //Boolean _retrieveCaricheFromParix;

        //public Boolean RetrieveCaricheFromParix
        //{
        //    get { return _retrieveCaricheFromParix; }
        //    set { _retrieveCaricheFromParix = value; }
        //}
        #endregion Fields

        #region Constructors (1)

        public ComunicazioneEdit()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Public Methods (3)

        public void EndInitBindingSource()
        {
            this.bindingSourceCommunicazioni.EndEdit();
        }

        public void ResetBindingsBindingSource()
        {
            this.bindingSourceCommunicazioni.ResetBindings(false);
        }

        public void SetBindableData(ComunicazioneCaricaSocialeFDT item)
        {
            this.bindingSourceCommunicazioni.DataSource = item;
        }

        public void SetGetParixChagesVisiility(Boolean btnVisible) {
            this.chckRetrieveCariche.Visible = btnVisible;
        }

        #endregion Public Methods 

        //private void chckRetrieveCariche_CheckedChanged(object sender, EventArgs e)
        //{
        //    _retrieveCaricheFromParix = ((DevExpress.XtraEditors.CheckEdit)(sender)).Checked;
        //}
        
    }
}
