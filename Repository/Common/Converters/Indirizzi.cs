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

        public static IndirizzoFDT Convert(GVCTINDIRIZZI itemToConvert)
        {
            IndirizzoFDT item = null;
            if (itemToConvert != null)
            {
                item = new IndirizzoFDT();
                item.IdIndirizzo = itemToConvert.IDOBJ;
                item.Principale = itemToConvert.FLAG_PRINCIPALE == 1 ? true : false;
                item.Sede = itemToConvert.FLAG_SEDE == 1 ? true : false;
                item.Via = itemToConvert.VIA;
                item.IdSoggetto = itemToConvert.IDOBJ_SOGGETTO;
                item.IdTipoIndirizzo = itemToConvert.IDOBJ_TIPO_INDIRIZZO;
                item.NumeroCivico = itemToConvert.CIVICOSafe;
                item.Cap = itemToConvert.CAPSafe;
                item.Provincia = itemToConvert.PROVINCIASafe;
                item.Comune = itemToConvert.COMUNESafe;
                item.Frazione = itemToConvert.FRAZIONESafe;

                item.CodiceStradario = itemToConvert.CODICE_STRADARIOSafe;
                item.Telefono = itemToConvert.TELEFONOSafe;
                item.Fax = itemToConvert.FAXSafe;

                item.Email = itemToConvert.EMAILSafe;
                item.UrlPage = itemToConvert.WEBPAGESafe;
                item.Nazione = itemToConvert.STATOSafe;
                item.Altro = itemToConvert.ALTROSafe;
                item.Note = itemToConvert.NOTESafe;
                item.DataInizio = itemToConvert.DATA_INIZIO;
                if (!itemToConvert.IsDATA_FINENull)
                    item.DataFine = itemToConvert.DATA_FINE;
                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaModifica = itemToConvert.DATAORAULTMOD;
                item.OperatoreUltimaModifica = itemToConvert.OPERATOREULTMODSafe;
            }
            return item;
        }

        public static GVCTINDIRIZZI Convert(IndirizzoFDT itemToConvert)
        {
            GVCTINDIRIZZI item = null;
            if (itemToConvert != null)
            {
                item = new GVCTINDIRIZZI();
                item.IDOBJ = itemToConvert.IdIndirizzo;
                
                item.ALTRO = Strings.Cut.Get(itemToConvert.Altro, 0, 250);

                
                item.STATO = Strings.Cut.Get(itemToConvert.Nazione, 0, 3);
                
                item.CAP = Strings.Cut.Get(itemToConvert.Cap, 0 ,10);
                item.CIVICO = Strings.Cut.Get(itemToConvert.NumeroCivico, 0 , 10);
                item.CODICE_STRADARIO = Strings.Cut.Get(itemToConvert.CodiceStradario, 0, 10);
                item.COMUNE = Strings.Cut.Get(itemToConvert.Comune, 0, 50);
                if (itemToConvert.DataFine.HasValue)
                    item.DATA_FINE = itemToConvert.DataFine.Value;
                item.DATA_INIZIO = itemToConvert.DataInizio;
                item.FAX = itemToConvert.Fax;
                item.FLAG_PRINCIPALE = itemToConvert.Principale == true ? 1 : 0;
                item.FLAG_SEDE = itemToConvert.Sede == true ? 1 : 0;
                item.FRAZIONE = Strings.Cut.Get(itemToConvert.Frazione, 0, 250);
                item.IDOBJ_SOGGETTO = itemToConvert.IdSoggetto;
                item.IDOBJ_TIPO_INDIRIZZO = itemToConvert.IdTipoIndirizzo;
                item.NOTE = Strings.Cut.Get(itemToConvert.Note, 0, 1000);
                item.PROVINCIA = Strings.Cut.Get(itemToConvert.Provincia, 0,2);
                item.TELEFONO = Strings.Cut.Get(itemToConvert.Telefono, 0, 25);
                item.VIA = Strings.Cut.Get(itemToConvert.Via, 0, 250, 1);

                item.EMAIL = Strings.Cut.Get(itemToConvert.Email, 0,100);
                item.WEBPAGE = Strings.Cut.Get(itemToConvert.UrlPage, 0, 100);

                if (itemToConvert.DataUltimaModifica.HasValue)
                    item.DATAORAULTMOD = itemToConvert.DataUltimaModifica.Value;
                item.OPERATOREULTMOD = itemToConvert.OperatoreUltimaModifica;
            }
            return item;
        }

        public static IndirizzoFDT[] ConvertAll(GVCTINDIRIZZI[] itemsToConvert)
        {
            List<IndirizzoFDT> listItem = new List<IndirizzoFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCTINDIRIZZI item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCTINDIRIZZI[] ConvertAll(IndirizzoFDT[] itemsToConvert)
        {
            List<GVCTINDIRIZZI> listItem = new List<GVCTINDIRIZZI>();
            if (itemsToConvert != null)
            {
                foreach (IndirizzoFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }


		#endregion Methods 

    }
}
