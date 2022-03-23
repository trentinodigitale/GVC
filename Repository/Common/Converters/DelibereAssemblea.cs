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

        public static DeliberaAssembleaFDT Convert(GVCTDELIBERE_ASSEMBLEA itemToConvert)
        {
            DeliberaAssembleaFDT item = null;
            if (itemToConvert != null)
            {
                item = new DeliberaAssembleaFDT();
                item.IdDeliberaAssemblea = itemToConvert.IDOBJ;

                item.Contenuto = itemToConvert.CONTENUTOSafe;
                item.DataAssemblea = itemToConvert.DATA_ASSEMBLEA;
                if (!itemToConvert.IsDATA_ESAMENull)
                item.DataEsameCommissione = itemToConvert.DATA_ESAME;
                if (!itemToConvert.IsDATA_EVASIONENull)
                item.DataEvasioneUfficio = itemToConvert.DATA_EVASIONE;
                if (!itemToConvert.IsDATA_ISCRIZIONE_RINull)
                item.DataIscrizRegistroImprese = itemToConvert.DATA_ISCRIZIONE_RI;
                item.IdNotaio = itemToConvert.IDOBJ_NOTAIOSafe;
                item.IdRegistro = itemToConvert.IDOBJ_REGISTRO;
                item.IdTipoAssemblea = itemToConvert.IDOBJ_TIPO_ASSEMBLEA;
                item.NumeroEsameCommissione = itemToConvert.NUMERO_ESAMESafe;
                
                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaModifica = itemToConvert.DATAORAULTMOD;
                item.OperatoreUltimaModifica = itemToConvert.OPERATOREULTMODSafe;
            }
            return item;
        }

        public static GVCTDELIBERE_ASSEMBLEA Convert(DeliberaAssembleaFDT itemToConvert)
        {
            GVCTDELIBERE_ASSEMBLEA item = null;
            if (itemToConvert != null)
            {
                item = new GVCTDELIBERE_ASSEMBLEA();
                item.IDOBJ = itemToConvert.IdDeliberaAssemblea;

                item.CONTENUTO = itemToConvert.Contenuto;
                item.DATA_ASSEMBLEA = itemToConvert.DataAssemblea;
                if (itemToConvert.DataEsameCommissione.HasValue)
                    item.DATA_ESAME = itemToConvert.DataEsameCommissione.Value;
                if (itemToConvert.DataEvasioneUfficio.HasValue)
                    item.DATA_EVASIONE = itemToConvert.DataEvasioneUfficio.Value;
                if (itemToConvert.DataIscrizRegistroImprese.HasValue)
                    item.DATA_ISCRIZIONE_RI = itemToConvert.DataIscrizRegistroImprese.Value;
                if (itemToConvert.IdNotaio > 0)
                    item.IDOBJ_NOTAIO = itemToConvert.IdNotaio;
                else
                    item.IsIDOBJ_NOTAIONull = true;
                item.IDOBJ_REGISTRO = itemToConvert.IdRegistro;
                item.IDOBJ_TIPO_ASSEMBLEA = itemToConvert.IdTipoAssemblea;
                item.NUMERO_ESAME = itemToConvert.NumeroEsameCommissione;

                if (itemToConvert.DataUltimaModifica.HasValue)
                    item.DATAORAULTMOD = itemToConvert.DataUltimaModifica.Value;
                item.OPERATOREULTMOD = itemToConvert.OperatoreUltimaModifica;
            }
            return item;
        }

        public static DeliberaAssembleaFDT[] ConvertAll(GVCTDELIBERE_ASSEMBLEA[] itemsToConvert)
        {
            List<DeliberaAssembleaFDT> listItem = new List<DeliberaAssembleaFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCTDELIBERE_ASSEMBLEA item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCTDELIBERE_ASSEMBLEA[] ConvertAll(DeliberaAssembleaFDT[] itemsToConvert)
        {
            List<GVCTDELIBERE_ASSEMBLEA> listItem = new List<GVCTDELIBERE_ASSEMBLEA>();
            if (itemsToConvert != null)
            {
                foreach (DeliberaAssembleaFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }


		#endregion Methods 

    }
}
