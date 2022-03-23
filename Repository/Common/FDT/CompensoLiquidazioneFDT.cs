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
    public partial class CompensoLiquidazioneFDT : FDTBase, DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo
    {
        #region Instance Variables (19)

        private int _idCompensoLiquidazione;
        private int _idRevisione;
        private int _idProcedura;
        private int _idLiquidazione;
        private DateTime? _dataRicevimentoDomanda;
        //private double _durataProcessoUfficio;
        //private DateTime? _dataLiquidazioneUfficio;
        //private DateTime? _dataFineTeorica;
        //private Boolean _processoChiuso;
        private double _percentualeContributoPAT;
        private int _valuta;
        private double _importoDeterminato;
        private double _importoErogato;
        private double _importoRichiesto;
        //private double _importoContributoPAT;
        private double _importoSpeseBFL;        
        private int _tipoContributo;
        private String _numeroDetermina;
        private DateTime? _dataDetermina;
        private Boolean _liquidato;
        private String _numeroMandatoPagamento;
        private DateTime? _dataMandatoPagamento;
        private String _note;
        private DateTime? _dataUltimaModifica;
        private String _operatoreUltimaModifica;

        #endregion Instance Variables (19)

        #region Public Properties (19)

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
        /// Gets or sets the data mandato pagamento.
        /// </summary>
        /// <value>The data mandato pagamento.</value>
        [Bindable(true)]
        public DateTime? DataMandatoPagamento
        {
            get { return _dataMandatoPagamento; }
            set { _dataMandatoPagamento = value; }
        }

        /// <summary>
        /// Gets or sets the numero mandato pagamento.
        /// </summary>
        /// <value>The numero mandato pagamento.</value>
        [Bindable(true)]
        public string NumeroMandatoPagamento
        {
            get { return _numeroMandatoPagamento; }
            set { _numeroMandatoPagamento = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CompensoLiquidazioneFDT"/> is liquidato.
        /// </summary>
        /// <value><c>true</c> if liquidato; otherwise, <c>false</c>.</value>
        [Bindable(true)]
        public Boolean Liquidato
        {
            get { return _liquidato; }
            set { _liquidato = value; }
        }

        /// <summary>
        /// Gets or sets the data determina.
        /// </summary>
        /// <value>The data determina.</value>
        [Bindable(true)]
        public DateTime? DataDetermina
        {
            get { return _dataDetermina; }
            set { _dataDetermina = value; }
        }

        /// <summary>
        /// Gets or sets the numero determina.
        /// </summary>
        /// <value>The numero determina.</value>
        [Bindable(true)]
        public string NumeroDetermina
        {
            get { return _numeroDetermina; }
            set { _numeroDetermina = value; }
        }

        /// <summary>
        /// Gets or sets the tipo contributo.
        /// </summary>
        /// <value>The tipo contributo.</value>
        [Bindable(true)]
        public int TipoContributo
        {
            get { return _tipoContributo; }
            set { _tipoContributo = value; }
        }

        /// <summary>
        /// Gets or sets the importo spese BFL.
        /// </summary>
        /// <value>The importo spese BFL.</value>
        [Bindable(true)]
        public double ImportoSpeseBFL
        {
            get { return _importoSpeseBFL; }
            set { _importoSpeseBFL = value; }
        }

        /// <summary>
        /// Gets or sets the importo contributo PAT.
        /// </summary>
        /// <value>The importo contributo PAT.</value>
        //[Bindable(true)]
        //public double ImportoContributoPAT
        //{
        //    get { return _importoContributoPAT; }
        //    set { _importoContributoPAT = value; }
        //}

        /// <summary>
        /// Gets or sets the importo richiesto.
        /// </summary>
        /// <value>The importo richiesto.</value>
        [Bindable(true)]
        public double ImportoRichiesto
        {
            get { return _importoRichiesto; }
            set { _importoRichiesto = value; }
        }

        /// <summary>
        /// Gets or sets the importo erogato.
        /// </summary>
        /// <value>The importo erogato.</value>
        [Bindable(true)]
        public double ImportoErogato
        {
            get { return _importoErogato; }
            set { _importoErogato = value; }
        }

        /// <summary>
        /// Gets or sets the importo determinato.
        /// </summary>
        /// <value>The importo determinato.</value>
        [Bindable(true)]
        public double ImportoDeterminato
        {
            get { return _importoDeterminato; }
            set { _importoDeterminato = value; }
        }

        /// <summary>
        /// Gets or sets the valuta.
        /// </summary>
        /// <value>The valuta.</value>
        [Bindable(true)]
        public int Valuta
        {
            get { return _valuta; }
            set { _valuta = value; }
        }

        /// <summary>
        /// Gets or sets the percentuale contributo PAT.
        /// </summary>
        /// <value>The percentuale contributo PAT.</value>
        [Bindable(true)]
        public double PercentualeContributoPAT
        {
            get { return _percentualeContributoPAT; }
            set { _percentualeContributoPAT = value; }
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
        /// Gets or sets the data fine teorica.
        /// </summary>
        /// <value>The data fine teorica.</value>
        //[Bindable(true)]
        //public DateTime? DataFineTeorica
        //{
        //    get { return _dataFineTeorica; }
        //    set { _dataFineTeorica = value; }
        //}

        /// <summary>
        /// Gets or sets the durata processo ufficio.
        /// </summary>
        /// <value>The durata processo ufficio.</value>
        //[Bindable(true)]
        //public double DurataProcessoUfficio
        //{
        //    get { return _durataProcessoUfficio; }
        //    set { _durataProcessoUfficio = value; }
        //}

        /// <summary>
        /// Gets or sets the data liquidazione ufficio.
        /// </summary>
        /// <value>The data liquidazione ufficio.</value>
        //[Bindable(true)]
        //public DateTime? DataLiquidazioneUfficio
        //{
        //    get { return _dataLiquidazioneUfficio; }
        //    set { _dataLiquidazioneUfficio = value; }
        //}

        /// <summary>
        /// Gets or sets the data ricevimento domanda.
        /// </summary>
        /// <value>The data ricevimento domanda.</value>
        [Bindable(true)]
        public DateTime? DataRicevimentoDomanda
        {
            get { return _dataRicevimentoDomanda; }
            set { _dataRicevimentoDomanda = value; }
        }

        /// <summary>
        /// Gets or sets the id compenso liquidazione.
        /// </summary>
        /// <value>The id compenso liquidazione.</value>
        [Bindable(true)]
        public int IdCompensoLiquidazione
        {
            get { return _idCompensoLiquidazione; }
            set { _idCompensoLiquidazione = value; }
        }

        /// <summary>
        /// Gets or sets the id liquidazione.
        /// </summary>
        /// <value>The id liquidazione.</value>
        [Bindable(true)]
        public int IdLiquidazione
        {
            get { return _idLiquidazione; }
            set { _idLiquidazione = value; }
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
        /// Gets or sets the id procedura.
        /// </summary>
        /// <value>The id procedura.</value>
        [Bindable(true)]
        public int IdProcedura
        {
            get { return _idProcedura; }
            set { _idProcedura = value; }
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
            public const string ImportoErogato = "ImportoErogato";
        }

        #endregion PropertyNames Class

        #region IDXDataErrorInfo Members

        public void GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {

        }

        public void GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
            //if ((propertyName == PropertyNames.ImportoErogato && _importoErogato < 1))
            //{
            //    info.ErrorText = "Campo obbligatorio";
            //    info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            //}
        }

        #endregion
    }
}
