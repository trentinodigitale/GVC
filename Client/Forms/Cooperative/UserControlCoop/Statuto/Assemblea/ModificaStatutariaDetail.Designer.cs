namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Statuto.Assemblea
{
    partial class ModificaStatutariaDetail
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
            this.gridControlModificheStatutarie = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceBaseModificheStatutarie = new OeF.Forms.BindingSourceBase(this.components);
            this.gridViewModificheStatutarie = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdChangeType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bindingSourceBaseTipiModificaStatutaria = new OeF.Forms.BindingSourceBase(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemModify = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCollegamento = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuModificheStatutarie = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlModificheStatutarie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseModificheStatutarie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewModificheStatutarie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseTipiModificaStatutaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuModificheStatutarie)).BeginInit();
            this.SuspendLayout();
            // 
            // BarManager
            // 
            this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemAdd,
            this.barButtonItemDelete,
            this.barButtonItemModify,
            this.barButtonItemCollegamento});
            this.BarManager.MaxItemId = 13;
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.gridControlModificheStatutarie);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 49);
            this.ScrollableContent.Size = new System.Drawing.Size(475, 171);
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // gridControlModificheStatutarie
            // 
            this.gridControlModificheStatutarie.DataSource = this.bindingSourceBaseModificheStatutarie;
            this.gridControlModificheStatutarie.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlModificheStatutarie.Location = new System.Drawing.Point(0, 0);
            this.gridControlModificheStatutarie.MainView = this.gridViewModificheStatutarie;
            this.gridControlModificheStatutarie.Name = "gridControlModificheStatutarie";
            this.gridControlModificheStatutarie.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControlModificheStatutarie.Size = new System.Drawing.Size(475, 170);
            this.gridControlModificheStatutarie.TabIndex = 0;
            this.gridControlModificheStatutarie.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewModificheStatutarie});
            this.gridControlModificheStatutarie.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlModificheStatutarie_MouseDoubleClick);
            // 
            // bindingSourceBaseModificheStatutarie
            // 
            this.bindingSourceBaseModificheStatutarie.AutoCreateObjects = false;
            this.bindingSourceBaseModificheStatutarie.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.ModificaStatutariaFDT);
            this.bindingSourceBaseModificheStatutarie.CurrentChanged += new System.EventHandler(this.bindingSourceBaseModificheStatutarie_CurrentChanged);
            // 
            // gridViewModificheStatutarie
            // 
            this.gridViewModificheStatutarie.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdChangeType,
            this.colStatus});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout);
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colStatus;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual;
            styleFormatCondition1.Value1 = "100";
            this.gridViewModificheStatutarie.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridViewModificheStatutarie.GridControl = this.gridControlModificheStatutarie;
            this.gridViewModificheStatutarie.Name = "gridViewModificheStatutarie";
            this.gridViewModificheStatutarie.OptionsBehavior.Editable = false;
            this.gridViewModificheStatutarie.OptionsCustomization.AllowGroup = false;
            this.gridViewModificheStatutarie.OptionsCustomization.AllowSort = false;
            this.gridViewModificheStatutarie.OptionsMenu.EnableColumnMenu = false;
            this.gridViewModificheStatutarie.OptionsMenu.EnableFooterMenu = false;
            this.gridViewModificheStatutarie.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewModificheStatutarie.OptionsView.ShowGroupPanel = false;
            this.gridViewModificheStatutarie.OptionsView.ShowIndicator = false;
            this.gridViewModificheStatutarie.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdChangeType, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewModificheStatutarie.ShowGridMenu += new DevExpress.XtraGrid.Views.Grid.GridMenuEventHandler(this.gridViewStatutaryChange_ShowGridMenu);
            // 
            // colIdChangeType
            // 
            this.colIdChangeType.Caption = "Tipo";
            this.colIdChangeType.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colIdChangeType.FieldName = "IdTipoModifica";
            this.colIdChangeType.Name = "colIdChangeType";
            this.colIdChangeType.OptionsColumn.AllowEdit = false;
            this.colIdChangeType.OptionsColumn.AllowFocus = false;
            this.colIdChangeType.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIdChangeType.OptionsColumn.AllowMove = false;
            this.colIdChangeType.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIdChangeType.OptionsFilter.AllowAutoFilter = false;
            this.colIdChangeType.OptionsFilter.AllowFilter = false;
            this.colIdChangeType.Visible = true;
            this.colIdChangeType.VisibleIndex = 0;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.bindingSourceBaseTipiModificaStatutaria;
            this.repositoryItemLookUpEdit1.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "IdElemento";
            // 
            // bindingSourceBaseTipiModificaStatutaria
            // 
            this.bindingSourceBaseTipiModificaStatutaria.AutoCreateObjects = false;
            this.bindingSourceBaseTipiModificaStatutaria.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 3";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemModify, "", false, true, false, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            // barButtonItemCollegamento
            // 
            this.barButtonItemCollegamento.Caption = "Modifica collegamento";
            this.barButtonItemCollegamento.Id = 12;
            this.barButtonItemCollegamento.Name = "barButtonItemCollegamento";
            this.barButtonItemCollegamento.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCollegamento_ItemClick);
            // 
            // popupMenuModificheStatutarie
            // 
            this.popupMenuModificheStatutarie.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemCollegamento),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemDelete)});
            this.popupMenuModificheStatutarie.Manager = this.BarManager;
            this.popupMenuModificheStatutarie.Name = "popupMenuModificheStatutarie";
            // 
            // ModificaStatutariaDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ModificaStatutariaDetail";
            this.Size = new System.Drawing.Size(475, 220);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlModificheStatutarie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseModificheStatutarie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewModificheStatutarie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseTipiModificaStatutaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuModificheStatutarie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlModificheStatutarie;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewModificheStatutarie;
        private OeF.Forms.BindingSourceBase bindingSourceBaseModificheStatutarie;
        private DevExpress.XtraGrid.Columns.GridColumn colIdChangeType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private OeF.Forms.BindingSourceBase bindingSourceBaseTipiModificaStatutaria;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonItemModify;
        private DevExpress.XtraBars.PopupMenu popupMenuModificheStatutarie;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCollegamento;
    }
}
