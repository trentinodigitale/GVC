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

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Budget
{
    public partial class BilancioEdit : UserControlDialog
    {
        public BilancioEdit()
        {
            InitializeComponent();
        }

        public void SetBindableData(BilancioFDT item)
        {
            this.bindingSourceTipoBilancio.DataSource =
                GVCSystemEngine.GetDizionarioByType(it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.TIPI_BILANCIO);
            this.bindingSourceBaseRequisitiPrevalenza.DataSource =
               GVCSystemEngine.GetDizionarioByType(it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.REQUISITI_PREVALENZA);
            this.bindingSourceTipoVerificaBilancio.DataSource =
               GVCSystemEngine.GetDizionarioByType(it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.TIPI_VERIFICA_BILANCIO);

            this.bindingSourceBaseBilancio.DataSource = item;

            DropDownFilter(gridViewTipoBilancio, colAttivo, true);
        }

        private void ManageFields()
        {

        }

        private void gridLookUpEditTipoBilancio_EditValueChanged(object sender, EventArgs e)
        {
            if (!this.ReadOnlyControls)
            {
                ImponibilePatrimonio.Enabled = true;
                DataDepositoBilancioRI.Enabled = true;
                LookUpRequisitiPrevalenzaSoci.Enabled = true;
                ImponibileAlTrePercento.Enabled = true;

                int idTipo = -1;
                if (gridLookUpEditTipoBilancio.EditValue != null)
                {
                    if (Int32.TryParse(gridLookUpEditTipoBilancio.EditValue.ToString(), out idTipo))
                    {
                        switch (idTipo)
                        {
                            case TipiBilancio.ESERCIZIO:

                                ImponibilePatrimonio.Enabled = false;

                                break;
                            case TipiBilancio.STRAORDINARIO:

                                DataDepositoBilancioRI.Enabled = false;
                                ImponibilePatrimonio.Enabled = false;
                                LookUpRequisitiPrevalenzaSoci.Enabled = false;

                                break;
                            case TipiBilancio.FINALE:

                                ImponibileAlTrePercento.Enabled = false;
                                LookUpRequisitiPrevalenzaSoci.Enabled = false;

                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }
    }
}
