using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Client.Forms.Common;
using System.Runtime.InteropServices;
using it.dedagroup.GVC.Client.Forms.Engine;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.Services;
using it.dedagroup.GVC.Client.Forms.Search;
using it.dedagroup.GVC.Client.Forms.Search.Annotazioni;
using it.dedagroup.GVC.Client.Forms.Search.Bilanci;
using it.dedagroup.GVC.Client.Forms.Search.Cancellazioni;
using it.dedagroup.GVC.Client.Forms.Search.Documentazione;
using it.dedagroup.GVC.Client.Forms.Search.Fallimenti;
using it.dedagroup.GVC.Client.Forms.Search.Sanzioni.SanzioniAmministrative;
using it.dedagroup.GVC.Client.Forms.Search.Revisioni;
using it.dedagroup.GVC.Client.Forms.Search.ModificheStatutarie;
using it.dedagroup.GVC.Client.Forms.Search.Procedimenti;
using it.dedagroup.GVC.Client.Forms.Search.Sanzioni.ProceduraCoatta;
using it.dedagroup.GVC.Client.Forms.Search.Sanzioni.LiquidazioneCoatta;
using it.dedagroup.GVC.Client.Forms.Search.ModificheParix;

namespace it.dedagroup.GVC.Client.Forms.MDIForm
{
    public partial class Main : OeF.Forms.MDIForm
    {

		#region Constructors (1) 

        public Main()
        {
            InitializeComponent();

            this.DockPanelMainMenu.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;

            SetImages();

            // Only for debugging purposes
            //try
            //{
            //    CooperativaFDT item = StaticClassTemp.GetCooperativeFDT();

            //    CooperativaFDT item1 = GVCSystemEngine.InvokeService<ICooperatives, CooperativaFDT>(
            //        delegate() { return GVCSystemEngine.Cooperatives.SaveCooperativa(item); }, false);
            //}
            //catch (Exception ex)
            //{
            //}


            HandleCurrentStartupSecurity();

         
                        
        }

		#endregion Constructors 

		#region Properties (3) 

        /// <summary>
        /// Gets the application engine.
        /// </summary>
        /// <value>The application engine.</value>
        public new OeF.Engine.ApplicationEngine ApplicationEngine
        {
            get
            {
                return base.ApplicationEngine;
            }
        }

        /// <summary>
        /// Gets the context.
        /// </summary>
        /// <value>The context.</value>
        public new OeF.Context Context
        {
            get 
            {
                return base.Context;
            }
        }

        /// <summary>
        /// Gets the GVC system engine.
        /// </summary>
        /// <value>The GVC system engine.</value>
        public GVCSystemEngine GVCSystemEngine
        {
            get
            {
                return GVCSystemEngine.Instance;
            }
        }

		#endregion Properties 

        private void HandleCurrentStartupSecurity()
        {
            if (!System.Threading.Thread.CurrentPrincipal.IsInRole(UserRoles.Administrator))
            {
                if (barButtonItemVocabolari != null)
                {
                    barButtonItemReleaseCoop.Visibility =
                    barButtonItemVocabolari.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
            }

            if (System.Threading.Thread.CurrentPrincipal.IsInRole(UserRoles.Visitatore))
            {
                barButtonItemNewCooperativa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }

		#region Methods (8) 


		// Public Methods (3) 

        public Boolean CreatePage<PageType>()
          where PageType : OeF.Forms.Pages.BarPage
        {
            return CreatePage<PageType>(this, PageActions.ShowMdiChild);
        }

        public Boolean CreatePage<PageType>(IWin32Window owner, PageActions pageAction)
           where PageType : OeF.Forms.Pages.BarPage
        {
            PageType page = default(PageType);
            BaseForm container = default(BaseForm);
            return CreatePage<PageType>(owner, pageAction, out page, out container);
        }

        public Boolean CreatePage<PageType>(IWin32Window owner, PageActions pageAction, out PageType page, out BaseForm container)
            where PageType : OeF.Forms.Pages.BarPage
        {
            page = Activator.CreateInstance<PageType>();
            if (page != null)
            {
                container = new BaseForm();
                container.Icon = this.Icon;
                container.Text = this.Text;
                container.Width = page.Width + 10;
                container.Height = page.Height + 10;
                container.StartPosition = FormStartPosition.CenterParent;
                page.Dock = DockStyle.Fill;
                container.Controls.Add(page);
                if (pageAction == PageActions.ShowMdiChild)
                {
                    container.MdiParent = this;
                    container.Show();
                }
                else if (pageAction == PageActions.Show)
                {
                    container.Show();
                }
                else if (pageAction == PageActions.ShowDialog)
                {
                    container.ShowDialog(this);
                }
                return true;
            }
            else
                throw new ArgumentNullException(typeof(PageType).FullName);
        }



		// Private Methods (5) 

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GVCSystemEngine.ResetDizionari();
        }

        private void barButtonItemChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GVCSystemEngine != null)
                GVCSystemEngine.ChangePassword(this);
        }

