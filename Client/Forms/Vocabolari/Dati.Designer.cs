namespace it.dedagroup.GVC.Client.Forms.Vocabolari
{
    partial class Dati
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
            this.gridControlDizionario = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceBaseDizionario = new OeF.Forms.BindingSourceBase(this.components);
            this.gridViewDizionario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValAzioneMin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValAzioneMax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValQuotaMin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValQuotaMax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPercentualeCNP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPercentualeIVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPercentualePAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemModify = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDizionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseDizionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDizionario)).BeginInit();
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
            this.ScrollableContent.Controls.Add(this.gridControlDizionario);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 49);
            this.ScrollableContent.Size = new System.Drawing.Size(428, 236);
            // 
            // gridControlDizionario
            // 
            this.gridControlDizionario.DataSource = this.bindingSourceBaseDizionario;
            this.gridControlDizionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDizionario.Location = new System.Drawing.Point(0, 0);
            this.gridControlDizionario.MainView = this.gridViewDizionario;
            this.gridControlDizionario.Name = "gridControlDizionario";
            this.gridControlDizionario.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControlDizionario.Size = new System.Drawing.Size(428, 236);
            this.gridControlDizionario.TabIndex = 0;
            this.gridControlDizionario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDizionario});
            this.gridControlDizionario.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlCadenza_MouseDoubleClick);
            // 
            // bindingSourceBaseDizionario
            // 
            this.bindingSourceBaseDizionario.AutoCreateObjects = false;
            this.bindingSourceBaseDizionario.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.Dictionaries.DatiFDT);
            this.bindingSourceBaseDizionario.CurrentItemChanged += new System.EventHandler(this.bindingSourceBaseCadenza_CurrentItemChanged);
            // 
            // gridViewDizionario
            // 
            this.gridViewDizionario.ColumnPanelRowHeight = 40;
            this.gridViewDizionario.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdItem,
            this.colValAzioneMin,
            this.colValAzioneMax,
            this.colValQuotaMin,
            this.colValQuotaMax,
            this.colPercentualeCNP,
            this.colPercentualeIVA,
            this.colPercentualePAT});
            this.gridViewDizionario.GridControl = this.gridControlDizionario;
            this.gridViewDizionario.Name = "gridViewDizionario";
            this.gridViewDizionario.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewDizionario.OptionsView.ShowGroupPanel = false;
            this.gridViewDizionario.OptionsView.ShowIndicator = false;
            // 
            // colIdItem
            // 
            this.colIdItem.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdItem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdItem.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colIdItem.Caption = "ID";
            this.colIdItem.FieldName = "IdItem";
            this.colIdItem.Name = "colIdItem";
            this.colIdItem.OptionsColumn.AllowEdit = false;
            this.colIdItem.OptionsColumn.AllowFocus = false;
            this.colIdItem.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIdItem.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colIdItem.OptionsColumn.AllowMove = false;
            this.colIdItem.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIdItem.OptionsFilter.AllowAutoFilter = false;
            this.colIdItem.OptionsFilter.AllowFilter = false;
            this.colIdItem.Visible = true;
            this.colIdItem.VisibleIndex = 0;
            this.colIdItem.Width = 32;
            // 
            // colValAzioneMin
            // 
            this.colValAzioneMin.AppearanceHeader.Options.UseTextOptions = true;
            this.colValAzioneMin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colValAzioneMin.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colValAzioneMin.Caption = "Valore minimo azione";
            this.colValAzioneMin.FieldName = "ValAzioneMin";
            this.colValAzioneMin.Name = "colValAzioneMin";
            this.colValAzioneMin.OptionsColumn.AllowEdit = false;
            this.colValAzioneMin.OptionsColumn.AllowFocus = false;
            this.colValAzioneMin.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colValAzioneMin.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colValAzioneMin.OptionsColumn.AllowMove = false;
            this.colValAzioneMin.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colValAzioneMin.OptionsFilter.AllowAutoFilter = false;
            this.colValAzioneMin.OptionsFilter.AllowFilter = false;
            this.colValAzioneMin.Visible = true;
            this.colValAzioneMin.VisibleIndex = 1;
            this.colValAzioneMin.Width = 42;
            // 
            // colValAzioneMax
            // 
            this.colValAzioneMax.AppearanceHeader.Options.UseTextOptions = true;
            this.colValAzioneMax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colValAzioneMax.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colValAzioneMax.Caption = "Valore massimo azione";
            this.colValAzioneMax.FieldName = "ValAzioneMax";
            this.colValAzioneMax.Name = "colValAzioneMax";
            this.colValAzioneMax.OptionsColumn.AllowEdit = false;
            this.colValAzioneMax.OptionsColumn.AllowFocus = false;
            this.colValAzioneMax.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colValAzioneMax.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colValAzioneMax.OptionsColumn.AllowMove = false;
            this.colValAzioneMax.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colValAzioneMax.OptionsFilter.AllowAutoFilter = false;
            this.colValAzioneMax.OptionsFilter.AllowFilter = false;
            this.colValAzioneMax.Visible = true;
            this.colValAzioneMax.VisibleIndex = 2;
            this.colValAzioneMax.Width = 42;
            // 
            // colValQuotaMin
            // 
            this.colValQuotaMin.AppearanceHeader.Options.UseTextOptions = true;
            this.colValQuotaMin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colValQuotaMin.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colValQuotaMin.Caption = "Valore minimo quota";
            this.colValQuotaMin.FieldName = "ValQuotaMin";
            this.colValQuotaMin.Name = "colValQuotaMin";
            this.colValQuotaMin.OptionsColumn.AllowEdit = false;
            this.colValQuotaMin.OptionsColumn.AllowFocus = false;
            this.colValQuotaMin.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colValQuotaMin.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colValQuotaMin.OptionsColumn.AllowMove = false;
            this.colValQuotaMin.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colValQuotaMin.OptionsFilter.AllowAutoFilter = false;
            this.colValQuotaMin.OptionsFilter.AllowFilter = false;
            this.colValQuotaMin.Visible = true;
            this.colValQuotaMin.VisibleIndex = 3;
            this.colValQuotaMin.Width = 42;
            // 
            // colValQuotaMax
            // 
            this.colValQuotaMax.AppearanceHeader.Options.UseTextOptions = true;
            this.colValQuotaMax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colValQuotaMax.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colValQuotaMax.Caption = "Valore massimo quota";
            this.colValQuotaMax.FieldName = "ValQuotaMax";
            this.colValQuotaMax.Name = "colValQuotaMax";
            this.colValQuotaMax.OptionsColumn.AllowEdit = false;
            this.colValQuotaMax.OptionsColumn.AllowFocus = false;
            this.colValQuotaMax.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colValQuotaMax.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colValQuotaMax.OptionsColumn.AllowMove = false;
            this.colValQuotaMax.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colValQuotaMax.OptionsFilter.AllowAutoFilter = false;
            this.colValQuotaMax.OptionsFilter.AllowFilter = false;
            this.colValQuotaMax.Visible = true;
            this.colValQuotaMax.VisibleIndex = 4;
            this.colValQuotaMax.Width = 42;
            // 
            // colPercentualeCNP
            // 
            this.colPercentualeCNP.AppearanceHeader.Options.UseTextOptions = true;
            this.colPercentualeCNP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPercentualeCNP.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colPercentualeCNP.Caption = "Percentuale CNP";
            this.colPercentualeCNP.DisplayFormat.FormatString = "{0:N0} %";
            this.colPercentualeCNP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPercentualeCNP.FieldName = "PercentualeCNP";
            this.colPercentualeCNP.Name = "colPercentualeCNP";
            this.colPercentualeCNP.OptionsColumn.AllowEdit = false;
            this.colPercentualeCNP.OptionsColumn.AllowFocus = false;
            this.colPercentualeCNP.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPercentualeCNP.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colPercentualeCNP.OptionsColumn.AllowMove = false;
            this.colPercentualeCNP.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPercentualeCNP.OptionsFilter.AllowAutoFilter = false;
            this.colPercentualeCNP.OptionsFilter.AllowFilter = false;
            this.colPercentualeCNP.Visible = true;
            this.colPercentualeCNP.VisibleIndex = 5;
            this.colPercentualeCNP.Width = 42;
            // 
            // colPercentualeIVA
            // 
            this.colPercentualeIVA.AppearanceHeader.Options.UseTextOptions = true;
            this.colPercentualeIVA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPercentualeIVA.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colPercentualeIVA.Caption = "Percentuale IVA";
            this.colPercentualeIVA.DisplayFormat.FormatString = "{0:N0} %";
            this.colPercentualeIVA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPercentualeIVA.FieldName = "PercentualeIVA";
            this.colPercentualeIVA.Name = "colPercentualeIVA";
            this.colPercentualeIVA.OptionsColumn.AllowEdit = false;
            this.colPercentualeIVA.OptionsColumn.AllowFocus = false;
            this.colPercentualeIVA.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPercentualeIVA.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colPercentualeIVA.OptionsColumn.AllowMove = false;
            this.colPercentualeIVA.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPercentualeIVA.OptionsFilter.AllowAutoFilter = false;
            this.colPercentualeIVA.OptionsFilter.AllowFilter = false;
            this.colPercentualeIVA.Visible = true;
            this.colPercentualeIVA.VisibleIndex = 6;
            this.colPercentualeIVA.Width = 47;
            // 
            // colPercentualePAT
            // 
            this.colPercentualePAT.AppearanceHeader.Options.UseTextOptions = true;
            this.colPercentualePAT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPercentualePAT.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colPercentualePAT.Caption = "Percentuale PAT";
            this.colPercentualePAT.DisplayFormat.FormatString = "{0:N0} %";
            this.colPercentualePAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPercentualePAT.FieldName = "PercentualePAT";
            this.colPercentualePAT.Name = "colPercentualePAT";
            this.colPercentualePAT.OptionsColumn.AllowEdit = false;
            this.colPercentualePAT.OptionsColumn.AllowFocus = false;
            this.colPercentualePAT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPercentualePAT.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colPercentualePAT.OptionsColumn.AllowMove = false;
            this.colPercentualePAT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPercentualePAT.OptionsFilter.AllowAutoFilter = false;
            this.colPercentualePAT.OptionsFilter.AllowFilter = false;
            this.colPercentualePAT.Visible = true;
            this.colPercentualePAT.VisibleIndex = 7;
            this.colPercentualePAT.Width = 54;
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
            // Dati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Dati";
            this.Size = new System.Drawing.Size(428, 285);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDizionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseDizionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDizionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemModify;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraGrid.GridControl gridControlDizionario;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDizionario;
        private OeF.Forms.BindingSourceBase bindingSourceBaseDizionario;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdItem;
        private DevExpress.XtraGrid.Columns.GridColumn colValAzioneMin;
        private DevExpress.XtraGrid.Columns.GridColumn colValAzioneMax;
        private DevExpress.XtraGrid.Columns.GridColumn colValQuotaMin;
        private DevExpress.XtraGrid.Columns.GridColumn colValQuotaMax;
        private DevExpress.XtraGrid.Columns.GridColumn colPercentualeCNP;
        private DevExpress.XtraGrid.Columns.GridColumn colPercentualeIVA;
        private DevExpress.XtraGrid.Columns.GridColumn colPercentualePAT;
    }
}
