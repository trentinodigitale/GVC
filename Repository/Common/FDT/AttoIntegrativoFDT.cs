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
    public partial class AttoIntegrativoFDT : FDTBase, DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo
    {
        #region Instance Variables (4)

        private int _idAttoIntegrativo;
        private int _idTipoAtto;
        private int _idAssemblea;
        //private String _codiceAtto;
        private DateTime _dataAtto;
        private String _descrizioneDatoStorico;
        private DateTime? _dataUltimaModifica;
        private string _operatoreUltimaModifica;

        #endregion Instance Variables

        #region Public Properties (4)

        /// <summary>
        /// Gets or sets the descrizione dato storico.
        /// </summary>
        /// <value>The descrizione dato storico.</value>
        [Bindable(true)]
        public string DescrizioneDatoStorico
        {
            get { return _descrizioneDatoStorico; }
            set { _descrizioneDatoStorico = value; }
        }

        /// <summary>
        /// Gets or sets the data atto.
        /// </summary>
        /// <value>The data atto.</value>
        [Bindable(true)]
        public DateTime DataAtto
        {
            get { return _dataAtto; }
            set { _dataAtto = value; }
        }

        /// <summary>
        /// Gets or sets the codice atto.
        /// </summary>
        /// <value>The codice atto.</value>
        //[Bindable(true)]
        //public string CodiceAtto
        //{
        //    get { return _codiceAtto; }
        //    set { _codiceAtto = value; }
        //}

        /// <summary>
        /// Gets or sets the id atto integrativo.
        /// </summary>
        /// <value>The id atto integrativo.</value>
        [Bindable(true)]
        public int IdAttoIntegrativo
        {
            get { return _idAttoIntegrativo; }
            set { _idAttoIntegrativo = value; }
        }

        /// <summary>
        /// Gets or sets the id tipo atto.
        /// </summary>
        /// <value>The id tipo atto.</value>
        [Bindable(true)]
        public int IdTipoAtto
        {
            get { return _idTipoAtto; }
            set { _idTipoAtto = value; }
        }

        /// <summary>
        /// Gets or sets the id assemblea.
        /// </summary>
        /// <value>The id assemblea.</value>
        [Bindable(true)]
        public int IdAssemblea
        {
            get { return _idAssemblea; }
            set { _idAssemblea = value; }
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
            public const string TipoAtto = "IdTipoAtto";
            public const string DataAtto = "DataAtto";
        }

        #endregion PropertyNames Class

        #region IDXDataErrorInfo Members

        public void GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {

        }

        public void GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {

            if ((propertyName == PropertyNames.TipoAtto && (_idTipoAtto == null || _idTipoAtto <= 0)))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }

            if ((propertyName == PropertyNames.DataAtto && (_dataAtto == DateTime.MinValue || _dataAtto == DateTime.MaxValue)))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }
        }

        #endregion
    }
}
