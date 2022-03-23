﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Client.Forms.Common;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.DatiStorici
{
    public partial class DatiStoriciRegistro : UserControlBase
    {

		#region Constructors (1) 

        public DatiStoriciRegistro()
        {
            InitializeComponent();

            if (!DesignMode)
            {
                EnableControlAutoSize(new object[] { this }, gridControlStorico, 100);

                SetImages();
            }
        }

		#endregion Constructors 

		#region Public Methods (3) 

     

        public void SetBindableData(CooperativaFDT item)
        {
            if (item != null && item.RegistroCooperativa != null)
            {
                this.bindingSourceStorico.DataSource = item.RegistroCooperativa.DatiStoriciRegistro;
            }
        }

		#endregion Public Methods 

		#region Private Methods (2) 

       

        private void SetImages()
        {
            //this.barButtonItemAddDocumentation.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Paperclip_24x24);
            //this.barButtonItemDelete.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
        }

		#endregion Private Methods 

    }
}
