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

		#region Methods (2) 


		// Public Methods (2) 

        public static DatiFDT Convert(GVCDDATI itemToConvert)
        {
            DatiFDT item = null;
            if (itemToConvert != null)
            {
                item = new DatiFDT();
                item.IdItem = itemToConvert.IDOBJ;
                item.ValAzioneMax = itemToConvert.VALMAXAZIONE;
                item.ValAzioneMin = itemToConvert.VALMINAZIONE;
                item.ValQuotaMax = itemToConvert.VALMAXQUOTA;
                item.ValQuotaMin = itemToConvert.VALMINQUOTA;
                item.PercentualeCNP = itemToConvert.PERCENTUALE_CNP;
                item.PercentualeIVA = itemToConvert.PERCENTUALE_IVA;
                item.PercentualePAT = itemToConvert.PERCENTUALE_PAT;
              
            }
            return item;
        }

        public static DatiFDT[] ConvertAll(GVCDDATI[] itemsToConvert)
        {
            List<DatiFDT> listItem = new List<DatiFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCDDATI item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }


        public static GVCDDATI Convert(DatiFDT itemToConvert)
        {
            GVCDDATI item = null;
            if (itemToConvert != null)
            {
                item = new GVCDDATI();
                item.IDOBJ = itemToConvert.IdItem;
                item.VALMAXAZIONE = itemToConvert.ValAzioneMax;
                item.VALMINAZIONE = itemToConvert.ValAzioneMin;
                item.VALMAXQUOTA = itemToConvert.ValQuotaMax;
                item.VALMINQUOTA = itemToConvert.ValQuotaMin;
                item.PERCENTUALE_CNP = itemToConvert.PercentualeCNP;
                item.PERCENTUALE_IVA = itemToConvert.PercentualeIVA;
                item.PERCENTUALE_PAT = itemToConvert.PercentualePAT;

            }
            return item;
        }

        public static GVCDDATI[] ConvertAll(DatiFDT[] itemsToConvert)
        {
            List<GVCDDATI> listItem = new List<GVCDDATI>();
            if (itemsToConvert != null)
            {
                foreach (DatiFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

		#endregion Methods 

    }
}
