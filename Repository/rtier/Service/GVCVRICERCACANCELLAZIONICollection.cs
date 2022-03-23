using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
    public partial class GVCVRICERCACANCELLAZIONICollection
    {
        public GVCVRICERCACANCELLAZIONI[] GetBySearchParameters(string where)
        {
            return GetAsArray(where, GVCVRICERCACANCELLAZIONICollection.R_IDOBJColumnName);
        }
    }
}
