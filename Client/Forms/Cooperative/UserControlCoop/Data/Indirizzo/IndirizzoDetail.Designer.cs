namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Data.Indirizzo
{
    partial class IndirizzoDetail
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaintRed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlAddresses = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceAddresses = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.gridViewAddresses = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdAddressType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bindingSourceAddressTypes = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.colStreet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCivicNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFrazione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrincipale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colSede = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.checkEdit1 = new it.dedagroup.GVC.Client.Forms.Controls.CheckEdit();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemAddAddress = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemModify = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDeleteAddress = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuIndirizzi = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAddresses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAddresses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAddresses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAddressTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuIndirizzi)).BeginInit();
            this.SuspendLayout();
            // 
            // BarManager
            // 
            this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemAddAddress,
            this.barButtonItemDeleteAddress,
            this.barButtonItemModify});
            this.BarManager.MaxItemId = 13;
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.gridControlAddresses);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 49);
            this.ScrollableContent.Size = new System.Drawing.Size(808, 118);
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
            // colPaintRed
            // 
            this.colPaintRed.Caption = "PaintRed";
            this.colPaintRed.FieldName = "PaintRed";
            this.colPaintRed.Name = "colPaintRed";
            // 
            // gridControlAddresses
            // 
            this.gridControlAddresses.DataSource = this.bindingSourceAddresses;
            this.gridControlAddresses.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlAddresses.Location = new System.Drawing.Point(0, 0);
            this.gridControlAddresses.MainView = this.gridViewAddresses;
            this.gridControlAddresses.Name = "gridControlAddresses";
            this.gridControlAddresses.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2});
            this.gridControlAddresses.Size = new System.Drawing.Size(808, 116);
            this.gridControlAddresses.TabIndex = 0;
            this.gridControlAddresses.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAddresses});
            this.gridControlAddresses.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlAddresses_MouseDoubleClick);
            // 
            // bindingSourceAddresses
            // 
            this.bindingSourceAddresses.AutoCreateObjects = false;
            this.bindingSourceAddresses.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.IndirizzoFDT);
            this.bindingSourceAddresses.CurrentChanged += new System.EventHandler(this.bindingSourceAddresses_CurrentChanged);
            // 
            // gridViewAddresses
            // 
            this.gridViewAddresses.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdAddressType,
            this.colStreet,
            this.colCivicNumber,
            this.colFrazione,
            this.colCity,
            this.colEmail,
            this.colStatus,
            this.colPrincipale,
            this.colSede,
            this.colPaintRed});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout);
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colStatus;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual;
            styleFormatCondition1.Value1 = 100;
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colPaintRed;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = true;
            styleFormatCondition3.Appearance.BackColor = System.Drawing.Color.LimeGreen;
            styleFormatCondition3.Appearance.Options.UseBackColor = true;
            styleFormatCondition3.ApplyToRow = true;
            styleFormatCondition3.Column = this.colPaintRed;
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition3.Value1 = false;
            this.gridViewAddresses.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2,
            styleFormatCondition3});
            this.gridViewAddresses.GridControl = this.gridControlAddresses;
            this.gridViewAddresses.Name = "gridViewAddresses";
            this.gridViewAddresses.OptionsBehavior.Editable = false;
            this.gridViewAddresses.OptionsMenu.EnableColumnMenu = false;
            this.gridViewAddresses.OptionsMenu.EnableFooterMenu = false;
            this.gridViewAddresses.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewAddresses.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewAddresses.OptionsView.ShowGroupPanel = false;
            this.gridViewAddresses.OptionsView.ShowIndicator = false;
            this.gridViewAddresses.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdAddressType, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewAddresses.ShowGridMenu += new DevExpress.XtraGrid.Views.Grid.GridMenuEventHandler(this.gridViewAddresses_ShowGridMenu);
            // 
            // colIdAddressType
            // 
            this.colIdAddressType.Caption = "Tipo";
            this.colIdAddressType.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colIdAddressType.FieldName = "IdTipoIndirizzo";
            this.colIdAddressType.Name = "colIdAddressType";
            this.colIdAddressType.OptionsColumn.AllowEdit = false;
            this.colIdAddressType.OptionsColumn.AllowFocus = false;
            this.colIdAddressType.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIdAddressType.OptionsColumn.AllowMove = false;
            this.colIdAddressType.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIdAddressType.OptionsFilter.AllowAutoFilter = false;
            this.colIdAddressType.OptionsFilter.AllowFilter = false;
            this.colIdAddressType.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
            this.colIdAddressType.Visible = true;
            this.colIdAddressType.VisibleIndex = 0;
            this.colIdAddressType.Width = 115;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.bindingSourceAddressTypes;
            this.repositoryItemLookUpEdit1.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "IdElemento";
            // 
            // bindingSourceAddressTypes
            // 
            this.bindingSourceAddressTypes.AutoCreateObjects = false;
            this.bindingSourceAddressTypes.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.Dictionaries.TipoIndirizzoFDT);
            // 
            // colStreet
            // 
            this.colStreet.Caption = "Via";
            this.colStreet.FieldName = "Via";
            this.colStreet.Name = "colStreet";
            this.colStreet.OptionsColumn.AllowEdit = false;
            this.colStreet.OptionsColumn.AllowFocus = false;
            this.colStreet.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colStreet.OptionsColumn.AllowMove = false;
            this.colStreet.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colStreet.OptionsFilter.AllowAutoFilter = false;
            this.colStreet.OptionsFilter.AllowFilter = false;
            this.colStreet.Visible = true;
            this.colStreet.VisibleIndex = 1;
            this.colStreet.Width = 150;
            // 
            // colCivicNumber
            // 
            this.colCivicNumber.Caption = "Civico";
            this.colCivicNumber.FieldName = "NumeroCivico";
            this.colCivicNumber.Name = "colCivicNumber";
            this.colCivicNumber.OptionsColumn.AllowEdit = false;
            this.colCivicNumber.OptionsColumn.AllowFocus = false;
            this.colCivicNumber.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCivicNumber.OptionsColumn.AllowMove = false;
            this.colCivicNumber.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCivicNumber.OptionsFilter.AllowAutoFilter = false;
            this.colCivicNumber.OptionsFilter.AllowFilter = false;
            this.colCivicNumber.Visible = true;
            this.colCivicNumber.VisibleIndex = 2;
            this.colCivicNumber.Width = 44;
            // 
            // colFrazione
            // 
            this.colFrazione.Caption = "Frazione";
            this.colFrazione.FieldName = "Frazione";
            this.colFrazione.Name = "colFrazione";
            this.colFrazione.OptionsColumn.AllowEdit = false;
            this.colFrazione.OptionsColumn.AllowFocus = false;
            this.colFrazione.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colFrazione.OptionsColumn.AllowMove = false;
            this.colFrazione.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colFrazione.OptionsFilter.AllowAutoFilter = false;
            this.colFrazione.OptionsFilter.AllowFilter = false;
            this.colFrazione.Visible = true;
            this.colFrazione.VisibleIndex = 3;
            this.colFrazione.Width = 120;
            // 
            // colCity
            // 
            this.colCity.Caption = "Comune";
            this.colCity.FieldName = "Comune";
            this.colCity.Name = "colCity";
            this.colCity.OptionsColumn.AllowEdit = false;
            this.colCity.OptionsColumn.AllowFocus = false;
            this.colCity.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCity.OptionsColumn.AllowMove = false;
            this.colCity.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCity.OptionsFilter.AllowAutoFilter = false;
            this.colCity.OptionsFilter.AllowFilter = false;
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 4;
            this.colCity.Width = 108;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.AllowEdit = false;
            this.colEmail.OptionsColumn.AllowFocus = false;
            this.colEmail.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colEmail.OptionsColumn.AllowMove = false;
            this.colEmail.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEmail.OptionsFilter.AllowAutoFilter = false;
            this.colEmail.OptionsFilter.AllowFilter = false;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 5;
            this.colEmail.Width = 168;
            // 
            // colPrincipale
            // 
            this.colPrincipale.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrincipale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrincipale.Caption = "Corrispondenza";
            this.colPrincipale.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colPrincipale.FieldName = "Principale";
            this.colPrincipale.Name = "colPrincipale";
            this.colPrincipale.OptionsColumn.AllowEdit = false;
            this.colPrincipale.OptionsColumn.AllowFocus = false;
            this.colPrincipale.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPrincipale.OptionsColumn.AllowMove = false;
            this.colPrincipale.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPrincipale.OptionsFilter.AllowAutoFilter = false;
            this.colPrincipale.OptionsFilter.AllowFilter = false;
            this.colPrincipale.Visible = true;
            this.colPrincipale.VisibleIndex = 6;
            this.colPrincipale.Width = 78;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // colSede
            // 
            this.colSede.AppearanceHeader.Options.UseTextOptions = true;
            this.colSede.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSede.Caption = "Confronta Parix";
            this.colSede.ColumnEdit = this.repositoryItemCheckEdit2;
            this.colSede.FieldName = "Sede";
            this.colSede.Name = "colSede";
            this.colSede.OptionsColumn.AllowEdit = false;
            this.colSede.OptionsColumn.AllowFocus = false;
            this.colSede.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colSede.OptionsColumn.AllowMove = false;
            this.colSede.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSede.OptionsFilter.AllowAutoFilter = false;
            this.colSede.OptionsFilter.AllowFilter = false;
            this.colSede.Visible = true;
            this.colSede.VisibleIndex = 7;
            this.colSede.Width = 108;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(348, 72);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "checkEdit1";
            this.checkEdit1.Size = new System.Drawing.Size(137, 19);
            this.checkEdit1.TabIndex = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 3";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemAddAddress, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemModify, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemDeleteAddress, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.RotateWhenVertical = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 3";
            // 
            // barButtonItemAddAddress
            // 
            this.barButtonItemAddAddress.Caption = "Nuovo";
            this.barButtonItemAddAddress.Id = 9;
            this.barButtonItemAddAddress.Name = "barButtonItemAddAddress";
            this.barButtonItemAddAddress.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAddAddress_ItemClick);
            // 
            // barButtonItemModify
            // 
            this.barButtonItemModify.Caption = "Modifica";
            this.barButtonItemModify.Id = 12;
            this.barButtonItemModify.Name = "barButtonItemModify";
            this.barButtonItemModify.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemModify_ItemClick);
            // 
            // barButtonItemDeleteAddress
            // 
            this.barButtonItemDeleteAddress.Caption = "Cancella";
            this.barButtonItemDeleteAddress.Id = 10;
            this.barButtonItemDeleteAddress.Name = "barButtonItemDeleteAddress";
            this.barButtonItemDeleteAddress.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDeleteAddress_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = -1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // popupMenuIndirizzi
            // 
            this.popupMenuIndirizzi.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAddAddress),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemModify),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemDeleteAddress)});
            this.popupMenuIndirizzi.Manager = this.BarManager;
            this.popupMenuIndirizzi.Name = "popupMenuIndirizzi";
            // 
            // IndirizzoDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "IndirizzoDetail";
            this.Size = new System.Drawing.Size(808, 167);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAddresses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAddresses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAddresses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAddressTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuIndirizzi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlAddresses;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceAddresses;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceAddressTypes;
        private it.dedagroup.GVC.Client.Forms.Controls.CheckEdit checkEdit1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAddAddress;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDeleteAddress;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAddresses;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAddressType;
        private DevExpress.XtraGrid.Columns.GridColumn colStreet;
        private DevExpress.XtraGrid.Columns.GridColumn colCivicNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemModify;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraBars.PopupMenu popupMenuIndirizzi;
        private DevExpress.XtraGrid.Columns.GridColumn colPrincipale;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colSede;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colPaintRed;
        private DevExpress.XtraGrid.Columns.GridColumn colFrazione;
    }
}
