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
    public partial class DeliberaAssembleaFDT : FDTBase, DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo
    {
        #region Instance Variables (15)

        private int _idDeliberaAssemblea;
        private int _idTipoAssemblea;
        private int _idNotaio;
        private int _idRegistro;
        private DateTime _dataAssemblea;
        private String _contenuto;
        //private double _durataProcessoUfficio;
        private DateTime? _dataIscrizRegistroImprese;
        private String _numeroEsameCommissione;
        private DateTime? _dataEsameCommissione;
        private DateTime? _dataEvasioneUfficio;
        private DateTime? _dataUltimaModifica;
        private String _operatoreUltimaModifica;
        
        private PersonaFisicaFDT _notaio;
        private ModificaStatutariaFDT[] _modificheStatutarie;
        private AttoIntegrativoFDT[] _attiIntegrativi;
        private DocumentazioneFDT[] _documentazioni;

        private DatiStoriciFDT[] _datiStorici;

        //private DateTime _officeMinutesReceivingDate;

        #endregion Instance Variables (15)

        #region Public Properties (15)

        /// <summary>
        /// Gets or sets the dati storici.
        /// </summary>
        /// <value>The dati storici.</value>
        public DatiStoriciFDT[] DatiStorici
        {
            get { return _datiStorici; }
            set { _datiStorici = value; }
        }

        /// <summary>
        /// Gets or sets the documentazioni.
        /// </summary>
        /// <value>The documentazioni.</value>
        [Bindable(true)]
        public DocumentazioneFDT[] Documentazioni
        {
            get { return _documentazioni; }
            set { _documentazioni = value; }
        }

        /// <summary>
        /// Gets or sets the modifiche statutarie.
        /// </summary>
        /// <value>The modifiche statutarie.</value>
        [Bindable(true)]
        public ModificaStatutariaFDT[] ModificheStatutarie
        {
            get { return _modificheStatutarie; }
            set { _modificheStatutarie = value; }
        }

        /// <summary>
        /// Gets or sets the supplementary acts.
        /// </summary>
        /// <value>The supplementary acts.</value>
        [Bindable(true)]
        public AttoIntegrativoFDT[] AttiIntegrativi
        {
            get { return _attiIntegrativi; }
            set { _attiIntegrativi = value; }
        }

        /// <summary>
        /// Gets or sets the id notaio.
        /// </summary>
        /// <value>The id notaio.</value>
        [Bindable(true)]
        public int IdNotaio
        {
            get { return _idNotaio; }
            set { _idNotaio = value; }
        }

        /// <summary>
        /// Gets or sets the numero esame commissione.
        /// </summary>
        /// <value>The numero esame commissione.</value>
        [Bindable(true)]
        public String NumeroEsameCommissione
        {
            get { return _numeroEsameCommissione; }
            set { _numeroEsameCommissione = value; }
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
        /// Gets or sets the notaio.
        /// </summary>
        /// <value>The notaio.</value>
        [Bindable(true)]
        public PersonaFisicaFDT Notaio
        {
            get { return _notaio; }
            set { _notaio = value; }
        }

        /// <summary>
        /// Gets or sets the data esame ufficio.
        /// </summary>
        /// <value>The data esame ufficio.</value>
        [Bindable(true)]
        public DateTime? DataEvasioneUfficio
        {
            get { return _dataEvasioneUfficio; }
            set { _dataEvasioneUfficio = value; }
        }

        /// <summary>
        /// Gets or sets the data esame commissione.
        /// </summary>
        /// <value>The data esame commissione.</value>
        [Bindable(true)]
        public DateTime? DataEsameCommissione
        {
            get { return _dataEsameCommissione; }
            set { _dataEsameCommissione = value; }
        }

        /// <summary>
        /// Gets or sets the data iscriz registro imprese.
        /// </summary>
        /// <value>The data iscriz registro imprese.</value>
        [Bindable(true)]
        public DateTime? DataIscrizRegistroImprese
        {
            get { return _dataIscrizRegistroImprese; }
            set { _dataIscrizRegistroImprese = value; }
        }

        /// <summary>
        /// Gets or sets the durata processo ufficio.
        /// </summary>
        /// <value>The durata processo ufficio.</value>
        //[Bindable(true)]
        //public double DurataProcessoUfficio
        //{
        //    get { return _durataProcessoUfficio; }
        //    set { _durataProcessoUfficio = value; }
        //}

        /// <summary>
        /// Gets or sets the office minutes receiving date.
        /// </summary>
        /// <value>The office minutes receiving date.</value>
        //[Bindable(true)]
        //public DateTime OfficeMinutesReceivingDate
        //{
        //    get { return _officeMinutesReceivingDate; }
        //    set { _officeMinutesReceivingDate = value; }
        //}

        /// <summary>
        /// Gets or sets the contenuto.
        /// </summary>
        /// <value>The contenuto.</value>
        [Bindable(true)]
        public string Contenuto
        {
            get { return _contenuto; }
            set { _contenuto = value; }
        }

        /// <summary>
        /// Gets or sets the id tipo assemblea.
        /// </summary>
        /// <value>The id tipo assemblea.</value>
        [Bindable(true)]
        public int IdTipoAssemblea
        {
            get { return _idTipoAssemblea; }
            set { _idTipoAssemblea = value; }
        }

        /// <summary>
        /// Gets or sets the data assemblea.
        /// </summary>
        /// <value>The data assemblea.</value>
        [Bindable(true)]
        public DateTime DataAssemblea
        {
            get { return _dataAssemblea; }
            set { _dataAssemblea = value; }
        }

        /// <summary>
        /// Gets or sets the id delibera assemblea.
        /// </summary>
        /// <value>The id delibera assemblea.</value>
        [Bindable(true)]
        public int IdDeliberaAssemblea
        {
            get { return _idDeliberaAssemblea; }
            set { _idDeliberaAssemblea = value; }
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

        #region PropertyNames Class

        /// <summary>
        /// PropertyNames
        /// </summary>
        public partial class PropertyNames
        {
            public const string DataAssemblea = "DataAssemblea";
            public const string IdTipoAssemblea = "IdTipoAssemblea";
            public const string DataIscrizRegistroImprese = "DataIscrizRegistroImprese";
        }

        #endregion PropertyNames Class

        #region IDXDataErrorInfo Members

        public void GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {

        }

        public void GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
            if ((propertyName == PropertyNames.DataAssemblea && (_dataAssemblea == DateTime.MinValue || _dataAssemblea == DateTime.MaxValue)))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }

            if ((propertyName == PropertyNames.IdTipoAssemblea && _idTipoAssemblea < 1))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }

            if ((propertyName == PropertyNames.DataIscrizRegistroImprese && (!_dataIscrizRegistroImprese.HasValue || _dataIscrizRegistroImprese == DateTime.MinValue || _dataIscrizRegistroImprese == DateTime.MaxValue)))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }

        }

        #endregion

        #region Methods

        public void AddAttoIntegrativo(AttoIntegrativoFDT item)
        {
            if (item != null)
            {
                if (_attiIntegrativi == null)
                    _attiIntegrativi = new AttoIntegrativoFDT[] { };

                List<AttoIntegrativoFDT> listTmp = new List<AttoIntegrativoFDT>(_attiIntegrativi);
                listTmp.Add(item);

                _attiIntegrativi = listTmp.ToArray();
            }
        }

        public void AddModificaStatutaria(ModificaStatutariaFDT item)
        {
            if (item != null)
            {
                if (_modificheStatutarie == null)
                    _modificheStatutarie = new ModificaStatutariaFDT[] { };

                List<ModificaStatutariaFDT> listTmp = new List<ModificaStatutariaFDT>(_modificheStatutarie);
                listTmp.Add(item);

                _modificheStatutarie = listTmp.ToArray();
            }
        }

        #endregion Methods
    }
}
