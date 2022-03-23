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
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.PersonaFisicaFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.PersonaGiuridicaFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.SoggettoFDT))]
    public partial class ProceduraFallimentareFDT : FDTBase, DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo
    {
        #region Instance Variables (7)

        private int _idProceduraFallimentare;
        private DateTime _dataSentenza;
        private int _idRegistro;
        private int _idCuratore;
        private int _esito;
        //private int _idTribunale;
        private String _tribunale;
        //private int _stato;
        private DateTime? _dataFineProcedura;

        private SoggettoFDT _curatore;
        //private SoggettoFDT _tribunale;
        private DocumentazioneFDT[] _documentazioni;

        #endregion Instance Variables

        #region Public Properties (7)

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
        /// Gets or sets the tribunale.
        /// </summary>
        /// <value>The tribunale.</value>
        //[Bindable(true)]
        //public SoggettoFDT Tribunale
        //{
        //    get { return _tribunale; }
        //    set { _tribunale = value; }
        //}

        /// <summary>
        /// Gets or sets the curatore.
        /// </summary>
        /// <value>The curatore.</value>
        [Bindable(true)]
        public SoggettoFDT Curatore
        {
            get { return _curatore; }
            set { _curatore = value; }
        }

        /// <summary>
        /// Gets or sets the id procedura fallimentare.
        /// </summary>
        /// <value>The id procedura fallimentare.</value>
        [Bindable(true)]
        public int IdProceduraFallimentare
        {
            get { return _idProceduraFallimentare; }
            set { _idProceduraFallimentare = value; }
        }

        [Bindable(true)]
        public int Esito
        {
            get { return _esito; }
            set { _esito = value; }
        }

        /// <summary>
        /// Gets or sets the tribunale.
        /// </summary>
        /// <value>The tribunale.</value>
        [Bindable(true)]
        public String Tribunale
        {
            get { return _tribunale; }
            set { _tribunale = value; }
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
        /// Gets or sets the data sentenza.
        /// </summary>
        /// <value>The data sentenza.</value>
        [Bindable(true)]
        public DateTime DataSentenza
        {
            get { return _dataSentenza; }
            set { _dataSentenza = value; }
        }

        /// <summary>
        /// Gets or sets the id tribunale.
        /// </summary>
        /// <value>The id tribunale.</value>
        //[Bindable(true)]
        //public int IdTribunale
        //{
        //    get { return _idTribunale; }
        //    set { _idTribunale = value; }
        //}

        /// <summary>
        /// Gets or sets the id curatore.
        /// </summary>
        /// <value>The id curatore.</value>
        [Bindable(true)]
        public int IdCuratore
        {
            get { return _idCuratore; }
            set { _idCuratore = value; }
        }

        /// <summary>
        /// Gets or sets the stato.
        /// </summary>
        /// <value>The stato.</value>
        //[Bindable(true)]
        //public int Stato
        //{
        //    get { return _stato; }
        //    set { _stato = value; }
        //}

        /// <summary>
        /// Gets or sets the data fine procedura.
        /// </summary>
        /// <value>The data fine procedura.</value>
        [Bindable(true)]
        public DateTime? DataFineProcedura
        {
            get { return _dataFineProcedura; }
            set { _dataFineProcedura = value; }
        }

        #endregion Public Properties

        #region PropertyNames Class

        /// <summary>
        /// PropertyNames
        /// </summary>
        public partial class PropertyNames
        {
            public const string DataSentenza = "DataSentenza";
            public const string Tribunale = "Tribunale";
        }

        #endregion PropertyNames Class

        #region IDXDataErrorInfo Members

        public void GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {

        }

        public void GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
            if ((propertyName == PropertyNames.DataSentenza && (_dataSentenza == null || _dataSentenza == DateTime.MinValue || _dataSentenza == DateTime.MaxValue)))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }

            if ((propertyName == PropertyNames.Tribunale && String.IsNullOrEmpty(_tribunale)))
            {
                info.ErrorText = "Richiesto";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            }

        }

        #endregion
    }
}
