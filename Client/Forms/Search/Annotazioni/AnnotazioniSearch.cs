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
using it.dedagroup.GVC.Client.Forms.Search.Common;

namespace it.dedagroup.GVC.Client.Forms.Search.Annotazioni
{
    public partial class AnnotazioniSearch : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        #region Instance Variables

        private ScadenziarioFDT parametri_annotazione = null;
        private Expression query = null;

        #endregion Instance Variables

        #region Constructors (1)

        public AnnotazioniSearch()
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
            //phf.Header.Content.AddRange(new string[] { String.Concat("PARAMETRI DI RICERCA", Environment.NewLine, ""), null, String.Concat(Environment.NewLine, "Ricerca annotazioni/scadenze") });
            phf.Header.Content.AddRange(new string[] { null, null, String.Concat(Environment.NewLine, "Ricerca annotazioni/scadenze") });

            pcl.ShowPreviewDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void AnnotazioniSearch_Load(object sender, EventArgs e)
        {
            SetFormTitle("Ricerca annotazioni/scadenze");

            this.bindingSourceTipiAnnotazione.DataSource = GVCSystemEngine.AddEmptyElement(GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_ANNOTAZIONE));

            CooperativaFDT parametri_coop = new CooperativaFDT();
            parametri_coop.RegistroCooperativa = new RegistroCooperativaFDT();
            this.cooperativaDati1.SetBindableData(parametri_coop);

            parametri_annotazione = new ScadenziarioFDT();
            parametri_annotazione.DataAnnotazione = DateTime.MinValue;
            this.bindingSourceParametriAnnotaz.DataSource = parametri_annotazione;

        }

        private void gridControlCooperative_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenCooperative();
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

            this.bindingSourceParametriAnnotaz.EndEdit();

            if (parametri_annotazione.DataAnnotazione > DateTime.MinValue)
                query &= (FieldName)SearchParameters.ANNOTAZIONE_DATA_DA >= parametri_annotazione.DataAnnotazione;
            if (parametri_annotazione.DataUltimaModifica.HasValue)
                query &= (FieldName)SearchParameters.ANNOTAZIONE_DATA_A <= parametri_annotazione.DataUltimaModifica.Value;
            if (parametri_annotazione.IdTipoScadenziario > 0)
                query &= (FieldName)SearchParameters.ANNOTAZIONE_ID_TIPO == parametri_annotazione.IdTipoScadenziario;
            if (!String.IsNullOrEmpty(parametri_annotazione.Descrizione))
                query &= (FieldName)SearchParameters.ANNOTAZIONE_DESCRIZIONE % GVCSystemEngine.RemoveDiacritics(parametri_annotazione.Descrizione);
            if (parametri_annotazione.Evasa)
                query &= (FieldName)SearchParameters.ANNOTAZIONE_FLAG_EVASA == 1;
            if (parametri_annotazione.DataEvasione.HasValue)
                query &= (FieldName)SearchParameters.ANNOTAZIONE_DATA_SCAD_DA >= parametri_annotazione.DataEvasione.Value;
            if (parametri_annotazione.DataScadenza.HasValue)
                query &= (FieldName)SearchParameters.ANNOTAZIONE_DATA_SCAD_A <= parametri_annotazione.DataScadenza.Value;

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
                CooperativaRicercaFDT[] lTemp = GVCSystemEngine.InvokeService<ICooperatives, CooperativaRicercaFDT[]>
                    (delegate()
                    {
                        return GVCSystemEngine.Cooperatives.GetAnnotazioniBySearch(query, cooperativaDati1.GetIndexIscrizione(), cooperativaDati1.GetIndexAdesione(), cooperativaDati1.GetDataIscrizione(), cooperativaDati1.GetDataAdesione(), cooperativaDati1.GetIDAssociazione());
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
                        page.OpenSelectedTab("xtraTabPageAnnotazioni");
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

            parametri_annotazione = new ScadenziarioFDT();
            this.bindingSourceParametriAnnotaz.DataSource = parametri_annotazione;
        }

        #endregion Private Methods

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
