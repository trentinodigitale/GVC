using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.Configurations;
using OeF.Utility;
using it.dedagroup.GVC.Repository.Common.Services;
using it.dedagroup.GVC.Repository.Common.Converters;
using it.dedagroup.GVC.Client.Forms.Registry;
using it.dedagroup.GVC.Client.Forms.Common;
using System.Xml.Serialization;
using System.IO;

namespace it.dedagroup.GVC.Client.Forms.Search
{
    public partial class SubjectSearch : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        private Expression query = null;
        private SoggettoPerVisualizzazioneFDT[] results = null;
        private List<DizionarioFDT> subjectTypes = null;

        public SubjectSearch()
        {
            InitializeComponent();

            if (!DesignMode)
            {
                EnableControlAutoSize(new object[] { this, gridControlSoggetto }, gridControlSoggetto, 290);

                SetImages();

                Init();
            }

            this.ConfirmCancel = false;
        }

        private void Init()
        {
            subjectTypes = new List<DizionarioFDT>();

            DizionarioFDT empty = new DizionarioFDT();
            empty.IdElemento = -1;
            empty.Descrizione = "TUTTI I TIPI";
            subjectTypes.Add(empty);

            DizionarioFDT[] temp = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_SOGGETTO);
            if (temp != null)
                subjectTypes.AddRange(temp);
            this.bindingSourceBaseTipoSoggetto.DataSource = subjectTypes.ToArray();

