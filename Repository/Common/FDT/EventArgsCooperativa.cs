using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.FDT
{
    /// <summary>
    /// Base class for FDTs
    /// </summary>
    [Serializable]
    public class EventArgsCooperativa : System.EventArgs
    {
        private String codiceFiscale;

        public String CodiceFiscale
        {
            get { return codiceFiscale; }
            set { codiceFiscale = value; }
        }
	
    }
}
