using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.RicercheWrapper;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Client.Forms.Cooperative;
using OeF.Utility;
using it.dedagroup.GVC.Repository.Common.Services;
using it.dedagroup.GVC.Repository.Common.Converters;
using it.dedagroup.GVC.Client.Forms.Registry;
using it.dedagroup.GVC.Client.Forms.Common;

namespace it.dedagroup.GVC.Client.Forms.Search.Bilanci
{
    public partial class BilanciSearch : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        #region Instance Variables

        private BilancioFDT parametri_bilancio = null;
        private CooperativaFDT parametri_coop = null;
        private Expression query = null;
        int annoBil = 0;

        #endregion Instance Variables

        #region Constructors (1)

        public BilanciSearch()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Event Handlers

        private void barButtonItemStampa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.XtraPrinting.PrintingSystem ps = new DevExpress.XtraPrinting.PrintingSystem();
            DevExpress.XtraPrinting.PrintableComponentLink pcl = new DevExpress.XtraPrinting.PrintableComponentLink();

            ps.Links.Add(pcl);
            pcl.Component = gridControlCooperative;

            ps.Links[0].Landscape = true;

            DevExpress.XtraPrinting.PageHeaderFooter phf = ps.Links[0].PageHeaderFooter as DevExpress.XtraPrinting.PageHeaderFooter;
            //phf.Header.Content.AddRange(new string[] { String.Concat("PARAMETRI DI RICERCA", Environment.NewLine, ""), null, String.Concat(Environment.NewLine, "Ricerca bilanci") });
            phf.Header.Content.AddRange(new string[] { null, null, String.Concat(Environment.NewLine, "Ricerca bilanci") });

