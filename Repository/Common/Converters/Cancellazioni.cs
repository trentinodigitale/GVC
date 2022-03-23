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

        public static CancellazioneFDT Convert(GVCTCANCELLAZIONI itemToConvert)
        {
            CancellazioneFDT item = null;
            if (itemToConvert != null)
            {
                item = new CancellazioneFDT();
                item.IdCancellazione = itemToConvert.IDOBJ;
                if (!itemToConvert.IsDATA_DELIBERANull)
                    item.DataDeliberaCommissione = itemToConvert.DATA_DELIBERA;
                if (!itemToConvert.IsDATA_DETERMINANull)
                    item.DataDetermina = itemToConvert.DATA_DETERMINA;
                if (!itemToConvert.IsDATA_DOMANDANull)
                    item.DataRicevimentoDomanda = itemToConvert.DATA_DOMANDA;
                item.IdRegistroCooperativa = itemToConvert.IDOBJ_REGISTRO;
                item.Note = itemToConvert.NOTESafe;
                item.NumeroDeliberaCommissione = itemToConvert.NUMERO_DELIBERASafe;
                item.NumeroDetermina = itemToConvert.NUMERO_DETERMINASafe;
                item.IdTipoCancellazione = itemToConvert.TIPOSafe;
                if (!itemToConvert.IsDATA_CANC_REGISTRONull)
                    item.DataCancRegistro = itemToConvert.DATA_CANC_REGISTRO;
                if (!itemToConvert.IsDATA_CANC_ALBONull)
                    item.DataCancAlbo = itemToConvert.DATA_CANC_ALBO;
                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaModifica = itemToConvert.DATAORAULTMOD;
                item.OperatoreUltimaModifica = itemToConvert.OPERATOREULTMODSafe;
            }
            return item;
        }

        public static GVCTCANCELLAZIONI Convert(CancellazioneFDT itemToConvert)
        {
            GVCTCANCELLAZIONI item = null;
            if (itemToConvert != null)
            {
                item = new GVCTCANCELLAZIONI();
                item.IDOBJ = itemToConvert.IdCancellazione;
                if (itemToConvert.DataDeliberaCommissione.HasValue)
                    item.DATA_DELIBERA = itemToConvert.DataDeliberaCommissione.Value;
                if (itemToConvert.DataDetermina.HasValue)
                    item.DATA_DETERMINA = itemToConvert.DataDetermina.Value;
                if (itemToConvert.DataRicevimentoDomanda.HasValue)
                    item.DATA_DOMANDA = itemToConvert.DataRicevimentoDomanda.Value;
                else
                    item.IsDATA_DOMANDANull = true;
                item.IDOBJ_REGISTRO = itemToConvert.IdRegistroCooperativa;
                item.NOTE = itemToConvert.Note;
                item.NUMERO_DELIBERA = itemToConvert.NumeroDeliberaCommissione;
                item.NUMERO_DETERMINA = itemToConvert.NumeroDetermina;
                item.TIPO = itemToConvert.IdTipoCancellazione;
                if (itemToConvert.DataCancRegistro.HasValue)
                    item.DATA_CANC_REGISTRO = itemToConvert.DataCancRegistro.Value;
                if (itemToConvert.DataCancAlbo.HasValue)
                    item.DATA_CANC_ALBO = itemToConvert.DataCancAlbo.Value;
                if (itemToConvert.DataUltimaModifica.HasValue)
                    item.DATAORAULTMOD = itemToConvert.DataUltimaModifica.Value;
                item.OPERATOREULTMOD = itemToConvert.OperatoreUltimaModifica;
            }
            return item;
        }

        public static CancellazioneFDT[] ConvertAll(GVCTCANCELLAZIONI[] itemsToConvert)
        {
            List<CancellazioneFDT> listItem = new List<CancellazioneFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCTCANCELLAZIONI item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCTCANCELLAZIONI[] ConvertAll(CancellazioneFDT[] itemsToConvert)
        {
            List<GVCTCANCELLAZIONI> listItem = new List<GVCTCANCELLAZIONI>();
            if (itemsToConvert != null)
            {
                foreach (CancellazioneFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }


		#endregion Methods 

    }
}
