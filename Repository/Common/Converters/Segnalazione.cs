using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.rtier.Service;
using System.Data;

namespace it.dedagroup.GVC.Repository.Common.Converters
{
    public abstract partial class Converters
    {

        #region Methods (4)


        // Public Methods (4) 

        public static SegnalazioneFDT Convert( GVCTLOG_SEGNALAZIONI itemToConvert)
        {
            SegnalazioneFDT item = null;
            if (itemToConvert != null)
            {
                item = new SegnalazioneFDT();
                
                item.IdSegnalazione = itemToConvert.IDOBJ;
                item.IdTipoSegnalazione = itemToConvert.IDOBJ_TIPO_SEGNALAZIONE;
                item.Visible = itemToConvert.VISIBILE == 1 ? true : false;
                item.Descrizione = itemToConvert.DESCRIZIONESafe;
                item.IdRegistro = itemToConvert.IDOBJ_REGISTRO;
                item.Apply = false;
                if(!itemToConvert.IsAPPLICATONull && itemToConvert.APPLICATO == 1)
                   item.Apply = true;
                item.DataSegnalazione = itemToConvert.DATA_SEGNALAZIONE;
                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaModifica = itemToConvert.DATAORAULTMOD;
                item.OperatoreUltimaModifica = itemToConvert.OPERATOREULTMODSafe;
            }
            return item;
        }

        public static SegnalazioneFDT Convert(GVCVCERCAMODIFICHEPARIX itemToConvert)
        {
            SegnalazioneFDT item = null;
            if (itemToConvert != null)
            {
                item = new SegnalazioneFDT();

                item.IdSegnalazione = itemToConvert.IDOBJ;
                item.IdTipoSegnalazione = itemToConvert.IDOBJ_TIPO_SEGNALAZIONE;
                item.Visible = itemToConvert.VISIBILE == 1 ? true : false;
                item.Apply = false;
                if (!itemToConvert.IsAPPLICATONull && itemToConvert.APPLICATO == 1)
                    item.Apply = true;
                if(!itemToConvert.IsDESCRIZIONENull)
                    item.Descrizione = itemToConvert.DESCRIZIONESafe;
                item.IdRegistro = itemToConvert.IDOBJ_REGISTRO;
                if(!itemToConvert.IsIDOBJ_SOGGETTONull)
                    item.IdSoggetto = itemToConvert.IDOBJ_SOGGETTO;
                if(!itemToConvert.IsNUMERO_REANull)
                    item.NumeroRea = itemToConvert.NUMERO_REASafe;
                if(!itemToConvert.IsDENOMINAZIONENull)
                    item.Denominazione = itemToConvert.DENOMINAZIONESafe;
                item.DataSegnalazione = itemToConvert.DATA_SEGNALAZIONE;
                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaModifica = itemToConvert.DATAORAULTMOD;
               
            }
            return item;
        }

        public static SegnalazioneFDT Convert(GVCVSEGDAAPPLICARE itemToConvert)
        {
            SegnalazioneFDT item = null;
            if (itemToConvert != null)
            {
                item = new SegnalazioneFDT();

                item.IdSegnalazione = itemToConvert.IDOBJ;
                item.IdTipoSegnalazione = itemToConvert.IDOBJ_TIPO_SEGNALAZIONE;
                item.Visible = itemToConvert.VISIBILE == 1 ? true : false;
                item.Descrizione = itemToConvert.DESCRIZIONESafe;
                item.IdRegistro = itemToConvert.IDOBJ_REGISTRO;
                item.Apply = false;
                if (!itemToConvert.IsAPPLICATONull && itemToConvert.APPLICATO == 1)
                    item.Apply = true;
                item.DataSegnalazione = itemToConvert.DATA_SEGNALAZIONE;
                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaModifica = itemToConvert.DATAORAULTMOD;
                item.OperatoreUltimaModifica = itemToConvert.OPERATOREULTMODSafe;
            }
            return item;
        }

        public static SegnalazioneFDT[] ConvertAll(GVCTLOG_SEGNALAZIONI[] itemsToConvert)
        {
            List<SegnalazioneFDT> listItem = new List<SegnalazioneFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCTLOG_SEGNALAZIONI item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static SegnalazioneFDT[] ConvertAll(GVCVCERCAMODIFICHEPARIX[] itemsToConvert)
        {
            List<SegnalazioneFDT> listItem = new List<SegnalazioneFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCVCERCAMODIFICHEPARIX item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static SegnalazioneFDT[] ConvertAll(GVCVSEGDAAPPLICARE[]itemsToConvert)
        {
            List<SegnalazioneFDT> listItem = new List<SegnalazioneFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCVSEGDAAPPLICARE item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCTLOG_SEGNALAZIONI Convert(SegnalazioneFDT itemToConvert)
        {
            GVCTLOG_SEGNALAZIONI item = null;
            if (itemToConvert != null)
            {
                item = new GVCTLOG_SEGNALAZIONI();
                item.IDOBJ = itemToConvert.IdSegnalazione;
                item.IDOBJ_TIPO_SEGNALAZIONE = itemToConvert.IdTipoSegnalazione;
                item.VISIBILE = itemToConvert.Visible == true ? 1 : 0;
                item.APPLICATO = itemToConvert.Apply == true ? 1 : 0;
                item.DESCRIZIONE = itemToConvert.Descrizione;
                item.IDOBJ_REGISTRO = itemToConvert.IdRegistro;
                item.DATA_SEGNALAZIONE = itemToConvert.DataSegnalazione;
                if (itemToConvert.DataUltimaModifica != null)
                    item.DATAORAULTMOD = (DateTime)itemToConvert.DataUltimaModifica;
                if (!String.IsNullOrEmpty(itemToConvert.OperatoreUltimaModifica))
                    item.OPERATOREULTMOD = itemToConvert.OperatoreUltimaModifica;
            }
            return item;
        }

        

        #endregion Methods

    }

}
