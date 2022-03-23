namespace it.dedagroup.GVC.Client.Forms.Common
{
    partial class UserControlDocking
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.BarAndDockingController = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.DockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.NavBarControl = new DevExpress.XtraNavBar.NavBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.DockManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarAndDockingController)).BeginInit();
            this.DockPanel.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavBarControl)).BeginInit();
            this.SuspendLayout();
            // 
            // DockManager
            // 
            this.DockManager.Controller = this.BarAndDockingController;
            this.DockManager.Form = this;
            this.DockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.DockPanel});
            this.DockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // DockPanel
            // 
            this.DockPanel.Controls.Add(this.dockPanel1_Container);
            this.DockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.DockPanel.ID = new System.Guid("0f232848-80a4-444e-9b89-285f9ab8ce94");
            this.DockPanel.Location = new System.Drawing.Point(598, 0);
            this.DockPanel.Name = "DockPanel";
            this.DockPanel.Options.AllowDockBottom = false;
            this.DockPanel.Options.AllowDockFill = false;
            this.DockPanel.Options.AllowDockLeft = false;
            this.DockPanel.Options.AllowDockTop = false;
            this.DockPanel.Options.AllowFloating = false;
            this.DockPanel.Options.FloatOnDblClick = false;
            this.DockPanel.Options.ShowAutoHideButton = false;
            this.DockPanel.Size = new System.Drawing.Size(202, 300);
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.NavBarControl);
            this.dockPanel1_Container.Location = new System.Drawing.Point(2, 24);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(198, 274);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // NavBarControl
            // 
            this.NavBarControl.ActiveGroup = null;
            this.NavBarControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavBarControl.Location = new System.Drawing.Point(0, 0);
            this.NavBarControl.Name = "NavBarControl";
            this.NavBarControl.OptionsNavPane.ExpandedWidth = 198;
            this.NavBarControl.Size = new System.Drawing.Size(198, 274);
            this.NavBarControl.TabIndex = 0;
            this.NavBarControl.Text = "navBarControl1";
            // 
            // UserControlDocking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DockPanel);
            this.Name = "UserControlDocking";
            this.Size = new System.Drawing.Size(800, 300);
            ((System.ComponentModel.ISupportInitialize)(this.DockManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarAndDockingController)).EndInit();
            this.DockPanel.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NavBarControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        protected DevExpress.XtraBars.Docking.DockPanel DockPanel;
        protected DevExpress.XtraBars.Docking.DockManager DockManager;
        protected DevExpress.XtraBars.BarAndDockingController BarAndDockingController;
        protected DevExpress.XtraNavBar.NavBarControl NavBarControl;
    }
}
