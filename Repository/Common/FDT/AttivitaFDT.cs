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
    public partial class AttivitaFDT : FDTBase
    {
        #region Instance Variables (10)

        private int _idAttivita;
        private int _idTipoAttivita;
        private int _idRegistro;
        private String _importanza;
        private DateTime? _dataInzio;
        private Boolean _infoCamere;
        private String _stato;
        private String _note;
        private DateTime? _dataUltimaModifica;
        private string _operatoreUltimaModifica;

        #endregion Instance Variables

        #region Public Properties (9)

        /// <summary>
        /// Gets or sets the data inizio.
        /// </summary>
        /// <value>The data inizio.</value>
        [Bindable(true)]
        public DateTime? DataInizio
        {
            get { return _dataInzio; }
            set { _dataInzio = value; }
        }

        /// <summary>
        /// Gets or sets the importanza.
        /// </summary>
        /// <value>The importanza.</value>
        [Bindable(true)]
        public string Importanza
        {
            get { return _importanza; }
            set { _importanza = value; }
        }

        /// <summary>
        /// Gets or sets the id tipo attivita.
        /// </summary>
        /// <value>The id tipo attivita.</value>
        [Bindable(true)]
        public int IdTipoAttivita
        {
            get { return _idTipoAttivita; }
            set { _idTipoAttivita = value; }
        }

        /// <summary>
        /// Gets or sets the id attivita.
        /// </summary>
        /// <value>The id attivita.</value>
        [Bindable(true)]
        public int IdAttivita
        {
            get { return _idAttivita; }
            set { _idAttivita = value; }
        }

        /// <summary>
        /// Gets or sets the id registro.
        /// </summary>
        /// <value>The id registro.</value>
        [Bindable(true)]
        public int IdRegistro
        {
            get { return _idRegistro; }
            set { _idRegistro = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [info camere].
        /// </summary>
        /// <value>The InfoCamere.</value>
        [Bindable(true)]
        public Boolean InfoCamere
        {
            get { return _infoCamere; }
            set { _infoCamere = value; }
        }

        /// <summary>
        /// Gets or sets the stato.
        /// </summary>
        /// <value>The stato.</value>
        [Bindable(true)]
        public String Stato
        {
            get { return _stato; }
            set { _stato = value; }
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
