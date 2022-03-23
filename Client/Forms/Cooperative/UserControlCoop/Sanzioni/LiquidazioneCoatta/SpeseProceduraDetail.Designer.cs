namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Sanzioni.LiquidazioneCoatta
{
    partial class SpeseProceduraDetail
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
            this.bindingSourceProcedurePayments = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.gridControlCommissionerPayments = new DevExpress.XtraGrid.GridControl();
            this.gridViewCommissionerPayments = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRequestReceivingDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImportoDeterminato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeterminaNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeterminaDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsLiquidated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.popupMenuSpeseProcedura = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProcedurePayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCommissionerPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCommissionerPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuSpeseProcedura)).BeginInit();
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
            this.BarManager.MaxItemId = 13;
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.gridControlCommissionerPayments);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 49);
            this.ScrollableContent.Size = new System.Drawing.Size(808, 399);
            // 
            // colStatus
            // 
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
            this.barButtonItemModify.Id = 12;
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
            // bindingSourceProcedurePayments
            // 
            this.bindingSourceProcedurePayments.AutoCreateObjects = false;
            this.bindingSourceProcedurePayments.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.CompensoLiquidazioneFDT);
            this.bindingSourceProcedurePayments.CurrentChanged += new System.EventHandler(this.bindingSourceProcedurePayments_CurrentChanged);
            // 
            // gridControlCommissionerPayments
            // 
            this.gridControlCommissionerPayments.DataSource = this.bindingSourceProcedurePayments;
            this.gridControlCommissionerPayments.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlCommissionerPayments.Location = new System.Drawing.Point(0, 0);
            this.gridControlCommissionerPayments.MainView = this.gridViewCommissionerPayments;
            this.gridControlCommissionerPayments.Name = "gridControlCommissionerPayments";
            this.gridControlCommissionerPayments.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControlCommissionerPayments.Size = new System.Drawing.Size(808, 399);
            this.gridControlCommissionerPayments.TabIndex = 3;
            this.gridControlCommissionerPayments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCommissionerPayments});
            this.gridControlCommissionerPayments.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlCommissionerPayments_MouseDoubleClick);
            // 
            // gridViewCommissionerPayments
            // 
            this.gridViewCommissionerPayments.ColumnPanelRowHeight = 40;
            this.gridViewCommissionerPayments.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRequestReceivingDate,
            this.colImportoDeterminato,
            this.colDeterminaNumber,
            this.colDeterminaDate,
            this.colIsLiquidated,
            this.colStatus});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colStatus;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual;
            styleFormatCondition1.Value1 = "100";
            this.gridViewCommissionerPayments.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridViewCommissionerPayments.GridControl = this.gridControlCommissionerPayments;
            this.gridViewCommissionerPayments.Name = "gridViewCommissionerPayments";
            this.gridViewCommissionerPayments.OptionsBehavior.Editable = false;
            this.gridViewCommissionerPayments.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewCommissionerPayments.OptionsView.ShowFooter = true;
            this.gridViewCommissionerPayments.OptionsView.ShowGroupPanel = false;
            this.gridViewCommissionerPayments.OptionsView.ShowIndicator = false;
            this.gridViewCommissionerPayments.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colImportoDeterminato, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewCommissionerPayments.ShowGridMenu += new DevExpress.XtraGrid.Views.Grid.GridMenuEventHandler(this.gridViewCommissionerPayments_ShowGridMenu);
            // 
            // colRequestReceivingDate
            // 
            this.colRequestReceivingDate.AppearanceCell.Options.UseTextOptions = true;
            this.colRequestReceivingDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colRequestReceivingDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colRequestReceivingDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRequestReceivingDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colRequestReceivingDate.Caption = "Ricevimento domanda contributo";
            this.colRequestReceivingDate.DisplayFormat.FormatString = "d";
            this.colRequestReceivingDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colRequestReceivingDate.FieldName = "DataRicevimentoDomanda";
            this.colRequestReceivingDate.Name = "colRequestReceivingDate";
            this.colRequestReceivingDate.OptionsColumn.AllowEdit = false;
            this.colRequestReceivingDate.OptionsColumn.AllowFocus = false;
            this.colRequestReceivingDate.OptionsColumn.AllowMove = false;
            this.colRequestReceivingDate.Visible = true;
            this.colRequestReceivingDate.VisibleIndex = 0;
            this.colRequestReceivingDate.Width = 77;
            // 
            // colImportoDeterminato
            // 
            this.colImportoDeterminato.AppearanceHeader.Options.UseTextOptions = true;
            this.colImportoDeterminato.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colImportoDeterminato.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colImportoDeterminato.Caption = "Importe spese determinate nel BFL";
            this.colImportoDeterminato.DisplayFormat.FormatString = "n";
            this.colImportoDeterminato.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colImportoDeterminato.FieldName = "ImportoDeterminato";
            this.colImportoDeterminato.Name = "colImportoDeterminato";
            this.colImportoDeterminato.OptionsColumn.AllowEdit = false;
            this.colImportoDeterminato.OptionsColumn.AllowFocus = false;
            this.colImportoDeterminato.OptionsColumn.AllowMove = false;
            this.colImportoDeterminato.SummaryItem.DisplayFormat = "{0:N2}";
            this.colImportoDeterminato.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colImportoDeterminato.Visible = true;
            this.colImportoDeterminato.VisibleIndex = 1;
            this.colImportoDeterminato.Width = 68;
            // 
            // colDeterminaNumber
            // 
            this.colDeterminaNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colDeterminaNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDeterminaNumber.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colDeterminaNumber.Caption = "Numero determina";
            this.colDeterminaNumber.FieldName = "NumeroDetermina";
            this.colDeterminaNumber.Name = "colDeterminaNumber";
            this.colDeterminaNumber.OptionsColumn.AllowEdit = false;
            this.colDeterminaNumber.OptionsColumn.AllowFocus = false;
            this.colDeterminaNumber.OptionsColumn.AllowMove = false;
            this.colDeterminaNumber.Visible = true;
            this.colDeterminaNumber.VisibleIndex = 2;
            this.colDeterminaNumber.Width = 60;
            // 
            // colDeterminaDate
            // 
            this.colDeterminaDate.AppearanceCell.Options.UseTextOptions = true;
            this.colDeterminaDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDeterminaDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colDeterminaDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDeterminaDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colDeterminaDate.Caption = "Data determina";
            this.colDeterminaDate.DisplayFormat.FormatString = "d";
            this.colDeterminaDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDeterminaDate.FieldName = "DataDetermina";
            this.colDeterminaDate.Name = "colDeterminaDate";
            this.colDeterminaDate.OptionsColumn.AllowEdit = false;
            this.colDeterminaDate.OptionsColumn.AllowFocus = false;
            this.colDeterminaDate.OptionsColumn.AllowMove = false;
            this.colDeterminaDate.Visible = true;
            this.colDeterminaDate.VisibleIndex = 3;
            this.colDeterminaDate.Width = 50;
            // 
            // colIsLiquidated
            // 
            this.colIsLiquidated.AppearanceHeader.Options.UseTextOptions = true;
            this.colIsLiquidated.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsLiquidated.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colIsLiquidated.Caption = "Liquidato";
            this.colIsLiquidated.FieldName = "Liquidato";
            this.colIsLiquidated.Name = "colIsLiquidated";
            this.colIsLiquidated.OptionsColumn.AllowEdit = false;
            this.colIsLiquidated.OptionsColumn.AllowFocus = false;
            this.colIsLiquidated.OptionsColumn.AllowMove = false;
            this.colIsLiquidated.Visible = true;
            this.colIsLiquidated.VisibleIndex = 4;
            this.colIsLiquidated.Width = 62;
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
            // popupMenuSpeseProcedura
            // 
            this.popupMenuSpeseProcedura.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemModify),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemDelete)});
            this.popupMenuSpeseProcedura.Manager = this.BarManager;
            this.popupMenuSpeseProcedura.Name = "popupMenuSpeseProcedura";
            // 
            // SpeseProceduraDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "SpeseProceduraDetail";
            this.Size = new System.Drawing.Size(808, 448);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProcedurePayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCommissionerPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCommissionerPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuSpeseProcedura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceProcedurePayments;
        private DevExpress.XtraGrid.GridControl gridControlCommissionerPayments;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCommissionerPayments;
        private DevExpress.XtraGrid.Columns.GridColumn colRequestReceivingDate;
        private DevExpress.XtraGrid.Columns.GridColumn colImportoDeterminato;
        private DevExpress.XtraGrid.Columns.GridColumn colDeterminaNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDeterminaDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIsLiquidated;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemModify;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraBars.PopupMenu popupMenuSpeseProcedura;
    }
}
