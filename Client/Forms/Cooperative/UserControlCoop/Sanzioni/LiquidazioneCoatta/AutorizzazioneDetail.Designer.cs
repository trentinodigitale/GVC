namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Sanzioni.LiquidazioneCoatta
{
    partial class AutorizzazioneDetail
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
            this.barButtonItemNew = new DevExpress.XtraBars.BarButtonItem();
            this.gridControlAuthorizations = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceAuthorizations = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.gridViewAuthorizations = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTipoAutorizzazione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bindingSourceAuthorizationType = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.colHistoricalDataDescrizione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeterminaNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeterminaDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommissionDeliberationNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommissionDeliberationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInstanceDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupMenuAutorizzazioneDetail = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAuthorizations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAuthorizations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAuthorizations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAuthorizationType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuAutorizzazioneDetail)).BeginInit();
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
            this.ScrollableContent.Controls.Add(this.gridControlAuthorizations);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 49);
            this.ScrollableContent.Size = new System.Drawing.Size(808, 399);
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
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
            // barButtonItemNew
            // 
            this.barButtonItemNew.Caption = "Nuovo";
            this.barButtonItemNew.Id = 11;
            this.barButtonItemNew.Name = "barButtonItemNew";
            // 
            // gridControlAuthorizations
            // 
            this.gridControlAuthorizations.DataSource = this.bindingSourceAuthorizations;
            this.gridControlAuthorizations.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlAuthorizations.Location = new System.Drawing.Point(0, 0);
            this.gridControlAuthorizations.MainView = this.gridViewAuthorizations;
            this.gridControlAuthorizations.Name = "gridControlAuthorizations";
            this.gridControlAuthorizations.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControlAuthorizations.Size = new System.Drawing.Size(808, 399);
            this.gridControlAuthorizations.TabIndex = 3;
            this.gridControlAuthorizations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAuthorizations});
            this.gridControlAuthorizations.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlAuthorizations_MouseDoubleClick);
            // 
            // bindingSourceAuthorizations
            // 
            this.bindingSourceAuthorizations.AutoCreateObjects = false;
            this.bindingSourceAuthorizations.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.AutorizzazioneFDT);
            this.bindingSourceAuthorizations.CurrentChanged += new System.EventHandler(this.bindingSourceAuthorizations_CurrentChanged);
            // 
            // gridViewAuthorizations
            // 
            this.gridViewAuthorizations.ColumnPanelRowHeight = 40;
            this.gridViewAuthorizations.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTipoAutorizzazione,
            this.colHistoricalDataDescrizione,
            this.colDeterminaNumber,
            this.colDeterminaDate,
            this.colCommissionDeliberationNumber,
            this.colCommissionDeliberationDate,
            this.colInstanceDate,
            this.colNote,
            this.colStatus});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colStatus;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual;
            styleFormatCondition1.Value1 = "100";
            this.gridViewAuthorizations.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridViewAuthorizations.GridControl = this.gridControlAuthorizations;
            this.gridViewAuthorizations.Name = "gridViewAuthorizations";
            this.gridViewAuthorizations.OptionsBehavior.Editable = false;
            this.gridViewAuthorizations.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewAuthorizations.OptionsView.ShowGroupPanel = false;
            this.gridViewAuthorizations.OptionsView.ShowIndicator = false;
            this.gridViewAuthorizations.ShowGridMenu += new DevExpress.XtraGrid.Views.Grid.GridMenuEventHandler(this.gridViewAuthorizations_ShowGridMenu);
            // 
            // colIdTipoAutorizzazione
            // 
            this.colIdTipoAutorizzazione.Caption = "Tipo";
            this.colIdTipoAutorizzazione.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colIdTipoAutorizzazione.FieldName = "IdTipoAutorizzazione";
            this.colIdTipoAutorizzazione.Name = "colIdTipoAutorizzazione";
            this.colIdTipoAutorizzazione.OptionsColumn.AllowEdit = false;
            this.colIdTipoAutorizzazione.OptionsColumn.AllowFocus = false;
            this.colIdTipoAutorizzazione.OptionsColumn.AllowMove = false;
            this.colIdTipoAutorizzazione.Visible = true;
            this.colIdTipoAutorizzazione.VisibleIndex = 0;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.bindingSourceAuthorizationType;
            this.repositoryItemLookUpEdit1.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "IdElemento";
            // 
            // bindingSourceAuthorizationType
            // 
            this.bindingSourceAuthorizationType.AutoCreateObjects = false;
            this.bindingSourceAuthorizationType.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // colHistoricalDataDescrizione
            // 
            this.colHistoricalDataDescrizione.AppearanceHeader.Options.UseTextOptions = true;
            this.colHistoricalDataDescrizione.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHistoricalDataDescrizione.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colHistoricalDataDescrizione.Caption = "Descrizione";
            this.colHistoricalDataDescrizione.FieldName = "DescrizioneDatoStorico";
            this.colHistoricalDataDescrizione.Name = "colHistoricalDataDescrizione";
            this.colHistoricalDataDescrizione.OptionsColumn.AllowEdit = false;
            this.colHistoricalDataDescrizione.OptionsColumn.AllowFocus = false;
            this.colHistoricalDataDescrizione.OptionsColumn.AllowMove = false;
            this.colHistoricalDataDescrizione.Visible = true;
            this.colHistoricalDataDescrizione.VisibleIndex = 1;
            this.colHistoricalDataDescrizione.Width = 183;
            // 
            // colDeterminaNumber
            // 
            this.colDeterminaNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colDeterminaNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDeterminaNumber.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colDeterminaNumber.Caption = "Nr.determina";
            this.colDeterminaNumber.FieldName = "NumeroDetermina";
            this.colDeterminaNumber.Name = "colDeterminaNumber";
            this.colDeterminaNumber.OptionsColumn.AllowEdit = false;
            this.colDeterminaNumber.OptionsColumn.AllowFocus = false;
            this.colDeterminaNumber.OptionsColumn.AllowMove = false;
            this.colDeterminaNumber.Visible = true;
            this.colDeterminaNumber.VisibleIndex = 2;
            this.colDeterminaNumber.Width = 90;
            // 
            // colDeterminaDate
            // 
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
            this.colDeterminaDate.Width = 76;
            // 
            // colCommissionDeliberationNumber
            // 
            this.colCommissionDeliberationNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colCommissionDeliberationNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCommissionDeliberationNumber.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colCommissionDeliberationNumber.Caption = "Nr.delibera commissione";
            this.colCommissionDeliberationNumber.FieldName = "NumeroDeliberaCommissione";
            this.colCommissionDeliberationNumber.Name = "colCommissionDeliberationNumber";
            this.colCommissionDeliberationNumber.OptionsColumn.AllowEdit = false;
            this.colCommissionDeliberationNumber.OptionsColumn.AllowFocus = false;
            this.colCommissionDeliberationNumber.OptionsColumn.AllowMove = false;
            this.colCommissionDeliberationNumber.Visible = true;
            this.colCommissionDeliberationNumber.VisibleIndex = 4;
            this.colCommissionDeliberationNumber.Width = 84;
            // 
            // colCommissionDeliberationDate
            // 
            this.colCommissionDeliberationDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colCommissionDeliberationDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCommissionDeliberationDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colCommissionDeliberationDate.Caption = "Data delibera commissione";
            this.colCommissionDeliberationDate.DisplayFormat.FormatString = "d";
            this.colCommissionDeliberationDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCommissionDeliberationDate.FieldName = "DataDeliberaCommissione";
            this.colCommissionDeliberationDate.Name = "colCommissionDeliberationDate";
            this.colCommissionDeliberationDate.OptionsColumn.AllowEdit = false;
            this.colCommissionDeliberationDate.OptionsColumn.AllowFocus = false;
            this.colCommissionDeliberationDate.OptionsColumn.AllowMove = false;
            this.colCommissionDeliberationDate.Visible = true;
            this.colCommissionDeliberationDate.VisibleIndex = 5;
            this.colCommissionDeliberationDate.Width = 109;
            // 
            // colInstanceDate
            // 
            this.colInstanceDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colInstanceDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInstanceDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colInstanceDate.Caption = "Data istanza";
            this.colInstanceDate.DisplayFormat.FormatString = "d";
            this.colInstanceDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colInstanceDate.FieldName = "DataIstanza";
            this.colInstanceDate.Name = "colInstanceDate";
            this.colInstanceDate.OptionsColumn.AllowEdit = false;
            this.colInstanceDate.OptionsColumn.AllowFocus = false;
            this.colInstanceDate.OptionsColumn.AllowMove = false;
            this.colInstanceDate.Visible = true;
            this.colInstanceDate.VisibleIndex = 6;
            this.colInstanceDate.Width = 67;
            // 
            // colNote
            // 
            this.colNote.AppearanceHeader.Options.UseTextOptions = true;
            this.colNote.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNote.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colNote.Caption = "Note";
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.OptionsColumn.AllowEdit = false;
            this.colNote.OptionsColumn.AllowFocus = false;
            this.colNote.OptionsColumn.AllowMove = false;
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 7;
            this.colNote.Width = 203;
            // 
            // popupMenuAutorizzazioneDetail
            // 
            this.popupMenuAutorizzazioneDetail.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemModify),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemDelete)});
            this.popupMenuAutorizzazioneDetail.Manager = this.BarManager;
            this.popupMenuAutorizzazioneDetail.Name = "popupMenuAutorizzazioneDetail";
            // 
            // AutorizzazioneDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "AutorizzazioneDetail";
            this.Size = new System.Drawing.Size(808, 448);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAuthorizations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAuthorizations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAuthorizations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAuthorizationType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuAutorizzazioneDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraGrid.GridControl gridControlAuthorizations;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAuthorizations;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceAuthorizations;
        private DevExpress.XtraGrid.Columns.GridColumn colHistoricalDataDescrizione;
        private DevExpress.XtraGrid.Columns.GridColumn colDeterminaNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDeterminaDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCommissionDeliberationNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colCommissionDeliberationDate;
        private DevExpress.XtraGrid.Columns.GridColumn colInstanceDate;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceAuthorizationType;
        private DevExpress.XtraBars.BarButtonItem barButtonItemNew;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoAutorizzazione;
        private DevExpress.XtraBars.BarButtonItem barButtonItemModify;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraBars.PopupMenu popupMenuAutorizzazioneDetail;
    }
}
