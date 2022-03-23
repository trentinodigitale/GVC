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

        public static RevisioneFDT Convert(GVCTREVISIONI itemToConvert)
        {
            RevisioneFDT item = null;
            if (itemToConvert != null)
            {
                item = new RevisioneFDT();
                item.IdRevisione = itemToConvert.IDOBJ;
                item.AnnoRevisione = itemToConvert.ANNO_REVISIONE;
                if (!itemToConvert.IsDATA_COMUNICAZIONE_ESITINull)
                    item.DataCominicazioneEsiti = itemToConvert.DATA_COMUNICAZIONE_ESITI;
                if (!itemToConvert.IsDATA_CONCLUSIONENull)
                    item.DataConclusione = itemToConvert.DATA_CONCLUSIONE;
                if (!itemToConvert.IsDATA_DELIBERA_ESAMENull)
                    item.DataDeliberaEsame = itemToConvert.DATA_DELIBERA_ESAME;
                if (!itemToConvert.IsDATA_DELIBERA_REVOCANull)
                    item.DataDeliberaRevoca = itemToConvert.DATA_DELIBERA_REVOCA;
                if (!itemToConvert.IsDATA_DEPOSITO_RELAZIONENull)
                    item.DataDepositoRelazione = itemToConvert.DATA_DEPOSITO_RELAZIONE;
                if (!itemToConvert.IsDATA_DETERMINA_ESAMENull)
                    item.DataDeterminaEsame = itemToConvert.DATA_DETERMINA_ESAME;
                if (!itemToConvert.IsDATA_DETERMINA_REVOCANull)
                    item.DataDeterminaRevoca = itemToConvert.DATA_DETERMINA_REVOCA;
                item.IdEsitoRevisione = itemToConvert.IDOBJ_ESITO_REVISIONE;
                item.IdRegistro = itemToConvert.IDOBJ_REGISTRO;
                item.IdTipoRevisione = itemToConvert.IDOBJ_TIPO_REVISIONE;
                item.IdOrganoRevisore = itemToConvert.IDOBJ_ORGANO_REVISORESafe;
                item.IdLimiteCosto = itemToConvert.IDOBJ_LIMITE_COSTOSafe;
                item.NumeroDeliberaEsame = itemToConvert.NUMERO_DELIBERA_ESAMESafe;
                item.NumeroDeliberaRevoca = itemToConvert.NUMERO_DELIBERA_REVOCASafe;
                item.NumeroDeterminaEsame = itemToConvert.NUMERO_DETERMINA_ESAMESafe;
                item.NumeroDeterminaRevoca = itemToConvert.NUMERO_DETERMINA_REVOCASafe;
                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaModifica = itemToConvert.DATAORAULTMOD;
                item.OperatoreUltimaModifica = itemToConvert.OPERATOREULTMODSafe;
            }
            return item;
        }

        public static GVCTREVISIONI Convert(RevisioneFDT itemToConvert)
        {
            GVCTREVISIONI item = null;
            if (itemToConvert != null)
            {
                item = new GVCTREVISIONI();
                item.IDOBJ = itemToConvert.IdRevisione;
                item.ANNO_REVISIONE = itemToConvert.AnnoRevisione;
                if (itemToConvert.DataCominicazioneEsiti.HasValue)
                item.DATA_COMUNICAZIONE_ESITI = itemToConvert.DataCominicazioneEsiti.Value;
                if (itemToConvert.DataConclusione.HasValue)
                item.DATA_CONCLUSIONE = itemToConvert.DataConclusione.Value;
                if (itemToConvert.DataDeliberaEsame.HasValue)
                item.DATA_DELIBERA_ESAME = itemToConvert.DataDeliberaEsame.Value;
                if (itemToConvert.DataDeliberaRevoca.HasValue)
                item.DATA_DELIBERA_REVOCA = itemToConvert.DataDeliberaRevoca.Value;
                if (itemToConvert.DataDepositoRelazione.HasValue)
                item.DATA_DEPOSITO_RELAZIONE = itemToConvert.DataDepositoRelazione.Value;
                if (itemToConvert.DataDeterminaEsame.HasValue)
                item.DATA_DETERMINA_ESAME = itemToConvert.DataDeterminaEsame.Value;
                if (itemToConvert.DataDeterminaRevoca.HasValue)
                item.DATA_DETERMINA_REVOCA = itemToConvert.DataDeterminaRevoca.Value;
                item.IDOBJ_ESITO_REVISIONE = itemToConvert.IdEsitoRevisione;
                item.IDOBJ_REGISTRO = itemToConvert.IdRegistro;
                item.IDOBJ_TIPO_REVISIONE = itemToConvert.IdTipoRevisione;
                
                if (itemToConvert.IdOrganoRevisore > 0)
                    item.IDOBJ_ORGANO_REVISORE = itemToConvert.IdOrganoRevisore;
                else
                    item.IsIDOBJ_ORGANO_REVISORENull = true;
                if (itemToConvert.IdLimiteCosto > 0)
                    item.IDOBJ_LIMITE_COSTO = itemToConvert.IdLimiteCosto;
                else
                    item.IsIDOBJ_LIMITE_COSTONull = true;
                item.NUMERO_DELIBERA_ESAME = itemToConvert.NumeroDeliberaEsame;
                item.NUMERO_DELIBERA_REVOCA = itemToConvert.NumeroDeliberaRevoca;
                item.NUMERO_DETERMINA_ESAME = itemToConvert.NumeroDeterminaEsame;
                item.NUMERO_DETERMINA_REVOCA = itemToConvert.NumeroDeterminaRevoca;
                if (itemToConvert.DataUltimaModifica.HasValue)
                    item.DATAORAULTMOD = itemToConvert.DataUltimaModifica.Value;
                item.OPERATOREULTMOD = itemToConvert.OperatoreUltimaModifica;
            }
            return item;
        }

        public static RevisioneFDT[] ConvertAll(GVCTREVISIONI[] itemsToConvert)
        {
            List<RevisioneFDT> listItem = new List<RevisioneFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCTREVISIONI item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCTREVISIONI[] ConvertAll(RevisioneFDT[] itemsToConvert)
        {
            List<GVCTREVISIONI> listItem = new List<GVCTREVISIONI>();
            if (itemsToConvert != null)
            {
                foreach (RevisioneFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }


		#endregion Methods 

    }
}
