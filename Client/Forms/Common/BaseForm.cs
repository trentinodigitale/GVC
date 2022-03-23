using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Client.Forms.MDIForm;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Client.Forms.Engine;

namespace it.dedagroup.GVC.Client.Forms.Common
{
    public partial class BaseForm : DevExpress.XtraEditors.XtraForm, OeF.Forms.ISheet
    {

		#region Constructors (1) 

        public BaseForm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialog(IWin32Window owner, Boolean isReadOnly)
        {
            if (this.Controls != null &&
                this.Controls.Count > 0)
            {
                OeF.Forms.Pages.BarPage barPage = this.Controls[0] as OeF.Forms.Pages.BarPage;
                if (barPage != null)
                {
                    barPage.ReadOnlyControls = isReadOnly;
                }
            }
            return ShowDialog(owner);
        }

		#endregion Constructors 

		#region Properties (3) 

        /// <summary>
        /// Gets the application engine.
        /// </summary>
        public OeF.Engine.ApplicationEngine ApplicationEngine
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

        /// <summary>
        /// Gets the context.
        /// </summary>
        public OeF.Context Context
        {
            get
            {
                OeF.Context context = null;
                System.Windows.Forms.Form form = this.ParentForm;
                if (form != null &&
                    form is Main)
                {
                    Main mainForm = form as Main;
                    if (mainForm != null)
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
        public GVCSystemEngine GVCSystemEngine
        {
            get
            {
                return GVCSystemEngine.Instance;
            }
        }

		#endregion Properties 

		#region Methods (3) 


		// Public Methods (3) 

        public Boolean CreatePage<PageType>()
           where PageType : OeF.Forms.Pages.BarPage
        {
            return CreatePage<PageType>(PageActions.ShowDialog);
        }

        public Boolean CreatePage<PageType>(PageActions pageAction)
           where PageType : OeF.Forms.Pages.BarPage
        {
            PageType page = default(PageType);
            BaseForm container = default(BaseForm);
            return CreatePage<PageType>(this, pageAction, out page, out container);
        }

        public Boolean CreatePage<PageType>(IWin32Window owner, PageActions pageAction, out PageType page, out BaseForm container)
            where PageType : OeF.Forms.Pages.BarPage
        {
            if (pageAction == PageActions.ShowMdiChild)
            {
                Main mdiParent = this.MdiParent as Main;
                if (mdiParent != null)
                {
                    return mdiParent.CreatePage<PageType>(owner, pageAction, out page, out container);
                }
                else
                    throw new ArgumentNullException(typeof(Main).FullName);
            }
            else
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
                    if (pageAction == PageActions.Show)
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
        }


		#endregion Methods 


        #region ISheet Members

        public string ApplicationTitle
        {
            get
            {
                return this.MdiParent != null ? this.MdiParent.Text : String.Empty;
            }
            set
            {
                if (this.MdiParent != null)
                    this.MdiParent.Text = value;
            }
        }

        public string Caption
        {
            get
            {
                return String.Empty;
            }
            set
            {
               
            }
        }

        public new System.Drawing.Size DefaultSize
        {
            get { return this.Size; }
        }

        public System.Drawing.Size FormSize
        {
            get
            {
                return this.Size;
            }
            set
            {
               
            }
        }

        public OeF.Engine.ApplicationConfiguration.TaskRow GetTaskRow(string taskID)
        {
            return null;
        }

        public OeF.Resources Resources
        {
            get { return null; }
        }

        public OeF.Engine.ActionResult RunSubTask(string subTaskID, bool checkSubTask)
        {
            return new OeF.Engine.ActionResult(DialogResult.None);
        }

        public OeF.Engine.ActionResult RunSubTask(string taskID)
        {
            return new OeF.Engine.ActionResult(DialogResult.None);
        }

        public OeF.Profiles.IUserEnvironment UserEnvironment
        {
            get { return System.Threading.Thread.CurrentPrincipal as OeF.Profiles.IUserEnvironment; }
        }

        #endregion

    }
}
