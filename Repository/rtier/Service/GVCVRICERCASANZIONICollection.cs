using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
    public partial class GVCVRICERCASANZIONICollection
    {
        public GVCVRICERCASANZIONI[] GetBySearchParameters(string where)
        {
            return GetAsArray(where, GVCVRICERCASANZIONICollection.R_IDOBJColumnName);
        }
    }
}
