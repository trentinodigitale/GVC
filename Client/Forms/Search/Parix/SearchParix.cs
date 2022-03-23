using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.Services;
using OeF.Forms.Controls;
using it.dedagroup.GVC.Client.Forms.Common;

namespace it.dedagroup.GVC.Client.Forms.Search.Parix
{
    public partial class SearchParix : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {
        private CooperativaFDT selectedItem;
        private Boolean searchByRea;

        public CooperativaFDT SelectedItem
        {
            get
            {
                return selectedItem;
            }
        }

        public SearchParix()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            String name = TxtBxDenominazione.Text;
            String cf = TxtBxCF.Text;
            String nrRea = TxtBxRea.Text;
            searchByRea = !nrRea.Equals("");


            bool includeCeased = checkEditIncludeCeased.Checked;

            
            Search(name, cf, nrRea, includeCeased);
            
        }

        private void Search(String name, String cf, String rea, bool includeCeased)
        {
            Boolean exception = false;
            CooperativaFDT[] results = GVCSystemEngine.InvokeService<ICooperatives, CooperativaFDT[]>(
                delegate { return GVCSystemEngine.Cooperatives.SearchCooperativaParix(name, cf, rea, includeCeased, out exception); },
                true);
            if (results == null)
            {
                if(exception)
                    ShowInformationMessage("Impossibile raggiungere il servizio", "Impossibile raggiungere il servizio \nVerificare lo stato della conessione");
                else
                    ShowInformationMessage("La ricerca da Parix non ha prodotto nessun risultato", "La ricerca da Parix non ha prodotto nessun risultato \nCambiare i parametri di ricerca e riprovare");
                return;
            }
            if (results.Length == 0)
            {
                ShowInformationMessage("Il numero dei risultati ottenuti è superiore al limite consentito dal sistema Parix", "Il numero dei risultati ottenuti è superiore al limite consentito dal sistema Parix. Si prega di rendere la ricerca più specifica e riprovare");
                return;
            }
            this.bindingSourceBase1.DataSource = results;
        }

        private void TxtBxDenominazione_EditValueChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = !(TxtBxDenominazione.Text.Equals("") && TxtBxCF.Text.Equals("") && TxtBxRea.Text.Equals(""));
        }

        private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenCooperative();
        }

        private CooperativaFDT GetCurrentItem()
        {
            CooperativaFDT toReturn = null;
            if (this.bindingSourceBase1.Current != null)
                toReturn = this.bindingSourceBase1.Current as CooperativaFDT;
            return toReturn;
        }


        public override bool ReadOnlyControls
        {
            get
            {
                return base.ReadOnlyControls;
            }
            set { }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Enter && btnSearch.Enabled && !gridControl1.Focused)
            {
                buttonSearch_Click(this, null);
                return true;
            }
            else if (gridControl1.Focused)
            {
                gridControl1_MouseDoubleClick(this, null);
                return true;
            }
            else
            {
                return base.ProcessDialogKey(keyData);
            }
        }

        private void SearchParix_Shown(object sender, EventArgs e)
        {
            TxtBxRea.Focus();
        }

        private void OpenCooperative()
        {
            selectedItem = GetCurrentItem();
            Boolean exception = false;
            if (!searchByRea)
            {

                CooperativaFDT[] results = GVCSystemEngine.InvokeService<ICooperatives, CooperativaFDT[]>(
                    delegate { return GVCSystemEngine.Cooperatives.SearchCooperativaParix("", "", selectedItem.RegistroCooperativa.NumeroREA, false, out exception); },
                    true);
                if (results != null)
                    selectedItem = results[0];
                else 
                { 
                    if(exception)
                        ShowInformationMessage("Impossibile raggiungere il servizio", "Impossibile raggiungere il servizio \nVerificare lo stato della conessione");   
                }
            }
            this.ParentForm.DialogResult = DialogResult.OK;
            this.ParentForm.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            OpenCooperative();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
      
    }
}
