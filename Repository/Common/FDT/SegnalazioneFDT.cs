using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace it.dedagroup.GVC.Repository.Common.FDT
{
   
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public partial class SegnalazioneFDT : FDTBase
    {
        #region Instance Variables (8)

        private int _idSegnalazione;
        private int _idTipoSegnalazione;
        private int _idRegistro;
        private int _idSoggetto;
        private DateTime _dataSegnalazione;
        private Boolean _visible;
        private String _descrizione;
        private DateTime? _dataUltimaModifica;
        private string _operatoreUltimaModifica;
        private string _numeroRea;
        private string _denominazione;
        private Boolean _apply;
       

        #endregion Instance Variables

        #region Public Properties (9)


        /// <summary>
        /// Gets or sets the id tipo segnalazione.
        /// </summary>
        /// <value>The id tipo segnalazione.</value>
        [Bindable(true)]
        public int IdTipoSegnalazione
        {
            get { return _idTipoSegnalazione; }
            set { _idTipoSegnalazione = value; }
        }

        /// <summary>
        /// Gets or sets the id attivita.
        /// </summary>
        /// <value>The id attivita.</value>
        [Bindable(true)]
        public int IdSegnalazione
        {
            get { return _idSegnalazione; }
            set { _idSegnalazione = value; }
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
        /// Gets or sets the visible.
        /// </summary>
        /// <value>The visible.</value>
        [Bindable(true)]
        public Boolean Visible
        {
            get { return _visible; }
            set { _visible = value; }
        }

        /// <summary>
        /// Gets or sets the note.
        /// </summary>
        /// <value>The note.</value>
        [Bindable(true)]
        public String Descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
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
        /// Gets or sets the data segnalazione.
        /// </summary>
        /// <value>The data segnalazione.</value>
        [Bindable(true)]
        public DateTime DataSegnalazione
        {
            get { return _dataSegnalazione; }
            set { _dataSegnalazione = value; }
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

        public string NumeroRea
        {
            get { return _numeroRea; }
            set { _numeroRea = value; }
        }

        public string Denominazione
        {
            get { return _denominazione; }
            set { _denominazione = value; }
        }

        public int IdSoggetto
        {
            get { return _idSoggetto; }
            set { _idSoggetto = value; }
        }

        [Bindable(true)]
        public Boolean Apply
        {
            get { return _apply; }
            set { _apply = value; }
        }
        
        #endregion Public Properties
    }
}
