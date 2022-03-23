using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.RicercheWrapper
{
    [Serializable]
    public partial class DeliberaAcquistoCreditiFiscRicercaFDT
    {

        private String _numeroDelibera;
        private DateTime? _dataDelibera;        
        private double _importo;

        public double Importo
        {
            get { return _importo; }
            set { _importo = value; }
        }

        public DateTime? DataDelibera
        {
            get { return _dataDelibera; }
            set { _dataDelibera = value; }
        }

        public string NumeroDelibera
        {
            get { return _numeroDelibera; }
            set { _numeroDelibera = value; }
        }
    }
}
