using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using it.dedagroup.GVC.Client.Forms.Common;
using it.dedagroup.GVC.Client.Forms.Cooperative;
using it.dedagroup.GVC.Client.Forms.Registry;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.Converters;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.RicercheWrapper;
using it.dedagroup.GVC.Repository.Common.Services;
using OeF.Utility;


namespace it.dedagroup.GVC.Client.Forms.Search.Procedimenti
{
    public partial class ProcedimentiSearch : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        #region Instance Variables

        private ProcedimentoFDT parametri_procedimento = null;
        private Expression query = null;

        #endregion Instance Variables

        #region Constructors (1)

        public ProcedimentiSearch()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Event Handlers

        private void ProcedimentiSearch_Load(object sender, EventArgs e)
        {
            SetFormTitle("Ricerca procedimenti");

            this.bindingSourceTipiIniziative.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_INIZIATIVA);
            this.bindingSourceTipiProcedimenti.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_PROCEDIMENTO);
            this.bindingSourceTipiConclusioni.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_CONCLUSIONE);
            this.bindingSourceTipiSospensioni.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_SOSPENSIONE);
            this.bindingSourceBaseStati.DataSource = GVCSystemEngine.RemoveEmptyElement(GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_STATO_PROCEDIMENTO));

            CooperativaFDT parametri_coop = new CooperativaFDT();
            parametri_coop.RegistroCooperativa = new RegistroCooperativaFDT();
            this.cooperativaDati1.SetBindableData(parametri_coop);

            parametri_procedimento = new ProcedimentoFDT();
            this.bindingSourceParametriProc.DataSource = parametri_procedimento;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
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
            //phf.Header.Content.AddRange(new string[] { String.Concat("PARAMETRI DI RICERCA", Environment.NewLine, ""), null, String.Concat(Environment.NewLine, "Ricerca procedimenti") });
            phf.Header.Content.AddRange(new string[] { null, null, String.Concat(Environment.NewLine, "Ricerca procedimenti") });

            pcl.ShowPreviewDialog();
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

            this.bindingSourceParametriProc.EndEdit();

            if (parametri_procedimento.DataInizioProcedimento.HasValue)
                query &= (FieldName)SearchParameters.PROC_DATA_DA >= parametri_procedimento.DataInizioProcedimento.Value;
            if (parametri_procedimento.AvvisoInizioProcedimento.HasValue)
                query &= (FieldName)SearchParameters.PROC_DATA_A <= parametri_procedimento.AvvisoInizioProcedimento.Value;
            if (parametri_procedimento.IdTipoProcedimento > 0)
                query &= (FieldName)SearchParameters.PROC_TIPO_PROC == parametri_procedimento.IdTipoProcedimento;
            if (parametri_procedimento.IdTipoIniziativa > 0)
                query &= (FieldName)SearchParameters.PROC_TIPO_INIZIATIVA == parametri_procedimento.IdTipoIniziativa;

            if (this.checkedListBoxControl1.CheckedItems != null &&
                this.checkedListBoxControl1.CheckedItems.Count > 0)
            {
                Expression tp = null;
                foreach (object itemChecked in checkedListBoxControl1.CheckedItems)
                {
                    DizionarioFDT item = itemChecked as DizionarioFDT;
                    tp |= (FieldName)SearchParameters.PROC_STATO == item.IdElemento;
                }
                query &= tp;
            }

            if (this.checkEditTempi.Checked)
            {
                Expression Scad = null;
                //query &= new Expression((FieldName)SearchParameters.PROC_DATA_TEORICA_FINE,
                //    Operators.Lower, (FieldName)SearchParameters.PROC_DATA_CONCLUSIONE);
                
                query &= (FieldName)SearchParameters.PROC_DATA_TEORICA_FINE < "PROC_DATA_CONCLUSIONEName";
                Scad &= new Expression((FieldName)SearchParameters.PROC_DATA_CONCLUSIONE, Operators.Is, DBNull.Value);
                Scad &= (FieldName)SearchParameters.PROC_DATA_TEORICA_FINE <= DateTime.Today;

                query |= Scad;
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
                        return GVCSystemEngine.Cooperatives.GetProcedimentiBySearch(query, cooperativaDati1.GetIndexIscrizione(), cooperativaDati1.GetIndexAdesione(), cooperativaDati1.GetDataIscrizione(), cooperativaDati1.GetDataAdesione(), cooperativaDati1.GetIDAssociazione());
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
                        page.OpenSelectedTab("xtraTabPageProcedimenti");
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

            parametri_procedimento = new ProcedimentoFDT();
            this.bindingSourceParametriProc.DataSource = parametri_procedimento;

            for (int i = 0; i < checkedListBoxControl1.ItemCount; i++)
                checkedListBoxControl1.SetItemChecked(i, false);

            checkEditTempi.Checked = false;
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
