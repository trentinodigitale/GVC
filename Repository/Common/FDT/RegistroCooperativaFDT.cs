using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;

namespace it.dedagroup.GVC.Repository.Common.FDT
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.PersonaFisicaFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.PersonaGiuridicaFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.SoggettoFDT))]
    [Serializable]
    public partial class RegistroCooperativaFDT : FDTBase, DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo
    {

		#region Fields (51) 

        private AdesioneFDT[] _adesioni;
        private Boolean _aggiornaNrScioglimento;
        private DeliberaAssembleaFDT[] _assemblee;
        private AttivitaFDT[] _attivita;
        private AttivitaFDT[] _attivitaParix;
        private DateTime? _bilancioEsercizioAl;
        private CambioPosizioneFDT[] _cambioPosizioni;
        private CancellazioneFDT _cancellazione;
        //private int _categoriaSociale;
        private int _codiceCooperativa;
        private String _codiceOperatore;
        private String _codiceUfficio;
        private ComunicazioneBaseSocialeFDT[] _comunicazioniBaseSociale;
        private ComunicazioneCaricaSocialeFDT[] _comunicazioniPosizioneCaricaSociale;
        private DateTime? _dataAcquisizioneAtto;
        private DateTime? _dataBFL;
        private DateTime? _dataCostituzione;
        private DateTime? _dataDepositoAtto;
        private DateTime? _dataDepositoBFL;
        private DateTime? _dataEsameComm;
        private DateTime? _dataUltimaModifica;
        private DatiStoriciFDT[] _datiStoriciRegistro;
        private DocumentazioneFDT[] _documentazioni;
        private CartellaFDT[] _cartelle;
        private DateTime? _durata;
        private int _durataIllimitata;
        private Boolean _esenzioneVersamentoUtili;
        private String _formaAmministrativaParix;
        private String _formaGiuridicaParix;
        private Boolean _gruppoParitetico;
        private int _idCadenzaRevisione;
        private int _idFormaAmm;
        private int _idFormaGiu;
        private int _idNotaio;
        private int _idRegistro;
        private int _idSoggetto;
        private int _idStatoIscrizione;
        private int _idTipoCostituzione;
        private double _importoVersamentoPatrimonioResiduo;
        private LiquidazioneCoattaFDT[] _liquidazioniCoatte;
        //private DateTime? _dataRicevimentoDomanda;
        //private String _numeroDetermina;
        //private int _sottoSezione;
        //private DateTime? _dataDeliberaCommissione;
        //private String _numeroDeliberaCommissione;
        //private int _sezione;   
        //private DateTime? _dataDetermina;
        //private int _idSottoCategoriaSociale;
        //private int _idCategoria;
        //private int _valuta;
        //private int _idNotaio;       
        //private Boolean _processoChiuso;     
        //private int _processTime;
        //private DateTime _registrationOfficeProcessDate;
        //private Boolean _undeterminedEnd;
        //private DateTime _dataFineProcessoTeorica;
        private PersonaFisicaFDT _notaio;
        private String _numeroEsameComm;
        private String _numeroIscrizioneAlboNaz;
        private String _numeroREA;
        private String _numeroRepertorioNotarile;
        private String _numeroRI;
        private int? _numeroScioglimento;
        private String _operatoreUltimaModifica;
        private ProceduraCoattaFDT[] _procedureCoatte;
        private ProceduraFallimentareFDT[] _procedureFallimentari;
        private RevisioneFDT[] _revisioni;
        private ScadenziarioFDT[] _scadenzaAnnotazioni;
        private ProcedimentoFDT[] _procedimenti;
        private BilancioFDT[] _bilanci;
        private SanzioneFDT[] _sanzioni;
        private Boolean _dirigente;

		#endregion Fields 

		#region Properties (54) 

        /// <summary>
        /// Gets or sets the sanzioni.
        /// </summary>
        /// <value>The sanzioni.</value>
        [Bindable(true)]
        public SanzioneFDT[] Sanzioni
        {
            get { return _sanzioni; }
            set { _sanzioni = value; }
        }

        /// <summary>
        /// Gets or sets the adesioni.
        /// </summary>
        /// <value>The adesioni.</value>
        [Bindable(true)]
        public AdesioneFDT[] Adesioni
        {
            get { return _adesioni; }
            set { _adesioni = value; }
        }

        /// <summary>
        /// Gets or sets the bilanci.
        /// </summary>
        /// <value>The bilanci.</value>
        [Bindable(true)]
        public BilancioFDT[] Bilanci
        {
            get { return _bilanci; }
            set { _bilanci = value; }
        }

        /// <summary>
        /// Gets or sets the procedimenti.
        /// </summary>
        /// <value>The procedimenti.</value>
        [Bindable(true)]
        public ProcedimentoFDT[] Procedimenti
        {
            get { return _procedimenti; }
            set { _procedimenti = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [aggiorna nr scioglimento].
        /// </summary>
        /// <value>
        /// 	<c>true</c> if [aggiorna nr scioglimento]; otherwise, <c>false</c>.
        /// </value>
        [Bindable(true)]
        public Boolean AggiornaNrScioglimento
        {
            get { return _aggiornaNrScioglimento; }
            set { _aggiornaNrScioglimento = value; }
        }

        /// <summary>
        /// Gets or sets the assemblee.
        /// </summary>
        /// <value>The assemblee.</value>
        [Bindable(true)]
        public DeliberaAssembleaFDT[] Assemblee
        {
            get { return _assemblee; }
            set { _assemblee = value; }
        }

        /// <summary>
        /// Gets or sets the attivita.
        /// </summary>
        /// <value>The attivita.</value>
        [Bindable(true)]
        public AttivitaFDT[] Attivita
        {
            get { return _attivita; }
            set { _attivita = value; }
        }

        /// <summary>
        /// Gets or sets the attivita parix.
        /// </summary>
        /// <value>The attivita parix.</value>
        [Bindable(true)]
        public AttivitaFDT[] AttivitaParix
        {
            get { return _attivitaParix; }
            set { _attivitaParix = value; }
        }

        /// <summary>
        /// Gets or sets the bilancio esercizio al.
        /// </summary>
        /// <value>The bilancio esercizio al.</value>
        [Bindable(true)]
        public DateTime? BilancioEsercizioAl
        {
            get { return _bilancioEsercizioAl; }
            set { _bilancioEsercizioAl = value; }
        }

        /// <summary>
        /// Gets or sets the position changes.
        /// </summary>
        /// <value>The position changes.</value>
        [Bindable(true)]
        public CambioPosizioneFDT[] CambioPosizioni
        {
            get { return _cambioPosizioni; }
            set { _cambioPosizioni = value; }
        }

        /// <summary>
        /// Gets or sets the cancellazione.
        /// </summary>
        /// <value>The cancellazione.</value>
        public CancellazioneFDT Cancellazione
        {
            get { return _cancellazione; }
            set { _cancellazione = value; }
        }

        /// <summary>
        /// Gets or sets the codice cooperativa.
        /// </summary>
        /// <value>The codice cooperativa.</value>
        [Bindable(true)]
        public int CodiceCooperativa
        {
            get { return _codiceCooperativa; }
            set { _codiceCooperativa = value; }
        }

        /// <summary>
        /// Gets or sets the codice operatore.
        /// </summary>
        /// <value>The codice operatore.</value>
        [Bindable(true)]
        public String CodiceOperatore
        {
            get { return _codiceOperatore; }
            set { _codiceOperatore = value; }
        }

        /// <summary>
        /// Gets or sets the id notaio.
        /// </summary>
        /// <value>The id notaio.</value>
        //[Bindable(true)]
        //public int IdNotaio
        //{
        //    get { return _idNotaio; }
        //    set { _idNotaio = value; }
        //}
        /// <summary>
        /// Gets or sets the codice ufficio.
        /// </summary>
        /// <value>The codice ufficio.</value>
        [Bindable(true)]
        public String CodiceUfficio
        {
            get { return _codiceUfficio; }
            set { _codiceUfficio = value; }
        }

        /// <summary>
        /// Gets or sets the comunicazioni base sociale.
        /// </summary>
        /// <value>The comunicazioni base sociale.</value>
        [Bindable(true)]
        public ComunicazioneBaseSocialeFDT[] ComunicazioniBaseSociale
        {
            get { return _comunicazioniBaseSociale; }
            set { _comunicazioniBaseSociale = value; }
        }

        /// <summary>
        /// Gets or sets the comunicazioni posizione carica sociale.
        /// </summary>
        /// <value>The comunicazioni posizione carica sociale.</value>
        [Bindable(true)]
        public ComunicazioneCaricaSocialeFDT[] ComunicazioniPosizioneCaricaSociale
        {
            get { return _comunicazioniPosizioneCaricaSociale; }
            set { _comunicazioniPosizioneCaricaSociale = value; }
        }

        /// <summary>
        /// Gets or sets the data acquisizione atto.
        /// </summary>
        /// <value>The data acquisizione atto.</value>
        [Bindable(true)]
        public DateTime? DataAcquisizioneAtto
        {
            get { return _dataAcquisizioneAtto; }
            set { _dataAcquisizioneAtto = value; }
        }

        /// <summary>
        /// Gets or sets the data BFL.
        /// </summary>
        /// <value>The data BFL.</value>
        [Bindable(true)]
        public DateTime? DataBFL
        {
            get { return _dataBFL; }
            set { _dataBFL = value; }
        }

        /// <summary>
        /// Gets or sets the data costituzione.
        /// </summary>
        /// <value>The data costituzione.</value>
        [Bindable(true)]
        public DateTime? DataCostituzione
        {
            get { return _dataCostituzione; }
            set { _dataCostituzione = value; }
        }

        /// <summary>
        /// Gets or sets the data deposito atto.
        /// </summary>
        /// <value>The data deposito atto.</value>
        [Bindable(true)]
        public DateTime? DataDepositoAtto
        {
            get { return _dataDepositoAtto; }
            set { _dataDepositoAtto = value; }
        }

        /// <summary>
        /// Gets or sets the data deposito BFL.
        /// </summary>
        /// <value>The data deposito BFL.</value>
        [Bindable(true)]
        public DateTime? DataDepositoBFL
        {
            get { return _dataDepositoBFL; }
            set { _dataDepositoBFL = value; }
        }

        /// <summary>
        /// Gets a value indicating whether [data durata presente].
        /// </summary>
        /// <value><c>true</c> if [data durata presente]; otherwise, <c>false</c>.</value>
        [Bindable(true)]
        public Boolean DataDurataPresente
        {
            get
            {
                if (Durata != DateTime.MinValue)
                    return true;
                return false;
            }
        }

        /// <summary>
        /// Gets or sets the data esame comm.
        /// </summary>
        /// <value>The data esame comm.</value>
        [Bindable(true)]
        public DateTime? DataEsameComm
        {
            get { return _dataEsameComm; }
            set { _dataEsameComm = value; }
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
        /// Gets or sets the dati storici registro.
        /// </summary>
        /// <value>The dati storici registro.</value>
        public DatiStoriciFDT[] DatiStoriciRegistro
        {
            get { return _datiStoriciRegistro; }
            set { _datiStoriciRegistro = value; }
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
        /// Gets or sets the documentazioni.
        /// </summary>
        /// <value>The documentazioni.</value>
        [Bindable(true)]
        public CartellaFDT[] Cartelle
        {
            get { return _cartelle; }
            set { _cartelle = value; }
        }

        /// <summary>
        /// Gets or sets the durata.
        /// </summary>
        /// <value>The durata.</value>
        [Bindable(true)]
        public DateTime? Durata
        {
            get { return _durata; }
            set { _durata = value; }
        }

        /// <summary>
        /// Gets or sets the sezione.
        /// </summary>
        /// <value>The sezione.</value>
        //[Bindable(true)]
        //public int Sezione
        //{
        //    get { return _sezione; }
        //    set { _sezione = value; }
        //}
        /// <summary>
        /// Gets or sets a value indicating whether [categoria sociale].
        /// </summary>
        /// <value><c>true</c> if [categoria sociale]; otherwise, <c>false</c>.</value>
        //[Bindable(true)]
        //public int CategoriaSociale
        //{
        //    get { return _categoriaSociale; }
        //    set { _categoriaSociale = value; }
        //}
        /// <summary>
        /// Gets or sets the sotto categoria sociale.
        /// </summary>
        /// <value>The sotto categoria sociale.</value>
        //[Bindable(true)]
        //public int IdSottoCategoriaSociale
        //{
        //    get { return _idSottoCategoriaSociale; }
        //    set { _idSottoCategoriaSociale = value; }
        //}
        /// <summary>
        /// Gets or sets the sotto sezione.
        /// </summary>
        /// <value>The sotto sezione.</value>
        //[Bindable(true)]
        //public int SottoSezione
        //{
        //    get { return _sottoSezione; }
        //    set { _sottoSezione = value; }
        //}
        /// <summary>
        /// Gets or sets the data fine processo teorica.
        /// </summary>
        /// <value>The data fine processo teorica.</value>
        //[Bindable(true)]
        //public DateTime DataFineProcessoTeorica
        //{
        //    get { return _dataFineProcessoTeorica; }
        //    set { _dataFineProcessoTeorica = value; }
        //}
        /// <summary>
        /// Gets or sets a value indicating whether [undetermined end].
        /// </summary>
        /// <value><c>true</c> if [undetermined end]; otherwise, <c>false</c>.</value>
        //[Bindable(true)]
        //public Boolean UndeterminedEnd
        //{
        //    get { return _undeterminedEnd; }
        //    set { _undeterminedEnd = value; }
        //}
        /// <summary>
        /// Gets or sets a value indicating whether [unlimited end].
        /// </summary>
        /// <value><c>true</c> if [unlimited end]; otherwise, <c>false</c>.</value>
        [Bindable(true)]
        public int DurataIllimitata
        {
            get { return _durataIllimitata; }
            set { _durataIllimitata = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [esenzione versamento utili].
        /// </summary>
        /// <value>
        /// 	<c>true</c> if [esenzione versamento utili]; otherwise, <c>false</c>.
        /// </value>
        [Bindable(true)]
        public Boolean EsenzioneVersamentoUtili
        {
            get { return _esenzioneVersamentoUtili; }
            set { _esenzioneVersamentoUtili = value; }
        }

        /// <summary>
        /// Gets or sets the forma amministrativa parix.
        /// </summary>
        /// <value>The forma amministrativa parix.</value>
        [Bindable(true)]
        public String FormaAmministrativaParix
        {
            get { return _formaAmministrativaParix; }
            set { _formaAmministrativaParix = value; }
        }

        /// <summary>
        /// Gets or sets the forma giuridica.
        /// </summary>
        /// <value>The forma giuridica.</value>
        //[Bindable(true)]
        //public String FormaGiuridica
        //{
        //    get { return _formaGiuridica; }
        //    set { _formaGiuridica = value; }
        //}
        /// <summary>
        /// Gets or sets the forma giuridica parix.
        /// </summary>
        /// <value>The forma giuridica parix.</value>
        [Bindable(true)]
        public String FormaGiuridicaParix
        {
            get { return _formaGiuridicaParix; }
            set { _formaGiuridicaParix = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [processo chiuso].
        /// </summary>
        /// <value><c>true</c> if [processo chiuso]; otherwise, <c>false</c>.</value>
        //[Bindable(true)]
        //public Boolean ProcessoChiuso
        //{
        //    get { return _processoChiuso; }
        //    set { _processoChiuso = value; }
        //}
        /// <summary>
        /// Gets or sets a value indicating whether [gruppo paritetico].
        /// </summary>
        /// <value><c>true</c> if [gruppo paritetico]; otherwise, <c>false</c>.</value>
        [Bindable(true)]
        public Boolean GruppoParitetico
        {
            get { return _gruppoParitetico; }
            set { _gruppoParitetico = value; }
        }

        [Bindable(true)]
        public Boolean HaDataDefinita
        {
            get
            {
                if (!_durata.HasValue)
                {
                    return false;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Gets or sets the id sotto categoria soc.
        /// </summary>
        /// <value>The id sotto categoria soc.</value>
        //[Bindable(true)]
        //public int IdSottoCategoriaSoc
        //{
        //    get { return _idSottoCategoriaSoc; }
        //    set { _idSottoCategoriaSoc = value; }
        //}
        /// <summary>
        /// Gets or sets the id stato iscrizione.
        /// </summary>
        /// <value>The id stato iscrizione.</value>
        //[Bindable(true)]
        //public int IdStatoIscrizione
        //{
        //    get { return _idStatoIscrizione; }
        //    set { _idStatoIscrizione = value; }
        //}
        /// <summary>
        /// Gets or sets the id tipo costituzione.
        /// </summary>
        /// <value>The id tipo costituzione.</value>
        //[Bindable(true)]
        //public int TipoCostituzione
        //{
        //    get { return _idTipoCostituzione; }
        //    set { _idTipoCostituzione = value; }
        //}
        /// <summary>
        /// Gets or sets the id cadenza revisione.
        /// </summary>
        /// <value>The id cadenza revisione.</value>
        [Bindable(true)]
        public int IdCadenzaRevisione
        {
            get { return _idCadenzaRevisione; }
            set { _idCadenzaRevisione = value; }
        }

        /// <summary>
        /// Gets or sets the forma amministrativa.
        /// </summary>
        /// <value>The forma amministrativa.</value>
        [Bindable(true)]
        public int IdFormaAmm
        {
            get { return _idFormaAmm; }
            set { _idFormaAmm = value; }
        }

        /// <summary>
        /// Gets or sets the id forma amm.
        /// </summary>
        /// <value>The id forma amm.</value>
        //[Bindable(true)]
        //public int IdFormaAmm
        //{
        //    get { return _idFormaAmm; }
        //    set { _idFormaAmm = value; }
        //}
        /// <summary>
        /// Gets or sets the id forma giu.
        /// </summary>
        /// <value>The id forma giu.</value>
        [Bindable(true)]
        public int IdFormaGiu
        {
            get { return _idFormaGiu; }
            set { _idFormaGiu = value; }
        }

        /// <summary>
        /// Gets or sets the id notaio.
        /// </summary>
        /// <value>The id notaio.</value>
        [Bindable(true)]
        public int IdNotaio
        {
            get { return _idNotaio; }
            set { _idNotaio = value; }
        }

        /// <summary>
        /// Gets or sets the id cadenza revisione.
        /// </summary>
        /// <value>The id cadenza revisione.</value>
        [Bindable(true)]
        public int IdRegistro
        {
            get { return _idRegistro; }
            set { _idRegistro = value; }
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
        /// Alternativa alla data ricevimento domanda (se ci fossero entrambe viene presa la più vecchia)
        /// </summary>
        //[Bindable(true)]
        //public DateTime RegistrationOfficeProcessDate
        //{
        //    get { return _registrationOfficeProcessDate; }
        //    set { _registrationOfficeProcessDate = value; }
        //}
        /// <summary>
        /// Gets or sets the stato iscrizione.
        /// </summary>
        /// <value>The stato iscrizione.</value>
        [Bindable(true)]
        public int IdStatoIscrizione
        {
            get { return _idStatoIscrizione; }
            set { _idStatoIscrizione = value; }
        }

        /// <summary>
        /// Gets or sets the categoria.
        /// </summary>
        /// <value>The categoria.</value>
        //[Bindable(true)]
        //public String Categoria
        //{
        //    get { return _categoria; }
        //    set { _categoria = value; }
        //}
        /// <summary>
        /// Gets or sets the costituzione.
        /// </summary>
        /// <value>The costituzione.</value>
        [Bindable(true)]
        public int IdTipoCostituzione
        {
            get { return _idTipoCostituzione; }
            set { _idTipoCostituzione = value; }
        }

        /// <summary>
        /// Gets or sets the data ricevimento domanda.
        /// </summary>
        /// <value>The data ricevimento domanda.</value>
        //[Bindable(true)]
        //public DateTime? DataRicevimentoDomanda
        //{
        //    get { return _dataRicevimentoDomanda; }
        //    set { _dataRicevimentoDomanda = value; }
        //}
        /// <summary>
        /// Gets or sets the importo versamento patrimonio residuo.
        /// </summary>
        /// <value>The importo versamento patrimonio residuo.</value>
        [Bindable(true)]
        public double ImportoVersamentoPatrimonioResiduo
        {
            get { return _importoVersamentoPatrimonioResiduo; }
            set { _importoVersamentoPatrimonioResiduo = value; }
        }

        [Bindable(true)]
        public CambioPosizioneFDT Iscrizione
        {
            get
            {
                CambioPosizioneFDT item = null;
                if (this.CambioPosizioni != null &&
                   this.CambioPosizioni.Length > 0)
                {
                    for (int i = 0; i < this.CambioPosizioni.Length; i++)
                    {
                        if (this.CambioPosizioni[i].Status < ObjectStatus.ToHide)
                        {
                            item = this.CambioPosizioni[i];
                            break;
                        }
                    }
                }

                return item;
            }
        }

        /// <summary>
        /// Gets or sets the liquidazioni coatte.
        /// </summary>
        /// <value>The liquidazioni coatte.</value>
        [Bindable(true)]
        public LiquidazioneCoattaFDT[] LiquidazioniCoatte
        {
            get { return _liquidazioniCoatte; }
            set { _liquidazioniCoatte = value; }
        }

        /// <summary>
        /// Gets or sets the notaio.
        /// </summary>
        /// <value>The notaio.</value>
        [Bindable(true)]
        public PersonaFisicaFDT Notaio
        {
            get { return _notaio; }
            set { _notaio = value; }
        }

        /// <summary>
        /// Gets or sets the numero esame comm.
        /// </summary>
        /// <value>The numero esame comm.</value>
        [Bindable(true)]
        public String NumeroEsameComm
        {
            get { return _numeroEsameComm; }
            set { _numeroEsameComm = value; }
        }

        /// <summary>
        /// Gets or sets the numero iscrizione albo naz.
        /// </summary>
        /// <value>The numero iscrizione albo naz.</value>
        [Bindable(true)]
        public String NumeroIscrizioneAlboNaz
        {
            get { return _numeroIscrizioneAlboNaz; }
            set { _numeroIscrizioneAlboNaz = value; }
        }

        /// <summary>
        /// Gets or sets the process time.
        /// </summary>
        /// <value>The process time.</value>
        //[Bindable(true)]
        //public int ProcessTime
        //{
        //    get { return _processTime; }
        //    set { _processTime = value; }
        //}
        /// <summary>
        /// Gets or sets the numero REA.
        /// </summary>
        /// <value>The numero REA.</value>
        [Bindable(true)]
        public String NumeroREA
        {
            get { return _numeroREA; }
            set { _numeroREA = value; }
        }

        /// <summary>
        /// Gets or sets the numero repertorio notarile.
        /// </summary>
        /// <value>The numero repertorio notarile.</value>
        [Bindable(true)]
        public String NumeroRepertorioNotarile
        {
            get { return _numeroRepertorioNotarile; }
            set { _numeroRepertorioNotarile = value; }
        }

        /// <summary>
        /// Gets or sets the id categoria.
        /// </summary>
        /// <value>The id categoria.</value>
        //[Bindable(true)]
        //public int IdCategoria
        //{
        //    get { return _idCategoria; }
        //    set { _idCategoria = value; }
        //}
        /// <summary>
        /// Gets or sets the numero RI.
        /// </summary>
        /// <value>The numero RI.</value>
        [Bindable(true)]
        public String NumeroRI
        {
            get { return _numeroRI; }
            set { _numeroRI = value; }
        }

        /// <summary>
        /// Gets or sets the id valuta.
        /// </summary>
        /// <value>The id valuta.</value>
        //[Bindable(true)]
        //public int Valuta
        //{
        //    get { return _valuta; }
        //    set { _valuta = value; }
        //}
        /// <summary>
        /// Gets or sets the data delibera commissione.
        /// </summary>
        /// <value>The data delibera commissione.</value>
        //[Bindable(true)]
        //public DateTime? DataDeliberaCommissione
        //{
        //    get { return _dataDeliberaCommissione; }
        //    set { _dataDeliberaCommissione = value; }
        //}
        /// <summary>
        /// Gets or sets the numero delibera commissione.
        /// </summary>
        /// <value>The numero delibera commissione.</value>
        //[Bindable(true)]
        //public String NumeroDeliberaCommissione
        //{
        //    get { return _numeroDeliberaCommissione; }
        //    set { _numeroDeliberaCommissione = value; }
        //}
        /// <summary>
        /// Sarà vuoto per le "non iscritte", altrimenti sarà la data che chiude il 
        /// procedimento di iscrizione al registro
        /// </summary>
        //[Bindable(true)]
        //public DateTime? DataDetermina
        //{
        //    get { return _dataDetermina; }
        //    set { _dataDetermina = value; }
        //}
        /// <summary>
        /// Sarà vuoto per le "non iscritte", altrimentiè il numero della 
        /// determina di iscrizione della cooperativa
        /// </summary>
        //[Bindable(true)]
        //public String NumeroDetermina
        //{
        //    get { return _numeroDetermina; }
        //    set { _numeroDetermina = value; }
        //}
        /// <summary>
        /// Gets or sets the numero scioglimento.
        /// </summary>
        /// <value>The numero scioglimento.</value>
        [Bindable(true)]
        public int? NumeroScioglimento
        {
            get { return _numeroScioglimento; }
            set { _numeroScioglimento = value; }
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

        [Bindable(true)]
        public CambioPosizioneFDT PosizioneAttuale
        {
            get 
            {
                CambioPosizioneFDT item = null;
                if (this.CambioPosizioni != null &&
                   this.CambioPosizioni.Length > 0)
                {
                    for (int i = this.CambioPosizioni.Length - 1; i >= 0; i--)
                    {
                        if (this.CambioPosizioni[i].Status < ObjectStatus.ToHide)
                        {
                            item = this.CambioPosizioni[i];
                            break;
                        }
                    }
                }

                return item;
            }
        }

        /// <summary>
        /// Gets or sets the procedure coatte.
        /// </summary>
        /// <value>The procedure coatte.</value>
        [Bindable(true)]
        public ProceduraCoattaFDT[] ProcedureCoatte
        {
            get { return _procedureCoatte; }
            set { _procedureCoatte = value; }
        }

        /// <summary>
        /// Gets or sets the procedure fallimentari.
        /// </summary>
        /// <value>The procedure fallimentari.</value>
        [Bindable(true)]
        public ProceduraFallimentareFDT[] ProcedureFallimentari
        {
            get { return _procedureFallimentari; }
            set { _procedureFallimentari = value; }
        }

        /// <summary>
        /// Gets or sets the revisioni.
        /// </summary>
        /// <value>The revisioni.</value>
        [Bindable(true)]
        public RevisioneFDT[] Revisioni
        {
            get { return _revisioni; }
            set { _revisioni = value; }
        }

        /// <summary>
        /// Gets or sets the remark expirations.
        /// </summary>
        /// <value>The remark expirations.</value>
        [Bindable(true)]
        public ScadenziarioFDT[] ScadenzaAnnotazioni
        {
            get { return _scadenzaAnnotazioni; }
            set { _scadenzaAnnotazioni = value; }
        }

        [Bindable(true)]
        public Boolean Dirigente
        {
            get { return _dirigente; }
            set { _dirigente = value; }
        }
		#endregion Properties 

		#region Methods (11) 


		// Public Methods (11) 

        public void AddAdesione(AdesioneFDT item)
        {
            if (Adesioni == null)
                Adesioni = new AdesioneFDT[]{};

            List<AdesioneFDT> lTemp = new List<AdesioneFDT>(Adesioni);
            lTemp.Add(item);
            Adesioni = lTemp.ToArray();
        }

        public void AddCambioPosizione(CambioPosizioneFDT item)
        {
            if (CambioPosizioni == null)
                CambioPosizioni = new CambioPosizioneFDT[] { };

            List<CambioPosizioneFDT> lTemp = new List<CambioPosizioneFDT>(CambioPosizioni);
            lTemp.Add(item);
            CambioPosizioni = lTemp.ToArray();
        }

        public void AddComunicazioneBS(ComunicazioneBaseSocialeFDT item)
        {
            if (ComunicazioniBaseSociale == null)
                ComunicazioniBaseSociale = new ComunicazioneBaseSocialeFDT[] { };

            List<ComunicazioneBaseSocialeFDT> lTemp = new List<ComunicazioneBaseSocialeFDT>(ComunicazioniBaseSociale);
            lTemp.Add(item);
            ComunicazioniBaseSociale = lTemp.ToArray();
        }

        public void AddComunicazioneCS(ComunicazioneCaricaSocialeFDT item)
        {
            if (ComunicazioniPosizioneCaricaSociale == null)
                ComunicazioniPosizioneCaricaSociale = new ComunicazioneCaricaSocialeFDT[] { };

            List<ComunicazioneCaricaSocialeFDT> lTemp = new List<ComunicazioneCaricaSocialeFDT>(ComunicazioniPosizioneCaricaSociale);
            lTemp.Add(item);
            ComunicazioniPosizioneCaricaSociale = lTemp.ToArray();
        }

        public void AddDeliberaAssemblea(DeliberaAssembleaFDT item)
        {
            if (Assemblee == null)
                Assemblee = new DeliberaAssembleaFDT[] { };

            List<DeliberaAssembleaFDT> lTemp = new List<DeliberaAssembleaFDT>(Assemblee);
            lTemp.Add(item);
            Assemblee = lTemp.ToArray();
        }

        public void AddDocumentazione(DocumentazioneFDT item)
        {
            if (Documentazioni == null)
                Documentazioni = new DocumentazioneFDT[] { };

            List<DocumentazioneFDT> lTemp = new List<DocumentazioneFDT>(Documentazioni);
            lTemp.Add(item);
            Documentazioni = lTemp.ToArray();
        }

        public void AddLiquidazioneCoatta(LiquidazioneCoattaFDT item)
        {
            if (LiquidazioniCoatte == null)
                LiquidazioniCoatte = new LiquidazioneCoattaFDT[] { };

            List<LiquidazioneCoattaFDT> lTemp = new List<LiquidazioneCoattaFDT>(LiquidazioniCoatte);
            lTemp.Add(item);
            LiquidazioniCoatte = lTemp.ToArray();
        }

        public void AddProceduraCoatta(ProceduraCoattaFDT item)
        {
            if (ProcedureCoatte == null)
                ProcedureCoatte = new ProceduraCoattaFDT[] { };

            List<ProceduraCoattaFDT> lTemp = new List<ProceduraCoattaFDT>(ProcedureCoatte);
            lTemp.Add(item);
            ProcedureCoatte = lTemp.ToArray();
        }

        public void AddProceduraFallimentare(ProceduraFallimentareFDT item)
        {
            if (ProcedureFallimentari == null)
                ProcedureFallimentari = new ProceduraFallimentareFDT[] { };

            List<ProceduraFallimentareFDT> lTemp = new List<ProceduraFallimentareFDT>(ProcedureFallimentari);
            lTemp.Add(item);
            ProcedureFallimentari = lTemp.ToArray();
        }

        public void AddRevisione(RevisioneFDT item)
        {
            if (Revisioni == null)
                Revisioni = new RevisioneFDT[] { };

            List<RevisioneFDT> lTemp = new List<RevisioneFDT>(Revisioni);
            lTemp.Add(item);
            Revisioni = lTemp.ToArray();
        }

        public void AddScadenziario(ScadenziarioFDT item)
        {
            if (ScadenzaAnnotazioni == null)
                ScadenzaAnnotazioni = new ScadenziarioFDT[] { };

            List<ScadenziarioFDT> lTemp = new List<ScadenziarioFDT>(ScadenzaAnnotazioni);
            lTemp.Add(item);
            ScadenzaAnnotazioni = lTemp.ToArray();
        }

        public void AddProcedimento(ProcedimentoFDT item)
        {
            if (Procedimenti == null)
                Procedimenti = new ProcedimentoFDT[] { };

            List<ProcedimentoFDT> lTemp = new List<ProcedimentoFDT>(Procedimenti);
            lTemp.Add(item);
            Procedimenti = lTemp.ToArray();
        }

        public void AddBilancio(BilancioFDT item)
        {
            if (Bilanci == null)
                Bilanci = new BilancioFDT[] { };

            List<BilancioFDT> lTemp = new List<BilancioFDT>(Bilanci);
            lTemp.Add(item);
            Bilanci = lTemp.ToArray();
        }

        public void AddSanzione(SanzioneFDT item)
        {
            if (Sanzioni == null)
                Sanzioni = new SanzioneFDT[] { };

            List<SanzioneFDT> lTemp = new List<SanzioneFDT>(Sanzioni);
            lTemp.Add(item);
            Sanzioni = lTemp.ToArray();
        }

        public override void OnCreateInstance()
        {
            _idStatoIscrizione = 1;
            base.OnCreateInstance();
        }


		#endregion Methods 

		#region Nested Classes (1) 


        public partial class PropertyNames
        {

		#region Fields (27) 

            public const string BilancioEsercizioAl = "BilancioEsercizioAl";
            public const string CategoriaSociale = "CategoriaSociale";
            public const string CodiceCooperativa = "CodiceCooperativa";
            public const string CodiceOperatore = "CodiceOperatore";
            public const string CodiceUfficio = "CodiceUfficio";
            public const string DataBFL = "DataBFL";
            public const string DataCostituzione = "DataCostituzione";
            public const string DataDepositoBFL = "DataDepositoBFL";
            public const string Durata = "Durata";
            public const string DurataIllimitata = "DurataIllimitata";
            public const string EsenzioneVersamentoUtili = "EsenzioneVersamentoUtili";
            public const string FormaGiuridicaParix = "FormaGiuridicaParix";
            public const string GruppoParitetico = "GruppoParitetico";
            public const string IdCadenzaRevisione = "IdCadenzaRevisione";
            public const string IdFormaAmm = "IdFormaAmm";
            public const string IdFormaGiu = "IdFormaGiu";
            public const string IdNotaio = "IdNotaio";
            public const string IdRegistro = "IdRegistro";
            public const string IdSoggetto = "IdSoggetto";
            public const string IdStatoIscrizione = "IdStatoIscrizione";
            public const string IdTipoCostituzione = "IdTipoCostituzione";
            public const string ImportoVersamentoPatrimonioResiduo = "ImportoVersamentoPatrimonioResiduo";
            public const string NumeroIscrizioneAlboNaz = "NumeroIscrizioneAlboNaz";
            public const string NumeroREA = "NumeroREA";
            public const string NumeroRepertorioNotarile = "NumeroRepertorioNotarile";
            public const string NumeroRI = "NumeroRI";
            public const string NumeroScioglimento = "NumeroScioglimento";

		#endregion Fields 

        }
		#endregion Nested Classes 


        #region IDXDataErrorInfo Members

        public void GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
        }

        public void GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
            string msg = "Richiesto";

            if (propertyName.EndsWith(PropertyNames.IdStatoIscrizione) && _idStatoIscrizione <= 0)
            {
                info.ErrorText = msg;
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            }
           
            if (propertyName.EndsWith(PropertyNames.IdFormaGiu) && _idFormaGiu <= 0)
            {
                info.ErrorText = msg;
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            }

            if (propertyName.EndsWith(PropertyNames.IdTipoCostituzione) && _idTipoCostituzione <= 0)
            {
                info.ErrorText = msg;
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            }

            if (propertyName.EndsWith(PropertyNames.DataCostituzione) && 
                (!_dataCostituzione.HasValue || _dataCostituzione.Value == DateTime.MinValue))
            {
                info.ErrorText = msg;
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            }

            if (propertyName.EndsWith(PropertyNames.NumeroREA) && String.IsNullOrEmpty(_numeroREA))
            {
                info.ErrorText = msg;
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            }


        }

        #endregion
    }
}
