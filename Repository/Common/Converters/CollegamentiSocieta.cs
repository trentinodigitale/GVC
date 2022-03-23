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

        public static CollegamentoSocietaFDT Convert(GVCRSOCIETA_COLLEGATE itemToConvert)
        {
            CollegamentoSocietaFDT item = null;
            if (itemToConvert != null)
            {
                item = new CollegamentoSocietaFDT();
                item.IdCollegamento = itemToConvert.IDOBJ;
                item.IdModificaStatutaria = itemToConvert.IDOBJ_MODIFICA_STATUTARIA;
                item.IdSoggetto = itemToConvert.IDOBJ_SOGGETTO;
                item.Note = itemToConvert.NOTESafe;
            }
            return item;
        }

        public static GVCRSOCIETA_COLLEGATE Convert(CollegamentoSocietaFDT itemToConvert)
        {
            GVCRSOCIETA_COLLEGATE item = null;
            if (itemToConvert != null)
            {
                item = new GVCRSOCIETA_COLLEGATE();
                item.IDOBJ = itemToConvert.IdCollegamento;
                item.IDOBJ_MODIFICA_STATUTARIA = itemToConvert.IdModificaStatutaria;
                item.IDOBJ_SOGGETTO = itemToConvert.IdSoggetto;
                item.NOTE = itemToConvert.Note;
            }
            return item;
        }

        public static CollegamentoSocietaFDT[] ConvertAll(GVCRSOCIETA_COLLEGATE[] itemsToConvert)
        {
            List<CollegamentoSocietaFDT> listItem = new List<CollegamentoSocietaFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCRSOCIETA_COLLEGATE item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCRSOCIETA_COLLEGATE[] ConvertAll(CollegamentoSocietaFDT[] itemsToConvert)
        {
            List<GVCRSOCIETA_COLLEGATE> listItem = new List<GVCRSOCIETA_COLLEGATE>();
            if (itemsToConvert != null)
            {
                foreach (CollegamentoSocietaFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }


        #endregion Methods 
    }
}
