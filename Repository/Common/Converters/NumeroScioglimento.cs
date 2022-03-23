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

        public static NumeroScioglimentoFDT Convert(GVCTSCIOGLIMENTO itemToConvert)
        {
            NumeroScioglimentoFDT item = null;
            if (itemToConvert != null)
            {
                item = new NumeroScioglimentoFDT();
                item.Id = itemToConvert.IDOBJ;
                item.NrScioglimento = itemToConvert.NRSCIOGLIMENTOSafe;
            }
            return item;
        }

        public static GVCTSCIOGLIMENTO Convert(NumeroScioglimentoFDT itemToConvert)
        {
            GVCTSCIOGLIMENTO item = null;
            if (itemToConvert != null)
            {
                item = new GVCTSCIOGLIMENTO();
                item.IDOBJ = itemToConvert.Id;
                item.NRSCIOGLIMENTO = itemToConvert.NrScioglimento;
            }
            return item;
        }

        public static NumeroScioglimentoFDT[] ConvertAll(GVCTSCIOGLIMENTO[] itemsToConvert)
        {
            List<NumeroScioglimentoFDT> listItem = new List<NumeroScioglimentoFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCTSCIOGLIMENTO item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCTSCIOGLIMENTO[] ConvertAll(NumeroScioglimentoFDT[] itemsToConvert)
        {
            List<GVCTSCIOGLIMENTO> listItem = new List<GVCTSCIOGLIMENTO>();
            if (itemsToConvert != null)
            {
                foreach (NumeroScioglimentoFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }


        #endregion Methods 

    }
}
