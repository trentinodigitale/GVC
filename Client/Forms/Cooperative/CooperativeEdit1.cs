using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.Services;
using it.dedagroup.GVC.Client.Forms.Search.Parix;
using it.dedagroup.GVC.Repository.Common.Configurations;

namespace it.dedagroup.GVC.Client.Forms.Cooperative
{
    public partial class CooperativeEdit1 : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {

		#region Fields (3) 

        private Boolean alreadyShowedConfirmCancel = false;
        private int itemID = -1;
        private CooperativaFDT itemLocal = null;

		#endregion Fields 

		#region Constructors (1) 

        public CooperativeEdit1()
        {
            InitializeComponent();

            SetImages();

            this.ParentChanged += new EventHandler(CooperativeEdit1_ParentChanged);

            HandleStartupSecurity();
        }

		#endregion Constructors 

		#region Properties (2) 

        public int IdSoggetto
        {
            get
            {
                return itemID;
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
           
                if (value)

                {
                    this.barButtonItemModify.Enabled = true;
                    this.barButtonItemModify.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    this.barButtonItemSave.Enabled = false;
                    this.barButtonItemSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    this.barButtonItemUndo.Enabled = false;
                    this.barButtonItemUndo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    this.barButtonAggiornamenti.Enabled = true;
                    this.barButtonAggiornamenti.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

                    this.barButtonItemClose.Enabled = true;
                    this.barButtonItemClose.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                }
                else
                {
                    this.barButtonItemClose.Enabled = false;
                    this.barButtonItemClose.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

                    this.barButtonItemModify.Enabled = false;
                    this.barButtonItemModify.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    this.barButtonItemSave.Enabled = true;
                    this.barButtonItemSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    this.barButtonItemUndo.Enabled = true;
                    this.barButtonItemUndo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                }

                base.ConfirmCancel = !value;
           }
        }

		#endregion Properties 

		#region Methods (17) 


		// Public Methods (3) 

        public override void OnCancel()
        {
            alreadyShowedConfirmCancel = true;
            base.OnCancel();
        }

        public void SetBindableData(int itemID)
        {
            if (itemID > 0)
            {
                itemLocal = GVCSystemEngine.InvokeService<ICooperatives, CooperativaFDT>
                    (delegate() { return GVCSystemEngine.Cooperatives.GetCooperativaById(itemID); },
                    true);
                this.itemID = itemID;
            }
            else
            {
                itemLocal = null;
            }
            SetBindableData(itemLocal);                       
        }

        public void SetBindableData(CooperativaFDT item)
        {
            this.barButtonItemGetParixData.Visibility =  DevExpress.XtraBars.BarItemVisibility.Always;
            if (item == null)
            {
                item = new CooperativaFDT();
                item.RegistroCooperativa = new RegistroCooperativaFDT();
            }

            itemLocal = item;

            if (itemLocal != null)
            {
                coopData1.SetBindableData(itemLocal);

                if (itemLocal != null && itemLocal.RegistroCooperativa != null && itemLocal.RegistroCooperativa.IdRegistro > 0)
                {
                    SetFormTitle(itemLocal.RegistroCooperativa.IdRegistro.ToString());
                    this.barButtonItemGetParixData.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
                else
                {
                    SetFormTitle("Nuova cooperativa");
                    this.barButtonAggiornamenti.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
            }

            if (itemID > 0)
                this.ReadOnlyControls = true;
            else
                this.ReadOnlyControls = false;
            
        }

        



		// Private Methods (14) 

        private void barButtonItemEvidence_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            coopData1.ChangeEvidenceVisibility();
        }

        private void barButtonItemGetParixData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SearchParix page = CreatePage<SearchParix>();
            if (page.BaseForm.ShowDialog(this, false) == DialogResult.OK)
            {
                if (page.SelectedItem != null)
                {
                    this.itemID = 0;
                    this.itemLocal = page.SelectedItem;
                    SetBindableData(itemLocal);
                }
            }
        }

        private void barButtonItemModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //coopData1.SetReadOnly(false);

            if (Lock())
            {
                this.ReadOnlyControls = false;
                this.barButtonAggiornamenti.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                this.itemLocal.BeginEdit();
            }
            else
            {
                ShowInformationMessage("La cooperativa risulta già aperta in modifica da un'altra postazione", string.Empty);
            }
        }

