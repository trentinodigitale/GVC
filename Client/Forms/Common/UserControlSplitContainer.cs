using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Client.Forms.MDIForm;
using it.dedagroup.GVC.Client.Forms.Engine;

namespace it.dedagroup.GVC.Client.Forms.Common
{
    public partial class UserControlSplitContainer : OeF.Forms.Pages.BarPage, IUserCommon
    {

		#region Fields (3) 

        private UserControl controlContainer = null;
        private Control controlForAutoSize = null;
        private int controlMinimumSize = 0;

		#endregion Fields 

		#region Constructors (1) 

        public UserControlSplitContainer()
        {
            InitializeComponent();
        }

		#endregion Constructors 

		#region Properties (4) 

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
                    form is BaseForm)
                {
                    BaseForm baseForm = form as BaseForm;
                    if (baseForm != null)
                    {
                        engine = baseForm.ApplicationEngine;
                    }
                }
                return engine;
            }
            set
            {
                // Do nothing back support
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
                    form is Main)
                {
                    Main mainForm = form as Main;
                    if (form != null)
                    {
                        context = mainForm.Context;
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

		#region Methods (16) 


		// Public Methods (10) 

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

        public void EndEditsBindigSources()
        {
            if (this.BindingContext != null)
            {
                foreach (BindingManagerBase manager in this.BindingContext)
                {
                    manager.EndCurrentEdit();
                }
            }
        }

        public void EndEditsBindingSources()
        {
            UserControlHelp.PeformActionOnBindingSources(this);
            if (this.HasChildren)
                UserControlHelp.EndEditsBindingSources(this.Controls);
        }

        public void ResetsBindingSources()
        {
            if (this.BindingContext != null)
            {
                foreach (BindingManagerBase manager in this.BindingContext)
                {
                    manager.CancelCurrentEdit();
                }
            }
        }

        public void SetFormTitle(String title)
        {
            if (this.ParentForm != null)
                this.ParentForm.Text = title;
        }



		// Private Methods (6) 

        private void HandleSizeChanged()
        {
            if (controlForAutoSize != null &&
                controlContainer != null)
            {
                int newHeight = controlContainer.Height - controlForAutoSize.Location.Y;
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

        private void Splitter_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (Splitter.SplitPosition <= 100)
            {
                Splitter.SplitPosition = ((Splitter.Dock == DockStyle.Left ? this.Size.Width : this.Size.Height) / 2);
            }
            else
            {
                Splitter.SplitPosition = 100;
            }
        }

        private void UserControlSplitContainer_Load(object sender, EventArgs e)
        {
           
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
    }
}
