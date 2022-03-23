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
    public partial class TipoModificaStatutariaFDT : DizionarioFDT
    {
        #region Instance Variables (2)

        private Boolean _attiva;
        private Boolean _aperta;

        #endregion Instance Variables

        #region Public Properties (1)

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="TipoModificaStatutariaFDT"/> is attiva.
        /// </summary>
        /// <value><c>true</c> if attiva; otherwise, <c>false</c>.</value>
        [Bindable(true)]
        public Boolean Attiva
        {
            get { return _attiva; }
            set { _attiva = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="TipoModificaStatutariaFDT"/> is aperta.
        /// </summary>
        /// <value><c>true</c> if aperta; otherwise, <c>false</c>.</value>
        [Bindable(true)]
        public Boolean Aperta
        {
            get { return _aperta; }
            set { _aperta = value; }
        }

        #endregion Public Properties
    }
}
