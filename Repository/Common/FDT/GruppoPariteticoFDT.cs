using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using it.dedagroup.GVC.Repository.Common.RicercheWrapper;

namespace it.dedagroup.GVC.Repository.Common.FDT
{
   /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public partial class GruppoPariteticoFDT : FDTBase, DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo
    {
        #region Instance Variables (9)
        private int _idGruppoParitetico;
        private DateTime _dataAtto;
        private DateTime? _dataFine;
        private String _note;
        private DateTime? _dataUltimaModifica;
        private string _operatoreUltimaModifica;
        private CooperativaFDT[] cooperative;
        private int _idDirigente;
        private string _numeroAtto;


        #endregion Instance Variables

        #region Public Properties (9)

        /// <summary>
        /// Gets or sets the id gruppo paritetico.
        /// </summary>
        /// <value>The id gruppo paritetico..</value>
        [Bindable(true)]
        public int IdGruppoParitetico
        {
            get { return _idGruppoParitetico; }
            set { _idGruppoParitetico = value; }
        }

        /// <summary>
        /// Gets or sets the id Numero Atto.
        /// </summary>
        /// <value>The Numero Atto gruppo paritetico..</value>
        [Bindable(true)]
        public string NumeroAtto
        {
            get { return _numeroAtto; }
            set { _numeroAtto = value; }
        }

        /// <summary>
        /// Gets or sets the data atto di riferimento.
        /// </summary>
        /// <value>The data atto di riferimento.</value>
        [Bindable(true)]
        public DateTime DataAtto
        {
            get { return _dataAtto; }
            set { _dataAtto = value; }
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

        public CooperativaFDT[] Cooperative
        {
            get { return cooperative; }
            set { cooperative = value; }
        }

        public int IdDirigente
        {
            get { return _idDirigente; }
            set { _idDirigente = value; }
        }

        [Bindable(true)]
        public DateTime? DataFine
        {
            get { return _dataFine; }
            set { _dataFine = value; }
        }

        [Bindable(true)]
        public string Descrizione
        {
            get { return String.Concat(_numeroAtto, " - ", _dataAtto.ToShortDateString()); }
        }

        #endregion Public Properties   


        public void AddCooperative(CooperativaFDT coop) 
        {
            if(this.cooperative == null)
                this.cooperative = new CooperativaFDT[0];
            List<CooperativaFDT> coopList = new List<CooperativaFDT>(this.cooperative);
            coopList.Add(coop);
            this.cooperative = coopList.ToArray();
        }

        public void RemoveCooperative(CooperativaFDT coop)
        {
            if (this.cooperative == null)
                return;
            List<CooperativaFDT> coopList = new List<CooperativaFDT>(this.cooperative);
            coopList.Remove(coop);
            this.cooperative = coopList.ToArray();
        }

        public Boolean IsCooperativeMember(CooperativaFDT coop) 
        {
            if (coop == null || this.Cooperative == null)
                return false;
            for (int i = 0; i < this.Cooperative.Length; i++) 
            {
                if (this.Cooperative[i].RegistroCooperativa.IdRegistro == coop.RegistroCooperativa.IdRegistro)
                    return true;
            }
            return false;
        }

        public void ReadDirigente()
        {
            if (this.Cooperative == null)
                return;
            for (int i = 0; i < this.Cooperative.Length; i++)
                if (this.Cooperative[i].RegistroCooperativa.Dirigente)
                    this.IdDirigente = this.Cooperative[i].RegistroCooperativa.IdRegistro;
        }

        public void WriteDirigente()
        {
            if (this.Cooperative == null)
                return;
            for (int i = 0; i < this.Cooperative.Length; i++)
                if (this.Cooperative[i].RegistroCooperativa.IdRegistro == this.IdDirigente)
                    this.Cooperative[i].RegistroCooperativa.Dirigente = true;
        }

        #region PropertyNames Class

        /// <summary>
        /// PropertyNames
        /// </summary>
        public partial class PropertyNames
        {
            public const string DataAtto = "DataAtto";
            public const string NumeroAtto = "NumeroAtto";
        }

        #endregion PropertyNames Class

        #region IDXDataErrorInfo Members

        public void GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
            
        }

        public void GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
            if ((propertyName == PropertyNames.DataAtto && !(DataAtto > DateTime.MinValue)))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }

            if ((propertyName == PropertyNames.NumeroAtto && string.IsNullOrEmpty(NumeroAtto)))
            {
                info.ErrorText = "Campo obbligatorio";
                info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            }
        }

        #endregion
    }
}

