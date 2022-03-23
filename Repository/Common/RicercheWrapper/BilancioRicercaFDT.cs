using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.RicercheWrapper
{
    [Serializable]
    public partial class BilancioRicercaFDT
    {
        private int _anno;
        private int _idTipoBilancio;
        private DateTime? _dataEsercizio;
        private DateTime? _dataDepositoBilancioRI;
        private DateTime? _dataSegnalazioneRevisoreLegale;
        private double _importoPercUtili;
        private double _importoPatrimonio;
        private int _pagamento;
        private int _requisitiPrevalenzaRapportiSoci;
        private String _note;

        public double ImportoPatrimonio
        {
            get { return _importoPatrimonio; }
            set { _importoPatrimonio = value; }
        }

        public int RequisitiPrevalenzaRapportiSoci
        {
            get { return _requisitiPrevalenzaRapportiSoci; }
            set { _requisitiPrevalenzaRapportiSoci = value; }
        }

        public int Pagamento
        {
            get { return _pagamento; }
            set { _pagamento = value; }
        }

        public string Note
        {
            get { return _note; }
            set { _note = value; }
        }

        public double ImportoPercUtili
        {
            get { return _importoPercUtili; }
            set { _importoPercUtili = value; }
        }

        public int IdTipoBilancio
        {
            get { return _idTipoBilancio; }
            set { _idTipoBilancio = value; }
        }

        public DateTime? DataEsercizio
        {
            get { return _dataEsercizio; }
            set { _dataEsercizio = value; }
        }

        public DateTime? DataDepositoBilancioRI
        {
            get { return _dataDepositoBilancioRI; }
            set { _dataDepositoBilancioRI = value; }
        }

        public DateTime? DataSegnalazioneRevisoreLegale
        {
            get { return _dataSegnalazioneRevisoreLegale; }
            set { _dataSegnalazioneRevisoreLegale = value; }
        }

        public int Anno
        {
            get { return _anno; }
            set { _anno = value; }
        }
    }
}
