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
    public partial class ControlloNumeroSociFDT : FDTBase
    {
        #region Instance Variables (6)

        private int _idRelazione;
        private int _idParametro;
        private int _valMin;
        private int _valMax;
        private String _note;
        private int _tipo;

        #endregion Instance Variables

        #region Public Properties

        /// <summary>
        /// Gets or sets the tipo.
        /// </summary>
        /// <value>The tipo.</value>
        [Bindable(true)]
        public int Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        /// <summary>
        /// Gets or sets the id relazione.
        /// </summary>
        /// <value>The id relazione.</value>
        [Bindable(true)]
        public int IdRelazione
        {
            get { return _idRelazione; }
            set { _idRelazione = value; }
        }

        /// <summary>
        /// Gets or sets the id parametro.
        /// </summary>
        /// <value>The id parametro.</value>
        [Bindable(true)]
        public int IdParametro
        {
            get { return _idParametro; }
            set { _idParametro = value; }
        }

        /// <summary>
        /// Gets or sets the val min.
        /// </summary>
        /// <value>The val min.</value>
        [Bindable(true)]
        public int ValMin
        {
            get { return _valMin; }
            set { _valMin = value; }
        }

        /// <summary>
        /// Gets or sets the val max.
        /// </summary>
        /// <value>The val max.</value>
        [Bindable(true)]
        public int ValMax
        {
            get { return _valMax; }
            set { _valMax = value; }
        }

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

        #endregion Public Properties
    }
}
