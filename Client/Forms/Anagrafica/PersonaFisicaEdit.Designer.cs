namespace it.dedagroup.GVC.Client.Forms.Registry
{
    partial class PersonaFisicaEdit
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
            this.Nome = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.textEdit1 = new it.dedagroup.GVC.Client.Forms.Controls.TextEdit();
            this.bindingSourcePersonaFisica = new OeF.Forms.BindingSourceBase(this.components);
            this.labelControl1 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.labelControl3 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.textEdit5 = new it.dedagroup.GVC.Client.Forms.Controls.TextEdit();
            this.labelControl4 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.textEdit6 = new it.dedagroup.GVC.Client.Forms.Controls.TextEdit();
            this.labelControl5 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.dateEdit1 = new it.dedagroup.GVC.Client.Forms.Controls.DateEdit();
            this.labelControl2 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.radioGroup3 = new OeF.Forms.Controls.RadioGroup();
            this.labelControl6 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.labelControl10 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.textEdit2 = new it.dedagroup.GVC.Client.Forms.Controls.TextEdit();
            this.labelControl7 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.textEdit3 = new it.dedagroup.GVC.Client.Forms.Controls.TextEdit();
            this.textEdit4 = new it.dedagroup.GVC.Client.Forms.Controls.TextEdit();
            this.textEdit7 = new it.dedagroup.GVC.Client.Forms.Controls.TextEdit();
            this.labelControl8 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.textEdit8 = new it.dedagroup.GVC.Client.Forms.Controls.TextEdit();
            this.labelControl9 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.textEdit9 = new it.dedagroup.GVC.Client.Forms.Controls.TextEdit();
            this.labelControl11 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textEdit10 = new it.dedagroup.GVC.Client.Forms.Controls.TextEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelControl12 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.Note = new OeF.Forms.Controls.MemoEdit();
            this.ErrorProviderPersonaFisica = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePersonaFisica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit10.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Note.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderPersonaFisica)).BeginInit();
            this.SuspendLayout();
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.groupBox1);
            this.ScrollableContent.Controls.Add(this.groupBox2);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 24);
            this.ScrollableContent.Size = new System.Drawing.Size(572, 292);
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(47, 50);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(27, 13);
            this.Nome.TabIndex = 38;
            this.Nome.Text = "Nome";
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourcePersonaFisica, "Cognome", true));
            this.ErrorProviderPersonaFisica.SetError(this.textEdit1, " ");
            this.ErrorProviderPersonaFisica.SetErrorType(this.textEdit1, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.textEdit1.Location = new System.Drawing.Point(80, 21);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.MaxLength = 50;
            this.textEdit1.Size = new System.Drawing.Size(244, 20);
            this.textEdit1.TabIndex = 1;
            // 
            // bindingSourcePersonaFisica
            // 
            this.bindingSourcePersonaFisica.AutoCreateObjects = false;
            this.bindingSourcePersonaFisica.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.PersonaFisicaFDT);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 40;
            this.labelControl1.Text = "Cognome";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 20);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(90, 13);
            this.labelControl3.TabIndex = 44;
            this.labelControl3.Text = "Cognome acquisito";
            // 
            // textEdit5
            // 
            this.textEdit5.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourcePersonaFisica, "ComuneNascita", true));
            this.ErrorProviderPersonaFisica.SetErrorType(this.textEdit5, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.textEdit5.Location = new System.Drawing.Point(317, 43);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Properties.MaxLength = 250;
            this.textEdit5.Size = new System.Drawing.Size(244, 20);
            this.textEdit5.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(234, 46);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(77, 13);
            this.labelControl4.TabIndex = 46;
            this.labelControl4.Text = "Luogo di nascita";
            // 
            // textEdit6
            // 
            this.textEdit6.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourcePersonaFisica, "StatoNascita", true));
            this.ErrorProviderPersonaFisica.SetErrorType(this.textEdit6, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.textEdit6.Location = new System.Drawing.Point(109, 69);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Properties.MaxLength = 50;
            this.textEdit6.Size = new System.Drawing.Size(163, 20);
            this.textEdit6.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(29, 72);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(74, 13);
            this.labelControl5.TabIndex = 48;
            this.labelControl5.Text = "Stato di nascita";
            // 
            // dateEdit1
            // 
            this.dateEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourcePersonaFisica, "DataNascita", true));
            this.dateEdit1.EditValue = null;
            this.ErrorProviderPersonaFisica.SetErrorType(this.dateEdit1, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.dateEdit1.Location = new System.Drawing.Point(109, 43);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(100, 20);
            this.dateEdit1.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(32, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 13);
            this.labelControl2.TabIndex = 50;
            this.labelControl2.Text = "Data di nascita";
            // 
            // radioGroup3
            // 
            this.radioGroup3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourcePersonaFisica, "Sesso", true));
            this.ErrorProviderPersonaFisica.SetErrorType(this.radioGroup3, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.radioGroup3.Location = new System.Drawing.Point(300, 74);
            this.radioGroup3.Margin = new System.Windows.Forms.Padding(0);
            this.radioGroup3.Name = "radioGroup3";
            this.radioGroup3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroup3.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup3.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black;
            this.radioGroup3.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.radioGroup3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroup3.Properties.Columns = 2;
            this.radioGroup3.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("M", "Maschio"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("F", "Femmina")});
            this.radioGroup3.Size = new System.Drawing.Size(143, 17);
            this.radioGroup3.TabIndex = 4;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(268, 76);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(28, 13);
            this.labelControl6.TabIndex = 53;
            this.labelControl6.Text = "Sesso";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(289, 72);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(60, 13);
            this.labelControl10.TabIndex = 55;
            this.labelControl10.Text = "Cittadinanza";
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourcePersonaFisica, "Cellulare", true));
            this.ErrorProviderPersonaFisica.SetErrorType(this.textEdit2, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.textEdit2.Location = new System.Drawing.Point(225, 95);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.MaxLength = 25;
            this.textEdit2.Size = new System.Drawing.Size(100, 20);
            this.textEdit2.TabIndex = 12;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(178, 98);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(41, 13);
            this.labelControl7.TabIndex = 56;
            this.labelControl7.Text = "Cellulare";
            // 
            // textEdit3
            // 
            this.textEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourcePersonaFisica, "Nome", true));
            this.ErrorProviderPersonaFisica.SetErrorType(this.textEdit3, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.textEdit3.Location = new System.Drawing.Point(80, 47);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.MaxLength = 80;
            this.textEdit3.Size = new System.Drawing.Size(244, 20);
            this.textEdit3.TabIndex = 2;
            // 
            // textEdit4
            // 
            this.textEdit4.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourcePersonaFisica, "CognomeAcquisito", true));
            this.ErrorProviderPersonaFisica.SetError(this.textEdit4, " ");
            this.ErrorProviderPersonaFisica.SetErrorType(this.textEdit4, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.textEdit4.Location = new System.Drawing.Point(109, 17);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.MaxLength = 50;
            this.textEdit4.Size = new System.Drawing.Size(244, 20);
            this.textEdit4.TabIndex = 6;
            // 
            // textEdit7
            // 
            this.textEdit7.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourcePersonaFisica, "CodiceFiscale", true));
            this.ErrorProviderPersonaFisica.SetErrorType(this.textEdit7, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.textEdit7.Location = new System.Drawing.Point(80, 73);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Properties.MaxLength = 16;
            this.textEdit7.Size = new System.Drawing.Size(139, 20);
            this.textEdit7.TabIndex = 3;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(9, 76);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(65, 13);
            this.labelControl8.TabIndex = 60;
            this.labelControl8.Text = "Codice fiscale";
            // 
            // textEdit8
            // 
            this.textEdit8.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourcePersonaFisica, "Email", true));
            this.ErrorProviderPersonaFisica.SetErrorType(this.textEdit8, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.textEdit8.Location = new System.Drawing.Point(387, 95);
            this.textEdit8.Name = "textEdit8";
            this.textEdit8.Properties.MaxLength = 100;
            this.textEdit8.Size = new System.Drawing.Size(174, 20);
            this.textEdit8.TabIndex = 13;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(353, 98);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(28, 13);
            this.labelControl9.TabIndex = 64;
            this.labelControl9.Text = "E-Mail";
            // 
            // textEdit9
            // 
            this.textEdit9.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourcePersonaFisica, "Telefono", true));
            this.ErrorProviderPersonaFisica.SetErrorType(this.textEdit9, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.textEdit9.Location = new System.Drawing.Point(54, 95);
            this.textEdit9.Name = "textEdit9";
            this.textEdit9.Properties.MaxLength = 25;
            this.textEdit9.Size = new System.Drawing.Size(100, 20);
            this.textEdit9.TabIndex = 11;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(6, 98);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(42, 13);
            this.labelControl11.TabIndex = 62;
            this.labelControl11.Text = "Telefono";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.textEdit8);
            this.groupBox1.Controls.Add(this.textEdit4);
            this.groupBox1.Controls.Add(this.labelControl9);
            this.groupBox1.Controls.Add(this.labelControl10);
            this.groupBox1.Controls.Add(this.textEdit2);
            this.groupBox1.Controls.Add(this.textEdit9);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.labelControl11);
            this.groupBox1.Controls.Add(this.textEdit10);
            this.groupBox1.Controls.Add(this.textEdit6);
            this.groupBox1.Controls.Add(this.dateEdit1);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.textEdit5);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 135);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dati facoltativi";
            // 
            // textEdit10
            // 
            this.textEdit10.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourcePersonaFisica, "Cittadinanza", true));
            this.ErrorProviderPersonaFisica.SetErrorType(this.textEdit10, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.textEdit10.Location = new System.Drawing.Point(355, 69);
            this.textEdit10.Name = "textEdit10";
            this.textEdit10.Properties.MaxLength = 50;
            this.textEdit10.Size = new System.Drawing.Size(206, 20);
            this.textEdit10.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelControl12);
            this.groupBox2.Controls.Add(this.Note);
            this.groupBox2.Controls.Add(this.labelControl8);
            this.groupBox2.Controls.Add(this.textEdit7);
            this.groupBox2.Controls.Add(this.labelControl6);
            this.groupBox2.Controls.Add(this.textEdit3);
            this.groupBox2.Controls.Add(this.radioGroup3);
            this.groupBox2.Controls.Add(this.textEdit1);
            this.groupBox2.Controls.Add(this.Nome);
            this.groupBox2.Controls.Add(this.labelControl1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 153);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dati obbligatori";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(51, 102);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(23, 13);
            this.labelControl12.TabIndex = 65;
            this.labelControl12.Text = "Note";
            // 
            // Note
            // 
            this.Note.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourcePersonaFisica, "Note", true));
            this.ErrorProviderPersonaFisica.SetErrorType(this.Note, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.Note.Location = new System.Drawing.Point(80, 99);
            this.Note.Name = "Note";
            this.Note.Properties.AcceptsReturn = false;
            this.Note.Properties.MaxLength = 1000;
            this.Note.Size = new System.Drawing.Size(319, 48);
            this.Note.TabIndex = 5;
            // 
            // ErrorProviderPersonaFisica
            // 
            this.ErrorProviderPersonaFisica.ContainerControl = this;
            this.ErrorProviderPersonaFisica.DataSource = this.bindingSourcePersonaFisica;
            // 
            // PersonaFisicaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "PersonaFisicaEdit";
            this.Size = new System.Drawing.Size(572, 316);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePersonaFisica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit10.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Note.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderPersonaFisica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private it.dedagroup.GVC.Client.Forms.Controls.TextEdit textEdit5;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl4;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl3;
        private it.dedagroup.GVC.Client.Forms.Controls.TextEdit textEdit1;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl1;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl Nome;
        private it.dedagroup.GVC.Client.Forms.Controls.TextEdit textEdit6;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl5;
        private it.dedagroup.GVC.Client.Forms.Controls.DateEdit dateEdit1;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl2;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl6;
        private OeF.Forms.Controls.RadioGroup radioGroup3;
        private it.dedagroup.GVC.Client.Forms.Controls.TextEdit textEdit3;
        private it.dedagroup.GVC.Client.Forms.Controls.TextEdit textEdit2;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl7;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl10;
        private it.dedagroup.GVC.Client.Forms.Controls.TextEdit textEdit4;
        private OeF.Forms.BindingSourceBase bindingSourcePersonaFisica;
        private it.dedagroup.GVC.Client.Forms.Controls.TextEdit textEdit7;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl8;
        private System.Windows.Forms.GroupBox groupBox1;
        private it.dedagroup.GVC.Client.Forms.Controls.TextEdit textEdit8;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl9;
        private it.dedagroup.GVC.Client.Forms.Controls.TextEdit textEdit9;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl11;
        private System.Windows.Forms.GroupBox groupBox2;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl12;
        private OeF.Forms.Controls.MemoEdit Note;
        private it.dedagroup.GVC.Client.Forms.Controls.TextEdit textEdit10;
        public DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ErrorProviderPersonaFisica;
    }
}
