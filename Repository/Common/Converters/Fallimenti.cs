using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using it.dedagroup.GVC.Repository.rtier.Service;

namespace it.dedagroup.GVC.Repository.Common.Converters
{
    public abstract partial class Converters
    {

		#region Methods (4) 


		// Public Methods (4) 

        public static ProceduraFallimentareFDT Convert(GVCTFALLIMENTI itemToConvert)
        {
            ProceduraFallimentareFDT item = null;
            if (itemToConvert != null)
            {
                item = new ProceduraFallimentareFDT();
                item.IdProceduraFallimentare = itemToConvert.IDOBJ;
                item.IdRegistro = itemToConvert.IDOBJ_REGISTRO;
                if (!itemToConvert.IsDATA_FINENull)
                    item.DataFineProcedura = itemToConvert.DATA_FINE;
                item.DataSentenza = itemToConvert.DATA_SENTENZA;
                item.IdCuratore = itemToConvert.IDOBJ_CURATORESafe;
                item.Tribunale = itemToConvert.TRIBUNALESafe;
                item.Esito = itemToConvert.ESITOSafe;
            }
            return item;
        }

        public static GVCTFALLIMENTI Convert(ProceduraFallimentareFDT itemToConvert)
        {
            GVCTFALLIMENTI item = null;
            if (itemToConvert != null)
            {
                item = new GVCTFALLIMENTI();
                item.IDOBJ = itemToConvert.IdProceduraFallimentare;
                item.IDOBJ_REGISTRO = itemToConvert.IdRegistro;
                if (itemToConvert.DataFineProcedura.HasValue)
                    item.DATA_FINE = itemToConvert.DataFineProcedura.Value;
                item.DATA_SENTENZA = itemToConvert.DataSentenza;
                item.ESITO = itemToConvert.Esito;
                
                if (itemToConvert.IdCuratore > 0)
                    item.IDOBJ_CURATORE = itemToConvert.IdCuratore;
                else
                    item.IsIDOBJ_CURATORENull = true;
                item.TRIBUNALE = itemToConvert.Tribunale;
            }
            return item;
        }

        public static ProceduraFallimentareFDT[] ConvertAll(GVCTFALLIMENTI[] itemsToConvert)
        {
            List<ProceduraFallimentareFDT> listItem = new List<ProceduraFallimentareFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCTFALLIMENTI item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCTFALLIMENTI[] ConvertAll(ProceduraFallimentareFDT[] itemsToConvert)
        {
            List<GVCTFALLIMENTI> listItem = new List<GVCTFALLIMENTI>();
            if (itemsToConvert != null)
            {
                foreach (ProceduraFallimentareFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }


		#endregion Methods 

    }
}
