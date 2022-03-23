using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
    public partial class GVCTATTIVITACollection
	{
        public GVCTATTIVITA[] GetActivitiesByIdRegistro(int idRegistro, Boolean parix)
        {
            SQLFilter sf = new SQLFilter();

            int cciaa = parix ? 1 : 0;
            String parixFilter = String.Format(
                    Queries.Oracle.Formats.FIELD_EQUALS_NUMBER,
                    GVCTATTIVITACollection.ATTIVITA_CCIAAColumnName,
                    cciaa);

            sf.Add(GVCTATTIVITACollection.ATTIVITA_CCIAAColumnName, parixFilter);

            String regFilter = String.Format(
                    Queries.Oracle.Formats.FIELD_EQUALS_NUMBER,
                    GVCTATTIVITACollection.IDOBJ_REGISTROColumnName,
                    idRegistro);

            sf.Add(GVCTATTIVITACollection.IDOBJ_REGISTROColumnName, regFilter);

            return GetAsArray(sf.ToString(), GVCTATTIVITACollection.IDOBJColumnName);
        }
    }
}
