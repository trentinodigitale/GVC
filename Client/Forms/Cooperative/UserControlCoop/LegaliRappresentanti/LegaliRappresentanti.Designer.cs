namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.LegaliRappresentanti
{
    partial class LegaliRappresentanti
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
            this.gridControlStorico = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceSoggetto = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.gridViewStorico = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescrizioneBreve = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodiceFiscale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStorico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSoggetto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStorico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarManager
            // 
            this.BarManager.MaxItemId = 11;
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.gridControlStorico);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 24);
            this.ScrollableContent.Size = new System.Drawing.Size(711, 163);
            // 
            // gridControlStorico
            // 
            this.gridControlStorico.DataSource = this.bindingSourceSoggetto;
            this.gridControlStorico.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlStorico.Location = new System.Drawing.Point(0, 0);
            this.gridControlStorico.MainView = this.gridViewStorico;
            this.gridControlStorico.Name = "gridControlStorico";
            this.gridControlStorico.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemPictureEdit1,
            this.repositoryItemMemoEdit1});
            this.gridControlStorico.Size = new System.Drawing.Size(711, 161);
            this.gridControlStorico.TabIndex = 0;
            this.gridControlStorico.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewStorico});
            // 
            // bindingSourceSoggetto
            // 
            this.bindingSourceSoggetto.AutoCreateObjects = false;
            this.bindingSourceSoggetto.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.SoggettoFDT);
            // 
            // gridViewStorico
            // 
            this.gridViewStorico.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescrizioneBreve,
            this.colCodiceFiscale});
            this.gridViewStorico.GridControl = this.gridControlStorico;
            this.gridViewStorico.Name = "gridViewStorico";
            this.gridViewStorico.OptionsBehavior.Editable = false;
            this.gridViewStorico.OptionsCustomization.AllowSort = false;
            this.gridViewStorico.OptionsMenu.EnableColumnMenu = false;
            this.gridViewStorico.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewStorico.OptionsView.RowAutoHeight = true;
            this.gridViewStorico.OptionsView.ShowGroupPanel = false;
            this.gridViewStorico.OptionsView.ShowIndicator = false;
            // 
            // colDescrizioneBreve
            // 
            this.colDescrizioneBreve.Caption = "Nominativo";
            this.colDescrizioneBreve.FieldName = "DescrizioneBreve";
            this.colDescrizioneBreve.Name = "colDescrizioneBreve";
            this.colDescrizioneBreve.Visible = true;
            this.colDescrizioneBreve.VisibleIndex = 0;
            // 
            // colCodiceFiscale
            // 
            this.colCodiceFiscale.Caption = "Codice fiscale";
            this.colCodiceFiscale.FieldName = "CodiceFiscale";
            this.colCodiceFiscale.Name = "colCodiceFiscale";
            this.colCodiceFiscale.Visible = true;
            this.colCodiceFiscale.VisibleIndex = 1;
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
            this.repositoryItemLookUpEdit2.DataSource = this.bindingSourceSoggetto;
            this.repositoryItemLookUpEdit2.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ValueMember = "IdElemento";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            this.repositoryItemMemoEdit1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            // 
            // LegaliRappresentanti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "LegaliRappresentanti";
            this.Size = new System.Drawing.Size(711, 187);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStorico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSoggetto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStorico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlStorico;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewStorico;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceSoggetto;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescrizioneBreve;
        private DevExpress.XtraGrid.Columns.GridColumn colCodiceFiscale;
    }
}
