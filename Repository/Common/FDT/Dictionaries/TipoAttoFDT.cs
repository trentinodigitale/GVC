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
    public partial class TipoAttoFDT : DizionarioFDT
    {

        #region Instance Variables (2)

        private String _codice;
        private Boolean _attiva;

        #endregion Instance Variables

        #region Public Properties (2)

        /// <summary>
        /// Gets or sets the codice.
        /// </summary>
        /// <value>The codice.</value>
        [Bindable(true)]
        public new string Codice
        {
            get { return _codice; }
            set { _codice = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="SottoCategoriaSocialeFDT"/> is attiva.
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
