using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.RicercheWrapper
{
    [Serializable]
    public partial class RevisioneRicercaFDT
    {
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

        private List<CompensoRicercaFDT> _compensi;
        private List<CompensoLiquidazioneRicercaFDT> _liquidazioni;

     
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

        public List<CompensoRicercaFDT> Compensi
        {
            get { return _compensi; }
            set { _compensi = value; }
        }

        public List<CompensoLiquidazioneRicercaFDT> Liquidazioni
        {
            get { return _liquidazioni; }
            set { _liquidazioni = value; }
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
    }
}
