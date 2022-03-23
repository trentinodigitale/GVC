namespace it.dedagroup.GVC.Client.Forms.Vocabolari
{
    partial class DizionarioEdit
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
            this.checkEditAttivo = new DevExpress.XtraEditors.CheckEdit();
            this.bindingSourceBaseDizionario = new OeF.Forms.BindingSourceBase(this.components);
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.panelControlCodice = new DevExpress.XtraEditors.PanelControl();
            this.panelControlAltroFlag = new DevExpress.XtraEditors.PanelControl();
            this.checkEditAltroFlag = new DevExpress.XtraEditors.CheckEdit();
            this.lblAltroFlag = new DevExpress.XtraEditors.LabelControl();
            this.ErrorProviderDizionario = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditAttivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseDizionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlCodice)).BeginInit();
            this.panelControlCodice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlAltroFlag)).BeginInit();
            this.panelControlAltroFlag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditAltroFlag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderDizionario)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelButtons
            // 
            this.PanelButtons.Location = new System.Drawing.Point(0, 143);
            this.PanelButtons.Size = new System.Drawing.Size(424, 40);
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.panelControlAltroFlag);
            this.ScrollableContent.Controls.Add(this.panelControlCodice);
            this.ScrollableContent.Controls.Add(this.lblTitle);
            this.ScrollableContent.Controls.Add(this.labelControl1);
            this.ScrollableContent.Controls.Add(this.labelControl2);
            this.ScrollableContent.Controls.Add(this.memoEdit1);
            this.ScrollableContent.Controls.Add(this.checkEditAttivo);
            this.ScrollableContent.Size = new System.Drawing.Size(424, 183);
            this.ScrollableContent.Controls.SetChildIndex(this.checkEditAttivo, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.memoEdit1, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl2, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl1, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.PanelButtons, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.lblTitle, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.panelControlCodice, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.panelControlAltroFlag, 0);
            // 
            // checkEditAttivo
            // 
            this.checkEditAttivo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseDizionario, "Attivo", true));
            this.ErrorProviderDizionario.SetErrorType(this.checkEditAttivo, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.checkEditAttivo.Location = new System.Drawing.Point(49, 111);
            this.checkEditAttivo.Name = "checkEditAttivo";
            this.checkEditAttivo.Properties.Caption = "";
            this.checkEditAttivo.Size = new System.Drawing.Size(22, 19);
            this.checkEditAttivo.TabIndex = 1;
            // 
            // bindingSourceBaseDizionario
            // 
            this.bindingSourceBaseDizionario.AutoCreateObjects = false;
            this.bindingSourceBaseDizionario.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // memoEdit1
            // 
            this.memoEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseDizionario, "Descrizione", true));
            this.ErrorProviderDizionario.SetErrorType(this.memoEdit1, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.memoEdit1.Location = new System.Drawing.Point(91, 32);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.MaxLength = 250;
            this.memoEdit1.Size = new System.Drawing.Size(319, 47);
            this.memoEdit1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(31, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Descrizione";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(44, 95);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Attivo";
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseDizionario, "Codice", true));
            this.ErrorProviderDizionario.SetErrorType(this.textEdit1, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.textEdit1.Location = new System.Drawing.Point(6, 18);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(119, 20);
            this.textEdit1.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(48, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(32, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Codice";
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.Location = new System.Drawing.Point(18, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 13);
            this.lblTitle.TabIndex = 7;
            // 
            // panelControlCodice
            // 
            this.panelControlCodice.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControlCodice.Controls.Add(this.labelControl4);
            this.panelControlCodice.Controls.Add(this.textEdit1);
            this.panelControlCodice.Location = new System.Drawing.Point(130, 93);
            this.panelControlCodice.Name = "panelControlCodice";
            this.panelControlCodice.Size = new System.Drawing.Size(130, 40);
            this.panelControlCodice.TabIndex = 8;
            // 
            // panelControlAltroFlag
            // 
            this.panelControlAltroFlag.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControlAltroFlag.Controls.Add(this.checkEditAltroFlag);
            this.panelControlAltroFlag.Controls.Add(this.lblAltroFlag);
            this.panelControlAltroFlag.Location = new System.Drawing.Point(280, 91);
            this.panelControlAltroFlag.Name = "panelControlAltroFlag";
            this.panelControlAltroFlag.Size = new System.Drawing.Size(130, 40);
            this.panelControlAltroFlag.TabIndex = 9;
            // 
            // checkEditAltroFlag
            // 
            this.checkEditAltroFlag.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseDizionario, "Flag", true));
            this.ErrorProviderDizionario.SetErrorType(this.checkEditAltroFlag, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.checkEditAltroFlag.Location = new System.Drawing.Point(52, 18);
            this.checkEditAltroFlag.Name = "checkEditAltroFlag";
            this.checkEditAltroFlag.Properties.Caption = "";
            this.checkEditAltroFlag.Size = new System.Drawing.Size(22, 19);
            this.checkEditAltroFlag.TabIndex = 3;
            // 
            // lblAltroFlag
            // 
            this.lblAltroFlag.Location = new System.Drawing.Point(45, 3);
            this.lblAltroFlag.Name = "lblAltroFlag";
            this.lblAltroFlag.Size = new System.Drawing.Size(0, 13);
            this.lblAltroFlag.TabIndex = 4;
            // 
            // ErrorProviderDizionario
            // 
            this.ErrorProviderDizionario.ContainerControl = this;
            this.ErrorProviderDizionario.DataSource = this.bindingSourceBaseDizionario;
            // 
            // DizionarioEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "DizionarioEdit";
            this.Size = new System.Drawing.Size(424, 207);
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            this.ScrollableContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditAttivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseDizionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlCodice)).EndInit();
            this.panelControlCodice.ResumeLayout(false);
            this.panelControlCodice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlAltroFlag)).EndInit();
            this.panelControlAltroFlag.ResumeLayout(false);
            this.panelControlAltroFlag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditAltroFlag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderDizionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.CheckEdit checkEditAttivo;
        private DevExpress.XtraEditors.PanelControl panelControlAltroFlag;
        private DevExpress.XtraEditors.LabelControl lblAltroFlag;
        private DevExpress.XtraEditors.PanelControl panelControlCodice;
        private OeF.Forms.BindingSourceBase bindingSourceBaseDizionario;
        private DevExpress.XtraEditors.CheckEdit checkEditAltroFlag;
        public DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ErrorProviderDizionario;
    }
}
