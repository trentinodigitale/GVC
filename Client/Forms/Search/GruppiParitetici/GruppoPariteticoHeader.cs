using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;

namespace it.dedagroup.GVC.Client.Forms.Search.GruppiParitetici
{
    public partial class GruppoPariteticoHeader : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        private GruppoPariteticoFDT itemLocal;
        
        public GruppoPariteticoHeader()
        {
            InitializeComponent();
        }

        public void SetBindableData(GruppoPariteticoFDT item)
        {
            itemLocal = item;            
            this.bindingSourceGruppoParitetico.DataSource = itemLocal;              
        }

        public void CancelEdit()
        {
            this.bindingSourceGruppoParitetico.CancelEdit();
        }

        public void EndEdit()
        {
            this.bindingSourceGruppoParitetico.EndEdit();
        }
                
        public GruppoPariteticoFDT GetItem()
        {
            return itemLocal;
        }

        public void ChangeFocus()
        {
            Control activControl = this.ActiveControl;

            if (activControl != null)
            {
                this.memoEditNote.Focus();

                activControl.Focus();
            }
        }

      
    }
}
