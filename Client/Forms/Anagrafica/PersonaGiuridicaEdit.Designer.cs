namespace it.dedagroup.GVC.Client.Forms.Registry
{
    partial class PersonaGiuridicaEdit
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
            this.labelControl6 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.checkEditAssociation = new it.dedagroup.GVC.Client.Forms.Controls.CheckEdit();
            this.bindingSourceBasePersonaGiuridica = new OeF.Forms.BindingSourceBase(this.components);
            this.labelControl1 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.memoEdit1 = new OeF.Forms.Controls.MemoEdit();
            this.labelControl3 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.textEdit1 = new OeF.Forms.Controls.TextEdit();
            this.Denomination = new OeF.Forms.Controls.MemoEdit();
            this.labelControl2 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.ErrorProviderPersonaGiuridica = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.labelControl4 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditAssociation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBasePersonaGiuridica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Denomination.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderPersonaGiuridica)).BeginInit();
            this.SuspendLayout();
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.labelControl4);
            this.ScrollableContent.Controls.Add(this.textEdit1);
            this.ScrollableContent.Controls.Add(this.labelControl2);
            this.ScrollableContent.Controls.Add(this.memoEdit1);
            this.ScrollableContent.Controls.Add(this.Denomination);
            this.ScrollableContent.Controls.Add(this.checkEditAssociation);
            this.ScrollableContent.Controls.Add(this.labelControl1);
            this.ScrollableContent.Controls.Add(this.labelControl3);
            this.ScrollableContent.Controls.Add(this.labelControl6);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 24);
            this.ScrollableContent.Size = new System.Drawing.Size(419, 160);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(30, 15);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(54, 13);
            this.labelControl6.TabIndex = 58;
            this.labelControl6.Text = "Descrizione";
            // 
            // checkEditAssociation
            // 
            this.checkEditAssociation.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBasePersonaGiuridica, "Associazione", true));
            this.ErrorProviderPersonaGiuridica.SetErrorType(this.checkEditAssociation, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.checkEditAssociation.Location = new System.Drawing.Point(385, 68);
            this.checkEditAssociation.Name = "checkEditAssociation";
            this.checkEditAssociation.Properties.Caption = "";
            this.checkEditAssociation.Size = new System.Drawing.Size(22, 19);
            this.checkEditAssociation.TabIndex = 3;
            // 
            // bindingSourceBasePersonaGiuridica
            // 
            this.bindingSourceBasePersonaGiuridica.AutoCreateObjects = false;
            this.bindingSourceBasePersonaGiuridica.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.PersonaGiuridicaFDT);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(304, 65);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 60;
            this.labelControl1.Text = "Associazione";
            // 
            // memoEdit1
            // 
            this.memoEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBasePersonaGiuridica, "Denominazione", true));
            this.ErrorProviderPersonaGiuridica.SetErrorType(this.memoEdit1, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.memoEdit1.Location = new System.Drawing.Point(90, 13);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.AcceptsReturn = false;
            this.memoEdit1.Properties.MaxLength = 500;
            this.memoEdit1.Size = new System.Drawing.Size(319, 48);
            this.memoEdit1.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(19, 73);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 13);
            this.labelControl3.TabIndex = 58;
            this.labelControl3.Text = "Codice fiscale";
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBasePersonaGiuridica, "CodiceFiscale", true));
            this.ErrorProviderPersonaGiuridica.SetErrorType(this.textEdit1, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.textEdit1.Location = new System.Drawing.Point(90, 70);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.MaxLength = 16;
            this.textEdit1.Size = new System.Drawing.Size(152, 20);
            this.textEdit1.TabIndex = 2;
            // 
            // Denomination
            // 
            this.Denomination.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBasePersonaGiuridica, "Note", true));
            this.ErrorProviderPersonaGiuridica.SetErrorType(this.Denomination, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.Denomination.Location = new System.Drawing.Point(90, 98);
            this.Denomination.Name = "Denomination";
            this.Denomination.Properties.AcceptsReturn = false;
            this.Denomination.Properties.MaxLength = 1000;
            this.Denomination.Size = new System.Drawing.Size(319, 48);
            this.Denomination.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(61, 101);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(23, 13);
            this.labelControl2.TabIndex = 63;
            this.labelControl2.Text = "Note";
            // 
            // ErrorProviderPersonaGiuridica
            // 
            this.ErrorProviderPersonaGiuridica.ContainerControl = this;
            this.ErrorProviderPersonaGiuridica.DataSource = this.bindingSourceBasePersonaGiuridica;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(294, 77);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(87, 13);
            this.labelControl4.TabIndex = 64;
            this.labelControl4.Text = "di rappresentanza";
            // 
            // PersonaGiuridicaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "PersonaGiuridicaEdit";
            this.Size = new System.Drawing.Size(419, 184);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            this.ScrollableContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditAssociation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBasePersonaGiuridica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Denomination.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderPersonaGiuridica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl6;
        private it.dedagroup.GVC.Client.Forms.Controls.CheckEdit checkEditAssociation;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl1;
        private OeF.Forms.Controls.TextEdit textEdit1;
        private OeF.Forms.Controls.MemoEdit memoEdit1;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl3;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl2;
        private OeF.Forms.Controls.MemoEdit Denomination;
        private OeF.Forms.BindingSourceBase bindingSourceBasePersonaGiuridica;
        public DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ErrorProviderPersonaGiuridica;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl4;
    }
}
