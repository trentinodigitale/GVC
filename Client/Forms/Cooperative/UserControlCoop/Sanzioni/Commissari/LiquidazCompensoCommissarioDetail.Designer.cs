namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Sanzioni.Commissari
{
    partial class LiquidazCompensoCommissarioDetail
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
            this.bindingSourceCommissionerPayment = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemModify = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.gridControlCommissionerPayments = new DevExpress.XtraGrid.GridControl();
            this.gridViewCommissionerPayments = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRequestReceivingDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImportoDeterminato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImportoErogato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroDetermina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataDetermina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsLiquidated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroMandatoPagamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataMandatoPagamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.popupMenuLiquidazCompensoCommissario = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCommissionerPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCommissionerPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCommissionerPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuLiquidazCompensoCommissario)).BeginInit();
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
            this.ScrollableContent.Controls.Add(this.gridControlCommissionerPayments);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 49);
            this.ScrollableContent.Size = new System.Drawing.Size(699, 279);
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.OptionsColumn.AllowEdit = false;
            this.colStatus.OptionsColumn.AllowFocus = false;
            this.colStatus.OptionsColumn.AllowMove = false;
            // 
            // bindingSourceCommissionerPayment
            // 
            this.bindingSourceCommissionerPayment.AutoCreateObjects = false;
            this.bindingSourceCommissionerPayment.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.CompensoLiquidazioneFDT);
            this.bindingSourceCommissionerPayment.CurrentChanged += new System.EventHandler(this.bindingSourceCommissionerPayment_CurrentChanged);
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
            // gridControlCommissionerPayments
            // 
            this.gridControlCommissionerPayments.DataSource = this.bindingSourceCommissionerPayment;
            this.gridControlCommissionerPayments.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlCommissionerPayments.Location = new System.Drawing.Point(0, 0);
            this.gridControlCommissionerPayments.MainView = this.gridViewCommissionerPayments;
            this.gridControlCommissionerPayments.Name = "gridControlCommissionerPayments";
            this.gridControlCommissionerPayments.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControlCommissionerPayments.Size = new System.Drawing.Size(699, 276);
            this.gridControlCommissionerPayments.TabIndex = 3;
            this.gridControlCommissionerPayments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCommissionerPayments});
            this.gridControlCommissionerPayments.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlCommissionerPayments_MouseDoubleClick);
            // 
            // gridViewCommissionerPayments
            // 
            this.gridViewCommissionerPayments.ColumnPanelRowHeight = 40;
            this.gridViewCommissionerPayments.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRequestReceivingDate,
            this.colImportoDeterminato,
            this.colImportoErogato,
            this.colNumeroDetermina,
            this.colDataDetermina,
            this.colIsLiquidated,
            this.colNumeroMandatoPagamento,
            this.colDataMandatoPagamento,
            this.colNote,
            this.colStatus});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colStatus;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual;
            styleFormatCondition1.Value1 = "100";
            this.gridViewCommissionerPayments.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridViewCommissionerPayments.GridControl = this.gridControlCommissionerPayments;
            this.gridViewCommissionerPayments.Name = "gridViewCommissionerPayments";
            this.gridViewCommissionerPayments.OptionsBehavior.Editable = false;
            this.gridViewCommissionerPayments.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewCommissionerPayments.OptionsView.ShowFooter = true;
            this.gridViewCommissionerPayments.OptionsView.ShowGroupPanel = false;
            this.gridViewCommissionerPayments.OptionsView.ShowIndicator = false;
            this.gridViewCommissionerPayments.ShowGridMenu += new DevExpress.XtraGrid.Views.Grid.GridMenuEventHandler(this.gridViewCommissionerPayments_ShowGridMenu);
            // 
            // colRequestReceivingDate
            // 
            this.colRequestReceivingDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colRequestReceivingDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRequestReceivingDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colRequestReceivingDate.Caption = "Data ricevimento domanda contributo";
            this.colRequestReceivingDate.DisplayFormat.FormatString = "d";
            this.colRequestReceivingDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colRequestReceivingDate.FieldName = "DataRicevimentoDomanda";
            this.colRequestReceivingDate.Name = "colRequestReceivingDate";
            this.colRequestReceivingDate.OptionsColumn.AllowEdit = false;
            this.colRequestReceivingDate.OptionsColumn.AllowFocus = false;
            this.colRequestReceivingDate.OptionsColumn.AllowMove = false;
            this.colRequestReceivingDate.Visible = true;
            this.colRequestReceivingDate.VisibleIndex = 0;
            this.colRequestReceivingDate.Width = 81;
            // 
            // colImportoDeterminato
            // 
            this.colImportoDeterminato.AppearanceHeader.Options.UseTextOptions = true;
            this.colImportoDeterminato.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colImportoDeterminato.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colImportoDeterminato.Caption = "Importo determinato";
            this.colImportoDeterminato.DisplayFormat.FormatString = "n";
            this.colImportoDeterminato.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colImportoDeterminato.FieldName = "ImportoDeterminato";
            this.colImportoDeterminato.Name = "colImportoDeterminato";
            this.colImportoDeterminato.OptionsColumn.AllowEdit = false;
            this.colImportoDeterminato.OptionsColumn.AllowFocus = false;
            this.colImportoDeterminato.OptionsColumn.AllowMove = false;
            this.colImportoDeterminato.SummaryItem.DisplayFormat = "{0:N2}";
            this.colImportoDeterminato.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colImportoDeterminato.Visible = true;
            this.colImportoDeterminato.VisibleIndex = 1;
            this.colImportoDeterminato.Width = 78;
            // 
            // colImportoErogato
            // 
            this.colImportoErogato.AppearanceHeader.Options.UseTextOptions = true;
            this.colImportoErogato.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colImportoErogato.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colImportoErogato.Caption = "Importo erogato";
            this.colImportoErogato.DisplayFormat.FormatString = "n";
            this.colImportoErogato.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colImportoErogato.FieldName = "ImportoErogato";
            this.colImportoErogato.Name = "colImportoErogato";
            this.colImportoErogato.OptionsColumn.AllowEdit = false;
            this.colImportoErogato.OptionsColumn.AllowFocus = false;
            this.colImportoErogato.OptionsColumn.AllowMove = false;
            this.colImportoErogato.SummaryItem.DisplayFormat = "{0:N2}";
            this.colImportoErogato.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colImportoErogato.Visible = true;
            this.colImportoErogato.VisibleIndex = 2;
            this.colImportoErogato.Width = 110;
            // 
            // colNumeroDetermina
            // 
            this.colNumeroDetermina.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumeroDetermina.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumeroDetermina.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colNumeroDetermina.Caption = "Nr. determina";
            this.colNumeroDetermina.FieldName = "NumeroDetermina";
            this.colNumeroDetermina.Name = "colNumeroDetermina";
            this.colNumeroDetermina.OptionsColumn.AllowEdit = false;
            this.colNumeroDetermina.OptionsColumn.AllowFocus = false;
            this.colNumeroDetermina.OptionsColumn.AllowMove = false;
            this.colNumeroDetermina.Visible = true;
            this.colNumeroDetermina.VisibleIndex = 3;
            this.colNumeroDetermina.Width = 82;
            // 
            // colDataDetermina
            // 
            this.colDataDetermina.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataDetermina.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataDetermina.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colDataDetermina.Caption = "Data determina";
            this.colDataDetermina.DisplayFormat.FormatString = "d";
            this.colDataDetermina.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDataDetermina.FieldName = "DataDetermina";
            this.colDataDetermina.Name = "colDataDetermina";
            this.colDataDetermina.OptionsColumn.AllowEdit = false;
            this.colDataDetermina.OptionsColumn.AllowFocus = false;
            this.colDataDetermina.OptionsColumn.AllowMove = false;
            this.colDataDetermina.Visible = true;
            this.colDataDetermina.VisibleIndex = 4;
            this.colDataDetermina.Width = 76;
            // 
            // colIsLiquidated
            // 
            this.colIsLiquidated.AppearanceHeader.Options.UseTextOptions = true;
            this.colIsLiquidated.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsLiquidated.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colIsLiquidated.Caption = "Liquidato";
            this.colIsLiquidated.FieldName = "Liquidato";
            this.colIsLiquidated.Name = "colIsLiquidated";
            this.colIsLiquidated.OptionsColumn.AllowEdit = false;
            this.colIsLiquidated.OptionsColumn.AllowFocus = false;
            this.colIsLiquidated.OptionsColumn.AllowMove = false;
            this.colIsLiquidated.Visible = true;
            this.colIsLiquidated.VisibleIndex = 5;
            this.colIsLiquidated.Width = 102;
            // 
            // colNumeroMandatoPagamento
            // 
            this.colNumeroMandatoPagamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumeroMandatoPagamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumeroMandatoPagamento.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colNumeroMandatoPagamento.Caption = "Nr. mandato pagamento";
            this.colNumeroMandatoPagamento.FieldName = "NumeroMandatoPagamento";
            this.colNumeroMandatoPagamento.Name = "colNumeroMandatoPagamento";
            this.colNumeroMandatoPagamento.OptionsColumn.AllowEdit = false;
            this.colNumeroMandatoPagamento.OptionsColumn.AllowFocus = false;
            this.colNumeroMandatoPagamento.OptionsColumn.AllowMove = false;
            this.colNumeroMandatoPagamento.Visible = true;
            this.colNumeroMandatoPagamento.VisibleIndex = 6;
            this.colNumeroMandatoPagamento.Width = 79;
            // 
            // colDataMandatoPagamento
            // 
            this.colDataMandatoPagamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataMandatoPagamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataMandatoPagamento.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colDataMandatoPagamento.Caption = "Data mandato pagamento";
            this.colDataMandatoPagamento.DisplayFormat.FormatString = "d";
            this.colDataMandatoPagamento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDataMandatoPagamento.FieldName = "DataMandatoPagamento";
            this.colDataMandatoPagamento.Name = "colDataMandatoPagamento";
            this.colDataMandatoPagamento.OptionsColumn.AllowEdit = false;
            this.colDataMandatoPagamento.OptionsColumn.AllowFocus = false;
            this.colDataMandatoPagamento.OptionsColumn.AllowMove = false;
            this.colDataMandatoPagamento.Visible = true;
            this.colDataMandatoPagamento.VisibleIndex = 7;
            this.colDataMandatoPagamento.Width = 70;
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
            this.colNote.VisibleIndex = 8;
            this.colNote.Width = 80;
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
            // popupMenuLiquidazCompensoCommissario
            // 
            this.popupMenuLiquidazCompensoCommissario.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemModify),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemDelete)});
            this.popupMenuLiquidazCompensoCommissario.Manager = this.BarManager;
            this.popupMenuLiquidazCompensoCommissario.Name = "popupMenuLiquidazCompensoCommissario";
            // 
            // LiquidazCompensoCommissarioDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "LiquidazCompensoCommissarioDetail";
            this.Size = new System.Drawing.Size(699, 328);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCommissionerPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCommissionerPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCommissionerPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuLiquidazCompensoCommissario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceCommissionerPayment;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraGrid.GridControl gridControlCommissionerPayments;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCommissionerPayments;
        private DevExpress.XtraGrid.Columns.GridColumn colRequestReceivingDate;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroDetermina;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colDataDetermina;
        private DevExpress.XtraGrid.Columns.GridColumn colIsLiquidated;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colImportoErogato;
        private DevExpress.XtraGrid.Columns.GridColumn colDataMandatoPagamento;
        private DevExpress.XtraGrid.Columns.GridColumn colImportoDeterminato;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroMandatoPagamento;
        private DevExpress.XtraBars.BarButtonItem barButtonItemModify;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraBars.PopupMenu popupMenuLiquidazCompensoCommissario;
    }
}
