using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Statuto.Assemblea.ModificheStatutarie
{
    public partial class ModificaGenerica : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        #region Constructors (1)

        public ModificaGenerica()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Public Methods

        public void SetBindableData(ModificaStatutariaFDT item)
        {
            this.bindingSourceBaseModificaStatutaria.DataSource = item;
        }

        #endregion Public Methods
    }
}