        private void barButtonItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.coopData1 != null &&
                this.coopData1.Header != null)
            {
                coopData1.Header.Denomination.Focus();
                Application.DoEvents();
            }

            this.itemLocal.EndEdit();
            this.EndEditsBindingSources();

            if (SaveProcedure())
            {
                UnLock();
                this.ReadOnlyControls = true;
            }
        }

        private void barButtonItemUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ConfirmCancel() == DialogResult.Yes)
            {
                itemLocal.CancelEdit();
                if (itemID > 0)
                {
                    UnLock();
                    SetBindableData(itemID);
                }
                else
                {
                    Form f = this.FindForm();
                    if (f != null)
                        f.Close();
                }
            }
        }

        private DialogResult ConfirmCancel()
        {
            return ShowConfirmMessage(
                (this.ParentForm != null && this.ParentForm.ParentForm != null ? this.ParentForm.ParentForm.Text : String.Empty),
                "Uscire senza salvare i dati?",
                String.Empty);
        }

        private void CooperativeEdit1_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                SetBindableData(0);
            }
        }

        private void CooperativeEdit1_ParentChanged(object sender, EventArgs e)
        {
            if (this.ParentForm != null)
                this.ParentForm.FormClosing += new FormClosingEventHandler(ParentForm_FormClosing);
        }

        private void CreateAssembleaCostitutiva()
        {
            if (itemLocal != null && itemLocal.RegistroCooperativa != null)
            {
                Boolean creaAssemblea = true;

                if (itemLocal.RegistroCooperativa.Assemblee != null &&
                    itemLocal.RegistroCooperativa.Assemblee.Length > 0)
                {
                    foreach (DeliberaAssembleaFDT item in itemLocal.RegistroCooperativa.Assemblee)
                    {
                        if (item.IdTipoAssemblea == TipoAssemblea.COSTITUTIVA)
                        {
                            creaAssemblea = false;
                            break;
                        }
                    }
                }
               
                if (creaAssemblea)
                {
                    if (itemLocal.RegistroCooperativa.DataCostituzione.HasValue)
                    {
                        DeliberaAssembleaFDT newItem = new DeliberaAssembleaFDT();
                        newItem.DataAssemblea = itemLocal.RegistroCooperativa.DataCostituzione.Value;
                        newItem.IdNotaio = itemLocal.RegistroCooperativa.IdNotaio;
                        newItem.IdTipoAssemblea = TipoAssemblea.COSTITUTIVA;
                        newItem.Contenuto = "Assemblea costitutiva";
                        newItem.Status = ObjectStatus.ToInsert;
                        itemLocal.RegistroCooperativa.AddDeliberaAssemblea(newItem);
                    }
                }
            }
        }

        private List<string> HasErrorsCritical()
        {
            List<string> toReturn = new List<string>();

            if (coopData1 != null)
            {
                toReturn.AddRange(coopData1.HasErrorsCritical());
            }

            return toReturn;
        }

        private void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.ReadOnlyControls &
                !alreadyShowedConfirmCancel)
            {                
                if (ConfirmCancel() == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    UnLock();
                }
            }
        }

        private Boolean SaveProcedure()
        {
            Boolean forceSaving = false;
            Boolean showMsg = true;

            //if (itemLocal.IdSoggetto <= 0)
            //{
            //    //Creo Assemblea e modifica statutaria
            //}

            if (coopData1 != null)
                coopData1.EndEditBindingSource();
            itemLocal.EndEdit();

            List<string> errors = HasErrorsCritical();

            if (errors != null && errors.Count == 0)
            {
                do
                {
                    if (itemLocal.IdSoggetto < 1)
                    {
                        //Al primo salvataggio creare l'assemblea costitutiva
                        CreateAssembleaCostitutiva();
                    }

                    DepureItemFromDocumentations();

                    string[] cop = GVCSystemEngine.InvokeService<ICooperatives, string[]>
                            (delegate() { return GVCSystemEngine.Cooperatives.SaveCooperativa(itemLocal, forceSaving); },
                            true);

                    showMsg = true;
                    forceSaving = !forceSaving;

                    if (cop != null)
                    {
                        // cop.Length == 4
                        if (cop.Length >= 3 && cop[0].Equals(MessageIdentifications.ID_SOGGETTO))
                        {
                            StringBuilder sb = new StringBuilder();

                            int idSogg = -1;
                            int idReg = -1;
                            if (Int32.TryParse(cop[1], out idSogg) && Int32.TryParse(cop[3], out idReg))
                            {
                                sb.AppendLine(String.Format("Codice cooperativa = {0}", idReg.ToString()));
                                sb.AppendLine(Environment.NewLine);

                                int numeroScioglimento = -1;
                                if (cop.Length == 6)
                                {
                                    Int32.TryParse(cop[5], out numeroScioglimento);
                                    if (numeroScioglimento > 0)
                                    {
                                          sb.AppendLine(String.Format("Numero scioglimento = {0}", numeroScioglimento.ToString()));
                                    }
                                }

                                //Cooperativa salvata con successo riporto il numero di ID
                                ShowInformationMessage("Cooperativa salvata con successo", sb.ToString());
                                SetBindableData(idSogg);
                                return true;
                            }
                        }
                        else if (cop.Length == 2 &&
                            cop[0].Equals(MessageIdentifications.COOP_ALREADY_PRESENT))
                        {
                            if (ShowConfirmMessage("Conferma operazione", "Cooperativa con identificativi già presenti in banca dati. Procedere con il salvataggio?", cop[1]) == DialogResult.Yes)
                            {
                                forceSaving = true;
                                showMsg = false;
                            }
                            else
                            {
                                return false;
                            }

                        }

                        if (showMsg)
                        {
                            StringBuilder sb = new StringBuilder();
                            foreach (string msg in cop)
                            {
                                sb.AppendLine(msg);
                            }
                            ShowInformationMessage("Si sono verificati dei problemi durante il salvataggio", sb.ToString());
                            break;
                        }
                    }
                }
                while (forceSaving);
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(String.Concat("Riscontrati errori in :", Environment.NewLine));
                foreach (string s in errors)
                {
                    sb.AppendLine(string.Concat("\t", s, Environment.NewLine));
                }
                ShowInformationMessage("Risolvere gli errori bloccanti e riprovare il salvataggio", sb.ToString());
                return false;
            }

            return false;
        }

        private void Serialize()
        {
            System.Xml.Serialization.XmlSerializer xml = new System.Xml.Serialization.XmlSerializer(typeof(CooperativaFDT));
            System.IO.StreamWriter objWriter = new System.IO.StreamWriter(@"c:\file.txt");
            xml.Serialize(objWriter, itemLocal);
            objWriter.Flush();
            objWriter.Close();
        }

        private void SetImages()
        {
            this.barButtonItemModify.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Edit_24x24);
            this.barButtonItemSave.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Disk_Blue_24x24);
            this.barButtonItemEvidence.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Magic_Wand_24x24);
            this.barButtonItemUndo.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Undo_24x24);
            this.barButtonItemClose.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Exit_24x24);
            this.barButtonAggiornamenti.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Refresh_24x24);
            this.barButtonItemGetParixData.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Find_24x24);
        }

		#endregion Methods 

        private void barButtonItemClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MyClose();
        }

        private void MyClose()
        {
            UnLock();

            Form f = this.FindForm();
            if (f != null)
                f.Close();
        }

        private void HandleStartupSecurity()
        {
            if (System.Threading.Thread.CurrentPrincipal.IsInRole(UserRoles.Visitatore))
            {
                this.barButtonItemModify.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }

        private void DepureItemFromDocumentations()
        {
            if (itemLocal != null)
            {
                if (itemLocal.RegistroCooperativa != null)
                {
                    // REGISTRO
                    RemoveByteArray(itemLocal.RegistroCooperativa.Documentazioni);

                    // ADESIONI
                    if (itemLocal.RegistroCooperativa.Adesioni != null)
                    {
                        foreach (AdesioneFDT item in itemLocal.RegistroCooperativa.Adesioni)
                        {
                            RemoveByteArray(item.Documentazioni);
                        }
                    }

                    // REVISIONI
                    if (itemLocal.RegistroCooperativa.Revisioni != null)
                    {
                        foreach (RevisioneFDT item in itemLocal.RegistroCooperativa.Revisioni)
                        {
                            RemoveByteArray(item.Documentazioni);
                        }
                    }

                    // BILANCIO
                    if (itemLocal.RegistroCooperativa.Bilanci != null)
                    {
                        foreach (BilancioFDT item in itemLocal.RegistroCooperativa.Bilanci)
                        {
                            RemoveByteArray(item.Documentazioni);
                        }
                    }

                    // BASE
                    if (itemLocal.RegistroCooperativa.ComunicazioniBaseSociale != null)
                    {
                        foreach (ComunicazioneBaseSocialeFDT item in itemLocal.RegistroCooperativa.ComunicazioniBaseSociale)
                        {
                            RemoveByteArray(item.Documentazioni);
                        }
                    }

                    // ASSEMBLEE
                    if (itemLocal.RegistroCooperativa.Assemblee != null)
                    {
                        foreach (DeliberaAssembleaFDT item in itemLocal.RegistroCooperativa.Assemblee)
                        {
                            RemoveByteArray(item.Documentazioni);
                        }
                    }

                    // PROCEDURA
                    if (itemLocal.RegistroCooperativa.ProcedureCoatte != null)
                    {
                        foreach (ProceduraCoattaFDT item in itemLocal.RegistroCooperativa.ProcedureCoatte)
                        {
                            RemoveByteArray(item.Documentazioni);
                        }
                    }

                    // FALLIMENTO
                    if (itemLocal.RegistroCooperativa.ProcedureFallimentari != null)
                    {
                        foreach (ProceduraFallimentareFDT item in itemLocal.RegistroCooperativa.ProcedureFallimentari)
                        {
                            RemoveByteArray(item.Documentazioni);
                        }
                    }

                    // LIQUIDAZIONE
                    if (itemLocal.RegistroCooperativa.LiquidazioniCoatte != null)
                    {
                        foreach (LiquidazioneCoattaFDT item in itemLocal.RegistroCooperativa.LiquidazioniCoatte)
                        {
                            RemoveByteArray(item.Documentazioni);
                        }
                    }

                    // CARICHE
                    if (itemLocal.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale != null)
                    {
                        foreach (ComunicazioneCaricaSocialeFDT item in itemLocal.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale)
                        {
                            RemoveByteArray(item.Documentazioni);
                        }
                    }
                }
                
            }
        }

        private void RemoveByteArray(DocumentazioneFDT[] items)
        {
            if (items != null)
            {
                foreach (DocumentazioneFDT item in items)
                {
                    if (item.Status == ObjectStatus.ToView ||
                        item.Status == ObjectStatus.ToCancel ||
                        item.Status == ObjectStatus.ToHide)
                    {
                        item.Allegati = null;
                        item.Icona = null;
                    }
                }
            }
        }

       

        private void barButtonAggiornamenti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Aggiornamenti.AggiornamentiMain mainAggiornamenti = CreatePage<Aggiornamenti.AggiornamentiMain>();
            mainAggiornamenti.DbCooperative = itemLocal;
            mainAggiornamenti.SetAggiornamentiToCoop();
            
            if (mainAggiornamenti.BaseForm.ShowDialog(this, false) == DialogResult.OK)
            {
                if (mainAggiornamenti.UpdatedCooperative != null 
                    && itemLocal.Segnalazioni != null)
                {
                    this.itemLocal.BeginEdit();
                    if (mainAggiornamenti.UpdatedCooperative != null)
                        SetBindableData(mainAggiornamenti.UpdatedCooperative);
                    this.ReadOnlyControls = false;
                    this.barButtonAggiornamenti.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                }
            }
        }


        internal void OpenSelectedTab(string tabName)
        {
            if (coopData1 != null)
            {
                coopData1.OpenSelectedTab(tabName, null);
            }
        }

        internal void OpenSelectedTab(string tabName, string tabControl)
        {
            if (coopData1 != null)
            {
                coopData1.OpenSelectedTab(tabName, tabControl);
            }
        }


        private Boolean Lock()
        {
            if (itemID > 0)
            {
                Boolean toReturn = false;

                LockFDT lockCoop = new LockFDT();
                lockCoop.IdEntityType = Locks.LockEntities.COOPERATIVA;
                if (itemLocal != null &&
                    itemLocal.RegistroCooperativa != null)
                {
                    lockCoop.IdEntity = itemLocal.RegistroCooperativa.IdRegistro;
                }
                else
                {
                    lockCoop.IdEntity = -1;
                }
                lockCoop.Status = Locks.LockStatus.LOCKED;

                LockFDT lockItem = GVCSystemEngine.InvokeService<ICooperatives, LockFDT>
                        (delegate()
                {
                    return GVCSystemEngine.Cooperatives.SaveLock(lockCoop);
                },
                        true);

                if (lockItem != null)
                {
                    toReturn = true;
                }

                return toReturn;
            }
            else
            {
                return true;
            }
        }

        private Boolean UnLock()
        {
            LockFDT lockCoop = new LockFDT();
            lockCoop.IdEntityType = Locks.LockEntities.COOPERATIVA;
            if (itemLocal != null &&
                itemLocal.RegistroCooperativa != null)
            {
                lockCoop.IdEntity = itemLocal.RegistroCooperativa.IdRegistro;
            }
            else
            {
                lockCoop.IdEntity = -1;
            }
            lockCoop.Status = Locks.LockStatus.LOCKED;

            Boolean toReturn = GVCSystemEngine.InvokeService<ICooperatives, Boolean>
                    (delegate()
                    {
                        return GVCSystemEngine.Cooperatives.Unlock(lockCoop);
                    },
                    true);

            //if (lockItem != null)
            //{
            //    toReturn = true;
            //}

            return toReturn;
        }
    }
}
