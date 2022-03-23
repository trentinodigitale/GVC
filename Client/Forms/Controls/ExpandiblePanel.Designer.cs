namespace it.dedagroup.GVC.Client.Forms.Controls
{
    partial class ExpandiblePanel
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
            this.panelControlFill = new DevExpress.XtraEditors.PanelControl();
            this.panelControlTitle = new DevExpress.XtraEditors.PanelControl();
            this.btnExpandCollapse = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlFill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTitle)).BeginInit();
            this.panelControlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlFill
            // 
            this.panelControlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlFill.Location = new System.Drawing.Point(2, 2);
            this.panelControlFill.Name = "panelControlFill";
            this.panelControlFill.Size = new System.Drawing.Size(699, 341);
            this.panelControlFill.TabIndex = 2;
            // 
            // panelControlTitle
            // 
            this.panelControlTitle.Controls.Add(this.btnExpandCollapse);
            this.panelControlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlTitle.Location = new System.Drawing.Point(2, 2);
            this.panelControlTitle.Name = "panelControlTitle";
            this.panelControlTitle.Size = new System.Drawing.Size(699, 31);
            this.panelControlTitle.TabIndex = 1;
            // 
            // btnExpandCollapse
            // 
            this.btnExpandCollapse.Location = new System.Drawing.Point(605, 5);
            this.btnExpandCollapse.Name = "btnExpandCollapse";
            this.btnExpandCollapse.Size = new System.Drawing.Size(93, 23);
            this.btnExpandCollapse.TabIndex = 0;
            this.btnExpandCollapse.Text = "Comprimi";
            this.btnExpandCollapse.Click += new System.EventHandler(this.btnExpandCollapse_Click);
            // 
            // ExpandiblePanel
            // 
            this.Controls.Add(this.panelControlTitle);
            this.Controls.Add(this.panelControlFill);
            this.Size = new System.Drawing.Size(703, 345);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlFill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTitle)).EndInit();
            this.panelControlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.PanelControl panelControlFill;
        public DevExpress.XtraEditors.PanelControl panelControlTitle;
        public DevExpress.XtraEditors.SimpleButton btnExpandCollapse;


    }
}
