using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.Services;
using OeF.Utility;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Statuto.Assemblea.ModificheStatutarie
{
    public partial class Fusione : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        #region Instance Variables (1)

        ModificaStatutariaFDT itemLocal = null;

        #endregion Instance Variables

        #region Constructors (1)

        public Fusione()
        {
            InitializeComponent();
            SetImages();
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
                this.btnViewSubject.Enabled = true;
                memoEdit2.Properties.ReadOnly = true;
                lookUpEditStato.Properties.ReadOnly = true;
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

            //if (OpenSubjectSearch(ref itemSogg, expression))
            //{
            //    if (itemLocal != null)
            //    {
            //        CollegamentoSocietaFDT newItem = SaveCollegamento(itemSogg, false, false);
            //        itemLocal.AddCollegamentoSocieta(newItem);
            //        this.bindingSourceBaseSocietaColl.DataSource = itemLocal.SocietaCollegate;
            //    }
            //    else
            //    {
            //        ShowProblemsMessage();
            //    }
            //}
        }

        private void btnViewSubject_Click(object sender, EventArgs e)
        {
            if (this.itemLocal != null)
            {
                if (this.itemLocal.SocietaCollegate != null &&
                    this.itemLocal.SocietaCollegate.Length > 0)
                {
                    int idCoop = this.itemLocal.SocietaCollegate[0].IdSoggetto;
                    if (idCoop > 0)
                    {
                        CooperativaFDT coopDetail =
                             GVCSystemEngine.InvokeService<ICooperatives, CooperativaFDT>
                                (delegate()
                                {
                                    return GVCSystemEngine.Cooperatives.GetCooperativaById(idCoop);
                                },
                             true);

                        OpenCoopView(coopDetail);
                    }
                }
              
            }
            
        }

        #endregion Event Handlers

        #region Public Methods

        public void SetBindableData(ModificaStatutariaFDT item)
        {
            if (item != null)
            {
                itemLocal = item;
                this.bindingSourceBaseModificaStatutaria.DataSource = item;

                if (item.SocietaCollegate != null)
                {
                    this.bindingSourceBaseSocietaColl.DataSource = item.SocietaCollegate;
                }
            }
            this.bindingSourceBaseStato.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.STATI_ISCRIZIONE);
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

                    //itemLocal.Status = ObjectStatus.ToUpdate;
                }
            }

            return toReturn;
        }

        private void SetImages()
        {
            this.btnSearchAssociation.Image = GVCResourcesUtility.Get_16x16(GVCResources.Businessman_Find_24x24);
            this.btnViewSubject.Image = GVCResourcesUtility.Get_16x16(GVCResources.Businessman_24x24);
        }

        private void OpenViewSubject(SoggettoFDT subject)
        {
            it.dedagroup.GVC.Client.Forms.Registry.AnagraficaEdit page =
                CreatePage<it.dedagroup.GVC.Client.Forms.Registry.AnagraficaEdit>();

            if (page != null)
            {
                page.SetBindableData(subject);
                page.SetFormTitle("Dettagli soggetto");
                page.BaseForm.ShowDialog(this, true);
            }
        }

        #endregion Private Methods

    }
}
