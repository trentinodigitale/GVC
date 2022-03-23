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
    public partial class RevisioniDaEffettuareSearch : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        #region Instance Variables

        private RevisioneFDT parametri_revisione = null;
        private CooperativaFDT parametri_coop = null;
        private Expression query = null;
        private Dizionari items = null;

        #endregion Instance Variables

        #region Constructors (1)

        public RevisioniDaEffettuareSearch()
        {
            InitializeComponent();
            SetImages();
        }

        #endregion Constructors

        #region Event Handlers

        private void RevisioniDaEffettuareSearch_Load(object sender, EventArgs e)
        {
            SetFormTitle("Ricerca revisioni da registrare");

            DizionarioFDT[] listaCadenze = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.CADENZA_REVISIONI);
            items = new Dizionari();
            items.AddRange(listaCadenze);

            this.bindingSourceBaseRevisionCadence.DataSource = listaCadenze;
            this.bindingSourceTipoRevisione.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_REVISIONE);
            this.bindingSourceBaseStato.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.STATI_ISCRIZIONE);
            this.bindingSourceEsitiRevisione.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.ESITI_REVISIONE);

            SetObjects();

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
            phf.Header.Content.AddRange(new string[] { String.Concat("PARAMETRI DI RICERCA", Environment.NewLine, ""), null, String.Concat(Environment.NewLine, "Ricerca revisioni da effettuare") });
            //DevExpress.XtraPrinting.PageHeaderFooter phf = ps.Links[0].PageHeaderFooter as DevExpress.XtraPrinting.PageHeaderFooter;
            //phf.Header.Content.AddRange(new string[] { String.Concat("PARAMETRI DI RICERCA", Environment.NewLine, sb.ToString()), null, String.Concat(Environment.NewLine, sb1.ToString()) });

            pcl.ShowPreviewDialog();
        }

        private void barButtonItemAzzera_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ResetParameters();
        }

        private void simpleButtonSearchAss_Click(object sender, EventArgs e)
        {
            SoggettoFDT item = new PersonaGiuridicaFDT();
            item.Note = this.textEditAssociazione.Text;

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

        private void radioGroupAdesione_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroupAdesione.SelectedIndex == 1)
            {
                AbilitaAssociazione(true);
            }
            else
            {
                AbilitaAssociazione(false);
            }
        }

        #endregion Event Handlers

        #region Private Methods

        private void SetObjects()
        {
            parametri_coop = new CooperativaFDT();
            parametri_coop.RegistroCooperativa = new RegistroCooperativaFDT();
            parametri_coop.RegistroCooperativa.IdCadenzaRevisione = 3;
            parametri_coop.RegistroCooperativa.DataUltimaModifica = DateTime.Today;
            parametri_coop.DataUltimaModifica = DateTime.Today;
            this.bindingSourceParametriCoop.DataSource = parametri_coop;

            parametri_revisione = new RevisioneFDT();
            parametri_revisione.AnnoRevisione = DateTime.Now.Year;
            parametri_revisione.IdTipoRevisione = TipoRevisione.BIENNALE;
            this.bindingSourceParametriRevisione.DataSource = parametri_revisione;
        }

        private int GetIndexIscrizione()
        {
            return this.radioGroupIscrizione.SelectedIndex;
        }

        private int GetIndexAdesione()
        {
            return this.radioGroupAdesione.SelectedIndex;
        }

        private DateTime GetDataIscrizione()
        {
            DateTime toReturn = DateTime.Today;

            if (parametri_coop.DataUltimaModifica.HasValue)
            {
                toReturn = parametri_coop.DataUltimaModifica.Value;
            }

            return toReturn;
        }

        private int GetIDAssociazione()
        {
            int toReturn = 0;
            if (parametri_revisione != null)
            {
                toReturn = parametri_revisione.IdOrganoRevisore;
            }

            return toReturn;
        }

        private DateTime GetDataAdesione()
        {
            DateTime toReturn = DateTime.Today;

            if (parametri_coop.RegistroCooperativa != null &&
                parametri_coop.RegistroCooperativa.DataUltimaModifica.HasValue)
            {
                toReturn = parametri_coop.RegistroCooperativa.DataUltimaModifica.Value;
            }

            return toReturn;
        }

        private bool DefineParameters()
        {
            query = null;
            
            Expression queryRev = null;
            Expression queryDoc = null;
            Expression queryStr = null;

            DizionarioFDT dettCadenzaRev = items.FindByID(parametri_coop.RegistroCooperativa.IdCadenzaRevisione);
            
            this.bindingSourceParametriCoop.EndEdit();

            this.bindingSourceParametriRevisione.EndEdit();

            int cadRev = 0;
            if (dettCadenzaRev.Dettaglio.Tempi.HasValue)
                cadRev = dettCadenzaRev.Dettaglio.Tempi.Value;

            query &= (FieldName)SearchParameters.STATO_SOGG_REV == 0;

            if (parametri_coop.RegistroCooperativa.IdCadenzaRevisione > 0)
                query &= (FieldName)SearchParameters.CADENZA_REV == parametri_coop.RegistroCooperativa.IdCadenzaRevisione;           

            if (parametri_revisione.AnnoRevisione > 0 &&
                parametri_revisione.IdTipoRevisione > 0) //controllo...
            {
                queryRev &= (FieldName)SearchParameters.REV_ANNO == parametri_revisione.AnnoRevisione - cadRev;

                queryRev &= (FieldName)SearchParameters.REV_ID_TIPO == parametri_revisione.IdTipoRevisione;

                queryDoc &= queryRev;

                Expression tp = null;
                DateTime dataRifInizio = new DateTime(parametri_revisione.AnnoRevisione - cadRev, 1, 1);
                DateTime dataRifFine = new DateTime(parametri_revisione.AnnoRevisione - cadRev, 12, 31);

                tp &= (FieldName)SearchParameters.DATA_COSTITUZIONE >= dataRifInizio;
                tp &= (FieldName)SearchParameters.DATA_COSTITUZIONE <= dataRifFine;

                queryDoc |= tp;

                queryStr &= (FieldName)SearchParameters.REV_ANNO > parametri_revisione.AnnoRevisione - cadRev;

                Expression st = null;
                st &= (FieldName)SearchParameters.REV_ID_TIPO == TipoRevisione.BIENNALE_STRAORDINARIA;
                st |= (FieldName)SearchParameters.REV_ID_TIPO == TipoRevisione.STRAORDINARIA;

                queryStr &= st;

                queryDoc |= queryStr;

            }

            query &= queryDoc;

            if (query == null || query.ToString().Equals(string.Empty))
                return false;

            return true;
        }

        private void Search()
        {
            lblResults.Text = "0";

            this.bindingSourceCooperative.DataSource = null;

            if (DefineParameters() &&
                parametri_revisione.AnnoRevisione > 0 &&
                parametri_coop.RegistroCooperativa.IdCadenzaRevisione > 0)
            {
                RevisioneCooperativaFlatFDT[] lTemp = GVCSystemEngine.InvokeService<ICooperatives, RevisioneCooperativaFlatFDT[]>
                    (delegate()
                    {
                        return GVCSystemEngine.Cooperatives.GetRevisioniDaEffettuareBySearch(query, GetIndexIscrizione(), GetIndexAdesione(), GetDataIscrizione(), GetDataAdesione(), GetIDAssociazione());
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
                if (parametri_revisione.AnnoRevisione <= 0)
                {
                    ShowInformationMessage("Definire l'anno di riferimento per la ricerca", string.Empty);
                }
                else if (parametri_coop.RegistroCooperativa.IdCadenzaRevisione <= 0)
                {
                    ShowInformationMessage("Definire la cadenza di revisione per la ricerca", string.Empty);
                }
            }
        }

        private void SetImages()
        {
            this.btnRemoveSubject.Image = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
        }

        private RevisioneCooperativaFlatFDT GetCurrentItem()
        {
            RevisioneCooperativaFlatFDT toReturn = null;
            if (this.bindingSourceCooperative.Current != null)
                toReturn = this.bindingSourceCooperative.Current as RevisioneCooperativaFlatFDT;
            return toReturn;
        }

        private void OpenCooperative()
        {
            RevisioneCooperativaFlatFDT item = GetCurrentItem();
            if (item != null)
            {
                OpenForEdit(item);
            }
        }

        private void OpenForEdit(RevisioneCooperativaFlatFDT item)
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

        private void ResetParameters()
        {
            SetObjects();

            this.radioGroupAdesione.SelectedIndex = 0;
            this.radioGroupIscrizione.SelectedIndex = 1;
        }

        private void AbilitaAssociazione(Boolean abilita)
        {
            this.textEditAssociazione.Properties.ReadOnly = !abilita;
            this.btnRemoveSubject.Enabled = abilita;
            this.simpleButtonSearchAss.Enabled = abilita;

            if (!abilita)
            {
                if (parametri_revisione.Revisore != null)
                {
                    parametri_revisione.Revisore = null;
                    this.bindingSourceParametriRevisione.DataSource = parametri_revisione;
                }

                this.textEditAssociazione.Text = String.Empty;
            }
        }

        #endregion Private Methods
    }
}
