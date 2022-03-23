namespace it.dedagroup.GVC.Client.Forms.Vocabolari
{
    partial class LeggiTrasgressioneEdit
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
            this.bindingSourceBaseDizionario = new OeF.Forms.BindingSourceBase(this.components);
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.memoEdit2 = new DevExpress.XtraEditors.MemoEdit();
            this.checkEditAttivo = new DevExpress.XtraEditors.CheckEdit();
            this.bindingSourceBaseNatura = new OeF.Forms.BindingSourceBase(this.components);
            this.gridLookUpEditNatura = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridViewNatura = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAttivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.ErrorProviderDizionario = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseDizionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditAttivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseNatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditNatura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderDizionario)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelButtons
            // 
            this.PanelButtons.Location = new System.Drawing.Point(0, 185);
            this.PanelButtons.Size = new System.Drawing.Size(424, 40);
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.gridLookUpEditNatura);
            this.ScrollableContent.Controls.Add(this.labelControl4);
            this.ScrollableContent.Controls.Add(this.labelControl3);
            this.ScrollableContent.Controls.Add(this.labelControl2);
            this.ScrollableContent.Controls.Add(this.memoEdit2);
            this.ScrollableContent.Controls.Add(this.checkEditAttivo);
            this.ScrollableContent.Controls.Add(this.labelControl1);
            this.ScrollableContent.Controls.Add(this.memoEdit1);
            this.ScrollableContent.Controls.Add(this.labelControl8);
            this.ScrollableContent.Size = new System.Drawing.Size(424, 225);
            this.ScrollableContent.Controls.SetChildIndex(this.PanelButtons, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl8, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.memoEdit1, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl1, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.checkEditAttivo, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.memoEdit2, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl2, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl3, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl4, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.gridLookUpEditNatura, 0);
            // 
            // bindingSourceBaseDizionario
            // 
            this.bindingSourceBaseDizionario.AutoCreateObjects = false;
            this.bindingSourceBaseDizionario.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.Dictionaries.LeggiTrasgressioneFDT);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(3, 6);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(181, 13);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "Dati legge/norma trasgressione";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Descrizione";
            // 
            // memoEdit1
            // 
            this.memoEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseDizionario, "Descrizione", true));
            this.ErrorProviderDizionario.SetErrorType(this.memoEdit1, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.memoEdit1.Location = new System.Drawing.Point(63, 61);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.MaxLength = 250;
            this.memoEdit1.Size = new System.Drawing.Size(319, 47);
            this.memoEdit1.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(211, 111);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Entita";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 111);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Attivo";
            // 
            // memoEdit2
            // 
            this.memoEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseDizionario, "Entita", true));
            this.ErrorProviderDizionario.SetErrorType(this.memoEdit2, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.memoEdit2.Location = new System.Drawing.Point(63, 127);
            this.memoEdit2.Name = "memoEdit2";
            this.memoEdit2.Properties.MaxLength = 250;
            this.memoEdit2.Size = new System.Drawing.Size(319, 47);
            this.memoEdit2.TabIndex = 3;
            // 
            // checkEditAttivo
            // 
            this.checkEditAttivo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseDizionario, "Attivo", true));
            this.ErrorProviderDizionario.SetErrorType(this.checkEditAttivo, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.checkEditAttivo.Location = new System.Drawing.Point(21, 127);
            this.checkEditAttivo.Name = "checkEditAttivo";
            this.checkEditAttivo.Properties.Caption = "";
            this.checkEditAttivo.Size = new System.Drawing.Size(22, 19);
            this.checkEditAttivo.TabIndex = 4;
            // 
            // bindingSourceBaseNatura
            // 
            this.bindingSourceBaseNatura.AutoCreateObjects = false;
            this.bindingSourceBaseNatura.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // gridLookUpEditNatura
            // 
            this.gridLookUpEditNatura.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseDizionario, "IdTipoTrasgressione", true));
            this.gridLookUpEditNatura.EditValue = "";
            this.ErrorProviderDizionario.SetErrorType(this.gridLookUpEditNatura, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.gridLookUpEditNatura.Location = new System.Drawing.Point(111, 26);
            this.gridLookUpEditNatura.Name = "gridLookUpEditNatura";
            this.gridLookUpEditNatura.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEditNatura.Properties.DataSource = this.bindingSourceBaseNatura;
            this.gridLookUpEditNatura.Properties.DisplayMember = "Descrizione";
            this.gridLookUpEditNatura.Properties.NullText = "";
            this.gridLookUpEditNatura.Properties.ValueMember = "IdElemento";
            this.gridLookUpEditNatura.Properties.View = this.gridViewNatura;
            this.gridLookUpEditNatura.Size = new System.Drawing.Size(250, 20);
            this.gridLookUpEditNatura.TabIndex = 1;
            // 
            // gridViewNatura
            // 
            this.gridViewNatura.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colAttivo});
            this.gridViewNatura.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewNatura.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gridViewNatura.Name = "gridViewNatura";
            this.gridViewNatura.OptionsMenu.EnableColumnMenu = false;
            this.gridViewNatura.OptionsMenu.EnableFooterMenu = false;
            this.gridViewNatura.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewNatura.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewNatura.OptionsView.ShowDetailButtons = false;
            this.gridViewNatura.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewNatura.OptionsView.ShowGroupPanel = false;
            this.gridViewNatura.OptionsView.ShowIndicator = false;
            this.gridViewNatura.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Natura trasgressione";
            this.gridColumn1.FieldName = "Descrizione";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.OptionsColumn.AllowMove = false;
            this.gridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // colAttivo
            // 
            this.colAttivo.Caption = "Attivo";
            this.colAttivo.FieldName = "Attivo";
            this.colAttivo.Name = "colAttivo";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(4, 29);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(101, 13);
            this.labelControl4.TabIndex = 104;
            this.labelControl4.Text = "Natura trasgressione";
            // 
            // ErrorProviderDizionario
            // 
            this.ErrorProviderDizionario.ContainerControl = this;
            this.ErrorProviderDizionario.DataSource = this.bindingSourceBaseDizionario;
            // 
            // LeggiTrasgressioneEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "LeggiTrasgressioneEdit";
            this.Size = new System.Drawing.Size(424, 249);
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            this.ScrollableContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseDizionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditAttivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseNatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditNatura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderDizionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OeF.Forms.BindingSourceBase bindingSourceBaseDizionario;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.MemoEdit memoEdit2;
        private DevExpress.XtraEditors.CheckEdit checkEditAttivo;
        private OeF.Forms.BindingSourceBase bindingSourceBaseNatura;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEditNatura;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNatura;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colAttivo;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl4;
        public DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ErrorProviderDizionario;
    }
}
