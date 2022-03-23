using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace it.dedagroup.GVC.Repository.Common.FDT.Dictionaries
{
    [Serializable]
    public partial class TipoSegnalazioneFDT : DizionarioFDT
    {
        #region Instance Variables (1)

        private Boolean _attiva;

        #endregion Instance Variables

        #region Public Properties (1)

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="TipoSegnalazioneFDT"/> is attiva.
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
