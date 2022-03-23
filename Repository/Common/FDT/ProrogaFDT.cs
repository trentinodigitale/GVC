using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.FDT
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public partial class ProrogaFDT : FDTBase
    {
        #region Instance Variables (6)

        private int _idProroga;
        private int _idProceduraCoatta;
        private DateTime _dataProroga;
        private String _numeroDetermina;
        private DateTime? _dataDetermina;
        private String _numeroDeliberaCommissione;
        private DateTime? _dataDeliberaCommissione;
        private DateTime? _dataUltimaModifica;
        private String _operatoreUltimaModifica;

        #endregion Instance Variables

        #region Public Properties (6)

        /// <summary>
        /// Gets or sets the data delibera commissione.
        /// </summary>
        /// <value>The data delibera commissione.</value>
        [Bindable(true)]
        public DateTime? DataDeliberaCommissione
        {
            get { return _dataDeliberaCommissione; }
            set { _dataDeliberaCommissione = value; }
        }

        /// <summary>
        /// Gets or sets the numero delibera commissione.
        /// </summary>
        /// <value>The numero delibera commissione.</value>
        [Bindable(true)]
        public string NumeroDeliberaCommissione
        {
            get { return _numeroDeliberaCommissione; }
            set { _numeroDeliberaCommissione = value; }
        }

        /// <summary>
        /// Gets or sets the data delibera.
        /// </summary>
        /// <value>The data delibera.</value>
        [Bindable(true)]
        public DateTime? DataDetermina
        {
            get { return _dataDetermina; }
            set { _dataDetermina = value; }
        }

        /// <summary>
        /// Gets or sets the numero delibera.
        /// </summary>
        /// <value>The numero delibera.</value>
        [Bindable(true)]
        public string NumeroDetermina
        {
            get { return _numeroDetermina; }
            set { _numeroDetermina = value; }
        }

        /// <summary>
        /// Gets or sets the data procedura.
        /// </summary>
        /// <value>The data procedura.</value>
        [Bindable(true)]
        public DateTime DataProroga
        {
            get { return _dataProroga; }
            set { _dataProroga = value; }
        }

        /// <summary>
        /// Gets or sets the id proroga.
        /// </summary>
        /// <value>The id proroga.</value>
        [Bindable(true)]
        public int IdProroga
        {
            get { return _idProroga; }
            set { _idProroga = value; }
        }

        /// <summary>
        /// Gets or sets the id procedura coatta.
        /// </summary>
        /// <value>The id procedura coatta.</value>
        [Bindable(true)]
        public int IdProceduraCoatta
        {
            get { return _idProceduraCoatta; }
            set { _idProceduraCoatta = value; }
        }
        /// <summary>
        /// Gets or sets the data ultima modifica.
        /// </summary>
        /// <value>The data ultima modifica.</value>
        [Bindable(true)]
        public DateTime? DataUltimaModifica
        {
            get { return _dataUltimaModifica; }
            set { _dataUltimaModifica = value; }
        }

        /// <summary>
        /// Gets or sets the operatore ultima modifica.
        /// </summary>
        /// <value>The operatore ultima modifica.</value>
        [Bindable(true)]
        public String OperatoreUltimaModifica
        {
            get { return _operatoreUltimaModifica; }
            set { _operatoreUltimaModifica = value; }
        }

        #endregion Public Properties
    }
}
