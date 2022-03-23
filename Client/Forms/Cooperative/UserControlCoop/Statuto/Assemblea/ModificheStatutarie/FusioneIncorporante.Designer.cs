namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Statuto.Assemblea.ModificheStatutarie
{
    partial class FusioneIncorporante
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bindingSourceBaseSocietaColl = new OeF.Forms.BindingSourceBase(this.components);
            this.bindingSourceBaseModificaStatutaria = new OeF.Forms.BindingSourceBase(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControlSocieta = new DevExpress.XtraGrid.GridControl();
            this.gridViewSocieta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSocieta_DescrizioneBreve = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panelControl1 = new it.dedagroup.GVC.Client.Forms.Controls.PanelControl();
            this.btnRemove = new it.dedagroup.GVC.Client.Forms.Controls.SimpleButton();
            this.btnAdd = new it.dedagroup.GVC.Client.Forms.Controls.SimpleButton();
            this.ErrorProviderModificaStatutaria = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.textEdit6 = new it.dedagroup.GVC.Client.Forms.Controls.TextEdit();
            this.dateEdit3 = new OeF.Forms.Controls.DateEdit();
            this.dateEdit2 = new OeF.Forms.Controls.DateEdit();
            this.dateEdit1 = new OeF.Forms.Controls.DateEdit();
            this.btnViewSubject = new OeF.Forms.Controls.SimpleButton();
            this.labelControl15 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.btnSearchNotary = new it.dedagroup.GVC.Client.Forms.Controls.SimpleButton();
            this.labelControl3 = new OeF.Forms.Controls.LabelControl();
            this.labelControl2 = new OeF.Forms.Controls.LabelControl();
            this.labelControl5 = new OeF.Forms.Controls.LabelControl();
            this.btnRemoveSubject = new OeF.Forms.Controls.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseSocietaColl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseModificaStatutaria)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSocieta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSocieta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderModificaStatutaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit3.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.btnRemoveSubject);
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
            this.ScrollableContent.Controls.Add(this.groupBox1);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 24);
            this.ScrollableContent.Size = new System.Drawing.Size(570, 293);
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // bindingSourceBaseSocietaColl
            // 
            this.bindingSourceBaseSocietaColl.AutoCreateObjects = false;
            this.bindingSourceBaseSocietaColl.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.CollegamentoSocietaFDT);
            // 
            // bindingSourceBaseModificaStatutaria
            // 
            this.bindingSourceBaseModificaStatutaria.AutoCreateObjects = false;
            this.bindingSourceBaseModificaStatutaria.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.ModificaStatutariaFDT);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControlSocieta);
            this.groupBox1.Controls.Add(this.panelControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 167);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Società incorporate";
            // 
            // gridControlSocieta
            // 
            this.gridControlSocieta.DataSource = this.bindingSourceBaseSocietaColl;
            this.gridControlSocieta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSocieta.Location = new System.Drawing.Point(3, 49);
            this.gridControlSocieta.MainView = this.gridViewSocieta;
            this.gridControlSocieta.Name = "gridControlSocieta";
            this.gridControlSocieta.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControlSocieta.Size = new System.Drawing.Size(525, 115);
            this.gridControlSocieta.TabIndex = 1;
            this.gridControlSocieta.TabStop = false;
            this.gridControlSocieta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSocieta});
            this.gridControlSocieta.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlSocieta_MouseDoubleClick);
            // 
            // gridViewSocieta
            // 
            this.gridViewSocieta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSocieta_DescrizioneBreve,
            this.colStatus});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout);
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colStatus;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual;
            styleFormatCondition1.Value1 = "100";
            this.gridViewSocieta.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridViewSocieta.GridControl = this.gridControlSocieta;
            this.gridViewSocieta.Name = "gridViewSocieta";
            this.gridViewSocieta.OptionsMenu.EnableColumnMenu = false;
            this.gridViewSocieta.OptionsMenu.EnableFooterMenu = false;
            this.gridViewSocieta.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewSocieta.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewSocieta.OptionsView.ShowGroupPanel = false;
            this.gridViewSocieta.OptionsView.ShowIndicator = false;
            // 
            // colSocieta_DescrizioneBreve
            // 
            this.colSocieta_DescrizioneBreve.Caption = "Denominazione";
            this.colSocieta_DescrizioneBreve.FieldName = "Societa_DescrizioneBreve";
            this.colSocieta_DescrizioneBreve.Name = "colSocieta_DescrizioneBreve";
            this.colSocieta_DescrizioneBreve.OptionsColumn.AllowEdit = false;
            this.colSocieta_DescrizioneBreve.OptionsColumn.AllowFocus = false;
            this.colSocieta_DescrizioneBreve.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colSocieta_DescrizioneBreve.OptionsColumn.AllowMove = false;
            this.colSocieta_DescrizioneBreve.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSocieta_DescrizioneBreve.Visible = true;
            this.colSocieta_DescrizioneBreve.VisibleIndex = 0;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DisplayMember = "Codice";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ValueMember = "IdElemento";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnRemove);
            this.panelControl1.Controls.Add(this.btnAdd);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(3, 17);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(525, 32);
            this.panelControl1.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(445, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.TabStop = false;
            this.btnRemove.Text = "Rimuovi";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(364, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Aggiungi";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ErrorProviderModificaStatutaria
            // 
            this.ErrorProviderModificaStatutaria.ContainerControl = this;
            this.ErrorProviderModificaStatutaria.DataSource = this.bindingSourceBaseModificaStatutaria;
            // 
            // textEdit6
            // 
            this.textEdit6.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseModificaStatutaria, "Notaio_DescrizioneBreve", true));
            this.ErrorProviderModificaStatutaria.SetErrorType(this.textEdit6, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.textEdit6.Location = new System.Drawing.Point(52, 234);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Size = new System.Drawing.Size(328, 20);
            this.textEdit6.TabIndex = 84;
            // 
            // dateEdit3
            // 
            this.dateEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseModificaStatutaria, "DataEfficaciaAtto", true));
            this.dateEdit3.EditValue = null;
            this.ErrorProviderModificaStatutaria.SetErrorType(this.dateEdit3, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.dateEdit3.Location = new System.Drawing.Point(110, 205);
            this.dateEdit3.Name = "dateEdit3";
            this.dateEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit3.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit3.Size = new System.Drawing.Size(100, 20);
            this.dateEdit3.TabIndex = 83;
            // 
            // dateEdit2
            // 
            this.dateEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseModificaStatutaria, "DataIscrizioneAtto", true));
            this.dateEdit2.EditValue = null;
            this.ErrorProviderModificaStatutaria.SetErrorType(this.dateEdit2, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.dateEdit2.Location = new System.Drawing.Point(344, 179);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit2.Size = new System.Drawing.Size(100, 20);
            this.dateEdit2.TabIndex = 82;
            // 
            // dateEdit1
            // 
            this.dateEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseModificaStatutaria, "DataAttoFusioneScissione", true));
            this.dateEdit1.EditValue = null;
            this.ErrorProviderModificaStatutaria.SetErrorType(this.dateEdit1, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.dateEdit1.Location = new System.Drawing.Point(110, 179);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(100, 20);
            this.dateEdit1.TabIndex = 81;
            // 
            // btnViewSubject
            // 
            this.btnViewSubject.Location = new System.Drawing.Point(386, 231);
            this.btnViewSubject.Name = "btnViewSubject";
            this.btnViewSubject.Size = new System.Drawing.Size(26, 23);
            this.btnViewSubject.TabIndex = 90;
            this.btnViewSubject.TabStop = false;
            this.btnViewSubject.Click += new System.EventHandler(this.btnViewSubject_Click);
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(15, 237);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(31, 13);
            this.labelControl15.TabIndex = 88;
            this.labelControl15.Text = "Notaio";
            // 
            // btnSearchNotary
            // 
            this.btnSearchNotary.Location = new System.Drawing.Point(450, 231);
            this.btnSearchNotary.Name = "btnSearchNotary";
            this.btnSearchNotary.Size = new System.Drawing.Size(93, 23);
            this.btnSearchNotary.TabIndex = 89;
            this.btnSearchNotary.TabStop = false;
            this.btnSearchNotary.Text = "Ricerca";
            this.btnSearchNotary.Click += new System.EventHandler(this.btnSearchNotary_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 205);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(89, 13);
            this.labelControl3.TabIndex = 87;
            this.labelControl3.Text = "Data efficacia atto";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(255, 182);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 13);
            this.labelControl2.TabIndex = 86;
            this.labelControl2.Text = "Data iscrizione RI";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(15, 179);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(84, 13);
            this.labelControl5.TabIndex = 85;
            this.labelControl5.Text = "Data atto fusione";
            // 
            // btnRemoveSubject
            // 
            this.btnRemoveSubject.Location = new System.Drawing.Point(418, 231);
            this.btnRemoveSubject.Name = "btnRemoveSubject";
            this.btnRemoveSubject.Size = new System.Drawing.Size(26, 23);
            this.btnRemoveSubject.TabIndex = 143;
            this.btnRemoveSubject.TabStop = false;
            this.btnRemoveSubject.Click += new System.EventHandler(this.btnRemoveSubject_Click);
            // 
            // FusioneIncorporante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "FusioneIncorporante";
            this.Size = new System.Drawing.Size(570, 317);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            this.ScrollableContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseSocietaColl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseModificaStatutaria)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSocieta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSocieta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderModificaStatutaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit3.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OeF.Forms.BindingSourceBase bindingSourceBaseSocietaColl;
        private OeF.Forms.BindingSourceBase bindingSourceBaseModificaStatutaria;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gridControlSocieta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSocieta;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private it.dedagroup.GVC.Client.Forms.Controls.PanelControl panelControl1;
        private it.dedagroup.GVC.Client.Forms.Controls.SimpleButton btnRemove;
        private it.dedagroup.GVC.Client.Forms.Controls.SimpleButton btnAdd;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ErrorProviderModificaStatutaria;
        private OeF.Forms.Controls.SimpleButton btnViewSubject;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl15;
        private it.dedagroup.GVC.Client.Forms.Controls.SimpleButton btnSearchNotary;
        private it.dedagroup.GVC.Client.Forms.Controls.TextEdit textEdit6;
        private OeF.Forms.Controls.DateEdit dateEdit3;
        private OeF.Forms.Controls.LabelControl labelControl3;
        private OeF.Forms.Controls.DateEdit dateEdit2;
        private OeF.Forms.Controls.LabelControl labelControl2;
        private OeF.Forms.Controls.DateEdit dateEdit1;
        private OeF.Forms.Controls.LabelControl labelControl5;
        private DevExpress.XtraGrid.Columns.GridColumn colSocieta_DescrizioneBreve;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private OeF.Forms.Controls.SimpleButton btnRemoveSubject;
    }
}
