using System;
using System.Data;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
	/// <summary>
	/// Data Access Layer for the object GVCTLOG_SEGNALAZIONI
	/// </summary>
    public partial class GVCVCERCAMODIFICHEPARIXCollection 
	{
        /// <summary>
        /// Gets the list segnalazioni between dates.
        /// </summary>
        /// <param name="from">From.</param>
        /// <param name="to">To.</param>
        /// <returns></returns>
        public GVCVCERCAMODIFICHEPARIX[] GetListSegnalazioniBetweenDates(int regNr, DateTime from, DateTime to, int[] segTypes, int visible, int applied)
        {
            if (segTypes == null || segTypes.Length <= 0)
                return null;
            
            SQLFilter sf = new SQLFilter();

            String dateFilter = String.Format(
                    Queries.Oracle.Formats.FIELD_BETWEEN_DATE,
                    GVCVCERCAMODIFICHEPARIXCollection.DATA_SEGNALAZIONEColumnName,
                    from.ToShortDateString(),
                    to.ToShortDateString());

            sf.Add(GVCVCERCAMODIFICHEPARIXCollection.DATA_SEGNALAZIONEColumnName,dateFilter);

            if (regNr != int.MinValue)
            {
                String regNrFilter = String.Format(
                        Queries.Oracle.Formats.FIELD_EQUALS_NUMBER,
                        GVCVCERCAMODIFICHEPARIXCollection.IDOBJ_REGISTROColumnName,
                        regNr);
                sf.Add(GVCVCERCAMODIFICHEPARIXCollection.IDOBJ_REGISTROColumnName, regNrFilter);
            }

            String segTypeFilter;
            
            for (int i = 0; i < segTypes.Length; i++)
            {
                segTypeFilter = String.Format(
                        Queries.Oracle.Formats.FIELD_EQUALS_NUMBER,
                        GVCVCERCAMODIFICHEPARIXCollection.IDOBJ_TIPO_SEGNALAZIONEColumnName,
                        segTypes[i]);
                sf.Add(GVCVCERCAMODIFICHEPARIXCollection.IDOBJ_TIPO_SEGNALAZIONEColumnName, segTypeFilter);
            }

            if (applied >= 0)
            {
                String appliedFilter = String.Format(
                        Queries.Oracle.Formats.FIELD_EQUALS_NUMBER,
                        GVCVCERCAMODIFICHEPARIXCollection.APPLICATOColumnName,
                        applied);

                sf.Add(GVCVCERCAMODIFICHEPARIXCollection.APPLICATOColumnName, appliedFilter);
            }

            if (visible >= 0)
            {
                String visibleFilter = String.Format(
                        Queries.Oracle.Formats.FIELD_EQUALS_NUMBER,
                        GVCVCERCAMODIFICHEPARIXCollection.VISIBILEColumnName,
                        visible);

                sf.Add(GVCVCERCAMODIFICHEPARIXCollection.VISIBILEColumnName, visibleFilter);
            }

            //int appliedInt = applied ? 1 : 0;

            //String appliedFilter = String.Format(
            //        Queries.Oracle.Formats.FIELD_EQUALS_NUMBER,
            //        GVCVCERCAMODIFICHEPARIXCollection.APPLICATOColumnName,
            //        appliedInt);

            //sf.Add(GVCVCERCAMODIFICHEPARIXCollection.APPLICATOColumnName, appliedFilter);

            //int visibleInt = invisible ? 0 : 1;

            //String visibleFilter = String.Format(
            //        Queries.Oracle.Formats.FIELD_EQUALS_NUMBER,
            //        GVCVCERCAMODIFICHEPARIXCollection.VISIBILEColumnName,
            //        visibleInt);

            //sf.Add(GVCVCERCAMODIFICHEPARIXCollection.VISIBILEColumnName, visibleFilter);

            return GetAsArray(sf.ToString(), GVCVCERCAMODIFICHEPARIXCollection.DATA_SEGNALAZIONEColumnName);
        }
	}
}
