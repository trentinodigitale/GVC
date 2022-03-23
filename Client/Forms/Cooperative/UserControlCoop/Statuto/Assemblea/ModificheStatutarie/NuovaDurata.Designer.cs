namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Statuto.Assemblea.ModificheStatutarie
{
    partial class NuovaDurata
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
            this.labelControl6 = new OeF.Forms.Controls.LabelControl();
            this.panelControlDuration = new it.dedagroup.GVC.Client.Forms.Controls.PanelControl();
            this.lookUpEditVecchiaDurata = new it.dedagroup.GVC.Client.Forms.Controls.LookUpEdit();
            this.bindingSourceBaseDurationTypes = new OeF.Forms.BindingSourceBase(this.components);
            this.dateEditVecchiaDurata = new it.dedagroup.GVC.Client.Forms.Controls.DateEdit();
            this.labelControl12 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.panelControl1 = new it.dedagroup.GVC.Client.Forms.Controls.PanelControl();
            this.lookUpEditNuovaDurata = new it.dedagroup.GVC.Client.Forms.Controls.LookUpEdit();
            this.dateEditNuovaDurata = new it.dedagroup.GVC.Client.Forms.Controls.DateEdit();
            this.checkEditDataPresente = new it.dedagroup.GVC.Client.Forms.Controls.CheckEdit();
            this.ErrorProviderModificaStatutaria = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseModificaStatutaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlDuration)).BeginInit();
            this.panelControlDuration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditVecchiaDurata.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseDurationTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditVecchiaDurata.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditVecchiaDurata.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditNuovaDurata.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNuovaDurata.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNuovaDurata.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditDataPresente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderModificaStatutaria)).BeginInit();
            this.SuspendLayout();
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.panelControl1);
            this.ScrollableContent.Controls.Add(this.checkEditDataPresente);
            this.ScrollableContent.Controls.Add(this.panelControlDuration);
            this.ScrollableContent.Controls.Add(this.labelControl12);
            this.ScrollableContent.Controls.Add(this.labelControl6);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 24);
            this.ScrollableContent.Size = new System.Drawing.Size(571, 95);
            // 
            // bindingSourceBaseModificaStatutaria
            // 
            this.bindingSourceBaseModificaStatutaria.AutoCreateObjects = false;
            this.bindingSourceBaseModificaStatutaria.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.ModificaStatutariaFDT);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 55);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(66, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Durata nuova";
            // 
            // panelControlDuration
            // 
            this.panelControlDuration.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControlDuration.Controls.Add(this.lookUpEditVecchiaDurata);
            this.panelControlDuration.Controls.Add(this.dateEditVecchiaDurata);
            this.panelControlDuration.Location = new System.Drawing.Point(88, 6);
            this.panelControlDuration.Name = "panelControlDuration";
            this.panelControlDuration.Size = new System.Drawing.Size(134, 34);
            this.panelControlDuration.TabIndex = 72;
            // 
            // lookUpEditVecchiaDurata
            // 
            this.lookUpEditVecchiaDurata.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseModificaStatutaria, "VecchiaDurataIllimitata", true));
            this.ErrorProviderModificaStatutaria.SetErrorType(this.lookUpEditVecchiaDurata, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.lookUpEditVecchiaDurata.Location = new System.Drawing.Point(5, 4);
            this.lookUpEditVecchiaDurata.Name = "lookUpEditVecchiaDurata";
            this.lookUpEditVecchiaDurata.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditVecchiaDurata.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descrizione", "", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.lookUpEditVecchiaDurata.Properties.DataSource = this.bindingSourceBaseDurationTypes;
            this.lookUpEditVecchiaDurata.Properties.DisplayMember = "Descrizione";
            this.lookUpEditVecchiaDurata.Properties.NullText = "";
            this.lookUpEditVecchiaDurata.Properties.ReadOnly = true;
            this.lookUpEditVecchiaDurata.Properties.ValueMember = "IdElemento";
            this.lookUpEditVecchiaDurata.Size = new System.Drawing.Size(122, 20);
            this.lookUpEditVecchiaDurata.TabIndex = 1;
            // 
            // bindingSourceBaseDurationTypes
            // 
            this.bindingSourceBaseDurationTypes.AutoCreateObjects = false;
            this.bindingSourceBaseDurationTypes.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // dateEditVecchiaDurata
            // 
            this.dateEditVecchiaDurata.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseModificaStatutaria, "VecchiaDurataDisplay", true));
            this.dateEditVecchiaDurata.EditValue = null;
            this.ErrorProviderModificaStatutaria.SetErrorType(this.dateEditVecchiaDurata, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.dateEditVecchiaDurata.Location = new System.Drawing.Point(5, 4);
            this.dateEditVecchiaDurata.Name = "dateEditVecchiaDurata";
            this.dateEditVecchiaDurata.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditVecchiaDurata.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dateEditVecchiaDurata.Properties.ReadOnly = true;
            this.dateEditVecchiaDurata.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEditVecchiaDurata.Size = new System.Drawing.Size(100, 20);
            this.dateEditVecchiaDurata.TabIndex = 40;
            this.dateEditVecchiaDurata.Visible = false;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(12, 13);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(70, 13);
            this.labelControl12.TabIndex = 71;
            this.labelControl12.Text = "Durata attuale";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.lookUpEditNuovaDurata);
            this.panelControl1.Controls.Add(this.dateEditNuovaDurata);
            this.panelControl1.Location = new System.Drawing.Point(87, 52);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(134, 34);
            this.panelControl1.TabIndex = 74;
            // 
            // lookUpEditNuovaDurata
            // 
            this.lookUpEditNuovaDurata.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseModificaStatutaria, "NuovaDurataIllimitata", true));
            this.ErrorProviderModificaStatutaria.SetErrorType(this.lookUpEditNuovaDurata, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.lookUpEditNuovaDurata.Location = new System.Drawing.Point(6, 4);
            this.lookUpEditNuovaDurata.Name = "lookUpEditNuovaDurata";
            this.lookUpEditNuovaDurata.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditNuovaDurata.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descrizione", "", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.lookUpEditNuovaDurata.Properties.DataSource = this.bindingSourceBaseDurationTypes;
            this.lookUpEditNuovaDurata.Properties.DisplayMember = "Descrizione";
            this.lookUpEditNuovaDurata.Properties.NullText = "";
            this.lookUpEditNuovaDurata.Properties.ValueMember = "IdElemento";
            this.lookUpEditNuovaDurata.Size = new System.Drawing.Size(122, 20);
            this.lookUpEditNuovaDurata.TabIndex = 1;
            // 
            // dateEditNuovaDurata
            // 
            this.dateEditNuovaDurata.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseModificaStatutaria, "NuovaDurata", true));
            this.dateEditNuovaDurata.EditValue = null;
            this.ErrorProviderModificaStatutaria.SetErrorType(this.dateEditNuovaDurata, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.dateEditNuovaDurata.Location = new System.Drawing.Point(5, 4);
            this.dateEditNuovaDurata.Name = "dateEditNuovaDurata";
            this.dateEditNuovaDurata.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNuovaDurata.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dateEditNuovaDurata.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEditNuovaDurata.Size = new System.Drawing.Size(100, 20);
            this.dateEditNuovaDurata.TabIndex = 40;
            this.dateEditNuovaDurata.Visible = false;
            // 
            // checkEditDataPresente
            // 
            this.checkEditDataPresente.Location = new System.Drawing.Point(91, 36);
            this.checkEditDataPresente.Name = "checkEditDataPresente";
            this.checkEditDataPresente.Properties.Caption = "Data presente";
            this.checkEditDataPresente.Size = new System.Drawing.Size(102, 19);
            this.checkEditDataPresente.TabIndex = 73;
            this.checkEditDataPresente.TabStop = false;
            this.checkEditDataPresente.CheckedChanged += new System.EventHandler(this.checkEditDataPresente_CheckedChanged);
            // 
            // ErrorProviderModificaStatutaria
            // 
            this.ErrorProviderModificaStatutaria.ContainerControl = this;
            this.ErrorProviderModificaStatutaria.DataSource = this.bindingSourceBaseModificaStatutaria;
            // 
            // NuovaDurata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "NuovaDurata";
            this.Size = new System.Drawing.Size(571, 119);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            this.ScrollableContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseModificaStatutaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlDuration)).EndInit();
            this.panelControlDuration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditVecchiaDurata.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseDurationTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditVecchiaDurata.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditVecchiaDurata.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditNuovaDurata.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNuovaDurata.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNuovaDurata.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditDataPresente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderModificaStatutaria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OeF.Forms.BindingSourceBase bindingSourceBaseModificaStatutaria;
        private OeF.Forms.Controls.LabelControl labelControl6;
        private it.dedagroup.GVC.Client.Forms.Controls.PanelControl panelControlDuration;
        private it.dedagroup.GVC.Client.Forms.Controls.LookUpEdit lookUpEditVecchiaDurata;
        private it.dedagroup.GVC.Client.Forms.Controls.DateEdit dateEditVecchiaDurata;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl12;
        private OeF.Forms.BindingSourceBase bindingSourceBaseDurationTypes;
        private it.dedagroup.GVC.Client.Forms.Controls.PanelControl panelControl1;
        private it.dedagroup.GVC.Client.Forms.Controls.LookUpEdit lookUpEditNuovaDurata;
        private it.dedagroup.GVC.Client.Forms.Controls.DateEdit dateEditNuovaDurata;
        private it.dedagroup.GVC.Client.Forms.Controls.CheckEdit checkEditDataPresente;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ErrorProviderModificaStatutaria;
    }
}
