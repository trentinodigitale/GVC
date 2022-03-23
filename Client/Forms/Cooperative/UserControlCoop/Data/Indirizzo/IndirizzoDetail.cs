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
using it.dedagroup.GVC.Repository.Common.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors.DXErrorProvider;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Data.Indirizzo
{
    public partial class IndirizzoDetail : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {

		#region Fields (1) 

        private SoggettoFDT itemLocal = null;
        public event EventHandler Indirizzi;

		#endregion Fields 

		#region Constructors (1) 

        public IndirizzoDetail()
        {
            InitializeComponent();

            EnableControlAutoSize(new object[]{this, gridControlAddresses}, gridControlAddresses, 400);

            SetImages();
        }

		#endregion Constructors 

		#region Methods (14) 


		// Public Methods (2) 

        public void SetBindableData(SoggettoFDT item)
        {
            itemLocal = item;

            if (item != null)
            {
                this.bindingSourceAddresses.DataSource = item.Indirizzi;
            }
            
            this.bindingSourceAddressTypes.DataSource = 
                GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_INDIRIZZO);
        }

        public void SetReadOnlyButtons(Boolean readOnly)
        {
            this.barButtonItemAddAddress.Enabled = !readOnly;
            this.barButtonItemModify.Enabled = !readOnly;
            this.barButtonItemDeleteAddress.Enabled = !readOnly;
        }



		// Private Methods (12) 

        private void AddIndirizzo()
        {
            IndirizzoFDT item = new IndirizzoFDT();
            item.IdSoggetto = (item != null) ? itemLocal.IdSoggetto : -1;

            if (OpenForEdit(item, true) == DialogResult.OK)
            {
                IndirizzoFDT newItem = SaveIndirizzo(item, false, false);
                if (newItem != null)
                {
                    gridViewAddresses.BeginDataUpdate();
                    itemLocal.AddIndirizzo(newItem);
                    this.bindingSourceAddresses.DataSource = itemLocal.Indirizzi;
                    gridViewAddresses.EndDataUpdate();

                    EventCaller();
                }
                else
                {
                    ShowProblemsMessage();
                }
            }
        }

        private void barButtonItemAddAddress_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddIndirizzo();
        }

        private void barButtonItemDeleteAddress_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteIndirizzo();
        }

        private void barButtonItemModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ModifyIndirizzo();
        }

        private void DeleteIndirizzo()
        {
            IndirizzoFDT item = GetCurrentItem();
            if (item != null)
            {
                if (ShowConfirmMessage("Cancellazione", "Confermi la cancellazione dell'elemento selezionato?", string.Empty) == DialogResult.Yes)
                {
                    if (item.IdIndirizzo > 0)
                    {
                        item.Status = ObjectStatus.ToCancel;
                    }
                    else
                    {
                        IndirizzoFDT[] listActual = this.bindingSourceAddresses.DataSource as IndirizzoFDT[];

                        if (listActual != null)
                        {
                            List<IndirizzoFDT> lTemp = new List<IndirizzoFDT>();
                            foreach (IndirizzoFDT ind in listActual)
                            {
                                if (ind != item)
                                {
                                    lTemp.Add(ind);
                                }
                            }
                            this.itemLocal.Indirizzi = lTemp.ToArray();
                        }
                    }

                    this.bindingSourceAddresses.DataSource = this.itemLocal.Indirizzi;
                    gridViewAddresses.RefreshData();
                    SetVisibilityBarButton(item);

                    EventCaller();
                }
            }
        }

        private IndirizzoFDT GetCurrentItem()
        {
            IndirizzoFDT toReturn = null;

            if (this.bindingSourceAddresses.Current != null)
            {
                toReturn = this.bindingSourceAddresses.Current as IndirizzoFDT;
            }
            return toReturn;
        }

        private void gridControlAddresses_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifyIndirizzo();
        }

        private void gridViewAddresses_ShowGridMenu(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs e)
        {
            IndirizzoFDT item = GetCurrentItem();
            if (item != null)
            {
                GridView view = sender as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
                if (hitInfo.InRow)
                {
                    view.FocusedRowHandle = hitInfo.RowHandle;
                    popupMenuIndirizzi.ShowPopup(BarManager,
                            gridControlAddresses.PointToScreen(e.Point));
                }
            }
        }

        private void ModifyIndirizzo()
        {
            IndirizzoFDT item = GetCurrentItem();
            if (item != null)
            {
                Boolean goOn = true;
                if (item.Status >= it.dedagroup.GVC.Repository.Common.Configurations.ObjectStatus.ToHide)
                {
                    goOn = false;
                }
                
                if (goOn)
                {
                    item.EndEdit();
                    item.BeginEdit();
                    if (OpenForEdit(item, false) == DialogResult.OK)
                    {
                        item.EndEdit();
                        IndirizzoFDT updatedItem = SaveIndirizzo(item, false, true);
                        if (updatedItem != null)
                        {
                            this.bindingSourceAddresses.EndEdit();
                            gridViewAddresses.RefreshData();
                        }
                        else
                        {
                            item.CancelEdit();
                            //this.bindingSourceAddresses.CancelEdit();
                            ShowProblemsMessage();
                        }
                    }
                    else
                    {
                        item.CancelEdit();
                        gridViewAddresses.RefreshData();
                    } 
                }
            }
        }

        private DialogResult OpenForEdit(IndirizzoFDT address, Boolean isNew)
        {
            IndirizzoEdit page = CreatePage<IndirizzoEdit>();
            if (page != null)
            {
                page.SetFormTitle("Gestione indirizzo");
                page.SetBindableData(address);
                DialogResult dr = DialogResult.OK;
                while (dr == DialogResult.OK)
                {
                    page.ErrorProviderAddress.ClearErrors();
                    
                    //dr = page.ParentForm.ShowDialog(this);

                    dr = page.BaseForm.ShowDialog(this, this.ReadOnlyControls);

                    if (dr == DialogResult.OK)
                    {
                        if (address.Sede && CheckSedeFlag(isNew))
                        {
                            //page.AddSedeError();
                            address.HaveToSetTheError = true;
                            page.ErrorProviderAddress.UpdateBinding();
                        }
                        else
                        {
                            //page.SetSedeError();
                            address.HaveToSetTheError = false;
                        }
                        if (!page.ErrorProviderAddress.HasErrors)
                            break;
                    }
                }
                return dr;
            }
            else
                return DialogResult.None;
        }

        private Boolean CheckSedeFlag(Boolean isNew)
        {
            Boolean toReturn = false;

            if (itemLocal != null && itemLocal.Indirizzi != null)
            {
                IndirizzoFDT[] inds = this.bindingSourceAddresses.DataSource as IndirizzoFDT[];
                if (inds != null && this.bindingSourceAddresses.Current != null)
                {
                    foreach (IndirizzoFDT item in inds)
                    {
                        if (item != null && item.Status < it.dedagroup.GVC.Repository.Common.Configurations.ObjectStatus.ToHide)
                        {
                            if (item == this.bindingSourceAddresses.Current as IndirizzoFDT)
                            {
                                if (isNew)
                                {
                                    if (item.Sede)
                                    {
                                        toReturn = true;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                if (item.Sede)
                                {
                                    toReturn = true;
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            return toReturn;
        }

        private IndirizzoFDT SaveIndirizzo(IndirizzoFDT item, Boolean onDB, Boolean isAnUpdate)
        {
            IndirizzoFDT toReturn = null;
            if (item != null)
            {
                if (onDB)
                {
                    toReturn = GVCSystemEngine.InvokeService<ICooperatives, IndirizzoFDT>
                        (delegate() { return GVCSystemEngine.Cooperatives.SaveIndirizzo(item); },
                        true);
                }
                else
                {
                    if (isAnUpdate)
                        item.Status = ObjectStatus.ToUpdate;
                    else
                        item.Status = ObjectStatus.ToInsert;

                    toReturn = item;
                }

                EventCaller();

            }
            return toReturn;
        }

        private void SetImages()
        {
            this.barButtonItemAddAddress.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Document_Add_24x24);
            this.barButtonItemModify.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Edit_24x24);
            this.barButtonItemDeleteAddress.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
        }


		#endregion Methods 

        private void bindingSourceAddresses_CurrentChanged(object sender, EventArgs e)
        {
            HandleCurrentItemChanged();
        }

        private void HandleCurrentItemChanged()
        {
            SetVisibilityBarButton();
        }

        private void SetVisibilityBarButton()
        {
            IndirizzoFDT item = GetCurrentItem();
            SetVisibilityBarButton(item);
        }

        private void SetVisibilityBarButton(IndirizzoFDT item)
        {
            if (!this.ReadOnlyControls)
            {
                this.barButtonItemDeleteAddress.Enabled = true;
                this.barButtonItemModify.Enabled = true;

                if (item != null)
                {
                    if (item.Status >= ObjectStatus.ToHide)
                    {
                        this.barButtonItemDeleteAddress.Enabled = false;
                        this.barButtonItemModify.Enabled = false;
                    }
                }
            }
        }


        private void EventCaller()
        {
            EventHandler eTemp = Indirizzi;
            if (eTemp != null)
            {
                eTemp(null, new EventArgs());
            }
        }

        public string[] HasErrorsCritical()
        {
            List<string> toReturn = new List<string>();

            if (this.gridViewAddresses != null && this.gridViewAddresses.DataSource != null)
            {
                if (bindingSourceAddresses != null && bindingSourceAddresses.DataSource != null)
                {
                    foreach (object item in bindingSourceAddresses.List)
                    {
                        IDXDataErrorInfo itemDataErrorInfo = item as IDXDataErrorInfo;
                        if (item != null)
                        {
                            DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info = new DevExpress.XtraEditors.DXErrorProvider.ErrorInfo();

                            for (int i = 0; i < gridViewAddresses.VisibleColumns.Count; i++)
                            {
                                itemDataErrorInfo.GetPropertyError(gridViewAddresses.VisibleColumns[i].FieldName, info);
                                if (info.ErrorType == ErrorType.Critical)
                                {
                                    toReturn.Add("Indirizzi");
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            return toReturn.ToArray();
        }
    }
}
