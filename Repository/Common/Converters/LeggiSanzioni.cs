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

        public static LeggiTrasgressioneFDT Convert(GVCDLEGGI_TRASGRESSIONE itemToConvert)
        {
            LeggiTrasgressioneFDT item = null;
            if (itemToConvert != null)
            {
                item = new LeggiTrasgressioneFDT();
               
                item.IdElemento = itemToConvert.IDOBJ;
                item.Descrizione = itemToConvert.DESCRIZIONE;
                item.Entita = itemToConvert.ENTITA;
                item.IdTipoTrasgressione = itemToConvert.IDOBJ_TIPO_TRASGRESSIONE;

                item.Attivo = (!itemToConvert.IsFLAG_ATTIVONull &&
                    itemToConvert.FLAG_ATTIVOSafe == 0) ? true : false;

            }
            return item;
        }

        public static LeggiTrasgressioneFDT[] ConvertAll(GVCDLEGGI_TRASGRESSIONE[] itemsToConvert)
        {
            List<LeggiTrasgressioneFDT> listItem = new List<LeggiTrasgressioneFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCDLEGGI_TRASGRESSIONE item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCDLEGGI_TRASGRESSIONE Convert(LeggiTrasgressioneFDT itemToConvert)
        {
            GVCDLEGGI_TRASGRESSIONE item = null;
            if (itemToConvert != null)
            {
                item = new GVCDLEGGI_TRASGRESSIONE();
                item.IDOBJ = itemToConvert.IdElemento;
                item.DESCRIZIONE = itemToConvert.Descrizione;
                item.ENTITA = itemToConvert.Entita;
                if (itemToConvert.IdTipoTrasgressione > 0)
                    item.IDOBJ_TIPO_TRASGRESSIONE = itemToConvert.IdTipoTrasgressione;
                if (itemToConvert.Attivo)
                    item.FLAG_ATTIVO = 0;
                else
                    item.FLAG_ATTIVO = 1;

            }
            return item;
        }

        public static GVCDLEGGI_TRASGRESSIONE[] ConvertAll(LeggiTrasgressioneFDT[] itemsToConvert)
        {
            List<GVCDLEGGI_TRASGRESSIONE> listItem = new List<GVCDLEGGI_TRASGRESSIONE>();
            if (itemsToConvert != null)
            {
                foreach (LeggiTrasgressioneFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        #endregion Methods 
    }
}
