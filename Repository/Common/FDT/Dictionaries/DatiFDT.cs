using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.FDT.Dictionaries
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public partial class DatiFDT : FDTBase
    {
        #region Instance Variables (8)

        private int _idItem;
        private double _valQuotaMin;
        private double _valQuotaMax;
        private double _valAzioneMin;
        private double _valAzioneMax;
        private double _percentualeCNP;
        private double _percentualeIVA;
        private double _percentualePAT;
        private double _displayValMin;
        private double _displayValMax;

        #endregion Instance Variables

        #region Public Properties (8)

        /// <summary>
        /// Gets or sets the id item.
        /// </summary>
        /// <value>The id item.</value>
        [Bindable(true)]
        public int IdItem
        {
            get { return _idItem; }
            set { _idItem = value; }
        }

        /// <summary>
        /// Gets or sets the val azione max.
        /// </summary>
        /// <value>The val azione max.</value>
        [Bindable(true)]
        public double ValAzioneMax
        {
            get { return _valAzioneMax; }
            set { _valAzioneMax = value; }
        }

        /// <summary>
        /// Gets or sets the val azione min.
        /// </summary>
        /// <value>The val azione min.</value>
        [Bindable(true)]
        public double ValAzioneMin
        {
            get { return _valAzioneMin; }
            set { _valAzioneMin = value; }
        }

        /// <summary>
        /// Gets or sets the val quota max.
        /// </summary>
        /// <value>The val quota max.</value>
        [Bindable(true)]
        public double ValQuotaMax
        {
            get { return _valQuotaMax; }
            set { _valQuotaMax = value; }
        }

        /// <summary>
        /// Gets or sets the val quota min.
        /// </summary>
        /// <value>The val quota min.</value>
        [Bindable(true)]
        public double ValQuotaMin
        {
            get { return _valQuotaMin; }
            set { _valQuotaMin = value; }
        }

        /// <summary>
        /// Gets or sets the percentuale CNP.
        /// </summary>
        /// <value>The percentuale CNP.</value>
        [Bindable(true)]
        public double PercentualeCNP
        {
            get { return _percentualeCNP; }
            set { _percentualeCNP = value; }
        }

        /// <summary>
        /// Gets or sets the percentuale IVA.
        /// </summary>
        /// <value>The percentuale IVA.</value>
        [Bindable(true)]
        public double PercentualeIVA
        {
            get { return _percentualeIVA; }
            set { _percentualeIVA = value; }
        }

        /// <summary>
        /// Gets or sets the percentuale PAT.
        /// </summary>
        /// <value>The percentuale PAT.</value>
        [Bindable(true)]
        public double PercentualePAT
        {
            get { return _percentualePAT; }
            set { _percentualePAT = value; }
        }

        /// <summary>
        /// Gets or sets the display val min.
        /// </summary>
        /// <value>The display val min.</value>
        [Bindable(true)]
        public double DisplayValMin
        {
            get { return _displayValMin; }
            set { _displayValMin = value; }
        }

        /// <summary>
        /// Gets or sets the display val max.
        /// </summary>
        /// <value>The display val max.</value>
        [Bindable(true)]
        public double DisplayValMax
        {
            get { return _displayValMax; }
            set { _displayValMax = value; }
        }

        #endregion Public Properties
    }
}
