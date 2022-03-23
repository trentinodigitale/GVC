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
    public partial class ProcedimentoFDT : FDTBase, DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo
    {
        #region Instance Variables

        private int _idProcedimento;
        private int _idRegistro;
        private int _idTipoProcedimento;
        private int _idTipoIniziativa;

        private DateTime? _dataInizioProcedimento;
        private DateTime? _avvisoInizioProcedimento;
        private int _tempi;
        private DateTime? _dataFineTeorica;
        
        private String _motivoSospensione;
        private int _giorniSospensione;
        private DateTime? _dataRiattivazione;
        private DateTime? _dataTermineFinale;
        private DateTime? _dataConclusione;
        private String _note;
        private String _responsabile;
        private String _noteTipologia;

        private int _idTipoSospensione;
        private int _idTipoConclusione;

        private DateTime? _dataUltimaModifica;
        private String _operatoreUltimaModifica;

        #endregion Instance Variables

        #region Public Properties

        /// <summary>
        /// Gets the stato procedimento.
        /// </summary>
        /// <value>The stato procedimento.</value>
        [Bindable(true)]
        public int StatoProcedimento
        {
            get 
            {
                int _statoProcedimento = TipiStatoProcedimento.Aperto;

                // calcolo
                if (_dataConclusione != null &
                    _dataConclusione != DateTime.MinValue &
                    _dataConclusione != DateTime.MaxValue)
                {
                    _statoProcedimento = TipiStatoProcedimento.Chiuso;
                }
                else if (_dataRiattivazione != null &
                    _dataRiattivazione != DateTime.MinValue &
                    _dataRiattivazione != DateTime.MaxValue)
                {
                    _statoProcedimento = TipiStatoProcedimento.Ripreso;
                }
                else if (_idTipoSospensione > 0)
                {
                    _statoProcedimento = TipiStatoProcedimento.Sospeso;
                }

                return _statoProcedimento; 
            }
        }

        /// <summary>
        /// Gets or sets the id procedimento.
        /// </summary>
        /// <value>The id procedimento.</value>
        [Bindable(true)]
        public int IdProcedimento
        {
            get { return _idProcedimento; }
            set { _idProcedimento = value; }
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
        /// Gets or sets the tipo procedimento.
        /// </summary>
        /// <value>The tipo procedimento.</value>
        [Bindable(true)]
        public int IdTipoProcedimento
        {
            get { return _idTipoProcedimento; }
            set { _idTipoProcedimento = value; }
        }

        /// <summary>
        /// Gets or sets the tipo iniziativa.
        /// </summary>
        /// <value>The tipo iniziativa.</value>
        [Bindable(true)]
        public int IdTipoIniziativa
        {
            get { return _idTipoIniziativa; }
            set { _idTipoIniziativa = value; }
        }

        /// <summary>
        /// Gets or sets the data inizio procedimento.
        /// </summary>
        /// <value>The data inizio procedimento.</value>
        [Bindable(true)]
        public DateTime? DataInizioProcedimento
        {
            get { return _dataInizioProcedimento; }
            set { _dataInizioProcedimento = value; }
        }

        /// <summary>
        /// Gets or sets the avviso inizio procedimento.
        /// </summary>
        /// <value>The avviso inizio procedimento.</value>
        [Bindable(true)]
        public DateTime? AvvisoInizioProcedimento
        {
            get { return _avvisoInizioProcedimento; }
            set { _avvisoInizioProcedimento = value; }
        }

        /// <summary>
        /// Gets or sets the tempi.
        /// </summary>
        /// <value>The tempi.</value>
        [Bindable(true)]
        public int Tempi
        {
            get { return _tempi; }
            set { _tempi = value; }
        }

        /// <summary>
        /// Gets or sets the data fine teorica.
        /// </summary>
        /// <value>The data fine teorica.</value>
        [Bindable(true)]
        public DateTime? DataFineTeorica
        {
            get { return _dataFineTeorica; }
            set { _dataFineTeorica = value; }
        }

        /// <summary>
        /// Gets or sets the tipo sospensione.
        /// </summary>
        /// <value>The tipo sospensione.</value>
        [Bindable(true)]
        public int IdTipoSospensione
        {
            get { return _idTipoSospensione; }
            set { _idTipoSospensione = value; }
        }

        /// <summary>
        /// Gets or sets the motivo sospensione.
        /// </summary>
        /// <value>The motivo sospensione.</value>
        [Bindable(true)]
        public String MotivoSospensione
        {
            get { return _motivoSospensione; }
            set { _motivoSospensione = value; }
        }

        /// <summary>
        /// Gets or sets the note tipologia.
        /// </summary>
        /// <value>The note tipologia.</value>
        [Bindable(true)]
        public String NoteTipologia
        {
            get { return _noteTipologia; }
            set { _noteTipologia = value; }
        }

        /// <summary>
        /// Gets or sets the responsabile.
        /// </summary>
        /// <value>The responsabile.</value>
        [Bindable(true)]
        public String Responsabile
        {
            get { return _responsabile; }
            set { _responsabile = value; }
        }

        /// <summary>
        /// Gets or sets the giorni sospensione.
        /// </summary>
        /// <value>The giorni sospensione.</value>
        [Bindable(true)]
        public int GiorniSospensione
        {
            get { return _giorniSospensione; }
            set { _giorniSospensione = value; }
        }

        /// <summary>
        /// Gets or sets the data riattivazione.
        /// </summary>
        /// <value>The data riattivazione.</value>
        [Bindable(true)]
        public DateTime? DataRiattivazione
        {
            get { return _dataRiattivazione; }
            set { _dataRiattivazione = value; }
        }

        /// <summary>
        /// Gets or sets the data termine finale.
        /// </summary>
        /// <value>The data termine finale.</value>
        [Bindable(true)]
        public DateTime? DataTermineFinale
        {
            get { return _dataTermineFinale; }
            set { _dataTermineFinale = value; }
        }

        /// <summary>
        /// Gets or sets the tipo conclusione.
        /// </summary>
        /// <value>The tipo conclusione.</value>
        [Bindable(true)]
        public int IdTipoConclusione
        {
            get { return _idTipoConclusione; }
            set { _idTipoConclusione = value; }
        }

        /// <summary>
        /// Gets or sets the data conclusione.
        /// </summary>
        /// <value>The data conclusione.</value>
        [Bindable(true)]
        public DateTime? DataConclusione
        {
            get { return _dataConclusione; }
            set { _dataConclusione = value; }
        }

        /// <summary>
        /// Gets or sets the note.
        /// </summary>
        /// <value>The note.</value>
        [Bindable(true)]
        public String Note
        {
            get { return _note; }
            set { _note = value; }
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

        #region PropertyNames Class

        /// <summary>
        /// PropertyNames
        /// </summary>
        public partial class PropertyNames
        {
            public const string IdTipoProcedimento = "IdTipoProcedimento";
            public const string DataInizio = "DataInizioProcedimento";
        }

        #endregion PropertyNames Class

        #region IDXDataErrorInfo Members

        public void GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {

        }

        public void GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
            if ((propertyName == PropertyNames.IdTipoProcedimento && _idTipoProcedimento < 1))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }

            if (propertyName == PropertyNames.DataInizio && 
                (!_dataInizioProcedimento.HasValue || _dataInizioProcedimento.Value == DateTime.MinValue))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }

        }

        #endregion
    }
}