            pcl.ShowPreviewDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void gridControlCooperative_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenCooperative();
        }

        private void BilanciSearch_Load(object sender, EventArgs e)
        {
            SetFormTitle("Ricerca bilanci");

            this.bindingSourceBaseStato.DataSource = GVCSystemEngine.AddEmptyElement(GVCSystemEngine.GetDizionarioByType(DictionaryTypes.STATI_ISCRIZIONE));
            this.bindingSourceTipoBilancio.DataSource = GVCSystemEngine.AddEmptyElement(GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_BILANCIO));
            this.bindingSourceBaseRequisitiPrevalenza.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.REQUISITI_PREVALENZA);
            this.bindingSourceTipoVerificaBilancio.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_VERIFICA_BILANCIO);

            SetObjects();

            this.cooperativaDati1.SetBindableData(parametri_coop);
        }

        private void barButtonItemAzzera_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ResetParameters();
        }

        #endregion Event Handlers

        #region Private Methods

        private bool DefineParameters()
        {
            query = null;

            this.cooperativaDati1.BindingSourceEndInit();

            this.bindingSourceParametriCoop.EndEdit();

            this.bindingSourceParametriBilancio.EndEdit();

            if (parametri_coop.RegistroCooperativa.IdStatoIscrizione > 0)
                query &= (FieldName)SearchParameters.STATO_ISCRIZIONE == parametri_coop.RegistroCooperativa.IdStatoIscrizione;

            if (this.checkEditBilEs.Checked)
            {
                //COOP che NON hanno bilanci
                if (parametri_bilancio.Anno > 0)
                {
                    annoBil = parametri_bilancio.Anno;
                }
                else
                {
                    annoBil = 0;
                }
            }
            else
            {
                annoBil = 0;

                //COOP che hanno bilanci
                if (parametri_bilancio.Anno > 0) //controllo...
                    query &= (FieldName)SearchParameters.BILANCIO_ANNO_DA == parametri_bilancio.Anno;

                if (parametri_bilancio.IdTipoBilancio > 0)
                    query &= (FieldName)SearchParameters.BILANCIO_TIPO == parametri_bilancio.IdTipoBilancio;

                if (this.checkEditUtili.Checked)
                {
                    query &= (FieldName)SearchParameters.BILANCIO_FLAG_UTILI == 0;
                    query &= (FieldName)SearchParameters.ESENTE_VERSAM_UTILI != "1";

                    Expression queryTipo = null;
                    queryTipo &= (FieldName)SearchParameters.BILANCIO_TIPO == TipiBilancio.ESERCIZIO;
                    queryTipo |= (FieldName)SearchParameters.BILANCIO_TIPO == TipiBilancio.STRAORDINARIO;

                    query &= queryTipo;
                }

                if (this.checkEditVerifica.Checked)
                    query &= (FieldName)SearchParameters.BILANCIO_FLAG_VERIFICA == "2";

                if (this.checkEditSegnalazione.Checked)
                    query &= new Expression((FieldName)SearchParameters.BILANCIO_FLAG_SEGNALAZIONE, Operators.IsNot, DBNull.Value);

                if (this.radioGroup2.SelectedIndex == 1)
                    query &= (FieldName)SearchParameters.BILANCIO_MUTUALITA == "1";
                else if (this.radioGroup2.SelectedIndex == 2)
                    query &= (FieldName)SearchParameters.BILANCIO_MUTUALITA == "2";
            }

            query &= this.cooperativaDati1.GetQueryCoop();

            if (query == null || query.ToString().Equals(string.Empty))
                return false;

            return true;
        }

        private void Search()
        {
            lblResults.Text = "0";
            this.btnSelAll.Text = "Espandi";
            this.btnSelAll.Tag = 1;

            this.bindingSourceCooperative.DataSource = null;

            if (DefineParameters() || cooperativaDati1.DefineParametrs())
            {
                if (this.checkEditBilEs.Checked && parametri_bilancio.Anno <= 0)
                {
                    ShowInformationMessage("Definire l'anno di riferimento per la ricerca", string.Empty);
                }
                else
                {
                    CooperativaRicercaFDT[] lTemp = GVCSystemEngine.InvokeService<ICooperatives, CooperativaRicercaFDT[]>
                        (delegate()
                        {
                            return GVCSystemEngine.Cooperatives.GetBilanciBySearch(query, cooperativaDati1.GetIndexIscrizione(), cooperativaDati1.GetIndexAdesione(), cooperativaDati1.GetDataIscrizione(), cooperativaDati1.GetDataAdesione(), cooperativaDati1.GetIDAssociazione(), annoBil);
                        },
                        true);

                    if (lTemp != null)
                    {
                        this.lblResults.Text = lTemp.Length.ToString();

                        this.bindingSourceCooperative.DataSource = lTemp;
                    }
                    else
                    {
                        this.lblResults.Text = "0";
                        this.bindingSourceCooperative.DataSource = null;
                    }
                }
            }
            else
            {
                ShowInformationMessage("Definire almeno un parametro di ricerca", string.Empty);
            }
        }

        private CooperativaRicercaFDT GetCurrentItem()
        {
            CooperativaRicercaFDT toReturn = null;
            if (this.bindingSourceCooperative.Current != null)
                toReturn = this.bindingSourceCooperative.Current as CooperativaRicercaFDT;
            return toReturn;
        }

        private void OpenCooperative()
        {
            CooperativaRicercaFDT item = GetCurrentItem();
            if (item != null)
            {
                OpenForEdit(item);
            }
        }

        private void OpenForEdit(CooperativaRicercaFDT item)
        {
            if (item != null)
            {
                if (!UserControlHelp.IsTheSubjectAlreadyOpen(this, item.IdSoggetto))
                {
                    CooperativeEdit1 page = null;
                    BaseForm baseForm = null;
                    CreatePage<Cooperative.CooperativeEdit1>(this, PageActions.ShowMdiChild, out page, out baseForm);
                    if (page != null)
                    {
                        page.SetBindableData(item.IdSoggetto);
                        page.OpenSelectedTab("xtraTabPageBilanci");
                    }
                }
                else
                {
                    ShowInformationMessage("Cooperativa già aperta a video", string.Empty);
                }
            }
        }

        private void ResetParameters()
        {
            this.cooperativaDati1.ResetParameters();

            checkEditSegnalazione.Checked = false;
            checkEditUtili.Checked = false;
            checkEditVerifica.Checked = false;

            this.radioGroup2.SelectedIndex = 0;
        }

        private void SetObjects()
        {
            parametri_coop = new CooperativaFDT();
            parametri_coop.RegistroCooperativa = new RegistroCooperativaFDT();
            parametri_coop.RegistroCooperativa.IdStatoIscrizione = 0;
            this.bindingSourceParametriCoop.DataSource = parametri_coop;

            parametri_bilancio = new BilancioFDT();
            this.bindingSourceParametriBilancio.DataSource = parametri_bilancio;
        }

        #endregion Private Methods

        //private void ExpandAllDetails1(DevExpress.XtraGrid.Views.Grid.GridView view, Boolean expand)
        //{
        //    if (expand)
        //    {
        //        for (int i = 0; i < view.DataRowCount; i++)
        //        {
        //            if (!view.IsMasterRowEmpty(i))
        //            {
        //                view.ExpandMasterRow(i);
        //                DevExpress.XtraGrid.Views.Grid.GridView childView = (DevExpress.XtraGrid.Views.Grid.GridView)view.GetDetailView(i, view.DefaultRelationIndex);
        //                if (childView != null)
        //                    ExpandAllDetails1(childView, expand);
        //            }
        //        }
        //    }
        //    else
        //        view.CollapseAllDetails();
        //}

        private void btnSelAll_Click(object sender, EventArgs e)
        {
            int selected = Convert.ToInt16(this.btnSelAll.Tag);
            if (selected == 1)
            {
                this.btnSelAll.Text = "Comprimi";
                this.btnSelAll.Tag = 0;
                ExpandAllDetails(this.gridViewCooperative, true);
            }
            else
            {
                this.btnSelAll.Text = "Espandi";
                this.btnSelAll.Tag = 1;
                ExpandAllDetails(this.gridViewCooperative, false);
            }
        }
    }
}
