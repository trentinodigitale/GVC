using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
    /// <summary>
    /// Data Access Layer for the object GVCVRICERCASOGGETTIDAESPORTARE
    /// </summary>
    public partial class GVCVRICERCASOGGETTIDAESPORTARECollection
    {

        public GVCVRICERCASOGGETTIDAESPORTARE[] GetBySearchParameters(string where)
        {
            return GetAsArray(where, string.Empty);
        }

    }
}
