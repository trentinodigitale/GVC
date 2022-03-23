using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Client.Forms.Common;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using it.dedagroup.GVC.Client.Forms.Registry;
using it.dedagroup.GVC.Repository.Common.Configurations;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Sanzioni.Commissari
{
    public partial class CommissarioDetail : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        #region Instance Variables (2)

        private ProceduraCoattaFDT itemProcCoatta = null;
        private LiquidazioneCoattaFDT itemLiqCoatta = null;
        DatiFDT dati = null;
        bool bProcCoatta;
        bool bLiqCoatta;
       
        #endregion Instance Variables

        #region Constructors (1)

        public CommissarioDetail()
        {
            InitializeComponent();

            EnableControlAutoSize(new object[] { this }, gridControlCommissioner, 200);

            SetImages();
        }

        #endregion

        #region Public Methods (2)

        public void SetLiquidazioneCoattaCaption()
        {
            colRevisor.Visible = false;
            colRevisorLiquidation.Visible = true;
            colRevisorLiquidation.VisibleIndex = 0;
            bProcCoatta = false;
            bLiqCoatta = true;
        }

        public void SetProceduraCoattaCaption()
        {
            colRevisor.Visible = true;
            colRevisor.VisibleIndex = 0;
            colRevisorLiquidation.Visible = false;
            bProcCoatta = true;
            bLiqCoatta = false;
        }

        public void SetBindableData(ProceduraCoattaFDT item, DatiFDT d)
        {
            itemProcCoatta = item;
            if (itemProcCoatta.CompensiCommissari != null)
            {
                this.bindingSourceForcedLiquidation.DataSource = itemProcCoatta.CompensiCommissari;
            }
                       
            dati = d;
        }

        public void SetBindableDataLiquidazione(LiquidazioneCoattaFDT item, DatiFDT d)
        {
            itemLiqCoatta = item;
            if (itemLiqCoatta.CompensiCommissari != null)
            {
                this.bindingSourceForcedLiquidation.DataSource = itemLiqCoatta.CompensiCommissari;
            }
                        
            dati = d;
        }

        public void ResetBindings()
        {
            this.bindingSourceForcedLiquidation.ResetBindings(false);            
        }

        #endregion Public Methods 

        #region Event Handlers (3)
        
        private void gridControlCommissioner_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifyItem();
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddItem();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteItem();
        }

        private void barButtonItemModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ModifyItem();
        }

        #endregion Event Handlers

        #region Private Methods (6)
        
        private void HandleCurrentItemChange()
        {
            if (this.bindingSourceForcedLiquidation.Current != null)
            {
                CompensoFDT c = this.bindingSourceForcedLiquidation.Current as CompensoFDT;
                if (c != null)
                {
                    SetVisibilityBarButton(c);
                }
            }
        }

        private void SetStatusPadre()
        {
            if (itemProcCoatta != null)
            {
                if (!(itemProcCoatta.Status == ObjectStatus.ToInsert))
                {
                    itemProcCoatta.BeginEdit();
                    itemProcCoatta.Status = ObjectStatus.ToUpdate;
                    itemProcCoatta.EndEdit();
                }
            }
            else if (itemLiqCoatta != null)
            {
                if (!(itemLiqCoatta.Status == ObjectStatus.ToInsert))
                {
                    itemLiqCoatta.BeginEdit();
                    itemLiqCoatta.Status = ObjectStatus.ToUpdate;
                    itemLiqCoatta.EndEdit();
                }
            } 
        }

        private void AddItem()
        {
            if ((bLiqCoatta) && ((itemLiqCoatta == null) || (itemLiqCoatta.Status > ObjectStatus.ToHide)))
            {
                ShowInformationMessage("Nessuna liquidazione coatta selezionata", "Per inserire un commissario è necessario selezionare la relativa liquidazione coatta");                
            }
            else if ((bProcCoatta) && ((itemProcCoatta == null) || (itemProcCoatta.Status > ObjectStatus.ToHide)))
            {
                ShowInformationMessage("Nessuna procedura coatta selezionata", "Per inserire un commissario è necessario selezionare la relativa procedura coatta");
            }
            else
            {
                CompensoFDT item = new CompensoFDT();
                item.BeginEdit();

                item.IdCompenso = -1;
                if (itemProcCoatta != null)
                {
                    item.IdProcedura = (item != null) ? itemProcCoatta.IdProceduraCoatta : -1;
                    item.IdLiquidazione = -1;
                }
                else if (itemLiqCoatta != null)
                {
                    item.IdProcedura = -1;
                    item.IdLiquidazione = (item != null) ? itemLiqCoatta.IdLiquidazioneCoatta : -1; ;
                }

                item.PercentualeCNP = dati.PercentualeCNP;
                item.PercentualeIVA = dati.PercentualeIVA;

                if (OpenForEdit(item) == DialogResult.OK)
                {
                    item.IdRevisore = item.Revisore.IdSoggetto;
                    item.Status = ObjectStatus.ToInsert;
                    item.EndEdit();

                    item.IdCompenso = -1;
                    SetStatusPadre();

                    gridViewCommissioner.BeginDataUpdate();
                    if (itemProcCoatta != null)
                    {
                        itemProcCoatta.AddCompensoCommissario(item);
                        this.bindingSourceForcedLiquidation.DataSource = itemProcCoatta.CompensiCommissari;
                    }
                    else if (itemLiqCoatta != null)
                    {
                        itemLiqCoatta.AddCompensoCommissario(item);
                        this.bindingSourceForcedLiquidation.DataSource = itemLiqCoatta.CompensiCommissari;
                    }
                    gridViewCommissioner.EndDataUpdate();
                }
                else
                {
                    item.CancelEdit();
                }
            }
        }

        private void ModifyItem()
        {
            CompensoFDT item = GetCurrentItem();
                        
            if (item != null)
            {
                Boolean goOn = true;

                if (item.Status >= ObjectStatus.ToHide)
                {
                    goOn = false;
                }

                if ((itemLiqCoatta != null) && (itemLiqCoatta.Status >= ObjectStatus.ToHide))
                {
                    goOn = false;
                }

                if ((itemProcCoatta != null) && (itemProcCoatta.Status >= ObjectStatus.ToHide))
                {
                    goOn = false;
                }


                if (goOn)
                {
                    item.BeginEdit();
                    if (OpenForEdit(item) == DialogResult.OK)
                    {
                        if (item.Status != ObjectStatus.ToInsert)
                            item.Status = ObjectStatus.ToUpdate;
                        item.IdRevisore = item.Revisore.IdSoggetto;
                        item.EndEdit();

                        SetStatusPadre();
                    }
                    else
                    {
                        item.CancelEdit();
                    }

                    gridViewCommissioner.RefreshData();
                }
            }
        }

        private void DeleteItem()
        {
            CompensoFDT item = GetCurrentItem();
            if (item != null)
            {
                if (ShowConfirmMessage("GVC", "Confermi la cancellazione dell'elemento selezionato?", string.Empty) == DialogResult.Yes)
                {
                    if (item.Status == ObjectStatus.ToInsert)
                    {
                        if (itemProcCoatta != null)
                        {
                            itemProcCoatta.RemoveCompensoCommissario(item);
                            this.bindingSourceForcedLiquidation.DataSource = itemProcCoatta.CompensiCommissari;
                        }
                        else if (itemLiqCoatta != null)
                        {
                            itemLiqCoatta.RemoveCompensoCommissario(item);
                            this.bindingSourceForcedLiquidation.DataSource = itemLiqCoatta.CompensiCommissari;
                        }
                    }
                    else
                    {
                        item.BeginEdit();
                        item.Status = ObjectStatus.ToCancel;
                        item.EndEdit();
                    }
                    SetStatusPadre();

                    SetVisibilityBarButton(item);
                    gridViewCommissioner.RefreshData();
                }
            }
        }

        private CompensoFDT GetCurrentItem()
        {
            CompensoFDT toReturn = null;

            if (this.bindingSourceForcedLiquidation.Current != null)
            {
                toReturn = this.bindingSourceForcedLiquidation.Current as CompensoFDT;
            }

            return toReturn;
        }

        private DialogResult OpenForEdit(CompensoFDT item)
        {
            if (item != null)
            {
                CommissarioEdit page = CreatePage<CommissarioEdit>();
                if (page != null)
                {
                    if (itemProcCoatta != null)
                    {
                        page.SetFormTitle("Compenso commissario");
                        page.SetProceduraCoattaCaption();
                        page.SetBindableData(itemProcCoatta, item);
                    }
                    else if (itemLiqCoatta != null)
                    {
                        page.SetFormTitle("Compenso commissario liquidatore");
                        page.SetLiquidazioneCoattaCaption();
                        page.SetBindableData(itemLiqCoatta, item);
                    }
                    
                    DialogResult dr = DialogResult.OK;
                    while (dr == DialogResult.OK)
                    {
                        page.ErrorProviderCommissario.ClearErrors();

                        dr = page.BaseForm.ShowDialog(this, this.ReadOnlyControls);

                        if (dr == DialogResult.OK)
                        {
                            if (!page.ErrorProviderCommissario.HasErrors)
                                break;
                        }
                    }
                    return dr;
                }
                else
                    return DialogResult.None;
            }
            return DialogResult.None;
        }

        private void SetImages()
        {
            this.barButtonItemAdd.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Document_Add_24x24);
            this.barButtonItemModify.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Edit_24x24);
            this.barButtonItemDelete.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
        }

        private void SetVisibilityBarButton(CompensoFDT item)
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

        private void gridViewCommissioner_ShowGridMenu(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs e)
        {
            CompensoFDT item = GetCurrentItem();
            if (item != null)
            {
                GridView view = sender as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
                if (hitInfo.InRow)
                {
                    view.FocusedRowHandle = hitInfo.RowHandle;
                    popupMenuCommissario.ShowPopup(BarManager,
                            gridControlCommissioner.PointToScreen(e.Point));
                }
            }
        }

        private void bindingSourceForcedLiquidation_CurrentChanged(object sender, EventArgs e)
        {
            HandleCurrentItemChange();
        }
        
    }
}
