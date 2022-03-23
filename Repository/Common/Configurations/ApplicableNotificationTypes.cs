using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.Configurations
{
    public class NotificationTypes
    {
        #region Fields (2)

        private static List<int> applicableTypes;
        private static List<int> comparableTypes;

        #endregion Fields

        #region Methods (2)


        public static List<int> getApplicableTypes()
        {
            if (applicableTypes != null)
                return applicableTypes;
            applicableTypes = new List<int>();
            applicableTypes.Add(TipoSegnalazione.CODICE_FISCALE);
            applicableTypes.Add(TipoSegnalazione.DURATA);
            applicableTypes.Add(TipoSegnalazione.INDIRIZZO_SEDE);

            applicableTypes.Add(TipoSegnalazione.SCADENZA_ESERCIZI);
            applicableTypes.Add(TipoSegnalazione.ATTIVITA_ISTAT);
            applicableTypes.Add(TipoSegnalazione.FORMA_GIURIDICA);

            applicableTypes.Add(TipoSegnalazione.FORMA_AMMINISTRATIVA);
            applicableTypes.Add(TipoSegnalazione.DATI_COSTITUZIONE);

            return applicableTypes;
        }


        public static List<int> getComparableTypes()
        {
            if (comparableTypes != null)
                return comparableTypes;
            comparableTypes = new List<int>();
            comparableTypes.Add(TipoSegnalazione.CODICE_FISCALE);
            comparableTypes.Add(TipoSegnalazione.DENOMINAZIONE);
            comparableTypes.Add(TipoSegnalazione.DURATA);
            comparableTypes.Add(TipoSegnalazione.INDIRIZZO_SEDE);


            comparableTypes.Add(TipoSegnalazione.SCADENZA_ESERCIZI);
           // comparableTypes.Add(TipoSegnalazione.CARICA_SOCIALE);
            comparableTypes.Add(TipoSegnalazione.ATTIVITA_ISTAT);
            comparableTypes.Add(TipoSegnalazione.FORMA_GIURIDICA);
            comparableTypes.Add(TipoSegnalazione.FORMA_AMMINISTRATIVA );
            comparableTypes.Add(TipoSegnalazione.DATI_COSTITUZIONE);
            return comparableTypes;
        }
        #endregion Methods
    }
}
