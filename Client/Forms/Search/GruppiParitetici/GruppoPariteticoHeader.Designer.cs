namespace it.dedagroup.GVC.Client.Forms.Search.GruppiParitetici
{
    partial class GruppoPariteticoHeader
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
            this.memoEditNote = new DevExpress.XtraEditors.MemoEdit();
            this.bindingSourceGruppoParitetico = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.dateEditdataAtto = new it.dedagroup.GVC.Client.Forms.Controls.DateEdit();
            this.textEditNumeroAtto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.dateEditTill = new it.dedagroup.GVC.Client.Forms.Controls.DateEdit();
            this.ErrorProviderGruppoParitetico = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGruppoParitetico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditdataAtto.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditdataAtto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNumeroAtto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTill.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTill.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderGruppoParitetico)).BeginInit();
            this.SuspendLayout();
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.memoEditNote);
            this.ScrollableContent.Controls.Add(this.labelControl3);
            this.ScrollableContent.Controls.Add(this.dateEditTill);
            this.ScrollableContent.Controls.Add(this.textEditNumeroAtto);
            this.ScrollableContent.Controls.Add(this.labelControl1);
            this.ScrollableContent.Controls.Add(this.labelControl2);
            this.ScrollableContent.Controls.Add(this.dateEditdataAtto);
            this.ScrollableContent.Controls.Add(this.labelControl4);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 24);
            this.ScrollableContent.Size = new System.Drawing.Size(846, 61);
            // 
            // memoEditNote
            // 
            this.memoEditNote.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceGruppoParitetico, "Note", true));
            this.ErrorProviderGruppoParitetico.SetErrorType(this.memoEditNote, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.memoEditNote.Location = new System.Drawing.Point(556, 3);
            this.memoEditNote.Name = "memoEditNote";
            this.memoEditNote.Size = new System.Drawing.Size(289, 50);
            this.memoEditNote.TabIndex = 3;
            // 
            // bindingSourceGruppoParitetico
            // 
            this.bindingSourceGruppoParitetico.AutoCreateObjects = false;
            this.bindingSourceGruppoParitetico.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.GruppoPariteticoFDT);
            // 
            // dateEditdataAtto
            // 
            this.dateEditdataAtto.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceGruppoParitetico, "DataAtto", true));
            this.dateEditdataAtto.EditValue = null;
            this.ErrorProviderGruppoParitetico.SetErrorType(this.dateEditdataAtto, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.dateEditdataAtto.Location = new System.Drawing.Point(139, 33);
            this.dateEditdataAtto.Name = "dateEditdataAtto";
            this.dateEditdataAtto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditdataAtto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dateEditdataAtto.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEditdataAtto.Size = new System.Drawing.Size(100, 20);
            this.dateEditdataAtto.TabIndex = 1;
            // 
            // textEditNumeroAtto
            // 
            this.textEditNumeroAtto.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceGruppoParitetico, "NumeroAtto", true));
            this.ErrorProviderGruppoParitetico.SetErrorType(this.textEditNumeroAtto, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.textEditNumeroAtto.Location = new System.Drawing.Point(139, 3);
            this.textEditNumeroAtto.Name = "textEditNumeroAtto";
            this.textEditNumeroAtto.Size = new System.Drawing.Size(100, 20);
            this.textEditNumeroAtto.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(525, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(23, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Note";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(20, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(101, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Data atto riferimento";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(115, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Numero atto riferimento";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(271, 6);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(119, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Durata del gruppo fino al";
            // 
            // dateEditTill
            // 
            this.dateEditTill.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceGruppoParitetico, "DataFine", true));
            this.dateEditTill.EditValue = null;
            this.ErrorProviderGruppoParitetico.SetErrorType(this.dateEditTill, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.dateEditTill.Location = new System.Drawing.Point(396, 3);
            this.dateEditTill.Name = "dateEditTill";
            this.dateEditTill.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditTill.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dateEditTill.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEditTill.Size = new System.Drawing.Size(100, 20);
            this.dateEditTill.TabIndex = 2;
            // 
            // ErrorProviderGruppoParitetico
            // 
            this.ErrorProviderGruppoParitetico.ContainerControl = this;
            this.ErrorProviderGruppoParitetico.DataSource = this.bindingSourceGruppoParitetico;
            // 
            // GruppoPariteticoHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "GruppoPariteticoHeader";
            this.Size = new System.Drawing.Size(846, 85);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            this.ScrollableContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGruppoParitetico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditdataAtto.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditdataAtto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNumeroAtto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTill.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTill.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderGruppoParitetico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit memoEditNote;
        private it.dedagroup.GVC.Client.Forms.Controls.DateEdit dateEditdataAtto;
        private DevExpress.XtraEditors.TextEdit textEditNumeroAtto;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceGruppoParitetico;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl4;
        private it.dedagroup.GVC.Client.Forms.Controls.DateEdit dateEditTill;
        public DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ErrorProviderGruppoParitetico;
    }
}
