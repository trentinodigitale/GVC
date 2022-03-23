namespace it.dedagroup.GVC.Client.Forms.Search.ModificheParix
{
    partial class ModificheParixSearch
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colVisible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescrizione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataSegnalazione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApply = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceCooperative = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDenominazione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroREA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnEspandiAll = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSelAll = new DevExpress.XtraEditors.SimpleButton();
            this.lbxtipoSegnalazione = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.bindingSourceTipoSegnalazioni = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioGroupApplicate = new DevExpress.XtraEditors.RadioGroup();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioGroupVisibili = new DevExpress.XtraEditors.RadioGroup();
            this.dtEditTo = new it.dedagroup.GVC.Client.Forms.Controls.DateEdit();
            this.dtEditFrom = new it.dedagroup.GVC.Client.Forms.Controls.DateEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchCoop = new DevExpress.XtraEditors.SimpleButton();
            this.tbxCoopCode = new DevExpress.XtraEditors.TextEdit();
            this.tbxCoopNRea = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblResult = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemStampa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCancellaLog = new DevExpress.XtraBars.BarButtonItem();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCooperative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbxtipoSegnalazione)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoSegnalazioni)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupApplicate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupVisibili.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditTo.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditFrom.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditFrom.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxCoopCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxCoopNRea.Properties)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarManager
            // 
            this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemStampa,
            this.barButtonItemCancellaLog});
            this.BarManager.MaxItemId = 17;
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.gridControl1);
            this.ScrollableContent.Controls.Add(this.xtraScrollableControl1);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 49);
            this.ScrollableContent.Size = new System.Drawing.Size(967, 410);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colVisible,
            this.colDescrizione,
            this.colDataSegnalazione,
            this.colApply});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowIndicator = false;
            // 
            // colVisible
            // 
            this.colVisible.Caption = "Visible";
            this.colVisible.FieldName = "Visible";
            this.colVisible.Name = "colVisible";
            this.colVisible.OptionsColumn.AllowEdit = false;
            this.colVisible.OptionsColumn.AllowFocus = false;
            this.colVisible.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colVisible.OptionsColumn.AllowMove = false;
            this.colVisible.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colVisible.OptionsFilter.AllowAutoFilter = false;
            this.colVisible.OptionsFilter.AllowFilter = false;
            this.colVisible.Visible = true;
            this.colVisible.VisibleIndex = 2;
            this.colVisible.Width = 90;
            // 
            // colDescrizione
            // 
            this.colDescrizione.Caption = "Descrizione";
            this.colDescrizione.FieldName = "Descrizione";
            this.colDescrizione.Name = "colDescrizione";
            this.colDescrizione.OptionsColumn.AllowEdit = false;
            this.colDescrizione.OptionsColumn.AllowFocus = false;
            this.colDescrizione.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDescrizione.OptionsColumn.AllowMove = false;
            this.colDescrizione.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDescrizione.OptionsFilter.AllowAutoFilter = false;
            this.colDescrizione.OptionsFilter.AllowFilter = false;
            this.colDescrizione.Visible = true;
            this.colDescrizione.VisibleIndex = 0;
            this.colDescrizione.Width = 398;
            // 
            // colDataSegnalazione
            // 
            this.colDataSegnalazione.Caption = "Data segnalazione";
            this.colDataSegnalazione.FieldName = "DataSegnalazione";
            this.colDataSegnalazione.Name = "colDataSegnalazione";
            this.colDataSegnalazione.OptionsColumn.AllowEdit = false;
            this.colDataSegnalazione.OptionsColumn.AllowFocus = false;
            this.colDataSegnalazione.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDataSegnalazione.OptionsColumn.AllowMove = false;
            this.colDataSegnalazione.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDataSegnalazione.OptionsFilter.AllowAutoFilter = false;
            this.colDataSegnalazione.OptionsFilter.AllowFilter = false;
            this.colDataSegnalazione.Visible = true;
            this.colDataSegnalazione.VisibleIndex = 1;
            this.colDataSegnalazione.Width = 106;
            // 
            // colApply
            // 
            this.colApply.Caption = "Applicato";
            this.colApply.FieldName = "Apply";
            this.colApply.Name = "colApply";
            this.colApply.OptionsColumn.AllowEdit = false;
            this.colApply.OptionsColumn.AllowFocus = false;
            this.colApply.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colApply.OptionsColumn.AllowMove = false;
            this.colApply.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colApply.OptionsFilter.AllowAutoFilter = false;
            this.colApply.OptionsFilter.AllowFilter = false;
            this.colApply.Visible = true;
            this.colApply.VisibleIndex = 3;
            this.colApply.Width = 73;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSourceCooperative;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "Segnalazioni";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 220);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(967, 190);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            this.gridControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseDoubleClick);
            // 
            // bindingSourceCooperative
            // 
            this.bindingSourceCooperative.AutoCreateObjects = false;
            this.bindingSourceCooperative.DataSource = typeof(it.dedagroup.GVC.Repository.Common.RicercheWrapper.CooperativaRicercaFDT);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDenominazione,
            this.colIdRegistro,
            this.colNumeroREA});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridView1.OptionsPrint.PrintDetails = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdRegistro, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colDenominazione
            // 
            this.colDenominazione.Caption = "Denominazione";
            this.colDenominazione.FieldName = "Denominazione";
            this.colDenominazione.Name = "colDenominazione";
            this.colDenominazione.OptionsColumn.AllowEdit = false;
            this.colDenominazione.OptionsColumn.AllowFocus = false;
            this.colDenominazione.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDenominazione.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDenominazione.OptionsColumn.AllowMove = false;
            this.colDenominazione.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDenominazione.OptionsFilter.AllowAutoFilter = false;
            this.colDenominazione.OptionsFilter.AllowFilter = false;
            this.colDenominazione.Visible = true;
            this.colDenominazione.VisibleIndex = 1;
            this.colDenominazione.Width = 404;
            // 
            // colIdRegistro
            // 
            this.colIdRegistro.Caption = "Codice cooperativa";
            this.colIdRegistro.FieldName = "IdRegistro";
            this.colIdRegistro.Name = "colIdRegistro";
            this.colIdRegistro.OptionsColumn.AllowEdit = false;
            this.colIdRegistro.OptionsColumn.AllowFocus = false;
            this.colIdRegistro.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIdRegistro.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colIdRegistro.OptionsColumn.AllowMove = false;
            this.colIdRegistro.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIdRegistro.OptionsFilter.AllowAutoFilter = false;
            this.colIdRegistro.OptionsFilter.AllowFilter = false;
            this.colIdRegistro.Visible = true;
            this.colIdRegistro.VisibleIndex = 0;
            this.colIdRegistro.Width = 114;
            // 
            // colNumeroREA
            // 
            this.colNumeroREA.Caption = "Numero REA";
            this.colNumeroREA.FieldName = "NumeroREA";
            this.colNumeroREA.Name = "colNumeroREA";
            this.colNumeroREA.OptionsColumn.AllowEdit = false;
            this.colNumeroREA.OptionsColumn.AllowFocus = false;
            this.colNumeroREA.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colNumeroREA.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colNumeroREA.OptionsColumn.AllowMove = false;
            this.colNumeroREA.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNumeroREA.OptionsFilter.AllowAutoFilter = false;
            this.colNumeroREA.OptionsFilter.AllowFilter = false;
            this.colNumeroREA.Visible = true;
            this.colNumeroREA.VisibleIndex = 2;
            this.colNumeroREA.Width = 146;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.bindingSourceCooperative;
            this.repositoryItemLookUpEdit1.DisplayMember = "NumeroREA";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "IdRegistro";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(105, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Data segnalazione dal";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(103, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(8, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "al";
            // 
            // btnEspandiAll
            // 
            this.btnEspandiAll.Location = new System.Drawing.Point(155, 192);
            this.btnEspandiAll.Name = "btnEspandiAll";
            this.btnEspandiAll.Size = new System.Drawing.Size(103, 23);
            this.btnEspandiAll.TabIndex = 74;
            this.btnEspandiAll.Tag = "1";
            this.btnEspandiAll.Text = "Espandi";
            this.btnEspandiAll.Click += new System.EventHandler(this.btnEspandiAll_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSelAll);
            this.groupBox3.Controls.Add(this.lbxtipoSegnalazione);
            this.groupBox3.Location = new System.Drawing.Point(451, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(502, 158);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo segnalazione";
            // 
            // btnSelAll
            // 
            this.btnSelAll.Location = new System.Drawing.Point(393, 20);
            this.btnSelAll.Name = "btnSelAll";
            this.btnSelAll.Size = new System.Drawing.Size(103, 23);
            this.btnSelAll.TabIndex = 1;
            this.btnSelAll.Tag = "1";
            this.btnSelAll.Text = "Deseleziona tutto";
            this.btnSelAll.Click += new System.EventHandler(this.btnSelAll_Click);
            // 
            // lbxtipoSegnalazione
            // 
            this.lbxtipoSegnalazione.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxtipoSegnalazione.Appearance.Options.UseFont = true;
            this.lbxtipoSegnalazione.CheckOnClick = true;
            this.lbxtipoSegnalazione.DataSource = this.bindingSourceTipoSegnalazioni;
            this.lbxtipoSegnalazione.DisplayMember = "Descrizione";
            this.lbxtipoSegnalazione.Location = new System.Drawing.Point(6, 18);
            this.lbxtipoSegnalazione.Name = "lbxtipoSegnalazione";
            this.lbxtipoSegnalazione.Size = new System.Drawing.Size(381, 134);
            this.lbxtipoSegnalazione.TabIndex = 0;
            this.lbxtipoSegnalazione.ValueMember = "Codice";
            // 
            // bindingSourceTipoSegnalazioni
            // 
            this.bindingSourceTipoSegnalazioni.AutoCreateObjects = false;
            this.bindingSourceTipoSegnalazioni.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioGroupApplicate);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.radioGroupVisibili);
            this.groupBox2.Controls.Add(this.dtEditTo);
            this.groupBox2.Controls.Add(this.dtEditFrom);
            this.groupBox2.Controls.Add(this.labelControl2);
            this.groupBox2.Controls.Add(this.labelControl1);
            this.groupBox2.Location = new System.Drawing.Point(218, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 158);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dati segnalazione";
            // 
            // radioGroupApplicate
            // 
            this.radioGroupApplicate.EditValue = 2;
            this.radioGroupApplicate.Location = new System.Drawing.Point(128, 90);
            this.radioGroupApplicate.Name = "radioGroupApplicate";
            this.radioGroupApplicate.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroupApplicate.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroupApplicate.Properties.Columns = 1;
            this.radioGroupApplicate.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Tutte"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Applicate"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Non applicate")});
            this.radioGroupApplicate.Size = new System.Drawing.Size(93, 64);
            this.radioGroupApplicate.TabIndex = 77;
            this.radioGroupApplicate.TabStop = false;
            this.radioGroupApplicate.SelectedIndexChanged += new System.EventHandler(this.radioGroupApplicate_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(1, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 1);
            this.panel1.TabIndex = 8;
            // 
            // radioGroupVisibili
            // 
            this.radioGroupVisibili.EditValue = 1;
            this.radioGroupVisibili.Location = new System.Drawing.Point(10, 90);
            this.radioGroupVisibili.Name = "radioGroupVisibili";
            this.radioGroupVisibili.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroupVisibili.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroupVisibili.Properties.Columns = 1;
            this.radioGroupVisibili.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Tutte"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Visibili"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Non visibili")});
            this.radioGroupVisibili.Size = new System.Drawing.Size(93, 64);
            this.radioGroupVisibili.TabIndex = 76;
            this.radioGroupVisibili.TabStop = false;
            this.radioGroupVisibili.SelectedIndexChanged += new System.EventHandler(this.radioGroupVisibili_SelectedIndexChanged);
            // 
            // dtEditTo
            // 
            this.dtEditTo.EditValue = null;
            this.dtEditTo.Location = new System.Drawing.Point(121, 51);
            this.dtEditTo.Name = "dtEditTo";
            this.dtEditTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEditTo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dtEditTo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtEditTo.Size = new System.Drawing.Size(100, 20);
            this.dtEditTo.TabIndex = 5;
            // 
            // dtEditFrom
            // 
            this.dtEditFrom.EditValue = null;
            this.dtEditFrom.Location = new System.Drawing.Point(121, 17);
            this.dtEditFrom.Name = "dtEditFrom";
            this.dtEditFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEditFrom.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dtEditFrom.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtEditFrom.Size = new System.Drawing.Size(100, 20);
            this.dtEditFrom.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchCoop);
            this.groupBox1.Controls.Add(this.tbxCoopCode);
            this.groupBox1.Controls.Add(this.tbxCoopNRea);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Location = new System.Drawing.Point(-4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 158);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dati cooperativa";
            // 
            // btnSearchCoop
            // 
            this.btnSearchCoop.Location = new System.Drawing.Point(80, 95);
            this.btnSearchCoop.Name = "btnSearchCoop";
            this.btnSearchCoop.Size = new System.Drawing.Size(75, 23);
            this.btnSearchCoop.TabIndex = 4;
            this.btnSearchCoop.Text = "Ricerca";
            this.btnSearchCoop.Click += new System.EventHandler(this.btnSearchCoop_Click);
            // 
            // tbxCoopCode
            // 
            this.tbxCoopCode.Location = new System.Drawing.Point(108, 17);
            this.tbxCoopCode.Name = "tbxCoopCode";
            this.tbxCoopCode.Size = new System.Drawing.Size(100, 20);
            this.tbxCoopCode.TabIndex = 1;
            // 
            // tbxCoopNRea
            // 
            this.tbxCoopNRea.Location = new System.Drawing.Point(108, 51);
            this.tbxCoopNRea.Name = "tbxCoopNRea";
            this.tbxCoopNRea.Size = new System.Drawing.Size(100, 20);
            this.tbxCoopNRea.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(6, 20);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(92, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Codice cooperativa";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(6, 58);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 13);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Numero REA";
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResult.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblResult.Appearance.Options.UseFont = true;
            this.lblResult.Location = new System.Drawing.Point(77, 201);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 201);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Risultati:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(376, 166);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(146, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Ricerca";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // bar1
            // 
            this.bar1.BarName = "PrintBar";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemStampa),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemCancellaLog)});
            this.bar1.Text = "PrintBar";
            // 
            // barButtonItemStampa
            // 
            this.barButtonItemStampa.Caption = "Stampa";
            this.barButtonItemStampa.Id = 15;
            this.barButtonItemStampa.Name = "barButtonItemStampa";
            this.barButtonItemStampa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemStampa_ItemClick);
            // 
            // barButtonItemCancellaLog
            // 
            this.barButtonItemCancellaLog.Caption = "Cancella log";
            this.barButtonItemCancellaLog.Id = 16;
            this.barButtonItemCancellaLog.Name = "barButtonItemCancellaLog";
            this.barButtonItemCancellaLog.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCancellaLog_ItemClick);
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.btnSearch);
            this.xtraScrollableControl1.Controls.Add(this.btnEspandiAll);
            this.xtraScrollableControl1.Controls.Add(this.lblResult);
            this.xtraScrollableControl1.Controls.Add(this.labelControl3);
            this.xtraScrollableControl1.Controls.Add(this.groupBox3);
            this.xtraScrollableControl1.Controls.Add(this.groupBox1);
            this.xtraScrollableControl1.Controls.Add(this.groupBox2);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(967, 220);
            this.xtraScrollableControl1.TabIndex = 75;
            // 
            // ModificheParixSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ModificheParixSearch";
            this.Size = new System.Drawing.Size(967, 459);
            this.Load += new System.EventHandler(this.ModificheParixSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCooperative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbxtipoSegnalazione)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoSegnalazioni)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupApplicate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupVisibili.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditTo.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditFrom.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditFrom.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxCoopCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxCoopNRea.Properties)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            this.xtraScrollableControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        
        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private it.dedagroup.GVC.Client.Forms.Controls.DateEdit dtEditTo;
        private it.dedagroup.GVC.Client.Forms.Controls.DateEdit dtEditFrom;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceCooperative;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit tbxCoopCode;
        private DevExpress.XtraEditors.SimpleButton btnSearchCoop;
        private DevExpress.XtraEditors.TextEdit tbxCoopNRea;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblResult;
        private DevExpress.XtraGrid.Columns.GridColumn colDenominazione;
        private DevExpress.XtraGrid.Columns.GridColumn colIdRegistro;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroREA;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.CheckedListBoxControl lbxtipoSegnalazione;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceTipoSegnalazioni;
        private DevExpress.XtraEditors.SimpleButton btnSelAll;
        private DevExpress.XtraGrid.Columns.GridColumn colVisible;
        private DevExpress.XtraGrid.Columns.GridColumn colDescrizione;
        private DevExpress.XtraGrid.Columns.GridColumn colDataSegnalazione;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemStampa;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCancellaLog;
        private DevExpress.XtraGrid.Columns.GridColumn colApply;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnEspandiAll;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.RadioGroup radioGroupApplicate;
        private DevExpress.XtraEditors.RadioGroup radioGroupVisibili;
       
    }
}
