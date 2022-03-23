using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.RicercheWrapper
{
    [Serializable]
    public partial class SanzioneRicercaFDT
    {
        private int _idNaturaTrasgressione;
        private DateTime _dataRilievoInfrazione;
        private DateTime? _dataScrittiDifensivi;
        private DateTime? _dataAudizione;
        private DateTime? _dataPagamentoOblazione;
        private Double _importoOrdinanza;
        private DateTime? _dataArchiviazione;
        private DateTime? _dataRicorso;

        public DateTime DataRilievoInfrazione
        {
            get { return _dataRilievoInfrazione; }
            set { _dataRilievoInfrazione = value; }
        }

        public int NaturaTrasgressione
        {
            get { return _idNaturaTrasgressione; }
            set { _idNaturaTrasgressione = value; }
        }

        public DateTime? DataAudizione
        {
            get { return _dataAudizione; }
            set { _dataAudizione = value; }
        }

        public DateTime? DataScrittiDifensivi
        {
            get { return _dataScrittiDifensivi; }
            set { _dataScrittiDifensivi = value; }
        }

        public DateTime? DataPagamentoOblazione
        {
            get { return _dataPagamentoOblazione; }
            set { _dataPagamentoOblazione = value; }
        }

        public Double ImportoOrdinanza
        {
            get { return _importoOrdinanza; }
            set { _importoOrdinanza = value; }
        }

        public DateTime? DataRicorso
        {
            get { return _dataRicorso; }
            set { _dataRicorso = value; }
        }

        public DateTime? DataArchiviazione
        {
            get { return _dataArchiviazione; }
            set { _dataArchiviazione = value; }
        }
    }
}
