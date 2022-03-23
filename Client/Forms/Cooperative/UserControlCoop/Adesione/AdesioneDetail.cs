using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Client.Forms.Common;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Adesione
{
    public partial class AdesioneDetail : it.dedagroup.GVC.Client.Forms.Common.UserControlSplitContainer
    {
        #region Instance Variables (1)

        private CooperativaFDT itemCoop = null;
        public event EventHandler Adesione;

        #endregion Instance Variables 

		#region Event Handlers (4) 

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddAdesione();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteAdesione();
        }

        private void gridControlAdhesions_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifyAdesione();
        }

        private void bindingSourceBaseAdhesion_CurrentChanged(object sender, EventArgs e)
        {
            HandleCurrentItemChange();
        }

        private void barButtonItemModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ModifyAdesione();
        }

        private void gridViewAdhesions_ShowGridMenu(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs e)
        {
            AdesioneFDT item = GetCurrentItem();
            if (item != null)
            {
                GridView view = sender as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
                if (hitInfo.InRow)
                {
                    view.FocusedRowHandle = hitInfo.RowHandle;
                    popupMenuAdesione.ShowPopup(BarManager,
                            gridControlAdhesions.PointToScreen(e.Point));
                }
            }
        }

		#endregion Event Handlers 

		#region Constructors (1) 

        public AdesioneDetail()
        {
            InitializeComponent();

            SetImages();
        }

		#endregion Constructors 

        #region Public Methods (1)

        public void SetBindableData(CooperativaFDT item)
        {
            itemCoop = item;

            if (itemCoop != null && item.RegistroCooperativa != null && itemCoop.RegistroCooperativa.Adesioni != null)
            {
                this.bindingSourceBaseAdesione.DataSource = itemCoop.RegistroCooperativa.Adesioni;
                                
                documentazioneFileSystemDetail1.SetBindableData(itemCoop, new int[]{2});
            }
        }

		#endregion Public Methods 

		#region Private Methods (7) 
     
        private DialogResult OpenForEdit(AdesioneFDT Adesione)
        {
            AdesioneEdit page = CreatePage<AdesioneEdit>();

            if (page != null)
            {
                page.SetFormTitle("Gestione adesione");
                page.SetBindableData(Adesione);

                DialogResult dr = DialogResult.OK;
                while (dr == DialogResult.OK)
                {
                    page.ErrorProviderAdesione.ClearErrors();

                    dr = page.BaseForm.ShowDialog(this, this.ReadOnlyControls);

                    if (dr == DialogResult.OK)
                    {
                        if (!page.ErrorProviderAdesione.HasErrors)
                            break;
                    }
                }
                return dr;
            }
            else
                return DialogResult.None;
        }

        //private AdesioneFDT Save(AdesioneFDT adesione)
        //{
        //    AdesioneFDT toReturn = null;

        //    try
        //    {
        //        toReturn = GVCSystemEngine.InvokeService<ICooperatives, AdesioneFDT>(
        //        delegate { return GVCSystemEngine.Cooperatives.SaveAdesione(adesione); },
        //        true);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //    return toReturn;
        //}

        private void DeleteAdesione()
        {
            AdesioneFDT item = GetCurrentItem();

            if (item != null)
            {
                if (ShowConfirmMessage("Cancellazione", "Confermi la cancellazione dell'elemento selezionato?", string.Empty) == DialogResult.Yes)
                {
                    if (item.IdAdesione > 0)
                    {
                        item.Status = ObjectStatus.ToCancel;
                    }
                    else
                    {
                        AdesioneFDT[] listActual = this.bindingSourceBaseAdesione.DataSource as AdesioneFDT[];

                        if (listActual != null)
                        {
                            List<AdesioneFDT> lTemp = new List<AdesioneFDT>();
                            foreach (AdesioneFDT ind in listActual)
                            {
                                if (ind != item)
                                {
                                    lTemp.Add(ind);
                                }
                            }
                            if (itemCoop != null && itemCoop.RegistroCooperativa != null)
                            {
                                itemCoop.RegistroCooperativa.Adesioni = lTemp.ToArray();
                                this.bindingSourceBaseAdesione.DataSource = itemCoop.RegistroCooperativa.Adesioni;
                            }
                        }
                    }

                    gridViewAdhesions.RefreshData();
                    SetVisibilityBarButton(item);

                    CallTheEvent();
                }
            }
        }

        private void AddAdesione()
        {
            AdesioneFDT item = new AdesioneFDT();

            item.IdRegistro = (item != null) ? itemCoop.RegistroCooperativa.IdRegistro : -1;
            item.IdAdesione = -1;

            if (OpenForEdit(item) == DialogResult.OK)
            {
                //item = Save(item);
                item.Status = ObjectStatus.ToInsert;

                //if (item != null && item.IdAdesione > 0)
                //{
                    gridViewAdhesions.BeginDataUpdate();
                    itemCoop.RegistroCooperativa.AddAdesione(item);
                    this.bindingSourceBaseAdesione.DataSource = itemCoop.RegistroCooperativa.Adesioni;
                    gridViewAdhesions.EndDataUpdate();
                //}
                //else
                //{
                //    ShowProblemsMessage();
                //}


                    CallTheEvent();
            }
        }

        private void CallTheEvent()
        {
            EventHandler temp = Adesione;
            if (temp != null)
                Adesione(null, new EventArgs());
        }

        private AdesioneFDT GetCurrentItem()
        {
            AdesioneFDT toReturn = null;

            if (this.bindingSourceBaseAdesione.Current != null)
            {
                toReturn = this.bindingSourceBaseAdesione.Current as AdesioneFDT;
            }
            return toReturn;
        }

        private void ModifyAdesione()
        {
            AdesioneFDT item = GetCurrentItem();

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
                        //item = Save(item);

                        if (item != null)
                        {
                            if (item.Status != ObjectStatus.ToInsert)
                                item.Status = ObjectStatus.ToUpdate;
                            this.bindingSourceBaseAdesione.EndEdit();
                            gridViewAdhesions.RefreshData();

                            CallTheEvent();
                        }
                        else
                        {
                            this.bindingSourceBaseAdesione.CancelEdit();
                            ShowProblemsMessage();
                        }
                    }
                    else
                    {
                        item.CancelEdit();
                        this.bindingSourceBaseAdesione.CancelEdit();
                    }
                }
            }
        }

        private void HandleCurrentItemChange()
        {
            if (this.bindingSourceBaseAdesione.Current != null)
            {
                AdesioneFDT adesione = this.bindingSourceBaseAdesione.Current as AdesioneFDT;
                if (adesione != null)
                {
                    this.documentationDetail1.SetBindableData(adesione);

                    SetVisibilityBarButton(adesione);
                }
            }
        }

        private void SetImages()
        {
            this.barButtonItemAdd.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Document_Add_24x24);
            this.barButtonItemModify.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Edit_24x24);
            this.barButtonItemDelete.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
        }


        private void SetVisibilityBarButton()
        {
            AdesioneFDT item = GetCurrentItem();
            SetVisibilityBarButton(item);
        }

        private void SetVisibilityBarButton(AdesioneFDT item)
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

		#endregion Private Methods

    }
}
