namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Sanzioni.LiquidazioneCoatta
{
    partial class AcquistoCreditFiscDetail
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
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemModify = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.gridControlAcquistoCreditFisc = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceTaxCreditBuy = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.gridViewAcquistoCreditFisc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumeroDelibera = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataDelibera = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImporto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.popupMenuAcquistoCreditFisc = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAcquistoCreditFisc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTaxCreditBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAcquistoCreditFisc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuAcquistoCreditFisc)).BeginInit();
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
            this.BarManager.MaxItemId = 18;
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.gridControlAcquistoCreditFisc);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 49);
            this.ScrollableContent.Size = new System.Drawing.Size(536, 323);
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
            this.barButtonItemAdd.Id = 15;
            this.barButtonItemAdd.Name = "barButtonItemAdd";
            this.barButtonItemAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAdd_ItemClick);
            // 
            // barButtonItemModify
            // 
            this.barButtonItemModify.Caption = "Modifica";
            this.barButtonItemModify.Id = 16;
            this.barButtonItemModify.Name = "barButtonItemModify";
            this.barButtonItemModify.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemModify_ItemClick);
            // 
            // barButtonItemDelete
            // 
            this.barButtonItemDelete.Caption = "Cancella";
            this.barButtonItemDelete.Id = 17;
            this.barButtonItemDelete.Name = "barButtonItemDelete";
            this.barButtonItemDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDelete_ItemClick);
            // 
            // gridControlAcquistoCreditFisc
            // 
            this.gridControlAcquistoCreditFisc.DataSource = this.bindingSourceTaxCreditBuy;
            this.gridControlAcquistoCreditFisc.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlAcquistoCreditFisc.Location = new System.Drawing.Point(0, 0);
            this.gridControlAcquistoCreditFisc.MainView = this.gridViewAcquistoCreditFisc;
            this.gridControlAcquistoCreditFisc.Name = "gridControlAcquistoCreditFisc";
            this.gridControlAcquistoCreditFisc.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControlAcquistoCreditFisc.Size = new System.Drawing.Size(536, 323);
            this.gridControlAcquistoCreditFisc.TabIndex = 3;
            this.gridControlAcquistoCreditFisc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAcquistoCreditFisc});
            this.gridControlAcquistoCreditFisc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlAcquistoCreditFisc_MouseDoubleClick);
            // 
            // bindingSourceTaxCreditBuy
            // 
            this.bindingSourceTaxCreditBuy.AutoCreateObjects = false;
            this.bindingSourceTaxCreditBuy.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DeliberaAcquistoCreditiFiscFDT);
            this.bindingSourceTaxCreditBuy.CurrentChanged += new System.EventHandler(this.bindingSourceTaxCreditBuy_CurrentChanged);
            // 
            // gridViewAcquistoCreditFisc
            // 
            this.gridViewAcquistoCreditFisc.ColumnPanelRowHeight = 40;
            this.gridViewAcquistoCreditFisc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumeroDelibera,
            this.colDataDelibera,
            this.colImporto,
            this.colStatus});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colStatus;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual;
            styleFormatCondition1.Value1 = "100";
            this.gridViewAcquistoCreditFisc.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridViewAcquistoCreditFisc.GridControl = this.gridControlAcquistoCreditFisc;
            this.gridViewAcquistoCreditFisc.Name = "gridViewAcquistoCreditFisc";
            this.gridViewAcquistoCreditFisc.OptionsBehavior.Editable = false;
            this.gridViewAcquistoCreditFisc.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewAcquistoCreditFisc.OptionsView.ShowFooter = true;
            this.gridViewAcquistoCreditFisc.OptionsView.ShowGroupPanel = false;
            this.gridViewAcquistoCreditFisc.OptionsView.ShowIndicator = false;
            this.gridViewAcquistoCreditFisc.ShowGridMenu += new DevExpress.XtraGrid.Views.Grid.GridMenuEventHandler(this.gridViewAcquistoCreditFisc_ShowGridMenu);
            // 
            // colNumeroDelibera
            // 
            this.colNumeroDelibera.Caption = "Numero delibera";
            this.colNumeroDelibera.FieldName = "NumeroDelibera";
            this.colNumeroDelibera.Name = "colNumeroDelibera";
            this.colNumeroDelibera.OptionsColumn.AllowEdit = false;
            this.colNumeroDelibera.OptionsColumn.AllowFocus = false;
            this.colNumeroDelibera.OptionsColumn.AllowMove = false;
            this.colNumeroDelibera.Visible = true;
            this.colNumeroDelibera.VisibleIndex = 0;
            // 
            // colDataDelibera
            // 
            this.colDataDelibera.Caption = "Data delibera";
            this.colDataDelibera.DisplayFormat.FormatString = "d";
            this.colDataDelibera.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDataDelibera.FieldName = "DataDelibera";
            this.colDataDelibera.Name = "colDataDelibera";
            this.colDataDelibera.OptionsColumn.AllowEdit = false;
            this.colDataDelibera.OptionsColumn.AllowFocus = false;
            this.colDataDelibera.OptionsColumn.AllowMove = false;
            this.colDataDelibera.Visible = true;
            this.colDataDelibera.VisibleIndex = 1;
            // 
            // colImporto
            // 
            this.colImporto.Caption = "Importo";
            this.colImporto.DisplayFormat.FormatString = "n";
            this.colImporto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colImporto.FieldName = "Importo";
            this.colImporto.Name = "colImporto";
            this.colImporto.OptionsColumn.AllowEdit = false;
            this.colImporto.OptionsColumn.AllowFocus = false;
            this.colImporto.OptionsColumn.AllowMove = false;
            this.colImporto.SummaryItem.DisplayFormat = "{0:N2}";
            this.colImporto.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colImporto.Visible = true;
            this.colImporto.VisibleIndex = 2;
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
            // popupMenuAcquistoCreditFisc
            // 
            this.popupMenuAcquistoCreditFisc.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemModify),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemDelete)});
            this.popupMenuAcquistoCreditFisc.Manager = this.BarManager;
            this.popupMenuAcquistoCreditFisc.Name = "popupMenuAcquistoCreditFisc";
            // 
            // AcquistoCreditFiscDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "AcquistoCreditFiscDetail";
            this.Size = new System.Drawing.Size(536, 372);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAcquistoCreditFisc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTaxCreditBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAcquistoCreditFisc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuAcquistoCreditFisc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraGrid.GridControl gridControlAcquistoCreditFisc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAcquistoCreditFisc;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceTaxCreditBuy;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroDelibera;
        private DevExpress.XtraGrid.Columns.GridColumn colDataDelibera;
        private DevExpress.XtraGrid.Columns.GridColumn colImporto;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemModify;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraBars.PopupMenu popupMenuAcquistoCreditFisc;
    }
}
