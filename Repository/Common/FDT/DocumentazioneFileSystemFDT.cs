using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.FDT
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public partial class DocumentazioneFileSystemFDT : FDTBase, DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo
    {
        #region Instance Variables (8)
                
        private Byte[] _icona;
        private DateTime _dataDocumento;
        private DateTime _dataUltimaModifica;
        private String _path;
        private String _cartella;
        private String _nomeFile;
        private int _dimensione;
        private int _idMaschera;

        #endregion Instance Variables

        #region Public Properties (8)

        /// <summary>
        /// Gets or sets the grandezza (espressa in KB)
        /// </summary>
        /// <value>The grandezza.</value>
        [Bindable(true)]
        public int Dimensione
        {
            get { return _dimensione; }
            set { _dimensione = value; }
        }
                
        [Bindable(true)]
        public int IdMaschera
        {
            get { return _idMaschera; }
            set { _idMaschera = value; }
        }
        
        [Bindable(true)]
        public Byte[] Icona
        {
            get { return _icona; }
            set { _icona = value; }
        }
        
        /// <summary>
        /// Gets or sets the data ultima modifica del documento.
        /// </summary>
        /// <value>The data ultima modifica del documento.</value>
        [Bindable(true)]
        public DateTime DataUltimaModifica
        {
            get { return _dataUltimaModifica; }
            set { _dataUltimaModifica = value; }
        }

        /// <summary>
        /// Gets or sets the data documento.
        /// </summary>
        /// <value>The data documento.</value>
        [Bindable(true)]
        public DateTime DataDocumento
        {
            get { return _dataDocumento; }
            set { _dataDocumento = value; }
        }

        /// <summary>
        /// Gets or sets the nome file.
        /// </summary>
        /// <value>The nome file.</value>
        [Bindable(true)]
        public String NomeFile
        {
            get { return _nomeFile; }
            set
            {
                _nomeFile = value;
                this._icona = GetIcon(System.IO.Path.GetExtension(value));
            }
        }
                  
        /// <summary>
        /// Gets or sets the cartella.
        /// </summary>
        /// <value>The cartella.</value>
        [Bindable(true)]
        public string Cartella
        {
            get { return _cartella; }
            set { _cartella = value; }
        }


        /// <summary>
        /// Gets or sets the Path.
        /// </summary>
        /// <value>The Path.</value>
        [Bindable(true)]
        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        #endregion Public Properties

        #region Public Methods (1)

        public override void OnCreateInstance()
        {
            this._dataDocumento = System.DateTime.Now;
            Random random = new Random();

            if (!string.IsNullOrEmpty(_nomeFile))
            {
                string ext = System.IO.Path.GetExtension(_nomeFile);

                if (!String.IsNullOrEmpty(ext))
                {
                    this._icona = GetIcon(ext);
                }
            }
            else
            {
                int number = 20;

                switch (number)
                {
                    case 0:
                        this._icona = GetIcon(".doc");
                        break;
                    case 1:
                        this._icona = GetIcon(".pdf");
                        break;
                    case 2:
                        this._icona = GetIcon(".xls");
                        break;
                    default:
                        this._icona = GetIcon(".jpg");
                        break;
                }
            }
            base.OnCreateInstance();
        }

        #endregion Public Methods

        #region Private Methods (1)

        private byte[] GetIcon(String extension)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();

            switch (extension.ToLower())
            {
                case ".doc":
                    GVCResources.Document_Doc_16x16.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    break;
                case ".pdf":
                    GVCResources.Document_Pdf_16x16.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    break;
                case ".xls":
                    GVCResources.Document_Xls_16x16.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    break;
                default:
                    GVCResources.Document_Other_16x16.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    break;
            }
            return ms.ToArray();
        }

        #endregion Private Methods

        #region IDXDataErrorInfo Members

        public void GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {

        }

        public void GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
            //if ((propertyName == "Titolo" && String.IsNullOrEmpty(_titolo)))
            //{
            //    info.ErrorText = "Campo obbligatorio";
            //    info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            //}

            //if ((propertyName == "IdTipoDocumentazione" && _idTipoDocumentazione <= 0))
            //{
            //    info.ErrorText = "Campo obbligatorio";
            //    info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            //}
        }

        #endregion
    }
}
