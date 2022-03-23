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


		// Public Methods (4) 

        public static ScadenziarioFDT Convert(GVCTANNOTAZIONI itemToConvert)
        {
            ScadenziarioFDT item = null;
            if (itemToConvert != null)
            {
                item = new ScadenziarioFDT();
                item.IdScadenziario = itemToConvert.IDOBJ;
                item.IdTipoScadenziario = itemToConvert.IDOBJ_TIPO_NOTA;
                item.IdRegistro = itemToConvert.IDOBJ_REGISTRO;
                item.DataAnnotazione = itemToConvert.DATA_ANNOTAZIONE;
                if (!itemToConvert.IsDATA_EVASIONENull)
                    item.DataEvasione = itemToConvert.DATA_EVASIONE;
                if (!itemToConvert.IsDATA_SCADENZANull)
                    item.DataScadenza = itemToConvert.DATA_SCADENZA;
                item.Descrizione = itemToConvert.DESCRIZIONESafe;
                item.Evasa = itemToConvert.EVASASafe == 1 ? true : false;
                item.RiservataUfficio = itemToConvert.RISERVATASafe == 1 ? true : false;

                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaModifica = itemToConvert.DATAORAULTMOD;
                item.OperatoreUltimaModifica = itemToConvert.OPERATOREULTMODSafe;
            }
            return item;
        }

        public static GVCTANNOTAZIONI Convert(ScadenziarioFDT itemToConvert)
        {
            GVCTANNOTAZIONI item = null;
            if (itemToConvert != null)
            {
                item = new GVCTANNOTAZIONI();
                item.IDOBJ = itemToConvert.IdScadenziario;
                item.IDOBJ_REGISTRO = itemToConvert.IdRegistro;
                item.IDOBJ_TIPO_NOTA = itemToConvert.IdTipoScadenziario;
                item.DATA_ANNOTAZIONE = itemToConvert.DataAnnotazione;
                if (itemToConvert.DataEvasione.HasValue)
                    item.DATA_EVASIONE = itemToConvert.DataEvasione.Value;
                if (itemToConvert.DataScadenza.HasValue)
                    item.DATA_SCADENZA = itemToConvert.DataScadenza.Value;
                item.DESCRIZIONE = itemToConvert.Descrizione;
                item.EVASA = itemToConvert.Evasa == true ? 1 : 0;
                item.RISERVATA = itemToConvert.RiservataUfficio == true ? 1 : 0;

                if (itemToConvert.DataUltimaModifica.HasValue)
                    item.DATAORAULTMOD = itemToConvert.DataUltimaModifica.Value;
                item.OPERATOREULTMOD = itemToConvert.OperatoreUltimaModifica;
            }
            return item;
        }

        public static ScadenziarioFDT[] ConvertAll(GVCTANNOTAZIONI[] itemsToConvert)
        {
            List<ScadenziarioFDT> listItem = new List<ScadenziarioFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCTANNOTAZIONI item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCTANNOTAZIONI[] ConvertAll(ScadenziarioFDT[] itemsToConvert)
        {
            List<GVCTANNOTAZIONI> listItem = new List<GVCTANNOTAZIONI>();
            if (itemsToConvert != null)
            {
                foreach (ScadenziarioFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }


		#endregion Methods 

    }
}
