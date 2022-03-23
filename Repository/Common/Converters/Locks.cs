using System;
using System.Collections.Generic;
using System.Text;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using it.dedagroup.GVC.Repository.rtier.Service;
using it.dedagroup.GVC.Repository.Common.Configurations;

namespace it.dedagroup.GVC.Repository.Common.Converters
{
    public abstract partial class Converters
    {

		#region Methods (4) 


		// Public Methods (4) 

        public static LockFDT Convert(GVCTLOCK itemToConvert)
        {
            LockFDT item = null;
            if (itemToConvert != null)
            {
                item = new LockFDT();
                item.IdLock = itemToConvert.IDOBJ;
                item.IdEntity = itemToConvert.IDOBJ_ENTITA;
                item.IdEntityType = itemToConvert.TIPO_ENTITA;
                if (!itemToConvert.IsSTATONull)
                    item.Status = itemToConvert.STATOSafe;
                else
                    item.Status = 0;
            }
            return item;
        }

        public static GVCTLOCK Convert(LockFDT itemToConvert)
        {
            GVCTLOCK item = null;
            if (itemToConvert != null)
            {
                item = new GVCTLOCK();
                item.IDOBJ = itemToConvert.IdLock;
                item.TIPO_ENTITA = itemToConvert.IdEntityType;
                item.IDOBJ_ENTITA = itemToConvert.IdEntity;
                item.STATO = itemToConvert.Status;
            }
            return item;
        }

        public static LockFDT[] ConvertAll(GVCTLOCK[] itemsToConvert)
        {
            List<LockFDT> listItem = new List<LockFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCTLOCK item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCTLOCK[] ConvertAll(LockFDT[] itemsToConvert)
        {
            List<GVCTLOCK> listItem = new List<GVCTLOCK>();
            if (itemsToConvert != null)
            {
                foreach (LockFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }


		#endregion Methods 

    }
}
