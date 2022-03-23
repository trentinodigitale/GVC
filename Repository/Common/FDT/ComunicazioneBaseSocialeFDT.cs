using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using it.dedagroup.GVC.Repository.Common.Configurations;

namespace it.dedagroup.GVC.Repository.Common.FDT
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public partial class ComunicazioneBaseSocialeFDT : FDTBase, DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo
    {
		#region Instance Variables (21) 

        private int _idComunicazioneBaseSociale;
        private int _idRegistro;
        private DateTime? _dataComunicazione;
        private DateTime _dataSituazione;
        private int _sociCooperatori;
        private int _sociSovventori;
        private int _sociAltreTipologie;
        private int _lavoratori;
        private int _lavoratoriSoci;
        private int _lavoratoriRemunerati;
        private int _sociUtenti;
        private int _sociVolontari;
        private int _sociPersoneGiuridiche;
        private int _totSoci;
        private int _lavoratoriSociENon;
        private int _personeSvantaggiate;
        private double? _capitaleSottoscritto;
        private double? _capitaleVersato;
        
        private double _valoreQuote;
        private double _valoreAzione;
        private string _note;
        private int _tipoConferimentoCapitale;
        private DateTime? _dataUltimaModifica;
        private string _operatoreUltimaModifica;
        private DocumentazioneFDT[] _documentazioni;

		#endregion Instance Variables 

		#region Public Properties (24) 

        /// <summary>
        /// Gets or sets the data comunicazione.
        /// </summary>
        /// <value>The data comunicazione.</value>
        [Bindable(true)]
        public DateTime? DataComunicazione
        {
            get { return _dataComunicazione; }
            set { _dataComunicazione = value; }
        }

        /// <summary>
        /// Gets or sets the soci cooperatori.
        /// </summary>
        /// <value>The soci cooperatori.</value>
        [Bindable(true)]
        public int SociCooperatori
        {
            get { return _sociCooperatori; }
            set { _sociCooperatori = value; }
        }

        /// <summary>
        /// Gets or sets the persone svantaggiate.
        /// </summary>
        /// <value>The persone svantaggiate.</value>
        [Bindable(true)]
        public int PersoneSvantaggiate
        {
            get { return _personeSvantaggiate; }
            set { _personeSvantaggiate = value; }
        }

        /// <summary>
        /// Gets or sets the documentazioni.
        /// </summary>
        /// <value>The documentazioni.</value>
        [Bindable(true)]
        public DocumentazioneFDT[] Documentazioni
        {
            get { return _documentazioni; }
            set { _documentazioni = value; }
        }

        /// <summary>
        /// Gets or sets the type of the id capital conferment.
        /// </summary>
        /// <value>The type of the id capital conferment.</value>
        [Bindable(true)]
        public int TipoConferimentoCapitale
        {
            get { return _tipoConferimentoCapitale; }
            set { _tipoConferimentoCapitale = value; }
        }

        /// <summary>
        /// Gets or sets the id communication social base.
        /// </summary>
        /// <value>The id communication social base.</value>
        [Bindable(true)]
        public int IdComunicazioneBaseSociale
        {
            get { return _idComunicazioneBaseSociale; }
            set { _idComunicazioneBaseSociale = value; }
        }

        /// <summary>
        /// Gets or sets the id registro.
        /// </summary>
        /// <value>The id registro.</value>
        [Bindable(true)]
        public int IdRegistro
        {
            get { return _idRegistro; }
            set { _idRegistro = value; }
        }

        /// <summary>
        /// Gets or sets the soci persone giuridiche.
        /// </summary>
        /// <value>The soci persone giuridiche.</value>
        [Bindable(true)]
        public int SociPersoneGiuridiche
        {
            get { return _sociPersoneGiuridiche; }
            set { _sociPersoneGiuridiche = value; }
        }

        /// <summary>
        /// Gets the totale soci.
        /// </summary>
        /// <value>The totale soci.</value>
        [Bindable(true)]
        public int TotaleSoci
        {
            get { return _totSoci; }
            set { _totSoci = value; }

        }

        [Bindable(true)]
        public double ValoreConferimento
        {
            get
            {
                if (_tipoConferimentoCapitale == 
                    it.dedagroup.GVC.Repository.Common.Configurations.TipoConferimentoCapitale.IDAzioni)
                {
                    return _valoreAzione;
                }
                else
                {
                    return _valoreQuote;
                }
            }
            set
            {
                if (_tipoConferimentoCapitale ==
                   it.dedagroup.GVC.Repository.Common.Configurations.TipoConferimentoCapitale.IDAzioni)
                {
                    _valoreAzione = value;
                    _valoreQuote = 0;
                }
                else
                {
                    _valoreAzione = 0;
                    _valoreQuote = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the soci utenti.
        /// </summary>
        /// <value>The soci utenti.</value>
        [Bindable(true)]
        public int SociUtenti
        {
            get { return _sociUtenti; }
            set { _sociUtenti = value; }
        }

        /// <summary>
        /// Gets or sets the soci volontari.
        /// </summary>
        /// <value>The soci volontari.</value>
        [Bindable(true)]
        public int SociVolontari
        {
            get { return _sociVolontari; }
            set { _sociVolontari = value; }
        }

        /// <summary>
        /// Gets or sets the minimum amount.
        /// </summary>
        /// <value>The minimum amount.</value>
        //[Bindable(true)]
        //public double MinimumAmount
        //{
        //    get { return _minimumAmount; }
        //    set { _minimumAmount = value; }
        //}

        [Bindable(true)]
        public double ValoreMinimoQuote
        {
            get {
                double toReturn = 0;

                if (_tipoConferimentoCapitale == 0)
                    toReturn = _valoreAzione;
                else if (_tipoConferimentoCapitale == 1)
                    toReturn = _valoreQuote;

                return toReturn;
            }
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
        /// Gets or sets the soci altre tipologie.
        /// </summary>
        /// <value>The soci altre tipologie.</value>
        [Bindable(true)]
        public int SociAltreTipologie
        {
            get { return _sociAltreTipologie; }
            set { _sociAltreTipologie = value; }
        }

        /// <summary>
        /// Gets or sets the soci sovventori.
        /// </summary>
        /// <value>The soci sovventori.</value>
        [Bindable(true)]
        public int SociSovventori
        {
            get { return _sociSovventori; }
            set { _sociSovventori = value; }
        }

        /// <summary>
        /// Gets or sets the capitale versato.
        /// </summary>
        /// <value>The capitale versato.</value>
        [Bindable(true)]
        public double? CapitaleVersato
        {
            get { return _capitaleVersato; }
            set { _capitaleVersato = value; }
        }

        /// <summary>
        /// Gets or sets the share value.
        /// </summary>
        /// <value>The share value.</value>
        [Bindable(true)]
        public double ValoreQuote
        {
            get { return _valoreQuote; }
            set { _valoreQuote = value; }
        }

        /// <summary>
        /// Gets or sets the valore azione.
        /// </summary>
        /// <value>The valore azione.</value>
        [Bindable(true)]
        public double ValoreAzione
        {
            get { return _valoreAzione; }
            set { _valoreAzione = value; }
        }

        /// <summary>
        /// Gets or sets the data situazione.
        /// </summary>
        /// <value>The data situazione.</value>
        [Bindable(true)]
        public DateTime DataSituazione
        {
            get { return _dataSituazione; }
            set { _dataSituazione = value; }
        }

        /// <summary>
        /// Gets or sets the capitale sottoscritto.
        /// </summary>
        /// <value>The capitale sottoscritto.</value>
        [Bindable(true)]
        public double? CapitaleSottoscritto
        {
            get { return _capitaleSottoscritto; }
            set { _capitaleSottoscritto = value; }
        }

        /// <summary>
        /// Gets or sets the lavoratori soci.
        /// </summary>
        /// <value>The lavoratori soci.</value>
        [Bindable(true)]
        public int LavoratoriSoci
        {
            get { return _lavoratoriSoci; }
            set { _lavoratoriSoci = value; }
        }

        /// <summary>
        /// Gets or sets the lavoratori.
        /// </summary>
        /// <value>The lavoratori.</value>
        [Bindable(true)]
        public int Lavoratori
        {
            get { return _lavoratori; }
            set { _lavoratori = value; }
        }

        /// <summary>
        /// Gets or sets the lavoratori soci E non.
        /// </summary>
        /// <value>The lavoratori soci E non.</value>
        [Bindable(true)]
        public int LavoratoriSociENon
        {
            get { return _lavoratoriSociENon; }
            set { _lavoratoriSociENon = value; }
        }

        /// <summary>
        /// Gets or sets the lavoratori remunerati.
        /// </summary>
        /// <value>The lavoratori remunerati.</value>
        [Bindable(true)]
        public int LavoratoriRemunerati
        {
            get { return _lavoratoriRemunerati; }
            set { _lavoratoriRemunerati = value; }
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

		#endregion Public Properties 

		#region Public Methods (1) 

        public override void OnCreateInstance()
        {
            this._dataComunicazione = System.DateTime.Now;
            this._dataSituazione = new System.DateTime(System.DateTime.Now.Year - 1, 12, 31);
            base.OnCreateInstance();
        }

		#endregion Public Methods 

        #region PropertyNames Class

        /// <summary>
        /// PropertyNames
        /// </summary>
        public partial class PropertyNames
        {
            public const string DataComunicazione = "DataComunicazione";
            public const string DataSituazione = "DataSituazione";
        }

        #endregion PropertyNames Class

        #region IDXDataErrorInfo Members

        public void GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {

        }

        public void GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
            if ((propertyName == "DataComunicazione" && (_dataComunicazione == DateTime.MinValue || _dataComunicazione == DateTime.MaxValue)))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }

            if ((propertyName == "DataSituazione" && (_dataSituazione == DateTime.MinValue || _dataSituazione == DateTime.MaxValue)))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }
        }

        #endregion
    }
}
