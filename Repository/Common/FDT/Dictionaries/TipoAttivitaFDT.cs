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
    public partial class TipoAttivitaFDT : DizionarioFDT
    {
        #region Instance Variables (1)

        private String _codice;

        #endregion Instance Variables

        #region Public Properties (1)

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

        #endregion Public Properties
    }
}
