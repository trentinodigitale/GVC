using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.RicercheWrapper;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Client.Forms.Cooperative;
using it.dedagroup.GVC.Repository.Common.Services;
using it.dedagroup.GVC.Repository.Common.Converters;
using it.dedagroup.GVC.Client.Forms.Registry;
using it.dedagroup.GVC.Client.Forms.Common;
using OeF.Utility;

namespace it.dedagroup.GVC.Client.Forms.Search.Sanzioni.ProceduraCoatta
{
    public partial class ProceduraCoattaSearch : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {

        #region Private properties

        private Expression query = null;

        private CooperativaFDT parametri_coop = null;

        #endregion Private properties

        #region Constructor

        public ProceduraCoattaSearch()
        {
            InitializeComponent();

            SetImages();
        }

        #endregion Constructor

        #region Event Handler

        private void ProceduraCoattaSearch_Load(object sender, EventArgs e)
        {
            SetFormTitle("Ricerca procedure coatte");

            this.bindingSourceTipoProcedura.DataSource = GVCSystemEngine.RemoveEmptyElement(GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_PROCEDURE_COATTE));

            parametri_coop = new CooperativaFDT();
            parametri_coop.RegistroCooperativa = new RegistroCooperativaFDT();
            this.bindingSourceParametriCoop.DataSource = parametri_coop;
            this.cooperativaDati1.SetBindableData(parametri_coop);

            //DropDownFilter(gridViewCompensi, colAttivo, true);
            //DropDownFilter(gridViewStatoIscrizione, colFlag, true);

            //this.gridLookUpEditTipoRevisione.EditValue = 1000;
            //this.gridLookUpEditTipoRevisione.Properties.ReadOnly = true;
        }

        private void btnRicercaCoop_Click(object sender, EventArgs e)
        {

            SoggettoFDT itemSogg = null;

            //Expression expression = (FieldName)SearchParameters.ID_TIPO_SOGGETTO == TipiSoggettiSpecifici.Cooperativa &
            //                        new Expression((FieldName)SearchParameters.CODICE_COOPERATIVA, Operators.IsNot, DBNull.Value);



            CoopTemplateSearch page = CreatePageDialog<Search.CoopTemplateSearch>();
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
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.lblResults.Text = "Risultati: 0";
            this.btnSelAll.Text = "Espandi";
            this.btnSelAll.Tag = 1;

            this.bindingSourceCooperative.DataSource = null;

            if (DefineParameters() || cooperativaDati1.DefineParametrs())
            {
                CooperativaRicercaFDT[] lTemp = GVCSystemEngine.InvokeService<ICooperatives, CooperativaRicercaFDT[]>
                    (delegate()
                    {
                        return GVCSystemEngine.Cooperatives.GetListProcedureCoatteBySearch(query, cooperativaDati1.GetIndexIscrizione(), cooperativaDati1.GetIndexAdesione(), cooperativaDati1.GetDataIscrizione(), cooperativaDati1.GetDataAdesione(), cooperativaDati1.GetIDAssociazione());
                    },
                    true);

                if (lTemp != null)
                {
                    this.lblResults.Text = "Risultati: " + lTemp.Length.ToString();

                    this.bindingSourceCooperative.DataSource = lTemp;

                    //if (!NotToOpen)
                    //{
                        if (lTemp.Length == 1)
                        {
                            OpenForEdit(lTemp[0]);
                        }
                    //}
                }
            }
            else
            {
                ShowInformationMessage("Definire almeno un parametro di ricerca", string.Empty);
            }
        }

