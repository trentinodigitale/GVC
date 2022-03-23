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

namespace it.dedagroup.GVC.Client.Forms.Search.Documentazione
{
    public partial class DocumentazioniSearch : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        #region Instance Variables

        private DocumentazioneFDT parametri_doc = null;
        private Expression query = null;

        #endregion Instance Variables

        #region Constructors (1)

        public DocumentazioniSearch()
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
            //phf.Header.Content.AddRange(new string[] { String.Concat("PARAMETRI DI RICERCA", Environment.NewLine, ""), null, String.Concat(Environment.NewLine, "Ricerca documentazione") });
            phf.Header.Content.AddRange(new string[] { null, null, String.Concat(Environment.NewLine, "Ricerca documentazione") });
          
            pcl.ShowPreviewDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private byte[] GetContentOfDocumentation(DocumentazioneRicercaFDT item)
        {
            byte[] toReturn = null;
            if (item != null)
            {
                if (item.Allegati != null)
                {
                    toReturn = item.Allegati;
                }
                else
                {
                    if (item.IdDocumentazione >= 0)
                    {
                        toReturn = GVCSystemEngine.InvokeService<ICooperatives, Byte[]>
                            (
                            delegate()
                            {
                                return GVCSystemEngine.Cooperatives.GetDocumentazioneByID(item.IdDocumentazione);
                            },
                            true);
                    }
                }
            }
            return toReturn;
        }

        private void gridControlCooperative_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!gridControlCooperative.FocusedView.Name.Equals(gridViewDocumentazioni.Name))
            {
                OpenCooperative();
            }
        }

        private void DocumentazioniSearch_Load(object sender, EventArgs e)
        {
            SetFormTitle("Ricerca documentazione");

            this.bindingSourceDocumentationTypes.DataSource = GVCSystemEngine.RemoveEmptyElement(GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_DOCUMENTO));

            CooperativaFDT parametri_coop = new CooperativaFDT();
            parametri_coop.RegistroCooperativa = new RegistroCooperativaFDT();
            this.cooperativaDati1.SetBindableData(parametri_coop);

            parametri_doc = new DocumentazioneFDT();
            this.bindingSourceParametriDoc.DataSource = parametri_doc;
        }

        private void gridViewDocumentazioni_DoubleClick(object sender, EventArgs e)
        {
            if (sender is DevExpress.XtraGrid.Views.Grid.GridView)
            {
                DevExpress.XtraGrid.Views.Grid.GridView gView =
                        sender as DevExpress.XtraGrid.Views.Grid.GridView;

                if (gView != null)
                {
                    //if (gView.FocusedColumn.Name == colAllegati.Name)
                    //{
                    DocumentazioneRicercaFDT item = gView.GetRow(gView.FocusedRowHandle) as DocumentazioneRicercaFDT;

                    if (item != null)
                    {
                        try
                        {
                            if (!String.IsNullOrEmpty(item.NomeFile))
                            {
                                Byte[] content = GetContentOfDocumentation(item);

                                if (content != null)
                                {
                                    item.Allegati = content;

                                    String path = System.IO.Path.GetTempPath();
                                    path = String.Concat(path, System.IO.Path.GetFileName(item.NomeFile));

                                    System.IO.FileInfo fi = new System.IO.FileInfo(path);
                                    if (System.IO.File.Exists(path))
                                    {
                                        fi.IsReadOnly = false;
                                        System.IO.File.Delete(path);
                                    }

                                    using (System.IO.FileStream fs = System.IO.File.Open(
                                                                            path,
                                                                            System.IO.FileMode.Create,
                                                                            System.IO.FileAccess.Write))
                                    {
                                        using (System.IO.BinaryWriter binWriter = new System.IO.BinaryWriter(fs))
                                        {
                                            binWriter.Write(item.Allegati);
                                        }
                                    }

                                    fi = new System.IO.FileInfo(path);
                                    fi.IsReadOnly = true;

                                    System.Diagnostics.Process.Start(path);
                                }
                                else
                                {
                                    ShowInformationMessage("Il documento è privo di contenuto; verificare il dato sul database.", string.Empty);
                                }
                            }
                            else
                            {
                                ShowInformationMessage("Il documento non ha nome, nè estensione e dunque non può essere aperto.", string.Empty);
                            }
                        }
                        catch
                        {
                            ShowProblemsMessage();
                        }
                    }
                    //}
                }
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

            this.bindingSourceParametriDoc.EndEdit();

            if (this.checkedListBoxTipi.CheckedItems != null &&
                this.checkedListBoxTipi.CheckedItems.Count > 0)
            {
                Expression tp = null;
                foreach (object itemChecked in checkedListBoxTipi.CheckedItems)
                {
                    DizionarioFDT item = itemChecked as DizionarioFDT;
                    tp |= (FieldName)SearchParameters.DOC_ID_TIPO == item.IdElemento;
                }

                query &= tp;
            }
           
            if (!String.IsNullOrEmpty(parametri_doc.Titolo))
                query &= (FieldName)SearchParameters.DOC_TITOLO % GVCSystemEngine.RemoveDiacritics(parametri_doc.Titolo);

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
                        return GVCSystemEngine.Cooperatives.GetDocumentazioneBySearch(query, cooperativaDati1.GetIndexIscrizione(), cooperativaDati1.GetIndexAdesione(), cooperativaDati1.GetDataIscrizione(), cooperativaDati1.GetDataAdesione(), cooperativaDati1.GetIDAssociazione());
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
                        page.OpenSelectedTab("xtraTabPageDocumentation");
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

            parametri_doc = new DocumentazioneFDT();
            this.bindingSourceParametriDoc.DataSource = parametri_doc;

            for (int i = 0; i < checkedListBoxTipi.ItemCount; i++)
                checkedListBoxTipi.SetItemChecked(i, false);
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
