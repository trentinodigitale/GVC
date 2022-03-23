using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace it.dedagroup.GVC.Repository.Common.FDT
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.FDTBase))]
    [Serializable]
    public partial class IndirizzoFDT : FDTBase, DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo
    {
        #region Private Properties (21)

        private int _idIndirizzo;
        private int _idSoggetto;
        private int _idTipoIndirizzo;
        private Boolean _principale;
        private Boolean _sede;
        private string _via;
        private string _numeroCivico;
        private string _cap;
        private string _provincia;
        private string _comune;
        private DateTime _dataInizio;
        private string _frazione;
        private string _altro;
        private string _codiceStradario;
        private string _telefono;
        private string _fax;
        private string _email;
        private string _urlPage;
        private string _note;
        private DateTime? _dataFine;
        private DateTime? _dataUltimaModifica;
        private String _operatoreUltimaModifica;

        private String _nazione;

       
	
        private Boolean _haveToSetTheError;

        #endregion Private Properties

        #region Public Properties (21)

        [Bindable(true)]
        public Boolean PaintRed
        {
            get
            {
                Boolean toReturn = false;

                if (DataFine.HasValue && DataFine.Value < System.DateTime.Now)
                    toReturn = true;

                return toReturn;
            }
        }

        public Boolean HaveToSetTheError
        {
            get { return _haveToSetTheError; }
            set { _haveToSetTheError = value; }
        }

        /// <summary>
        /// Gets or sets the nazione.
        /// </summary>
        /// <value>The nazione.</value>
        [Bindable(true)]
        public String Nazione
        {
            get { return _nazione; }
            set { _nazione = value; }
        }

        /// <summary>
        /// Gets or sets the data fine.
        /// </summary>
        /// <value>The data fine.</value>
        [Bindable(true)]
        public DateTime? DataFine
        {
            get { return _dataFine; }
            set { _dataFine = value; }
        }

        /// <summary>
        /// Gets or sets the note.
        /// </summary>
        /// <value>The note.</value>
        [Bindable(true)]
        public string Note
        {
            get { return _note; }
            set { _note = value; }
        }

        /// <summary>
        /// Gets or sets the URL page.
        /// </summary>
        /// <value>The URL page.</value>
        [Bindable(true)]
        public string UrlPage
        {
            get { return _urlPage; }
            set { _urlPage = value; }
        }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
        [Bindable(true)]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        /// <summary>
        /// Gets or sets the fax.
        /// </summary>
        /// <value>The fax.</value>
        [Bindable(true)]
        public string Fax
        {
            get { return _fax; }
            set { _fax = value; }
        }

        /// <summary>
        /// Gets or sets the telefono.
        /// </summary>
        /// <value>The telefono.</value>
        [Bindable(true)]
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        /// <summary>
        /// Gets or sets the codice stradario.
        /// </summary>
        /// <value>The codice stradario.</value>
        [Bindable(true)]
        public string CodiceStradario
        {
            get { return _codiceStradario; }
            set { _codiceStradario = value; }
        }

        /// <summary>
        /// Gets or sets the altro.
        /// </summary>
        /// <value>The altro.</value>
        [Bindable(true)]
        public string Altro
        {
            get { return _altro; }
            set { _altro = value; }
        }

        /// <summary>
        /// Gets or sets the frazione.
        /// </summary>
        /// <value>The frazione.</value>
        [Bindable(true)]
        public string Frazione
        {
            get { return _frazione; }
            set { _frazione = value; }
        }

        /// <summary>
        /// Gets or sets the data inizio.
        /// </summary>
        /// <value>The data inizio.</value>
        [Bindable(true)]
        public DateTime DataInizio
        {
            get { return _dataInizio; }
            set { _dataInizio = value; }
        }

        /// <summary>
        /// Gets or sets the comune.
        /// </summary>
        /// <value>The comune.</value>
        [Bindable(true)]
        public string Comune
        {
            get { return _comune; }
            set { _comune = value; }
        }

        /// <summary>
        /// Gets or sets the provincia.
        /// </summary>
        /// <value>The provincia.</value>
        [Bindable(true)]
        public string Provincia
        {
            get { return _provincia; }
            set { _provincia = value; }
        }

        /// <summary>
        /// Gets or sets the cap.
        /// </summary>
        /// <value>The cap.</value>
        [Bindable(true)]
        public string Cap
        {
            get { return _cap; }
            set { _cap = value; }
        }

        /// <summary>
        /// Gets or sets the numero civico.
        /// </summary>
        /// <value>The numero civico.</value>
        [Bindable(true)]
        public string NumeroCivico
        {
            get { return _numeroCivico; }
            set { _numeroCivico = value; }
        }

        /// <summary>
        /// Gets or sets the via.
        /// </summary>
        /// <value>The via.</value>
        [Bindable(true)]
        public string Via
        {
            get { return _via; }
            set { _via = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="IndirizzoFDT"/> is sede.
        /// </summary>
        /// <value><c>true</c> if principale; otherwise, <c>false</c>.</value>
        [Bindable(true)]
        public Boolean Sede
        {
            get { return _sede; }
            set { _sede = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="IndirizzoFDT"/> is principale.
        /// </summary>
        /// <value><c>true</c> if principale; otherwise, <c>false</c>.</value>
        [Bindable(true)]
        public Boolean Principale
        {
            get { return _principale; }
            set { _principale = value; }
        }

        /// <summary>
        /// Gets or sets the id tipo indirizzo.
        /// </summary>
        /// <value>The id tipo indirizzo.</value>
        [Bindable(true)]
        public int IdTipoIndirizzo
        {
            get { return _idTipoIndirizzo; }
            set { _idTipoIndirizzo = value; }
        }

        /// <summary>
        /// Gets or sets the id soggetto.
        /// </summary>
        /// <value>The id soggetto.</value>
        [Bindable(true)]
        public int IdSoggetto
        {
            get { return _idSoggetto; }
            set { _idSoggetto = value; }
        }

        /// <summary>
        /// Gets or sets the id indirizzo.
        /// </summary>
        /// <value>The id indirizzo.</value>
        [Bindable(true)]
        public int IdIndirizzo
        {
            get { return _idIndirizzo; }
            set { _idIndirizzo = value; }
        }

        /// <summary>
        /// Gets or sets the data ultima modifica.
        /// </summary>
        /// <value>The data ultima modifica.</value>
        [Bindable(true)]
        public DateTime? DataUltimaModifica
        {
            get { return _dataUltimaModifica; }
            set { _dataUltimaModifica = value; }
        }

        /// <summary>
        /// Gets or sets the operatore ultima modifica.
        /// </summary>
        /// <value>The operatore ultima modifica.</value>
        [Bindable(true)]
        public String OperatoreUltimaModifica
        {
            get { return _operatoreUltimaModifica; }
            set { _operatoreUltimaModifica = value; }
        }

        #endregion Public Properties

        #region PropertyNames Class

        /// <summary>
        /// PropertyNames
        /// </summary>
        public partial class PropertyNames
        {
            public const string IdTipoIndirizzo = "IdTipoIndirizzo";
            public const string Via = "Via";
            public const string NumeroCivico = "NumeroCivico";
            public const string Cap = "Cap";
            public const string Provincia = "Provincia";
            public const string Comune = "Comune";
            public const string DataInizio = "DataInizio";
        }

        #endregion PropertyNames Class

        #region IDXDataErrorInfo Members

        public void GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
           
        }

        public void GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
            if (propertyName == PropertyNames.IdTipoIndirizzo && _idTipoIndirizzo <= 0)
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }

            if (propertyName == "Sede" && _sede && _haveToSetTheError)
            {
                info.ErrorText = "Altri indirizzi hanno il flag confronta Parix";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }

            //if ((propertyName == PropertyNames.Via && String.IsNullOrEmpty(_via)))
            //{
            //    info.ErrorText = "Campo obbligatorio";
            //    info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            //}

            //if ((propertyName == PropertyNames.NumeroCivico && String.IsNullOrEmpty(_numeroCivico)))
            //{
            //    info.ErrorText = "Campo obbligatorio";
            //    info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            //}

            //if ((propertyName == PropertyNames.Cap && String.IsNullOrEmpty(_cap)))
            //{
            //    info.ErrorText = "Campo obbligatorio";
            //    info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            //}

            //if ((propertyName == PropertyNames.Provincia && String.IsNullOrEmpty(_provincia)))
            //{
            //    info.ErrorText = "Campo obbligatorio";
            //    info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            //}

            //if ((propertyName == PropertyNames.Comune && String.IsNullOrEmpty(_comune)))
            //{
            //    info.ErrorText = "Campo obbligatorio";
            //    info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            //}

            if ((propertyName == PropertyNames.DataInizio && (_dataInizio == DateTime.MinValue || _dataInizio == DateTime.MaxValue)))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }
        }

        #endregion

        public override void OnCreateInstance()
        {
            this._dataInizio = System.DateTime.Now;
            
            base.OnCreateInstance();
        }
    }
}
