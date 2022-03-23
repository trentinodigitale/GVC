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
    public partial class RevisioneIncaricoFDT : FDTBase, DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo
    {
        #region Instance Variables (20)

        private int _idRevisioneIncarico;
        private int _idRevisione;
        private DateTime? _dataDeliberaCommissioneIncarico;
        private String _numeroDeliberaCommissioneIncarico;
        private String _numeroDeterminaIncarico;
        private DateTime? _dataDeterminaIncarico;
        private DateTime? _dataScadenzaTeorica;
        private Double _importoImpegno;
        private String _numeroDeliberaCommRicusazione;
        private DateTime? _dataDeliberaCommRicusazione;
        private DateTime? _dataDeterminaRicusazione;
        private String _numeroDeterminaRicusazione;
        private DateTime? _dataUltimaModifica;
        private String _operatoreUltimaModifica;

        private CompensoFDT _compensoRevisore;

        //private DateTime? _dataScadenzaEffettiva;
        //private DateTime? _dataFine;
        //private DateTime? _filingDate;
        //private int _progressDuration;
        //private String _numeroDeliberaCommissioneEsame;
        //private DateTime? _dataDeliberaCommissioneEsame;
        //private String _numeroDeterminaEsame;
        //private DateTime? _dataDeterminaEsame;
        //private DateTime? _dataEsito;
        //private int _idEsito;

        //private List<CompensoFDT> _counterBalances;

        #endregion Instance Variables

        #region Public Properties (20)

        //[Bindable(true)]
        //public List<CompensoFDT> CounterBalances
        //{
        //    get { return _counterBalances; }
        //    set { _counterBalances = value; }
        //}

        /// <summary>
        /// Gets or sets the annulment determina number (numero determina revoca)
        /// </summary>
        /// <value>The annulment determina number.</value>
        [Bindable(true)]
        public string NumeroDeterminaRicusazione
        {
            get { return _numeroDeterminaRicusazione; }
            set { _numeroDeterminaRicusazione = value; }
        }

        /// <summary>
        /// Gets or sets the annulment determina date. (data determina revoca)
        /// </summary>
        /// <value>The annulment determina date.</value>
        [Bindable(true)]
        public DateTime? DataDeterminaRicusazione
        {
            get { return _dataDeterminaRicusazione; }
            set { _dataDeterminaRicusazione = value; }
        }

        /// <summary>
        /// Gets or sets the annulment commission deliberation date. (data delibera revoca commissione)
        /// </summary>
        /// <value>The annulment commission deliberation date.</value>
        [Bindable(true)]
        public DateTime? DataDeliberaCommRicusazione
        {
            get { return _dataDeliberaCommRicusazione; }
            set { _dataDeliberaCommRicusazione = value; }
        }

        /// <summary>
        /// Gets or sets the annulment commission deliberation number. (numero delibera revoca commissione)
        /// </summary>
        /// <value>The annulment commission deliberation number.</value>
        [Bindable(true)]
        public string NumeroDeliberaCommRicusazione
        {
            get { return _numeroDeliberaCommRicusazione; }
            set { _numeroDeliberaCommRicusazione = value; }
        }

        /// <summary>
        /// Gets or sets the outcome Descrizione. (esito conclusioni)
        /// </summary>
        /// <value>The outcome Descrizione.</value>
        //[Bindable(true)]
        //public int IdEsito
        //{
        //    get { return _idEsito; }
        //    set { _idEsito = value; }
        //}

        [Bindable(true)]
        public Double ImportoImpegno
        {
            get { return _importoImpegno; }
            set { _importoImpegno = value; }
        }

        /// <summary>
        /// Gets or sets the id revisione.
        /// </summary>
        /// <value>The id revisione.</value>
        [Bindable(true)]
        public int IdRevisione
        {
            get { return _idRevisione; }
            set { _idRevisione = value; }
        }

        /// <summary>
        /// Gets or sets the outcome date. (Data nota comunicazione esiti)
        /// </summary>
        /// <value>The outcome date.</value>
        //[Bindable(true)]
        //public DateTime? DataEsito
        //{
        //    get { return _dataEsito; }
        //    set { _dataEsito = value; }
        //}

        /// <summary>
        /// Gets or sets the exam determina date. (data determina esame)
        /// </summary>
        /// <value>The exam determina date.</value>
        //[Bindable(true)]
        //public DateTime? DataDeterminaEsame
        //{
        //    get { return _dataDeterminaEsame; }
        //    set { _dataDeterminaEsame = value; }
        //}

        /// <summary>
        /// Gets or sets the exam determina number. (numero determina esame)
        /// </summary>
        /// <value>The exam determina number.</value>
        //[Bindable(true)]
        //public string NumeroDeterminaEsame
        //{
        //    get { return _numeroDeterminaEsame; }
        //    set { _numeroDeterminaEsame = value; }
        //}

        /// <summary>
        /// Gets or sets the exam commission deliberation date. (data delibera esame commissione)
        /// </summary>
        /// <value>The exam commission deliberation date.</value>
        //[Bindable(true)]
        //public DateTime? DataDeliberaCommissioneEsame
        //{
        //    get { return _dataDeliberaCommissioneEsame; }
        //    set { _dataDeliberaCommissioneEsame = value; }
        //}

        /// <summary>
        /// Gets or sets the exam commission deliberation number. (numero delibera esame commissione)
        /// </summary>
        /// <value>The exam commission deliberation number.</value>
        //[Bindable(true)]
        //public string NumeroDeliberaCommissioneEsame
        //{
        //    get { return _numeroDeliberaCommissioneEsame; }
        //    set { _numeroDeliberaCommissioneEsame = value; }
        //}

        /// <summary>
        /// Gets or sets the progress duration. (tempi procedimento ufficio)
        /// </summary>
        /// <value>The progress duration.</value>
        //[Bindable(true)]
        //public int ProgressDuration
        //{
        //    get { return _progressDuration; }
        //    set { _progressDuration = value; }
        //}

        /// <summary>
        /// Gets or sets the filing date. (data deposito revisione ufficio)
        /// </summary>
        /// <value>The filing date.</value>
        //[Bindable(true)]
        //public DateTime? FilingDate
        //{
        //    get { return _filingDate; }
        //    set { _filingDate = value; }
        //}

        /// <summary>
        /// Gets or sets the end date. (data conclusione revisione)
        /// </summary>
        /// <value>The end date.</value>
        //[Bindable(true)]
        //public DateTime? DataFine
        //{
        //    get { return _dataFine; }
        //    set { _dataFine = value; }
        //}

        /// <summary>
        /// Gets or sets the job determina date (data determina incarico)
        /// </summary>
        /// <value>The job determina date.</value>
        [Bindable(true)]
        public DateTime? DataDeterminaIncarico
        {
            get { return _dataDeterminaIncarico; }
            set { _dataDeterminaIncarico = value; }
        }

        /// <summary>
        /// Gets or sets the job determina number (numero determina incarico).
        /// </summary>
        /// <value>The job determina number.</value>
        [Bindable(true)]
        public string NumeroDeterminaIncarico
        {
            get { return _numeroDeterminaIncarico; }
            set { _numeroDeterminaIncarico = value; }
        }

        /// <summary>
        /// Gets or sets the job commission deliberation number (numero delibera commissione incarico).
        /// </summary>
        /// <value>The job commission deliberation number.</value>
        [Bindable(true)]
        public string NumeroDeliberaCommissioneIncarico
        {
            get { return _numeroDeliberaCommissioneIncarico; }
            set { _numeroDeliberaCommissioneIncarico = value; }
        }

        /// <summary>
        /// Gets or sets the job commission deliberation date (data delibera commissione incarico).
        /// </summary>
        /// <value>The job commission deliberation date.</value>
        [Bindable(true)]
        public DateTime? DataDeliberaCommissioneIncarico
        {
            get { return _dataDeliberaCommissioneIncarico; }
            set { _dataDeliberaCommissioneIncarico = value; }
        }

        /// <summary>
        /// Gets or sets the effectively expiration date (data scadenza effettiva revisione)
        /// </summary>
        /// <value>The effectively expiration date.</value>
        //[Bindable(true)]
        //public DateTime? DataScadenzaEffettiva
        //{
        //    get { return _dataScadenzaEffettiva; }
        //    set { _dataScadenzaEffettiva = value; }
        //}

        /// <summary>
        /// Gets or sets the theoretical expiration date (data scadenza teorica revisione).
        /// </summary>
        /// <value>The theoretical expiration date.</value>
        [Bindable(true)]
        public DateTime? DataScadenzaTeorica
        {
            get { return _dataScadenzaTeorica; }
            set { _dataScadenzaTeorica = value; }
        }

        /// <summary>
        /// Gets or sets the record id.
        /// </summary>
        /// <value>The record id.</value>
        [Bindable(true)]
        public int IdRevisioneIncarico
        {
            get { return _idRevisioneIncarico; }
            set { _idRevisioneIncarico = value; }
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

        /// <summary>
        /// Gets or sets the compenso revisore.
        /// </summary>
        /// <value>The compenso revisore.</value>
        [Bindable(true)]
        public CompensoFDT CompensoRevisore
        {
            get { return _compensoRevisore; }
            set { _compensoRevisore = value; }
        }

        #endregion Public Properties

        #region PropertyNames Class

        /// <summary>
        /// PropertyNames
        /// </summary>
        public partial class PropertyNames
        {
            public const string DataScadenzaTeorica = "DataScadenzaTeorica";
            public const string ImportoImpegno = "ImportoImpegno";
            public const string Revisore = "CompensoRevisore_Revisore_DescrizioneBreve";
        }

        #endregion PropertyNames Class

        #region IDXDataErrorInfo Members

        public void GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
           
        }

        public void GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
            if ((propertyName == PropertyNames.DataScadenzaTeorica && (_dataScadenzaTeorica == DateTime.MinValue || _dataScadenzaTeorica == DateTime.MaxValue)))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }

            if ((propertyName == PropertyNames.Revisore && (_compensoRevisore.Revisore == null || _compensoRevisore.IdRevisore <= 0)))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }

            //if ((propertyName == PropertyNames.ImportoImpegno && _importoImpegno < 1))
            //{
            //    info.ErrorText = "Campo obbligatorio";
            //    info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            //}

        }

        #endregion
    }
}
