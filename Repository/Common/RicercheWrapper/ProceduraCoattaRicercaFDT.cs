using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.RicercheWrapper
{
    [Serializable]
    public partial class ProceduraCoattaRicercaFDT
    {

        private int _idTipoProceduraCoatta;
        private String _numeroDetermina;
        private DateTime? _dataDetermina;
        private String _numeroDeliberaCommissione;
        private DateTime? _dataDeliberaCommissione;
        private DateTime? _dataInzioProcedura;
        private DateTime? _dataIscrizioneRI;
        private DateTime? _dataScadenzaProcedura;
        private DateTime? _dataFineProcedura;
        private String _numeroDeterminaFineIncarico;
        private DateTime? _dataDeterminaFineIncarico;
        private String _numeroDeliberaCommissioneFineIncarico;
        private DateTime? _dataDeliberaCommissioneFineIncarico;


        private List<ProrogaRicercaFDT> _proroghe;
        private List<CompensoCommissarioRicercaFDT> _compensiCommissari;
        private List<CompensoLiquidazioneRicercaFDT> _liquidazioni;

        public List<ProrogaRicercaFDT> Proroghe
        {
            get { return _proroghe; }
            set { _proroghe = value; }
        }

        public List<CompensoCommissarioRicercaFDT> CompensiCommissari
        {
            get { return _compensiCommissari; }
            set { _compensiCommissari = value; }
        }

        public List<CompensoLiquidazioneRicercaFDT> Liquidazioni
        {
            get { return _liquidazioni; }
            set { _liquidazioni = value; }
        }


        public int IdTipoProceduraCoatta
        {
            get { return _idTipoProceduraCoatta; }
            set { _idTipoProceduraCoatta = value; }
        }

        public string NumeroDetermina
        {
            get { return _numeroDetermina; }
            set { _numeroDetermina = value; }
        }

        public DateTime? DataDetermina
        {
            get { return _dataDetermina; }
            set { _dataDetermina = value; }
        }

        public string NumeroDeliberaCommissione
        {
            get { return _numeroDeliberaCommissione; }
            set { _numeroDeliberaCommissione = value; }
        }

        public DateTime? DataDeliberaCommissione
        {
            get { return _dataDeliberaCommissione; }
            set { _dataDeliberaCommissione = value; }
        }

        public DateTime? DataInzioProcedura
        {
            get { return _dataInzioProcedura; }
            set { _dataInzioProcedura = value; }
        }

        public DateTime? DataIscrizioneRI
        {
            get { return _dataIscrizioneRI; }
            set { _dataIscrizioneRI = value; }
        }

        public DateTime? DataScadenzaProcedura
        {
            get { return _dataScadenzaProcedura; }
            set { _dataScadenzaProcedura = value; }
        }

        public DateTime? DataFineProcedura
        {
            get { return _dataFineProcedura; }
            set { _dataFineProcedura = value; }
        }
                
        public string NumeroDeterminaFineIncarico
        {
            get { return _numeroDeterminaFineIncarico; }
            set { _numeroDeterminaFineIncarico = value; }
        }

        public DateTime? DataDeterminaFineIncarico
        {
            get { return _dataDeterminaFineIncarico; }
            set { _dataDeterminaFineIncarico = value; }
        }

        public String NumeroDeliberaCommissioneFineIncarico
        {
            get { return _numeroDeliberaCommissioneFineIncarico; }
            set { _numeroDeliberaCommissioneFineIncarico = value; }
        }

        public DateTime? DataDeliberaCommissioneFineIncarico
        {
            get { return _dataDeliberaCommissioneFineIncarico; }
            set { _dataDeliberaCommissioneFineIncarico = value; }
        }
        
    }
}
