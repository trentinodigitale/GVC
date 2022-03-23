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
    public partial class FusioneIncorporante : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        #region Instance Variables (1)

        ModificaStatutariaFDT itemLocal = null;

        #endregion Instance Variables

        #region Constructors (1)

        public FusioneIncorporante()
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
                textEdit6.Properties.ReadOnly = true;
                this.btnViewSubject.Enabled = true;
            }
        }

        #endregion Constructors

        #region Event Handlers

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCollegamentoSocieta();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DeleteCollegamentoSocieta();
        }

        private void btnSearchNotary_Click(object sender, EventArgs e)
        {
            SoggettoFDT item = new PersonaFisicaFDT();

            Expression expression = (FieldName)SearchParameters.ID_TIPO_SOGGETTO == TipiSoggettiSpecifici.Notaio;
            if (OpenSubjectSearch(ref item, expression))
            {
                if (itemLocal != null)
                {
                    itemLocal.Notaio = item as PersonaFisicaFDT;
                    itemLocal.IdNotaio = item.IdSoggetto;
                    this.bindingSourceBaseModificaStatutaria.ResetBindings(false);
                }
                //else
                //{
                //    this.textEdit6.Text = ((PersonaFisicaFDT)item).DescrizioneBreve;
            }
        }

        private void btnViewSubject_Click(object sender, EventArgs e)
        {
            SoggettoFDT sj = null;
            if (this.itemLocal != null)
            {
                if (itemLocal.Notaio != null)
                {
                    sj = itemLocal.Notaio;
                }
                else
                {
                    if (itemLocal.IdNotaio > 0)
                    {

                        SoggettoFDT ss =
                        GVCSystemEngine.InvokeService<ICooperatives, SoggettoFDT>
                            (delegate()
                            {
                                return GVCSystemEngine.Cooperatives.GetSoggettoById(itemLocal.IdNotaio);
                            },
                         true);

                        if (ss is PersonaFisicaFDT)
                        {
                            itemLocal.Notaio = ss as PersonaFisicaFDT;

                            if (itemLocal.Notaio != null)
                            {
                                sj = itemLocal.Notaio;
                            }
                        }
                    }
                }
            }
            if (sj != null)
            {
                OpenViewSubject(sj);
            }
        }

        private void btnRemoveSubject_Click(object sender, EventArgs e)
        {
            if (itemLocal != null)
            {
                itemLocal.BeginEdit();

                itemLocal.Notaio = null;
                itemLocal.IdNotaio = -1;

                itemLocal.EndEdit();

                this.bindingSourceBaseModificaStatutaria.ResetBindings(false);
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
            }

            if (item.SocietaCollegate != null && item.SocietaCollegate.Length > 0)
                this.bindingSourceBaseSocietaColl.DataSource = item.SocietaCollegate;
        }

        #endregion Public Methods

        #region Private Methods

        private void SetImages()
        {
            this.btnAdd.Image = GVCResourcesUtility.Get_16x16(GVCResources.Add_24x24);
            this.btnRemove.Image = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
            this.btnSearchNotary.Image = GVCResourcesUtility.Get_16x16(GVCResources.Businessman_Find_24x24);
            this.btnViewSubject.Image = GVCResourcesUtility.Get_16x16(GVCResources.Businessman_24x24);
            this.btnRemoveSubject.Image = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
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

        private CollegamentoSocietaFDT GetCurrentItem()
        {
            CollegamentoSocietaFDT toReturn = null;
            if (this.bindingSourceBaseSocietaColl.Current != null)
                toReturn = this.bindingSourceBaseSocietaColl.Current as CollegamentoSocietaFDT;
            return toReturn;
        }

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

        private void AddCollegamentoSocieta()
        {
            SoggettoFDT itemSogg = new CooperativaFDT();

             Search.CoopTemplateSearch page = CreatePageDialog<Search.CoopTemplateSearch>();
             if (page != null)
             {
                 DialogResult dr = DialogResult.OK;
                 page.NotToOpen = true;

                 while (dr == DialogResult.OK)
                 {
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

                         this.gridViewSocieta.BeginDataUpdate();

                         itemLocal.AddCollegamentoSocieta(newItem);

                         this.bindingSourceBaseSocietaColl.DataSource = itemLocal.SocietaCollegate;
                         this.gridViewSocieta.EndDataUpdate();
                     }
                     else
                     {
                         ShowProblemsMessage();
                     }
                 }
             }

            //Expression expression = (FieldName)SearchParameters.ID_TIPO_SOGGETTO == TipiSoggettiSpecifici.Cooperativa &
            //                        new Expression((FieldName)SearchParameters.CODICE_COOPERATIVA, Operators.IsNot, DBNull.Value);

            //if (OpenSubjectSearch(ref itemSogg, expression))
            //{
            //    if (itemLocal != null)
            //    {
            //        CollegamentoSocietaFDT newItem = SaveCollegamento(itemSogg, false, false);

            //        this.gridViewSocieta.BeginDataUpdate();

            //        itemLocal.AddCollegamentoSocieta(newItem);

            //        this.bindingSourceBaseSocietaColl.DataSource = itemLocal.SocietaCollegate;
            //        this.gridViewSocieta.EndDataUpdate();
            //    }
            //    else
            //    {
            //        ShowProblemsMessage();
            //    }
            //}
        }

        private void DeleteCollegamentoSocieta()
        {
            CollegamentoSocietaFDT item = GetCurrentItem();

            if (item != null)
            {
                if (ShowConfirmMessage("Cancellazione", "Confermi la cancellazione dell'elemento selezionato?", string.Empty) == DialogResult.Yes)
                {
                    if (item.IdCollegamento > 0)
                    {
                        item.Status = ObjectStatus.ToCancel;
                        itemLocal.Status = ObjectStatus.ToUpdate;
                    }
                    else
                    {
                        CollegamentoSocietaFDT[] listActual = this.bindingSourceBaseSocietaColl.DataSource as CollegamentoSocietaFDT[];

                        if (listActual != null)
                        {
                            List<CollegamentoSocietaFDT> lTemp = new List<CollegamentoSocietaFDT>();
                            foreach (CollegamentoSocietaFDT ind in listActual)
                            {
                                if (ind != item)
                                {
                                    lTemp.Add(ind);
                                }
                            }
                            if (itemLocal != null)
                            {
                                itemLocal.SocietaCollegate = lTemp.ToArray();
                                this.bindingSourceBaseSocietaColl.DataSource = itemLocal.SocietaCollegate;
                            }
                        }
                    }
                    gridViewSocieta.RefreshData();
                }
            }
        }

        #endregion Private Methods

        private void gridControlSocieta_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CollegamentoSocietaFDT item = GetCurrentItem();
            if (item != null)
            {
                OpenCoopView(item.IdSoggetto);
            }
        }

        public void OpenCoopView(int idSoggetto)
        {
            if (idSoggetto > 0)
            {
                CooperativaFDT coopDetail =
                     GVCSystemEngine.InvokeService<ICooperatives, CooperativaFDT>
                        (delegate()
                        {
                            return GVCSystemEngine.Cooperatives.GetCooperativaById(idSoggetto);
                        },
                     true);

                OpenCoopView(coopDetail);
            }
        }
    }
}
