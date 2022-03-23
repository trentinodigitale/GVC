using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using OeF.Configurations;
using it.dedagroup.GVC.Repository.Common.Configurations;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Registro
{
    public partial class IscrizioneComeCambio : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {

        public event EventHandler ModifyIscrizione;
        public event EventHandler DeleteIscrizione;
        public event EventHandler NuovoProcedimento;
        public Boolean activeEvents = false;

        public IscrizioneComeCambio()
        {
            InitializeComponent();

            if (gridLookUpEditSottocategoriaSociale != null)
                this.gridLookUpEditSottocategoriaSociale.Properties.ReadOnly = true;

            this.VecchiaPosizione.Properties.ReadOnly = true;
        }


        internal void HideButtons()
        {
            this.panelControl1.Visible = false;

            DropDownFilter(gridViewCategoria, colAttivo, true);
            DropDownFilter(gridViewSottocategoria, colAttivo2, true);
        }
        internal void ShowButtons()
        {
            this.panelControl1.Visible = true;
        }

        internal void ToggleButtons(Boolean enabled)
        {
            this.simpleButtonNewProcess1.Enabled = 
            this.btnModify.Enabled =
                this.btnDelete.Enabled = enabled;
        }

        void simpleButtonNewProcess1_Click(object sender, EventArgs e)
        {
            //OpenNewProcess();
            EventHandler temp = NuovoProcedimento;
            if (temp != null)
                NuovoProcedimento(null, new EventArgs());
        }


        public void SetBindableData(CambioPosizioneFDT item)
        {
            this.bindingSourceCategoriaSociale.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.CATEGORIA_SOCIALE);
            this.bindingSourceSottoCategoriaSociale.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.SOTTO_CATEGORIE);
            this.bindingSourceCategoria.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.CATEGORIE);


            this.bindingSourceSezione.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.SEZIONE);
            //this.bindingSourceSottoSezione.DataSource = StaticClassTemp.GetListSubSections(1);

            //this.lookUpEditSubSection.EditValue = 1;

            if (item == null)
            {
                item = new CambioPosizioneFDT();
                item.IdSottoCategoria = -1;
                item.CategoriaSociale = -1;
            }

            
            this.bindingSourceBaseCambioPosizione.DataSource = item; 
        }


        private void lookUpEditSection_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEditSezione.EditValue != null)
            {
                int id = -1;
                if (Int32.TryParse(lookUpEditSezione.EditValue.ToString(), out id))
                {
                    DizionarioFDT[] listSubSec = GVCSystemEngine.GetDizionarioByType(
                                       String.Concat("sottosezione_", id));

                    this.bindingSourceSottoSezione.DataSource = listSubSec;
                    if (listSubSec != null && listSubSec.Length > 0)
                        this.lookUpEditSubSection.EditValue = listSubSec[0].IdElemento;
                    else
                    {
                        CambioPosizioneFDT itemL = this.bindingSourceBaseCambioPosizione.DataSource as CambioPosizioneFDT;
                        if (itemL != null)
                        {
                            itemL.SottoSezione = -1;
                        }
                        else
                        {
                            this.lookUpEditSubSection.EditValue = -1;
                        }
                    }

                    //this.bindingSourceSottoSezione.DataSource = StaticClassTemp.GetListSubSections(id);
                    //this.lookUpEditSubSection.EditValue = StaticClassTemp.GetListSubSections(id)[0].IdElemento;
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            EventHandler temp = ModifyIscrizione;
            if (temp != null)
                ModifyIscrizione(this, new EventArgs());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EventHandler temp = DeleteIscrizione;
            if (temp != null)
                DeleteIscrizione(this, new EventArgs());
        }

        private void lookUpEditCategoriaSociale_EditValueChanged(object sender, EventArgs e)
        {
            if (activeEvents)
            {
                int catSoc = -1;
                if (lookUpEditCategoriaSociale.EditValue != null)
                {
                    if (Int32.TryParse(lookUpEditCategoriaSociale.EditValue.ToString(), out catSoc))
                    {
                        if (catSoc == 1)
                        {
                            this.gridLookUpEditSottocategoriaSociale.Properties.ReadOnly = false;
                        }
                        else
                        {
                            this.gridLookUpEditSottocategoriaSociale.EditValue = -1;
                            if (this.bindingSourceBaseCambioPosizione.DataSource is CambioPosizioneFDT)
                                ((CambioPosizioneFDT)this.bindingSourceBaseCambioPosizione.DataSource).IdSottoCategoria = -1;

                            this.gridLookUpEditSottocategoriaSociale.Properties.ReadOnly = true;
                        }
                    }
                }
            }
        }
    }
}
