namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Data
{
    partial class Activities
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
            this.bindingSourceBaseActivities = new OeF.Forms.BindingSourceBase(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoveActivity = new OeF.Forms.Controls.SimpleButton();
            this.btnAddActivity = new OeF.Forms.Controls.SimpleButton();
            this.panelControlSearchFields = new OeF.Forms.Controls.PanelControl();
            this.simpleButton1 = new OeF.Forms.Controls.SimpleButton();
            this.textEdit1 = new it.dedagroup.GVC.Client.Forms.Controls.TextEdit();
            this.panelControl1 = new it.dedagroup.GVC.Client.Forms.Controls.PanelControl();
            this.gridControlActivityParix = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceBaseActivitiesParix = new OeF.Forms.BindingSourceBase(this.components);
            this.gridViewActivityParix = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdActivityType2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit8 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bindingSourceActivityTypes = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.colIdActivity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit7 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colImportance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBeginDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.labelControl3 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.labelControl2 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControlParix();
            this.panelControlGrid = new it.dedagroup.GVC.Client.Forms.Controls.PanelControl();
            this.gridControlActivities = new DevExpress.XtraGrid.GridControl();
            this.gridViewActivities = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdActivityType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colIdActivityType1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseActivities)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlSearchFields)).BeginInit();
            this.panelControlSearchFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlActivityParix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseActivitiesParix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewActivityParix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActivityTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlGrid)).BeginInit();
            this.panelControlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlActivities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewActivities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.groupBox1);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 24);
            this.ScrollableContent.Size = new System.Drawing.Size(628, 323);
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // bindingSourceBaseActivities
            // 
            this.bindingSourceBaseActivities.AutoCreateObjects = false;
            this.bindingSourceBaseActivities.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.AttivitaFDT);
            this.bindingSourceBaseActivities.CurrentChanged += new System.EventHandler(this.bindingSourceBaseActivities_CurrentChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoveActivity);
            this.groupBox1.Controls.Add(this.btnAddActivity);
            this.groupBox1.Controls.Add(this.panelControlSearchFields);
            this.groupBox1.Controls.Add(this.panelControl1);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.panelControlGrid);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 323);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elenco Attività";
            // 
            // btnRemoveActivity
            // 
            this.btnRemoveActivity.Location = new System.Drawing.Point(430, 12);
            this.btnRemoveActivity.Name = "btnRemoveActivity";
            this.btnRemoveActivity.Size = new System.Drawing.Size(63, 23);
            this.btnRemoveActivity.TabIndex = 38;
            this.btnRemoveActivity.Text = "Rimuovi";
            this.btnRemoveActivity.Click += new System.EventHandler(this.btnRemoveActivity_Click);
            // 
            // btnAddActivity
            // 
            this.btnAddActivity.Location = new System.Drawing.Point(361, 12);
            this.btnAddActivity.Name = "btnAddActivity";
            this.btnAddActivity.Size = new System.Drawing.Size(63, 23);
            this.btnAddActivity.TabIndex = 38;
            this.btnAddActivity.Text = "Aggiungi";
            this.btnAddActivity.Click += new System.EventHandler(this.btnAddActivity_Click);
            // 
            // panelControlSearchFields
            // 
            this.panelControlSearchFields.Controls.Add(this.simpleButton1);
            this.panelControlSearchFields.Controls.Add(this.textEdit1);
            this.panelControlSearchFields.Location = new System.Drawing.Point(520, 62);
            this.panelControlSearchFields.Name = "panelControlSearchFields";
            this.panelControlSearchFields.Size = new System.Drawing.Size(101, 61);
            this.panelControlSearchFields.TabIndex = 39;
            this.panelControlSearchFields.Visible = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(15, 31);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(63, 23);
            this.simpleButton1.TabIndex = 38;
            this.simpleButton1.Text = "Ricerca";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(5, 5);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(73, 20);
            this.textEdit1.TabIndex = 39;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControlActivityParix);
            this.panelControl1.Location = new System.Drawing.Point(15, 194);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(608, 104);
            this.panelControl1.TabIndex = 40;
            // 
            // gridControlActivityParix
            // 
            this.gridControlActivityParix.DataSource = this.bindingSourceBaseActivitiesParix;
            this.gridControlActivityParix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlActivityParix.EmbeddedNavigator.Name = "";
            this.gridControlActivityParix.Location = new System.Drawing.Point(2, 2);
            this.gridControlActivityParix.MainView = this.gridViewActivityParix;
            this.gridControlActivityParix.Name = "gridControlActivityParix";
            this.gridControlActivityParix.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit6,
            this.repositoryItemLookUpEdit4,
            this.repositoryItemLookUpEdit5,
            this.repositoryItemLookUpEdit7,
            this.repositoryItemLookUpEdit8});
            this.gridControlActivityParix.Size = new System.Drawing.Size(604, 100);
            this.gridControlActivityParix.TabIndex = 35;
            this.gridControlActivityParix.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewActivityParix});
            // 
            // bindingSourceBaseActivitiesParix
            // 
            this.bindingSourceBaseActivitiesParix.AutoCreateObjects = false;
            this.bindingSourceBaseActivitiesParix.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.AttivitaFDT);
            // 
            // gridViewActivityParix
            // 
            this.gridViewActivityParix.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdActivityType2,
            this.colIdActivity,
            this.colImportance,
            this.colBeginDate});
            this.gridViewActivityParix.GridControl = this.gridControlActivityParix;
            this.gridViewActivityParix.Name = "gridViewActivityParix";
            this.gridViewActivityParix.OptionsBehavior.Editable = false;
            this.gridViewActivityParix.OptionsMenu.EnableColumnMenu = false;
            this.gridViewActivityParix.OptionsMenu.EnableFooterMenu = false;
            this.gridViewActivityParix.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewActivityParix.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewActivityParix.OptionsView.ShowGroupPanel = false;
            this.gridViewActivityParix.OptionsView.ShowIndicator = false;
            // 
            // colIdActivityType2
            // 
            this.colIdActivityType2.Caption = "Codice";
            this.colIdActivityType2.ColumnEdit = this.repositoryItemLookUpEdit8;
            this.colIdActivityType2.FieldName = "IdTipoAttivita";
            this.colIdActivityType2.Name = "colIdActivityType2";
            this.colIdActivityType2.OptionsColumn.AllowEdit = false;
            this.colIdActivityType2.OptionsColumn.AllowFocus = false;
            this.colIdActivityType2.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIdActivityType2.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colIdActivityType2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIdActivityType2.OptionsFilter.AllowAutoFilter = false;
            this.colIdActivityType2.OptionsFilter.AllowFilter = false;
            this.colIdActivityType2.Visible = true;
            this.colIdActivityType2.VisibleIndex = 0;
            this.colIdActivityType2.Width = 59;
            // 
            // repositoryItemLookUpEdit8
            // 
            this.repositoryItemLookUpEdit8.AutoHeight = false;
            this.repositoryItemLookUpEdit8.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit8.DataSource = this.bindingSourceActivityTypes;
            this.repositoryItemLookUpEdit8.DisplayMember = "Codice";
            this.repositoryItemLookUpEdit8.Name = "repositoryItemLookUpEdit8";
            this.repositoryItemLookUpEdit8.ValueMember = "IdElemento";
            // 
            // bindingSourceActivityTypes
            // 
            this.bindingSourceActivityTypes.AutoCreateObjects = false;
            this.bindingSourceActivityTypes.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // colIdActivity
            // 
            this.colIdActivity.Caption = "Descrizione";
            this.colIdActivity.ColumnEdit = this.repositoryItemLookUpEdit7;
            this.colIdActivity.FieldName = "IdTipoAttivita";
            this.colIdActivity.Name = "colIdActivity";
            this.colIdActivity.OptionsColumn.AllowEdit = false;
            this.colIdActivity.OptionsColumn.AllowFocus = false;
            this.colIdActivity.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIdActivity.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colIdActivity.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIdActivity.OptionsFilter.AllowAutoFilter = false;
            this.colIdActivity.OptionsFilter.AllowFilter = false;
            this.colIdActivity.Visible = true;
            this.colIdActivity.VisibleIndex = 1;
            this.colIdActivity.Width = 410;
            // 
            // repositoryItemLookUpEdit7
            // 
            this.repositoryItemLookUpEdit7.AutoHeight = false;
            this.repositoryItemLookUpEdit7.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit7.DataSource = this.bindingSourceActivityTypes;
            this.repositoryItemLookUpEdit7.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit7.Name = "repositoryItemLookUpEdit7";
            this.repositoryItemLookUpEdit7.ValueMember = "IdElemento";
            // 
            // colImportance
            // 
            this.colImportance.Caption = "Importanza";
            this.colImportance.FieldName = "Importanza";
            this.colImportance.Name = "colImportance";
            this.colImportance.OptionsColumn.AllowEdit = false;
            this.colImportance.OptionsColumn.AllowFocus = false;
            this.colImportance.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colImportance.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colImportance.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colImportance.OptionsFilter.AllowAutoFilter = false;
            this.colImportance.OptionsFilter.AllowFilter = false;
            this.colImportance.Visible = true;
            this.colImportance.VisibleIndex = 2;
            this.colImportance.Width = 88;
            // 
            // colBeginDate
            // 
            this.colBeginDate.Caption = "Data inizio";
            this.colBeginDate.DisplayFormat.FormatString = "d";
            this.colBeginDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colBeginDate.FieldName = "DataInizio";
            this.colBeginDate.Name = "colBeginDate";
            this.colBeginDate.OptionsColumn.AllowEdit = false;
            this.colBeginDate.OptionsColumn.AllowFocus = false;
            this.colBeginDate.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colBeginDate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colBeginDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBeginDate.OptionsFilter.AllowAutoFilter = false;
            this.colBeginDate.OptionsFilter.AllowFilter = false;
            this.colBeginDate.Visible = true;
            this.colBeginDate.VisibleIndex = 3;
            this.colBeginDate.Width = 110;
            // 
            // repositoryItemLookUpEdit6
            // 
            this.repositoryItemLookUpEdit6.AutoHeight = false;
            this.repositoryItemLookUpEdit6.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit6.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit6.Name = "repositoryItemLookUpEdit6";
            this.repositoryItemLookUpEdit6.ValueMember = "IdElemento";
            // 
            // repositoryItemLookUpEdit4
            // 
            this.repositoryItemLookUpEdit4.AutoHeight = false;
            this.repositoryItemLookUpEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit4.DataSource = this.bindingSourceActivityTypes;
            this.repositoryItemLookUpEdit4.DisplayMember = "Code";
            this.repositoryItemLookUpEdit4.Name = "repositoryItemLookUpEdit4";
            this.repositoryItemLookUpEdit4.ValueMember = "IdElemento";
            // 
            // repositoryItemLookUpEdit5
            // 
            this.repositoryItemLookUpEdit5.AutoHeight = false;
            this.repositoryItemLookUpEdit5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit5.DataSource = this.bindingSourceActivityTypes;
            this.repositoryItemLookUpEdit5.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit5.Name = "repositoryItemLookUpEdit5";
            this.repositoryItemLookUpEdit5.ValueMember = "IdElemento";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 20);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(119, 13);
            this.labelControl3.TabIndex = 28;
            this.labelControl3.Text = "Elenco attività esercitate";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(15, 175);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(174, 13);
            this.labelControl2.TabIndex = 27;
            this.labelControl2.Text = "Elenco attività recuperate da CCIAA";
            // 
            // panelControlGrid
            // 
            this.panelControlGrid.Controls.Add(this.gridControlActivities);
            this.panelControlGrid.Location = new System.Drawing.Point(15, 39);
            this.panelControlGrid.Name = "panelControlGrid";
            this.panelControlGrid.Size = new System.Drawing.Size(480, 130);
            this.panelControlGrid.TabIndex = 37;
            // 
            // gridControlActivities
            // 
            this.gridControlActivities.DataSource = this.bindingSourceBaseActivities;
            this.gridControlActivities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlActivities.EmbeddedNavigator.Name = "";
            this.gridControlActivities.Location = new System.Drawing.Point(2, 2);
            this.gridControlActivities.MainView = this.gridViewActivities;
            this.gridControlActivities.Name = "gridControlActivities";
            this.gridControlActivities.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemLookUpEdit3});
            this.gridControlActivities.Size = new System.Drawing.Size(476, 126);
            this.gridControlActivities.TabIndex = 35;
            this.gridControlActivities.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewActivities});
            // 
            // gridViewActivities
            // 
            this.gridViewActivities.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdActivityType,
            this.colIdActivityType1,
            this.colStatus});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout);
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colStatus;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual;
            styleFormatCondition1.Value1 = 100;
            this.gridViewActivities.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridViewActivities.GridControl = this.gridControlActivities;
            this.gridViewActivities.Name = "gridViewActivities";
            this.gridViewActivities.OptionsBehavior.Editable = false;
            this.gridViewActivities.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewActivities.OptionsView.ShowGroupPanel = false;
            this.gridViewActivities.OptionsView.ShowIndicator = false;
            // 
            // colIdActivityType
            // 
            this.colIdActivityType.Caption = "Codice";
            this.colIdActivityType.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colIdActivityType.FieldName = "IdTipoAttivita";
            this.colIdActivityType.Name = "colIdActivityType";
            this.colIdActivityType.OptionsColumn.AllowEdit = false;
            this.colIdActivityType.OptionsColumn.AllowFocus = false;
            this.colIdActivityType.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIdActivityType.OptionsColumn.AllowMove = false;
            this.colIdActivityType.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIdActivityType.OptionsFilter.AllowAutoFilter = false;
            this.colIdActivityType.OptionsFilter.AllowFilter = false;
            this.colIdActivityType.Visible = true;
            this.colIdActivityType.VisibleIndex = 0;
            this.colIdActivityType.Width = 136;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.DataSource = this.bindingSourceActivityTypes;
            this.repositoryItemLookUpEdit2.DisplayMember = "Codice";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ValueMember = "IdElemento";
            // 
            // colIdActivityType1
            // 
            this.colIdActivityType1.Caption = "Descrizione";
            this.colIdActivityType1.ColumnEdit = this.repositoryItemLookUpEdit3;
            this.colIdActivityType1.FieldName = "IdTipoAttivita";
            this.colIdActivityType1.Name = "colIdActivityType1";
            this.colIdActivityType1.OptionsColumn.AllowEdit = false;
            this.colIdActivityType1.OptionsColumn.AllowFocus = false;
            this.colIdActivityType1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIdActivityType1.OptionsColumn.AllowMove = false;
            this.colIdActivityType1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIdActivityType1.OptionsFilter.AllowAutoFilter = false;
            this.colIdActivityType1.OptionsFilter.AllowFilter = false;
            this.colIdActivityType1.Visible = true;
            this.colIdActivityType1.VisibleIndex = 1;
            this.colIdActivityType1.Width = 531;
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.DataSource = this.bindingSourceActivityTypes;
            this.repositoryItemLookUpEdit3.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.ValueMember = "IdElemento";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "IdElemento";
            // 
            // Activities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Activities";
            this.Size = new System.Drawing.Size(628, 347);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseActivities)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlSearchFields)).EndInit();
            this.panelControlSearchFields.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlActivityParix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseActivitiesParix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewActivityParix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActivityTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlGrid)).EndInit();
            this.panelControlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlActivities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewActivities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private OeF.Forms.Controls.PanelControl panelControlSearchFields;
        private OeF.Forms.Controls.SimpleButton simpleButton1;
        private it.dedagroup.GVC.Client.Forms.Controls.TextEdit textEdit1;
        private it.dedagroup.GVC.Client.Forms.Controls.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControlActivityParix;
        private OeF.Forms.BindingSourceBase bindingSourceBaseActivitiesParix;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewActivityParix;
        private DevExpress.XtraGrid.Columns.GridColumn colIdActivityType2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit8;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceActivityTypes;
        private DevExpress.XtraGrid.Columns.GridColumn colIdActivity;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit7;
        private DevExpress.XtraGrid.Columns.GridColumn colImportance;
        private DevExpress.XtraGrid.Columns.GridColumn colBeginDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit6;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit4;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit5;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl3;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControlParix labelControl2;
        private it.dedagroup.GVC.Client.Forms.Controls.PanelControl panelControlGrid;
        private DevExpress.XtraGrid.GridControl gridControlActivities;
        private OeF.Forms.BindingSourceBase bindingSourceBaseActivities;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewActivities;
        private DevExpress.XtraGrid.Columns.GridColumn colIdActivityType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdActivityType1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private OeF.Forms.Controls.SimpleButton btnRemoveActivity;
        private OeF.Forms.Controls.SimpleButton btnAddActivity;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
    }
}
