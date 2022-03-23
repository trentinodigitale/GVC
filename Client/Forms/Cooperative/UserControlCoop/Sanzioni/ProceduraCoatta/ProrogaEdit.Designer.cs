namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Sanzioni.ProceduraCoatta
{
    partial class ProrogaEdit
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
            this.labelControl1 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.labelControl8 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.textEdit1 = new it.dedagroup.GVC.Client.Forms.Controls.TextEdit();
            this.bindingSourceExtensions = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.dateEdit2 = new it.dedagroup.GVC.Client.Forms.Controls.DateEdit();
            this.dateEdit3 = new it.dedagroup.GVC.Client.Forms.Controls.DateEdit();
            this.labelControl10 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.textEdit2 = new it.dedagroup.GVC.Client.Forms.Controls.TextEdit();
            this.dateEdit1 = new it.dedagroup.GVC.Client.Forms.Controls.DateEdit();
            this.labelControl2 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceExtensions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit3.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelButtons
            // 
            this.PanelButtons.Location = new System.Drawing.Point(0, 127);
            this.PanelButtons.Size = new System.Drawing.Size(307, 40);
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.dateEdit1);
            this.ScrollableContent.Controls.Add(this.labelControl2);
            this.ScrollableContent.Controls.Add(this.dateEdit2);
            this.ScrollableContent.Controls.Add(this.textEdit1);
            this.ScrollableContent.Controls.Add(this.labelControl8);
            this.ScrollableContent.Controls.Add(this.dateEdit3);
            this.ScrollableContent.Controls.Add(this.labelControl10);
            this.ScrollableContent.Controls.Add(this.labelControl1);
            this.ScrollableContent.Controls.Add(this.textEdit2);
            this.ScrollableContent.Size = new System.Drawing.Size(307, 167);
            this.ScrollableContent.Controls.SetChildIndex(this.textEdit2, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl1, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl10, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.dateEdit3, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl8, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.textEdit1, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.dateEdit2, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.PanelButtons, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl2, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.dateEdit1, 0);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(102, 13);
            this.labelControl1.TabIndex = 69;
            this.labelControl1.Text = "Dati della proroga";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(79, 71);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(49, 13);
            this.labelControl8.TabIndex = 70;
            this.labelControl8.Text = "Determina";
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceExtensions, "NumeroDetermina", true));
            this.textEdit1.Location = new System.Drawing.Point(134, 68);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(57, 20);
            this.textEdit1.TabIndex = 71;
            // 
            // bindingSourceExtensions
            // 
            this.bindingSourceExtensions.AutoCreateObjects = false;
            this.bindingSourceExtensions.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.ProrogaFDT);
            // 
            // dateEdit2
            // 
            this.dateEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceExtensions, "DataDetermina", true));
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(197, 68);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit2.Size = new System.Drawing.Size(100, 20);
            this.dateEdit2.TabIndex = 73;
            // 
            // dateEdit3
            // 
            this.dateEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceExtensions, "DataDeliberaCommissione", true));
            this.dateEdit3.EditValue = null;
            this.dateEdit3.Location = new System.Drawing.Point(197, 94);
            this.dateEdit3.Name = "dateEdit3";
            this.dateEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dateEdit3.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit3.Size = new System.Drawing.Size(100, 20);
            this.dateEdit3.TabIndex = 77;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(27, 97);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(101, 13);
            this.labelControl10.TabIndex = 74;
            this.labelControl10.Text = "Delibera commissione";
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceExtensions, "NumeroDeliberaCommissione", true));
            this.textEdit2.Location = new System.Drawing.Point(134, 94);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(57, 20);
            this.textEdit2.TabIndex = 75;
            // 
            // dateEdit1
            // 
            this.dateEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceExtensions, "DataProroga", true));
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(134, 42);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(100, 20);
            this.dateEdit1.TabIndex = 70;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(105, 45);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(23, 13);
            this.labelControl2.TabIndex = 78;
            this.labelControl2.Text = "Data";
            // 
            // ProrogaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ProrogaEdit";
            this.Size = new System.Drawing.Size(307, 191);
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            this.ScrollableContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceExtensions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit3.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl1;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl8;
        private it.dedagroup.GVC.Client.Forms.Controls.TextEdit textEdit1;
        private it.dedagroup.GVC.Client.Forms.Controls.DateEdit dateEdit2;
        private it.dedagroup.GVC.Client.Forms.Controls.DateEdit dateEdit3;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl10;
        private it.dedagroup.GVC.Client.Forms.Controls.TextEdit textEdit2;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceExtensions;
        private it.dedagroup.GVC.Client.Forms.Controls.DateEdit dateEdit1;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl2;
    }
}
