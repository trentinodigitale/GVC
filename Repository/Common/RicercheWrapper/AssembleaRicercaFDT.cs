using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.RicercheWrapper
{
    [Serializable]
    public partial class AssembleaRicercaFDT
    {
        private int _idDeliberaAssemblea;
        private int _idTipoAssemblea;
        private DateTime _dataAssemblea;
        private String _contenuto;

        List<ModificaStatRicercaFDT> _modificheStatutarie;

        public int IdDeliberaAssemblea
        {
            get { return _idDeliberaAssemblea; }
            set { _idDeliberaAssemblea = value; }
        }

        public int IdTipoAssemblea
        {
            get { return _idTipoAssemblea; }
            set { _idTipoAssemblea = value; }
        }

        public DateTime DataAssemblea
        {
            get { return _dataAssemblea; }
            set { _dataAssemblea = value; }
        }

        public String Contenuto
        {
            get { return _contenuto; }
            set { _contenuto = value; }
        }

        public List<ModificaStatRicercaFDT> ModificheStatutarie
        {
            get { return _modificheStatutarie; }
            set { _modificheStatutarie = value; }
        }
    }
}
