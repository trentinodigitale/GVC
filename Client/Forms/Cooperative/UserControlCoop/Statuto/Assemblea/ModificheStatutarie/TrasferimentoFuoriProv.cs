using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.FDT;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Statuto.Assemblea.ModificheStatutarie
{
    public partial class TrasferimentoFuoriProv : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        #region Constructors (2)

        public TrasferimentoFuoriProv()
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
                lookUpEdit1.Properties.ReadOnly = true;
            }
        }

        #endregion Constructors

        #region Public Methods

        public void SetBindableData(ModificaStatutariaFDT item)
        {
            this.bindingSourceBaseModificaStatutaria.DataSource = item;
            this.bindingSourceBaseStato.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.STATI_ISCRIZIONE);
        }

        #endregion Public Methods
    }
}
