namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Revisione
{
    partial class IncaricoRevisioneDetail
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
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridControlRevisionTask = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceBaseIncarichi = new OeF.Forms.BindingSourceBase(this.components);
            this.gridViewRevisionTask = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumeroDeliberaCommissioneIncarico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataScadenzaTeorica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataDeterminaIncarico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImportoImpegno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompensoRevisore_Revisore_DescrizioneBreve = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompensoRevisore_ImportoTotale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemModify = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuIncarico = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRevisionTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseIncarichi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRevisionTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuIncarico)).BeginInit();
            this.SuspendLayout();
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
            this.ScrollableContent.Controls.Add(this.gridControlRevisionTask);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 49);
            this.ScrollableContent.Size = new System.Drawing.Size(800, 259);
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.DisplayMember = "Value";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.NullText = "€";
            this.repositoryItemLookUpEdit3.ValueMember = "Key";
            // 
            // gridControlRevisionTask
            // 
            this.gridControlRevisionTask.DataSource = this.bindingSourceBaseIncarichi;
            this.gridControlRevisionTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlRevisionTask.Location = new System.Drawing.Point(0, 0);
            this.gridControlRevisionTask.MainView = this.gridViewRevisionTask;
            this.gridControlRevisionTask.Name = "gridControlRevisionTask";
            this.gridControlRevisionTask.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemLookUpEdit3});
            this.gridControlRevisionTask.Size = new System.Drawing.Size(800, 259);
            this.gridControlRevisionTask.TabIndex = 8;
            this.gridControlRevisionTask.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRevisionTask});
            this.gridControlRevisionTask.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlRevisionTask_MouseDoubleClick);
            // 
            // bindingSourceBaseIncarichi
            // 
            this.bindingSourceBaseIncarichi.AutoCreateObjects = false;
            this.bindingSourceBaseIncarichi.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.RevisioneIncaricoFDT);
            this.bindingSourceBaseIncarichi.CurrentChanged += new System.EventHandler(this.bindingSourceBaseIncarichi_CurrentChanged);
            // 
            // gridViewRevisionTask
            // 
            this.gridViewRevisionTask.ColumnPanelRowHeight = 40;
            this.gridViewRevisionTask.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumeroDeliberaCommissioneIncarico,
            this.colDataScadenzaTeorica,
            this.colDataDeterminaIncarico,
            this.colImportoImpegno,
            this.colCompensoRevisore_Revisore_DescrizioneBreve,
            this.colCompensoRevisore_ImportoTotale,
            this.colStatus});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout);
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colStatus;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual;
            styleFormatCondition1.Value1 = "100";
            this.gridViewRevisionTask.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridViewRevisionTask.GridControl = this.gridControlRevisionTask;
            this.gridViewRevisionTask.Name = "gridViewRevisionTask";
            this.gridViewRevisionTask.OptionsBehavior.Editable = false;
            this.gridViewRevisionTask.OptionsCustomization.AllowGroup = false;
            this.gridViewRevisionTask.OptionsDetail.AllowZoomDetail = false;
            this.gridViewRevisionTask.OptionsDetail.ShowDetailTabs = false;
            this.gridViewRevisionTask.OptionsMenu.EnableFooterMenu = false;
            this.gridViewRevisionTask.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewRevisionTask.OptionsView.ShowFooter = true;
            this.gridViewRevisionTask.OptionsView.ShowGroupPanel = false;
            this.gridViewRevisionTask.OptionsView.ShowIndicator = false;
            this.gridViewRevisionTask.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNumeroDeliberaCommissioneIncarico, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewRevisionTask.ShowGridMenu += new DevExpress.XtraGrid.Views.Grid.GridMenuEventHandler(this.gridViewRevisionTask_ShowGridMenu);
            // 
            // colNumeroDeliberaCommissioneIncarico
            // 
            this.colNumeroDeliberaCommissioneIncarico.AppearanceCell.Options.UseTextOptions = true;
            this.colNumeroDeliberaCommissioneIncarico.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumeroDeliberaCommissioneIncarico.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumeroDeliberaCommissioneIncarico.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumeroDeliberaCommissioneIncarico.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colNumeroDeliberaCommissioneIncarico.Caption = "Delibera commissione";
            this.colNumeroDeliberaCommissioneIncarico.FieldName = "NumeroDeliberaCommissioneIncarico";
            this.colNumeroDeliberaCommissioneIncarico.Name = "colNumeroDeliberaCommissioneIncarico";
            this.colNumeroDeliberaCommissioneIncarico.OptionsColumn.AllowEdit = false;
            this.colNumeroDeliberaCommissioneIncarico.OptionsColumn.AllowFocus = false;
            this.colNumeroDeliberaCommissioneIncarico.OptionsColumn.AllowMove = false;
            this.colNumeroDeliberaCommissioneIncarico.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNumeroDeliberaCommissioneIncarico.OptionsFilter.AllowAutoFilter = false;
            this.colNumeroDeliberaCommissioneIncarico.OptionsFilter.AllowFilter = false;
            this.colNumeroDeliberaCommissioneIncarico.Visible = true;
            this.colNumeroDeliberaCommissioneIncarico.VisibleIndex = 0;
            this.colNumeroDeliberaCommissioneIncarico.Width = 123;
            // 
            // colDataScadenzaTeorica
            // 
            this.colDataScadenzaTeorica.AppearanceCell.Options.UseTextOptions = true;
            this.colDataScadenzaTeorica.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataScadenzaTeorica.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataScadenzaTeorica.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataScadenzaTeorica.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colDataScadenzaTeorica.Caption = "Data scadenza teorica";
            this.colDataScadenzaTeorica.DisplayFormat.FormatString = "d";
            this.colDataScadenzaTeorica.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDataScadenzaTeorica.FieldName = "DataScadenzaTeorica";
            this.colDataScadenzaTeorica.Name = "colDataScadenzaTeorica";
            this.colDataScadenzaTeorica.OptionsColumn.AllowEdit = false;
            this.colDataScadenzaTeorica.OptionsColumn.AllowFocus = false;
            this.colDataScadenzaTeorica.OptionsColumn.AllowMove = false;
            this.colDataScadenzaTeorica.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDataScadenzaTeorica.OptionsFilter.AllowAutoFilter = false;
            this.colDataScadenzaTeorica.OptionsFilter.AllowFilter = false;
            this.colDataScadenzaTeorica.Visible = true;
            this.colDataScadenzaTeorica.VisibleIndex = 1;
            this.colDataScadenzaTeorica.Width = 133;
            // 
            // colDataDeterminaIncarico
            // 
            this.colDataDeterminaIncarico.AppearanceCell.Options.UseTextOptions = true;
            this.colDataDeterminaIncarico.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataDeterminaIncarico.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataDeterminaIncarico.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataDeterminaIncarico.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colDataDeterminaIncarico.Caption = "Determina incarico";
            this.colDataDeterminaIncarico.DisplayFormat.FormatString = "d";
            this.colDataDeterminaIncarico.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDataDeterminaIncarico.FieldName = "DataDeterminaIncarico";
            this.colDataDeterminaIncarico.Name = "colDataDeterminaIncarico";
            this.colDataDeterminaIncarico.OptionsColumn.AllowEdit = false;
            this.colDataDeterminaIncarico.OptionsColumn.AllowFocus = false;
            this.colDataDeterminaIncarico.OptionsColumn.AllowMove = false;
            this.colDataDeterminaIncarico.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDataDeterminaIncarico.OptionsFilter.AllowAutoFilter = false;
            this.colDataDeterminaIncarico.OptionsFilter.AllowFilter = false;
            this.colDataDeterminaIncarico.Visible = true;
            this.colDataDeterminaIncarico.VisibleIndex = 2;
            this.colDataDeterminaIncarico.Width = 103;
            // 
            // colImportoImpegno
            // 
            this.colImportoImpegno.AppearanceHeader.Options.UseTextOptions = true;
            this.colImportoImpegno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colImportoImpegno.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colImportoImpegno.Caption = "Importo impegno";
            this.colImportoImpegno.DisplayFormat.FormatString = "n";
            this.colImportoImpegno.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colImportoImpegno.FieldName = "ImportoImpegno";
            this.colImportoImpegno.Name = "colImportoImpegno";
            this.colImportoImpegno.Visible = true;
            this.colImportoImpegno.VisibleIndex = 3;
            this.colImportoImpegno.Width = 101;
            // 
            // colCompensoRevisore_Revisore_DescrizioneBreve
            // 
            this.colCompensoRevisore_Revisore_DescrizioneBreve.Caption = "Revisore";
            this.colCompensoRevisore_Revisore_DescrizioneBreve.FieldName = "CompensoRevisore_Revisore_DescrizioneBreve";
            this.colCompensoRevisore_Revisore_DescrizioneBreve.Name = "colCompensoRevisore_Revisore_DescrizioneBreve";
            this.colCompensoRevisore_Revisore_DescrizioneBreve.Visible = true;
            this.colCompensoRevisore_Revisore_DescrizioneBreve.VisibleIndex = 4;
            this.colCompensoRevisore_Revisore_DescrizioneBreve.Width = 173;
            // 
            // colCompensoRevisore_ImportoTotale
            // 
            this.colCompensoRevisore_ImportoTotale.Caption = "Importo totale";
            this.colCompensoRevisore_ImportoTotale.DisplayFormat.FormatString = "n";
            this.colCompensoRevisore_ImportoTotale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCompensoRevisore_ImportoTotale.FieldName = "CompensoRevisore_ImportoTotale";
            this.colCompensoRevisore_ImportoTotale.Name = "colCompensoRevisore_ImportoTotale";
            this.colCompensoRevisore_ImportoTotale.SummaryItem.DisplayFormat = "{0:N2}";
            this.colCompensoRevisore_ImportoTotale.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colCompensoRevisore_ImportoTotale.Visible = true;
            this.colCompensoRevisore_ImportoTotale.VisibleIndex = 5;
            this.colCompensoRevisore_ImportoTotale.Width = 100;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DisplayMember = "Value";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "Key";
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ValueMember = "IdElemento";
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
            // popupMenuIncarico
            // 
            this.popupMenuIncarico.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemModify),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemDelete)});
            this.popupMenuIncarico.Manager = this.BarManager;
            this.popupMenuIncarico.Name = "popupMenuIncarico";
            // 
            // IncaricoRevisioneDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "IncaricoRevisioneDetail";
            this.Size = new System.Drawing.Size(800, 308);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRevisionTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseIncarichi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRevisionTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuIncarico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlRevisionTask;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRevisionTask;
        private OeF.Forms.BindingSourceBase bindingSourceBaseIncarichi;
        private DevExpress.XtraGrid.Columns.GridColumn colDataScadenzaTeorica;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroDeliberaCommissioneIncarico;
        private DevExpress.XtraGrid.Columns.GridColumn colDataDeterminaIncarico;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colImportoImpegno;
        private DevExpress.XtraBars.BarButtonItem barButtonItemModify;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraBars.PopupMenu popupMenuIncarico;
        private DevExpress.XtraGrid.Columns.GridColumn colCompensoRevisore_Revisore_DescrizioneBreve;
        private DevExpress.XtraGrid.Columns.GridColumn colCompensoRevisore_ImportoTotale;
    }
}
