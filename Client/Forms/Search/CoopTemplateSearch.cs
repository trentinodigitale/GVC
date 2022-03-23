using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Client.Forms.Common;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Client.Forms.Cooperative;
using OeF.Utility;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.Services;

namespace it.dedagroup.GVC.Client.Forms.Search
{
    public partial class CoopTemplateSearch : UserControlBase
    {
        #region Private properties

        private Expression query = null;

        private Boolean _notToOpen;

        public Boolean NotToOpen
        {
            get { return _notToOpen; }
            set { _notToOpen = value; }
        }

        

        public CooperativaFDT SelectedItem
        {
            get
            {
                CooperativaFDT c = new CooperativaFDT();

                SoggettoPerVisualizzazioneFDT sV = GetCurrentItem();
                if (sV != null)
                {
                    c.IdSoggetto = sV.IdSoggetto;
                    c.Denominazione = sV.Nominativo;
                    c.RegistroCooperativa = new RegistroCooperativaFDT();
                    c.RegistroCooperativa.NumeroREA = sV.NumeroREA;
                    c.RegistroCooperativa.IdRegistro = sV.CodiceCooperativa;
                }

                return c;
            }
        }
	

        #endregion Private properties

        #region Costruttore

        public CoopTemplateSearch()
        {
            InitializeComponent();

            if (!DesignMode)
            {
                EnableControlAutoSize(new object[] { this, gridControlSoggetto }, gridControlSoggetto, 250);

                this.ParentChanged += new EventHandler(SearchCoopTemplate_ParentChanged);

                Init();
            }

            this.ConfirmCancel = false;
        }

        #endregion Costruttore

        #region Events

        private void CoopTemplateSearch_Shown(object sender, EventArgs e)
        {
            CodiceCooperativa.Focus();
        }

        void SearchCoopTemplate_ParentChanged(object sender, EventArgs e)
        {
            if (this.ParentForm != null)
            {
                this.ParentForm.FormClosing += new FormClosingEventHandler(ParentForm_FormClosing);
            }
        }

