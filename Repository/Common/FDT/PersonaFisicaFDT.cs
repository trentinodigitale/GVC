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
    public partial class PersonaFisicaFDT : SoggettoFDT, DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo
    {
        #region Instance Variables (10)

        private String _cognome;
        private String _nome;
        private String _sesso;
        private String _cognomeAcquisito;
        private DateTime _dataNascita;
        private String _comuneNascita;
        private String _statoNascita;
        private String _cittadinanza;
       // private String _statoCivile;
        private String _cellulare;

        #endregion Instance Variables (10)

        #region Public Properties (10)

        /// <summary>
        /// Gets or sets the cellulare.
        /// </summary>
        /// <value>The cellulare.</value>
        [Bindable(true)]
        public string Cellulare
        {
            get { return _cellulare; }
            set { _cellulare = value; }
        }

        ///// <summary>
        ///// Gets or sets the stato civile.
        ///// </summary>
        ///// <value>The stato civile.</value>
        //[Bindable(true)]
        //public string StatoCivile
        //{
        //    get { return _statoCivile; }
        //    set { _statoCivile = value; }
        //}

        /// <summary>
        /// Gets or sets the cittadinanza.
        /// </summary>
        /// <value>The cittadinanza.</value>
        [Bindable(true)]
        public string Cittadinanza
        {
            get { return _cittadinanza; }
            set { _cittadinanza = value; }
        }

        /// <summary>
        /// Gets or sets the stato nascita.
        /// </summary>
        /// <value>The stato nascita.</value>
        [Bindable(true)]
        public string StatoNascita
        {
            get { return _statoNascita; }
            set { _statoNascita = value; }
        }

        /// <summary>
        /// Gets or sets the comune nascita.
        /// </summary>
        /// <value>The comune nascita.</value>
        [Bindable(true)]
        public string ComuneNascita
        {
            get { return _comuneNascita; }
            set { _comuneNascita = value; }
        }

        /// <summary>
        /// Gets or sets the data nascita.
        /// </summary>
        /// <value>The data nascita.</value>
        [Bindable(true)]
        public DateTime DataNascita
        {
            get { return _dataNascita; }
            set { _dataNascita = value; }
        }

        /// <summary>
        /// Gets or sets the cognome acquisito.
        /// </summary>
        /// <value>The cognome acquisito.</value>
        [Bindable(true)]
        public string CognomeAcquisito
        {
            get { return _cognomeAcquisito; }
            set { _cognomeAcquisito = value; }
        }

        /// <summary>
        /// Gets or sets the sesso.
        /// </summary>
        /// <value>The sesso.</value>
        [Bindable(true)]
        public string Sesso
        {
            get { return _sesso; }
            set { _sesso = value; }
        }

        /// <summary>
        /// Gets or sets the nome.
        /// </summary>
        /// <value>The nome.</value>
        [Bindable(true)]
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        /// <summary>
        /// Gets or sets the cognome.
        /// </summary>
        /// <value>The cognome.</value>
        [Bindable(true)]
        public string Cognome
        {
            get { return _cognome; }
            set { _cognome = value; }
        }

        /// <summary>
        /// Gets the nome completo.
        /// </summary>
        /// <value>The nome completo.</value>
        [Bindable(true)]
        public string NomeCompleto
        {
            get { return DescrizioneToString(); }
        }

        #endregion Public Properties

        #region Methods

        /// <summary>
        /// Descriziones to string.
        /// </summary>
        /// <returns></returns>
        public string DescrizioneToString()
        {
            return String.Concat(_cognome, " ", _nome);
        }

        /// <summary>
        /// Called when [create instance].
        /// </summary>
        public override void OnCreateInstance()
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            GVCResourcesUtility.Get_16x16(GVCResources.Businessman_24x24).Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            this.Icona = ms.ToArray();
            base.OnCreateInstance();
        }

        #endregion Methods

        #region IDXDataErrorInfo Members

        void DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo.GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
           
        }

        void DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo.GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
            base.GetPropertyError(propertyName, info);

            info.ErrorText = "";

            if (propertyName.Equals("Nome") && String.IsNullOrEmpty(_nome))
            {
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
                
            }

            if (propertyName.Equals("Cognome") && String.IsNullOrEmpty(_cognomeAcquisito))
            {
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            }

            if (propertyName.Equals("CognomeAcquisito") && String.IsNullOrEmpty(_cognomeAcquisito))
            {
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            }

        }

        #endregion
    }
}
