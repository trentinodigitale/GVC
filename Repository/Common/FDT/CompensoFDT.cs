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
    public partial class CompensoFDT : FDTBase, DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo
    {
        #region Instance Variables (11)

        private int _idCompenso;
        private int _idRevisore;
        private double _percentualeCNP;
        private double _percentualeIVA;
        private int _valuta;
        private double _importoCompenso;
        private double _importoSpese;
        private double _importoCassa;
        private double _importoIVA;
        private double _importoTotale;
        private int _idLiquidazione;
        private int _idIncarico;
        private int _idProcedura;
        private int _tipoContributo;
        private String _numeroDetermina;
        private DateTime? _dataDetermina;
        
        private DateTime? _dataUltimaModifica;
        private String _operatoreUltimaModifica;

        private SoggettoFDT _revisore;

        #endregion Instance Variables (11)

        #region Public Properties (11)

        /// <summary>
        /// Gets or sets the revisore.
        /// </summary>
        /// <value>The revisore.</value>
        [Bindable(true)]
        public SoggettoFDT Revisore
        {
            get { return _revisore; }
            set { _revisore = value; }
        }

        /// <summary>
        /// Gets or sets the id revisore.
        /// </summary>
        /// <value>The id revisore.</value>
        [Bindable(true)]
        public int IdRevisore
        {
            get { return _idRevisore; }
            set { _idRevisore = value; }
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
        /// Gets or sets the id incarico.
        /// </summary>
        /// <value>The id incarico.</value>
        [Bindable(true)]
        public int IdIncarico
        {
            get { return _idIncarico; }
            set { _idIncarico = value; }
        }

        /// <summary>
        /// Gets or sets the id procedura.
        /// </summary>
        /// <value>The id procedura.</value>
        [Bindable(true)]
        public int IdProcedura
        {
            get { return _idProcedura; }
            set { _idProcedura = value; }
        }

        /// <summary>
        /// Gets or sets the tipo contributo.
        /// </summary>
        /// <value>The tipo contributo.</value>
        [Bindable(true)]
        public int TipoContributo
        {
            get { return _tipoContributo; }
            set { _tipoContributo = value; }
        }

        /// <summary>
        /// Gets or sets the numero determina.
        /// </summary>
        /// <value>The numero determina.</value>
        [Bindable(true)]
        public String NumeroDetermina
        {
            get { return _numeroDetermina; }
            set { _numeroDetermina = value; }
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
        /// Gets or sets the total amount (importo totale).
        /// </summary>
        /// <value>The total amount.</value>
        [Bindable(true)]
        public double ImportoTotale
        {
            get { return _importoTotale; }
            set { _importoTotale = value; }
        }

        /// <summary>
        /// Gets or sets the IVA amount.
        /// </summary>
        /// <value>The IVA amount.</value>
        [Bindable(true)]
        public double ImportoIVA
        {
            get { return _importoIVA; }
            set { _importoIVA = value; }
        }

        /// <summary>
        /// Gets or sets the case amount (importo cassa).
        /// </summary>
        /// <value>The case amount.</value>
        [Bindable(true)]
        public double ImportoCassa
        {
            get { return _importoCassa; }
            set { _importoCassa = value; }
        }

        /// <summary>
        /// Gets or sets the spending amount (importo spesa).
        /// </summary>
        /// <value>The spending amount.</value>
        [Bindable(true)]
        public double ImportoSpese
        {
            get { return _importoSpese; }
            set { _importoSpese = value; }
        }

        /// <summary>
        /// Gets or sets the counter balance amount (importo compenso).
        /// </summary>
        /// <value>The counter balance amount.</value>
        [Bindable(true)]
        public double ImportoCompenso
        {
            get { return _importoCompenso; }
            set { _importoCompenso = value; }
        }


        /// <summary>
        /// Gets or sets the valuta.
        /// </summary>
        /// <value>The valuta.</value>
        [Bindable(true)]
        public int Valuta
        {
            get { return _valuta; }
            set { _valuta = value; }
        }

        /// <summary>
        /// Percentage IVA
        /// </summary>
        [Bindable(true)]
        public double PercentualeIVA
        {
            get { return _percentualeIVA; }
            set { _percentualeIVA = value; }
        }

        /// <summary>
        /// Percentage CNP
        /// </summary>
        [Bindable(true)]
        public double PercentualeCNP
        {
            get { return _percentualeCNP; }
            set { _percentualeCNP = value; }
        }

        /// <summary>
        /// Record id
        /// </summary>
        [Bindable(true)]
        public int IdCompenso
        {
            get { return _idCompenso; }
            set { _idCompenso = value; }
        }

        public Byte[] IconaRevisore
        {
            get
            {
                if (Revisore != null)
                    return Revisore.Icona;
                else return null;
            }
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
            public const string Revisore = "Revisore_DescrizioneBreve";
        }

        #endregion PropertyNames Class

        #region IDXDataErrorInfo Members

        public void GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {

        }

        public void GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
            if ((propertyName == PropertyNames.Revisore && (_revisore == null || _revisore.DescrizioneBreve == null || _revisore.IdSoggetto <= 0)))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }
        }

        #endregion
    }
}
