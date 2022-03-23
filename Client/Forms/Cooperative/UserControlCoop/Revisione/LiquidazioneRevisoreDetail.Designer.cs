namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Revisione
{
    partial class LiquidazioneRevisoreDetail
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
            this.barButtonItemAddNew = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemModify = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRemove = new DevExpress.XtraBars.BarButtonItem();
            this.gridControlCommissionerPayments = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceLiquidazioneCompensi = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.gridViewCommissionerPayments = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDataRicevimentoDomanda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImportoContributoPAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLiquidato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataLiquidazioneUfficio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.popupMenuLiquidazione = new DevExpress.XtraBars.PopupMenu(this.components);
            this.colNumeroDetermina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataDetermina = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCommissionerPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLiquidazioneCompensi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCommissionerPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuLiquidazione)).BeginInit();
            this.SuspendLayout();
            // 
            // BarManager
            // 
            this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemAddNew,
            this.barButtonItemRemove,
            this.barButtonItemModify});
            this.BarManager.MaxItemId = 15;
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.gridControlCommissionerPayments);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 49);
            this.ScrollableContent.Size = new System.Drawing.Size(808, 116);
            // 
            // BarGridControl
            // 
            this.BarGridControl.DockRow = 1;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemAddNew, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemModify, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemRemove, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 2";
            // 
            // barButtonItemAddNew
            // 
            this.barButtonItemAddNew.Caption = "Nuovo";
            this.barButtonItemAddNew.Id = 9;
            this.barButtonItemAddNew.Name = "barButtonItemAddNew";
            this.barButtonItemAddNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAddNew_ItemClick);
            // 
            // barButtonItemModify
            // 
            this.barButtonItemModify.Caption = "Modifica";
            this.barButtonItemModify.Id = 11;
            this.barButtonItemModify.Name = "barButtonItemModify";
            this.barButtonItemModify.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemModify_ItemClick);
            // 
            // barButtonItemRemove
            // 
            this.barButtonItemRemove.Caption = "Cancella";
            this.barButtonItemRemove.Id = 10;
            this.barButtonItemRemove.Name = "barButtonItemRemove";
            this.barButtonItemRemove.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemRemove_ItemClick);
            // 
            // gridControlCommissionerPayments
            // 
            this.gridControlCommissionerPayments.DataSource = this.bindingSourceLiquidazioneCompensi;
            this.gridControlCommissionerPayments.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlCommissionerPayments.Location = new System.Drawing.Point(0, 0);
            this.gridControlCommissionerPayments.MainView = this.gridViewCommissionerPayments;
            this.gridControlCommissionerPayments.Name = "gridControlCommissionerPayments";
            this.gridControlCommissionerPayments.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2});
            this.gridControlCommissionerPayments.Size = new System.Drawing.Size(808, 116);
            this.gridControlCommissionerPayments.TabIndex = 2;
            this.gridControlCommissionerPayments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCommissionerPayments});
            this.gridControlCommissionerPayments.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlCommissionerPayments_MouseDoubleClick);
            // 
            // bindingSourceLiquidazioneCompensi
            // 
            this.bindingSourceLiquidazioneCompensi.AutoCreateObjects = false;
            this.bindingSourceLiquidazioneCompensi.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.CompensoLiquidazioneFDT);
            this.bindingSourceLiquidazioneCompensi.CurrentChanged += new System.EventHandler(this.bindingSourceLiquidazioneCompensi_CurrentChanged);
            // 
            // gridViewCommissionerPayments
            // 
            this.gridViewCommissionerPayments.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDataRicevimentoDomanda,
            this.colImportoContributoPAT,
            this.colNumeroDetermina,
            this.colDataDetermina,
            this.colLiquidato,
            this.colDataLiquidazioneUfficio,
            this.colStatus});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout);
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colStatus;
            styleFormatCondition1.Value1 = "100";
            this.gridViewCommissionerPayments.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridViewCommissionerPayments.GridControl = this.gridControlCommissionerPayments;
            this.gridViewCommissionerPayments.Name = "gridViewCommissionerPayments";
            this.gridViewCommissionerPayments.OptionsBehavior.Editable = false;
            this.gridViewCommissionerPayments.OptionsMenu.EnableFooterMenu = false;
            this.gridViewCommissionerPayments.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewCommissionerPayments.OptionsView.ShowFooter = true;
            this.gridViewCommissionerPayments.OptionsView.ShowGroupPanel = false;
            this.gridViewCommissionerPayments.OptionsView.ShowIndicator = false;
            this.gridViewCommissionerPayments.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDataRicevimentoDomanda, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewCommissionerPayments.ShowGridMenu += new DevExpress.XtraGrid.Views.Grid.GridMenuEventHandler(this.gridViewCommissionerPayments_ShowGridMenu);
            // 
            // colDataRicevimentoDomanda
            // 
            this.colDataRicevimentoDomanda.AppearanceCell.Options.UseTextOptions = true;
            this.colDataRicevimentoDomanda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataRicevimentoDomanda.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataRicevimentoDomanda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataRicevimentoDomanda.Caption = "Data ricevimento domanda contributo";
            this.colDataRicevimentoDomanda.DisplayFormat.FormatString = "d";
            this.colDataRicevimentoDomanda.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDataRicevimentoDomanda.FieldName = "DataRicevimentoDomanda";
            this.colDataRicevimentoDomanda.Name = "colDataRicevimentoDomanda";
            this.colDataRicevimentoDomanda.OptionsColumn.AllowEdit = false;
            this.colDataRicevimentoDomanda.OptionsColumn.AllowFocus = false;
            this.colDataRicevimentoDomanda.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDataRicevimentoDomanda.OptionsColumn.AllowMove = false;
            this.colDataRicevimentoDomanda.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDataRicevimentoDomanda.OptionsFilter.AllowAutoFilter = false;
            this.colDataRicevimentoDomanda.OptionsFilter.AllowFilter = false;
            this.colDataRicevimentoDomanda.Visible = true;
            this.colDataRicevimentoDomanda.VisibleIndex = 0;
            this.colDataRicevimentoDomanda.Width = 213;
            // 
            // colImportoContributoPAT
            // 
            this.colImportoContributoPAT.AppearanceHeader.Options.UseTextOptions = true;
            this.colImportoContributoPAT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colImportoContributoPAT.Caption = "Importo erogato";
            this.colImportoContributoPAT.DisplayFormat.FormatString = "n";
            this.colImportoContributoPAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colImportoContributoPAT.FieldName = "ImportoErogato";
            this.colImportoContributoPAT.Name = "colImportoContributoPAT";
            this.colImportoContributoPAT.OptionsColumn.AllowEdit = false;
            this.colImportoContributoPAT.OptionsColumn.AllowFocus = false;
            this.colImportoContributoPAT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colImportoContributoPAT.OptionsColumn.AllowMove = false;
            this.colImportoContributoPAT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colImportoContributoPAT.OptionsFilter.AllowAutoFilter = false;
            this.colImportoContributoPAT.OptionsFilter.AllowFilter = false;
            this.colImportoContributoPAT.SummaryItem.DisplayFormat = "{0:N2}";
            this.colImportoContributoPAT.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colImportoContributoPAT.Visible = true;
            this.colImportoContributoPAT.VisibleIndex = 1;
            this.colImportoContributoPAT.Width = 263;
            // 
            // colLiquidato
            // 
            this.colLiquidato.AppearanceHeader.Options.UseTextOptions = true;
            this.colLiquidato.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLiquidato.Caption = "Liquidato";
            this.colLiquidato.FieldName = "Liquidato";
            this.colLiquidato.Name = "colLiquidato";
            this.colLiquidato.OptionsColumn.AllowEdit = false;
            this.colLiquidato.OptionsColumn.AllowFocus = false;
            this.colLiquidato.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colLiquidato.OptionsColumn.AllowMove = false;
            this.colLiquidato.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colLiquidato.OptionsFilter.AllowAutoFilter = false;
            this.colLiquidato.OptionsFilter.AllowFilter = false;
            this.colLiquidato.Visible = true;
            this.colLiquidato.VisibleIndex = 4;
            this.colLiquidato.Width = 114;
            // 
            // colDataLiquidazioneUfficio
            // 
            this.colDataLiquidazioneUfficio.AppearanceCell.Options.UseTextOptions = true;
            this.colDataLiquidazioneUfficio.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataLiquidazioneUfficio.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataLiquidazioneUfficio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataLiquidazioneUfficio.Caption = "Data liquidazione d\'ufficio";
            this.colDataLiquidazioneUfficio.DisplayFormat.FormatString = "d";
            this.colDataLiquidazioneUfficio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDataLiquidazioneUfficio.FieldName = "DataLiquidazioneUfficio";
            this.colDataLiquidazioneUfficio.Name = "colDataLiquidazioneUfficio";
            this.colDataLiquidazioneUfficio.OptionsColumn.AllowEdit = false;
            this.colDataLiquidazioneUfficio.OptionsColumn.AllowFocus = false;
            this.colDataLiquidazioneUfficio.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDataLiquidazioneUfficio.OptionsColumn.AllowMove = false;
            this.colDataLiquidazioneUfficio.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDataLiquidazioneUfficio.OptionsFilter.AllowAutoFilter = false;
            this.colDataLiquidazioneUfficio.OptionsFilter.AllowFilter = false;
            this.colDataLiquidazioneUfficio.Width = 178;
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
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.DisplayMember = "Value";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ValueMember = "Key";
            // 
            // popupMenuLiquidazione
            // 
            this.popupMenuLiquidazione.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAddNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemModify),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemRemove)});
            this.popupMenuLiquidazione.Manager = this.BarManager;
            this.popupMenuLiquidazione.Name = "popupMenuLiquidazione";
            // 
            // colNumeroDetermina
            // 
            this.colNumeroDetermina.Caption = "Numero determina";
            this.colNumeroDetermina.FieldName = "NumeroDetermina";
            this.colNumeroDetermina.Name = "colNumeroDetermina";
            this.colNumeroDetermina.Visible = true;
            this.colNumeroDetermina.VisibleIndex = 2;
            this.colNumeroDetermina.Width = 111;
            // 
            // colDataDetermina
            // 
            this.colDataDetermina.Caption = "Data determina";
            this.colDataDetermina.FieldName = "DataDetermina";
            this.colDataDetermina.Name = "colDataDetermina";
            this.colDataDetermina.Visible = true;
            this.colDataDetermina.VisibleIndex = 3;
            this.colDataDetermina.Width = 111;
            // 
            // LiquidazioneRevisoreDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "LiquidazioneRevisoreDetail";
            this.Size = new System.Drawing.Size(808, 165);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCommissionerPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLiquidazioneCompensi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCommissionerPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuLiquidazione)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAddNew;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRemove;
        private DevExpress.XtraGrid.GridControl gridControlCommissionerPayments;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCommissionerPayments;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceLiquidazioneCompensi;
        private DevExpress.XtraGrid.Columns.GridColumn colImportoContributoPAT;
        private DevExpress.XtraGrid.Columns.GridColumn colLiquidato;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colDataRicevimentoDomanda;
        private DevExpress.XtraGrid.Columns.GridColumn colDataLiquidazioneUfficio;
        private DevExpress.XtraBars.BarButtonItem barButtonItemModify;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraBars.PopupMenu popupMenuLiquidazione;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroDetermina;
        private DevExpress.XtraGrid.Columns.GridColumn colDataDetermina;
    }
}
