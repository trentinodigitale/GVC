using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.FDT
{
    /// <summary>
    /// Base class for FDTs
    /// </summary>
   
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "FDTBase", Namespace = "http://schemas.datacontract.org/2004/07/it.dedagroup.GVC.Repository.Common.FDT")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.Dictionaries.DatiFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.IndirizzoFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.AttoIntegrativoFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.RevisioneIncaricoFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.CompensoFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.ProrogaFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.RegistroCooperativaFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.AdesioneFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.DocumentazioneFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.DeliberaAssembleaFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.ModificaStatutariaFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.AttivitaFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.CambioPosizioneFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.CancellazioneFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.ComunicazioneBaseSocialeFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.ComunicazioneCaricaSocialeFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.CaricaSocialeFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.LiquidazioneCoattaFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.AutorizzazioneFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.DeliberaAcquistoCreditiFiscFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.CompensoLiquidazioneFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.RelazioneSemestraleFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.ProceduraCoattaFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.ProceduraFallimentareFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.RevisioneFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.ScadenziarioFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.SoggettoFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.PersonaGiuridicaFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.CooperativaFDT))]
    [Serializable]
    public partial class FDTBase : IEditableObject
    {

		#region Fields (3) 

        private int _status;
        private System.Boolean inBindingEdit;
        private System.Collections.Hashtable state;

		#endregion Fields 

		#region Constructors (1) 

        public FDTBase()
        {
            OnCreateInstance();
        }

		#endregion Constructors 

		#region Properties (1) 

        /// <summary>
        /// Gets or sets the status. Used for the grid and the save procedures
        /// </summary>
        /// <value>The status.</value>
        [Bindable(true)]
        [System.Runtime.Serialization.DataMember()]
        public int Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }

		#endregion Properties 

		#region Methods (18) 


		// Public Methods (4) 

        public void BeginEdit()
        {
            if (this.inBindingEdit) return;

            this.OnBeforeBeginEdit();

            this.CopyState();

            this.OnAfterBeginEdit();

            this.inBindingEdit = true;
        }

        public void CancelEdit()
        {
            if (!this.inBindingEdit) return;

            this.OnBeforeCancelEdit();

            this.RollbackChanges();

            this.OnAfterCancelEdit();

            this.inBindingEdit = false;
        }

        public void EndEdit()
        {
            if (!this.inBindingEdit) return;

            this.OnBeforeEndEdit();

            this.CommitChanges();

            this.OnAfterEdnEdit();

            this.inBindingEdit = false;
        }

        public virtual void OnCreateInstance()
        {
            _status = it.dedagroup.GVC.Repository.Common.Configurations.ObjectStatus.ToView;
        }



		// Protected Methods (6) 

        protected virtual void OnAfterBeginEdit() { }

        protected virtual void OnAfterCancelEdit() { }

        protected virtual void OnAfterEdnEdit() { }

        protected virtual void OnBeforeBeginEdit() { }

        protected virtual void OnBeforeCancelEdit() { }

        protected virtual void OnBeforeEndEdit() { }



		// Private Methods (8) 

        private void Cleanup()
        {
            if (this.state == null) return;

            this.state.Clear();
            this.state = null;
        }

        private void CommitChanges()
        {
            System.Type currentType = this.GetType();

            do
            {
                foreach (System.Reflection.FieldInfo field in this.ReflectFields(currentType))
                {
                    System.ComponentModel.IEditableObject value = this.state[this.CreateUniqueKey(field)] as System.ComponentModel.IEditableObject;

                    if (value != null) value.EndEdit();
                }

                currentType = currentType.BaseType;
            } while (currentType != typeof(FDTBase));

            this.Cleanup();
        }

        private void CopyField(System.Reflection.FieldInfo field)
        {
            if (System.Attribute.IsDefined(field, typeof(NoRollbackSupportAttribute))) return;

            System.Object fieldValue = field.GetValue(this);

            if (fieldValue is System.ComponentModel.IEditableObject) ((System.ComponentModel.IEditableObject)fieldValue).BeginEdit();

            this.state.Add(this.CreateUniqueKey(field), fieldValue);
        }

        private void CopyState()
        {
            System.Type inspectedType = this.GetType();
            this.state = new System.Collections.Hashtable();

            do
            {

                foreach (System.Reflection.FieldInfo field in this.ReflectFields(inspectedType))
                {
                    if (field.DeclaringType == inspectedType)
                    {
                        this.CopyField(field);
                    }
                }

                inspectedType = inspectedType.BaseType;
            } while (inspectedType != typeof(FDTBase));
        }

        private System.String CreateUniqueKey(System.Reflection.FieldInfo field)
        {
            return field.DeclaringType.FullName + "." + field.Name;
        }

        private System.Reflection.FieldInfo[] ReflectFields(System.Type type)
        {
            return type.GetFields(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        }

        private void RollbackChanges()
        {
            System.Type inspectedType = this.GetType();

            do
            {
                foreach (System.Reflection.FieldInfo field in this.ReflectFields(inspectedType))
                {
                    if (field.DeclaringType == inspectedType)
                    {
                        this.SetField(field);
                    }
                }

                inspectedType = inspectedType.BaseType;
            } while (inspectedType != typeof(FDTBase));

            this.Cleanup();
        }

        private void SetField(System.Reflection.FieldInfo field)
        {
            System.Object value = this.state[this.CreateUniqueKey(field)];

            if (value is System.ComponentModel.IEditableObject) ((System.ComponentModel.IEditableObject)value).CancelEdit();

            field.SetValue(this, value);
        }


		#endregion Methods 

    }

    [System.AttributeUsage(System.AttributeTargets.Field)]
    [System.Serializable()]
    public class NoRollbackSupportAttribute : System.Attribute {
}
}
