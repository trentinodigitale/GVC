using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using OeF.Configurations;

namespace it.dedagroup.GVC.Repository.Common.FDT
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class ParametriDiRicercaFDT
    {

		#region Methods (2) 


		// Public Methods (2) 

        public void AddParameter(DictionaryEntry de)
        {
            if (_parameters == null)
                _parameters = new DictionaryEntryList();
            _parameters.Add(de);
        }

        public void AddParameter(string key, object value)
        {
            if (_parameters == null)
                _parameters = new DictionaryEntryList();
            DictionaryEntry de = new DictionaryEntry(key, value);
            _parameters.Add(de);
        }


		#endregion Methods 


        #region Instance Variables (5)

        private DictionaryEntryList _parameters;

        #endregion Instance Variables (5)


        #region Public Properties (6)

        public DictionaryEntryList Parameters
        {
            get { return _parameters; }
            //set { _parameters = value; }
        }

        #endregion Public Properties

    }
}
