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
    public partial class Iscrizione : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {

        public event EventHandler ModifyIscrizione;
        public event EventHandler DeleteIscrizione;
        public event EventHandler NuovoProcedimento;


        public override bool ReadOnlyControls
        {
            get
            {
                return base.ReadOnlyControls;
            }
            set
            {
                //base.ReadOnlyControls = value;

                if (simpleButtonNewProcess1 != null)
                    simpleButtonNewProcess1.Enabled = !value;

                if (btnModify != null)
                    btnModify.Enabled = !value;
                if (btnDelete != null)
                    btnDelete.Enabled = !value;
            }
        }

        public Iscrizione()
        {
            InitializeComponent();
        }


        internal void HideButtons()
        {
            this.panelControl1.Visible = false;
        }
        internal void ShowButtons()
        {
            this.panelControl1.Visible = true;
        }

        void simpleButtonNewProcess1_Click(object sender, EventArgs e)
        {
            //OpenNewProcess();
            EventHandler temp = NuovoProcedimento;
            if (temp != null)
                NuovoProcedimento(null, new EventArgs());
        }


        public void SetBindableData(CooperativaFDT item)
        {
            this.bindingSourceCategoriaSociale.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.CATEGORIA_SOCIALE);
            this.bindingSourceSottoCategoriaSociale.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.SOTTO_CATEGORIE);
            this.bindingSourceCategoria.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.CATEGORIE);


            this.bindingSourceSezione.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.SEZIONE);
            //this.bindingSourceSottoSezione.DataSource = StaticClassTemp.GetListSubSections(1);

            //this.lookUpEditSubSection.EditValue = 1;

            this.bindingSourceBaseCooperativa.DataSource = item;
        }


        private void lookUpEditSection_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEditSezione.EditValue != null)
            {
                int id = -1;
                if (Int32.TryParse(lookUpEditSezione.EditValue.ToString(), out id))
                {
                    this.bindingSourceSottoSezione.DataSource = StaticClassTemp.GetListSubSections(id);
                    this.lookUpEditSubSection.EditValue = StaticClassTemp.GetListSubSections(id)[0].IdElemento;
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
    }
}