            if (subjectTypes != null && subjectTypes.Count > 0)
            {
                this.lookUpEditSubjectType.EditValue = subjectTypes[0].IdElemento;
            }
        }

        private void SetImages()
        {
            this.barButtonItemAdd.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Add_24x24);
            this.barButtonItemOpen.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Star_Yellow_24x24);
            this.barButtonItemRemove.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddSoggetto();
        }

        private void barButtonItemOpen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenSubject();
        }

        private void gridViewSoggetto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenSubject();
        }


        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                Search();
                return true;
            }
            else
            {
                return base.ProcessDialogKey(keyData);
            }
        }

        private void OpenSubject()
        {
            SoggettoPerVisualizzazioneFDT item = GetCurrentItem();
            if (item != null)
            {
                if (item != null)
                {
                    OpenForEdit(item, false);
                }
            }
        }

        private DialogResult OpenForEdit(SoggettoPerVisualizzazioneFDT item, Boolean isReadOnly)
        {
            if (item != null)
            {
                if (item.IdTipoSoggetto == 99)
                {
                    BaseForm baseForm = null;
                    Cooperative.CooperativeEdit1 page = null;

                    CreatePage<Cooperative.CooperativeEdit1>(this, PageActions.ShowMdiChild, out page, out baseForm);
                    if (page != null)
                    {
                        page.SetBindableData(item.IdSoggetto);
                    }
                }
                else
                {
                    ModifySubject(item, isReadOnly);
                }
            }

            return DialogResult.None;
        }

        private void AddSoggetto()
        {
            SoggettoFDT item = null;

            AnagraficaEdit page = CreatePage<AnagraficaEdit>();
            if (page != null)
            {
                page.SetFormTitle("Gestisci soggetto");
                page.SetBindableData(item);

                DialogResult dr = DialogResult.OK;

                while (dr == DialogResult.OK)
                {
                    dr = page.BaseForm.ShowDialog(this, false);

                    if (dr == DialogResult.Cancel)
                        break;

                    if (!page.HasErrors())
                        break;

                }

                if (dr == DialogResult.OK)
                {
                    item = page.CurrentItem;
                    if (item != null)
                    {
                        SaveSubject(item);
                    }
                }
            }
        }

        private void ModifySubject(SoggettoPerVisualizzazioneFDT item, Boolean isReadOnly)
        {
            if (item != null)
            {
                AnagraficaEdit page = CreatePage<AnagraficaEdit>();
                if (page != null)
                {
                    page.SetFormTitle("Gestisci soggetto");
                    page.SetBindableData(item.IdSoggetto);

                    if (isReadOnly)
                    {
                        page.BaseForm.ShowDialog(this, isReadOnly);
                    }
                    else
                    {
                        DialogResult dr = DialogResult.OK;

                        while (dr == DialogResult.OK)
                        {
                            dr = page.BaseForm.ShowDialog(this, isReadOnly);

                            if (dr == DialogResult.Cancel)
                                break;

                            if (!page.HasErrors())
                                break;

                        }

                        if (dr == DialogResult.OK)
                        {
                           SaveSubject(page.itemToSave);
                        }
                    }
                }
            }
        }

        private Boolean SaveSubject(SoggettoFDT item)
        {
            if (item != null)
            {
                SoggettoFDT savedItem = GVCSystemEngine.InvokeService<ICooperatives, SoggettoFDT>
                             (delegate()
                             {
                                 return
                                     GVCSystemEngine.Cooperatives.SaveSoggetto(item);
                             },
                          true);

                if (savedItem != null)
                {
                    ShowInformationMessage("Salvataggio completato", string.Empty);
                    return true;
                }
                else
                {
                    ShowProblemsMessage();
                } 
            }
            return false;
        }

        private void gridViewSoggetto_ShowGridMenu(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs e)
        {
            SoggettoPerVisualizzazioneFDT item = GetCurrentItem();
            if (item != null)
            {
                GridView view = sender as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
                if (hitInfo.InRow)
                {
                    view.FocusedRowHandle = hitInfo.RowHandle;
                    popupMenuSoggetto.ShowPopup(BarManager,
                            gridControlSoggetto.PointToScreen(e.Point));
                }
            }
        }

        private SoggettoPerVisualizzazioneFDT GetCurrentItem()
        {
            SoggettoPerVisualizzazioneFDT toReturn = null;
            if (this.bindingSourceBaseResults.Current != null)
                toReturn = this.bindingSourceBaseResults.Current as SoggettoPerVisualizzazioneFDT;
            return toReturn;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            lblResults.Text = "0";
            results = null;
            this.bindingSourceBaseResults.DataSource = null;

            if (DefineParameters())
            {
                

                results = GVCSystemEngine.InvokeService<ICooperatives, SoggettoPerVisualizzazioneFDT[]>
                (delegate()
                {
                    return GVCSystemEngine.Cooperatives.GetSoggettoBySearch(query);
                },
                true);

                //if (subjects != null)
                //{
                //    results = Converters.ConvertAllForVisualization(subjects);
                //}
               
                this.bindingSourceBaseResults.DataSource = results;

                if (results != null)
                {
                    lblResults.Text = results.Length.ToString();

                    if (results.Length == 1)
                    {
                        OpenForEdit(results[0], false);
                    }
                }
            }
            else
            {
                ShowInformationMessage("Definire almeno un parametro di ricerca", string.Empty);
            }
        }

        private bool DefineParameters()
        {
            query = null;
           
            int subjectType = -1;
            if (lookUpEditSubjectType.EditValue != null)
            {
                if (Int32.TryParse(lookUpEditSubjectType.EditValue.ToString(), out subjectType))
                {
                    if (subjectType > 0)
                    {
                        query &= (FieldName)SearchParameters.ID_TIPO_SOGGETTO == subjectType;
                    }
                }
            }

            if (!Nominativo.Text.Equals(string.Empty))
            {
                String desc = GVCSystemEngine.RemoveDiacritics(Nominativo.Text);
                query &= ((FieldName)SearchParameters.NOME % desc |
                            (FieldName)SearchParameters.COGNOME % desc |
                                   (FieldName)SearchParameters.DENOMINAZIONE % desc);
            }

            if (!CodiceFiscale.Text.Equals(String.Empty))
            {
                query &= (FieldName)SearchParameters.CODICE_FISCALE % CodiceFiscale.Text;
            }

            if (DataNascita.EditValue != null)
            {
                DateTime d = DateTime.MinValue;
                if (DateTime.TryParse(DataNascita.EditValue.ToString(), out d))
                {
                    if (d != DateTime.MinValue)
                    {
                        query &= (FieldName)SearchParameters.DATA_NASCITA == d;
                    }
                }
            }
            if (!LuogoNascita.Text.Equals(String.Empty))
            {
                query &= (FieldName)SearchParameters.LUOGO_NASCITA % LuogoNascita.Text;
            }

            if (Associazione.Checked)
            {
                query &= (FieldName)SearchParameters.ASSOCIAZIONE == 1;
            }

            if (query == null || query.ToString().Equals(string.Empty))
                return false;

            query &= new Expression((FieldName)SearchParameters.CODICE_COOPERATIVA, Operators.Is, DBNull.Value);
            return true;
        }

        private int GetPersonaFisicaId()
        {
            int toReturn = -1;
            DizionarioFDT[] listSubjectTypes = this.bindingSourceBaseTipoSoggetto.DataSource as DizionarioFDT[];
            if (listSubjectTypes != null)
            {
                foreach (DizionarioFDT item in listSubjectTypes)
                {
                    if (item.Descrizione.ToUpper().Contains("PERSON") &&
                        item.Descrizione.ToUpper().Contains("FISIC"))
                    {
                        toReturn = item.IdElemento;
                        break;
                    }
                }
            }
            return toReturn;
        }

        private void SubjectSearch_Shown(object sender, EventArgs e)
        {
            SetFormTitle("Ricerca soggetti");

            Nominativo.Focus();
        }

        private void gridControlSoggetto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenForEdit(GetCurrentItem(), false);
        }

        private void barButtonItemRemove_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SoggettoPerVisualizzazioneFDT item = GetCurrentItem();
            if (item != null && item.IdSoggetto > 0)
            {
                if (ShowConfirmMessage("Conferma operazione", "Confermi al cancellazione dell'elemento selezionato?", string.Empty) == DialogResult.Yes)
                {
                    string[] errors =
                        GVCSystemEngine.InvokeService<ICooperatives, string[]>
                        (delegate()
                        {
                            return GVCSystemEngine.Cooperatives.DeleteSubject(item.IdSoggetto);
                        },
                        true);

                    if (errors != null)
                    {
                        if (errors.Length > 0)
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.AppendLine(string.Concat("Soggetto utilizzato in ", Environment.NewLine));
                            foreach (string error in errors)
                            {
                                sb.AppendLine(string.Concat("\t", error, Environment.NewLine));
                            }
                            ShowInformationMessage("Non è stato possibile cancellare il soggetto", sb.ToString());
                        }
                        else
                        {
                            ShowInformationMessage("Cancellazione avvenuta con successo", string.Empty);
                        }
                    }
                    else
                    {
                        ShowProblemsMessage();
                    }
                }
            }
        }

        private void barButtonItemResultsExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dlg;

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

                    ExportResults(dlg.FileName);
                }
            }
        }

        private void ExportResults(string filepath)
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
                    return GVCSystemEngine.Cooperatives.GetSoggettiDaEsportare(idToExport);
                },
                true);

                dsExport.WriteXml(filepath, XmlWriteMode.DiffGram);
            }
        }
    }
}
