namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Sanzioni.Commissari
{
    partial class CommissarioDetail
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
            this.gridControlCommissioner = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceForcedLiquidation = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.gridViewCommissioner = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRevisorLiquidation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRevisor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPercentageCNP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPercentageIVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCounterBalanceAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSpendingAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCaseAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIvaAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.popupMenuCommissario = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCommissioner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceForcedLiquidation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCommissioner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuCommissario)).BeginInit();
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
            this.BarManager.MaxItemId = 12;
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.gridControlCommissioner);
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
            // gridControlCommissioner
            // 
            this.gridControlCommissioner.DataSource = this.bindingSourceForcedLiquidation;
            this.gridControlCommissioner.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlCommissioner.Location = new System.Drawing.Point(0, 0);
            this.gridControlCommissioner.MainView = this.gridViewCommissioner;
            this.gridControlCommissioner.Name = "gridControlCommissioner";
            this.gridControlCommissioner.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemPictureEdit1,
            this.repositoryItemTextEdit1});
            this.gridControlCommissioner.Size = new System.Drawing.Size(808, 399);
            this.gridControlCommissioner.TabIndex = 2;
            this.gridControlCommissioner.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCommissioner});
            this.gridControlCommissioner.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlCommissioner_MouseDoubleClick);
            // 
            // bindingSourceForcedLiquidation
            // 
            this.bindingSourceForcedLiquidation.AutoCreateObjects = false;
            this.bindingSourceForcedLiquidation.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.CompensoFDT);
            this.bindingSourceForcedLiquidation.CurrentChanged += new System.EventHandler(this.bindingSourceForcedLiquidation_CurrentChanged);
            // 
            // gridViewCommissioner
            // 
            this.gridViewCommissioner.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRevisorLiquidation,
            this.colRevisor,
            this.colPercentageCNP,
            this.colPercentageIVA,
            this.colCounterBalanceAmount,
            this.colSpendingAmount,
            this.colCaseAmount,
            this.colIvaAmount,
            this.colTotalAmount,
            this.colStatus});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colStatus;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual;
            styleFormatCondition1.Value1 = "100";
            this.gridViewCommissioner.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridViewCommissioner.GridControl = this.gridControlCommissioner;
            this.gridViewCommissioner.Name = "gridViewCommissioner";
            this.gridViewCommissioner.OptionsBehavior.Editable = false;
            this.gridViewCommissioner.OptionsMenu.EnableColumnMenu = false;
            this.gridViewCommissioner.OptionsMenu.EnableFooterMenu = false;
            this.gridViewCommissioner.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewCommissioner.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewCommissioner.OptionsView.ShowFooter = true;
            this.gridViewCommissioner.OptionsView.ShowGroupPanel = false;
            this.gridViewCommissioner.OptionsView.ShowIndicator = false;
            this.gridViewCommissioner.ShowGridMenu += new DevExpress.XtraGrid.Views.Grid.GridMenuEventHandler(this.gridViewCommissioner_ShowGridMenu);
            // 
            // colRevisorLiquidation
            // 
            this.colRevisorLiquidation.Caption = "Commisario liquidatore";
            this.colRevisorLiquidation.FieldName = "Revisore";
            this.colRevisorLiquidation.Name = "colRevisorLiquidation";
            this.colRevisorLiquidation.OptionsColumn.AllowEdit = false;
            this.colRevisorLiquidation.OptionsColumn.AllowFocus = false;
            this.colRevisorLiquidation.OptionsColumn.AllowMove = false;
            this.colRevisorLiquidation.Width = 137;
            // 
            // colRevisor
            // 
            this.colRevisor.Caption = "Commissario";
            this.colRevisor.FieldName = "Revisore";
            this.colRevisor.Name = "colRevisor";
            this.colRevisor.OptionsColumn.AllowEdit = false;
            this.colRevisor.OptionsColumn.AllowFocus = false;
            this.colRevisor.OptionsColumn.AllowMove = false;
            this.colRevisor.OptionsFilter.AllowAutoFilter = false;
            this.colRevisor.OptionsFilter.AllowFilter = false;
            this.colRevisor.Visible = true;
            this.colRevisor.VisibleIndex = 0;
            this.colRevisor.Width = 137;
            // 
            // colPercentageCNP
            // 
            this.colPercentageCNP.Caption = "% C.N.P.";
            this.colPercentageCNP.DisplayFormat.FormatString = "n";
            this.colPercentageCNP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPercentageCNP.FieldName = "PercentualeCNP";
            this.colPercentageCNP.Name = "colPercentageCNP";
            this.colPercentageCNP.OptionsColumn.AllowEdit = false;
            this.colPercentageCNP.OptionsColumn.AllowFocus = false;
            this.colPercentageCNP.OptionsColumn.AllowMove = false;
            this.colPercentageCNP.Visible = true;
            this.colPercentageCNP.VisibleIndex = 1;
            this.colPercentageCNP.Width = 67;
            // 
            // colPercentageIVA
            // 
            this.colPercentageIVA.Caption = "% I.V.A.";
            this.colPercentageIVA.DisplayFormat.FormatString = "n";
            this.colPercentageIVA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPercentageIVA.FieldName = "PercentualeIVA";
            this.colPercentageIVA.Name = "colPercentageIVA";
            this.colPercentageIVA.OptionsColumn.AllowEdit = false;
            this.colPercentageIVA.OptionsColumn.AllowFocus = false;
            this.colPercentageIVA.OptionsColumn.AllowMove = false;
            this.colPercentageIVA.Visible = true;
            this.colPercentageIVA.VisibleIndex = 2;
            this.colPercentageIVA.Width = 67;
            // 
            // colCounterBalanceAmount
            // 
            this.colCounterBalanceAmount.Caption = "Importo compenso";
            this.colCounterBalanceAmount.DisplayFormat.FormatString = "n";
            this.colCounterBalanceAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCounterBalanceAmount.FieldName = "ImportoCompenso";
            this.colCounterBalanceAmount.Name = "colCounterBalanceAmount";
            this.colCounterBalanceAmount.OptionsColumn.AllowEdit = false;
            this.colCounterBalanceAmount.OptionsColumn.AllowFocus = false;
            this.colCounterBalanceAmount.OptionsColumn.AllowMove = false;
            this.colCounterBalanceAmount.Visible = true;
            this.colCounterBalanceAmount.VisibleIndex = 3;
            this.colCounterBalanceAmount.Width = 93;
            // 
            // colSpendingAmount
            // 
            this.colSpendingAmount.Caption = "Importo spese";
            this.colSpendingAmount.DisplayFormat.FormatString = "n";
            this.colSpendingAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSpendingAmount.FieldName = "ImportoSpese";
            this.colSpendingAmount.Name = "colSpendingAmount";
            this.colSpendingAmount.OptionsColumn.AllowEdit = false;
            this.colSpendingAmount.OptionsColumn.AllowFocus = false;
            this.colSpendingAmount.OptionsColumn.AllowMove = false;
            this.colSpendingAmount.Visible = true;
            this.colSpendingAmount.VisibleIndex = 4;
            this.colSpendingAmount.Width = 69;
            // 
            // colCaseAmount
            // 
            this.colCaseAmount.Caption = "Importo cassa";
            this.colCaseAmount.DisplayFormat.FormatString = "n";
            this.colCaseAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCaseAmount.FieldName = "ImportoCassa";
            this.colCaseAmount.Name = "colCaseAmount";
            this.colCaseAmount.OptionsColumn.AllowEdit = false;
            this.colCaseAmount.OptionsColumn.AllowFocus = false;
            this.colCaseAmount.OptionsColumn.AllowMove = false;
            this.colCaseAmount.Visible = true;
            this.colCaseAmount.VisibleIndex = 5;
            this.colCaseAmount.Width = 69;
            // 
            // colIvaAmount
            // 
            this.colIvaAmount.Caption = "Importo I.V.A.";
            this.colIvaAmount.DisplayFormat.FormatString = "n";
            this.colIvaAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIvaAmount.FieldName = "ImportoIVA";
            this.colIvaAmount.Name = "colIvaAmount";
            this.colIvaAmount.OptionsColumn.AllowEdit = false;
            this.colIvaAmount.OptionsColumn.AllowFocus = false;
            this.colIvaAmount.OptionsColumn.AllowMove = false;
            this.colIvaAmount.Visible = true;
            this.colIvaAmount.VisibleIndex = 6;
            this.colIvaAmount.Width = 69;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.Caption = "Totale";
            this.colTotalAmount.DisplayFormat.FormatString = "n";
            this.colTotalAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalAmount.FieldName = "ImportoTotale";
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.OptionsColumn.AllowEdit = false;
            this.colTotalAmount.OptionsColumn.AllowFocus = false;
            this.colTotalAmount.OptionsColumn.AllowMove = false;
            this.colTotalAmount.SummaryItem.DisplayFormat = "{0:N2}";
            this.colTotalAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTotalAmount.Visible = true;
            this.colTotalAmount.VisibleIndex = 7;
            this.colTotalAmount.Width = 79;
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
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.NullText = "€";
            // 
            // popupMenuCommissario
            // 
            this.popupMenuCommissario.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemModify),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemDelete)});
            this.popupMenuCommissario.Manager = this.BarManager;
            this.popupMenuCommissario.Name = "popupMenuCommissario";
            // 
            // CommissarioDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CommissarioDetail";
            this.Size = new System.Drawing.Size(808, 448);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCommissioner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceForcedLiquidation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCommissioner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuCommissario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraGrid.GridControl gridControlCommissioner;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCommissioner;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceForcedLiquidation;
        private DevExpress.XtraGrid.Columns.GridColumn colRevisor;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colPercentageCNP;
        private DevExpress.XtraGrid.Columns.GridColumn colPercentageIVA;
        private DevExpress.XtraGrid.Columns.GridColumn colCounterBalanceAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colIvaAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colSpendingAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colCaseAmount;
        private DevExpress.XtraBars.BarButtonItem barButtonItemModify;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colRevisorLiquidation;
        private DevExpress.XtraBars.PopupMenu popupMenuCommissario;
    }
}
