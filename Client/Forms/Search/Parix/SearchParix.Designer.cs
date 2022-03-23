namespace it.dedagroup.GVC.Client.Forms.Search.Parix
{
    partial class SearchParix
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
            this.components = new System.ComponentModel.Container();
            this.panelControl1 = new OeF.Forms.Controls.PanelControl();
            this.checkEditIncludeCeased = new OeF.Forms.Controls.CheckEdit();
            this.TxtBxRea = new OeF.Forms.Controls.TextEdit();
            this.TxtBxCF = new OeF.Forms.Controls.TextEdit();
            this.labelControl3 = new OeF.Forms.Controls.LabelControl();
            this.labelControl2 = new OeF.Forms.Controls.LabelControl();
            this.labelControl1 = new OeF.Forms.Controls.LabelControl();
            this.TxtBxDenominazione = new OeF.Forms.Controls.TextEdit();
            this.btnSearch = new OeF.Forms.Controls.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceBase1 = new OeF.Forms.BindingSourceBase(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDenominazione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodiceFiscale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegistroCooperativa_NumeroREA = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditIncludeCeased.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBxRea.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBxCF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBxDenominazione.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBase1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // PanelButtons
            // 
            this.PanelButtons.Location = new System.Drawing.Point(0, 359);
            this.PanelButtons.Size = new System.Drawing.Size(625, 40);
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.gridControl1);
            this.ScrollableContent.Controls.Add(this.panelControl1);
            this.ScrollableContent.Size = new System.Drawing.Size(625, 399);
            this.ScrollableContent.Controls.SetChildIndex(this.panelControl1, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.gridControl1, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.PanelButtons, 0);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.checkEditIncludeCeased);
            this.panelControl1.Controls.Add(this.TxtBxRea);
            this.panelControl1.Controls.Add(this.TxtBxCF);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.TxtBxDenominazione);
            this.panelControl1.Controls.Add(this.btnSearch);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(625, 113);
            this.panelControl1.TabIndex = 0;
            // 
            // checkEditIncludeCeased
            // 
            this.checkEditIncludeCeased.EditValue = true;
            this.checkEditIncludeCeased.Location = new System.Drawing.Point(484, 20);
            this.checkEditIncludeCeased.Name = "checkEditIncludeCeased";
            this.checkEditIncludeCeased.Properties.Caption = "Includere cessate";
            this.checkEditIncludeCeased.Size = new System.Drawing.Size(109, 19);
            this.checkEditIncludeCeased.TabIndex = 4;
            // 
            // TxtBxRea
            // 
            this.TxtBxRea.Location = new System.Drawing.Point(83, 19);
            this.TxtBxRea.Name = "TxtBxRea";
            this.TxtBxRea.Size = new System.Drawing.Size(66, 20);
            this.TxtBxRea.TabIndex = 1;
            this.TxtBxRea.EditValueChanged += new System.EventHandler(this.TxtBxDenominazione_EditValueChanged);
            // 
            // TxtBxCF
            // 
            this.TxtBxCF.Location = new System.Drawing.Point(271, 19);
            this.TxtBxCF.Name = "TxtBxCF";
            this.TxtBxCF.Size = new System.Drawing.Size(196, 20);
            this.TxtBxCF.TabIndex = 2;
            this.TxtBxCF.EditValueChanged += new System.EventHandler(this.TxtBxDenominazione_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 22);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Numero REA";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(198, 22);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Codice Fiscale";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Denominazione";
            // 
            // TxtBxDenominazione
            // 
            this.TxtBxDenominazione.Location = new System.Drawing.Point(83, 49);
            this.TxtBxDenominazione.Name = "TxtBxDenominazione";
            this.TxtBxDenominazione.Size = new System.Drawing.Size(384, 20);
            this.TxtBxDenominazione.TabIndex = 3;
            this.TxtBxDenominazione.EditValueChanged += new System.EventHandler(this.TxtBxDenominazione_EditValueChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(225, 84);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Ricerca";
            this.btnSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.bindingSourceBase1;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(0, 113);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(625, 286);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseDoubleClick);
            // 
            // bindingSourceBase1
            // 
            this.bindingSourceBase1.AutoCreateObjects = false;
            this.bindingSourceBase1.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.CooperativaFDT);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDenominazione,
            this.colCodiceFiscale,
            this.colRegistroCooperativa_NumeroREA});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // colDenominazione
            // 
            this.colDenominazione.Caption = "Denominazione";
            this.colDenominazione.FieldName = "Denominazione";
            this.colDenominazione.Name = "colDenominazione";
            this.colDenominazione.OptionsColumn.AllowEdit = false;
            this.colDenominazione.Visible = true;
            this.colDenominazione.VisibleIndex = 0;
            this.colDenominazione.Width = 415;
            // 
            // colCodiceFiscale
            // 
            this.colCodiceFiscale.Caption = "Codice Fiscale";
            this.colCodiceFiscale.FieldName = "CodiceFiscale";
            this.colCodiceFiscale.Name = "colCodiceFiscale";
            this.colCodiceFiscale.OptionsColumn.AllowEdit = false;
            this.colCodiceFiscale.Visible = true;
            this.colCodiceFiscale.VisibleIndex = 1;
            this.colCodiceFiscale.Width = 105;
            // 
            // colRegistroCooperativa_NumeroREA
            // 
            this.colRegistroCooperativa_NumeroREA.Caption = "Numero REA";
            this.colRegistroCooperativa_NumeroREA.FieldName = "RegistroCooperativa_NumeroREA";
            this.colRegistroCooperativa_NumeroREA.Name = "colRegistroCooperativa_NumeroREA";
            this.colRegistroCooperativa_NumeroREA.OptionsColumn.AllowEdit = false;
            this.colRegistroCooperativa_NumeroREA.Visible = true;
            this.colRegistroCooperativa_NumeroREA.VisibleIndex = 2;
            this.colRegistroCooperativa_NumeroREA.Width = 101;
            // 
            // SearchParix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "SearchParix";
            this.Size = new System.Drawing.Size(625, 423);
            this.Shown += new System.EventHandler(this.SearchParix_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditIncludeCeased.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBxRea.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBxCF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBxDenominazione.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBase1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OeF.Forms.Controls.PanelControl panelControl1;
        private OeF.Forms.Controls.SimpleButton btnSearch;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private OeF.Forms.Controls.TextEdit TxtBxDenominazione;
        private OeF.Forms.BindingSourceBase bindingSourceBase1;
        private DevExpress.XtraGrid.Columns.GridColumn colDenominazione;
        private OeF.Forms.Controls.TextEdit TxtBxCF;
        private OeF.Forms.Controls.LabelControl labelControl3;
        private OeF.Forms.Controls.LabelControl labelControl2;
        private OeF.Forms.Controls.LabelControl labelControl1;
        private OeF.Forms.Controls.TextEdit TxtBxRea;
        private DevExpress.XtraGrid.Columns.GridColumn colCodiceFiscale;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistroCooperativa_NumeroREA;
        private OeF.Forms.Controls.CheckEdit checkEditIncludeCeased;
    }
}
