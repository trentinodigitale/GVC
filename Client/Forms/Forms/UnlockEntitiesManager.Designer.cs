namespace it.dedagroup.GVC.Client.Forms.Forms
{
    partial class UnlockEntitiesManager
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
            this.gridControlLocks = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceBaseLocks = new OeF.Forms.BindingSourceBase(this.components);
            this.gridViewLocks = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEntityType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEntity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.popupMenuLock = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItemUnlock = new DevExpress.XtraBars.BarButtonItem();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemUpdate = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseLocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuLock)).BeginInit();
            this.SuspendLayout();
            // 
            // BarManager
            // 
            this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemUnlock,
            this.barButtonItemUpdate});
            this.BarManager.MaxItemId = 11;
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.gridControlLocks);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 49);
            this.ScrollableContent.Size = new System.Drawing.Size(594, 355);
            // 
            // gridControlLocks
            // 
            this.gridControlLocks.DataSource = this.bindingSourceBaseLocks;
            this.gridControlLocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlLocks.Location = new System.Drawing.Point(0, 0);
            this.gridControlLocks.MainView = this.gridViewLocks;
            this.gridControlLocks.Name = "gridControlLocks";
            this.gridControlLocks.Size = new System.Drawing.Size(594, 355);
            this.gridControlLocks.TabIndex = 0;
            this.gridControlLocks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLocks,
            this.gridView2});
            // 
            // bindingSourceBaseLocks
            // 
            this.bindingSourceBaseLocks.AutoCreateObjects = false;
            this.bindingSourceBaseLocks.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.LockFDT);
            // 
            // gridViewLocks
            // 
            this.gridViewLocks.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEntityType,
            this.colIdEntity,
            this.colStatus});
            this.gridViewLocks.GridControl = this.gridControlLocks;
            this.gridViewLocks.Name = "gridViewLocks";
            this.gridViewLocks.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewLocks.OptionsView.ShowGroupPanel = false;
            this.gridViewLocks.OptionsView.ShowIndicator = false;
            this.gridViewLocks.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdEntityType, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdEntity, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewLocks.ShowGridMenu += new DevExpress.XtraGrid.Views.Grid.GridMenuEventHandler(this.gridViewLocks_ShowGridMenu);
            // 
            // colIdEntityType
            // 
            this.colIdEntityType.AppearanceCell.Options.UseTextOptions = true;
            this.colIdEntityType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdEntityType.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdEntityType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdEntityType.Caption = "Tipo entità";
            this.colIdEntityType.FieldName = "IdEntityType";
            this.colIdEntityType.Name = "colIdEntityType";
            this.colIdEntityType.OptionsColumn.AllowEdit = false;
            this.colIdEntityType.OptionsColumn.AllowFocus = false;
            this.colIdEntityType.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIdEntityType.OptionsColumn.AllowMove = false;
            this.colIdEntityType.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIdEntityType.OptionsFilter.AllowAutoFilter = false;
            this.colIdEntityType.OptionsFilter.AllowFilter = false;
            this.colIdEntityType.Visible = true;
            this.colIdEntityType.VisibleIndex = 0;
            this.colIdEntityType.Width = 137;
            // 
            // colIdEntity
            // 
            this.colIdEntity.AppearanceCell.Options.UseTextOptions = true;
            this.colIdEntity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdEntity.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdEntity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdEntity.Caption = "Entità";
            this.colIdEntity.FieldName = "IdEntity";
            this.colIdEntity.Name = "colIdEntity";
            this.colIdEntity.OptionsColumn.AllowEdit = false;
            this.colIdEntity.OptionsColumn.AllowFocus = false;
            this.colIdEntity.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIdEntity.OptionsColumn.AllowMove = false;
            this.colIdEntity.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIdEntity.OptionsFilter.AllowAutoFilter = false;
            this.colIdEntity.OptionsFilter.AllowFilter = false;
            this.colIdEntity.Visible = true;
            this.colIdEntity.VisibleIndex = 1;
            this.colIdEntity.Width = 227;
            // 
            // colStatus
            // 
            this.colStatus.AppearanceCell.Options.UseTextOptions = true;
            this.colStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.colStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStatus.Caption = "Stato";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.OptionsColumn.AllowEdit = false;
            this.colStatus.OptionsColumn.AllowFocus = false;
            this.colStatus.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colStatus.OptionsColumn.AllowMove = false;
            this.colStatus.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colStatus.OptionsFilter.AllowAutoFilter = false;
            this.colStatus.OptionsFilter.AllowFilter = false;
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 2;
            this.colStatus.Width = 111;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControlLocks;
            this.gridView2.Name = "gridView2";
            // 
            // popupMenuLock
            // 
            this.popupMenuLock.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemUnlock)});
            this.popupMenuLock.Manager = this.BarManager;
            this.popupMenuLock.Name = "popupMenuLock";
            // 
            // barButtonItemUnlock
            // 
            this.barButtonItemUnlock.Caption = "Sblocca";
            this.barButtonItemUnlock.Id = 9;
            this.barButtonItemUnlock.Name = "barButtonItemUnlock";
            this.barButtonItemUnlock.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemUnlock_ItemClick);
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemUpdate, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Custom 2";
            // 
            // barButtonItemUpdate
            // 
            this.barButtonItemUpdate.Caption = "Aggiorna";
            this.barButtonItemUpdate.Id = 10;
            this.barButtonItemUpdate.Name = "barButtonItemUpdate";
            this.barButtonItemUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemUpdate_ItemClick);
            // 
            // UnlockEntitiesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "UnlockEntitiesManager";
            this.Size = new System.Drawing.Size(594, 404);
            this.Load += new System.EventHandler(this.UnlockEntitiesManager_Load);
            this.Shown += new System.EventHandler(this.UnlockEntitiesManager_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseLocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuLock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlLocks;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLocks;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private OeF.Forms.BindingSourceBase bindingSourceBaseLocks;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEntityType;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEntity;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraBars.PopupMenu popupMenuLock;
        private DevExpress.XtraBars.BarButtonItem barButtonItemUnlock;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemUpdate;

        
    }
}
