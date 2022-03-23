using System;
using System.Collections.Generic;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.Configurations
{
    public sealed class Valute : OeF.Configurations.DictionaryEntryList
    {


        #region Private fields

        private static Valute instance;

        #endregion Private fields


        #region Consts

        /// <summary>
        /// Euro
        /// </summary>
        public const string Euro = "€";

        /// <summary>
        /// Lire
        /// </summary>
        public const string Lire = "£";

        #endregion Consts


        #region Public Static Methods

        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns></returns>
        public static Valute GetList()
        {
            if (instance == null)
            {
                instance = new Valute();
                instance.Add(new OeF.Configurations.DictionaryEntry(0, Euro));
                instance.Add(new OeF.Configurations.DictionaryEntry(1, Lire));
            }
            return instance;
        }

        #endregion Public Static Methods

    }
}
