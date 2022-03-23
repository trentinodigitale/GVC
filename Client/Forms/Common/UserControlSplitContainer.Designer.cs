namespace it.dedagroup.GVC.Client.Forms.Common
{
    partial class UserControlSplitContainer
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
            this.PanelTop = new DevExpress.XtraEditors.PanelControl();
            this.Splitter = new DevExpress.XtraEditors.SplitterControl();
            this.PanelBottom = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.PanelBottom);
            this.ScrollableContent.Controls.Add(this.Splitter);
            this.ScrollableContent.Controls.Add(this.PanelTop);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 24);
            this.ScrollableContent.Size = new System.Drawing.Size(800, 576);
            // 
            // PanelTop
            // 
            this.PanelTop.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(800, 223);
            this.PanelTop.TabIndex = 1;
            // 
            // Splitter
            // 
            this.Splitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.Splitter.Location = new System.Drawing.Point(0, 223);
            this.Splitter.Name = "Splitter";
            this.Splitter.Size = new System.Drawing.Size(800, 6);
            this.Splitter.TabIndex = 2;
            this.Splitter.TabStop = false;
            this.Splitter.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Splitter_MouseDoubleClick);
            // 
            // PanelBottom
            // 
            this.PanelBottom.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBottom.Location = new System.Drawing.Point(0, 229);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(800, 347);
            this.PanelBottom.TabIndex = 3;
            // 
            // UserControlSplitContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "UserControlSplitContainer";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.UserControlSplitContainer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelBottom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraEditors.PanelControl PanelTop;
        protected DevExpress.XtraEditors.PanelControl PanelBottom;
        protected DevExpress.XtraEditors.SplitterControl Splitter;

    }
}
