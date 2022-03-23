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

        public static RevisioneIncaricoFDT Convert(GVCTINCARICHI itemToConvert)
        {
            RevisioneIncaricoFDT item = null;
            if (itemToConvert != null)
            {
                item = new RevisioneIncaricoFDT();
                item.IdRevisioneIncarico = itemToConvert.IDOBJ;
                item.IdRevisione = itemToConvert.IDOBJ_REVISIONE;
                if (!itemToConvert.IsDATA_DELIBERA_INCARICONull)
                    item.DataDeliberaCommissioneIncarico = itemToConvert.DATA_DELIBERA_INCARICO;
                if (!itemToConvert.IsDATA_DELIBERA_RICUSAZIONENull)
                    item.DataDeliberaCommRicusazione = itemToConvert.DATA_DELIBERA_RICUSAZIONE;
                if (!itemToConvert.IsDATA_DETERMINA_INCARICONull)
                    item.DataDeterminaIncarico = itemToConvert.DATA_DETERMINA_INCARICO;
                if (!itemToConvert.IsDATA_DETERMINA_RICUSAZIONENull)
                    item.DataDeterminaRicusazione = itemToConvert.DATA_DETERMINA_RICUSAZIONE;
                if (!itemToConvert.IsDATA_SCADENZA_TEORICANull)
                    item.DataScadenzaTeorica = itemToConvert.DATA_SCADENZA_TEORICA;
                item.ImportoImpegno = itemToConvert.IMPEGNO;
                item.NumeroDeliberaCommissioneIncarico = itemToConvert.NUMERO_DELIBERA_INCARICOSafe;
                item.NumeroDeliberaCommRicusazione = itemToConvert.NUMERO_DELIBERA_RICUSAZIONESafe;
                item.NumeroDeterminaIncarico = itemToConvert.NUMERO_DETERMINA_INCARICOSafe;
                item.NumeroDeterminaRicusazione = itemToConvert.NUMERO_DETERMINA_RICUSAZIONESafe;

                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaModifica = itemToConvert.DATAORAULTMOD;
                item.OperatoreUltimaModifica = itemToConvert.OPERATOREULTMODSafe;
            }
            return item;
        }

        public static GVCTINCARICHI Convert(RevisioneIncaricoFDT itemToConvert)
        {
            GVCTINCARICHI item = null;
            if (itemToConvert != null)
            {
                item = new GVCTINCARICHI();
                item.IDOBJ = itemToConvert.IdRevisioneIncarico;
                item.IDOBJ_REVISIONE = itemToConvert.IdRevisione;
                if (itemToConvert.DataDeliberaCommissioneIncarico.HasValue)
                    item.DATA_DELIBERA_INCARICO = itemToConvert.DataDeliberaCommissioneIncarico.Value;
                if (itemToConvert.DataDeliberaCommRicusazione.HasValue)
                    item.DATA_DELIBERA_RICUSAZIONE = itemToConvert.DataDeliberaCommRicusazione.Value;
                if (itemToConvert.DataDeterminaIncarico.HasValue)
                    item.DATA_DETERMINA_INCARICO = itemToConvert.DataDeterminaIncarico.Value;
                if (itemToConvert.DataDeterminaRicusazione.HasValue)
                    item.DATA_DETERMINA_RICUSAZIONE = itemToConvert.DataDeterminaRicusazione.Value;
                if (itemToConvert.DataScadenzaTeorica.HasValue)
                    item.DATA_SCADENZA_TEORICA = itemToConvert.DataScadenzaTeorica.Value;
                item.IMPEGNO = itemToConvert.ImportoImpegno;
                item.NUMERO_DELIBERA_INCARICO = itemToConvert.NumeroDeliberaCommissioneIncarico;
                item.NUMERO_DELIBERA_RICUSAZIONE = itemToConvert.NumeroDeliberaCommRicusazione;
                item.NUMERO_DETERMINA_INCARICO = itemToConvert.NumeroDeterminaIncarico;
                item.NUMERO_DETERMINA_RICUSAZIONE = itemToConvert.NumeroDeterminaRicusazione;

                if (itemToConvert.DataUltimaModifica.HasValue)
                    item.DATAORAULTMOD = itemToConvert.DataUltimaModifica.Value;
                item.OPERATOREULTMOD = itemToConvert.OperatoreUltimaModifica;
            }
            return item;
        }

        public static RevisioneIncaricoFDT[] ConvertAll(GVCTINCARICHI[] itemsToConvert)
        {
            List<RevisioneIncaricoFDT> listItem = new List<RevisioneIncaricoFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCTINCARICHI item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCTINCARICHI[] ConvertAll(RevisioneIncaricoFDT[] itemsToConvert)
        {
            List<GVCTINCARICHI> listItem = new List<GVCTINCARICHI>();
            if (itemsToConvert != null)
            {
                foreach (RevisioneIncaricoFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }


		#endregion Methods 

    }
}
