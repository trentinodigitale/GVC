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
    public partial class StatoCooperativaFDT : DizionarioFDT
    {
        #region Instance Variables (2)

        private Boolean _attiva;
        private Boolean _soggettaRevisione;

        #endregion Instance Variables

        #region Public Properties (2)

        /// <summary>
        /// Gets or sets a value indicating whether [soggetta revisione].
        /// </summary>
        /// <value><c>true</c> if [soggetta revisione]; otherwise, <c>false</c>.</value>
        [Bindable(true)]
        public Boolean SoggettaRevisione
        {
            get { return _soggettaRevisione; }
            set { _soggettaRevisione = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="StatoCooperativaFDT"/> is attiva.
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
