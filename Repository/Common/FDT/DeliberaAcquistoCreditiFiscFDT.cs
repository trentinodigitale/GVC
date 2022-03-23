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
    public partial class DeliberaAcquistoCreditiFiscFDT : FDTBase
    {
        #region Instance Variables (5)

        private int _idDeliberaAcquistoCreditiFisc;
        private int _idLiquidazione;
        private String _numeroDelibera;
        private DateTime? _dataDelibera;
        private int _valuta;
        private double _importo;
        private String _note;
        private DateTime? _dataUltimaModifica;
        private String _operatoreUltimaModifica;

        #endregion Instance Variables (5)

        #region Public Properties (5)

        /// <summary>
        /// Gets or sets the importo.
        /// </summary>
        /// <value>The importo.</value>
        [Bindable(true)]
        public double Importo
        {
            get { return _importo; }
            set { _importo = value; }
        }

        /// <summary>
        /// Gets or sets the id valuta.
        /// </summary>
        /// <value>The id valuta.</value>
        [Bindable(true)]
        public int Valuta
        {
            get { return _valuta; }
            set { _valuta = value; }
        }

        /// <summary>
        /// Gets or sets the id liquidazione.
        /// </summary>
        /// <value>The id liquidazione.</value>
        [Bindable(true)]
        public int IdLiquidazione
        {
            get { return _idLiquidazione; }
            set { _idLiquidazione = value; }
        }

        /// <summary>
        /// Gets or sets the data delibera.
        /// </summary>
        /// <value>The data delibera.</value>
        [Bindable(true)]
        public DateTime? DataDelibera
        {
            get { return _dataDelibera; }
            set { _dataDelibera = value; }
        }

        /// <summary>
        /// Gets or sets the numero delibera.
        /// </summary>
        /// <value>The numero delibera.</value>
        [Bindable(true)]
        public string NumeroDelibera
        {
            get { return _numeroDelibera; }
            set { _numeroDelibera = value; }
        }

        /// <summary>
        /// Gets or sets the id delibera acquisto crediti fisc.
        /// </summary>
        /// <value>The id delibera acquisto crediti fisc.</value>
        [Bindable(true)]
        public int IdDeliberaAcquistoCreditiFisc
        {
            get { return _idDeliberaAcquistoCreditiFisc; }
            set { _idDeliberaAcquistoCreditiFisc = value; }
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
