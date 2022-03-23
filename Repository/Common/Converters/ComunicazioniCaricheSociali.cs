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

        public static ComunicazioneCaricaSocialeFDT Convert(GVCTCOM_CARICHE itemToConvert)
        {
            ComunicazioneCaricaSocialeFDT item = null;
            if (itemToConvert != null)
            {
                item = new ComunicazioneCaricaSocialeFDT();
                item.IdComunicazioneCaricaSociale = itemToConvert.IDOBJ;
                if (!itemToConvert.IsDATA_COMUNICAZIONENull)
                    item.DataComunicazione = itemToConvert.DATA_COMUNICAZIONE;
                if (!itemToConvert.IsDATA_ANTIMAFIANull)
                    item.DataComunicazioneAntimafia = itemToConvert.DATA_ANTIMAFIA;
                item.DataSituazione = itemToConvert.DATA_SITUAZIONE;
                item.Note = itemToConvert.NOTESafe;
                item.NumeroProtocolloAntimafia = itemToConvert.PROTOCOLLO_ANTIMAFIASafe;
                item.IdRegistro = itemToConvert.IDOBJ_REGISTRO;
                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaModifica = itemToConvert.DATAORAULTMOD;
                item.OperatoreUltimaModifica = itemToConvert.OPERATOREULTMODSafe;
            }
            return item;
        }

        public static GVCTCOM_CARICHE Convert(ComunicazioneCaricaSocialeFDT itemToConvert)
        {
            GVCTCOM_CARICHE item = null;
            if (itemToConvert != null)
            {
                item = new GVCTCOM_CARICHE();
                item.IDOBJ = itemToConvert.IdComunicazioneCaricaSociale;
                item.IDOBJ_REGISTRO = itemToConvert.IdRegistro;
                if (itemToConvert.DataComunicazione.HasValue)
                    item.DATA_COMUNICAZIONE = itemToConvert.DataComunicazione.Value;
                if (itemToConvert.DataComunicazioneAntimafia.HasValue)
                    item.DATA_ANTIMAFIA = itemToConvert.DataComunicazioneAntimafia.Value;
                item.DATA_SITUAZIONE = itemToConvert.DataSituazione;
                item.PROTOCOLLO_ANTIMAFIA = itemToConvert.NumeroProtocolloAntimafia;
                item.NOTE = itemToConvert.Note;
                if (itemToConvert.DataUltimaModifica.HasValue)
                    item.DATAORAULTMOD = itemToConvert.DataUltimaModifica.Value;
                item.OPERATOREULTMOD = itemToConvert.OperatoreUltimaModifica;
            }
            return item;
        }

        public static ComunicazioneCaricaSocialeFDT[] ConvertAll(GVCTCOM_CARICHE[] itemsToConvert)
        {
            List<ComunicazioneCaricaSocialeFDT> listItem = new List<ComunicazioneCaricaSocialeFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCTCOM_CARICHE item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCTCOM_CARICHE[] ConvertAll(ComunicazioneCaricaSocialeFDT[] itemsToConvert)
        {
            List<GVCTCOM_CARICHE> listItem = new List<GVCTCOM_CARICHE>();
            if (itemsToConvert != null)
            {
                foreach (ComunicazioneCaricaSocialeFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }


		#endregion Methods 

    }
}
