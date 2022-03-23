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

        public static BilancioFDT Convert(GVCTBILANCI itemToConvert)
        {
            BilancioFDT item = null;
            if (itemToConvert != null)
            {
                item = new BilancioFDT();
                item.IdBilancio = itemToConvert.IDOBJ;
                item.IdRegistro = itemToConvert.IDOBJ_REGISTRO;
                item.IdTipoBilancio = itemToConvert.IDOBJ_TIPO_BILANCIO;
                item.Anno = itemToConvert.ANNO_RIFERIMENTO;
                if (!itemToConvert.IsDATA_DEPOSITO_RINull)
                    item.DataDepositoBilancioRI = itemToConvert.DATA_DEPOSITO_RI;
                if (!itemToConvert.IsDATA_RIFERIMENTONull)
                    item.DataEsercizio = itemToConvert.DATA_RIFERIMENTO;
                if (!itemToConvert.IsDATA_SEGNALAZIONENull)
                    item.DataSegnalazioneRevisoreLegale = itemToConvert.DATA_SEGNALAZIONE;
                item.ImportoPatrimonio = itemToConvert.IMPORTO_PATRIMONIO;
                item.ImportoPercUtili = itemToConvert.IMPORTO_PERCENTO_UTILI;
                if (itemToConvert.VERIFICA_PAGAMENTOSafe > 0)
                    item.Pagamento = itemToConvert.VERIFICA_PAGAMENTOSafe; // == 1 ? true : false;
                item.RequisitiPrevalenzaRapportiSoci = itemToConvert.REQUISITO_PREVALENZASafe;
                item.Note = itemToConvert.NOTESafe;
                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaModifica = itemToConvert.DATAORAULTMOD;
                item.OperatoreUltimaModifica = itemToConvert.OPERATOREULTMODSafe;
            }
            return item;
        }

        public static GVCTBILANCI Convert(BilancioFDT itemToConvert)
        {
            GVCTBILANCI item = null;
            if (itemToConvert != null)
            {
                item = new GVCTBILANCI();
                item.IDOBJ = itemToConvert.IdBilancio;
                item.IDOBJ_REGISTRO = itemToConvert.IdRegistro;
                item.ANNO_RIFERIMENTO = itemToConvert.Anno;
                if (itemToConvert.DataDepositoBilancioRI.HasValue)
                    item.DATA_DEPOSITO_RI = itemToConvert.DataDepositoBilancioRI.Value;
                if (itemToConvert.DataEsercizio.HasValue)
                    item.DATA_RIFERIMENTO = itemToConvert.DataEsercizio.Value;
                if (itemToConvert.DataSegnalazioneRevisoreLegale.HasValue)
                    item.DATA_SEGNALAZIONE = itemToConvert.DataSegnalazioneRevisoreLegale.Value;
                item.IDOBJ_TIPO_BILANCIO = itemToConvert.IdTipoBilancio;
                item.IMPORTO_PATRIMONIO = itemToConvert.ImportoPatrimonio;
                item.IMPORTO_PERCENTO_UTILI = itemToConvert.ImportoPercUtili;
                if (itemToConvert.Pagamento > 0)
                    item.VERIFICA_PAGAMENTO = itemToConvert.Pagamento; // == true ? 1 : 0;
                item.REQUISITO_PREVALENZA = itemToConvert.RequisitiPrevalenzaRapportiSoci;
                item.NOTE = itemToConvert.Note;
                if (itemToConvert.DataUltimaModifica.HasValue)
                    item.DATAORAULTMOD = itemToConvert.DataUltimaModifica.Value;
                item.OPERATOREULTMOD = itemToConvert.OperatoreUltimaModifica;
            }
            return item;
        }

        public static BilancioFDT[] ConvertAll(GVCTBILANCI[] itemsToConvert)
        {
            List<BilancioFDT> listItem = new List<BilancioFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCTBILANCI item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCTBILANCI[] ConvertAll(BilancioFDT[] itemsToConvert)
        {
            List<GVCTBILANCI> listItem = new List<GVCTBILANCI>();
            if (itemsToConvert != null)
            {
                foreach (BilancioFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }


        #endregion Methods 

    }
}
