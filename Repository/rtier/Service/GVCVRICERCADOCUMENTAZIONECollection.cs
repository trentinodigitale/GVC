using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
    public partial class GVCVRICERCADOCUMENTAZIONECollection
    {
        public GVCVRICERCADOCUMENTAZIONE[] GetBySearchParameters(string where)
        {
            return GetAsArray(where, GVCVRICERCADOCUMENTAZIONECollection.R_IDOBJColumnName);
        }
    }
}
