namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Statuto.Assemblea.ModificheStatutarie
{
    partial class NuovaFormaGiuridica
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
            this.labelControl4 = new OeF.Forms.Controls.LabelControl();
            this.labelControl3 = new OeF.Forms.Controls.LabelControl();
            this.bindingSourceBaseFormaGiuridica = new OeF.Forms.BindingSourceBase(this.components);
            this.lookUpEditFormaGiu = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditFormaGiuNuova = new DevExpress.XtraEditors.LookUpEdit();
            this.ErrorProviderModificaStatutaria = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.labelControl1 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.checkEditNrScioglimento = new it.dedagroup.GVC.Client.Forms.Controls.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseModificaStatutaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseFormaGiuridica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditFormaGiu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditFormaGiuNuova.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderModificaStatutaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditNrScioglimento.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.labelControl1);
            this.ScrollableContent.Controls.Add(this.checkEditNrScioglimento);
            this.ScrollableContent.Controls.Add(this.lookUpEditFormaGiuNuova);
            this.ScrollableContent.Controls.Add(this.lookUpEditFormaGiu);
            this.ScrollableContent.Controls.Add(this.labelControl4);
            this.ScrollableContent.Controls.Add(this.labelControl3);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 24);
            this.ScrollableContent.Size = new System.Drawing.Size(570, 95);
            // 
            // bindingSourceBaseModificaStatutaria
            // 
            this.bindingSourceBaseModificaStatutaria.AutoCreateObjects = false;
            this.bindingSourceBaseModificaStatutaria.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.ModificaStatutariaFDT);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 35);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(105, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Forma giuridica nuova";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 9);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(109, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Forma giuridica attuale";
            // 
            // bindingSourceBaseFormaGiuridica
            // 
            this.bindingSourceBaseFormaGiuridica.AutoCreateObjects = false;
            this.bindingSourceBaseFormaGiuridica.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // lookUpEditFormaGiu
            // 
            this.lookUpEditFormaGiu.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseModificaStatutaria, "IdVecchiaFormaGiuridica", true));
            this.ErrorProviderModificaStatutaria.SetErrorType(this.lookUpEditFormaGiu, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.lookUpEditFormaGiu.Location = new System.Drawing.Point(127, 6);
            this.lookUpEditFormaGiu.Name = "lookUpEditFormaGiu";
            this.lookUpEditFormaGiu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditFormaGiu.Properties.DataSource = this.bindingSourceBaseFormaGiuridica;
            this.lookUpEditFormaGiu.Properties.DisplayMember = "Descrizione";
            this.lookUpEditFormaGiu.Properties.NullText = "";
            this.lookUpEditFormaGiu.Properties.ReadOnly = true;
            this.lookUpEditFormaGiu.Properties.ValueMember = "IdElemento";
            this.lookUpEditFormaGiu.Size = new System.Drawing.Size(414, 20);
            this.lookUpEditFormaGiu.TabIndex = 9;
            this.lookUpEditFormaGiu.TabStop = false;
            // 
            // lookUpEditFormaGiuNuova
            // 
            this.lookUpEditFormaGiuNuova.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseModificaStatutaria, "IdNuovaFormaGiuridica", true));
            this.ErrorProviderModificaStatutaria.SetErrorType(this.lookUpEditFormaGiuNuova, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.lookUpEditFormaGiuNuova.Location = new System.Drawing.Point(127, 32);
            this.lookUpEditFormaGiuNuova.Name = "lookUpEditFormaGiuNuova";
            this.lookUpEditFormaGiuNuova.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditFormaGiuNuova.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descrizione", "Descrizione", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEditFormaGiuNuova.Properties.DataSource = this.bindingSourceBaseFormaGiuridica;
            this.lookUpEditFormaGiuNuova.Properties.DisplayMember = "Descrizione";
            this.lookUpEditFormaGiuNuova.Properties.NullText = "";
            this.lookUpEditFormaGiuNuova.Properties.ValueMember = "IdElemento";
            this.lookUpEditFormaGiuNuova.Size = new System.Drawing.Size(414, 20);
            this.lookUpEditFormaGiuNuova.TabIndex = 1;
            // 
            // ErrorProviderModificaStatutaria
            // 
            this.ErrorProviderModificaStatutaria.ContainerControl = this;
            this.ErrorProviderModificaStatutaria.DataSource = this.bindingSourceBaseModificaStatutaria;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(127, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(173, 13);
            this.labelControl1.TabIndex = 53;
            this.labelControl1.Text = "Aggiornamento numero scioglimento";
            // 
            // checkEditNrScioglimento
            // 
            this.checkEditNrScioglimento.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseModificaStatutaria, "AggiornaNrScioglimento", true));
            this.checkEditNrScioglimento.Location = new System.Drawing.Point(306, 55);
            this.checkEditNrScioglimento.Name = "checkEditNrScioglimento";
            this.checkEditNrScioglimento.Properties.Caption = "";
            this.checkEditNrScioglimento.Size = new System.Drawing.Size(19, 19);
            this.checkEditNrScioglimento.TabIndex = 52;
            // 
            // NuovaFormaGiuridica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "NuovaFormaGiuridica";
            this.Size = new System.Drawing.Size(570, 119);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            this.ScrollableContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseModificaStatutaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseFormaGiuridica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditFormaGiu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditFormaGiuNuova.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderModificaStatutaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditNrScioglimento.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OeF.Forms.Controls.LabelControl labelControl4;
        private OeF.Forms.Controls.LabelControl labelControl3;
        private OeF.Forms.BindingSourceBase bindingSourceBaseFormaGiuridica;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditFormaGiuNuova;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditFormaGiu;
        private OeF.Forms.BindingSourceBase bindingSourceBaseModificaStatutaria;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ErrorProviderModificaStatutaria;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl1;
        private it.dedagroup.GVC.Client.Forms.Controls.CheckEdit checkEditNrScioglimento;
    }
}
