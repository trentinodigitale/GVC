using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
    public partial class GVCVRICERCAANNOTAZIONICollection
    {
        public GVCVRICERCAANNOTAZIONI[] GetBySearchParameters(string where)
        {
            return GetAsArray(where, GVCVRICERCAANNOTAZIONICollection.R_IDOBJColumnName);
        }
    }
}
