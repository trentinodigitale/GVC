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
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.PersonaGiuridicaFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.SoggettoFDT))]
    public partial class AdesioneFDT : FDTBase, DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo
    {
		#region Instance Variables (12) 

        private int _idAdesione;
        private int _idRegistro;
        private int _idAssociazione;
        private DateTime _dataInizio;
        private DateTime? _dataFine;
        private DateTime? _dataInzioEsameCommissione;
        private DateTime? _dataFineEsameCommissione;
        private Boolean _revisore;
        private String _note;
        private DateTime? _dataUltimaModifica;
        private String _operatoreUltimaModifica;

        private PersonaGiuridicaFDT _associazione;
        private DocumentazioneFDT[] _documentazioni;

		#endregion Instance Variables 

		#region Public Properties (12) 

        /// <summary>
        /// Gets or sets the associazione.
        /// </summary>
        /// <value>The associazione.</value>
        [Bindable(true)]
        public PersonaGiuridicaFDT Associazione
        {
            get { return _associazione; }
            set { _associazione = value; }
        }

        /// <summary>
        /// Gets or sets the begin date. (data inizio adesione)
        /// </summary>
        /// <value>The begin date.</value>
        [Bindable(true)]
        public DateTime DataInizio
        {
            get { return _dataInizio; }
            set { _dataInizio = value; }
        }

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
        /// Gets or sets the end date. (data fine adesione)
        /// </summary>
        /// <value>The end date.</value>
        [Bindable(true)]
        public DateTime? DataFine
        {
            get { return _dataFine; }
            set { _dataFine = value; }
        }

        /// <summary>
        /// Gets or sets the exam commission begin date. (Data inizio esame commissione)
        /// </summary>
        /// <value>The exam commission begin date.</value>
        [Bindable(true)]
        public DateTime? DataInzioEsameCommissione
        {
            get { return _dataInzioEsameCommissione; }
            set { _dataInzioEsameCommissione = value; }
        }

        /// <summary>
        /// Gets or sets the exam commission end date. (Data fine esame commissione)
        /// </summary>
        /// <value>The exam commission end date.</value>
        [Bindable(true)]
        public DateTime? DataFineEsameCommissione
        {
            get { return _dataFineEsameCommissione; }
            set { _dataFineEsameCommissione = value; }
        }

        /// <summary>
        /// Gets or sets the id associazione.
        /// </summary>
        /// <value>The id associazione.</value>
        [Bindable(true)]
        public int IdAssociazione
        {
            get { return _idAssociazione; }
            set { _idAssociazione = value; }
        }

        /// <summary>
        /// Gets or sets the id adesione.
        /// </summary>
        /// <value>The id adesione.</value>
        [Bindable(true)]
        public int IdAdesione
        {
            get { return _idAdesione; }
            set { _idAdesione = value; }
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
        /// Gets or sets a value indicating whether this instance is revisor. 
        /// (indica se l'associazione è anche organo di revisione)
        /// </summary>
        [Bindable(true)]
        public Boolean Revisore
        {
            get { return _revisore; }
            set { _revisore = value; }
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

        #region IDXDataErrorInfo Members

        public void GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {

        }

        public void GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
            if (propertyName == "Associazione_DescrizioneBreve" && (_associazione == null || _idAssociazione <= 0))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }

            if ((propertyName == "DataInizio" && (_dataInizio == DateTime.MinValue || _dataInizio == DateTime.MaxValue)))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }
        }

        #endregion

        public override void OnCreateInstance()
        {
            this._dataInizio = System.DateTime.Now;
            this._dataFine = null;
            this._dataInzioEsameCommissione = null;
            this._dataFineEsameCommissione = null;
            base.OnCreateInstance();
        }
    }
}
