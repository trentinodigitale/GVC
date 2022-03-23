using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace it.dedagroup.GVC.Repository.Common.FDT
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public partial class AggiornamentoFDT : FDTBase
    {
        #region Instance Variables (14)

        private int _idAggiornamento;

        [Bindable(true)]
        public int IdAggiornamento
        {
            get { return _idAggiornamento; }
            set { _idAggiornamento = value; }
        }

        private String _trackingId;

        [Bindable(true)]
        public String TrackingId
        {
            get { return _trackingId; }
            set { _trackingId = value; }
        }
        
        private DateTime _dataInserimento;
        
        [Bindable(true)]
        public DateTime DataInserimento
        {
            get { return _dataInserimento; }
            set { _dataInserimento = value; }
        }
        
        private DateTime _dataAggiornamento;
        [Bindable(true)]
        public DateTime DataAggiornamento
        {
            get { return _dataAggiornamento; }
            set { _dataAggiornamento = value; }
        }
        
        private String _codiceFiscale;
        [Bindable(true)]
        public String CodiceFiscale
        {
            get { return _codiceFiscale; }
            set { _codiceFiscale = value; }
        }

        private String _denominazione;
        [Bindable(true)]
        public String Denominazione
        {
            get { return _denominazione; }
            set { _denominazione = value; }
        }

        private String _numeroRI;
        [Bindable(true)]
        public String NumeroRI
        {
            get { return _numeroRI; }
            set { _numeroRI = value; }
        }

        private String _cciaaRegZ;
        [Bindable(true)]
        public String CciaaRegZ
        {
            get { return _cciaaRegZ; }
            set { _cciaaRegZ = value; }
        }

        private int _numeroRea;
        [Bindable(true)]
        public int NumeroRea
        {
            get { return _numeroRea; }
            set { _numeroRea = value; }
        }
        
        private DateTime _dataInscrizione;
        [Bindable(true)]
        public DateTime DataInscrizione
        {
            get { return _dataInscrizione; }
            set { _dataInscrizione = value; }
        }

        private CooperativaFDT _cooperativa;
        [Bindable(true)]
        public CooperativaFDT Cooperativa
        {
            get { return _cooperativa; }
            set { _cooperativa = value; }
        }

        private byte[] _cooperativaByte;
        [Bindable(true)]
        public byte[] CooperativaByte
        {
            get { return _cooperativaByte; }
            set { _cooperativaByte = value; }
        }

        private String _naturaGiuridica;
        [Bindable(true)]
        public String NaturaGiuridica
        {
            get { return _naturaGiuridica; }
            set { _naturaGiuridica = value; }
        }

        private DateTime _dataAllineamentoGvc;
        [Bindable(true)]
        public DateTime DataAllineamentoGvc
        {
            get { return _dataAllineamentoGvc; }
            set { _dataAllineamentoGvc = value; }
        }


        #endregion Instance Variables
    }
}
