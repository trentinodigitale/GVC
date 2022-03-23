using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Data.Indirizzo;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.Services;
using it.dedagroup.GVC.Repository.Common.Converters;
using it.dedagroup.GVC.Repository.Common;
using OeF.Utility;


namespace it.dedagroup.GVC.Client.Forms.Registry
{
    public partial class RicercaSoggetto : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {
        private SoggettoPerVisualizzazioneFDT selectedSubject = null;
        private Expression query = null;
        private Expression customExpression = null;

        #region Constructors (1)

        public RicercaSoggetto()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Public Methods (3)

        public void BindingSourceEndInit()
        {
            this.bindingSourceSoggetto.EndEdit();
        }

        public void BindingSourceResetBindings()
        {
            this.bindingSourceSoggetto.ResetBindings(false);
        }

        public void SetBindableData(SoggettoFDT item, Expression expression)
        {
            if (expression != null)
                customExpression = expression;

            this.bindingSourceTipoSoggetto.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_SOGGETTO);

            if (item != null)
                this.Denominazione.Text = item.Note;
        }

        #endregion Public Methods 

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                SearchSubject();
                return true;
            }
            else
            {
                return base.ProcessDialogKey(keyData);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchSubject();
        }

        private void SearchSubject()
        {
            this.bindingSourceSoggetto.DataSource = null;

            if (DefineParameters())
            {
                SoggettoPerVisualizzazioneFDT[] resVis =
                    GVCSystemEngine.InvokeService<ICooperatives, SoggettoPerVisualizzazioneFDT[]>
                (delegate
                {
                    return GVCSystemEngine.Cooperatives.GetSoggettoBySearch(query);
                },
                true);

                this.bindingSourceSoggetto.DataSource = resVis;

                if (resVis != null && resVis.Length > 0)
                {
                    gridViewSoggetti.SelectRow(0);
                    gridViewSoggetti.FocusedRowHandle = 0;
                    SoggettoPerVisualizzazioneFDT selected = gridViewSoggetti.GetRow(0) as SoggettoPerVisualizzazioneFDT;
                    //selectedSubject = resVis[0];
                    selectedSubject = selected;
                }
            }
            else
            {
                ShowInformationMessage("Imposta almeno un parametro di ricerca", string.Empty);
            }
        }

        private Boolean DefineParameters()
        {
            query = null;

            if (customExpression != null)
                query &= customExpression;

            //int subjectType = -1;
            //if (lookUpEditSubjectType.EditValue != null)
            //{
            //    if (Int32.TryParse(lookUpEditSubjectType.EditValue.ToString(), out subjectType))
            //    {
            //        if (subjectType > 0)
            //        {
            //            query &= (FieldName)SearchParameters.ID_TIPO_SOGGETTO == subjectType;
            //        }
            //    }
            //}

            if (!Denominazione.Text.Equals(string.Empty))
            {
                String desc = GVCSystemEngine.RemoveDiacritics(Denominazione.Text);

                Expression exTemp = (FieldName)SearchParameters.NOME % desc |
                                (FieldName)SearchParameters.COGNOME % desc |
                                (FieldName)SearchParameters.DENOMINAZIONE % desc;
                query &= exTemp;
            }

            if (!CodiceFiscale.Text.Equals(String.Empty))
            {
                query &= (FieldName)SearchParameters.CODICE_FISCALE % CodiceFiscale.Text;
            }

            if (query.ToString().Equals(string.Empty))
                return false;
            return true;
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            AddSubject();
        }

        private void AddSubject()
        {
            SoggettoFDT item = null;
            if (OpenForEdit(ref item, false) == DialogResult.OK)
            {
                SoggettoPerVisualizzazioneFDT spv = new SoggettoPerVisualizzazioneFDT();
                spv.Soggetto = item;
                this.selectedSubject = spv;

                
                Form f = this.FindForm();
                if (f != null)
                {
                    f.DialogResult = DialogResult.OK;
                    f.Close();
                }
            }
        }

        private DialogResult OpenForEdit(ref SoggettoFDT item, Boolean isReadOnly)
        {
            DialogResult dr = DialogResult.OK;

            AnagraficaEdit page = CreatePage<AnagraficaEdit>();
            if (page != null)
            {
                page.SetFormTitle("Inserisci soggetto");
                page.SetBindableData(item);

                while (dr == DialogResult.OK)
                {
                    dr = page.BaseForm.ShowDialog(this, false);

                    if (dr == DialogResult.Cancel)
                        break;

                    if (!page.HasErrors())
                        break;

                }

                if (dr == DialogResult.OK)
                {
                    item = page.CurrentItem;
                }
            }

            return dr;
        }

        private DialogResult OpenForEdit(SoggettoFDT item, Boolean isReadOnly)
        {
            return OpenForEdit(ref item, isReadOnly);
        }

        internal SoggettoPerVisualizzazioneFDT SelectedSubject
        {
            get
            {
                return selectedSubject;
            }
        }

        private void bindingSourceSoggetto_CurrentItemChanged(object sender, EventArgs e)
        {
            HandleCurrentItemChanged();
        }

        private void HandleCurrentItemChanged()
        {
            selectedSubject = this.bindingSourceSoggetto.Current as SoggettoPerVisualizzazioneFDT;
        }

        private SoggettoFDT GetSoggettoById(int idSoggetto)
        {
            SoggettoFDT toReturn = null;

            toReturn = GVCSystemEngine.InvokeService<ICooperatives, SoggettoFDT>
                              (delegate()
                                {
                                    return 
                                        GVCSystemEngine.Cooperatives.
                                            GetSoggettoById(idSoggetto);
                                },
                           true);

            return toReturn;
        }

        private void gridControlSoggetti_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SoggettoPerVisualizzazioneFDT item = GetCurrentItem();
            if (item != null)
            {
                if (item != null)
                {
                    if (item.Soggetto == null)
                    {
                        item.Soggetto = GetSoggettoById(item.IdSoggetto);
                    }
                    OpenForEdit(item.Soggetto, true);
                }
            }
        }

        private SoggettoPerVisualizzazioneFDT GetCurrentItem()
        {
            SoggettoPerVisualizzazioneFDT toReturn = null;
            if (this.bindingSourceSoggetto.Current != null)
                toReturn = this.bindingSourceSoggetto.Current as SoggettoPerVisualizzazioneFDT;
            return toReturn;
        }

        private void RicercaSoggetto_Shown(object sender, EventArgs e)
        {
            if ((customExpression != null &&
                customExpression.ToString().Contains(SearchParameters.ASSOCIAZIONE)) ||
                !Denominazione.Text.Equals(string.Empty))
                SearchSubject();

            Denominazione.Focus();
        }
    }
}
