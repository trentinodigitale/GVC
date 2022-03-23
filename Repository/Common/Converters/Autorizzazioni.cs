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

        public static AutorizzazioneFDT Convert(GVCTAUTORIZZAZIONI itemToConvert)
        {
            AutorizzazioneFDT item = null;
            if (itemToConvert != null)
            {
                item = new AutorizzazioneFDT();
                item.IdAutorizzazione = itemToConvert.IDOBJ;
                if (!itemToConvert.IsDATA_DELIBERANull)
                item.DataDeliberaCommissione = itemToConvert.DATA_DELIBERA;
                if (!itemToConvert.IsDATA_DETERMINANull)
                item.DataDetermina = itemToConvert.DATA_DETERMINA;
                if (!itemToConvert.IsDATA_ISTANZANull)
                item.DataIstanza = itemToConvert.DATA_ISTANZA;
                item.DescrizioneDatoStorico = itemToConvert.DESCRIZIONESafe;
                item.IdLiquidazione = itemToConvert.IDOBJ_LIQUIDAZIONE;
                item.IdTipoAutorizzazione = itemToConvert.IDOBJ_TIPO;
                item.NumeroDeliberaCommissione = itemToConvert.NUMERO_DELIBERASafe;
                item.NumeroDetermina = itemToConvert.NUMERO_DETERMINASafe;
                item.Note = itemToConvert.NOTESafe;               
                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaModifica = itemToConvert.DATAORAULTMOD;
                item.OperatoreUltimaModifica = itemToConvert.OPERATOREULTMODSafe;
            }
            return item;
        }

        public static GVCTAUTORIZZAZIONI Convert(AutorizzazioneFDT itemToConvert)
        {
            GVCTAUTORIZZAZIONI item = null;
            if (itemToConvert != null)
            {
                item = new GVCTAUTORIZZAZIONI();
                item.IDOBJ = itemToConvert.IdAutorizzazione;
                if (itemToConvert.DataDeliberaCommissione.HasValue)
                    item.DATA_DELIBERA = itemToConvert.DataDeliberaCommissione.Value;
                if (itemToConvert.DataDetermina.HasValue)
                    item.DATA_DETERMINA = itemToConvert.DataDetermina.Value;
                if (itemToConvert.DataIstanza.HasValue)
                    item.DATA_ISTANZA = itemToConvert.DataIstanza.Value;
                item.DESCRIZIONE = itemToConvert.DescrizioneDatoStorico;
                item.IDOBJ_LIQUIDAZIONE = itemToConvert.IdLiquidazione;
                item.IDOBJ_TIPO = itemToConvert.IdTipoAutorizzazione;
                item.NUMERO_DELIBERA = itemToConvert.NumeroDeliberaCommissione;
                item.NOTE = itemToConvert.Note;
                item.NUMERO_DETERMINA = itemToConvert.NumeroDetermina;

                if (itemToConvert.DataUltimaModifica.HasValue)
                    item.DATAORAULTMOD = itemToConvert.DataUltimaModifica.Value;
                item.OPERATOREULTMOD = itemToConvert.OperatoreUltimaModifica;
            }
            return item;
        }

        public static AutorizzazioneFDT[] ConvertAll(GVCTAUTORIZZAZIONI[] itemsToConvert)
        {
            List<AutorizzazioneFDT> listItem = new List<AutorizzazioneFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCTAUTORIZZAZIONI item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCTAUTORIZZAZIONI[] ConvertAll(AutorizzazioneFDT[] itemsToConvert)
        {
            List<GVCTAUTORIZZAZIONI> listItem = new List<GVCTAUTORIZZAZIONI>();
            if (itemsToConvert != null)
            {
                foreach (AutorizzazioneFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }


		#endregion Methods 

    }
}
