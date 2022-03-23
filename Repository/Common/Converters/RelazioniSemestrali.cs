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

        public static RelazioneSemestraleFDT Convert(GVCTRELAZIONI_SEMESTRALI itemToConvert)
        {
            RelazioneSemestraleFDT item = null;
            if (itemToConvert != null)
            {
                item = new RelazioneSemestraleFDT();
                item.IdRelazioneSemestrale = itemToConvert.IDOBJ;
                if (!itemToConvert.IsDATA_ESAMENull)
                item.DataEsameufficio = itemToConvert.DATA_ESAME;
                if (!itemToConvert.IsDATA_PARERENull)
                item.DataEsitoCommissione = itemToConvert.DATA_PARERE;
                item.DataRelazione = itemToConvert.DATA_RELAZIONE;
                item.IdLiquidazione = itemToConvert.IDOBJ_LIQUIDAZIONE;
                item.Note = itemToConvert.NOTESafe;

                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaModifica = itemToConvert.DATAORAULTMOD;
                item.OperatoreUltimaModifica = itemToConvert.OPERATOREULTMODSafe;
            }
            return item;
        }

        public static GVCTRELAZIONI_SEMESTRALI Convert(RelazioneSemestraleFDT itemToConvert)
        {
            GVCTRELAZIONI_SEMESTRALI item = null;
            if (itemToConvert != null)
            {
                item = new GVCTRELAZIONI_SEMESTRALI();
                item.IDOBJ = itemToConvert.IdRelazioneSemestrale;
                if (itemToConvert.DataEsameufficio.HasValue)
                item.DATA_ESAME = itemToConvert.DataEsameufficio.Value;
                if (itemToConvert.DataEsitoCommissione.HasValue)
                item.DATA_PARERE = itemToConvert.DataEsitoCommissione.Value;
                if (itemToConvert.DataRelazione.HasValue)
                item.DATA_RELAZIONE = itemToConvert.DataRelazione.Value;
                item.IDOBJ_LIQUIDAZIONE = itemToConvert.IdLiquidazione;
                item.NOTE = itemToConvert.Note;

                if (itemToConvert.DataUltimaModifica.HasValue)
                    item.DATAORAULTMOD = itemToConvert.DataUltimaModifica.Value;
                item.OPERATOREULTMOD = itemToConvert.OperatoreUltimaModifica;
            }
            return item;
        }

        public static RelazioneSemestraleFDT[] ConvertAll(GVCTRELAZIONI_SEMESTRALI[] itemsToConvert)
        {
            List<RelazioneSemestraleFDT> listItem = new List<RelazioneSemestraleFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCTRELAZIONI_SEMESTRALI item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCTRELAZIONI_SEMESTRALI[] ConvertAll(RelazioneSemestraleFDT[] itemsToConvert)
        {
            List<GVCTRELAZIONI_SEMESTRALI> listItem = new List<GVCTRELAZIONI_SEMESTRALI>();
            if (itemsToConvert != null)
            {
                foreach (RelazioneSemestraleFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }


		#endregion Methods 

    }
}
