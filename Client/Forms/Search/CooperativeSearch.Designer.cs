namespace it.dedagroup.GVC.Client.Forms.Search
{
    partial class CooperativeSearch
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
            this.gridControlCooperatives = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceCooperatives = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.gridViewCooperatives = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCooperativeRegistry_CooperativeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShortDescrizione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCooperativeRegistry_REANumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl4 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.panelControl1 = new it.dedagroup.GVC.Client.Forms.Controls.PanelControl();
            this.labelControl3 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.labelControl2 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.labelControl1 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.btnSearch = new it.dedagroup.GVC.Client.Forms.Controls.SimpleButton();
            this.textEdit3 = new it.dedagroup.GVC.Client.Forms.Controls.TextEdit();
            this.textEdit2 = new it.dedagroup.GVC.Client.Forms.Controls.TextEdit();
            this.textEdit1 = new it.dedagroup.GVC.Client.Forms.Controls.TextEdit();
            this.lblTitleSearchParameter = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCooperatives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCooperatives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCooperatives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.gridControlCooperatives);
            this.ScrollableContent.Controls.Add(this.panelControl1);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 24);
            this.ScrollableContent.Size = new System.Drawing.Size(800, 576);
            // 
            // BarButtonItemExport
            // 
            this.BarButtonItemExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemExport_ItemClick);
            // 
            // BarButtonItemPrint
            // 
            this.BarButtonItemPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemPrint_ItemClick);
            // 
            // gridControlCooperatives
            // 
            this.gridControlCooperatives.DataSource = this.bindingSourceCooperatives;
            this.gridControlCooperatives.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlCooperatives.EmbeddedNavigator.Name = "";
            this.gridControlCooperatives.Location = new System.Drawing.Point(0, 137);
            this.gridControlCooperatives.MainView = this.gridViewCooperatives;
            this.gridControlCooperatives.Name = "gridControlCooperatives";
            this.gridControlCooperatives.Size = new System.Drawing.Size(800, 439);
            this.gridControlCooperatives.TabIndex = 4;
            this.gridControlCooperatives.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCooperatives,
            this.gridView2});
            this.gridControlCooperatives.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlCooperatives_MouseDoubleClick);
            // 
            // bindingSourceCooperatives
            // 
            this.bindingSourceCooperatives.AutoCreateObjects = false;
            this.bindingSourceCooperatives.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.CooperativaFDT);
            // 
            // gridViewCooperatives
            // 
            this.gridViewCooperatives.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCooperativeRegistry_CooperativeCode,
            this.colShortDescrizione,
            this.colTaxCode,
            this.colCooperativeRegistry_REANumber});
            this.gridViewCooperatives.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewCooperatives.GridControl = this.gridControlCooperatives;
            this.gridViewCooperatives.Name = "gridViewCooperatives";
            this.gridViewCooperatives.OptionsBehavior.Editable = false;
            this.gridViewCooperatives.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewCooperatives.OptionsView.ShowGroupPanel = false;
            this.gridViewCooperatives.OptionsView.ShowIndicator = false;
            this.gridViewCooperatives.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colShortDescrizione, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colCooperativeRegistry_CooperativeCode
            // 
            this.colCooperativeRegistry_CooperativeCode.Caption = "Codice";
            this.colCooperativeRegistry_CooperativeCode.FieldName = "CooperativeRegistry_CooperativeCode";
            this.colCooperativeRegistry_CooperativeCode.Name = "colCooperativeRegistry_CooperativeCode";
            this.colCooperativeRegistry_CooperativeCode.OptionsColumn.AllowEdit = false;
            this.colCooperativeRegistry_CooperativeCode.OptionsColumn.AllowFocus = false;
            this.colCooperativeRegistry_CooperativeCode.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colCooperativeRegistry_CooperativeCode.OptionsColumn.AllowMove = false;
            this.colCooperativeRegistry_CooperativeCode.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCooperativeRegistry_CooperativeCode.OptionsFilter.AllowAutoFilter = false;
            this.colCooperativeRegistry_CooperativeCode.OptionsFilter.AllowFilter = false;
            this.colCooperativeRegistry_CooperativeCode.Visible = true;
            this.colCooperativeRegistry_CooperativeCode.VisibleIndex = 0;
            // 
            // colShortDescrizione
            // 
            this.colShortDescrizione.Caption = "Denominazione";
            this.colShortDescrizione.FieldName = "DescrizioneBreve";
            this.colShortDescrizione.Name = "colShortDescrizione";
            this.colShortDescrizione.Visible = true;
            this.colShortDescrizione.VisibleIndex = 1;
            this.colShortDescrizione.Width = 226;
            // 
            // colTaxCode
            // 
            this.colTaxCode.Caption = "Codice fiscale";
            this.colTaxCode.FieldName = "CodiceFiscale";
            this.colTaxCode.Name = "colTaxCode";
            this.colTaxCode.Visible = true;
            this.colTaxCode.VisibleIndex = 2;
            this.colTaxCode.Width = 207;
            // 
            // colCooperativeRegistry_REANumber
            // 
            this.colCooperativeRegistry_REANumber.Caption = "Numero REA";
            this.colCooperativeRegistry_REANumber.FieldName = "CooperativeRegistry_REANumber";
            this.colCooperativeRegistry_REANumber.Name = "colCooperativeRegistry_REANumber";
            this.colCooperativeRegistry_REANumber.Visible = true;
            this.colCooperativeRegistry_REANumber.VisibleIndex = 3;
            this.colCooperativeRegistry_REANumber.Width = 80;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControlCooperatives;
            this.gridView2.Name = "gridView2";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(3, 118);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(50, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Risultati:";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnSearch);
            this.panelControl1.Controls.Add(this.textEdit3);
            this.panelControl1.Controls.Add(this.textEdit2);
            this.panelControl1.Controls.Add(this.textEdit1);
            this.panelControl1.Controls.Add(this.lblTitleSearchParameter);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 137);
            this.panelControl1.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(83, 94);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Numero REA";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(78, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Codice fiscale";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(71, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Denominazione";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(444, 58);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 33);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Ricerca";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(152, 91);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(225, 20);
            this.textEdit3.TabIndex = 1;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(152, 65);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(225, 20);
            this.textEdit2.TabIndex = 1;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(152, 39);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(225, 20);
            this.textEdit1.TabIndex = 1;
            // 
            // lblTitleSearchParameter
            // 
            this.lblTitleSearchParameter.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTitleSearchParameter.Appearance.Options.UseFont = true;
            this.lblTitleSearchParameter.Location = new System.Drawing.Point(3, 6);
            this.lblTitleSearchParameter.Name = "lblTitleSearchParameter";
            this.lblTitleSearchParameter.Size = new System.Drawing.Size(166, 13);
            this.lblTitleSearchParameter.TabIndex = 0;
            this.lblTitleSearchParameter.Text = "Compila i parametri di ricerca";
            // 
            // CooperativeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "CooperativeSearch";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.SearchCooperative_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCooperatives)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCooperatives)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCooperatives)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlCooperatives;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCooperatives;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl4;
        private it.dedagroup.GVC.Client.Forms.Controls.PanelControl panelControl1;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl3;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl2;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl1;
        private it.dedagroup.GVC.Client.Forms.Controls.SimpleButton btnSearch;
        private it.dedagroup.GVC.Client.Forms.Controls.TextEdit textEdit3;
        private it.dedagroup.GVC.Client.Forms.Controls.TextEdit textEdit2;
        private it.dedagroup.GVC.Client.Forms.Controls.TextEdit textEdit1;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl lblTitleSearchParameter;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceCooperatives;
        private DevExpress.XtraGrid.Columns.GridColumn colShortDescrizione;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCooperativeRegistry_REANumber;
        private DevExpress.XtraGrid.Columns.GridColumn colCooperativeRegistry_CooperativeCode;
    }
}
