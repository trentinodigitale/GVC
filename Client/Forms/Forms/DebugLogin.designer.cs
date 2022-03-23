namespace it.dedagroup.GVC.Client.Forms.Forms
{
    partial class DebugLogin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebugLogin));
            this.ScrollableContent = new DevExpress.XtraEditors.XtraScrollableControl();
            this.LoginPicture = new OeF.Forms.Controls.PictureEdit();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonRole1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonRole7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonRole6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonRole5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonRole4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonRole2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonRole3 = new DevExpress.XtraEditors.SimpleButton();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.ErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.LoginPicture);
            this.ScrollableContent.Controls.Add(this.simpleButtonCancel);
            this.ScrollableContent.Controls.Add(this.simpleButtonRole1);
            this.ScrollableContent.Controls.Add(this.simpleButtonRole7);
            this.ScrollableContent.Controls.Add(this.simpleButtonRole6);
            this.ScrollableContent.Controls.Add(this.simpleButtonRole5);
            this.ScrollableContent.Controls.Add(this.simpleButtonRole4);
            this.ScrollableContent.Controls.Add(this.simpleButtonRole2);
            this.ScrollableContent.Controls.Add(this.simpleButtonRole3);
            resources.ApplyResources(this.ScrollableContent, "ScrollableContent");
            this.ScrollableContent.Name = "ScrollableContent";
            // 
            // LoginPicture
            // 
            resources.ApplyResources(this.LoginPicture, "LoginPicture");
            this.LoginPicture.Name = "LoginPicture";
            this.LoginPicture.Properties.AllowFocused = false;
            this.LoginPicture.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.LoginPicture.Properties.Appearance.Options.UseBackColor = true;
            this.LoginPicture.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.LoginPicture.Properties.ShowMenu = false;
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.simpleButtonCancel, "simpleButtonCancel");
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Click += new System.EventHandler(this.simpleButtonCancel_Click);
            // 
            // simpleButtonRole1
            // 
            resources.ApplyResources(this.simpleButtonRole1, "simpleButtonRole1");
            this.simpleButtonRole1.Name = "simpleButtonRole1";
            this.simpleButtonRole1.Click += new System.EventHandler(this.simpleButtonLogin_Click);
            // 
            // simpleButtonRole7
            // 
            resources.ApplyResources(this.simpleButtonRole7, "simpleButtonRole7");
            this.simpleButtonRole7.Name = "simpleButtonRole7";
            this.simpleButtonRole7.Click += new System.EventHandler(this.simpleButtonLogin_Click);
            // 
            // simpleButtonRole6
            // 
            resources.ApplyResources(this.simpleButtonRole6, "simpleButtonRole6");
            this.simpleButtonRole6.Name = "simpleButtonRole6";
            this.simpleButtonRole6.Click += new System.EventHandler(this.simpleButtonLogin_Click);
            // 
            // simpleButtonRole5
            // 
            resources.ApplyResources(this.simpleButtonRole5, "simpleButtonRole5");
            this.simpleButtonRole5.Name = "simpleButtonRole5";
            this.simpleButtonRole5.Click += new System.EventHandler(this.simpleButtonLogin_Click);
            // 
            // simpleButtonRole4
            // 
            resources.ApplyResources(this.simpleButtonRole4, "simpleButtonRole4");
            this.simpleButtonRole4.Name = "simpleButtonRole4";
            this.simpleButtonRole4.Click += new System.EventHandler(this.simpleButtonLogin_Click);
            // 
            // simpleButtonRole2
            // 
            resources.ApplyResources(this.simpleButtonRole2, "simpleButtonRole2");
            this.simpleButtonRole2.Name = "simpleButtonRole2";
            this.simpleButtonRole2.Click += new System.EventHandler(this.simpleButtonLogin_Click);
            // 
            // simpleButtonRole3
            // 
            resources.ApplyResources(this.simpleButtonRole3, "simpleButtonRole3");
            this.simpleButtonRole3.Name = "simpleButtonRole3";
            this.simpleButtonRole3.Click += new System.EventHandler(this.simpleButtonLogin_Click);
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "FlagGermany.png");
            this.ImageList.Images.SetKeyName(1, "FlagItaly.png");
            this.ImageList.Images.SetKeyName(2, "FlagUsa.png");
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // DebugLogin
            // 
            this.AcceptButton = this.simpleButtonRole3;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.simpleButtonCancel;
            this.Controls.Add(this.ScrollableContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DebugLogin";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.XtraScrollableControl ScrollableContent;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRole3;
        /// <summary>
        /// ImageList
        /// </summary>
        protected System.Windows.Forms.ImageList ImageList;
        /// <summary>
        /// LoginPicture
        /// </summary>
        protected OeF.Forms.Controls.PictureEdit LoginPicture;
        /// <summary>
        /// ErrorProvider
        /// </summary>
        public DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ErrorProvider;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRole1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRole5;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRole4;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRole7;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRole6;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRole2;
    }
}