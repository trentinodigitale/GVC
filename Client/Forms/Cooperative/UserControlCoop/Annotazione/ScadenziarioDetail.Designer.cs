namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Annotazione
{
    partial class ScadenziarioDetail
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlRemarkExpirations = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceAnnotazioni = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.gridViewRemarkExpirations = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRemarkDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDRemarkType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bindingSourceTipiAnnotazione = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.colReserved = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colDescrizione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpirationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEscaped = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemAddNew = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemModify = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRemove = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuAnnotazioni = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRemarkExpirations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAnnotazioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRemarkExpirations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipiAnnotazione)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuAnnotazioni)).BeginInit();
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
            this.BarManager.MaxItemId = 12;
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.gridControlRemarkExpirations);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 49);
            this.ScrollableContent.Size = new System.Drawing.Size(870, 430);
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // gridControlRemarkExpirations
            // 
            this.gridControlRemarkExpirations.DataSource = this.bindingSourceAnnotazioni;
            this.gridControlRemarkExpirations.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlRemarkExpirations.Location = new System.Drawing.Point(0, 0);
            this.gridControlRemarkExpirations.MainView = this.gridViewRemarkExpirations;
            this.gridControlRemarkExpirations.Name = "gridControlRemarkExpirations";
            this.gridControlRemarkExpirations.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2});
            this.gridControlRemarkExpirations.Size = new System.Drawing.Size(870, 427);
            this.gridControlRemarkExpirations.TabIndex = 1;
            this.gridControlRemarkExpirations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRemarkExpirations});
            this.gridControlRemarkExpirations.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlRemarkExpirations_MouseDoubleClick);
            // 
            // bindingSourceAnnotazioni
            // 
            this.bindingSourceAnnotazioni.AutoCreateObjects = false;
            this.bindingSourceAnnotazioni.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.ScadenziarioFDT);
            this.bindingSourceAnnotazioni.CurrentChanged += new System.EventHandler(this.bindingSourceAnnotazioni_CurrentChanged);
            // 
            // gridViewRemarkExpirations
            // 
            this.gridViewRemarkExpirations.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRemarkDate,
            this.colIDRemarkType,
            this.colReserved,
            this.colDescrizione,
            this.colExpirationDate,
            this.colEscaped,
            this.colStatus});
            styleFormatCondition2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout);
            styleFormatCondition2.Appearance.Options.UseFont = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colStatus;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual;
            styleFormatCondition2.Value1 = "100";
            this.gridViewRemarkExpirations.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition2});
            this.gridViewRemarkExpirations.GridControl = this.gridControlRemarkExpirations;
            this.gridViewRemarkExpirations.Name = "gridViewRemarkExpirations";
            this.gridViewRemarkExpirations.OptionsMenu.EnableColumnMenu = false;
            this.gridViewRemarkExpirations.OptionsMenu.EnableFooterMenu = false;
            this.gridViewRemarkExpirations.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewRemarkExpirations.OptionsView.ShowGroupPanel = false;
            this.gridViewRemarkExpirations.OptionsView.ShowIndicator = false;
            this.gridViewRemarkExpirations.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colRemarkDate, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewRemarkExpirations.ShowGridMenu += new DevExpress.XtraGrid.Views.Grid.GridMenuEventHandler(this.gridViewRemarkExpirations_ShowGridMenu);
            // 
            // colRemarkDate
            // 
            this.colRemarkDate.Caption = "Data annotazione";
            this.colRemarkDate.DisplayFormat.FormatString = "d";
            this.colRemarkDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colRemarkDate.FieldName = "DataAnnotazione";
            this.colRemarkDate.Name = "colRemarkDate";
            this.colRemarkDate.OptionsColumn.AllowEdit = false;
            this.colRemarkDate.OptionsColumn.AllowFocus = false;
            this.colRemarkDate.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colRemarkDate.OptionsColumn.AllowMove = false;
            this.colRemarkDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colRemarkDate.OptionsFilter.AllowAutoFilter = false;
            this.colRemarkDate.OptionsFilter.AllowFilter = false;
            this.colRemarkDate.Visible = true;
            this.colRemarkDate.VisibleIndex = 0;
            this.colRemarkDate.Width = 98;
            // 
            // colIDRemarkType
            // 
            this.colIDRemarkType.Caption = "Tipo";
            this.colIDRemarkType.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colIDRemarkType.FieldName = "IdTipoScadenziario";
            this.colIDRemarkType.Name = "colIDRemarkType";
            this.colIDRemarkType.OptionsColumn.AllowEdit = false;
            this.colIDRemarkType.OptionsColumn.AllowFocus = false;
            this.colIDRemarkType.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIDRemarkType.OptionsColumn.AllowMove = false;
            this.colIDRemarkType.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIDRemarkType.OptionsFilter.AllowAutoFilter = false;
            this.colIDRemarkType.OptionsFilter.AllowFilter = false;
            this.colIDRemarkType.Visible = true;
            this.colIDRemarkType.VisibleIndex = 1;
            this.colIDRemarkType.Width = 115;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.DataSource = this.bindingSourceTipiAnnotazione;
            this.repositoryItemLookUpEdit2.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ValueMember = "IdElemento";
            // 
            // bindingSourceTipiAnnotazione
            // 
            this.bindingSourceTipiAnnotazione.AutoCreateObjects = false;
            this.bindingSourceTipiAnnotazione.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // colReserved
            // 
            this.colReserved.Caption = "Riservata";
            this.colReserved.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colReserved.FieldName = "RiservataUfficio";
            this.colReserved.Name = "colReserved";
            this.colReserved.OptionsColumn.AllowEdit = false;
            this.colReserved.OptionsColumn.AllowFocus = false;
            this.colReserved.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colReserved.OptionsColumn.AllowMove = false;
            this.colReserved.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colReserved.OptionsFilter.AllowAutoFilter = false;
            this.colReserved.OptionsFilter.AllowFilter = false;
            this.colReserved.Visible = true;
            this.colReserved.VisibleIndex = 2;
            this.colReserved.Width = 60;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // colDescrizione
            // 
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
            this.colDescrizione.VisibleIndex = 3;
            this.colDescrizione.Width = 344;
            // 
            // colExpirationDate
            // 
            this.colExpirationDate.Caption = "Scadenza";
            this.colExpirationDate.DisplayFormat.FormatString = "d";
            this.colExpirationDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colExpirationDate.FieldName = "DataScadenza";
            this.colExpirationDate.Name = "colExpirationDate";
            this.colExpirationDate.OptionsColumn.AllowEdit = false;
            this.colExpirationDate.OptionsColumn.AllowFocus = false;
            this.colExpirationDate.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colExpirationDate.OptionsColumn.AllowMove = false;
            this.colExpirationDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colExpirationDate.OptionsFilter.AllowAutoFilter = false;
            this.colExpirationDate.OptionsFilter.AllowFilter = false;
            this.colExpirationDate.Visible = true;
            this.colExpirationDate.VisibleIndex = 5;
            this.colExpirationDate.Width = 77;
            // 
            // colEscaped
            // 
            this.colEscaped.Caption = "Evasa";
            this.colEscaped.ColumnEdit = this.repositoryItemCheckEdit2;
            this.colEscaped.FieldName = "Evasa";
            this.colEscaped.Name = "colEscaped";
            this.colEscaped.OptionsColumn.AllowEdit = false;
            this.colEscaped.OptionsColumn.AllowFocus = false;
            this.colEscaped.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colEscaped.OptionsColumn.AllowMove = false;
            this.colEscaped.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEscaped.OptionsFilter.AllowAutoFilter = false;
            this.colEscaped.OptionsFilter.AllowFilter = false;
            this.colEscaped.Visible = true;
            this.colEscaped.VisibleIndex = 4;
            this.colEscaped.Width = 46;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
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
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
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
            // popupMenuAnnotazioni
            // 
            this.popupMenuAnnotazioni.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAddNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemModify),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemRemove)});
            this.popupMenuAnnotazioni.Manager = this.BarManager;
            this.popupMenuAnnotazioni.Name = "popupMenuAnnotazioni";
            // 
            // ScadenziarioDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ScadenziarioDetail";
            this.Size = new System.Drawing.Size(870, 479);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRemarkExpirations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAnnotazioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRemarkExpirations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipiAnnotazione)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuAnnotazioni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlRemarkExpirations;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRemarkExpirations;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarkDate;
        private DevExpress.XtraGrid.Columns.GridColumn colReserved;
        private DevExpress.XtraGrid.Columns.GridColumn colDescrizione;
        private DevExpress.XtraGrid.Columns.GridColumn colEscaped;
        private DevExpress.XtraGrid.Columns.GridColumn colExpirationDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAddNew;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRemove;
        private DevExpress.XtraGrid.Columns.GridColumn colIDRemarkType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraBars.BarButtonItem barButtonItemModify;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceAnnotazioni;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceTipiAnnotazione;
        private DevExpress.XtraBars.PopupMenu popupMenuAnnotazioni;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
    }
}
