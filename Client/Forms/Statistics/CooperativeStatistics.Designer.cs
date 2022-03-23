namespace it.dedagroup.GVC.Client.Forms.Statistics
{
    partial class CooperativeStatistics
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemStampa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExportResults = new DevExpress.XtraBars.BarButtonItem();
            this.PnlCntSearch = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl2 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.StatoCategoria = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl1 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.DataFinoAl = new it.dedagroup.GVC.Client.Forms.Controls.DateEdit();
            this.btnSearch = new OeF.Forms.Controls.SimpleButton();
            this.gridControlStatisticaCooperative = new DevExpress.XtraGrid.GridControl();
            this.gridViewStatisticaCooperative = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCategoriaCodice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoriaDescrizione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCooperativeCancellate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCooperativeIscritteDataDalAl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCooperativeAderentiDataDalAl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCooperativeIscritteTotale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            this.PnlCntSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatoCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataFinoAl.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataFinoAl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStatisticaCooperative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStatisticaCooperative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarManager
            // 
            this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemStampa,
            this.barButtonItemExportResults});
            this.BarManager.MaxItemId = 11;
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.gridControlStatisticaCooperative);
            this.ScrollableContent.Controls.Add(this.PnlCntSearch);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 49);
            this.ScrollableContent.Size = new System.Drawing.Size(707, 342);
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemStampa),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemExportResults)});
            this.bar1.Text = "Custom 2";
            // 
            // barButtonItemStampa
            // 
            this.barButtonItemStampa.Caption = "Stampa";
            this.barButtonItemStampa.Id = 9;
            this.barButtonItemStampa.Name = "barButtonItemStampa";
            this.barButtonItemStampa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemStampa_ItemClick);
            // 
            // barButtonItemExportResults
            // 
            this.barButtonItemExportResults.Caption = "Esporta risultati";
            this.barButtonItemExportResults.Id = 10;
            this.barButtonItemExportResults.Name = "barButtonItemExportResults";
            this.barButtonItemExportResults.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemExportResults_ItemClick);
            // 
            // PnlCntSearch
            // 
            this.PnlCntSearch.Controls.Add(this.groupBox1);
            this.PnlCntSearch.Controls.Add(this.btnSearch);
            this.PnlCntSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlCntSearch.Location = new System.Drawing.Point(0, 0);
            this.PnlCntSearch.Name = "PnlCntSearch";
            this.PnlCntSearch.Size = new System.Drawing.Size(707, 121);
            this.PnlCntSearch.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.StatoCategoria);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.DataFinoAl);
            this.groupBox1.Location = new System.Drawing.Point(16, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 57);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dati statistica cooperative ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 23);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(130, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Periodo di interrogazione al";
            // 
            // StatoCategoria
            // 
            this.StatoCategoria.Location = new System.Drawing.Point(323, 20);
            this.StatoCategoria.Name = "StatoCategoria";
            this.StatoCategoria.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.StatoCategoria.Properties.Appearance.Options.UseBackColor = true;
            this.StatoCategoria.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.StatoCategoria.Properties.Columns = 2;
            this.StatoCategoria.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Tutte"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Solo attive")});
            this.StatoCategoria.Size = new System.Drawing.Size(148, 20);
            this.StatoCategoria.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(270, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Categorie";
            // 
            // DataFinoAl
            // 
            this.DataFinoAl.EditValue = null;
            this.DataFinoAl.Location = new System.Drawing.Point(152, 20);
            this.DataFinoAl.Name = "DataFinoAl";
            this.DataFinoAl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DataFinoAl.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.DataFinoAl.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.DataFinoAl.Size = new System.Drawing.Size(100, 20);
            this.DataFinoAl.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(232, 81);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Ricerca";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gridControlStatisticaCooperative
            // 
            this.gridControlStatisticaCooperative.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlStatisticaCooperative.Location = new System.Drawing.Point(0, 121);
            this.gridControlStatisticaCooperative.MainView = this.gridViewStatisticaCooperative;
            this.gridControlStatisticaCooperative.Name = "gridControlStatisticaCooperative";
            this.gridControlStatisticaCooperative.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControlStatisticaCooperative.Size = new System.Drawing.Size(707, 221);
            this.gridControlStatisticaCooperative.TabIndex = 3;
            this.gridControlStatisticaCooperative.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewStatisticaCooperative,
            this.gridView1});
            // 
            // gridViewStatisticaCooperative
            // 
            this.gridViewStatisticaCooperative.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCategoriaCodice,
            this.colCategoriaDescrizione,
            this.colCooperativeCancellate,
            this.colCooperativeIscritteDataDalAl,
            this.colCooperativeAderentiDataDalAl,
            this.colCooperativeIscritteTotale});
            this.gridViewStatisticaCooperative.GridControl = this.gridControlStatisticaCooperative;
            this.gridViewStatisticaCooperative.Name = "gridViewStatisticaCooperative";
            this.gridViewStatisticaCooperative.OptionsMenu.EnableColumnMenu = false;
            this.gridViewStatisticaCooperative.OptionsMenu.EnableFooterMenu = false;
            this.gridViewStatisticaCooperative.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewStatisticaCooperative.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewStatisticaCooperative.OptionsView.ShowGroupPanel = false;
            this.gridViewStatisticaCooperative.OptionsView.ShowIndicator = false;
            // 
            // colCategoriaCodice
            // 
            this.colCategoriaCodice.AppearanceHeader.Options.UseTextOptions = true;
            this.colCategoriaCodice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCategoriaCodice.Caption = "Codice";
            this.colCategoriaCodice.FieldName = "CODICE";
            this.colCategoriaCodice.Name = "colCategoriaCodice";
            this.colCategoriaCodice.OptionsColumn.AllowEdit = false;
            this.colCategoriaCodice.OptionsColumn.AllowFocus = false;
            this.colCategoriaCodice.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCategoriaCodice.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colCategoriaCodice.OptionsColumn.AllowMove = false;
            this.colCategoriaCodice.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCategoriaCodice.OptionsFilter.AllowAutoFilter = false;
            this.colCategoriaCodice.OptionsFilter.AllowFilter = false;
            this.colCategoriaCodice.Visible = true;
            this.colCategoriaCodice.VisibleIndex = 0;
            this.colCategoriaCodice.Width = 111;
            // 
            // colCategoriaDescrizione
            // 
            this.colCategoriaDescrizione.AppearanceHeader.Options.UseTextOptions = true;
            this.colCategoriaDescrizione.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCategoriaDescrizione.Caption = "Descrizione";
            this.colCategoriaDescrizione.FieldName = "DESCRIZIONE";
            this.colCategoriaDescrizione.Name = "colCategoriaDescrizione";
            this.colCategoriaDescrizione.OptionsColumn.AllowEdit = false;
            this.colCategoriaDescrizione.OptionsColumn.AllowFocus = false;
            this.colCategoriaDescrizione.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCategoriaDescrizione.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colCategoriaDescrizione.OptionsColumn.AllowMove = false;
            this.colCategoriaDescrizione.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCategoriaDescrizione.OptionsFilter.AllowAutoFilter = false;
            this.colCategoriaDescrizione.OptionsFilter.AllowFilter = false;
            this.colCategoriaDescrizione.Visible = true;
            this.colCategoriaDescrizione.VisibleIndex = 1;
            this.colCategoriaDescrizione.Width = 468;
            // 
            // colCooperativeCancellate
            // 
            this.colCooperativeCancellate.AppearanceHeader.Options.UseTextOptions = true;
            this.colCooperativeCancellate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCooperativeCancellate.Caption = "Cancellate";
            this.colCooperativeCancellate.FieldName = "COOPERATIVE_CANCELLATE";
            this.colCooperativeCancellate.Name = "colCooperativeCancellate";
            this.colCooperativeCancellate.OptionsColumn.AllowEdit = false;
            this.colCooperativeCancellate.OptionsColumn.AllowFocus = false;
            this.colCooperativeCancellate.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCooperativeCancellate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colCooperativeCancellate.OptionsColumn.AllowMove = false;
            this.colCooperativeCancellate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCooperativeCancellate.OptionsFilter.AllowAutoFilter = false;
            this.colCooperativeCancellate.OptionsFilter.AllowFilter = false;
            this.colCooperativeCancellate.Visible = true;
            this.colCooperativeCancellate.VisibleIndex = 2;
            this.colCooperativeCancellate.Width = 108;
            // 
            // colCooperativeIscritteDataDalAl
            // 
            this.colCooperativeIscritteDataDalAl.Caption = "Iscritte dal al";
            this.colCooperativeIscritteDataDalAl.FieldName = "COOPERATIVE_ISCRITTE_DATA_DAL_AL";
            this.colCooperativeIscritteDataDalAl.Name = "colCooperativeIscritteDataDalAl";
            this.colCooperativeIscritteDataDalAl.OptionsColumn.AllowEdit = false;
            this.colCooperativeIscritteDataDalAl.OptionsColumn.AllowFocus = false;
            this.colCooperativeIscritteDataDalAl.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCooperativeIscritteDataDalAl.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colCooperativeIscritteDataDalAl.OptionsColumn.AllowMove = false;
            this.colCooperativeIscritteDataDalAl.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCooperativeIscritteDataDalAl.Visible = true;
            this.colCooperativeIscritteDataDalAl.VisibleIndex = 3;
            this.colCooperativeIscritteDataDalAl.Width = 112;
            // 
            // colCooperativeAderentiDataDalAl
            // 
            this.colCooperativeAderentiDataDalAl.Caption = "Aderenti dal al";
            this.colCooperativeAderentiDataDalAl.FieldName = "COOPERATIVE_ADERENTI_DATA_DAL_AL";
            this.colCooperativeAderentiDataDalAl.Name = "colCooperativeAderentiDataDalAl";
            this.colCooperativeAderentiDataDalAl.OptionsColumn.AllowEdit = false;
            this.colCooperativeAderentiDataDalAl.OptionsColumn.AllowFocus = false;
            this.colCooperativeAderentiDataDalAl.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCooperativeAderentiDataDalAl.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colCooperativeAderentiDataDalAl.OptionsColumn.AllowMove = false;
            this.colCooperativeAderentiDataDalAl.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colCooperativeIscritteTotale
            // 
            this.colCooperativeIscritteTotale.Caption = "Iscritte totale";
            this.colCooperativeIscritteTotale.FieldName = "COOPERATIVE_ISCRITTE_TOTALE";
            this.colCooperativeIscritteTotale.Name = "colCooperativeIscritteTotale";
            this.colCooperativeIscritteTotale.OptionsColumn.AllowEdit = false;
            this.colCooperativeIscritteTotale.OptionsColumn.AllowFocus = false;
            this.colCooperativeIscritteTotale.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCooperativeIscritteTotale.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colCooperativeIscritteTotale.OptionsColumn.AllowMove = false;
            this.colCooperativeIscritteTotale.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCooperativeIscritteTotale.Visible = true;
            this.colCooperativeIscritteTotale.VisibleIndex = 4;
            this.colCooperativeIscritteTotale.Width = 130;
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
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.GridControl = this.gridControlStatisticaCooperative;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Codice";
            this.gridColumn1.FieldName = "CODICE";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.OptionsColumn.AllowMove = false;
            this.gridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 68;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Descrizione";
            this.gridColumn2.FieldName = "DESCRIZIONE";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn2.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn2.OptionsColumn.AllowMove = false;
            this.gridColumn2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn2.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 288;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Cancellate";
            this.gridColumn3.FieldName = "COOPERATIVE_CANCELLATE";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn3.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn3.OptionsColumn.AllowMove = false;
            this.gridColumn3.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn3.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn3.OptionsFilter.AllowFilter = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 108;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Iscritte fino data dal";
            this.gridColumn4.FieldName = "COOPERATIVE_ISCRITTE_FINO_DATA_DAL";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn4.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn4.OptionsColumn.AllowMove = false;
            this.gridColumn4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 108;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Iscritte dal al";
            this.gridColumn5.FieldName = "COOPERATIVE_ISCRITTE_DATA_DAL_AL";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowFocus = false;
            this.gridColumn5.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn5.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn5.OptionsColumn.AllowMove = false;
            this.gridColumn5.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 112;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Iscritte totale";
            this.gridColumn6.FieldName = "COOPERATIVE_ISCRITTE_TOTALE";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowFocus = false;
            this.gridColumn6.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn6.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn6.OptionsColumn.AllowMove = false;
            this.gridColumn6.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 130;
            // 
            // CooperativeStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "CooperativeStatistics";
            this.Size = new System.Drawing.Size(707, 391);
            this.Load += new System.EventHandler(this.CooperativeStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            this.PnlCntSearch.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatoCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataFinoAl.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataFinoAl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStatisticaCooperative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStatisticaCooperative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemStampa;
        private System.Windows.Forms.Panel PnlCntSearch;
        private OeF.Forms.Controls.SimpleButton btnSearch;
        private DevExpress.XtraGrid.GridControl gridControlStatisticaCooperative;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewStatisticaCooperative;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoriaCodice;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoriaDescrizione;
        private DevExpress.XtraGrid.Columns.GridColumn colCooperativeCancellate;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colCooperativeIscritteDataDalAl;
        private DevExpress.XtraGrid.Columns.GridColumn colCooperativeIscritteTotale;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn colCooperativeAderentiDataDalAl;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExportResults;
        private DevExpress.XtraEditors.RadioGroup StatoCategoria;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl2;
        private it.dedagroup.GVC.Client.Forms.Controls.DateEdit DataFinoAl;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
