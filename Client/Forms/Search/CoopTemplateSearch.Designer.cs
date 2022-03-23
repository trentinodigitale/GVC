namespace it.dedagroup.GVC.Client.Forms.Search
{
    partial class CoopTemplateSearch
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
            this.panelControlSearchParameter = new OeF.Forms.Controls.PanelControl();
            this.lblResults = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.labelControl1 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.NumeroREA = new OeF.Forms.Controls.TextEdit();
            this.CodiceCooperativa = new OeF.Forms.Controls.TextEdit();
            this.CodiceFiscale = new OeF.Forms.Controls.TextEdit();
            this.Denominazione = new OeF.Forms.Controls.TextEdit();
            this.labelControl5 = new OeF.Forms.Controls.LabelControl();
            this.labelControl4 = new OeF.Forms.Controls.LabelControl();
            this.labelControl3 = new OeF.Forms.Controls.LabelControl();
            this.labelControl2 = new OeF.Forms.Controls.LabelControl();
            this.btnSearch = new OeF.Forms.Controls.SimpleButton();
            this.gridControlSoggetto = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceBaseResults = new OeF.Forms.BindingSourceBase(this.components);
            this.gridViewSoggetto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodiceCooperativa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNominativo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroREA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bindingSourceBaseTipoSoggetto = new OeF.Forms.BindingSourceBase(this.components);
            this.barButtonItemExportResults = new DevExpress.XtraBars.BarButtonItem();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemAzzera = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlSearchParameter)).BeginInit();
            this.panelControlSearchParameter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumeroREA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodiceCooperativa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodiceFiscale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Denominazione.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSoggetto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSoggetto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseTipoSoggetto)).BeginInit();
            this.SuspendLayout();
            // 
            // BarManager
            // 
            this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemExportResults,
            this.barButtonItemAzzera});
            this.BarManager.MaxItemId = 11;
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.gridControlSoggetto);
            this.ScrollableContent.Controls.Add(this.panelControlSearchParameter);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 49);
            this.ScrollableContent.Size = new System.Drawing.Size(729, 278);
            // 
            // BarGridControl
            // 
            this.BarGridControl.OptionsBar.AllowQuickCustomization = false;
            this.BarGridControl.OptionsBar.DisableClose = true;
            this.BarGridControl.OptionsBar.DisableCustomization = true;
            this.BarGridControl.OptionsBar.UseWholeRow = true;
            // 
            // panelControlSearchParameter
            // 
            this.panelControlSearchParameter.Controls.Add(this.lblResults);
            this.panelControlSearchParameter.Controls.Add(this.labelControl1);
            this.panelControlSearchParameter.Controls.Add(this.NumeroREA);
            this.panelControlSearchParameter.Controls.Add(this.CodiceCooperativa);
            this.panelControlSearchParameter.Controls.Add(this.CodiceFiscale);
            this.panelControlSearchParameter.Controls.Add(this.Denominazione);
            this.panelControlSearchParameter.Controls.Add(this.labelControl5);
            this.panelControlSearchParameter.Controls.Add(this.labelControl4);
            this.panelControlSearchParameter.Controls.Add(this.labelControl3);
            this.panelControlSearchParameter.Controls.Add(this.labelControl2);
            this.panelControlSearchParameter.Controls.Add(this.btnSearch);
            this.panelControlSearchParameter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlSearchParameter.Location = new System.Drawing.Point(0, 0);
            this.panelControlSearchParameter.Name = "panelControlSearchParameter";
            this.panelControlSearchParameter.Size = new System.Drawing.Size(729, 119);
            this.panelControlSearchParameter.TabIndex = 1;
            // 
            // lblResults
            // 
            this.lblResults.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblResults.Appearance.Options.UseFont = true;
            this.lblResults.Location = new System.Drawing.Point(82, 101);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 13);
            this.lblResults.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(16, 101);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Risultati:";
            // 
            // NumeroREA
            // 
            this.NumeroREA.Location = new System.Drawing.Point(105, 49);
            this.NumeroREA.Name = "NumeroREA";
            this.NumeroREA.Size = new System.Drawing.Size(66, 20);
            this.NumeroREA.TabIndex = 1;
            // 
            // CodiceCooperativa
            // 
            this.CodiceCooperativa.Location = new System.Drawing.Point(105, 23);
            this.CodiceCooperativa.Name = "CodiceCooperativa";
            this.CodiceCooperativa.Size = new System.Drawing.Size(66, 20);
            this.CodiceCooperativa.TabIndex = 0;
            // 
            // CodiceFiscale
            // 
            this.CodiceFiscale.Location = new System.Drawing.Point(312, 49);
            this.CodiceFiscale.Name = "CodiceFiscale";
            this.CodiceFiscale.Size = new System.Drawing.Size(245, 20);
            this.CodiceFiscale.TabIndex = 3;
            // 
            // Denominazione
            // 
            this.Denominazione.Location = new System.Drawing.Point(312, 23);
            this.Denominazione.Name = "Denominazione";
            this.Denominazione.Size = new System.Drawing.Size(245, 20);
            this.Denominazione.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(39, 52);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Numero REA";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(5, 26);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(94, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Codice Cooperativa";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(241, 52);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Codice fiscale";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(234, 26);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Denominazione";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(234, 84);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Ricerca";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gridControlSoggetto
            // 
            this.gridControlSoggetto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlSoggetto.DataSource = this.bindingSourceBaseResults;
            this.gridControlSoggetto.Location = new System.Drawing.Point(0, 120);
            this.gridControlSoggetto.MainView = this.gridViewSoggetto;
            this.gridControlSoggetto.Name = "gridControlSoggetto";
            this.gridControlSoggetto.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControlSoggetto.Size = new System.Drawing.Size(729, 158);
            this.gridControlSoggetto.TabIndex = 2;
            this.gridControlSoggetto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSoggetto});
            this.gridControlSoggetto.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlSoggetto_MouseDoubleClick);
            // 
            // bindingSourceBaseResults
            // 
            this.bindingSourceBaseResults.AutoCreateObjects = false;
            this.bindingSourceBaseResults.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.SoggettoPerVisualizzazioneFDT);
            // 
            // gridViewSoggetto
            // 
            this.gridViewSoggetto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodiceCooperativa,
            this.colNominativo,
            this.colNumeroREA});
            this.gridViewSoggetto.GridControl = this.gridControlSoggetto;
            this.gridViewSoggetto.Name = "gridViewSoggetto";
            this.gridViewSoggetto.OptionsMenu.EnableColumnMenu = false;
            this.gridViewSoggetto.OptionsMenu.EnableFooterMenu = false;
            this.gridViewSoggetto.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewSoggetto.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewSoggetto.OptionsView.ShowGroupPanel = false;
            this.gridViewSoggetto.OptionsView.ShowIndicator = false;
            this.gridViewSoggetto.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCodiceCooperativa, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colCodiceCooperativa
            // 
            this.colCodiceCooperativa.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodiceCooperativa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodiceCooperativa.Caption = "Codice cooperativa";
            this.colCodiceCooperativa.FieldName = "CodiceCooperativa";
            this.colCodiceCooperativa.Name = "colCodiceCooperativa";
            this.colCodiceCooperativa.OptionsColumn.AllowEdit = false;
            this.colCodiceCooperativa.OptionsColumn.AllowFocus = false;
            this.colCodiceCooperativa.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCodiceCooperativa.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colCodiceCooperativa.OptionsColumn.AllowMove = false;
            this.colCodiceCooperativa.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCodiceCooperativa.OptionsFilter.AllowAutoFilter = false;
            this.colCodiceCooperativa.OptionsFilter.AllowFilter = false;
            this.colCodiceCooperativa.Visible = true;
            this.colCodiceCooperativa.VisibleIndex = 0;
            this.colCodiceCooperativa.Width = 111;
            // 
            // colNominativo
            // 
            this.colNominativo.AppearanceHeader.Options.UseTextOptions = true;
            this.colNominativo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNominativo.Caption = "Denominazione";
            this.colNominativo.FieldName = "Nominativo";
            this.colNominativo.Name = "colNominativo";
            this.colNominativo.OptionsColumn.AllowEdit = false;
            this.colNominativo.OptionsColumn.AllowFocus = false;
            this.colNominativo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colNominativo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colNominativo.OptionsColumn.AllowMove = false;
            this.colNominativo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNominativo.OptionsFilter.AllowAutoFilter = false;
            this.colNominativo.OptionsFilter.AllowFilter = false;
            this.colNominativo.Visible = true;
            this.colNominativo.VisibleIndex = 1;
            this.colNominativo.Width = 468;
            // 
            // colNumeroREA
            // 
            this.colNumeroREA.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumeroREA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumeroREA.Caption = "Numero REA";
            this.colNumeroREA.FieldName = "NumeroREA";
            this.colNumeroREA.Name = "colNumeroREA";
            this.colNumeroREA.OptionsColumn.AllowEdit = false;
            this.colNumeroREA.OptionsColumn.AllowFocus = false;
            this.colNumeroREA.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colNumeroREA.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colNumeroREA.OptionsColumn.AllowMove = false;
            this.colNumeroREA.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNumeroREA.OptionsFilter.AllowAutoFilter = false;
            this.colNumeroREA.OptionsFilter.AllowFilter = false;
            this.colNumeroREA.Visible = true;
            this.colNumeroREA.VisibleIndex = 2;
            this.colNumeroREA.Width = 146;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.bindingSourceBaseTipoSoggetto;
            this.repositoryItemLookUpEdit1.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "IdElemento";
            // 
            // bindingSourceBaseTipoSoggetto
            // 
            this.bindingSourceBaseTipoSoggetto.AutoCreateObjects = false;
            this.bindingSourceBaseTipoSoggetto.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // barButtonItemExportResults
            // 
            this.barButtonItemExportResults.Caption = "Esporta risultati";
            this.barButtonItemExportResults.Id = 9;
            this.barButtonItemExportResults.Name = "barButtonItemExportResults";
            this.barButtonItemExportResults.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemExportResults_ItemClick);
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAzzera)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 2";
            // 
            // barButtonItemAzzera
            // 
            this.barButtonItemAzzera.Caption = "Azzera parametri";
            this.barButtonItemAzzera.Id = 10;
            this.barButtonItemAzzera.Name = "barButtonItemAzzera";
            this.barButtonItemAzzera.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAzzera_ItemClick);
            // 
            // CoopTemplateSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CoopTemplateSearch";
            this.Size = new System.Drawing.Size(729, 327);
            this.Load += new System.EventHandler(this.SearchCoopTemplate_Load);
            this.Shown += new System.EventHandler(this.CoopTemplateSearch_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlSearchParameter)).EndInit();
            this.panelControlSearchParameter.ResumeLayout(false);
            this.panelControlSearchParameter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumeroREA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodiceCooperativa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodiceFiscale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Denominazione.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSoggetto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSoggetto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseTipoSoggetto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OeF.Forms.Controls.PanelControl panelControlSearchParameter;
        private OeF.Forms.Controls.TextEdit NumeroREA;
        private OeF.Forms.Controls.TextEdit CodiceCooperativa;
        private OeF.Forms.Controls.TextEdit CodiceFiscale;
        private OeF.Forms.Controls.TextEdit Denominazione;
        private OeF.Forms.Controls.LabelControl labelControl5;
        private OeF.Forms.Controls.LabelControl labelControl4;
        private OeF.Forms.Controls.LabelControl labelControl3;
        private OeF.Forms.Controls.LabelControl labelControl2;
        private OeF.Forms.Controls.SimpleButton btnSearch;
        private DevExpress.XtraGrid.GridControl gridControlSoggetto;
        private OeF.Forms.BindingSourceBase bindingSourceBaseResults;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSoggetto;
        private DevExpress.XtraGrid.Columns.GridColumn colNominativo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private OeF.Forms.BindingSourceBase bindingSourceBaseTipoSoggetto;
        private DevExpress.XtraGrid.Columns.GridColumn colCodiceCooperativa;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroREA;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl lblResults;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExportResults;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAzzera;        

    }
}
