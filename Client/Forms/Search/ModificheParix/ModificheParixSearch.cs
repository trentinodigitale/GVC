using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.RicercheWrapper;
using it.dedagroup.GVC.Repository.Common.Converters;
using it.dedagroup.GVC.Repository.Common.Services;
using it.dedagroup.GVC.Client.Forms.Common;
using it.dedagroup.GVC.Client.Forms.Cooperative;
using it.dedagroup.GVC.Repository.Common;
using DevExpress.XtraEditors;

namespace it.dedagroup.GVC.Client.Forms.Search.ModificheParix
{
    public partial class ModificheParixSearch : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        private SegnalazioneFDT[] segnalazioni;
        

        public ModificheParixSearch()
        {
            InitializeComponent();
        }

        private void SetBarButtonsEnable(Boolean enabled) 
        {
            this.barButtonItemCancellaLog.Enabled = enabled;
            this.barButtonItemStampa.Enabled = enabled;
        }

        private void SetCoopDataSource(CooperativaRicercaFDT[] coopRicerca) 
        {
            if (coopRicerca != null && coopRicerca.Length > 0)
                SetBarButtonsEnable(true); 
            else
                SetBarButtonsEnable(false);
            this.bindingSourceCooperative.DataSource = coopRicerca;
        }

        void ModificheParixSearch_Load(object sender, System.EventArgs e)
        {
            SetFormTitle("Ricerca modifiche Parix");
            PopulateTipiSegnalazioneList();
            dtEditTo.DateTime = DateTime.Today;
            dtEditFrom.DateTime = DateTime.Today.AddDays(-1);
            selectAllTypes(true);
            SetBarButtonsEnable(false);
            this.gridControl1.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.False;
        }

