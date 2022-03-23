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
    public class SoggettoPerVisualizzazioneFDT
    {


        #region Instance Variables (5)

        private int _identificativo;
        private int _idTipo;

        private Boolean _associazione;

        private String _numeroREA;
        private int _codiceCooperativa;

        private string _nominativo;
        private String _codiceFiscale;
        private string _comuneNascita;
        private DateTime? _dataNascita;

        private SoggettoFDT _soggetto;

        #endregion Instance Variables (5)


        #region Public Properties (6)

        [Bindable(true)]
        public int CodiceCooperativa
        {
            get { return _codiceCooperativa; }
            set { _codiceCooperativa = value; }
        }

        [Bindable(true)]
        public String NumeroREA
        {
            get { return _numeroREA; }
            set { _numeroREA = value; }
        }

        [Bindable(true)]
        public SoggettoFDT Soggetto
        {
            get { return _soggetto; }
            set { _soggetto = value; }
        }
	
        [Bindable(true)]
        public DateTime? DataNascita
        {
            get { return _dataNascita; }
            set { _dataNascita = value; }
        }

        [Bindable(true)]
        public string ComuneNascita
        {
            get { return _comuneNascita; }
            set { _comuneNascita = value; }
        }

        [Bindable(true)]
        public string Nominativo
        {
            get { return _nominativo; }
            set { _nominativo = value; }
        }

        /// <summary>
        /// Gets or sets the codice fiscale.
        /// </summary>
        /// <value>The codice fiscale.</value>
        [Bindable(true)]
        public string CodiceFiscale
        {
            get { return _codiceFiscale; }
            set { _codiceFiscale = value; }
        }

        /// <summary>
        /// Gets or sets the id tipo soggetto.
        /// </summary>
        /// <value>The id tipo soggetto.</value>
        [Bindable(true)]
        public int IdTipoSoggetto
        {
            get { return _idTipo; }
            set { _idTipo = value; }
        }

        /// <summary>
        /// Gets or sets the id soggetto.
        /// </summary>
        /// <value>The id soggetto.</value>
        [Bindable(true)]
        public int IdSoggetto
        {
            get { return _identificativo; }
            set { _identificativo = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="SoggettoFDT"/> is associazione.
        /// </summary>
        /// <value><c>true</c> if associazione; otherwise, <c>false</c>.</value>
        [Bindable(true)]
        public Boolean Associazione
        {
            get { return _associazione; }
            set { _associazione = value; }
        }

        #endregion Public Properties

    }
}
