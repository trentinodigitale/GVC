using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.FDT.Dictionaries
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public partial class CadenzaRevisioneFDT : DizionarioFDT
    {
        #region Instance Variables (2)

        private Boolean _attiva;
        private int _frequenza;
	
        #endregion Instance Variables

        #region Public Properties (2)

        /// <summary>
        /// Gets or sets the frequenza.
        /// </summary>
        /// <value>The frequenza.</value>
        [Bindable(true)]
        public int Frequenza
        {
            get { return _frequenza; }
            set { _frequenza = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CadenzaRevisioneFDT"/> is attiva.
        /// </summary>
        /// <value><c>true</c> if attiva; otherwise, <c>false</c>.</value>
        [Bindable(true)]
        public Boolean Attiva
        {
            get { return _attiva; }
            set { _attiva = value; }
        }

        #endregion Public Properties
    }
}
