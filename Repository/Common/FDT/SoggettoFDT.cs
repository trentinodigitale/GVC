using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.FDT
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.FDTBase))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.PersonaFisicaFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.PersonaGiuridicaFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.IndirizzoFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.RegistroCooperativaFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.AdesioneFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.DocumentazioneFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.DeliberaAssembleaFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.AttoIntegrativoFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.ModificaStatutariaFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.AttivitaFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.CambioPosizioneFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.CancellazioneFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.ComunicazioneBaseSocialeFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.ComunicazioneCaricaSocialeFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.CaricaSocialeFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.LiquidazioneCoattaFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.AutorizzazioneFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.CompensoFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.DeliberaAcquistoCreditiFiscFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.CompensoLiquidazioneFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.RelazioneSemestraleFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.ProceduraCoattaFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.ProrogaFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.ProceduraFallimentareFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.RevisioneFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.RevisioneIncaricoFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.ScadenziarioFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.SoggettoFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.CooperativaFDT))]
    [Serializable]
    public class SoggettoFDT : FDTBase, DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo
    {
        #region Instance Variables (5)

        private int _idSoggetto;
        private int _idTipoSoggetto;

        private String _codiceFiscale;
        //private String _partitaIVA;

        private Boolean _associazione;
        private Boolean _personaFisica;
       
        private String _note;
        private DateTime? _dataUltimaModifica;
        private string _operatoreUltimaModifica;
        private string _telefono;
        private string _email;

        private IndirizzoFDT[] _indirizzi;
        private GruppoPariteticoFDT[] _gruppiPariteticiAppartenenza;

        #endregion Instance Variables (5)

        #region Public Properties (6)


        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
        [Bindable(true)]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }


        /// <summary>
        /// Gets or sets the telefono.
        /// </summary>
        /// <value>The telefono.</value>
        [Bindable(true)]
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [persona fisica].
        /// </summary>
        /// <value><c>true</c> if [persona fisica]; otherwise, <c>false</c>.</value>
        [Bindable(true)]
        public Boolean PersonaFisica
        {
            get { return _personaFisica; }
            set { _personaFisica = value; }
        }

        /// <summary>
        /// Gets or sets the note.
        /// </summary>
        /// <value>The note.</value>
        [Bindable(true)]
        public string Note
        {
            get { return _note; }
            set { _note = value; }
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

        ///// <summary>
        ///// Gets or sets the partita IVA.
        ///// </summary>
        ///// <value>The partita IVA.</value>
        //[Bindable(true)]
        //public string PartitaIVA
        //{
        //    get { return _partitaIVA; }
        //    set { _partitaIVA = value; }
        //}

        /// <summary>
        /// Gets the nome completo.
        /// </summary>
        /// <value>The nome completo.</value>
        //[Bindable(true)]
        //public string NomeCompleto
        //{
        //    get { return _denominazione; }
        //}

        /// <summary>
        /// Gets the descrizione breve.
        /// </summary>
        /// <value>The descrizione breve.</value>
        [Bindable(true)]
        public string DescrizioneBreve
        {
            get
            {
                string toReturn = string.Empty;

                if (this is PersonaFisicaFDT)
                {
                    PersonaFisicaFDT p = this as PersonaFisicaFDT;
                    if (p != null)
                    {
                        toReturn = p.NomeCompleto;
                    }
                }
                else if (this is CooperativaFDT)
                {
                    CooperativaFDT c = this as CooperativaFDT;
                    if (c != null)
                    {
                        toReturn = c.Denominazione;
                    }
                }
                else if (this is PersonaGiuridicaFDT)
                {
                    PersonaGiuridicaFDT j = this as PersonaGiuridicaFDT;
                    if (j != null)
                    {
                        toReturn = j.Denominazione;
                    }
                }

                return toReturn;
            }
        }

        /// <summary>
        /// Gets or sets the id tipo soggetto.
        /// </summary>
        /// <value>The id tipo soggetto.</value>
        [Bindable(true)]
        public int IdTipoSoggetto
        {
            get { return _idTipoSoggetto; }
            set { _idTipoSoggetto = value; }
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
        /// Gets or sets a value indicating whether this <see cref="SoggettoFDT"/> is associazione.
        /// </summary>
        /// <value><c>true</c> if associazione; otherwise, <c>false</c>.</value>
        [Bindable(true)]
        public Boolean Associazione
        {
            get { return _associazione; }
            set { _associazione = value; }
        }

        /// <summary>
        /// Gets or sets the gruppiPariteticiAppartenenza.
        /// </summary>
        /// <value>The gruppiPariteticiAppartenenza.</value>
        [Bindable(true)]
        public GruppoPariteticoFDT[] GruppiPariteticiAppartenenza
        {
            get { return _gruppiPariteticiAppartenenza; }
            set { _gruppiPariteticiAppartenenza = value; }
        }

        /// <summary>
        /// Gets or sets the indirizzi.
        /// </summary>
        /// <value>The indirizzi.</value>
        [Bindable(true)]
        public IndirizzoFDT[] Indirizzi
        {
            get { return _indirizzi; }
            set { _indirizzi = value; }
        }

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

        /// <summary>
        /// Gets the indirizzo sede.
        /// </summary>
        /// <value>The indirizzo sede.</value>
        [Bindable(true)]
        public String IndirizzoSede
        {
            get
            {
                string toReturn = string.Empty;

                IndirizzoFDT tmp = null;
                if (_indirizzi != null && _indirizzi.Length > 0)
                {
                    for (int i = 0; i < _indirizzi.Length; i++)
                    {
                        if (_indirizzi[i].Status < it.dedagroup.GVC.Repository.Common.Configurations.ObjectStatus.ToHide)
                        {
                            if (_indirizzi[i].Sede && 
                                (!_indirizzi[i].DataFine.HasValue || _indirizzi[i].DataFine.Value.Date >= DateTime.Now.Date))
                            {
                                tmp = _indirizzi[i];
                                break;
                            }
                        }
                    }

                    if (tmp != null)
                    {
                        if (!String.IsNullOrEmpty(tmp.Frazione))
                            toReturn = string.Concat(tmp.Via, " ", tmp.NumeroCivico, ", ", tmp.Frazione, ", ", tmp.Comune, ", (", tmp.Provincia, ")");
                        else
                            toReturn = string.Concat(tmp.Via, " ", tmp.NumeroCivico, ", ", tmp.Comune, ", (", tmp.Provincia, ")");
                    }
                }

                return toReturn;
            }
        }

        #endregion Public Properties

        private Byte[] icona;

        [Bindable(true)]
        public Byte[] Icona
        {
            get { return icona; }
            set { icona = value; }
        }
	
        public override string ToString()
        {
            return DescrizioneBreve;
        }

        public void AddIndirizzo(IndirizzoFDT item)
        {
            if (_indirizzi == null)
                _indirizzi = new IndirizzoFDT[] { };

            List<IndirizzoFDT> lTemp = new List<IndirizzoFDT>(_indirizzi);
            lTemp.Add(item);
            _indirizzi = lTemp.ToArray();
        }


        #region IDXDataErrorInfo Members

        public virtual void GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
            
        }

        public virtual void GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
            string msg = "Richiesto";

            if (propertyName.EndsWith("IdTipoSoggetto") && _idTipoSoggetto <= 0)
            {
                info.ErrorText = msg;
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            }

            if (propertyName.EndsWith("CodiceFiscale") && String.IsNullOrEmpty(_codiceFiscale))
            {
                info.ErrorText = msg;
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            }

        }

        #endregion
    }
}
