using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Sanzioni.ProceduraCoatta
{
    public partial class ProrogaEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {
        public ProrogaEdit()
        {
            InitializeComponent();
        }

        #region Public Methods (3)

        public void BindingSourceEndInit()
        {
            this.bindingSourceExtensions.EndEdit();
        }

        public void BindingSourceResetBindings()
        {
            this.bindingSourceExtensions.ResetBindings(false);
        }

        public void SetBindableData(ProrogaFDT item)
        {
            this.bindingSourceExtensions.DataSource = item;
        }

        #endregion Public Methods 
    }
}
