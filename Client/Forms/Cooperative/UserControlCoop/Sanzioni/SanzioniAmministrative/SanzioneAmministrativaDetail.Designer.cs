namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Sanzioni.SanzioniAmministrative
{
    partial class SanzioneAmministrativaDetail
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
            this.gridControlPenalties = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceBaseSanzioni = new OeF.Forms.BindingSourceBase(this.components);
            this.gridViewPenalties = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPenaltyNature = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bindingSourceBaseNatura = new OeF.Forms.BindingSourceBase(this.components);
            this.colDataRilievoInfrazione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataPagamentoOblazione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataScrittiDifensivi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataAudizione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImportoOrdinanza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataArchiviazione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataRicorso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdGiudiceCompetente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bindingSourceBaseGiudici = new OeF.Forms.BindingSourceBase(this.components);
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.documentationDetail1 = new it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Documentazione.DocumentazioneDetail();
            this.xtraTabControl1 = new it.dedagroup.GVC.Client.Forms.Controls.XtraTabControl();
            this.xtraTabPageDocumentazioneFileSystem = new DevExpress.XtraTab.XtraTabPage();
            this.documentazioneFileSystemDetail1 = new it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.DocumentazioneFileSystem.DocumentazioneFileSystemDetail();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemModifiy = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuSanzione = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PanelTop)).BeginInit();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelBottom)).BeginInit();
            this.PanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPenalties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseSanzioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPenalties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseNatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseGiudici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPageDocumentazioneFileSystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuSanzione)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.gridControlPenalties);
            // 
            // PanelBottom
            // 
            this.PanelBottom.Controls.Add(this.xtraTabControl1);
            this.PanelBottom.Size = new System.Drawing.Size(800, 322);
            // 
            // BarManager
            // 
            this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemAdd,
            this.barButtonItemModifiy,
            this.barButtonItemDelete,
            this.barButtonItem1});
            this.BarManager.MaxItemId = 17;
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Location = new System.Drawing.Point(0, 49);
            this.ScrollableContent.Size = new System.Drawing.Size(800, 551);
            // 
            // gridControlPenalties
            // 
            this.gridControlPenalties.DataSource = this.bindingSourceBaseSanzioni;
            this.gridControlPenalties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPenalties.Location = new System.Drawing.Point(0, 0);
            this.gridControlPenalties.MainView = this.gridViewPenalties;
            this.gridControlPenalties.Name = "gridControlPenalties";
            this.gridControlPenalties.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemLookUpEdit3});
            this.gridControlPenalties.Size = new System.Drawing.Size(800, 223);
            this.gridControlPenalties.TabIndex = 0;
            this.gridControlPenalties.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPenalties});
            this.gridControlPenalties.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlPenalties_MouseDoubleClick);
            // 
            // bindingSourceBaseSanzioni
            // 
            this.bindingSourceBaseSanzioni.AutoCreateObjects = false;
            this.bindingSourceBaseSanzioni.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.SanzioneFDT);
            this.bindingSourceBaseSanzioni.CurrentChanged += new System.EventHandler(this.bindingSourceBaseSanzioni_CurrentChanged);
            // 
            // gridViewPenalties
            // 
            this.gridViewPenalties.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewPenalties.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewPenalties.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewPenalties.ColumnPanelRowHeight = 40;
            this.gridViewPenalties.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPenaltyNature,
            this.colDataRilievoInfrazione,
            this.colDataPagamentoOblazione,
            this.colDataScrittiDifensivi,
            this.colDataAudizione,
            this.colImportoOrdinanza,
            this.colDataArchiviazione,
            this.colDataRicorso,
            this.colIdGiudiceCompetente,
            this.colStatus});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout);
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colStatus;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual;
            styleFormatCondition1.Value1 = "100";
            this.gridViewPenalties.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridViewPenalties.GridControl = this.gridControlPenalties;
            this.gridViewPenalties.Name = "gridViewPenalties";
            this.gridViewPenalties.OptionsMenu.EnableColumnMenu = false;
            this.gridViewPenalties.OptionsMenu.EnableFooterMenu = false;
            this.gridViewPenalties.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewPenalties.OptionsView.ShowGroupPanel = false;
            this.gridViewPenalties.OptionsView.ShowIndicator = false;
            this.gridViewPenalties.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDataRilievoInfrazione, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewPenalties.ShowGridMenu += new DevExpress.XtraGrid.Views.Grid.GridMenuEventHandler(this.gridViewPenalties_ShowGridMenu);
            // 
            // colIdPenaltyNature
            // 
            this.colIdPenaltyNature.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdPenaltyNature.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdPenaltyNature.Caption = "Natura trasgressione";
            this.colIdPenaltyNature.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colIdPenaltyNature.FieldName = "IdNaturaTrasgressione";
            this.colIdPenaltyNature.Name = "colIdPenaltyNature";
            this.colIdPenaltyNature.OptionsColumn.AllowEdit = false;
            this.colIdPenaltyNature.OptionsColumn.AllowFocus = false;
            this.colIdPenaltyNature.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIdPenaltyNature.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colIdPenaltyNature.OptionsColumn.AllowMove = false;
            this.colIdPenaltyNature.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIdPenaltyNature.OptionsFilter.AllowAutoFilter = false;
            this.colIdPenaltyNature.OptionsFilter.AllowFilter = false;
            this.colIdPenaltyNature.Visible = true;
            this.colIdPenaltyNature.VisibleIndex = 0;
            this.colIdPenaltyNature.Width = 119;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.DataSource = this.bindingSourceBaseNatura;
            this.repositoryItemLookUpEdit2.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ValueMember = "IdElemento";
            // 
            // bindingSourceBaseNatura
            // 
            this.bindingSourceBaseNatura.AutoCreateObjects = false;
            this.bindingSourceBaseNatura.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // colDataRilievoInfrazione
            // 
            this.colDataRilievoInfrazione.Caption = "Data rilievo infrazione";
            this.colDataRilievoInfrazione.FieldName = "DataRilievoInfrazione";
            this.colDataRilievoInfrazione.Name = "colDataRilievoInfrazione";
            this.colDataRilievoInfrazione.OptionsColumn.AllowEdit = false;
            this.colDataRilievoInfrazione.OptionsColumn.AllowFocus = false;
            this.colDataRilievoInfrazione.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDataRilievoInfrazione.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDataRilievoInfrazione.OptionsColumn.AllowMove = false;
            this.colDataRilievoInfrazione.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDataRilievoInfrazione.OptionsFilter.AllowAutoFilter = false;
            this.colDataRilievoInfrazione.OptionsFilter.AllowFilter = false;
            this.colDataRilievoInfrazione.Visible = true;
            this.colDataRilievoInfrazione.VisibleIndex = 1;
            this.colDataRilievoInfrazione.Width = 65;
            // 
            // colDataPagamentoOblazione
            // 
            this.colDataPagamentoOblazione.Caption = "Data pagamento oblazione";
            this.colDataPagamentoOblazione.FieldName = "DataPagamentoOblazione";
            this.colDataPagamentoOblazione.Name = "colDataPagamentoOblazione";
            this.colDataPagamentoOblazione.OptionsColumn.AllowEdit = false;
            this.colDataPagamentoOblazione.OptionsColumn.AllowFocus = false;
            this.colDataPagamentoOblazione.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDataPagamentoOblazione.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDataPagamentoOblazione.OptionsColumn.AllowMove = false;
            this.colDataPagamentoOblazione.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDataPagamentoOblazione.OptionsFilter.AllowAutoFilter = false;
            this.colDataPagamentoOblazione.OptionsFilter.AllowFilter = false;
            this.colDataPagamentoOblazione.Visible = true;
            this.colDataPagamentoOblazione.VisibleIndex = 2;
            this.colDataPagamentoOblazione.Width = 68;
            // 
            // colDataScrittiDifensivi
            // 
            this.colDataScrittiDifensivi.Caption = "Data scritti difensivi";
            this.colDataScrittiDifensivi.FieldName = "DataScrittiDifensivi";
            this.colDataScrittiDifensivi.Name = "colDataScrittiDifensivi";
            this.colDataScrittiDifensivi.OptionsColumn.AllowEdit = false;
            this.colDataScrittiDifensivi.OptionsColumn.AllowFocus = false;
            this.colDataScrittiDifensivi.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDataScrittiDifensivi.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDataScrittiDifensivi.OptionsColumn.AllowMove = false;
            this.colDataScrittiDifensivi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDataScrittiDifensivi.OptionsFilter.AllowAutoFilter = false;
            this.colDataScrittiDifensivi.OptionsFilter.AllowFilter = false;
            this.colDataScrittiDifensivi.Visible = true;
            this.colDataScrittiDifensivi.VisibleIndex = 3;
            this.colDataScrittiDifensivi.Width = 66;
            // 
            // colDataAudizione
            // 
            this.colDataAudizione.Caption = "Data audizione";
            this.colDataAudizione.FieldName = "DataAudizione";
            this.colDataAudizione.Name = "colDataAudizione";
            this.colDataAudizione.OptionsColumn.AllowEdit = false;
            this.colDataAudizione.OptionsColumn.AllowFocus = false;
            this.colDataAudizione.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDataAudizione.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDataAudizione.OptionsColumn.AllowMove = false;
            this.colDataAudizione.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDataAudizione.OptionsFilter.AllowAutoFilter = false;
            this.colDataAudizione.OptionsFilter.AllowFilter = false;
            this.colDataAudizione.Visible = true;
            this.colDataAudizione.VisibleIndex = 4;
            this.colDataAudizione.Width = 65;
            // 
            // colImportoOrdinanza
            // 
            this.colImportoOrdinanza.Caption = "Importo ordinanza";
            this.colImportoOrdinanza.DisplayFormat.FormatString = "n";
            this.colImportoOrdinanza.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colImportoOrdinanza.FieldName = "ImportoOrdinanza";
            this.colImportoOrdinanza.Name = "colImportoOrdinanza";
            this.colImportoOrdinanza.OptionsColumn.AllowEdit = false;
            this.colImportoOrdinanza.OptionsColumn.AllowFocus = false;
            this.colImportoOrdinanza.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colImportoOrdinanza.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colImportoOrdinanza.OptionsColumn.AllowMove = false;
            this.colImportoOrdinanza.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colImportoOrdinanza.OptionsFilter.AllowAutoFilter = false;
            this.colImportoOrdinanza.OptionsFilter.AllowFilter = false;
            this.colImportoOrdinanza.Visible = true;
            this.colImportoOrdinanza.VisibleIndex = 5;
            this.colImportoOrdinanza.Width = 79;
            // 
            // colDataArchiviazione
            // 
            this.colDataArchiviazione.Caption = "Data archiviazione";
            this.colDataArchiviazione.FieldName = "DataArchiviazione";
            this.colDataArchiviazione.Name = "colDataArchiviazione";
            this.colDataArchiviazione.OptionsColumn.AllowEdit = false;
            this.colDataArchiviazione.OptionsColumn.AllowFocus = false;
            this.colDataArchiviazione.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDataArchiviazione.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDataArchiviazione.OptionsColumn.AllowMove = false;
            this.colDataArchiviazione.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDataArchiviazione.OptionsFilter.AllowAutoFilter = false;
            this.colDataArchiviazione.OptionsFilter.AllowFilter = false;
            this.colDataArchiviazione.Visible = true;
            this.colDataArchiviazione.VisibleIndex = 6;
            this.colDataArchiviazione.Width = 73;
            // 
            // colDataRicorso
            // 
            this.colDataRicorso.Caption = "Data ricorso";
            this.colDataRicorso.FieldName = "DataRicorso";
            this.colDataRicorso.Name = "colDataRicorso";
            this.colDataRicorso.OptionsColumn.AllowEdit = false;
            this.colDataRicorso.OptionsColumn.AllowFocus = false;
            this.colDataRicorso.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDataRicorso.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDataRicorso.OptionsColumn.AllowMove = false;
            this.colDataRicorso.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDataRicorso.OptionsFilter.AllowAutoFilter = false;
            this.colDataRicorso.OptionsFilter.AllowFilter = false;
            this.colDataRicorso.Visible = true;
            this.colDataRicorso.VisibleIndex = 7;
            this.colDataRicorso.Width = 63;
            // 
            // colIdGiudiceCompetente
            // 
            this.colIdGiudiceCompetente.Caption = "Giudice competente";
            this.colIdGiudiceCompetente.ColumnEdit = this.repositoryItemLookUpEdit3;
            this.colIdGiudiceCompetente.FieldName = "IdGiudiceCompetente";
            this.colIdGiudiceCompetente.Name = "colIdGiudiceCompetente";
            this.colIdGiudiceCompetente.OptionsColumn.AllowEdit = false;
            this.colIdGiudiceCompetente.OptionsColumn.AllowFocus = false;
            this.colIdGiudiceCompetente.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIdGiudiceCompetente.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colIdGiudiceCompetente.OptionsColumn.AllowMove = false;
            this.colIdGiudiceCompetente.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIdGiudiceCompetente.OptionsFilter.AllowAutoFilter = false;
            this.colIdGiudiceCompetente.OptionsFilter.AllowFilter = false;
            this.colIdGiudiceCompetente.Visible = true;
            this.colIdGiudiceCompetente.VisibleIndex = 8;
            this.colIdGiudiceCompetente.Width = 69;
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.DataSource = this.bindingSourceBaseGiudici;
            this.repositoryItemLookUpEdit3.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.ValueMember = "IdElemento";
            // 
            // bindingSourceBaseGiudici
            // 
            this.bindingSourceBaseGiudici.AutoCreateObjects = false;
            this.bindingSourceBaseGiudici.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.NullText = "€";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.documentationDetail1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(791, 292);
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
            this.documentationDetail1.Size = new System.Drawing.Size(791, 292);
            this.documentationDetail1.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(800, 322);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPageDocumentazioneFileSystem});
            // 
            // xtraTabPageDocumentazioneFileSystem
            // 
            this.xtraTabPageDocumentazioneFileSystem.Controls.Add(this.documentazioneFileSystemDetail1);
            this.xtraTabPageDocumentazioneFileSystem.Name = "xtraTabPageDocumentazioneFileSystem";
            this.xtraTabPageDocumentazioneFileSystem.Size = new System.Drawing.Size(791, 341);
            this.xtraTabPageDocumentazioneFileSystem.Text = "Documenti vigilanza";
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
            this.documentazioneFileSystemDetail1.Size = new System.Drawing.Size(791, 341);
            this.documentazioneFileSystemDetail1.TabIndex = 0;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemModifiy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 2";
            // 
            // barButtonItemAdd
            // 
            this.barButtonItemAdd.Caption = "Nuovo";
            this.barButtonItemAdd.Id = 12;
            this.barButtonItemAdd.Name = "barButtonItemAdd";
            this.barButtonItemAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAddPenalty_ItemClick);
            // 
            // barButtonItemModifiy
            // 
            this.barButtonItemModifiy.Caption = "Modifica";
            this.barButtonItemModifiy.Id = 13;
            this.barButtonItemModifiy.Name = "barButtonItemModifiy";
            this.barButtonItemModifiy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemModifiy_ItemClick);
            // 
            // barButtonItemDelete
            // 
            this.barButtonItemDelete.Caption = "Cancella";
            this.barButtonItemDelete.Id = 14;
            this.barButtonItemDelete.Name = "barButtonItemDelete";
            this.barButtonItemDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDelete_ItemClick);
            // 
            // popupMenuSanzione
            // 
            this.popupMenuSanzione.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemModifiy),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemDelete)});
            this.popupMenuSanzione.Manager = this.BarManager;
            this.popupMenuSanzione.Name = "popupMenuSanzione";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 16;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // SanzioneAmministrativaDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "SanzioneAmministrativaDetail";
            ((System.ComponentModel.ISupportInitialize)(this.PanelTop)).EndInit();
            this.PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelBottom)).EndInit();
            this.PanelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPenalties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseSanzioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPenalties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseNatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseGiudici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPageDocumentazioneFileSystem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuSanzione)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlPenalties;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPenalties;
        private OeF.Forms.BindingSourceBase bindingSourceBaseSanzioni;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPenaltyNature;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private it.dedagroup.GVC.Client.Forms.Controls.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Documentazione.DocumentazioneDetail documentationDetail1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraGrid.Columns.GridColumn colDataPagamentoOblazione;
        private DevExpress.XtraGrid.Columns.GridColumn colDataScrittiDifensivi;
        private DevExpress.XtraGrid.Columns.GridColumn colDataAudizione;
        private DevExpress.XtraGrid.Columns.GridColumn colImportoOrdinanza;
        private DevExpress.XtraGrid.Columns.GridColumn colDataArchiviazione;
        private DevExpress.XtraGrid.Columns.GridColumn colDataRicorso;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGiudiceCompetente;
        private DevExpress.XtraGrid.Columns.GridColumn colDataRilievoInfrazione;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private OeF.Forms.BindingSourceBase bindingSourceBaseNatura;
        private OeF.Forms.BindingSourceBase bindingSourceBaseGiudici;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private DevExpress.XtraBars.PopupMenu popupMenuSanzione;
        private DevExpress.XtraBars.BarButtonItem barButtonItemModifiy;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageDocumentazioneFileSystem;
        private it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.DocumentazioneFileSystem.DocumentazioneFileSystemDetail documentazioneFileSystemDetail1;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
    }
}
