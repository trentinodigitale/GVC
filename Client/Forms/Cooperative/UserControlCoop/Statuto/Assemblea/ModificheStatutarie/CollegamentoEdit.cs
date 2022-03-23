using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.Services;
using OeF.Utility;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Statuto.Assemblea.ModificheStatutarie
{
    public partial class CollegamentoEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {
        #region Instance Variables (1)

        ModificaStatutariaFDT itemLocal = null;
        CooperativaFDT itemCoop = null;

        #endregion Instance Variables

        #region Constructors (1)

        public CollegamentoEdit()
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
            }
        }

        #endregion Constructors

        #region Event Handlers

        private void btnSearchAssociation_Click(object sender, EventArgs e)
        {
            SoggettoFDT itemSogg = null;

            //Expression expression = (FieldName)SearchParameters.ID_TIPO_SOGGETTO == TipiSoggettiSpecifici.Cooperativa &
            //                        new Expression((FieldName)SearchParameters.CODICE_COOPERATIVA, Operators.IsNot, DBNull.Value);



            Search.CoopTemplateSearch page = CreatePageDialog<Search.CoopTemplateSearch>();
            if (page != null)
            {
                page.BaseForm.StartPosition = FormStartPosition.CenterScreen;

                DialogResult dr = DialogResult.OK;
                page.NotToOpen = true;

                while (dr == DialogResult.OK)
                {
                    itemSogg = null;

                    dr = page.BaseForm.ShowDialog(null, false);

                    if (dr != DialogResult.OK)
                        break;

                    if (dr == DialogResult.OK)
                    {
                        itemSogg = page.SelectedItem;
                    }

                    if (itemSogg != null)
                        break;
                }

                if (itemSogg != null)
                {
                    if (itemLocal != null)
                    {
                        CollegamentoSocietaFDT newItem = SaveCollegamento(itemSogg, false, false);
                        if (itemLocal.SocietaCollegate != null &&
                            itemLocal.SocietaCollegate.Length == 1)
                        {
                            itemLocal.SocietaCollegate[0] = newItem;
                        }
                        else
                        {
                            itemLocal.AddCollegamentoSocieta(newItem);
                        }
                        this.bindingSourceBaseSocietaColl.DataSource = itemLocal.SocietaCollegate;
                        this.bindingSourceBaseSocietaColl.ResetBindings(false);
                    }
                    else
                    {
                        ShowProblemsMessage();
                    }
                }
            }
        }

        #endregion Event Handlers

        #region Public Methods

        internal void SetBindableData(ModificaStatutariaFDT item, CooperativaFDT coop)
        {
            itemLocal = item;
            this.bindingSourceBaseModificaStatutaria.DataSource = item;

            if (coop != null)
            {
                itemCoop = coop;
            }
        }

        #endregion Public Methods

        #region Private Methods

        private CollegamentoSocietaFDT SaveCollegamento(SoggettoFDT itemSogg, Boolean isAnUpdate, Boolean onDB)
        {
            CollegamentoSocietaFDT toReturn = new CollegamentoSocietaFDT();

            if (itemSogg != null)
            {
                toReturn.IdModificaStatutaria = itemLocal.IdModificaStatutaria;
                toReturn.IdSoggetto = itemSogg.IdSoggetto;
                toReturn.Societa = itemSogg;

                if (onDB)
                {
                    // chiamata al servizio
                }
                else
                {
                    if (isAnUpdate)
                        toReturn.Status = ObjectStatus.ToUpdate;
                    else
                        toReturn.Status = ObjectStatus.ToInsert;
                }
            }

            return toReturn;
        }

       

        #endregion Private Methods
    }
}
