namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Statuto.Assemblea.ModificheStatutarie
{
    partial class TrasferimentoFuoriProv
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
            this.labelControl2 = new OeF.Forms.Controls.LabelControl();
            this.labelControl7 = new OeF.Forms.Controls.LabelControl();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.bindingSourceBaseModificaStatutaria = new OeF.Forms.BindingSourceBase(this.components);
            this.bindingSourceBaseStato = new OeF.Forms.BindingSourceBase(this.components);
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.ErrorProviderModificaStatutaria = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.labelControl3 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.checkEditNrScioglimento = new it.dedagroup.GVC.Client.Forms.Controls.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseModificaStatutaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseStato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderModificaStatutaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditNrScioglimento.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.labelControl3);
            this.ScrollableContent.Controls.Add(this.checkEditNrScioglimento);
            this.ScrollableContent.Controls.Add(this.labelControl2);
            this.ScrollableContent.Controls.Add(this.labelControl7);
            this.ScrollableContent.Controls.Add(this.lookUpEdit2);
            this.ScrollableContent.Controls.Add(this.lookUpEdit1);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 24);
            this.ScrollableContent.Size = new System.Drawing.Size(570, 92);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(39, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 13);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Stato nuovo";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(35, 9);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(63, 13);
            this.labelControl7.TabIndex = 22;
            this.labelControl7.Text = "Stato attuale";
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseModificaStatutaria, "IdNuovoStatoIscrizione", true));
            this.ErrorProviderModificaStatutaria.SetErrorType(this.lookUpEdit2, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.lookUpEdit2.Location = new System.Drawing.Point(104, 32);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.lookUpEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descrizione", "Descrizione", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit2.Properties.DataSource = this.bindingSourceBaseStato;
            this.lookUpEdit2.Properties.DisplayMember = "Descrizione";
            this.lookUpEdit2.Properties.NullText = "";
            this.lookUpEdit2.Properties.ValueMember = "IdElemento";
            this.lookUpEdit2.Size = new System.Drawing.Size(436, 20);
            this.lookUpEdit2.TabIndex = 25;
            this.lookUpEdit2.TabStop = false;
            // 
            // bindingSourceBaseModificaStatutaria
            // 
            this.bindingSourceBaseModificaStatutaria.AutoCreateObjects = false;
            this.bindingSourceBaseModificaStatutaria.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.ModificaStatutariaFDT);
            // 
            // bindingSourceBaseStato
            // 
            this.bindingSourceBaseStato.AutoCreateObjects = false;
            this.bindingSourceBaseStato.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseModificaStatutaria, "IdVecchioStatoIscrizione", true));
            this.ErrorProviderModificaStatutaria.SetErrorType(this.lookUpEdit1, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.lookUpEdit1.Location = new System.Drawing.Point(104, 6);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.DataSource = this.bindingSourceBaseStato;
            this.lookUpEdit1.Properties.DisplayMember = "Descrizione";
            this.lookUpEdit1.Properties.NullText = "";
            this.lookUpEdit1.Properties.ReadOnly = true;
            this.lookUpEdit1.Properties.ValueMember = "IdElemento";
            this.lookUpEdit1.Size = new System.Drawing.Size(436, 20);
            this.lookUpEdit1.TabIndex = 24;
            this.lookUpEdit1.TabStop = false;
            // 
            // ErrorProviderModificaStatutaria
            // 
            this.ErrorProviderModificaStatutaria.ContainerControl = this;
            this.ErrorProviderModificaStatutaria.DataSource = this.bindingSourceBaseModificaStatutaria;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(104, 58);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(173, 13);
            this.labelControl3.TabIndex = 51;
            this.labelControl3.Text = "Aggiornamento numero scioglimento";
            // 
            // checkEditNrScioglimento
            // 
            this.checkEditNrScioglimento.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseModificaStatutaria, "AggiornaNrScioglimento", true));
            this.checkEditNrScioglimento.Location = new System.Drawing.Point(283, 55);
            this.checkEditNrScioglimento.Name = "checkEditNrScioglimento";
            this.checkEditNrScioglimento.Properties.Caption = "";
            this.checkEditNrScioglimento.Size = new System.Drawing.Size(19, 19);
            this.checkEditNrScioglimento.TabIndex = 50;
            // 
            // TrasferimentoFuoriProv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TrasferimentoFuoriProv";
            this.Size = new System.Drawing.Size(570, 116);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            this.ScrollableContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseModificaStatutaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseStato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderModificaStatutaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditNrScioglimento.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OeF.Forms.Controls.LabelControl labelControl2;
        private OeF.Forms.Controls.LabelControl labelControl7;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private OeF.Forms.BindingSourceBase bindingSourceBaseModificaStatutaria;
        private OeF.Forms.BindingSourceBase bindingSourceBaseStato;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ErrorProviderModificaStatutaria;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl3;
        private it.dedagroup.GVC.Client.Forms.Controls.CheckEdit checkEditNrScioglimento;
    }
}
