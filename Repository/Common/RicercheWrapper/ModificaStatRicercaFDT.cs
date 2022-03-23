using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.RicercheWrapper
{
    [Serializable]
    public partial class ModificaStatRicercaFDT
    {
        private int _idTipoModifica;

        public int IdTipoModifica
        {
            get { return _idTipoModifica; }
            set { _idTipoModifica = value; }
        }
    }
}
