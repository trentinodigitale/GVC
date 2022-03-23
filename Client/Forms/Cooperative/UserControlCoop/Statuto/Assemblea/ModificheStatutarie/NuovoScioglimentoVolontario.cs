using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.FDT;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Statuto.Assemblea.ModificheStatutarie
{
    public partial class NuovoScioglimentoVolontario : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        #region Instance Variables (1)

        private ComunicazioneCaricaSocialeFDT comCariche = null;

        #endregion Instance Variables (1)

        #region Constructors (2)

        public NuovoScioglimentoVolontario()
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

        public void SetBindableData(ModificaStatutariaFDT item, ComunicazioneCaricaSocialeFDT ultimaComCariche)
        {
            this.bindingSourceBaseModificaStatutaria.DataSource = item;

            if (ultimaComCariche != null)
            {
                comCariche = ultimaComCariche;
                if (comCariche.Cariche != null && comCariche.Cariche.Length > 0)
                    this.bindingSourceCariche.DataSource = listaLiquidatori(comCariche.Cariche);
            }

            this.bindingSourceBaseStato.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.STATI_ISCRIZIONE);
        }

        public void ShowNumeroScioglimento(Boolean visibile)
        {
            labelControl1.Visible = visibile;
            checkEditNrScioglimento.Visible = visibile;
        }

        #endregion Public Methods

        #region Private Methods

        private CaricaSocialeFDT[] listaLiquidatori(CaricaSocialeFDT[] cariche)
        {
            List<CaricaSocialeFDT> elencoLiquidatori = new List<CaricaSocialeFDT>();

            if (cariche != null && cariche.Length > 0)
            {
                foreach (CaricaSocialeFDT item in cariche)
                {
                    if (item.Liquidatore == true)
                    {
                        elencoLiquidatori.Add(item);
                    }
                }
            }

            return elencoLiquidatori.ToArray();

        }

        #endregion Private Methods
    }
}
