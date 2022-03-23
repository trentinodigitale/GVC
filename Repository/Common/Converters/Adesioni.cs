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

        public static AdesioneFDT Convert(GVCTADESIONI itemToConvert)
        {
            AdesioneFDT item = null;
            if (itemToConvert != null)
            {
                item = new AdesioneFDT();
                item.IdAdesione = itemToConvert.IDOBJ;
                item.IdRegistro = itemToConvert.IDOBJ_REGISTRO;
                item.IdAssociazione = itemToConvert.IDOBJ_ASSOCIAZIONE;
                if (!itemToConvert.IsDATA_FINE_ADESIONENull)
                    item.DataFine = itemToConvert.DATA_FINE_ADESIONE;
                if (!itemToConvert.IsDATA_ESAME_FINENull)
                    item.DataFineEsameCommissione = itemToConvert.DATA_ESAME_FINE;
                item.DataInizio = itemToConvert.DATA_INIZIO_ADESIONE;
                if (!itemToConvert.IsDATA_ESAME_INIZIONull)
                    item.DataInzioEsameCommissione = itemToConvert.DATA_ESAME_INIZIO;
                item.Note = itemToConvert.NOTESafe;
                item.Revisore = itemToConvert.REVISORE == 1 ? true : false;
                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaModifica = itemToConvert.DATAORAULTMOD;
                item.OperatoreUltimaModifica = itemToConvert.OPERATOREULTMODSafe;
            }
            return item;
        }

        public static GVCTADESIONI Convert(AdesioneFDT itemToConvert)
        {
            GVCTADESIONI item = null;
            if (itemToConvert != null)
            {
                item = new GVCTADESIONI();
                item.IDOBJ = itemToConvert.IdAdesione;
                item.IDOBJ_REGISTRO = itemToConvert.IdRegistro;
                item.IDOBJ_ASSOCIAZIONE = itemToConvert.IdAssociazione;
                if (itemToConvert.DataFine.HasValue)
                    item.DATA_FINE_ADESIONE = itemToConvert.DataFine.Value;
                if (itemToConvert.DataFineEsameCommissione.HasValue)
                    item.DATA_ESAME_FINE = itemToConvert.DataFineEsameCommissione.Value;
                item.DATA_INIZIO_ADESIONE = itemToConvert.DataInizio;
                if (itemToConvert.DataInzioEsameCommissione.HasValue)
                    item.DATA_ESAME_INIZIO = itemToConvert.DataInzioEsameCommissione.Value;
                item.NOTE = itemToConvert.Note;
                item.REVISORE = itemToConvert.Revisore == true ? 1 : 0;
                if (itemToConvert.DataUltimaModifica.HasValue)
                    item.DATAORAULTMOD = itemToConvert.DataUltimaModifica.Value;
                item.OPERATOREULTMOD = itemToConvert.OperatoreUltimaModifica;
            }
            return item;
        }

        public static AdesioneFDT[] ConvertAll(GVCTADESIONI[] itemsToConvert)
        {
            List<AdesioneFDT> listItem = new List<AdesioneFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCTADESIONI item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCTADESIONI[] ConvertAll(AdesioneFDT[] itemsToConvert)
        {
            List<GVCTADESIONI> listItem = new List<GVCTADESIONI>();
            if (itemsToConvert != null)
            {
                foreach (AdesioneFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }


		#endregion Methods 

    }
}
