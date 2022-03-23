using System;
using System.Collections.Generic;
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

        public static DatiStoriciFDT Convert(GVCTSTORICO_REGISTRO itemToConvert)
        {
            DatiStoriciFDT item = null;
            if (itemToConvert != null)
            {
                item = new DatiStoriciFDT();

                item.IdDatoStorico = itemToConvert.IDOBJ;
                item.IdRiferimento = itemToConvert.IDOBJ_REGISTRO;

                item.Descrizione = itemToConvert.DESCRIZIONE;
                
                if (!itemToConvert.IsDATA_FINENull)
                    item.DataFine = itemToConvert.DATA_FINE;
                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaMod = itemToConvert.DATAORAULTMOD;
                item.OperatoreUltimaMod = itemToConvert.OPERATOREULTMODSafe;
            }
            return item;
        }

        public static DatiStoriciFDT Convert(GVCTSTORICO_ASSEMBLEA itemToConvert)
        {
            DatiStoriciFDT item = null;
            if (itemToConvert != null)
            {
                item = new DatiStoriciFDT();

                item.IdDatoStorico = itemToConvert.IDOBJ;
                item.IdRiferimento = itemToConvert.IDOBJ_ASSEMBLEA;

                item.Descrizione = itemToConvert.DESCRIZIONE;

                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaMod = itemToConvert.DATAORAULTMOD;
                item.OperatoreUltimaMod = itemToConvert.OPERATOREULTMODSafe;
            }
            return item;
        }

        public static DatiStoriciFDT[] ConvertAll(GVCTSTORICO_REGISTRO[] itemsToConvert)
        {
            List<DatiStoriciFDT> listItem = new List<DatiStoriciFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCTSTORICO_REGISTRO item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static DatiStoriciFDT[] ConvertAll(GVCTSTORICO_ASSEMBLEA[] itemsToConvert)
        {
            List<DatiStoriciFDT> listItem = new List<DatiStoriciFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCTSTORICO_ASSEMBLEA item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }


		#endregion Methods 

    }
}
