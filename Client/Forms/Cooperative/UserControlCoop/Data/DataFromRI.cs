using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Client.Forms.Common;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.Configurations;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Data
{
    public partial class DataFromRI : UserControlBase
    {
        private CooperativaFDT itemLocal = null;
        private Boolean initialization = true;

        public DataFromRI()
        {
            InitializeComponent();

            if (dateEditDuration != null)
                dateEditDuration.Leave +=new EventHandler(dateEditDuration_Leave);
           if (lookUpEditDuration != null)
               lookUpEditDuration.Leave += new EventHandler(lookUpEditDuration_Leave);
            if (gridLookUpEditTipoCostituzione != null)
                gridLookUpEditTipoCostituzione.Leave += new EventHandler(gridLookUpEditTipoCostituzione_Leave);
        }

        void gridLookUpEditTipoCostituzione_Leave(object sender, EventArgs e)
        {
            if (gridLookUpEditCadenza != null)
                gridLookUpEditCadenza.Focus();
        }

        void lookUpEditDuration_Leave(object sender, EventArgs e)
        {
            if (textEdit11 != null)
                textEdit11.Focus();
        }

        void dateEditDuration_Leave(object sender, EventArgs e)
        {
            if (textEdit11 != null)
                textEdit11.Focus();
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

                if (!value)
                {
                    this.dateEditCostituzione.Properties.ReadOnly = true;
                    this.DataRegistroImprese.Properties.ReadOnly = true;
                }

                Filter();
            }
        }

        public void SetBindableData(CooperativaFDT item, DizionarioFDT[] listaCadenze)
        {
            itemLocal = item;

            this.bindingSourceBaseAdministrativeForm.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.FORME_AMMINISTRATIVE);
            this.bindingSourceBaseConstitution.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_COSTITUZIONE);
            this.bindingSourceBaseRevisionCadence.DataSource = listaCadenze;
            this.bindingSourceBaseDurationTypes.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_DURATA);

            this.bindingSourceBaseCooperative.DataSource = itemLocal;
            this.bindingSourceBaseCooperative.ResetBindings(false);
            if (itemLocal != null)
            {
                this.registroCooperativaFDTBindingSource.DataSource = itemLocal.RegistroCooperativa;
                if (itemLocal.RegistroCooperativa != null)
                    if (itemLocal.RegistroCooperativa.Cancellazione != null)
                        this.bindingSourceBaseCancellazione.DataSource = itemLocal.RegistroCooperativa.Cancellazione;
            }

            this.registroCooperativaFDTBindingSource.ResetBindings(false);
            if (itemLocal != null && itemLocal.RegistroCooperativa != null)
            {
                AggiornaDurata();
            }


            Filter();
        }

        private void Filter()
        {
            if (this.ReadOnlyControls)
            {
                DropDownFilter(gridViewTipoCostituzione, colAttivo, false);
                DropDownFilter(gridViewCadenza, colAttivo2, false);
            }
            else
            {
                DropDownFilter(gridViewTipoCostituzione, colAttivo, true);
                DropDownFilter(gridViewCadenza, colAttivo2, true);
            }
        }


        private void checkEditDate_CheckedChanged(object sender, EventArgs e)
        {
            if (!initialization)
            {
                registroCooperativaFDTBindingSource.EndEdit();

                if (itemLocal != null && itemLocal.RegistroCooperativa != null)
                {
                    itemLocal.RegistroCooperativa.BeginEdit();

                    if (checkEditDate.Checked)
                    {
                        this.dateEditDuration.Visible = true;
                        this.lookUpEditDuration.Visible = false;

                        if (!itemLocal.RegistroCooperativa.Durata.HasValue)
                            itemLocal.RegistroCooperativa.Durata = DateTime.Now;
                        itemLocal.RegistroCooperativa.DurataIllimitata = -1;
                    }
                    else
                    {
                        this.dateEditDuration.Visible = false;
                        this.lookUpEditDuration.Visible = true;

                        itemLocal.RegistroCooperativa.Durata = null;
                        if (itemLocal.RegistroCooperativa.DurataIllimitata < 0)
                            itemLocal.RegistroCooperativa.DurataIllimitata = 0;
                    }

                    itemLocal.RegistroCooperativa.EndEdit();

                    registroCooperativaFDTBindingSource.ResetBindings(false);
                }
            }
        }

        private void lookUpEditDuration_EditValueChanged(object sender, EventArgs e)
        {
            this.registroCooperativaFDTBindingSource.EndEdit();

            if (lookUpEditDuration.EditValue != null)
            {
                int v = -1;
                if (Int32.TryParse(lookUpEditDuration.EditValue.ToString(), out v))
                {
                    if (itemLocal != null && itemLocal.RegistroCooperativa != null)
                    {
                        itemLocal.RegistroCooperativa.DurataIllimitata = v;
                    }
                }
            }
        }

        private void dateEditDuration_EditValueChanged(object sender, EventArgs e)
        {
            this.registroCooperativaFDTBindingSource.EndEdit();
        }

        private void DataFromRI_Load(object sender, EventArgs e)
        {
            initialization = false;
        }

        private void AggiornaDurata()
        {
            if (itemLocal.RegistroCooperativa.Durata.HasValue)
            {
                this.dateEditDuration.Visible = true;
                this.lookUpEditDuration.Visible = false;

                checkEditDate.Checked = true;
            }
            else
            {
                this.dateEditDuration.Visible = false;
                this.lookUpEditDuration.Visible = true;

                checkEditDate.Checked = false;
            }
        }

        public void ResetBindingSource(Boolean aggiornaDurata)
        {
            this.bindingSourceBaseCooperative.ResetBindings(false);

            if (aggiornaDurata)
            {
                AggiornaDurata();
            }
        }

        public void EndEditBindingSource()
        {
            this.bindingSourceBaseCooperative.EndEdit();
            this.registroCooperativaFDTBindingSource.EndEdit();
        }
    }
}
