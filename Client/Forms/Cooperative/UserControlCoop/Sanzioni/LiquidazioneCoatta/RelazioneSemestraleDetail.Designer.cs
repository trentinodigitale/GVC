namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Sanzioni.LiquidazioneCoatta
{
    partial class RelazioneSemestraleDetail
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
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemModify = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.gridControlSixMonthReports = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceSixMonthReports = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.gridViewSixMonthReports = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colReportDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommissionOutcomeDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOfficeExamDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.popupMenuRelazioneSemestrale = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSixMonthReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSixMonthReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSixMonthReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuRelazioneSemestrale)).BeginInit();
            this.SuspendLayout();
            // 
            // BarManager
            // 
            this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemAdd,
            this.barButtonItemModify,
            this.barButtonItemDelete});
            this.BarManager.MaxItemId = 15;
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.gridControlSixMonthReports);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 49);
            this.ScrollableContent.Size = new System.Drawing.Size(808, 399);
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.OptionsColumn.AllowEdit = false;
            this.colStatus.OptionsColumn.AllowFocus = false;
            this.colStatus.OptionsColumn.AllowMove = false;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
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
            this.bar1.Text = "Custom 2";
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
            this.barButtonItemDelete.Id = 14;
            this.barButtonItemDelete.Name = "barButtonItemDelete";
            this.barButtonItemDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDelete_ItemClick);
            // 
            // gridControlSixMonthReports
            // 
            this.gridControlSixMonthReports.DataSource = this.bindingSourceSixMonthReports;
            this.gridControlSixMonthReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlSixMonthReports.Location = new System.Drawing.Point(0, 0);
            this.gridControlSixMonthReports.MainView = this.gridViewSixMonthReports;
            this.gridControlSixMonthReports.Name = "gridControlSixMonthReports";
            this.gridControlSixMonthReports.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControlSixMonthReports.Size = new System.Drawing.Size(808, 399);
            this.gridControlSixMonthReports.TabIndex = 2;
            this.gridControlSixMonthReports.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSixMonthReports});
            this.gridControlSixMonthReports.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlSixMonthReports_MouseDoubleClick);
            // 
            // bindingSourceSixMonthReports
            // 
            this.bindingSourceSixMonthReports.AutoCreateObjects = false;
            this.bindingSourceSixMonthReports.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.RelazioneSemestraleFDT);
            this.bindingSourceSixMonthReports.CurrentChanged += new System.EventHandler(this.bindingSourceSixMonthReports_CurrentChanged);
            // 
            // gridViewSixMonthReports
            // 
            this.gridViewSixMonthReports.ColumnPanelRowHeight = 40;
            this.gridViewSixMonthReports.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colReportDate,
            this.colCommissionOutcomeDate,
            this.colOfficeExamDate,
            this.colNote,
            this.colStatus});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colStatus;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual;
            styleFormatCondition1.Value1 = "100";
            this.gridViewSixMonthReports.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridViewSixMonthReports.GridControl = this.gridControlSixMonthReports;
            this.gridViewSixMonthReports.Name = "gridViewSixMonthReports";
            this.gridViewSixMonthReports.OptionsBehavior.Editable = false;
            this.gridViewSixMonthReports.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewSixMonthReports.OptionsView.ShowGroupPanel = false;
            this.gridViewSixMonthReports.OptionsView.ShowIndicator = false;
            this.gridViewSixMonthReports.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colReportDate, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridViewSixMonthReports.ShowGridMenu += new DevExpress.XtraGrid.Views.Grid.GridMenuEventHandler(this.gridViewSixMonthReports_ShowGridMenu);
            // 
            // colReportDate
            // 
            this.colReportDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colReportDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReportDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colReportDate.Caption = "Data relazione";
            this.colReportDate.FieldName = "DataRelazione";
            this.colReportDate.Name = "colReportDate";
            this.colReportDate.OptionsColumn.AllowEdit = false;
            this.colReportDate.OptionsColumn.AllowFocus = false;
            this.colReportDate.OptionsColumn.AllowMove = false;
            this.colReportDate.Visible = true;
            this.colReportDate.VisibleIndex = 0;
            this.colReportDate.Width = 65;
            // 
            // colCommissionOutcomeDate
            // 
            this.colCommissionOutcomeDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colCommissionOutcomeDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCommissionOutcomeDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colCommissionOutcomeDate.Caption = "Data parere commissione";
            this.colCommissionOutcomeDate.DisplayFormat.FormatString = "d";
            this.colCommissionOutcomeDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCommissionOutcomeDate.FieldName = "DataEsitoCommissione";
            this.colCommissionOutcomeDate.Name = "colCommissionOutcomeDate";
            this.colCommissionOutcomeDate.OptionsColumn.AllowEdit = false;
            this.colCommissionOutcomeDate.OptionsColumn.AllowFocus = false;
            this.colCommissionOutcomeDate.OptionsColumn.AllowMove = false;
            this.colCommissionOutcomeDate.Visible = true;
            this.colCommissionOutcomeDate.VisibleIndex = 1;
            this.colCommissionOutcomeDate.Width = 93;
            // 
            // colOfficeExamDate
            // 
            this.colOfficeExamDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colOfficeExamDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOfficeExamDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colOfficeExamDate.Caption = "Data esame ufficio";
            this.colOfficeExamDate.DisplayFormat.FormatString = "d";
            this.colOfficeExamDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colOfficeExamDate.FieldName = "DataEsameufficio";
            this.colOfficeExamDate.Name = "colOfficeExamDate";
            this.colOfficeExamDate.OptionsColumn.AllowEdit = false;
            this.colOfficeExamDate.OptionsColumn.AllowFocus = false;
            this.colOfficeExamDate.OptionsColumn.AllowMove = false;
            this.colOfficeExamDate.Visible = true;
            this.colOfficeExamDate.VisibleIndex = 2;
            this.colOfficeExamDate.Width = 83;
            // 
            // colNote
            // 
            this.colNote.AppearanceHeader.Options.UseTextOptions = true;
            this.colNote.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNote.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colNote.Caption = "Note";
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.OptionsColumn.AllowEdit = false;
            this.colNote.OptionsColumn.AllowFocus = false;
            this.colNote.OptionsColumn.AllowMove = false;
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 3;
            this.colNote.Width = 293;
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
            // popupMenuRelazioneSemestrale
            // 
            this.popupMenuRelazioneSemestrale.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemModify),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemDelete)});
            this.popupMenuRelazioneSemestrale.Manager = this.BarManager;
            this.popupMenuRelazioneSemestrale.Name = "popupMenuRelazioneSemestrale";
            // 
            // RelazioneSemestraleDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "RelazioneSemestraleDetail";
            this.Size = new System.Drawing.Size(808, 448);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSixMonthReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSixMonthReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSixMonthReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuRelazioneSemestrale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraGrid.GridControl gridControlSixMonthReports;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSixMonthReports;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceSixMonthReports;
        private DevExpress.XtraGrid.Columns.GridColumn colReportDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCommissionOutcomeDate;
        private DevExpress.XtraGrid.Columns.GridColumn colOfficeExamDate;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraBars.BarButtonItem barButtonItemModify;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraBars.PopupMenu popupMenuRelazioneSemestrale;
    }
}
