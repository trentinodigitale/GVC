namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Statuto.Assemblea.ModificheStatutarie
{
    partial class NuovoScioglimentoVolontario
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
            this.labelControl2 = new OeF.Forms.Controls.LabelControl();
            this.labelControl7 = new OeF.Forms.Controls.LabelControl();
            this.bindingSourceBaseStato = new OeF.Forms.BindingSourceBase(this.components);
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.gridControlCariche = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceCariche = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.gridViewCariche = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescrizioneSocio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ErrorProviderModificaStatutaria = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.checkEditNrScioglimento = new it.dedagroup.GVC.Client.Forms.Controls.CheckEdit();
            this.labelControl1 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.labelControl3 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseModificaStatutaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseStato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCariche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCariche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCariche)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderModificaStatutaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditNrScioglimento.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.labelControl3);
            this.ScrollableContent.Controls.Add(this.labelControl1);
            this.ScrollableContent.Controls.Add(this.checkEditNrScioglimento);
            this.ScrollableContent.Controls.Add(this.groupBox1);
            this.ScrollableContent.Controls.Add(this.labelControl2);
            this.ScrollableContent.Controls.Add(this.labelControl7);
            this.ScrollableContent.Controls.Add(this.lookUpEdit2);
            this.ScrollableContent.Controls.Add(this.lookUpEdit1);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 24);
            this.ScrollableContent.Size = new System.Drawing.Size(570, 294);
            // 
            // bindingSourceBaseModificaStatutaria
            // 
            this.bindingSourceBaseModificaStatutaria.AutoCreateObjects = false;
            this.bindingSourceBaseModificaStatutaria.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.ModificaStatutariaFDT);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(53, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Stato nuovo";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(49, 6);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(63, 13);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Stato attuale";
            // 
            // bindingSourceBaseStato
            // 
            this.bindingSourceBaseStato.AutoCreateObjects = false;
            this.bindingSourceBaseStato.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseModificaStatutaria, "IdNuovoStatoIscrizione", true));
            this.ErrorProviderModificaStatutaria.SetErrorType(this.lookUpEdit2, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.lookUpEdit2.Location = new System.Drawing.Point(118, 29);
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
            this.lookUpEdit2.Size = new System.Drawing.Size(427, 20);
            this.lookUpEdit2.TabIndex = 19;
            this.lookUpEdit2.TabStop = false;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseModificaStatutaria, "IdVecchioStatoIscrizione", true));
            this.ErrorProviderModificaStatutaria.SetErrorType(this.lookUpEdit1, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.lookUpEdit1.Location = new System.Drawing.Point(118, 3);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.DataSource = this.bindingSourceBaseStato;
            this.lookUpEdit1.Properties.DisplayMember = "Descrizione";
            this.lookUpEdit1.Properties.NullText = "";
            this.lookUpEdit1.Properties.ReadOnly = true;
            this.lookUpEdit1.Properties.ValueMember = "IdElemento";
            this.lookUpEdit1.Size = new System.Drawing.Size(427, 20);
            this.lookUpEdit1.TabIndex = 1;
            this.lookUpEdit1.TabStop = false;
            // 
            // gridControlCariche
            // 
            this.gridControlCariche.DataSource = this.bindingSourceCariche;
            this.gridControlCariche.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlCariche.Location = new System.Drawing.Point(3, 24);
            this.gridControlCariche.MainView = this.gridViewCariche;
            this.gridControlCariche.Name = "gridControlCariche";
            this.gridControlCariche.Size = new System.Drawing.Size(513, 131);
            this.gridControlCariche.TabIndex = 20;
            this.gridControlCariche.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCariche});
            // 
            // bindingSourceCariche
            // 
            this.bindingSourceCariche.AutoCreateObjects = false;
            this.bindingSourceCariche.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.CaricaSocialeFDT);
            // 
            // gridViewCariche
            // 
            this.gridViewCariche.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescrizioneSocio});
            this.gridViewCariche.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewCariche.GridControl = this.gridControlCariche;
            this.gridViewCariche.Name = "gridViewCariche";
            this.gridViewCariche.OptionsCustomization.AllowFilter = false;
            this.gridViewCariche.OptionsMenu.EnableColumnMenu = false;
            this.gridViewCariche.OptionsMenu.EnableFooterMenu = false;
            this.gridViewCariche.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewCariche.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewCariche.OptionsView.ShowGroupPanel = false;
            this.gridViewCariche.OptionsView.ShowIndicator = false;
            // 
            // colDescrizioneSocio
            // 
            this.colDescrizioneSocio.Caption = "Nominativo";
            this.colDescrizioneSocio.FieldName = "DescrizioneSocio";
            this.colDescrizioneSocio.Name = "colDescrizioneSocio";
            this.colDescrizioneSocio.Visible = true;
            this.colDescrizioneSocio.VisibleIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControlCariche);
            this.groupBox1.Location = new System.Drawing.Point(26, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 158);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liquidatori";
            // 
            // ErrorProviderModificaStatutaria
            // 
            this.ErrorProviderModificaStatutaria.ContainerControl = this;
            this.ErrorProviderModificaStatutaria.DataSource = this.bindingSourceBaseModificaStatutaria;
            // 
            // checkEditNrScioglimento
            // 
            this.checkEditNrScioglimento.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseModificaStatutaria, "AggiornaNrScioglimento", true));
            this.ErrorProviderModificaStatutaria.SetErrorType(this.checkEditNrScioglimento, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.checkEditNrScioglimento.Location = new System.Drawing.Point(297, 52);
            this.checkEditNrScioglimento.Name = "checkEditNrScioglimento";
            this.checkEditNrScioglimento.Properties.Caption = "";
            this.checkEditNrScioglimento.Size = new System.Drawing.Size(19, 19);
            this.checkEditNrScioglimento.TabIndex = 82;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(118, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(173, 13);
            this.labelControl1.TabIndex = 83;
            this.labelControl1.Text = "Aggiornamento numero scioglimento";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(26, 262);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(184, 13);
            this.labelControl3.TabIndex = 84;
            this.labelControl3.Text = "Aggiornare l\'elenco delle cariche sociali";
            // 
            // NuovoScioglimentoVolontario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "NuovoScioglimentoVolontario";
            this.Size = new System.Drawing.Size(570, 318);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            this.ScrollableContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseModificaStatutaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseStato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCariche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCariche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCariche)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderModificaStatutaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditNrScioglimento.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OeF.Forms.BindingSourceBase bindingSourceBaseModificaStatutaria;
        private OeF.Forms.Controls.LabelControl labelControl2;
        private OeF.Forms.Controls.LabelControl labelControl7;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private OeF.Forms.BindingSourceBase bindingSourceBaseStato;
        private DevExpress.XtraGrid.GridControl gridControlCariche;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCariche;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceCariche;
        private DevExpress.XtraGrid.Columns.GridColumn colDescrizioneSocio;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ErrorProviderModificaStatutaria;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl1;
        private it.dedagroup.GVC.Client.Forms.Controls.CheckEdit checkEditNrScioglimento;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl3;
    }
}
