namespace it.dedagroup.GVC.Client.Forms.Cooperative
{
    partial class CooperativeEdit1
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
            this.coopData1 = new it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.CoopData();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemModify = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemSave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemUndo = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemClose = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEvidence = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemGetParixData = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonAggiornamenti = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // BarManager
            // 
            this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemModify,
            this.barButtonItemSave,
            this.barButtonItemEvidence,
            this.barButtonItemGetParixData,
            this.barButtonItemUndo,
            this.barButtonItemClose,
            this.barButtonAggiornamenti});
            this.BarManager.MaxItemId = 16;
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.coopData1);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 49);
            this.ScrollableContent.Size = new System.Drawing.Size(893, 435);
            // 
            // coopData1
            // 
            this.coopData1.ApplicationTitle = "";
            this.coopData1.ConfirmCancel = true;
            this.coopData1.ConfirmCancelMessage = "";
            this.coopData1.CurrentSequenceID = null;
            this.coopData1.CurrentTaskID = null;
            this.coopData1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coopData1.IsShowing = false;
            this.coopData1.Location = new System.Drawing.Point(0, 0);
            this.coopData1.Name = "coopData1";
            this.coopData1.PageCaption = "";
            this.coopData1.ReadOnlyControls = true;
            this.coopData1.Size = new System.Drawing.Size(893, 435);
            this.coopData1.TabIndex = 0;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemModify, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemClose, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemEvidence, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemGetParixData),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonAggiornamenti)});
            this.bar1.Text = "Custom 2";
            // 
            // barButtonItemModify
            // 
            this.barButtonItemModify.Caption = "Modifica";
            this.barButtonItemModify.Id = 9;
            this.barButtonItemModify.Name = "barButtonItemModify";
            this.barButtonItemModify.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemModify_ItemClick);
            // 
            // barButtonItemSave
            // 
            this.barButtonItemSave.Caption = "Salva";
            this.barButtonItemSave.Id = 10;
            this.barButtonItemSave.Name = "barButtonItemSave";
            this.barButtonItemSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSave_ItemClick);
            // 
            // barButtonItemUndo
            // 
            this.barButtonItemUndo.Caption = "Annulla";
            this.barButtonItemUndo.Id = 13;
            this.barButtonItemUndo.Name = "barButtonItemUndo";
            this.barButtonItemUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemUndo_ItemClick);
            // 
            // barButtonItemClose
            // 
            this.barButtonItemClose.Caption = "Chiudi";
            this.barButtonItemClose.Id = 14;
            this.barButtonItemClose.Name = "barButtonItemClose";
            this.barButtonItemClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemClose_ItemClick);
            // 
            // barButtonItemEvidence
            // 
            this.barButtonItemEvidence.Caption = "Evidenze";
            this.barButtonItemEvidence.Id = 11;
            this.barButtonItemEvidence.Name = "barButtonItemEvidence";
            this.barButtonItemEvidence.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemEvidence_ItemClick);
            // 
            // barButtonItemGetParixData
            // 
            this.barButtonItemGetParixData.Caption = "Cerca in Parix";
            this.barButtonItemGetParixData.Id = 12;
            this.barButtonItemGetParixData.Name = "barButtonItemGetParixData";
            this.barButtonItemGetParixData.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItemGetParixData.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemGetParixData_ItemClick);
            // 
            // barButtonAggiornamenti
            // 
            this.barButtonAggiornamenti.Caption = "Aggiornamenti";
            this.barButtonAggiornamenti.Id = 15;
            this.barButtonAggiornamenti.Name = "barButtonAggiornamenti";
            this.barButtonAggiornamenti.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonAggiornamenti.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonAggiornamenti_ItemClick);
            // 
            // CooperativeEdit1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CooperativeEdit1";
            this.Size = new System.Drawing.Size(893, 484);
            this.Load += new System.EventHandler(this.CooperativeEdit1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.CoopData coopData1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemModify;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSave;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEvidence;
        private DevExpress.XtraBars.BarButtonItem barButtonItemGetParixData;
        private DevExpress.XtraBars.BarButtonItem barButtonItemUndo;
        private DevExpress.XtraBars.BarButtonItem barButtonItemClose;
        private DevExpress.XtraBars.BarButtonItem barButtonAggiornamenti;
    }
}
