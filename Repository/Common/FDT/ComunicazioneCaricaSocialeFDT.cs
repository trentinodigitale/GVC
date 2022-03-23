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
    public partial class ComunicazioneCaricaSocialeFDT : FDTBase, DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo
    {
        #region Instance Variables (12)

        private int _idComunicazioneCaricaSociale;
        private int _idRegistro;
        private DateTime? _dataComunicazione;
        private DateTime _dataSituazione;
        private String _numeroProtocolloAntimafia;
        private DateTime? _dataComunicazioneAntimafia;
        private String _note;
        private DateTime? _dataUltimaModifica;
        private String _operatoreUltimaModifica;
        private Boolean _retrieveCaricheFromParix;

        private CaricaSocialeFDT[] _cariche;
        private DocumentazioneFDT[] _documentazioni;

        #endregion Instance Variables

        #region Public Properties (12)

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
        /// Gets or sets the cariche.
        /// </summary>
        /// <value>The cariche.</value>
        [Bindable(true)]
        public CaricaSocialeFDT[] Cariche
        {
            get { return _cariche; }
            set { _cariche = value; }
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
        /// Gets or sets the data comunizazione antimafia.
        /// </summary>
        /// <value>The data comunizazione antimafia.</value>
        [Bindable(true)]
        public DateTime? DataComunicazioneAntimafia
        {
            get { return _dataComunicazioneAntimafia; }
            set { _dataComunicazioneAntimafia = value; }
        }

        [Bindable(true)]
        public Boolean RetrieveCaricheFromParix
        {
            get { return _retrieveCaricheFromParix; }
            set { _retrieveCaricheFromParix = value; }
        }


        /// <summary>
        /// Gets or sets the numero protocollo antimafia.
        /// </summary>
        /// <value>The numero protocollo antimafia.</value>
        [Bindable(true)]
        public string NumeroProtocolloAntimafia
        {
            get { return _numeroProtocolloAntimafia; }
            set { _numeroProtocolloAntimafia = value; }
        }

        /// <summary>
        /// Gets or sets the data situazione.
        /// </summary>
        /// <value>The data situazione.</value>
        [Bindable(true)]
        public DateTime DataSituazione
        {
            get { return _dataSituazione; }
            set { _dataSituazione = value; }
        }

        /// <summary>
        /// Gets or sets the data comunicazione.
        /// </summary>
        /// <value>The data comunicazione.</value>
        [Bindable(true)]
        public DateTime? DataComunicazione
        {
            get { return _dataComunicazione; }
            set { _dataComunicazione = value; }
        }

        /// <summary>
        /// Gets or sets the id comunicazione carica sociale.
        /// </summary>
        /// <value>The id comunicazione carica sociale.</value>
        [Bindable(true)]
        public int IdComunicazioneCaricaSociale
        {
            get { return _idComunicazioneCaricaSociale; }
            set { _idComunicazioneCaricaSociale = value; }
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

        public void AddCariche(CaricaSocialeFDT item)
        {
            if (Cariche == null)
                Cariche = new CaricaSocialeFDT[] { };

            List<CaricaSocialeFDT> lTemp = new List<CaricaSocialeFDT>(Cariche);
            lTemp.Add(item);
            Cariche = lTemp.ToArray();
        }

        #endregion Public Properties

        #region Public Methods (1)

        public override void OnCreateInstance()
        {
            this._dataSituazione = new System.DateTime(System.DateTime.Now.Year - 1, 12, 31);
            base.OnCreateInstance();
        }

        #endregion Public Methods 

        #region PropertyNames Class

        /// <summary>
        /// PropertyNames
        /// </summary>
        public partial class PropertyNames
        {
            public const string DataSituazione = "DataSituazione";
        }

        #endregion PropertyNames Class

        #region IDXDataErrorInfo Members

        public void GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {

        }

        public void GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
            if ((propertyName == "DataSituazione" && (_dataSituazione == DateTime.MinValue || _dataSituazione == DateTime.MaxValue)))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }
        }

        #endregion
    }
}
