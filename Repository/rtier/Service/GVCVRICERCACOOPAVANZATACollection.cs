using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
    public partial class GVCVRICERCACOOPAVANZATACollection
    {
        public GVCVRICERCACOOPAVANZATA[] GetBySearchParameters(string where)
        {
            return GetAsArray(where, GVCVRICERCACOOPAVANZATACollection.R_IDOBJColumnName);
        }
    }
}
