namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.PositionAndBase.ComunicazioneCaricaSoc
{
    partial class ComunicazioneDetail
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
            this.gridControlCommunications = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceCommunicazioni = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.gridViewCommunications = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCommunicationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSituationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAntimafiaCommunicationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAntimafiaProtocolNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.xtraTabControl1 = new it.dedagroup.GVC.Client.Forms.Controls.XtraTabControl();
            this.xtraTabPageSocialPosition = new DevExpress.XtraTab.XtraTabPage();
            this.CaricaSocialeDetail1 = new it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.PositionAndBase.ComunicazioneCaricaSoc.CaricaSocialeDetail();
            this.xtraTabPageDocumentationCommunicationSocialPosition = new DevExpress.XtraTab.XtraTabPage();
            this.documentationDetail1 = new it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Documentazione.DocumentazioneDetail();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemModify = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuComunicazioneCarica = new DevExpress.XtraBars.PopupMenu(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.documentazioneFileSystemDetail1 = new it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.DocumentazioneFileSystem.DocumentazioneFileSystemDetail();
            ((System.ComponentModel.ISupportInitialize)(this.PanelTop)).BeginInit();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelBottom)).BeginInit();
            this.PanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCommunications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCommunicazioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCommunications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPageSocialPosition.SuspendLayout();
            this.xtraTabPageDocumentationCommunicationSocialPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuComunicazioneCarica)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.gridControlCommunications);
            this.PanelTop.Size = new System.Drawing.Size(706, 151);
            // 
            // PanelBottom
            // 
            this.PanelBottom.Controls.Add(this.xtraTabControl1);
            this.PanelBottom.Location = new System.Drawing.Point(0, 157);
            this.PanelBottom.Size = new System.Drawing.Size(706, 262);
            // 
            // Splitter
            // 
            this.Splitter.Location = new System.Drawing.Point(0, 151);
            this.Splitter.Size = new System.Drawing.Size(706, 6);
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
            this.ScrollableContent.Size = new System.Drawing.Size(706, 419);
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // gridControlCommunications
            // 
            this.gridControlCommunications.DataSource = this.bindingSourceCommunicazioni;
            this.gridControlCommunications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCommunications.Location = new System.Drawing.Point(0, 0);
            this.gridControlCommunications.MainView = this.gridViewCommunications;
            this.gridControlCommunications.Name = "gridControlCommunications";
            this.gridControlCommunications.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControlCommunications.Size = new System.Drawing.Size(706, 151);
            this.gridControlCommunications.TabIndex = 1;
            this.gridControlCommunications.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCommunications});
            this.gridControlCommunications.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlCommunications_MouseDoubleClick);
            // 
            // bindingSourceCommunicazioni
            // 
            this.bindingSourceCommunicazioni.AutoCreateObjects = false;
            this.bindingSourceCommunicazioni.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.ComunicazioneCaricaSocialeFDT);
            this.bindingSourceCommunicazioni.CurrentChanged += new System.EventHandler(this.bindingSourceCommunications_CurrentChanged);
            // 
            // gridViewCommunications
            // 
            this.gridViewCommunications.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCommunicationDate,
            this.colSituationDate,
            this.colAntimafiaCommunicationDate,
            this.colAntimafiaProtocolNumber,
            this.colStatus});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout);
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colStatus;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual;
            styleFormatCondition1.Value1 = "100";
            this.gridViewCommunications.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridViewCommunications.GridControl = this.gridControlCommunications;
            this.gridViewCommunications.Name = "gridViewCommunications";
            this.gridViewCommunications.OptionsBehavior.Editable = false;
            this.gridViewCommunications.OptionsCustomization.AllowSort = false;
            this.gridViewCommunications.OptionsMenu.EnableColumnMenu = false;
            this.gridViewCommunications.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewCommunications.OptionsView.ShowGroupPanel = false;
            this.gridViewCommunications.OptionsView.ShowIndicator = false;
            this.gridViewCommunications.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCommunicationDate, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridViewCommunications.ShowGridMenu += new DevExpress.XtraGrid.Views.Grid.GridMenuEventHandler(this.gridViewCommunications_ShowGridMenu);
            // 
            // colCommunicationDate
            // 
            this.colCommunicationDate.AppearanceCell.Options.UseTextOptions = true;
            this.colCommunicationDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCommunicationDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colCommunicationDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCommunicationDate.Caption = "Comunicazione del";
            this.colCommunicationDate.DisplayFormat.FormatString = "d";
            this.colCommunicationDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCommunicationDate.FieldName = "DataComunicazione";
            this.colCommunicationDate.Name = "colCommunicationDate";
            this.colCommunicationDate.OptionsColumn.AllowEdit = false;
            this.colCommunicationDate.OptionsColumn.AllowFocus = false;
            this.colCommunicationDate.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCommunicationDate.OptionsColumn.AllowMove = false;
            this.colCommunicationDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCommunicationDate.OptionsFilter.AllowAutoFilter = false;
            this.colCommunicationDate.OptionsFilter.AllowFilter = false;
            this.colCommunicationDate.Visible = true;
            this.colCommunicationDate.VisibleIndex = 0;
            this.colCommunicationDate.Width = 118;
            // 
            // colSituationDate
            // 
            this.colSituationDate.AppearanceCell.Options.UseTextOptions = true;
            this.colSituationDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSituationDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colSituationDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSituationDate.Caption = "Situazione al";
            this.colSituationDate.DisplayFormat.FormatString = "d";
            this.colSituationDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSituationDate.FieldName = "DataSituazione";
            this.colSituationDate.Name = "colSituationDate";
            this.colSituationDate.OptionsColumn.AllowEdit = false;
            this.colSituationDate.OptionsColumn.AllowFocus = false;
            this.colSituationDate.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colSituationDate.OptionsColumn.AllowMove = false;
            this.colSituationDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSituationDate.OptionsFilter.AllowAutoFilter = false;
            this.colSituationDate.OptionsFilter.AllowFilter = false;
            this.colSituationDate.Visible = true;
            this.colSituationDate.VisibleIndex = 1;
            this.colSituationDate.Width = 95;
            // 
            // colAntimafiaCommunicationDate
            // 
            this.colAntimafiaCommunicationDate.AppearanceCell.Options.UseTextOptions = true;
            this.colAntimafiaCommunicationDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAntimafiaCommunicationDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colAntimafiaCommunicationDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAntimafiaCommunicationDate.Caption = "Data comunicazione certificazione antimafia";
            this.colAntimafiaCommunicationDate.DisplayFormat.FormatString = "d";
            this.colAntimafiaCommunicationDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colAntimafiaCommunicationDate.FieldName = "DataComunicazioneAntimafia";
            this.colAntimafiaCommunicationDate.Name = "colAntimafiaCommunicationDate";
            this.colAntimafiaCommunicationDate.OptionsColumn.AllowEdit = false;
            this.colAntimafiaCommunicationDate.OptionsColumn.AllowFocus = false;
            this.colAntimafiaCommunicationDate.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colAntimafiaCommunicationDate.OptionsColumn.AllowMove = false;
            this.colAntimafiaCommunicationDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAntimafiaCommunicationDate.OptionsFilter.AllowAutoFilter = false;
            this.colAntimafiaCommunicationDate.OptionsFilter.AllowFilter = false;
            this.colAntimafiaCommunicationDate.Visible = true;
            this.colAntimafiaCommunicationDate.VisibleIndex = 2;
            this.colAntimafiaCommunicationDate.Width = 212;
            // 
            // colAntimafiaProtocolNumber
            // 
            this.colAntimafiaProtocolNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colAntimafiaProtocolNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAntimafiaProtocolNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colAntimafiaProtocolNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAntimafiaProtocolNumber.Caption = "Numero di protocollo certificazione antimafia";
            this.colAntimafiaProtocolNumber.FieldName = "NumeroProtocolloAntimafia";
            this.colAntimafiaProtocolNumber.Name = "colAntimafiaProtocolNumber";
            this.colAntimafiaProtocolNumber.OptionsColumn.AllowEdit = false;
            this.colAntimafiaProtocolNumber.OptionsColumn.AllowFocus = false;
            this.colAntimafiaProtocolNumber.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colAntimafiaProtocolNumber.OptionsColumn.AllowMove = false;
            this.colAntimafiaProtocolNumber.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAntimafiaProtocolNumber.OptionsFilter.AllowAutoFilter = false;
            this.colAntimafiaProtocolNumber.OptionsFilter.AllowFilter = false;
            this.colAntimafiaProtocolNumber.Width = 221;
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
            // xtraTabControl1
            // 
            this.xtraTabControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTabControl1.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageSocialPosition;
            this.xtraTabControl1.Size = new System.Drawing.Size(706, 262);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageSocialPosition,
            this.xtraTabPageDocumentationCommunicationSocialPosition,
            this.xtraTabPage1});
            // 
            // xtraTabPageSocialPosition
            // 
            this.xtraTabPageSocialPosition.Controls.Add(this.CaricaSocialeDetail1);
            this.xtraTabPageSocialPosition.Name = "xtraTabPageSocialPosition";
            this.xtraTabPageSocialPosition.Size = new System.Drawing.Size(697, 231);
            this.xtraTabPageSocialPosition.Text = "Cariche sociali";
            // 
            // CaricaSocialeDetail1
            // 
            this.CaricaSocialeDetail1.ApplicationTitle = "";
            this.CaricaSocialeDetail1.ConfirmCancel = true;
            this.CaricaSocialeDetail1.ConfirmCancelMessage = "";
            this.CaricaSocialeDetail1.CurrentSequenceID = null;
            this.CaricaSocialeDetail1.CurrentTaskID = null;
            this.CaricaSocialeDetail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CaricaSocialeDetail1.IsShowing = false;
            this.CaricaSocialeDetail1.Location = new System.Drawing.Point(0, 0);
            this.CaricaSocialeDetail1.Name = "CaricaSocialeDetail1";
            this.CaricaSocialeDetail1.PageCaption = "";
            this.CaricaSocialeDetail1.ReadOnlyControls = true;
            this.CaricaSocialeDetail1.Size = new System.Drawing.Size(697, 231);
            this.CaricaSocialeDetail1.TabIndex = 0;
            // 
            // xtraTabPageDocumentationCommunicationSocialPosition
            // 
            this.xtraTabPageDocumentationCommunicationSocialPosition.Controls.Add(this.documentationDetail1);
            this.xtraTabPageDocumentationCommunicationSocialPosition.Name = "xtraTabPageDocumentationCommunicationSocialPosition";
            this.xtraTabPageDocumentationCommunicationSocialPosition.Size = new System.Drawing.Size(697, 231);
            this.xtraTabPageDocumentationCommunicationSocialPosition.Text = "Documentazione";
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
            this.documentationDetail1.Size = new System.Drawing.Size(697, 231);
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
            // popupMenuComunicazioneCarica
            // 
            this.popupMenuComunicazioneCarica.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemModify),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemDelete)});
            this.popupMenuComunicazioneCarica.Manager = this.BarManager;
            this.popupMenuComunicazioneCarica.Name = "popupMenuComunicazioneCarica";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.documentazioneFileSystemDetail1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(697, 231);
            this.xtraTabPage1.Text = "Documenti vigilanza";
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
            this.documentazioneFileSystemDetail1.Size = new System.Drawing.Size(697, 231);
            this.documentazioneFileSystemDetail1.TabIndex = 0;
            // 
            // ComunicazioneDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ComunicazioneDetail";
            this.Size = new System.Drawing.Size(706, 468);
            ((System.ComponentModel.ISupportInitialize)(this.PanelTop)).EndInit();
            this.PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelBottom)).EndInit();
            this.PanelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCommunications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCommunicazioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCommunications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPageSocialPosition.ResumeLayout(false);
            this.xtraTabPageDocumentationCommunicationSocialPosition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuComunicazioneCarica)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlCommunications;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCommunications;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private it.dedagroup.GVC.Client.Forms.Controls.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageSocialPosition;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageDocumentationCommunicationSocialPosition;
        private it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Documentazione.DocumentazioneDetail documentationDetail1;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceCommunicazioni;
        private DevExpress.XtraGrid.Columns.GridColumn colCommunicationDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSituationDate;
        private DevExpress.XtraGrid.Columns.GridColumn colAntimafiaCommunicationDate;
        private DevExpress.XtraGrid.Columns.GridColumn colAntimafiaProtocolNumber;
        private CaricaSocialeDetail CaricaSocialeDetail1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonItemModify;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraBars.PopupMenu popupMenuComunicazioneCarica;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.DocumentazioneFileSystem.DocumentazioneFileSystemDetail documentazioneFileSystemDetail1;
    }
}
