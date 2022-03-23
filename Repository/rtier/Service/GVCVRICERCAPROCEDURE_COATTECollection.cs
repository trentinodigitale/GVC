using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
    public partial class GVCVRICERCAPROCEDURE_COATTECollection
    {
        public GVCVRICERCAPROCEDURE_COATTE[] GetBySearchParameters(string where)
        {
            return GetAsArray(where, "R_IDOBJ");
        }
    }
}
