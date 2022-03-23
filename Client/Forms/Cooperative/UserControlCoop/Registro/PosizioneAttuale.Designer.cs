namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Registro
{
    partial class PosizioneAttuale
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lookUpEditCategoriaSociale = new it.dedagroup.GVC.Client.Forms.Controls.LookUpEdit();
            this.bindingSourceBaseCambioPosizione = new OeF.Forms.BindingSourceBase(this.components);
            this.bindingSourceCategoriaSociale = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.labelControl3 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.lookUpEditSezione = new it.dedagroup.GVC.Client.Forms.Controls.LookUpEdit();
            this.bindingSourceSezione = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.lookUpEditSubSection = new it.dedagroup.GVC.Client.Forms.Controls.LookUpEdit();
            this.bindingSourceSottoSezione = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.lookUpEditCategoria = new it.dedagroup.GVC.Client.Forms.Controls.LookUpEdit();
            this.bindingSourceCategoria = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.textEditNumeroIscrizioneAlboNazionale = new it.dedagroup.GVC.Client.Forms.Controls.TextEdit();
            this.registroCooperativaFDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lookUpEditSottoCategoriaSociale = new it.dedagroup.GVC.Client.Forms.Controls.LookUpEdit();
            this.bindingSourceSottoCategoriaSociale = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.labelControl9 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.labelControl5 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.labelControl4 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.labelControl6 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.labelControl11 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.bindingSourceBaseCooperative = new OeF.Forms.BindingSourceBase(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCategoriaSociale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseCambioPosizione)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCategoriaSociale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditSezione.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSezione)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditSubSection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSottoSezione)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNumeroIscrizioneAlboNazionale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroCooperativaFDTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditSottoCategoriaSociale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSottoCategoriaSociale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseCooperative)).BeginInit();
            this.SuspendLayout();
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.ScrollableContent.Appearance.Options.UseBackColor = true;
            this.ScrollableContent.Controls.Add(this.groupBox3);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 24);
            this.ScrollableContent.Size = new System.Drawing.Size(748, 127);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lookUpEditCategoriaSociale);
            this.groupBox3.Controls.Add(this.labelControl3);
            this.groupBox3.Controls.Add(this.lookUpEditSezione);
            this.groupBox3.Controls.Add(this.lookUpEditSubSection);
            this.groupBox3.Controls.Add(this.lookUpEditCategoria);
            this.groupBox3.Controls.Add(this.textEditNumeroIscrizioneAlboNazionale);
            this.groupBox3.Controls.Add(this.lookUpEditSottoCategoriaSociale);
            this.groupBox3.Controls.Add(this.labelControl9);
            this.groupBox3.Controls.Add(this.labelControl5);
            this.groupBox3.Controls.Add(this.labelControl4);
            this.groupBox3.Controls.Add(this.labelControl6);
            this.groupBox3.Controls.Add(this.labelControl11);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(748, 127);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Posizione di iscrizione attuale";
            // 
            // lookUpEditCategoriaSociale
            // 
            this.lookUpEditCategoriaSociale.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseCambioPosizione, "CategoriaSociale", true));
            this.lookUpEditCategoriaSociale.Location = new System.Drawing.Point(98, 71);
            this.lookUpEditCategoriaSociale.Name = "lookUpEditCategoriaSociale";
            this.lookUpEditCategoriaSociale.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCategoriaSociale.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descrizione", "", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.lookUpEditCategoriaSociale.Properties.DataSource = this.bindingSourceCategoriaSociale;
            this.lookUpEditCategoriaSociale.Properties.DisplayMember = "Descrizione";
            this.lookUpEditCategoriaSociale.Properties.NullText = "";
            this.lookUpEditCategoriaSociale.Properties.ReadOnly = true;
            this.lookUpEditCategoriaSociale.Properties.ValueMember = "IdElemento";
            this.lookUpEditCategoriaSociale.Size = new System.Drawing.Size(88, 20);
            this.lookUpEditCategoriaSociale.TabIndex = 4;
            // 
            // bindingSourceBaseCambioPosizione
            // 
            this.bindingSourceBaseCambioPosizione.AutoCreateObjects = false;
            this.bindingSourceBaseCambioPosizione.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.CambioPosizioneFDT);
            // 
            // bindingSourceCategoriaSociale
            // 
            this.bindingSourceCategoriaSociale.AutoCreateObjects = false;
            this.bindingSourceCategoriaSociale.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(52, 22);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "Sezione";
            // 
            // lookUpEditSezione
            // 
            this.lookUpEditSezione.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseCambioPosizione, "Sezione", true));
            this.lookUpEditSezione.Location = new System.Drawing.Point(98, 19);
            this.lookUpEditSezione.Name = "lookUpEditSezione";
            this.lookUpEditSezione.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditSezione.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descrizione", "Sezione", 100)});
            this.lookUpEditSezione.Properties.DataSource = this.bindingSourceSezione;
            this.lookUpEditSezione.Properties.DisplayMember = "Descrizione";
            this.lookUpEditSezione.Properties.NullText = "";
            this.lookUpEditSezione.Properties.ReadOnly = true;
            this.lookUpEditSezione.Properties.ValueMember = "IdElemento";
            this.lookUpEditSezione.Size = new System.Drawing.Size(218, 20);
            this.lookUpEditSezione.TabIndex = 1;
            this.lookUpEditSezione.EditValueChanged += new System.EventHandler(this.lookUpEditSection_EditValueChanged);
            // 
            // bindingSourceSezione
            // 
            this.bindingSourceSezione.AutoCreateObjects = false;
            this.bindingSourceSezione.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // lookUpEditSubSection
            // 
            this.lookUpEditSubSection.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseCambioPosizione, "SottoSezione", true));
            this.lookUpEditSubSection.Location = new System.Drawing.Point(404, 19);
            this.lookUpEditSubSection.Name = "lookUpEditSubSection";
            this.lookUpEditSubSection.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditSubSection.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descrizione", "Sottosezione", 100)});
            this.lookUpEditSubSection.Properties.DataSource = this.bindingSourceSottoSezione;
            this.lookUpEditSubSection.Properties.DisplayMember = "Descrizione";
            this.lookUpEditSubSection.Properties.NullText = "";
            this.lookUpEditSubSection.Properties.ReadOnly = true;
            this.lookUpEditSubSection.Properties.ValueMember = "IdElemento";
            this.lookUpEditSubSection.Size = new System.Drawing.Size(199, 20);
            this.lookUpEditSubSection.TabIndex = 2;
            // 
            // bindingSourceSottoSezione
            // 
            this.bindingSourceSottoSezione.AutoCreateObjects = false;
            this.bindingSourceSottoSezione.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // lookUpEditCategoria
            // 
            this.lookUpEditCategoria.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseCambioPosizione, "IdCategoria", true));
            this.lookUpEditCategoria.Location = new System.Drawing.Point(98, 45);
            this.lookUpEditCategoria.Name = "lookUpEditCategoria";
            this.lookUpEditCategoria.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCategoria.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codice", "Codice", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descrizione", "Categoria", 100)});
            this.lookUpEditCategoria.Properties.DataSource = this.bindingSourceCategoria;
            this.lookUpEditCategoria.Properties.DisplayMember = "CodiceEdescrizione";
            this.lookUpEditCategoria.Properties.NullText = "";
            this.lookUpEditCategoria.Properties.ReadOnly = true;
            this.lookUpEditCategoria.Properties.ValueMember = "IdElemento";
            this.lookUpEditCategoria.Size = new System.Drawing.Size(637, 20);
            this.lookUpEditCategoria.TabIndex = 3;
            // 
            // bindingSourceCategoria
            // 
            this.bindingSourceCategoria.AutoCreateObjects = false;
            this.bindingSourceCategoria.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // textEditNumeroIscrizioneAlboNazionale
            // 
            this.textEditNumeroIscrizioneAlboNazionale.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.registroCooperativaFDTBindingSource, "NumeroIscrizioneAlboNaz", true));
            this.textEditNumeroIscrizioneAlboNazionale.Location = new System.Drawing.Point(186, 97);
            this.textEditNumeroIscrizioneAlboNazionale.Name = "textEditNumeroIscrizioneAlboNazionale";
            this.textEditNumeroIscrizioneAlboNazionale.Properties.MaxLength = 10;
            this.textEditNumeroIscrizioneAlboNazionale.Properties.ReadOnly = true;
            this.textEditNumeroIscrizioneAlboNazionale.Size = new System.Drawing.Size(117, 20);
            this.textEditNumeroIscrizioneAlboNazionale.TabIndex = 6;
            // 
            // registroCooperativaFDTBindingSource
            // 
            this.registroCooperativaFDTBindingSource.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.RegistroCooperativaFDT);
            // 
            // lookUpEditSottoCategoriaSociale
            // 
            this.lookUpEditSottoCategoriaSociale.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseCambioPosizione, "IdSottoCategoria", true));
            this.lookUpEditSottoCategoriaSociale.Location = new System.Drawing.Point(305, 71);
            this.lookUpEditSottoCategoriaSociale.Name = "lookUpEditSottoCategoriaSociale";
            this.lookUpEditSottoCategoriaSociale.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditSottoCategoriaSociale.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descrizione", "Sottocategoria", 200)});
            this.lookUpEditSottoCategoriaSociale.Properties.DataSource = this.bindingSourceSottoCategoriaSociale;
            this.lookUpEditSottoCategoriaSociale.Properties.DisplayMember = "Descrizione";
            this.lookUpEditSottoCategoriaSociale.Properties.NullText = "";
            this.lookUpEditSottoCategoriaSociale.Properties.ReadOnly = true;
            this.lookUpEditSottoCategoriaSociale.Properties.ValueMember = "IdElemento";
            this.lookUpEditSottoCategoriaSociale.Size = new System.Drawing.Size(430, 20);
            this.lookUpEditSottoCategoriaSociale.TabIndex = 5;
            // 
            // bindingSourceSottoCategoriaSociale
            // 
            this.bindingSourceSottoCategoriaSociale.AutoCreateObjects = false;
            this.bindingSourceSottoCategoriaSociale.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(11, 100);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(154, 13);
            this.labelControl9.TabIndex = 19;
            this.labelControl9.Text = "Numero iscrizione albo nazionale";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(336, 22);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(62, 13);
            this.labelControl5.TabIndex = 17;
            this.labelControl5.Text = "Sottosezione";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(45, 48);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 13);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Categoria";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(9, 74);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(83, 13);
            this.labelControl6.TabIndex = 23;
            this.labelControl6.Text = "Categoria Sociale";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(192, 74);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(107, 13);
            this.labelControl11.TabIndex = 24;
            this.labelControl11.Text = "Sottocategoria Sociale";
            // 
            // bindingSourceBaseCooperative
            // 
            this.bindingSourceBaseCooperative.AutoCreateObjects = false;
            this.bindingSourceBaseCooperative.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.CooperativaFDT);
            // 
            // PosizioneAttuale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "PosizioneAttuale";
            this.Size = new System.Drawing.Size(748, 151);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCategoriaSociale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseCambioPosizione)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCategoriaSociale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditSezione.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSezione)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditSubSection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSottoSezione)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNumeroIscrizioneAlboNazionale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroCooperativaFDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditSottoCategoriaSociale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSottoCategoriaSociale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseCooperative)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private it.dedagroup.GVC.Client.Forms.Controls.LookUpEdit lookUpEditCategoriaSociale;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl3;
        private it.dedagroup.GVC.Client.Forms.Controls.LookUpEdit lookUpEditSezione;
        private it.dedagroup.GVC.Client.Forms.Controls.LookUpEdit lookUpEditSubSection;
        private it.dedagroup.GVC.Client.Forms.Controls.LookUpEdit lookUpEditCategoria;
        private it.dedagroup.GVC.Client.Forms.Controls.TextEdit textEditNumeroIscrizioneAlboNazionale;
        private it.dedagroup.GVC.Client.Forms.Controls.LookUpEdit lookUpEditSottoCategoriaSociale;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl9;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl5;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl4;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl6;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl11;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceCategoriaSociale;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceSezione;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceSottoSezione;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceCategoria;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceSottoCategoriaSociale;
        private OeF.Forms.BindingSourceBase bindingSourceBaseCooperative;
        private OeF.Forms.BindingSourceBase bindingSourceBaseCambioPosizione;
        private System.Windows.Forms.BindingSource registroCooperativaFDTBindingSource;
    }
}
