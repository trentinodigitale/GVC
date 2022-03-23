using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using it.dedagroup.GVC.Repository.Common.Services;
using it.dedagroup.GVC.Repository.Common.Configurations;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Sanzioni.SanzioniAmministrative
{
    public partial class SanzioneAmministrativaEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {
        SanzioneFDT sanzione = null;
        LeggiTrasgressioneFDT[] leggi = null;

        #region Constructors (1)
        
        public SanzioneAmministrativaEdit()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Private Methods (1)

        #endregion Private Methods

        #region Public Methods (3)

        public void BindingSourceEndInit()
        {
            this.bindingSourceBaseSanzione.EndEdit();
        }

        public void BindingSourceResetBindings()
        {
            this.bindingSourceBaseSanzione.ResetBindings(false);
        }

        public void SetBindableData(SanzioneFDT item, DizionarioFDT[] listaGiudici, DizionarioFDT[] listaNature, LeggiTrasgressioneFDT[] listaLeggi)
        {
            sanzione = item;
            this.bindingSourceBaseSanzione.DataSource = sanzione;

            this.bindingSourceBaseGiudici.DataSource = listaGiudici;
            this.bindingSourceBaseNatura.DataSource = listaNature;
            leggi = listaLeggi;
            this.bindingSourceBaseLeggi.DataSource = listaLeggi; //GVCSystemEngine.GetDizionarioByType(DictionaryTypes.LEGGI);

            DropDownFilter(gridViewNatura, colAttivo, true);
            DropDownFilter(gridView2, colAttivo, true);
            DropDownFilter(gridViewLeggi, colAttivo, true);
        }

        private void ManageFields()
        {

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

                this.memoEditNoteLegge.Properties.ReadOnly = true;
            }
        }

        #endregion Public Methods

        private void gridLookUpEditNatura_EditValueChanged(object sender, EventArgs e)
        {
            //sanzione.EndEdit();
            if (gridLookUpEditNatura.EditValue is int)
            {
                Int32 idNatura = Convert.ToInt32(gridLookUpEditNatura.EditValue);
                DropDownFilter(gridViewLeggi, colIdTipoTrasgressione, idNatura);

                gridLookUpEditLeggi.EditValue = null;
            }
        }

        public LeggiTrasgressioneFDT FindLeggeByID(int id)
        {
            LeggiTrasgressioneFDT returnValue = null;
            if (leggi.Length > 0)
            {
                foreach (LeggiTrasgressioneFDT item in leggi)
                {
                    if (item.IdElemento == id)
                    {
                        returnValue = item;
                        break;
                    }
                }
            }
            return returnValue;
        }

        private void gridLookUpEditLeggi_EditValueChanged(object sender, EventArgs e)
        {
            if (gridLookUpEditLeggi.EditValue is int)
            {
                LeggiTrasgressioneFDT tipoSelezionato = FindLeggeByID(Convert.ToInt32(this.gridLookUpEditLeggi.EditValue));

                this.bindingSourceBaseSanzione.EndEdit();

                sanzione.NoteLeggeTrasgredita = tipoSelezionato.Entita;

                this.bindingSourceBaseSanzione.ResetBindings(false);
            }
        }
    }
}
