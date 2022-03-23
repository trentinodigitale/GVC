using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.RicercheWrapper
{
    [Serializable]
    public partial class CompensoCommissarioRicercaFDT
    {

        private string _revisore;
        private double _percentualeCNP;
        private double _percentualeIVA;
        private double _importoCompenso;
        private double _importoSpese;
        private double _importoCassa;
        private double _importoIVA;
        private double _importoTotale;


        public string Revisore
        {
            get { return _revisore; }
            set { _revisore = value; }
        }

        public double ImportoTotale
        {
            get { return _importoTotale; }
            set { _importoTotale = value; }
        }

        public double ImportoIVA
        {
            get { return _importoIVA; }
            set { _importoIVA = value; }
        }

        public double ImportoCassa
        {
            get { return _importoCassa; }
            set { _importoCassa = value; }
        }

        public double ImportoSpese
        {
            get { return _importoSpese; }
            set { _importoSpese = value; }
        }

        public double ImportoCompenso
        {
            get { return _importoCompenso; }
            set { _importoCompenso = value; }
        }

        public double PercentualeIVA
        {
            get { return _percentualeIVA; }
            set { _percentualeIVA = value; }
        }

        public double PercentualeCNP
        {
            get { return _percentualeCNP; }
            set { _percentualeCNP = value; }
        }
    }
}
