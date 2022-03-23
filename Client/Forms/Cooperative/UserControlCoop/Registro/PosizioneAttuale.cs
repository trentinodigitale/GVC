using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using OeF.Configurations;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.Configurations;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Registro
{
    public partial class PosizioneAttuale : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        public override bool ReadOnlyControls
        {
            get
            {
                return base.ReadOnlyControls;
            }
            set
            {
                SetReadOnlyControls(this.Controls, true);
            }
        }
        public PosizioneAttuale()
        {
            InitializeComponent();
        }

        public void SetBindableData(CooperativaFDT item)
        {
            this.bindingSourceCategoriaSociale.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.CATEGORIA_SOCIALE);
            this.bindingSourceCategoria.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.CATEGORIE);
            this.bindingSourceSottoCategoriaSociale.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.SOTTO_CATEGORIE);
            this.bindingSourceSezione.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.SEZIONE);

            this.bindingSourceBaseCooperative.DataSource = item;

            CambioPosizioneFDT cambioItem = null;

            if (item != null)
            {
                this.registroCooperativaFDTBindingSource.DataSource = item.RegistroCooperativa;

                if (item.RegistroCooperativa != null)
                {
                    if (item.RegistroCooperativa.Cancellazione != null &&
                        item.RegistroCooperativa.Cancellazione.Status < ObjectStatus.ToHide)
                    {
                        // c'è una cancellazione.. quindi la pos attuale rimane vuota
                    }
                    else
                    {
                        cambioItem = item.RegistroCooperativa.PosizioneAttuale;
                    }
                }
            }

            if (cambioItem == null)
            {
                cambioItem = new CambioPosizioneFDT();
                cambioItem.IdSottoCategoria = -1;
                cambioItem.CategoriaSociale = -1;
            }

            this.bindingSourceBaseCambioPosizione.DataSource = cambioItem;
            this.bindingSourceBaseCambioPosizione.ResetBindings(false);
            

            
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
                }
            }
        }
    }
}
