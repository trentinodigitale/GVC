namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Sanzioni.ProceduraFallimentare
{
    partial class ProceduraFallimentareDetail
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
            this.colStatus1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlFailureProcedures = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceFailureProcedurs = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.gridViewFailureProcedures = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRulingDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDCourt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDCurator = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bindingSourceFailureType = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.colProcedureEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemAddNew = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemModify = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRemove = new DevExpress.XtraBars.BarButtonItem();
            this.xtraTabControl1 = new OeF.Forms.Controls.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.documentationDetail1 = new it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Documentazione.DocumentazioneDetail();
            this.popupMenuFallimenti = new DevExpress.XtraBars.PopupMenu(this.components);
            this.xtraTabPageDocumentazioneFileSystem = new DevExpress.XtraTab.XtraTabPage();
            this.documentazioneFileSystemDetail1 = new it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.DocumentazioneFileSystem.DocumentazioneFileSystemDetail();
            ((System.ComponentModel.ISupportInitialize)(this.PanelTop)).BeginInit();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelBottom)).BeginInit();
            this.PanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFailureProcedures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFailureProcedurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFailureProcedures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFailureType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuFallimenti)).BeginInit();
            this.xtraTabPageDocumentazioneFileSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.gridControlFailureProcedures);
            this.PanelTop.Size = new System.Drawing.Size(808, 223);
            // 
            // PanelBottom
            // 
            this.PanelBottom.Controls.Add(this.xtraTabControl1);
            this.PanelBottom.Size = new System.Drawing.Size(808, 205);
            // 
            // Splitter
            // 
            this.Splitter.Size = new System.Drawing.Size(808, 6);
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
            this.ScrollableContent.Location = new System.Drawing.Point(0, 49);
            this.ScrollableContent.Size = new System.Drawing.Size(808, 434);
            // 
            // colStatus1
            // 
            this.colStatus1.Caption = "Status";
            this.colStatus1.FieldName = "Status";
            this.colStatus1.Name = "colStatus1";
            // 
            // gridControlFailureProcedures
            // 
            this.gridControlFailureProcedures.DataSource = this.bindingSourceFailureProcedurs;
            this.gridControlFailureProcedures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlFailureProcedures.Location = new System.Drawing.Point(0, 0);
            this.gridControlFailureProcedures.MainView = this.gridViewFailureProcedures;
            this.gridControlFailureProcedures.Name = "gridControlFailureProcedures";
            this.gridControlFailureProcedures.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControlFailureProcedures.Size = new System.Drawing.Size(808, 223);
            this.gridControlFailureProcedures.TabIndex = 1;
            this.gridControlFailureProcedures.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFailureProcedures});
            this.gridControlFailureProcedures.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlFailureProcedures_MouseDoubleClick);
            // 
            // bindingSourceFailureProcedurs
            // 
            this.bindingSourceFailureProcedurs.AutoCreateObjects = false;
            this.bindingSourceFailureProcedurs.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.ProceduraFallimentareFDT);
            this.bindingSourceFailureProcedurs.CurrentChanged += new System.EventHandler(this.bindingSourceFailureProcedurs_CurrentChanged);
            // 
            // gridViewFailureProcedures
            // 
            this.gridViewFailureProcedures.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRulingDate,
            this.colIDCourt,
            this.colIDCurator,
            this.colStatus,
            this.colProcedureEndDate,
            this.colStatus1});
            styleFormatCondition2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout);
            styleFormatCondition2.Appearance.Options.UseFont = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colStatus1;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual;
            styleFormatCondition2.Value1 = "100";
            this.gridViewFailureProcedures.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition2});
            this.gridViewFailureProcedures.GridControl = this.gridControlFailureProcedures;
            this.gridViewFailureProcedures.Name = "gridViewFailureProcedures";
            this.gridViewFailureProcedures.OptionsBehavior.Editable = false;
            this.gridViewFailureProcedures.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewFailureProcedures.OptionsView.ShowGroupPanel = false;
            this.gridViewFailureProcedures.OptionsView.ShowIndicator = false;
            this.gridViewFailureProcedures.ShowGridMenu += new DevExpress.XtraGrid.Views.Grid.GridMenuEventHandler(this.gridViewFailureProcedures_ShowGridMenu);
            // 
            // colRulingDate
            // 
            this.colRulingDate.Caption = "Data sentenza";
            this.colRulingDate.FieldName = "DataSentenza";
            this.colRulingDate.Name = "colRulingDate";
            this.colRulingDate.Visible = true;
            this.colRulingDate.VisibleIndex = 0;
            this.colRulingDate.Width = 94;
            // 
            // colIDCourt
            // 
            this.colIDCourt.Caption = "Tribunale";
            this.colIDCourt.FieldName = "Tribunale";
            this.colIDCourt.Name = "colIDCourt";
            this.colIDCourt.Visible = true;
            this.colIDCourt.VisibleIndex = 1;
            this.colIDCourt.Width = 219;
            // 
            // colIDCurator
            // 
            this.colIDCurator.Caption = "Curatore fallimentare";
            this.colIDCurator.FieldName = "Curatore_DescrizioneBreve";
            this.colIDCurator.Name = "colIDCurator";
            this.colIDCurator.Visible = true;
            this.colIDCurator.VisibleIndex = 2;
            this.colIDCurator.Width = 198;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Stato";
            this.colStatus.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colStatus.FieldName = "Esito";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 3;
            this.colStatus.Width = 160;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.bindingSourceFailureType;
            this.repositoryItemLookUpEdit1.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "IdElemento";
            // 
            // bindingSourceFailureType
            // 
            this.bindingSourceFailureType.AutoCreateObjects = false;
            this.bindingSourceFailureType.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // colProcedureEndDate
            // 
            this.colProcedureEndDate.Caption = "Data fine procedimento";
            this.colProcedureEndDate.FieldName = "DataFineProcedura";
            this.colProcedureEndDate.Name = "colProcedureEndDate";
            this.colProcedureEndDate.Visible = true;
            this.colProcedureEndDate.VisibleIndex = 4;
            this.colProcedureEndDate.Width = 135;
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
            this.barButtonItemAddNew.Enabled = false;
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
            this.barButtonItemRemove.Enabled = false;
            this.barButtonItemRemove.Id = 10;
            this.barButtonItemRemove.Name = "barButtonItemRemove";
            this.barButtonItemRemove.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemRemove_ItemClick);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(808, 205);
            this.xtraTabControl1.TabIndex = 3;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPageDocumentazioneFileSystem});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.documentationDetail1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(799, 174);
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
            this.documentationDetail1.Size = new System.Drawing.Size(799, 174);
            this.documentationDetail1.TabIndex = 0;
            // 
            // popupMenuFallimenti
            // 
            this.popupMenuFallimenti.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAddNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemModify),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemRemove)});
            this.popupMenuFallimenti.Manager = this.BarManager;
            this.popupMenuFallimenti.Name = "popupMenuFallimenti";
            // 
            // xtraTabPageDocumentazioneFileSystem
            // 
            this.xtraTabPageDocumentazioneFileSystem.Controls.Add(this.documentazioneFileSystemDetail1);
            this.xtraTabPageDocumentazioneFileSystem.Name = "xtraTabPageDocumentazioneFileSystem";
            this.xtraTabPageDocumentazioneFileSystem.Size = new System.Drawing.Size(799, 174);
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
            this.documentazioneFileSystemDetail1.Size = new System.Drawing.Size(799, 174);
            this.documentazioneFileSystemDetail1.TabIndex = 0;
            // 
            // ProceduraFallimentareDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ProceduraFallimentareDetail";
            this.Size = new System.Drawing.Size(808, 483);
            ((System.ComponentModel.ISupportInitialize)(this.PanelTop)).EndInit();
            this.PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelBottom)).EndInit();
            this.PanelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFailureProcedures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFailureProcedurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFailureProcedures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFailureType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuFallimenti)).EndInit();
            this.xtraTabPageDocumentazioneFileSystem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlFailureProcedures;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFailureProcedures;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceFailureProcedurs;
        private DevExpress.XtraGrid.Columns.GridColumn colRulingDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIDCourt;
        private DevExpress.XtraGrid.Columns.GridColumn colIDCurator;
        private DevExpress.XtraGrid.Columns.GridColumn colProcedureEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAddNew;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRemove;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceFailureType;
        private DevExpress.XtraBars.BarButtonItem barButtonItemModify;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus1;
        private OeF.Forms.Controls.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Documentazione.DocumentazioneDetail documentationDetail1;
        private DevExpress.XtraBars.PopupMenu popupMenuFallimenti;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageDocumentazioneFileSystem;
        private it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.DocumentazioneFileSystem.DocumentazioneFileSystemDetail documentazioneFileSystemDetail1;
    }
}
