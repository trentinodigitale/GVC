namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Sanzioni.ProceduraCoatta
{
    partial class ProceduraCoattaDetail
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
            this.gridControlForcedProcedure = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceForcedProcedure = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.gridViewForcedProcedure = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdForcedProcedureType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bindingSourceProceduresTypes = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.colNumeroDeliberaCommissione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataDeliberaCommissione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeterminaNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeterminaDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProcedureBeginDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataIscrizioneRI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProcedureExpirationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProcedureEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndjobDeterminaNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndjobDeterminaDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroDeliberaCommissioneFineIncarico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataDeliberaCommissioneFineIncarico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new OeF.Forms.Controls.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.commissionerDetail1 = new it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Sanzioni.Commissari.CommissarioDetail();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.commissionerLiquidationDetail1 = new it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Sanzioni.Commissari.LiquidazCompensoCommissarioDetail();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.documentationDetail1 = new it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Documentazione.DocumentazioneDetail();
            this.popupMenuProcedureCoatte = new DevExpress.XtraBars.PopupMenu(this.components);
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.documentazioneFileSystemDetail1 = new it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.DocumentazioneFileSystem.DocumentazioneFileSystemDetail();
            ((System.ComponentModel.ISupportInitialize)(this.PanelTop)).BeginInit();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelBottom)).BeginInit();
            this.PanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlForcedProcedure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceForcedProcedure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewForcedProcedure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProceduresTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuProcedureCoatte)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.gridControlForcedProcedure);
            this.PanelTop.Size = new System.Drawing.Size(758, 124);
            // 
            // PanelBottom
            // 
            this.PanelBottom.Controls.Add(this.xtraTabControl1);
            this.PanelBottom.Location = new System.Drawing.Point(0, 130);
            this.PanelBottom.Size = new System.Drawing.Size(758, 255);
            // 
            // Splitter
            // 
            this.Splitter.Location = new System.Drawing.Point(0, 124);
            this.Splitter.Size = new System.Drawing.Size(758, 6);
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
            this.ScrollableContent.Location = new System.Drawing.Point(0, 49);
            this.ScrollableContent.Size = new System.Drawing.Size(758, 385);
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.OptionsColumn.AllowEdit = false;
            this.colStatus.OptionsColumn.AllowFocus = false;
            this.colStatus.OptionsColumn.AllowMove = false;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 3";
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
            this.bar1.Text = "Custom 3";
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
            // gridControlForcedProcedure
            // 
            this.gridControlForcedProcedure.DataSource = this.bindingSourceForcedProcedure;
            this.gridControlForcedProcedure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlForcedProcedure.Location = new System.Drawing.Point(0, 0);
            this.gridControlForcedProcedure.MainView = this.gridViewForcedProcedure;
            this.gridControlForcedProcedure.Name = "gridControlForcedProcedure";
            this.gridControlForcedProcedure.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControlForcedProcedure.Size = new System.Drawing.Size(758, 124);
            this.gridControlForcedProcedure.TabIndex = 6;
            this.gridControlForcedProcedure.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewForcedProcedure,
            this.gridView2});
            this.gridControlForcedProcedure.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlForcedProcedure_MouseDoubleClick);
            // 
            // bindingSourceForcedProcedure
            // 
            this.bindingSourceForcedProcedure.AutoCreateObjects = false;
            this.bindingSourceForcedProcedure.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.ProceduraCoattaFDT);
            this.bindingSourceForcedProcedure.CurrentChanged += new System.EventHandler(this.bindingSourceForcedProcedure_CurrentChanged);
            // 
            // gridViewForcedProcedure
            // 
            this.gridViewForcedProcedure.ColumnPanelRowHeight = 40;
            this.gridViewForcedProcedure.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdForcedProcedureType,
            this.colNumeroDeliberaCommissione,
            this.colDataDeliberaCommissione,
            this.colDeterminaNumber,
            this.colDeterminaDate,
            this.colProcedureBeginDate,
            this.colDataIscrizioneRI,
            this.colProcedureExpirationDate,
            this.colProcedureEndDate,
            this.colEndjobDeterminaNumber,
            this.colEndjobDeterminaDate,
            this.colNumeroDeliberaCommissioneFineIncarico,
            this.colDataDeliberaCommissioneFineIncarico,
            this.colStatus});
            this.gridViewForcedProcedure.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout);
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colStatus;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual;
            styleFormatCondition1.Value1 = "100";
            this.gridViewForcedProcedure.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridViewForcedProcedure.GridControl = this.gridControlForcedProcedure;
            this.gridViewForcedProcedure.Name = "gridViewForcedProcedure";
            this.gridViewForcedProcedure.OptionsBehavior.Editable = false;
            this.gridViewForcedProcedure.OptionsCustomization.AllowSort = false;
            this.gridViewForcedProcedure.OptionsMenu.EnableColumnMenu = false;
            this.gridViewForcedProcedure.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewForcedProcedure.OptionsView.ShowGroupPanel = false;
            this.gridViewForcedProcedure.OptionsView.ShowIndicator = false;
            this.gridViewForcedProcedure.ShowGridMenu += new DevExpress.XtraGrid.Views.Grid.GridMenuEventHandler(this.gridViewForcedProcedure_ShowGridMenu);
            // 
            // colIdForcedProcedureType
            // 
            this.colIdForcedProcedureType.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdForcedProcedureType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdForcedProcedureType.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colIdForcedProcedureType.Caption = "Tipo";
            this.colIdForcedProcedureType.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colIdForcedProcedureType.FieldName = "IdTipoProceduraCoatta";
            this.colIdForcedProcedureType.Name = "colIdForcedProcedureType";
            this.colIdForcedProcedureType.OptionsColumn.AllowEdit = false;
            this.colIdForcedProcedureType.OptionsColumn.AllowFocus = false;
            this.colIdForcedProcedureType.OptionsColumn.AllowMove = false;
            this.colIdForcedProcedureType.Visible = true;
            this.colIdForcedProcedureType.VisibleIndex = 0;
            this.colIdForcedProcedureType.Width = 60;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.bindingSourceProceduresTypes;
            this.repositoryItemLookUpEdit1.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "IdElemento";
            // 
            // bindingSourceProceduresTypes
            // 
            this.bindingSourceProceduresTypes.AutoCreateObjects = false;
            this.bindingSourceProceduresTypes.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // colNumeroDeliberaCommissione
            // 
            this.colNumeroDeliberaCommissione.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumeroDeliberaCommissione.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumeroDeliberaCommissione.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colNumeroDeliberaCommissione.Caption = "Nr. delibera";
            this.colNumeroDeliberaCommissione.FieldName = "NumeroDeliberaCommissione";
            this.colNumeroDeliberaCommissione.Name = "colNumeroDeliberaCommissione";
            this.colNumeroDeliberaCommissione.OptionsColumn.AllowEdit = false;
            this.colNumeroDeliberaCommissione.OptionsColumn.AllowFocus = false;
            this.colNumeroDeliberaCommissione.OptionsColumn.AllowMove = false;
            this.colNumeroDeliberaCommissione.Visible = true;
            this.colNumeroDeliberaCommissione.VisibleIndex = 1;
            this.colNumeroDeliberaCommissione.Width = 71;
            // 
            // colDataDeliberaCommissione
            // 
            this.colDataDeliberaCommissione.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataDeliberaCommissione.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataDeliberaCommissione.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colDataDeliberaCommissione.Caption = "Data delibera";
            this.colDataDeliberaCommissione.DisplayFormat.FormatString = "d";
            this.colDataDeliberaCommissione.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDataDeliberaCommissione.FieldName = "DataDeliberaCommissione";
            this.colDataDeliberaCommissione.Name = "colDataDeliberaCommissione";
            this.colDataDeliberaCommissione.OptionsColumn.AllowEdit = false;
            this.colDataDeliberaCommissione.OptionsColumn.AllowFocus = false;
            this.colDataDeliberaCommissione.OptionsColumn.AllowMove = false;
            this.colDataDeliberaCommissione.Visible = true;
            this.colDataDeliberaCommissione.VisibleIndex = 2;
            this.colDataDeliberaCommissione.Width = 68;
            // 
            // colDeterminaNumber
            // 
            this.colDeterminaNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colDeterminaNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDeterminaNumber.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colDeterminaNumber.Caption = "Nr. determina";
            this.colDeterminaNumber.FieldName = "NumeroDetermina";
            this.colDeterminaNumber.Name = "colDeterminaNumber";
            this.colDeterminaNumber.OptionsColumn.AllowEdit = false;
            this.colDeterminaNumber.OptionsColumn.AllowFocus = false;
            this.colDeterminaNumber.OptionsColumn.AllowMove = false;
            this.colDeterminaNumber.Visible = true;
            this.colDeterminaNumber.VisibleIndex = 3;
            this.colDeterminaNumber.Width = 77;
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
            this.colDeterminaDate.VisibleIndex = 4;
            this.colDeterminaDate.Width = 68;
            // 
            // colProcedureBeginDate
            // 
            this.colProcedureBeginDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colProcedureBeginDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProcedureBeginDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colProcedureBeginDate.Caption = "Inizio procedura";
            this.colProcedureBeginDate.DisplayFormat.FormatString = "d";
            this.colProcedureBeginDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colProcedureBeginDate.FieldName = "DataInzioProcedura";
            this.colProcedureBeginDate.Name = "colProcedureBeginDate";
            this.colProcedureBeginDate.OptionsColumn.AllowEdit = false;
            this.colProcedureBeginDate.OptionsColumn.AllowFocus = false;
            this.colProcedureBeginDate.OptionsColumn.AllowMove = false;
            this.colProcedureBeginDate.Visible = true;
            this.colProcedureBeginDate.VisibleIndex = 5;
            this.colProcedureBeginDate.Width = 70;
            // 
            // colDataIscrizioneRI
            // 
            this.colDataIscrizioneRI.Caption = "Data Iscrizione R.I.";
            this.colDataIscrizioneRI.DisplayFormat.FormatString = "d";
            this.colDataIscrizioneRI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDataIscrizioneRI.FieldName = "DataIscrizioneRI";
            this.colDataIscrizioneRI.Name = "colDataIscrizioneRI";
            this.colDataIscrizioneRI.OptionsColumn.AllowEdit = false;
            this.colDataIscrizioneRI.OptionsColumn.AllowFocus = false;
            this.colDataIscrizioneRI.OptionsColumn.AllowMove = false;
            this.colDataIscrizioneRI.Visible = true;
            this.colDataIscrizioneRI.VisibleIndex = 6;
            // 
            // colProcedureExpirationDate
            // 
            this.colProcedureExpirationDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colProcedureExpirationDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProcedureExpirationDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colProcedureExpirationDate.Caption = "Scadenza procedura";
            this.colProcedureExpirationDate.DisplayFormat.FormatString = "d";
            this.colProcedureExpirationDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colProcedureExpirationDate.FieldName = "DataScadenzaProcedura";
            this.colProcedureExpirationDate.Name = "colProcedureExpirationDate";
            this.colProcedureExpirationDate.OptionsColumn.AllowEdit = false;
            this.colProcedureExpirationDate.OptionsColumn.AllowFocus = false;
            this.colProcedureExpirationDate.OptionsColumn.AllowMove = false;
            this.colProcedureExpirationDate.Visible = true;
            this.colProcedureExpirationDate.VisibleIndex = 7;
            this.colProcedureExpirationDate.Width = 69;
            // 
            // colProcedureEndDate
            // 
            this.colProcedureEndDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colProcedureEndDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProcedureEndDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colProcedureEndDate.Caption = "Conclusione";
            this.colProcedureEndDate.DisplayFormat.FormatString = "d";
            this.colProcedureEndDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colProcedureEndDate.FieldName = "DataFineProcedura";
            this.colProcedureEndDate.Name = "colProcedureEndDate";
            this.colProcedureEndDate.OptionsColumn.AllowEdit = false;
            this.colProcedureEndDate.OptionsColumn.AllowFocus = false;
            this.colProcedureEndDate.OptionsColumn.AllowMove = false;
            this.colProcedureEndDate.Visible = true;
            this.colProcedureEndDate.VisibleIndex = 8;
            this.colProcedureEndDate.Width = 81;
            // 
            // colEndjobDeterminaNumber
            // 
            this.colEndjobDeterminaNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colEndjobDeterminaNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEndjobDeterminaNumber.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colEndjobDeterminaNumber.Caption = "Nr.determina fine inc.";
            this.colEndjobDeterminaNumber.FieldName = "NumeroDeterminaFineIncarico";
            this.colEndjobDeterminaNumber.Name = "colEndjobDeterminaNumber";
            this.colEndjobDeterminaNumber.OptionsColumn.AllowEdit = false;
            this.colEndjobDeterminaNumber.OptionsColumn.AllowFocus = false;
            this.colEndjobDeterminaNumber.OptionsColumn.AllowMove = false;
            this.colEndjobDeterminaNumber.Visible = true;
            this.colEndjobDeterminaNumber.VisibleIndex = 9;
            this.colEndjobDeterminaNumber.Width = 76;
            // 
            // colEndjobDeterminaDate
            // 
            this.colEndjobDeterminaDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colEndjobDeterminaDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEndjobDeterminaDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colEndjobDeterminaDate.Caption = "Data determina fine inc.";
            this.colEndjobDeterminaDate.DisplayFormat.FormatString = "d";
            this.colEndjobDeterminaDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colEndjobDeterminaDate.FieldName = "DataDeterminaFineIncarico";
            this.colEndjobDeterminaDate.Name = "colEndjobDeterminaDate";
            this.colEndjobDeterminaDate.OptionsColumn.AllowEdit = false;
            this.colEndjobDeterminaDate.OptionsColumn.AllowFocus = false;
            this.colEndjobDeterminaDate.OptionsColumn.AllowMove = false;
            this.colEndjobDeterminaDate.Visible = true;
            this.colEndjobDeterminaDate.VisibleIndex = 10;
            this.colEndjobDeterminaDate.Width = 73;
            // 
            // colNumeroDeliberaCommissioneFineIncarico
            // 
            this.colNumeroDeliberaCommissioneFineIncarico.Caption = "Nr.delibera fine inc.";
            this.colNumeroDeliberaCommissioneFineIncarico.FieldName = "NumeroDeliberaCommissioneFineIncarico";
            this.colNumeroDeliberaCommissioneFineIncarico.Name = "colNumeroDeliberaCommissioneFineIncarico";
            this.colNumeroDeliberaCommissioneFineIncarico.OptionsColumn.AllowEdit = false;
            this.colNumeroDeliberaCommissioneFineIncarico.OptionsColumn.AllowFocus = false;
            this.colNumeroDeliberaCommissioneFineIncarico.OptionsColumn.AllowMove = false;
            this.colNumeroDeliberaCommissioneFineIncarico.Visible = true;
            this.colNumeroDeliberaCommissioneFineIncarico.VisibleIndex = 11;
            // 
            // colDataDeliberaCommissioneFineIncarico
            // 
            this.colDataDeliberaCommissioneFineIncarico.Caption = "Data delibera fine inc.";
            this.colDataDeliberaCommissioneFineIncarico.DisplayFormat.FormatString = "d";
            this.colDataDeliberaCommissioneFineIncarico.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDataDeliberaCommissioneFineIncarico.FieldName = "DataDeliberaCommissioneFineIncarico";
            this.colDataDeliberaCommissioneFineIncarico.Name = "colDataDeliberaCommissioneFineIncarico";
            this.colDataDeliberaCommissioneFineIncarico.OptionsColumn.AllowEdit = false;
            this.colDataDeliberaCommissioneFineIncarico.OptionsColumn.AllowFocus = false;
            this.colDataDeliberaCommissioneFineIncarico.OptionsColumn.AllowMove = false;
            this.colDataDeliberaCommissioneFineIncarico.Visible = true;
            this.colDataDeliberaCommissioneFineIncarico.VisibleIndex = 12;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControlForcedProcedure;
            this.gridView2.Name = "gridView2";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTabControl1.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(758, 255);
            this.xtraTabControl1.TabIndex = 7;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage3,
            this.xtraTabPage2,
            this.xtraTabPage4});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.commissionerDetail1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(749, 224);
            this.xtraTabPage1.Text = "Commissari";
            // 
            // commissionerDetail1
            // 
            this.commissionerDetail1.ApplicationTitle = "";
            this.commissionerDetail1.ConfirmCancel = true;
            this.commissionerDetail1.ConfirmCancelMessage = "";
            this.commissionerDetail1.CurrentSequenceID = null;
            this.commissionerDetail1.CurrentTaskID = null;
            this.commissionerDetail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commissionerDetail1.IsShowing = false;
            this.commissionerDetail1.Location = new System.Drawing.Point(0, 0);
            this.commissionerDetail1.Name = "commissionerDetail1";
            this.commissionerDetail1.PageCaption = "";
            this.commissionerDetail1.ReadOnlyControls = true;
            this.commissionerDetail1.Size = new System.Drawing.Size(749, 224);
            this.commissionerDetail1.TabIndex = 0;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.commissionerLiquidationDetail1);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(791, 439);
            this.xtraTabPage3.Text = "Liquidazione compensi commissari";
            // 
            // commissionerLiquidationDetail1
            // 
            this.commissionerLiquidationDetail1.ApplicationTitle = "";
            this.commissionerLiquidationDetail1.ConfirmCancel = true;
            this.commissionerLiquidationDetail1.ConfirmCancelMessage = "";
            this.commissionerLiquidationDetail1.CurrentSequenceID = null;
            this.commissionerLiquidationDetail1.CurrentTaskID = null;
            this.commissionerLiquidationDetail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commissionerLiquidationDetail1.IsShowing = false;
            this.commissionerLiquidationDetail1.Location = new System.Drawing.Point(0, 0);
            this.commissionerLiquidationDetail1.Name = "commissionerLiquidationDetail1";
            this.commissionerLiquidationDetail1.PageCaption = "";
            this.commissionerLiquidationDetail1.ReadOnlyControls = true;
            this.commissionerLiquidationDetail1.Size = new System.Drawing.Size(791, 439);
            this.commissionerLiquidationDetail1.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.documentationDetail1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(791, 439);
            this.xtraTabPage2.Text = "Documentazione";
            // 
            // documentationDetail1
            // 
            this.documentationDetail1.ApplicationTitle = "";
            this.documentationDetail1.ConfirmCancel = true;
            this.documentationDetail1.ConfirmCancelMessage = "";
            this.documentationDetail1.CurrentSequenceID = null;
            this.documentationDetail1.CurrentTaskID = null;
            this.documentationDetail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentationDetail1.IsGeneral = false;
            this.documentationDetail1.IsShowing = false;
            this.documentationDetail1.Location = new System.Drawing.Point(0, 0);
            this.documentationDetail1.Name = "documentationDetail1";
            this.documentationDetail1.PageCaption = "";
            this.documentationDetail1.ReadOnlyControls = true;
            this.documentationDetail1.Size = new System.Drawing.Size(791, 439);
            this.documentationDetail1.TabIndex = 0;
            // 
            // popupMenuProcedureCoatte
            // 
            this.popupMenuProcedureCoatte.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemModify),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemDelete)});
            this.popupMenuProcedureCoatte.Manager = this.BarManager;
            this.popupMenuProcedureCoatte.Name = "popupMenuProcedureCoatte";
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.documentazioneFileSystemDetail1);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(749, 224);
            this.xtraTabPage4.Text = "Documenti vigilanza";
            // 
            // documentazioneFileSystemDetail1
            // 
            this.documentazioneFileSystemDetail1.ApplicationTitle = "";
            this.documentazioneFileSystemDetail1.ConfirmCancel = true;
            this.documentazioneFileSystemDetail1.ConfirmCancelMessage = "";
            this.documentazioneFileSystemDetail1.CurrentSequenceID = null;
            this.documentazioneFileSystemDetail1.CurrentTaskID = null;
            this.documentazioneFileSystemDetail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentazioneFileSystemDetail1.IsShowing = false;
            this.documentazioneFileSystemDetail1.Location = new System.Drawing.Point(0, 0);
            this.documentazioneFileSystemDetail1.Name = "documentazioneFileSystemDetail1";
            this.documentazioneFileSystemDetail1.PageCaption = "";
            this.documentazioneFileSystemDetail1.ReadOnlyControls = true;
            this.documentazioneFileSystemDetail1.Size = new System.Drawing.Size(749, 224);
            this.documentazioneFileSystemDetail1.TabIndex = 0;
            // 
            // ProceduraCoattaDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ProceduraCoattaDetail";
            this.Size = new System.Drawing.Size(758, 434);
            ((System.ComponentModel.ISupportInitialize)(this.PanelTop)).EndInit();
            this.PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelBottom)).EndInit();
            this.PanelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlForcedProcedure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceForcedProcedure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewForcedProcedure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProceduresTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuProcedureCoatte)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraGrid.GridControl gridControlForcedProcedure;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewForcedProcedure;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceForcedProcedure;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroDeliberaCommissione;
        private OeF.Forms.Controls.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Documentazione.DocumentazioneDetail documentationDetail1;
        private DevExpress.XtraGrid.Columns.GridColumn colDeterminaNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDeterminaDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDataDeliberaCommissione;
        private DevExpress.XtraGrid.Columns.GridColumn colProcedureBeginDate;
        private DevExpress.XtraGrid.Columns.GridColumn colProcedureExpirationDate;
        private DevExpress.XtraGrid.Columns.GridColumn colProcedureEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEndjobDeterminaNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colEndjobDeterminaDate;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Sanzioni.Commissari.CommissarioDetail commissionerDetail1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceProceduresTypes;
        private DevExpress.XtraGrid.Columns.GridColumn colIdForcedProcedureType;
        private it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Sanzioni.Commissari.LiquidazCompensoCommissarioDetail commissionerLiquidationDetail1;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroDeliberaCommissioneFineIncarico;
        private DevExpress.XtraGrid.Columns.GridColumn colDataDeliberaCommissioneFineIncarico;
        private DevExpress.XtraGrid.Columns.GridColumn colDataIscrizioneRI;
        private DevExpress.XtraBars.BarButtonItem barButtonItemModify;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraBars.PopupMenu popupMenuProcedureCoatte;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.DocumentazioneFileSystem.DocumentazioneFileSystemDetail documentazioneFileSystemDetail1;
    }
}
