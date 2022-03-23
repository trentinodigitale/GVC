﻿namespace it.dedagroup.GVC.Client.Forms.Vocabolari
{
    partial class TipiProcedimento
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
            this.colIdElemento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescrizione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAttivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colDettaglio_Tempi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDettaglio_Note = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemModify = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDizionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseDizionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDizionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
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
            this.repositoryItemCheckEdit1,
            this.repositoryItemMemoEdit1});
            this.gridControlDizionario.Size = new System.Drawing.Size(428, 236);
            this.gridControlDizionario.TabIndex = 0;
            this.gridControlDizionario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDizionario});
            this.gridControlDizionario.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlCadenza_MouseDoubleClick);
            // 
            // bindingSourceBaseDizionario
            // 
            this.bindingSourceBaseDizionario.AutoCreateObjects = false;
            this.bindingSourceBaseDizionario.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            this.bindingSourceBaseDizionario.CurrentItemChanged += new System.EventHandler(this.bindingSourceBaseCadenza_CurrentItemChanged);
            // 
            // gridViewDizionario
            // 
            this.gridViewDizionario.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdElemento,
            this.colDescrizione,
            this.colAttivo,
            this.colDettaglio_Tempi,
            this.colDettaglio_Note});
            this.gridViewDizionario.GridControl = this.gridControlDizionario;
            this.gridViewDizionario.Name = "gridViewDizionario";
            this.gridViewDizionario.OptionsView.RowAutoHeight = true;
            this.gridViewDizionario.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewDizionario.OptionsView.ShowGroupPanel = false;
            this.gridViewDizionario.OptionsView.ShowIndicator = false;
            this.gridViewDizionario.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdElemento, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIdElemento
            // 
            this.colIdElemento.AppearanceCell.Options.UseTextOptions = true;
            this.colIdElemento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdElemento.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdElemento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdElemento.Caption = "ID";
            this.colIdElemento.FieldName = "IdElemento";
            this.colIdElemento.Name = "colIdElemento";
            this.colIdElemento.OptionsColumn.AllowEdit = false;
            this.colIdElemento.OptionsColumn.AllowFocus = false;
            this.colIdElemento.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIdElemento.OptionsColumn.AllowMove = false;
            this.colIdElemento.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIdElemento.OptionsFilter.AllowAutoFilter = false;
            this.colIdElemento.OptionsFilter.AllowFilter = false;
            this.colIdElemento.Visible = true;
            this.colIdElemento.VisibleIndex = 0;
            this.colIdElemento.Width = 50;
            // 
            // colDescrizione
            // 
            this.colDescrizione.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescrizione.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescrizione.Caption = "Descrizione";
            this.colDescrizione.FieldName = "Descrizione";
            this.colDescrizione.Name = "colDescrizione";
            this.colDescrizione.OptionsColumn.AllowEdit = false;
            this.colDescrizione.OptionsColumn.AllowFocus = false;
            this.colDescrizione.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDescrizione.OptionsColumn.AllowMove = false;
            this.colDescrizione.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDescrizione.OptionsFilter.AllowAutoFilter = false;
            this.colDescrizione.OptionsFilter.AllowFilter = false;
            this.colDescrizione.Visible = true;
            this.colDescrizione.VisibleIndex = 1;
            this.colDescrizione.Width = 359;
            // 
            // colAttivo
            // 
            this.colAttivo.AppearanceCell.Options.UseTextOptions = true;
            this.colAttivo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAttivo.AppearanceHeader.Options.UseTextOptions = true;
            this.colAttivo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAttivo.Caption = "Attivo";
            this.colAttivo.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colAttivo.FieldName = "Attivo";
            this.colAttivo.Name = "colAttivo";
            this.colAttivo.OptionsColumn.AllowEdit = false;
            this.colAttivo.OptionsColumn.AllowFocus = false;
            this.colAttivo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colAttivo.OptionsColumn.AllowMove = false;
            this.colAttivo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAttivo.OptionsFilter.AllowAutoFilter = false;
            this.colAttivo.OptionsFilter.AllowFilter = false;
            this.colAttivo.Visible = true;
            this.colAttivo.VisibleIndex = 2;
            this.colAttivo.Width = 86;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // colDettaglio_Tempi
            // 
            this.colDettaglio_Tempi.AppearanceCell.Options.UseTextOptions = true;
            this.colDettaglio_Tempi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDettaglio_Tempi.AppearanceHeader.Options.UseTextOptions = true;
            this.colDettaglio_Tempi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDettaglio_Tempi.Caption = "Tempi";
            this.colDettaglio_Tempi.FieldName = "Dettaglio_Tempi";
            this.colDettaglio_Tempi.Name = "colDettaglio_Tempi";
            this.colDettaglio_Tempi.OptionsColumn.AllowEdit = false;
            this.colDettaglio_Tempi.OptionsColumn.AllowFocus = false;
            this.colDettaglio_Tempi.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDettaglio_Tempi.OptionsColumn.AllowMove = false;
            this.colDettaglio_Tempi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDettaglio_Tempi.OptionsFilter.AllowAutoFilter = false;
            this.colDettaglio_Tempi.OptionsFilter.AllowFilter = false;
            this.colDettaglio_Tempi.Visible = true;
            this.colDettaglio_Tempi.VisibleIndex = 3;
            // 
            // colDettaglio_Note
            // 
            this.colDettaglio_Note.AppearanceHeader.Options.UseTextOptions = true;
            this.colDettaglio_Note.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDettaglio_Note.Caption = "Note";
            this.colDettaglio_Note.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colDettaglio_Note.FieldName = "Dettaglio_Note";
            this.colDettaglio_Note.Name = "colDettaglio_Note";
            this.colDettaglio_Note.OptionsColumn.AllowEdit = false;
            this.colDettaglio_Note.OptionsColumn.AllowFocus = false;
            this.colDettaglio_Note.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDettaglio_Note.OptionsColumn.AllowMove = false;
            this.colDettaglio_Note.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDettaglio_Note.OptionsFilter.AllowAutoFilter = false;
            this.colDettaglio_Note.OptionsFilter.AllowFilter = false;
            this.colDettaglio_Note.Visible = true;
            this.colDettaglio_Note.VisibleIndex = 4;
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
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            this.repositoryItemMemoEdit1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            // 
            // TipiProcedimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TipiProcedimento";
            this.Size = new System.Drawing.Size(428, 285);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDizionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseDizionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDizionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn colIdElemento;
        private DevExpress.XtraGrid.Columns.GridColumn colDescrizione;
        private DevExpress.XtraGrid.Columns.GridColumn colAttivo;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colDettaglio_Tempi;
        private DevExpress.XtraGrid.Columns.GridColumn colDettaglio_Note;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
    }
}
