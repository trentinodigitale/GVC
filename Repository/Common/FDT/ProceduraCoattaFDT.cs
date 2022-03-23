using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;

namespace it.dedagroup.GVC.Repository.Common.FDT
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public partial class ProceduraCoattaFDT : FDTBase, DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo
    {
        #region Instance Variables (21)

        private int _idProceduraCoatta;
        private int _idTipoProceduraCoatta;
        private int _idRegistro;
        //private DateTime _dataInizioProcesso;
        //private double _durataProcessoUfficio;
        //private DateTime _dataFineProcessoTeorica;
        //private Boolean _processoChiuso;
        private String _numeroDeliberaCommissione;
        private DateTime? _dataDeliberaCommissione;
        private DateTime? _dataIscrizioneRI;
        private String _numeroDetermina;
        private DateTime? _dataDetermina;
        private DateTime? _dataInzioProcedura;
        private DateTime? _dataScadenzaProcedura;
        private DateTime? _dataFineProcedura;
        private String _numeroDeliberaCommissioneFineIncarico;
        private DateTime? _dataDeliberaCommissioneFineIncarico;
        private String _numeroDeterminaFineIncarico;
        private DateTime? _dataDeterminaFineIncarico;

        private ProrogaFDT[] _proroghe;
        private CompensoFDT[] _compensiCommissari;
        private CompensoLiquidazioneFDT[] _liquidazioni;
        private DocumentazioneFDT[] _documentazioni;

        private DateTime? _dataUltimaModifica;
        private String _operatoreUltimaModifica;

        #endregion Instance Variables (21)

        #region Public Properties (21)

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
        /// Gets or sets the compensi commissari.
        /// </summary>
        /// <value>The compensi commissari.</value>
        [Bindable(true)]
        public CompensoFDT[] CompensiCommissari
        {
            get { return _compensiCommissari; }
            set { _compensiCommissari = value; }
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

        [Bindable(true)]
        public DateTime? DataIscrizioneRI
        {
            get { return _dataIscrizioneRI; }
            set { _dataIscrizioneRI = value; }
        }

        /// <summary>
        /// Gets or sets the data determina fine incarico.
        /// </summary>
        /// <value>The data determina fine incarico.</value>
        [Bindable(true)]
        public DateTime? DataDeterminaFineIncarico
        {
            get { return _dataDeterminaFineIncarico; }
            set { _dataDeterminaFineIncarico = value; }
        }

        /// <summary>
        /// Gets or sets the numero determina fine incarico.
        /// </summary>
        /// <value>The numero determina fine incarico.</value>
        [Bindable(true)]
        public string NumeroDeterminaFineIncarico
        {
            get { return _numeroDeterminaFineIncarico; }
            set { _numeroDeterminaFineIncarico = value; }
        }

        /// <summary>
        /// Gets or sets the data delibera commissione fine incarico.
        /// </summary>
        /// <value>The data delibera commissione fine incarico.</value>
        [Bindable(true)]
        public DateTime? DataDeliberaCommissioneFineIncarico
        {
            get { return _dataDeliberaCommissioneFineIncarico; }
            set { _dataDeliberaCommissioneFineIncarico = value; }
        }

        /// <summary>
        /// Gets or sets the numero delibera commissione fine incarico.
        /// </summary>
        /// <value>The numero delibera commissione fine incarico.</value>
        [Bindable(true)]
        public String NumeroDeliberaCommissioneFineIncarico
        {
            get { return _numeroDeliberaCommissioneFineIncarico; }
            set { _numeroDeliberaCommissioneFineIncarico = value; }
        }

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

        /// <summary>
        /// Gets or sets the data scadenza procedura.
        /// </summary>
        /// <value>The data scadenza procedura.</value>
        [Bindable(true)]
        public DateTime? DataScadenzaProcedura
        {
            get { return _dataScadenzaProcedura; }
            set { _dataScadenzaProcedura = value; }
        }

        /// <summary>
        /// Gets or sets the data inzio procedura.
        /// </summary>
        /// <value>The data inzio procedura.</value>
        [Bindable(true)]
        public DateTime? DataInzioProcedura
        {
            get { return _dataInzioProcedura; }
            set { _dataInzioProcedura = value; }
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
        //[Bindable(true)]
        //public Boolean ProcessoChiuso
        //{
        //    get { return _processoChiuso; }
        //    set { _processoChiuso = value; }
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
        /// Gets or sets the data inizio processo.
        /// </summary>
        /// <value>The data inizio processo.</value>
        //[Bindable(true)]
        //public DateTime? DataInizioProcesso
        //{
        //    get { return _dataInizioProcesso; }
        //    set { _dataInizioProcesso = value; }
        //}

        /// <summary>
        /// Gets or sets the data fine processo teorica.
        /// </summary>
        /// <value>The data fine processo teorica.</value>
        //[Bindable(true)]
        //public DateTime? DataFineProcessoTeorica
        //{
        //    get { return _dataFineProcessoTeorica; }
        //    set { _dataFineProcessoTeorica = value; }
        //}

        /// <summary>
        /// Gets or sets the id tipo procedura coatta.
        /// </summary>
        /// <value>The id tipo procedura coatta.</value>
        [Bindable(true)]
        public int IdTipoProceduraCoatta
        {
            get { return _idTipoProceduraCoatta; }
            set { _idTipoProceduraCoatta = value; }
        }

        /// <summary>
        /// Gets or sets the id procedura coatta.
        /// </summary>
        /// <value>The id procedura coatta.</value>
        [Bindable(true)]
        public int IdProceduraCoatta
        {
            get { return _idProceduraCoatta; }
            set { _idProceduraCoatta = value; }
        }

        [Bindable(true)]
        public int IdRegistro
        {
            get { return _idRegistro; }
            set { _idRegistro = value; }
        }

        /// <summary>
        /// Gets or sets the proroghe.
        /// </summary>
        /// <value>The proroghe.</value>
        [Bindable(true)]
        public ProrogaFDT[] Proroghe
        {
            get { return _proroghe; }
            set { _proroghe = value; }
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

        public void AddLiquidazione(CompensoLiquidazioneFDT item)
        {
            if (Liquidazioni == null)
                Liquidazioni = new CompensoLiquidazioneFDT[] { };

            List<CompensoLiquidazioneFDT> lTemp = new List<CompensoLiquidazioneFDT>(Liquidazioni);
            lTemp.Add(item);
            Liquidazioni = lTemp.ToArray();
        }

        public void RemoveLiquidazione(CompensoLiquidazioneFDT item)
        {
            if (Liquidazioni != null)
            {
                List<CompensoLiquidazioneFDT> lTemp = new List<CompensoLiquidazioneFDT>(Liquidazioni);

                if (lTemp.Remove(item))
                {
                    Liquidazioni = lTemp.ToArray();
                }
            }
        }

        public void AddCompensoCommissario(CompensoFDT item)
        {
            if (CompensiCommissari == null)
                CompensiCommissari = new CompensoFDT[] { };

            List<CompensoFDT> lTemp = new List<CompensoFDT>(CompensiCommissari);
            lTemp.Add(item);
            CompensiCommissari = lTemp.ToArray();
        }

        public void RemoveCompensoCommissario(CompensoFDT item)
        {
            if (CompensiCommissari != null)
            {
                List<CompensoFDT> lTemp = new List<CompensoFDT>(CompensiCommissari);

                if (lTemp.Remove(item))
                {
                    CompensiCommissari = lTemp.ToArray();
                }
            }
        }

        public void AddProroga(ProrogaFDT item)
        {
            if (Proroghe == null)
                Proroghe = new ProrogaFDT[] { };

            List<ProrogaFDT> lTemp = new List<ProrogaFDT>(Proroghe);
            lTemp.Add(item);
            Proroghe = lTemp.ToArray();
        }

        public void RemoveProroga(ProrogaFDT item)
        {
            if (Proroghe != null)
            {
                List<ProrogaFDT> lTemp = new List<ProrogaFDT>(Proroghe);

                if (lTemp.Remove(item))
                {
                    Proroghe = lTemp.ToArray();
                }
            }
        }

        #endregion Public Properties

        #region PropertyNames Class

        /// <summary>
        /// PropertyNames
        /// </summary>
        public partial class PropertyNames
        {            
            public const string IdTipoProceduraCoatta = "IdTipoProceduraCoatta";
        }

        #endregion PropertyNames Class

        #region IDXDataErrorInfo Members

        public void GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {

        }

        public void GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {            
            if ((propertyName == PropertyNames.IdTipoProceduraCoatta && _idTipoProceduraCoatta < 1))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }

        }

        #endregion


    }
}
