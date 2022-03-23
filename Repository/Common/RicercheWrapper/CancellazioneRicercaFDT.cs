using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.RicercheWrapper
{
    [Serializable]
    public partial class CancellazioneRicercaFDT
    {
        private String _numeroDetermina;
        private DateTime? _dataDetermina;
        private int _idTipoCancellazione;
        private String _tipoCancellazione;
        private string _note;

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

        public string TipoCancellazione
        {
            get { return _tipoCancellazione; }
            set { _tipoCancellazione = value; }
        }

        public int IdTipoCancellazione
        {
            get { return _idTipoCancellazione; }
            set { _idTipoCancellazione = value; }
        }

        public string Note
        {
            get { return _note; }
            set { _note = value; }
        }
    }
}
