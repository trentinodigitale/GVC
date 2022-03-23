namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.DocumentazioneFileSystem
{
    partial class DocumentazioneFileSystemDetail
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridViewDocumentationFileSystem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNomeFile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocumentDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocumentLastModifie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAttachment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colDimensione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlDocumentationFileSystem = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceDocumentationFileSystem = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.gridViewHeader = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bindingSourceDocumenti = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.barButtonItemLoadDocumenti = new DevExpress.XtraBars.BarButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AnagraficaGeneralYesNo = new DevExpress.XtraEditors.CheckEdit();
            this.btnSearch = new OeF.Forms.Controls.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDocumentationFileSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDocumentationFileSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDocumentationFileSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDocumenti)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnagraficaGeneralYesNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BarManager
            // 
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemLoadDocumenti});
            this.BarManager.MaxItemId = 11;
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.gridControlDocumentationFileSystem);
            this.ScrollableContent.Controls.Add(this.panel1);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 24);
            this.ScrollableContent.Size = new System.Drawing.Size(705, 278);
            // 
            // gridViewDocumentationFileSystem
            // 
            this.gridViewDocumentationFileSystem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNomeFile,
            this.colDocumentDate,
            this.colDocumentLastModifie,
            this.colAttachment,
            this.colDimensione,
            this.colPath});
            this.gridViewDocumentationFileSystem.GridControl = this.gridControlDocumentationFileSystem;
            this.gridViewDocumentationFileSystem.Name = "gridViewDocumentationFileSystem";
            this.gridViewDocumentationFileSystem.OptionsBehavior.Editable = false;
            this.gridViewDocumentationFileSystem.OptionsCustomization.AllowSort = false;
            this.gridViewDocumentationFileSystem.OptionsMenu.EnableColumnMenu = false;
            this.gridViewDocumentationFileSystem.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewDocumentationFileSystem.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewDocumentationFileSystem.OptionsView.ShowGroupPanel = false;
            this.gridViewDocumentationFileSystem.OptionsView.ShowIndicator = false;
            this.gridViewDocumentationFileSystem.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colPath, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewDocumentationFileSystem.DoubleClick += new System.EventHandler(this.gridViewDocumentationFileSystem_DoubleClick);
            // 
            // colNomeFile
            // 
            this.colNomeFile.AppearanceHeader.Options.UseTextOptions = true;
            this.colNomeFile.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNomeFile.Caption = "Nome File";
            this.colNomeFile.FieldName = "NomeFile";
            this.colNomeFile.Name = "colNomeFile";
            this.colNomeFile.OptionsColumn.AllowEdit = false;
            this.colNomeFile.OptionsColumn.AllowFocus = false;
            this.colNomeFile.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colNomeFile.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colNomeFile.OptionsColumn.AllowMove = false;
            this.colNomeFile.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNomeFile.OptionsFilter.AllowAutoFilter = false;
            this.colNomeFile.OptionsFilter.AllowFilter = false;
            this.colNomeFile.Visible = true;
            this.colNomeFile.VisibleIndex = 0;
            this.colNomeFile.Width = 146;
            // 
            // colDocumentDate
            // 
            this.colDocumentDate.AppearanceCell.Options.UseTextOptions = true;
            this.colDocumentDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDocumentDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colDocumentDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDocumentDate.Caption = "Data documento";
            this.colDocumentDate.DisplayFormat.FormatString = "d";
            this.colDocumentDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDocumentDate.FieldName = "DataDocumento";
            this.colDocumentDate.Name = "colDocumentDate";
            this.colDocumentDate.OptionsColumn.AllowEdit = false;
            this.colDocumentDate.OptionsColumn.AllowFocus = false;
            this.colDocumentDate.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDocumentDate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDocumentDate.OptionsColumn.AllowMove = false;
            this.colDocumentDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDocumentDate.OptionsFilter.AllowAutoFilter = false;
            this.colDocumentDate.OptionsFilter.AllowFilter = false;
            this.colDocumentDate.Visible = true;
            this.colDocumentDate.VisibleIndex = 1;
            this.colDocumentDate.Width = 104;
            // 
            // colDocumentLastModifie
            // 
            this.colDocumentLastModifie.AppearanceCell.Options.UseTextOptions = true;
            this.colDocumentLastModifie.AppearanceHeader.Options.UseTextOptions = true;
            this.colDocumentLastModifie.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDocumentLastModifie.Caption = "Data ultima modifica";
            this.colDocumentLastModifie.DisplayFormat.FormatString = "d";
            this.colDocumentLastModifie.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDocumentLastModifie.FieldName = "DataUltimaModifica";
            this.colDocumentLastModifie.Name = "colDocumentLastModifie";
            this.colDocumentLastModifie.OptionsColumn.AllowEdit = false;
            this.colDocumentLastModifie.OptionsColumn.AllowFocus = false;
            this.colDocumentLastModifie.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDocumentLastModifie.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colDocumentLastModifie.OptionsColumn.AllowMove = false;
            this.colDocumentLastModifie.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDocumentLastModifie.OptionsFilter.AllowAutoFilter = false;
            this.colDocumentLastModifie.OptionsFilter.AllowFilter = false;
            this.colDocumentLastModifie.Visible = true;
            this.colDocumentLastModifie.VisibleIndex = 2;
            this.colDocumentLastModifie.Width = 107;
            // 
            // colAttachment
            // 
            this.colAttachment.AppearanceHeader.Options.UseTextOptions = true;
            this.colAttachment.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAttachment.Caption = "Allegato";
            this.colAttachment.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colAttachment.FieldName = "Icona";
            this.colAttachment.Name = "colAttachment";
            this.colAttachment.OptionsFilter.AllowAutoFilter = false;
            this.colAttachment.OptionsFilter.AllowFilter = false;
            this.colAttachment.Visible = true;
            this.colAttachment.VisibleIndex = 3;
            this.colAttachment.Width = 51;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            // 
            // colDimensione
            // 
            this.colDimensione.AppearanceHeader.Options.UseTextOptions = true;
            this.colDimensione.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDimensione.Caption = "Dimensione";
            this.colDimensione.DisplayFormat.FormatString = "{0:N0} KB";
            this.colDimensione.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDimensione.FieldName = "Dimensione";
            this.colDimensione.Name = "colDimensione";
            this.colDimensione.OptionsColumn.AllowEdit = false;
            this.colDimensione.OptionsColumn.AllowFocus = false;
            this.colDimensione.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDimensione.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDimensione.OptionsColumn.AllowMove = false;
            this.colDimensione.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDimensione.OptionsFilter.AllowAutoFilter = false;
            this.colDimensione.OptionsFilter.AllowFilter = false;
            this.colDimensione.Visible = true;
            this.colDimensione.VisibleIndex = 4;
            this.colDimensione.Width = 61;
            // 
            // colPath
            // 
            this.colPath.Caption = "Percorso";
            this.colPath.FieldName = "Path";
            this.colPath.Name = "colPath";
            this.colPath.OptionsColumn.AllowEdit = false;
            this.colPath.OptionsColumn.AllowFocus = false;
            this.colPath.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colPath.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colPath.OptionsColumn.AllowMove = false;
            this.colPath.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colPath.OptionsFilter.AllowAutoFilter = false;
            this.colPath.OptionsFilter.AllowFilter = false;
            this.colPath.Visible = true;
            this.colPath.VisibleIndex = 5;
            this.colPath.Width = 232;
            // 
            // gridControlDocumentationFileSystem
            // 
            this.gridControlDocumentationFileSystem.DataSource = this.bindingSourceDocumentationFileSystem;
            this.gridControlDocumentationFileSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridViewDocumentationFileSystem;
            gridLevelNode1.RelationName = "Documenti";
            gridLevelNode2.RelationName = "Level2";
            this.gridControlDocumentationFileSystem.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.gridControlDocumentationFileSystem.Location = new System.Drawing.Point(0, 28);
            this.gridControlDocumentationFileSystem.MainView = this.gridViewHeader;
            this.gridControlDocumentationFileSystem.Name = "gridControlDocumentationFileSystem";
            this.gridControlDocumentationFileSystem.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemPictureEdit1});
            this.gridControlDocumentationFileSystem.Size = new System.Drawing.Size(705, 250);
            this.gridControlDocumentationFileSystem.TabIndex = 1;
            this.gridControlDocumentationFileSystem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewHeader,
            this.gridViewDocumentationFileSystem});
            // 
            // bindingSourceDocumentationFileSystem
            // 
            this.bindingSourceDocumentationFileSystem.AutoCreateObjects = false;
            this.bindingSourceDocumentationFileSystem.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DocumentazioneFDT);
            // 
            // gridViewHeader
            // 
            this.gridViewHeader.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn1});
            this.gridViewHeader.GridControl = this.gridControlDocumentationFileSystem;
            this.gridViewHeader.Name = "gridViewHeader";
            this.gridViewHeader.OptionsBehavior.Editable = false;
            this.gridViewHeader.OptionsCustomization.AllowSort = false;
            this.gridViewHeader.OptionsMenu.EnableColumnMenu = false;
            this.gridViewHeader.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewHeader.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewHeader.OptionsView.ShowGroupPanel = false;
            this.gridViewHeader.OptionsView.ShowIndicator = false;
            this.gridViewHeader.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewHeader.ViewCaption = "Documenti vigilanza";
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "Icona";
            this.gridColumn4.ColumnEdit = this.repositoryItemPictureEdit1;
            this.gridColumn4.FieldName = "Icona";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn4.OptionsFilter.AllowFilter = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 39;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Descrizione";
            this.gridColumn1.FieldName = "Descrizione";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.OptionsColumn.AllowMove = false;
            this.gridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 662;
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
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.NullText = "";
            this.repositoryItemLookUpEdit2.ValueMember = "IdElemento";
            // 
            // bindingSourceDocumenti
            // 
            this.bindingSourceDocumenti.AutoCreateObjects = false;
            this.bindingSourceDocumenti.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DocumentazioneFDT);
            // 
            // barButtonItemLoadDocumenti
            // 
            this.barButtonItemLoadDocumenti.Id = 10;
            this.barButtonItemLoadDocumenti.Name = "barButtonItemLoadDocumenti";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AnagraficaGeneralYesNo);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 28);
            this.panel1.TabIndex = 2;
            // 
            // AnagraficaGeneralYesNo
            // 
            this.AnagraficaGeneralYesNo.Location = new System.Drawing.Point(169, 6);
            this.AnagraficaGeneralYesNo.Name = "AnagraficaGeneralYesNo";
            this.AnagraficaGeneralYesNo.Properties.Caption = "Anagrafica - Generale";
            this.AnagraficaGeneralYesNo.Size = new System.Drawing.Size(129, 19);
            this.AnagraficaGeneralYesNo.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(3, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Carica documenti";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // DocumentazioneFileSystemDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "DocumentazioneFileSystemDetail";
            this.Size = new System.Drawing.Size(705, 302);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDocumentationFileSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDocumentationFileSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDocumentationFileSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDocumenti)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AnagraficaGeneralYesNo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlDocumentationFileSystem;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewDocumentationFileSystem;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumentDate;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeFile;
        private DevExpress.XtraGrid.Columns.GridColumn colAttachment;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colDimensione;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceDocumentationFileSystem;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumentLastModifie;
        private DevExpress.XtraGrid.Columns.GridColumn colPath;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewHeader;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceDocumenti;
        private DevExpress.XtraBars.BarButtonItem barButtonItemLoadDocumenti;
        private System.Windows.Forms.Panel panel1;
        private OeF.Forms.Controls.SimpleButton btnSearch;
        private DevExpress.XtraEditors.CheckEdit AnagraficaGeneralYesNo;
    }
}
