using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using it.dedagroup.GVC.Repository.Common.Configurations;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.BaseCariche
{
    public partial class BaseCaricheDetail : it.dedagroup.GVC.Client.Forms.Common.UserControlSplitContainer
    {
        #region Constructors (1)
        
        public BaseCaricheDetail()
        {
            InitializeComponent();
        }

        #endregion Constructors (1)

        #region Public Methods (1)

        public void SetBindableData(CooperativaFDT item, DatiFDT d)
        {
            comunicazioneBaseSocDetail1.SetBindableData(item, d);
            
            comunicazioneDetail1.SetBindableData(item);
        }

        #endregion Public Methods

        #region Private Methods (1)

        private void PositionAndBase_SizeChanged(object sender, EventArgs e)
        {
            Splitter.SplitPosition = this.Size.Width / 2;
        }

        #endregion Private Methods

        public string[] HasErrorsCritical()
        {
            List<string> toReturn = new List<string>();

            if (comunicazioneDetail1 != null)
            {
                toReturn.AddRange(comunicazioneDetail1.HasErrors());
            }

            return toReturn.ToArray();
        }
    }
}
