namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Statuto.Assemblea.ModificheStatutarie
{
    partial class Fusione
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
            this.bindingSourceBaseModificaStatutaria = new OeF.Forms.BindingSourceBase(this.components);
            this.bindingSourceBaseSocietaColl = new OeF.Forms.BindingSourceBase(this.components);
            this.btnViewSubject = new OeF.Forms.Controls.SimpleButton();
            this.btnSearchAssociation = new it.dedagroup.GVC.Client.Forms.Controls.SimpleButton();
            this.memoEdit2 = new OeF.Forms.Controls.MemoEdit();
            this.labelControl2 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.ErrorProviderModificaStatutaria = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.lookUpEditFormaGiuNuova = new DevExpress.XtraEditors.LookUpEdit();
            this.bindingSourceBaseStato = new OeF.Forms.BindingSourceBase(this.components);
            this.lookUpEditStato = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new OeF.Forms.Controls.LabelControl();
            this.labelControl6 = new OeF.Forms.Controls.LabelControl();
            this.labelControl3 = new OeF.Forms.Controls.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseModificaStatutaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseSocietaColl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderModificaStatutaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditFormaGiuNuova.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseStato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditStato.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.labelControl3);
            this.ScrollableContent.Controls.Add(this.lookUpEditFormaGiuNuova);
            this.ScrollableContent.Controls.Add(this.lookUpEditStato);
            this.ScrollableContent.Controls.Add(this.labelControl1);
            this.ScrollableContent.Controls.Add(this.labelControl6);
            this.ScrollableContent.Controls.Add(this.btnViewSubject);
            this.ScrollableContent.Controls.Add(this.btnSearchAssociation);
            this.ScrollableContent.Controls.Add(this.memoEdit2);
            this.ScrollableContent.Controls.Add(this.labelControl2);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 24);
            this.ScrollableContent.Size = new System.Drawing.Size(570, 153);
            // 
            // bindingSourceBaseModificaStatutaria
            // 
            this.bindingSourceBaseModificaStatutaria.AutoCreateObjects = false;
            this.bindingSourceBaseModificaStatutaria.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.ModificaStatutariaFDT);
            // 
            // bindingSourceBaseSocietaColl
            // 
            this.bindingSourceBaseSocietaColl.AutoCreateObjects = false;
            this.bindingSourceBaseSocietaColl.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.CollegamentoSocietaFDT);
            // 
            // btnViewSubject
            // 
            this.btnViewSubject.Location = new System.Drawing.Point(481, 1);
            this.btnViewSubject.Name = "btnViewSubject";
            this.btnViewSubject.Size = new System.Drawing.Size(26, 23);
            this.btnViewSubject.TabIndex = 63;
            this.btnViewSubject.TabStop = false;
            this.btnViewSubject.Click += new System.EventHandler(this.btnViewSubject_Click);
            // 
            // btnSearchAssociation
            // 
            this.btnSearchAssociation.Location = new System.Drawing.Point(480, 29);
            this.btnSearchAssociation.Name = "btnSearchAssociation";
            this.btnSearchAssociation.Size = new System.Drawing.Size(75, 23);
            this.btnSearchAssociation.TabIndex = 61;
            this.btnSearchAssociation.Text = "Ricerca";
            this.btnSearchAssociation.Click += new System.EventHandler(this.btnSearchAssociation_Click);
            // 
            // memoEdit2
            // 
            this.memoEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseSocietaColl, "Societa_DescrizioneBreve", true));
            this.ErrorProviderModificaStatutaria.SetErrorType(this.memoEdit2, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.memoEdit2.Location = new System.Drawing.Point(117, 6);
            this.memoEdit2.Name = "memoEdit2";
            this.memoEdit2.Size = new System.Drawing.Size(358, 43);
            this.memoEdit2.TabIndex = 60;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(99, 13);
            this.labelControl2.TabIndex = 62;
            this.labelControl2.Text = "Società incorporante";
            // 
            // ErrorProviderModificaStatutaria
            // 
            this.ErrorProviderModificaStatutaria.ContainerControl = this;
            this.ErrorProviderModificaStatutaria.DataSource = this.bindingSourceBaseModificaStatutaria;
            // 
            // lookUpEditFormaGiuNuova
            // 
            this.lookUpEditFormaGiuNuova.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseModificaStatutaria, "IdNuovoStatoIscrizione", true));
            this.ErrorProviderModificaStatutaria.SetErrorType(this.lookUpEditFormaGiuNuova, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.lookUpEditFormaGiuNuova.Location = new System.Drawing.Point(81, 84);
            this.lookUpEditFormaGiuNuova.Name = "lookUpEditFormaGiuNuova";
            this.lookUpEditFormaGiuNuova.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditFormaGiuNuova.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descrizione", "Descrizione", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEditFormaGiuNuova.Properties.DataSource = this.bindingSourceBaseStato;
            this.lookUpEditFormaGiuNuova.Properties.DisplayMember = "Descrizione";
            this.lookUpEditFormaGiuNuova.Properties.NullText = "";
            this.lookUpEditFormaGiuNuova.Properties.ValueMember = "IdElemento";
            this.lookUpEditFormaGiuNuova.Size = new System.Drawing.Size(474, 20);
            this.lookUpEditFormaGiuNuova.TabIndex = 64;
            // 
            // bindingSourceBaseStato
            // 
            this.bindingSourceBaseStato.AutoCreateObjects = false;
            this.bindingSourceBaseStato.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // lookUpEditStato
            // 
            this.lookUpEditStato.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseModificaStatutaria, "IdVecchioStatoIscrizione", true));
            this.ErrorProviderModificaStatutaria.SetErrorType(this.lookUpEditStato, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.lookUpEditStato.Location = new System.Drawing.Point(81, 58);
            this.lookUpEditStato.Name = "lookUpEditStato";
            this.lookUpEditStato.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditStato.Properties.DataSource = this.bindingSourceBaseStato;
            this.lookUpEditStato.Properties.DisplayMember = "Descrizione";
            this.lookUpEditStato.Properties.NullText = "";
            this.lookUpEditStato.Properties.ReadOnly = true;
            this.lookUpEditStato.Properties.ValueMember = "IdElemento";
            this.lookUpEditStato.Size = new System.Drawing.Size(474, 20);
            this.lookUpEditStato.TabIndex = 67;
            this.lookUpEditStato.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 66;
            this.labelControl1.Text = "Stato attuale";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 87);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 13);
            this.labelControl6.TabIndex = 65;
            this.labelControl6.Text = "Stato nuovo";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 116);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(248, 13);
            this.labelControl3.TabIndex = 68;
            this.labelControl3.Text = "Atto di fusione: vedere società incorporante";
            // 
            // Fusione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Fusione";
            this.Size = new System.Drawing.Size(570, 177);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            this.ScrollableContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseModificaStatutaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseSocietaColl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderModificaStatutaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditFormaGiuNuova.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseStato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditStato.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OeF.Forms.BindingSourceBase bindingSourceBaseModificaStatutaria;
        private OeF.Forms.BindingSourceBase bindingSourceBaseSocietaColl;
        private OeF.Forms.Controls.SimpleButton btnViewSubject;
        private it.dedagroup.GVC.Client.Forms.Controls.SimpleButton btnSearchAssociation;
        private OeF.Forms.Controls.MemoEdit memoEdit2;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl2;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ErrorProviderModificaStatutaria;
        private OeF.Forms.BindingSourceBase bindingSourceBaseStato;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditFormaGiuNuova;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditStato;
        private OeF.Forms.Controls.LabelControl labelControl1;
        private OeF.Forms.Controls.LabelControl labelControl6;
        private OeF.Forms.Controls.LabelControl labelControl3;
    }
}
