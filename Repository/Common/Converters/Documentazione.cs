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

        public static DocumentazioneFDT Convert(GVCTDOCUMENTAZIONE itemToConvert, Boolean toContainField)
        {
            DocumentazioneFDT item = null;
            if (itemToConvert != null)
            {
                item = new DocumentazioneFDT();

                if (toContainField)
                {
                    item.Allegati = itemToConvert.TESTO;
                }

                item.DataDocumento = itemToConvert.DATA_DOCUMENTO;
                item.IdDocumentazione = itemToConvert.IDOBJ;

                item.IdTipoDocumentazione = itemToConvert.IDOBJ_TIPO_DOCUMENTO;

                item.NomeFile = itemToConvert.NOME_FILESafe;

                item.Note = itemToConvert.NOTESafe;
                item.NumeroProtocollo = itemToConvert.NUMERO_PROTOCOLLOSafe;
                item.Titolo = itemToConvert.SEGNALIBROSafe;

                if (!itemToConvert.IsDIMENSIONENull)
                    item.Dimensione = itemToConvert.DIMENSIONESafe;

                if (!itemToConvert.IsIDOBJ_ADESIONENull)
                {
                    item.IdPadre = itemToConvert.IDOBJ_ADESIONESafe;
                }
                else if (!itemToConvert.IsIDOBJ_ASSEMBLEANull)
                {
                    item.IdPadre = itemToConvert.IDOBJ_ASSEMBLEASafe;
                }
                else if (!itemToConvert.IsIDOBJ_BASE_SOCIALENull)
                {
                    item.IdPadre = itemToConvert.IDOBJ_BASE_SOCIALESafe;
                }
                else if (!itemToConvert.IsIDOBJ_BILANCIONull)
                {
                    item.IdPadre = itemToConvert.IDOBJ_BILANCIOSafe;
                }
                else if (!itemToConvert.IsIDOBJ_CARICHENull)
                {
                    item.IdPadre = itemToConvert.IDOBJ_CARICHESafe;
                }
                else if (!itemToConvert.IsIDOBJ_FALLIMENTONull)
                {
                    item.IdPadre = itemToConvert.IDOBJ_FALLIMENTOSafe;
                }
                else if (!itemToConvert.IsIDOBJ_LIQUIDAZIONENull)
                {
                    item.IdPadre = itemToConvert.IDOBJ_LIQUIDAZIONESafe;
                }
                else if (!itemToConvert.IsIDOBJ_PROCEDURANull)
                {
                    item.IdPadre = itemToConvert.IDOBJ_PROCEDURASafe;
                }
                else if (!itemToConvert.IsIDOBJ_REGISTRONull)
                {
                    item.IdPadre = itemToConvert.IDOBJ_REGISTROSafe;
                }
                else if (!itemToConvert.IsIDOBJ_REVISIONENull)
                {
                    item.IdPadre = itemToConvert.IDOBJ_REVISIONESafe;
                }
                else if (!itemToConvert.IsIDOBJ_SANZIONENull)
                {
                    item.IdPadre = itemToConvert.IDOBJ_SANZIONESafe;
                }
            }
            return item;
        }

        public static GVCTDOCUMENTAZIONE Convert(DocumentazioneFDT itemToConvert, string parameter)
        {
            GVCTDOCUMENTAZIONE item = null;
            if (itemToConvert != null)
            {
                item = new GVCTDOCUMENTAZIONE();
                item.IDOBJ = itemToConvert.IdDocumentazione;
                item.IDOBJ_TIPO_DOCUMENTO = itemToConvert.IdTipoDocumentazione;

                item.NOME_FILE = System.IO.Path.GetFileName(itemToConvert.NomeFile);

                item.SEGNALIBRO = itemToConvert.Titolo;
                item.NOTE = itemToConvert.Note;
                item.DATA_DOCUMENTO = itemToConvert.DataDocumento;
                item.TESTO = itemToConvert.Allegati;

                item.DIMENSIONE = itemToConvert.Dimensione;

                System.Reflection.PropertyInfo pInfo = item.GetType().GetProperty(parameter);
                if (pInfo != null)
                {
                    pInfo.SetValue(item, itemToConvert.IdPadre, null);
                }
            }
            return item;
        }

        public static DocumentazioneFDT[] ConvertAll(GVCTDOCUMENTAZIONE[] itemsToConvert)
        {
            List<DocumentazioneFDT> listItem = new List<DocumentazioneFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCTDOCUMENTAZIONE item in itemsToConvert)
                {
                    listItem.Add(Convert(item, false));
                }
            }
            return listItem.ToArray();
        }

        public static GVCTDOCUMENTAZIONE[] ConvertAll(DocumentazioneFDT[] itemsToConvert, string parameter)
        {
            List<GVCTDOCUMENTAZIONE> listItem = new List<GVCTDOCUMENTAZIONE>();
            if (itemsToConvert != null)
            {
                foreach (DocumentazioneFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item, parameter));
                }
            }
            return listItem.ToArray();
        }


		#endregion Methods 

    }
}
