using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace it.dedagroup.GVC.Repository.Common.RicercheWrapper
{
    [Serializable]
    public partial class RelazioneSemestraleRicercaFDT
    {

        private DateTime? _dataRelazione;
        private DateTime? _dataEsitoCommissione;
        private DateTime? _dataEsameufficio;
        private String _note;


        public string Note
        {
            get { return _note; }
            set { _note = value; }
        }

        public DateTime? DataEsameufficio
        {
            get { return _dataEsameufficio; }
            set { _dataEsameufficio = value; }
        }

        public DateTime? DataEsitoCommissione
        {
            get { return _dataEsitoCommissione; }
            set { _dataEsitoCommissione = value; }
        }

        public DateTime? DataRelazione
        {
            get { return _dataRelazione; }
            set { _dataRelazione = value; }
        }
    }
}
