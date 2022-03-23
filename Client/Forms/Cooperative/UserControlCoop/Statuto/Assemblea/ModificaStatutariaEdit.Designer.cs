namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Statuto.Assemblea
{
    partial class ModificaStatutariaEdit
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
            this.bindingSourceBaseModificaStatutaria = new OeF.Forms.BindingSourceBase(this.components);
            this.panelControl1 = new OeF.Forms.Controls.PanelControl();
            this.gridLookUpEditTipoModifica = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSourceBaseTipoModificaStatutaria = new OeF.Forms.BindingSourceBase(this.components);
            this.gridViewTipoModifica = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAttivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateEdit1 = new it.dedagroup.GVC.Client.Forms.Controls.DateEdit();
            this.bindingSourceBaseAssemblea = new OeF.Forms.BindingSourceBase(this.components);
            this.lookUpEditType = new it.dedagroup.GVC.Client.Forms.Controls.LookUpEdit();
            this.bindingSourceBaseTipoAssemblea = new OeF.Forms.BindingSourceBase(this.components);
            this.labelControl4 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.labelControl5 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.labelControl2 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.labelControl1 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.labelControl3 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.panelControl2 = new OeF.Forms.Controls.PanelControl();
            this.ErrorProviderModificaStatutaria = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseModificaStatutaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditTipoModifica.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseTipoModificaStatutaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTipoModifica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseAssemblea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseTipoAssemblea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderModificaStatutaria)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelButtons
            // 
            this.PanelButtons.Location = new System.Drawing.Point(0, 177);
            this.PanelButtons.Size = new System.Drawing.Size(570, 40);
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.panelControl2);
            this.ScrollableContent.Controls.Add(this.panelControl1);
            this.ScrollableContent.Size = new System.Drawing.Size(570, 217);
            this.ScrollableContent.Controls.SetChildIndex(this.panelControl1, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.panelControl2, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.PanelButtons, 0);
            // 
            // bindingSourceBaseModificaStatutaria
            // 
            this.bindingSourceBaseModificaStatutaria.AutoCreateObjects = false;
            this.bindingSourceBaseModificaStatutaria.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.ModificaStatutariaFDT);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridLookUpEditTipoModifica);
            this.panelControl1.Controls.Add(this.dateEdit1);
            this.panelControl1.Controls.Add(this.lookUpEditType);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(570, 124);
            this.panelControl1.TabIndex = 1;
            // 
            // gridLookUpEditTipoModifica
            // 
            this.gridLookUpEditTipoModifica.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseModificaStatutaria, "IdTipoModifica", true));
            this.gridLookUpEditTipoModifica.EditValue = "";
            this.ErrorProviderModificaStatutaria.SetErrorType(this.gridLookUpEditTipoModifica, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.gridLookUpEditTipoModifica.Location = new System.Drawing.Point(130, 86);
            this.gridLookUpEditTipoModifica.Name = "gridLookUpEditTipoModifica";
            this.gridLookUpEditTipoModifica.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEditTipoModifica.Properties.DataSource = this.bindingSourceBaseTipoModificaStatutaria;
            this.gridLookUpEditTipoModifica.Properties.DisplayMember = "Descrizione";
            this.gridLookUpEditTipoModifica.Properties.NullText = "";
            this.gridLookUpEditTipoModifica.Properties.ValueMember = "IdElemento";
            this.gridLookUpEditTipoModifica.Properties.View = this.gridViewTipoModifica;
            this.gridLookUpEditTipoModifica.Size = new System.Drawing.Size(345, 20);
            this.gridLookUpEditTipoModifica.TabIndex = 1;
            this.gridLookUpEditTipoModifica.EditValueChanged += new System.EventHandler(this.gridLookUpEditTipoModifica_EditValueChanged);
            // 
            // bindingSourceBaseTipoModificaStatutaria
            // 
            this.bindingSourceBaseTipoModificaStatutaria.AutoCreateObjects = false;
            this.bindingSourceBaseTipoModificaStatutaria.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // gridViewTipoModifica
            // 
            this.gridViewTipoModifica.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colAttivo});
            this.gridViewTipoModifica.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewTipoModifica.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gridViewTipoModifica.Name = "gridViewTipoModifica";
            this.gridViewTipoModifica.OptionsMenu.EnableColumnMenu = false;
            this.gridViewTipoModifica.OptionsMenu.EnableFooterMenu = false;
            this.gridViewTipoModifica.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewTipoModifica.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewTipoModifica.OptionsView.ShowDetailButtons = false;
            this.gridViewTipoModifica.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewTipoModifica.OptionsView.ShowGroupPanel = false;
            this.gridViewTipoModifica.OptionsView.ShowIndicator = false;
            this.gridViewTipoModifica.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Tipo";
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
            // dateEdit1
            // 
            this.dateEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseAssemblea, "DataAssemblea", true));
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(94, 25);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dateEdit1.Properties.ReadOnly = true;
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(100, 20);
            this.dateEdit1.TabIndex = 79;
            // 
            // bindingSourceBaseAssemblea
            // 
            this.bindingSourceBaseAssemblea.AutoCreateObjects = false;
            this.bindingSourceBaseAssemblea.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DeliberaAssembleaFDT);
            // 
            // lookUpEditType
            // 
            this.lookUpEditType.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseAssemblea, "IdTipoAssemblea", true));
            this.lookUpEditType.Location = new System.Drawing.Point(299, 25);
            this.lookUpEditType.Name = "lookUpEditType";
            this.lookUpEditType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descrizione", "Tipo", 100)});
            this.lookUpEditType.Properties.DataSource = this.bindingSourceBaseTipoAssemblea;
            this.lookUpEditType.Properties.DisplayMember = "Descrizione";
            this.lookUpEditType.Properties.NullText = "";
            this.lookUpEditType.Properties.ReadOnly = true;
            this.lookUpEditType.Properties.ValueMember = "IdElemento";
            this.lookUpEditType.Size = new System.Drawing.Size(186, 20);
            this.lookUpEditType.TabIndex = 76;
            // 
            // bindingSourceBaseTipoAssemblea
            // 
            this.bindingSourceBaseTipoAssemblea.AutoCreateObjects = false;
            this.bindingSourceBaseTipoAssemblea.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(220, 28);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 13);
            this.labelControl4.TabIndex = 78;
            this.labelControl4.Text = "Tipo assemblea";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 28);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(76, 13);
            this.labelControl5.TabIndex = 77;
            this.labelControl5.Text = "Data assemblea";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(111, 13);
            this.labelControl2.TabIndex = 71;
            this.labelControl2.Text = "Dati dell\'assemblea";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 70);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(165, 13);
            this.labelControl1.TabIndex = 68;
            this.labelControl1.Text = "Dati della modifica statutaria";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 89);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(112, 13);
            this.labelControl3.TabIndex = 70;
            this.labelControl3.Text = "Tipo modifica statutaria";
            // 
            // panelControl2
            // 
            this.panelControl2.AutoSize = true;
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 124);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(570, 4);
            this.panelControl2.TabIndex = 2;
            // 
            // ErrorProviderModificaStatutaria
            // 
            this.ErrorProviderModificaStatutaria.ContainerControl = this;
            this.ErrorProviderModificaStatutaria.DataSource = this.bindingSourceBaseModificaStatutaria;
            // 
            // ModificaStatutariaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ModificaStatutariaEdit";
            this.Size = new System.Drawing.Size(570, 241);
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            this.ScrollableContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseModificaStatutaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditTipoModifica.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseTipoModificaStatutaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTipoModifica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseAssemblea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseTipoAssemblea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderModificaStatutaria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OeF.Forms.BindingSourceBase bindingSourceBaseModificaStatutaria;
        private OeF.Forms.Controls.PanelControl panelControl1;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl1;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl3;
        private OeF.Forms.BindingSourceBase bindingSourceBaseTipoModificaStatutaria;
        private OeF.Forms.Controls.PanelControl panelControl2;
        private OeF.Forms.BindingSourceBase bindingSourceBaseAssemblea;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl2;
        private it.dedagroup.GVC.Client.Forms.Controls.DateEdit dateEdit1;
        private it.dedagroup.GVC.Client.Forms.Controls.LookUpEdit lookUpEditType;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl4;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl5;
        private OeF.Forms.BindingSourceBase bindingSourceBaseTipoAssemblea;
        public DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ErrorProviderModificaStatutaria;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEditTipoModifica;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTipoModifica;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colAttivo;
    }
}
