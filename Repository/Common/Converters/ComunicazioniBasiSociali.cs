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

        public static ComunicazioneBaseSocialeFDT Convert(GVCTCOM_BASE_SOCIALE itemToConvert)
        {
            ComunicazioneBaseSocialeFDT item = null;
            if (itemToConvert != null)
            {
                item = new ComunicazioneBaseSocialeFDT();
                item.IdComunicazioneBaseSociale = itemToConvert.IDOBJ;
                if (!itemToConvert.IsCAPITALE_SOTTOSCRITTONull)
                    item.CapitaleSottoscritto = itemToConvert.CAPITALE_SOTTOSCRITTO;
                if (!itemToConvert.IsCAPITALE_VERSATONull)
                    item.CapitaleVersato = itemToConvert.CAPITALE_VERSATO;
                item.TipoConferimentoCapitale = itemToConvert.CONFERIMENTO_CAPITALESafe;
                if (!itemToConvert.IsDATA_COMUNICAZIONENull)
                    item.DataComunicazione = itemToConvert.DATA_COMUNICAZIONE;
                item.DataSituazione = itemToConvert.DATA_SITUAZIONE;
                item.IdRegistro = itemToConvert.IDOBJ_REGISTRO;
                if (!itemToConvert.IsLAVORATORINull)
                    item.Lavoratori = itemToConvert.LAVORATORI;
                else
                    item.Lavoratori = 0;
                if (!itemToConvert.IsLAVORATORI_REMUNERATINull)
                    item.LavoratoriRemunerati = itemToConvert.LAVORATORI_REMUNERATI;
                else
                    item.LavoratoriRemunerati = 0;
                if (!itemToConvert.IsLAVORATORI_SOCINull)
                    item.LavoratoriSoci = itemToConvert.LAVORATORI_SOCI;
                else
                    item.LavoratoriSoci = 0;
                if (!itemToConvert.IsLAVORATORI_TUTTINull)
                    item.LavoratoriSociENon = itemToConvert.LAVORATORI_TUTTI;
                else
                    item.LavoratoriSociENon = 0;
                item.Note = itemToConvert.NOTESafe;
                if (!itemToConvert.IsALTRI_SOCINull)
                    item.SociAltreTipologie = itemToConvert.ALTRI_SOCI;
                else
                    item.SociAltreTipologie = 0;
                if (!itemToConvert.IsPERSONE_SVANTAGGIATENull)
                    item.PersoneSvantaggiate = itemToConvert.PERSONE_SVANTAGGIATE;
                else
                    item.PersoneSvantaggiate = 0;
                if (!itemToConvert.IsSOCI_COOPERATORINull)
                    item.SociCooperatori = itemToConvert.SOCI_COOPERATORI;
                else
                    item.SociCooperatori = 0;
                if (!itemToConvert.IsSOCI_PGNull)
                    item.SociPersoneGiuridiche = itemToConvert.SOCI_PG;
                else
                    item.SociPersoneGiuridiche = 0;
                if (!itemToConvert.IsSOCI_SOVVENTORINull)
                    item.SociSovventori = itemToConvert.SOCI_SOVVENTORI;
                else
                    item.SociSovventori = 0;
                if (!itemToConvert.IsSOCI_UTENTINull)
                    item.SociUtenti = itemToConvert.SOCI_UTENTI;
                else
                    item.SociUtenti = 0;
                if (!itemToConvert.IsSOCI_VOLONTARINull)
                    item.SociVolontari = itemToConvert.SOCI_VOLONTARI;
                else
                    item.SociVolontari = 0;
                if (!itemToConvert.IsVALORE_AZIONENull)
                    item.ValoreAzione = itemToConvert.VALORE_AZIONE;
                if (!itemToConvert.IsVALORE_QUOTENull)
                    item.ValoreQuote = itemToConvert.VALORE_QUOTE;
                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaModifica = itemToConvert.DATAORAULTMOD;
                item.OperatoreUltimaModifica = itemToConvert.OPERATOREULTMODSafe;
            }
            return item;
        }

        public static GVCTCOM_BASE_SOCIALE Convert(ComunicazioneBaseSocialeFDT itemToConvert)
        {
            GVCTCOM_BASE_SOCIALE item = null;
            if (itemToConvert != null)
            {
                item = new GVCTCOM_BASE_SOCIALE();
                item.IDOBJ = itemToConvert.IdComunicazioneBaseSociale;
                item.ALTRI_SOCI = itemToConvert.SociAltreTipologie;
                if (itemToConvert.CapitaleSottoscritto.HasValue)
                    item.CAPITALE_SOTTOSCRITTO = itemToConvert.CapitaleSottoscritto.Value;
                if (itemToConvert.CapitaleVersato.HasValue)
                    item.CAPITALE_VERSATO = itemToConvert.CapitaleVersato.Value;
                item.CONFERIMENTO_CAPITALE = itemToConvert.TipoConferimentoCapitale;
                if (itemToConvert.DataComunicazione.HasValue)
                    item.DATA_COMUNICAZIONE = itemToConvert.DataComunicazione.Value;
                item.DATA_SITUAZIONE = itemToConvert.DataSituazione;
                item.IDOBJ_REGISTRO = itemToConvert.IdRegistro;
                item.LAVORATORI = itemToConvert.Lavoratori;
                item.LAVORATORI_REMUNERATI = itemToConvert.LavoratoriRemunerati;
                item.LAVORATORI_SOCI = itemToConvert.LavoratoriSoci;
                item.LAVORATORI_TUTTI = itemToConvert.LavoratoriSociENon;
                item.NOTE = itemToConvert.Note;
                item.PERSONE_SVANTAGGIATE = itemToConvert.PersoneSvantaggiate;
                item.SOCI_COOPERATORI = itemToConvert.SociCooperatori;
                item.SOCI_PG = itemToConvert.SociPersoneGiuridiche;
                item.SOCI_SOVVENTORI = itemToConvert.SociSovventori;
                item.SOCI_UTENTI = itemToConvert.SociUtenti;
                item.SOCI_VOLONTARI = itemToConvert.SociVolontari;
                item.VALORE_AZIONE = itemToConvert.ValoreAzione;
                item.VALORE_QUOTE = itemToConvert.ValoreQuote;
                if (itemToConvert.DataUltimaModifica.HasValue)
                    item.DATAORAULTMOD = itemToConvert.DataUltimaModifica.Value;
                item.OPERATOREULTMOD = itemToConvert.OperatoreUltimaModifica;
            }
            return item;
        }

        public static ComunicazioneBaseSocialeFDT[] ConvertAll(GVCTCOM_BASE_SOCIALE[] itemsToConvert)
        {
            List<ComunicazioneBaseSocialeFDT> listItem = new List<ComunicazioneBaseSocialeFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCTCOM_BASE_SOCIALE item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCTCOM_BASE_SOCIALE[] ConvertAll(ComunicazioneBaseSocialeFDT[] itemsToConvert)
        {
            List<GVCTCOM_BASE_SOCIALE> listItem = new List<GVCTCOM_BASE_SOCIALE>();
            if (itemsToConvert != null)
            {
                foreach (ComunicazioneBaseSocialeFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }


		#endregion Methods 

    }
}
