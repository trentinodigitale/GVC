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
    public partial class DizionarioFDT : FDTBase, DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo
    {


        #region Instance Variables 

        private int _idElemento;
        private string _descrizione;
        private string _tipo;
        private string _codice;
        private Boolean _attivo;
        private Boolean _flag;

        private DettaglioDizionarioFDT _dettaglio;

        #endregion Instance Variables


        #region Public Properties 

        /// <summary>
        /// Gets or sets the dettaglio.
        /// </summary>
        /// <value>The dettaglio.</value>
        [Bindable(true)]
        public DettaglioDizionarioFDT Dettaglio
        {
            get { return _dettaglio; }
            set { _dettaglio = value; }
        }

        /// <summary>
        /// Contains the second flag 0=True 1=False
        /// </summary>
        /// <value><c>true</c> if flag; otherwise, <c>false</c>.</value>
        [Bindable(true)]
        public Boolean Flag
        {
            get { return _flag; }
            set { _flag = value; }
        }

        /// <summary>
        /// Indicates if the record is active 0=True 1=False
        /// </summary>
        /// <value><c>true</c> if attivo; otherwise, <c>false</c>.</value>
        [Bindable(true)]
        public Boolean Attivo
        {
            get { return _attivo; }
            set { _attivo = value; }
        }

        /// <summary>
        /// Gets or sets the type
        /// </summary>
        /// <value>The tipo.</value>
        [Bindable(true)]
        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

      

        /// <summary>
        /// Gets or sets the codice.
        /// </summary>
        /// <value>The codice.</value>
        [Bindable(true)]
        public string Codice
        {
            get { return _codice; }
            set { _codice = value; }
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
        /// Gets or sets the id elemento.
        /// </summary>
        /// <value>The id elemento.</value>
        [Bindable(true)]
        public int IdElemento
        {
            get { return _idElemento; }
            set { _idElemento = value; }
        }


        /// <summary>
        /// Gets or sets the id elemento.
        /// </summary>
        /// <value>The id elemento.</value>
        [Bindable(true)]
        public string CodiceEdescrizione
        {
            get { return String.Concat(_codice, " - ", _descrizione); }
        }

        #endregion Public Properties

        #region PropertyNames Class

        /// <summary>
        /// PropertyNames
        /// </summary>
        public partial class PropertyNames
        {
            public const string Descrizione = "Descrizione";
        }

        #endregion PropertyNames Class

        #region IDXDataErrorInfo Members

        public void GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {

        }

        public void GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
            if (propertyName == PropertyNames.Descrizione && String.IsNullOrEmpty(Descrizione))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }
        }

        #endregion

        public DizionarioFDT()
        { }

        public DizionarioFDT(int id, string type)
        {
            _idElemento = id;
            _tipo = type;

           
        }

        public override void OnCreateInstance()
        {
            _flag = true;

            base.OnCreateInstance();
        }
    }
}