        private void PopulateTipiSegnalazioneList()
        {
            DizionarioFDT[] allSignals = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_SEGNALAZIONE);
            List<DizionarioFDT> signalsToBind = new List<DizionarioFDT>();
            if (allSignals != null && allSignals.Length > 0) 
            {
                foreach (DizionarioFDT eachSig in allSignals) 
                {
                    if (eachSig.Attivo)
                        signalsToBind.Add(eachSig);
                } 
            }
            bindingSourceTipoSegnalazioni.DataSource = signalsToBind.ToArray();
        }

        private int[] RetrieveSegTypes() 
        { 
            int[] segTypes = new int[lbxtipoSegnalazione.CheckedIndices.Count];
            
            for (int i = 0; i < segTypes.Length; i++) 
            {
                segTypes[i] = ((DizionarioFDT)lbxtipoSegnalazione.GetItem(lbxtipoSegnalazione.CheckedIndices[i])).IdElemento;
            }
            return segTypes;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool searchSeg = false;

            int idRegistro = Int32.MinValue;
            if (!String.IsNullOrEmpty(tbxCoopCode.Text) || !String.IsNullOrEmpty(tbxCoopNRea.Text))
            {
                searchSeg = SearchCooperative();
                idRegistro = Convert.ToInt32(tbxCoopCode.Text);
            }
            else
            {
                searchSeg = true;
            }
            if (searchSeg)
            {
                this.btnEspandiAll.Text = "Espandi";
                this.btnEspandiAll.Tag = 1;

                int checkVisibile = -1;
                int checkApplicato = -1;

                if (radioGroupVisibili.SelectedIndex == 1)
                    checkVisibile = 1;
                else if (radioGroupVisibili.SelectedIndex == 2)
                    checkVisibile = 0;

                if (radioGroupApplicate.SelectedIndex == 1)
                    checkApplicato = 1;
                else if (radioGroupApplicate.SelectedIndex == 2)
                    checkApplicato = 0;


                segnalazioni = GVCSystemEngine.InvokeService<ICooperatives, SegnalazioneFDT[]>(
                       delegate { return GVCSystemEngine.Cooperatives.GetListSegnalazioniByDate(idRegistro, dtEditFrom.DateTime, dtEditTo.DateTime, RetrieveSegTypes(), checkVisibile, checkApplicato); }, //checkEditVisible.Checked, checkEditApplied.Checked
                       true);
                if (segnalazioni != null && segnalazioni.Length > 0)
                {
                    CooperativaRicercaFDT[] result = Converters.ConvertAllIntoModificheParix(segnalazioni);
                    SetCoopDataSource(result);
                    lblResult.Text = result.Length.ToString();
                }
                else
                {
                    lblResult.Text = "0";
                    SetCoopDataSource(null);
                }
            }
        }

        private void btnSearchCoop_Click(object sender, EventArgs e)
        {
            SearchCooperative();
        }

        private Boolean SearchCooperative()
        {
            CooperativaFDT item = null;
            CoopTemplateSearch page = CreatePageDialog<Search.CoopTemplateSearch>();
            if (page != null)
            {
                page.BaseForm.StartPosition = FormStartPosition.CenterScreen;
                DialogResult dr = DialogResult.OK;
                page.NotToOpen = true;
                page.SetCode(tbxCoopCode.Text);
                page.SetReaNr(tbxCoopNRea.Text);
                int results = 0;
                if (!String.IsNullOrEmpty(tbxCoopCode.Text) || !String.IsNullOrEmpty(tbxCoopNRea.Text))
                    results = page.Search();
                if (results == 1)
                {
                    tbxCoopCode.Text = page.SelectedItem.RegistroCooperativa.IdRegistro.ToString();
                    tbxCoopNRea.Text = page.SelectedItem.RegistroCooperativa.NumeroREA;
                    page.BaseForm.DialogResult = DialogResult.OK;
                    return true;
                }
                else
                {
                    while (dr == DialogResult.OK)
                    {
                        item = null;
                        dr = page.BaseForm.ShowDialog(null, false);
                        if (dr != DialogResult.OK)
                            break;
                        if (dr == DialogResult.OK)
                            item = page.SelectedItem;

                        if (item != null)
                        {
                            tbxCoopCode.Text = item.RegistroCooperativa.IdRegistro.ToString();
                            tbxCoopNRea.Text = item.RegistroCooperativa.NumeroREA;
                            break;
                        }
                    }
                }
            }
            return false;
        }

       

        private void btnSelAll_Click(object sender, EventArgs e)
        {
            int selected = Convert.ToInt16(this.btnSelAll.Tag);
            if (selected == 1)
            {
                this.btnSelAll.Text = "Seleziona tutto";
                this.btnSelAll.Tag = 0;
                selectAllTypes(false);
            }
            else 
            {
                this.btnSelAll.Text = "Deseleziona tutto";
                this.btnSelAll.Tag = 1;
                selectAllTypes(true);
            }
        }

        private void selectAllTypes(Boolean check) 
        {
            for (int i = 0; i < lbxtipoSegnalazione.ItemCount; i++)
                lbxtipoSegnalazione.SetItemChecked(i, check);
        }

       
        
        private void OpenForEdit(CooperativaRicercaFDT item)
        {
            if (item != null)
            {
                if (!UserControlHelp.IsTheSubjectAlreadyOpen(this, item.IdSoggetto))
                {
                    CooperativeEdit1 page = null;
                    BaseForm baseForm = null;
                    CreatePage<Cooperative.CooperativeEdit1>(this, PageActions.ShowMdiChild, out page, out baseForm);
                    if (page != null)
                        page.SetBindableData(item.IdSoggetto);
                }
                else
                    ShowInformationMessage("Cooperativa già aperta a video", string.Empty);
            }
        }

        private CooperativaRicercaFDT GetCurrentItem()
        {
            CooperativaRicercaFDT toReturn = null;
            if (this.bindingSourceCooperative.Current != null)
                toReturn = this.bindingSourceCooperative.Current as CooperativaRicercaFDT;
            return toReturn;
        }

        private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenForEdit(GetCurrentItem());
        }

        //private void barButtonStampa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    DevExpress.XtraPrinting.PrintingSystem ps = new DevExpress.XtraPrinting.PrintingSystem();
        //    DevExpress.XtraPrinting.PrintableComponentLink pcl = new DevExpress.XtraPrinting.PrintableComponentLink();

        //    ps.Links.Add(pcl);
        //    pcl.Component = this.gridControl1;

        //    ps.Links[0].Landscape = true;

        //    DevExpress.XtraPrinting.PageHeaderFooter phf = ps.Links[0].PageHeaderFooter as DevExpress.XtraPrinting.PageHeaderFooter;
        //    //phf.Header.Content.AddRange(new string[] { String.Concat("PARAMETRI DI RICERCA", Environment.NewLine, ""), null, String.Concat(Environment.NewLine, "Ricerca documentazione") });
        //    phf.Header.Content.AddRange(new string[] { null, null, String.Concat(Environment.NewLine, "Ricerca segnalazioni") });

        //    pcl.ShowPreviewDialog();
        //}

        private void barButtonItemCancellaLog_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cancellaLog();
        }

        private void cancellaLog() 
        {
            if (segnalazioni != null && segnalazioni.Length > 0)
            {
                DialogResult confirmDelete =  ShowConfirmMessage(
                (this.ParentForm != null && this.ParentForm.ParentForm != null ? this.ParentForm.ParentForm.Text : String.Empty),
                "Desidera veramente cancellare permanentemente le segnalazioni dal log?",
                String.Empty);
                if (confirmDelete == DialogResult.Yes)
                {
                    this.bindingSourceCooperative.MoveFirst();
                    int errors = 0;
                    Boolean successful = false;
                    for (int i = 0; i < segnalazioni.Length; i++)
                    {
                        successful = GVCSystemEngine.InvokeService<ICooperatives, Boolean>(
                             delegate { return GVCSystemEngine.Cooperatives.DeleteSegnalazione(segnalazioni[i]); },
                             true);
                        if (!successful)
                            errors++;
                    }
                    segnalazioni = null;
                    SetCoopDataSource(null);
                    ShowInformationMessage("Le sengalazioni sono state cancellate con successo", "Le sengalazioni sono state cancellate con successo");
                }
            }
        }

        private void barButtonItemStampa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.XtraPrinting.PrintingSystem ps = new DevExpress.XtraPrinting.PrintingSystem();
            DevExpress.XtraPrinting.PrintableComponentLink pcl = new DevExpress.XtraPrinting.PrintableComponentLink();

            ps.Links.Add(pcl);
            pcl.Component = this.gridControl1;

            ps.Links[0].Landscape = true;

            DevExpress.XtraPrinting.PageHeaderFooter phf = ps.Links[0].PageHeaderFooter as DevExpress.XtraPrinting.PageHeaderFooter;
            phf.Header.Content.AddRange(new string[] { null, null, String.Concat(Environment.NewLine, "Ricerca segnalazioni") });
            pcl.ShowPreviewDialog();
        }

        private void btnEspandiAll_Click(object sender, EventArgs e)
        {
            int selected = Convert.ToInt16(this.btnEspandiAll.Tag);
            if (selected == 1)
            {
                this.btnEspandiAll.Text = "Comprimi";
                this.btnEspandiAll.Tag = 0;
                ExpandAllDetails(this.gridView1, true);
            }
            else
            {
                this.btnEspandiAll.Text = "Espandi";
                this.btnEspandiAll.Tag = 1;
                ExpandAllDetails(this.gridView1, false);
            }
        }

        private void radioGroupApplicate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroupApplicate.SelectedIndex == 1)
            {
                radioGroupVisibili.SelectedIndex = 2;
                radioGroupVisibili.Enabled = false;
            }
            else
            {
                if (radioGroupVisibili.Enabled == false)
                    radioGroupVisibili.Enabled = true;
            }
        }

        private void radioGroupVisibili_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroupVisibili.SelectedIndex == 1)
            {
                radioGroupApplicate.SelectedIndex = 2;
                radioGroupApplicate.Enabled = false;
            }
            else
            {
                if (radioGroupApplicate.Enabled == false)
                    radioGroupApplicate.Enabled = true;
            }
        }       
    }
}
