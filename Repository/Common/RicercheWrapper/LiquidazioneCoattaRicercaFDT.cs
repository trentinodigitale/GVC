using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.RicercheWrapper
{
    [Serializable]
    public class LiquidazioneCoattaRicercaFDT
    {

        private int _idTipoLiquidazioneCoatta;
        private String _numeroDetermina;
        private DateTime? _dataDetermina;
        private String _numeroDeliberaCommissione;
        private DateTime? _dataDeliberaCommissione;
        private String _numeroDeliberaGiunta;
        private DateTime? _dataDeliberaGiunta;
        private DateTime? _dataPubblicazioneGU;
        private DateTime? _dataDepositoRI;
        private DateTime? _dataSentenzaInsolvenza;        
        private Boolean _depositoBFL;
        private Boolean _proceduraRevocata;
        private Boolean _proceduraTerminata;

        private List<CompensoCommissarioRicercaFDT> _compensiCommissari;
        private List<RelazioneSemestraleRicercaFDT> _relazioniSemestrali;
        private List<AutorizzazioneRicercaFDT> _autorizzazioni;
        private List<CompensoLiquidazioneRicercaFDT> _liquidazioneSpeseProcedure;
        private List<DeliberaAcquistoCreditiFiscRicercaFDT> _acquistoCreditiFiscali;

        public List<DeliberaAcquistoCreditiFiscRicercaFDT> AcquistoCreditiFiscali
        {
            get { return _acquistoCreditiFiscali; }
            set { _acquistoCreditiFiscali = value; }
        }

        public List<CompensoCommissarioRicercaFDT> CompensiCommissari
        {
            get { return _compensiCommissari; }
            set { _compensiCommissari = value; }
        }

        public List<AutorizzazioneRicercaFDT> Autorizzazioni
        {
            get { return _autorizzazioni; }
            set { _autorizzazioni = value; }
        }

        public List<RelazioneSemestraleRicercaFDT> RelazioniSemestrali
        {
            get { return _relazioniSemestrali; }
            set { _relazioniSemestrali = value; }
        }

        public List<CompensoLiquidazioneRicercaFDT> LiquidazioneSpeseProcedure
        {
            get { return _liquidazioneSpeseProcedure; }
            set { _liquidazioneSpeseProcedure = value; }
        }

        public Boolean ProceduraTerminata
        {
            get { return _proceduraTerminata; }
            set { _proceduraTerminata = value; }
        }

        public Boolean ProceduraRevocata
        {
            get { return _proceduraRevocata; }
            set { _proceduraRevocata = value; }
        }

        public Boolean DepositoBFL
        {
            get { return _depositoBFL; }
            set { _depositoBFL = value; }
        }

        public DateTime? DataSentenzaInsolvenza
        {
            get { return _dataSentenzaInsolvenza; }
            set { _dataSentenzaInsolvenza = value; }
        }

        public DateTime? DataPubblicazioneGU
        {
            get { return _dataPubblicazioneGU; }
            set { _dataPubblicazioneGU = value; }
        }

        public DateTime? DataDepositoRI
        {
            get { return _dataDepositoRI; }
            set { _dataDepositoRI = value; }
        }

        public DateTime? DataDeliberaGiunta
        {
            get { return _dataDeliberaGiunta; }
            set { _dataDeliberaGiunta = value; }
        }

        public string NumeroDeliberaGiunta
        {
            get { return _numeroDeliberaGiunta; }
            set { _numeroDeliberaGiunta = value; }
        }

        public DateTime? DataDeliberaCommissione
        {
            get { return _dataDeliberaCommissione; }
            set { _dataDeliberaCommissione = value; }
        }

        public string NumeroDeliberaCommissione
        {
            get { return _numeroDeliberaCommissione; }
            set { _numeroDeliberaCommissione = value; }
        }

        public DateTime? DataDetermina
        {
            get { return _dataDetermina; }
            set { _dataDetermina = value; }
        }

        public string NumeroDetermina
        {
            get { return _numeroDetermina; }
            set { _numeroDetermina = value; }
        }

        public int IdTipoLiquidazioneCoatta
        {
            get { return _idTipoLiquidazioneCoatta; }
            set { _idTipoLiquidazioneCoatta = value; }
        }


    }
}
