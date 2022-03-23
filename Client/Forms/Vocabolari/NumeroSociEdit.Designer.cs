namespace it.dedagroup.GVC.Client.Forms.Vocabolari
{
    partial class NumeroSociEdit
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
            this.bindingSourceBaseNumeroSoci = new OeF.Forms.BindingSourceBase(this.components);
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.ErrorProviderDizionario = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.lblParent = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseNumeroSoci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderDizionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelButtons
            // 
            this.PanelButtons.Location = new System.Drawing.Point(0, 171);
            this.PanelButtons.Size = new System.Drawing.Size(382, 40);
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.labelControl3);
            this.ScrollableContent.Controls.Add(this.labelControl4);
            this.ScrollableContent.Controls.Add(this.textEdit2);
            this.ScrollableContent.Controls.Add(this.textEdit1);
            this.ScrollableContent.Controls.Add(this.lblTitle);
            this.ScrollableContent.Controls.Add(this.lblParent);
            this.ScrollableContent.Controls.Add(this.labelControl1);
            this.ScrollableContent.Controls.Add(this.memoEdit1);
            this.ScrollableContent.Size = new System.Drawing.Size(382, 211);
            this.ScrollableContent.Controls.SetChildIndex(this.memoEdit1, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl1, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.lblParent, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.PanelButtons, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.lblTitle, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.textEdit1, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.textEdit2, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl4, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl3, 0);
            // 
            // bindingSourceBaseNumeroSoci
            // 
            this.bindingSourceBaseNumeroSoci.AutoCreateObjects = false;
            this.bindingSourceBaseNumeroSoci.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.ControlloNumeroSociFDT);
            // 
            // memoEdit1
            // 
            this.memoEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseNumeroSoci, "Note", true));
            this.memoEdit1.Location = new System.Drawing.Point(95, 116);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.MaxLength = 250;
            this.memoEdit1.Size = new System.Drawing.Size(255, 47);
            this.memoEdit1.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(66, 119);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Note";
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseNumeroSoci, "ValMax", true));
            this.textEdit1.Location = new System.Drawing.Point(95, 90);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(87, 20);
            this.textEdit1.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 93);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Valore massimo";
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
            // ErrorProviderDizionario
            // 
            this.ErrorProviderDizionario.ContainerControl = this;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(24, 67);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Valore minimo";
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseNumeroSoci, "ValMin", true));
            this.textEdit2.Location = new System.Drawing.Point(95, 64);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(87, 20);
            this.textEdit2.TabIndex = 0;
            // 
            // lblParent
            // 
            this.lblParent.Location = new System.Drawing.Point(24, 33);
            this.lblParent.Name = "lblParent";
            this.lblParent.Size = new System.Drawing.Size(0, 13);
            this.lblParent.TabIndex = 4;
            // 
            // NumeroSociEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "NumeroSociEdit";
            this.Size = new System.Drawing.Size(382, 235);
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            this.ScrollableContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseNumeroSoci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderDizionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private OeF.Forms.BindingSourceBase bindingSourceBaseNumeroSoci;
        public DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ErrorProviderDizionario;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl lblParent;
    }
}
