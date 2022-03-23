using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
    public partial class GVCVRICERCAPROCEDIMENTICollection
    {
        public GVCVRICERCAPROCEDIMENTI[] GetBySearchParameters(string where)
        {
            return GetAsArray(where, GVCVRICERCAPROCEDIMENTICollection.R_IDOBJColumnName);
        }
    }
}
