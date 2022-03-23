using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.Configurations;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Documentazione
{
	public partial class DocumentazioneEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
	{
        public override bool ReadOnlyControls
        {
            get
            {
                return base.ReadOnlyControls;
            }
            set
            {
                base.ReadOnlyControls = value;

                Filter();
            }
        }

        private void Filter()
        {
            if (this.ReadOnlyControls)
            {
                DropDownFilter(gridViewTipoDocumento, colAttivo, false);
            }
            else
            {
                DropDownFilter(gridViewTipoDocumento, colAttivo, true);
            }
        }

		#region Event Handlers (2) 

        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (fileDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.buttonEdit1.Text = fileDialog.FileName;
            }
        }

        private void memoEditNote_EditValueChanged(object sender, EventArgs e)
        {

        }

		#endregion Event Handlers 

		#region Instance Variables (15) 

        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceDocumentation;
        private it.dedagroup.GVC.Client.Forms.Controls.BindingSource bindingSourceDocumentationTypes;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit1;
        private it.dedagroup.GVC.Client.Forms.Controls.DateEdit dateEditBegin;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl1;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl17;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl2;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl3;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl4;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl7;
        private it.dedagroup.GVC.Client.Forms.Controls.LabelControl labelControl9;
        private OeF.Forms.Controls.MemoEdit memoEditNote;
        private it.dedagroup.GVC.Client.Forms.Controls.TextEdit textEditDocumentationTitle;
        public DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ErrorProvideDocumentation;
        private IContainer components;
        private it.dedagroup.GVC.Client.Forms.Controls.DateEdit dateEdit1;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEditTipoDocumentazione;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTipoDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colAttivo;
        private it.dedagroup.GVC.Client.Forms.Controls.TextEdit textEditProvince;

		#endregion Instance Variables 

		#region Constructors (1) 

    		public DocumentazioneEdit()
		{
			InitializeComponent();
		}

		#endregion Constructors 

		#region Public Methods (3) 

        public void BindingSourceEndInit()
        {
            this.bindingSourceDocumentation.EndEdit();
        }

        public void BindingSourceResetBindings()
        {
            this.bindingSourceDocumentation.ResetBindings(false);
        }

        public void SetBindableData(it.dedagroup.GVC.Repository.Common.FDT.DocumentazioneFDT documentazione)
        {
            this.bindingSourceDocumentationTypes.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_DOCUMENTO);
            this.bindingSourceDocumentation.DataSource = documentazione;
            

            Filter();
        }

		#endregion Public Methods 

		#region Private Methods (1) 

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelControl1 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.bindingSourceDocumentation = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.bindingSourceDocumentationTypes = new it.dedagroup.GVC.Client.Forms.Controls.BindingSource();
            this.labelControl2 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.labelControl4 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.textEditDocumentationTitle = new it.dedagroup.GVC.Client.Forms.Controls.TextEdit();
            this.dateEditBegin = new it.dedagroup.GVC.Client.Forms.Controls.DateEdit();
            this.labelControl9 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.memoEditNote = new OeF.Forms.Controls.MemoEdit();
            this.labelControl17 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.labelControl7 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.textEditProvince = new it.dedagroup.GVC.Client.Forms.Controls.TextEdit();
            this.labelControl3 = new it.dedagroup.GVC.Client.Forms.Controls.LabelControl();
            this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
            this.ErrorProvideDocumentation = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.gridLookUpEditTipoDocumentazione = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridViewTipoDocumento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAttivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateEdit1 = new it.dedagroup.GVC.Client.Forms.Controls.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDocumentation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDocumentationTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDocumentationTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBegin.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditProvince.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvideDocumentation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditTipoDocumentazione.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTipoDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(0, 5);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(0, 5);
            // 
            // PanelButtons
            // 
            this.PanelButtons.Location = new System.Drawing.Point(0, 204);
            this.PanelButtons.Size = new System.Drawing.Size(697, 38);
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.gridLookUpEditTipoDocumentazione);
            this.ScrollableContent.Controls.Add(this.buttonEdit1);
            this.ScrollableContent.Controls.Add(this.labelControl7);
            this.ScrollableContent.Controls.Add(this.textEditProvince);
            this.ScrollableContent.Controls.Add(this.memoEditNote);
            this.ScrollableContent.Controls.Add(this.labelControl3);
            this.ScrollableContent.Controls.Add(this.labelControl17);
            this.ScrollableContent.Controls.Add(this.dateEdit1);
            this.ScrollableContent.Controls.Add(this.dateEditBegin);
            this.ScrollableContent.Controls.Add(this.labelControl9);
            this.ScrollableContent.Controls.Add(this.labelControl1);
            this.ScrollableContent.Controls.Add(this.labelControl2);
            this.ScrollableContent.Controls.Add(this.labelControl4);
            this.ScrollableContent.Controls.Add(this.textEditDocumentationTitle);
            this.ScrollableContent.Size = new System.Drawing.Size(697, 242);
            this.ScrollableContent.Controls.SetChildIndex(this.PanelButtons, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.textEditDocumentationTitle, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl4, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl2, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl1, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl9, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.dateEditBegin, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.dateEdit1, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl17, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl3, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.memoEditNote, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.textEditProvince, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.labelControl7, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.buttonEdit1, 0);
            this.ScrollableContent.Controls.SetChildIndex(this.gridLookUpEditTipoDocumentazione, 0);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(151, 13);
            this.labelControl1.TabIndex = 47;
            this.labelControl1.Text = "Dati della documentazione";
            // 
            // bindingSourceDocumentation
            // 
            this.bindingSourceDocumentation.AutoCreateObjects = false;
            this.bindingSourceDocumentation.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DocumentazioneFDT);
            // 
            // bindingSourceDocumentationTypes
            // 
            this.bindingSourceDocumentationTypes.AutoCreateObjects = false;
            this.bindingSourceDocumentationTypes.DataSource = typeof(it.dedagroup.GVC.Repository.Common.FDT.DizionarioFDT);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(55, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 13);
            this.labelControl2.TabIndex = 52;
            this.labelControl2.Text = "Tipo documento";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(81, 57);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(50, 13);
            this.labelControl4.TabIndex = 51;
            this.labelControl4.Text = "Segnalibro";
            // 
            // textEditDocumentationTitle
            // 
            this.textEditDocumentationTitle.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceDocumentation, "Titolo", true));
            this.ErrorProvideDocumentation.SetErrorType(this.textEditDocumentationTitle, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.textEditDocumentationTitle.Location = new System.Drawing.Point(137, 54);
            this.textEditDocumentationTitle.Name = "textEditDocumentationTitle";
            this.textEditDocumentationTitle.Size = new System.Drawing.Size(540, 20);
            this.textEditDocumentationTitle.TabIndex = 55;
            // 
            // dateEditBegin
            // 
            this.dateEditBegin.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceDocumentation, "DataDocumento", true));
            this.dateEditBegin.EditValue = null;
            this.ErrorProvideDocumentation.SetErrorType(this.dateEditBegin, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.dateEditBegin.Location = new System.Drawing.Point(137, 80);
            this.dateEditBegin.Name = "dateEditBegin";
            this.dateEditBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditBegin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dateEditBegin.Properties.NullDate = "";
            this.dateEditBegin.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEditBegin.Size = new System.Drawing.Size(100, 20);
            this.dateEditBegin.TabIndex = 57;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(52, 83);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(79, 13);
            this.labelControl9.TabIndex = 56;
            this.labelControl9.Text = "Data documento";
            // 
            // memoEditNote
            // 
            this.memoEditNote.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceDocumentation, "Note", true));
            this.ErrorProvideDocumentation.SetErrorType(this.memoEditNote, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.memoEditNote.Location = new System.Drawing.Point(137, 132);
            this.memoEditNote.Name = "memoEditNote";
            this.memoEditNote.Properties.AcceptsReturn = false;
            this.memoEditNote.Size = new System.Drawing.Size(540, 41);
            this.memoEditNote.TabIndex = 59;
            this.memoEditNote.EditValueChanged += new System.EventHandler(this.memoEditNote_EditValueChanged);
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(108, 138);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(23, 13);
            this.labelControl17.TabIndex = 58;
            this.labelControl17.Text = "Note";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(316, 83);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(47, 13);
            this.labelControl7.TabIndex = 60;
            this.labelControl7.Text = "Protocollo";
            // 
            // textEditProvince
            // 
            this.textEditProvince.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceDocumentation, "NumeroProtocollo", true));
            this.ErrorProvideDocumentation.SetErrorType(this.textEditProvince, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.textEditProvince.Location = new System.Drawing.Point(369, 80);
            this.textEditProvince.Name = "textEditProvince";
            this.textEditProvince.Size = new System.Drawing.Size(45, 20);
            this.textEditProvince.TabIndex = 61;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(36, 109);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(95, 13);
            this.labelControl3.TabIndex = 58;
            this.labelControl3.Text = "Documento allegato";
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceDocumentation, "NomeFile", true));
            this.ErrorProvideDocumentation.SetErrorType(this.buttonEdit1, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.buttonEdit1.Location = new System.Drawing.Point(137, 106);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit1.Size = new System.Drawing.Size(540, 20);
            this.buttonEdit1.TabIndex = 62;
            this.buttonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit1_ButtonClick);
            // 
            // ErrorProvideDocumentation
            // 
            this.ErrorProvideDocumentation.ContainerControl = this;
            this.ErrorProvideDocumentation.DataSource = this.bindingSourceDocumentation;
            // 
            // gridLookUpEditTipoDocumentazione
            // 
            this.gridLookUpEditTipoDocumentazione.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceDocumentation, "IdTipoDocumentazione", true));
            this.gridLookUpEditTipoDocumentazione.EditValue = "";
            this.ErrorProvideDocumentation.SetErrorType(this.gridLookUpEditTipoDocumentazione, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            this.gridLookUpEditTipoDocumentazione.Location = new System.Drawing.Point(137, 28);
            this.gridLookUpEditTipoDocumentazione.Name = "gridLookUpEditTipoDocumentazione";
            this.gridLookUpEditTipoDocumentazione.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEditTipoDocumentazione.Properties.DataSource = this.bindingSourceDocumentationTypes;
            this.gridLookUpEditTipoDocumentazione.Properties.DisplayMember = "Descrizione";
            this.gridLookUpEditTipoDocumentazione.Properties.NullText = "";
            this.gridLookUpEditTipoDocumentazione.Properties.ValueMember = "IdElemento";
            this.gridLookUpEditTipoDocumentazione.Properties.View = this.gridViewTipoDocumento;
            this.gridLookUpEditTipoDocumentazione.Size = new System.Drawing.Size(254, 20);
            this.gridLookUpEditTipoDocumentazione.TabIndex = 63;
            // 
            // gridViewTipoDocumento
            // 
            this.gridViewTipoDocumento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colAttivo});
            this.gridViewTipoDocumento.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewTipoDocumento.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gridViewTipoDocumento.Name = "gridViewTipoDocumento";
            this.gridViewTipoDocumento.OptionsMenu.EnableColumnMenu = false;
            this.gridViewTipoDocumento.OptionsMenu.EnableFooterMenu = false;
            this.gridViewTipoDocumento.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewTipoDocumento.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewTipoDocumento.OptionsView.ShowDetailButtons = false;
            this.gridViewTipoDocumento.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewTipoDocumento.OptionsView.ShowGroupPanel = false;
            this.gridViewTipoDocumento.OptionsView.ShowIndicator = false;
            this.gridViewTipoDocumento.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Tipo documento";
            this.gridColumn1.FieldName = "Descrizione";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.OptionsColumn.AllowMove = false;
            this.gridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // colAttivo
            // 
            this.colAttivo.Caption = "Attivo";
            this.colAttivo.FieldName = "Attivo";
            this.colAttivo.Name = "colAttivo";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(420, 80);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dateEdit1.Properties.NullDate = "";
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(100, 20);
            this.dateEdit1.TabIndex = 57;
            // 
            // DocumentazioneEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "DocumentazioneEdit";
            this.Size = new System.Drawing.Size(697, 266);
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            this.ScrollableContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDocumentation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDocumentationTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDocumentationTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBegin.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditProvince.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvideDocumentation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditTipoDocumentazione.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTipoDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion Private Methods 

    }
}
