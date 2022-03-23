namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Data
{
    partial class DataGenerics
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBoxGruppiPar = new System.Windows.Forms.GroupBox();
            this.labelControl38 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.checkEdit3 = new it.dedagroup.GVC.Client.Forms.Controls.CheckEdit();
            this.bindingSourceBaseCooperativa = new OeF.Forms.BindingSourceBase(this.components);
            this.labelControl37 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.checkEdit1 = new it.dedagroup.GVC.Client.Forms.Controls.CheckEdit();
            this.checkEdit2 = new it.dedagroup.GVC.Client.Forms.Controls.CheckEdit();
            this.labelControl19 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.labelControl20 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.labelControl21 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.labelControl22 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.textEdit12 = new it.dedagroup.GVC.Client.Forms.Controls.TextEdit();
            this.textEdit13 = new it.dedagroup.GVC.Client.Forms.Controls.TextEdit();
            this.registroCooperativaFDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textEdit14 = new it.dedagroup.GVC.Client.Forms.Controls.TextEdit();
            this.ErrorProviderCooperativa = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.memoEditGruppi = new OeF.Forms.Controls.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBoxGruppiPar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseCooperativa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit12.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit13.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroCooperativaFDTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit14.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderCooperativa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditGruppi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.groupBox3);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 24);
            this.ScrollableContent.Size = new System.Drawing.Size(787, 115);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBoxGruppiPar);
            this.groupBox3.Controls.Add(this.labelControl38);
            this.groupBox3.Controls.Add(this.checkEdit3);
            this.groupBox3.Controls.Add(this.labelControl37);
            this.groupBox3.Controls.Add(this.checkEdit1);
            this.groupBox3.Controls.Add(this.checkEdit2);
            this.groupBox3.Controls.Add(this.labelControl19);
            this.groupBox3.Controls.Add(this.labelControl20);
            this.groupBox3.Controls.Add(this.labelControl21);
            this.groupBox3.Controls.Add(this.labelControl22);
            this.groupBox3.Controls.Add(this.textEdit12);
            this.groupBox3.Controls.Add(this.textEdit13);
            this.groupBox3.Controls.Add(this.textEdit14);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(787, 115);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // groupBoxGruppiPar
            // 
            this.groupBoxGruppiPar.Controls.Add(this.memoEditGruppi);
            this.groupBoxGruppiPar.Location = new System.Drawing.Point(566, 12);
            this.groupBoxGruppiPar.Name = "groupBoxGruppiPar";
            this.groupBoxGruppiPar.Size = new System.Drawing.Size(200, 70);
            this.groupBoxGruppiPar.TabIndex = 59;
            this.groupBoxGruppiPar.TabStop = false;
            this.groupBoxGruppiPar.Text = "Appartenenza gruppi paritetici";
            // 
            // labelControl38
            // 
            this.labelControl38.Location = new System.Drawing.Point(301, 91);
            this.labelControl38.Name = "labelControl38";
            this.labelControl38.Size = new System.Drawing.Size(233, 13);
            this.labelControl38.TabIndex = 57;
            this.labelControl38.Text = "La cooperativa è associazione di rappresentanza";
            // 
            // checkEdit3
            // 
            this.checkEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseCooperativa, "Associazione", true));
            this.ErrorProviderCooperativa.SetErrorType(this.checkEdit3, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.checkEdit3.Location = new System.Drawing.Point(540, 90);
            this.checkEdit3.Name = "checkEdit3";
            this.checkEdit3.Properties.Caption = "";
            this.checkEdit3.Size = new System.Drawing.Size(22, 19);
            this.checkEdit3.TabIndex = 6;
            // 
            // bindingSourceBaseCooperativa
            // 
            this.bindingSourceBaseCooperativa.AutoCreateObjects = false;
            this.bindingSourceBaseCooperativa.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.CooperativaFDT);
            // 
            // labelControl37
            // 
            this.labelControl37.Location = new System.Drawing.Point(389, 43);
            this.labelControl37.Name = "labelControl37";
            this.labelControl37.Size = new System.Drawing.Size(143, 13);
            this.labelControl37.TabIndex = 55;
            this.labelControl37.Text = "Gruppo cooperativo paritetico";
            // 
            // checkEdit1
            // 
            this.checkEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseCooperativa, "RegistroCooperativa_GruppoParitetico", true));
            this.ErrorProviderCooperativa.SetErrorType(this.checkEdit1, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.checkEdit1.Location = new System.Drawing.Point(538, 41);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "";
            this.checkEdit1.Size = new System.Drawing.Size(22, 19);
            this.checkEdit1.TabIndex = 3;
            // 
            // checkEdit2
            // 
            this.checkEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseCooperativa, "RegistroCooperativa_EsenzioneVersamentoUtili", true));
            this.ErrorProviderCooperativa.SetErrorType(this.checkEdit2, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.checkEdit2.Location = new System.Drawing.Point(277, 43);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "";
            this.checkEdit2.Size = new System.Drawing.Size(22, 19);
            this.checkEdit2.TabIndex = 2;
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(32, 20);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(98, 13);
            this.labelControl19.TabIndex = 50;
            this.labelControl19.Text = "Numero scioglimento";
            // 
            // labelControl20
            // 
            this.labelControl20.Location = new System.Drawing.Point(32, 43);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(239, 13);
            this.labelControl20.TabIndex = 49;
            this.labelControl20.Text = "Esentato dal versamento percento degli utili annui";
            // 
            // labelControl21
            // 
            this.labelControl21.Location = new System.Drawing.Point(32, 65);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(83, 13);
            this.labelControl21.TabIndex = 48;
            this.labelControl21.Text = "Codice operatore";
            // 
            // labelControl22
            // 
            this.labelControl22.Location = new System.Drawing.Point(51, 91);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(64, 13);
            this.labelControl22.TabIndex = 47;
            this.labelControl22.Text = "Codice ufficio";
            // 
            // textEdit12
            // 
            this.textEdit12.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseCooperativa, "RegistroCooperativa_CodiceUfficio", true));
            this.ErrorProviderCooperativa.SetErrorType(this.textEdit12, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.textEdit12.Location = new System.Drawing.Point(121, 88);
            this.textEdit12.Name = "textEdit12";
            this.textEdit12.Properties.MaxLength = 25;
            this.textEdit12.Size = new System.Drawing.Size(144, 20);
            this.textEdit12.TabIndex = 5;
            // 
            // textEdit13
            // 
            this.textEdit13.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.registroCooperativaFDTBindingSource, "NumeroScioglimento", true));
            this.textEdit13.Location = new System.Drawing.Point(136, 17);
            this.textEdit13.Name = "textEdit13";
            this.textEdit13.Properties.MaxLength = 10;
            this.textEdit13.Size = new System.Drawing.Size(57, 20);
            this.textEdit13.TabIndex = 1;
            // 
            // registroCooperativaFDTBindingSource
            // 
            this.registroCooperativaFDTBindingSource.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.RegistroCooperativaFDT);
            // 
            // textEdit14
            // 
            this.textEdit14.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseCooperativa, "RegistroCooperativa_CodiceOperatore", true));
            this.ErrorProviderCooperativa.SetErrorType(this.textEdit14, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.textEdit14.Location = new System.Drawing.Point(121, 62);
            this.textEdit14.Name = "textEdit14";
            this.textEdit14.Properties.MaxLength = 25;
            this.textEdit14.Size = new System.Drawing.Size(144, 20);
            this.textEdit14.TabIndex = 4;
            // 
            // ErrorProviderCooperativa
            // 
            this.ErrorProviderCooperativa.ContainerControl = this;
            this.ErrorProviderCooperativa.DataSource = this.bindingSourceBaseCooperativa;
            // 
            // memoEditGruppi
            // 
            this.memoEditGruppi.Location = new System.Drawing.Point(6, 20);
            this.memoEditGruppi.Name = "memoEditGruppi";
            this.memoEditGruppi.Properties.MaxLength = 1000;
            this.memoEditGruppi.Size = new System.Drawing.Size(188, 46);
            this.memoEditGruppi.TabIndex = 9;
            // 
            // DataGenerics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "DataGenerics";
            this.Size = new System.Drawing.Size(787, 139);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxGruppiPar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseCooperativa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit12.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit13.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroCooperativaFDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit14.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderCooperativa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditGruppi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl37;
        private it.dedagroup.GVC.Client.Forms.Controls.CheckEdit checkEdit1;
        private it.dedagroup.GVC.Client.Forms.Controls.CheckEdit checkEdit2;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl19;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl20;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl21;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl22;
        private it.dedagroup.GVC.Client.Forms.Controls.TextEdit textEdit12;
        private it.dedagroup.GVC.Client.Forms.Controls.TextEdit textEdit13;
        private it.dedagroup.GVC.Client.Forms.Controls.TextEdit textEdit14;
        private OeF.Forms.BindingSourceBase bindingSourceBaseCooperativa;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl38;
        private it.dedagroup.GVC.Client.Forms.Controls.CheckEdit checkEdit3;
        public DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ErrorProviderCooperativa;
        private System.Windows.Forms.BindingSource registroCooperativaFDTBindingSource;
        private System.Windows.Forms.GroupBox groupBoxGruppiPar;
        private OeF.Forms.Controls.MemoEdit memoEditGruppi;
    }
}
