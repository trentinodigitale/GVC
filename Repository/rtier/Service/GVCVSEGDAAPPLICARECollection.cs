using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
    public partial class GVCVSEGDAAPPLICARECollection
    {
        public GVCVSEGDAAPPLICARE[] GetSegnalazioniToAppliByIdReg(int regNr) 
        {
            SQLFilter sf = new SQLFilter();

            String regFilter = String.Format(
                    Queries.Oracle.Formats.FIELD_EQUALS_NUMBER,
                    GVCVSEGDAAPPLICARECollection.IDOBJ_REGISTROColumnName,
                    regNr);

            sf.Add(GVCVSEGDAAPPLICARECollection.IDOBJ_REGISTROColumnName, regFilter);


            return GetAsArray(sf.ToString(), GVCVSEGDAAPPLICARECollection.IDOBJ_TIPO_SEGNALAZIONEColumnName);
        }
    }
}
