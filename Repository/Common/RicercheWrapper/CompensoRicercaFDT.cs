using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.RicercheWrapper
{
    [Serializable]
    public partial class CompensoRicercaFDT
    {
        private DateTime? _dataDeliberaCommissioneIncarico;
        private DateTime? _dataScadenzaTeorica;
        private DateTime? _dataDeterminaIncarico;
        private Double _importoImpegno;
        private String _revisore;
        private Double _importoTotale;
        private String _numeroDeterminaIncarico;

        public DateTime? DataDeliberaCommissioneIncarico
        {
            get { return _dataDeliberaCommissioneIncarico; }
            set { _dataDeliberaCommissioneIncarico = value; }
        }

        public DateTime? DataScadenzaTeorica
        {
            get { return _dataScadenzaTeorica; }
            set { _dataScadenzaTeorica = value; }
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

        public double ImportoTotale
        {
            get { return _importoTotale; }
            set { _importoTotale = value; }
        }

        public DateTime? DataDeterminaIncarico
        {
            get { return _dataDeterminaIncarico; }
            set { _dataDeterminaIncarico = value; }
        }

        public string NumeroDeterminaIncarico
        {
            get { return _numeroDeterminaIncarico; }
            set { _numeroDeterminaIncarico = value; }
        }
    }
}
