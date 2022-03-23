using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.FDT
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.SoggettoFDT))]
    [Serializable]
    public partial class RevisioneFDT : FDTBase, DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo
    {
        #region Instance Variables (21)

        private int _idRevisione;
        private int _idTipoRevisione;
        private int _idEsitoRevisione;
        private int _idRegistro;
        private int _idOrganoRevisore;
        private int _idLimiteCosto;
        private int _annoRevisione;
        private DateTime? _dataConclusione;
        private DateTime? _dataDepositoRelazione;  
        private String _numeroDeliberaEsame;
        private DateTime? _dataDeliberaEsame;
        private String _numeroDeterminaEsame;
        private DateTime? _dataDeterminaEsame;
        private DateTime? _dataCominicazioneEsiti;
        private DateTime? _dataDeliberaRevoca;
        private String _numeroDeliberaRevoca;
        private String _numeroDeterminaRevoca;
        private DateTime? _dataDeterminaRevoca;
        private DateTime? _dataUltimaModifica;
        private String _operatoreUltimaModifica;
        
        private PersonaGiuridicaFDT _revisore;
        private RevisioneIncaricoFDT[] _revisioniIncarichi;
        private CompensoLiquidazioneFDT[] _liquidazioni;
        private DocumentazioneFDT[] _documentazioni;

        #endregion Instance Variables

        #region Public Properties (21)

        /// <summary>
        /// Gets or sets the anno revisione.
        /// </summary>
        /// <value>The anno revisione.</value>
        [Bindable(true)]
        public int AnnoRevisione
        {
            get { return _annoRevisione; }
            set { _annoRevisione = value; }
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
        /// Gets or sets the id esito revisione.
        /// </summary>
        /// <value>The id esito revisione.</value>
        [Bindable(true)]
        public int IdEsitoRevisione
        {
            get { return _idEsitoRevisione; }
            set { _idEsitoRevisione = value; }
        }

        [Bindable(true)]
        public int IdOrganoRevisore
        {
            get { return _idOrganoRevisore; }
            set { _idOrganoRevisore = value; }
        }


        [Bindable(true)]
        public int IdLimiteCosto
        {
            get { return _idLimiteCosto; }
            set { _idLimiteCosto = value; }
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
        /// Gets or sets the data deposito relazione.
        /// </summary>
        /// <value>The data deposito relazione.</value>
        [Bindable(true)]
        public DateTime? DataDepositoRelazione
        {
            get { return _dataDepositoRelazione; }
            set { _dataDepositoRelazione = value; }
        }

        /// <summary>
        /// Gets or sets the numero delibera esame.
        /// </summary>
        /// <value>The numero delibera esame.</value>
        [Bindable(true)]
        public String NumeroDeliberaEsame
        {
            get { return _numeroDeliberaEsame; }
            set { _numeroDeliberaEsame = value; }
        }

        /// <summary>
        /// Gets or sets the data delibera esame.
        /// </summary>
        /// <value>The data delibera esame.</value>
        [Bindable(true)]
        public DateTime? DataDeliberaEsame
        {
            get { return _dataDeliberaEsame; }
            set { _dataDeliberaEsame = value; }
        }

        /// <summary>
        /// Gets or sets the numero determina esame.
        /// </summary>
        /// <value>The numero determina esame.</value>
        [Bindable(true)]
        public String NumeroDeterminaEsame
        {
            get { return _numeroDeterminaEsame; }
            set { _numeroDeterminaEsame = value; }
        }

        /// <summary>
        /// Gets or sets the data determina esame.
        /// </summary>
        /// <value>The data determina esame.</value>
        [Bindable(true)]
        public DateTime? DataDeterminaEsame
        {
            get { return _dataDeterminaEsame; }
            set { _dataDeterminaEsame = value; }
        }

        /// <summary>
        /// Gets or sets the data cominicazione esiti.
        /// </summary>
        /// <value>The data cominicazione esiti.</value>
        [Bindable(true)]
        public DateTime? DataCominicazioneEsiti
        {
            get { return _dataCominicazioneEsiti; }
            set { _dataCominicazioneEsiti = value; }
        }

        /// <summary>
        /// Gets or sets the numero delibera revoca.
        /// </summary>
        /// <value>The numero delibera revoca.</value>
        [Bindable(true)]
        public String NumeroDeliberaRevoca
        {
            get { return _numeroDeliberaRevoca; }
            set { _numeroDeliberaRevoca = value; }
        }

        /// <summary>
        /// Gets or sets the data delibera revoca.
        /// </summary>
        /// <value>The data delibera revoca.</value>
        [Bindable(true)]
        public DateTime? DataDeliberaRevoca
        {
            get { return _dataDeliberaRevoca; }
            set { _dataDeliberaRevoca = value; }
        }

        /// <summary>
        /// Gets or sets the numero determina revoca.
        /// </summary>
        /// <value>The numero determina revoca.</value>
        [Bindable(true)]
        public String NumeroDeterminaRevoca
        {
            get { return _numeroDeterminaRevoca; }
            set { _numeroDeterminaRevoca = value; }
        }

        /// <summary>
        /// Gets or sets the data determina revoca.
        /// </summary>
        /// <value>The data determina revoca.</value>
        [Bindable(true)]
        public DateTime? DataDeterminaRevoca
        {
            get { return _dataDeterminaRevoca; }
            set { _dataDeterminaRevoca = value; }
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
        /// Gets or sets the id revisione.
        /// </summary>
        /// <value>The id revisione.</value>
        [Bindable(true)]
        public int IdRevisione
        {
            get { return _idRevisione; }
            set { _idRevisione = value; }
        }

        /// <summary>
        /// Gets or sets the liquidazioni.
        /// </summary>
        /// <value>The liquidazioni.</value>
        [Bindable(true)]
        public CompensoLiquidazioneFDT[] Liquidazioni
        {
            get { return _liquidazioni; }
            set { _liquidazioni = value; }
        }

        /// <summary>
        /// Revisore (object)
        /// </summary>
        [Bindable(true)]
        public PersonaGiuridicaFDT Revisore
        {
            get { return _revisore; }
            set { _revisore = value; }
        }

        /// <summary>
        /// Gets or sets the revisioni incarichi.
        /// </summary>
        /// <value>The revisioni incarichi.</value>
        [Bindable(true)]
        public RevisioneIncaricoFDT[] RevisioniIncarichi
        {
            get { return _revisioniIncarichi; }
            set { _revisioniIncarichi = value; }
        }

        /// <summary>
        /// Gets or sets the id tipo revisione.
        /// </summary>
        /// <value>The id tipo revisione.</value>
        [Bindable(true)]
        public int IdTipoRevisione
        {
            get { return _idTipoRevisione; }
            set { _idTipoRevisione = value; }
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

        public void AddIncarico(RevisioneIncaricoFDT item)
        {
            if (RevisioniIncarichi == null)
                RevisioniIncarichi = new RevisioneIncaricoFDT[] { };

            List<RevisioneIncaricoFDT> lTemp = new List<RevisioneIncaricoFDT>(RevisioniIncarichi);
            lTemp.Add(item);
            RevisioniIncarichi = lTemp.ToArray();
        }

        public void Addliquidazione(CompensoLiquidazioneFDT item)
        {
            if (Liquidazioni == null)
                Liquidazioni = new CompensoLiquidazioneFDT[] { };

            List<CompensoLiquidazioneFDT> lTemp = new List<CompensoLiquidazioneFDT>(Liquidazioni);
            lTemp.Add(item);
            Liquidazioni = lTemp.ToArray();
        }

        #endregion Public Properties

        #region PropertyNames Class

        /// <summary>
        /// PropertyNames
        /// </summary>
        public partial class PropertyNames
        {
            public const string AnnoRevisione = "AnnoRevisione";
            public const string IdTipoRevisione = "IdTipoRevisione";
        }

        #endregion PropertyNames Class

        #region IDXDataErrorInfo Members

        public void GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
           
        }

        public void GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
            if ((propertyName == PropertyNames.AnnoRevisione && _annoRevisione < 1))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }

            if ((propertyName == PropertyNames.IdTipoRevisione && _idTipoRevisione < 1))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }

        }

        #endregion
    }
}
