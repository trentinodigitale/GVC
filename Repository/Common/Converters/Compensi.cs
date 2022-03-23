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

        public static CompensoFDT Convert(GVCTCOMPENSI itemToConvert)
        {
            CompensoFDT item = null;
            if (itemToConvert != null)
            {
                item = new CompensoFDT();
                item.IdCompenso = itemToConvert.IDOBJ;
                if (!itemToConvert.IsCASSANull)
                item.ImportoCassa = itemToConvert.CASSA;
                if (!itemToConvert.IsCOMPENSONull)
                item.ImportoCompenso = itemToConvert.COMPENSO;
                item.IdIncarico = itemToConvert.IDOBJ_INCARICOSafe;
                item.IdLiquidazione = itemToConvert.IDOBJ_LIQUIDAZIONESafe;
                item.IdProcedura = itemToConvert.IDOBJ_PROCEDURASafe;
                item.IdRevisore = itemToConvert.IDOBJ_SOGGETTO;
                if (!itemToConvert.IsIVANull)
                item.ImportoIVA = itemToConvert.IVA;
                if (!itemToConvert.IsPERCENTUALE_CNPNull)
                item.PercentualeCNP = itemToConvert.PERCENTUALE_CNP;
                if (!itemToConvert.IsPERCENTUALE_IVANull)
                item.PercentualeIVA = itemToConvert.PERCENTUALE_IVA;
                if (!itemToConvert.IsSPESENull)
                item.ImportoSpese = itemToConvert.SPESE;
                if (!itemToConvert.IsTOTALENull)
                item.ImportoTotale = itemToConvert.TOTALE;
                item.Valuta = itemToConvert.VALUTASafe;
                item.TipoContributo = itemToConvert.TIPO_CONTRIBUTOSafe;
                item.NumeroDetermina = itemToConvert.NUMERO_DETERMINASafe;
                if (!itemToConvert.IsDATA_DETERMINANull)
                    item.DataDetermina = itemToConvert.DATA_DETERMINA;
                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaModifica = itemToConvert.DATAORAULTMOD;
                item.OperatoreUltimaModifica = itemToConvert.OPERATOREULTMODSafe;
            }
            return item;
        }

        public static GVCTCOMPENSI Convert(CompensoFDT itemToConvert)
        {
            GVCTCOMPENSI item = null;
            if (itemToConvert != null)
            {
                item = new GVCTCOMPENSI();
                item.IDOBJ = itemToConvert.IdCompenso;
                item.CASSA = itemToConvert.ImportoCassa;
                item.COMPENSO = itemToConvert.ImportoCompenso;

                if (itemToConvert.IdIncarico > 0)
                {
                    item.IDOBJ_INCARICO = itemToConvert.IdIncarico;
                }
                else
                {
                    item.IsIDOBJ_INCARICONull = true;
                }

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

                item.IDOBJ_SOGGETTO = itemToConvert.IdRevisore;
                item.IVA = itemToConvert.ImportoIVA;
                item.PERCENTUALE_CNP = itemToConvert.PercentualeCNP;
                item.PERCENTUALE_IVA = itemToConvert.PercentualeIVA;
                item.SPESE = itemToConvert.ImportoSpese;
                item.TOTALE = itemToConvert.ImportoTotale;
                item.VALUTA = itemToConvert.Valuta;
                item.TIPO_CONTRIBUTO = itemToConvert.TipoContributo;
                item.NUMERO_DETERMINA = itemToConvert.NumeroDetermina;
                if (itemToConvert.DataDetermina.HasValue)
                    item.DATA_DETERMINA = itemToConvert.DataDetermina.Value;
                if (itemToConvert.DataUltimaModifica.HasValue)
                    item.DATAORAULTMOD = itemToConvert.DataUltimaModifica.Value;
                item.OPERATOREULTMOD = itemToConvert.OperatoreUltimaModifica;
            }
            return item;
        }

        public static CompensoFDT[] ConvertAll(GVCTCOMPENSI[] itemsToConvert)
        {
            List<CompensoFDT> listItem = new List<CompensoFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCTCOMPENSI item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCTCOMPENSI[] ConvertAll(CompensoFDT[] itemsToConvert)
        {
            List<GVCTCOMPENSI> listItem = new List<GVCTCOMPENSI>();
            if (itemsToConvert != null)
            {
                foreach (CompensoFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }


		#endregion Methods 

    }
}
