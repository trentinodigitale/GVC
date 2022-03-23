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
    public partial class CambioPosizioneFDT : FDTBase, DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo
    {
        #region Instance Variables (29)

        private int _idCambioPosizione;
        private DateTime? _dataRicevimentoDomanda;
        private int _idRegistro;
        private String _numeroDetermina;
        private DateTime? _dataDetermina;
        private String _numeroDeliberaCommissione;
        private DateTime? _dataDeliberaCommissione;
        private int _sottoSezione;
        private int _sezione;
        private int _idCategoria;
        private int _categoriaSociale;
        private int _idSottoCategoria;
        private String _note;
        private DateTime? _dataUltimaModifica;
        private string _operatoreUltimaModifica;
        private String _numeroPosizione;
        //private DateTime? _dataProcessoUfficio;
        //private double _durataProcessoUfficio;
        //private Boolean _processoConcluso;
        //private Boolean _cambioSezione;
        //private int _vecchiaSezione;
        //private int _idTipoCambioSezione;
        //private String _motivoCambioSezione;
        //private Boolean _cambioCategoria; 
        //private int _vecchiaCategoria;
        //private int _idTipoCambioCategoria;
        //private String _motivoCambioCategoria;
        //private Boolean _cambioCategoriaSociale;
        //private int _vecchiaCategoriaSociale;
        //private int _idTipoCambioCategoriaSociale;
        //private String _motivoCambioCategoriaSociale;
        //private Boolean _cambioSottoCategoria;
        //private int _vecchiaSottoCategoria;
        //private int _idTipoCambioSottoCategoria;
        //private String _motivoCambioSottoCategoria;

        #endregion Instance Variables

        #region Public Properties (29)

        ///// <summary>
        ///// Gets or sets the motivo cambio sotto categoria.
        ///// </summary>
        ///// <value>The motivo cambio sotto categoria.</value>
        //[Bindable(true)]
        //public String MotivoCambioSottoCategoria
        //{
        //    get { return _motivoCambioSottoCategoria; }
        //    set { _motivoCambioSottoCategoria = value; }
        //}


        /// <summary>
        /// Gets or sets the numero posizione.
        /// </summary>
        /// <value>The numero posizione.</value>
        [Bindable(true)]
        public String NumeroPosizione
        {
            get { return _numeroPosizione; }
            set { _numeroPosizione = value; }
        }

        /// <summary>
        /// Gets or sets the sotto sezione.
        /// </summary>
        /// <value>The sotto sezione.</value>
        [Bindable(true)]
        public int SottoSezione
        {
            get { return _sottoSezione; }
            set { _sottoSezione = value; }
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
        /// Gets or sets the nuova sotto categoria.
        /// </summary>
        /// <value>The nuova sotto categoria.</value>
        [Bindable(true)]
        public int IdSottoCategoria
        {
            get { return _idSottoCategoria; }
            set { _idSottoCategoria = value; }
        }

        /// <summary>
        /// Gets or sets the vecchia sotto categoria.
        /// </summary>
        /// <value>The vecchia sotto categoria.</value>
        //[Bindable(true)]
        //public int VecchiaSottoCategoria
        //{
        //    get { return _vecchiaSottoCategoria; }
        //    set { _vecchiaSottoCategoria = value; }
        //}

        ///// <summary>
        ///// Gets or sets a value indicating whether [cambio sotto categoria].
        ///// </summary>
        ///// <value>
        ///// 	<c>true</c> if [cambio sotto categoria]; otherwise, <c>false</c>.
        ///// </value>
        //[Bindable(true)]
        //public Boolean CambioSottoCategoria
        //{
        //    get { return _cambioSottoCategoria; }
        //    set { _cambioSottoCategoria = value; }
        //}

        /// <summary>
        /// Gets or sets the motivo cambio categoria sociale.
        /// </summary>
        /// <value>The motivo cambio categoria sociale.</value>
        //[Bindable(true)]
        //public String MotivoCambioCategoriaSociale
        //{
        //    get { return _motivoCambioCategoriaSociale; }
        //    set { _motivoCambioCategoriaSociale = value; }
        //}

        /// <summary>
        /// Gets or sets the id tipo cambio categoria sociale.
        /// </summary>
        /// <value>The id tipo cambio categoria sociale.</value>
        //[Bindable(true)]
        //public int IdTipoCambioCategoriaSociale
        //{
        //    get { return _idTipoCambioCategoriaSociale; }
        //    set { _idTipoCambioCategoriaSociale = value; }
        //}

        /// <summary>
        /// Gets or sets the nuova categoria sociale.
        /// </summary>
        /// <value>The nuova categoria sociale.</value>
        [Bindable(true)]
        public int CategoriaSociale
        {
            get { return _categoriaSociale; }
            set { _categoriaSociale = value; }
        }

        /// <summary>
        /// Gets or sets the vecchia categoria sociale.
        /// </summary>
        /// <value>The vecchia categoria sociale.</value>
        //[Bindable(true)]
        //public int VecchiaCategoriaSociale
        //{
        //    get { return _vecchiaCategoriaSociale; }
        //    set { _vecchiaCategoriaSociale = value; }
        //}

        ///// <summary>
        ///// Gets or sets a value indicating whether [cambio categoria sociale].
        ///// </summary>
        ///// <value>
        ///// 	<c>true</c> if [cambio categoria sociale]; otherwise, <c>false</c>.
        ///// </value>
        //[Bindable(true)]
        //public Boolean CambioCategoriaSociale
        //{
        //    get { return _cambioCategoriaSociale; }
        //    set { _cambioCategoriaSociale = value; }
        //}

        /// <summary>
        /// Gets or sets the motivo cambio categoria.
        /// </summary>
        /// <value>The motivo cambio categoria.</value>
        //[Bindable(true)]
        //public String MotivoCambioCategoria
        //{
        //    get { return _motivoCambioCategoria; }
        //    set { _motivoCambioCategoria = value; }
        //}

        /// <summary>
        /// Gets or sets the id tipo cambio categoria.
        /// </summary>
        /// <value>The id tipo cambio categoria.</value>
        //[Bindable(true)]
        //public int IdTipoCambioCategoria
        //{
        //    get { return _idTipoCambioCategoria; }
        //    set { _idTipoCambioCategoria = value; }
        //}

        /// <summary>
        /// Gets or sets the nuova categoria.
        /// </summary>
        /// <value>The nuova categoria.</value>
        [Bindable(true)]
        public int IdCategoria
        {
            get { return _idCategoria; }
            set { _idCategoria = value; }
        }

        /// <summary>
        /// Gets or sets the vecchia categoria.
        /// </summary>
        /// <value>The vecchia categoria.</value>
        //[Bindable(true)]
        //public int VecchiaCategoria
        //{
        //    get { return _vecchiaCategoria; }
        //    set { _vecchiaCategoria = value; }
        //}

        ///// <summary>
        ///// Gets or sets a value indicating whether [cambio categoria].
        ///// </summary>
        ///// <value><c>true</c> if [cambio categoria]; otherwise, <c>false</c>.</value>
        //[Bindable(true)]
        //public Boolean CambioCategoria
        //{
        //    get { return _cambioCategoria; }
        //    set { _cambioCategoria = value; }
        //}

        /// <summary>
        /// Gets or sets the motivo cambio sezione.
        /// </summary>
        /// <value>The motivo cambio sezione.</value>
        //[Bindable(true)]
        //public String MotivoCambioSezione
        //{
        //    get { return _motivoCambioSezione; }
        //    set { _motivoCambioSezione = value; }
        //}

        /// <summary>
        /// Gets or sets the id tipo cambio sezione.
        /// </summary>
        /// <value>The id tipo cambio sezione.</value>
        //[Bindable(true)]
        //public int IdTipoCambioSezione
        //{
        //    get { return _idTipoCambioSezione; }
        //    set { _idTipoCambioSezione = value; }
        //}

        /// <summary>
        /// Gets or sets the nuova sezione.
        /// </summary>
        /// <value>The nuova sezione.</value>
        [Bindable(true)]
        public int Sezione
        {
            get { return _sezione; }
            set { _sezione = value; }
        }

        /// <summary>
        /// Gets or sets the vecchia sezione.
        /// </summary>
        /// <value>The vecchia sezione.</value>
        //[Bindable(true)]
        //public int VecchiaSezione
        //{
        //    get { return _vecchiaSezione; }
        //    set { _vecchiaSezione = value; }
        //}

        ///// <summary>
        ///// Gets or sets a value indicating whether [cambio sezione].
        ///// </summary>
        ///// <value><c>true</c> if [cambio sezione]; otherwise, <c>false</c>.</value>
        //[Bindable(true)]
        //public Boolean CambioSezione
        //{
        //    get { return _cambioSezione; }
        //    set { _cambioSezione = value; }
        //}

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
        /// Gets or sets a value indicating whether [processo concluso].
        /// </summary>
        /// <value><c>true</c> if [processo concluso]; otherwise, <c>false</c>.</value>
        //[Bindable(true)]
        //public Boolean ProcessoConcluso
        //{
        //    get { return _processoConcluso; }
        //    set { _processoConcluso = value; }
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
        /// Gets or sets the data processo ufficio.
        /// </summary>
        /// <value>The data processo ufficio.</value>
        //[Bindable(true)]
        //public DateTime? DataProcessoUfficio
        //{
        //    get { return _dataProcessoUfficio; }
        //    set { _dataProcessoUfficio = value; }
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
        /// Gets or sets the id cambio posizione.
        /// </summary>
        /// <value>The id cambio posizione.</value>
        [Bindable(true)]
        public int IdCambioPosizione
        {
            get { return _idCambioPosizione; }
            set { _idCambioPosizione = value; }
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

                if (_idCambioPosizione > 0)
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

                if (_sottoSezione > 0)
                {
                    toReturn = true;
                }
                if (_sezione > 0)
                {
                    toReturn = true;
                }
                if (_idCategoria > 0)
                {
                    toReturn = true;
                }
                if (_categoriaSociale > 0)
                {
                    toReturn = true;
                }
                if (_idSottoCategoria > 0)
                {
                    toReturn = true;
                }
                if (!String.IsNullOrEmpty(_note))
                {
                    toReturn = true;
                }

                //if (_idRegistro
                //if (_numeroPosizione

                return toReturn;
            }
        }
    }
}
