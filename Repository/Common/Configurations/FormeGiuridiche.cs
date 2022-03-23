using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.Configurations
{
    public class FormeGiuridiche
    {

		#region Fields (1) 

        private static List<String> formeGiuridiche;

		#endregion Fields 

		#region Methods (3) 


		// Public Methods (3) 

        public static void AddFormaGiuridica(String newForm){
            getFormeGiuridiche();
            formeGiuridiche.Add(newForm);
        }

        public static List<String> getFormeGiuridiche() {
            if (formeGiuridiche != null)
                return formeGiuridiche;
            formeGiuridiche = new List<string>();
            formeGiuridiche.Add("cf");
            formeGiuridiche.Add("ci");
            formeGiuridiche.Add("cl");

            formeGiuridiche.Add("oc");
            formeGiuridiche.Add("oo");
            formeGiuridiche.Add("os");

            formeGiuridiche.Add("pc");
            formeGiuridiche.Add("ps");

            formeGiuridiche.Add("sc");
            formeGiuridiche.Add("sg");
            formeGiuridiche.Add("sm");
        
            return formeGiuridiche;
        }

        public static bool RemoveFormaGiuridica(String remForm)
        {
            getFormeGiuridiche();
            if (formeGiuridiche == null || !formeGiuridiche.Contains(remForm))
                return false;    
            formeGiuridiche.Remove(remForm);
            return true;
        }


		#endregion Methods 

    }
}
