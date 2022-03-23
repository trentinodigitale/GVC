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

namespace it.dedagroup.GVC.Client.Forms.Search.Sanzioni.LiquidazioneCoatta
{
    public partial class LiquidazioneCoattaSearch : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {

        #region Private properties

        private Expression query = null;

        private CooperativaFDT parametri_coop = null;

        #endregion Private properties

        public LiquidazioneCoattaSearch()
        {
            InitializeComponent();

            SetImages();
        }

        private void LiquidazioneCoattaSearch_Load(object sender, EventArgs e)
        {
            SetFormTitle("Ricerca liquidazioni coatte amministrative");

            bindingSourceLiquidationsTypes.DataSource = GVCSystemEngine.RemoveEmptyElement(GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_LIQUIDAZIONI_COATTE));
            bindingSourceAuthorizationType.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_AUTORIZZAZIONE);

            parametri_coop = new CooperativaFDT();
            parametri_coop.RegistroCooperativa = new RegistroCooperativaFDT();
            this.bindingSourceParametriCoop.DataSource = parametri_coop;
            this.cooperativaDati1.SetBindableData(parametri_coop);
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
                        return GVCSystemEngine.Cooperatives.GetListLiquidazioniCoatteBySearch(query, cooperativaDati1.GetIndexIscrizione(), cooperativaDati1.GetIndexAdesione(), cooperativaDati1.GetDataIscrizione(), cooperativaDati1.GetDataAdesione(), cooperativaDati1.GetIDAssociazione());
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