        private void barButtonItemParix_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreatePage<it.dedagroup.GVC.Client.Forms.Search.Parix.SearchParix>();
        }

        private void barButtonItemSearchCooperative_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //CreatePage<CooperativeSearch>();
            CreatePage<CoopTemplateSearch>();
        }

        private void SetImages()
        {
            if (!this.DesignMode)
            {
                this.mainMenu.LinksPersistInfo.Clear();
                this.mainMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
                    new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemFile),
                    new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemView),
                    new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemCooperative),
                    new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemSubjects),
                    new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemTools),
                    new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemWindows),
                    new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemHelp)});

                barButtonItemSearch.Glyph = GVCResources.View_24x24;
                barButtonItemSearchCooperative.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.View_24x24);

                barButtonItemSubjectSearch.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.View_24x24);
            }
        }


		#endregion Methods 

        private void barButtonItemNewCooperativa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreatePage<it.dedagroup.GVC.Client.Forms.Cooperative.CooperativeEdit1>(this, PageActions.ShowMdiChild);
        }

        private void barButtonItemSubjectSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreatePage<SubjectSearch>();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreatePage<RevisioniEffettuateSearch>();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreatePage<RevisioniDaEffettuareSearch>();

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreatePage<ModificheStatSearch>();
        }

        private void barButtonItemVocabolari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!UserControlHelp.IsTheUserControlAlreadyOpen(this, typeof(Vocabolari.VocabolariManager), true))
            {
                CreatePage<Vocabolari.VocabolariManager>();
            }
        }

        private void barButtonItemProcedureCoatteRicerca_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreatePage<ProceduraCoattaSearch>();
        }

        private void barButtonItemLiqiudazioniCoatteRicerca_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreatePage<LiquidazioneCoattaSearch>();
        }

        private void barButtonItemRelazioniSemestraliRicerca_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreatePage<RelazioneSemestraleSearch>();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreatePage<ProcedimentiSearch>();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreatePage<CoopAdvancedSearch>();
        }

        private void barButtonItemAnnotazioni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreatePage<AnnotazioniSearch>();
        }

        private void barButtonItemBilanci_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreatePage<BilanciSearch>();
        }

        private void barButtonItemCancellazioni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreatePage<CancellazioniSearch>();
        }

        private void barButtonItemSanzioni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreatePage<SanzioniSearch>();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreatePage<FallimentiSearch>();
        }

        private void barButtonItemDocumentazione_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreatePage<DocumentazioniSearch>();
        }

        private void barButtonModificheParix_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreatePage<ModificheParixSearch>();
        }

        private void barButtonItemReleaseCoop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreatePage<it.dedagroup.GVC.Client.Forms.Forms.UnlockEntitiesManager>();
        }

        private void barButtonItemConfrontaParix_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreatePage<it.dedagroup.GVC.Client.Forms.Search.ConfrontoParix.ConfrontoParix>();
        }

        private void barButtonItemStatistica_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreatePage<it.dedagroup.GVC.Client.Forms.Statistics.CooperativeStatistics>();
        }

        private void barButtonGruppiParitetici_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            CreatePage<it.dedagroup.GVC.Client.Forms.Search.GruppiParitetici.GruppiPariteticiSearch>();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            CreatePage<CoopTemplateSearch>();
        }
         
    }
}
