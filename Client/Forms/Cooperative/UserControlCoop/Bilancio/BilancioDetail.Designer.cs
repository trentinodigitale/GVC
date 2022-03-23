namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Budget
{
    partial class BilancioDetail
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
            this.gridControlBudgets = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceBaseBudgets = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewBudgets = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExerciseAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBudgetType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bindingSourceBaseBudgetTypes = new OeF.Forms.BindingSourceBase(this.components);
            this.colDataDepositoBilancioRI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataSegnalazioneRevisoreLegale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdRequisitiPrevalenzaRapportiSoci = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bindingSourceBaseRequisitiPrevalenza = new OeF.Forms.BindingSourceBase(this.components);
            this.colImpPercentualeUtili = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImpPatrimonio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bindingSourceTipoVerificaBilancio = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemModify = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuBilanci = new DevExpress.XtraBars.PopupMenu(this.components);
            this.xtraTabControl1 = new OeF.Forms.Controls.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.documentationDetail1 = new it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Documentazione.DocumentazioneDetail();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.documentazioneFileSystemDetail1 = new it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.DocumentazioneFileSystem.DocumentazioneFileSystemDetail();
            ((System.ComponentModel.ISupportInitialize)(this.PanelTop)).BeginInit();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelBottom)).BeginInit();
            this.PanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBudgets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseBudgets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBudgets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseBudgetTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseRequisitiPrevalenza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoVerificaBilancio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuBilanci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.gridControlBudgets);
            this.PanelTop.Size = new System.Drawing.Size(784, 223);
            // 
            // PanelBottom
            // 
            this.PanelBottom.Controls.Add(this.xtraTabControl1);
            this.PanelBottom.Size = new System.Drawing.Size(784, 190);
            // 
            // Splitter
            // 
            this.Splitter.Size = new System.Drawing.Size(784, 6);
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
            this.ScrollableContent.Size = new System.Drawing.Size(784, 419);
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // gridControlBudgets
            // 
            this.gridControlBudgets.DataSource = this.bindingSourceBaseBudgets;
            this.gridControlBudgets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlBudgets.Location = new System.Drawing.Point(0, 0);
            this.gridControlBudgets.MainView = this.gridViewBudgets;
            this.gridControlBudgets.Name = "gridControlBudgets";
            this.gridControlBudgets.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemCheckEdit1,
            this.repositoryItemTextEdit1,
            this.repositoryItemLookUpEdit3});
            this.gridControlBudgets.Size = new System.Drawing.Size(784, 223);
            this.gridControlBudgets.TabIndex = 0;
            this.gridControlBudgets.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBudgets});
            this.gridControlBudgets.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlBudgets_MouseDoubleClick);
            // 
            // bindingSourceBaseBudgets
            // 
            this.bindingSourceBaseBudgets.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.BilancioFDT);
            this.bindingSourceBaseBudgets.CurrentItemChanged += new System.EventHandler(this.bindingSourceBaseBudgets_CurrentItemChanged);
            // 
            // gridViewBudgets
            // 
            this.gridViewBudgets.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewBudgets.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBudgets.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewBudgets.ColumnPanelRowHeight = 40;
            this.gridViewBudgets.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colYear,
            this.colExerciseAt,
            this.colIdBudgetType,
            this.colDataDepositoBilancioRI,
            this.colDataSegnalazioneRevisoreLegale,
            this.colIdRequisitiPrevalenzaRapportiSoci,
            this.colImpPercentualeUtili,
            this.colImpPatrimonio,
            this.colNote,
            this.colPayment,
            this.colStatus});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout);
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colStatus;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual;
            styleFormatCondition1.Value1 = 100;
            this.gridViewBudgets.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridViewBudgets.GridControl = this.gridControlBudgets;
            this.gridViewBudgets.Name = "gridViewBudgets";
            this.gridViewBudgets.OptionsMenu.EnableColumnMenu = false;
            this.gridViewBudgets.OptionsMenu.EnableFooterMenu = false;
            this.gridViewBudgets.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewBudgets.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewBudgets.OptionsView.ShowGroupPanel = false;
            this.gridViewBudgets.OptionsView.ShowIndicator = false;
            this.gridViewBudgets.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colYear, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridViewBudgets.ShowGridMenu += new DevExpress.XtraGrid.Views.Grid.GridMenuEventHandler(this.gridViewBudgets_ShowGridMenu);
            // 
            // colYear
            // 
            this.colYear.AppearanceCell.Options.UseTextOptions = true;
            this.colYear.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colYear.Caption = "Anno";
            this.colYear.FieldName = "Anno";
            this.colYear.Name = "colYear";
            this.colYear.OptionsColumn.AllowEdit = false;
            this.colYear.OptionsColumn.AllowFocus = false;
            this.colYear.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colYear.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colYear.OptionsColumn.AllowMove = false;
            this.colYear.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colYear.OptionsFilter.AllowAutoFilter = false;
            this.colYear.OptionsFilter.AllowFilter = false;
            this.colYear.Visible = true;
            this.colYear.VisibleIndex = 0;
            this.colYear.Width = 53;
            // 
            // colExerciseAt
            // 
            this.colExerciseAt.AppearanceCell.Options.UseTextOptions = true;
            this.colExerciseAt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colExerciseAt.Caption = "Esercizio al";
            this.colExerciseAt.DisplayFormat.FormatString = "dd.MM";
            this.colExerciseAt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colExerciseAt.FieldName = "DataEsercizio";
            this.colExerciseAt.Name = "colExerciseAt";
            this.colExerciseAt.OptionsColumn.AllowEdit = false;
            this.colExerciseAt.OptionsColumn.AllowFocus = false;
            this.colExerciseAt.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colExerciseAt.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colExerciseAt.OptionsColumn.AllowMove = false;
            this.colExerciseAt.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colExerciseAt.OptionsFilter.AllowAutoFilter = false;
            this.colExerciseAt.OptionsFilter.AllowFilter = false;
            this.colExerciseAt.Visible = true;
            this.colExerciseAt.VisibleIndex = 1;
            this.colExerciseAt.Width = 63;
            // 
            // colIdBudgetType
            // 
            this.colIdBudgetType.AppearanceCell.Options.UseTextOptions = true;
            this.colIdBudgetType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdBudgetType.Caption = "Tipo bilancio";
            this.colIdBudgetType.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colIdBudgetType.FieldName = "IdTipoBilancio";
            this.colIdBudgetType.Name = "colIdBudgetType";
            this.colIdBudgetType.OptionsColumn.AllowEdit = false;
            this.colIdBudgetType.OptionsColumn.AllowFocus = false;
            this.colIdBudgetType.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIdBudgetType.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colIdBudgetType.OptionsColumn.AllowMove = false;
            this.colIdBudgetType.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIdBudgetType.OptionsFilter.AllowAutoFilter = false;
            this.colIdBudgetType.OptionsFilter.AllowFilter = false;
            this.colIdBudgetType.Visible = true;
            this.colIdBudgetType.VisibleIndex = 2;
            this.colIdBudgetType.Width = 91;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.bindingSourceBaseBudgetTypes;
            this.repositoryItemLookUpEdit1.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ValueMember = "IdElemento";
            // 
            // bindingSourceBaseBudgetTypes
            // 
            this.bindingSourceBaseBudgetTypes.AutoCreateObjects = false;
            this.bindingSourceBaseBudgetTypes.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // colDataDepositoBilancioRI
            // 
            this.colDataDepositoBilancioRI.AppearanceCell.Options.UseTextOptions = true;
            this.colDataDepositoBilancioRI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataDepositoBilancioRI.Caption = "Data deposito bilancio RI";
            this.colDataDepositoBilancioRI.DisplayFormat.FormatString = "d";
            this.colDataDepositoBilancioRI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDataDepositoBilancioRI.FieldName = "DataDepositoBilancioRI";
            this.colDataDepositoBilancioRI.Name = "colDataDepositoBilancioRI";
            this.colDataDepositoBilancioRI.OptionsColumn.AllowEdit = false;
            this.colDataDepositoBilancioRI.OptionsColumn.AllowFocus = false;
            this.colDataDepositoBilancioRI.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDataDepositoBilancioRI.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDataDepositoBilancioRI.OptionsColumn.AllowMove = false;
            this.colDataDepositoBilancioRI.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDataDepositoBilancioRI.OptionsFilter.AllowAutoFilter = false;
            this.colDataDepositoBilancioRI.OptionsFilter.AllowFilter = false;
            this.colDataDepositoBilancioRI.Visible = true;
            this.colDataDepositoBilancioRI.VisibleIndex = 3;
            this.colDataDepositoBilancioRI.Width = 64;
            // 
            // colDataSegnalazioneRevisoreLegale
            // 
            this.colDataSegnalazioneRevisoreLegale.AppearanceCell.Options.UseTextOptions = true;
            this.colDataSegnalazioneRevisoreLegale.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataSegnalazioneRevisoreLegale.Caption = "Data segnalazione revisore legale";
            this.colDataSegnalazioneRevisoreLegale.DisplayFormat.FormatString = "d";
            this.colDataSegnalazioneRevisoreLegale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDataSegnalazioneRevisoreLegale.FieldName = "DataSegnalazioneRevisoreLegale";
            this.colDataSegnalazioneRevisoreLegale.Name = "colDataSegnalazioneRevisoreLegale";
            this.colDataSegnalazioneRevisoreLegale.OptionsColumn.AllowEdit = false;
            this.colDataSegnalazioneRevisoreLegale.OptionsColumn.AllowFocus = false;
            this.colDataSegnalazioneRevisoreLegale.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDataSegnalazioneRevisoreLegale.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDataSegnalazioneRevisoreLegale.OptionsColumn.AllowMove = false;
            this.colDataSegnalazioneRevisoreLegale.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDataSegnalazioneRevisoreLegale.OptionsFilter.AllowAutoFilter = false;
            this.colDataSegnalazioneRevisoreLegale.OptionsFilter.AllowFilter = false;
            this.colDataSegnalazioneRevisoreLegale.Visible = true;
            this.colDataSegnalazioneRevisoreLegale.VisibleIndex = 4;
            this.colDataSegnalazioneRevisoreLegale.Width = 67;
            // 
            // colIdRequisitiPrevalenzaRapportiSoci
            // 
            this.colIdRequisitiPrevalenzaRapportiSoci.AppearanceCell.Options.UseTextOptions = true;
            this.colIdRequisitiPrevalenzaRapportiSoci.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdRequisitiPrevalenzaRapportiSoci.Caption = "Requisiti prevalenza nei rapporti coi soci";
            this.colIdRequisitiPrevalenzaRapportiSoci.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colIdRequisitiPrevalenzaRapportiSoci.FieldName = "RequisitiPrevalenzaRapportiSoci";
            this.colIdRequisitiPrevalenzaRapportiSoci.Name = "colIdRequisitiPrevalenzaRapportiSoci";
            this.colIdRequisitiPrevalenzaRapportiSoci.OptionsColumn.AllowEdit = false;
            this.colIdRequisitiPrevalenzaRapportiSoci.OptionsColumn.AllowFocus = false;
            this.colIdRequisitiPrevalenzaRapportiSoci.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIdRequisitiPrevalenzaRapportiSoci.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colIdRequisitiPrevalenzaRapportiSoci.OptionsColumn.AllowMove = false;
            this.colIdRequisitiPrevalenzaRapportiSoci.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIdRequisitiPrevalenzaRapportiSoci.OptionsFilter.AllowAutoFilter = false;
            this.colIdRequisitiPrevalenzaRapportiSoci.OptionsFilter.AllowFilter = false;
            this.colIdRequisitiPrevalenzaRapportiSoci.Visible = true;
            this.colIdRequisitiPrevalenzaRapportiSoci.VisibleIndex = 5;
            this.colIdRequisitiPrevalenzaRapportiSoci.Width = 92;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.DataSource = this.bindingSourceBaseRequisitiPrevalenza;
            this.repositoryItemLookUpEdit2.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.NullText = "";
            this.repositoryItemLookUpEdit2.ValueMember = "IdElemento";
            // 
            // bindingSourceBaseRequisitiPrevalenza
            // 
            this.bindingSourceBaseRequisitiPrevalenza.AutoCreateObjects = false;
            this.bindingSourceBaseRequisitiPrevalenza.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // colImpPercentualeUtili
            // 
            this.colImpPercentualeUtili.AppearanceCell.Options.UseTextOptions = true;
            this.colImpPercentualeUtili.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colImpPercentualeUtili.Caption = "Imp.3% utili";
            this.colImpPercentualeUtili.DisplayFormat.FormatString = "n";
            this.colImpPercentualeUtili.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colImpPercentualeUtili.FieldName = "ImportoPercUtili";
            this.colImpPercentualeUtili.Name = "colImpPercentualeUtili";
            this.colImpPercentualeUtili.OptionsColumn.AllowEdit = false;
            this.colImpPercentualeUtili.OptionsColumn.AllowFocus = false;
            this.colImpPercentualeUtili.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colImpPercentualeUtili.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colImpPercentualeUtili.OptionsColumn.AllowMove = false;
            this.colImpPercentualeUtili.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colImpPercentualeUtili.OptionsFilter.AllowAutoFilter = false;
            this.colImpPercentualeUtili.OptionsFilter.AllowFilter = false;
            this.colImpPercentualeUtili.Visible = true;
            this.colImpPercentualeUtili.VisibleIndex = 6;
            this.colImpPercentualeUtili.Width = 62;
            // 
            // colImpPatrimonio
            // 
            this.colImpPatrimonio.AppearanceCell.Options.UseTextOptions = true;
            this.colImpPatrimonio.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colImpPatrimonio.Caption = "Imp. patrimonio";
            this.colImpPatrimonio.DisplayFormat.FormatString = "n";
            this.colImpPatrimonio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colImpPatrimonio.FieldName = "ImportoPatrimonio";
            this.colImpPatrimonio.Name = "colImpPatrimonio";
            this.colImpPatrimonio.OptionsColumn.AllowEdit = false;
            this.colImpPatrimonio.OptionsColumn.AllowFocus = false;
            this.colImpPatrimonio.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colImpPatrimonio.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colImpPatrimonio.OptionsColumn.AllowMove = false;
            this.colImpPatrimonio.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colImpPatrimonio.OptionsFilter.AllowAutoFilter = false;
            this.colImpPatrimonio.OptionsFilter.AllowFilter = false;
            this.colImpPatrimonio.Visible = true;
            this.colImpPatrimonio.VisibleIndex = 7;
            this.colImpPatrimonio.Width = 64;
            // 
            // colNote
            // 
            this.colNote.AppearanceCell.Options.UseTextOptions = true;
            this.colNote.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNote.Caption = "Note";
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.OptionsColumn.AllowEdit = false;
            this.colNote.OptionsColumn.AllowFocus = false;
            this.colNote.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colNote.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colNote.OptionsColumn.AllowMove = false;
            this.colNote.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNote.OptionsFilter.AllowAutoFilter = false;
            this.colNote.OptionsFilter.AllowFilter = false;
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 8;
            this.colNote.Width = 154;
            // 
            // colPayment
            // 
            this.colPayment.AppearanceCell.Options.UseTextOptions = true;
            this.colPayment.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colPayment.Caption = "Verifica";
            this.colPayment.ColumnEdit = this.repositoryItemLookUpEdit3;
            this.colPayment.FieldName = "Pagamento";
            this.colPayment.Name = "colPayment";
            this.colPayment.OptionsColumn.AllowEdit = false;
            this.colPayment.OptionsColumn.AllowFocus = false;
            this.colPayment.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPayment.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colPayment.OptionsColumn.AllowMove = false;
            this.colPayment.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPayment.OptionsFilter.AllowAutoFilter = false;
            this.colPayment.OptionsFilter.AllowFilter = false;
            this.colPayment.Visible = true;
            this.colPayment.VisibleIndex = 9;
            this.colPayment.Width = 80;
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.DataSource = this.bindingSourceTipoVerificaBilancio;
            this.repositoryItemLookUpEdit3.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.NullText = "";
            this.repositoryItemLookUpEdit3.ValueMember = "IdElemento";
            // 
            // bindingSourceTipoVerificaBilancio
            // 
            this.bindingSourceTipoVerificaBilancio.AutoCreateObjects = false;
            this.bindingSourceTipoVerificaBilancio.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = "Ok";
            this.repositoryItemCheckEdit1.ValueUnchecked = "da vedere";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.NullText = "da vedere";
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
            // popupMenuBilanci
            // 
            this.popupMenuBilanci.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemModify),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemModify)});
            this.popupMenuBilanci.Manager = this.BarManager;
            this.popupMenuBilanci.Name = "popupMenuBilanci";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(784, 190);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.documentationDetail1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(775, 159);
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
            this.documentationDetail1.Size = new System.Drawing.Size(775, 159);
            this.documentationDetail1.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.documentazioneFileSystemDetail1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(775, 159);
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
            this.documentazioneFileSystemDetail1.Size = new System.Drawing.Size(775, 159);
            this.documentazioneFileSystemDetail1.TabIndex = 0;
            // 
            // BilancioDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "BilancioDetail";
            this.Size = new System.Drawing.Size(784, 468);
            ((System.ComponentModel.ISupportInitialize)(this.PanelTop)).EndInit();
            this.PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelBottom)).EndInit();
            this.PanelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBudgets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseBudgets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBudgets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseBudgetTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseRequisitiPrevalenza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoVerificaBilancio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuBilanci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlBudgets;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBudgets;
        private OeF.Forms.BindingSourceBase bindingSourceBaseBudgetTypes;
        private System.Windows.Forms.BindingSource bindingSourceBaseBudgets;
        private DevExpress.XtraGrid.Columns.GridColumn colYear;
        private DevExpress.XtraGrid.Columns.GridColumn colExerciseAt;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBudgetType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colDataDepositoBilancioRI;
        private DevExpress.XtraGrid.Columns.GridColumn colIdRequisitiPrevalenzaRapportiSoci;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colImpPercentualeUtili;
        private DevExpress.XtraGrid.Columns.GridColumn colImpPatrimonio;
        private OeF.Forms.BindingSourceBase bindingSourceBaseRequisitiPrevalenza;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraGrid.Columns.GridColumn colPayment;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colDataSegnalazioneRevisoreLegale;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemModify;
        private DevExpress.XtraBars.PopupMenu popupMenuBilanci;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceTipoVerificaBilancio;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private OeF.Forms.Controls.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Documentazione.DocumentazioneDetail documentationDetail1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.DocumentazioneFileSystem.DocumentazioneFileSystemDetail documentazioneFileSystemDetail1;
    }
}