        private void gridControlCooperative_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenCooperative();
        }

        private CooperativaRicercaFDT GetCurrentItem()
        {
            CooperativaRicercaFDT toReturn = null;
            if (this.bindingSourceCooperative.Current != null)
                toReturn = this.bindingSourceCooperative.Current as CooperativaRicercaFDT;
            return toReturn;
        }

        private void barButtonItemStampa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.XtraPrinting.PrintingSystem ps = new DevExpress.XtraPrinting.PrintingSystem();
            DevExpress.XtraPrinting.PrintableComponentLink pcl = new DevExpress.XtraPrinting.PrintableComponentLink();

            ps.Links.Add(pcl);
            pcl.Component = gridControlCooperative;

            ps.Links[0].Landscape = true;

            DevExpress.XtraPrinting.PageHeaderFooter phf = ps.Links[0].PageHeaderFooter as DevExpress.XtraPrinting.PageHeaderFooter;
            //phf.Header.Content.AddRange(new string[] { String.Concat("PARAMETRI DI RICERCA", Environment.NewLine, ""), null, String.Concat(Environment.NewLine, "Ricerca procedure coatte") });
            phf.Header.Content.AddRange(new string[] { null, null, String.Concat(Environment.NewLine, "Ricerca procedure coatte") });

            pcl.ShowPreviewDialog();
        }

        private void btnRicercaRevisore_Click(object sender, EventArgs e)
        {
            SoggettoFDT item = new PersonaFisicaFDT();
            item.Note = this.Commissario.Text;

            Expression expression = (FieldName)SearchParameters.ID_TIPO_SOGGETTO == TipiSoggettiSpecifici.Commissari;
            if (OpenSubjectSearch(ref item, expression))
            {
                PersonaFisicaFDT Revisore = item as PersonaFisicaFDT;
                this.Commissario.Text = Revisore.ToString();
                this.Commissario.Tag = Revisore.IdSoggetto;
            }
        }

        #endregion Event Handler

        #region Private Methods

        private void SetImages()
        {
            this.btnRemoveRevisore.Image = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
        }


        private bool DefineParameters()
        {
            query = null;

            query &= this.cooperativaDati1.GetQueryCoop();
          
            if (DataInizioProceduraDal.DateTime > DateTime.MinValue)
            {
                query &= (FieldName)SearchParameters.PROCEDURA_COATTA_DATA_INIZIO >= DataInizioProceduraDal.DateTime;
            }

            if (DataInizioProceduraAl.DateTime > DateTime.MinValue)
            {
                query &= (FieldName)SearchParameters.PROCEDURA_COATTA_DATA_INIZIO <= DataInizioProceduraAl.DateTime;
            }

            if (StatoConclusione.SelectedIndex == 1)
            {
                query &= new Expression((FieldName)SearchParameters.PROCEDURA_COATTA_DATA_CONCLUSIONE, Operators.IsNot, DBNull.Value);
            }
            else if (StatoConclusione.SelectedIndex == 2)
            {
                query &= new Expression((FieldName)SearchParameters.PROCEDURA_COATTA_DATA_CONCLUSIONE, Operators.Is, DBNull.Value);
                query &= new Expression((FieldName)SearchParameters.PROCEDURA_COATTA_ID, Operators.IsNot, DBNull.Value);
            }

            if (TipoProceduraCoatta.CheckedItems.Count > 0)
            {
                Expression exp = null;

                for (int i = 0; i < TipoProceduraCoatta.CheckedItems.Count; i++)
                {
                    if (i > 0)
                    {
                        exp |= (FieldName)SearchParameters.PROCEDURA_COATTA_ID_TIPO == TipoProceduraCoatta.CheckedItems[i].ToString();
                    }
                    else
                    {
                        exp = (FieldName)SearchParameters.PROCEDURA_COATTA_ID_TIPO == TipoProceduraCoatta.CheckedItems[i].ToString();
                    }
                }

                query &= exp;
            }

            if (Commissario.Tag != null)
            {
                int idCommissario = -1;
                if (Int32.TryParse(Commissario.Tag.ToString(), out idCommissario))
                {
                    if (idCommissario > 0)
                        query &= (FieldName)SearchParameters.PROCEDURA_COATTA_ID_SOGGETTO == idCommissario;
                }
            }

            if (query == null || query.ToString().Equals(string.Empty))
                return false;

            return true;
        }

        private void OpenCooperative()
        {
            //if (!NotToOpen)
            //{
            CooperativaRicercaFDT item = GetCurrentItem();
            if (item != null)
            {
                OpenForEdit(item);
            }
            //}
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
                        page.OpenSelectedTab("xtraTabPageSanzioni", "xtraTabPageProcedureCoatte");
                        //page.RequestSearch += new EventHandler(page_RequestSearch);
                    }
                }
                else
                {
                    ShowInformationMessage("Cooperativa già aperta a video", string.Empty);
                }
            }
        }

        #endregion Private Methods

        private void btnRemoveRevisore_Click(object sender, EventArgs e)
        {
            Commissario.Text = string.Empty;
            Commissario.Tag = null;
        }

        private void ResetParameters()
        {
            this.cooperativaDati1.ResetParameters();

            DataInizioProceduraDal.DateTime = DateTime.MinValue;
            DataInizioProceduraAl.DateTime = DateTime.MinValue;
            StatoConclusione.SelectedIndex = 0;
       
            Commissario.Text = string.Empty;
            Commissario.Tag = null;

            for (int i = 0; i < TipoProceduraCoatta.ItemCount; i++)
                TipoProceduraCoatta.SetItemChecked(i, false);
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
    }
}
