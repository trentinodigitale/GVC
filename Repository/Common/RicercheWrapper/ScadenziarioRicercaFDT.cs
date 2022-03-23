using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.RicercheWrapper
{
    [Serializable]
    public partial class ScadenziarioRicercaFDT
    {
        private int _idTipoScadenziario;
        private DateTime _dataAnnotazione;
        private Boolean _riservataUfficio;
        private String _descrizione;
        private Boolean _evasa;
        private DateTime? _dataScadenza;
        private DateTime? _dataEvasione;

        public DateTime DataAnnotazione
        {
            get { return _dataAnnotazione; }
            set { _dataAnnotazione = value; }
        }

        public int IdTipoScadenziario
        {
            get { return _idTipoScadenziario; }
            set { _idTipoScadenziario = value; }
        }

        public Boolean RiservataUfficio
        {
            get { return _riservataUfficio; }
            set { _riservataUfficio = value; }
        }

        public String Descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
        }

        public Boolean Evasa
        {
            get { return _evasa; }
            set { _evasa = value; }
        }

        public DateTime? DataScadenza
        {
            get { return _dataScadenza; }
            set { _dataScadenza = value; }
        }

        public DateTime? DataEvasione
        {
            get { return _dataEvasione; }
            set { _dataEvasione = value; }
        }
    }
}
