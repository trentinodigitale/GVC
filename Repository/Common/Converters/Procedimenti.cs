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
        public static ProcedimentoFDT Convert(GVCTPROCEDIMENTI itemToConvert)
        {
            ProcedimentoFDT item = null;
            if (itemToConvert != null)
            {
                item = new ProcedimentoFDT();
                item.IdProcedimento = itemToConvert.IDOBJ;
                item.IdRegistro = itemToConvert.IDOBJ_REGISTRO;
                if (!itemToConvert.IsDATA_AVVISONull)
                    item.AvvisoInizioProcedimento = itemToConvert.DATA_AVVISO;
                if (!itemToConvert.IsDATA_FINENull)
                    item.DataConclusione = itemToConvert.DATA_FINE;
                if (!itemToConvert.IsDATA_TEORICA_FINENull)
                    item.DataFineTeorica = itemToConvert.DATA_TEORICA_FINE;
                if (!itemToConvert.IsDATA_INIZIONull)
                    item.DataInizioProcedimento = itemToConvert.DATA_INIZIO;
                if (!itemToConvert.IsDATA_RIATTIVAZIONENull)
                    item.DataRiattivazione = itemToConvert.DATA_RIATTIVAZIONE;
                if (!itemToConvert.IsDATA_TERMINE_FINENull)
                    item.DataTermineFinale = itemToConvert.DATA_TERMINE_FINE;
                item.IdTipoConclusione = itemToConvert.IDOBJ_TIPO_CONCLUSIONESafe;
                item.IdTipoIniziativa = itemToConvert.IDOBJ_TIPO_INIZIATIVA;
                item.IdTipoProcedimento = itemToConvert.IDOBJ_TIPO_PROCEDIMENTO;
                item.IdTipoSospensione = itemToConvert.IDOBJ_TIPO_SOSPENSIONESafe;
                item.MotivoSospensione = itemToConvert.MOTIVO_SOSPENSIONESafe;
                item.Tempi = itemToConvert.TEMPISafe;
                item.Note = itemToConvert.NOTESafe;
                item.Responsabile = itemToConvert.RESPONSABILESafe;
                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaModifica = itemToConvert.DATAORAULTMOD;
                item.OperatoreUltimaModifica = itemToConvert.OPERATOREULTMODSafe;
            }
            return item;
        }
        public static ProcedimentoFDT[] ConvertAll(GVCTPROCEDIMENTI[] itemsToConvert)
        {
            List<ProcedimentoFDT> listItem = new List<ProcedimentoFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCTPROCEDIMENTI item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }
        public static GVCTPROCEDIMENTI Convert(ProcedimentoFDT itemToConvert)
        {
            GVCTPROCEDIMENTI item = null;
            if (itemToConvert != null)
            {
                item = new GVCTPROCEDIMENTI();
                item.IDOBJ = itemToConvert.IdProcedimento;

                item.IDOBJ_REGISTRO = itemToConvert.IdRegistro;
                if (itemToConvert.AvvisoInizioProcedimento.HasValue)
                    item.DATA_AVVISO = itemToConvert.AvvisoInizioProcedimento.Value;
                if (itemToConvert.DataConclusione.HasValue)
                    item.DATA_FINE = itemToConvert.DataConclusione.Value;
                if (itemToConvert.DataFineTeorica.HasValue)
                    item.DATA_TEORICA_FINE = itemToConvert.DataFineTeorica.Value;
                if (itemToConvert.DataInizioProcedimento.HasValue)
                    item.DATA_INIZIO = itemToConvert.DataInizioProcedimento.Value;
                if (itemToConvert.DataRiattivazione.HasValue)
                    item.DATA_RIATTIVAZIONE = itemToConvert.DataRiattivazione.Value;
                if (itemToConvert.DataTermineFinale.HasValue)
                    item.DATA_TERMINE_FINE = itemToConvert.DataTermineFinale.Value;
                if (itemToConvert.IdTipoConclusione > 0)
                    item.IDOBJ_TIPO_CONCLUSIONE = itemToConvert.IdTipoConclusione;
                else
                    item.IsIDOBJ_TIPO_CONCLUSIONENull = true;
                item.IDOBJ_TIPO_INIZIATIVA = itemToConvert.IdTipoIniziativa;
                item.IDOBJ_TIPO_PROCEDIMENTO = itemToConvert.IdTipoProcedimento;
                if (itemToConvert.IdTipoSospensione > 0)
                    item.IDOBJ_TIPO_SOSPENSIONE = itemToConvert.IdTipoSospensione;
                else
                    item.IsIDOBJ_TIPO_SOSPENSIONENull = true;
                item.MOTIVO_SOSPENSIONE = itemToConvert.MotivoSospensione;
                item.TEMPI = itemToConvert.Tempi;
                item.NOTE = itemToConvert.Note;
                item.RESPONSABILE = itemToConvert.Responsabile;
                if (itemToConvert.DataUltimaModifica.HasValue)
                    item.DATAORAULTMOD = itemToConvert.DataUltimaModifica.Value;
                item.OPERATOREULTMOD = itemToConvert.OperatoreUltimaModifica;
            }
            return item;
        }
        public static GVCTPROCEDIMENTI[] ConvertAll(ProcedimentoFDT[] itemsToConvert)
        {
            List<GVCTPROCEDIMENTI> listItem = new List<GVCTPROCEDIMENTI>();
            if (itemsToConvert != null)
            {
                foreach (ProcedimentoFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

    }
}
