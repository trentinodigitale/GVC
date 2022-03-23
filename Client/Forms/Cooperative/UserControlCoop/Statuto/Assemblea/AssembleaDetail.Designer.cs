namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Statuto.Assemblea
{
    partial class AssembleaDetail
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
            this.gridControlMeeting = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceBaseMeeting = new OeF.Forms.BindingSourceBase(this.components);
            this.gridViewMeeting = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMeetingDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMeetingType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bindingSourceBaseMeetingType = new OeF.Forms.BindingSourceBase(this.components);
            this.colDataEvasioneUfficio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.xtraTabControl1 = new it.dedagroup.GVC.Client.Forms.Controls.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.modificaStatutariaDetail1 = new it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Statuto.Assemblea.ModificaStatutariaDetail();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.documentationDetail1 = new it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Documentazione.DocumentazioneDetail();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemModify = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemViewStorico = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuAssemblea = new DevExpress.XtraBars.PopupMenu(this.components);
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.documentazioneFileSystemDetail1 = new it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.DocumentazioneFileSystem.DocumentazioneFileSystemDetail();
            ((System.ComponentModel.ISupportInitialize)(this.PanelTop)).BeginInit();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelBottom)).BeginInit();
            this.PanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMeeting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseMeeting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMeeting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseMeetingType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuAssemblea)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.gridControlMeeting);
            this.PanelTop.Size = new System.Drawing.Size(639, 115);
            // 
            // PanelBottom
            // 
            this.PanelBottom.Controls.Add(this.xtraTabControl1);
            this.PanelBottom.Location = new System.Drawing.Point(0, 121);
            this.PanelBottom.Size = new System.Drawing.Size(639, 305);
            // 
            // Splitter
            // 
            this.Splitter.Location = new System.Drawing.Point(0, 115);
            this.Splitter.Size = new System.Drawing.Size(639, 6);
            // 
            // BarManager
            // 
            this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemAdd,
            this.barButtonItemDelete,
            this.barButtonItemModify,
            this.barButtonItemViewStorico});
            this.BarManager.MaxItemId = 16;
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Location = new System.Drawing.Point(0, 49);
            this.ScrollableContent.Size = new System.Drawing.Size(639, 426);
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // gridControlMeeting
            // 
            this.gridControlMeeting.DataSource = this.bindingSourceBaseMeeting;
            this.gridControlMeeting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMeeting.Location = new System.Drawing.Point(0, 0);
            this.gridControlMeeting.MainView = this.gridViewMeeting;
            this.gridControlMeeting.Name = "gridControlMeeting";
            this.gridControlMeeting.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemMemoEdit1});
            this.gridControlMeeting.Size = new System.Drawing.Size(639, 115);
            this.gridControlMeeting.TabIndex = 0;
            this.gridControlMeeting.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMeeting});
            this.gridControlMeeting.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlMeeting_MouseDoubleClick);
            // 
            // bindingSourceBaseMeeting
            // 
            this.bindingSourceBaseMeeting.AutoCreateObjects = false;
            this.bindingSourceBaseMeeting.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DeliberaAssembleaFDT);
            this.bindingSourceBaseMeeting.CurrentChanged += new System.EventHandler(this.bindingSourceBaseMeeting_CurrentChanged);
            // 
            // gridViewMeeting
            // 
            this.gridViewMeeting.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMeetingDate,
            this.colIdMeetingType,
            this.colDataEvasioneUfficio,
            this.colContent,
            this.colStatus});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout);
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colStatus;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual;
            styleFormatCondition1.Value1 = "100";
            this.gridViewMeeting.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridViewMeeting.GridControl = this.gridControlMeeting;
            this.gridViewMeeting.Name = "gridViewMeeting";
            this.gridViewMeeting.OptionsBehavior.Editable = false;
            this.gridViewMeeting.OptionsMenu.EnableColumnMenu = false;
            this.gridViewMeeting.OptionsMenu.EnableFooterMenu = false;
            this.gridViewMeeting.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewMeeting.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewMeeting.OptionsView.ShowGroupPanel = false;
            this.gridViewMeeting.OptionsView.ShowIndicator = false;
            this.gridViewMeeting.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMeetingDate, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewMeeting.ShowGridMenu += new DevExpress.XtraGrid.Views.Grid.GridMenuEventHandler(this.gridViewMeeting_ShowGridMenu);
            // 
            // colMeetingDate
            // 
            this.colMeetingDate.AppearanceCell.Options.UseTextOptions = true;
            this.colMeetingDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMeetingDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colMeetingDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMeetingDate.Caption = "Data assemblea";
            this.colMeetingDate.FieldName = "DataAssemblea";
            this.colMeetingDate.Name = "colMeetingDate";
            this.colMeetingDate.OptionsColumn.AllowEdit = false;
            this.colMeetingDate.OptionsColumn.AllowFocus = false;
            this.colMeetingDate.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colMeetingDate.OptionsColumn.AllowMove = false;
            this.colMeetingDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colMeetingDate.OptionsFilter.AllowAutoFilter = false;
            this.colMeetingDate.OptionsFilter.AllowFilter = false;
            this.colMeetingDate.Visible = true;
            this.colMeetingDate.VisibleIndex = 0;
            this.colMeetingDate.Width = 116;
            // 
            // colIdMeetingType
            // 
            this.colIdMeetingType.Caption = "Tipo";
            this.colIdMeetingType.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colIdMeetingType.FieldName = "IdTipoAssemblea";
            this.colIdMeetingType.Name = "colIdMeetingType";
            this.colIdMeetingType.OptionsColumn.AllowEdit = false;
            this.colIdMeetingType.OptionsColumn.AllowFocus = false;
            this.colIdMeetingType.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIdMeetingType.OptionsColumn.AllowMove = false;
            this.colIdMeetingType.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIdMeetingType.OptionsFilter.AllowAutoFilter = false;
            this.colIdMeetingType.OptionsFilter.AllowFilter = false;
            this.colIdMeetingType.Visible = true;
            this.colIdMeetingType.VisibleIndex = 1;
            this.colIdMeetingType.Width = 122;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.bindingSourceBaseMeetingType;
            this.repositoryItemLookUpEdit1.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "IdElemento";
            // 
            // bindingSourceBaseMeetingType
            // 
            this.bindingSourceBaseMeetingType.AutoCreateObjects = false;
            this.bindingSourceBaseMeetingType.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.Dictionaries.TipoAssembleaFDT);
            // 
            // colDataEvasioneUfficio
            // 
            this.colDataEvasioneUfficio.Caption = "Data evasione ufficio";
            this.colDataEvasioneUfficio.DisplayFormat.FormatString = "d";
            this.colDataEvasioneUfficio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDataEvasioneUfficio.FieldName = "DataEvasioneUfficio";
            this.colDataEvasioneUfficio.Name = "colDataEvasioneUfficio";
            this.colDataEvasioneUfficio.Visible = true;
            this.colDataEvasioneUfficio.VisibleIndex = 2;
            this.colDataEvasioneUfficio.Width = 127;
            // 
            // colContent
            // 
            this.colContent.AppearanceHeader.Options.UseTextOptions = true;
            this.colContent.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colContent.Caption = "Contenuto";
            this.colContent.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colContent.FieldName = "Contenuto";
            this.colContent.Name = "colContent";
            this.colContent.OptionsColumn.AllowEdit = false;
            this.colContent.OptionsColumn.AllowFocus = false;
            this.colContent.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colContent.OptionsColumn.AllowMove = false;
            this.colContent.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colContent.OptionsFilter.AllowAutoFilter = false;
            this.colContent.OptionsFilter.AllowFilter = false;
            this.colContent.Visible = true;
            this.colContent.VisibleIndex = 3;
            this.colContent.Width = 302;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(639, 305);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.modificaStatutariaDetail1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(630, 274);
            this.xtraTabPage1.Text = "Elenco modifiche statutarie";
            // 
            // modificaStatutariaDetail1
            // 
            this.modificaStatutariaDetail1.ApplicationTitle = "";
            this.modificaStatutariaDetail1.ConfirmCancel = true;
            this.modificaStatutariaDetail1.ConfirmCancelMessage = "";
            this.modificaStatutariaDetail1.CurrentSequenceID = null;
            this.modificaStatutariaDetail1.CurrentTaskID = null;
            this.modificaStatutariaDetail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modificaStatutariaDetail1.IsShowing = false;
            this.modificaStatutariaDetail1.Location = new System.Drawing.Point(0, 0);
            this.modificaStatutariaDetail1.Name = "modificaStatutariaDetail1";
            this.modificaStatutariaDetail1.PageCaption = "";
            this.modificaStatutariaDetail1.ReadOnlyControls = true;
            this.modificaStatutariaDetail1.Size = new System.Drawing.Size(630, 274);
            this.modificaStatutariaDetail1.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.documentationDetail1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(630, 274);
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
            this.documentationDetail1.Size = new System.Drawing.Size(630, 274);
            this.documentationDetail1.TabIndex = 0;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemViewStorico, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            // barButtonItemViewStorico
            // 
            this.barButtonItemViewStorico.Caption = "Dati storici";
            this.barButtonItemViewStorico.Id = 15;
            this.barButtonItemViewStorico.Name = "barButtonItemViewStorico";
            this.barButtonItemViewStorico.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemViewStorico_ItemClick);
            // 
            // popupMenuAssemblea
            // 
            this.popupMenuAssemblea.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemModify),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemDelete)});
            this.popupMenuAssemblea.Manager = this.BarManager;
            this.popupMenuAssemblea.Name = "popupMenuAssemblea";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.documentazioneFileSystemDetail1);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(630, 274);
            this.xtraTabPage3.Text = "Documenti vigilanza";
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
            this.documentazioneFileSystemDetail1.Size = new System.Drawing.Size(630, 274);
            this.documentazioneFileSystemDetail1.TabIndex = 0;
            // 
            // AssembleaDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "AssembleaDetail";
            this.Size = new System.Drawing.Size(639, 475);
            ((System.ComponentModel.ISupportInitialize)(this.PanelTop)).EndInit();
            this.PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelBottom)).EndInit();
            this.PanelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMeeting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseMeeting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMeeting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseMeetingType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuAssemblea)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlMeeting;
        private OeF.Forms.BindingSourceBase bindingSourceBaseMeeting;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMeeting;
        private DevExpress.XtraGrid.Columns.GridColumn colMeetingDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMeetingType;
        private DevExpress.XtraGrid.Columns.GridColumn colContent;
        private it.dedagroup.GVC.Client.Forms.Controls.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private OeF.Forms.BindingSourceBase bindingSourceBaseMeetingType;
        private it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Documentazione.DocumentazioneDetail documentationDetail1;
        private ModificaStatutariaDetail modificaStatutariaDetail1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonItemModify;
        private DevExpress.XtraBars.PopupMenu popupMenuAssemblea;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraBars.BarButtonItem barButtonItemViewStorico;
        private DevExpress.XtraGrid.Columns.GridColumn colDataEvasioneUfficio;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.DocumentazioneFileSystem.DocumentazioneFileSystemDetail documentazioneFileSystemDetail1;

    }
}
