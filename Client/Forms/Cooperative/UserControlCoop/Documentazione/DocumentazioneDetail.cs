using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Client.Forms.Common;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.Services;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Documentazione
{
    public partial class DocumentazioneDetail : UserControlBase
    {
        private CooperativaFDT itemLocal = null;
        private System.Reflection.PropertyInfo pInfo = null;
        private object itemReceived = null;

        #region parte generale

        private Boolean _isGeneral;
        public Boolean IsGeneral
        {
            get { return _isGeneral; }
            set
            {
                _isGeneral = value;

                if (value)
                {
                    if (listGeneral != null)
                        listGeneral.Clear();
                    corrDocumentazione = null;
                }   
            }
        }

        public void HideButtonsGeneral()
        {
            this.barButtonItemAddDocumentation.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

        }

        private Dictionary<string, List<DocumentazioneFDT>> corrDocumentazione = null;
        private List<DocumentazioneFDT> listGeneral = new List<DocumentazioneFDT>();

        public void UpdateListDictionaryGeneral(string parameter, DocumentazioneFDT[] listDoc)
        {
            if (corrDocumentazione == null)
            {
                corrDocumentazione = new Dictionary<string, List<DocumentazioneFDT>>();
            }

            if (corrDocumentazione.ContainsKey(parameter))
            {
                corrDocumentazione.Remove(parameter);
            }
            
            List<DocumentazioneFDT> listTemp = new List<DocumentazioneFDT>();
            listTemp.AddRange(listDoc);

            corrDocumentazione.Add(parameter, listTemp);
        }

        private void UpdateList(object item)
        {
            if (item != null)
            {
                SetDictionary();

                this.bindingSourceDocumentation.DataSource = null;
                if (item.GetType() == typeof(DocumentazioneFDT))
                {
                        listGeneral.Add(item as DocumentazioneFDT);
                }
                else
                {
                    if (item.GetType() == typeof(DocumentazioneFDT[]))
                    {
                        listGeneral.AddRange(item as DocumentazioneFDT[]);
                    }
                }
                this.bindingSourceDocumentation.DataSource = listGeneral.ToArray();
            }
            else
            {
                this.gridViewDocumentation.BeginDataUpdate();
                this.gridViewDocumentation.EndDataUpdate();
                gridViewDocumentation.PostEditor();
            }
        }

        #endregion parte generale

        #region Constructors (1)

        public DocumentazioneDetail()
        {
            InitializeComponent();

            if (!DesignMode)
            {
                EnableControlAutoSize(new object[] { this }, gridControlDocumentation, 200);

                SetImages();
            }

            _isGeneral = false;

            UserControlHelp.UpdateDocumentazione += new EventHandler(UserControlHelp_UpdateDocumentazione);
        }

        void UserControlHelp_UpdateDocumentazione(object sender, EventArgs e)
        {
            if (_isGeneral)
            {
               // UpdateListDictionaryGeneral(string.Empty, null);
                UpdateList(sender);
            }
        }



		#endregion Constructors 

		#region Properties (1) 

        public override bool ReadOnlyControls
        {
            get
            {
                return base.ReadOnlyControls;
            }
            set
            {
                base.ReadOnlyControls = value;

                this.barButtonItemAddDocumentation.Enabled =
                    this.barButtonItemDelete.Enabled = !value;
            }
        }

		#endregion Properties 

		#region Methods (8) 

        private void SetImages()
        {
            this.barButtonItemAddDocumentation.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Paperclip_24x24);
            this.barButtonItemDelete.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
            this.barButtonItemModify.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Edit_24x24);
        }

        //public void ActivateFilter(Boolean isActive, String stringCondition)
        //{
        //    if (isActive)
        //    {
        //        this.gridViewDocumentation.ActiveFilterEnabled = true;
        //        this.gridViewDocumentation.ActiveFilterString = stringCondition;
        //    }
        //    else
        //    {
        //        this.gridViewDocumentation.ActiveFilterEnabled = false;
        //        this.gridViewDocumentation.ActiveFilterString = string.Empty;
        //    }
        //}

        public void SetBindableData(object item)
        {
            SetDictionary();

            this.bindingSourceDocumentation.DataSource = null;
            if (item != null)
            {
                itemReceived = item;
                pInfo = itemReceived.GetType().GetProperty("Documentazioni");
                if (pInfo != null)
                {
                    DocumentazioneFDT[] items = pInfo.GetValue(itemReceived, null) as DocumentazioneFDT[];

                    this.bindingSourceDocumentation.DataSource = items;

                    //CallEventUpdateGeneral(items);
                }
            }
           
            //if (item != null && item.RegistroCooperativa != null)
            //{
            //    this.bindingSourceDocumentation.DataSource = item.RegistroCooperativa.Documentazioni;
            //}
        }

        private void SetDictionary()
        {
            //if (this.bindingSourceDocumentationTypes.DataSource == null)
            {
                this.bindingSourceDocumentationTypes.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_DOCUMENTO);
            }
        }

        private void bindingSourceDocumentation_CurrentItemChanged(object sender, EventArgs e)
        {
            HandleCurrentItemChanged();
        }

        private void barButtonItemAddDocumentation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddItem();
        }
        private void barButtonItemModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ModifyItem();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteItem();
        }


        private void gridControlDocumentation_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo ghInfo = gridControlDocumentation.DefaultView.CalcHitInfo(new Point(e.X, e.Y)) as DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo;

            if (ghInfo != null &&
                ghInfo.Column != null &&
                ghInfo.Column.Name == colAttachment.Name)
            {
                DocumentazioneFDT item = bindingSourceDocumentation.Current as DocumentazioneFDT;
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
                    }
                    catch
                    {
                        ShowProblemsMessage();
                    }
                }
            }
            else
            {
                ModifyItem();
            }
        }

        private byte[] GetContentOfDocumentation(DocumentazioneFDT item)
        {
            byte[] toReturn = null;
            if (item != null )
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

       

        private void repositoryItemPictureEdit1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        


		#endregion Methods 

        #region Private methods

        private void HandleCurrentItemChanged()
        {
            SetVisibilityBarButton();
        }

        private void SetVisibilityBarButton()
        {
            DocumentazioneFDT item = GetCurrentItem();
            SetVisibilityBarButton(item);
        }

        private void SetVisibilityBarButton(DocumentazioneFDT item)
        {
            if (!this.ReadOnlyControls)
            {
                this.barButtonItemDelete.Enabled = true;
                this.barButtonItemModify.Enabled = true;

                if (item != null)
                {
                    if (item.Status >= ObjectStatus.ToHide)
                    {
                        this.barButtonItemDelete.Enabled = false;
                        this.barButtonItemModify.Enabled = false;
                    }
                }
            }
        }

        private void AddItem()
        {
            if (itemReceived != null)
            {
                DocumentazioneFDT item = new DocumentazioneFDT();
                //item.IdRegistro = -1;
                if (itemLocal != null && itemLocal.RegistroCooperativa != null)
                {
                    // item.IdRegistro = itemLocal.RegistroCooperativa.IdRegistro;
                }

                if (OpenForEdit(item, true) == DialogResult.OK)
                {
                    DocumentazioneFDT newItem = SaveItem(item, false, false);
                    if (newItem != null)
                    {
                        gridViewDocumentation.BeginDataUpdate();

                        DocumentazioneFDT[] listActual = this.bindingSourceDocumentation.DataSource as DocumentazioneFDT[];
                        if (listActual == null)
                            listActual = new DocumentazioneFDT[] { };

                        if (listActual != null)
                        {
                            List<DocumentazioneFDT> lTemp = new List<DocumentazioneFDT>();
                            lTemp.AddRange(listActual);
                            lTemp.Add(newItem);

                            if (pInfo != null && itemReceived != null)
                            {
                                pInfo.SetValue(itemReceived, lTemp.ToArray(), null);
                            }

                            this.bindingSourceDocumentation.DataSource = lTemp.ToArray();

                            CallEventUpdateGeneral(newItem);

                        }

                        gridViewDocumentation.EndDataUpdate();
                    }
                    else
                    {
                        ShowProblemsMessage();
                    }
                }
            }
            else
            {
                ShowInformationMessage("Nessun dettaglio selezionato", "Per inserire la documentazione è necessario selezionare un dettaglio");
            }
        }

        private void CallEventUpdateGeneral(object item)
        {
           UserControlHelp.UpdateDocumentazioneCall(item);
        }

        private void DeleteItem()
        {
            DocumentazioneFDT item = GetCurrentItem();
            if (item != null)
            {
                if (ShowConfirmMessage("Cancellazione", "Confermi la cancellazione dell'elemento selezionato?", string.Empty) == DialogResult.Yes)
                {
                    if (item.IdDocumentazione > 0)
                    {
                        item.Status = ObjectStatus.ToCancel;
                    }
                    else
                    {
                        DocumentazioneFDT[] listActual = this.bindingSourceDocumentation.DataSource as DocumentazioneFDT[];

                        if (listActual != null)
                        {
                            List<DocumentazioneFDT> lTemp = new List<DocumentazioneFDT>();
                            foreach (DocumentazioneFDT ind in listActual)
                            {
                                if (ind != item)
                                {
                                    lTemp.Add(ind);
                                }
                            }

                            //pInfo = itemReceived.GetType().GetProperty("Documentazioni");
                            if (pInfo != null && itemReceived != null)
                            {
                                pInfo.SetValue(itemReceived, lTemp.ToArray(), null);
                            }

                            if (itemReceived == null)
                            {
                                item.Status = ObjectStatus.ToCancel;
                               
                                this.bindingSourceDocumentation.DataSource = lTemp.ToArray();
                            }
                        }
                    }

                    if (itemReceived != null)
                    {
                        pInfo = itemReceived.GetType().GetProperty("Documentazioni");
                        if (pInfo != null)
                        {
                            DocumentazioneFDT[] items = pInfo.GetValue(itemReceived, null) as DocumentazioneFDT[];

                            this.bindingSourceDocumentation.DataSource = items;
                        }
                    }
                   
                    gridViewDocumentation.RefreshData();
                    SetVisibilityBarButton(item);

                    CallEventUpdateGeneral(null);
                }
            }
        }

        private DocumentazioneFDT GetCurrentItem()
        {
            DocumentazioneFDT toReturn = null;

            if (this.bindingSourceDocumentation.Current != null)
            {
                toReturn = this.bindingSourceDocumentation.Current as DocumentazioneFDT;
            }
            return toReturn;
        }

        private void ModifyItem()
        {
            DocumentazioneFDT item = GetCurrentItem();
            if (item != null)
            {
                Boolean goOn = true;
                if (item.Status >= it.dedagroup.GVC.Repository.Common.Configurations.ObjectStatus.ToHide)
                {
                    goOn = false;
                }

                if (goOn)
                {

                    if (item.IdDocumentazione > 0 && item.Allegati == null)
                    {
                        item.Allegati = GetContentOfDocumentation(item); ;
                    }

                    item.EndEdit();
                    item.BeginEdit();
                    if (OpenForEdit(item, false) == DialogResult.OK)
                    {
                        item.EndEdit();
                        DocumentazioneFDT updatedItem = SaveItem(item, false, true);
                        if (updatedItem != null)
                        {
                            this.bindingSourceDocumentation.EndEdit();
                            gridViewDocumentation.RefreshData();

                            CallEventUpdateGeneral(null);
                        }
                        else
                        {
                            item.CancelEdit();
                            ShowProblemsMessage();
                        }
                    }
                    else
                    {
                        item.CancelEdit();
                        gridViewDocumentation.RefreshData();
                    }
                }
            }
        }

        private DialogResult OpenForEdit(DocumentazioneFDT item, Boolean isNew)
        {
            DocumentazioneEdit page = CreatePage<DocumentazioneEdit>();
            if (page != null)
            {
                page.SetFormTitle("Gestione documentazione");
                page.SetBindableData(item);
                DialogResult dr = DialogResult.OK;
                while (dr == DialogResult.OK)
                {
                    page.ErrorProvideDocumentation.ClearErrors();

                    dr = page.BaseForm.ShowDialog(this, this.ReadOnlyControls);

                    if (dr == DialogResult.OK)
                    {
                        if (!page.ErrorProvideDocumentation.HasErrors)
                            break;
                    }
                }

                //if (isNew)
                {
                    if (dr == DialogResult.OK)
                    {
                        try
                        {
                            if (System.IO.File.Exists(item.NomeFile))
                            {
                                System.IO.FileInfo f = new System.IO.FileInfo(item.NomeFile);
                                item.Dimensione = (int)(f.Length / 1024);


                                using (System.IO.FileStream fs = System.IO.File.OpenRead(item.NomeFile))
                                {
                                    item.Allegati = new byte[fs.Length];
                                    fs.Read(item.Allegati, 0, item.Allegati.Length);
                                }
                            }
                        }
                        catch
                        {
                            ShowProblemsMessage();
                        }
                    }
                }

                return dr;
            }
            else
                return DialogResult.None;
        }

        private DocumentazioneFDT SaveItem(DocumentazioneFDT item, Boolean onDB, Boolean isAnUpdate)
        {
            DocumentazioneFDT toReturn = null;
            if (item != null)
            {
                if (onDB)
                {
                    //toReturn = GVCSystemEngine.InvokeService<ICooperatives, BilancioFDT>
                    //    (delegate() { return GVCSystemEngine.Cooperatives.SaveBilancio(item); },
                    //    true);
                }
                else
                {
                    if (isAnUpdate)
                        item.Status = ObjectStatus.ToUpdate;
                    else
                        item.Status = ObjectStatus.ToInsert;

                    toReturn = item;
                }

            }
            return toReturn;
        }

        #endregion Private methods

        public void ApplyFilter(int TipoDocumentazioneFilter, String TitoloFilter, String AnnoFilter)
        {
            StringBuilder condition = new StringBuilder();

            if (TipoDocumentazioneFilter > 0)
            {
                if (condition.Length > 0)
                {
                    condition.Append(" And ");
                }

                colIdDocumentationType.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
                condition.Append(string.Format("[{0}] = {1}",
                                            colIdDocumentationType.FieldName,
                                            TipoDocumentazioneFilter));

            }


            if (!String.IsNullOrEmpty(TitoloFilter))
            {
                if (condition.Length > 0)
                {
                    condition.Append(" And ");
                }
                colTitle.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
                condition.Append(string.Format("LOWER([{0}]) LIKE LOWER('%{1}%')",
                                            colTitle.FieldName,
                                            TitoloFilter));

            }

            if (!String.IsNullOrEmpty(AnnoFilter))
            {
                if (condition.Length > 0)
                {
                    condition.Append(" And ");
                }
                int AnnoFilterInt = 0;

                if (int.TryParse(AnnoFilter, out AnnoFilterInt))
                {
                    if (AnnoFilterInt > 0)
                    {
                        DateTime inizio = new DateTime(AnnoFilterInt, 1, 1);
                        DateTime fine = new DateTime(AnnoFilterInt, 12, 31);

                        colDocumentDate.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
                        condition.Append(string.Format("[{0}] >= #{1}#",
                                                    colDocumentDate.FieldName,
                                                    inizio.ToString("yyyy/MM/dd")));
                        condition.Append(" And ");
                        condition.Append(string.Format("[{0}] <= #{1}#",
                                                   colDocumentDate.FieldName,
                                                   fine.ToString("yyyy/MM/dd")));

                        // "[DataDocumento] >= #2009-04-27# And [DataDocumento] < #2009-04-28#"
                    }
                }
            }


            if (condition.Length > 0)
            {
                gridViewDocumentation.ActiveFilterEnabled = true;
                gridViewDocumentation.ActiveFilterString = condition.ToString();

            }
            else
            {
                gridViewDocumentation.ActiveFilterEnabled = false;
                gridViewDocumentation.ActiveFilterString = string.Empty;
            }
        }     

    }
}
