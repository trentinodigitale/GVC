namespace it.dedagroup.GVC.Client.Forms.Registry
{
    partial class RicercaSoggetto
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
            this.bindingSourceSoggetto = new OeF.Forms.BindingSourceBase(this.components);
            this.bindingSourceTipoSoggetto = new OeF.Forms.BindingSourceBase(this.components);
            this.panelControl1 = new OeF.Forms.Controls.PanelControl();
            this.labelControl2 = new OeF.Forms.Controls.LabelControl();
            this.Denominazione = new OeF.Forms.Controls.TextEdit();
            this.labelControl4 = new OeF.Forms.Controls.LabelControl();
            this.btnAddSubject = new OeF.Forms.Controls.SimpleButton();
            this.btnSearch = new OeF.Forms.Controls.SimpleButton();
            this.CodiceFiscale = new OeF.Forms.Controls.TextEdit();
            this.gridControlSoggetti = new DevExpress.XtraGrid.GridControl();
            this.gridViewSoggetti = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTipoSoggetto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colNominativo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodiceFiscale = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSoggetto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoSoggetto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Denominazione.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodiceFiscale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSoggetti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSoggetti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelButtons
            // 
            this.PanelButtons.Location = new System.Drawing.Point(0, 412);
            this.PanelButtons.Size = new System.Drawing.Size(657, 40);
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.gridControlSoggetti);
            this.ScrollableContent.Controls.Add(this.panelControl1);
            this.ScrollableContent.Size = new System.Drawing.Size(657, 452);
            this.ScrollableContent.Controls.SetChildIndex(this.panelControl1, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.PanelButtons, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.gridControlSoggetti, 0);
            // 
            // bindingSourceSoggetto
            // 
            this.bindingSourceSoggetto.AutoCreateObjects = false;
            this.bindingSourceSoggetto.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.SoggettoPerVisualizzazioneFDT);
            this.bindingSourceSoggetto.CurrentItemChanged += new System.EventHandler(this.bindingSourceSoggetto_CurrentItemChanged);
            // 
            // bindingSourceTipoSoggetto
            // 
            this.bindingSourceTipoSoggetto.AutoCreateObjects = false;
            this.bindingSourceTipoSoggetto.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.Denominazione);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.btnAddSubject);
            this.panelControl1.Controls.Add(this.btnSearch);
            this.panelControl1.Controls.Add(this.CodiceFiscale);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(657, 96);
            this.panelControl1.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(43, 19);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Nominativo";
            // 
            // Denominazione
            // 
            this.Denominazione.Location = new System.Drawing.Point(102, 16);
            this.Denominazione.Name = "Denominazione";
            this.Denominazione.Size = new System.Drawing.Size(288, 20);
            this.Denominazione.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(31, 45);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(65, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Codice fiscale";
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Location = new System.Drawing.Point(531, 35);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(107, 23);
            this.btnAddSubject.TabIndex = 1;
            this.btnAddSubject.Text = "Aggiungi soggetto";
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(207, 68);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Ricerca";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // CodiceFiscale
            // 
            this.CodiceFiscale.Location = new System.Drawing.Point(102, 42);
            this.CodiceFiscale.Name = "CodiceFiscale";
            this.CodiceFiscale.Size = new System.Drawing.Size(139, 20);
            this.CodiceFiscale.TabIndex = 0;
            // 
            // gridControlSoggetti
            // 
            this.gridControlSoggetti.DataSource = this.bindingSourceSoggetto;
            this.gridControlSoggetti.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlSoggetti.Location = new System.Drawing.Point(0, 96);
            this.gridControlSoggetti.MainView = this.gridViewSoggetti;
            this.gridControlSoggetti.Name = "gridControlSoggetti";
            this.gridControlSoggetti.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControlSoggetti.Size = new System.Drawing.Size(657, 310);
            this.gridControlSoggetti.TabIndex = 2;
            this.gridControlSoggetti.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSoggetti});
            this.gridControlSoggetti.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlSoggetti_MouseDoubleClick);
            // 
            // gridViewSoggetti
            // 
            this.gridViewSoggetti.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTipoSoggetto,
            this.colNominativo,
            this.colCodiceFiscale});
            this.gridViewSoggetti.GridControl = this.gridControlSoggetti;
            this.gridViewSoggetti.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gridViewSoggetti.Name = "gridViewSoggetti";
            this.gridViewSoggetti.OptionsView.ShowGroupPanel = false;
            this.gridViewSoggetti.OptionsView.ShowIndicator = false;
            this.gridViewSoggetti.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNominativo, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIdTipoSoggetto
            // 
            this.colIdTipoSoggetto.Caption = "Tipo soggetto";
            this.colIdTipoSoggetto.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colIdTipoSoggetto.FieldName = "IdTipoSoggetto";
            this.colIdTipoSoggetto.Name = "colIdTipoSoggetto";
            this.colIdTipoSoggetto.OptionsColumn.AllowEdit = false;
            this.colIdTipoSoggetto.OptionsColumn.AllowFocus = false;
            this.colIdTipoSoggetto.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIdTipoSoggetto.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colIdTipoSoggetto.OptionsColumn.AllowMove = false;
            this.colIdTipoSoggetto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIdTipoSoggetto.OptionsFilter.AllowAutoFilter = false;
            this.colIdTipoSoggetto.OptionsFilter.AllowFilter = false;
            this.colIdTipoSoggetto.Visible = true;
            this.colIdTipoSoggetto.VisibleIndex = 0;
            this.colIdTipoSoggetto.Width = 158;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.bindingSourceTipoSoggetto;
            this.repositoryItemLookUpEdit1.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "IdElemento";
            // 
            // colNominativo
            // 
            this.colNominativo.Caption = "Nominativo";
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
            this.colNominativo.Width = 338;
            // 
            // colCodiceFiscale
            // 
            this.colCodiceFiscale.Caption = "Codice fiscale";
            this.colCodiceFiscale.FieldName = "CodiceFiscale";
            this.colCodiceFiscale.Name = "colCodiceFiscale";
            this.colCodiceFiscale.OptionsColumn.AllowEdit = false;
            this.colCodiceFiscale.OptionsColumn.AllowFocus = false;
            this.colCodiceFiscale.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCodiceFiscale.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colCodiceFiscale.OptionsColumn.AllowMove = false;
            this.colCodiceFiscale.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCodiceFiscale.OptionsFilter.AllowAutoFilter = false;
            this.colCodiceFiscale.OptionsFilter.AllowFilter = false;
            this.colCodiceFiscale.Visible = true;
            this.colCodiceFiscale.VisibleIndex = 2;
            this.colCodiceFiscale.Width = 171;
            // 
            // RicercaSoggetto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "RicercaSoggetto";
            this.Size = new System.Drawing.Size(657, 476);
            this.Shown += new System.EventHandler(this.RicercaSoggetto_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSoggetto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoSoggetto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Denominazione.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodiceFiscale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSoggetti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSoggetti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OeF.Forms.BindingSourceBase bindingSourceSoggetto;
        private OeF.Forms.BindingSourceBase bindingSourceTipoSoggetto;
        private DevExpress.XtraGrid.GridControl gridControlSoggetti;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSoggetti;
        private OeF.Forms.Controls.PanelControl panelControl1;
        private OeF.Forms.Controls.SimpleButton btnSearch;
        private OeF.Forms.Controls.LabelControl labelControl2;
        private OeF.Forms.Controls.TextEdit Denominazione;
        private OeF.Forms.Controls.LabelControl labelControl4;
        private OeF.Forms.Controls.TextEdit CodiceFiscale;
        private OeF.Forms.Controls.SimpleButton btnAddSubject;
        private DevExpress.XtraGrid.Columns.GridColumn colCodiceFiscale;
        private DevExpress.XtraGrid.Columns.GridColumn colNominativo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoSoggetto;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    }
}
