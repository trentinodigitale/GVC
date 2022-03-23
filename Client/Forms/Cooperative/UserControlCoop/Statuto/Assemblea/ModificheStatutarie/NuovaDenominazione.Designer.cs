namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Statuto.Assemblea.ModificheStatutarie
{
    partial class NuovaDenominazione
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
            this.labelControl3 = new OeF.Forms.Controls.LabelControl();
            this.labelControl1 = new OeF.Forms.Controls.LabelControl();
            this.memoEdit2 = new OeF.Forms.Controls.MemoEdit();
            this.memoEdit1 = new OeF.Forms.Controls.MemoEdit();
            this.ErrorProviderModificaStatutaria = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseModificaStatutaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderModificaStatutaria)).BeginInit();
            this.SuspendLayout();
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.labelControl3);
            this.ScrollableContent.Controls.Add(this.labelControl1);
            this.ScrollableContent.Controls.Add(this.memoEdit2);
            this.ScrollableContent.Controls.Add(this.memoEdit1);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 24);
            this.ScrollableContent.Size = new System.Drawing.Size(570, 136);
            // 
            // bindingSourceBaseModificaStatutaria
            // 
            this.bindingSourceBaseModificaStatutaria.AutoCreateObjects = false;
            this.bindingSourceBaseModificaStatutaria.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.ModificaStatutariaFDT);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 68);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(105, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Nuova denominazione";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(110, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Vecchia denominazione";
            // 
            // memoEdit2
            // 
            this.memoEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseModificaStatutaria, "NuovaDenominazione", true));
            this.ErrorProviderModificaStatutaria.SetErrorType(this.memoEdit2, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.memoEdit2.Location = new System.Drawing.Point(127, 65);
            this.memoEdit2.Name = "memoEdit2";
            this.memoEdit2.Properties.MaxLength = 250;
            this.memoEdit2.Size = new System.Drawing.Size(425, 53);
            this.memoEdit2.TabIndex = 1;
            // 
            // memoEdit1
            // 
            this.memoEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseModificaStatutaria, "VecchiaDenominazione", true));
            this.ErrorProviderModificaStatutaria.SetErrorType(this.memoEdit1, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.memoEdit1.Location = new System.Drawing.Point(127, 6);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.MaxLength = 250;
            this.memoEdit1.Properties.ReadOnly = true;
            this.memoEdit1.Size = new System.Drawing.Size(425, 53);
            this.memoEdit1.TabIndex = 30;
            this.memoEdit1.TabStop = false;
            // 
            // ErrorProviderModificaStatutaria
            // 
            this.ErrorProviderModificaStatutaria.ContainerControl = this;
            this.ErrorProviderModificaStatutaria.DataSource = this.bindingSourceBaseModificaStatutaria;
            // 
            // NuovaDenominazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "NuovaDenominazione";
            this.Size = new System.Drawing.Size(570, 160);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            this.ScrollableContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseModificaStatutaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderModificaStatutaria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OeF.Forms.BindingSourceBase bindingSourceBaseModificaStatutaria;
        private OeF.Forms.Controls.LabelControl labelControl3;
        private OeF.Forms.Controls.LabelControl labelControl1;
        private OeF.Forms.Controls.MemoEdit memoEdit2;
        private OeF.Forms.Controls.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ErrorProviderModificaStatutaria;
    }
}
