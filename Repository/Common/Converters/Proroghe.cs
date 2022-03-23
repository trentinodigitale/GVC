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

        public static ProrogaFDT Convert(GVCRPROROGHE itemToConvert)
        {
            ProrogaFDT item = null;
            if (itemToConvert != null)
            {
                item = new ProrogaFDT();
                item.IdProroga = itemToConvert.IDOBJ;

                if (!itemToConvert.IsDATA_DELIBERANull)
                    item.DataDeliberaCommissione = itemToConvert.DATA_DELIBERA;
                if (!itemToConvert.IsDATA_DETERMINANull)
                    item.DataDetermina = itemToConvert.DATA_DETERMINA;
                item.DataProroga = itemToConvert.DATA_PROROGA;
                item.IdProceduraCoatta = itemToConvert.IDOBJ_PROCEDURA;
                item.NumeroDeliberaCommissione = itemToConvert.NUMERO_DELIBERASafe;
                item.NumeroDetermina = itemToConvert.NUMERO_DETERMINASafe;

                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaModifica = itemToConvert.DATAORAULTMOD;
                item.OperatoreUltimaModifica = itemToConvert.OPERATOREULTMODSafe;
            }
            return item;
        }

        public static GVCRPROROGHE Convert(ProrogaFDT itemToConvert)
        {
            GVCRPROROGHE item = null;
            if (itemToConvert != null)
            {
                item = new GVCRPROROGHE();
                item.IDOBJ = itemToConvert.IdProroga;
                if (itemToConvert.DataDeliberaCommissione.HasValue)
                    item.DATA_DELIBERA = itemToConvert.DataDeliberaCommissione.Value;
                if (itemToConvert.DataDetermina.HasValue)
                    item.DATA_DETERMINA = itemToConvert.DataDetermina.Value;
                item.DATA_PROROGA = itemToConvert.DataProroga;
                item.IDOBJ_PROCEDURA = itemToConvert.IdProceduraCoatta;
                item.NUMERO_DELIBERA = itemToConvert.NumeroDeliberaCommissione;
                item.NUMERO_DETERMINA = itemToConvert.NumeroDetermina;

                if (itemToConvert.DataUltimaModifica.HasValue)
                    item.DATAORAULTMOD = itemToConvert.DataUltimaModifica.Value;
                item.OPERATOREULTMOD = itemToConvert.OperatoreUltimaModifica;
            }
            return item;
        }

        public static ProrogaFDT[] ConvertAll(GVCRPROROGHE[] itemsToConvert)
        {
            List<ProrogaFDT> listItem = new List<ProrogaFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCRPROROGHE item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCRPROROGHE[] ConvertAll(ProrogaFDT[] itemsToConvert)
        {
            List<GVCRPROROGHE> listItem = new List<GVCRPROROGHE>();
            if (itemsToConvert != null)
            {
                foreach (ProrogaFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }


		#endregion Methods 

    }
}
