using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Client.Forms.MDIForm;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Client.Forms.Engine;
using it.dedagroup.GVC.Repository.Common.Services;

namespace it.dedagroup.GVC.Client.Forms.Common
{
    public partial class UserControlBase : OeF.Forms.Pages.BarPage, IUserCommon
    {

		#region Fields (4) 

        private BaseForm _baseForm;
        private UserControl controlContainer = null;
        private Control controlForAutoSize = null;
        private int controlMinimumSize = 0;

		#endregion Fields 

		#region Constructors (1) 

        public UserControlBase()
        {
            InitializeComponent();

        }

		#endregion Constructors 

		#region Properties (6) 

        /// <summary>
        /// Gets the application engine.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new OeF.Engine.ApplicationEngine ApplicationEngine
        {
            get
            {
                OeF.Engine.ApplicationEngine engine = null;
                System.Windows.Forms.Form form = this.ParentForm;
                if (form != null &&
                    form is Main)
                {
                    Main mainForm = form as Main;
                    if (form != null)
                    {
                        engine = mainForm.ApplicationEngine;
                    }
                }
                return engine;
            }
            set
            {
                // Do nothing back support
            }
        }

        public int BarHeight
        {
            get
            {
                if (this.BarManager.Bars.Count > 1)
                {
                    return 30;
                }
                else
                {
                    return 0;
                }
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BaseForm BaseForm
        {
            get
            {
                BaseForm _baseForm = null;
                if (this.ParentForm != null && this.ParentForm is BaseForm)
                    _baseForm = this.ParentForm as BaseForm;
                if (_baseForm == null)
                    _baseForm = new BaseForm();
                return _baseForm;
            }
        }

        /// <summary>
        /// Gets the context.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new OeF.Context Context
        {
            get
            {
                OeF.Context context = null;
                System.Windows.Forms.Form form = this.ParentForm;
                if (form != null &&
                    form is BaseForm)
                {
                    BaseForm baseForm = form as BaseForm;
                    if (baseForm != null)
                    {
                        context = baseForm.Context;
                    }
                }
                return context;
            }
        }

        /// <summary>
        /// Gets the GVC system engine.
        /// </summary>
        /// <value>The GVC system engine.</value>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public GVCSystemEngine GVCSystemEngine
        {
            get
            {
                return GVCSystemEngine.Instance;
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
                it.dedagroup.GVC.Client.Forms.Common.UserControlHelp.SetEnabledAndReadOnly(this, value);
                base.ReadOnlyControls = value;
            }
        }

		#endregion Properties 

		#region Delegates and Events (1) 


		// Events (1) 

        public event EventHandler RequestSearch;


		#endregion Delegates and Events 

		#region Methods (16) 


		// Public Methods (11) 

        public Boolean CreatePage<PageType>(PageActions pageAction)
           where PageType : OeF.Forms.Pages.BarPage
        {
            return CreatePage<PageType>(this, pageAction);
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
            BaseForm parent = this.ParentForm as BaseForm;
            if (parent != null)
            {
                return parent.CreatePage<PageType>(owner, pageAction, out page, out container);
            }
            else
                throw new ArgumentNullException(typeof(BaseForm).FullName);
        }

        public PageType CreatePage<PageType>()
           where PageType : OeF.Forms.Pages.BarPage
        {
            PageType page = default(PageType);
            BaseForm container = default(BaseForm);

            if (CreatePage<PageType>(null, PageActions.OnlyCreate, out page, out container))
            {
                if (container != null)
                {
                    return page;
                }
            }
            return null;
        }

        public PageType CreatePageDialog<PageType>() where PageType : UserControlBase, new()
        {

            UserControlDialog page = CreatePage<UserControlDialog>();
            PageType cp = CreatePage<PageType>();
            page.AddUserControl(cp);
            return cp;


            //BaseForm b = null;

            //UserControlDialog ucd = null;
            //    CreatePage<UserControlDialog>(this, PageActions.OnlyCreate, out ucd, out b);
            //PageType page = new PageType();            
            //ucd.ScrollableContent.Controls.Add(page);
            //Form f = b; // ucd.FindForm();
            //if (f != null)
            //{
            //    f.Size = new Size(page.Size.Width, page.Size.Height + ucd.PanelButtons.Height + 10);
            //    f.MinimumSize = f.Size;
            //}
            
            //return page;
        }

        public void EnableControlAutoSize(object[] sizeableItems, Control control, int minimumSize)
        {
            if (!DesignMode)
            {
                if (controlForAutoSize == null)
                {
                    if (sizeableItems != null &&
                        sizeableItems.Length > 0 &&
                        control != null)
                    {
                        this.controlMinimumSize = minimumSize;
                        this.controlForAutoSize = control;
                        foreach (object sizeableItem in sizeableItems)
                        {
                            if (sizeableItem is UserControl)
                            {
                                controlContainer = sizeableItem as UserControl;
                                if (controlContainer != null)
                                    controlContainer.SizeChanged += new EventHandler(item_SizeChanged);
                            }
                            else if (sizeableItem is OeF.Forms.Controls.CollapseContainer)
                            {
                                OeF.Forms.Controls.CollapseContainer item = sizeableItem as OeF.Forms.Controls.CollapseContainer;
                                if (item != null)
                                    item.Paint += new PaintEventHandler(item_Paint);
                            }
                        }

                    }
                }
                else
                    throw new NotSupportedException("Only 1 grid is supported!");
            }
        }

        public void EndEditsBindingSources()
        {
            UserControlHelp.PeformActionOnBindingSources(this);
            if (this.HasChildren)
                UserControlHelp.EndEditsBindingSources(this.Controls);
        }

        public DialogResult OpenNewProcess()
        {
            //it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Procedimento.ProcedimentoEdit
            //    page = CreatePage<it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Procedimento.ProcedimentoEdit>();
            //if (page != null)
            //{
            //    page.SetFormTitle("Procedimento");
            //    return page.BaseForm.ShowDialog(this, this.ReadOnlyControls);
            //}
            //else
            //    return DialogResult.None;
            return DialogResult.None;
        }

        public Boolean OpenSubjectSearch(ref it.dedagroup.GVC.Repository.Common.FDT.SoggettoFDT item)
        {
            return OpenSubjectSearch(ref item, null);
        }

        public Boolean OpenSubjectSearch(ref it.dedagroup.GVC.Repository.Common.FDT.SoggettoFDT item, OeF.Utility.Expression customExpression)
        {
            it.dedagroup.GVC.Client.Forms.Registry.RicercaSoggetto
                page = CreatePage<it.dedagroup.GVC.Client.Forms.Registry.RicercaSoggetto>();
            if (page != null)
            {
                page.SetBindableData(item, customExpression);
                page.SetFormTitle("Ricerca soggetto");

                DialogResult dr = DialogResult.OK;

                while (dr == DialogResult.OK)
                {
                    dr = page.ParentForm.ShowDialog(this);

                    if (dr == DialogResult.Cancel)
                    {
                        item = null;
                        break;
                    }

                    if (page.SelectedSubject != null)
                    {
                        if (page.SelectedSubject.Soggetto != null)
                        {
                            item = page.SelectedSubject.Soggetto;
                        }
                        else
                        {
                            item = GVCSystemEngine.InvokeService<ICooperatives, it.dedagroup.GVC.Repository.Common.FDT.SoggettoFDT>
                                (delegate()
                                {
                                return GVCSystemEngine.Cooperatives.GetSoggettoById(page.SelectedSubject.IdSoggetto);
                                },
                                true);
                        }
                    }
                    if (item != null)
                        break;
                }
                if (item != null)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public void SetFormTitle(String title)
        {
            if (this.ParentForm != null)
                this.ParentForm.Text = title;
        }



		// Protected Methods (1) 

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.R))
            {
                EventHandler tmpReqSearch = RequestSearch;
                if (tmpReqSearch != null)
                {
                    tmpReqSearch(this, new EventArgs());
                }
                return true;
            }
            else
            {
                return base.ProcessDialogKey(keyData);
            }
        }



		// Private Methods (4) 

        private void HandleSizeChanged()
        {
            if (controlForAutoSize != null &&
                controlContainer != null)
            {
                int newHeight = controlContainer.Height - controlForAutoSize.Location.Y;

                if (!(controlContainer.Parent is BaseForm))
                {
                    UserControlBase ucb = controlContainer as UserControlBase;
                    if (ucb != null)
                    {
                        newHeight -= ucb.BarHeight;
                    }
                }

                if (newHeight >= controlMinimumSize)
                    controlForAutoSize.Height = newHeight;
            }
        }

        private void item_Paint(object sender, PaintEventArgs e)
        {
            HandleSizeChanged();
        }

        private void item_SizeChanged(object sender, EventArgs e)
        {
            HandleSizeChanged();
        }

        private void ScrollableContent_ControlAdded(object sender, ControlEventArgs e)
        {
            this.ScrollableContent.Update();
        }


		#endregion Methods 


        #region Show messages

        protected DialogResult ShowConfirmMessage(string caption, string message, string data)
        {
            return OeF.Forms.OeFMessageBox.Show(
                                this,
                                message,
                                caption,
                                data,
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question/*,
                            MessageBoxDefaultButton.Button2*/
                                                                 );
        }

        protected DialogResult ShowInformationMessage(string message, string data)
        {
            return OeF.Forms.OeFMessageBox.Show(
                                this,
                                message,
                                "GVC Client",
                                data,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information/*,
                            MessageBoxDefaultButton.Button2*/
                                                                 );
        }

        protected void ShowProblemsMessage()
        {
            OeF.Forms.OeFMessageBox.Show("Si è verificato un problema durante l'operazione richiesta.",
                                                 "Attenzione!",
                                                  MessageBoxButtons.OK,
                                                   MessageBoxIcon.Error);
        }

        #endregion Show messages


        #region IUserCommon Members

        DevExpress.XtraBars.BarManager IUserCommon.GetBarManager()
        {
            return this.BarManager;
        }

        #endregion


        public void DropDownFilter(DevExpress.XtraGrid.Views.Grid.GridView view,
                                    DevExpress.XtraGrid.Columns.GridColumn column, 
                                    Boolean toActive)
        {
            if (toActive)
            {
                view.ActiveFilterEnabled = true;
                view.ActiveFilterString = string.Format("[{0}] = {1}",
                                        column.FieldName,
                                        true);
            }
            else
            {
                view.ActiveFilterString = string.Empty;
                view.ActiveFilterEnabled = false;
            }
        }

        public void DropDownFilter(DevExpress.XtraGrid.Views.Grid.GridView view,
                                   DevExpress.XtraGrid.Columns.GridColumn column,
                                   int valueRif)
        {
            view.ActiveFilterEnabled = true;
            view.ActiveFilterString = string.Format("[{0}] = {1}",
                                    column.FieldName,
                                    valueRif);
        }

        public void ExpandAllDetails(DevExpress.XtraGrid.Views.Grid.GridView view, Boolean expand)
        {
            if (expand)
            {
                for (int i = 0; i < view.DataRowCount; i++)
                {
                    //if (!view.IsMasterRowEmpty(i))
                    //{
                        view.ExpandMasterRow(i);
                        DevExpress.XtraGrid.Views.Grid.GridView childView = (DevExpress.XtraGrid.Views.Grid.GridView)view.GetDetailView(i, view.DefaultRelationIndex);
                        if (childView != null)
                            ExpandAllDetails(childView, expand);
                    //}
                }
            }
            else
                view.CollapseAllDetails();
        }

        public void OpenCoopView(it.dedagroup.GVC.Repository.Common.FDT.CooperativaFDT coopDetail)
        {
            if (coopDetail != null)
            {
                it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.CoopData page = 
                    CreatePageDialog<it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.CoopData>();
                if (page != null)
                {
                    page.BaseForm.StartPosition = FormStartPosition.CenterScreen;
                    page.BaseForm.WindowState = FormWindowState.Maximized;

                    page.SetFormTitle("Dettaglio cooperativa");
                    page.SetBindableData(coopDetail);

                    page.BaseForm.ShowDialog(this, true);
                }
            }
        }

        private static string GetDefaultBrowserPath()
        {
            string key = @"htmlfile\shell\open\command";

            Microsoft.Win32.RegistryKey registryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(key, false);

            return ((string)registryKey.GetValue(null, null)).Split('"')[1];
        }

        public void OpenBrowser(string url)
        {
            string defaultBrowserPath = GetDefaultBrowserPath();

            try
            {
                System.Diagnostics.Process.Start(defaultBrowserPath, url);
            }

            catch (Exception exp)
            {
                ShowInformationMessage("Problemi nell'apertura del browser", exp.Message);
            }
        }

        public void OpenMail(string email)
        {
            try
            {
                System.Diagnostics.Process.Start(string.Concat("mailto:",email));
            }

            catch (Exception exp)
            {
                ShowInformationMessage("Problemi nell'apertura della mail", exp.Message);
            }
        }

    }
}
