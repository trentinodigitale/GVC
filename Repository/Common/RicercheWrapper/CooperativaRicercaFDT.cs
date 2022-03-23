using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using it.dedagroup.GVC.Repository.Common.FDT;

namespace it.dedagroup.GVC.Repository.Common.RicercheWrapper
{
    [Serializable]
    public partial class CooperativaRicercaFDT
    {
        private String _denominazione;
        private int _idRegistro;
        private int _idSoggetto;
        private String _numeroREA;
        private int _idCadenzaRevisione;
        private int _idStatoIscrizione;
        private Boolean _soggettaRevisione;
        private Boolean _revisioneStraordinaria;
        private DateTime? _bilancioEsercizioAl;
        private String _adesionHeader;
        private String _iscrizioneHeader;
        private int _idAssociazioneAderenza;
        private String _codiceFiscale;
        private DateTime? _dataIscrizioneRI;
        private String _numeroRI;
        private DateTime? _dataCancellazioneRINazionale;
        private DateTime? _dataCancellazioneRIRegistro;
        private double _numeroReaNumeric;
        private Boolean _dirigente;
        private Boolean _cancellata;
        private int _nrScioglimento;

        private List<RevisioneRicercaFDT> _revisioni;
        private List<AssembleaRicercaFDT> _assemblee;
        private List<ProceduraCoattaRicercaFDT> _procedureCoatte;
        private List<LiquidazioneCoattaRicercaFDT> _liquidazioniCoatte;
        private List<ProcedimentoRicercaFDT> _procedimenti;
        private List<ScadenziarioRicercaFDT> _scadenzaAnnotazioni;
        private List<DocumentazioneRicercaFDT> _documentazioni;
        private List<BilancioRicercaFDT> _bilanci;
        private List<FallimentoRicercaFDT> _fallimenti;
        private List<SanzioneRicercaFDT> _sanzioni;
        private List<CancellazioneRicercaFDT> _cancellazioni;
        private List<SegnalazioneFDT> _segnalazioni;

        

         public String AdesionHeader
        {
            get { return _adesionHeader; }
            set { _adesionHeader = value; }
        }

         public String IscrizioneHeader
         {
             get { return _iscrizioneHeader; }
             set { _iscrizioneHeader = value; }
         }

        public DateTime? BilancioEsercizioAl
        {
            get { return _bilancioEsercizioAl; }
            set { _bilancioEsercizioAl = value; }
        }

        public String Denominazione
        {
            get { return _denominazione; }
            set { _denominazione = value; }
        }

        public int IdRegistro
        {
            get { return _idRegistro; }
            set { _idRegistro = value; }
        }

        public Boolean SoggettaRevisione
        {
            get { return _soggettaRevisione; }
            set { _soggettaRevisione = value; }
        }

        public Boolean RevisioneStraordinaria
        {
            get { return _revisioneStraordinaria; }
            set { _revisioneStraordinaria = value; }
        }

        public int IdSoggetto
        {
            get { return _idSoggetto; }
            set { _idSoggetto = value; }
        }

        public String NumeroREA
        {
            get { return _numeroREA; }
            set { _numeroREA = value; }
        }

        public List<RevisioneRicercaFDT> Revisioni
        {
            get { return _revisioni; }
            set { _revisioni = value; }
        }

        public List<AssembleaRicercaFDT> Assemblee
        {
            get { return _assemblee; }
            set { _assemblee = value; }
        }

        public List<ProceduraCoattaRicercaFDT> ProcedureCoatte
        {
            get { return _procedureCoatte; }
            set { _procedureCoatte = value; }
        }

        public List<LiquidazioneCoattaRicercaFDT> LiquidazioniCoatte
        {
            get { return _liquidazioniCoatte; }
            set { _liquidazioniCoatte = value; }
        }

        public List<ScadenziarioRicercaFDT> ScadenzaAnnotazioni
        {
            get { return _scadenzaAnnotazioni; }
            set { _scadenzaAnnotazioni = value; }
        }

        public int IdCadenzaRevisione
        {
            get { return _idCadenzaRevisione; }
            set { _idCadenzaRevisione = value; }
        }

        public int IdStatoIscrizione
        {
            get { return _idStatoIscrizione; }
            set { _idStatoIscrizione = value; }
        }

        public List<ProcedimentoRicercaFDT> Procedimenti
        {
            get { return _procedimenti; }
            set { _procedimenti = value; }
        }

        public List<DocumentazioneRicercaFDT> Documentazioni
        {
            get { return _documentazioni; }
            set { _documentazioni = value; }
        }

        public List<BilancioRicercaFDT> Bilanci
        {
            get { return _bilanci; }
            set { _bilanci = value; }
        }

        public List<FallimentoRicercaFDT> Fallimenti
        {
            get { return _fallimenti; }
            set { _fallimenti = value; }
        }

        public List<SanzioneRicercaFDT> Sanzioni
        {
            get { return _sanzioni; }
            set { _sanzioni = value; }
        }

        public List<CancellazioneRicercaFDT> Cancellazioni
        {
            get { return _cancellazioni; }
            set { _cancellazioni = value; }
        }

        public List<SegnalazioneFDT> Segnalazioni
        {
            get { return _segnalazioni; }
            set { _segnalazioni = value; }
        }
        
        public int IdAssociazioneAderenza
        {
            get { return _idAssociazioneAderenza; }
            set { _idAssociazioneAderenza = value; }
        }

        public String CodiceFiscale
        {
            get { return _codiceFiscale; }
            set { _codiceFiscale = value; }
        }
        public DateTime? DataIscrizioneRI
        {
            get { return _dataIscrizioneRI; }
            set { _dataIscrizioneRI = value; }
        }

        public String NumeroRI
        {
            get { return _numeroRI; }
            set { _numeroRI = value; }
        }

        public DateTime? DataCancellazioneRINazionale
        {
            get { return _dataCancellazioneRINazionale; }
            set { _dataCancellazioneRINazionale = value; }
        }

        public DateTime? DataCancellazioneRIRegistro
        {
            get { return _dataCancellazioneRIRegistro; }
            set { _dataCancellazioneRIRegistro = value; }
        }

        public double NumeroReaNumeric
        {
            get { return _numeroReaNumeric; }
            set { _numeroReaNumeric = value; }
        }

        public Boolean Dirigente
        {
            get { return _dirigente; }
            set { _dirigente = value; }
        }

        public Boolean Cancellata
        {
            get { return _cancellata; }
            set { _cancellata = value; }
        }

        public int NrScioglimento
        {
            get { return _nrScioglimento; }
            set { _nrScioglimento = value; }
        }
    }
}
