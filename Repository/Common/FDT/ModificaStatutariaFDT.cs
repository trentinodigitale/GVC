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
    public partial class ModificaStatutariaFDT : FDTBase, DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo
    {
        #region Instance Variables (15)

        private int _idModificaStatutaria;
        private int _idTipoModifica;
        private int _idAssemblea;
        private int _idNotaio;
        private DateTime? _dataInizioValidita;
        private String _vecchiaDenominazione;
        private String _nuovaDenominazione;
        private int _idVecchiaFormaGiuridica;
        private int _idNuovaFormaGiuridica;
        private DateTime? _vecchiaDurataDisplay;
        private DateTime? _nuovaDurata;
        private int _nuovaDurataIllimitata;
        private int _vecchiaDurataIllimitata;
        private DateTime? _vecchioBilancioEsercizioAl;
        private DateTime? _nuovoBilancioEsercizioAl;
        private DateTime? _dataAttoFusioneScissione;
        private DateTime? _dataEfficaciaAtto;
        private DateTime? _dataIscrizioneAtto;
        private int _idVecchioStatoIscrizione;
        private int _idNuovoStatoIscrizione;
        private String _note;
        private Boolean _aggiornaNrScioglimento;
        private DateTime? _dataUltimaModifica;
        private String _operatoreUltimaModifica;

        private SoggettoFDT _notaio;
        private CaricaSocialeFDT[] _liquidatori;

        //private SoggettoFDT _societaIncorporante;
        //private SoggettoFDT[] _societaCollegate;
        private CollegamentoSocietaFDT[] _societaCollegate;

        #endregion Instance Variables (15)

        #region Public Properties (15)

        /// <summary>
        /// Gets or sets the liquidatori.
        /// </summary>
        /// <value>The liquidatori.</value>
        [Bindable(true)]
        public CaricaSocialeFDT[] Liquidatori
        {
            get { return _liquidatori; }
            set { _liquidatori = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [aggiorna nr scioglimento].
        /// </summary>
        /// <value>
        /// 	<c>true</c> if [aggiorna nr scioglimento]; otherwise, <c>false</c>.
        /// </value>
        [Bindable(true)]
        public Boolean AggiornaNrScioglimento
        {
            get { return _aggiornaNrScioglimento; }
            set { _aggiornaNrScioglimento = value; }
        }

        /// <summary>
        /// Gets or sets the societa collegate.
        /// </summary>
        /// <value>The societa collegate.</value>
        [Bindable(true)]
        public CollegamentoSocietaFDT[] SocietaCollegate
        {
            get { return _societaCollegate; }
            set { _societaCollegate = value; }
        }

        /// <summary>
        /// Gets or sets the notaio.
        /// </summary>
        /// <value>The notaio.</value>
        [Bindable(true)]
        public SoggettoFDT Notaio
        {
            get { return _notaio; }
            set { _notaio = value; }
        }

        /// <summary>
        /// Gets or sets the societa incorporante.
        /// </summary>
        /// <value>The societa incorporante.</value>
        //[Bindable(true)]
        //public SoggettoFDT SocietaIncorporante
        //{
        //    get { return _societaIncorporante; }
        //    set { _societaIncorporante = value; }
        //}

        /// <summary>
        /// Gets or sets the id nuovo stato iscrizione.
        /// </summary>
        /// <value>The id nuovo stato iscrizione.</value>
        [Bindable(true)]
        public int IdNuovoStatoIscrizione
        {
            get { return _idNuovoStatoIscrizione; }
            set { _idNuovoStatoIscrizione = value; }
        }

        /// <summary>
        /// Gets or sets the id notaio.
        /// </summary>
        /// <value>The id notaio.</value>
        [Bindable(true)]
        public int IdNotaio
        {
            get { return _idNotaio; }
            set { _idNotaio = value; }
        }

        /// <summary>
        /// Gets or sets the id assemblea.
        /// </summary>
        /// <value>The id assemblea.</value>
        [Bindable(true)]
        public int IdAssemblea
        {
            get { return _idAssemblea; }
            set { _idAssemblea = value; }
        }

        /// <summary>
        /// Gets or sets the id vecchio stato iscrizione.
        /// </summary>
        /// <value>The id vecchio stato iscrizione.</value>
        [Bindable(true)]
        public int IdVecchioStatoIscrizione
        {
            get { return _idVecchioStatoIscrizione; }
            set { _idVecchioStatoIscrizione = value; }
        }

        /// <summary>
        /// Gets or sets the data iscrizione atto.
        /// </summary>
        /// <value>The data iscrizione atto.</value>
        [Bindable(true)]
        public DateTime? DataIscrizioneAtto
        {
            get { return _dataIscrizioneAtto; }
            set { _dataIscrizioneAtto = value; }
        }

        /// <summary>
        /// Gets or sets the data efficacia atto.
        /// </summary>
        /// <value>The data efficacia atto.</value>
        [Bindable(true)]
        public DateTime? DataEfficaciaAtto
        {
            get { return _dataEfficaciaAtto; }
            set { _dataEfficaciaAtto = value; }
        }

        /// <summary>
        /// Gets or sets the data atto fusione scissione.
        /// </summary>
        /// <value>The data atto fusione scissione.</value>
        [Bindable(true)]
        public DateTime? DataAttoFusioneScissione
        {
            get { return _dataAttoFusioneScissione; }
            set { _dataAttoFusioneScissione = value; }
        }

        /// <summary>
        /// Gets or sets the vecchio bilancio esercizio al.
        /// </summary>
        /// <value>The vecchio bilancio esercizio al.</value>
        [Bindable(true)]
        public DateTime? VecchioBilancioEsercizioAl
        {
            get { return _vecchioBilancioEsercizioAl; }
            set { _vecchioBilancioEsercizioAl = value; }
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
        /// Gets or sets the nuovo bilancio esercizio al.
        /// </summary>
        /// <value>The nuovo bilancio esercizio al.</value>
        [Bindable(true)]
        public DateTime? NuovoBilancioEsercizioAl
        {
            get { return _nuovoBilancioEsercizioAl; }
            set { _nuovoBilancioEsercizioAl = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [nuova durata illimitata].
        /// </summary>
        /// <value>
        /// 	<c>true</c> if [nuova durata illimitata]; otherwise, <c>false</c>.
        /// </value>
        [Bindable(true)]
        public int NuovaDurataIllimitata
        {
            get { return _nuovaDurataIllimitata; }
            set { _nuovaDurataIllimitata = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [vecchia durata illimitata].
        /// </summary>
        /// <value>
        /// 	<c>true</c> if [vecchia durata illimitata]; otherwise, <c>false</c>.
        /// </value>
        [Bindable(true)]
        public int VecchiaDurataIllimitata
        {
            get { return _vecchiaDurataIllimitata; }
            set { _vecchiaDurataIllimitata = value; }
        }

        /// <summary>
        /// Gets or sets the nuova durata.
        /// </summary>
        /// <value>The nuova durata.</value>
        [Bindable(true)]
        public DateTime? NuovaDurata
        {
            get { return _nuovaDurata; }
            set { _nuovaDurata = value; }
        }

        /// <summary>
        /// Gets or sets the vecchia durata display.
        /// </summary>
        /// <value>The vecchia durata display.</value>
        [Bindable(true)]
        public DateTime? VecchiaDurataDisplay
        {
            get { return _vecchiaDurataDisplay; }
            set { _vecchiaDurataDisplay = value; }
        }

        /// <summary>
        /// Gets or sets the id nuova forma giuridica.
        /// </summary>
        /// <value>The id nuova forma giuridica.</value>
        [Bindable(true)]
        public int IdNuovaFormaGiuridica
        {
            get { return _idNuovaFormaGiuridica; }
            set { _idNuovaFormaGiuridica = value; }
        }

        /// <summary>
        /// Gets or sets the id vecchia forma giuridica.
        /// </summary>
        /// <value>The id vecchia forma giuridica.</value>
        [Bindable(true)]
        public int IdVecchiaFormaGiuridica
        {
            get { return _idVecchiaFormaGiuridica; }
            set { _idVecchiaFormaGiuridica = value; }
        }

        /// <summary>
        /// Gets or sets the nuova denominazione.
        /// </summary>
        /// <value>The nuova denominazione.</value>
        [Bindable(true)]
        public string NuovaDenominazione
        {
            get { return _nuovaDenominazione; }
            set { _nuovaDenominazione = value; }
        }

        /// <summary>
        /// Gets or sets the vecchia denominazione.
        /// </summary>
        /// <value>The vecchia denominazione.</value>
        [Bindable(true)]
        public string VecchiaDenominazione
        {
            get { return _vecchiaDenominazione; }
            set { _vecchiaDenominazione = value; }
        }

        /// <summary>
        /// Gets or sets the data inizio validita.
        /// </summary>
        /// <value>The data inizio validita.</value>
        [Bindable(true)]
        public DateTime? DataInizioValidita
        {
            get { return _dataInizioValidita; }
            set { _dataInizioValidita = value; }
        }

        /// <summary>
        /// Gets or sets the id tipo modifica.
        /// </summary>
        /// <value>The id tipo modifica.</value>
        [Bindable(true)]
        public int IdTipoModifica
        {
            get { return _idTipoModifica; }
            set { _idTipoModifica = value; }
        }

        /// <summary>
        /// Gets or sets the id modifica statutaria.
        /// </summary>
        /// <value>The id modifica statutaria.</value>
        [Bindable(true)]
        public int IdModificaStatutaria
        {
            get { return _idModificaStatutaria; }
            set { _idModificaStatutaria = value; }
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

        public void AddCollegamentoSocieta(CollegamentoSocietaFDT item)
        {
            if (SocietaCollegate == null)
                SocietaCollegate = new CollegamentoSocietaFDT[] { };

            List<CollegamentoSocietaFDT> lTemp = new List<CollegamentoSocietaFDT>(SocietaCollegate);
            lTemp.Add(item);
            SocietaCollegate = lTemp.ToArray();
        }

        #region PropertyNames Class

        /// <summary>
        /// PropertyNames
        /// </summary>
        public partial class PropertyNames
        {
            public const string TipoModifica = "IdTipoModifica";
            public const string Denominazione = "NuovaDenominazione";
            public const string FormaGiuridica = "IdNuovaFormaGiuridica";
            public const string NuovoBilancio = "NuovoBilancioAl";
            public const string DataFusione = "DataAttoFusioneScissione";
            public const string DataIscrizione = "DataIscrizioneAtto";
            public const string DataEfficacia = "DataEfficaciaAtto";
            public const string Stato = "IdNuovoStatoIscrizione";
            public const string DataValidita = "DataInizioValidita";
        }

        #endregion PropertyNames Class

        #region IDXDataErrorInfo Members

        public void GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {

        }

        public void GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
         

            if ((propertyName == PropertyNames.TipoModifica && _idTipoModifica <= 0))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }

            if ((propertyName == PropertyNames.Stato && _idNuovoStatoIscrizione <= 0))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }

            if ((propertyName == PropertyNames.FormaGiuridica && _idNuovaFormaGiuridica <= 0))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }

            if ((propertyName == PropertyNames.Denominazione && String.IsNullOrEmpty(_nuovaDenominazione)))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }

            if ((propertyName == PropertyNames.NuovoBilancio && (_nuovoBilancioEsercizioAl == DateTime.MinValue || _nuovoBilancioEsercizioAl == DateTime.MaxValue)))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }

            //if ((propertyName == PropertyNames.DataEfficacia && (_dataEfficaciaAtto == null || _dataEfficaciaAtto == DateTime.MinValue || _dataEfficaciaAtto == DateTime.MaxValue)))
            //{
            //    info.ErrorText = "Campo obbligatorio";
            //    info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            //}

            //if ((propertyName == PropertyNames.DataFusione && (_dataAttoFusioneScissione == null || _dataAttoFusioneScissione == DateTime.MinValue || _dataAttoFusioneScissione == DateTime.MaxValue)))
            //{
            //    info.ErrorText = "Campo obbligatorio";
            //    info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            //}

            //if ((propertyName == PropertyNames.DataIscrizione && (_dataIscrizioneAtto == null || _dataIscrizioneAtto == DateTime.MinValue || _dataIscrizioneAtto == DateTime.MaxValue)))
            //{
            //    info.ErrorText = "Campo obbligatorio";
            //    info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            //}

            //if ((propertyName == PropertyNames.DataValidita && (_dataInizioValidita == DateTime.MinValue || _dataInizioValidita == DateTime.MaxValue)))
            //{
            //    info.ErrorText = "Campo obbligatorio";
            //    info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            //}
        }

        #endregion
    }
}
