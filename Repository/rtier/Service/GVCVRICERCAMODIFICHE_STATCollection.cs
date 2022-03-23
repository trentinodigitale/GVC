using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
    public partial class GVCVRICERCAMODIFICHE_STATCollection
    {
        public GVCVRICERCAMODIFICHE_STAT[] GetBySearchParameters(string where)
        {
            return GetAsArray(where, GVCVRICERCAMODIFICHE_STATCollection.R_IDOBJColumnName);
        }
    }
}
