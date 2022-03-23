using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Client.Forms.Common;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Client.Forms.Cooperative;
using OeF.Utility;
using it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Data;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.RicercheWrapper;
using it.dedagroup.GVC.Repository.Common.Services;

namespace it.dedagroup.GVC.Client.Forms.Search
{
    public partial class CoopAdvancedSearch : UserControlBase
    {
        #region Instance Variables

        private CooperativaFDT parametri_coop = null;
        private RevisioneFDT parametri_rev = null;
        private Expression query = null;

        #endregion Instance Variables

        #region Constructors (1)

        public CoopAdvancedSearch()
        {
            InitializeComponent();

            SetImages();
        }

        #endregion Constructors

        #region Event Handlers

        private void CoopAdvancedSearch_Load(object sender, EventArgs e)
        {
            SetFormTitle("Ricerca avanzata cooperative");

            this.bindingSourceBaseConstitution.DataSource = GVCSystemEngine.RemoveEmptyElement(GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_COSTITUZIONE));
            this.bindingSourceBaseStato.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.STATI_ISCRIZIONE);
            this.bindingSourceBaseJuridicalForm.DataSource = GVCSystemEngine.RemoveEmptyElement(GVCSystemEngine.GetDizionarioByType(DictionaryTypes.FORME_GIURIDICHE));
            this.bindingSourceBaseRevisionCadence.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.CADENZA_REVISIONI);

            this.bindingSourceCategoriaSociale.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.CATEGORIA_SOCIALE);
            this.bindingSourceSottoCategoriaSociale.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.SOTTO_CATEGORIE);
            this.bindingSourceCategoria.DataSource = GVCSystemEngine.OrderActiveElement(GVCSystemEngine.GetDizionarioByType(DictionaryTypes.CATEGORIE));
            this.bindingSourceSezione.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.SEZIONE);

            this.bindingSourceActivityTypes.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.ATTIVITA);

            parametri_coop = new CooperativaFDT();
            parametri_coop.RegistroCooperativa = new RegistroCooperativaFDT();
             
            parametri_coop.RegistroCooperativa.IdStatoIscrizione = 0;
            this.bindingSourceParametriCoop.DataSource = parametri_coop;

            parametri_rev = new RevisioneFDT();

            this.bindingSourceRevisione.DataSource = parametri_rev;

            AbilitaAssociazione(false);
        }

        private void barButtonItemStampa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.XtraPrinting.PrintingSystem ps = new DevExpress.XtraPrinting.PrintingSystem();
            DevExpress.XtraPrinting.PrintableComponentLink pcl = new DevExpress.XtraPrinting.PrintableComponentLink();

            ps.Links.Add(pcl);
            pcl.Component = gridControlSoggetto;

            ps.Links[0].Landscape = true;

            DevExpress.XtraPrinting.PageHeaderFooter phf = ps.Links[0].PageHeaderFooter as DevExpress.XtraPrinting.PageHeaderFooter;
            //phf.Header.Content.AddRange(new string[] { String.Concat("PARAMETRI DI RICERCA", Environment.NewLine, ""), null, String.Concat(Environment.NewLine, "Ricerca annotazioni/scadenze") });
            phf.Header.Content.AddRange(new string[] { null, null, String.Concat(Environment.NewLine, "Ricerca cooperative") });

            pcl.ShowPreviewDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void gridControlSoggetto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenCooperative();
        }

        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            AttivitaFDT item = new AttivitaFDT();
            item.Status = ObjectStatus.ToInsert;

            if (OpenForEdit(item) == DialogResult.OK)
            {
                if (parametri_coop != null && parametri_coop.RegistroCooperativa != null)
                {
                    if (parametri_coop.RegistroCooperativa.Attivita == null)
                        parametri_coop.RegistroCooperativa.Attivita = new AttivitaFDT[] { };

                    List<AttivitaFDT> lTemp = new List<AttivitaFDT>(parametri_coop.RegistroCooperativa.Attivita);
                    lTemp.Add(item);
                    parametri_coop.RegistroCooperativa.Attivita = lTemp.ToArray();

                    this.bindingSourceBaseActivities.DataSource = parametri_coop.RegistroCooperativa.Attivita;
                }
            }
        }

        private void btnRemoveActivity_Click(object sender, EventArgs e)
        {
            AttivitaFDT item = GetCurrentItemAtt();
            if (item != null)
            {
                Boolean reallyRemove = false;
                if (item.IdAttivita <= 0)
                {
                    reallyRemove = true;
                }

                if (ShowConfirmMessage("Conferma operazione", "Confermi la rimozione dell'elemento selezionato?", string.Empty) == DialogResult.Yes)
                {
                    RemoveAttivita(item, reallyRemove);
                }
            }
        }

        private void barButtonItemExportResults_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dlg;

            CooperativaRicercaFDT[] results = this.bindingSourceBaseResults.DataSource as CooperativaRicercaFDT[];

             if ((results != null) && (results.Length > 0))
            {
                dlg = new SaveFileDialog();
                dlg.Filter = "xml files (*.xml)|*.xml";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (dlg.FileName.ToUpper().IndexOf(".xml".ToUpper()) < 0)
                    {
                        dlg.FileName = dlg.FileName + ".xml";
                    }

                    ExportResults(dlg.FileName, results);
                }
            }
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
                if (parametri_rev != null)
                {
                    parametri_rev.Revisore = item as PersonaGiuridicaFDT;
                    parametri_rev.IdOrganoRevisore = item.IdSoggetto;
                    this.bindingSourceRevisione.ResetBindings(false);
                }
            }
        }

        private void btnRemoveSubject_Click(object sender, EventArgs e)
        {
            if (parametri_rev != null)
            {
                parametri_rev.BeginEdit();

                parametri_rev.Revisore = null;
                parametri_rev.IdOrganoRevisore = -1;

                parametri_rev.EndEdit();

                this.bindingSourceRevisione.ResetBindings(false);
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

        private void SetImages()
        {
            this.btnRemoveSubject.Image = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
        }

        private int[] GetCategorie()
        {
            List<int> listCat = new List<int>();

            if (this.checkedListBoxCategorie.CheckedItems != null &&
               this.checkedListBoxCategorie.CheckedItems.Count > 0)
            {
                foreach (object itemChecked in checkedListBoxCategorie.CheckedItems)
                {
                    DizionarioFDT item = itemChecked as DizionarioFDT;
                    listCat.Add(item.IdElemento);
                }
            }

            return listCat.ToArray();
        }

        private int GetSezione()
        {
            return parametri_coop.IdTipoSoggetto;
        }

        private int GetCategoriaSoc()
        {
            return this.radioGroupSociale.SelectedIndex;
        }

        private int GetSottoCatSoc()
        {
            return parametri_coop.IdSoggetto;
        }

        private bool DefineParameters()
        {
            query = null;

            //this.cooperativaDati1.BindingSourceEndInit();

            this.bindingSourceParametriCoop.EndEdit();

            #region dati generali

            if (parametri_coop.RegistroCooperativa.IdRegistro > 0)
                query &= (FieldName)SearchParameters.CODICE_COOPERATIVA == parametri_coop.RegistroCooperativa.IdRegistro;

            if (!String.IsNullOrEmpty(parametri_coop.RegistroCooperativa.NumeroREA))
                query &= (FieldName)SearchParameters.NUMERO_REA == parametri_coop.RegistroCooperativa.NumeroREA;
            
            if (!String.IsNullOrEmpty(parametri_coop.Denominazione))
                query &= (FieldName)SearchParameters.DENOMINAZIONE % GVCSystemEngine.RemoveDiacritics(parametri_coop.Denominazione);

            if (!String.IsNullOrEmpty(parametri_coop.CodiceFiscale))
                query &= (FieldName)SearchParameters.CODICE_FISCALE % parametri_coop.CodiceFiscale;

            //if (parametri_coop.RegistroCooperativa.IdStatoIscrizione > 0)
            //    query &= (FieldName)SearchParameters.STATO_ISCRIZIONE == parametri_coop.RegistroCooperativa.IdStatoIscrizione;

            if (this.checkedListBoxStati.CheckedItems != null &&
             this.checkedListBoxStati.CheckedItems.Count > 0)
            {
                Expression st = null;
                foreach (object itemChecked in checkedListBoxStati.CheckedItems)
                {
                    DizionarioFDT item = itemChecked as DizionarioFDT;
                    st |= (FieldName)SearchParameters.STATO_ISCRIZIONE == item.IdElemento;
                }
                query &= st;
            }

            if (parametri_coop.RegistroCooperativa.IdCadenzaRevisione > 0)
                query &= (FieldName)SearchParameters.CADENZA_REV == parametri_coop.RegistroCooperativa.IdCadenzaRevisione;

            if (checkEditEsenteVersamento.Checked)
                query &= (FieldName)SearchParameters.ESENTE_VERSAM_UTILI == "1";

            if (checkEditGruppo.Checked)
                query &= (FieldName)SearchParameters.FLAG_GRUPPO == "1";

            if (this.checkedListBoxFormaGiurid.CheckedItems != null &&
                this.checkedListBoxFormaGiurid.CheckedItems.Count > 0)
            {
                Expression fg = null;
                foreach (object itemChecked in checkedListBoxFormaGiurid.CheckedItems)
                {
                    DizionarioFDT item = itemChecked as DizionarioFDT;
                    fg |= (FieldName)SearchParameters.FORMA_GIURIDICA == item.IdElemento;
                }
                query &= fg;
            }

            if (!String.IsNullOrEmpty(parametri_coop.RegistroCooperativa.CodiceOperatore))
                query &= (FieldName)SearchParameters.COD_OPERATORE == parametri_coop.RegistroCooperativa.CodiceOperatore;

            if (!String.IsNullOrEmpty(parametri_coop.RegistroCooperativa.CodiceUfficio))
                query &= (FieldName)SearchParameters.COD_UFF == parametri_coop.RegistroCooperativa.CodiceUfficio;

            if (parametri_coop.RegistroCooperativa.BilancioEsercizioAl.HasValue)
                query &= (FieldName)SearchParameters.DATA_BILANCIO == String.Concat(parametri_coop.RegistroCooperativa.BilancioEsercizioAl.Value.Day,parametri_coop.RegistroCooperativa.BilancioEsercizioAl.Value.Month) ;

            #endregion dati generali

            #region dati indirizzo sede

            if (!String.IsNullOrEmpty(this.textEditComune.Text))
                query &= (FieldName)SearchParameters.INDIRIZZO_SEDE % this.textEditComune.Text.ToUpper();

            #endregion dati indirizzo sede

            #region dati costituzione

            if (parametri_coop.RegistroCooperativa.DataCostituzione.HasValue)
                query &= (FieldName)SearchParameters.DATA_COSTITUZIONE > parametri_coop.RegistroCooperativa.DataCostituzione.Value;

            if (this.checkedListBoxTipoCost.CheckedItems != null &&
                this.checkedListBoxTipoCost.CheckedItems.Count > 0)
            {
                Expression tp = null;
                foreach (object itemChecked in checkedListBoxTipoCost.CheckedItems)
                {
                    DizionarioFDT item = itemChecked as DizionarioFDT;
                    tp |= (FieldName)SearchParameters.TIPO_COSTITUZIONE == item.IdElemento;
                }
                query &= tp;
            }

            #endregion dati costituzione

            #region dati attivita

            if (parametri_coop.RegistroCooperativa.Attivita != null &&
                parametri_coop.RegistroCooperativa.Attivita.Length > 0)
            {
                Expression att = null;
                foreach (AttivitaFDT itemAtt in parametri_coop.RegistroCooperativa.Attivita)
                {
                    att |= (FieldName)SearchParameters.ATTIVITA == itemAtt.IdTipoAttivita;
                }

                query &= att;

                if (this.radioGroupTipoAttivita.SelectedIndex == 2)
                    query &= (FieldName)SearchParameters.ATT_FLAG_CCIAA == "1";
                else
                    query &= (FieldName)SearchParameters.ATT_FLAG_CCIAA == "0";
            }

            #endregion dati attivita

            //query &= this.cooperativaDati1.GetQueryCoop();

            if (query == null || query.ToString().Equals(string.Empty))
                return false;

            return true;
        }

        private void Search()
        {
            lblResults.Text = "0";

            this.bindingSourceBaseResults.DataSource = null;

            //if (DefineParameters() || cooperativaDati1.DefineParametrs())
            //{
            DefineParameters();

            DateTime dataIscrizione = DateTime.Today;

            if (parametri_coop.DataUltimaModifica.HasValue)
            {
                dataIscrizione = parametri_coop.DataUltimaModifica.Value;
            }

            DateTime dataAdesione = DateTime.Today;

            if (parametri_coop.RegistroCooperativa != null &&
                parametri_coop.RegistroCooperativa.DataUltimaModifica.HasValue)
            {
                dataAdesione = parametri_coop.RegistroCooperativa.DataUltimaModifica.Value;
            }

            int idAssociazione = 0;

            if (parametri_rev != null &&
                parametri_rev.IdOrganoRevisore > 0)
            {
                idAssociazione = parametri_rev.IdOrganoRevisore;
            }

            CooperativaRicercaFDT[] lTemp = GVCSystemEngine.InvokeService<ICooperatives, CooperativaRicercaFDT[]>
                (delegate()
                {
                    return GVCSystemEngine.Cooperatives.GetListCooperativeBySearchAdvanced(query, this.radioGroupIscrizione.SelectedIndex, this.radioGroupAdesione.SelectedIndex, dataIscrizione, dataAdesione, idAssociazione, GetCategorie(), GetSezione(), GetCategoriaSoc(), GetSottoCatSoc());
                },
                true);

            if (lTemp != null)
            {
                this.lblResults.Text = lTemp.Length.ToString();

                this.bindingSourceBaseResults.DataSource = lTemp;
            }
            else
            {
                this.lblResults.Text = "0";
                this.bindingSourceBaseResults.DataSource = null;
            }
            //}
            //else
            //{
            //    ShowInformationMessage("Definire almeno un parametro di ricerca", string.Empty);
            //}
        }

        private DialogResult OpenForEdit(AttivitaFDT item)
        {
            RicercaAttivita ra = CreatePageDialog<RicercaAttivita>();
            if (ra != null)
            {
                ra.SetBindableData();
                ra.SetFormTitle("Aggiungi attività");

                DialogResult dr = DialogResult.OK;
                while (dr == DialogResult.OK)
                {
                    dr = ra.BaseForm.ShowDialog(this, false);

                    DizionarioFDT it = ra.GetSelectedItem();
                    if (it != null)
                        item.IdTipoAttivita = it.IdElemento;

                    if (dr == DialogResult.OK)
                        break;
                }
                return dr;
            }
            else
            {
                return DialogResult.Cancel;
            }
        }


        private AttivitaFDT GetCurrentItemAtt()
        {
            AttivitaFDT toReturn = null;
            if (this.bindingSourceBaseActivities.Current != null)
                toReturn = this.bindingSourceBaseActivities.Current as AttivitaFDT;
            return toReturn;
        }

        private void RemoveAttivita(AttivitaFDT item, bool reallyRemove)
        {
            if (parametri_coop != null && parametri_coop.RegistroCooperativa != null &&
                parametri_coop.RegistroCooperativa.Attivita != null)
            {
                List<AttivitaFDT> lTemp = new List<AttivitaFDT>();

                foreach (AttivitaFDT counter in parametri_coop.RegistroCooperativa.Attivita)
                {
                    if (counter.IdTipoAttivita == item.IdTipoAttivita)
                    {
                        if (!reallyRemove)
                        {
                            counter.Status = ObjectStatus.ToCancel;
                            lTemp.Add(counter);
                        }
                    }
                    else
                    {
                        lTemp.Add(counter);
                    }
                }

                parametri_coop.RegistroCooperativa.Attivita = lTemp.ToArray();
                this.bindingSourceBaseActivities.DataSource = parametri_coop.RegistroCooperativa.Attivita;
            }
        }

        private CooperativaRicercaFDT GetCurrentItem()
        {
            CooperativaRicercaFDT toReturn = null;
            if (this.bindingSourceBaseResults.Current != null)
                toReturn = this.bindingSourceBaseResults.Current as CooperativaRicercaFDT;
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

        private void ExportResults(string filepath, CooperativaRicercaFDT[] results)
        {
            int[] idToExport;
            
            if ((results != null) && (results.Length > 0))
            {
                idToExport = new int[results.Length];

                for (int i = 0; i < results.Length; i++)
                {
                    idToExport[i] = results[i].IdSoggetto;
                }

                DataSet dsExport = GVCSystemEngine.InvokeService<ICooperatives, DataSet>
                (delegate()
                {
                    return GVCSystemEngine.Cooperatives.GetCooperativeDaEsportare(idToExport);
                },
                true);

                dsExport.WriteXml(filepath, XmlWriteMode.DiffGram);
            }
        }

        private void ResetParameters()
        {
            parametri_coop = new CooperativaFDT();
            parametri_coop.RegistroCooperativa = new RegistroCooperativaFDT();
            parametri_coop.DataUltimaModifica = null; 
            parametri_coop.RegistroCooperativa.DataUltimaModifica = null; 
            parametri_coop.RegistroCooperativa.IdStatoIscrizione = 0;

            this.bindingSourceParametriCoop.DataSource = parametri_coop;

            parametri_rev = new RevisioneFDT();

            this.bindingSourceRevisione.DataSource = parametri_rev;

            this.radioGroupAdesione.SelectedIndex = 0;
            this.radioGroupIscrizione.SelectedIndex = 0;

            this.bindingSourceBaseActivities.DataSource = null;

            for (int i = 0; i < checkedListBoxStati.ItemCount; i++)
                checkedListBoxStati.SetItemChecked(i, false);

            for (int i = 0; i < checkedListBoxFormaGiurid.ItemCount; i++)
                checkedListBoxFormaGiurid.SetItemChecked(i, false);

            for (int i = 0; i < checkedListBoxCategorie.ItemCount; i++)
                checkedListBoxCategorie.SetItemChecked(i, false);

            for (int i = 0; i < checkedListBoxTipoCost.ItemCount; i++)
                checkedListBoxTipoCost.SetItemChecked(i, false);

            radioGroupSociale.SelectedIndex = 0;
            radioGroupTipoAttivita.SelectedIndex = 0;

            checkEditEsenteVersamento.Checked = false;
            checkEditGruppo.Checked = false;
        }

        private void AbilitaAssociazione(Boolean abilita)
        {
            this.textEditAssociazione.Properties.ReadOnly = !abilita;
            this.btnRemoveSubject.Enabled = abilita;
            this.simpleButtonSearchAss.Enabled = abilita;

            if (!abilita)
            {
                if (parametri_rev.Revisore != null)
                {
                    parametri_rev.Revisore = null;
                    this.bindingSourceRevisione.DataSource = parametri_rev;
                }

                this.textEditAssociazione.Text = String.Empty;
            }
        }

        #endregion Private Methods
    }
}
