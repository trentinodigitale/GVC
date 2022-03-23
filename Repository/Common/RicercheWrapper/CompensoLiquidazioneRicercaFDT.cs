using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.RicercheWrapper
{
    [Serializable]
    public partial class CompensoLiquidazioneRicercaFDT
    {
        private DateTime? _dataRicevimentoDomanda;
        private double _importoDeterminato;
        private double _importoErogato;
        private String _numeroDetermina;
        private DateTime? _dataDetermina;
        private Boolean _liquidato;
        private String _numeroMandatoPagamento;
        private DateTime? _dataMandatoPagamento;
        private double _importoSpeseBFL;
        
        public double ImportoSpeseBFL
        {
            get { return _importoSpeseBFL; }
            set { _importoSpeseBFL = value; }
        }

        public DateTime? DataMandatoPagamento
        {
            get { return _dataMandatoPagamento; }
            set { _dataMandatoPagamento = value; }
        }

        public string NumeroMandatoPagamento
        {
            get { return _numeroMandatoPagamento; }
            set { _numeroMandatoPagamento = value; }
        }

        public Boolean Liquidato
        {
            get { return _liquidato; }
            set { _liquidato = value; }
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

        public double ImportoErogato
        {
            get { return _importoErogato; }
            set { _importoErogato = value; }
        }

        public double ImportoDeterminato
        {
            get { return _importoDeterminato; }
            set { _importoDeterminato = value; }
        }

        public DateTime? DataRicevimentoDomanda
        {
            get { return _dataRicevimentoDomanda; }
            set { _dataRicevimentoDomanda = value; }
        }

    }
}
