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

        public static ProceduraCoattaFDT Convert(GVCTPROCEDURE_COATTE itemToConvert)
        {
            ProceduraCoattaFDT item = null;
            if (itemToConvert != null)
            {
                item = new ProceduraCoattaFDT();
                item.IdProceduraCoatta = itemToConvert.IDOBJ;

                if (!itemToConvert.IsDATA_CONCLUSIONENull)
                    item.DataFineProcedura = itemToConvert.DATA_CONCLUSIONE;
                if (!itemToConvert.IsDATA_DELIBERANull)
                    item.DataDeliberaCommissione = itemToConvert.DATA_DELIBERA;
                if (!itemToConvert.IsDATA_DELIBERA_FINENull)
                    item.DataDeliberaCommissioneFineIncarico = itemToConvert.DATA_DELIBERA_FINE;
                if (!itemToConvert.IsDATA_DETERMINANull)
                    item.DataDetermina = itemToConvert.DATA_DETERMINA;
                if (!itemToConvert.IsDATA_DETERMINA_FINENull)
                    item.DataDeterminaFineIncarico = itemToConvert.DATA_DETERMINA_FINE;
                if (!itemToConvert.IsDATA_INIZIONull)
                    item.DataInzioProcedura = itemToConvert.DATA_INIZIO;
                if (!itemToConvert.IsDATA_ISCRIZIONE_RINull)
                    item.DataIscrizioneRI = itemToConvert.DATA_ISCRIZIONE_RI;
                if (!itemToConvert.IsDATA_SCADENZANull)
                    item.DataScadenzaProcedura = itemToConvert.DATA_SCADENZA;
                item.IdRegistro = itemToConvert.IDOBJ_REGISTRO;
                item.IdTipoProceduraCoatta = itemToConvert.IDOBJ_TIPO_PROCEDURA;
                item.NumeroDeliberaCommissione = itemToConvert.NUMERO_DELIBERASafe;
                item.NumeroDeliberaCommissioneFineIncarico = itemToConvert.NUMERO_DELIBERA_FINESafe;
                item.NumeroDetermina = itemToConvert.NUMERO_DETERMINASafe;
                item.NumeroDeterminaFineIncarico = itemToConvert.NUMERO_DETERMINA_FINESafe;

                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaModifica = itemToConvert.DATAORAULTMOD;
                item.OperatoreUltimaModifica = itemToConvert.OPERATOREULTMODSafe;
            }
            return item;
        }

        public static GVCTPROCEDURE_COATTE Convert(ProceduraCoattaFDT itemToConvert)
        {
            GVCTPROCEDURE_COATTE item = null;
            if (itemToConvert != null)
            {
                item = new GVCTPROCEDURE_COATTE();
                item.IDOBJ = itemToConvert.IdProceduraCoatta;
                if (itemToConvert.DataFineProcedura.HasValue)
                    item.DATA_CONCLUSIONE = itemToConvert.DataFineProcedura.Value;
                if (itemToConvert.DataDeliberaCommissione.HasValue)
                    item.DATA_DELIBERA = itemToConvert.DataDeliberaCommissione.Value;
                if (itemToConvert.DataDeliberaCommissioneFineIncarico.HasValue)
                    item.DATA_DELIBERA_FINE = itemToConvert.DataDeliberaCommissioneFineIncarico.Value;
                if (itemToConvert.DataDetermina.HasValue)
                    item.DATA_DETERMINA = itemToConvert.DataDetermina.Value;
                if (itemToConvert.DataDeterminaFineIncarico.HasValue)
                    item.DATA_DETERMINA_FINE = itemToConvert.DataDeterminaFineIncarico.Value;
                if (itemToConvert.DataInzioProcedura.HasValue)
                    item.DATA_INIZIO = itemToConvert.DataInzioProcedura.Value;
                if (itemToConvert.DataIscrizioneRI.HasValue)
                    item.DATA_ISCRIZIONE_RI = itemToConvert.DataIscrizioneRI.Value;
                if (itemToConvert.DataScadenzaProcedura.HasValue)
                    item.DATA_SCADENZA = itemToConvert.DataScadenzaProcedura.Value;
                item.IDOBJ_REGISTRO = itemToConvert.IdRegistro;
                item.IDOBJ_TIPO_PROCEDURA = itemToConvert.IdTipoProceduraCoatta;
                item.NUMERO_DELIBERA = itemToConvert.NumeroDeliberaCommissione;
                item.NUMERO_DELIBERA_FINE = itemToConvert.NumeroDeliberaCommissioneFineIncarico;
                item.NUMERO_DETERMINA = itemToConvert.NumeroDetermina;
                item.NUMERO_DETERMINA_FINE = itemToConvert.NumeroDeterminaFineIncarico;

                if (itemToConvert.DataUltimaModifica.HasValue)
                    item.DATAORAULTMOD = itemToConvert.DataUltimaModifica.Value;
                item.OPERATOREULTMOD = itemToConvert.OperatoreUltimaModifica;
            }
            return item;
        }

        public static ProceduraCoattaFDT[] ConvertAll(GVCTPROCEDURE_COATTE[] itemsToConvert)
        {
            List<ProceduraCoattaFDT> listItem = new List<ProceduraCoattaFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCTPROCEDURE_COATTE item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCTPROCEDURE_COATTE[] ConvertAll(ProceduraCoattaFDT[] itemsToConvert)
        {
            List<GVCTPROCEDURE_COATTE> listItem = new List<GVCTPROCEDURE_COATTE>();
            if (itemsToConvert != null)
            {
                foreach (ProceduraCoattaFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }


		#endregion Methods 

    }
}
