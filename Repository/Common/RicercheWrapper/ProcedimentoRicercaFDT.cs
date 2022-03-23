using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.RicercheWrapper
{
    [Serializable]
    public partial class ProcedimentoRicercaFDT
    {
        private int _idTipoProcedimento;
        private DateTime? _dataInizioProcedimento;

        private DateTime? _dataFineTeorica;
        private int _idTipoSospensione;
        
        private DateTime? _dataRiattivazione;

        private int _idTipoConclusione;
        private DateTime? _dataTermineFinale;
        private DateTime? _dataConclusione;

        private String _stato;

        public String Stato
        {
            get { return _stato; }
            set { _stato = value; }
        }

        public int IdTipoProcedimento
        {
            get { return _idTipoProcedimento; }
            set { _idTipoProcedimento = value; }
        }

        public DateTime? DataInizioProcedimento
        {
            get { return _dataInizioProcedimento; }
            set { _dataInizioProcedimento = value; }
        }

        public DateTime? DataFineTeorica
        {
            get { return _dataFineTeorica; }
            set { _dataFineTeorica = value; }
        }

        public int IdTipoSospensione
        {
            get { return _idTipoSospensione; }
            set { _idTipoSospensione = value; }
        }

        public DateTime? DataRiattivazione
        {
            get { return _dataRiattivazione; }
            set { _dataRiattivazione = value; }
        }

        public DateTime? DataTermineFinale
        {
            get { return _dataTermineFinale; }
            set { _dataTermineFinale = value; }
        }

        public int IdTipoConclusione
        {
            get { return _idTipoConclusione; }
            set { _idTipoConclusione = value; }
        }

        public DateTime? DataConclusione
        {
            get { return _dataConclusione; }
            set { _dataConclusione = value; }
        }
    }
}
