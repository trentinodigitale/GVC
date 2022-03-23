using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.FDT
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public partial class DettaglioDizionarioFDT : FDTBase
    {
        #region Instance Variables

        private int? _tempi;
        private String _note;

        #endregion Instance Variables

        #region Public Properties

        /// <summary>
        /// Gets or sets the note.
        /// </summary>
        /// <value>The note.</value>
        [Bindable(true)]
        public String Note
        {
            get { return _note; }
            set { _note = value; }
        }

        /// <summary>
        /// Gets or sets the tempi.
        /// </summary>
        /// <value>The tempi.</value>
        [Bindable(true)]
        public int? Tempi
        {
            get { return _tempi; }
            set { _tempi = value; }
        }

        #endregion Public Properties
    }
}
