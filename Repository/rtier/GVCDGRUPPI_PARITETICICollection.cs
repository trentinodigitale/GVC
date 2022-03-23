using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
    public partial class GVCDGRUPPI_PARITETICICollection
    {
        public GVCDGRUPPI_PARITETICI[] GetBySearchParameters(string where)
        {
            return GetAsArray(where, string.Empty);
        }
    }
}
