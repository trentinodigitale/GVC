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

namespace it.dedagroup.GVC.Client.Forms.Search.ModificheStatutarie
{
    public partial class ModificheStatSearch : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        #region Instance Variables

        private DeliberaAssembleaFDT parametri_assemblea = null;
        private Expression query = null;

        #endregion Instance Variables

        #region Constructors (1)

        public ModificheStatSearch()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Event Handlers

        private void ModificheStatSearch_Load(object sender, EventArgs e)
        {
            SetFormTitle("Ricerca modifiche statutarie");

            this.bindingSourceBaseTipiModificaStatutaria.DataSource = GVCSystemEngine.RemoveEmptyElement(GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_TIPI_MODIFICA));
            this.bindingSourceBaseTipoAssemblea.DataSource = GVCSystemEngine.AddEmptyElement(GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_ASSEMBLEA));

            CooperativaFDT parametri_coop = new CooperativaFDT();
            parametri_coop.RegistroCooperativa = new RegistroCooperativaFDT();
            this.cooperativaDati1.SetBindableData(parametri_coop);

            parametri_assemblea = new DeliberaAssembleaFDT();
            this.bindingSourceParametriAssemblea.DataSource = parametri_assemblea;

            VisualizzaDenominazione(false);

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
            //phf.Header.Content.AddRange(new string[] { String.Concat("PARAMETRI DI RICERCA", Environment.NewLine, ""), null, String.Concat(Environment.NewLine, "Ricerca modifiche statutarie") });
            phf.Header.Content.AddRange(new string[] { null, null, String.Concat(Environment.NewLine, "Ricerca modifiche statutarie") });

            pcl.ShowPreviewDialog();
        }

        private void barButtonItemAzzera_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ResetParameters();
        }

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

        private void checkedListBoxTipi_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            Boolean visible = false;

            if (this.checkedListBoxTipi.CheckedItems != null &&
              this.checkedListBoxTipi.CheckedItems.Count > 0)
            {
                foreach (object itemChecked in checkedListBoxTipi.CheckedItems)
                {
                    DizionarioFDT item = itemChecked as DizionarioFDT;
                    if (item.IdElemento == TipoModificaStatutaria.DENOMINAZIONE)
                    {
                        visible = true;
                    }
                }
            }

            VisualizzaDenominazione(visible);
        }

        #endregion Event Handlers

        #region Private Methods

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
                        page.OpenSelectedTab("xtraTabPageModificheStatutarie");
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
            Boolean ricercaDenominazione = false;

            query = null;

            this.cooperativaDati1.BindingSourceEndInit();

            this.bindingSourceParametriAssemblea.EndEdit();

            if (parametri_assemblea.DataAssemblea > DateTime.MinValue)
                query &= (FieldName)SearchParameters.MODSTAT_DATA_ASS_DA >= parametri_assemblea.DataAssemblea;
            if (parametri_assemblea.DataUltimaModifica.HasValue)
                query &= (FieldName)SearchParameters.MODSTAT_DATA_ASS_A <= parametri_assemblea.DataUltimaModifica.Value;
            if (parametri_assemblea.IdTipoAssemblea > 0)
                query &= (FieldName)SearchParameters.MODSTAT_ID_TIPO_ASS == parametri_assemblea.IdTipoAssemblea;

            if (this.checkedListBoxTipi.CheckedItems != null &&
                this.checkedListBoxTipi.CheckedItems.Count > 0)
            {
                Expression tp = null;
                foreach (object itemChecked in checkedListBoxTipi.CheckedItems)
                {
                    DizionarioFDT item = itemChecked as DizionarioFDT;
                    tp |= (FieldName)SearchParameters.MODSTAT_ID_TIPO_MODIFICA == item.IdElemento;

                    if (item.IdElemento == TipoModificaStatutaria.DENOMINAZIONE)
                    {
                        //ricerco nei cambio denominazione
                        ricercaDenominazione = true;
                    }
                }
                query &= tp;
            }

            if (ricercaDenominazione && !String.IsNullOrEmpty(parametri_assemblea.Contenuto))
            {
                //ricerco nei cambio denominazione
                query &= (FieldName)SearchParameters.MODSTAT_VECCHIA_DENOMINAZIONE % parametri_assemblea.Contenuto;
            }

            if (this.checkEdit1.Checked)
            {
                Expression tColl = null;

                tColl |= (FieldName)SearchParameters.MODSTAT_ID_TIPO_MODIFICA == TipoModificaStatutaria.FUSIONE_INCORPORANTE;
                tColl |= (FieldName)SearchParameters.MODSTAT_ID_TIPO_MODIFICA == TipoModificaStatutaria.FUSIONE_INCORPORATA;
                tColl |= (FieldName)SearchParameters.MODSTAT_ID_TIPO_MODIFICA == TipoModificaStatutaria.SCISSIONE;

                tColl &= new Expression((FieldName)SearchParameters.MODSTAT_FLAG_COLL, Operators.Is, DBNull.Value);

                query &= tColl;
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
                        return GVCSystemEngine.Cooperatives.GetModificheStatBySearch(query, cooperativaDati1.GetIndexIscrizione(), cooperativaDati1.GetIndexAdesione(), cooperativaDati1.GetDataIscrizione(), cooperativaDati1.GetDataAdesione(), cooperativaDati1.GetIDAssociazione());
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

        private void ResetParameters()
        {
            this.cooperativaDati1.ResetParameters();

            parametri_assemblea = new DeliberaAssembleaFDT();
            this.bindingSourceParametriAssemblea.DataSource = parametri_assemblea;

            for (int i = 0; i < checkedListBoxTipi.ItemCount; i++)
                checkedListBoxTipi.SetItemChecked(i, false);

            checkEdit1.Checked = false;
        }

        private void VisualizzaDenominazione(Boolean visible)
        {
            this.Denominazione.Visible = this.labelControlDenominazione.Visible = visible;
        }

        #endregion Private Methods
    }
}
