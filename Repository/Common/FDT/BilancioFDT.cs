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
    public partial class BilancioFDT : FDTBase, DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo
    {
        #region Instance Variables (11)

        private int _idBilancio;
        private int _idRegistro;
        private int _anno;
        private int _idTipoBilancio;
        private DateTime? _dataEsercizio;
        private DateTime? _dataDepositoBilancioRI;
        private DateTime? _dataSegnalazioneRevisoreLegale;
        private int _requisitiPrevalenzaRapportiSoci;               
        private double _importoPercUtili;
        private double _importoPatrimonio;
        private int _pagamento;
        private String _note;
        //private String _evidenze;

        private DateTime? _dataUltimaModifica;
        private String _operatoreUltimaModifica;

        private DocumentazioneFDT[] _documentazioni;

      
	
        #endregion Instance Variables (11)

        #region Public Properties (11)

        [Bindable(true)]
        public DocumentazioneFDT[] Documentazioni
        {
            get { return _documentazioni; }
            set { _documentazioni = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="BilancioFDT"/> is pagamento.
        /// </summary>
        /// <value><c>true</c> if pagamento; otherwise, <c>false</c>.</value>
        [Bindable(true)]
        public int Pagamento
        {
            get { return _pagamento; }
            set { _pagamento = value; }
        }

        /// <summary>
        /// Gets or sets the evidenze.
        /// </summary>
        /// <value>The evidenze.</value>
        //[Bindable(true)]
        //public string Evidenze
        //{
        //    get { return _evidenze; }
        //    set { _evidenze = value; }
        //}

        [Bindable(true)]
        public string Note
        {
            get { return _note; }
            set { _note = value; }
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
        /// Gets or sets the importo patrimonio.
        /// </summary>
        /// <value>The importo patrimonio.</value>
        [Bindable(true)]
        public double ImportoPatrimonio
        {
            get { return _importoPatrimonio; }
            set { _importoPatrimonio = value; }
        }

        /// <summary>
        /// Gets or sets the importo perc utili.
        /// </summary>
        /// <value>The importo perc utili.</value>
        [Bindable(true)]
        public double ImportoPercUtili
        {
            get { return _importoPercUtili; }
            set { _importoPercUtili = value; }
        }

        /// <summary>
        /// Gets or sets the id requisiti prevalenza rapporti soci.
        /// </summary>
        /// <value>The id requisiti prevalenza rapporti soci.</value>
        [Bindable(true)]
        public int RequisitiPrevalenzaRapportiSoci
        {
            get { return _requisitiPrevalenzaRapportiSoci; }
            set { _requisitiPrevalenzaRapportiSoci = value; }
        }

        /// <summary>
        /// Gets or sets the data segnalazione revisore legale.
        /// </summary>
        /// <value>The data segnalazione revisore legale.</value>
        [Bindable(true)]
        public DateTime? DataSegnalazioneRevisoreLegale
        {
            get { return _dataSegnalazioneRevisoreLegale; }
            set { _dataSegnalazioneRevisoreLegale = value; }
        }

        /// <summary>
        /// Gets or sets the data deposito bilancio RI.
        /// </summary>
        /// <value>The data deposito bilancio RI.</value>
        [Bindable(true)]
        public DateTime? DataDepositoBilancioRI
        {
            get { return _dataDepositoBilancioRI; }
            set { _dataDepositoBilancioRI = value; }
        }

        /// <summary>
        /// Gets or sets the id tipo bilancio.
        /// </summary>
        /// <value>The id tipo bilancio.</value>
        [Bindable(true)]
        public int IdTipoBilancio
        {
            get { return _idTipoBilancio; }
            set { _idTipoBilancio = value; }
        }

        /// <summary>
        /// Gets or sets the data esercizio.
        /// </summary>
        /// <value>The data esercizio.</value>
        [Bindable(true)]
        public DateTime? DataEsercizio
        {
            get { return _dataEsercizio; }
            set { _dataEsercizio = value; }
        }

        /// <summary>
        /// Gets or sets the anno.
        /// </summary>
        /// <value>The anno.</value>
        [Bindable(true)]
        public int Anno
        {
            get { return _anno; }
            set { _anno = value; }
        }

        /// <summary>
        /// Gets or sets the id bilancio.
        /// </summary>
        /// <value>The id bilancio.</value>
        [Bindable(true)]
        public int IdBilancio
        {
            get { return _idBilancio; }
            set { _idBilancio = value; }
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
            public const string IdTipoBilancio = "IdTipoBilancio";
            public const string Anno = "Anno";
        }

        #endregion PropertyNames Class

        #region IDXDataErrorInfo Members

        public void GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {

        }

        public void GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
            if ((propertyName == PropertyNames.IdTipoBilancio && _idTipoBilancio < 1))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }

            if ((propertyName == PropertyNames.Anno && _anno < 1))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }
        }

        #endregion

    }
}
