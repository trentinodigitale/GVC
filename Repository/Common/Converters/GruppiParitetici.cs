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


        // Public Methods (4) 

        public static GruppoPariteticoFDT Convert(GVCDGRUPPI_PARITETICI itemToConvert)
        {
            GruppoPariteticoFDT item = null;
            if (itemToConvert != null)
            {
                item = new GruppoPariteticoFDT();
                item.IdGruppoParitetico = itemToConvert.IDOBJ;
                item.Note = itemToConvert.DESCRIZIONESafe;
                item.NumeroAtto = itemToConvert.NUMERO_ATTOSafe;
                if (!itemToConvert.IsDATA_ATTONull)
                    item.DataAtto = itemToConvert.DATA_ATTO;
                if (!itemToConvert.IsDATA_SCADENZANull)
                    item.DataFine = itemToConvert.DATA_SCADENZA;                                               
            }

            return item;
        }

        public static GVCDGRUPPI_PARITETICI Convert(GruppoPariteticoFDT itemToConvert)
        {
            GVCDGRUPPI_PARITETICI item = null;
            if (itemToConvert != null)
            {
                item = new GVCDGRUPPI_PARITETICI();
                item.IDOBJ = itemToConvert.IdGruppoParitetico;
                item.DESCRIZIONE = itemToConvert.Note;
                item.NUMERO_ATTO = itemToConvert.NumeroAtto;
                item.DATA_ATTO = itemToConvert.DataAtto;
                if (itemToConvert.DataFine.HasValue)
                    item.DATA_SCADENZA = itemToConvert.DataFine.Value;                
            }
            return item;
        }

        public static GruppoPariteticoFDT[] ConvertAll(GVCDGRUPPI_PARITETICI[] itemsToConvert)
        {
            List<GruppoPariteticoFDT> listItem = new List<GruppoPariteticoFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCDGRUPPI_PARITETICI item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCDGRUPPI_PARITETICI[] ConvertAll(GruppoPariteticoFDT[] itemsToConvert)
        {
            List<GVCDGRUPPI_PARITETICI> listItem = new List<GVCDGRUPPI_PARITETICI>();
            if (itemsToConvert != null)
            {
                foreach (GruppoPariteticoFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static CooperativaFDT ConvertIntoSocietaGruppo(GVCRSOCIETA_GRUPPO itemToConvert)
        {
            CooperativaFDT item = null;
            if (itemToConvert != null)
            {
                item = new CooperativaFDT();
                item.IdTipoSoggetto = itemToConvert.IDOBJ;
                item.IdSoggetto = itemToConvert.IDOBJ_SOGGETTO;
                item.RegistroCooperativa = new RegistroCooperativaFDT();                
                item.RegistroCooperativa.Dirigente = System.Convert.ToBoolean(itemToConvert.RUOLO_DIREZIONESafe);
            }

            return item;
        }

        public static GVCRSOCIETA_GRUPPO ConvertIntoSocietaGruppo(CooperativaFDT itemToConvert)
        {
            GVCRSOCIETA_GRUPPO item = null;
            if (itemToConvert != null)
            {
                item = new GVCRSOCIETA_GRUPPO();
                item.IDOBJ = itemToConvert.IdTipoSoggetto;
                item.IDOBJ_SOGGETTO = itemToConvert.IdSoggetto;
                item.RUOLO_DIREZIONE = System.Convert.ToInt32(itemToConvert.RegistroCooperativa.Dirigente);
            }
            return item;
        }

        public static CooperativaFDT[] ConvertAllIntoSocietaGruppo(GVCRSOCIETA_GRUPPO[] itemsToConvert)
        {
            List<CooperativaFDT> listItem = new List<CooperativaFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCRSOCIETA_GRUPPO item in itemsToConvert)
                {
                    listItem.Add(ConvertIntoSocietaGruppo(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCRSOCIETA_GRUPPO[] ConvertAllIntoSocietaGruppo(CooperativaFDT[] itemsToConvert)
        {
            List<GVCRSOCIETA_GRUPPO> listItem = new List<GVCRSOCIETA_GRUPPO>();
            if (itemsToConvert != null)
            {
                foreach (CooperativaFDT item in itemsToConvert)
                {
                    listItem.Add(ConvertIntoSocietaGruppo(item));
                }
            }
            return listItem.ToArray();
        }


        #endregion Methods

    }
}
