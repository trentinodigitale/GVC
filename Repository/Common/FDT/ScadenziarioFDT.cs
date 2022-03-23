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
    public partial class ScadenziarioFDT : FDTBase, DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo
    {
        #region Instance Variables (8)

        private int _idScadenziario;
        private int _idTipoScadenziario;
        private int _idRegistro;
        private DateTime _dataAnnotazione;
        private Boolean _riservataUfficio;
        private String _descrizione;
        private Boolean _evasa;
        private DateTime? _dataScadenza;
        private DateTime? _dataEvasione;
        private DateTime? _dataUltimaModifica;
        private String _operatoreUltimaModifica;

        //private DocumentazioneFDT[] _documentazioni;

        #endregion Instance Variables

        #region Public Properties (8)

        /// <summary>
        /// Gets or sets the id scadenziario.
        /// </summary>
        /// <value>The id scadenziario.</value>
        [Bindable(true)]
        public int IdScadenziario
        {
            get { return _idScadenziario; }
            set { _idScadenziario = value; }
        }

        /// <summary>
        /// Gets or sets the data annotazione.
        /// </summary>
        /// <value>The data annotazione.</value>
        [Bindable(true)]
        public DateTime DataAnnotazione
        {
            get { return _dataAnnotazione; }
            set { _dataAnnotazione = value; }
        }

        /// <summary>
        /// Gets or sets the id tipo scadenziario.
        /// </summary>
        /// <value>The id tipo scadenziario.</value>
        [Bindable(true)]
        public int IdTipoScadenziario
        {
            get { return _idTipoScadenziario; }
            set { _idTipoScadenziario = value; }
        }

        [Bindable(true)]
        public int IdRegistro
        {
            get { return _idRegistro; }
            set { _idRegistro = value; }
        }

        /// <summary>
        /// Gets or sets the riservata ufficio.
        /// </summary>
        /// <value>The riservata ufficio.</value>
        [Bindable(true)]
        public Boolean RiservataUfficio
        {
            get { return _riservataUfficio; }
            set { _riservataUfficio = value; }
        }

        /// <summary>
        /// Gets or sets the descrizione.
        /// </summary>
        /// <value>The descrizione.</value>
        [Bindable(true)]
        public String Descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
        }

        /// <summary>
        /// Gets or sets the evasa.
        /// </summary>
        /// <value>The evasa.</value>
        [Bindable(true)]
        public Boolean Evasa
        {
            get { return _evasa; }
            set { _evasa = value; }
        }

        /// <summary>
        /// Gets or sets the data scadenza.
        /// </summary>
        /// <value>The data scadenza.</value>
        [Bindable(true)]
        public DateTime? DataScadenza
        {
            get { return _dataScadenza; }
            set { _dataScadenza = value; }
        }

        /// <summary>
        /// Gets or sets the data evasione.
        /// </summary>
        /// <value>The data evasione.</value>
        [Bindable(true)]
        public DateTime? DataEvasione
        {
            get { return _dataEvasione; }
            set { _dataEvasione = value; }
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
        /// Gets or sets the documentazioni.
        /// </summary>
        /// <value>The documentazioni.</value>
        //[Bindable(true)]
        //public DocumentazioneFDT[] Documentazioni
        //{
        //    get { return _documentazioni; }
        //    set { _documentazioni = value; }
        //}

        #endregion Public Properties


        #region PropertyNames Class

        /// <summary>
        /// PropertyNames
        /// </summary>
        public partial class PropertyNames
        {
            public const string IdTipoScadenziario = "IdTipoScadenziario";
            public const string Data = "DataAnnotazione";
        }

        #endregion PropertyNames Class

        #region IDXDataErrorInfo Members

        public void GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {

        }

        public void GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
            if ((propertyName == PropertyNames.IdTipoScadenziario && _idTipoScadenziario < 1))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }

            if ((propertyName == PropertyNames.Data && (_dataAnnotazione == DateTime.MinValue || _dataAnnotazione == DateTime.MaxValue)))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }

        }

        #endregion

        public override void OnCreateInstance()
        {
            this._dataAnnotazione = System.DateTime.Now;
        }
    }
}
