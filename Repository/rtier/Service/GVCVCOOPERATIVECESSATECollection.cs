using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
    public partial class GVCVCOOPERATIVECESSATECollection
    {
        public GVCVCOOPERATIVECESSATE[] GetCooperativesClosedAfter(DateTime closedAfterDt)
        {
            SQLFilter sf = new SQLFilter();

            String dtFilter = String.Format(
                    Queries.Oracle.Formats.FIELD_EQUALS_OR_GREATER_DATE,
                    GVCVCOOPERATIVECESSATECollection.DATA_CANC_REGISTROColumnName,
                    closedAfterDt.ToShortDateString());

            sf.Add(GVCVCOOPERATIVECESSATECollection.DATA_CANC_REGISTROColumnName, dtFilter);

            return GetAsArray(sf.ToString(), GVCVCOOPERATIVECESSATECollection.REANUMERICColumnName);
        }
    }
}
