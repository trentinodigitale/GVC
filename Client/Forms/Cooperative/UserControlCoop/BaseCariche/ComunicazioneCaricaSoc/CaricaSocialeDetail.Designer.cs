namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.PositionAndBase.ComunicazioneCaricaSoc
{
    partial class CaricaSocialeDetail
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlSocialPosition = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceCariche = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.gridViewSocialPosition = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTipoCarica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bindingSourceTipiCarica = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.colLegaleRappresentante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colLiquidatore = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colDescrizioneSocio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRichiestaAntimafia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colRichiestaAntimafiaProdotta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRichiestaAntimafiaArrivata = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemModify = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemPDF = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuCarica = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSocialPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCariche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSocialPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipiCarica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuCarica)).BeginInit();
            this.SuspendLayout();
            // 
            // BarManager
            // 
            this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemAdd,
            this.barButtonItemDelete,
            this.barButtonItemModify,
            this.barButtonItemPDF});
            this.BarManager.MaxItemId = 16;
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.gridControlSocialPosition);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 49);
            this.ScrollableContent.Size = new System.Drawing.Size(606, 151);
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // gridControlSocialPosition
            // 
            this.gridControlSocialPosition.DataSource = this.bindingSourceCariche;
            this.gridControlSocialPosition.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlSocialPosition.Location = new System.Drawing.Point(0, 0);
            this.gridControlSocialPosition.MainView = this.gridViewSocialPosition;
            this.gridControlSocialPosition.Name = "gridControlSocialPosition";
            this.gridControlSocialPosition.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2,
            this.repositoryItemCheckEdit3,
            this.repositoryItemCheckEdit4,
            this.repositoryItemCheckEdit5,
            this.repositoryItemLookUpEdit2});
            this.gridControlSocialPosition.Size = new System.Drawing.Size(589, 176);
            this.gridControlSocialPosition.TabIndex = 2;
            this.gridControlSocialPosition.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSocialPosition});
            this.gridControlSocialPosition.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlSocialPosition_MouseDoubleClick);
            // 
            // bindingSourceCariche
            // 
            this.bindingSourceCariche.AutoCreateObjects = false;
            this.bindingSourceCariche.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.CaricaSocialeFDT);
            this.bindingSourceCariche.CurrentChanged += new System.EventHandler(this.bindingSourceSocialPosition_CurrentChanged);
            // 
            // gridViewSocialPosition
            // 
            this.gridViewSocialPosition.ColumnPanelRowHeight = 40;
            this.gridViewSocialPosition.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTipoCarica,
            this.colLegaleRappresentante,
            this.colLiquidatore,
            this.colDescrizioneSocio,
            this.colRichiestaAntimafia,
            this.colRichiestaAntimafiaProdotta,
            this.colRichiestaAntimafiaArrivata,
            this.colStatus});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout);
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colStatus;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual;
            styleFormatCondition1.Value1 = "100";
            this.gridViewSocialPosition.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridViewSocialPosition.GridControl = this.gridControlSocialPosition;
            this.gridViewSocialPosition.Name = "gridViewSocialPosition";
            this.gridViewSocialPosition.OptionsCustomization.AllowSort = false;
            this.gridViewSocialPosition.OptionsMenu.EnableColumnMenu = false;
            this.gridViewSocialPosition.OptionsView.ShowGroupPanel = false;
            this.gridViewSocialPosition.OptionsView.ShowIndicator = false;
            this.gridViewSocialPosition.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdTipoCarica, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewSocialPosition.ShowGridMenu += new DevExpress.XtraGrid.Views.Grid.GridMenuEventHandler(this.gridViewSocialPosition_ShowGridMenu);
            // 
            // colIdTipoCarica
            // 
            this.colIdTipoCarica.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdTipoCarica.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdTipoCarica.Caption = "Tipo carica";
            this.colIdTipoCarica.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colIdTipoCarica.FieldName = "IdTipoCarica";
            this.colIdTipoCarica.Name = "colIdTipoCarica";
            this.colIdTipoCarica.OptionsColumn.AllowEdit = false;
            this.colIdTipoCarica.OptionsColumn.AllowFocus = false;
            this.colIdTipoCarica.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIdTipoCarica.OptionsColumn.AllowMove = false;
            this.colIdTipoCarica.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIdTipoCarica.OptionsFilter.AllowAutoFilter = false;
            this.colIdTipoCarica.OptionsFilter.AllowFilter = false;
            this.colIdTipoCarica.Visible = true;
            this.colIdTipoCarica.VisibleIndex = 0;
            this.colIdTipoCarica.Width = 109;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.DataSource = this.bindingSourceTipiCarica;
            this.repositoryItemLookUpEdit2.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.NullText = "";
            this.repositoryItemLookUpEdit2.ValueMember = "IdElemento";
            // 
            // bindingSourceTipiCarica
            // 
            this.bindingSourceTipiCarica.AutoCreateObjects = false;
            this.bindingSourceTipiCarica.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.Dictionaries.TipoCaricaSocialeFDT);
            // 
            // colLegaleRappresentante
            // 
            this.colLegaleRappresentante.AppearanceHeader.Options.UseTextOptions = true;
            this.colLegaleRappresentante.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLegaleRappresentante.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colLegaleRappresentante.Caption = "Legale Rappresentante";
            this.colLegaleRappresentante.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colLegaleRappresentante.FieldName = "LegaleRappresentante";
            this.colLegaleRappresentante.Name = "colLegaleRappresentante";
            this.colLegaleRappresentante.OptionsColumn.AllowEdit = false;
            this.colLegaleRappresentante.OptionsColumn.AllowFocus = false;
            this.colLegaleRappresentante.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colLegaleRappresentante.OptionsColumn.AllowMove = false;
            this.colLegaleRappresentante.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colLegaleRappresentante.OptionsFilter.AllowAutoFilter = false;
            this.colLegaleRappresentante.OptionsFilter.AllowFilter = false;
            this.colLegaleRappresentante.Visible = true;
            this.colLegaleRappresentante.VisibleIndex = 1;
            this.colLegaleRappresentante.Width = 92;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // colLiquidatore
            // 
            this.colLiquidatore.Caption = "Liquidatore";
            this.colLiquidatore.ColumnEdit = this.repositoryItemCheckEdit2;
            this.colLiquidatore.FieldName = "Liquidatore";
            this.colLiquidatore.Name = "colLiquidatore";
            this.colLiquidatore.OptionsColumn.AllowEdit = false;
            this.colLiquidatore.OptionsColumn.AllowFocus = false;
            this.colLiquidatore.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colLiquidatore.OptionsColumn.AllowMove = false;
            this.colLiquidatore.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colLiquidatore.OptionsFilter.AllowAutoFilter = false;
            this.colLiquidatore.OptionsFilter.AllowFilter = false;
            this.colLiquidatore.Visible = true;
            this.colLiquidatore.VisibleIndex = 2;
            this.colLiquidatore.Width = 53;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // colDescrizioneSocio
            // 
            this.colDescrizioneSocio.Caption = "Socio";
            this.colDescrizioneSocio.FieldName = "DescrizioneSocio";
            this.colDescrizioneSocio.Name = "colDescrizioneSocio";
            this.colDescrizioneSocio.OptionsColumn.AllowEdit = false;
            this.colDescrizioneSocio.OptionsColumn.AllowFocus = false;
            this.colDescrizioneSocio.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDescrizioneSocio.OptionsColumn.AllowMove = false;
            this.colDescrizioneSocio.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDescrizioneSocio.OptionsFilter.AllowAutoFilter = false;
            this.colDescrizioneSocio.OptionsFilter.AllowFilter = false;
            this.colDescrizioneSocio.Visible = true;
            this.colDescrizioneSocio.VisibleIndex = 3;
            this.colDescrizioneSocio.Width = 174;
            // 
            // colRichiestaAntimafia
            // 
            this.colRichiestaAntimafia.AppearanceHeader.Options.UseTextOptions = true;
            this.colRichiestaAntimafia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRichiestaAntimafia.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colRichiestaAntimafia.Caption = "Antim. richiesta";
            this.colRichiestaAntimafia.ColumnEdit = this.repositoryItemCheckEdit4;
            this.colRichiestaAntimafia.FieldName = "RichiestaAntimafia";
            this.colRichiestaAntimafia.Name = "colRichiestaAntimafia";
            this.colRichiestaAntimafia.OptionsColumn.AllowEdit = false;
            this.colRichiestaAntimafia.OptionsColumn.AllowFocus = false;
            this.colRichiestaAntimafia.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colRichiestaAntimafia.OptionsColumn.AllowMove = false;
            this.colRichiestaAntimafia.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colRichiestaAntimafia.OptionsFilter.AllowAutoFilter = false;
            this.colRichiestaAntimafia.OptionsFilter.AllowFilter = false;
            this.colRichiestaAntimafia.Visible = true;
            this.colRichiestaAntimafia.VisibleIndex = 4;
            this.colRichiestaAntimafia.Width = 69;
            // 
            // repositoryItemCheckEdit4
            // 
            this.repositoryItemCheckEdit4.AutoHeight = false;
            this.repositoryItemCheckEdit4.Name = "repositoryItemCheckEdit4";
            // 
            // colRichiestaAntimafiaProdotta
            // 
            this.colRichiestaAntimafiaProdotta.AppearanceHeader.Options.UseTextOptions = true;
            this.colRichiestaAntimafiaProdotta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRichiestaAntimafiaProdotta.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colRichiestaAntimafiaProdotta.Caption = "Antim. prodotta";
            this.colRichiestaAntimafiaProdotta.ColumnEdit = this.repositoryItemCheckEdit4;
            this.colRichiestaAntimafiaProdotta.FieldName = "RichiestaAntimafiaProdotta";
            this.colRichiestaAntimafiaProdotta.Name = "colRichiestaAntimafiaProdotta";
            this.colRichiestaAntimafiaProdotta.OptionsColumn.AllowEdit = false;
            this.colRichiestaAntimafiaProdotta.OptionsColumn.AllowFocus = false;
            this.colRichiestaAntimafiaProdotta.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colRichiestaAntimafiaProdotta.OptionsColumn.AllowMove = false;
            this.colRichiestaAntimafiaProdotta.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colRichiestaAntimafiaProdotta.OptionsFilter.AllowAutoFilter = false;
            this.colRichiestaAntimafiaProdotta.OptionsFilter.AllowFilter = false;
            this.colRichiestaAntimafiaProdotta.Visible = true;
            this.colRichiestaAntimafiaProdotta.VisibleIndex = 5;
            this.colRichiestaAntimafiaProdotta.Width = 68;
            // 
            // colRichiestaAntimafiaArrivata
            // 
            this.colRichiestaAntimafiaArrivata.AppearanceHeader.Options.UseTextOptions = true;
            this.colRichiestaAntimafiaArrivata.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRichiestaAntimafiaArrivata.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colRichiestaAntimafiaArrivata.Caption = "Antim. arrivata";
            this.colRichiestaAntimafiaArrivata.ColumnEdit = this.repositoryItemCheckEdit5;
            this.colRichiestaAntimafiaArrivata.FieldName = "RichiestaAntimafiaArrivata";
            this.colRichiestaAntimafiaArrivata.Name = "colRichiestaAntimafiaArrivata";
            this.colRichiestaAntimafiaArrivata.OptionsColumn.AllowEdit = false;
            this.colRichiestaAntimafiaArrivata.OptionsColumn.AllowFocus = false;
            this.colRichiestaAntimafiaArrivata.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colRichiestaAntimafiaArrivata.OptionsColumn.AllowMove = false;
            this.colRichiestaAntimafiaArrivata.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colRichiestaAntimafiaArrivata.OptionsFilter.AllowAutoFilter = false;
            this.colRichiestaAntimafiaArrivata.OptionsFilter.AllowFilter = false;
            this.colRichiestaAntimafiaArrivata.Visible = true;
            this.colRichiestaAntimafiaArrivata.VisibleIndex = 6;
            this.colRichiestaAntimafiaArrivata.Width = 69;
            // 
            // repositoryItemCheckEdit5
            // 
            this.repositoryItemCheckEdit5.AutoHeight = false;
            this.repositoryItemCheckEdit5.Name = "repositoryItemCheckEdit5";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DisplayMember = "Descrizione";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "IdElemento";
            // 
            // repositoryItemCheckEdit3
            // 
            this.repositoryItemCheckEdit3.AutoHeight = false;
            this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 3";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemModify, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemPDF, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 3";
            // 
            // barButtonItemAdd
            // 
            this.barButtonItemAdd.Caption = "Nuovo";
            this.barButtonItemAdd.Id = 9;
            this.barButtonItemAdd.Name = "barButtonItemAdd";
            this.barButtonItemAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAdd_ItemClick);
            // 
            // barButtonItemModify
            // 
            this.barButtonItemModify.Caption = "Modifica";
            this.barButtonItemModify.Id = 11;
            this.barButtonItemModify.Name = "barButtonItemModify";
            this.barButtonItemModify.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemModify_ItemClick);
            // 
            // barButtonItemDelete
            // 
            this.barButtonItemDelete.Caption = "Cancella";
            this.barButtonItemDelete.Id = 10;
            this.barButtonItemDelete.Name = "barButtonItemDelete";
            this.barButtonItemDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDelete_ItemClick);
            // 
            // barButtonItemPDF
            // 
            this.barButtonItemPDF.Caption = "Stampa";
            this.barButtonItemPDF.Id = 15;
            this.barButtonItemPDF.Name = "barButtonItemPDF";
            this.barButtonItemPDF.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemPDF_ItemClick);
            // 
            // popupMenuCarica
            // 
            this.popupMenuCarica.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemModify),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemDelete)});
            this.popupMenuCarica.Manager = this.BarManager;
            this.popupMenuCarica.Name = "popupMenuCarica";
            // 
            // CaricaSocialeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CaricaSocialeDetail";
            this.Size = new System.Drawing.Size(606, 200);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSocialPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCariche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSocialPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipiCarica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuCarica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlSocialPosition;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSocialPosition;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceCariche;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit4;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit5;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceTipiCarica;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCarica;
        private DevExpress.XtraGrid.Columns.GridColumn colLegaleRappresentante;
        private DevExpress.XtraGrid.Columns.GridColumn colLiquidatore;
        private DevExpress.XtraGrid.Columns.GridColumn colDescrizioneSocio;
        private DevExpress.XtraGrid.Columns.GridColumn colRichiestaAntimafia;
        private DevExpress.XtraGrid.Columns.GridColumn colRichiestaAntimafiaProdotta;
        private DevExpress.XtraGrid.Columns.GridColumn colRichiestaAntimafiaArrivata;
        private DevExpress.XtraBars.BarButtonItem barButtonItemModify;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraBars.PopupMenu popupMenuCarica;
        private DevExpress.XtraBars.BarButtonItem barButtonItemPDF;
    }
}
