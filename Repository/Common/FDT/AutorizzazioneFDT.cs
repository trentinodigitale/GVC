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
    public partial class AutorizzazioneFDT : FDTBase, DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo
    {
        #region Instance Variables (12)

        private int _idAutorizzazione;
        private int _idTipoAutorizzazione;
        private int _idLiquidazione;
        private int _idRegistrazione;
        private String _descrizioneDatoStorico;
        private DateTime? _dataIstanza;
        private DateTime? _dataRicevimentoRichiesta;
        private double _durataProcessoUfficio;
        private Boolean _processoChiuso;
        private String _numeroDeliberaCommissione;
        private DateTime? _dataDeliberaCommissione;
        private String _numeroDetermina;
        private DateTime? _dataDetermina;
        private String _note;
        private DateTime? _dataUltimaModifica;
        private string _operatoreUltimaModifica;

        #endregion Instance Variables (12)

        #region Public Properties (12)

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
        public string NumeroDeliberaCommissione
        {
            get { return _numeroDeliberaCommissione; }
            set { _numeroDeliberaCommissione = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [processo chiuso].
        /// </summary>
        /// <value><c>true</c> if [processo chiuso]; otherwise, <c>false</c>.</value>
        [Bindable(true)]
        public Boolean ProcessoChiuso
        {
            get { return _processoChiuso; }
            set { _processoChiuso = value; }
        }

        /// <summary>
        /// Gets or sets the durata processo ufficio.
        /// </summary>
        /// <value>The durata processo ufficio.</value>
        [Bindable(true)]
        public double DurataProcessoUfficio
        {
            get { return _durataProcessoUfficio; }
            set { _durataProcessoUfficio = value; }
        }

        /// <summary>
        /// Gets or sets the data ricevimento richiesta.
        /// </summary>
        /// <value>The data ricevimento richiesta.</value>
        [Bindable(true)]
        public DateTime? DataRicevimentoRichiesta
        {
            get { return _dataRicevimentoRichiesta; }
            set { _dataRicevimentoRichiesta = value; }
        }

        /// <summary>
        /// Gets or sets the data istanza.
        /// </summary>
        /// <value>The data istanza.</value>
        [Bindable(true)]
        public DateTime? DataIstanza
        {
            get { return _dataIstanza; }
            set { _dataIstanza = value; }
        }

        /// <summary>
        /// Gets or sets the descrizione dato storico.
        /// </summary>
        /// <value>The descrizione dato storico.</value>
        [Bindable(true)]
        public string DescrizioneDatoStorico
        {
            get { return _descrizioneDatoStorico; }
            set { _descrizioneDatoStorico = value; }
        }

        /// <summary>
        /// Gets or sets the id tipo autorizzazione.
        /// </summary>
        /// <value>The id tipo autorizzazione.</value>
        [Bindable(true)]
        public int IdTipoAutorizzazione
        {
            get { return _idTipoAutorizzazione; }
            set { _idTipoAutorizzazione = value; }
        }

        /// <summary>
        /// Gets or sets the id registrazione.
        /// </summary>
        /// <value>The id registrazione.</value>
        [Bindable(true)]
        public int IdRegistrazione
        {
            get { return _idRegistrazione; }
            set { _idRegistrazione = value; }
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
        /// Gets or sets the id autorizzazione.
        /// </summary>
        /// <value>The id autorizzazione.</value>
        [Bindable(true)]
        public int IdAutorizzazione
        {
            get { return _idAutorizzazione; }
            set { _idAutorizzazione = value; }
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
            public const string IdTipoAutorizzazione = "IdTipoAutorizzazione";
        }

        #endregion PropertyNames Class

        #region IDXDataErrorInfo Members

        public void GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {

        }

        public void GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
            if ((propertyName == PropertyNames.IdTipoAutorizzazione && _idTipoAutorizzazione < 1))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }

        }

        #endregion
    }
}
