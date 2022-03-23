using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;

namespace it.dedagroup.GVC.Repository.etier.Services.ParixWrapper
{
    public class DictionaryContainer : ServiceBase
    {
        private static Dictionary<String, int> activities;
        private static Dictionary<String, int> charges;

        public static Dictionary<String, int> Charges
        {
            get { return DictionaryContainer.charges; }
        }

        public static Dictionary<String, int> Activities
        {
            get { return DictionaryContainer.activities; }
        }

        public void RetrieveActivities()
        {
            try
            {
                    
                   TipoAttivitaFDT[] listAtt =
                    it.dedagroup.GVC.Repository.Common.Converters.Converters.ConvertAll(
                    GVCDB.GVCDATECOCollection.GetAll());
                    activities = new Dictionary<string, int>();

                    if (listAtt != null && listAtt.Length > 0)
                    {
                        foreach (TipoAttivitaFDT attivita in listAtt)
                        {
                            activities[attivita.Codice] = attivita.IdElemento;
                        }
                    }
             }
             catch (Exception a)
             {

             }
        }
        


        public void RetrieveCharges()
        {
            try
                {
                  TipoCaricaSocialeFDT[]  listCariche =
                    it.dedagroup.GVC.Repository.Common.Converters.Converters.ConvertAll(
                    GVCDB.GVCDTIPI_CARICACollection.GetAll());
                  charges = new Dictionary<string, int>();

                  if (listCariche != null && listCariche.Length > 0)
                    {
                        foreach (TipoCaricaSocialeFDT carica in listCariche)
                        {
                            charges[carica.Descrizione] = carica.IdElemento;
                        }
                    }
                }
                catch (Exception a)
                {

                }
            
        }

    }
}
