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
    public partial class CategoriaFDT : DizionarioFDT
    {
        #region Instance Variables (3)

        private String _codiceGsc;
        private String _codiceNuovo;
        private Boolean _attiva;

        #endregion Instance Variables

        #region Public Properties (5)

        /// <summary>
        /// Gets the descrizione completa.
        /// </summary>
        /// <value>The descrizione completa.</value>
        [Bindable(true)]
        public string DescrizioneCompleta
        {
            get { return String.Concat(CodiceAttuale, " - ", Descrizione); }
        }


        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CategoriaFDT"/> is attiva.
        /// </summary>
        /// <value><c>true</c> if attiva; otherwise, <c>false</c>.</value>
        [Bindable(true)]
        public Boolean Attiva
        {
            get { return _attiva; }
            set { _attiva = value; }
        }

        /// <summary>
        /// Gets the codice attuale.
        /// </summary>
        /// <value>The codice attuale.</value>
        [Bindable(true)]
        public string CodiceAttuale
        {
            get { return (!String.IsNullOrEmpty(_codiceNuovo)) ? _codiceNuovo : _codiceGsc; }
        }

        /// <summary>
        /// Gets or sets the codice nuovo.
        /// </summary>
        /// <value>The codice nuovo.</value>
        [Bindable(true)]
        public string CodiceNuovo
        {
            get { return _codiceNuovo; }
            set { _codiceNuovo = value; }
        }

        /// <summary>
        /// Gets or sets the GSC code.
        /// </summary>
        /// <value>The GSC code.</value>
        [Bindable(true)]
        public string GSCCode
        {
            get { return _codiceGsc; }
            set { _codiceGsc = value; }
        }
	
        #endregion Public Properties

    }
}
