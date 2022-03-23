using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Header
{
    public partial class Header : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {

        Color cOriginal = Color.Transparent;
        CooperativaFDT itemLocal = null;

        public Header()
        {
            InitializeComponent();

            cOriginal = this.ScrollableContent.BackColor;
        }

        private void SetImages()
        {
            if (itemLocal != null &&
               itemLocal.RegistroCooperativa != null)
            {
                if (itemLocal.RegistroCooperativa.AggiornaNrScioglimento)
                {
                    this.btnNumeroScioglimento.Image = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
                }
                else
                {
                    this.btnNumeroScioglimento.Image = GVCResourcesUtility.Get_16x16(GVCResources.Check_24x24);
                }
            }
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

                CooperativeCode.Properties.ReadOnly = true;
                textEdit1.Properties.ReadOnly = true;
                textEdit3.Properties.ReadOnly = true;
                lookUpEditTipoIscrizione.Properties.ReadOnly = true;

                btnNumeroScioglimento.Enabled = !value;

                Filter();

                textEdit2_EditValueChanged(null, new EventArgs());
            }
        }

        private void Filter()
        {
            if (this.ReadOnlyControls)
            {
                DropDownFilter(gridViewStatoIscrizione, colAttivo, false);
                DropDownFilter(gridViewFormaGiuridica, colAttivo2, false);
            }
            else
            {
                DropDownFilter(gridViewStatoIscrizione, colAttivo, true);
                DropDownFilter(gridViewFormaGiuridica, colAttivo2, true);
            }
        }

        public void SetBindableData(CooperativaFDT item)
        {
            itemLocal = item;

            this.bindingSourceBaseJuridicalForm.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.FORME_GIURIDICHE);
            this.bindingSourceBaseStato.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.STATI_ISCRIZIONE);
            this.bindingSourceBaseIscrizioni.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_ISCRIZIONE_HEADER);

            this.bindingSourceBaseCooperativa.DataSource = item;
            
            if (item != null)
                this.registroCooperativaFDTBindingSource.DataSource = item.RegistroCooperativa;

            if (item != null && item.RegistroCooperativa != null &&
                item.RegistroCooperativa.Cancellazione != null && item.RegistroCooperativa.Cancellazione.DataRicevimentoDomanda != DateTime.MinValue)
            {
                SetHeaderColor(true);
            }

            Filter();

            SetImages();

            if (item != null &&
                item.RegistroCooperativa != null)
            {
                EnableButton(item.RegistroCooperativa.AggiornaNrScioglimento);
            }
        }

        private void EnableButton(Boolean toEnable)
        {
            if (btnNumeroScioglimento == null)
                return;

            if (toEnable)
            {
                if (!this.ReadOnlyControls)
                    this.btnNumeroScioglimento.Enabled = toEnable;
            }
            else
            {
                this.btnNumeroScioglimento.Enabled = toEnable;
            }
        }

        public void EndEditBindingSource()
        {
            this.bindingSourceBaseCooperativa.EndEdit();
            this.registroCooperativaFDTBindingSource.EndEdit();
        }

        public void ResetBindingSource()
        {
            this.bindingSourceBaseCooperativa.ResetBindings(false);
            this.registroCooperativaFDTBindingSource.ResetBindings(false);
        }

        internal void SetHeaderColor(Boolean value)
        {
            if (value)
            {
                //this.ScrollableContent.BackColor = Color.Coral;
                this.ScrollableContent.BackColor = Color.DarkOrange;
                //this.ScrollableContent.BackColor = Color.Goldenrod;
            }
            else
            {
                this.ScrollableContent.BackColor = cOriginal;
            }
        }

        internal void FocusDefault()
        {
            this.CooperativeCode.SelectAll();
            this.CooperativeCode.Focus();
        }

        public void CleanFields()
        {
            this.textEdit1.Text = "";
            this.textEdit2.Text = "";
            this.textEdit3.Text = "";
        }

        private void gridLookUpEditStatoIscrizione_EditValueChanged(object sender, EventArgs e)
        {
            this.registroCooperativaFDTBindingSource.EndEdit();
            gridViewStatoIscrizione.PostEditor();
        }

        private void gridLookUpEditStatoIscrizione_Leave(object sender, EventArgs e)
        {
            this.registroCooperativaFDTBindingSource.EndEdit();
            gridViewStatoIscrizione.PostEditor();
        }

        public string[] HasErrorsCritical()
        {
            List<string> toReturn = new List<string>();

            Boolean tmp = false;
            tmp = tmp || ErrorProviderCooperativa.HasErrorsOfType(DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical);
            tmp = tmp || ErrorProviderRegistro.HasErrorsOfType(DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical);

            if (tmp)
            {
                toReturn.Add("Intestazione");
            }

            return toReturn.ToArray();
        }

        private void btnNumeroScioglimento_Click(object sender, EventArgs e)
        {
            if (itemLocal != null &&
                itemLocal.RegistroCooperativa != null)
            {
                if (itemLocal.RegistroCooperativa.AggiornaNrScioglimento)
                {
                    itemLocal.RegistroCooperativa.AggiornaNrScioglimento = false;
                    this.btnNumeroScioglimento.Image = GVCResourcesUtility.Get_16x16(GVCResources.Check_24x24);
                }
                else
                {
                    itemLocal.RegistroCooperativa.AggiornaNrScioglimento = true;
                    this.btnNumeroScioglimento.Image = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
                }
            }
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {
            this.ErrorProviderRegistro.SetError(this.textEdit2, "", DevExpress.XtraEditors.DXErrorProvider.ErrorType.None);
            if (textEdit2 != null)
            {
                if (textEdit2.EditValue == null)
                {
                    if (itemLocal != null &&
                        itemLocal.RegistroCooperativa != null)
                    {
                        itemLocal.RegistroCooperativa.NumeroScioglimento = null;
                    }
                    EnableButton(true);
                }
                else
                {
                    string s = textEdit2.EditValue.ToString();
                    if (String.IsNullOrEmpty(s))
                    {
                        if (itemLocal != null &&
                         itemLocal.RegistroCooperativa != null)
                        {
                            itemLocal.RegistroCooperativa.NumeroScioglimento = null;
                        }
                        EnableButton(true);
                    }
                    else
                    {
                        int num = -1;
                        if (Int32.TryParse(s, out num))
                        {
                            EnableButton(false);
                        }
                        else
                        {
                            this.ErrorProviderRegistro.SetError(this.textEdit2, "Valore non corretto", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical);
                        }
                    }
                }
            }
        }
    }
}
