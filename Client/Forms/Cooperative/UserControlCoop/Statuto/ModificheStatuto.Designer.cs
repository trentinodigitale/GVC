namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Statuto
{
    partial class ModificheStatuto
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
            this.constitutiveAct1 = new it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Statuto.AttoCostitutivo();
            this.panelControl1 = new OeF.Forms.Controls.PanelControl();
            this.labelControl1 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.meetingDetail1 = new it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Statuto.Assemblea.AssembleaDetail();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.meetingDetail1);
            this.ScrollableContent.Controls.Add(this.panelControl1);
            this.ScrollableContent.Controls.Add(this.constitutiveAct1);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 24);
            this.ScrollableContent.Size = new System.Drawing.Size(782, 436);
            // 
            // constitutiveAct1
            // 
            this.constitutiveAct1.ApplicationEngine = null;
            this.constitutiveAct1.ApplicationTitle = "";
            this.constitutiveAct1.ConfirmCancel = true;
            this.constitutiveAct1.ConfirmCancelMessage = "";
            this.constitutiveAct1.CurrentSequenceID = null;
            this.constitutiveAct1.CurrentTaskID = null;
            this.constitutiveAct1.Dock = System.Windows.Forms.DockStyle.Top;
            this.constitutiveAct1.IsShowing = false;
            this.constitutiveAct1.Location = new System.Drawing.Point(0, 0);
            this.constitutiveAct1.Name = "constitutiveAct1";
            this.constitutiveAct1.PageCaption = "";
            this.constitutiveAct1.ReadOnlyControls = true;
            this.constitutiveAct1.Size = new System.Drawing.Size(765, 99);
            this.constitutiveAct1.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 99);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(765, 25);
            this.panelControl1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(102, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Elenco assemblee";
            // 
            // meetingDetail1
            // 
            this.meetingDetail1.ApplicationEngine = null;
            this.meetingDetail1.ApplicationTitle = "";
            this.meetingDetail1.ConfirmCancel = true;
            this.meetingDetail1.ConfirmCancelMessage = "";
            this.meetingDetail1.CurrentSequenceID = null;
            this.meetingDetail1.CurrentTaskID = null;
            this.meetingDetail1.Dock = System.Windows.Forms.DockStyle.Top;
            this.meetingDetail1.IsShowing = false;
            this.meetingDetail1.Location = new System.Drawing.Point(0, 124);
            this.meetingDetail1.Name = "meetingDetail1";
            this.meetingDetail1.PageCaption = "";
            this.meetingDetail1.ReadOnlyControls = true;
            this.meetingDetail1.Size = new System.Drawing.Size(765, 475);
            this.meetingDetail1.TabIndex = 2;
            // 
            // ModificheStatuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ModificheStatuto";
            this.Size = new System.Drawing.Size(782, 460);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Statuto.Assemblea.AssembleaDetail meetingDetail1;
        private OeF.Forms.Controls.PanelControl panelControl1;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl1;
        private AttoCostitutivo constitutiveAct1;
    }
}
