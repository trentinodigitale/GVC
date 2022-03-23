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

        public static CaricaSocialeFDT Convert(GVCRCARICHE itemToConvert)
        {
            CaricaSocialeFDT item = null;
            if (itemToConvert != null)
            {
                item = new CaricaSocialeFDT();
                item.IdCarica = itemToConvert.IDOBJ;
                item.IdTipoCarica = itemToConvert.IDOBJ_TIPO_CARICA;
                item.IdComunicazione = itemToConvert.IDOBJ_COMUNICAZIONE;
                item.IdSoggetto = itemToConvert.IDOBJ_SOGGETTOSafe;
                if (!itemToConvert.IsDATA_INIZIONull)
                    item.DataInizio = itemToConvert.DATA_INIZIO;
                if (!itemToConvert.IsDATA_FINENull)
                    item.DataFine = itemToConvert.DATA_FINE;
                item.LegaleRappresentante = itemToConvert.FLAG_LEGALE == 1 ? true : false;
                item.Liquidatore = itemToConvert.FLAG_LIQUIDATORE == 1 ? true : false;
                item.RichiestaAntimafia = itemToConvert.ANTIMAFIA == 1 ? true : false;
                item.RichiestaAntimafiaArrivata = itemToConvert.ANTIMAFIA_ARRIVATA == 1 ? true : false;
                item.RichiestaAntimafiaProdotta = itemToConvert.ANTIMAFIA_PRODOTTA == 1 ? true : false;
                item.DescrizioneGSC = itemToConvert.SOCIO_GCSSafe;
                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaModifica = itemToConvert.DATAORAULTMOD;
                item.OperatoreUltimaModifica = itemToConvert.OPERATOREULTMODSafe;
            }
            return item;
        }

        public static GVCRCARICHE Convert(CaricaSocialeFDT itemToConvert)
        {
            GVCRCARICHE item = null;
            if (itemToConvert != null)
            {
                item = new GVCRCARICHE();
                item.IDOBJ = itemToConvert.IdCarica;
                item.IDOBJ_TIPO_CARICA = itemToConvert.IdTipoCarica;
                if (itemToConvert.DataFine.HasValue)
                    item.DATA_FINE = itemToConvert.DataFine.Value;
                if (itemToConvert.DataInizio.HasValue)
                    item.DATA_INIZIO = itemToConvert.DataInizio.Value;
                item.IDOBJ_COMUNICAZIONE = itemToConvert.IdComunicazione;
                if (itemToConvert.IdSoggetto > 0)
                    item.IDOBJ_SOGGETTO = itemToConvert.IdSoggetto;
                else
                    item.IsIDOBJ_SOGGETTONull = true;
                item.FLAG_LEGALE = itemToConvert.LegaleRappresentante == true ? 1 : 0;
                item.FLAG_LIQUIDATORE = itemToConvert.Liquidatore == true ? 1 : 0;
                item.ANTIMAFIA = itemToConvert.RichiestaAntimafia == true ? 1 : 0;
                item.ANTIMAFIA_ARRIVATA = itemToConvert.RichiestaAntimafiaArrivata == true ? 1 : 0;
                item.ANTIMAFIA_PRODOTTA = itemToConvert.RichiestaAntimafiaProdotta == true ? 1 : 0;
                item.SOCIO_GCS = itemToConvert.DescrizioneGSC;
                if (itemToConvert.DataUltimaModifica.HasValue)
                    item.DATAORAULTMOD = itemToConvert.DataUltimaModifica.Value;
                item.OPERATOREULTMOD = itemToConvert.OperatoreUltimaModifica;
            }
            return item;
        }

        public static CaricaSocialeFDT[] ConvertAll(GVCRCARICHE[] itemsToConvert)
        {
            List<CaricaSocialeFDT> listItem = new List<CaricaSocialeFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCRCARICHE item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCRCARICHE[] ConvertAll(CaricaSocialeFDT[] itemsToConvert)
        {
            List<GVCRCARICHE> listItem = new List<GVCRCARICHE>();
            if (itemsToConvert != null)
            {
                foreach (CaricaSocialeFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }


		#endregion Methods 

    }
}
