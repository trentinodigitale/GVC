namespace it.dedagroup.GVC.Client.Forms.Vocabolari
{
    partial class CartelleEdit
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.bindingSourceBaseDizionario = new OeF.Forms.BindingSourceBase(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.memoEdit2 = new DevExpress.XtraEditors.MemoEdit();
            this.textEditID = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseDizionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelButtons
            // 
            this.PanelButtons.Location = new System.Drawing.Point(0, 168);
            this.PanelButtons.Size = new System.Drawing.Size(403, 40);
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.textEditID);
            this.ScrollableContent.Controls.Add(this.memoEdit2);
            this.ScrollableContent.Controls.Add(this.labelControl2);
            this.ScrollableContent.Controls.Add(this.labelControl1);
            this.ScrollableContent.Controls.Add(this.labelControl3);
            this.ScrollableContent.Controls.Add(this.memoEdit1);
            this.ScrollableContent.Controls.Add(this.labelControl8);
            this.ScrollableContent.Size = new System.Drawing.Size(403, 208);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl8, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.PanelButtons, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.memoEdit1, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl3, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl1, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl2, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.memoEdit2, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.textEditID, 0);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 139);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 13);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "ID maschera";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(3, 6);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(69, 13);
            this.labelControl8.TabIndex = 12;
            this.labelControl8.Text = "Dati cartella";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 86);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Percorso";
            // 
            // bindingSourceBaseDizionario
            // 
            this.bindingSourceBaseDizionario.AutoCreateObjects = false;
            this.bindingSourceBaseDizionario.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.Dictionaries.CartellaFDT);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 32);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 13);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Descrizione";
            // 
            // memoEdit1
            // 
            this.memoEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseDizionario, "Descrizione", true));
            this.memoEdit1.Location = new System.Drawing.Point(71, 30);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.MaxLength = 250;
            this.memoEdit1.Size = new System.Drawing.Size(319, 47);
            this.memoEdit1.TabIndex = 1;
            // 
            // memoEdit2
            // 
            this.memoEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseDizionario, "Path", true));
            this.memoEdit2.Location = new System.Drawing.Point(71, 83);
            this.memoEdit2.Name = "memoEdit2";
            this.memoEdit2.Properties.MaxLength = 2000;
            this.memoEdit2.Size = new System.Drawing.Size(319, 47);
            this.memoEdit2.TabIndex = 2;
            // 
            // textEditID
            // 
            this.textEditID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseDizionario, "IdMaschera", true));
            this.textEditID.Location = new System.Drawing.Point(71, 136);
            this.textEditID.Name = "textEditID";
            this.textEditID.Properties.Mask.EditMask = "f0";
            this.textEditID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditID.Properties.MaxLength = 2;
            this.textEditID.Size = new System.Drawing.Size(119, 20);
            this.textEditID.TabIndex = 3;
            // 
            // CartelleEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CartelleEdit";
            this.Size = new System.Drawing.Size(403, 232);
            this.Shown += new System.EventHandler(this.CartelleEdit_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            this.ScrollableContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseDizionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.MemoEdit memoEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private OeF.Forms.BindingSourceBase bindingSourceBaseDizionario;
        private DevExpress.XtraEditors.TextEdit textEditID;
    }
}
