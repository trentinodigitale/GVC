namespace it.dedagroup.GVC.Client.Forms.Vocabolari
{
    partial class CadenzaRevisioneEdit
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
            this.bindingSourceBaseDizionario = new OeF.Forms.BindingSourceBase(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.checkEditAttivo = new DevExpress.XtraEditors.CheckEdit();
            this.ErrorProviderDizionario = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.bindingSourceBaseDettaglio = new OeF.Forms.BindingSourceBase(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseDizionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditAttivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderDizionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseDettaglio)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelButtons
            // 
            this.PanelButtons.Location = new System.Drawing.Point(0, 192);
            this.PanelButtons.Size = new System.Drawing.Size(443, 40);
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.labelControl2);
            this.ScrollableContent.Controls.Add(this.checkEditAttivo);
            this.ScrollableContent.Controls.Add(this.labelControl1);
            this.ScrollableContent.Controls.Add(this.memoEdit1);
            this.ScrollableContent.Controls.Add(this.labelControl3);
            this.ScrollableContent.Controls.Add(this.textEdit2);
            this.ScrollableContent.Size = new System.Drawing.Size(443, 232);
            this.ScrollableContent.Controls.SetChildIndex(this.textEdit2, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.PanelButtons, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl3, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.memoEdit1, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl1, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.checkEditAttivo, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl2, 0);
            // 
            // bindingSourceBaseDizionario
            // 
            this.bindingSourceBaseDizionario.AutoCreateObjects = false;
            this.bindingSourceBaseDizionario.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(99, 90);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Anni frequenza";
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseDettaglio, "Tempi", true));
            this.textEdit2.Location = new System.Drawing.Point(92, 105);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(87, 20);
            this.textEdit2.TabIndex = 9;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Descrizione";
            // 
            // memoEdit1
            // 
            this.memoEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseDizionario, "Descrizione", true));
            this.ErrorProviderDizionario.SetErrorType(this.memoEdit1, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.memoEdit1.Location = new System.Drawing.Point(92, 33);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.MaxLength = 250;
            this.memoEdit1.Size = new System.Drawing.Size(319, 47);
            this.memoEdit1.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(45, 90);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Attivo";
            // 
            // checkEditAttivo
            // 
            this.checkEditAttivo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseDizionario, "Attivo", true));
            this.ErrorProviderDizionario.SetErrorType(this.checkEditAttivo, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.checkEditAttivo.Location = new System.Drawing.Point(50, 106);
            this.checkEditAttivo.Name = "checkEditAttivo";
            this.checkEditAttivo.Properties.Caption = "";
            this.checkEditAttivo.Size = new System.Drawing.Size(22, 19);
            this.checkEditAttivo.TabIndex = 12;
            // 
            // ErrorProviderDizionario
            // 
            this.ErrorProviderDizionario.ContainerControl = this;
            this.ErrorProviderDizionario.DataSource = this.bindingSourceBaseDizionario;
            // 
            // bindingSourceBaseDettaglio
            // 
            this.bindingSourceBaseDettaglio.AutoCreateObjects = true;
            this.bindingSourceBaseDettaglio.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DettaglioDizionarioFDT);
            // 
            // CadenzaRevisioneEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CadenzaRevisioneEdit";
            this.Size = new System.Drawing.Size(443, 256);
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            this.ScrollableContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseDizionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditAttivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderDizionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseDettaglio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OeF.Forms.BindingSourceBase bindingSourceBaseDizionario;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit checkEditAttivo;
        public DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ErrorProviderDizionario;
        private OeF.Forms.BindingSourceBase bindingSourceBaseDettaglio;
    }
}
