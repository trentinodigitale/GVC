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

        public static LiquidazioneCoattaFDT Convert(GVCTLIQUIDAZIONI_COATTE itemToConvert)
        {
            LiquidazioneCoattaFDT item = null;
            if (itemToConvert != null)
            {
                item = new LiquidazioneCoattaFDT();
                item.IdLiquidazioneCoatta = itemToConvert.IDOBJ;

                item.CodiceUfficio = itemToConvert.CODICE_UFFICIOSafe;
                if (!itemToConvert.IsDATA_DELIBERANull)
                    item.DataDeliberaCommissione = itemToConvert.DATA_DELIBERA;
                if (!itemToConvert.IsDATA_DELIBERA_GIUNTANull)
                    item.DataDeliberaGiunta = itemToConvert.DATA_DELIBERA_GIUNTA;
                if (!itemToConvert.IsDATA_DELIBERA_REVOCANull)
                    item.DataDeliberaRevoca = itemToConvert.DATA_DELIBERA_REVOCA;
                if (!itemToConvert.IsDATA_DEPOSITO_RINull)
                    item.DataDepositoRI = itemToConvert.DATA_DEPOSITO_RI;
                if (!itemToConvert.IsDATA_DETERMINANull)
                    item.DataDetermina = itemToConvert.DATA_DETERMINA;
                if (!itemToConvert.IsDATA_DETERMINA_REVOCANull)
                    item.DataDeterminaRevoca = itemToConvert.DATA_DETERMINA_REVOCA;
                if (!itemToConvert.IsDATA_INSOLVENZANull)
                    item.DataSentenzaInsolvenza = itemToConvert.DATA_INSOLVENZA;
                if (!itemToConvert.IsDATA_PUBBLICAZIONENull)
                    item.DataPubblicazioneGU = itemToConvert.DATA_PUBBLICAZIONE;
                item.DepositoBFL = itemToConvert.DEPOSITO_BFL == 1 ? true : false;
                item.IdRegistro = itemToConvert.IDOBJ_REGISTRO;
                item.IdTipoLiquidazioneCoatta = itemToConvert.IDOBJ_TIPO_LIQUIDAZIONE;
                item.NumeroDeliberaCommissione = itemToConvert.NUMERO_DELIBERASafe;
                item.NumeroDeliberaGiunta = itemToConvert.NUMERO_DELIBERA_GIUNTASafe;
                item.NumeroDeliberaRevoca = itemToConvert.NUMERO_DELIBERA_REVOCASafe;
                item.NumeroDetermina = itemToConvert.NUMERO_DETERMINASafe;
                item.NumeroDeterminaRevoca = itemToConvert.NUMERO_DETERMINA_REVOCASafe;
                item.ProceduraTerminata = itemToConvert.PROCEDURA_CONCLUSA == 1 ? true : false;
                item.ProceduraRevocata = itemToConvert.PROCEDURA_REVOCATA == 1 ? true : false;
                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaModifica = itemToConvert.DATAORAULTMOD;
                item.OperatoreUltimaModifica = itemToConvert.OPERATOREULTMODSafe;
            }
            return item;
        }

        public static GVCTLIQUIDAZIONI_COATTE Convert(LiquidazioneCoattaFDT itemToConvert)
        {
            GVCTLIQUIDAZIONI_COATTE item = null;
            if (itemToConvert != null)
            {
                item = new GVCTLIQUIDAZIONI_COATTE();
                item.IDOBJ = itemToConvert.IdLiquidazioneCoatta;
                item.CODICE_UFFICIO = itemToConvert.CodiceUfficio;
                if (itemToConvert.DataDeliberaCommissione.HasValue)
                    item.DATA_DELIBERA = itemToConvert.DataDeliberaCommissione.Value;
                if (itemToConvert.DataDeliberaGiunta.HasValue)
                    item.DATA_DELIBERA_GIUNTA = itemToConvert.DataDeliberaGiunta.Value;
                if (itemToConvert.DataDeliberaRevoca.HasValue)
                    item.DATA_DELIBERA_REVOCA = itemToConvert.DataDeliberaRevoca.Value;
                if (itemToConvert.DataDepositoRI.HasValue)
                    item.DATA_DEPOSITO_RI = itemToConvert.DataDepositoRI.Value;
                if (itemToConvert.DataDetermina.HasValue)
                    item.DATA_DETERMINA = itemToConvert.DataDetermina.Value;
                if (itemToConvert.DataDeterminaRevoca.HasValue)
                    item.DATA_DETERMINA_REVOCA = itemToConvert.DataDeterminaRevoca.Value;
                if (itemToConvert.DataSentenzaInsolvenza.HasValue)
                    item.DATA_INSOLVENZA = itemToConvert.DataSentenzaInsolvenza.Value;
                if (itemToConvert.DataPubblicazioneGU.HasValue)
                    item.DATA_PUBBLICAZIONE = itemToConvert.DataPubblicazioneGU.Value;
                item.DEPOSITO_BFL = itemToConvert.DepositoBFL == true ? 1 : 0;
                item.IDOBJ_REGISTRO = itemToConvert.IdRegistro;
                item.IDOBJ_TIPO_LIQUIDAZIONE = itemToConvert.IdTipoLiquidazioneCoatta;
                item.NUMERO_DELIBERA = itemToConvert.NumeroDeliberaCommissione;
                item.NUMERO_DELIBERA_GIUNTA = itemToConvert.NumeroDeliberaGiunta;
                item.NUMERO_DELIBERA_REVOCA = itemToConvert.NumeroDeliberaRevoca;
                item.NUMERO_DETERMINA = itemToConvert.NumeroDetermina;
                item.NUMERO_DETERMINA_REVOCA = itemToConvert.NumeroDeterminaRevoca;
                item.PROCEDURA_CONCLUSA = itemToConvert.ProceduraTerminata == true ? 1 : 0;
                item.PROCEDURA_REVOCATA = itemToConvert.ProceduraRevocata == true ? 1 : 0;
                if (itemToConvert.DataUltimaModifica.HasValue)
                    item.DATAORAULTMOD = itemToConvert.DataUltimaModifica.Value;
                item.OPERATOREULTMOD = itemToConvert.OperatoreUltimaModifica;
            }
            return item;
        }

        public static LiquidazioneCoattaFDT[] ConvertAll(GVCTLIQUIDAZIONI_COATTE[] itemsToConvert)
        {
            List<LiquidazioneCoattaFDT> listItem = new List<LiquidazioneCoattaFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCTLIQUIDAZIONI_COATTE item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCTLIQUIDAZIONI_COATTE[] ConvertAll(LiquidazioneCoattaFDT[] itemsToConvert)
        {
            List<GVCTLIQUIDAZIONI_COATTE> listItem = new List<GVCTLIQUIDAZIONI_COATTE>();
            if (itemsToConvert != null)
            {
                foreach (LiquidazioneCoattaFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }


		#endregion Methods 

    }
}
