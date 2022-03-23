using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.RicercheWrapper
{
    [Serializable]
    public partial class DocumentazioneRicercaFDT
    {
        #region Private Properties

        private int _idDocumentazione;
        private Byte[] _allegati;
        private Byte[] _icona;
        private DateTime _dataDocumento;
        private int _idTipoDocumentazione;
        private String _nomeFile;
        private String _numeroProtocollo;
        private String _titolo;
        private int _dimensione;

        #endregion Private Properties

        #region Public Properties

        public int Dimensione
        {
            get { return _dimensione; }
            set { _dimensione = value; }
        }

        public Byte[] Allegati
        {
            get { return _allegati; }
            set { _allegati = value; }
        }

        public Byte[] Icona
        {
            get { return _icona; }
            set { _icona = value; }
        }

        public DateTime DataDocumento
        {
            get { return _dataDocumento; }
            set { _dataDocumento = value; }
        }

        public int IdTipoDocumentazione
        {
            get { return _idTipoDocumentazione; }
            set { _idTipoDocumentazione = value; }
        }

        public int IdDocumentazione
        {
            get { return _idDocumentazione; }
            set { _idDocumentazione = value; }
        }

        public string NumeroProtocollo
        {
            get { return _numeroProtocollo; }
            set { _numeroProtocollo = value; }
        }

        public string NomeFile
        {
            get { return _nomeFile; }
            set { _nomeFile = value; }
        }

        public string Titolo
        {
            get { return _titolo; }
            set { _titolo = value; }
        }

        #endregion Public Properties

        public void SetIcon()
        {
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
        }

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
    }
}
