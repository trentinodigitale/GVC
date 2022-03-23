namespace it.dedagroup.GVC.Client.Forms.Aggiornamenti
{
    partial class AggiornamentiMain
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
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceSegnalazioni = new OeF.Forms.BindingSourceBase(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colVisible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescrizione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataSegnalazione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApply = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonDetail = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colIdTipoSegnalazione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bindingSourceNotAppliable = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSegnalazioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNotAppliable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // PanelButtons
            // 
            this.PanelButtons.Location = new System.Drawing.Point(0, 297);
            this.PanelButtons.Size = new System.Drawing.Size(606, 40);
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.gridControl1);
            this.ScrollableContent.Size = new System.Drawing.Size(606, 337);
            this.ScrollableContent.Controls.SetChildIndex(this.gridControl1, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.PanelButtons, 0);
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.bindingSourceSegnalazioni;
            this.gridControl1.Location = new System.Drawing.Point(3, 6);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemButtonDetail,
            this.repositoryItemComboBox1,
            this.repositoryItemTextEdit1,
            this.repositoryItemCheckEdit2,
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(593, 285);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bindingSourceSegnalazioni
            // 
            this.bindingSourceSegnalazioni.AutoCreateObjects = false;
            this.bindingSourceSegnalazioni.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.SegnalazioneFDT);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colVisible,
            this.colDescrizione,
            this.colDataSegnalazione,
            this.colApply,
            this.colDetail,
            this.colIdTipoSegnalazione});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridView1_CustomRowCellEdit);
            // 
            // colVisible
            // 
            this.colVisible.Caption = "Visibile";
            this.colVisible.FieldName = "Visible";
            this.colVisible.Name = "colVisible";
            this.colVisible.Visible = true;
            this.colVisible.VisibleIndex = 2;
            this.colVisible.Width = 76;
            // 
            // colDescrizione
            // 
            this.colDescrizione.Caption = "Descrizione";
            this.colDescrizione.FieldName = "Descrizione";
            this.colDescrizione.Name = "colDescrizione";
            this.colDescrizione.OptionsColumn.AllowEdit = false;
            this.colDescrizione.Visible = true;
            this.colDescrizione.VisibleIndex = 0;
            this.colDescrizione.Width = 232;
            // 
            // colDataSegnalazione
            // 
            this.colDataSegnalazione.Caption = "Data segnalazione";
            this.colDataSegnalazione.FieldName = "DataSegnalazione";
            this.colDataSegnalazione.Name = "colDataSegnalazione";
            this.colDataSegnalazione.OptionsColumn.AllowEdit = false;
            this.colDataSegnalazione.Visible = true;
            this.colDataSegnalazione.VisibleIndex = 1;
            this.colDataSegnalazione.Width = 119;
            // 
            // colApply
            // 
            this.colApply.Caption = "Applica";
            this.colApply.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colApply.FieldName = "Apply";
            this.colApply.Name = "colApply";
            this.colApply.Visible = true;
            this.colApply.VisibleIndex = 3;
            // 
            // colDetail
            // 
            this.colDetail.Caption = "Dettagli";
            this.colDetail.ColumnEdit = this.repositoryItemButtonDetail;
            this.colDetail.Name = "colDetail";
            this.colDetail.OptionsColumn.AllowMove = false;
            this.colDetail.OptionsColumn.AllowSize = false;
            this.colDetail.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDetail.OptionsColumn.FixedWidth = true;
            this.colDetail.OptionsColumn.ReadOnly = true;
            this.colDetail.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colDetail.Visible = true;
            this.colDetail.VisibleIndex = 4;
            this.colDetail.Width = 70;
            // 
            // repositoryItemButtonDetail
            // 
            this.repositoryItemButtonDetail.AutoHeight = false;
            this.repositoryItemButtonDetail.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", 58, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null)});
            this.repositoryItemButtonDetail.Name = "repositoryItemButtonDetail";
            this.repositoryItemButtonDetail.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonDetail_ButtonClick);
            // 
            // colIdTipoSegnalazione
            // 
            this.colIdTipoSegnalazione.Caption = "IdTipoSegnalazione";
            this.colIdTipoSegnalazione.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colIdTipoSegnalazione.FieldName = "IdTipoSegnalazione";
            this.colIdTipoSegnalazione.Name = "colIdTipoSegnalazione";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.DataSource = this.bindingSourceNotAppliable;
            this.repositoryItemLookUpEdit1.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ReadOnly = true;
            this.repositoryItemLookUpEdit1.ValueMember = "Apply";
            // 
            // bindingSourceNotAppliable
            // 
            this.bindingSourceNotAppliable.AutoCreateObjects = false;
            this.bindingSourceNotAppliable.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.SegnalazioneFDT);
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.repositoryItemTextEdit1.Appearance.Options.UseBackColor = true;
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.NullText = "Non applicabile";
            this.repositoryItemTextEdit1.ReadOnly = true;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AllowGrayed = true;
            this.repositoryItemCheckEdit2.Appearance.BackColor = System.Drawing.Color.IndianRed;
            this.repositoryItemCheckEdit2.Appearance.BackColor2 = System.Drawing.Color.IndianRed;
            this.repositoryItemCheckEdit2.Appearance.Options.UseBackColor = true;
            this.repositoryItemCheckEdit2.AppearanceFocused.BackColor = System.Drawing.Color.IndianRed;
            this.repositoryItemCheckEdit2.AppearanceFocused.BackColor2 = System.Drawing.Color.IndianRed;
            this.repositoryItemCheckEdit2.AppearanceFocused.Options.UseBackColor = true;
            this.repositoryItemCheckEdit2.AppearanceReadOnly.BackColor = System.Drawing.Color.IndianRed;
            this.repositoryItemCheckEdit2.AppearanceReadOnly.BackColor2 = System.Drawing.Color.IndianRed;
            this.repositoryItemCheckEdit2.AppearanceReadOnly.Options.UseBackColor = true;
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.ReadOnly = true;
            this.repositoryItemCheckEdit2.ValueGrayed = false;
            // 
            // AggiornamentiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "AggiornamentiMain";
            this.Size = new System.Drawing.Size(606, 361);
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSegnalazioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNotAppliable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private OeF.Forms.BindingSourceBase bindingSourceSegnalazioni;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colVisible;
        private DevExpress.XtraGrid.Columns.GridColumn colDescrizione;
        private DevExpress.XtraGrid.Columns.GridColumn colDataSegnalazione;
        private DevExpress.XtraGrid.Columns.GridColumn colApply;
        private DevExpress.XtraGrid.Columns.GridColumn colDetail;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoSegnalazione;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceNotAppliable;
        
    }
}
