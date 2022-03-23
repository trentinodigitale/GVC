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
    [Serializable]
    public class PersonaGiuridicaFDT : SoggettoFDT, DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo
    {
        #region Instance Variables (2)

        private String _denominazione;
        //private int _idTipoPersonaGiuridica;

        #endregion Instance Variables (2)

        #region Public Properties (2)

        /// <summary>
        /// Gets or sets the id tipo persona giuridica.
        /// </summary>
        /// <value>The id tipo persona giuridica.</value>
        //[Bindable(true)]
        //public int IdTipoPersonaGiuridica
        //{
        //    get { return _idTipoPersonaGiuridica; }
        //    set { _idTipoPersonaGiuridica = value; }
        //}

        /// <summary>
        /// Gets or sets the denominazione.
        /// </summary>
        /// <value>The denominazione.</value>
        [Bindable(true)]
        public string Denominazione
        {
            get { return _denominazione; }
            set { _denominazione = value; }
        }

        #endregion Public Properties


        #region IDXDataErrorInfo Members

        public override void GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
           
        }

        public override void GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
            String msg = "Richiesto";

            base.GetPropertyError(propertyName, info);

            if (propertyName.Contains("Denominazione") && String.IsNullOrEmpty(_denominazione))
            {
                info.ErrorText = msg;
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }
        }

        #endregion
    }
}
