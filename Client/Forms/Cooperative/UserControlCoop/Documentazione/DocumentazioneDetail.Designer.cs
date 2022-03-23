namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Documentazione
{
    partial class DocumentazioneDetail
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlDocumentation = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceDocumentation = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.gridViewDocumentation = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdDocumentationType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bindingSourceDocumentationTypes = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocumentDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeFile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAttachment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colProtocolNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemAddDocumentation = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemModify = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.colDimensione = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDocumentation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDocumentation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDocumentation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDocumentationTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarManager
            // 
            this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemAddDocumentation,
            this.barButtonItemDelete,
            this.barButtonItemModify});
            this.BarManager.MaxItemId = 12;
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.gridControlDocumentation);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 49);
            this.ScrollableContent.Size = new System.Drawing.Size(711, 162);
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.OptionsFilter.AllowAutoFilter = false;
            this.colStatus.OptionsFilter.AllowFilter = false;
            // 
            // gridControlDocumentation
            // 
            this.gridControlDocumentation.DataSource = this.bindingSourceDocumentation;
            this.gridControlDocumentation.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlDocumentation.Location = new System.Drawing.Point(0, 0);
            this.gridControlDocumentation.MainView = this.gridViewDocumentation;
            this.gridControlDocumentation.Name = "gridControlDocumentation";
            this.gridControlDocumentation.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemPictureEdit1});
            this.gridControlDocumentation.Size = new System.Drawing.Size(694, 187);
            this.gridControlDocumentation.TabIndex = 0;
            this.gridControlDocumentation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDocumentation});
            this.gridControlDocumentation.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlDocumentation_MouseDoubleClick);
            // 
            // bindingSourceDocumentation
            // 
            this.bindingSourceDocumentation.AutoCreateObjects = false;
            this.bindingSourceDocumentation.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DocumentazioneFDT);
            this.bindingSourceDocumentation.CurrentItemChanged += new System.EventHandler(this.bindingSourceDocumentation_CurrentItemChanged);
            // 
            // gridViewDocumentation
            // 
            this.gridViewDocumentation.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdDocumentationType,
            this.colTitle,
            this.colDocumentDate,
            this.colNomeFile,
            this.colAttachment,
            this.colDimensione,
            this.colProtocolNumber,
            this.colStatus});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout);
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colStatus;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual;
            styleFormatCondition1.Value1 = 100;
            this.gridViewDocumentation.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridViewDocumentation.GridControl = this.gridControlDocumentation;
            this.gridViewDocumentation.Name = "gridViewDocumentation";
            this.gridViewDocumentation.OptionsBehavior.Editable = false;
            this.gridViewDocumentation.OptionsCustomization.AllowSort = false;
            this.gridViewDocumentation.OptionsMenu.EnableColumnMenu = false;
            this.gridViewDocumentation.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewDocumentation.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewDocumentation.OptionsView.ShowGroupPanel = false;
            this.gridViewDocumentation.OptionsView.ShowIndicator = false;
            this.gridViewDocumentation.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDocumentDate, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colIdDocumentationType
            // 
            this.colIdDocumentationType.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdDocumentationType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdDocumentationType.Caption = "Tipo";
            this.colIdDocumentationType.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colIdDocumentationType.FieldName = "IdTipoDocumentazione";
            this.colIdDocumentationType.Name = "colIdDocumentationType";
            this.colIdDocumentationType.OptionsColumn.AllowEdit = false;
            this.colIdDocumentationType.OptionsColumn.AllowFocus = false;
            this.colIdDocumentationType.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIdDocumentationType.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colIdDocumentationType.OptionsColumn.AllowMove = false;
            this.colIdDocumentationType.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIdDocumentationType.OptionsFilter.AllowAutoFilter = false;
            this.colIdDocumentationType.OptionsFilter.AllowFilter = false;
            this.colIdDocumentationType.Visible = true;
            this.colIdDocumentationType.VisibleIndex = 0;
            this.colIdDocumentationType.Width = 129;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.DataSource = this.bindingSourceDocumentationTypes;
            this.repositoryItemLookUpEdit2.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.NullText = "";
            this.repositoryItemLookUpEdit2.ValueMember = "IdElemento";
            // 
            // bindingSourceDocumentationTypes
            // 
            this.bindingSourceDocumentationTypes.AutoCreateObjects = false;
            this.bindingSourceDocumentationTypes.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // colTitle
            // 
            this.colTitle.AppearanceHeader.Options.UseTextOptions = true;
            this.colTitle.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTitle.Caption = "Segnalibro";
            this.colTitle.FieldName = "Titolo";
            this.colTitle.Name = "colTitle";
            this.colTitle.OptionsColumn.AllowEdit = false;
            this.colTitle.OptionsColumn.AllowFocus = false;
            this.colTitle.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colTitle.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colTitle.OptionsColumn.AllowMove = false;
            this.colTitle.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTitle.OptionsFilter.AllowAutoFilter = false;
            this.colTitle.OptionsFilter.AllowFilter = false;
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 1;
            this.colTitle.Width = 169;
            // 
            // colDocumentDate
            // 
            this.colDocumentDate.AppearanceCell.Options.UseTextOptions = true;
            this.colDocumentDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDocumentDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colDocumentDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDocumentDate.Caption = "Data documento";
            this.colDocumentDate.DisplayFormat.FormatString = "d";
            this.colDocumentDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDocumentDate.FieldName = "DataDocumento";
            this.colDocumentDate.Name = "colDocumentDate";
            this.colDocumentDate.OptionsColumn.AllowEdit = false;
            this.colDocumentDate.OptionsColumn.AllowFocus = false;
            this.colDocumentDate.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDocumentDate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDocumentDate.OptionsColumn.AllowMove = false;
            this.colDocumentDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDocumentDate.OptionsFilter.AllowAutoFilter = false;
            this.colDocumentDate.OptionsFilter.AllowFilter = false;
            this.colDocumentDate.Visible = true;
            this.colDocumentDate.VisibleIndex = 2;
            this.colDocumentDate.Width = 105;
            // 
            // colNomeFile
            // 
            this.colNomeFile.AppearanceHeader.Options.UseTextOptions = true;
            this.colNomeFile.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNomeFile.Caption = "Nome File";
            this.colNomeFile.FieldName = "NomeFile";
            this.colNomeFile.Name = "colNomeFile";
            this.colNomeFile.OptionsColumn.AllowEdit = false;
            this.colNomeFile.OptionsColumn.AllowFocus = false;
            this.colNomeFile.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colNomeFile.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colNomeFile.OptionsColumn.AllowMove = false;
            this.colNomeFile.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNomeFile.OptionsFilter.AllowAutoFilter = false;
            this.colNomeFile.OptionsFilter.AllowFilter = false;
            this.colNomeFile.Visible = true;
            this.colNomeFile.VisibleIndex = 3;
            this.colNomeFile.Width = 119;
            // 
            // colAttachment
            // 
            this.colAttachment.AppearanceHeader.Options.UseTextOptions = true;
            this.colAttachment.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAttachment.Caption = "Allegato";
            this.colAttachment.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colAttachment.FieldName = "Icona";
            this.colAttachment.Name = "colAttachment";
            this.colAttachment.OptionsFilter.AllowAutoFilter = false;
            this.colAttachment.OptionsFilter.AllowFilter = false;
            this.colAttachment.Visible = true;
            this.colAttachment.VisibleIndex = 4;
            this.colAttachment.Width = 50;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.repositoryItemPictureEdit1.DoubleClick += new System.EventHandler(this.repositoryItemPictureEdit1_DoubleClick);
            // 
            // colProtocolNumber
            // 
            this.colProtocolNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colProtocolNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProtocolNumber.Caption = "Numero protocollo";
            this.colProtocolNumber.FieldName = "NumeroProtocollo";
            this.colProtocolNumber.Name = "colProtocolNumber";
            this.colProtocolNumber.OptionsColumn.AllowEdit = false;
            this.colProtocolNumber.OptionsColumn.AllowFocus = false;
            this.colProtocolNumber.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colProtocolNumber.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colProtocolNumber.OptionsColumn.AllowMove = false;
            this.colProtocolNumber.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colProtocolNumber.OptionsFilter.AllowAutoFilter = false;
            this.colProtocolNumber.OptionsFilter.AllowFilter = false;
            this.colProtocolNumber.Visible = true;
            this.colProtocolNumber.VisibleIndex = 6;
            this.colProtocolNumber.Width = 95;
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
            this.bar1.BarName = "Custom 3";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemAddDocumentation, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemModify, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 3";
            // 
            // barButtonItemAddDocumentation
            // 
            this.barButtonItemAddDocumentation.Caption = "Nuova documentazione";
            this.barButtonItemAddDocumentation.Id = 9;
            this.barButtonItemAddDocumentation.Name = "barButtonItemAddDocumentation";
            this.barButtonItemAddDocumentation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAddDocumentation_ItemClick);
            // 
            // barButtonItemModify
            // 
            this.barButtonItemModify.Caption = "Modifica documentazione";
            this.barButtonItemModify.Id = 11;
            this.barButtonItemModify.Name = "barButtonItemModify";
            this.barButtonItemModify.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemModify_ItemClick);
            // 
            // barButtonItemDelete
            // 
            this.barButtonItemDelete.Caption = "Cancella documentazione";
            this.barButtonItemDelete.Id = 10;
            this.barButtonItemDelete.Name = "barButtonItemDelete";
            this.barButtonItemDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDelete_ItemClick);
            // 
            // colDimensione
            // 
            this.colDimensione.AppearanceHeader.Options.UseTextOptions = true;
            this.colDimensione.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDimensione.Caption = "Dimensione";
            this.colDimensione.DisplayFormat.FormatString = "{0:N0} KB";
            this.colDimensione.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDimensione.FieldName = "Dimensione";
            this.colDimensione.Name = "colDimensione";
            this.colDimensione.OptionsColumn.AllowEdit = false;
            this.colDimensione.OptionsColumn.AllowFocus = false;
            this.colDimensione.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDimensione.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDimensione.OptionsColumn.AllowMove = false;
            this.colDimensione.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDimensione.OptionsFilter.AllowAutoFilter = false;
            this.colDimensione.OptionsFilter.AllowFilter = false;
            this.colDimensione.Visible = true;
            this.colDimensione.VisibleIndex = 5;
            // 
            // DocumentazioneDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "DocumentazioneDetail";
            this.Size = new System.Drawing.Size(711, 211);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDocumentation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDocumentation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDocumentation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDocumentationTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlDocumentation;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceDocumentationTypes;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceDocumentation;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDocumentationType;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumentDate;
        private DevExpress.XtraGrid.Columns.GridColumn colProtocolNumber;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAddDocumentation;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colAttachment;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemModify;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewDocumentation;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeFile;
        private DevExpress.XtraGrid.Columns.GridColumn colDimensione;
    }
}
