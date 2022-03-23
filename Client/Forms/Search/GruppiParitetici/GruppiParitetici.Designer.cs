namespace it.dedagroup.GVC.Client.Forms.Search.GruppiParitetici
{
    partial class GruppiParitetici
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
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonModifica = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemElimina = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonSalva = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonAnnulla = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonChiudi = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new it.dedagroup.GVC.Client.Forms.Controls.PanelControl();
            this.gruppoPariteticoHeader1 = new it.dedagroup.GVC.Client.Forms.Search.GruppiParitetici.GruppoPariteticoHeader();
            this.groupControl1 = new it.dedagroup.GVC.Client.Forms.Controls.GroupControl();
            this.cooperativeGruppoParitetico1 = new it.dedagroup.GVC.Client.Forms.Search.GruppiParitetici.CooperativeGruppoParitetico();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarManager
            // 
            this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonModifica,
            this.barButtonSalva,
            this.barButtonAnnulla,
            this.barButtonChiudi,
            this.barButtonItemElimina});
            this.BarManager.MaxItemId = 14;
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.groupControl1);
            this.ScrollableContent.Controls.Add(this.panelControl1);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 49);
            this.ScrollableContent.Size = new System.Drawing.Size(873, 349);
            // 
            // bar1
            // 
            this.bar1.BarName = "BasicToolBar";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonModifica),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemElimina, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonSalva),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonAnnulla),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonChiudi)});
            this.bar1.Text = "BasicToolBar";
            // 
            // barButtonModifica
            // 
            this.barButtonModifica.Caption = "Modifica";
            this.barButtonModifica.Id = 9;
            this.barButtonModifica.Name = "barButtonModifica";
            this.barButtonModifica.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonModifica.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonModifica_ItemClick);
            // 
            // barButtonItemElimina
            // 
            this.barButtonItemElimina.Caption = "Elimina";
            this.barButtonItemElimina.Id = 13;
            this.barButtonItemElimina.Name = "barButtonItemElimina";
            this.barButtonItemElimina.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemElimina_ItemClick);
            // 
            // barButtonSalva
            // 
            this.barButtonSalva.Caption = "Salva";
            this.barButtonSalva.Id = 10;
            this.barButtonSalva.Name = "barButtonSalva";
            this.barButtonSalva.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonSalva.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonSalva_ItemClick);
            // 
            // barButtonAnnulla
            // 
            this.barButtonAnnulla.Caption = "Annulla";
            this.barButtonAnnulla.Id = 11;
            this.barButtonAnnulla.Name = "barButtonAnnulla";
            this.barButtonAnnulla.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonAnnulla.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonAnnulla_ItemClick);
            // 
            // barButtonChiudi
            // 
            this.barButtonChiudi.Caption = "Chiudi";
            this.barButtonChiudi.Id = 12;
            this.barButtonChiudi.Name = "barButtonChiudi";
            this.barButtonChiudi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonChiudi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonChiudi_ItemClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gruppoPariteticoHeader1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(873, 100);
            this.panelControl1.TabIndex = 0;
            // 
            // gruppoPariteticoHeader1
            // 
            this.gruppoPariteticoHeader1.ApplicationTitle = "";
            this.gruppoPariteticoHeader1.ConfirmCancel = true;
            this.gruppoPariteticoHeader1.ConfirmCancelMessage = "";
            this.gruppoPariteticoHeader1.CurrentSequenceID = null;
            this.gruppoPariteticoHeader1.CurrentTaskID = null;
            this.gruppoPariteticoHeader1.IsShowing = false;
            this.gruppoPariteticoHeader1.Location = new System.Drawing.Point(19, 15);
            this.gruppoPariteticoHeader1.Name = "gruppoPariteticoHeader1";
            this.gruppoPariteticoHeader1.PageCaption = "";
            this.gruppoPariteticoHeader1.ReadOnlyControls = true;
            this.gruppoPariteticoHeader1.Size = new System.Drawing.Size(850, 62);
            this.gruppoPariteticoHeader1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.cooperativeGruppoParitetico1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 100);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(873, 249);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Elenco cooperative";
            // 
            // cooperativeGruppoParitetico1
            // 
            this.cooperativeGruppoParitetico1.ApplicationTitle = "";
            this.cooperativeGruppoParitetico1.ConfirmCancel = false;
            this.cooperativeGruppoParitetico1.ConfirmCancelMessage = "";
            this.cooperativeGruppoParitetico1.CurrentSequenceID = null;
            this.cooperativeGruppoParitetico1.CurrentTaskID = null;
            this.cooperativeGruppoParitetico1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cooperativeGruppoParitetico1.IsShowing = false;
            this.cooperativeGruppoParitetico1.Location = new System.Drawing.Point(2, 20);
            this.cooperativeGruppoParitetico1.Name = "cooperativeGruppoParitetico1";
            this.cooperativeGruppoParitetico1.PageCaption = "";
            this.cooperativeGruppoParitetico1.ReadOnlyControls = true;
            this.cooperativeGruppoParitetico1.Size = new System.Drawing.Size(869, 227);
            this.cooperativeGruppoParitetico1.TabIndex = 0;
            // 
            // GruppiParitetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "GruppiParitetici";
            this.Size = new System.Drawing.Size(873, 398);
            this.Load += new System.EventHandler(this.GruppiParitetici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonSalva;
        private DevExpress.XtraBars.BarButtonItem barButtonModifica;
        private DevExpress.XtraBars.BarButtonItem barButtonAnnulla;
        private DevExpress.XtraBars.BarButtonItem barButtonChiudi;
        private it.dedagroup.GVC.Client.Forms.Controls.PanelControl panelControl1;
        private GruppoPariteticoHeader gruppoPariteticoHeader1;
        private it.dedagroup.GVC.Client.Forms.Controls.GroupControl groupControl1;
        private CooperativeGruppoParitetico cooperativeGruppoParitetico1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemElimina;
    }
}
