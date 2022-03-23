using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace it.dedagroup.GVC.Repository.Common.FDT
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.FDTBase))]
    [Serializable]
    public partial class LockFDT : FDTBase
    {
        #region Private Properties (21)

        private int _idLock;

        private int _idEntity;

        private int _idEntityType;

        private int _status;

        #endregion Private Properties

        #region Public Properties (21)

        [Bindable(true)]
        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }

        [Bindable(true)]
        public int IdEntityType
        {
            get { return _idEntityType; }
            set { _idEntityType = value; }
        }

        [Bindable(true)]
        public int IdEntity
        {
            get { return _idEntity; }
            set { _idEntity = value; }
        }

        [Bindable(true)]
        public int IdLock
        {
            get { return _idLock; }
            set { _idLock = value; }
        }

        #endregion Public Properties

    }
}
