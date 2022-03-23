namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.BaseCariche
{
    partial class BaseCaricheDetail
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
            this.comunicazioneBaseSocDetail1 = new it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.PositionAndBase.ComunicazioneBaseSoc.ComunicazioneBaseSocDetail();
            this.comunicazioneDetail1 = new it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.PositionAndBase.ComunicazioneCaricaSoc.ComunicazioneDetail();
            ((System.ComponentModel.ISupportInitialize)(this.PanelTop)).BeginInit();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelBottom)).BeginInit();
            this.PanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.comunicazioneDetail1);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelTop.Size = new System.Drawing.Size(428, 444);
            // 
            // PanelBottom
            // 
            this.PanelBottom.Controls.Add(this.comunicazioneBaseSocDetail1);
            this.PanelBottom.Location = new System.Drawing.Point(434, 0);
            this.PanelBottom.Size = new System.Drawing.Size(332, 444);
            // 
            // Splitter
            // 
            this.Splitter.Dock = System.Windows.Forms.DockStyle.Left;
            this.Splitter.Location = new System.Drawing.Point(428, 0);
            this.Splitter.Size = new System.Drawing.Size(6, 444);
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Size = new System.Drawing.Size(766, 444);
            // 
            // comunicazioneBaseSocDetail1
            // 
            this.comunicazioneBaseSocDetail1.ApplicationEngine = null;
            this.comunicazioneBaseSocDetail1.ApplicationTitle = "";
            this.comunicazioneBaseSocDetail1.ConfirmCancel = true;
            this.comunicazioneBaseSocDetail1.ConfirmCancelMessage = "";
            this.comunicazioneBaseSocDetail1.CurrentSequenceID = null;
            this.comunicazioneBaseSocDetail1.CurrentTaskID = null;
            this.comunicazioneBaseSocDetail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comunicazioneBaseSocDetail1.IsShowing = false;
            this.comunicazioneBaseSocDetail1.Location = new System.Drawing.Point(0, 0);
            this.comunicazioneBaseSocDetail1.Name = "comunicazioneBaseSocDetail1";
            this.comunicazioneBaseSocDetail1.PageCaption = "";
            this.comunicazioneBaseSocDetail1.ReadOnlyControls = true;
            this.comunicazioneBaseSocDetail1.Size = new System.Drawing.Size(332, 444);
            this.comunicazioneBaseSocDetail1.TabIndex = 0;
            // 
            // comunicazioneDetail1
            // 
            this.comunicazioneDetail1.ApplicationEngine = null;
            this.comunicazioneDetail1.ApplicationTitle = "";
            this.comunicazioneDetail1.ConfirmCancel = true;
            this.comunicazioneDetail1.ConfirmCancelMessage = "";
            this.comunicazioneDetail1.CurrentSequenceID = null;
            this.comunicazioneDetail1.CurrentTaskID = null;
            this.comunicazioneDetail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comunicazioneDetail1.IsShowing = false;
            this.comunicazioneDetail1.Location = new System.Drawing.Point(0, 0);
            this.comunicazioneDetail1.Name = "comunicazioneDetail1";
            this.comunicazioneDetail1.PageCaption = "";
            this.comunicazioneDetail1.ReadOnlyControls = true;
            this.comunicazioneDetail1.Size = new System.Drawing.Size(428, 444);
            this.comunicazioneDetail1.TabIndex = 0;
            // 
            // BaseCaricheDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "BaseCaricheDetail";
            this.Size = new System.Drawing.Size(766, 468);
            this.SizeChanged += new System.EventHandler(this.PositionAndBase_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.PanelTop)).EndInit();
            this.PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelBottom)).EndInit();
            this.PanelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.PositionAndBase.ComunicazioneBaseSoc.ComunicazioneBaseSocDetail comunicazioneBaseSocDetail1;
        private it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.PositionAndBase.ComunicazioneCaricaSoc.ComunicazioneDetail comunicazioneDetail1;

    }
}
