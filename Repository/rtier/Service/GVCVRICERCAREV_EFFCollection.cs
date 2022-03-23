using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
    public partial class GVCVRICERCAREV_EFFCollection
    {
        public GVCVRICERCAREV_EFF[] GetBySearchParameters(string where)
        {
            return GetAsArray(where, GVCVRICERCAREV_EFFCollection.R_IDOBJColumnName);
        }
    }
}
