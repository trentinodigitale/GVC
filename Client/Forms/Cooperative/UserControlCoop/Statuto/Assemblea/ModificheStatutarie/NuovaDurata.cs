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
    public partial class NuovaDurata : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        #region Instance Variables (1)

        ModificaStatutariaFDT itemLocal = null;

        #endregion Instance Variables

        #region Constructors (2)

        public NuovaDurata()
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
                dateEditVecchiaDurata.Properties.ReadOnly = true;
                lookUpEditVecchiaDurata.Properties.ReadOnly = true;
            }
        }

        #endregion Constructors

        #region Private Methods

        private void checkEditDataPresente_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditDataPresente.Checked)
            {
                this.dateEditNuovaDurata.Visible = true;
                this.lookUpEditNuovaDurata.Visible = false;
                if (itemLocal != null)
                {
                    itemLocal.NuovaDurataIllimitata = -1;
                }
                this.bindingSourceBaseModificaStatutaria.ResetBindings(false);
            }
            else
            {
                itemLocal.NuovaDurata = null;

                if (itemLocal != null)
                {
                    if (itemLocal.NuovaDurataIllimitata < 0)
                        itemLocal.NuovaDurataIllimitata = 0;
                }

                this.lookUpEditNuovaDurata.Visible = true;
                this.bindingSourceBaseModificaStatutaria.ResetBindings(false);
                this.dateEditNuovaDurata.Visible = false;
            }
        }

        #endregion Private Methods

        #region Public Methods

        public void SetBindableData(ModificaStatutariaFDT item)
        {
            if (item != null)
            {
                this.bindingSourceBaseModificaStatutaria.DataSource = item;
                itemLocal = item;

                if (item.IdModificaStatutaria > 0)
                {
                    this.lookUpEditVecchiaDurata.Visible = false;
                    this.dateEditVecchiaDurata.Visible = false;
                    this.labelControl12.Visible = false;
                }
                else
                {
                    if (itemLocal.VecchiaDurataDisplay.HasValue)
                    {
                        this.lookUpEditVecchiaDurata.Visible = false;
                        this.dateEditVecchiaDurata.Visible = true;
                    }
                    else
                    {
                        this.lookUpEditVecchiaDurata.Visible = true;
                        this.dateEditVecchiaDurata.Visible = false;
                    }
                }

                if (itemLocal.NuovaDurata.HasValue)
                {
                    checkEditDataPresente.Checked = true;
                }
            }

            this.bindingSourceBaseDurationTypes.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_DURATA);
        }

        #endregion Public Methods
    }
}
