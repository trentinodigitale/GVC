using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;

namespace it.dedagroup.GVC.Client.Forms.Registry
{
    public partial class PersonaGiuridicaEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        public PersonaGiuridicaEdit()
        {
            InitializeComponent();
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
                checkEditAssociation.Properties.ReadOnly = value;
            }
        }

        public void SetBindableData(PersonaGiuridicaFDT item)
        {
            if (item == null) item = new PersonaGiuridicaFDT();
            this.bindingSourceBasePersonaGiuridica.DataSource = item;
        }

        public Boolean HasErrors
        {
            get
            {
                return this.ErrorProviderPersonaGiuridica.HasErrorsOfType(DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical);
            }
        }
    }
}
