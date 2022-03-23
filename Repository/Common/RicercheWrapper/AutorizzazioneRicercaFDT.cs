using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.RicercheWrapper
{
    [Serializable]
    public partial class AutorizzazioneRicercaFDT
    {
        private int _idTipoAutorizzazione;
        private String _descrizioneDatoStorico;
        private DateTime? _dataIstanza;
        private String _numeroDeliberaCommissione;
        private DateTime? _dataDeliberaCommissione;
        private String _numeroDetermina;
        private DateTime? _dataDetermina;
        private String _note;

        public string Note
        {
            get { return _note; }
            set { _note = value; }
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

        public DateTime? DataIstanza
        {
            get { return _dataIstanza; }
            set { _dataIstanza = value; }
        }

        public string DescrizioneDatoStorico
        {
            get { return _descrizioneDatoStorico; }
            set { _descrizioneDatoStorico = value; }
        }

        public int IdTipoAutorizzazione
        {
            get { return _idTipoAutorizzazione; }
            set { _idTipoAutorizzazione = value; }
        }

    }
}
