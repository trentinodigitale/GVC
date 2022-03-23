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

        public static CambioPosizioneFDT Convert(GVCTCAMBI_POSIZIONE itemToConvert)
        {
            CambioPosizioneFDT item = null;
            if (itemToConvert != null)
            {
                item = new CambioPosizioneFDT();
                item.IdCambioPosizione = itemToConvert.IDOBJ;
                if (!itemToConvert.IsDATA_DOMANDANull)
                    item.DataRicevimentoDomanda = itemToConvert.DATA_DOMANDA;
                item.IdRegistro = itemToConvert.IDOBJ_REGISTRO;
                if (!itemToConvert.IsDATA_DELIBERANull)
                    item.DataDeliberaCommissione = itemToConvert.DATA_DELIBERA;
                if (!itemToConvert.IsDATA_DETERMINANull)
                    item.DataDetermina = itemToConvert.DATA_DETERMINA;
                item.NumeroDeliberaCommissione = itemToConvert.NUMERO_DELIBERASafe;
                item.NumeroDetermina = itemToConvert.NUMERO_DETERMINASafe;
                item.SottoSezione = itemToConvert.SOTTOSEZIONESafe;
                item.Sezione = itemToConvert.SEZIONESafe;
                item.Note = itemToConvert.NOTESafe;
                item.IdCategoria = itemToConvert.IDOBJ_CATEGORIASafe;

                if (itemToConvert.CATEGORIA_SOCIALESafe >= 0)
                    item.CategoriaSociale = itemToConvert.CATEGORIA_SOCIALESafe;
                else
                    item.CategoriaSociale = 0;

           
                item.IdSottoCategoria = itemToConvert.IDOBJ_SOTTOCATEGORIASafe;
           

                item.NumeroPosizione = itemToConvert.NUMERO_POSIZIONESafe;

                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaModifica = itemToConvert.DATAORAULTMOD;
                item.OperatoreUltimaModifica = itemToConvert.OPERATOREULTMODSafe;
            }
            return item;
        }

        public static GVCTCAMBI_POSIZIONE Convert(CambioPosizioneFDT itemToConvert)
        {
            GVCTCAMBI_POSIZIONE item = null;
            if (itemToConvert != null)
            {
                item = new GVCTCAMBI_POSIZIONE();
                item.IDOBJ = itemToConvert.IdCambioPosizione;
                if (itemToConvert.DataRicevimentoDomanda.HasValue)
                    item.DATA_DOMANDA = itemToConvert.DataRicevimentoDomanda.Value;
                else
                    item.IsDATA_DOMANDANull = true;
                item.IDOBJ_REGISTRO = itemToConvert.IdRegistro;
                if (itemToConvert.DataDeliberaCommissione.HasValue)
                    item.DATA_DELIBERA = itemToConvert.DataDeliberaCommissione.Value;
                if (itemToConvert.DataDetermina.HasValue)
                    item.DATA_DETERMINA = itemToConvert.DataDetermina.Value;
                item.NUMERO_DELIBERA = itemToConvert.NumeroDeliberaCommissione;
                item.NUMERO_DETERMINA = itemToConvert.NumeroDetermina;

                item.SOTTOSEZIONE = itemToConvert.SottoSezione;

                item.SEZIONE = itemToConvert.Sezione;

                if (itemToConvert.IdCategoria > 0)
                    item.IDOBJ_CATEGORIA = itemToConvert.IdCategoria;
                else
                    item.IsIDOBJ_CATEGORIANull = true;

                if (itemToConvert.IdSottoCategoria > 0)
                    item.IDOBJ_SOTTOCATEGORIA = itemToConvert.IdSottoCategoria;
                else
                    item.IsIDOBJ_SOTTOCATEGORIANull = true;

                if (itemToConvert.CategoriaSociale >= 0)
                    item.CATEGORIA_SOCIALE = itemToConvert.CategoriaSociale;
                else
                    item.IsCATEGORIA_SOCIALENull = true;

                item.NOTE = itemToConvert.Note;
                if (itemToConvert.DataUltimaModifica.HasValue)
                    item.DATAORAULTMOD = itemToConvert.DataUltimaModifica.Value;
                item.OPERATOREULTMOD = itemToConvert.OperatoreUltimaModifica;
                item.NUMERO_POSIZIONE = itemToConvert.NumeroPosizione;
            }
            return item;
        }

        public static CambioPosizioneFDT[] ConvertAll(GVCTCAMBI_POSIZIONE[] itemsToConvert)
        {
            List<CambioPosizioneFDT> listItem = new List<CambioPosizioneFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCTCAMBI_POSIZIONE item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCTCAMBI_POSIZIONE[] ConvertAll(CambioPosizioneFDT[] itemsToConvert)
        {
            List<GVCTCAMBI_POSIZIONE> listItem = new List<GVCTCAMBI_POSIZIONE>();
            if (itemsToConvert != null)
            {
                foreach (CambioPosizioneFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }


		#endregion Methods 

    }
}
