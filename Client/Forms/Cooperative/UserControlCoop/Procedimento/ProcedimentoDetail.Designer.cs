namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Procedimento
{
    partial class ProcedimentoDetail
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
            this.gridControlProcess = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceProcedimenti = new OeF.Forms.BindingSourceBase(this.components);
            this.gridViewProcess = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTipoProcedimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bindingSourceTipiProcedimenti = new OeF.Forms.BindingSourceBase(this.components);
            this.colDataInizioProcedimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataFineTeorica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoSospensione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bindingSourceTipiSospensioni = new OeF.Forms.BindingSourceBase(this.components);
            this.colDataRiattivazione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataTermineFinale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoConclusione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bindingSourceTipiConclusioni = new OeF.Forms.BindingSourceBase(this.components);
            this.colDataConclusione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatoProcedimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoIniziativa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl3 = new OeF.Forms.Controls.PanelControl();
            this.lookUpEditStatus = new it.dedagroup.GVC.Client.Forms.Controls.LookUpEdit();
            this.bindingSourceBaseStati = new OeF.Forms.BindingSourceBase(this.components);
            this.lookUpEdit3 = new it.dedagroup.GVC.Client.Forms.Controls.LookUpEdit();
            this.bindingSourceTipiIniziative = new OeF.Forms.BindingSourceBase(this.components);
            this.lookUpEdit2 = new it.dedagroup.GVC.Client.Forms.Controls.LookUpEdit();
            this.labelControl35 = new OeF.Forms.Controls.LabelControl();
            this.labelControl34 = new OeF.Forms.Controls.LabelControl();
            this.labelControl33 = new OeF.Forms.Controls.LabelControl();
            this.popupMenuProcedimenti = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProcedimenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipiProcedimenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipiSospensioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipiConclusioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseStati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipiIniziative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuProcedimenti)).BeginInit();
            this.SuspendLayout();
            // 
            // BarManager
            // 
            this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemAdd,
            this.barButtonItemDelete,
            this.barButtonItemEdit});
            this.BarManager.MaxItemId = 12;
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.gridControlProcess);
            this.ScrollableContent.Controls.Add(this.panelControl3);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 49);
            this.ScrollableContent.Size = new System.Drawing.Size(929, 384);
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.OptionsColumn.AllowEdit = false;
            this.colStatus.OptionsColumn.AllowFocus = false;
            this.colStatus.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colStatus.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colStatus.OptionsColumn.AllowMove = false;
            this.colStatus.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colStatus.OptionsFilter.AllowAutoFilter = false;
            this.colStatus.OptionsFilter.AllowFilter = false;
            // 
            // gridControlProcess
            // 
            this.gridControlProcess.DataSource = this.bindingSourceProcedimenti;
            this.gridControlProcess.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlProcess.Location = new System.Drawing.Point(0, 39);
            this.gridControlProcess.MainView = this.gridViewProcess;
            this.gridControlProcess.Name = "gridControlProcess";
            this.gridControlProcess.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemLookUpEdit3});
            this.gridControlProcess.Size = new System.Drawing.Size(929, 164);
            this.gridControlProcess.TabIndex = 0;
            this.gridControlProcess.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProcess});
            this.gridControlProcess.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlProcess_MouseDoubleClick);
            // 
            // bindingSourceProcedimenti
            // 
            this.bindingSourceProcedimenti.AutoCreateObjects = false;
            this.bindingSourceProcedimenti.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.ProcedimentoFDT);
            this.bindingSourceProcedimenti.CurrentChanged += new System.EventHandler(this.bindingSourceProcedimenti_CurrentChanged);
            // 
            // gridViewProcess
            // 
            this.gridViewProcess.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTipoProcedimento,
            this.colDataInizioProcedimento,
            this.colDataFineTeorica,
            this.colIdTipoSospensione,
            this.colDataRiattivazione,
            this.colDataTermineFinale,
            this.colIdTipoConclusione,
            this.colDataConclusione,
            this.colStatus,
            this.colStatoProcedimento,
            this.colIdTipoIniziativa});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout);
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colStatus;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual;
            styleFormatCondition1.Value1 = "100";
            this.gridViewProcess.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridViewProcess.GridControl = this.gridControlProcess;
            this.gridViewProcess.Name = "gridViewProcess";
            this.gridViewProcess.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewProcess.OptionsView.ShowGroupPanel = false;
            this.gridViewProcess.OptionsView.ShowIndicator = false;
            this.gridViewProcess.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDataInizioProcedimento, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewProcess.ShowGridMenu += new DevExpress.XtraGrid.Views.Grid.GridMenuEventHandler(this.gridViewProcess_ShowGridMenu);
            // 
            // colIdTipoProcedimento
            // 
            this.colIdTipoProcedimento.Caption = "Tipo procedimento";
            this.colIdTipoProcedimento.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colIdTipoProcedimento.FieldName = "IdTipoProcedimento";
            this.colIdTipoProcedimento.Name = "colIdTipoProcedimento";
            this.colIdTipoProcedimento.OptionsColumn.AllowEdit = false;
            this.colIdTipoProcedimento.OptionsColumn.AllowFocus = false;
            this.colIdTipoProcedimento.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIdTipoProcedimento.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colIdTipoProcedimento.OptionsColumn.AllowMove = false;
            this.colIdTipoProcedimento.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIdTipoProcedimento.OptionsFilter.AllowAutoFilter = false;
            this.colIdTipoProcedimento.OptionsFilter.AllowFilter = false;
            this.colIdTipoProcedimento.Visible = true;
            this.colIdTipoProcedimento.VisibleIndex = 0;
            this.colIdTipoProcedimento.Width = 149;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.bindingSourceTipiProcedimenti;
            this.repositoryItemLookUpEdit1.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "IdElemento";
            // 
            // bindingSourceTipiProcedimenti
            // 
            this.bindingSourceTipiProcedimenti.AutoCreateObjects = false;
            this.bindingSourceTipiProcedimenti.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // colDataInizioProcedimento
            // 
            this.colDataInizioProcedimento.Caption = "Data inizio";
            this.colDataInizioProcedimento.DisplayFormat.FormatString = "d";
            this.colDataInizioProcedimento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDataInizioProcedimento.FieldName = "DataInizioProcedimento";
            this.colDataInizioProcedimento.Name = "colDataInizioProcedimento";
            this.colDataInizioProcedimento.OptionsColumn.AllowEdit = false;
            this.colDataInizioProcedimento.OptionsColumn.AllowFocus = false;
            this.colDataInizioProcedimento.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDataInizioProcedimento.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDataInizioProcedimento.OptionsColumn.AllowMove = false;
            this.colDataInizioProcedimento.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDataInizioProcedimento.OptionsFilter.AllowAutoFilter = false;
            this.colDataInizioProcedimento.OptionsFilter.AllowFilter = false;
            this.colDataInizioProcedimento.Visible = true;
            this.colDataInizioProcedimento.VisibleIndex = 1;
            this.colDataInizioProcedimento.Width = 91;
            // 
            // colDataFineTeorica
            // 
            this.colDataFineTeorica.Caption = "Data teorica fine";
            this.colDataFineTeorica.DisplayFormat.FormatString = "d";
            this.colDataFineTeorica.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDataFineTeorica.FieldName = "DataFineTeorica";
            this.colDataFineTeorica.Name = "colDataFineTeorica";
            this.colDataFineTeorica.OptionsColumn.AllowEdit = false;
            this.colDataFineTeorica.OptionsColumn.AllowFocus = false;
            this.colDataFineTeorica.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDataFineTeorica.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDataFineTeorica.OptionsColumn.AllowMove = false;
            this.colDataFineTeorica.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDataFineTeorica.OptionsFilter.AllowAutoFilter = false;
            this.colDataFineTeorica.OptionsFilter.AllowFilter = false;
            this.colDataFineTeorica.Visible = true;
            this.colDataFineTeorica.VisibleIndex = 2;
            this.colDataFineTeorica.Width = 131;
            // 
            // colIdTipoSospensione
            // 
            this.colIdTipoSospensione.Caption = "Tipo sospensione";
            this.colIdTipoSospensione.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colIdTipoSospensione.FieldName = "IdTipoSospensione";
            this.colIdTipoSospensione.Name = "colIdTipoSospensione";
            this.colIdTipoSospensione.OptionsColumn.AllowEdit = false;
            this.colIdTipoSospensione.OptionsColumn.AllowFocus = false;
            this.colIdTipoSospensione.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIdTipoSospensione.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colIdTipoSospensione.OptionsColumn.AllowMove = false;
            this.colIdTipoSospensione.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIdTipoSospensione.OptionsFilter.AllowAutoFilter = false;
            this.colIdTipoSospensione.OptionsFilter.AllowFilter = false;
            this.colIdTipoSospensione.Visible = true;
            this.colIdTipoSospensione.VisibleIndex = 3;
            this.colIdTipoSospensione.Width = 120;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.DataSource = this.bindingSourceTipiSospensioni;
            this.repositoryItemLookUpEdit2.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ValueMember = "IdElemento";
            // 
            // bindingSourceTipiSospensioni
            // 
            this.bindingSourceTipiSospensioni.AutoCreateObjects = false;
            this.bindingSourceTipiSospensioni.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // colDataRiattivazione
            // 
            this.colDataRiattivazione.Caption = "Data riattivazione";
            this.colDataRiattivazione.DisplayFormat.FormatString = "d";
            this.colDataRiattivazione.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDataRiattivazione.FieldName = "DataRiattivazione";
            this.colDataRiattivazione.Name = "colDataRiattivazione";
            this.colDataRiattivazione.OptionsColumn.AllowEdit = false;
            this.colDataRiattivazione.OptionsColumn.AllowFocus = false;
            this.colDataRiattivazione.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDataRiattivazione.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDataRiattivazione.OptionsColumn.AllowMove = false;
            this.colDataRiattivazione.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDataRiattivazione.OptionsFilter.AllowAutoFilter = false;
            this.colDataRiattivazione.OptionsFilter.AllowFilter = false;
            this.colDataRiattivazione.Visible = true;
            this.colDataRiattivazione.VisibleIndex = 4;
            this.colDataRiattivazione.Width = 96;
            // 
            // colDataTermineFinale
            // 
            this.colDataTermineFinale.Caption = "Data teorica termine finale";
            this.colDataTermineFinale.DisplayFormat.FormatString = "d";
            this.colDataTermineFinale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDataTermineFinale.FieldName = "DataTermineFinale";
            this.colDataTermineFinale.Name = "colDataTermineFinale";
            this.colDataTermineFinale.OptionsColumn.AllowEdit = false;
            this.colDataTermineFinale.OptionsColumn.AllowFocus = false;
            this.colDataTermineFinale.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDataTermineFinale.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDataTermineFinale.OptionsColumn.AllowMove = false;
            this.colDataTermineFinale.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDataTermineFinale.OptionsFilter.AllowAutoFilter = false;
            this.colDataTermineFinale.OptionsFilter.AllowFilter = false;
            this.colDataTermineFinale.Visible = true;
            this.colDataTermineFinale.VisibleIndex = 5;
            this.colDataTermineFinale.Width = 96;
            // 
            // colIdTipoConclusione
            // 
            this.colIdTipoConclusione.Caption = "Tipo conclusione";
            this.colIdTipoConclusione.ColumnEdit = this.repositoryItemLookUpEdit3;
            this.colIdTipoConclusione.FieldName = "IdTipoConclusione";
            this.colIdTipoConclusione.Name = "colIdTipoConclusione";
            this.colIdTipoConclusione.OptionsColumn.AllowEdit = false;
            this.colIdTipoConclusione.OptionsColumn.AllowFocus = false;
            this.colIdTipoConclusione.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIdTipoConclusione.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colIdTipoConclusione.OptionsColumn.AllowMove = false;
            this.colIdTipoConclusione.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIdTipoConclusione.OptionsFilter.AllowAutoFilter = false;
            this.colIdTipoConclusione.OptionsFilter.AllowFilter = false;
            this.colIdTipoConclusione.Visible = true;
            this.colIdTipoConclusione.VisibleIndex = 6;
            this.colIdTipoConclusione.Width = 149;
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.DataSource = this.bindingSourceTipiConclusioni;
            this.repositoryItemLookUpEdit3.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.ValueMember = "IdElemento";
            // 
            // bindingSourceTipiConclusioni
            // 
            this.bindingSourceTipiConclusioni.AutoCreateObjects = false;
            this.bindingSourceTipiConclusioni.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // colDataConclusione
            // 
            this.colDataConclusione.Caption = "Data conclusione";
            this.colDataConclusione.DisplayFormat.FormatString = "d";
            this.colDataConclusione.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDataConclusione.FieldName = "DataConclusione";
            this.colDataConclusione.Name = "colDataConclusione";
            this.colDataConclusione.OptionsColumn.AllowEdit = false;
            this.colDataConclusione.OptionsColumn.AllowFocus = false;
            this.colDataConclusione.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDataConclusione.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDataConclusione.OptionsColumn.AllowMove = false;
            this.colDataConclusione.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDataConclusione.OptionsFilter.AllowAutoFilter = false;
            this.colDataConclusione.OptionsFilter.AllowFilter = false;
            this.colDataConclusione.Visible = true;
            this.colDataConclusione.VisibleIndex = 7;
            this.colDataConclusione.Width = 93;
            // 
            // colStatoProcedimento
            // 
            this.colStatoProcedimento.Caption = "StatoProcedimento";
            this.colStatoProcedimento.FieldName = "StatoProcedimento";
            this.colStatoProcedimento.Name = "colStatoProcedimento";
            // 
            // colIdTipoIniziativa
            // 
            this.colIdTipoIniziativa.Caption = "IdTipoIniziativa";
            this.colIdTipoIniziativa.FieldName = "IdTipoIniziativa";
            this.colIdTipoIniziativa.Name = "colIdTipoIniziativa";
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.RotateWhenVertical = false;
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
            // barButtonItemEdit
            // 
            this.barButtonItemEdit.Caption = "Modifica";
            this.barButtonItemEdit.Id = 11;
            this.barButtonItemEdit.Name = "barButtonItemEdit";
            this.barButtonItemEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemEdit_ItemClick);
            // 
            // barButtonItemDelete
            // 
            this.barButtonItemDelete.Caption = "Cancella";
            this.barButtonItemDelete.Id = 10;
            this.barButtonItemDelete.Name = "barButtonItemDelete";
            this.barButtonItemDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDelete_ItemClick);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.lookUpEditStatus);
            this.panelControl3.Controls.Add(this.lookUpEdit3);
            this.panelControl3.Controls.Add(this.lookUpEdit2);
            this.panelControl3.Controls.Add(this.labelControl35);
            this.panelControl3.Controls.Add(this.labelControl34);
            this.panelControl3.Controls.Add(this.labelControl33);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(929, 39);
            this.panelControl3.TabIndex = 1;
            // 
            // lookUpEditStatus
            // 
            this.lookUpEditStatus.Location = new System.Drawing.Point(752, 10);
            this.lookUpEditStatus.Name = "lookUpEditStatus";
            this.lookUpEditStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditStatus.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descrizione", "Descrizione", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEditStatus.Properties.DataSource = this.bindingSourceBaseStati;
            this.lookUpEditStatus.Properties.DisplayMember = "Descrizione";
            this.lookUpEditStatus.Properties.NullText = "";
            this.lookUpEditStatus.Properties.ValueMember = "IdElemento";
            this.lookUpEditStatus.Size = new System.Drawing.Size(91, 20);
            this.lookUpEditStatus.TabIndex = 33;
            this.lookUpEditStatus.EditValueChanged += new System.EventHandler(this.lookUpEditStatus_EditValueChanged);
            // 
            // bindingSourceBaseStati
            // 
            this.bindingSourceBaseStati.AutoCreateObjects = false;
            this.bindingSourceBaseStati.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // lookUpEdit3
            // 
            this.lookUpEdit3.Location = new System.Drawing.Point(523, 10);
            this.lookUpEdit3.Name = "lookUpEdit3";
            this.lookUpEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit3.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descrizione", "Tipo iniziativa", 200)});
            this.lookUpEdit3.Properties.DataSource = this.bindingSourceTipiIniziative;
            this.lookUpEdit3.Properties.DisplayMember = "Descrizione";
            this.lookUpEdit3.Properties.NullText = "";
            this.lookUpEdit3.Properties.ValueMember = "IdElemento";
            this.lookUpEdit3.Size = new System.Drawing.Size(123, 20);
            this.lookUpEdit3.TabIndex = 33;
            this.lookUpEdit3.EditValueChanged += new System.EventHandler(this.lookUpEdit3_EditValueChanged);
            // 
            // bindingSourceTipiIniziative
            // 
            this.bindingSourceTipiIniziative.AutoCreateObjects = false;
            this.bindingSourceTipiIniziative.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.Location = new System.Drawing.Point(101, 10);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descrizione", "Tipo procedimento", 200)});
            this.lookUpEdit2.Properties.DataSource = this.bindingSourceTipiProcedimenti;
            this.lookUpEdit2.Properties.DisplayMember = "Descrizione";
            this.lookUpEdit2.Properties.NullText = "";
            this.lookUpEdit2.Properties.ValueMember = "IdElemento";
            this.lookUpEdit2.Size = new System.Drawing.Size(367, 20);
            this.lookUpEdit2.TabIndex = 33;
            this.lookUpEdit2.EditValueChanged += new System.EventHandler(this.lookUpEdit2_EditValueChanged);
            // 
            // labelControl35
            // 
            this.labelControl35.Location = new System.Drawing.Point(652, 13);
            this.labelControl35.Name = "labelControl35";
            this.labelControl35.Size = new System.Drawing.Size(94, 13);
            this.labelControl35.TabIndex = 0;
            this.labelControl35.Text = "Stato procedimento";
            // 
            // labelControl34
            // 
            this.labelControl34.Location = new System.Drawing.Point(474, 13);
            this.labelControl34.Name = "labelControl34";
            this.labelControl34.Size = new System.Drawing.Size(43, 13);
            this.labelControl34.TabIndex = 0;
            this.labelControl34.Text = "Iniziativa";
            // 
            // labelControl33
            // 
            this.labelControl33.Location = new System.Drawing.Point(7, 13);
            this.labelControl33.Name = "labelControl33";
            this.labelControl33.Size = new System.Drawing.Size(88, 13);
            this.labelControl33.TabIndex = 0;
            this.labelControl33.Text = "Tipo procedimento";
            // 
            // popupMenuProcedimenti
            // 
            this.popupMenuProcedimenti.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemDelete)});
            this.popupMenuProcedimenti.Manager = this.BarManager;
            this.popupMenuProcedimenti.Name = "popupMenuProcedimenti";
            // 
            // ProcedimentoDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ProcedimentoDetail";
            this.Size = new System.Drawing.Size(929, 433);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProcedimenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipiProcedimenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipiSospensioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipiConclusioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseStati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipiIniziative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuProcedimenti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlProcess;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProcess;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private OeF.Forms.Controls.PanelControl panelControl3;
        private it.dedagroup.GVC.Client.Forms.Controls.LookUpEdit lookUpEditStatus;
        private it.dedagroup.GVC.Client.Forms.Controls.LookUpEdit lookUpEdit3;
        private it.dedagroup.GVC.Client.Forms.Controls.LookUpEdit lookUpEdit2;
        private OeF.Forms.Controls.LabelControl labelControl35;
        private OeF.Forms.Controls.LabelControl labelControl34;
        private OeF.Forms.Controls.LabelControl labelControl33;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private OeF.Forms.BindingSourceBase bindingSourceBaseStati;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEdit;
        private OeF.Forms.BindingSourceBase bindingSourceTipiProcedimenti;
        private OeF.Forms.BindingSourceBase bindingSourceTipiSospensioni;
        private OeF.Forms.BindingSourceBase bindingSourceTipiConclusioni;
        private OeF.Forms.BindingSourceBase bindingSourceProcedimenti;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoProcedimento;
        private DevExpress.XtraGrid.Columns.GridColumn colDataInizioProcedimento;
        private DevExpress.XtraGrid.Columns.GridColumn colDataTermineFinale;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoSospensione;
        private DevExpress.XtraGrid.Columns.GridColumn colDataRiattivazione;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoConclusione;
        private DevExpress.XtraGrid.Columns.GridColumn colDataConclusione;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private OeF.Forms.BindingSourceBase bindingSourceTipiIniziative;
        private DevExpress.XtraBars.PopupMenu popupMenuProcedimenti;
        private DevExpress.XtraGrid.Columns.GridColumn colStatoProcedimento;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoIniziativa;
        private DevExpress.XtraGrid.Columns.GridColumn colDataFineTeorica;
    }
}
