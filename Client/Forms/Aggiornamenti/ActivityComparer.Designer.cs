namespace it.dedagroup.GVC.Client.Forms.Aggiornamenti
{
    partial class ActivityComparer
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
            this.bindingSourceBaseCurrentActivitiesParix = new OeF.Forms.BindingSourceBase(this.components);
            this.bindingSourceActivityTypes = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.bindingSourceBaseUpdatedActivitiesParix = new OeF.Forms.BindingSourceBase(this.components);
            this.gridControlCurrentActivities = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDataInizio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImportanza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoAttivita = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colIdTipoAttivita1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridControlUpdatedActivities = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDataInizio1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImportanza1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoAttivita2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colIdTipoAttivita3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseCurrentActivitiesParix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActivityTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseUpdatedActivitiesParix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCurrentActivities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUpdatedActivities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.SplitterPosition = 136;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlCurrentActivities);
            this.groupControl1.Size = new System.Drawing.Size(628, 132);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControlUpdatedActivities);
            this.groupControl2.Size = new System.Drawing.Size(628, 130);
            // 
            // bindingSourceBaseCurrentActivitiesParix
            // 
            this.bindingSourceBaseCurrentActivitiesParix.AutoCreateObjects = false;
            this.bindingSourceBaseCurrentActivitiesParix.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.AttivitaFDT);
            // 
            // bindingSourceActivityTypes
            // 
            this.bindingSourceActivityTypes.AutoCreateObjects = false;
            this.bindingSourceActivityTypes.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // bindingSourceBaseUpdatedActivitiesParix
            // 
            this.bindingSourceBaseUpdatedActivitiesParix.AutoCreateObjects = false;
            this.bindingSourceBaseUpdatedActivitiesParix.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.AttivitaFDT);
            // 
            // gridControlCurrentActivities
            // 
            this.gridControlCurrentActivities.DataSource = this.bindingSourceBaseCurrentActivitiesParix;
            this.gridControlCurrentActivities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCurrentActivities.Location = new System.Drawing.Point(2, 20);
            this.gridControlCurrentActivities.MainView = this.gridView1;
            this.gridControlCurrentActivities.Name = "gridControlCurrentActivities";
            this.gridControlCurrentActivities.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2});
            this.gridControlCurrentActivities.Size = new System.Drawing.Size(624, 110);
            this.gridControlCurrentActivities.TabIndex = 0;
            this.gridControlCurrentActivities.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDataInizio,
            this.colImportanza,
            this.colIdTipoAttivita,
            this.colIdTipoAttivita1});
            this.gridView1.GridControl = this.gridControlCurrentActivities;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colDataInizio
            // 
            this.colDataInizio.Caption = "Data inizio";
            this.colDataInizio.DisplayFormat.FormatString = "d";
            this.colDataInizio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDataInizio.FieldName = "DataInizio";
            this.colDataInizio.Name = "colDataInizio";
            this.colDataInizio.Visible = true;
            this.colDataInizio.VisibleIndex = 3;
            this.colDataInizio.Width = 107;
            // 
            // colImportanza
            // 
            this.colImportanza.Caption = "Importanza";
            this.colImportanza.FieldName = "Importanza";
            this.colImportanza.Name = "colImportanza";
            this.colImportanza.Visible = true;
            this.colImportanza.VisibleIndex = 2;
            this.colImportanza.Width = 79;
            // 
            // colIdTipoAttivita
            // 
            this.colIdTipoAttivita.Caption = "Codice";
            this.colIdTipoAttivita.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colIdTipoAttivita.FieldName = "IdTipoAttivita";
            this.colIdTipoAttivita.Name = "colIdTipoAttivita";
            this.colIdTipoAttivita.Visible = true;
            this.colIdTipoAttivita.VisibleIndex = 0;
            this.colIdTipoAttivita.Width = 99;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.bindingSourceActivityTypes;
            this.repositoryItemLookUpEdit1.DisplayMember = "Codice";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "IdElemento";
            // 
            // colIdTipoAttivita1
            // 
            this.colIdTipoAttivita1.Caption = "Descrizione";
            this.colIdTipoAttivita1.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colIdTipoAttivita1.FieldName = "IdTipoAttivita";
            this.colIdTipoAttivita1.Name = "colIdTipoAttivita1";
            this.colIdTipoAttivita1.Visible = true;
            this.colIdTipoAttivita1.VisibleIndex = 1;
            this.colIdTipoAttivita1.Width = 318;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.DataSource = this.bindingSourceActivityTypes;
            this.repositoryItemLookUpEdit2.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ValueMember = "IdElemento";
            // 
            // gridControlUpdatedActivities
            // 
            this.gridControlUpdatedActivities.DataSource = this.bindingSourceBaseUpdatedActivitiesParix;
            this.gridControlUpdatedActivities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUpdatedActivities.Location = new System.Drawing.Point(2, 20);
            this.gridControlUpdatedActivities.MainView = this.gridView2;
            this.gridControlUpdatedActivities.Name = "gridControlUpdatedActivities";
            this.gridControlUpdatedActivities.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit3,
            this.repositoryItemLookUpEdit4});
            this.gridControlUpdatedActivities.Size = new System.Drawing.Size(624, 108);
            this.gridControlUpdatedActivities.TabIndex = 0;
            this.gridControlUpdatedActivities.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDataInizio1,
            this.colImportanza1,
            this.colIdTipoAttivita2,
            this.colIdTipoAttivita3});
            this.gridView2.GridControl = this.gridControlUpdatedActivities;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colDataInizio1
            // 
            this.colDataInizio1.Caption = "Data inizio";
            this.colDataInizio1.DisplayFormat.FormatString = "d";
            this.colDataInizio1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDataInizio1.FieldName = "DataInizio";
            this.colDataInizio1.Name = "colDataInizio1";
            this.colDataInizio1.Visible = true;
            this.colDataInizio1.VisibleIndex = 3;
            this.colDataInizio1.Width = 107;
            // 
            // colImportanza1
            // 
            this.colImportanza1.Caption = "Importanza";
            this.colImportanza1.FieldName = "Importanza";
            this.colImportanza1.Name = "colImportanza1";
            this.colImportanza1.Visible = true;
            this.colImportanza1.VisibleIndex = 2;
            this.colImportanza1.Width = 79;
            // 
            // colIdTipoAttivita2
            // 
            this.colIdTipoAttivita2.Caption = "Codice";
            this.colIdTipoAttivita2.ColumnEdit = this.repositoryItemLookUpEdit3;
            this.colIdTipoAttivita2.FieldName = "IdTipoAttivita";
            this.colIdTipoAttivita2.Name = "colIdTipoAttivita2";
            this.colIdTipoAttivita2.Visible = true;
            this.colIdTipoAttivita2.VisibleIndex = 0;
            this.colIdTipoAttivita2.Width = 99;
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.DataSource = this.bindingSourceActivityTypes;
            this.repositoryItemLookUpEdit3.DisplayMember = "Codice";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.ValueMember = "IdElemento";
            // 
            // colIdTipoAttivita3
            // 
            this.colIdTipoAttivita3.Caption = "Descrizione";
            this.colIdTipoAttivita3.ColumnEdit = this.repositoryItemLookUpEdit4;
            this.colIdTipoAttivita3.FieldName = "IdTipoAttivita";
            this.colIdTipoAttivita3.Name = "colIdTipoAttivita3";
            this.colIdTipoAttivita3.Visible = true;
            this.colIdTipoAttivita3.VisibleIndex = 1;
            this.colIdTipoAttivita3.Width = 318;
            // 
            // repositoryItemLookUpEdit4
            // 
            this.repositoryItemLookUpEdit4.AutoHeight = false;
            this.repositoryItemLookUpEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit4.DataSource = this.bindingSourceActivityTypes;
            this.repositoryItemLookUpEdit4.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit4.Name = "repositoryItemLookUpEdit4";
            this.repositoryItemLookUpEdit4.ValueMember = "IdElemento";
            // 
            // ActivityComparer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ActivityComparer";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseCurrentActivitiesParix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActivityTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseUpdatedActivitiesParix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCurrentActivities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUpdatedActivities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OeF.Forms.BindingSourceBase bindingSourceBaseCurrentActivitiesParix;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceActivityTypes;
        private OeF.Forms.BindingSourceBase bindingSourceBaseUpdatedActivitiesParix;
        private DevExpress.XtraGrid.GridControl gridControlCurrentActivities;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDataInizio;
        private DevExpress.XtraGrid.Columns.GridColumn colImportanza;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoAttivita;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoAttivita1;
        private DevExpress.XtraGrid.GridControl gridControlUpdatedActivities;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colDataInizio1;
        private DevExpress.XtraGrid.Columns.GridColumn colImportanza1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoAttivita2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoAttivita3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit4;
    }
}
