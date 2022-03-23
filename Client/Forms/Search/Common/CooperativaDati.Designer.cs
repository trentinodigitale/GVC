namespace it.dedagroup.GVC.Client.Forms.Search.Common
{
    partial class CooperativaDati
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
            this.dateEditAderenzaDel = new it.dedagroup.GVC.Client.Forms.Controls.DateEdit();
            this.bindingSourceParametriCoop = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.labelControl10 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.radioGroupAdesione = new DevExpress.XtraEditors.RadioGroup();
            this.simpleButtonCoopRicerca = new it.dedagroup.GVC.Client.Forms.Controls.SimpleButton();
            this.REANumber = new it.dedagroup.GVC.Client.Forms.Controls.TextEdit();
            this.labelControlParix1 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControlParix();
            this.CodiceCooperativa = new OeF.Forms.Controls.TextEdit();
            this.labelControl4 = new OeF.Forms.Controls.LabelControl();
            this.simpleButtonSearchAss = new it.dedagroup.GVC.Client.Forms.Controls.SimpleButton();
            this.textEditAssociazione = new OeF.Forms.Controls.TextEdit();
            this.bindingSourceRevisione = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.bindingSourceParametriAdesione = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.labelControl13 = new OeF.Forms.Controls.LabelControl();
            this.btnRemoveSubject = new OeF.Forms.Controls.SimpleButton();
            this.radioGroupIscrizione = new DevExpress.XtraEditors.RadioGroup();
            this.dateEdit1 = new it.dedagroup.GVC.Client.Forms.Controls.DateEdit();
            this.labelControl1 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAderenzaDel.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAderenzaDel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceParametriCoop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupAdesione.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REANumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodiceCooperativa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAssociazione.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRevisione)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceParametriAdesione)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupIscrizione.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.groupBox2);
            this.ScrollableContent.Controls.Add(this.groupBox1);
            this.ScrollableContent.Controls.Add(this.labelControl4);
            this.ScrollableContent.Controls.Add(this.CodiceCooperativa);
            this.ScrollableContent.Controls.Add(this.labelControlParix1);
            this.ScrollableContent.Controls.Add(this.simpleButtonCoopRicerca);
            this.ScrollableContent.Controls.Add(this.REANumber);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 24);
            this.ScrollableContent.Size = new System.Drawing.Size(477, 112);
            // 
            // dateEditAderenzaDel
            // 
            this.dateEditAderenzaDel.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceParametriCoop, "RegistroCooperativa_DataUltimaModifica", true));
            this.dateEditAderenzaDel.EditValue = null;
            this.dateEditAderenzaDel.Location = new System.Drawing.Point(363, 7);
            this.dateEditAderenzaDel.Name = "dateEditAderenzaDel";
            this.dateEditAderenzaDel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditAderenzaDel.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dateEditAderenzaDel.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEditAderenzaDel.Size = new System.Drawing.Size(100, 20);
            this.dateEditAderenzaDel.TabIndex = 4;
            // 
            // bindingSourceParametriCoop
            // 
            this.bindingSourceParametriCoop.AutoCreateObjects = false;
            this.bindingSourceParametriCoop.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.CooperativaFDT);
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(299, 12);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(58, 13);
            this.labelControl10.TabIndex = 183;
            this.labelControl10.Text = "alla data del";
            // 
            // radioGroupAdesione
            // 
            this.radioGroupAdesione.EditValue = 0;
            this.radioGroupAdesione.Location = new System.Drawing.Point(0, 8);
            this.radioGroupAdesione.Name = "radioGroupAdesione";
            this.radioGroupAdesione.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroupAdesione.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroupAdesione.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroupAdesione.Properties.Columns = 3;
            this.radioGroupAdesione.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Tutte"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Con Organo rev"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Senza adesione")});
            this.radioGroupAdesione.Size = new System.Drawing.Size(296, 22);
            this.radioGroupAdesione.TabIndex = 178;
            this.radioGroupAdesione.TabStop = false;
            this.radioGroupAdesione.SelectedIndexChanged += new System.EventHandler(this.radioGroupAdesione_SelectedIndexChanged);
            // 
            // simpleButtonCoopRicerca
            // 
            this.simpleButtonCoopRicerca.Location = new System.Drawing.Point(295, 3);
            this.simpleButtonCoopRicerca.Name = "simpleButtonCoopRicerca";
            this.simpleButtonCoopRicerca.Size = new System.Drawing.Size(56, 23);
            this.simpleButtonCoopRicerca.TabIndex = 182;
            this.simpleButtonCoopRicerca.TabStop = false;
            this.simpleButtonCoopRicerca.Text = "Ricerca";
            this.simpleButtonCoopRicerca.Click += new System.EventHandler(this.simpleButtonCoopRicerca_Click);
            // 
            // REANumber
            // 
            this.REANumber.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceParametriCoop, "RegistroCooperativa_NumeroREA", true));
            this.REANumber.EditValue = "";
            this.REANumber.Location = new System.Drawing.Point(223, 3);
            this.REANumber.Name = "REANumber";
            this.REANumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.REANumber.Size = new System.Drawing.Size(66, 20);
            this.REANumber.TabIndex = 2;
            // 
            // labelControlParix1
            // 
            this.labelControlParix1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControlParix1.Appearance.Options.UseForeColor = true;
            this.labelControlParix1.Location = new System.Drawing.Point(173, 6);
            this.labelControlParix1.Name = "labelControlParix1";
            this.labelControlParix1.Size = new System.Drawing.Size(42, 13);
            this.labelControlParix1.TabIndex = 181;
            this.labelControlParix1.Text = "N. R.E.A";
            // 
            // CodiceCooperativa
            // 
            this.CodiceCooperativa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceParametriCoop, "RegistroCooperativa_IdRegistro", true));
            this.CodiceCooperativa.Location = new System.Drawing.Point(103, 3);
            this.CodiceCooperativa.Name = "CodiceCooperativa";
            this.CodiceCooperativa.Size = new System.Drawing.Size(66, 20);
            this.CodiceCooperativa.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(3, 6);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(94, 13);
            this.labelControl4.TabIndex = 180;
            this.labelControl4.Text = "Codice Cooperativa";
            // 
            // simpleButtonSearchAss
            // 
            this.simpleButtonSearchAss.Location = new System.Drawing.Point(374, 29);
            this.simpleButtonSearchAss.Name = "simpleButtonSearchAss";
            this.simpleButtonSearchAss.Size = new System.Drawing.Size(56, 23);
            this.simpleButtonSearchAss.TabIndex = 186;
            this.simpleButtonSearchAss.TabStop = false;
            this.simpleButtonSearchAss.Text = "Ricerca";
            this.simpleButtonSearchAss.Click += new System.EventHandler(this.simpleButtonSearchAss_Click);
            // 
            // textEditAssociazione
            // 
            this.textEditAssociazione.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceRevisione, "Revisore_DescrizioneBreve", true));
            this.textEditAssociazione.Location = new System.Drawing.Point(73, 31);
            this.textEditAssociazione.Name = "textEditAssociazione";
            this.textEditAssociazione.Size = new System.Drawing.Size(284, 20);
            this.textEditAssociazione.TabIndex = 184;
            this.textEditAssociazione.TabStop = false;
            // 
            // bindingSourceRevisione
            // 
            this.bindingSourceRevisione.AutoCreateObjects = false;
            this.bindingSourceRevisione.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.RevisioneFDT);
            // 
            // bindingSourceParametriAdesione
            // 
            this.bindingSourceParametriAdesione.AutoCreateObjects = false;
            this.bindingSourceParametriAdesione.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.PersonaGiuridicaFDT);
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(6, 34);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(61, 13);
            this.labelControl13.TabIndex = 185;
            this.labelControl13.Text = "Associazione";
            // 
            // btnRemoveSubject
            // 
            this.btnRemoveSubject.Location = new System.Drawing.Point(436, 29);
            this.btnRemoveSubject.Name = "btnRemoveSubject";
            this.btnRemoveSubject.Size = new System.Drawing.Size(26, 23);
            this.btnRemoveSubject.TabIndex = 187;
            this.btnRemoveSubject.TabStop = false;
            this.btnRemoveSubject.Click += new System.EventHandler(this.btnRemoveSubject_Click);
            // 
            // radioGroupIscrizione
            // 
            this.radioGroupIscrizione.EditValue = 0;
            this.radioGroupIscrizione.Location = new System.Drawing.Point(0, 7);
            this.radioGroupIscrizione.Name = "radioGroupIscrizione";
            this.radioGroupIscrizione.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroupIscrizione.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroupIscrizione.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroupIscrizione.Properties.Columns = 4;
            this.radioGroupIscrizione.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Tutte"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Iscritta"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Non iscritta"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Cancellata")});
            this.radioGroupIscrizione.Size = new System.Drawing.Size(296, 22);
            this.radioGroupIscrizione.TabIndex = 188;
            this.radioGroupIscrizione.TabStop = false;
            // 
            // dateEdit1
            // 
            this.dateEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceParametriCoop, "DataUltimaModifica", true));
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(363, 7);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(100, 20);
            this.dateEdit1.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(299, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 13);
            this.labelControl1.TabIndex = 190;
            this.labelControl1.Text = "alla data del";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioGroupIscrizione);
            this.groupBox1.Controls.Add(this.dateEdit1);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(3, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 29);
            this.groupBox1.TabIndex = 191;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dati iscrizione";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioGroupAdesione);
            this.groupBox2.Controls.Add(this.dateEditAderenzaDel);
            this.groupBox2.Controls.Add(this.btnRemoveSubject);
            this.groupBox2.Controls.Add(this.labelControl10);
            this.groupBox2.Controls.Add(this.simpleButtonSearchAss);
            this.groupBox2.Controls.Add(this.labelControl13);
            this.groupBox2.Controls.Add(this.textEditAssociazione);
            this.groupBox2.Location = new System.Drawing.Point(3, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 56);
            this.groupBox2.TabIndex = 192;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dati adesione";
            // 
            // CooperativaDati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CooperativaDati";
            this.Size = new System.Drawing.Size(477, 136);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            this.ScrollableContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAderenzaDel.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAderenzaDel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceParametriCoop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupAdesione.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REANumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodiceCooperativa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAssociazione.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRevisione)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceParametriAdesione)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupIscrizione.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private it.dedagroup.GVC.Client.Forms.Controls.DateEdit dateEditAderenzaDel;
        private OeF.Forms.Controls.LabelControl labelControl4;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl10;
        private OeF.Forms.Controls.TextEdit CodiceCooperativa;
        private DevExpress.XtraEditors.RadioGroup radioGroupAdesione;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControlParix labelControlParix1;
        private it.dedagroup.GVC.Client.Forms.Controls.SimpleButton simpleButtonCoopRicerca;
        private it.dedagroup.GVC.Client.Forms.Controls.TextEdit REANumber;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceParametriCoop;
        private it.dedagroup.GVC.Client.Forms.Controls.SimpleButton simpleButtonSearchAss;
        private OeF.Forms.Controls.TextEdit textEditAssociazione;
        private OeF.Forms.Controls.LabelControl labelControl13;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceParametriAdesione;
        private OeF.Forms.Controls.SimpleButton btnRemoveSubject;
        private it.dedagroup.GVC.Client.Forms.Controls.DateEdit dateEdit1;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl1;
        private DevExpress.XtraEditors.RadioGroup radioGroupIscrizione;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceRevisione;
    }
}
