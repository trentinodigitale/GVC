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

namespace it.dedagroup.GVC.Client.Forms.Search.Cancellazioni
{
    public partial class CancellazioniSearch : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        #region Instance Variables

        private CancellazioneFDT parametri_canc = null;
        private Expression query = null;

        #endregion Instance Variables

        #region Constructors (1)

        public CancellazioniSearch()
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
            //phf.Header.Content.AddRange(new string[] { String.Concat("PARAMETRI DI RICERCA", Environment.NewLine, ""), null, String.Concat(Environment.NewLine, "Ricerca cooperative cancellate") });
            phf.Header.Content.AddRange(new string[] { null, null, String.Concat(Environment.NewLine, "Ricerca cooperative cancellate") });

            pcl.ShowPreviewDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void CancellazioniSearch_Load(object sender, EventArgs e)
        {
            SetFormTitle("Ricerca cooperative cancellate");

            parametri_canc = new CancellazioneFDT();
            this.bindingSourceParametriCanc.DataSource = parametri_canc;

            this.bindingSourceTipiCanc.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_CANCELLAZIONE);
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
            Boolean checkData = false;

            this.bindingSourceParametriCanc.EndEdit();

            if (this.checkEditFirst.Checked)
            {
                Expression queryRI = null;
                queryRI &= (FieldName)SearchParameters.CANC_FLAG_RI == "2";
                if (parametri_canc.DataDetermina.HasValue)
                    queryRI &= (FieldName)SearchParameters.CANC_DATA_REG >= parametri_canc.DataDetermina.Value;

                query &= queryRI;
                checkData = true;
            }

            if (this.checkEditSecond.Checked)
            {
                Expression queryRE = null;
                queryRE &= (FieldName)SearchParameters.CANC_FLAG_REGCOOP == "2";
                if (parametri_canc.DataDetermina.HasValue)
                    queryRE &= (FieldName)SearchParameters.CANC_DATA_DETERMINA >= parametri_canc.DataDetermina.Value;

                query |= queryRE;
                checkData = true;
            }

            if (this.checkEditThird.Checked)
            {
                Expression queryALBO = null;
                queryALBO &= (FieldName)SearchParameters.CANC_FLAG_ALBO == "2";
                if (parametri_canc.DataDetermina.HasValue)
                    queryALBO &= (FieldName)SearchParameters.CANC_DATA_ALBO >= parametri_canc.DataDetermina.Value;

                query |= queryALBO;
                checkData = true;
            }

            if (!checkData)
            {
                if (parametri_canc.DataDetermina.HasValue)
                    query &= (FieldName)SearchParameters.CANC_DATA_DETERMINA >= parametri_canc.DataDetermina.Value;
            }

            //query &= this.cooperativaDati1.GetQueryCoop();

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

            if (DefineParameters())
            {
                CooperativaRicercaFDT[] lTemp = GVCSystemEngine.InvokeService<ICooperatives, CooperativaRicercaFDT[]>
                    (delegate()
                    {
                        return GVCSystemEngine.Cooperatives.GetCancellazioniBySearch(query);
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
            parametri_canc = new CancellazioneFDT();
            this.bindingSourceParametriCanc.DataSource = parametri_canc;

            checkEditFirst.Checked = false;
            checkEditSecond.Checked = false;
            checkEditThird.Checked = false;
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
