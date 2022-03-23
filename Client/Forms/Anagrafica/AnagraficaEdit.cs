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


namespace it.dedagroup.GVC.Client.Forms.Registry
{
    public partial class AnagraficaEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {
        private SoggettoFDT itemLocal = null;
        it.dedagroup.GVC.Client.Forms.Common.UserControlBase ucb = null;


        public SoggettoFDT CurrentItem
        {
            get { return itemLocal; }
        }
	

        public SoggettoFDT itemToSave
        {
            get
            {
                return itemLocal;
            }
        }
        
        #region Constructors (1)
        
        public AnagraficaEdit()
        {
            InitializeComponent();

            EnableControlAutoSize(new object[] { this, indirizzoDetail1}, indirizzoDetail1, 400);
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

        //public void SetBindableData(SoggettoFDT item)
        //{
        //    if (item == null)
        //        item = new PersonaFisicaFDT();
        //    SetBindableData(item);
        //}

        public void SetBindableData(SoggettoFDT item)
        {
            if (item == null)
            {
                item = new PersonaFisicaFDT();
                item.IdTipoSoggetto = 1;
            }

            if (item != null)
            {
                if (item.IdTipoSoggetto <= 0)
                {
                    item.IdTipoSoggetto = 1;
                }
            }
           
            itemLocal = item;

            this.bindingSourceBaseAddressTypes.DataSource =
                 GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_INDIRIZZO);
            this.bindingSourceTipoSoggetto.DataSource =
                GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_SOGGETTO);

            this.bindingSourceSoggetto.DataSource = itemLocal;

            if (itemLocal != null)
            {
                indirizzoDetail1.SetBindableData(itemLocal);
            }
        }


        #endregion Public Methods 

       
        private DialogResult OpenForEdit(IndirizzoFDT item)
        {
            if (item != null)
            {
                IndirizzoEdit page = CreatePage<IndirizzoEdit>();
                if (page != null)
                {
                    page.SetFormTitle("Gestione indirizzo");
                    page.SetBindableData(item);
                    return page.BaseForm.ShowDialog(this, this.ReadOnlyControls);
                }
            }

            return DialogResult.None;
        }

        private void lookUpEditTipoSoggetto_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEditTipoSoggetto.EditValue != null)
            {
                int subjectType = -1;
                if (Int32.TryParse(lookUpEditTipoSoggetto.EditValue.ToString(), out subjectType))
                {
                    UpdateUserControls(subjectType);
                }
            }
        }

        private void UpdateUserControls(int subjectType)
        {
            this.ScrollableContent.Hide();
            this.panelData.Hide();
            this.indirizzoDetail1.Hide();

            ucb = null;
            switch (subjectType)
            {
                case 1:
                    ucb = new PersonaFisicaEdit();
                    if (!(itemLocal is PersonaFisicaFDT)) 
                        itemLocal = new PersonaFisicaFDT();
                    ((PersonaFisicaEdit)ucb).SetBindableData((PersonaFisicaFDT)itemLocal);
                    itemLocal.IdTipoSoggetto = 1;
                    itemLocal.PersonaFisica = true;
                    break;

                default:
                    ucb = new PersonaGiuridicaEdit();
                    if (!(itemLocal is PersonaGiuridicaFDT)) 
                        itemLocal = new PersonaGiuridicaFDT();
                    ((PersonaGiuridicaEdit)ucb).SetBindableData((PersonaGiuridicaFDT)itemLocal);
                    itemLocal.IdTipoSoggetto = subjectType;
                    itemLocal.PersonaFisica = false;
                    break;
            }
            this.panelData.Controls.Clear();

            int width = indirizzoDetail1.Width;
            int height = 20 + PanelButtons.Height + panelRegistryType.Height + indirizzoDetail1.Height;

            if (ucb != null)
            {
                if (width < ucb.Width)
                    width = ucb.Width;
                height += ucb.Height;

                ucb.ReadOnlyControls = this.ReadOnlyControls;

                this.panelData.Size = new Size(ucb.Width, ucb.Height);
                ucb.Dock = DockStyle.Fill;
                this.panelData.Controls.Add(ucb);


                ucb.BringToFront();
            }

            this.MinimumSize = new Size(width, height);
            this.MaximumSize = new Size(width, height);
            this.Size = new Size(width, height);
           

            this.indirizzoDetail1.Show();
            this.panelData.Show();
            this.ScrollableContent.Show();
           

            this.ResumeLayout();

            this.bindingSourceSoggetto.DataSource = itemLocal;
        }


        internal void SetBindableData(int idSoggetto)
        {
            this.itemLocal = GetSoggettoById(idSoggetto);
            SetBindableData(itemLocal);
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


       internal Boolean HasErrors()
       {
           int subjectType = -1;
           if (itemLocal != null)
           {
               subjectType = itemLocal.IdTipoSoggetto;
           }
           if (subjectType > 0 && ucb != null)
           {
               switch (subjectType)
               {
                   case 1:
                       return ((PersonaFisicaEdit)ucb).HasErrors;
                   default:
                       return ((PersonaGiuridicaEdit)ucb).HasErrors;
               }
           }
           return false;
       }

        private void MyClose()
        {
            Form f = this.FindForm();
            if (f != null)
                f.Close();
        }
    }
}
