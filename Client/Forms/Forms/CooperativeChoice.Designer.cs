namespace it.dedagroup.GVC.Client.Forms.Forms
{
    partial class CooperativeChoice
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
            this.gridControlCooperative = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceBaseCooperative = new OeF.Forms.BindingSourceBase(this.components);
            this.gridViewCooperative = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCooperativeRegistry_CooperativeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDenomination = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCooperative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseCooperative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCooperative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // PanelButtons
            // 
            this.PanelButtons.Location = new System.Drawing.Point(0, 120);
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.gridControlCooperative);
            this.ScrollableContent.Size = new System.Drawing.Size(600, 160);
            this.ScrollableContent.Controls.SetChildIndex(this.gridControlCooperative, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.PanelButtons, 0);
            // 
            // gridControlCooperative
            // 
            this.gridControlCooperative.DataSource = this.bindingSourceBaseCooperative;
            this.gridControlCooperative.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCooperative.Location = new System.Drawing.Point(0, 0);
            this.gridControlCooperative.MainView = this.gridViewCooperative;
            this.gridControlCooperative.Name = "gridControlCooperative";
            this.gridControlCooperative.Size = new System.Drawing.Size(600, 160);
            this.gridControlCooperative.TabIndex = 0;
            this.gridControlCooperative.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCooperative,
            this.gridView2});
            // 
            // bindingSourceBaseCooperative
            // 
            this.bindingSourceBaseCooperative.AutoCreateObjects = false;
            this.bindingSourceBaseCooperative.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.CooperativaFDT);
            // 
            // gridViewCooperative
            // 
            this.gridViewCooperative.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCooperativeRegistry_CooperativeCode,
            this.colDenomination});
            this.gridViewCooperative.GridControl = this.gridControlCooperative;
            this.gridViewCooperative.Name = "gridViewCooperative";
            this.gridViewCooperative.OptionsMenu.EnableColumnMenu = false;
            this.gridViewCooperative.OptionsMenu.EnableFooterMenu = false;
            this.gridViewCooperative.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewCooperative.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewCooperative.OptionsView.ShowGroupPanel = false;
            this.gridViewCooperative.OptionsView.ShowIndicator = false;
            // 
            // colCooperativeRegistry_CooperativeCode
            // 
            this.colCooperativeRegistry_CooperativeCode.Caption = "Codice";
            this.colCooperativeRegistry_CooperativeCode.FieldName = "CooperativeRegistry_CooperativeCode";
            this.colCooperativeRegistry_CooperativeCode.Name = "colCooperativeRegistry_CooperativeCode";
            this.colCooperativeRegistry_CooperativeCode.OptionsColumn.AllowEdit = false;
            this.colCooperativeRegistry_CooperativeCode.OptionsColumn.AllowFocus = false;
            this.colCooperativeRegistry_CooperativeCode.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCooperativeRegistry_CooperativeCode.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colCooperativeRegistry_CooperativeCode.OptionsColumn.AllowMove = false;
            this.colCooperativeRegistry_CooperativeCode.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCooperativeRegistry_CooperativeCode.OptionsFilter.AllowAutoFilter = false;
            this.colCooperativeRegistry_CooperativeCode.OptionsFilter.AllowFilter = false;
            this.colCooperativeRegistry_CooperativeCode.Visible = true;
            this.colCooperativeRegistry_CooperativeCode.VisibleIndex = 0;
            this.colCooperativeRegistry_CooperativeCode.Width = 70;
            // 
            // colDenomination
            // 
            this.colDenomination.Caption = "Denominazione";
            this.colDenomination.FieldName = "Denominazione";
            this.colDenomination.Name = "colDenomination";
            this.colDenomination.OptionsColumn.AllowEdit = false;
            this.colDenomination.OptionsColumn.AllowFocus = false;
            this.colDenomination.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDenomination.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDenomination.OptionsColumn.AllowMove = false;
            this.colDenomination.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDenomination.OptionsFilter.AllowAutoFilter = false;
            this.colDenomination.OptionsFilter.AllowFilter = false;
            this.colDenomination.Visible = true;
            this.colDenomination.VisibleIndex = 1;
            this.colDenomination.Width = 580;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControlCooperative;
            this.gridView2.Name = "gridView2";
            // 
            // CooperativeChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CooperativeChoice";
            this.Size = new System.Drawing.Size(600, 184);
            this.Shown += new System.EventHandler(this.CooperativeChoice_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCooperative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseCooperative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCooperative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlCooperative;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCooperative;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private OeF.Forms.BindingSourceBase bindingSourceBaseCooperative;
        private DevExpress.XtraGrid.Columns.GridColumn colCooperativeRegistry_CooperativeCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDenomination;
    }
}