        private void SetImages()
        {
            this.btnRemoveRevisore.Image = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
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
                        page.OpenSelectedTab("xtraTabPageSanzioni", "xtraTabPageLiquidazioniCoatte");
                        //page.RequestSearch += new EventHandler(page_RequestSearch);
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

            query &= this.cooperativaDati1.GetQueryCoop();

            if (DataDeliberaGiuntaDal.DateTime > DateTime.MinValue)
            {
                query &= (FieldName)SearchParameters.LIQUIDAZIONE_COATTA_DATA_GIUNTA >= DataDeliberaGiuntaDal.DateTime;
            }

            if (DataDeliberaGiuntaAl.DateTime > DateTime.MinValue)
            {
                query &= (FieldName)SearchParameters.LIQUIDAZIONE_COATTA_DATA_GIUNTA <= DataDeliberaGiuntaAl.DateTime;
            }

            if (DepositoBFLYes.Checked)
            {
                query &= (FieldName)SearchParameters.LIQUIDAZIONE_COATTA_DEPOSITO_BFL == 1;
            }
            if (DepositoBFLNo.Checked)
            {
                query &= (FieldName)SearchParameters.LIQUIDAZIONE_COATTA_DEPOSITO_BFL == 0;
            }

            if (ProceduraConclusaYes.Checked)
            {
                query &= (FieldName)SearchParameters.LIQUIDAZIONE_COATTA_PROCEDURA_CONCLUSA == 1;
            }
            if (ProceduraConclusaNo.Checked)
            {
                query &= (FieldName)SearchParameters.LIQUIDAZIONE_COATTA_PROCEDURA_CONCLUSA == 0;
            }

            if (ProceduraRevocataYes.Checked)
            {
                query &= (FieldName)SearchParameters.LIQUIDAZIONE_COATTA_PROCEDURA_REVOCATA == 1;
            }
            if (ProceduraRevocataNo.Checked)
            {
                query &= (FieldName)SearchParameters.LIQUIDAZIONE_COATTA_PROCEDURA_REVOCATA == 0;
            }

            if (LiquidazioneSpesePATYes.Checked)
            {
                query &= (FieldName)SearchParameters.LIQUIDAZIONE_COATTA_SPESE_CARICO_PAT > 0;
            }
            if (LiquidazioneSpesePATNo.Checked)
            {
                Expression exp = null;

                exp &= new Expression((FieldName)SearchParameters.LIQUIDAZIONE_COATTA_SPESE_CARICO_PAT_ID, Operators.Is, DBNull.Value);
                exp |= (FieldName)SearchParameters.LIQUIDAZIONE_COATTA_SPESE_CARICO_PAT <= 0;
                query &= exp;
            }  

            if (AcquistoCreditiFiscaliYes.Checked)
            {
                query &= new Expression((FieldName)SearchParameters.LIQUIDAZIONE_COATTA_ACQUISTO_CREDITI_FISCALI, Operators.IsNot, DBNull.Value);
            }
            if (AcquistoCreditiFiscaliNo.Checked)
            {
                query &= new Expression((FieldName)SearchParameters.LIQUIDAZIONE_COATTA_ACQUISTO_CREDITI_FISCALI, Operators.Is, DBNull.Value);
            }                

            if (!CodiceUfficio.Text.Equals(String.Empty))
            {
                query &= (FieldName)SearchParameters.LIQUIDAZIONE_COATTA_CODICE_UFFICIO == CodiceUfficio.Text; 
            }

            if (TipoLiquidazione.CheckedItems.Count > 0)
            {
                Expression exp = null;

                for (int i = 0; i < TipoLiquidazione.CheckedItems.Count; i++)
                {
                    if (i > 0)
                    {
                        exp |= (FieldName)SearchParameters.LIQUIDAZIONE_COATTA_ID_TIPO == TipoLiquidazione.CheckedItems[i].ToString();
                    }
                    else
                    {
                        exp = (FieldName)SearchParameters.LIQUIDAZIONE_COATTA_ID_TIPO == TipoLiquidazione.CheckedItems[i].ToString();
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
                        query &= (FieldName)SearchParameters.LIQUIDAZIONE_COATTA_ID_SOGGETTO == idCommissario;
                }
            }
                       

            if (query == null || query.ToString().Equals(string.Empty))
                return false;

            return true;
        }

        private void ResetParameters()
        {
            this.cooperativaDati1.ResetParameters();

            DataDeliberaGiuntaDal.DateTime = DateTime.MinValue;
            DataDeliberaGiuntaAl.DateTime = DateTime.MinValue;
            DepositoBFLYes.Checked = false;
            DepositoBFLNo.Checked = false;
            ProceduraConclusaYes.Checked = false;
            ProceduraConclusaNo.Checked = false;
            ProceduraRevocataYes.Checked = false;
            ProceduraRevocataNo.Checked = false;
            LiquidazioneSpesePATYes.Checked = false;
            LiquidazioneSpesePATNo.Checked = false;
            AcquistoCreditiFiscaliYes.Checked = false;
            AcquistoCreditiFiscaliNo.Checked = false;
            CodiceUfficio.Text = String.Empty;

            Commissario.Tag = null;
            Commissario.Text = String.Empty;

            for (int i = 0; i < TipoLiquidazione.ItemCount; i++)
                TipoLiquidazione.SetItemChecked(i, false);

        }

        private void barButtonItemStampa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.XtraPrinting.PrintingSystem ps = new DevExpress.XtraPrinting.PrintingSystem();
            DevExpress.XtraPrinting.PrintableComponentLink pcl = new DevExpress.XtraPrinting.PrintableComponentLink();

            ps.Links.Add(pcl);
            pcl.Component = gridControlCooperative;

            ps.Links[0].Landscape = true;

            DevExpress.XtraPrinting.PageHeaderFooter phf = ps.Links[0].PageHeaderFooter as DevExpress.XtraPrinting.PageHeaderFooter;
            //phf.Header.Content.AddRange(new string[] { String.Concat("PARAMETRI DI RICERCA", Environment.NewLine, ""), null, String.Concat(Environment.NewLine, "Ricerca liquidazioni coatte") });
            phf.Header.Content.AddRange(new string[] { null, null, String.Concat(Environment.NewLine, "Ricerca liquidazioni coatte") });

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

        private void btnRemoveRevisore_Click(object sender, EventArgs e)
        {
            this.Commissario.Text = string.Empty;
            this.Commissario.Tag = null;
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
