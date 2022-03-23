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

namespace it.dedagroup.GVC.Client.Forms.Search.Fallimenti
{
    public partial class FallimentiSearch : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        #region Instance Variables

        private ProceduraFallimentareFDT parametri_fallimento = null;
        private Expression query = null;

        #endregion Instance Variables

        #region Constructors (1)

        public FallimentiSearch()
        {
            InitializeComponent();

            SetImages();
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
            //phf.Header.Content.AddRange(new string[] { String.Concat("PARAMETRI DI RICERCA", Environment.NewLine, ""), null, String.Concat(Environment.NewLine, "Ricerca cooperative in fallimento") });
            phf.Header.Content.AddRange(new string[] { null, null, String.Concat(Environment.NewLine, "Ricerca cooperative in fallimento") });

            pcl.ShowPreviewDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void FallimentiSearch_Load(object sender, EventArgs e)
        {
            SetFormTitle("Ricerca Cooperative in fallimento");

            this.bindingSourceTipiStato.DataSource = GVCSystemEngine.RemoveEmptyElement(GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_ESITO_FALLIMENTI));

            CooperativaFDT parametri_coop = new CooperativaFDT();
            parametri_coop.RegistroCooperativa = new RegistroCooperativaFDT();
            this.cooperativaDati1.SetBindableData(parametri_coop);

            parametri_fallimento = new ProceduraFallimentareFDT();
            this.bindingSourceParametriFallimento.DataSource = parametri_fallimento;
        }

        private void gridControlCooperative_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenCooperative();
        }

        private void btnRicercaRevisore_Click(object sender, EventArgs e)
        {
            SoggettoFDT item = new SoggettoFDT();
            item.Note = this.memoEditCuratore.Text;

            Expression expression = (FieldName)SearchParameters.ID_TIPO_SOGGETTO == TipiSoggettiSpecifici.Revisore |
                                    (FieldName)SearchParameters.ID_TIPO_SOGGETTO == 2;
            if (OpenSubjectSearch(ref item, expression))
            {

                bindingSourceParametriFallimento.EndEdit();

                parametri_fallimento.IdCuratore = item.IdSoggetto;
                parametri_fallimento.Curatore = item;               

                bindingSourceParametriFallimento.ResetBindings(false);
            }
        }

        private void btnRemoveSubject_Click(object sender, EventArgs e)
        {
            if (parametri_fallimento != null)
            {
                parametri_fallimento.BeginEdit();

                parametri_fallimento.Curatore = null;
                parametri_fallimento.IdCuratore = -1;

                parametri_fallimento.EndEdit();

                this.bindingSourceParametriFallimento.ResetBindings(false);
            }
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

            this.bindingSourceParametriFallimento.EndEdit();

            if (parametri_fallimento.DataSentenza > DateTime.MinValue)
                query &= (FieldName)SearchParameters.FALLIMENTO_DATA_SENTENZA >= parametri_fallimento.DataSentenza;
            if (parametri_fallimento.IdCuratore > 0)
                query &= (FieldName)SearchParameters.FALLIMENTO_CURATORE == parametri_fallimento.IdCuratore;
            if (!String.IsNullOrEmpty(parametri_fallimento.Tribunale))
                query &= (FieldName)SearchParameters.FALLIMENTO_TRIBUNALE % GVCSystemEngine.RemoveDiacritics(parametri_fallimento.Tribunale);
            if (this.radioGroupEsito.SelectedIndex > 0)
                query &= (FieldName)SearchParameters.FALLIMENTO_STATO == this.radioGroupEsito.EditValue.ToString();

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
                        return GVCSystemEngine.Cooperatives.GetFallimentiBySearch(query, cooperativaDati1.GetIndexIscrizione(), cooperativaDati1.GetIndexAdesione(), cooperativaDati1.GetDataIscrizione(), cooperativaDati1.GetDataAdesione(), cooperativaDati1.GetIDAssociazione());
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

        private void SetImages()
        {
            this.btnRemoveSubject.Image = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
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
                        page.OpenSelectedTab("xtraTabPageSanzioni","xtraTabPageFallimenti");
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

            parametri_fallimento = new ProceduraFallimentareFDT();
            this.bindingSourceParametriFallimento.DataSource = parametri_fallimento;

            this.radioGroupEsito.SelectedIndex = 0;
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
