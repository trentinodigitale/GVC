using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.rtier.Service;


namespace it.dedagroup.GVC.Repository.Common.Converters
{
    public abstract partial class Converters
    {

        #region Methods (2)


        

        public static AggiornamentoFDT Convert(GVC_PARIX_UPD itemToConvert)
        {
            AggiornamentoFDT item = null;
            if (itemToConvert != null)
            {
                item = new AggiornamentoFDT();
                item.CciaaRegZ = itemToConvert.CCIAA_REGZ;
                item.CodiceFiscale = itemToConvert.CODICE_FISCALE;
                item.CooperativaByte = itemToConvert.DATI_IMPRESA;
                
                if (!itemToConvert.IsDATAORA_AGGIORNAMENTONull)
                    item.DataAggiornamento = itemToConvert.DATAORA_AGGIORNAMENTO;
                if (!itemToConvert.IsDATAORA_ALLINEAMENTOINGVCNull)
                    item.DataAllineamentoGvc = itemToConvert.DATAORA_ALLINEAMENTOINGVC;

                item.DataInscrizione = itemToConvert.DATA_ISCR_REA;
                if (!itemToConvert.IsDATAORA_INSERIMENTO_RECORDNull)
                    item.DataInserimento = itemToConvert.DATAORA_INSERIMENTO_RECORD;
                item.Denominazione = itemToConvert.DENOMINAZIONE;
                item.IdAggiornamento = itemToConvert.ID;
                item.NaturaGiuridica = itemToConvert.C_NATURA_GIURIDICASafe;
                item.NumeroRea = itemToConvert.N_ISCRIZIONE_REASafe;
                item.NumeroRI = itemToConvert.NUMERO_RISafe;
                item.TrackingId = itemToConvert.TRACKINGIDSafe;
            }
            return item;
        }

        //public static GVCTADESIONI Convert(AdesioneFDT itemToConvert)
        //{
        //    GVCTADESIONI item = null;
        //    if (itemToConvert != null)
        //    {
        //        item = new GVCTADESIONI();
        //        item.IDOBJ = itemToConvert.IdAdesione;
        //        item.IDOBJ_REGISTRO = itemToConvert.IdRegistro;
        //        item.IDOBJ_ASSOCIAZIONE = itemToConvert.IdAssociazione;
        //        if (itemToConvert.DataFine.HasValue)
        //            item.DATA_FINE_ADESIONE = itemToConvert.DataFine.Value;
        //        if (itemToConvert.DataFineEsameCommissione.HasValue)
        //            item.DATA_ESAME_FINE = itemToConvert.DataFineEsameCommissione.Value;
        //        item.DATA_INIZIO_ADESIONE = itemToConvert.DataInizio;
        //        if (itemToConvert.DataInzioEsameCommissione.HasValue)
        //            item.DATA_ESAME_INIZIO = itemToConvert.DataInzioEsameCommissione.Value;
        //        item.NOTE = itemToConvert.Note;
        //        item.REVISORE = itemToConvert.Revisore == true ? 1 : 0;
        //        if (itemToConvert.DataUltimaModifica.HasValue)
        //            item.DATAORAULTMOD = itemToConvert.DataUltimaModifica.Value;
        //        item.OPERATOREULTMOD = itemToConvert.OperatoreUltimaModifica;
        //    }
        //    return item;
        //}

        public static AggiornamentoFDT[] ConvertAll(GVC_PARIX_UPD[] itemsToConvert)
        {
            List<AggiornamentoFDT> listItem = new List<AggiornamentoFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVC_PARIX_UPD item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        //public static GVCTADESIONI[] ConvertAll(AdesioneFDT[] itemsToConvert)
        //{
        //    List<GVCTADESIONI> listItem = new List<GVCTADESIONI>();
        //    if (itemsToConvert != null)
        //    {
        //        foreach (AdesioneFDT item in itemsToConvert)
        //        {
        //            listItem.Add(Convert(item));
        //        }
        //    }
        //    return listItem.ToArray();
        //}


        #endregion Methods

    }
}
