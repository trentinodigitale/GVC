using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
    public partial class GVCVRICERCALIQUIDAZIONI_COATTECollection
    {

        public GVCVRICERCALIQUIDAZIONI_COATTE[] GetBySearchParameters(string where)
        {
            return GetAsArray(where, "R_IDOBJ, LIQCOA_IDOBJ, COMP_IDOBJ, RELSEM_IDOBJ, AUTO_IDOBJ, COMPLIQ_IDOBJ, CREFIS_IDOBJ");
        }

        public string GetSqlWhereDataRelazioneNotIn(DateTime dataRelazione)
        {
           StringBuilder toReturn;

            toReturn = new StringBuilder(GVCVRICERCALIQUIDAZIONI_COATTECollection.S_IDOBJColumnName);
            toReturn.Append(" NOT IN (");
            toReturn.Append(" SELECT DISTINCT(");
            toReturn.Append(GVCVRICERCALIQUIDAZIONI_COATTECollection.S_IDOBJColumnName);
            toReturn.Append(") FROM ");
            toReturn.Append(" GVCVRICERCALIQUIDAZIONI_COATTE ");
            toReturn.Append(" WHERE (TRUNC(");
            toReturn.Append(GVCVRICERCALIQUIDAZIONI_COATTECollection.RELSEM_DATA_RELAZIONEColumnName);
            toReturn.Append(") >= TRUNC(TO_DATE('");
            toReturn.Append(dataRelazione.ToString("dd/MM/yyyy"));
            toReturn.Append("00.00.00', 'dd/MM/yyyy HH24:MI:SS')))");
            toReturn.Append(")");

            return toReturn.ToString();
        }

    }
}
