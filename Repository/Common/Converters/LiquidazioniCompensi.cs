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

        public static CompensoLiquidazioneFDT Convert(GVCTLIQUIDAZIONE_COMPENSI itemToConvert)
        {
            CompensoLiquidazioneFDT item = null;
            if (itemToConvert != null)
            {
                item = new CompensoLiquidazioneFDT();
                item.IdCompensoLiquidazione = itemToConvert.IDOBJ;
                if (!itemToConvert.IsDATA_DETERMINANull)
                    item.DataDetermina = itemToConvert.DATA_DETERMINA;
                if (!itemToConvert.IsDATA_DOMANDANull)
                    item.DataRicevimentoDomanda = itemToConvert.DATA_DOMANDA;
                if (!itemToConvert.IsDATA_MANDATONull)
                    item.DataMandatoPagamento = itemToConvert.DATA_MANDATO;
                item.IdLiquidazione = itemToConvert.IDOBJ_LIQUIDAZIONESafe;
                item.IdProcedura = itemToConvert.IDOBJ_PROCEDURASafe;
                item.IdRevisione = itemToConvert.IDOBJ_REVISIONESafe;
                if (!itemToConvert.IsIMPORTO_CONTRIBUTONull)
                    item.ImportoErogato = itemToConvert.IMPORTO_CONTRIBUTO;
                if (!itemToConvert.IsIMPORTO_DETERMINATONull)
                    item.ImportoDeterminato = itemToConvert.IMPORTO_DETERMINATO;
                if (!itemToConvert.IsIMPORTO_RICHIESTONull)
                    item.ImportoRichiesto = itemToConvert.IMPORTO_RICHIESTO;
                if (!itemToConvert.IsIMPORTO_SPESENull)
                    item.ImportoSpeseBFL = itemToConvert.IMPORTO_SPESE;
                item.Liquidato = (!itemToConvert.IsLIQUIDATONull &&
                   itemToConvert.LIQUIDATO == 1) ? true : false;
                item.Note = itemToConvert.NOTESafe;
                item.NumeroDetermina = itemToConvert.NUMERO_DETERMINASafe;
                item.NumeroMandatoPagamento = itemToConvert.NUMERO_MANDATOSafe;
                if (!itemToConvert.IsPERCENTUALE_CONTRIBUTONull)
                    item.PercentualeContributoPAT = itemToConvert.PERCENTUALE_CONTRIBUTO;
                item.TipoContributo = itemToConvert.TIPO_CONTRIBUTOSafe;
                item.Valuta = itemToConvert.VALUTASafe;

                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaModifica = itemToConvert.DATAORAULTMOD;
                item.OperatoreUltimaModifica = itemToConvert.OPERATOREULTMODSafe;
            }
            return item;
        }

        public static GVCTLIQUIDAZIONE_COMPENSI Convert(CompensoLiquidazioneFDT itemToConvert)
        {
            GVCTLIQUIDAZIONE_COMPENSI item = null;
            if (itemToConvert != null)
            {
                item = new GVCTLIQUIDAZIONE_COMPENSI();
                item.IDOBJ = itemToConvert.IdCompensoLiquidazione;
                if (itemToConvert.DataDetermina.HasValue)
                    item.DATA_DETERMINA = itemToConvert.DataDetermina.Value;
                if (itemToConvert.DataRicevimentoDomanda.HasValue)
                    item.DATA_DOMANDA = itemToConvert.DataRicevimentoDomanda.Value;
                if (itemToConvert.DataMandatoPagamento.HasValue)
                    item.DATA_MANDATO = itemToConvert.DataMandatoPagamento.Value;
                if (itemToConvert.IdLiquidazione > 0)
                {
                    item.IDOBJ_LIQUIDAZIONE = itemToConvert.IdLiquidazione;
                }
                else
                {
                    item.IsIDOBJ_LIQUIDAZIONENull = true;
                }
                if (itemToConvert.IdProcedura > 0)
                {
                    item.IDOBJ_PROCEDURA = itemToConvert.IdProcedura;
                }
                else
                {
                    item.IsIDOBJ_PROCEDURANull = true;
                }
                 if (itemToConvert.IdRevisione > 0)
                 {
                     item.IDOBJ_REVISIONE = itemToConvert.IdRevisione;
                 }
                 else
                 {
                     item.IsIDOBJ_REVISIONENull = true;
                 }
                item.IMPORTO_CONTRIBUTO = itemToConvert.ImportoErogato;
                item.IMPORTO_DETERMINATO = itemToConvert.ImportoDeterminato;
                item.IMPORTO_RICHIESTO = itemToConvert.ImportoRichiesto;
                item.IMPORTO_SPESE = itemToConvert.ImportoSpeseBFL;
                item.LIQUIDATO = (itemToConvert.Liquidato == true) ? 1 : 0;
                item.NOTE = itemToConvert.Note;
                item.NUMERO_DETERMINA = itemToConvert.NumeroDetermina;
                item.NUMERO_MANDATO = itemToConvert.NumeroMandatoPagamento;
                item.PERCENTUALE_CONTRIBUTO = itemToConvert.PercentualeContributoPAT;
                item.TIPO_CONTRIBUTO = itemToConvert.TipoContributo;
                item.VALUTA = itemToConvert.Valuta;

                if (itemToConvert.DataUltimaModifica.HasValue)
                    item.DATAORAULTMOD = itemToConvert.DataUltimaModifica.Value;
                item.OPERATOREULTMOD = itemToConvert.OperatoreUltimaModifica;
            }
            return item;
        }

        public static CompensoLiquidazioneFDT[] ConvertAll(GVCTLIQUIDAZIONE_COMPENSI[] itemsToConvert)
        {
            List<CompensoLiquidazioneFDT> listItem = new List<CompensoLiquidazioneFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCTLIQUIDAZIONE_COMPENSI item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCTLIQUIDAZIONE_COMPENSI[] ConvertAll(CompensoLiquidazioneFDT[] itemsToConvert)
        {
            List<GVCTLIQUIDAZIONE_COMPENSI> listItem = new List<GVCTLIQUIDAZIONE_COMPENSI>();
            if (itemsToConvert != null)
            {
                foreach (CompensoLiquidazioneFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }


		#endregion Methods 

    }
}
