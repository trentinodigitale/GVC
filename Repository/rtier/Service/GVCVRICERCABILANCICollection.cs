using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
    public partial class GVCVRICERCABILANCICollection
    {
        public GVCVRICERCABILANCI[] GetBySearchParameters(string where)
        {
            return GetAsArray(where, GVCVRICERCABILANCICollection.R_IDOBJColumnName);
        }

        public string GetSqlWhereBilancioNotIn(int annoBilancio, int tipoBil)
        {
            StringBuilder toReturn;

            toReturn = new StringBuilder(GVCVRICERCABILANCICollection.R_IDOBJColumnName);
            toReturn.Append(" NOT IN ( ");
            toReturn.Append("SELECT DISTINCT(");
            toReturn.Append(GVCVRICERCABILANCICollection.R_IDOBJColumnName);
            toReturn.Append(") FROM GVCVRICERCABILANCI ");
            toReturn.Append("WHERE ");
            toReturn.Append(String.Format("{0} = {1} ", GVCVRICERCABILANCICollection.BIL_ANNO_RIFERIMENTOColumnName, annoBilancio));
            toReturn.Append("AND ");
            toReturn.Append(String.Format("{0} = {1}", GVCVRICERCABILANCICollection.BIL_IDOBJ_TIPO_BILANCIOColumnName, tipoBil));
            toReturn.Append(")");

            return toReturn.ToString();
        }

        //public GVCVRICERCABILANCI[] GetBySearchParameters(string where, string newColumn, string condition)
        //{
        //    return GetAsArray(where, GVCVRICERCABILANCICollection.R_IDOBJColumnName, newColumn, condition);
        //}
    }
}
