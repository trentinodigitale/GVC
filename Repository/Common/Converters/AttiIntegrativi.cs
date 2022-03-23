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

        public static AttoIntegrativoFDT Convert(GVCRATTI_INTEGRATIVI itemToConvert)
        {
            AttoIntegrativoFDT item = null;
            if (itemToConvert != null)
            {
                item = new AttoIntegrativoFDT();
                item.IdAttoIntegrativo = itemToConvert.IDOBJ;
                item.DataAtto = itemToConvert.DATA_ATTO;
                item.DescrizioneDatoStorico = itemToConvert.DESCRIZIONESafe;
                item.IdAssemblea = itemToConvert.IDOBJ_ASSEMBLEA;
                item.IdTipoAtto = itemToConvert.IDOBJ_TIPO_ATTO;
                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaModifica = itemToConvert.DATAORAULTMOD;
                item.OperatoreUltimaModifica = itemToConvert.OPERATOREULTMODSafe;
            }
            return item;
        }

        public static GVCRATTI_INTEGRATIVI Convert(AttoIntegrativoFDT itemToConvert)
        {
            GVCRATTI_INTEGRATIVI item = null;
            if (itemToConvert != null)
            {
                item = new GVCRATTI_INTEGRATIVI();
                item.IDOBJ = itemToConvert.IdAttoIntegrativo;
                item.DATA_ATTO = itemToConvert.DataAtto;
                item.DESCRIZIONE = itemToConvert.DescrizioneDatoStorico;
                item.IDOBJ_ASSEMBLEA = itemToConvert.IdAssemblea;
                item.IDOBJ_TIPO_ATTO = itemToConvert.IdTipoAtto;
                if (itemToConvert.DataUltimaModifica.HasValue)
                    item.DATAORAULTMOD = itemToConvert.DataUltimaModifica.Value;
                item.OPERATOREULTMOD = itemToConvert.OperatoreUltimaModifica;
            }
            return item;
        }

        public static AttoIntegrativoFDT[] ConvertAll(GVCRATTI_INTEGRATIVI[] itemsToConvert)
        {
            List<AttoIntegrativoFDT> listItem = new List<AttoIntegrativoFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCRATTI_INTEGRATIVI item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCRATTI_INTEGRATIVI[] ConvertAll(AttoIntegrativoFDT[] itemsToConvert)
        {
            List<GVCRATTI_INTEGRATIVI> listItem = new List<GVCRATTI_INTEGRATIVI>();
            if (itemsToConvert != null)
            {
                foreach (AttoIntegrativoFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }


		#endregion Methods 

    }
}
