using System;
using System.Collections.Generic;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.Configurations
{
    public sealed class UserRoles : OeF.Configurations.DictionaryEntryList
    {


        #region Private Fields

        private static UserRoles instance;

        #endregion Private Fields


        #region Consts

        /// <summary>
        /// Operator
        /// </summary>
        public const string Operator = "OPERATORE";

        /// <summary>
        /// Administrator
        /// </summary>
        public const string Administrator = "AMMINISTRATORE";

        /// <summary>
        /// Administrator
        /// </summary>
        public const string Visitatore = "VISITATORE";

        #endregion Consts


        #region Public Static Methods

        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns></returns>
        public static UserRoles GetList()
        {
            if (instance == null)
            {
                instance = new UserRoles();
                instance.Add(new OeF.Configurations.DictionaryEntry(Operator, Operator));
                instance.Add(new OeF.Configurations.DictionaryEntry(Administrator, Administrator));
                instance.Add(new OeF.Configurations.DictionaryEntry(Visitatore, Visitatore));
            }
            return instance;
        }

        /// <summary>
        /// Gets the not availables roles.
        /// </summary>
        /// <param name="availableKeys">The available roles keys.</param>
        /// <returns></returns>
        public static UserRoles GetNotAvailables(String[] availableKeys)
        {
            List<String> availableRoles = new List<string>(availableKeys);
            UserRoles notAvailableRoles = new UserRoles();
            foreach (OeF.Configurations.DictionaryEntry item in GetList())
            {
                if (availableRoles.IndexOf(item.Key.ToString()) == -1)
                {
                    notAvailableRoles.Add(item);
                }
            }
            return notAvailableRoles;
        }

        #endregion Public Static Methods

    }
}