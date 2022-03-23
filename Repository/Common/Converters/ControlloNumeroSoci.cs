using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using it.dedagroup.GVC.Repository.rtier.Service;

namespace it.dedagroup.GVC.Repository.Common.Converters
{
    public abstract partial class Converters
    {


        #region SOCI CATEGORIA

        public static ControlloNumeroSociFDT Convert(GVCRSOCI_CATEGORIA itemToConvert)
        {
            ControlloNumeroSociFDT item = null;
            if (itemToConvert != null)
            {
                item = new ControlloNumeroSociFDT();
                item.IdRelazione = itemToConvert.IDOBJ;
                item.IdParametro = itemToConvert.IDOBJ_CATEGORIA;
                item.ValMin = itemToConvert.VALMINSafe;
                item.ValMax = itemToConvert.VALMAXSafe;
                item.Note = itemToConvert.NOTESafe;
                item.Tipo = TipoControlloNumeroSoci.PER_CATEGORIA;
            }
            return item;
        }

        public static ControlloNumeroSociFDT[] ConvertAll(GVCRSOCI_CATEGORIA[] itemsToConvert)
        {
            List<ControlloNumeroSociFDT> listItem = new List<ControlloNumeroSociFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCRSOCI_CATEGORIA item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        #endregion SOCI CATEGORIA


        #region SOCI FORMA GIURIDICA

        public static ControlloNumeroSociFDT Convert(GVCRSOCI_FOG itemToConvert)
        {
            ControlloNumeroSociFDT item = null;
            if (itemToConvert != null)
            {
                item = new ControlloNumeroSociFDT();
                item.IdRelazione = itemToConvert.IDOBJ;
                item.IdParametro = itemToConvert.IDOBJ_FORMA_GIURIDICA;
                item.ValMin = itemToConvert.VALMINSafe;
                item.ValMax = itemToConvert.VALMAXSafe;
                item.Note = itemToConvert.NOTESafe;
                item.Tipo = TipoControlloNumeroSoci.PER_FORMAGIURIDICA;
            }
            return item;
        }

        public static ControlloNumeroSociFDT[] ConvertAll(GVCRSOCI_FOG[] itemsToConvert)
        {
            List<ControlloNumeroSociFDT> listItem = new List<ControlloNumeroSociFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCRSOCI_FOG item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        #endregion SOCI FORMA GIURIDICA

        public static object Convert(ControlloNumeroSociFDT itemToConvert)
        {
            object item = null;

            if (itemToConvert != null)
            {
                if (itemToConvert.Tipo == TipoControlloNumeroSoci.PER_CATEGORIA)
                {
                    GVCRSOCI_CATEGORIA itemLocal = new GVCRSOCI_CATEGORIA();
                    itemLocal.IDOBJ = itemToConvert.IdRelazione;
                    itemLocal.IDOBJ_CATEGORIA = itemToConvert.IdParametro; 
                    itemLocal.NOTE = itemToConvert.Note;
                    itemLocal.VALMIN = itemToConvert.ValMin;
                    itemLocal.VALMAX = itemToConvert.ValMax;

                    item = itemLocal;
                }
                else
                {
                    GVCRSOCI_FOG itemLocal = new GVCRSOCI_FOG();
                    itemLocal.IDOBJ = itemToConvert.IdRelazione;
                    itemLocal.IDOBJ_FORMA_GIURIDICA = itemToConvert.IdParametro; 
                    itemLocal.NOTE = itemToConvert.Note;
                    itemLocal.VALMIN = itemToConvert.ValMin;
                    itemLocal.VALMAX = itemToConvert.ValMax;

                    item = itemLocal;

                }
            }

            return item;
        }

      
    }
}
