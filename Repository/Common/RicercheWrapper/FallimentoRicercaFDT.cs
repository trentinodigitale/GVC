using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.RicercheWrapper
{
    [Serializable]
    public partial class FallimentoRicercaFDT
    {
        private DateTime _dataSentenza;
        private String _tribunale;
        private String _curatore;
        private int _esito;
        private DateTime? _dataFineProcedura;

        public String Curatore
        {
            get { return _curatore; }
            set { _curatore = value; }
        }

        public int Esito
        {
            get { return _esito; }
            set { _esito = value; }
        }

        public String Tribunale
        {
            get { return _tribunale; }
            set { _tribunale = value; }
        }

        public DateTime DataSentenza
        {
            get { return _dataSentenza; }
            set { _dataSentenza = value; }
        }

        public DateTime? DataFineProcedura
        {
            get { return _dataFineProcedura; }
            set { _dataFineProcedura = value; }
        }
    }
}
