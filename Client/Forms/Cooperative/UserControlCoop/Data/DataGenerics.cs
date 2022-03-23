using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Data
{
    public partial class DataGenerics : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        public DataGenerics()
        {
            InitializeComponent();
        }

        public void SetBindableData(CooperativaFDT item)
        {
            this.bindingSourceBaseCooperativa.DataSource = item;

            if (item != null)
            {
                registroCooperativaFDTBindingSource.DataSource = item.RegistroCooperativa;

                if (item.GruppiPariteticiAppartenenza != null &&
                    item.GruppiPariteticiAppartenenza.Length > 0)
                {
                    StringBuilder elencogruppi = new StringBuilder();
                    foreach(GruppoPariteticoFDT itemG in item.GruppiPariteticiAppartenenza)
                    {
                        elencogruppi.Append(itemG.Descrizione);
                        //elencogruppi.AppendLine();
                    }

                    memoEditGruppi.Text = elencogruppi.ToString();
                    groupBoxGruppiPar.Visible = true;
                }
                else
                {
                    groupBoxGruppiPar.Visible = false;
                }
            }
        }

        public void EndEditBindingSource()
        {
            this.bindingSourceBaseCooperativa.EndEdit();
            this.registroCooperativaFDTBindingSource.EndEdit();
        }

        public override bool ReadOnlyControls
        {
            get
            {
                return base.ReadOnlyControls;
            }
            set
            {
                base.ReadOnlyControls = value;
                memoEditGruppi.Properties.ReadOnly = true;
            }
        }
    }
}
