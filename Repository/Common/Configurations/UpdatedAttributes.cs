using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.Configurations
{
    public class UpdatedAttributes
    {

        #region Fields (1)

        private static Dictionary<int, String[]> updatedAttributes;

        #endregion Fields

        #region Methods (1)

        public static Dictionary<int, String[]> getUpdatedAttributes()
        {
            if (updatedAttributes != null)
                return updatedAttributes;
            updatedAttributes = new Dictionary<int, string[]>();
            updatedAttributes.Add(TipoSegnalazione.CODICE_FISCALE, new String[] { "CodiceFiscale" });
            updatedAttributes.Add(TipoSegnalazione.DENOMINAZIONE, new String[] { "Denominazione" });
            updatedAttributes.Add(TipoSegnalazione.FORMA_GIURIDICA, new String[] { "RegistroCooperativa.FormaGiuridicaParix" });
            updatedAttributes.Add(TipoSegnalazione.FORMA_AMMINISTRATIVA, new String[] { "RegistroCooperativa.FormaAmministrativaParix" });
            updatedAttributes.Add(TipoSegnalazione.ATTIVITA_ISTAT, new String[] { "RegistroCooperativa.AttivitaParix" });
            updatedAttributes.Add(TipoSegnalazione.DURATA, new String[] { "RegistroCooperativa.Durata", "RegistroCooperativa.DurataIllimitata" });
            updatedAttributes.Add(TipoSegnalazione.INDIRIZZO_SEDE, new String[] { "Indirizzi" });
            updatedAttributes.Add(TipoSegnalazione.DATI_COSTITUZIONE, new String[] { "RegistroCooperativa.DataCostituzione" });
            updatedAttributes.Add(TipoSegnalazione.SCADENZA_ESERCIZI, new String[] { "RegistroCooperativa.BilancioEsercizioAl" });
            return updatedAttributes;
        }




        #endregion Methods
    }
}
