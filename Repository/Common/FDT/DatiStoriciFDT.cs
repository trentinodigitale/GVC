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
    public partial class DatiStoriciFDT
    {

		#region Fields (6) 

        private DateTime? _dataFine;
        private DateTime _dataUltimaMod;
        private string _descrizione;
        private int _idDatoStorico;
        private int _idRiferimento;
        private string _operatoreUltimaMod;

		#endregion Fields 

		#region Properties (6) 

        /// <summary>
        /// Gets or sets the data fine.
        /// </summary>
        /// <value>The data fine.</value>
        [Bindable(true)]
        public DateTime? DataFine
        {
            get { return _dataFine; }
            set { _dataFine = value; }
        }

        /// <summary>
        /// Gets or sets the data ultima mod.
        /// </summary>
        /// <value>The data ultima mod.</value>
        [Bindable(true)]
        public DateTime DataUltimaMod
        {
            get { return _dataUltimaMod; }
            set { _dataUltimaMod = value; }
        }

        /// <summary>
        /// Gets or sets the descrizione.
        /// </summary>
        /// <value>The descrizione.</value>
        [Bindable(true)]
        public string Descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
        }

        /// <summary>
        /// Gets or sets the id dato storico.
        /// </summary>
        /// <value>The id dato storico.</value>
        [Bindable(true)]
        public int IdDatoStorico
        {
            get { return _idDatoStorico; }
            set { _idDatoStorico = value; }
        }

        /// <summary>
        /// Gets or sets the id registro.
        /// </summary>
        /// <value>The id registro.</value>
        [Bindable(true)]
        public int IdRiferimento
        {
            get { return _idRiferimento; }
            set { _idRiferimento = value; }
        }

        /// <summary>
        /// Gets or sets the operatore ultima mod.
        /// </summary>
        /// <value>The operatore ultima mod.</value>
        [Bindable(true)]
        public string OperatoreUltimaMod
        {
            get { return _operatoreUltimaMod; }
            set { _operatoreUltimaMod = value; }
        }

		#endregion Properties 

    }
}
