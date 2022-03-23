using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.Configurations;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Statuto.Assemblea
{
    public partial class AttoIntegrativoEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {
		#region Constructors (1) 

        public AttoIntegrativoEdit()
        {
            InitializeComponent();
        }

		#endregion Constructors 

		#region Public Methods (3) 

        public void BindingSourceEndInit()
        {
            this.bindingSourceBaseAttoIntegrativo.EndEdit();
        }

        public void BindingSourceResetBindings()
        {
            this.bindingSourceBaseAttoIntegrativo.ResetBindings(false);
        }

        public void SetBindableData(AttoIntegrativoFDT item)
        {
            this.bindingSourceBaseTipiAttiIntegrativi.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_ATTI);
            this.bindingSourceBaseAttoIntegrativo.DataSource = item;
        }

		#endregion Public Methods 
    }
}
