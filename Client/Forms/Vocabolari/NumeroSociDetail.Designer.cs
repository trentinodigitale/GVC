namespace it.dedagroup.GVC.Client.Forms.Vocabolari
{
    partial class NumeroSociDetail
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
            this.gridControlNumeroSoci = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceBaseNumeroSoci = new OeF.Forms.BindingSourceBase(this.components);
            this.gridViewNumeroSoci = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdRelazione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValMin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValMax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemModify = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNumeroSoci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseNumeroSoci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNumeroSoci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
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
            this.BarManager.MaxItemId = 12;
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.gridControlNumeroSoci);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 49);
            this.ScrollableContent.Size = new System.Drawing.Size(428, 236);
            // 
            // gridControlNumeroSoci
            // 
            this.gridControlNumeroSoci.DataSource = this.bindingSourceBaseNumeroSoci;
            this.gridControlNumeroSoci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlNumeroSoci.Location = new System.Drawing.Point(0, 0);
            this.gridControlNumeroSoci.MainView = this.gridViewNumeroSoci;
            this.gridControlNumeroSoci.Name = "gridControlNumeroSoci";
            this.gridControlNumeroSoci.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControlNumeroSoci.Size = new System.Drawing.Size(428, 236);
            this.gridControlNumeroSoci.TabIndex = 0;
            this.gridControlNumeroSoci.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNumeroSoci});
            this.gridControlNumeroSoci.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlCadenza_MouseDoubleClick);
            // 
            // bindingSourceBaseNumeroSoci
            // 
            this.bindingSourceBaseNumeroSoci.AutoCreateObjects = false;
            this.bindingSourceBaseNumeroSoci.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.ControlloNumeroSociFDT);
            this.bindingSourceBaseNumeroSoci.CurrentItemChanged += new System.EventHandler(this.bindingSourceBaseCadenza_CurrentItemChanged);
            // 
            // gridViewNumeroSoci
            // 
            this.gridViewNumeroSoci.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdRelazione,
            this.colValMin,
            this.colValMax,
            this.colNote});
            this.gridViewNumeroSoci.GridControl = this.gridControlNumeroSoci;
            this.gridViewNumeroSoci.Name = "gridViewNumeroSoci";
            this.gridViewNumeroSoci.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewNumeroSoci.OptionsView.ShowGroupPanel = false;
            this.gridViewNumeroSoci.OptionsView.ShowIndicator = false;
            this.gridViewNumeroSoci.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdRelazione, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIdRelazione
            // 
            this.colIdRelazione.AppearanceCell.Options.UseTextOptions = true;
            this.colIdRelazione.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdRelazione.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdRelazione.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdRelazione.Caption = "ID";
            this.colIdRelazione.FieldName = "IdRelazione";
            this.colIdRelazione.Name = "colIdRelazione";
            this.colIdRelazione.OptionsColumn.AllowEdit = false;
            this.colIdRelazione.OptionsColumn.AllowFocus = false;
            this.colIdRelazione.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIdRelazione.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colIdRelazione.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIdRelazione.OptionsFilter.AllowAutoFilter = false;
            this.colIdRelazione.OptionsFilter.AllowFilter = false;
            this.colIdRelazione.Visible = true;
            this.colIdRelazione.VisibleIndex = 0;
            this.colIdRelazione.Width = 46;
            // 
            // colValMin
            // 
            this.colValMin.AppearanceHeader.Options.UseTextOptions = true;
            this.colValMin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colValMin.Caption = "Valore Minimo";
            this.colValMin.FieldName = "ValMin";
            this.colValMin.Name = "colValMin";
            this.colValMin.OptionsColumn.AllowEdit = false;
            this.colValMin.OptionsColumn.AllowFocus = false;
            this.colValMin.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colValMin.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colValMin.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colValMin.OptionsFilter.AllowAutoFilter = false;
            this.colValMin.OptionsFilter.AllowFilter = false;
            this.colValMin.Visible = true;
            this.colValMin.VisibleIndex = 1;
            this.colValMin.Width = 136;
            // 
            // colValMax
            // 
            this.colValMax.AppearanceHeader.Options.UseTextOptions = true;
            this.colValMax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colValMax.Caption = "Valore Massimo";
            this.colValMax.FieldName = "ValMax";
            this.colValMax.Name = "colValMax";
            this.colValMax.OptionsColumn.AllowEdit = false;
            this.colValMax.OptionsColumn.AllowFocus = false;
            this.colValMax.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colValMax.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colValMax.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colValMax.OptionsFilter.AllowAutoFilter = false;
            this.colValMax.OptionsFilter.AllowFilter = false;
            this.colValMax.Visible = true;
            this.colValMax.VisibleIndex = 2;
            this.colValMax.Width = 128;
            // 
            // colNote
            // 
            this.colNote.AppearanceHeader.Options.UseTextOptions = true;
            this.colNote.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNote.Caption = "Note";
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.OptionsColumn.AllowEdit = false;
            this.colNote.OptionsColumn.AllowFocus = false;
            this.colNote.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colNote.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colNote.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNote.OptionsFilter.AllowAutoFilter = false;
            this.colNote.OptionsFilter.AllowFilter = false;
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 3;
            this.colNote.Width = 357;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
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
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
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
            this.barButtonItemModify.Id = 10;
            this.barButtonItemModify.Name = "barButtonItemModify";
            this.barButtonItemModify.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemModify_ItemClick);
            // 
            // barButtonItemDelete
            // 
            this.barButtonItemDelete.Caption = "Cancella";
            this.barButtonItemDelete.Id = 11;
            this.barButtonItemDelete.Name = "barButtonItemDelete";
            this.barButtonItemDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDelete_ItemClick);
            // 
            // NumeroSociDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "NumeroSociDetail";
            this.ReadOnlyControls = false;
            this.Size = new System.Drawing.Size(428, 285);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNumeroSoci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseNumeroSoci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNumeroSoci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemModify;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraGrid.GridControl gridControlNumeroSoci;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNumeroSoci;
        private OeF.Forms.BindingSourceBase bindingSourceBaseNumeroSoci;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdRelazione;
        private DevExpress.XtraGrid.Columns.GridColumn colValMin;
        private DevExpress.XtraGrid.Columns.GridColumn colValMax;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
    }
}
