namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Statuto.Assemblea.ModificheStatutarie
{
    partial class CollegamentoEdit
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
            this.btnSearchAssociation = new it.dedagroup.GVC.Client.Forms.Controls.SimpleButton();
            this.memoEdit2 = new OeF.Forms.Controls.MemoEdit();
            this.bindingSourceBaseSocietaColl = new OeF.Forms.BindingSourceBase(this.components);
            this.labelControl2 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.bindingSourceBaseModificaStatutaria = new OeF.Forms.BindingSourceBase(this.components);
            this.labelControl1 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseSocietaColl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseModificaStatutaria)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelButtons
            // 
            this.PanelButtons.Location = new System.Drawing.Point(0, 91);
            this.PanelButtons.Size = new System.Drawing.Size(564, 40);
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.labelControl1);
            this.ScrollableContent.Controls.Add(this.memoEdit2);
            this.ScrollableContent.Controls.Add(this.btnSearchAssociation);
            this.ScrollableContent.Controls.Add(this.labelControl2);
            this.ScrollableContent.Size = new System.Drawing.Size(564, 131);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl2, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.btnSearchAssociation, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.memoEdit2, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.PanelButtons, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl1, 0);
            // 
            // btnSearchAssociation
            // 
            this.btnSearchAssociation.Location = new System.Drawing.Point(475, 34);
            this.btnSearchAssociation.Name = "btnSearchAssociation";
            this.btnSearchAssociation.Size = new System.Drawing.Size(75, 23);
            this.btnSearchAssociation.TabIndex = 65;
            this.btnSearchAssociation.Text = "Ricerca";
            this.btnSearchAssociation.Click += new System.EventHandler(this.btnSearchAssociation_Click);
            // 
            // memoEdit2
            // 
            this.memoEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceBaseSocietaColl, "Societa_DescrizioneBreve", true));
            this.memoEdit2.Location = new System.Drawing.Point(111, 32);
            this.memoEdit2.Name = "memoEdit2";
            this.memoEdit2.Size = new System.Drawing.Size(358, 43);
            this.memoEdit2.TabIndex = 64;
            // 
            // bindingSourceBaseSocietaColl
            // 
            this.bindingSourceBaseSocietaColl.AutoCreateObjects = false;
            this.bindingSourceBaseSocietaColl.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.CollegamentoSocietaFDT);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 13);
            this.labelControl2.TabIndex = 66;
            this.labelControl2.Text = "Società da collegare";
            // 
            // bindingSourceBaseModificaStatutaria
            // 
            this.bindingSourceBaseModificaStatutaria.AutoCreateObjects = false;
            this.bindingSourceBaseModificaStatutaria.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.ModificaStatutariaFDT);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(9, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(165, 13);
            this.labelControl1.TabIndex = 69;
            this.labelControl1.Text = "Dati della modifica statutaria";
            // 
            // CollegamentoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CollegamentoEdit";
            this.Size = new System.Drawing.Size(564, 155);
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            this.ScrollableContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseSocietaColl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseModificaStatutaria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private it.dedagroup.GVC.Client.Forms.Controls.SimpleButton btnSearchAssociation;
        private OeF.Forms.Controls.MemoEdit memoEdit2;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl2;
        private OeF.Forms.BindingSourceBase bindingSourceBaseModificaStatutaria;
        private OeF.Forms.BindingSourceBase bindingSourceBaseSocietaColl;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl1;
    }
}
