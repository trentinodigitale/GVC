using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using it.dedagroup.GVC.Repository.Common.FDT;

namespace it.dedagroup.GVC.Repository.Common.RicercheWrapper
{
    [Serializable]
    public partial class RevisioneCooperativaFlatFDT
    {
        private String _denominazione;
        private int _idRegistro;
        private int _idSoggetto;
        private String _numeroREA;
        private int _idCadenzaRevisione;
        private int _idStatoIscrizione;
        private Boolean _soggettaRevisione;
        private Boolean _revisioneStraordinaria;

        private int _idRevisione;
        private int _idTipoRevisione;
        private int _idEsitoRevisione;
        private String _organoRevisore;
        private int _annoRevisione;
        private DateTime? _dataConclusione;
        private DateTime? _dataDepositoRelazione;
        private String _numeroDeterminaRevoca;
        private DateTime? _dataDeterminaRevoca;
        private DateTime? _dataDeliberaRevoca;

        private Double _importoImpegno;
        private String _revisore;

        public String Denominazione
        {
            get { return _denominazione; }
            set { _denominazione = value; }
        }

        public int IdRegistro
        {
            get { return _idRegistro; }
            set { _idRegistro = value; }
        }

        public Boolean SoggettaRevisione
        {
            get { return _soggettaRevisione; }
            set { _soggettaRevisione = value; }
        }

        public Boolean RevisioneStraordinaria
        {
            get { return _revisioneStraordinaria; }
            set { _revisioneStraordinaria = value; }
        }

        public int IdSoggetto
        {
            get { return _idSoggetto; }
            set { _idSoggetto = value; }
        }

        public String NumeroREA
        {
            get { return _numeroREA; }
            set { _numeroREA = value; }
        }

        public int IdCadenzaRevisione
        {
            get { return _idCadenzaRevisione; }
            set { _idCadenzaRevisione = value; }
        }

        public int IdStatoIscrizione
        {
            get { return _idStatoIscrizione; }
            set { _idStatoIscrizione = value; }
        }

        public int AnnoRevisione
        {
            get { return _annoRevisione; }
            set { _annoRevisione = value; }
        }

        public int IdRevisione
        {
            get { return _idRevisione; }
            set { _idRevisione = value; }
        }

        public int IdEsitoRevisione
        {
            get { return _idEsitoRevisione; }
            set { _idEsitoRevisione = value; }
        }


        public String OrganoRevisore
        {
            get { return _organoRevisore; }
            set { _organoRevisore = value; }
        }


        public int IdTipoRevisione
        {
            get { return _idTipoRevisione; }
            set { _idTipoRevisione = value; }
        }

        public DateTime? DataConclusione
        {
            get { return _dataConclusione; }
            set { _dataConclusione = value; }
        }

        public DateTime? DataDepositoRelazione
        {
            get { return _dataDepositoRelazione; }
            set { _dataDepositoRelazione = value; }
        }

        public String NumeroDeterminaRevoca
        {
            get { return _numeroDeterminaRevoca; }
            set { _numeroDeterminaRevoca = value; }
        }

        public DateTime? DataDeterminaRevoca
        {
            get { return _dataDeterminaRevoca; }
            set { _dataDeterminaRevoca = value; }
        }

        public DateTime? DataDeliberaRevoca
        {
            get { return _dataDeliberaRevoca; }
            set { _dataDeliberaRevoca = value; }
        }

        public Double ImportoImpegno
        {
            get { return _importoImpegno; }
            set { _importoImpegno = value; }
        }

        public String Revisore
        {
            get { return _revisore; }
            set { _revisore = value; }
        }
    }
}
