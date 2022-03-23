namespace it.dedagroup.GVC.Client.Forms.Registry
{
    partial class AnagraficaEdit
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
            this.panelRegistryType = new System.Windows.Forms.Panel();
            this.lookUpEditTipoSoggetto = new it.dedagroup.GVC.Client.Forms.Controls.LookUpEdit();
            this.bindingSourceSoggetto = new OeF.Forms.BindingSourceBase(this.components);
            this.bindingSourceTipoSoggetto = new OeF.Forms.BindingSourceBase(this.components);
            this.labelControl2 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.panelData = new System.Windows.Forms.Panel();
            this.bindingSourceBaseAddresses = new OeF.Forms.BindingSourceBase(this.components);
            this.bindingSourceBaseAddressTypes = new OeF.Forms.BindingSourceBase(this.components);
            this.indirizzoDetail1 = new it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Data.Indirizzo.IndirizzoDetail();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            this.panelRegistryType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTipoSoggetto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSoggetto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoSoggetto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseAddresses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseAddressTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelButtons
            // 
            this.PanelButtons.Location = new System.Drawing.Point(0, 216);
            this.PanelButtons.Size = new System.Drawing.Size(657, 40);
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.indirizzoDetail1);
            this.ScrollableContent.Controls.Add(this.panelData);
            this.ScrollableContent.Controls.Add(this.panelRegistryType);
            this.ScrollableContent.Size = new System.Drawing.Size(657, 256);
            this.ScrollableContent.Controls.SetChildIndex(this.PanelButtons, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.panelRegistryType, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.panelData, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.indirizzoDetail1, 0);
            // 
            // panelRegistryType
            // 
            this.panelRegistryType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRegistryType.Controls.Add(this.lookUpEditTipoSoggetto);
            this.panelRegistryType.Controls.Add(this.labelControl2);
            this.panelRegistryType.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRegistryType.Location = new System.Drawing.Point(0, 0);
            this.panelRegistryType.Name = "panelRegistryType";
            this.panelRegistryType.Size = new System.Drawing.Size(657, 50);
            this.panelRegistryType.TabIndex = 1;
            // 
            // lookUpEditTipoSoggetto
            // 
            this.lookUpEditTipoSoggetto.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceSoggetto, "IdTipoSoggetto", true));
            this.lookUpEditTipoSoggetto.Location = new System.Drawing.Point(223, 14);
            this.lookUpEditTipoSoggetto.Name = "lookUpEditTipoSoggetto";
            this.lookUpEditTipoSoggetto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditTipoSoggetto.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descrizione", "Tipo", 100)});
            this.lookUpEditTipoSoggetto.Properties.DataSource = this.bindingSourceTipoSoggetto;
            this.lookUpEditTipoSoggetto.Properties.DisplayMember = "Descrizione";
            this.lookUpEditTipoSoggetto.Properties.NullText = "";
            this.lookUpEditTipoSoggetto.Properties.ValueMember = "IdElemento";
            this.lookUpEditTipoSoggetto.Size = new System.Drawing.Size(234, 20);
            this.lookUpEditTipoSoggetto.TabIndex = 31;
            this.lookUpEditTipoSoggetto.EditValueChanged += new System.EventHandler(this.lookUpEditTipoSoggetto_EditValueChanged);
            // 
            // bindingSourceSoggetto
            // 
            this.bindingSourceSoggetto.AutoCreateObjects = false;
            this.bindingSourceSoggetto.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.PersonaFisicaFDT);
            // 
            // bindingSourceTipoSoggetto
            // 
            this.bindingSourceTipoSoggetto.AutoCreateObjects = false;
            this.bindingSourceTipoSoggetto.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(197, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 13);
            this.labelControl2.TabIndex = 32;
            this.labelControl2.Text = "Tipo";
            // 
            // panelData
            // 
            this.panelData.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelData.Location = new System.Drawing.Point(0, 50);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(657, 12);
            this.panelData.TabIndex = 4;
            // 
            // bindingSourceBaseAddresses
            // 
            this.bindingSourceBaseAddresses.AutoCreateObjects = false;
            this.bindingSourceBaseAddresses.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.IndirizzoFDT);
            // 
            // bindingSourceBaseAddressTypes
            // 
            this.bindingSourceBaseAddressTypes.AutoCreateObjects = false;
            this.bindingSourceBaseAddressTypes.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.Dictionaries.TipoIndirizzoFDT);
            // 
            // indirizzoDetail1
            // 
            this.indirizzoDetail1.ApplicationEngine = null;
            this.indirizzoDetail1.ApplicationTitle = "";
            this.indirizzoDetail1.ConfirmCancel = true;
            this.indirizzoDetail1.ConfirmCancelMessage = "";
            this.indirizzoDetail1.CurrentSequenceID = null;
            this.indirizzoDetail1.CurrentTaskID = null;
            this.indirizzoDetail1.Dock = System.Windows.Forms.DockStyle.Top;
            this.indirizzoDetail1.IsShowing = false;
            this.indirizzoDetail1.Location = new System.Drawing.Point(0, 62);
            this.indirizzoDetail1.Name = "indirizzoDetail1";
            this.indirizzoDetail1.PageCaption = "";
            this.indirizzoDetail1.ReadOnlyControls = true;
            this.indirizzoDetail1.Size = new System.Drawing.Size(657, 145);
            this.indirizzoDetail1.TabIndex = 5;
            // 
            // AnagraficaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "AnagraficaEdit";
            this.Size = new System.Drawing.Size(657, 280);
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            this.panelRegistryType.ResumeLayout(false);
            this.panelRegistryType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTipoSoggetto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSoggetto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoSoggetto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseAddresses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseAddressTypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRegistryType;
        private it.dedagroup.GVC.Client.Forms.Controls.LookUpEdit lookUpEditTipoSoggetto;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl2;
        private OeF.Forms.BindingSourceBase bindingSourceSoggetto;
        private System.Windows.Forms.Panel panelData;
        private OeF.Forms.BindingSourceBase bindingSourceTipoSoggetto;
        private OeF.Forms.BindingSourceBase bindingSourceBaseAddresses;
        private OeF.Forms.BindingSourceBase bindingSourceBaseAddressTypes;
        private it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Data.Indirizzo.IndirizzoDetail indirizzoDetail1;
    }
}
