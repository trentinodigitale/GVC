namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Revisione
{
    partial class RevisioneDetail
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
            this.gridControlRevisions = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceRevisioni = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.gridViewRevisions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAnnoRevisione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoRevisione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bindingSourceBaseTipiRevisione = new OeF.Forms.BindingSourceBase(this.components);
            this.colRevisore_DescrizioneBreve = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataConclusione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroDeterminaEsame = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataDeterminaEsame = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroDeterminaRevoca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataDeterminaRevoca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEsitoRevisione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bindingSourceEsitiRevisione = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new OeF.Forms.Controls.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.incaricoLiquidazioneDetail1 = new it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Revisione.IncaricoLiquidazioneDetail();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.documentazioneDetail1 = new it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Documentazione.DocumentazioneDetail();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.documentazioneFileSystemDetail1 = new it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.DocumentazioneFileSystem.DocumentazioneFileSystemDetail();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemModify = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuRevisione = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PanelTop)).BeginInit();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelBottom)).BeginInit();
            this.PanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRevisions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRevisioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRevisions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseTipiRevisione)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEsitiRevisione)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuRevisione)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.gridControlRevisions);
            this.PanelTop.Size = new System.Drawing.Size(827, 117);
            // 
            // PanelBottom
            // 
            this.PanelBottom.Controls.Add(this.xtraTabControl1);
            this.PanelBottom.Location = new System.Drawing.Point(0, 123);
            this.PanelBottom.Size = new System.Drawing.Size(827, 428);
            // 
            // Splitter
            // 
            this.Splitter.Location = new System.Drawing.Point(0, 117);
            this.Splitter.Size = new System.Drawing.Size(827, 6);
            // 
            // BarManager
            // 
            this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemAdd,
            this.barButtonItemDelete,
            this.barButtonItemModify});
            this.BarManager.MaxItemId = 15;
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Location = new System.Drawing.Point(0, 49);
            this.ScrollableContent.Size = new System.Drawing.Size(827, 551);
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // gridControlRevisions
            // 
            this.gridControlRevisions.DataSource = this.bindingSourceRevisioni;
            this.gridControlRevisions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlRevisions.Location = new System.Drawing.Point(0, 0);
            this.gridControlRevisions.MainView = this.gridViewRevisions;
            this.gridControlRevisions.Name = "gridControlRevisions";
            this.gridControlRevisions.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2});
            this.gridControlRevisions.Size = new System.Drawing.Size(827, 117);
            this.gridControlRevisions.TabIndex = 5;
            this.gridControlRevisions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRevisions,
            this.gridView2});
            this.gridControlRevisions.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlRevisions_MouseDoubleClick);
            // 
            // bindingSourceRevisioni
            // 
            this.bindingSourceRevisioni.AutoCreateObjects = false;
            this.bindingSourceRevisioni.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.RevisioneFDT);
            this.bindingSourceRevisioni.CurrentChanged += new System.EventHandler(this.bindingSourceRevision_CurrentChanged);
            // 
            // gridViewRevisions
            // 
            this.gridViewRevisions.ColumnPanelRowHeight = 40;
            this.gridViewRevisions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAnnoRevisione,
            this.colIdTipoRevisione,
            this.colRevisore_DescrizioneBreve,
            this.colDataConclusione,
            this.colNumeroDeterminaEsame,
            this.colDataDeterminaEsame,
            this.colNumeroDeterminaRevoca,
            this.colDataDeterminaRevoca,
            this.colIdEsitoRevisione,
            this.colStatus});
            this.gridViewRevisions.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout);
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colStatus;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual;
            styleFormatCondition1.Value1 = "100";
            this.gridViewRevisions.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridViewRevisions.GridControl = this.gridControlRevisions;
            this.gridViewRevisions.Name = "gridViewRevisions";
            this.gridViewRevisions.OptionsBehavior.Editable = false;
            this.gridViewRevisions.OptionsCustomization.AllowSort = false;
            this.gridViewRevisions.OptionsMenu.EnableColumnMenu = false;
            this.gridViewRevisions.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewRevisions.OptionsView.ShowGroupPanel = false;
            this.gridViewRevisions.OptionsView.ShowIndicator = false;
            this.gridViewRevisions.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colAnnoRevisione, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridViewRevisions.ShowGridMenu += new DevExpress.XtraGrid.Views.Grid.GridMenuEventHandler(this.gridViewRevisions_ShowGridMenu);
            // 
            // colAnnoRevisione
            // 
            this.colAnnoRevisione.AppearanceHeader.Options.UseTextOptions = true;
            this.colAnnoRevisione.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAnnoRevisione.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colAnnoRevisione.Caption = "Anno revisione";
            this.colAnnoRevisione.FieldName = "AnnoRevisione";
            this.colAnnoRevisione.Name = "colAnnoRevisione";
            this.colAnnoRevisione.OptionsColumn.AllowEdit = false;
            this.colAnnoRevisione.OptionsColumn.AllowFocus = false;
            this.colAnnoRevisione.OptionsColumn.AllowMove = false;
            this.colAnnoRevisione.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAnnoRevisione.OptionsFilter.AllowAutoFilter = false;
            this.colAnnoRevisione.OptionsFilter.AllowFilter = false;
            this.colAnnoRevisione.Visible = true;
            this.colAnnoRevisione.VisibleIndex = 0;
            this.colAnnoRevisione.Width = 70;
            // 
            // colIdTipoRevisione
            // 
            this.colIdTipoRevisione.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdTipoRevisione.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdTipoRevisione.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colIdTipoRevisione.Caption = "Tipo revisione";
            this.colIdTipoRevisione.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colIdTipoRevisione.FieldName = "IdTipoRevisione";
            this.colIdTipoRevisione.Name = "colIdTipoRevisione";
            this.colIdTipoRevisione.OptionsColumn.AllowEdit = false;
            this.colIdTipoRevisione.OptionsColumn.AllowFocus = false;
            this.colIdTipoRevisione.OptionsColumn.AllowMove = false;
            this.colIdTipoRevisione.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIdTipoRevisione.Visible = true;
            this.colIdTipoRevisione.VisibleIndex = 1;
            this.colIdTipoRevisione.Width = 95;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.bindingSourceBaseTipiRevisione;
            this.repositoryItemLookUpEdit1.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "IdElemento";
            // 
            // bindingSourceBaseTipiRevisione
            // 
            this.bindingSourceBaseTipiRevisione.AutoCreateObjects = false;
            this.bindingSourceBaseTipiRevisione.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.Dictionaries.TipoRevisioneFDT);
            // 
            // colRevisore_DescrizioneBreve
            // 
            this.colRevisore_DescrizioneBreve.AppearanceHeader.Options.UseTextOptions = true;
            this.colRevisore_DescrizioneBreve.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRevisore_DescrizioneBreve.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colRevisore_DescrizioneBreve.Caption = "Organo revisore";
            this.colRevisore_DescrizioneBreve.FieldName = "Revisore_DescrizioneBreve";
            this.colRevisore_DescrizioneBreve.Name = "colRevisore_DescrizioneBreve";
            this.colRevisore_DescrizioneBreve.OptionsColumn.AllowEdit = false;
            this.colRevisore_DescrizioneBreve.OptionsColumn.AllowFocus = false;
            this.colRevisore_DescrizioneBreve.OptionsColumn.AllowMove = false;
            this.colRevisore_DescrizioneBreve.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colRevisore_DescrizioneBreve.OptionsFilter.AllowAutoFilter = false;
            this.colRevisore_DescrizioneBreve.OptionsFilter.AllowFilter = false;
            this.colRevisore_DescrizioneBreve.Visible = true;
            this.colRevisore_DescrizioneBreve.VisibleIndex = 2;
            this.colRevisore_DescrizioneBreve.Width = 95;
            // 
            // colDataConclusione
            // 
            this.colDataConclusione.AppearanceCell.Options.UseTextOptions = true;
            this.colDataConclusione.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colDataConclusione.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataConclusione.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataConclusione.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colDataConclusione.Caption = "Data conclusione";
            this.colDataConclusione.DisplayFormat.FormatString = "d";
            this.colDataConclusione.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDataConclusione.FieldName = "DataConclusione";
            this.colDataConclusione.Name = "colDataConclusione";
            this.colDataConclusione.Visible = true;
            this.colDataConclusione.VisibleIndex = 3;
            // 
            // colNumeroDeterminaEsame
            // 
            this.colNumeroDeterminaEsame.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumeroDeterminaEsame.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumeroDeterminaEsame.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colNumeroDeterminaEsame.Caption = "Nr determina esame";
            this.colNumeroDeterminaEsame.FieldName = "NumeroDeterminaEsame";
            this.colNumeroDeterminaEsame.Name = "colNumeroDeterminaEsame";
            this.colNumeroDeterminaEsame.Visible = true;
            this.colNumeroDeterminaEsame.VisibleIndex = 4;
            this.colNumeroDeterminaEsame.Width = 65;
            // 
            // colDataDeterminaEsame
            // 
            this.colDataDeterminaEsame.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataDeterminaEsame.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataDeterminaEsame.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colDataDeterminaEsame.Caption = "Data determina esame";
            this.colDataDeterminaEsame.FieldName = "DataDeterminaEsame";
            this.colDataDeterminaEsame.Name = "colDataDeterminaEsame";
            this.colDataDeterminaEsame.Visible = true;
            this.colDataDeterminaEsame.VisibleIndex = 5;
            this.colDataDeterminaEsame.Width = 51;
            // 
            // colNumeroDeterminaRevoca
            // 
            this.colNumeroDeterminaRevoca.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumeroDeterminaRevoca.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumeroDeterminaRevoca.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colNumeroDeterminaRevoca.Caption = "Nr determina revoca";
            this.colNumeroDeterminaRevoca.FieldName = "NumeroDeterminaRevoca";
            this.colNumeroDeterminaRevoca.Name = "colNumeroDeterminaRevoca";
            this.colNumeroDeterminaRevoca.Visible = true;
            this.colNumeroDeterminaRevoca.VisibleIndex = 6;
            this.colNumeroDeterminaRevoca.Width = 51;
            // 
            // colDataDeterminaRevoca
            // 
            this.colDataDeterminaRevoca.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataDeterminaRevoca.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataDeterminaRevoca.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colDataDeterminaRevoca.Caption = "Data determina revoca";
            this.colDataDeterminaRevoca.FieldName = "DataDeterminaRevoca";
            this.colDataDeterminaRevoca.Name = "colDataDeterminaRevoca";
            this.colDataDeterminaRevoca.Visible = true;
            this.colDataDeterminaRevoca.VisibleIndex = 7;
            this.colDataDeterminaRevoca.Width = 51;
            // 
            // colIdEsitoRevisione
            // 
            this.colIdEsitoRevisione.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdEsitoRevisione.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdEsitoRevisione.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colIdEsitoRevisione.Caption = "Esito";
            this.colIdEsitoRevisione.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colIdEsitoRevisione.FieldName = "IdEsitoRevisione";
            this.colIdEsitoRevisione.Name = "colIdEsitoRevisione";
            this.colIdEsitoRevisione.Visible = true;
            this.colIdEsitoRevisione.VisibleIndex = 8;
            this.colIdEsitoRevisione.Width = 114;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.DataSource = this.bindingSourceEsitiRevisione;
            this.repositoryItemLookUpEdit2.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ValueMember = "IdElemento";
            // 
            // bindingSourceEsitiRevisione
            // 
            this.bindingSourceEsitiRevisione.AutoCreateObjects = false;
            this.bindingSourceEsitiRevisione.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControlRevisions;
            this.gridView2.Name = "gridView2";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTabControl1.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(827, 428);
            this.xtraTabControl1.TabIndex = 6;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage3,
            this.xtraTabPage2,
            this.xtraTabPage4});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.incaricoLiquidazioneDetail1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(818, 397);
            this.xtraTabPage1.Text = "Incarichi / Liquidazioni";
            // 
            // incaricoLiquidazioneDetail1
            // 
            this.incaricoLiquidazioneDetail1.ApplicationTitle = "";
            this.incaricoLiquidazioneDetail1.ConfirmCancel = true;
            this.incaricoLiquidazioneDetail1.ConfirmCancelMessage = "";
            this.incaricoLiquidazioneDetail1.CurrentSequenceID = null;
            this.incaricoLiquidazioneDetail1.CurrentTaskID = null;
            this.incaricoLiquidazioneDetail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.incaricoLiquidazioneDetail1.IsShowing = false;
            this.incaricoLiquidazioneDetail1.Location = new System.Drawing.Point(0, 0);
            this.incaricoLiquidazioneDetail1.Name = "incaricoLiquidazioneDetail1";
            this.incaricoLiquidazioneDetail1.PageCaption = "";
            this.incaricoLiquidazioneDetail1.ReadOnlyControls = true;
            this.incaricoLiquidazioneDetail1.Size = new System.Drawing.Size(818, 397);
            this.incaricoLiquidazioneDetail1.TabIndex = 0;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.PageVisible = false;
            this.xtraTabPage3.Size = new System.Drawing.Size(791, 446);
            this.xtraTabPage3.Text = "Liquidazione";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.documentazioneDetail1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(791, 446);
            this.xtraTabPage2.Text = "Documentazione";
            // 
            // documentazioneDetail1
            // 
            this.documentazioneDetail1.ApplicationTitle = "";
            this.documentazioneDetail1.ConfirmCancel = true;
            this.documentazioneDetail1.ConfirmCancelMessage = "";
            this.documentazioneDetail1.CurrentSequenceID = null;
            this.documentazioneDetail1.CurrentTaskID = null;
            this.documentazioneDetail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentazioneDetail1.IsGeneral = false;
            this.documentazioneDetail1.IsShowing = false;
            this.documentazioneDetail1.Location = new System.Drawing.Point(0, 0);
            this.documentazioneDetail1.Name = "documentazioneDetail1";
            this.documentazioneDetail1.PageCaption = "";
            this.documentazioneDetail1.ReadOnlyControls = true;
            this.documentazioneDetail1.Size = new System.Drawing.Size(791, 446);
            this.documentazioneDetail1.TabIndex = 0;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.documentazioneFileSystemDetail1);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(791, 446);
            this.xtraTabPage4.Text = "Documenti vigilanza";
            // 
            // documentazioneFileSystemDetail1
            // 
            this.documentazioneFileSystemDetail1.ApplicationTitle = "";
            this.documentazioneFileSystemDetail1.ConfirmCancel = true;
            this.documentazioneFileSystemDetail1.ConfirmCancelMessage = "";
            this.documentazioneFileSystemDetail1.CurrentSequenceID = null;
            this.documentazioneFileSystemDetail1.CurrentTaskID = null;
            this.documentazioneFileSystemDetail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentazioneFileSystemDetail1.IsShowing = false;
            this.documentazioneFileSystemDetail1.Location = new System.Drawing.Point(0, 0);
            this.documentazioneFileSystemDetail1.Name = "documentazioneFileSystemDetail1";
            this.documentazioneFileSystemDetail1.PageCaption = "";
            this.documentazioneFileSystemDetail1.ReadOnlyControls = true;
            this.documentazioneFileSystemDetail1.Size = new System.Drawing.Size(791, 446);
            this.documentazioneFileSystemDetail1.TabIndex = 0;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 3";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemAdd, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemModify, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 3";
            // 
            // barButtonItemAdd
            // 
            this.barButtonItemAdd.Caption = "Nuovo";
            this.barButtonItemAdd.Id = 9;
            this.barButtonItemAdd.Name = "barButtonItemAdd";
            this.barButtonItemAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAdd_ItemClick);
            // 
            // barButtonItemModify
            // 
            this.barButtonItemModify.Caption = "Modifica";
            this.barButtonItemModify.Id = 11;
            this.barButtonItemModify.Name = "barButtonItemModify";
            this.barButtonItemModify.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemModify_ItemClick);
            // 
            // barButtonItemDelete
            // 
            this.barButtonItemDelete.Caption = "Cancella";
            this.barButtonItemDelete.Id = 10;
            this.barButtonItemDelete.Name = "barButtonItemDelete";
            this.barButtonItemDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDelete_ItemClick);
            // 
            // popupMenuRevisione
            // 
            this.popupMenuRevisione.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemModify),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemDelete)});
            this.popupMenuRevisione.Manager = this.BarManager;
            this.popupMenuRevisione.Name = "popupMenuRevisione";
            // 
            // RevisioneDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "RevisioneDetail";
            this.Size = new System.Drawing.Size(827, 600);
            ((System.ComponentModel.ISupportInitialize)(this.PanelTop)).EndInit();
            this.PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelBottom)).EndInit();
            this.PanelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRevisions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRevisioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRevisions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseTipiRevisione)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEsitiRevisione)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuRevisione)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlRevisions;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceRevisioni;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRevisions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private OeF.Forms.Controls.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Documentazione.DocumentazioneDetail documentazioneDetail1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private OeF.Forms.BindingSourceBase bindingSourceBaseTipiRevisione;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colAnnoRevisione;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoRevisione;
        private DevExpress.XtraGrid.Columns.GridColumn colRevisore_DescrizioneBreve;
        private DevExpress.XtraGrid.Columns.GridColumn colDataConclusione;
        private DevExpress.XtraBars.BarButtonItem barButtonItemModify;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraBars.PopupMenu popupMenuRevisione;
        private IncaricoLiquidazioneDetail incaricoLiquidazioneDetail1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEsitoRevisione;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceEsitiRevisione;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroDeterminaEsame;
        private DevExpress.XtraGrid.Columns.GridColumn colDataDeterminaEsame;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroDeterminaRevoca;
        private DevExpress.XtraGrid.Columns.GridColumn colDataDeterminaRevoca;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.DocumentazioneFileSystem.DocumentazioneFileSystemDetail documentazioneFileSystemDetail1;
    }
}
