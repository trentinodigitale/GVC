namespace it.dedagroup.GVC.Client.Forms.Search.GruppiParitetici
{
    partial class CooperativeGruppoParitetico
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemAggiungi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRimuovi = new DevExpress.XtraBars.BarButtonItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceCooperative = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnDirigente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colRegistroCooperativa_IdRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDenominazione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCooperative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // BarManager
            // 
            this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemAggiungi,
            this.barButtonItemRimuovi});
            this.BarManager.MaxItemId = 11;
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.gridControl1);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 47);
            this.ScrollableContent.Size = new System.Drawing.Size(526, 286);
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.OptionsColumn.AllowEdit = false;
            this.colStatus.OptionsColumn.AllowFocus = false;
            this.colStatus.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colStatus.OptionsColumn.AllowIncrementalSearch = false;
            this.colStatus.OptionsColumn.AllowMove = false;
            this.colStatus.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            // 
            // bar1
            // 
            this.bar1.BarName = "CoopToolBar";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAggiungi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemRimuovi)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.Text = "CoopToolBar";
            // 
            // barButtonItemAggiungi
            // 
            this.barButtonItemAggiungi.Caption = "Aggiungi";
            this.barButtonItemAggiungi.Id = 9;
            this.barButtonItemAggiungi.Name = "barButtonItemAggiungi";
            this.barButtonItemAggiungi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItemAggiungi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAggiungi_ItemClick);
            // 
            // barButtonItemRimuovi
            // 
            this.barButtonItemRimuovi.Caption = "Rimuovi";
            this.barButtonItemRimuovi.Id = 10;
            this.barButtonItemRimuovi.Name = "barButtonItemRimuovi";
            this.barButtonItemRimuovi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItemRimuovi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemRimuovi_ItemClick);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSourceCooperative;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRadioGroup1,
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2});
            this.gridControl1.Size = new System.Drawing.Size(526, 286);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // bindingSourceCooperative
            // 
            this.bindingSourceCooperative.AutoCreateObjects = false;
            this.bindingSourceCooperative.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.CooperativaFDT);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnDirigente,
            this.colRegistroCooperativa_IdRegistro,
            this.colDenominazione,
            this.colStatus});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout);
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colStatus;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual;
            styleFormatCondition1.Value1 = "100";
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colRegistroCooperativa_IdRegistro, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumnDirigente
            // 
            this.gridColumnDirigente.Caption = "Ruolo direzione";
            this.gridColumnDirigente.ColumnEdit = this.repositoryItemCheckEdit2;
            this.gridColumnDirigente.FieldName = "RegistroCooperativa_Dirigente";
            this.gridColumnDirigente.Name = "gridColumnDirigente";
            this.gridColumnDirigente.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnDirigente.OptionsColumn.AllowIncrementalSearch = false;
            this.gridColumnDirigente.OptionsColumn.AllowMove = false;
            this.gridColumnDirigente.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnDirigente.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.gridColumnDirigente.Visible = true;
            this.gridColumnDirigente.VisibleIndex = 2;
            this.gridColumnDirigente.Width = 94;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Value;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.RadioGroupIndex = 2;
            this.repositoryItemCheckEdit2.CheckedChanged += new System.EventHandler(this.repositoryItemCheckEdit2_CheckedChanged);
            // 
            // colRegistroCooperativa_IdRegistro
            // 
            this.colRegistroCooperativa_IdRegistro.Caption = "Codice cooperativa";
            this.colRegistroCooperativa_IdRegistro.FieldName = "RegistroCooperativa_IdRegistro";
            this.colRegistroCooperativa_IdRegistro.Name = "colRegistroCooperativa_IdRegistro";
            this.colRegistroCooperativa_IdRegistro.OptionsColumn.AllowEdit = false;
            this.colRegistroCooperativa_IdRegistro.OptionsColumn.AllowFocus = false;
            this.colRegistroCooperativa_IdRegistro.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colRegistroCooperativa_IdRegistro.OptionsColumn.AllowIncrementalSearch = false;
            this.colRegistroCooperativa_IdRegistro.OptionsColumn.AllowMove = false;
            this.colRegistroCooperativa_IdRegistro.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colRegistroCooperativa_IdRegistro.Visible = true;
            this.colRegistroCooperativa_IdRegistro.VisibleIndex = 0;
            this.colRegistroCooperativa_IdRegistro.Width = 99;
            // 
            // colDenominazione
            // 
            this.colDenominazione.Caption = "Denominazione";
            this.colDenominazione.FieldName = "Denominazione";
            this.colDenominazione.Name = "colDenominazione";
            this.colDenominazione.OptionsColumn.AllowEdit = false;
            this.colDenominazione.OptionsColumn.AllowFocus = false;
            this.colDenominazione.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDenominazione.OptionsColumn.AllowIncrementalSearch = false;
            this.colDenominazione.OptionsColumn.AllowMove = false;
            this.colDenominazione.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDenominazione.Visible = true;
            this.colDenominazione.VisibleIndex = 1;
            this.colDenominazione.Width = 312;
            // 
            // repositoryItemRadioGroup1
            // 
            this.repositoryItemRadioGroup1.AllowFocused = false;
            this.repositoryItemRadioGroup1.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem()});
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // CooperativeGruppoParitetico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CooperativeGruppoParitetico";
            this.Size = new System.Drawing.Size(526, 333);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCooperative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAggiungi;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRimuovi;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceCooperative;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDirigente;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistroCooperativa_IdRegistro;
        private DevExpress.XtraGrid.Columns.GridColumn colDenominazione;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
    }
}
