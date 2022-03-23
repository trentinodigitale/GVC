namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Data
{
    partial class RicercaAttivita
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
            this.bindingSourceBaseAttività = new OeF.Forms.BindingSourceBase(this.components);
            this.bindingSourceBaseTipoAttivita = new OeF.Forms.BindingSourceBase(this.components);
            this.gridControlAttivita = new DevExpress.XtraGrid.GridControl();
            this.gridViewAttivita = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodiceEdescrizione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panelControlSearchParameter = new OeF.Forms.Controls.PanelControl();
            this.Filtro = new OeF.Forms.Controls.TextEdit();
            this.labelControl3 = new OeF.Forms.Controls.LabelControl();
            this.btnSearch = new OeF.Forms.Controls.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseAttività)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseTipoAttivita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAttivita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAttivita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlSearchParameter)).BeginInit();
            this.panelControlSearchParameter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Filtro.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.gridControlAttivita);
            this.ScrollableContent.Controls.Add(this.panelControlSearchParameter);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 24);
            this.ScrollableContent.Size = new System.Drawing.Size(500, 399);
            // 
            // bindingSourceBaseAttività
            // 
            this.bindingSourceBaseAttività.AutoCreateObjects = false;
            this.bindingSourceBaseAttività.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.AttivitaFDT);
            // 
            // bindingSourceBaseTipoAttivita
            // 
            this.bindingSourceBaseTipoAttivita.AutoCreateObjects = false;
            this.bindingSourceBaseTipoAttivita.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // gridControlAttivita
            // 
            this.gridControlAttivita.DataSource = this.bindingSourceBaseTipoAttivita;
            this.gridControlAttivita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAttivita.EmbeddedNavigator.Name = "";
            this.gridControlAttivita.Location = new System.Drawing.Point(0, 78);
            this.gridControlAttivita.MainView = this.gridViewAttivita;
            this.gridControlAttivita.Name = "gridControlAttivita";
            this.gridControlAttivita.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2});
            this.gridControlAttivita.Size = new System.Drawing.Size(500, 321);
            this.gridControlAttivita.TabIndex = 66;
            this.gridControlAttivita.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAttivita});
            // 
            // gridViewAttivita
            // 
            this.gridViewAttivita.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodiceEdescrizione});
            this.gridViewAttivita.GridControl = this.gridControlAttivita;
            this.gridViewAttivita.Name = "gridViewAttivita";
            this.gridViewAttivita.OptionsBehavior.Editable = false;
            this.gridViewAttivita.OptionsMenu.EnableColumnMenu = false;
            this.gridViewAttivita.OptionsMenu.EnableFooterMenu = false;
            this.gridViewAttivita.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewAttivita.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewAttivita.OptionsView.ShowGroupPanel = false;
            this.gridViewAttivita.OptionsView.ShowIndicator = false;
            // 
            // colCodiceEdescrizione
            // 
            this.colCodiceEdescrizione.Caption = "Tipo attività";
            this.colCodiceEdescrizione.FieldName = "CodiceEdescrizione";
            this.colCodiceEdescrizione.Name = "colCodiceEdescrizione";
            this.colCodiceEdescrizione.OptionsColumn.AllowEdit = false;
            this.colCodiceEdescrizione.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colCodiceEdescrizione.OptionsColumn.AllowMove = false;
            this.colCodiceEdescrizione.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCodiceEdescrizione.OptionsFilter.AllowAutoFilter = false;
            this.colCodiceEdescrizione.OptionsFilter.AllowFilter = false;
            this.colCodiceEdescrizione.Visible = true;
            this.colCodiceEdescrizione.VisibleIndex = 0;
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
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // panelControlSearchParameter
            // 
            this.panelControlSearchParameter.Controls.Add(this.Filtro);
            this.panelControlSearchParameter.Controls.Add(this.labelControl3);
            this.panelControlSearchParameter.Controls.Add(this.btnSearch);
            this.panelControlSearchParameter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlSearchParameter.Location = new System.Drawing.Point(0, 0);
            this.panelControlSearchParameter.Name = "panelControlSearchParameter";
            this.panelControlSearchParameter.Size = new System.Drawing.Size(500, 78);
            this.panelControlSearchParameter.TabIndex = 67;
            // 
            // Filtro
            // 
            this.Filtro.Location = new System.Drawing.Point(134, 19);
            this.Filtro.Name = "Filtro";
            this.Filtro.Size = new System.Drawing.Size(245, 20);
            this.Filtro.TabIndex = 2;
            this.Filtro.EditValueChanged += new System.EventHandler(this.Filtro_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(104, 22);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Filtra";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(175, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Ricerca";
            // 
            // RicercaAttivita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "RicercaAttivita";
            this.Size = new System.Drawing.Size(500, 423);
            this.Shown += new System.EventHandler(this.RicercaAttivita_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseAttività)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseTipoAttivita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAttivita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAttivita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlSearchParameter)).EndInit();
            this.panelControlSearchParameter.ResumeLayout(false);
            this.panelControlSearchParameter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Filtro.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OeF.Forms.BindingSourceBase bindingSourceBaseAttività;
        private OeF.Forms.BindingSourceBase bindingSourceBaseTipoAttivita;
        private DevExpress.XtraGrid.GridControl gridControlAttivita;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAttivita;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colCodiceEdescrizione;
        private OeF.Forms.Controls.PanelControl panelControlSearchParameter;
        private OeF.Forms.Controls.TextEdit Filtro;
        private OeF.Forms.Controls.LabelControl labelControl3;
        private OeF.Forms.Controls.SimpleButton btnSearch;
    }
}
