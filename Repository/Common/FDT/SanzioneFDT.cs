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
    public partial class SanzioneFDT : FDTBase, DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo
    {
        #region Instance Variables
        
        private int _idSanzione;
        private int _idRegistro;
        private int _idNaturaTrasgressione;
        private int _idLeggeTrasgredita;
        private String _noteLeggeTrasgredita;
        private DateTime? _dataInfrazione;
        private DateTime _dataRilievoInfrazione;
        private DateTime? _dataNotificaInfrazione;
        private DateTime? _dataRicevimentoInfrazione;
        private DateTime? _dataScadenzaPagamento;
        private Double _entitaSanzione;
        private String _numeroRecidiva;
        private String _noteSanzione;
        private DateTime? _dataScrittiDifensivi;
        private DateTime? _dataAudizione;
        private DateTime? _dataPagamentoOblazione;
        private String _noteContraddittorio;
        private Double _importoOblazione;
        private Double _importoOrdinanza;
        private String _numeroProtocolloIngiunzione;
        private DateTime? _dataDecretoIngiunzione;
        private DateTime? _dataNotificaOrdinanza;
        private DateTime? _dataRicevimentoOrdinanza;
        private DateTime? _dataScadenzaPagamentoOrdinanza;
        private String _numeroArchiviazione;
        private DateTime? _dataArchiviazione;
        private String _noteOrdinanza;
        private int _idGiudiceCompetente;
        private DateTime? _dataRicorso;
        private DateTime? _dataDepositoRicorso;
        private DateTime? _dataSentenzaRicorso;
        private String _esitoSentenza;
        private DateTime? _dataPagamentoOrdinanza;
        private Double _importoPagamento;
        private DateTime? _dataUltimaModifica;
        private String _operatoreUltimaModifica;

        private DocumentazioneFDT[] _documentazioni;

        #endregion Instance Variables

        #region Public Properties

        [Bindable(true)]
        public String EsitoSentenza
        {
            get { return _esitoSentenza; }
            set { _esitoSentenza = value; }
        }

        [Bindable(true)]
        public DateTime? DataSentenzaRicorso
        {
            get { return _dataSentenzaRicorso; }
            set { _dataSentenzaRicorso = value; }
        }

        [Bindable(true)]
        public DateTime? DataDepositoRicorso
        {
            get { return _dataDepositoRicorso; }
            set { _dataDepositoRicorso = value; }
        }

        [Bindable(true)]
        public DateTime? DataRicorso
        {
            get { return _dataRicorso; }
            set { _dataRicorso = value; }
        }

        [Bindable(true)]
        public int IdGiudiceCompetente
        {
            get { return _idGiudiceCompetente; }
            set { _idGiudiceCompetente = value; }
        }

        [Bindable(true)]
        public string NoteOrdinanza
        {
            get { return _noteOrdinanza; }
            set { _noteOrdinanza = value; }
        }


        [Bindable(true)]
        public DateTime? DataArchiviazione
        {
            get { return _dataArchiviazione; }
            set { _dataArchiviazione = value; }
        }

        [Bindable(true)]
        public String NumeroArchiviazione
        {
            get { return _numeroArchiviazione; }
            set { _numeroArchiviazione = value; }
        }

        [Bindable(true)]
        public DateTime? DataPagamentoOrdinanza
        {
            get { return _dataPagamentoOrdinanza; }
            set { _dataPagamentoOrdinanza = value; }
        }

        [Bindable(true)]
        public DateTime? DataScadenzaPagamentoOrdinanza
        {
            get { return _dataScadenzaPagamentoOrdinanza; }
            set { _dataScadenzaPagamentoOrdinanza = value; }
        }

        [Bindable(true)]
        public DateTime? DataNotificaOrdinanza
        {
            get { return _dataNotificaOrdinanza; }
            set { _dataNotificaOrdinanza = value; }
        }

        [Bindable(true)]
        public DateTime? DataRicevimentoOrdinanza
        {
            get { return _dataRicevimentoOrdinanza; }
            set { _dataRicevimentoOrdinanza = value; }
        }

        [Bindable(true)]
        public DateTime? DataDecretoIngiunzione
        {
            get { return _dataDecretoIngiunzione; }
            set { _dataDecretoIngiunzione = value; }
        }

        [Bindable(true)]
        public String NumeroProtocolloIngiunzione
        {
            get { return _numeroProtocolloIngiunzione; }
            set { _numeroProtocolloIngiunzione = value; }
        }

        [Bindable(true)]
        public Double ImportoPagamento
        {
            get { return _importoPagamento; }
            set { _importoPagamento = value; }
        }

        [Bindable(true)]
        public Double ImportoOrdinanza
        {
            get { return _importoOrdinanza; }
            set { _importoOrdinanza = value; }
        }

        [Bindable(true)]
        public Double ImportoOblazione
        {
            get { return _importoOblazione; }
            set { _importoOblazione = value; }
        }

        [Bindable(true)]
        public String NoteContraddittorio
        {
            get { return _noteContraddittorio; }
            set { _noteContraddittorio = value; }
        }

        [Bindable(true)]
        public DateTime? DataPagamentoOblazione
        {
            get { return _dataPagamentoOblazione; }
            set { _dataPagamentoOblazione = value; }
        }

        [Bindable(true)]
        public DateTime? DataAudizione
        {
            get { return _dataAudizione; }
            set { _dataAudizione = value; }
        }

        [Bindable(true)]
        public DateTime? DataScrittiDifensivi
        {
            get { return _dataScrittiDifensivi; }
            set { _dataScrittiDifensivi = value; }
        }

        [Bindable(true)]
        public String NoteSanzione
        {
            get { return _noteSanzione; }
            set { _noteSanzione = value; }
        }

        [Bindable(true)]
        public String NumeroRecidiva
        {
            get { return _numeroRecidiva; }
            set { _numeroRecidiva = value; }
        }

        [Bindable(true)]
        public Double EntitaSanzione
        {
            get { return _entitaSanzione; }
            set { _entitaSanzione = value; }
        }

        [Bindable(true)]
        public DateTime? DataScadenzaPagamento
        {
            get { return _dataScadenzaPagamento; }
            set { _dataScadenzaPagamento = value; }
        }

        [Bindable(true)]
        public DateTime? DataRicevimentoInfrazione
        {
            get { return _dataRicevimentoInfrazione; }
            set { _dataRicevimentoInfrazione = value; }
        }

        [Bindable(true)]
        public DateTime? DataNotificaInfrazione
        {
            get { return _dataNotificaInfrazione; }
            set { _dataNotificaInfrazione = value; }
        }

        [Bindable(true)]
        public DateTime DataRilievoInfrazione
        {
            get { return _dataRilievoInfrazione; }
            set { _dataRilievoInfrazione = value; }
        }

        [Bindable(true)]
        public DateTime? DataInfrazione
        {
            get { return _dataInfrazione; }
            set { _dataInfrazione = value; }
        }

        [Bindable(true)]
        public String NoteLeggeTrasgredita
        {
            get { return _noteLeggeTrasgredita; }
            set { _noteLeggeTrasgredita = value; }
        }

        [Bindable(true)]
        public int IdLeggeTrasgredita
        {
            get { return _idLeggeTrasgredita; }
            set { _idLeggeTrasgredita = value; }
        }

        [Bindable(true)]
        public int IdNaturaTrasgressione
        {
            get { return _idNaturaTrasgressione; }
            set { _idNaturaTrasgressione = value; }
        }

        [Bindable(true)]
        public int IdSanzione
        {
            get { return _idSanzione; }
            set { _idSanzione = value; }
        }

        [Bindable(true)]
        public int IdRegistro
        {
            get { return _idRegistro; }
            set { _idRegistro = value; }
        }

        [Bindable(true)]
        public DocumentazioneFDT[] Documentazioni
        {
            get { return _documentazioni; }
            set { _documentazioni = value; }
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
            public const string IdNaturaTrasgressione = "IdNaturaTrasgressione";
            public const string DataRilievoInfrazione = "DataRilievoInfrazione";
            public const string DataScritti = "DataScritti";
            public const string DataAudizione = "DataAudizione";
            public const string DataPagamentoOblazione = "DataPagamentoOblazione";
            public const string ImportoOrdinanza = "ImportoOrdinanza";
            public const string DataRicorso = "DataRicorso";
            public const string DataPagamento = "DataPagamento";
        }

        #endregion PropertyNames Class

        #region IDXDataErrorInfo Members

        public void GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {

        }

        public void GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
            if ((propertyName == PropertyNames.IdNaturaTrasgressione && _idNaturaTrasgressione < 1))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }

            //if ((propertyName == PropertyNames.ImportoOrdinanza && _importoOrdinanza < 1))
            //{
            //    info.ErrorText = "Campo obbligatorio";
            //    info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            //}

            if ((propertyName == PropertyNames.DataRilievoInfrazione && (_dataRilievoInfrazione == DateTime.MinValue || _dataRilievoInfrazione == DateTime.MaxValue)))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }

            //if ((propertyName == PropertyNames.DataScritti && (_dataScrittiDifensivi == DateTime.MinValue || _dataScrittiDifensivi == DateTime.MaxValue)))
            //{
            //    info.ErrorText = "Campo obbligatorio";
            //    info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            //}

            //if ((propertyName == PropertyNames.DataAudizione && (_dataAudizione == DateTime.MinValue || _dataAudizione == DateTime.MaxValue)))
            //{
            //    info.ErrorText = "Campo obbligatorio";
            //    info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            //}

            //if ((propertyName == PropertyNames.DataPagamentoOblazione && (_dataPagamentoOblazione == DateTime.MinValue || _dataPagamentoOblazione == DateTime.MaxValue)))
            //{
            //    info.ErrorText = "Campo obbligatorio";
            //    info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            //}

            //if ((propertyName == PropertyNames.DataRicorso && (_dataRicorso == DateTime.MinValue || _dataRicorso == DateTime.MaxValue)))
            //{
            //    info.ErrorText = "Campo obbligatorio";
            //    info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            //}

            //if ((propertyName == PropertyNames.DataPagamento && (_dataPagamentoOrdinanza == DateTime.MinValue || _dataPagamentoOrdinanza == DateTime.MaxValue)))
            //{
            //    info.ErrorText = "Campo obbligatorio";
            //    info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            //}
        }

        #endregion
    }
}
