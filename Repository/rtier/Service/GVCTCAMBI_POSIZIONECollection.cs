using System;
using System.Data;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
	/// <summary>
	/// Data Access Layer for the object GVCTCAMBI_POSIZIONE
	/// </summary>
	public partial class GVCTCAMBI_POSIZIONECollection
	{
		  public GVCTCAMBI_POSIZIONE[] GetListCambiPosizioneByIdRegistroOrder(int idRegistro)
          {
              SQLFilter sf = new SQLFilter();

              sf.Add(GVCTCAMBI_POSIZIONECollection.IDOBJ_REGISTROColumnName, String.Format(Queries.Oracle.Formats.FIELD_EQUALS_NUMBER, GVCTCAMBI_POSIZIONECollection.IDOBJ_REGISTROColumnName, idRegistro));

              String orderBy = string.Concat(GVCTCAMBI_POSIZIONECollection.DATA_DETERMINAColumnName,
                                        ", ",
                                        GVCTCAMBI_POSIZIONECollection.IDOBJColumnName);

              return GetAsArray(sf.ToString(), orderBy);
          }
	}
}
