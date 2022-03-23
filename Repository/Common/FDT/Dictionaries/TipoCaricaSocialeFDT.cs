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
    public partial class TipoCaricaSocialeFDT : DizionarioFDT
    {
        #region Instance Variables (2)

        private Boolean _anti_mafia;
        private Boolean _attiva;

        #endregion Instance Variables

        #region Public Properties (2)

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="TipoCaricaSocialeFDT"/> is attiva.
        /// </summary>
        /// <value><c>true</c> if attiva; otherwise, <c>false</c>.</value>
        [Bindable(true)]
        public Boolean Attiva
        {
            get { return _attiva; }
            set { _attiva = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [anti_ mafia].
        /// </summary>
        /// <value><c>true</c> if [anti_ mafia]; otherwise, <c>false</c>.</value>
        [Bindable(true)]
        public Boolean Anti_Mafia
        {
            get { return _anti_mafia; }
            set { _anti_mafia = value; }
        }

        #endregion Public Properties

    }
}
