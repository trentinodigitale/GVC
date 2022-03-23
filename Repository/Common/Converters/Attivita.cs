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

        public static AttivitaFDT Convert(GVCTATTIVITA itemToConvert)
        {
            AttivitaFDT item = null;
            if (itemToConvert != null)
            {
                item = new AttivitaFDT();
                item.IdAttivita = itemToConvert.IDOBJ;
                item.IdTipoAttivita = itemToConvert.IDOBJ_CODICE_ATECO;
                item.Importanza = itemToConvert.IMPORTANZASafe;
                item.InfoCamere = itemToConvert.ATTIVITA_CCIAA == 1 ? true : false;
                item.Stato = itemToConvert.STATO_ATTIVITASafe;
                if (!itemToConvert.IsDATA_INIZIONull)
                    item.DataInizio = itemToConvert.DATA_INIZIO;
                item.Note = itemToConvert.NOTESafe;
                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaModifica = itemToConvert.DATAORAULTMOD;
                item.OperatoreUltimaModifica = itemToConvert.OPERATOREULTMODSafe;
            }
            return item;
        }

        public static GVCTATTIVITA Convert(AttivitaFDT itemToConvert)
        {
            GVCTATTIVITA item = null;
            if (itemToConvert != null)
            {
                item = new GVCTATTIVITA();
                item.IDOBJ = itemToConvert.IdAttivita;
                item.IDOBJ_REGISTRO = itemToConvert.IdRegistro;
                item.IDOBJ_CODICE_ATECO = itemToConvert.IdTipoAttivita;
                item.IMPORTANZA = itemToConvert.Importanza;
                item.ATTIVITA_CCIAA = itemToConvert.InfoCamere == true ? 1 : 0;
                item.STATO_ATTIVITA = itemToConvert.Stato;
                if (itemToConvert.DataInizio.HasValue)
                    item.DATA_INIZIO = itemToConvert.DataInizio.Value;
                item.NOTE = itemToConvert.Note;
                if (itemToConvert.DataUltimaModifica.HasValue)
                    item.DATAORAULTMOD = itemToConvert.DataUltimaModifica.Value;
                item.OPERATOREULTMOD = itemToConvert.OperatoreUltimaModifica;
            }
            return item;
        }

        public static AttivitaFDT[] ConvertAll(GVCTATTIVITA[] itemsToConvert)
        {
            List<AttivitaFDT> listItem = new List<AttivitaFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCTATTIVITA item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCTATTIVITA[] ConvertAll(AttivitaFDT[] itemsToConvert)
        {
            List<GVCTATTIVITA> listItem = new List<GVCTATTIVITA>();
            if (itemsToConvert != null)
            {
                foreach (AttivitaFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }


		#endregion Methods 

    }
}
