namespace it.dedagroup.GVC.Client.Forms.Search
{
    partial class SubjectSearch
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
            this.lblResults = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.labelControl7 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.Associazione = new DevExpress.XtraEditors.CheckEdit();
            this.lookUpEditSubjectType = new DevExpress.XtraEditors.LookUpEdit();
            this.bindingSourceBaseTipoSoggetto = new OeF.Forms.BindingSourceBase(this.components);
            this.DataNascita = new OeF.Forms.Controls.DateEdit();
            this.LuogoNascita = new OeF.Forms.Controls.TextEdit();
            this.CodiceFiscale = new OeF.Forms.Controls.TextEdit();
            this.Nominativo = new OeF.Forms.Controls.TextEdit();
            this.labelControl6 = new OeF.Forms.Controls.LabelControl();
            this.labelControl5 = new OeF.Forms.Controls.LabelControl();
            this.labelControl4 = new OeF.Forms.Controls.LabelControl();
            this.labelControl3 = new OeF.Forms.Controls.LabelControl();
            this.labelControl2 = new OeF.Forms.Controls.LabelControl();
            this.labelControl1 = new OeF.Forms.Controls.LabelControl();
            this.btnSearch = new OeF.Forms.Controls.SimpleButton();
            this.gridControlSoggetto = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceBaseResults = new OeF.Forms.BindingSourceBase(this.components);
            this.gridViewSoggetto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNominativo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoSoggetto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colCodiceFiscale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComuneNascita = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataNascita = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRemove = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemResultsExport = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemModify = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuSoggetto = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItemOpen = new DevExpress.XtraBars.BarButtonItem();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Associazione.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditSubjectType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseTipoSoggetto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataNascita.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataNascita.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuogoNascita.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodiceFiscale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nominativo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSoggetto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSoggetto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuSoggetto)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarManager
            // 
            this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemAdd,
            this.barButtonItemResultsExport,
            this.barButtonItemModify,
            this.barButtonItemOpen,
            this.barButtonItemRemove});
            this.BarManager.MaxItemId = 14;
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.gridControlSoggetto);
            this.ScrollableContent.Controls.Add(this.xtraScrollableControl1);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 49);
            this.ScrollableContent.Size = new System.Drawing.Size(659, 404);
            // 
            // lblResults
            // 
            this.lblResults.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblResults.Appearance.Options.UseFont = true;
            this.lblResults.Location = new System.Drawing.Point(68, 95);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 13);
            this.lblResults.TabIndex = 8;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(2, 95);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(50, 13);
            this.labelControl7.TabIndex = 7;
            this.labelControl7.Text = "Risultati:";
            // 
            // Associazione
            // 
            this.Associazione.Location = new System.Drawing.Point(442, 3);
            this.Associazione.Name = "Associazione";
            this.Associazione.Properties.Caption = "";
            this.Associazione.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Associazione.Size = new System.Drawing.Size(17, 19);
            this.Associazione.TabIndex = 3;
            // 
            // lookUpEditSubjectType
            // 
            this.lookUpEditSubjectType.Location = new System.Drawing.Point(75, 1);
            this.lookUpEditSubjectType.Name = "lookUpEditSubjectType";
            this.lookUpEditSubjectType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditSubjectType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descrizione", "", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.lookUpEditSubjectType.Properties.DataSource = this.bindingSourceBaseTipoSoggetto;
            this.lookUpEditSubjectType.Properties.DisplayMember = "Descrizione";
            this.lookUpEditSubjectType.Properties.NullText = "";
            this.lookUpEditSubjectType.Properties.ValueMember = "IdElemento";
            this.lookUpEditSubjectType.Size = new System.Drawing.Size(245, 20);
            this.lookUpEditSubjectType.TabIndex = 0;
            // 
            // bindingSourceBaseTipoSoggetto
            // 
            this.bindingSourceBaseTipoSoggetto.AutoCreateObjects = false;
            this.bindingSourceBaseTipoSoggetto.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // DataNascita
            // 
            this.DataNascita.EditValue = null;
            this.DataNascita.Location = new System.Drawing.Point(441, 56);
            this.DataNascita.Name = "DataNascita";
            this.DataNascita.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DataNascita.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.DataNascita.Size = new System.Drawing.Size(100, 20);
            this.DataNascita.TabIndex = 5;
            // 
            // LuogoNascita
            // 
            this.LuogoNascita.Location = new System.Drawing.Point(441, 30);
            this.LuogoNascita.Name = "LuogoNascita";
            this.LuogoNascita.Size = new System.Drawing.Size(151, 20);
            this.LuogoNascita.TabIndex = 4;
            // 
            // CodiceFiscale
            // 
            this.CodiceFiscale.Location = new System.Drawing.Point(74, 56);
            this.CodiceFiscale.Name = "CodiceFiscale";
            this.CodiceFiscale.Size = new System.Drawing.Size(245, 20);
            this.CodiceFiscale.TabIndex = 2;
            // 
            // Nominativo
            // 
            this.Nominativo.Location = new System.Drawing.Point(74, 30);
            this.Nominativo.Name = "Nominativo";
            this.Nominativo.Size = new System.Drawing.Size(245, 20);
            this.Nominativo.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(375, 6);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(61, 13);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Associazione";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(358, 33);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(77, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Luogo di nascita";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(364, 59);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Data di nascita";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(3, 59);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Codice fiscale";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 33);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nominativo";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tipo soggetto";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(244, 82);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Ricerca";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gridControlSoggetto
            // 
            this.gridControlSoggetto.DataSource = this.bindingSourceBaseResults;
            this.gridControlSoggetto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSoggetto.Location = new System.Drawing.Point(0, 118);
            this.gridControlSoggetto.MainView = this.gridViewSoggetto;
            this.gridControlSoggetto.Name = "gridControlSoggetto";
            this.gridControlSoggetto.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControlSoggetto.Size = new System.Drawing.Size(659, 286);
            this.gridControlSoggetto.TabIndex = 1;
            this.gridControlSoggetto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSoggetto});
            this.gridControlSoggetto.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlSoggetto_MouseDoubleClick);
            // 
            // bindingSourceBaseResults
            // 
            this.bindingSourceBaseResults.AutoCreateObjects = false;
            this.bindingSourceBaseResults.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.SoggettoPerVisualizzazioneFDT);
            // 
            // gridViewSoggetto
            // 
            this.gridViewSoggetto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNominativo,
            this.colIdTipoSoggetto,
            this.colCodiceFiscale,
            this.colComuneNascita,
            this.colDataNascita});
            this.gridViewSoggetto.GridControl = this.gridControlSoggetto;
            this.gridViewSoggetto.Name = "gridViewSoggetto";
            this.gridViewSoggetto.OptionsMenu.EnableColumnMenu = false;
            this.gridViewSoggetto.OptionsMenu.EnableFooterMenu = false;
            this.gridViewSoggetto.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewSoggetto.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewSoggetto.OptionsView.ShowGroupPanel = false;
            this.gridViewSoggetto.OptionsView.ShowIndicator = false;
            this.gridViewSoggetto.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdTipoSoggetto, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNominativo, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewSoggetto.ShowGridMenu += new DevExpress.XtraGrid.Views.Grid.GridMenuEventHandler(this.gridViewSoggetto_ShowGridMenu);
            // 
            // colNominativo
            // 
            this.colNominativo.AppearanceHeader.Options.UseTextOptions = true;
            this.colNominativo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNominativo.Caption = "Nominativo";
            this.colNominativo.FieldName = "Nominativo";
            this.colNominativo.Name = "colNominativo";
            this.colNominativo.OptionsColumn.AllowEdit = false;
            this.colNominativo.OptionsColumn.AllowFocus = false;
            this.colNominativo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colNominativo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colNominativo.OptionsColumn.AllowMove = false;
            this.colNominativo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNominativo.OptionsFilter.AllowAutoFilter = false;
            this.colNominativo.OptionsFilter.AllowFilter = false;
            this.colNominativo.Visible = true;
            this.colNominativo.VisibleIndex = 0;
            this.colNominativo.Width = 187;
            // 
            // colIdTipoSoggetto
            // 
            this.colIdTipoSoggetto.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdTipoSoggetto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdTipoSoggetto.Caption = "Tipo soggetto";
            this.colIdTipoSoggetto.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colIdTipoSoggetto.FieldName = "IdTipoSoggetto";
            this.colIdTipoSoggetto.Name = "colIdTipoSoggetto";
            this.colIdTipoSoggetto.OptionsColumn.AllowEdit = false;
            this.colIdTipoSoggetto.OptionsColumn.AllowFocus = false;
            this.colIdTipoSoggetto.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIdTipoSoggetto.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colIdTipoSoggetto.OptionsColumn.AllowMove = false;
            this.colIdTipoSoggetto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIdTipoSoggetto.OptionsFilter.AllowAutoFilter = false;
            this.colIdTipoSoggetto.OptionsFilter.AllowFilter = false;
            this.colIdTipoSoggetto.Visible = true;
            this.colIdTipoSoggetto.VisibleIndex = 2;
            this.colIdTipoSoggetto.Width = 113;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.bindingSourceBaseTipoSoggetto;
            this.repositoryItemLookUpEdit1.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "IdElemento";
            // 
            // colCodiceFiscale
            // 
            this.colCodiceFiscale.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodiceFiscale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodiceFiscale.Caption = "Codice fiscale";
            this.colCodiceFiscale.FieldName = "CodiceFiscale";
            this.colCodiceFiscale.Name = "colCodiceFiscale";
            this.colCodiceFiscale.OptionsColumn.AllowEdit = false;
            this.colCodiceFiscale.OptionsColumn.AllowFocus = false;
            this.colCodiceFiscale.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCodiceFiscale.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colCodiceFiscale.OptionsColumn.AllowMove = false;
            this.colCodiceFiscale.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCodiceFiscale.OptionsFilter.AllowAutoFilter = false;
            this.colCodiceFiscale.OptionsFilter.AllowFilter = false;
            this.colCodiceFiscale.Visible = true;
            this.colCodiceFiscale.VisibleIndex = 1;
            this.colCodiceFiscale.Width = 147;
            // 
            // colComuneNascita
            // 
            this.colComuneNascita.AppearanceHeader.Options.UseTextOptions = true;
            this.colComuneNascita.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colComuneNascita.Caption = "Comune di nascita";
            this.colComuneNascita.FieldName = "ComuneNascita";
            this.colComuneNascita.Name = "colComuneNascita";
            this.colComuneNascita.OptionsColumn.AllowEdit = false;
            this.colComuneNascita.OptionsColumn.AllowFocus = false;
            this.colComuneNascita.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colComuneNascita.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colComuneNascita.OptionsColumn.AllowMove = false;
            this.colComuneNascita.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colComuneNascita.OptionsFilter.AllowAutoFilter = false;
            this.colComuneNascita.OptionsFilter.AllowFilter = false;
            this.colComuneNascita.Visible = true;
            this.colComuneNascita.VisibleIndex = 3;
            this.colComuneNascita.Width = 121;
            // 
            // colDataNascita
            // 
            this.colDataNascita.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataNascita.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataNascita.Caption = "Data di nascita";
            this.colDataNascita.DisplayFormat.FormatString = "d";
            this.colDataNascita.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDataNascita.FieldName = "DataNascita";
            this.colDataNascita.Name = "colDataNascita";
            this.colDataNascita.OptionsColumn.AllowEdit = false;
            this.colDataNascita.OptionsColumn.AllowFocus = false;
            this.colDataNascita.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDataNascita.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDataNascita.OptionsColumn.AllowMove = false;
            this.colDataNascita.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDataNascita.OptionsFilter.AllowAutoFilter = false;
            this.colDataNascita.OptionsFilter.AllowFilter = false;
            this.colDataNascita.Visible = true;
            this.colDataNascita.VisibleIndex = 4;
            this.colDataNascita.Width = 84;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemRemove, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemResultsExport, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Custom 2";
            // 
            // barButtonItemAdd
            // 
            this.barButtonItemAdd.Caption = "Aggiungi soggetto";
            this.barButtonItemAdd.Id = 9;
            this.barButtonItemAdd.Name = "barButtonItemAdd";
            this.barButtonItemAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAdd_ItemClick);
            // 
            // barButtonItemRemove
            // 
            this.barButtonItemRemove.Caption = "Rimuovi soggetto";
            this.barButtonItemRemove.Id = 13;
            this.barButtonItemRemove.Name = "barButtonItemRemove";
            this.barButtonItemRemove.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemRemove_ItemClick);
            // 
            // barButtonItemResultsExport
            // 
            this.barButtonItemResultsExport.Caption = "Esporta risultati";
            this.barButtonItemResultsExport.Id = 10;
            this.barButtonItemResultsExport.Name = "barButtonItemResultsExport";
            this.barButtonItemResultsExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemResultsExport_ItemClick);
            // 
            // barButtonItemModify
            // 
            this.barButtonItemModify.Caption = "Modifica soggetto";
            this.barButtonItemModify.Id = 11;
            this.barButtonItemModify.Name = "barButtonItemModify";
            // 
            // popupMenuSoggetto
            // 
            this.popupMenuSoggetto.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemOpen, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemRemove)});
            this.popupMenuSoggetto.Manager = this.BarManager;
            this.popupMenuSoggetto.Name = "popupMenuSoggetto";
            // 
            // barButtonItemOpen
            // 
            this.barButtonItemOpen.Caption = "Apri";
            this.barButtonItemOpen.Id = 12;
            this.barButtonItemOpen.Name = "barButtonItemOpen";
            this.barButtonItemOpen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemOpen_ItemClick);
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.btnSearch);
            this.xtraScrollableControl1.Controls.Add(this.lblResults);
            this.xtraScrollableControl1.Controls.Add(this.labelControl6);
            this.xtraScrollableControl1.Controls.Add(this.labelControl5);
            this.xtraScrollableControl1.Controls.Add(this.labelControl7);
            this.xtraScrollableControl1.Controls.Add(this.Nominativo);
            this.xtraScrollableControl1.Controls.Add(this.Associazione);
            this.xtraScrollableControl1.Controls.Add(this.labelControl4);
            this.xtraScrollableControl1.Controls.Add(this.CodiceFiscale);
            this.xtraScrollableControl1.Controls.Add(this.lookUpEditSubjectType);
            this.xtraScrollableControl1.Controls.Add(this.labelControl3);
            this.xtraScrollableControl1.Controls.Add(this.labelControl1);
            this.xtraScrollableControl1.Controls.Add(this.LuogoNascita);
            this.xtraScrollableControl1.Controls.Add(this.DataNascita);
            this.xtraScrollableControl1.Controls.Add(this.labelControl2);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(659, 118);
            this.xtraScrollableControl1.TabIndex = 9;
            // 
            // SubjectSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "SubjectSearch";
            this.Size = new System.Drawing.Size(659, 453);
            this.Shown += new System.EventHandler(this.SubjectSearch_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Associazione.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditSubjectType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseTipoSoggetto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataNascita.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataNascita.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuogoNascita.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodiceFiscale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nominativo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSoggetto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSoggetto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuSoggetto)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            this.xtraScrollableControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlSoggetto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSoggetto;
        private DevExpress.XtraEditors.CheckEdit Associazione;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditSubjectType;
        private OeF.Forms.Controls.DateEdit DataNascita;
        private OeF.Forms.Controls.TextEdit Nominativo;
        private OeF.Forms.Controls.LabelControl labelControl1;
        private OeF.Forms.Controls.SimpleButton btnSearch;
        private OeF.Forms.Controls.TextEdit LuogoNascita;
        private OeF.Forms.Controls.TextEdit CodiceFiscale;
        private OeF.Forms.Controls.LabelControl labelControl6;
        private OeF.Forms.Controls.LabelControl labelControl5;
        private OeF.Forms.Controls.LabelControl labelControl4;
        private OeF.Forms.Controls.LabelControl labelControl3;
        private OeF.Forms.Controls.LabelControl labelControl2;
        private OeF.Forms.BindingSourceBase bindingSourceBaseResults;
        private OeF.Forms.BindingSourceBase bindingSourceBaseTipoSoggetto;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemModify;
        private DevExpress.XtraBars.BarButtonItem barButtonItemResultsExport;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOpen;
        private DevExpress.XtraBars.PopupMenu popupMenuSoggetto;
        private DevExpress.XtraGrid.Columns.GridColumn colNominativo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoSoggetto;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colCodiceFiscale;
        private DevExpress.XtraGrid.Columns.GridColumn colComuneNascita;
        private DevExpress.XtraGrid.Columns.GridColumn colDataNascita;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl lblResults;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl7;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRemove;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
    }
}
