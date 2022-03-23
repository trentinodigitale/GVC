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

        public static DeliberaAcquistoCreditiFiscFDT Convert(GVCTCREDITI_FISCALI itemToConvert)
        {
            DeliberaAcquistoCreditiFiscFDT item = null;
            if (itemToConvert != null)
            {
                item = new DeliberaAcquistoCreditiFiscFDT();
                item.IdDeliberaAcquistoCreditiFisc = itemToConvert.IDOBJ;
                if (!itemToConvert.IsDATA_DELIBERANull)
                    item.DataDelibera = itemToConvert.DATA_DELIBERA;
                item.IdLiquidazione = itemToConvert.IDOBJ_LIQUIDAZIONE;
                if (!itemToConvert.IsIMPORTONull)
                    item.Importo = itemToConvert.IMPORTO;
                item.Note = itemToConvert.NOTESafe;
                item.NumeroDelibera = itemToConvert.NUMERO_DELIBERASafe;
                item.Valuta = itemToConvert.VALUTASafe;

                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaModifica = itemToConvert.DATAORAULTMOD;
                item.OperatoreUltimaModifica = itemToConvert.OPERATOREULTMODSafe;
            }
            return item;
        }

        public static GVCTCREDITI_FISCALI Convert(DeliberaAcquistoCreditiFiscFDT itemToConvert)
        {
            GVCTCREDITI_FISCALI item = null;
            if (itemToConvert != null)
            {
                item = new GVCTCREDITI_FISCALI();
                item.IDOBJ = itemToConvert.IdDeliberaAcquistoCreditiFisc;
                if (itemToConvert.DataDelibera.HasValue)
                item.DATA_DELIBERA = itemToConvert.DataDelibera.Value;
                item.IDOBJ_LIQUIDAZIONE = itemToConvert.IdLiquidazione;
                item.IMPORTO = itemToConvert.Importo;
                item.NOTE = itemToConvert.Note;
                item.NUMERO_DELIBERA = itemToConvert.NumeroDelibera;
                item.VALUTA = itemToConvert.Valuta;
               
                if (itemToConvert.DataUltimaModifica.HasValue)
                    item.DATAORAULTMOD = itemToConvert.DataUltimaModifica.Value;
                item.OPERATOREULTMOD = itemToConvert.OperatoreUltimaModifica;
            }
            return item;
        }

        public static DeliberaAcquistoCreditiFiscFDT[] ConvertAll(GVCTCREDITI_FISCALI[] itemsToConvert)
        {
            List<DeliberaAcquistoCreditiFiscFDT> listItem = new List<DeliberaAcquistoCreditiFiscFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCTCREDITI_FISCALI item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCTCREDITI_FISCALI[] ConvertAll(DeliberaAcquistoCreditiFiscFDT[] itemsToConvert)
        {
            List<GVCTCREDITI_FISCALI> listItem = new List<GVCTCREDITI_FISCALI>();
            if (itemsToConvert != null)
            {
                foreach (DeliberaAcquistoCreditiFiscFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }


		#endregion Methods 

    }
}
