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

namespace it.dedagroup.GVC.Client.Forms.Search.Revisioni
{
    public partial class RevisioniEffettuateSearch : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        #region Instance Variables

        private RevisioneFDT parametri_revisione = null;
        private RevisioneIncaricoFDT parametri_incarico = null;
        private CooperativaFDT parametri_coop = null;
        private Expression query = null;

        #endregion Instance Variables

        #region Constructors (1)

        public RevisioniEffettuateSearch()
        {
            InitializeComponent();

            SetImages();
        }

        #endregion Constructors

        #region Event Handlers

        private void btnRicercaRevisore_Click(object sender, EventArgs e)
        {
            SoggettoFDT item = new SoggettoFDT();
            item.Note = this.textEditRevisore.Text;

            Expression expression = (FieldName)SearchParameters.ID_TIPO_SOGGETTO == TipiSoggettiSpecifici.Revisore |
                                    (FieldName)SearchParameters.ID_TIPO_SOGGETTO == 2;
            if (OpenSubjectSearch(ref item, expression))
            {
                if (parametri_incarico != null &&
                    parametri_incarico.CompensoRevisore != null)
                {
                    parametri_incarico.CompensoRevisore.Revisore = item;
                    parametri_incarico.CompensoRevisore.IdRevisore = item.IdSoggetto;
                    this.bindingSourceParametriIncarico.ResetBindings(false);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void RevisioniEffettuateSearch_Load(object sender, EventArgs e)
        {
            SetFormTitle("Ricerca revisioni registrate");

            //this.cooperativaDati1.SelectDefault(1,0);

            this.bindingSourceBaseRevisionCadence.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.CADENZA_REVISIONI);
            this.bindingSourceTipoRevisione.DataSource = GVCSystemEngine.AddEmptyElement(GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_REVISIONE));
            this.bindingSourceEsitiRevisione.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.ESITI_REVISIONE);
            this.bindingSourceStati.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.STATI_ISCRIZIONE);
            this.bindingSourceLimitiCosto.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.LIMITI_COSTO);

            SetObjects();

        }

        private void gridControlCooperative_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenCooperative();
        }

        private void barButtonItemStampa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.XtraPrinting.PrintingSystem ps = new DevExpress.XtraPrinting.PrintingSystem();
            DevExpress.XtraPrinting.PrintableComponentLink pcl = new DevExpress.XtraPrinting.PrintableComponentLink();

            ps.Links.Add(pcl);
            pcl.Component = gridControlCooperative;

            ps.Links[0].Landscape = true;

            DevExpress.XtraPrinting.PageHeaderFooter phf = ps.Links[0].PageHeaderFooter as DevExpress.XtraPrinting.PageHeaderFooter;
            //phf.Header.Content.AddRange(new string[] { String.Concat("PARAMETRI DI RICERCA", Environment.NewLine, ""), null, String.Concat(Environment.NewLine, "Ricerca revisioni effettuate") });
            phf.Header.Content.AddRange(new string[] { null, null, String.Concat(Environment.NewLine, "Ricerca revisioni effettuate") });

            pcl.ShowPreviewDialog();
        }

        private void simpleButtonSearchOrgano_Click(object sender, EventArgs e)
        {
            SoggettoFDT item = new PersonaGiuridicaFDT();
            item.Note = this.Organo.Text;

            Expression expression = (FieldName)SearchParameters.ASSOCIAZIONE == 1;
            if (OpenSubjectSearch(ref item, expression))
            {
                if (parametri_revisione != null)
                {
                    parametri_revisione.Revisore = item as PersonaGiuridicaFDT;
                    parametri_revisione.IdOrganoRevisore = item.IdSoggetto;
                    this.bindingSourceParametriRevisione.ResetBindings(false);
                }
            }
        }

        private void btnRemoveRevisore_Click(object sender, EventArgs e)
        {
            if (parametri_incarico != null &&
                parametri_incarico.CompensoRevisore != null)
            {
                parametri_incarico.CompensoRevisore.BeginEdit();
                
                parametri_incarico.CompensoRevisore.Revisore = null;
                parametri_incarico.CompensoRevisore.IdRevisore = -1;

                parametri_incarico.CompensoRevisore.EndEdit();

                this.bindingSourceParametriIncarico.ResetBindings(false);
            }
        }

        private void btnRemoveSubject_Click(object sender, EventArgs e)
        {
            if (parametri_revisione != null)
            {
                parametri_revisione.BeginEdit();

                parametri_revisione.Revisore = null;
                parametri_revisione.IdOrganoRevisore = -1;

                parametri_revisione.EndEdit();

                this.bindingSourceParametriRevisione.ResetBindings(false);
            }
        }

        private void barButtonItemAzzera_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ResetParameters();
        }

        #endregion Event Handlers

        #region Private Methods

        private void SetObjects()
        {
            parametri_coop = new CooperativaFDT();
            parametri_coop.RegistroCooperativa = new RegistroCooperativaFDT();
            this.bindingSourceParametriCoop.DataSource = parametri_coop;
            this.cooperativaDati1.SetBindableData(parametri_coop);

            parametri_incarico = new RevisioneIncaricoFDT();
            parametri_incarico.CompensoRevisore = new CompensoFDT();
            this.bindingSourceParametriIncarico.DataSource = parametri_incarico;

            parametri_revisione = new RevisioneFDT();
            this.bindingSourceParametriRevisione.DataSource = parametri_revisione;
        }

        private void SetImages()
        {
            this.btnRemoveSubject.Image = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
            this.btnRemoveRevisore.Image = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
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
                        page.OpenSelectedTab("xtraTabPageRevision");
                    }
                }
                else
                {
                    ShowInformationMessage("Cooperativa già aperta a video", string.Empty);
                }
            }
        }

        private bool DefineParameters()
        {
            query = null;

            this.cooperativaDati1.BindingSourceEndInit();

            this.bindingSourceParametriCoop.EndEdit();

            this.bindingSourceParametriIncarico.EndEdit();

            this.bindingSourceParametriRevisione.EndEdit();

            if (parametri_coop.RegistroCooperativa.IdCadenzaRevisione > 0)
                query &= (FieldName)SearchParameters.CADENZA_REV == parametri_coop.RegistroCooperativa.IdCadenzaRevisione;

            if (parametri_revisione.AnnoRevisione > 0) //controllo...
                query &= (FieldName)SearchParameters.REV_ANNO == parametri_revisione.AnnoRevisione;
            
            if (parametri_revisione.IdTipoRevisione > 0)
                query &= (FieldName)SearchParameters.REV_ID_TIPO == parametri_revisione.IdTipoRevisione;

            if (parametri_revisione.IdEsitoRevisione > 0)
                query &= (FieldName)SearchParameters.REV_ID_ESITO == parametri_revisione.IdEsitoRevisione;

            if (parametri_revisione.IdOrganoRevisore > 0)
                query &= (FieldName)SearchParameters.REV_ID_ORGANO == parametri_revisione.IdOrganoRevisore;

            if (parametri_revisione.IdLimiteCosto > 0)
                query &= (FieldName)SearchParameters.REV_ID_LIMITI == parametri_revisione.IdLimiteCosto;

            if (parametri_incarico.CompensoRevisore.IdRevisore > 0)
                query &= (FieldName)SearchParameters.REV_ID_REVISORE == parametri_incarico.CompensoRevisore.IdRevisore;

            if (parametri_incarico.DataScadenzaTeorica.HasValue)
                query &= (FieldName)SearchParameters.REV_DATA_SCAD <= parametri_incarico.DataScadenzaTeorica.Value;

            if (this.radioGroup2.SelectedIndex == 1)
                query &= (FieldName)SearchParameters.REV_FLAG_LIQUID == "1";
            else if (this.radioGroup2.SelectedIndex == 2)
                query &= (FieldName)SearchParameters.REV_FLAG_LIQUID != "1";
            
            if (this.StatoConclusione.SelectedIndex == 1)
                query &= new Expression((FieldName)SearchParameters.REV_DATA_CONCLUSIONE, Operators.IsNot, DBNull.Value);
            else if (this.StatoConclusione.SelectedIndex == 2)
                query &= new Expression((FieldName)SearchParameters.REV_DATA_CONCLUSIONE, Operators.Is, DBNull.Value);

            if (this.StatoRevoca.SelectedIndex == 1)
            {
                Expression queryRev = null;
                queryRev &= new Expression((FieldName)SearchParameters.REV_DATA_REVOCA_DET, Operators.IsNot, DBNull.Value);
                queryRev |= new Expression((FieldName)SearchParameters.REV_DATA_REVOCA_DEL, Operators.IsNot, DBNull.Value);

                query &= queryRev;
            }
            else if (this.StatoRevoca.SelectedIndex == 2)
            {
                query &= new Expression((FieldName)SearchParameters.REV_DATA_REVOCA_DET, Operators.Is, DBNull.Value);
                query &= new Expression((FieldName)SearchParameters.REV_DATA_REVOCA_DEL, Operators.Is, DBNull.Value);
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
                CooperativaRicercaFDT[] lTemp = GVCSystemEngine.InvokeService<ICooperatives, CooperativaRicercaFDT[]>
                    (delegate()
                    {
                        return GVCSystemEngine.Cooperatives.GetRevisioniEffettuateBySearch(query, cooperativaDati1.GetIndexIscrizione(), cooperativaDati1.GetIndexAdesione(), cooperativaDati1.GetDataIscrizione(), cooperativaDati1.GetDataAdesione(), cooperativaDati1.GetIDAssociazione());
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

        //void ExpandAllDetails(GridView view, Boolean expand)
        //{
        //    if (expand)
        //    {
        //        for (int i = 0; i < view.DataRowCount; i++)
        //        {
        //            if (!view.IsMasterRowEmpty(i))
        //            {
        //                view.ExpandMasterRow(i);
        //                GridView childView = (GridView)view.GetDetailView(i, view.DefaultRelationIndex);
        //                if (childView != null)
        //                    ExpandAllDetails(childView, expand);
        //            }
        //        }
        //    }
        //    else
        //        view.CollapseAllDetails();
        //}

        private void ResetParameters()
        {
            this.cooperativaDati1.ResetParameters();
            this.cooperativaDati1.SelectDefault(1, 0);

            SetObjects();

            StatoConclusione.SelectedIndex = 2;
            StatoRevoca.SelectedIndex = 2;
            radioGroup2.SelectedIndex = 0;
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
