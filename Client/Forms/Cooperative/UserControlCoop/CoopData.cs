using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Client.Forms.Common;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.Configurations;
using DevExpress.XtraNavBar;
using it.dedagroup.GVC.Repository.Common.Services;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop
{
    public partial class CoopData : UserControlDocking
    {
        private int TipoDocumentazioneFilter = 0;
        private String AnnoFilter = String.Empty;
        private String TitoloFilter = String.Empty;

		#region Delegates and Events (1) 


		// Events (1) 

        public event EventHandler<OeF.GenericEventArgs<it.dedagroup.GVC.Repository.Common.TabSheetNames>> ChangeTabSheetRequest;


		#endregion Delegates and Events 

		#region Event Handlers (4) 

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            RaiseChangeTabSheetRequest(it.dedagroup.GVC.Repository.Common.TabSheetNames.Adhesions);
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            RaiseChangeTabSheetRequest(it.dedagroup.GVC.Repository.Common.TabSheetNames.Revisions);
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            RaiseChangeTabSheetRequest(it.dedagroup.GVC.Repository.Common.TabSheetNames.ForcedProcedures);
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            RaiseChangeTabSheetRequest(it.dedagroup.GVC.Repository.Common.TabSheetNames.StatutaryChanges);
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            RaiseChangeTabSheetRequest(it.dedagroup.GVC.Repository.Common.TabSheetNames.ForcedLiquidations);
        }

		#endregion Event Handlers 

        CooperativaFDT item = null;

		#region Constructors (1) 

        public CoopData()
        {
            InitializeComponent();

            EventSubscription();

            //PopulateDockPanel();

            SetImages();
        }

        private void EventSubscription()
        {
            if (register1 != null)
            {
                register1.Cancellazione += new EventHandler(register1_Cancellazione);
                register1.Iscrizione += new EventHandler(register1_Iscrizione);
                register1.NuovoProcedimento += new EventHandler(register1_NuovoProcedimento);
            }
            if (data1 != null)
            {
                data1.Indirizzi += new EventHandler(data1_Indirizzi);
            }
            if (adesioneDetail1 != null)
            {
                adesioneDetail1.Adesione += new EventHandler(adesioneDetail1_Adesione);
            }
            if (statute1 != null)
            {
                statute1.ModificaStatutaria += new EventHandler(statute1_ModificaStatutaria);
                statute1.NuovoProcedimento += new EventHandler(statute1_NuovoProcedimento);
            }
            if (forcedProcedureDetail2 != null)
            {
                forcedProcedureDetail2.NuovoProcedimento += new EventHandler(forcedProcedureDetail2_NuovoProcedimento);
            }
            if (forcedLiquidationDetail1 != null)
            {
                forcedLiquidationDetail1.NuovoProcedimento += new EventHandler(forcedLiquidationDetail1_NuovoProcedimento);
            }

            if (revisionDetail1 != null)
            {
                revisionDetail1.NuovoProcedimento += new EventHandler(revisionDetail1_NuovoProcedimento);
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

                if (panelControl2 != null)
                {
                    SetReadOnlyControls(panelControl2.Controls, false);
                }
                this.btnRemoveSubject.Enabled = true;
            }
        }

        void revisionDetail1_NuovoProcedimento(object sender, EventArgs e)
        {
            processDetail1.UpdateProcedimento();
        }

        void forcedLiquidationDetail1_NuovoProcedimento(object sender, EventArgs e)
        {
            processDetail1.UpdateProcedimento();
        }

        void forcedProcedureDetail2_NuovoProcedimento(object sender, EventArgs e)
        {
            processDetail1.UpdateProcedimento();
        }

        void statute1_NuovoProcedimento(object sender, EventArgs e)
        {
            processDetail1.UpdateProcedimento();
        }

        void register1_NuovoProcedimento(object sender, EventArgs e)
        {
            processDetail1.UpdateProcedimento();
        }

        void statute1_ModificaStatutaria(object sender, EventArgs e)
        {
            UpdateHeader();
            UpdateDataRI();
        }

        void adesioneDetail1_Adesione(object sender, EventArgs e)
        {
            UpdateHeader();
        }

        void register1_Iscrizione(object sender, EventArgs e)
        {
            UpdateHeader();
        }

        void register1_Cancellazione(object sender, EventArgs e)
        {
            if (sender is Boolean)
            {
                Boolean b = (Boolean)sender;
                this.Header.SetHeaderColor(b);

                UpdateHeader();
            }
        }

        void data1_Indirizzi(object sender, EventArgs e)
        {
            UpdateHeader();
        }

        private void UpdateDataRI()
        {
            if (this.data1 != null)
                this.data1.ResetBindingSource();
        }

        private void UpdateHeader()
        {
            if (this.Header != null)
                this.Header.ResetBindingSource();
        }

        public void SetBindableData(CooperativaFDT itemP)
        {
            item = itemP;

            DatiFDT dati = GVCSystemEngine.InvokeService<ICooperatives, DatiFDT>
                         (delegate() { return GVCSystemEngine.Cooperatives.GetDati(); },
                         true);

            LeggiTrasgressioneFDT[] leggi = GVCSystemEngine.InvokeService<ICooperatives, LeggiTrasgressioneFDT[]>
                       (delegate() { return GVCSystemEngine.Cooperatives.GetLeggiSanzioni(); },
                       true);

            DizionarioFDT[] listaCadenze = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.CADENZA_REVISIONI);
            Dizionari items = new Dizionari();
            items.AddRange(listaCadenze);
            DizionarioFDT dettCadenzaRev = items.FindByID(itemP.RegistroCooperativa.IdCadenzaRevisione);

            this.bindingSourceDocumentationTypes.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_DOCUMENTO);

            if (item != null)
            {
                Header.SetBindableData(item);

                statute1.SetBindableData(item);

                adesioneDetail1.SetBindableData(item);

                revisionDetail1.SetBindableData(item, null, dati, dettCadenzaRev);

                processDetail1.SetBindableData(item);

                if (item.RegistroCooperativa != null)
                {
                    //documentationDetail1.SetBindableData(item.RegistroCooperativa.Documentazioni);
                    documentationDetail1.IsGeneral = true;
                    documentationDetail1.HideButtonsGeneral();
                    UserControlHelp.UpdateDocumentazioneCall(SetInitialDocumentationsGeneral());


                    failureProcedureDetail2.SetBindableData(item);
                    penaltyProcedureDetail1.SetBindableData(item, leggi);
                    remarkExpirationDetail1.SetBindableData(item);
                }

                BaseCaricheDetail1.SetBindableData(item, dati);

                forcedProcedureDetail2.SetBindableData(item, dati);
                forcedLiquidationDetail1.SetBindableData(item, dati);

                data1.SetBindableData(item, listaCadenze);

                register1.SetBindableData(item);

                budget1.SetBindableData(item);

                documentazioneFileSystemDetail1.SetBindableData(item, null);
            }            

            PopulateDockPanel();
        }

		#endregion Constructors 

		#region Public Methods (2) 

        public void InitializeBindingSource(CooperativaFDT item,
                                            FormaAmministrativaFDT[] listAdministrativeForms,
                                           CategoriaFDT[] listCategory,
                                           TipoCostituzioneFDT[] listConstitutionTypes,
                                           FormaGiuridicaFDT[] listJuridicalForms,
                                           CadenzaRevisioneFDT[] listRevisionCadences,
                                           DizionarioFDT[] listSections,
                                           Dictionary<int, DizionarioFDT[]> listSubSections,
                                           SottoCategoriaSocialeFDT[] listSocialSubCategory,
                                           StatoCooperativaFDT[] listStatus,
                                           DocumentazioneFDT[] generalDocumentation,
                                           DizionarioFDT[] documentationTypes,
                                           TipoAttivitaFDT[] listActivityTypes
                                            )
        {

            this.bindingSourceStatus.DataSource = listStatus;
            //this.bindingSourceGlobalData.DataSource = item;

            //if (coopAlboData1 != null)
            //{
            //    coopAlboData1.InitializeBindingSource(item,
            //                                          listAdministrativeForms,
            //                                          listCategory,
            //                                          listConstitutionTypes,
            //                                          listJuridicalForms,
            //                                          listRevisionCadences,
            //                                          listSections,
            //                                          listSubSections,
            //                                          listSocialSubCategory);
            //}

            //if (coopIscrizioneRegistro1 != null)
            //{
            //    coopIscrizioneRegistro1.InitializeBindingSource(item);
            //}

            //if (coopAltriDati1 != null)
            //{
            //    coopAltriDati1.InitializeBindingSource(item);
            //}

            //if (coopAttivitaEsercitate1 != null)
            //{
            //    coopAttivitaEsercitate1.InitializeBindingSource(item, listActivityTypes);
            //}

            if (generalDocumentation != null)
            {
                documentationDetail1.SetBindableData(generalDocumentation);
            }
        }

     

        internal void ChangeEvidenceVisibility()
        {
            if (DockPanel.Visibility == DevExpress.XtraBars.Docking.DockVisibility.Visible)
            {
                DockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            }
            else
            {
                DockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            }
        }

		#endregion Public Methods 

		#region Private Methods (1) 

        private void RaiseChangeTabSheetRequest(it.dedagroup.GVC.Repository.Common.TabSheetNames tabSheetName)
        {
            EventHandler<OeF.GenericEventArgs<it.dedagroup.GVC.Repository.Common.TabSheetNames>> changeTabSheetRequestTemp = ChangeTabSheetRequest;
            if (changeTabSheetRequestTemp != null)
            {
                changeTabSheetRequestTemp(this, new OeF.GenericEventArgs<it.dedagroup.GVC.Repository.Common.TabSheetNames>(tabSheetName));
            }
        }

		#endregion Private Methods 

        private DocumentazioneFDT[] SetInitialDocumentationsGeneral()
        {
            List<DocumentazioneFDT> toReturn = new List<DocumentazioneFDT>();

            if (item != null)
            {
                if (item.RegistroCooperativa != null)
                {
                    // REGISTRO
                    if (item.RegistroCooperativa.Documentazioni != null)
                    {
                        toReturn.AddRange(item.RegistroCooperativa.Documentazioni);
                    }

                    // ADESIONI
                    if (item.RegistroCooperativa.Adesioni != null)
                    {
                        foreach (AdesioneFDT itemP in item.RegistroCooperativa.Adesioni)
                        {
                            if (itemP.Documentazioni != null)
                            {
                                toReturn.AddRange(itemP.Documentazioni);
                            }
                        }
                    }

                    // REVISIONI
                    if (item.RegistroCooperativa.Revisioni != null)
                    {
                        foreach (RevisioneFDT itemP in item.RegistroCooperativa.Revisioni)
                        {
                            if (itemP.Documentazioni != null)
                            {
                                toReturn.AddRange(itemP.Documentazioni);
                            }
                        }
                    }

                    // BILANCIO
                    if (item.RegistroCooperativa.Bilanci != null)
                    {
                        foreach (BilancioFDT itemP in item.RegistroCooperativa.Bilanci)
                        {
                            if (itemP.Documentazioni != null)
                            {
                                toReturn.AddRange(itemP.Documentazioni);
                            }
                        }
                    }

                    // BASE
                    if (item.RegistroCooperativa.ComunicazioniBaseSociale != null)
                    {
                        foreach (ComunicazioneBaseSocialeFDT itemP in item.RegistroCooperativa.ComunicazioniBaseSociale)
                        {
                            if (itemP.Documentazioni != null)
                            {
                                toReturn.AddRange(itemP.Documentazioni);
                            }
                        }
                    }

                    // ASSEMBLEE
                    if (item.RegistroCooperativa.Assemblee != null)
                    {
                        foreach (DeliberaAssembleaFDT itemP in item.RegistroCooperativa.Assemblee)
                        {
                            if (itemP.Documentazioni != null)
                            {
                                toReturn.AddRange(itemP.Documentazioni);
                            }
                        }
                    }

                    // PROCEDURA
                    if (item.RegistroCooperativa.ProcedureCoatte != null)
                    {
                        foreach (ProceduraCoattaFDT itemP in item.RegistroCooperativa.ProcedureCoatte)
                        {
                            if (itemP.Documentazioni != null)
                            {
                                toReturn.AddRange(itemP.Documentazioni);
                            }
                        }
                    }

                    // FALLIMENTO
                    if (item.RegistroCooperativa.ProcedureFallimentari != null)
                    {
                        foreach (ProceduraFallimentareFDT itemP in item.RegistroCooperativa.ProcedureFallimentari)
                        {
                            if (itemP.Documentazioni != null)
                            {
                                toReturn.AddRange(itemP.Documentazioni);
                            }
                        }
                    }

                    // LIQUIDAZIONE
                    if (item.RegistroCooperativa.LiquidazioniCoatte != null)
                    {
                        foreach (LiquidazioneCoattaFDT itemP in item.RegistroCooperativa.LiquidazioniCoatte)
                        {
                            if (itemP.Documentazioni != null)
                            {
                                toReturn.AddRange(itemP.Documentazioni);
                            }
                        }
                    }

                    // CARICHE
                    if (item.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale != null)
                    {
                        foreach (ComunicazioneCaricaSocialeFDT itemP in item.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale)
                        {
                            if (itemP.Documentazioni != null)
                            {
                                toReturn.AddRange(itemP.Documentazioni);
                            }
                        }
                    }

                    // SANZIONI AMMINISTRATIVE
                    if (item.RegistroCooperativa.Sanzioni != null)
                    {
                        foreach (SanzioneFDT itemS in item.RegistroCooperativa.Sanzioni)
                        {
                            if (itemS.Documentazioni != null)
                            {
                                toReturn.AddRange(itemS.Documentazioni);
                            }
                        }
                    }
                }
            }
            return toReturn.ToArray();
        }

        private void barButtonItemEvidence_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangeEvidenceVisibility();
        }

        private void barButtonItemModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           // SetReadOnly(false);
        }

        public void EndEditBindingSource()
        {
            if (data1 != null)
            {
                data1.EndEditBindingSource();
            }
            if (Header != null)
            {
                Header.EndEditBindingSource();
            }
        }

        private void PopulateDockPanel()
        {
            DockPanel.Text = "Evidenze";

            NavBarItem nbi;
            NavBarGroup nbg;

            //nbi = new NavBarItem();
            //NavBarGroup nbg = new NavBarGroup("Dati generali");
            //nbg.Expanded = true;
            //nbi.Caption = "Aderente";
            //nbg.ItemLinks.Add(nbi);
            //this.NavBarControl.Items.Add(nbi);

           
            //NavBarItem nb1 = new NavBarItem("Ultima revisione anno 2001");
            //nbg.ItemLinks.Add(nb1);
            //this.NavBarControl.Items.Add(nb1);

            //NavBarControl.Groups.Add(nbg);

            NavBarControl.Groups.Clear();

            nbi = new NavBarItem();
            nbg = new NavBarGroup("Notifiche");
            nbg.Expanded = true;

            if (item != null)
            {

                if (item.AdesioneHeader.Equals("NON ADERENTE"))
                {
                    nbi = new NavBarItem();
                    nbi.Tag = 0;                    
                    nbi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_LinkClicked);
                    nbi.Caption = "Non aderente";
                    nbi.Hint = nbi.Caption;
                    nbg.ItemLinks.Add(nbi);
                    this.NavBarControl.Items.Add(nbi);
                }

                if ((item.RegistroCooperativa.Cancellazione != null) && (item.RegistroCooperativa.Cancellazione.ContainsData))
                {
                    nbi = new NavBarItem();
                    nbi.Tag = 1;
                    nbi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_LinkClicked);
                    nbi.Caption = "Cooperativa cancellata";                    
                    nbi.Hint = nbi.Caption;
                    nbg.ItemLinks.Add(nbi);
                    this.NavBarControl.Items.Add(nbi);
                }

                if (item.RegistroCooperativa.ScadenzaAnnotazioni != null)
                {
                    for (int i = 0; i < item.RegistroCooperativa.ScadenzaAnnotazioni.Length; i++)
                    {
                        if ((item.RegistroCooperativa.ScadenzaAnnotazioni[i].DataScadenza.HasValue) && (!item.RegistroCooperativa.ScadenzaAnnotazioni[i].Evasa))
                        {
                            nbi = new NavBarItem();
                            nbi.Tag = 2;
                            nbi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_LinkClicked);
                            nbi.Caption = "Scadenze non evase";
                            nbi.Hint = nbi.Caption;
                            nbg.ItemLinks.Add(nbi);
                            this.NavBarControl.Items.Add(nbi);
                            break;
                        }
                    }
                }

                if (item.RegistroCooperativa.Procedimenti != null)
                {
                    for (int i = 0; i < item.RegistroCooperativa.Procedimenti.Length; i++)
                    {
                        if ((item.RegistroCooperativa.Procedimenti[i].DataTermineFinale.HasValue) &&
                            (!item.RegistroCooperativa.Procedimenti[i].DataConclusione.HasValue))
                        {
                            nbi = new NavBarItem();
                            nbi.Tag = 3;
                            nbi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_LinkClicked);
                            nbi.Caption = "Procedimenti aperti";
                            nbi.Hint = nbi.Caption;
                            nbg.ItemLinks.Add(nbi);
                            this.NavBarControl.Items.Add(nbi);
                            break;
                        }
                    }

                    for (int i = 0; i < item.RegistroCooperativa.Procedimenti.Length; i++)
                    {
                        if ((item.RegistroCooperativa.Procedimenti[i].DataTermineFinale.HasValue) &&
                            (item.RegistroCooperativa.Procedimenti[i].DataConclusione.HasValue))
                        {
                            if (item.RegistroCooperativa.Procedimenti[i].DataTermineFinale.Value >
                                item.RegistroCooperativa.Procedimenti[i].DataConclusione.Value)
                            {
                                nbi = new NavBarItem();
                                nbi.Tag = 4;
                                nbi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_LinkClicked);
                                nbi.Caption = "Procedimenti non conclusi nei termini previsti";
                                nbi.Hint = nbi.Caption;
                                nbg.ItemLinks.Add(nbi);
                                this.NavBarControl.Items.Add(nbi);
                                break;
                            }
                        }
                    }
                }

                if (item.RegistroCooperativa.Revisioni != null)
                {
                    for (int i = 0; i < item.RegistroCooperativa.Revisioni.Length; i++)
                    {
                        if ((!item.RegistroCooperativa.Revisioni[i].DataDeliberaRevoca.HasValue) &&
                           (!item.RegistroCooperativa.Revisioni[i].DataDeliberaRevoca.HasValue) &&
                                (!item.RegistroCooperativa.Revisioni[i].DataConclusione.HasValue))
                        {
                            nbi = new NavBarItem();
                            nbi.Tag = 5;
                            nbi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_LinkClicked);
                            nbi.Caption = "Revisione non conclusa";
                            nbi.Hint = nbi.Caption;
                            nbg.ItemLinks.Add(nbi);
                            this.NavBarControl.Items.Add(nbi);
                            break;
                        }
                    }
                }

                if (item.RegistroCooperativa.LiquidazioniCoatte != null)
                {
                    for (int i = 0; i < item.RegistroCooperativa.LiquidazioniCoatte.Length; i++)
                    {
                        if ((!item.RegistroCooperativa.LiquidazioniCoatte[i].ProceduraRevocata) &&
                            (!item.RegistroCooperativa.LiquidazioniCoatte[i].ProceduraTerminata))
                        {
                            nbi = new NavBarItem();
                            nbi.Tag = 6;
                            nbi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_LinkClicked);
                            nbi.Caption = "Procedure sanzionatorie non concluse";
                            nbi.Hint = nbi.Caption;
                            nbg.ItemLinks.Add(nbi);
                            this.NavBarControl.Items.Add(nbi);
                            break;
                        }
                    }
                }

                if ((item.RegistroCooperativa.Cancellazione == null) || (!item.RegistroCooperativa.Cancellazione.ContainsData))
                {
                    if (item.RegistroCooperativa.Bilanci != null)
                    {
                        bool bShow;
                        List<BilancioFDT> listBilanci = new List<BilancioFDT>();

                        
                        for (int i = 0; i < item.RegistroCooperativa.Bilanci.Length; i++)
                        {
                            if (item.RegistroCooperativa.Bilanci[i].IdTipoBilancio == 1)
                            {
                                listBilanci.Add(item.RegistroCooperativa.Bilanci[i]);
                            }
                        }

                        if (listBilanci.Count >= 2)
                        {
                            listBilanci.Sort(
                             delegate(BilancioFDT b1, BilancioFDT b2) { return b1.Anno.CompareTo(b2.Anno); }
                            );

                            listBilanci.Reverse();

                            bShow = true;
                            for (int i = 0; i < 2; i++)
                            {
                                if (listBilanci[i].RequisitiPrevalenzaRapportiSoci != 2)
                                {
                                    bShow = false;
                                }
                            }

                            if (bShow)
                            {
                                nbi = new NavBarItem();
                                nbi.Tag = 7;
                                nbi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_LinkClicked);
                                nbi.Caption = @"Non sussitono i requisiti di prevalenza nei raporti con i soci";
                                nbi.Hint = nbi.Caption;
                                nbg.ItemLinks.Add(nbi);
                                this.NavBarControl.Items.Add(nbi);                                
                            }
                        }
                    }
                }               
            }

            NavBarControl.Groups.Add(nbg);

            //nbi = new NavBarItem();
            //nbg = new NavBarGroup("Legali rappresentanti");
            //nbg.Expanded = true;
            //nbi.Caption = "Tomina Alessandro (commissario liquidatore)";
            //nbg.ItemLinks.Add(nbi);
            //this.NavBarControl.Items.Add(nbi);

            //NavBarControl.Groups.Add(nbg);

            //NavBarControl.ActiveGroup = nbg;
        }

        private void navBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int itemID = Convert.ToInt32( e.Link.Item.Tag);

            if (itemID == 0)
            {
                OpenSelectedTab("xtraTabPageAdhesion", string.Empty);
            }
            else if (itemID == 1)
            {
                OpenSelectedTab("xtraTabPageDatiIscrizione", string.Empty);
            }
            else if (itemID == 2)
            {
                OpenSelectedTab("xtraTabPageAnnotazioni", string.Empty);
            }
            else if (itemID == 3)
            {
                OpenSelectedTab("xtraTabPageProcedimenti", string.Empty);
            }
            else if (itemID == 4)
            {
                OpenSelectedTab("xtraTabPageProcedimenti", string.Empty);
            }
            else if (itemID == 5)
            {
                OpenSelectedTab("xtraTabPageRevision", string.Empty);
            }
            else if (itemID == 6)
            {
                OpenSelectedTab("xtraTabPageSanzioni", "xtraTabPageLiquidazioniCoatte");
            }
            else if (itemID == 7)
            {
                OpenSelectedTab("xtraTabPageBilanci", string.Empty);
            }



        }


        public string[] HasErrorsCritical()
        {
            List<string> toReturn = new List<string>();

            if (Header != null)
            {
                toReturn.AddRange(Header.HasErrorsCritical());
            }

            if (data1 != null)
            {
                toReturn.AddRange(data1.HasErrorsCritical());
            }

            if (BaseCaricheDetail1 != null)
            {
                toReturn.AddRange(BaseCaricheDetail1.HasErrorsCritical());
            }

            

            return toReturn.ToArray();
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            // tipo documentazione
            TipoDocumentazioneFilter = 0;

            if (lookUpEdit1 != null)
            {
                if (lookUpEdit1.EditValue != null)
                {
                    int idTipo = -1;
                    if (Int32.TryParse(lookUpEdit1.EditValue.ToString(), out idTipo))
                    {
                        TipoDocumentazioneFilter = idTipo;
                    }
                }
            }

            documentationDetail1.ApplyFilter(TipoDocumentazioneFilter, TitoloFilter, AnnoFilter);
        }

        private void textEdit5_Leave(object sender, EventArgs e)
        {
            //Titolo (segnalibro)
            TitoloFilter = String.Empty;

            if (!String.IsNullOrEmpty(textEdit5.Text))
            {
                TitoloFilter = textEdit5.Text;
            }

            documentationDetail1.ApplyFilter(TipoDocumentazioneFilter, TitoloFilter, AnnoFilter);
        }

        private void textEditAnno_Leave(object sender, EventArgs e)
        {
            //Anno
            AnnoFilter = String.Empty;

            if (!String.IsNullOrEmpty(textEditAnno.Text))
            {
                AnnoFilter = textEditAnno.Text;
            }

            documentationDetail1.ApplyFilter(TipoDocumentazioneFilter, TitoloFilter, AnnoFilter);
        }

        private void btnRemoveSubject_Click(object sender, EventArgs e)
        {
            textEditAnno.Text = null;
            AnnoFilter = String.Empty;

            documentationDetail1.ApplyFilter(TipoDocumentazioneFilter, TitoloFilter, AnnoFilter);
        }

        private void SetImages()
        {
            this.btnRemoveSubject.Image = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
        }

        //public void ApplyFilterDocumentation()
        //{
        //    StringBuilder condition = new StringBuilder();

        //    if (TipoDocumentazioneFilter > 0)
        //    {
        //        if (condition.Length > 0)
        //        {
        //            condition.Append(" And ");
        //        }

        //        //documentationDetail1.gridViewDocumentation.Columns["colIdDocumentationType"].FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
        //        //condition.Append(string.Format("[{0}] = {1}",
        //        //                            documentationDetail1.gridViewDocumentation.Columns["colIdDocumentationType"].FieldName,
        //        //                            TipoDocumentazioneFilter));

        //    }

        //    if (!String.IsNullOrEmpty(TitoloFilter))
        //    {
        //        if (condition.Length > 0)
        //        {
        //            condition.Append(" And ");
        //        }
        //        //documentationDetail1.gridViewDocumentation.Columns["colTitle"].FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
        //        //condition.Append(string.Format("LOWER([{0}]) LIKE LOWER('%{1}%')",
        //        //                            documentationDetail1.gridViewDocumentation.Columns["colTitle"].FieldName,
        //        //                            TitoloFilter));

        //    }

        //    if (!String.IsNullOrEmpty(AnnoFilter))
        //    {
        //        if (condition.Length > 0)
        //        {
        //            condition.Append(" And ");
        //        }
        //        //documentationDetail1.gridViewDocumentation.Columns["colDocumentDate"].FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
        //        //condition.Append(string.Format("EXTRACT(YEAR FROM [{0}]) = {1}",
        //        //                            documentationDetail1.gridViewDocumentation.Columns["colDocumentDate"].FieldName,
        //        //                            AnnoFilter));

        //    }


        //    if (condition.Length > 0)
        //    {
        //        //documentationDetail1.ActivateFilter(true, condition.ToString());
        //        documentationDetail1.gridViewDocumentation.ActiveFilterEnabled = true;
        //        documentationDetail1.gridViewDocumentation.ActiveFilterString = condition.ToString();

        //    }
        //    else
        //    {
        //        //documentationDetail1.ActivateFilter(false, String.Empty);
        //        documentationDetail1.gridViewDocumentation.ActiveFilterEnabled = false;
        //        documentationDetail1.gridViewDocumentation.ActiveFilterString = string.Empty;
        //    }
        //}

        public void OpenSelectedTab(string tabName, string tabNameSub)
        {
            if (xtraTabControl1 != null)
            {
                foreach (DevExpress.XtraTab.XtraTabPage item in xtraTabControl1.TabPages)
                {
                    if (item != null)
                    {
                        if (item.Name.Equals(tabName))
                        {
                            xtraTabControl1.SelectedTabPage = item;

                            if (!String.IsNullOrEmpty(tabNameSub))
                            {
                                if (xtraTabControl2 != null)
                                {
                                    foreach (DevExpress.XtraTab.XtraTabPage item2 in xtraTabControl2.TabPages)
                                    {
                                        if (item2 != null)
                                        {
                                            if (item2.Name.Equals(tabNameSub))
                                            {
                                                xtraTabControl2.SelectedTabPage = item2;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
