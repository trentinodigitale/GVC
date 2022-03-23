namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.BaseCariche.ComunicazioneCaricaSoc
{
    partial class ComunicazioneEdit
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
            this.bindingSourceCommunicazioni = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.dateEdit2 = new it.dedagroup.GVC.Client.Forms.Controls.DateEdit();
            this.dateEdit1 = new it.dedagroup.GVC.Client.Forms.Controls.DateEdit();
            this.labelControl1 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.labelControl3 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.labelControl2 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.labelControl10 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.dateEdit3 = new it.dedagroup.GVC.Client.Forms.Controls.DateEdit();
            this.textEdit11 = new it.dedagroup.GVC.Client.Forms.Controls.TextEdit();
            this.memoEdit1 = new OeF.Forms.Controls.MemoEdit();
            this.labelControl22 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.ErrorProviderComunicazioni = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.chckRetrieveCariche = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            this.PanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCommunicazioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit3.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit11.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderComunicazioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chckRetrieveCariche.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.TabIndex = 7;
            // 
            // OK
            // 
            this.OK.TabIndex = 6;
            // 
            // PanelButtons
            // 
            this.PanelButtons.Controls.Add(this.chckRetrieveCariche);
            this.PanelButtons.Location = new System.Drawing.Point(0, 193);
            this.PanelButtons.Size = new System.Drawing.Size(538, 40);
            this.PanelButtons.Controls.SetChildIndex(this.chckRetrieveCariche, 0);
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.memoEdit1);
            this.ScrollableContent.Controls.Add(this.labelControl22);
            this.ScrollableContent.Controls.Add(this.labelControl10);
            this.ScrollableContent.Controls.Add(this.dateEdit3);
            this.ScrollableContent.Controls.Add(this.textEdit11);
            this.ScrollableContent.Controls.Add(this.dateEdit2);
            this.ScrollableContent.Controls.Add(this.dateEdit1);
            this.ScrollableContent.Controls.Add(this.labelControl1);
            this.ScrollableContent.Controls.Add(this.labelControl3);
            this.ScrollableContent.Controls.Add(this.labelControl2);
            this.ScrollableContent.Size = new System.Drawing.Size(538, 233);
            this.ScrollableContent.Controls.SetChildIndex(this.PanelButtons, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl2, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl3, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl1, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.dateEdit1, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.dateEdit2, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.textEdit11, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.dateEdit3, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl10, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl22, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.memoEdit1, 0);
            // 
            // bindingSourceCommunicazioni
            // 
            this.bindingSourceCommunicazioni.AutoCreateObjects = false;
            this.bindingSourceCommunicazioni.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.ComunicazioneCaricaSocialeFDT);
            // 
            // dateEdit2
            // 
            this.dateEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceCommunicazioni, "DataComunicazione", true));
            this.dateEdit2.EditValue = null;
            this.ErrorProviderComunicazioni.SetErrorType(this.dateEdit2, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.dateEdit2.Location = new System.Drawing.Point(119, 31);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit2.Size = new System.Drawing.Size(100, 20);
            this.dateEdit2.TabIndex = 1;
            // 
            // dateEdit1
            // 
            this.dateEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceCommunicazioni, "DataSituazione", true));
            this.dateEdit1.EditValue = null;
            this.ErrorProviderComunicazioni.SetErrorType(this.dateEdit1, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.dateEdit1.Location = new System.Drawing.Point(351, 31);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(100, 20);
            this.dateEdit1.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(225, 13);
            this.labelControl1.TabIndex = 37;
            this.labelControl1.Text = "Dati della comunicazione cariche sociali";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(271, 34);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(74, 13);
            this.labelControl3.TabIndex = 39;
            this.labelControl3.Text = "Data situazione";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(18, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(95, 13);
            this.labelControl2.TabIndex = 38;
            this.labelControl2.Text = "Data comunicazione";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(12, 70);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(97, 13);
            this.labelControl10.TabIndex = 53;
            this.labelControl10.Text = "Certificato antimafia";
            // 
            // dateEdit3
            // 
            this.dateEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceCommunicazioni, "DataComunicazioneAntimafia", true));
            this.dateEdit3.EditValue = null;
            this.ErrorProviderComunicazioni.SetErrorType(this.dateEdit3, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.dateEdit3.Location = new System.Drawing.Point(194, 67);
            this.dateEdit3.Name = "dateEdit3";
            this.dateEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dateEdit3.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit3.Size = new System.Drawing.Size(100, 20);
            this.dateEdit3.TabIndex = 4;
            // 
            // textEdit11
            // 
            this.textEdit11.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceCommunicazioni, "NumeroProtocolloAntimafia", true));
            this.ErrorProviderComunicazioni.SetErrorType(this.textEdit11, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.textEdit11.Location = new System.Drawing.Point(119, 67);
            this.textEdit11.Name = "textEdit11";
            this.textEdit11.Properties.MaxLength = 50;
            this.textEdit11.Size = new System.Drawing.Size(69, 20);
            this.textEdit11.TabIndex = 3;
            // 
            // memoEdit1
            // 
            this.memoEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceCommunicazioni, "Note", true));
            this.ErrorProviderComunicazioni.SetErrorType(this.memoEdit1, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.memoEdit1.Location = new System.Drawing.Point(119, 106);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.MaxLength = 1000;
            this.memoEdit1.Size = new System.Drawing.Size(407, 71);
            this.memoEdit1.TabIndex = 5;
            // 
            // labelControl22
            // 
            this.labelControl22.Location = new System.Drawing.Point(90, 106);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(23, 13);
            this.labelControl22.TabIndex = 57;
            this.labelControl22.Text = "Note";
            // 
            // ErrorProviderComunicazioni
            // 
            this.ErrorProviderComunicazioni.ContainerControl = this;
            this.ErrorProviderComunicazioni.DataSource = this.bindingSourceCommunicazioni;
            // 
            // chckRetrieveCariche
            // 
            this.chckRetrieveCariche.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceCommunicazioni, "RetrieveCaricheFromParix", true));
            this.chckRetrieveCariche.Location = new System.Drawing.Point(10, 11);
            this.chckRetrieveCariche.Name = "chckRetrieveCariche";
            this.chckRetrieveCariche.Properties.Caption = "Recupera cariche da Parix";
            this.chckRetrieveCariche.Size = new System.Drawing.Size(150, 19);
            this.chckRetrieveCariche.TabIndex = 2;
           
            // 
            // ComunicazioneEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ComunicazioneEdit";
            this.Size = new System.Drawing.Size(538, 257);
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            this.PanelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            this.ScrollableContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCommunicazioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit3.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit11.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderComunicazioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chckRetrieveCariche.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceCommunicazioni;
        private it.dedagroup.GVC.Client.Forms.Controls.DateEdit dateEdit2;
        private it.dedagroup.GVC.Client.Forms.Controls.DateEdit dateEdit1;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl1;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl3;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl2;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl10;
        private it.dedagroup.GVC.Client.Forms.Controls.DateEdit dateEdit3;
        private it.dedagroup.GVC.Client.Forms.Controls.TextEdit textEdit11;
        private OeF.Forms.Controls.MemoEdit memoEdit1;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl22;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ErrorProviderComunicazioni;
        private DevExpress.XtraEditors.CheckEdit chckRetrieveCariche;
    }
}
