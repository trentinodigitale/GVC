namespace it.dedagroup.GVC.Client.Forms.Aggiornamenti
{
    partial class InfoDlg
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
            this.txaMessage = new DevExpress.XtraEditors.MemoEdit();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txaMessage.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.btnOk);
            this.ScrollableContent.Controls.Add(this.txaMessage);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 24);
            this.ScrollableContent.Size = new System.Drawing.Size(447, 163);
            // 
            // txaMessage
            // 
            this.txaMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txaMessage.EditValue = "";
            this.txaMessage.Location = new System.Drawing.Point(3, 3);
            this.txaMessage.Name = "txaMessage";
            this.txaMessage.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txaMessage.Properties.Appearance.Options.UseForeColor = true;
            this.txaMessage.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txaMessage.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txaMessage.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black;
            this.txaMessage.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.txaMessage.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black;
            this.txaMessage.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txaMessage.Properties.ReadOnly = true;
            this.txaMessage.Size = new System.Drawing.Size(440, 132);
            this.txaMessage.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(369, 138);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // InfoDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "InfoDlg";
            this.Size = new System.Drawing.Size(447, 187);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txaMessage.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.MemoEdit txaMessage;
    }
}
