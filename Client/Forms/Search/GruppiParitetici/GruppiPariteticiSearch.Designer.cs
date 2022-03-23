namespace it.dedagroup.GVC.Client.Forms.Search.GruppiParitetici
{
    partial class GruppiPariteticiSearch
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
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonNuovoGruppo = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.memoEditNote = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dateEditTill = new it.dedagroup.GVC.Client.Forms.Controls.DateEdit();
            this.textEditNumeroAtto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateEditDataAtto = new it.dedagroup.GVC.Client.Forms.Controls.DateEdit();
            this.labelControl4 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.simpleButtonRicerca = new it.dedagroup.GVC.Client.Forms.Controls.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceGruppiParitetici = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdGruppoParitetico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataAtto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTill.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTill.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNumeroAtto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDataAtto.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDataAtto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGruppiParitetici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarManager
            // 
            this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonNuovoGruppo});
            this.BarManager.MaxItemId = 10;
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.gridControl1);
            this.ScrollableContent.Controls.Add(this.panelControl1);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 47);
            this.ScrollableContent.Size = new System.Drawing.Size(881, 321);
            // 
            // bar1
            // 
            this.bar1.BarName = "gpToolBar";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonNuovoGruppo)});
            this.bar1.Text = "gpToolBar";
            // 
            // barButtonNuovoGruppo
            // 
            this.barButtonNuovoGruppo.Caption = "Nuovo gruppo paritetico";
            this.barButtonNuovoGruppo.Id = 9;
            this.barButtonNuovoGruppo.Name = "barButtonNuovoGruppo";
            this.barButtonNuovoGruppo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonNuovoGruppo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonNuovoGruppo_ItemClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.memoEditNote);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.dateEditTill);
            this.panelControl1.Controls.Add(this.textEditNumeroAtto);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.dateEditDataAtto);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.simpleButtonRicerca);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(881, 121);
            this.panelControl1.TabIndex = 0;
            // 
            // memoEditNote
            // 
            this.memoEditNote.Location = new System.Drawing.Point(572, 7);
            this.memoEditNote.Name = "memoEditNote";
            this.memoEditNote.Size = new System.Drawing.Size(289, 50);
            this.memoEditNote.TabIndex = 22;
            this.memoEditNote.Visible = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(541, 10);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(23, 13);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Note";
            this.labelControl3.Visible = false;
            // 
            // dateEditTill
            // 
            this.dateEditTill.EditValue = null;
            this.dateEditTill.Location = new System.Drawing.Point(411, 6);
            this.dateEditTill.Name = "dateEditTill";
            this.dateEditTill.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditTill.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dateEditTill.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEditTill.Size = new System.Drawing.Size(100, 20);
            this.dateEditTill.TabIndex = 16;
            // 
            // textEditNumeroAtto
            // 
            this.textEditNumeroAtto.Location = new System.Drawing.Point(154, 6);
            this.textEditNumeroAtto.Name = "textEditNumeroAtto";
            this.textEditNumeroAtto.Size = new System.Drawing.Size(100, 20);
            this.textEditNumeroAtto.TabIndex = 20;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(115, 13);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Numero atto riferimento";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(35, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(101, 13);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "Data atto riferimento";
            // 
            // dateEditDataAtto
            // 
            this.dateEditDataAtto.EditValue = null;
            this.dateEditDataAtto.Location = new System.Drawing.Point(154, 35);
            this.dateEditDataAtto.Name = "dateEditDataAtto";
            this.dateEditDataAtto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDataAtto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dateEditDataAtto.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEditDataAtto.Size = new System.Drawing.Size(100, 20);
            this.dateEditDataAtto.TabIndex = 21;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(286, 9);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(119, 13);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Durata del gruppo fino al";
            // 
            // simpleButtonRicerca
            // 
            this.simpleButtonRicerca.Location = new System.Drawing.Point(341, 86);
            this.simpleButtonRicerca.Name = "simpleButtonRicerca";
            this.simpleButtonRicerca.Size = new System.Drawing.Size(160, 23);
            this.simpleButtonRicerca.TabIndex = 6;
            this.simpleButtonRicerca.Text = "Ricerca";
            this.simpleButtonRicerca.Click += new System.EventHandler(this.simpleButtonRicerca_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.bindingSourceGruppiParitetici;
            this.gridControl1.Location = new System.Drawing.Point(0, 122);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(881, 196);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseDoubleClick);
            // 
            // bindingSourceGruppiParitetici
            // 
            this.bindingSourceGruppiParitetici.AutoCreateObjects = false;
            this.bindingSourceGruppiParitetici.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.GruppoPariteticoFDT);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdGruppoParitetico,
            this.colDataAtto,
            this.colNote});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDataAtto, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIdGruppoParitetico
            // 
            this.colIdGruppoParitetico.Caption = "Numero atto riferimento";
            this.colIdGruppoParitetico.FieldName = "NumeroAtto";
            this.colIdGruppoParitetico.Name = "colIdGruppoParitetico";
            this.colIdGruppoParitetico.OptionsColumn.AllowEdit = false;
            this.colIdGruppoParitetico.OptionsColumn.AllowFocus = false;
            this.colIdGruppoParitetico.OptionsColumn.AllowIncrementalSearch = false;
            this.colIdGruppoParitetico.OptionsColumn.AllowMove = false;
            this.colIdGruppoParitetico.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIdGruppoParitetico.Visible = true;
            this.colIdGruppoParitetico.VisibleIndex = 0;
            this.colIdGruppoParitetico.Width = 147;
            // 
            // colDataAtto
            // 
            this.colDataAtto.Caption = "Data atto riferimento";
            this.colDataAtto.FieldName = "DataAtto";
            this.colDataAtto.Name = "colDataAtto";
            this.colDataAtto.OptionsColumn.AllowEdit = false;
            this.colDataAtto.OptionsColumn.AllowFocus = false;
            this.colDataAtto.OptionsColumn.AllowIncrementalSearch = false;
            this.colDataAtto.OptionsColumn.AllowMove = false;
            this.colDataAtto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDataAtto.Visible = true;
            this.colDataAtto.VisibleIndex = 1;
            this.colDataAtto.Width = 164;
            // 
            // colNote
            // 
            this.colNote.Caption = "Note";
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.OptionsColumn.AllowEdit = false;
            this.colNote.OptionsColumn.AllowFocus = false;
            this.colNote.OptionsColumn.AllowIncrementalSearch = false;
            this.colNote.OptionsColumn.AllowMove = false;
            this.colNote.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 2;
            this.colNote.Width = 322;
            // 
            // GruppiPariteticiSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "GruppiPariteticiSearch";
            this.Size = new System.Drawing.Size(881, 368);
            this.Load += new System.EventHandler(this.GruppiPariteticiSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTill.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTill.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNumeroAtto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDataAtto.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDataAtto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGruppiParitetici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonNuovoGruppo;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceGruppiParitetici;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGruppoParitetico;
        private DevExpress.XtraGrid.Columns.GridColumn colDataAtto;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private it.dedagroup.GVC.Client.Forms.Controls.SimpleButton simpleButtonRicerca;
        private DevExpress.XtraEditors.MemoEdit memoEditNote;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private it.dedagroup.GVC.Client.Forms.Controls.DateEdit dateEditTill;
        private DevExpress.XtraEditors.TextEdit textEditNumeroAtto;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private it.dedagroup.GVC.Client.Forms.Controls.DateEdit dateEditDataAtto;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl4;
    }
}
