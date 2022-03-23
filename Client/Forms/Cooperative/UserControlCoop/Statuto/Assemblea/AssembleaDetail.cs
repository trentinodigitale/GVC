using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.Services;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Statuto.Assemblea
{
    public partial class AssembleaDetail : it.dedagroup.GVC.Client.Forms.Common.UserControlSplitContainer
    {
        #region Instance Variables (2)

        private CooperativaFDT itemLocal = null;
        
        public event EventHandler ModificaStatutaria;
        public event EventHandler NuovoProcedimento;

        #endregion Instance Variables 

		#region Event Handlers (6) 

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddAssemblea();
        }
       
        private void gridControlMeeting_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifyAssemblea();
        }

        private void bindingSourceBaseMeeting_CurrentChanged(object sender, EventArgs e)
        {
            HandleCurrentItemChanged();
        }

        private void barButtonItemModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ModifyAssemblea();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteAssemblea();
        }

        private void gridViewMeeting_ShowGridMenu(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs e)
        {
            DeliberaAssembleaFDT item = GetCurrentItem();
            if (item != null)
            {
                GridView view = sender as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
                if (hitInfo.InRow)
                {
                    view.FocusedRowHandle = hitInfo.RowHandle;
                    popupMenuAssemblea.ShowPopup(BarManager,
                            gridControlMeeting.PointToScreen(e.Point));
                }
            }
        }

        private void barButtonItemViewStorico_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadStorico();
        }

		#endregion Event Handlers 

		#region Constructors (2) 

        public AssembleaDetail()
        {
            InitializeComponent();

            EnableControlAutoSize(new object[] { this }, xtraTabControl1, 350);

            modificaStatutariaDetail1.ModificaStatutaria += new EventHandler(modificaStatutariaDetail1_ModificaStatutaria);
            
            SetImages();
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

                if (this.barButtonItemViewStorico != null)
                    this.barButtonItemViewStorico.Enabled = true;
            }
        }

		#endregion Constructors 

		#region Public Methods (1) 

        public void SetBindableData(CooperativaFDT item)
        {
            itemLocal = item;

            if (item != null && item.RegistroCooperativa != null)
            {
                this.bindingSourceBaseMeeting.DataSource = item.RegistroCooperativa.Assemblee;

                this.documentazioneFileSystemDetail1.SetBindableData(item, new int[] { 10 });  
            }

            this.bindingSourceBaseMeetingType.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_ASSEMBLEA);
        }

		#endregion Public Methods 

		#region Private Methods

        private void modificaStatutariaDetail1_ModificaStatutaria(object sender, EventArgs e)
        {
            EventHandler temp = ModificaStatutaria;
            if (temp != null)
                ModificaStatutaria(null, new EventArgs());
        }

        private void assembleaEdit_NuovoProcedimento(object sender, EventArgs e)
        {
            EventHandler temp = NuovoProcedimento;
            if (temp != null)
                NuovoProcedimento(null, new EventArgs());
        }

        private DialogResult OpenForEdit(DeliberaAssembleaFDT item)
        {
            AssembleaEdit page = CreatePage<AssembleaEdit>();
            if (page != null)
            {
                page.NuovoProcedimento += new EventHandler(assembleaEdit_NuovoProcedimento);

                page.SetFormTitle("Gestione assemblea");
                page.SetBindableData(item);

                DialogResult dr = DialogResult.OK;
                while (dr == DialogResult.OK)
                {
                    page.ErrorProviderAssemblea.ClearErrors();

                    dr = page.BaseForm.ShowDialog(this, this.ReadOnlyControls);

                    if (dr == DialogResult.OK)
                    {
                        if (!page.ErrorProviderAssemblea.HasErrors)
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
            this.barButtonItemAdd.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Document_Add_24x24);
            this.barButtonItemModify.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Edit_24x24);
            this.barButtonItemDelete.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);

            this.barButtonItemViewStorico.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Door_24x24);
        }

        private void HandleCurrentItemChanged()
        {
            DeliberaAssembleaFDT assemblea = GetCurrentItem();
            SetVisibilityBarButton(assemblea);

            if (assemblea != null && modificaStatutariaDetail1 != null)
            {
                modificaStatutariaDetail1.SetBindableData(assemblea, itemLocal);

                this.documentationDetail1.SetBindableData(assemblea);                    
            }
            else
            {
                modificaStatutariaDetail1.SetBindableData(null, itemLocal);
            }
        }

        private DeliberaAssembleaFDT GetCurrentItem()
        {
            DeliberaAssembleaFDT toReturn = null;

            if (this.bindingSourceBaseMeeting.Current != null)
            {
                toReturn = this.bindingSourceBaseMeeting.Current as DeliberaAssembleaFDT;
            }

            return toReturn;
        }

        private void AddAssemblea()
        {
            DeliberaAssembleaFDT item = new DeliberaAssembleaFDT();
            item.IdRegistro =
                (itemLocal != null && itemLocal.RegistroCooperativa != null) ?
                itemLocal.RegistroCooperativa.IdRegistro : -1;

            if (OpenForEdit(item) == DialogResult.OK)
            {
                DeliberaAssembleaFDT newItem = SaveAssemblea(item, false, false);
                if (newItem != null)
                {
                    this.gridViewMeeting.BeginDataUpdate();

                    if (itemLocal != null && itemLocal.RegistroCooperativa != null)
                    {
                        itemLocal.RegistroCooperativa.AddDeliberaAssemblea(newItem);
                    }
                    this.bindingSourceBaseMeeting.DataSource = itemLocal.RegistroCooperativa.Assemblee;
                    gridViewMeeting.EndDataUpdate();

                    SetVisibilityBarButton(GetCurrentItem());
                }
                else
                {
                    ShowProblemsMessage();
                }
            }
        }

        private DeliberaAssembleaFDT SaveAssemblea(DeliberaAssembleaFDT item, Boolean isAnUpdate, Boolean onDB)
        {
            DeliberaAssembleaFDT toReturn = null;

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

                    toReturn = item;
                }
            }

            return toReturn;
        }

        private void ModifyAssemblea()
        {
            DeliberaAssembleaFDT item = GetCurrentItem();

            if (item != null)
            {
                 Boolean goOn = true;
                if (item.Status >= ObjectStatus.ToHide)
                {
                    goOn = false;
                }

                if (goOn)
                {
                    item.EndEdit();
                    item.BeginEdit();

                    if (OpenForEdit(item) == DialogResult.OK)
                    {
                        item.EndEdit();
                        DeliberaAssembleaFDT newItem = SaveAssemblea(item, true, false);

                        if (newItem != null)
                        {
                            if (newItem.Status != ObjectStatus.ToInsert)
                                newItem.Status = ObjectStatus.ToUpdate;
                            this.bindingSourceBaseMeeting.EndEdit();
                            gridViewMeeting.RefreshData();
                        }
                        else
                        {
                            this.bindingSourceBaseMeeting.CancelEdit();
                            ShowProblemsMessage();
                        }
                    }
                    else
                    {
                        item.CancelEdit();
                        this.bindingSourceBaseMeeting.CancelEdit();
                    }
                }
            }
        }
        
        private void DeleteAssemblea()
        {
            DeliberaAssembleaFDT item = GetCurrentItem();

            if (item != null)
            {
                if (ShowConfirmMessage("Cancellazione", "Confermi la cancellazione dell'elemento selezionato?", string.Empty) == DialogResult.Yes)
                {
                    if (item.IdDeliberaAssemblea > 0)
                    {
                        item.Status = ObjectStatus.ToCancel;

                        if (item.ModificheStatutarie != null &&
                            item.ModificheStatutarie.Length > 0)
                        {
                            foreach (ModificaStatutariaFDT modifica in item.ModificheStatutarie)
                            {
                                modifica.Status = ObjectStatus.ToCancel;
                            }

                            modificaStatutariaDetail1.ResetBindings();
                        }
                    }
                    else
                    {
                        DeliberaAssembleaFDT[] listActual = this.bindingSourceBaseMeeting.DataSource as DeliberaAssembleaFDT[];

                        if (listActual != null)
                        {
                            List<DeliberaAssembleaFDT> lTemp = new List<DeliberaAssembleaFDT>();
                            foreach (DeliberaAssembleaFDT ind in listActual)
                            {
                                if (ind != item)
                                {
                                    lTemp.Add(ind);
                                }
                            }
                            if (itemLocal != null && itemLocal.RegistroCooperativa != null)
                            {
                                itemLocal.RegistroCooperativa.Assemblee = lTemp.ToArray();
                                this.bindingSourceBaseMeeting.DataSource = itemLocal.RegistroCooperativa.Assemblee;
                            }
                        }
                    }

                    gridViewMeeting.RefreshData();
                    SetVisibilityBarButton(item);
                }
            }
        }

        private void SetVisibilityBarButton(DeliberaAssembleaFDT item)
        {
            if (!this.ReadOnlyControls)
            {
                this.barButtonItemDelete.Enabled = true;
                this.barButtonItemModify.Enabled = true;

                if (item != null)
                {
                    if (item.Status >= ObjectStatus.ToHide)
                    {
                        this.barButtonItemDelete.Enabled = false;
                        this.barButtonItemModify.Enabled = false;
                    }
                }
            }
        }

        private void LoadStorico()
        {
            DeliberaAssembleaFDT item = GetCurrentItem();
            if (item != null)
            {
                if (item.DatiStorici == null)
                {
                    DatiStoriciFDT[] storico =
                       GVCSystemEngine.InvokeService<ICooperatives, DatiStoriciFDT[]>
                           (delegate()
                           {
                               return GVCSystemEngine.Cooperatives.GetListDatiStoriciAssemblea(item.IdDeliberaAssemblea);
                           },
                       true);

                    item.DatiStorici = storico;
                }

                DatiStorici.DatiStoriciAssemblea page = CreatePageDialog<DatiStorici.DatiStoriciAssemblea>();
                if (page != null)
                {
                    page.SetBindableData(item);
                    page.SetFormTitle("Lista dati storici");
                    page.BaseForm.MinimizeBox = false;
                    page.BaseForm.MaximizeBox = false;
                    page.BaseForm.ShowDialog(this, true);
                }

            }
        }

        #endregion Private Methods
    }
}
