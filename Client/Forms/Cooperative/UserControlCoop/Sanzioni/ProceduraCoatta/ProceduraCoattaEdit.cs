using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.Configurations;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Sanzioni.ProceduraCoatta
{
    public partial class ProceduraCoattaEdit : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {
        public event EventHandler NuovoProcedimento;

        public override bool ReadOnlyControls
        {
            get
            {
                return base.ReadOnlyControls;
            }
            set
            {
                base.ReadOnlyControls = value;

                simpleButtonNewProcess1.Enabled = !value;

                Filter();
            }
        }

        #region Instance Variables (1)

        private ProceduraCoattaFDT localItem;

        #endregion Instance Variables

        #region Constructors (1)

        public ProceduraCoattaEdit()
        {
            InitializeComponent();
        }

		#endregion Constructors 

		#region Public Methods (3) 

        public void BindingSourceEndInit()
        {
            this.bindingSourceForcedProcedures.EndEdit();
            this.bindingSourceExtensions.EndEdit();
        }

        public void BindingSourceResetBindings()
        {
            this.bindingSourceForcedProcedures.ResetBindings(false);
            this.bindingSourceExtensions.ResetBindings(false);
        }

        public void SetBindableData(ProceduraCoattaFDT item, DizionarioFDT[] tipiProceduraCoatta)
        {
            localItem = item;
            this.bindingSourceForcedProcedures.DataSource = localItem;
            this.bindingSourceProceduresTypes.DataSource = tipiProceduraCoatta;
            if (localItem.Proroghe == null)
                localItem.Proroghe = new ProrogaFDT[] { };
            this.bindingSourceExtensions.DataSource = localItem.Proroghe;

            Filter();
        }

		#endregion Public Methods 

        #region Private Methods (6)

        private void Filter()
        {
            if (this.ReadOnlyControls)
            {
                DropDownFilter(gridViewTipoProcedura, colAttivo, false);
            }
            else
            {
                DropDownFilter(gridViewTipoProcedura, colAttivo, true);
            }
        }

        private void AddItem()
        {
            ProrogaFDT item = new ProrogaFDT();

            if (OpenForEdit(item) == DialogResult.OK)
            {
                item.Status = ObjectStatus.ToInsert;
                item.EndEdit();

                gridViewExtensions.BeginDataUpdate();
                localItem.AddProroga(item);
                this.bindingSourceExtensions.DataSource = localItem.Proroghe;
                gridViewExtensions.EndDataUpdate();
            }
            else
            {
                item.CancelEdit();
            }
        }

        private void ModifyItem()
        {
            ProrogaFDT item = GetCurrentItem();
            item.BeginEdit();

            if (OpenForEdit(item) == DialogResult.OK)
            {
                if (item.Status != ObjectStatus.ToInsert)
                    item.Status = ObjectStatus.ToUpdate;

                item.EndEdit();
            }
            else
            {
                item.CancelEdit();
            }

            gridViewExtensions.RefreshData();
        }

        private void DeleteItem()
        {
            ProrogaFDT item = GetCurrentItem();
            if (item != null)
            {
                if (ShowConfirmMessage("GVC", "Confermi la cancellazione dell'elemento selezionato?", string.Empty) == DialogResult.Yes)
                {
                    if (item.Status == ObjectStatus.ToInsert)
                    {
                        localItem.RemoveProroga(item);
                        this.bindingSourceExtensions.DataSource = localItem.Proroghe;
                    }
                    else
                    {
                        gridViewExtensions.BeginDataUpdate();                    
                        item.BeginEdit();
                        item.Status = ObjectStatus.ToCancel;
                        item.EndEdit();
                        gridViewExtensions.EndDataUpdate();
                    }
                }
            }
        }

        private ProrogaFDT GetCurrentItem()
        {
            ProrogaFDT toReturn = null;

            if (this.bindingSourceExtensions.Current != null)
            {
                toReturn = this.bindingSourceExtensions.Current as ProrogaFDT;
            }

            return toReturn;
        }

        private DialogResult OpenForEdit(ProrogaFDT item)
        {
            if (item != null)
            {
                ProrogaEdit page = CreatePage<ProrogaEdit>();
                if (page != null)
                {
                    page.SetFormTitle("Gestione proroghe");
                    page.SetBindableData(item);
                    return page.BaseForm.ShowDialog(this, this.ReadOnlyControls);
                }
                else
                    return DialogResult.None;
            }
            return DialogResult.None;
        }

        #endregion Private Methods 

        #region Event Handlers (3)

        private void btnAddSupplementaryAct_Click(object sender, EventArgs e)
        {
            //List<ProrogaFDT> items = null;
            //if (this.bindingSourceExtensions.DataSource != null &&
            //    this.bindingSourceExtensions.DataSource.GetType() == typeof(ProrogaFDT[]) &&
            //    this.bindingSourceExtensions.DataSource != null)
            //{
            //    items = new List<ProrogaFDT>(this.bindingSourceExtensions.DataSource as ProrogaFDT[]);
            //}
            //if (items == null)
            //    items = new List<ProrogaFDT>();
            //ProrogaFDT item = new ProrogaFDT();
            //if (OpenForEdit(item) == DialogResult.OK)
            //{
            //    items.Add(item);
            //}
            //this.bindingSourceExtensions.DataSource = items.ToArray();
            AddItem();
        }

        private void btnRemoveSupplementaryAct_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }

        private void gridControlExtensions_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifyItem();
        }

        void simpleButtonNewProcess1_Click(object sender, EventArgs e)
        {
            //OpenNewProcess();
            EventHandler temp = NuovoProcedimento;
            if (temp != null)
                NuovoProcedimento(null, new EventArgs());
        }     
                
        #endregion Event Handlers
    }
}
