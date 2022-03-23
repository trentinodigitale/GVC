using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Client.Forms.Registry;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using it.dedagroup.GVC.Repository.Common.Services;
using OeF.Utility;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Statuto.Assemblea
{
    public partial class AssembleaEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {
        #region Instance Variables (1)

        private DeliberaAssembleaFDT itemLocal = null;

        public event EventHandler NuovoProcedimento;

        #endregion Instance Variables
        
        #region Event Handlers

        private void btnAddSupplementaryAct_Click(object sender, EventArgs e)
        {
            AddAttoIntegrativo();

            //this.simpleButtonNewProcess1.Click += new EventHandler(simpleButtonNewProcess1_Click);
        }

        private void gridControlSupplementaryAct_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifyAttoIntegrativo();
        }

        void simpleButtonNewProcess1_Click(object sender, EventArgs e)
        {
            //OpenNewProcess();
            EventHandler temp = NuovoProcedimento;
            if (temp != null)
                NuovoProcedimento(null, new EventArgs());
        }

        private void simpleButtonNotarySearch_Click(object sender, EventArgs e)
        {
            SoggettoFDT item = new PersonaFisicaFDT();

            Expression expression = (FieldName)SearchParameters.ID_TIPO_SOGGETTO == TipiSoggettiSpecifici.Notaio;
            if (OpenSubjectSearch(ref item, expression))
            {
                if (itemLocal != null)
                {
                    itemLocal.Notaio = item as PersonaFisicaFDT;
                    itemLocal.IdNotaio = item.IdSoggetto;
                    this.bindingSourceBaseAssemblea.ResetBindings(false);
                }
                //else
                //{
                //    this.memoEdit1.Text = ((PersonaFisicaFDT)item).DescrizioneBreve;
            }
        }

        private void btnRemoveSupplementaryAct_Click(object sender, EventArgs e)
        {
            DeleteAttoIntegrativo();
        }

        private void btnViewSubject_Click(object sender, EventArgs e)
        {
            SoggettoFDT sj = null;
            if (this.itemLocal != null)
            {
                if (itemLocal.Notaio != null)
                {
                    sj = itemLocal.Notaio;
                }
                else
                {
                    if (itemLocal.IdNotaio > 0)
                    {

                        SoggettoFDT ss =
                        GVCSystemEngine.InvokeService<ICooperatives, SoggettoFDT>
                            (delegate()
                            {
                                return GVCSystemEngine.Cooperatives.GetSoggettoById(itemLocal.IdNotaio);
                            },
                         true);

                        if (ss is PersonaFisicaFDT)
                        {
                            itemLocal.Notaio = ss as PersonaFisicaFDT;

                            if (itemLocal.Notaio != null)
                            {
                                sj = itemLocal.Notaio;
                            }
                        }
                    }
                }
            }
            if (sj != null)
            {
                OpenViewSubject(sj);
            }
        }

        private void btnRemoveSubject_Click(object sender, EventArgs e)
        {
            if (itemLocal != null)
            {
                itemLocal.BeginEdit();

                itemLocal.Notaio = null;
                itemLocal.IdNotaio = -1;

                itemLocal.EndEdit();

                this.bindingSourceBaseAssemblea.ResetBindings(false);
            }
        }

		#endregion Event Handlers 

		#region Constructors (1) 

        public AssembleaEdit()
        {
            InitializeComponent();

            SetImages();
        }

		#endregion Constructors 

		#region Public Methods

        public void SetBindableData(DeliberaAssembleaFDT item)
        {
            DizionarioFDT[] tipiAssemblea = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_ASSEMBLEA);
            DizionarioFDT[] codiciAttiIntegrativi = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_ATTI);
            
            this.bindingSourceBaseTipoAssemblea.DataSource = tipiAssemblea;
            this.bindingSourceBaseTipoAttoIntegrativo.DataSource = codiciAttiIntegrativi;

            if (item != null)
            {
                this.bindingSourceBaseAssemblea.DataSource = item;
                itemLocal = item;

                this.bindingSourceBaseAttiIntegrativi.DataSource = itemLocal.AttiIntegrativi;
            }

            Filter();
        }

        private void Filter()
        {
            if (this.ReadOnlyControls)
            {
                DropDownFilter(gridViewTipoAssemblea, colAttivo, false);
            }
            else
            {
                DropDownFilter(gridViewTipoAssemblea, colAttivo, true);
            }
        }

        public override bool ReadOnlyControls
        {
            get
            {
                return base.ReadOnlyControls;
            }
            set
            {
                base.ReadOnlyControls = value;
                textEdit1.Properties.ReadOnly = true;
                this.btnViewSubject.Enabled = true;
                
                simpleButtonNewProcess1.Enabled = !value;

                Filter();
            }
        }

		#endregion Public Methods 

		#region Private Methods

        private DialogResult OpenForEdit(AttoIntegrativoFDT item)
        {
            AttoIntegrativoEdit page = CreatePage<AttoIntegrativoEdit>();
            if (page != null)
            {
                page.SetFormTitle("Gestione dati atto integrativo");
                page.SetBindableData(item);

                DialogResult dr = DialogResult.OK;
                while (dr == DialogResult.OK)
                {
                    page.ErrorProviderAtto.ClearErrors();

                    dr = page.BaseForm.ShowDialog(this, this.ReadOnlyControls);

                    if (dr == DialogResult.OK)
                    {
                        if (!page.ErrorProviderAtto.HasErrors)
                            break;
                    }
                }
                return dr;
            }
            else
                return DialogResult.None;
        }

        private void SetImages()
        {
            this.simpleButtonNotarySearch.Image = GVCResourcesUtility.Get_16x16(GVCResources.Businessman_Find_24x24);
            this.btnAddSupplementaryAct.Image = GVCResourcesUtility.Get_16x16(GVCResources.Add_24x24);
            this.btnRemoveSupplementaryAct.Image = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
            this.btnViewSubject.Image = GVCResourcesUtility.Get_16x16(GVCResources.Businessman_24x24);
            this.btnRemoveSubject.Image = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
        }

        private void AddAttoIntegrativo()
        {
            AttoIntegrativoFDT item = new AttoIntegrativoFDT();

            if (OpenForEdit(item) == DialogResult.OK)
            {
                AttoIntegrativoFDT newItem = SaveAttoIntegrativo(item, false, false);
                if (newItem != null)
                {
                    this.gridViewAttoIntegrativo.BeginDataUpdate();
                    itemLocal.AddAttoIntegrativo(newItem);

                    this.bindingSourceBaseAttiIntegrativi.DataSource = itemLocal.AttiIntegrativi;
                    this.gridViewAttoIntegrativo.EndDataUpdate();
                    //gridViewAttoIntegrativo.RefreshData();
                }
                else
                {
                    ShowProblemsMessage();
                }
            }
        }

        private AttoIntegrativoFDT SaveAttoIntegrativo(AttoIntegrativoFDT item, Boolean isAnUpdate, Boolean onDB)
        {
            AttoIntegrativoFDT toReturn = null;

            if (item != null)
            {
                if (onDB)
                {
                    // chiamata al servizio
                }
                else
                {
                    if (isAnUpdate)
                        item.Status = ObjectStatus.ToUpdate;
                    else
                        item.Status = ObjectStatus.ToInsert;

                    itemLocal.Status = ObjectStatus.ToUpdate;
                    toReturn = item;
                }
            }

            return toReturn;
        }

        private void ModifyAttoIntegrativo()
        {
            AttoIntegrativoFDT item = GetCurrentItem();

            if (item != null)
            {
                if (OpenForEdit(item) == DialogResult.OK)
                {
                    AttoIntegrativoFDT newItem = SaveAttoIntegrativo(item, true, false);
                    if (newItem != null)
                    {
                        this.bindingSourceBaseAttiIntegrativi.EndEdit();
                        gridViewAttoIntegrativo.RefreshData();
                    }
                    else
                    {
                        this.bindingSourceBaseAttiIntegrativi.CancelEdit();
                        ShowProblemsMessage();
                    }
                }
                else
                {
                    this.bindingSourceBaseAttiIntegrativi.CancelEdit();
                }
            }
        }

        private AttoIntegrativoFDT GetCurrentItem()
        {
            AttoIntegrativoFDT toReturn = null;
            if (this.bindingSourceBaseAttiIntegrativi.Current != null)
                toReturn = this.bindingSourceBaseAttiIntegrativi.Current as AttoIntegrativoFDT;
            return toReturn;
        }

        private void DeleteAttoIntegrativo()
        {
            AttoIntegrativoFDT item = GetCurrentItem();

            if (item != null)
            {
                if (ShowConfirmMessage("Cancellazione", "Confermi la cancellazione dell'elemento selezionato?", string.Empty) == DialogResult.Yes)
                {
                    //item.Status = ObjectStatus.ToCancel;
                    //this.bindingSourceBaseAttiIntegrativi.EndEdit();
                    //gridViewAttoIntegrativo.RefreshData();
                    if (item.IdAttoIntegrativo > 0)
                    {
                        item.Status = ObjectStatus.ToCancel;
                    }
                    else
                    {
                        AttoIntegrativoFDT[] listActual = this.bindingSourceBaseAttiIntegrativi.DataSource as AttoIntegrativoFDT[];

                        if (listActual != null)
                        {
                            List<AttoIntegrativoFDT> lTemp = new List<AttoIntegrativoFDT>();
                            foreach (AttoIntegrativoFDT ind in listActual)
                            {
                                if (ind != item)
                                {
                                    lTemp.Add(ind);
                                }
                            }
                            if (itemLocal != null)
                            {
                                itemLocal.AttiIntegrativi = lTemp.ToArray();
                                this.bindingSourceBaseAttiIntegrativi.DataSource = itemLocal.AttiIntegrativi;
                            }
                        }
                    }

                    gridViewAttoIntegrativo.RefreshData();
                }
            }
        }

        private void OpenViewSubject(SoggettoFDT subject)
        {
            it.dedagroup.GVC.Client.Forms.Registry.AnagraficaEdit page =
                CreatePage<it.dedagroup.GVC.Client.Forms.Registry.AnagraficaEdit>();

            if (page != null)
            {
                page.SetBindableData(subject);
                page.SetFormTitle("Dettagli soggetto");
                page.BaseForm.ShowDialog(this, true);
            }
        }

		#endregion Private Methods 
    }
}