        void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!NotToOpen)
            {
                if (e.CloseReason != CloseReason.ApplicationExitCall &&
                    e.CloseReason != CloseReason.WindowsShutDown &&
                    e.CloseReason != CloseReason.MdiFormClosing)
                {
                    e.Cancel = true;
                }
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                Search();
                return true;
            }
            else
            {
                return base.ProcessDialogKey(keyData);
            }
        }

        void page_RequestSearch(object sender, EventArgs e)
        {
            try
            {
                this.FindForm().Activate();
            }
            catch
            {

            }
        }

        private void SearchCoopTemplate_Load(object sender, EventArgs e)
        {
            SetFormTitle("Ricerca cooperative");
        }

        #endregion Events

        private void Init()
        {
            this.bindingSourceBaseTipoSoggetto.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_SOGGETTO);
        }

        private void OpenForEdit(SoggettoPerVisualizzazioneFDT item)
        {
            if (item != null)
            {
                if (!UserControlHelp.IsTheSubjectAlreadyOpen(this, item.IdSoggetto))
                {
                    CooperativeEdit1 page = null;
                    BaseForm baseForm = null;
                    CreatePage<Cooperative.CooperativeEdit1>(this, PageActions.ShowMdiChild, out page, out baseForm);
                    if (page != null)
                    {
                        page.SetBindableData(item.IdSoggetto);
                        //page.RequestSearch += new EventHandler(page_RequestSearch);
                    }
                }
                else
                {
                    ShowInformationMessage("Cooperativa già aperta a video", string.Empty);
                }
            }
        }

        private SoggettoPerVisualizzazioneFDT GetCurrentItem()
        {
            SoggettoPerVisualizzazioneFDT toReturn = null;
            if (this.bindingSourceBaseResults.Current != null)
                 toReturn = this.bindingSourceBaseResults.Current as SoggettoPerVisualizzazioneFDT;
            return toReturn;
        }

        private bool DefineParameters()
        {
            query = null;
            
            query &= (((FieldName)SearchParameters.ID_TIPO_SOGGETTO == 99 |
                (FieldName)SearchParameters.ID_TIPO_SOGGETTO == 2)) &
                new Expression((FieldName)SearchParameters.CODICE_COOPERATIVA, Operators.IsNot, DBNull.Value);

            if (!Denominazione.Text.Equals(string.Empty))
            {
                String desc = GVCSystemEngine.RemoveDiacritics(Denominazione.Text);
                query &= ((FieldName)SearchParameters.NOME % desc |
                                   (FieldName)SearchParameters.DENOMINAZIONE % desc);
            }

            if (!CodiceFiscale.Text.Equals(String.Empty))
            {
                query &= (FieldName)SearchParameters.CODICE_FISCALE % CodiceFiscale.Text;
            }

            if (!CodiceCooperativa.Text.Equals(String.Empty))
            {
                int codice = -1;
                if (Int32.TryParse(CodiceCooperativa.Text, out codice))
                {
                    if (codice > 0)
                        query &= (FieldName)SearchParameters.CODICE_COOPERATIVA == codice;
                }
            }

            if (!NumeroREA.Text.Equals(String.Empty))
            {
                int numeroRea = -1;
                if (Int32.TryParse(NumeroREA.Text, out numeroRea))
                {
                    if (numeroRea > 0)
                        query &= (FieldName)SearchParameters.NUMERO_REA == NumeroREA.Text;
                }
            }

            if (query.ToString().Equals(string.Empty))
                return false;
            return true;
        }

        public int Search()
        {
            this.lblResults.Text = "0";
            this.bindingSourceBaseResults.DataSource = null;

            if (DefineParameters())
            {
                SoggettoPerVisualizzazioneFDT[] lTemp = GVCSystemEngine.InvokeService<ICooperatives, SoggettoPerVisualizzazioneFDT[]>
                    (delegate()
                    {
                        return GVCSystemEngine.Cooperatives.GetListCooperativeBySearch(query);
                    },
                    true);

                if (lTemp != null)
                {
                    this.lblResults.Text = lTemp.Length.ToString();

                    this.bindingSourceBaseResults.DataSource = lTemp;

                    if (!NotToOpen)
                    {
                        if (lTemp.Length == 1)
                        {
                            OpenForEdit(lTemp[0]);
                        }
                    }
                    return lTemp.Length;
                }
            }
            return 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void gridControlSoggetto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenCooperative();
        }

        private void OpenCooperative()
        {
            if (!NotToOpen)
            {
                SoggettoPerVisualizzazioneFDT item = GetCurrentItem();
                if (item != null)
                {
                    OpenForEdit(item);
                }
            }
        }

        public void SetCode(String code) 
        {
            this.CodiceCooperativa.Text = code;
        }

        public void SetReaNr(String reaNr)
        {
            this.NumeroREA.Text = reaNr;
        }

        private void barButtonItemExportResults_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dlg;
            
            SoggettoPerVisualizzazioneFDT[] results = this.bindingSourceBaseResults.DataSource as SoggettoPerVisualizzazioneFDT[];

            if ((results != null) && (results.Length > 0))
            {
                dlg = new SaveFileDialog();
                dlg.Filter = "xml files (*.xml)|*.xml";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (dlg.FileName.ToUpper().IndexOf(".xml".ToUpper()) < 0)
                    {
                        dlg.FileName = dlg.FileName + ".xml";
                    }

                    ExportResults(dlg.FileName, results);
                }
            }
        }

        private void ExportResults(string filepath, SoggettoPerVisualizzazioneFDT[] results)
        {
            int[] idToExport;
           
            if ((results != null) && (results.Length > 0))
            {
                idToExport = new int[results.Length];

                for (int i = 0; i < results.Length; i++)
                {
                    idToExport[i] = results[i].IdSoggetto;
                }

                DataSet dsExport = GVCSystemEngine.InvokeService<ICooperatives, DataSet>
                (delegate()
                {
                    return GVCSystemEngine.Cooperatives.GetCooperativeDaEsportare(idToExport);
                },
                true);

                dsExport.WriteXml(filepath, XmlWriteMode.DiffGram);
            }
        }

        private void ResetParameters()
        {
            NumeroREA.Text = String.Empty;
            Denominazione.Text = String.Empty;
            CodiceCooperativa.Text = String.Empty;
            CodiceFiscale.Text = String.Empty;
        }

        private void barButtonItemAzzera_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ResetParameters();
        }
    }
}
