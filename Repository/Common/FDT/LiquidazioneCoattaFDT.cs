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
    public partial class LiquidazioneCoattaFDT : FDTBase, DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo
    {
        #region Instance Variables (24)

        private int _idLiquidazioneCoatta;
        private int _idTipoLiquidazioneCoatta;
        private int _idRegistro;
        //private DateTime _dataInizioProcesso;
        //private double _durataProcessoUfficio;
        //private DateTime _dataFineProcessoTeorica;
        //private Boolean _processoChiuso;
        private String _numeroDetermina;
        private DateTime? _dataDetermina;
        private String _numeroDeliberaCommissione;
        private DateTime? _dataDeliberaCommissione;
        private String _numeroDeliberaGiunta;
        private DateTime? _dataDeliberaGiunta;
        private DateTime? _dataPubblicazioneGU;
        private DateTime? _dataDepositoRI;
        private DateTime? _dataSentenzaInsolvenza;
        private String _codiceUfficio;
        private Boolean _depositoBFL;
        private Boolean _proceduraRevocata;
        private String _numeroDeterminaRevoca;
        private DateTime? _dataDeterminaRevoca;
        private String _numeroDeliberaRevoca;
        private DateTime? _dataDeliberaRevoca;
        private Boolean _proceduraTerminata;

        private DeliberaAcquistoCreditiFiscFDT[] _delibereAcquistoCreditiFisc;
        private CompensoFDT[] _compensiCommissari;
        private CompensoLiquidazioneFDT[] _liquidazioni;
        private DocumentazioneFDT[] _documentazioni;
        private RelazioneSemestraleFDT[] _relazioniSemestrali;
        private AutorizzazioneFDT[] _autorizzazioni;
        private DateTime? _dataUltimaModifica;
        private String _operatoreUltimaModifica;

        #endregion Instance Variables (24)

        #region Public Properties (24)

        /// <summary>
        /// Gets or sets the autorizzazioni.
        /// </summary>
        /// <value>The autorizzazioni.</value>
        [Bindable(true)]
        public AutorizzazioneFDT[] Autorizzazioni
        {
            get { return _autorizzazioni; }
            set { _autorizzazioni = value; }
        }

        /// <summary>
        /// Gets or sets the relazioni semestrali.
        /// </summary>
        /// <value>The relazioni semestrali.</value>
        [Bindable(true)]
        public RelazioneSemestraleFDT[] RelazioniSemestrali
        {
            get { return _relazioniSemestrali; }
            set { _relazioniSemestrali = value; }
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

        //[Bindable(true)]
        /// <summary>
        /// Gets or sets the compensi commissari.
        /// </summary>
        /// <value>The compensi commissari.</value>
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

        /// <summary>
        /// Gets or sets the tax credit buy deliberations.
        /// </summary>
        /// <value>The tax credit buy deliberations.</value>
        [Bindable(true)]
        public DeliberaAcquistoCreditiFiscFDT[] DelibereAcquistoCreditiFisc
        {
            get { return _delibereAcquistoCreditiFisc; }
            set { _delibereAcquistoCreditiFisc = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [procedura terminata].
        /// </summary>
        /// <value><c>true</c> if [procedura terminata]; otherwise, <c>false</c>.</value>
        [Bindable(true)]
        public Boolean ProceduraTerminata
        {
            get { return _proceduraTerminata; }
            set { _proceduraTerminata = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [procedura revocata].
        /// </summary>
        /// <value><c>true</c> if [procedura revocata]; otherwise, <c>false</c>.</value>
        [Bindable(true)]
        public Boolean ProceduraRevocata
        {
            get { return _proceduraRevocata; }
            set { _proceduraRevocata = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [deposito BFL].
        /// </summary>
        /// <value><c>true</c> if [deposito BFL]; otherwise, <c>false</c>.</value>
        [Bindable(true)]
        public Boolean DepositoBFL
        {
            get { return _depositoBFL; }
            set { _depositoBFL = value; }
        }

        /// <summary>
        /// Gets or sets the codice ufficio.
        /// </summary>
        /// <value>The codice ufficio.</value>
        [Bindable(true)]
        public string CodiceUfficio
        {
            get { return _codiceUfficio; }
            set { _codiceUfficio = value; }
        }

        /// <summary>
        /// Gets or sets the data sentenza insolvenza.
        /// </summary>
        /// <value>The data sentenza insolvenza.</value>
        [Bindable(true)]
        public DateTime? DataSentenzaInsolvenza
        {
            get { return _dataSentenzaInsolvenza; }
            set { _dataSentenzaInsolvenza = value; }
        }

        /// <summary>
        /// Gets or sets the data pubblicazione GU.
        /// </summary>
        /// <value>The data pubblicazione GU.</value>
        [Bindable(true)]
        public DateTime? DataPubblicazioneGU
        {
            get { return _dataPubblicazioneGU; }
            set { _dataPubblicazioneGU = value; }
        }

        /// <summary>
        /// Gets or sets the data deposito RI.
        /// </summary>
        /// <value>The data deposito RI.</value>
        [Bindable(true)]
        public DateTime? DataDepositoRI
        {
            get { return _dataDepositoRI; }
            set { _dataDepositoRI = value; }
        }

        /// <summary>
        /// Gets or sets the data delibera giunta.
        /// </summary>
        /// <value>The data delibera giunta.</value>
        [Bindable(true)]
        public DateTime? DataDeliberaGiunta
        {
            get { return _dataDeliberaGiunta; }
            set { _dataDeliberaGiunta = value; }
        }

        /// <summary>
        /// Gets or sets the numero delibera giunta.
        /// </summary>
        /// <value>The numero delibera giunta.</value>
        [Bindable(true)]
        public string NumeroDeliberaGiunta
        {
            get { return _numeroDeliberaGiunta; }
            set { _numeroDeliberaGiunta = value; }
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
        /// Gets or sets the numero delibera revoca.
        /// </summary>
        /// <value>The numero delibera revoca.</value>
        [Bindable(true)]
        public string NumeroDeliberaRevoca
        {
            get { return _numeroDeliberaRevoca; }
            set { _numeroDeliberaRevoca = value; }
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
        /// Gets or sets the numero determina revoca.
        /// </summary>
        /// <value>The numero determina revoca.</value>
        [Bindable(true)]
        public string NumeroDeterminaRevoca
        {
            get { return _numeroDeterminaRevoca; }
            set { _numeroDeterminaRevoca = value; }
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
        /// Gets or sets the data fine processo teorica.
        /// </summary>
        /// <value>The data fine processo teorica.</value>
        //[Bindable(true)]
        //public DateTime DataFineProcessoTeorica
        //{
        //    get { return _dataFineProcessoTeorica; }
        //    set { _dataFineProcessoTeorica = value; }
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
        //public DateTime DataInizioProcesso
        //{
        //    get { return _dataInizioProcesso; }
        //    set { _dataInizioProcesso = value; }
        //}

        /// <summary>
        /// Gets or sets the id tipo liquidazione coatta.
        /// </summary>
        /// <value>The id tipo liquidazione coatta.</value>
        [Bindable(true)]
        public int IdTipoLiquidazioneCoatta
        {
            get { return _idTipoLiquidazioneCoatta; }
            set { _idTipoLiquidazioneCoatta = value; }
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
        /// Gets or sets the id liquidazione coatta.
        /// </summary>
        /// <value>The id liquidazione coatta.</value>
        [Bindable(true)]
        public int IdLiquidazioneCoatta
        {
            get { return _idLiquidazioneCoatta; }
            set { _idLiquidazioneCoatta = value; }
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

        public void AddAutorizzazione(AutorizzazioneFDT item)
        {
            if (Autorizzazioni == null)
                Autorizzazioni = new AutorizzazioneFDT[] { };

            List<AutorizzazioneFDT> lTemp = new List<AutorizzazioneFDT>(Autorizzazioni);
            lTemp.Add(item);
            Autorizzazioni = lTemp.ToArray();
        }

        public void RemoveAutorizzazione(AutorizzazioneFDT item)
        {
            if (Autorizzazioni != null)
            {
                List<AutorizzazioneFDT> lTemp = new List<AutorizzazioneFDT>(Autorizzazioni);

                if (lTemp.Remove(item))
                {
                    Autorizzazioni = lTemp.ToArray();
                }
            }
        }

        public void AddRelazioneSemestrale(RelazioneSemestraleFDT item)
        {
            if (RelazioniSemestrali == null)
                RelazioniSemestrali = new RelazioneSemestraleFDT[] { };

            List<RelazioneSemestraleFDT> lTemp = new List<RelazioneSemestraleFDT>(RelazioniSemestrali);
            lTemp.Add(item);
            RelazioniSemestrali = lTemp.ToArray();
        }

        public void RemoveRelazioneSemestrale(RelazioneSemestraleFDT item)
        {
            if (RelazioniSemestrali != null)
            {
                List<RelazioneSemestraleFDT> lTemp = new List<RelazioneSemestraleFDT>(RelazioniSemestrali);

                if (lTemp.Remove(item))
                {
                    RelazioniSemestrali = lTemp.ToArray();
                }
            }
        }

        public void AddDelibereAcquistoCreditiFisc(DeliberaAcquistoCreditiFiscFDT item)
        {
            if (DelibereAcquistoCreditiFisc == null)
                DelibereAcquistoCreditiFisc = new DeliberaAcquistoCreditiFiscFDT[] { };

            List<DeliberaAcquistoCreditiFiscFDT> lTemp = new List<DeliberaAcquistoCreditiFiscFDT>(DelibereAcquistoCreditiFisc);
            lTemp.Add(item);
            DelibereAcquistoCreditiFisc = lTemp.ToArray();
        }

        public void RemoveDelibereAcquistoCreditiFisc(DeliberaAcquistoCreditiFiscFDT item)
        {
            if (DelibereAcquistoCreditiFisc != null)
            {
                List<DeliberaAcquistoCreditiFiscFDT> lTemp = new List<DeliberaAcquistoCreditiFiscFDT>(DelibereAcquistoCreditiFisc);

                if (lTemp.Remove(item))
                {
                    DelibereAcquistoCreditiFisc = lTemp.ToArray();
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
            public const string IdTipoLiquidazioneCoatta = "IdTipoLiquidazioneCoatta";
        }

        #endregion PropertyNames Class

        #region IDXDataErrorInfo Members

        public void GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {

        }

        public void GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
            if ((propertyName == PropertyNames.IdTipoLiquidazioneCoatta && _idTipoLiquidazioneCoatta < 1))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }
        }

        #endregion
    }
}
