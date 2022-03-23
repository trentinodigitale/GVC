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
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.PersonaFisicaFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.PersonaGiuridicaFDT))]
    public partial class CollegamentoSocietaFDT : FDTBase
    {
        #region Instance Variables (5)

        private int _idCollegamento;
        private int _idModificaStatutaria;
        private int _idSoggetto;
        private String _note;

        private SoggettoFDT _societa;

        #endregion Instance Variables

        #region Public Properties

        /// <summary>
        /// Gets or sets the id collegamento.
        /// </summary>
        /// <value>The id collegamento.</value>
        [Bindable(true)]
        public int IdCollegamento
        {
            get { return _idCollegamento; }
            set { _idCollegamento = value; }
        }

        /// <summary>
        /// Gets or sets the id modifica statutaria.
        /// </summary>
        /// <value>The id modifica statutaria.</value>
        [Bindable(true)]
        public int IdModificaStatutaria
        {
            get { return _idModificaStatutaria; }
            set { _idModificaStatutaria = value; }
        }

        /// <summary>
        /// Gets or sets the id soggetto.
        /// </summary>
        /// <value>The id soggetto.</value>
        [Bindable(true)]
        public int IdSoggetto
        {
            get { return _idSoggetto; }
            set { _idSoggetto = value; }
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
        /// Gets or sets the societa.
        /// </summary>
        /// <value>The societa.</value>
        [Bindable(true)]
        public SoggettoFDT Societa
        {
            get { return _societa; }
            set { _societa = value; }
        }

        #endregion Public Properties

    }
}
