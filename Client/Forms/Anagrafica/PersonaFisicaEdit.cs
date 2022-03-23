using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using it.dedagroup.GVC.Repository.Common.Configurations;

namespace it.dedagroup.GVC.Client.Forms.Registry
{
    public partial class PersonaFisicaEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {

		#region Constructors (1) 

        public PersonaFisicaEdit()
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
                radioGroup3.Properties.ReadOnly = value;
            }
        }

		#region Public Methods (1) 

        public void SetBindableData(PersonaFisicaFDT item)
        {
            if (item == null)
                item = new PersonaFisicaFDT();
            this.bindingSourcePersonaFisica.DataSource = item;
            
        }

        public Boolean HasErrors
        {
            get
            {
                return this.ErrorProviderPersonaFisica.HasErrorsOfType(DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical);
            }
        }

		#endregion Public Methods 

    }
}
