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
    public partial class RelazioneSemestraleFDT : FDTBase, DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo
    {
        #region Instance Variables (8)

        private int _idRelazioneSemestrale;
        private int _idLiquidazione;
        private DateTime? _dataRelazione;
        //private DateTime _dataRicevimentoRelazione;
        //private double _durataProcessoUfficio;
        //private DateTime _dataFineTeorica;
        private DateTime? _dataEsitoCommissione;
        private DateTime? _dataEsameufficio;
        private String _note;
        private DateTime? _dataUltimaModifica;
        private String _operatoreUltimaModifica;

        #endregion Instance Variables

        #region Public Properties (8)

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
        /// Gets or sets the data esameufficio.
        /// </summary>
        /// <value>The data esameufficio.</value>
        [Bindable(true)]
        public DateTime? DataEsameufficio
        {
            get { return _dataEsameufficio; }
            set { _dataEsameufficio = value; }
        }

        /// <summary>
        /// Gets or sets the data esito commissione.
        /// </summary>
        /// <value>The data esito commissione.</value>
        [Bindable(true)]
        public DateTime? DataEsitoCommissione
        {
            get { return _dataEsitoCommissione; }
            set { _dataEsitoCommissione = value; }
        }

        /// <summary>
        /// Gets or sets the data fine teorica.
        /// </summary>
        /// <value>The data fine teorica.</value>
        //[Bindable(true)]
        //public DateTime DataFineTeorica
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
        /// Gets or sets the data ricevimento relazione.
        /// </summary>
        /// <value>The data ricevimento relazione.</value>
        //[Bindable(true)]
        //public DateTime DataRicevimentoRelazione
        //{
        //    get { return _dataRicevimentoRelazione; }
        //    set { _dataRicevimentoRelazione = value; }
        //}

        /// <summary>
        /// Gets or sets the data relazione.
        /// </summary>
        /// <value>The data relazione.</value>
        [Bindable(true)]
        public DateTime? DataRelazione
        {
            get { return _dataRelazione; }
            set { _dataRelazione = value; }
        }

        /// <summary>
        /// Gets or sets the id relazione semestrale.
        /// </summary>
        /// <value>The id relazione semestrale.</value>
        [Bindable(true)]
        public int IdRelazioneSemestrale
        {
            get { return _idRelazioneSemestrale; }
            set { _idRelazioneSemestrale = value; }
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
            public const string DataRelazione = "DataRelazione";
        }

        #endregion PropertyNames Class

        #region IDXDataErrorInfo Members

        public void GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {

        }

        public void GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {            
            if ((propertyName == PropertyNames.DataRelazione && _dataRelazione == null))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }
        }

        #endregion
    }
}
