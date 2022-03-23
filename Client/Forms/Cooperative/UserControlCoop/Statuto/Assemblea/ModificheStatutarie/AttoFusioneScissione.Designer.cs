namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Statuto.Assemblea.ModificheStatutarie
{
    partial class AttoFusioneScissione
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
            this.lookUpEditStato = new DevExpress.XtraEditors.LookUpEdit();
            this.bindingSourceBaseModificaStatutaria = new OeF.Forms.BindingSourceBase(this.components);
            this.bindingSourceBaseStato = new OeF.Forms.BindingSourceBase(this.components);
            this.labelControl6 = new OeF.Forms.Controls.LabelControl();
            this.labelControl1 = new OeF.Forms.Controls.LabelControl();
            this.lookUpEditFormaGiuNuova = new DevExpress.XtraEditors.LookUpEdit();
            this.dateEdit1 = new OeF.Forms.Controls.DateEdit();
            this.labelControl5 = new OeF.Forms.Controls.LabelControl();
            this.dateEdit2 = new OeF.Forms.Controls.DateEdit();
            this.labelControl2 = new OeF.Forms.Controls.LabelControl();
            this.dateEdit3 = new OeF.Forms.Controls.DateEdit();
            this.labelControl3 = new OeF.Forms.Controls.LabelControl();
            this.labelControl15 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.btnSearchNotary = new it.dedagroup.GVC.Client.Forms.Controls.SimpleButton();
            this.textEdit6 = new it.dedagroup.GVC.Client.Forms.Controls.TextEdit();
            this.btnViewSubject = new OeF.Forms.Controls.SimpleButton();
            this.ErrorProviderModificaStatutaria = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.labelControl4 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.checkEditNrScioglimento = new it.dedagroup.GVC.Client.Forms.Controls.CheckEdit();
            this.btnRemoveSubject = new OeF.Forms.Controls.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditStato.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseModificaStatutaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseStato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditFormaGiuNuova.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit3.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderModificaStatutaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditNrScioglimento.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.btnRemoveSubject);
            this.ScrollableContent.Controls.Add(this.labelControl4);
            this.ScrollableContent.Controls.Add(this.checkEditNrScioglimento);
            this.ScrollableContent.Controls.Add(this.btnViewSubject);
            this.ScrollableContent.Controls.Add(this.labelControl15);
            this.ScrollableContent.Controls.Add(this.btnSearchNotary);
            this.ScrollableContent.Controls.Add(this.textEdit6);
            this.ScrollableContent.Controls.Add(this.dateEdit3);
            this.ScrollableContent.Controls.Add(this.labelControl3);
            this.ScrollableContent.Controls.Add(this.dateEdit2);
            this.ScrollableContent.Controls.Add(this.labelControl2);
            this.ScrollableContent.Controls.Add(this.dateEdit1);
            this.ScrollableContent.Controls.Add(this.labelControl5);
            this.ScrollableContent.Controls.Add(this.lookUpEditFormaGiuNuova);
            this.ScrollableContent.Controls.Add(this.lookUpEditStato);
            this.ScrollableContent.Controls.Add(this.labelControl1);
            this.ScrollableContent.Controls.Add(this.labelControl6);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 24);
            this.ScrollableContent.Size = new System.Drawing.Size(570, 165);
            // 
            // lookUpEditStato
            // 
            this.lookUpEditStato.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseModificaStatutaria, "IdVecchioStatoIscrizione", true));
            this.ErrorProviderModificaStatutaria.SetErrorType(this.lookUpEditStato, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.lookUpEditStato.Location = new System.Drawing.Point(81, 6);
            this.lookUpEditStato.Name = "lookUpEditStato";
            this.lookUpEditStato.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditStato.Properties.DataSource = this.bindingSourceBaseStato;
            this.lookUpEditStato.Properties.DisplayMember = "Descrizione";
            this.lookUpEditStato.Properties.NullText = "";
            this.lookUpEditStato.Properties.ReadOnly = true;
            this.lookUpEditStato.Properties.ValueMember = "IdElemento";
            this.lookUpEditStato.Size = new System.Drawing.Size(464, 20);
            this.lookUpEditStato.TabIndex = 13;
            this.lookUpEditStato.TabStop = false;
            // 
            // bindingSourceBaseModificaStatutaria
            // 
            this.bindingSourceBaseModificaStatutaria.AutoCreateObjects = false;
            this.bindingSourceBaseModificaStatutaria.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.ModificaStatutariaFDT);
            // 
            // bindingSourceBaseStato
            // 
            this.bindingSourceBaseStato.AutoCreateObjects = false;
            this.bindingSourceBaseStato.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 35);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Stato nuovo";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Stato attuale";
            // 
            // lookUpEditFormaGiuNuova
            // 
            this.lookUpEditFormaGiuNuova.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseModificaStatutaria, "IdNuovoStatoIscrizione", true));
            this.ErrorProviderModificaStatutaria.SetErrorType(this.lookUpEditFormaGiuNuova, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.lookUpEditFormaGiuNuova.Location = new System.Drawing.Point(81, 32);
            this.lookUpEditFormaGiuNuova.Name = "lookUpEditFormaGiuNuova";
            this.lookUpEditFormaGiuNuova.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditFormaGiuNuova.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descrizione", "Descrizione", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEditFormaGiuNuova.Properties.DataSource = this.bindingSourceBaseStato;
            this.lookUpEditFormaGiuNuova.Properties.DisplayMember = "Descrizione";
            this.lookUpEditFormaGiuNuova.Properties.NullText = "";
            this.lookUpEditFormaGiuNuova.Properties.ValueMember = "IdElemento";
            this.lookUpEditFormaGiuNuova.Size = new System.Drawing.Size(464, 20);
            this.lookUpEditFormaGiuNuova.TabIndex = 1;
            // 
            // dateEdit1
            // 
            this.dateEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseModificaStatutaria, "DataAttoFusioneScissione", true));
            this.dateEdit1.EditValue = null;
            this.ErrorProviderModificaStatutaria.SetErrorType(this.dateEdit1, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.dateEdit1.Location = new System.Drawing.Point(156, 58);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(100, 20);
            this.dateEdit1.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(59, 61);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(91, 13);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "Data atto scissione";
            // 
            // dateEdit2
            // 
            this.dateEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseModificaStatutaria, "DataIscrizioneAtto", true));
            this.dateEdit2.EditValue = null;
            this.ErrorProviderModificaStatutaria.SetErrorType(this.dateEdit2, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.dateEdit2.Location = new System.Drawing.Point(445, 58);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit2.Size = new System.Drawing.Size(100, 20);
            this.dateEdit2.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(356, 61);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 13);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Data iscrizione RI";
            // 
            // dateEdit3
            // 
            this.dateEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseModificaStatutaria, "DataEfficaciaAtto", true));
            this.dateEdit3.EditValue = null;
            this.ErrorProviderModificaStatutaria.SetErrorType(this.dateEdit3, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.dateEdit3.Location = new System.Drawing.Point(156, 84);
            this.dateEdit3.Name = "dateEdit3";
            this.dateEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit3.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit3.Size = new System.Drawing.Size(100, 20);
            this.dateEdit3.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(61, 87);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(89, 13);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Data efficacia atto";
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(12, 113);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(31, 13);
            this.labelControl15.TabIndex = 47;
            this.labelControl15.Text = "Notaio";
            // 
            // btnSearchNotary
            // 
            this.btnSearchNotary.Location = new System.Drawing.Point(452, 107);
            this.btnSearchNotary.Name = "btnSearchNotary";
            this.btnSearchNotary.Size = new System.Drawing.Size(93, 23);
            this.btnSearchNotary.TabIndex = 49;
            this.btnSearchNotary.TabStop = false;
            this.btnSearchNotary.Text = "Ricerca";
            this.btnSearchNotary.Click += new System.EventHandler(this.btnSearchNotary_Click);
            // 
            // textEdit6
            // 
            this.textEdit6.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseModificaStatutaria, "Notaio_DescrizioneBreve", true));
            this.ErrorProviderModificaStatutaria.SetErrorType(this.textEdit6, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.textEdit6.Location = new System.Drawing.Point(49, 110);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Size = new System.Drawing.Size(330, 20);
            this.textEdit6.TabIndex = 5;
            // 
            // btnViewSubject
            // 
            this.btnViewSubject.Location = new System.Drawing.Point(385, 107);
            this.btnViewSubject.Name = "btnViewSubject";
            this.btnViewSubject.Size = new System.Drawing.Size(26, 23);
            this.btnViewSubject.TabIndex = 50;
            this.btnViewSubject.TabStop = false;
            this.btnViewSubject.Click += new System.EventHandler(this.btnViewSubject_Click);
            // 
            // ErrorProviderModificaStatutaria
            // 
            this.ErrorProviderModificaStatutaria.ContainerControl = this;
            this.ErrorProviderModificaStatutaria.DataSource = this.bindingSourceBaseModificaStatutaria;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(81, 136);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(173, 13);
            this.labelControl4.TabIndex = 53;
            this.labelControl4.Text = "Aggiornamento numero scioglimento";
            // 
            // checkEditNrScioglimento
            // 
            this.checkEditNrScioglimento.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseModificaStatutaria, "AggiornaNrScioglimento", true));
            this.ErrorProviderModificaStatutaria.SetErrorType(this.checkEditNrScioglimento, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.checkEditNrScioglimento.Location = new System.Drawing.Point(260, 133);
            this.checkEditNrScioglimento.Name = "checkEditNrScioglimento";
            this.checkEditNrScioglimento.Properties.Caption = "";
            this.checkEditNrScioglimento.Size = new System.Drawing.Size(19, 19);
            this.checkEditNrScioglimento.TabIndex = 52;
            // 
            // btnRemoveSubject
            // 
            this.btnRemoveSubject.Location = new System.Drawing.Point(420, 107);
            this.btnRemoveSubject.Name = "btnRemoveSubject";
            this.btnRemoveSubject.Size = new System.Drawing.Size(26, 23);
            this.btnRemoveSubject.TabIndex = 143;
            this.btnRemoveSubject.TabStop = false;
            this.btnRemoveSubject.Click += new System.EventHandler(this.btnRemoveSubject_Click);
            // 
            // AttoFusioneScissione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "AttoFusioneScissione";
            this.Size = new System.Drawing.Size(570, 189);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            this.ScrollableContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditStato.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseModificaStatutaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseStato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditFormaGiuNuova.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit3.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderModificaStatutaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditNrScioglimento.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lookUpEditStato;
        private OeF.Forms.Controls.LabelControl labelControl1;
        private OeF.Forms.Controls.LabelControl labelControl6;
        private OeF.Forms.BindingSourceBase bindingSourceBaseModificaStatutaria;
        private OeF.Forms.BindingSourceBase bindingSourceBaseStato;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditFormaGiuNuova;
        private OeF.Forms.Controls.DateEdit dateEdit1;
        private OeF.Forms.Controls.LabelControl labelControl5;
        private OeF.Forms.Controls.DateEdit dateEdit3;
        private OeF.Forms.Controls.LabelControl labelControl3;
        private OeF.Forms.Controls.DateEdit dateEdit2;
        private OeF.Forms.Controls.LabelControl labelControl2;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl15;
        private it.dedagroup.GVC.Client.Forms.Controls.SimpleButton btnSearchNotary;
        private it.dedagroup.GVC.Client.Forms.Controls.TextEdit textEdit6;
        private OeF.Forms.Controls.SimpleButton btnViewSubject;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ErrorProviderModificaStatutaria;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl4;
        private it.dedagroup.GVC.Client.Forms.Controls.CheckEdit checkEditNrScioglimento;
        private OeF.Forms.Controls.SimpleButton btnRemoveSubject;
    }
}
