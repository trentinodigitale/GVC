using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.FDT
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.PersonaFisicaFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.PersonaGiuridicaFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.SoggettoFDT))]
    [Serializable]
    public partial class CaricaSocialeFDT : FDTBase, DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo
    {
        #region Instance Variables (11)

        private int _idCarica;
        private int _idTipoCarica;
        private int _idComunicazione;
        private int _idSoggetto;
        private Boolean _legaleRappresentante;
        private Boolean _liquidatore;
        private Boolean _richiestaAntimafia;
        private Boolean _richiestaAntimafiaProdotta;
        private Boolean _richiestaAntimafiaArrivata;
        private String _descrizioneGSC;
        private DateTime? _dataInizio;
        private DateTime? _dataFine;
        private DateTime? _dataUltimaModifica;
        private String _operatoreUltimaModifica;

        private PersonaFisicaFDT _personaFisica;

        #endregion Instance Variables

        #region Public Properties (11)

        /// <summary>
        /// Gets the descrizione socio.
        /// </summary>
        /// <value>The descrizione socio.</value>
        [Bindable(true)]
        public string DescrizioneSocio
        {
            get
            {
                string toReturn = string.Empty;

                if (!String.IsNullOrEmpty(_descrizioneGSC))
                {
                    toReturn = _descrizioneGSC;
                }
                else if (_personaFisica != null)
                {
                    toReturn = _personaFisica.NomeCompleto;
                }

                return toReturn;
            }
        }

        /// <summary>
        /// Gets or sets the descrizione GSC.
        /// </summary>
        /// <value>The descrizione GSC.</value>
        [Bindable(true)]
        public string DescrizioneGSC
        {
            get { return _descrizioneGSC; }
            set { _descrizioneGSC = value; }
        }

        /// <summary>
        /// Gets or sets the persona fisica.
        /// </summary>
        /// <value>The persona fisica.</value>
        [Bindable(true)]
        public PersonaFisicaFDT PersonaFisica
        {
            get { return _personaFisica; }
            set { _personaFisica = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [richiesta antimafia arrivata].
        /// </summary>
        /// <value>
        /// 	<c>true</c> if [richiesta antimafia arrivata]; otherwise, <c>false</c>.
        /// </value>
        [Bindable(true)]
        public Boolean RichiestaAntimafiaArrivata
        {
            get { return _richiestaAntimafiaArrivata; }
            set { _richiestaAntimafiaArrivata = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [richiesta antimafia prodotta].
        /// </summary>
        /// <value>
        /// 	<c>true</c> if [richiesta antimafia prodotta]; otherwise, <c>false</c>.
        /// </value>
        [Bindable(true)]
        public Boolean RichiestaAntimafiaProdotta
        {
            get { return _richiestaAntimafiaProdotta; }
            set { _richiestaAntimafiaProdotta = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [richiesta antimafia].
        /// </summary>
        /// <value><c>true</c> if [richiesta antimafia]; otherwise, <c>false</c>.</value>
        [Bindable(true)]
        public Boolean RichiestaAntimafia
        {
            get { return _richiestaAntimafia; }
            set { _richiestaAntimafia = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CaricaSocialeFDT"/> is liquidatore.
        /// </summary>
        /// <value><c>true</c> if liquidatore; otherwise, <c>false</c>.</value>
        [Bindable(true)]
        public Boolean Liquidatore
        {
            get { return _liquidatore; }
            set { _liquidatore = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [legale rappresentante].
        /// </summary>
        /// <value><c>true</c> if [legale rappresentante]; otherwise, <c>false</c>.</value>
        [Bindable(true)]
        public Boolean LegaleRappresentante
        {
            get { return _legaleRappresentante; }
            set { _legaleRappresentante = value; }
        }

        /// <summary>
        /// Gets or sets the id tipo socio cooperativa.
        /// </summary>
        /// <value>The id tipo socio cooperativa.</value>
        [Bindable(true)]
        public int IdTipoCarica
        {
            get { return _idTipoCarica; }
            set { _idTipoCarica = value; }
        }

        [Bindable(true)]
        public int IdComunicazione
        {
            get { return _idComunicazione; }
            set { _idComunicazione = value; }
        }

        [Bindable(true)]
        public int IdSoggetto
        {
            get { return _idSoggetto; }
            set { _idSoggetto = value; }
        }
        /// <summary>
        /// Gets or sets the id socio cooperativa.
        /// </summary>
        /// <value>The id socio cooperativa.</value>
        [Bindable(true)]
        public int IdCarica
        {
            get { return _idCarica; }
            set { _idCarica = value; }
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
        /// Gets or sets the data inizio.
        /// </summary>
        /// <value>The data inizio.</value>
        [Bindable(true)]
        public DateTime? DataInizio
        {
            get { return _dataInizio; }
            set { _dataInizio = value; }
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
            public const string TipoCarica = "IdTipoCarica";
        }

        #endregion PropertyNames Class

        #region IDXDataErrorInfo Members

        public void GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {

        }

        public void GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
            if ((propertyName == PropertyNames.TipoCarica &&  _idTipoCarica <= 0))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }
        }

        #endregion

        public override void OnCreateInstance()
        {
            this._dataInizio = System.DateTime.Now;
        }
    }
}
