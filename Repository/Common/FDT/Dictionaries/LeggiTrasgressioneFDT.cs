using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.FDT.Dictionaries
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public partial class LeggiTrasgressioneFDT : DizionarioFDT, DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo
    {
        #region Instance Variables

        private int _idTipoTrasgressione;

        private String _entita;

        #endregion Instance Variables

        #region Public Properties

        [Bindable(true)]
        public int IdTipoTrasgressione
        {
            get { return _idTipoTrasgressione; }
            set { _idTipoTrasgressione = value; }
        }

        [Bindable(true)]
        public String Entita
        {
            get { return _entita; }
            set { _entita = value; }
        }

        #endregion Public Properties

        #region PropertyNames Class

        /// <summary>
        /// PropertyNames
        /// </summary>
        public partial class PropertyNames
        {
            public const string Descrizione = "Descrizione";
            public const string Entita = "Entita";
            public const string IdNatura = "IdNatura";
        }

        #endregion PropertyNames Class

        #region IDXDataErrorInfo Members

        public void GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {

        }

        public void GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
            if (propertyName == PropertyNames.IdNatura && IdTipoTrasgressione <= 0)
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }

            if (propertyName == PropertyNames.Descrizione && String.IsNullOrEmpty(Descrizione))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }

            if (propertyName == PropertyNames.Entita && String.IsNullOrEmpty(Entita))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }
        }

        #endregion

    }
}
