namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.PositionAndBase.ComunicazioneBaseSoc
{
    partial class ComunicazioneBaseSocDetail
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
            this.gridControlCommunicationBase = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceBaseComunicazioneBase = new OeF.Forms.BindingSourceBase(this.components);
            this.gridViewCommunicationBase = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDataComunicazione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataSituazione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotaleSoci = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSociCooperatori = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSociSovventori = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLavoratori = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLavoratoriSoci = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoConferimentoCapitale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bindingSourceBaseTipiConferimentoCapitale = new OeF.Forms.BindingSourceBase(this.components);
            this.colValoreMinimoQuote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCapitaleSottoscritto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCapitaleVersato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemModify = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.xtraTabControl1 = new it.dedagroup.GVC.Client.Forms.Controls.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.documentationDetail1 = new it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Documentazione.DocumentazioneDetail();
            this.popupMenuComunicazioneBase = new DevExpress.XtraBars.PopupMenu(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.documentazioneFileSystemDetail1 = new it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.DocumentazioneFileSystem.DocumentazioneFileSystemDetail();
            ((System.ComponentModel.ISupportInitialize)(this.PanelTop)).BeginInit();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelBottom)).BeginInit();
            this.PanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCommunicationBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseComunicazioneBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCommunicationBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseTipiConferimentoCapitale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuComunicazioneBase)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.gridControlCommunicationBase);
            this.PanelTop.Size = new System.Drawing.Size(614, 151);
            // 
            // PanelBottom
            // 
            this.PanelBottom.Controls.Add(this.xtraTabControl1);
            this.PanelBottom.Location = new System.Drawing.Point(0, 157);
            this.PanelBottom.Size = new System.Drawing.Size(614, 260);
            // 
            // Splitter
            // 
            this.Splitter.Location = new System.Drawing.Point(0, 151);
            this.Splitter.Size = new System.Drawing.Size(614, 6);
            // 
            // BarManager
            // 
            this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemAdd,
            this.barButtonItemDelete,
            this.barButtonItemModify});
            this.BarManager.MaxItemId = 15;
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Location = new System.Drawing.Point(0, 49);
            this.ScrollableContent.Size = new System.Drawing.Size(614, 417);
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // gridControlCommunicationBase
            // 
            this.gridControlCommunicationBase.DataSource = this.bindingSourceBaseComunicazioneBase;
            this.gridControlCommunicationBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCommunicationBase.Location = new System.Drawing.Point(0, 0);
            this.gridControlCommunicationBase.MainView = this.gridViewCommunicationBase;
            this.gridControlCommunicationBase.Name = "gridControlCommunicationBase";
            this.gridControlCommunicationBase.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControlCommunicationBase.Size = new System.Drawing.Size(614, 151);
            this.gridControlCommunicationBase.TabIndex = 0;
            this.gridControlCommunicationBase.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCommunicationBase});
            this.gridControlCommunicationBase.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlCommunicationBase_MouseDoubleClick);
            // 
            // bindingSourceBaseComunicazioneBase
            // 
            this.bindingSourceBaseComunicazioneBase.AutoCreateObjects = false;
            this.bindingSourceBaseComunicazioneBase.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.ComunicazioneBaseSocialeFDT);
            this.bindingSourceBaseComunicazioneBase.CurrentChanged += new System.EventHandler(this.bindingSourceBaseCommunicationBase_CurrentChanged);
            // 
            // gridViewCommunicationBase
            // 
            this.gridViewCommunicationBase.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewCommunicationBase.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewCommunicationBase.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDataComunicazione,
            this.colDataSituazione,
            this.colTotaleSoci,
            this.colSociCooperatori,
            this.colSociSovventori,
            this.colLavoratori,
            this.colLavoratoriSoci,
            this.colTipoConferimentoCapitale,
            this.colValoreMinimoQuote,
            this.colCapitaleSottoscritto,
            this.colCapitaleVersato,
            this.colStatus});
            styleFormatCondition2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout);
            styleFormatCondition2.Appearance.Options.UseFont = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colStatus;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual;
            styleFormatCondition2.Value1 = "100";
            this.gridViewCommunicationBase.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition2});
            this.gridViewCommunicationBase.GridControl = this.gridControlCommunicationBase;
            this.gridViewCommunicationBase.Name = "gridViewCommunicationBase";
            this.gridViewCommunicationBase.OptionsBehavior.Editable = false;
            this.gridViewCommunicationBase.OptionsMenu.EnableColumnMenu = false;
            this.gridViewCommunicationBase.OptionsMenu.EnableFooterMenu = false;
            this.gridViewCommunicationBase.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewCommunicationBase.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewCommunicationBase.OptionsView.ShowGroupPanel = false;
            this.gridViewCommunicationBase.OptionsView.ShowIndicator = false;
            this.gridViewCommunicationBase.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDataComunicazione, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridViewCommunicationBase.ShowGridMenu += new DevExpress.XtraGrid.Views.Grid.GridMenuEventHandler(this.gridViewCommunicationBase_ShowGridMenu);
            // 
            // colDataComunicazione
            // 
            this.colDataComunicazione.Caption = "Comunicazione del";
            this.colDataComunicazione.DisplayFormat.FormatString = "d";
            this.colDataComunicazione.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDataComunicazione.FieldName = "DataComunicazione";
            this.colDataComunicazione.Name = "colDataComunicazione";
            this.colDataComunicazione.OptionsColumn.AllowEdit = false;
            this.colDataComunicazione.OptionsColumn.AllowFocus = false;
            this.colDataComunicazione.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDataComunicazione.OptionsColumn.AllowMove = false;
            this.colDataComunicazione.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDataComunicazione.OptionsFilter.AllowAutoFilter = false;
            this.colDataComunicazione.OptionsFilter.AllowFilter = false;
            this.colDataComunicazione.Visible = true;
            this.colDataComunicazione.VisibleIndex = 0;
            this.colDataComunicazione.Width = 95;
            // 
            // colDataSituazione
            // 
            this.colDataSituazione.Caption = "Situazione al";
            this.colDataSituazione.DisplayFormat.FormatString = "d";
            this.colDataSituazione.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDataSituazione.FieldName = "DataSituazione";
            this.colDataSituazione.Name = "colDataSituazione";
            this.colDataSituazione.OptionsColumn.AllowEdit = false;
            this.colDataSituazione.OptionsColumn.AllowFocus = false;
            this.colDataSituazione.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDataSituazione.OptionsColumn.AllowMove = false;
            this.colDataSituazione.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDataSituazione.OptionsFilter.AllowAutoFilter = false;
            this.colDataSituazione.OptionsFilter.AllowFilter = false;
            this.colDataSituazione.Visible = true;
            this.colDataSituazione.VisibleIndex = 1;
            this.colDataSituazione.Width = 83;
            // 
            // colTotaleSoci
            // 
            this.colTotaleSoci.Caption = "Totale numero soci";
            this.colTotaleSoci.FieldName = "TotaleSoci";
            this.colTotaleSoci.Name = "colTotaleSoci";
            this.colTotaleSoci.OptionsColumn.AllowEdit = false;
            this.colTotaleSoci.OptionsColumn.AllowFocus = false;
            this.colTotaleSoci.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colTotaleSoci.OptionsColumn.AllowMove = false;
            this.colTotaleSoci.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTotaleSoci.OptionsFilter.AllowAutoFilter = false;
            this.colTotaleSoci.OptionsFilter.AllowFilter = false;
            this.colTotaleSoci.Width = 64;
            // 
            // colSociCooperatori
            // 
            this.colSociCooperatori.AppearanceHeader.Options.UseTextOptions = true;
            this.colSociCooperatori.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSociCooperatori.Caption = "Soci cooperatori";
            this.colSociCooperatori.FieldName = "SociCooperatori";
            this.colSociCooperatori.Name = "colSociCooperatori";
            this.colSociCooperatori.Visible = true;
            this.colSociCooperatori.VisibleIndex = 3;
            this.colSociCooperatori.Width = 117;
            // 
            // colSociSovventori
            // 
            this.colSociSovventori.AppearanceHeader.Options.UseTextOptions = true;
            this.colSociSovventori.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSociSovventori.Caption = "Soci sovventori";
            this.colSociSovventori.FieldName = "SociSovventori";
            this.colSociSovventori.Name = "colSociSovventori";
            this.colSociSovventori.Visible = true;
            this.colSociSovventori.VisibleIndex = 2;
            this.colSociSovventori.Width = 112;
            // 
            // colLavoratori
            // 
            this.colLavoratori.Caption = "Tot lavoratori";
            this.colLavoratori.FieldName = "Lavoratori";
            this.colLavoratori.Name = "colLavoratori";
            this.colLavoratori.OptionsColumn.AllowEdit = false;
            this.colLavoratori.OptionsColumn.AllowFocus = false;
            this.colLavoratori.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colLavoratori.OptionsColumn.AllowMove = false;
            this.colLavoratori.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colLavoratori.OptionsFilter.AllowAutoFilter = false;
            this.colLavoratori.OptionsFilter.AllowFilter = false;
            this.colLavoratori.Visible = true;
            this.colLavoratori.VisibleIndex = 4;
            this.colLavoratori.Width = 110;
            // 
            // colLavoratoriSoci
            // 
            this.colLavoratoriSoci.Caption = "Totale numero lavoratori di cui soci";
            this.colLavoratoriSoci.FieldName = "LavoratoriSoci";
            this.colLavoratoriSoci.Name = "colLavoratoriSoci";
            this.colLavoratoriSoci.OptionsColumn.AllowEdit = false;
            this.colLavoratoriSoci.OptionsColumn.AllowFocus = false;
            this.colLavoratoriSoci.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colLavoratoriSoci.OptionsColumn.AllowMove = false;
            this.colLavoratoriSoci.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colLavoratoriSoci.OptionsFilter.AllowAutoFilter = false;
            this.colLavoratoriSoci.OptionsFilter.AllowFilter = false;
            this.colLavoratoriSoci.Width = 93;
            // 
            // colTipoConferimentoCapitale
            // 
            this.colTipoConferimentoCapitale.Caption = "Conferimento capitale";
            this.colTipoConferimentoCapitale.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colTipoConferimentoCapitale.FieldName = "TipoConferimentoCapitale";
            this.colTipoConferimentoCapitale.Name = "colTipoConferimentoCapitale";
            this.colTipoConferimentoCapitale.OptionsColumn.AllowEdit = false;
            this.colTipoConferimentoCapitale.OptionsColumn.AllowFocus = false;
            this.colTipoConferimentoCapitale.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colTipoConferimentoCapitale.OptionsColumn.AllowMove = false;
            this.colTipoConferimentoCapitale.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTipoConferimentoCapitale.OptionsFilter.AllowAutoFilter = false;
            this.colTipoConferimentoCapitale.OptionsFilter.AllowFilter = false;
            this.colTipoConferimentoCapitale.Width = 68;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.bindingSourceBaseTipiConferimentoCapitale;
            this.repositoryItemLookUpEdit1.DisplayMember = "Value";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "Key";
            // 
            // bindingSourceBaseTipiConferimentoCapitale
            // 
            this.bindingSourceBaseTipiConferimentoCapitale.AutoCreateObjects = false;
            this.bindingSourceBaseTipiConferimentoCapitale.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // colValoreMinimoQuote
            // 
            this.colValoreMinimoQuote.Caption = "Valore azioni/min. quote";
            this.colValoreMinimoQuote.DisplayFormat.FormatString = "{0:N2}";
            this.colValoreMinimoQuote.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValoreMinimoQuote.FieldName = "ValoreMinimoQuote";
            this.colValoreMinimoQuote.Name = "colValoreMinimoQuote";
            this.colValoreMinimoQuote.OptionsColumn.AllowEdit = false;
            this.colValoreMinimoQuote.OptionsColumn.AllowFocus = false;
            this.colValoreMinimoQuote.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colValoreMinimoQuote.OptionsColumn.AllowMove = false;
            this.colValoreMinimoQuote.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colValoreMinimoQuote.OptionsFilter.AllowAutoFilter = false;
            this.colValoreMinimoQuote.OptionsFilter.AllowFilter = false;
            // 
            // colCapitaleSottoscritto
            // 
            this.colCapitaleSottoscritto.Caption = "Capitale sottoscritto";
            this.colCapitaleSottoscritto.DisplayFormat.FormatString = "{0:N2}";
            this.colCapitaleSottoscritto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCapitaleSottoscritto.FieldName = "CapitaleSottoscritto";
            this.colCapitaleSottoscritto.Name = "colCapitaleSottoscritto";
            this.colCapitaleSottoscritto.OptionsColumn.AllowEdit = false;
            this.colCapitaleSottoscritto.OptionsColumn.AllowFocus = false;
            this.colCapitaleSottoscritto.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCapitaleSottoscritto.OptionsColumn.AllowMove = false;
            this.colCapitaleSottoscritto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCapitaleSottoscritto.OptionsFilter.AllowAutoFilter = false;
            this.colCapitaleSottoscritto.OptionsFilter.AllowFilter = false;
            this.colCapitaleSottoscritto.Width = 90;
            // 
            // colCapitaleVersato
            // 
            this.colCapitaleVersato.Caption = "Capitale versato";
            this.colCapitaleVersato.DisplayFormat.FormatString = "{0:N2}";
            this.colCapitaleVersato.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCapitaleVersato.FieldName = "CapitaleVersato";
            this.colCapitaleVersato.Name = "colCapitaleVersato";
            this.colCapitaleVersato.OptionsColumn.AllowEdit = false;
            this.colCapitaleVersato.OptionsColumn.AllowFocus = false;
            this.colCapitaleVersato.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCapitaleVersato.OptionsColumn.AllowMove = false;
            this.colCapitaleVersato.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCapitaleVersato.OptionsFilter.AllowAutoFilter = false;
            this.colCapitaleVersato.OptionsFilter.AllowFilter = false;
            this.colCapitaleVersato.Width = 89;
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
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(614, 260);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.documentationDetail1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(605, 229);
            this.xtraTabPage1.Text = "Documentazione";
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
            this.documentationDetail1.Size = new System.Drawing.Size(605, 229);
            this.documentationDetail1.TabIndex = 0;
            // 
            // popupMenuComunicazioneBase
            // 
            this.popupMenuComunicazioneBase.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemModify),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemDelete)});
            this.popupMenuComunicazioneBase.Manager = this.BarManager;
            this.popupMenuComunicazioneBase.Name = "popupMenuComunicazioneBase";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.documentazioneFileSystemDetail1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(605, 229);
            this.xtraTabPage2.Text = "Documenti vigilanza";
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
            this.documentazioneFileSystemDetail1.Size = new System.Drawing.Size(605, 229);
            this.documentazioneFileSystemDetail1.TabIndex = 0;
            // 
            // ComunicazioneBaseSocDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ComunicazioneBaseSocDetail";
            this.Size = new System.Drawing.Size(614, 466);
            ((System.ComponentModel.ISupportInitialize)(this.PanelTop)).EndInit();
            this.PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelBottom)).EndInit();
            this.PanelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCommunicationBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseComunicazioneBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCommunicationBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseTipiConferimentoCapitale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuComunicazioneBase)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlCommunicationBase;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCommunicationBase;
        private OeF.Forms.BindingSourceBase bindingSourceBaseComunicazioneBase;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private OeF.Forms.BindingSourceBase bindingSourceBaseTipiConferimentoCapitale;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private it.dedagroup.GVC.Client.Forms.Controls.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Documentazione.DocumentazioneDetail documentationDetail1;
        private DevExpress.XtraGrid.Columns.GridColumn colDataComunicazione;
        private DevExpress.XtraGrid.Columns.GridColumn colDataSituazione;
        private DevExpress.XtraGrid.Columns.GridColumn colTotaleSoci;
        private DevExpress.XtraGrid.Columns.GridColumn colSociCooperatori;
        private DevExpress.XtraGrid.Columns.GridColumn colSociSovventori;
        private DevExpress.XtraGrid.Columns.GridColumn colLavoratori;
        private DevExpress.XtraGrid.Columns.GridColumn colLavoratoriSoci;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoConferimentoCapitale;
        private DevExpress.XtraGrid.Columns.GridColumn colValoreMinimoQuote;
        private DevExpress.XtraGrid.Columns.GridColumn colCapitaleSottoscritto;
        private DevExpress.XtraGrid.Columns.GridColumn colCapitaleVersato;
        private DevExpress.XtraBars.BarButtonItem barButtonItemModify;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraBars.PopupMenu popupMenuComunicazioneBase;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.DocumentazioneFileSystem.DocumentazioneFileSystemDetail documentazioneFileSystemDetail1;
    }
}
