using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.Configurations;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Data
{
    public partial class Activities : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {

        private CooperativaFDT itemLocal = null;

        public Activities()
        {
            InitializeComponent();
        }

        public void SetBindableData(CooperativaFDT item)
        {

            
            this.bindingSourceActivityTypes.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.ATTIVITA);

            itemLocal = item;
            if (itemLocal != null && itemLocal.RegistroCooperativa != null)
            {
                this.bindingSourceBaseActivities.DataSource = itemLocal.RegistroCooperativa.Attivita;
                this.bindingSourceBaseActivitiesParix.DataSource = item.RegistroCooperativa.AttivitaParix;
            }

        }

        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            AttivitaFDT item = new AttivitaFDT();
            item.Status = ObjectStatus.ToInsert;

            if (OpenForEdit(item) == DialogResult.OK)
            {
                if (itemLocal != null && itemLocal.RegistroCooperativa != null)
                {
                    if (itemLocal.RegistroCooperativa.Attivita == null)
                        itemLocal.RegistroCooperativa.Attivita = new AttivitaFDT[] { };

                    List<AttivitaFDT> lTemp = new List<AttivitaFDT>(itemLocal.RegistroCooperativa.Attivita);
                    lTemp.Add(item);
                    itemLocal.RegistroCooperativa.Attivita = lTemp.ToArray();

                    this.bindingSourceBaseActivities.DataSource = itemLocal.RegistroCooperativa.Attivita;
                }
            }
        }

        private void btnRemoveActivity_Click(object sender, EventArgs e)
        {
            AttivitaFDT item = GetCurrentItem();
            if (item != null)
            {
                Boolean reallyRemove = false;
                if (item.IdAttivita <= 0)
                {
                    reallyRemove = true;
                }

                if (ShowConfirmMessage("Conferma operazione", "Confermi la rimozione dell'elemento selezionato?", string.Empty) == DialogResult.Yes)
                {
                    RemoveAttivita(item, reallyRemove);
                }
            }
        }

        private void RemoveAttivita(AttivitaFDT item, bool reallyRemove)
        {
            if (itemLocal != null && itemLocal.RegistroCooperativa != null &&
                itemLocal.RegistroCooperativa.Attivita != null)
            {
                List<AttivitaFDT> lTemp = new List<AttivitaFDT>();

                foreach (AttivitaFDT counter in itemLocal.RegistroCooperativa.Attivita)
                {
                    if (counter.IdTipoAttivita == item.IdTipoAttivita)
                    {
                        if (!reallyRemove)
                        {
                            counter.Status = ObjectStatus.ToCancel;
                            lTemp.Add(counter);
                        }
                    }
                    else
                    {
                        lTemp.Add(counter);
                    }
                }

                itemLocal.RegistroCooperativa.Attivita = lTemp.ToArray();
                this.bindingSourceBaseActivities.DataSource = itemLocal.RegistroCooperativa.Attivita;
            }
        }

        private AttivitaFDT GetCurrentItem()
        {
            AttivitaFDT toReturn = null;
            if (this.bindingSourceBaseActivities.Current != null)
                toReturn = this.bindingSourceBaseActivities.Current as AttivitaFDT;
            return toReturn;
        }

        private DialogResult OpenForEdit(AttivitaFDT item)
        {
            RicercaAttivita ra = CreatePageDialog<RicercaAttivita>();
            if (ra != null)
            {
                ra.SetBindableData();
                ra.SetFormTitle("Aggiungi attività");

                DialogResult dr = DialogResult.OK;
                while (dr == DialogResult.OK)
                {
                    dr = ra.BaseForm.ShowDialog(this, false);

                    DizionarioFDT it = ra.GetSelectedItem();
                    if (it != null)
                        item.IdTipoAttivita = it.IdElemento;

                    if (dr == DialogResult.OK)
                        break;
                }
                return dr;
            }
            else
            {
                return DialogResult.Cancel;
            }
        }

        private void bindingSourceBaseActivities_CurrentChanged(object sender, EventArgs e)
        {
            HandleCurrentItemChanged();
        }


        private void HandleCurrentItemChanged()
        {
            SetVisibilityBarButton();
        }

        private void SetVisibilityBarButton()
        {
            AttivitaFDT item = GetCurrentItem();
            SetVisibilityBarButton(item);
        }

        private void SetVisibilityBarButton(AttivitaFDT item)
        {
            if (!this.ReadOnlyControls)
            {
                btnRemoveActivity.Enabled = true;

                if (item != null)
                {
                    if (item.Status >= ObjectStatus.ToHide)
                    {
                        btnRemoveActivity.Enabled = false;
                    }
                }
            }
        }

    }
}
