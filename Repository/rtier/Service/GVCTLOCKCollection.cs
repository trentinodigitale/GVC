using System;
using System.Data;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
	/// <summary>
	/// Data Access Layer for the object GVCTLOCK
	/// </summary>
    public partial class GVCTLOCKCollection
    {
        public GVCTLOCK GetLockByEntityTypeAndStatus(int entity, int entityType, int status)
        {
            GVCTLOCK toReturn = null;

            string where = string.Format("{0} AND {1} AND {2}",
                string.Format(Queries.Oracle.Formats.FIELD_EQUALS_NUMBER,
                                GVCTLOCKCollection.IDOBJ_ENTITAColumnName,
                                entity),
                string.Format(Queries.Oracle.Formats.FIELD_EQUALS_NUMBER,
                                GVCTLOCKCollection.TIPO_ENTITAColumnName,
                                entityType),
                string.Format(Queries.Oracle.Formats.FIELD_EQUALS_NUMBER,
                                GVCTLOCKCollection.STATOColumnName,
                                status)
                );


            GVCTLOCK[] locks = GetAsArray(where, string.Empty);
            if (locks != null)
            {
                if (locks.Length == 1)
                {
                    toReturn = locks[0];
                }
                else if (locks.Length == 0)
                {
                    toReturn = new GVCTLOCK();
                    toReturn.IDOBJ = -1;
                }
                else
                {
                    throw new Exception(String.Format("Troppi record con entity = {0}, tipo = {1} e stato = {2}",
                                                        entity, entityType, status));
                }
            }
            else
            {
                throw new Exception("Valore ritornato dalla query è null (GetLockByEntityTypeAndStatus)");
            }

            return toReturn;
        }
    }
}
