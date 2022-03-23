using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Data
{
    public partial class Data : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        private CooperativaFDT itemLocal = null;
        public event EventHandler Indirizzi;

        public Data()
        {
            InitializeComponent();

            if (addressDetail1 != null)
            {
                addressDetail1.Indirizzi += new EventHandler(addressDetail1_Indirizzi);
            }

            SetImages();
        }

        private void SetImages()
        {

        }

        void addressDetail1_Indirizzi(object sender, EventArgs e)
        {
            EventCaller();
        }

        public void SetBindableData(CooperativaFDT item, DizionarioFDT[] listaCadenze)
        {
            itemLocal = item;

            addressDetail1.SetBindableData(item);
            dataGenerics1.SetBindableData(item);
            dataFromRI1.SetBindableData(item, listaCadenze);
            activities1.SetBindableData(item);
          
        }

        public void EndEditBindingSource()
        {
            if (dataFromRI1 != null)
            {
                dataFromRI1.EndEditBindingSource();
            }
            if (dataGenerics1 != null)
            {
                dataGenerics1.EndEditBindingSource();
            }
        }

        public void ResetBindingSource()
        {
            if (dataFromRI1 != null)
            {
                this.dataFromRI1.ResetBindingSource(true);
            }
        }

        private void EventCaller()
        {
            EventHandler eTemp = this.Indirizzi;
            if (eTemp != null)
            {
                eTemp(null, new EventArgs());
            }
        }

        public string[] HasErrorsCritical()
        {
            List<string> toReturn = new List<string>();

            if (addressDetail1 != null)
            {
                toReturn.AddRange(addressDetail1.HasErrorsCritical());
            }

            return toReturn.ToArray();
        }

        

    }
}
