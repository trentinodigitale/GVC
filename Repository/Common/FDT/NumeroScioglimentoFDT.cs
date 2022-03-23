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
    public partial class NumeroScioglimentoFDT : FDTBase
    {
        #region Instance Variables (2)

        private int _id;
        private int _nrScioglimento;

        #endregion Instance Variables

        #region Public Properties (2)

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>The id.</value>
        [Bindable(true)]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// Gets or sets the nr sciogliemnto.
        /// </summary>
        /// <value>The nr sciogliemnto.</value>
        [Bindable(true)]
        public int NrScioglimento
        {
            get { return _nrScioglimento; }
            set { _nrScioglimento = value; }
        }

        #endregion Public Properties
    }
}
