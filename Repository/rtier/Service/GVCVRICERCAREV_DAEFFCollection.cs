using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
    public partial class GVCVRICERCAREV_DAEFFCollection
    {
        public GVCVRICERCAREV_DAEFF[] GetBySearchParameters(string where)
        {
            return GetAsArray(where, GVCVRICERCAREV_DAEFFCollection.R_IDOBJColumnName);
        }
    }
}
