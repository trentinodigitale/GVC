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
    public partial class CancellazioneFDT : FDTBase, DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo
    {


        #region Instance Variables (29)

        private int _idCancellazione;
        private int _idRegistroCooperativa;
        private int _idTipoCancellazione;

        private DateTime? _dataRicevimentoDomanda;
        private String _numeroDetermina;
        private DateTime? _dataDetermina;
        private String _numeroDeliberaCommissione;
        private DateTime? _dataDeliberaCommissione;

        private string _note;
        private DateTime? _dataCancRegistro;
        private DateTime? _dataCancAlbo;

        private DateTime? _dataUltimaModifica;
        private string _operatoreUltimaModifica;

        #endregion Instance Variables


        #region Public Properties (29)

        /// <summary>
        /// Gets or sets the id registro cooperativa.
        /// </summary>
        /// <value>The id registro cooperativa.</value>
        public int IdRegistroCooperativa
        {
            get { return _idRegistroCooperativa; }
            set { _idRegistroCooperativa = value; }
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
        /// Gets or sets the id cancellazione.
        /// </summary>
        /// <value>The id cancellazione.</value>
        public int IdCancellazione
        {
            get { return _idCancellazione; }
            set { _idCancellazione = value; }
        }

        /// <summary>
        /// Gets or sets the id cancellazione.
        /// </summary>
        /// <value>The id cancellazione.</value>
        [Bindable(true)]
        public int IdTipoCancellazione
        {
            get { return _idTipoCancellazione; }
            set { _idTipoCancellazione = value; }
        }

        /// <summary>
        /// Gets or sets the data canc albo.
        /// </summary>
        /// <value>The data canc albo.</value>
        [Bindable(true)]
        public DateTime? DataCancAlbo
        {
            get { return _dataCancAlbo; }
            set { _dataCancAlbo = value; }
        }

        /// <summary>
        /// Gets or sets the data canc registro.
        /// </summary>
        /// <value>The data canc registro.</value>
        [Bindable(true)]
        public DateTime? DataCancRegistro
        {
            get { return _dataCancRegistro; }
            set { _dataCancRegistro = value; }
        }

        /// <summary>
        /// Gets or sets the data delibera commissione.
        /// </summary>
        /// <value>The data delibera commissione.</value>
        [Bindable(true)]
        public DateTime? DataDeliberaCommissione
        {
            get { return _dataDeliberaCommissione; }
            set { _dataDeliberaCommissione = value; }
        }

        /// <summary>
        /// Gets or sets the numero delibera commissione.
        /// </summary>
        /// <value>The numero delibera commissione.</value>
        [Bindable(true)]
        public String NumeroDeliberaCommissione
        {
            get { return _numeroDeliberaCommissione; }
            set { _numeroDeliberaCommissione = value; }
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
            public const string DataRicevimentoDomanda = "DataRicevimentoDomanda";
        }

        #endregion PropertyNames Class


        #region IDXDataErrorInfo Members

        public void GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {

        }

        public void GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
            //if ((propertyName == PropertyNames.DataRicevimentoDomanda && (_dataRicevimentoDomanda == DateTime.MinValue || _dataRicevimentoDomanda == DateTime.MaxValue)))
            //{
            //    info.ErrorText = "Campo obbligatorio";
            //    info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            //}
        }

        #endregion

        public Boolean ContainsData
        {
            get
            {
                Boolean toReturn = false;

                if (_idCancellazione > 0)
                {
                    toReturn = true;
                }
                if (_dataRicevimentoDomanda.HasValue && _dataRicevimentoDomanda.Value > DateTime.MinValue)
                {
                    toReturn = true;
                }
                if (!String.IsNullOrEmpty(_numeroDetermina))
                {
                    toReturn = true;
                }
                if (_dataDetermina.HasValue && _dataDetermina.Value > DateTime.MinValue)
                {
                    toReturn = true;
                }
                if (!String.IsNullOrEmpty(_numeroDeliberaCommissione))
                {
                    toReturn = true;
                }
                if (_dataDeliberaCommissione.HasValue && _dataDeliberaCommissione.Value > DateTime.MinValue)
                {
                    toReturn = true;
                }

                if (!String.IsNullOrEmpty(_note))
                {
                    toReturn = true;
                }
                if (_idTipoCancellazione > 111)
                {
                    toReturn = true;
                }

                return toReturn;
            }
        }
    }
}
