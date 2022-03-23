using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
    public partial class GVCVRICERCAFALLIMENTICollection
    {
        public GVCVRICERCAFALLIMENTI[] GetBySearchParameters(string where)
        {
            return GetAsArray(where, GVCVRICERCAFALLIMENTICollection.R_IDOBJColumnName);
        }
    }
}
