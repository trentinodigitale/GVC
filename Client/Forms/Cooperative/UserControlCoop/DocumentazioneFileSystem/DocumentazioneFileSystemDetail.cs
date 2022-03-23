using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.Configurations;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.DocumentazioneFileSystem
{
    public partial class DocumentazioneFileSystemDetail : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {

        public override bool ReadOnlyControls
        {
            get
            {
                return base.ReadOnlyControls;
            }
            set
            {
                this.btnSearch.Enabled = true;
                this.AnagraficaGeneralYesNo.Enabled = true;
            }
        }

        #region Private Members

        private CooperativaFDT itemLocal;

        private List<string> codeToSearch;

        private List<CartellaFDT> itemsToView;

        private List<int> idMaschereLocal;

        #endregion Private Members

        #region Constructor

        public DocumentazioneFileSystemDetail()
        {
            InitializeComponent();
        }

        #endregion Constructor

        #region Public Methode

        public void SetBindableData(CooperativaFDT item, int[] idMaschere)
        {
            itemLocal = item;

            if ((itemLocal.RegistroCooperativa != null) && (itemLocal.RegistroCooperativa.CambioPosizioni != null))
            {                
                if (idMaschere != null)
                {
                    idMaschereLocal = new List<int>(idMaschere);
                    AnagraficaGeneralYesNo.Visible = false;
                }

                codeToSearch = new List<string>();
                List<DizionarioFDT> lstCategorie = new List<DizionarioFDT>(GVCSystemEngine.GetDizionarioByType(DictionaryTypes.CATEGORIE));

                codeToSearch.Add(itemLocal.RegistroCooperativa.IdRegistro.ToString());
                for (int i = 0; i < itemLocal.RegistroCooperativa.CambioPosizioni.Length; i++)
                {
                    if (itemLocal.RegistroCooperativa.CambioPosizioni[i].NumeroPosizione != null)
                    {
                        string code = itemLocal.RegistroCooperativa.CambioPosizioni[i].NumeroPosizione.Trim();
                        if (code.IndexOf(" ") > 0)
                        {
                            code = code.Substring(0, code.IndexOf(" ")).Trim();
                        }

                        if ((code != string.Empty) && (code != itemLocal.RegistroCooperativa.IdRegistro.ToString()))
                        {
                            DizionarioFDT categoria = lstCategorie.Find(o => o.IdElemento == itemLocal.RegistroCooperativa.CambioPosizioni[i].IdCategoria);
                            if (categoria != null)
                            {
                                code = categoria.Codice.Trim() + code;
                            }

                            if (!(codeToSearch.IndexOf(code) > 0))
                            {
                                codeToSearch.Add(code);
                            }
                        }
                    }
                }
            }
        }

        #endregion Public Methode

        private void LoadDocumenti()
        {
            itemsToView = new List<CartellaFDT>();

            if ((itemLocal.RegistroCooperativa != null) && (itemLocal.RegistroCooperativa.Cartelle != null))
            {
                for (int i = 0; i < itemLocal.RegistroCooperativa.Cartelle.Length; i++)
                {
                    if (idMaschereLocal != null)
                    {
                        for (int x = 0; x < idMaschereLocal.Count; x++)
                        {
                            if (itemLocal.RegistroCooperativa.Cartelle[i].IdMaschera == idMaschereLocal[x])
                            {
                                if (itemLocal.RegistroCooperativa.Cartelle[i].Documenti == null)
                                {
                                    itemLocal.RegistroCooperativa.Cartelle[i].Documenti = new List<DocumentazioneFileSystemFDT>(GetDocumentazioneFileSystem(itemLocal.RegistroCooperativa.Cartelle[i]));
                                }

                                if (itemLocal.RegistroCooperativa.Cartelle[i].Documenti.Count > 0)
                                {
                                    itemsToView.Add(itemLocal.RegistroCooperativa.Cartelle[i]);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (itemLocal.RegistroCooperativa.Cartelle[i].IdMaschera != 99)
                        {
                            if (itemLocal.RegistroCooperativa.Cartelle[i].Documenti == null)
                            {
                                itemLocal.RegistroCooperativa.Cartelle[i].Documenti = new List<DocumentazioneFileSystemFDT>(GetDocumentazioneFileSystem(itemLocal.RegistroCooperativa.Cartelle[i]));
                            }

                            if (itemLocal.RegistroCooperativa.Cartelle[i].Documenti.Count > 0)
                            {
                                itemsToView.Add(itemLocal.RegistroCooperativa.Cartelle[i]);
                            }
                        }
                    }
                }
            }

            bindingSourceDocumentationFileSystem.DataSource = itemsToView.ToArray();
        }


        private DocumentazioneFileSystemFDT[] GetDocumentazioneFileSystem(CartellaFDT cartella)
        {
            List<DocumentazioneFileSystemFDT> toReturn;
            
            toReturn = new List<DocumentazioneFileSystemFDT>();

            for (int x = 0; x < codeToSearch.Count; x++)
            {
                if (System.IO.Directory.Exists(cartella.Path))
                {
                    string[] files = System.IO.Directory.GetFiles(cartella.Path, codeToSearch[x] + "_*", System.IO.SearchOption.AllDirectories);

                    foreach (string file in files)
                    {
                        DocumentazioneFileSystemFDT docItem = new DocumentazioneFileSystemFDT();
                        docItem.NomeFile = System.IO.Path.GetFileName(file);
                        docItem.IdMaschera = cartella.IdMaschera;
                        docItem.Cartella = cartella.Descrizione;
                        docItem.Path = System.IO.Path.GetFullPath(file);
                        System.IO.FileInfo fi = new System.IO.FileInfo(file);
                        docItem.Dimensione = Convert.ToInt32(fi.Length / 1024);
                        docItem.DataDocumento = System.IO.File.GetCreationTime(file);
                        docItem.DataUltimaModifica = System.IO.File.GetLastWriteTime(file);

                        toReturn.Add(docItem);
                    }
                }
            }

            return toReturn.ToArray();
        }

        private void gridViewDocumentationFileSystem_DoubleClick(object sender, EventArgs e)
        {
            int [] items = ((DevExpress.XtraGrid.Views.Grid.GridView)sender).GetSelectedRows();

            if (items.Length > 0)
            {

                DocumentazioneFileSystemFDT item = ((DevExpress.XtraGrid.Views.Grid.GridView)sender).GetRow(items[0]) as DocumentazioneFileSystemFDT;

                if ((item != null) && (System.IO.File.Exists(item.Path)))
                {
                    System.Diagnostics.Process.Start(item.Path);
                }

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if ((idMaschereLocal == null) && (AnagraficaGeneralYesNo.Checked))
                {
                    idMaschereLocal = new List<int>();
                    idMaschereLocal.Add(99);
                }

                LoadDocumenti();

                if ((idMaschereLocal != null) && (idMaschereLocal.Count == 1) && (idMaschereLocal[0] == 99) && (AnagraficaGeneralYesNo.Checked))
                {
                    idMaschereLocal = null;
                }
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

    }
}
