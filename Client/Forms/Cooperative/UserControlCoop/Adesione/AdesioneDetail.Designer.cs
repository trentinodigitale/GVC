namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Adesione
{
    partial class AdesioneDetail
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlAdhesions = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceBaseAdesione = new OeF.Forms.BindingSourceBase(this.components);
            this.gridViewAdhesions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAssociazione_DescrizioneBreve = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colRevisore = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colDataInizio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataFine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new it.dedagroup.GVC.Client.Forms.Controls.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.documentationDetail1 = new it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Documentazione.DocumentazioneDetail();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.documentazioneFileSystemDetail1 = new it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.DocumentazioneFileSystem.DocumentazioneFileSystemDetail();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemModify = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuAdesione = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.PanelTop)).BeginInit();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelBottom)).BeginInit();
            this.PanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAdhesions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseAdesione)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAdhesions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuAdesione)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.gridControlAdhesions);
            this.PanelTop.Size = new System.Drawing.Size(641, 108);
            // 
            // PanelBottom
            // 
            this.PanelBottom.Controls.Add(this.xtraTabControl1);
            this.PanelBottom.Location = new System.Drawing.Point(0, 114);
            this.PanelBottom.Size = new System.Drawing.Size(641, 308);
            // 
            // Splitter
            // 
            this.Splitter.Location = new System.Drawing.Point(0, 108);
            this.Splitter.Size = new System.Drawing.Size(641, 6);
            // 
            // BarManager
            // 
            this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemAdd,
            this.barButtonItemDelete,
            this.barButtonItemModify});
            this.BarManager.MaxItemId = 19;
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Location = new System.Drawing.Point(0, 49);
            this.ScrollableContent.Size = new System.Drawing.Size(641, 422);
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // gridControlAdhesions
            // 
            this.gridControlAdhesions.DataSource = this.bindingSourceBaseAdesione;
            this.gridControlAdhesions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAdhesions.Location = new System.Drawing.Point(0, 0);
            this.gridControlAdhesions.MainView = this.gridViewAdhesions;
            this.gridControlAdhesions.Name = "gridControlAdhesions";
            this.gridControlAdhesions.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemMemoEdit1});
            this.gridControlAdhesions.Size = new System.Drawing.Size(641, 108);
            this.gridControlAdhesions.TabIndex = 0;
            this.gridControlAdhesions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAdhesions,
            this.gridView2});
            this.gridControlAdhesions.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlAdhesions_MouseDoubleClick);
            // 
            // bindingSourceBaseAdesione
            // 
            this.bindingSourceBaseAdesione.AutoCreateObjects = false;
            this.bindingSourceBaseAdesione.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.AdesioneFDT);
            this.bindingSourceBaseAdesione.CurrentChanged += new System.EventHandler(this.bindingSourceBaseAdhesion_CurrentChanged);
            // 
            // gridViewAdhesions
            // 
            this.gridViewAdhesions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAssociazione_DescrizioneBreve,
            this.colRevisore,
            this.colDataInizio,
            this.colDataFine,
            this.colStatus});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout);
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colStatus;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual;
            styleFormatCondition1.Value1 = "100";
            this.gridViewAdhesions.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridViewAdhesions.GridControl = this.gridControlAdhesions;
            this.gridViewAdhesions.Name = "gridViewAdhesions";
            this.gridViewAdhesions.OptionsBehavior.Editable = false;
            this.gridViewAdhesions.OptionsCustomization.AllowSort = false;
            this.gridViewAdhesions.OptionsMenu.EnableColumnMenu = false;
            this.gridViewAdhesions.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewAdhesions.OptionsView.ShowGroupPanel = false;
            this.gridViewAdhesions.OptionsView.ShowIndicator = false;
            this.gridViewAdhesions.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDataInizio, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridViewAdhesions.ShowGridMenu += new DevExpress.XtraGrid.Views.Grid.GridMenuEventHandler(this.gridViewAdhesions_ShowGridMenu);
            // 
            // colAssociazione_DescrizioneBreve
            // 
            this.colAssociazione_DescrizioneBreve.Caption = "Associazione";
            this.colAssociazione_DescrizioneBreve.FieldName = "Associazione_DescrizioneBreve";
            this.colAssociazione_DescrizioneBreve.Name = "colAssociazione_DescrizioneBreve";
            this.colAssociazione_DescrizioneBreve.OptionsColumn.AllowEdit = false;
            this.colAssociazione_DescrizioneBreve.OptionsColumn.AllowFocus = false;
            this.colAssociazione_DescrizioneBreve.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colAssociazione_DescrizioneBreve.OptionsColumn.AllowMove = false;
            this.colAssociazione_DescrizioneBreve.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAssociazione_DescrizioneBreve.OptionsFilter.AllowAutoFilter = false;
            this.colAssociazione_DescrizioneBreve.OptionsFilter.AllowFilter = false;
            this.colAssociazione_DescrizioneBreve.Visible = true;
            this.colAssociazione_DescrizioneBreve.VisibleIndex = 0;
            this.colAssociazione_DescrizioneBreve.Width = 365;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.AcceptsReturn = false;
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // colRevisore
            // 
            this.colRevisore.AppearanceHeader.Options.UseTextOptions = true;
            this.colRevisore.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRevisore.Caption = "Revisore";
            this.colRevisore.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colRevisore.FieldName = "Revisore";
            this.colRevisore.Name = "colRevisore";
            this.colRevisore.OptionsColumn.AllowEdit = false;
            this.colRevisore.OptionsColumn.AllowFocus = false;
            this.colRevisore.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colRevisore.OptionsColumn.AllowMove = false;
            this.colRevisore.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colRevisore.OptionsFilter.AllowAutoFilter = false;
            this.colRevisore.OptionsFilter.AllowFilter = false;
            this.colRevisore.Visible = true;
            this.colRevisore.VisibleIndex = 1;
            this.colRevisore.Width = 58;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // colDataInizio
            // 
            this.colDataInizio.AppearanceCell.Options.UseTextOptions = true;
            this.colDataInizio.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataInizio.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataInizio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataInizio.Caption = "Data inizio adesione";
            this.colDataInizio.DisplayFormat.FormatString = "d";
            this.colDataInizio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDataInizio.FieldName = "DataInizio";
            this.colDataInizio.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colDataInizio.Name = "colDataInizio";
            this.colDataInizio.OptionsColumn.AllowEdit = false;
            this.colDataInizio.OptionsColumn.AllowFocus = false;
            this.colDataInizio.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDataInizio.OptionsColumn.AllowMove = false;
            this.colDataInizio.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDataInizio.OptionsFilter.AllowAutoFilter = false;
            this.colDataInizio.OptionsFilter.AllowFilter = false;
            this.colDataInizio.Visible = true;
            this.colDataInizio.VisibleIndex = 2;
            this.colDataInizio.Width = 107;
            // 
            // colDataFine
            // 
            this.colDataFine.AppearanceCell.Options.UseTextOptions = true;
            this.colDataFine.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataFine.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataFine.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataFine.Caption = "Data fine adesione";
            this.colDataFine.DisplayFormat.FormatString = "d";
            this.colDataFine.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDataFine.FieldName = "DataFine";
            this.colDataFine.Name = "colDataFine";
            this.colDataFine.OptionsColumn.AllowEdit = false;
            this.colDataFine.OptionsColumn.AllowFocus = false;
            this.colDataFine.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDataFine.OptionsColumn.AllowMove = false;
            this.colDataFine.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDataFine.OptionsFilter.AllowAutoFilter = false;
            this.colDataFine.OptionsFilter.AllowFilter = false;
            this.colDataFine.Visible = true;
            this.colDataFine.VisibleIndex = 3;
            this.colDataFine.Width = 107;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControlAdhesions;
            this.gridView2.Name = "gridView2";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(641, 308);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.documentationDetail1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(632, 277);
            this.xtraTabPage1.Text = "Documentazione";
            // 
            // documentationDetail1
            // 
            this.documentationDetail1.ApplicationTitle = "";
            this.documentationDetail1.ConfirmCancel = true;
            this.documentationDetail1.ConfirmCancelMessage = "";
            this.documentationDetail1.CurrentSequenceID = null;
            this.documentationDetail1.CurrentTaskID = null;
            this.documentationDetail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentationDetail1.IsGeneral = false;
            this.documentationDetail1.IsShowing = false;
            this.documentationDetail1.Location = new System.Drawing.Point(0, 0);
            this.documentationDetail1.Name = "documentationDetail1";
            this.documentationDetail1.PageCaption = "";
            this.documentationDetail1.ReadOnlyControls = true;
            this.documentationDetail1.Size = new System.Drawing.Size(632, 277);
            this.documentationDetail1.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.documentazioneFileSystemDetail1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(791, 455);
            this.xtraTabPage2.Text = "Documenti vigilanza";
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
            this.documentazioneFileSystemDetail1.Size = new System.Drawing.Size(791, 455);
            this.documentazioneFileSystemDetail1.TabIndex = 0;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 3";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            this.barButtonItemAdd.Id = 11;
            this.barButtonItemAdd.Name = "barButtonItemAdd";
            this.barButtonItemAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAdd_ItemClick);
            // 
            // barButtonItemModify
            // 
            this.barButtonItemModify.Caption = "Modifica";
            this.barButtonItemModify.Id = 13;
            this.barButtonItemModify.Name = "barButtonItemModify";
            this.barButtonItemModify.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemModify_ItemClick);
            // 
            // barButtonItemDelete
            // 
            this.barButtonItemDelete.Caption = "Cancella";
            this.barButtonItemDelete.Id = 12;
            this.barButtonItemDelete.Name = "barButtonItemDelete";
            this.barButtonItemDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDelete_ItemClick);
            // 
            // popupMenuAdesione
            // 
            this.popupMenuAdesione.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemModify),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemDelete)});
            this.popupMenuAdesione.Manager = this.BarManager;
            this.popupMenuAdesione.Name = "popupMenuAdesione";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Nuovo";
            this.barButtonItem1.Id = 14;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAdd_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Modifica";
            this.barButtonItem2.Id = 15;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemModify_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Cancella";
            this.barButtonItem3.Id = 16;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDelete_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "testr";
            this.barButtonItem4.Id = 17;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "ff";
            this.barButtonItem5.Id = 18;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // AdesioneDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "AdesioneDetail";
            this.Size = new System.Drawing.Size(641, 471);
            ((System.ComponentModel.ISupportInitialize)(this.PanelTop)).EndInit();
            this.PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelBottom)).EndInit();
            this.PanelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAdhesions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseAdesione)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAdhesions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuAdesione)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlAdhesions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAdhesions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private OeF.Forms.BindingSourceBase bindingSourceBaseAdesione;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private it.dedagroup.GVC.Client.Forms.Controls.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Documentazione.DocumentazioneDetail documentationDetail1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colAssociazione_DescrizioneBreve;
        private DevExpress.XtraGrid.Columns.GridColumn colRevisore;
        private DevExpress.XtraGrid.Columns.GridColumn colDataFine;
        private DevExpress.XtraGrid.Columns.GridColumn colDataInizio;
        private DevExpress.XtraBars.BarButtonItem barButtonItemModify;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraBars.PopupMenu popupMenuAdesione;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.DocumentazioneFileSystem.DocumentazioneFileSystemDetail documentazioneFileSystemDetail1;

    }
}
