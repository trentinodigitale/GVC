namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Statuto.Assemblea
{
    partial class AttoIntegrativoEdit
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
            this.labelControl1 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.lookUpEditTipoAtto = new it.dedagroup.GVC.Client.Forms.Controls.LookUpEdit();
            this.bindingSourceBaseAttoIntegrativo = new OeF.Forms.BindingSourceBase(this.components);
            this.bindingSourceBaseTipiAttiIntegrativi = new OeF.Forms.BindingSourceBase(this.components);
            this.labelControl3 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.labelControl2 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.labelControl4 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.memoEdit1 = new OeF.Forms.Controls.MemoEdit();
            this.dateEdit1 = new it.dedagroup.GVC.Client.Forms.Controls.DateEdit();
            this.ErrorProviderAtto = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTipoAtto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseAttoIntegrativo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseTipiAttiIntegrativi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderAtto)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelButtons
            // 
            this.PanelButtons.Location = new System.Drawing.Point(0, 152);
            this.PanelButtons.Size = new System.Drawing.Size(549, 40);
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.dateEdit1);
            this.ScrollableContent.Controls.Add(this.memoEdit1);
            this.ScrollableContent.Controls.Add(this.labelControl1);
            this.ScrollableContent.Controls.Add(this.lookUpEditTipoAtto);
            this.ScrollableContent.Controls.Add(this.labelControl4);
            this.ScrollableContent.Controls.Add(this.labelControl3);
            this.ScrollableContent.Controls.Add(this.labelControl2);
            this.ScrollableContent.Size = new System.Drawing.Size(549, 192);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl2, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl3, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl4, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.lookUpEditTipoAtto, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl1, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.memoEdit1, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.dateEdit1, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.PanelButtons, 0);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(139, 13);
            this.labelControl1.TabIndex = 68;
            this.labelControl1.Text = "Dati dell\'atto integrativo";
            // 
            // lookUpEditTipoAtto
            // 
            this.lookUpEditTipoAtto.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseAttoIntegrativo, "IdTipoAtto", true));
            this.ErrorProviderAtto.SetErrorType(this.lookUpEditTipoAtto, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.lookUpEditTipoAtto.Location = new System.Drawing.Point(135, 57);
            this.lookUpEditTipoAtto.Name = "lookUpEditTipoAtto";
            this.lookUpEditTipoAtto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditTipoAtto.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descrizione", "Riferimento", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.lookUpEditTipoAtto.Properties.DataSource = this.bindingSourceBaseTipiAttiIntegrativi;
            this.lookUpEditTipoAtto.Properties.DisplayMember = "Codice";
            this.lookUpEditTipoAtto.Properties.NullText = "";
            this.lookUpEditTipoAtto.Properties.ValueMember = "IdElemento";
            this.lookUpEditTipoAtto.Size = new System.Drawing.Size(186, 20);
            this.lookUpEditTipoAtto.TabIndex = 2;
            // 
            // bindingSourceBaseAttoIntegrativo
            // 
            this.bindingSourceBaseAttoIntegrativo.AutoCreateObjects = false;
            this.bindingSourceBaseAttoIntegrativo.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.AttoIntegrativoFDT);
            // 
            // bindingSourceBaseTipiAttiIntegrativi
            // 
            this.bindingSourceBaseTipiAttiIntegrativi.AutoCreateObjects = false;
            this.bindingSourceBaseTipiAttiIntegrativi.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(19, 60);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(110, 13);
            this.labelControl3.TabIndex = 71;
            this.labelControl3.Text = "Codice riferimento atto";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(28, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(101, 13);
            this.labelControl2.TabIndex = 70;
            this.labelControl2.Text = "Data riferimento atto";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(75, 86);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 13);
            this.labelControl4.TabIndex = 71;
            this.labelControl4.Text = "Descrizione";
            // 
            // memoEdit1
            // 
            this.memoEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseAttoIntegrativo, "DescrizioneDatoStorico", true));
            this.ErrorProviderAtto.SetErrorType(this.memoEdit1, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.memoEdit1.Location = new System.Drawing.Point(135, 83);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.MaxLength = 1000;
            this.memoEdit1.Size = new System.Drawing.Size(387, 54);
            this.memoEdit1.TabIndex = 3;
            // 
            // dateEdit1
            // 
            this.dateEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseAttoIntegrativo, "DataAtto", true));
            this.dateEdit1.EditValue = null;
            this.ErrorProviderAtto.SetErrorType(this.dateEdit1, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.dateEdit1.Location = new System.Drawing.Point(135, 31);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(100, 20);
            this.dateEdit1.TabIndex = 1;
            // 
            // ErrorProviderAtto
            // 
            this.ErrorProviderAtto.ContainerControl = this;
            this.ErrorProviderAtto.DataSource = this.bindingSourceBaseAttoIntegrativo;
            // 
            // AttoIntegrativoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "AttoIntegrativoEdit";
            this.Size = new System.Drawing.Size(549, 216);
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            this.ScrollableContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTipoAtto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseAttoIntegrativo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseTipiAttiIntegrativi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderAtto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl1;
        private it.dedagroup.GVC.Client.Forms.Controls.LookUpEdit lookUpEditTipoAtto;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl4;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl3;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl2;
        private OeF.Forms.Controls.MemoEdit memoEdit1;
        private it.dedagroup.GVC.Client.Forms.Controls.DateEdit dateEdit1;
        private OeF.Forms.BindingSourceBase bindingSourceBaseAttoIntegrativo;
        private OeF.Forms.BindingSourceBase bindingSourceBaseTipiAttiIntegrativi;
        public DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ErrorProviderAtto;
    }
}
