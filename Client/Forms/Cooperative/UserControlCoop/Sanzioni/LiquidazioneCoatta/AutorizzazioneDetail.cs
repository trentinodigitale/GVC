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
using it.dedagroup.GVC.Repository.Common.Configurations;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Sanzioni.LiquidazioneCoatta
{
    public partial class AutorizzazioneDetail : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        #region Instance Variables (2)

        private LiquidazioneCoattaFDT itemLiquiCoatta; 
        private DizionarioFDT[] listTipiAutorizzazione;

        public event EventHandler NuovoProcedimento;

        #endregion Instance Variables

        public AutorizzazioneDetail()
        {
            InitializeComponent();

            EnableControlAutoSize(new object[] { this }, gridControlAuthorizations, 200);

            SetImages();
        }

        #region Constructors (1)

        private void SetImages()
        {
            this.barButtonItemAdd.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Document_Add_24x24);
            this.barButtonItemModify.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Edit_24x24);
            this.barButtonItemDelete.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
        }

        #endregion Constructors

        #region Public Methods (1)

        public void SetBindableData(LiquidazioneCoattaFDT item)
        {
            itemLiquiCoatta = item;
            if (itemLiquiCoatta.Autorizzazioni != null)
            {
                this.bindingSourceAuthorizations.DataSource = itemLiquiCoatta.Autorizzazioni;
            }
            
            listTipiAutorizzazione = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_AUTORIZZAZIONE);
            this.bindingSourceAuthorizationType.DataSource = listTipiAutorizzazione;
        }

        public void ResetBindings()
        {
            this.bindingSourceAuthorizations.ResetBindings(false);
        }

        #endregion Public Methods 

        #region Private Methods (6)

        private void HandleCurrentItemChange()
        {
            if (this.bindingSourceAuthorizations.Current != null)
            {
                AutorizzazioneFDT a = this.bindingSourceAuthorizations.Current as AutorizzazioneFDT;
                if (a != null)
                {
                    SetVisibilityBarButton(a);
                }
            }
        }
        
        private void SetStatusPadre()
        {
            if (itemLiquiCoatta != null)
            {
                if (!(itemLiquiCoatta.Status == ObjectStatus.ToInsert))
                {
                    itemLiquiCoatta.BeginEdit();
                    itemLiquiCoatta.Status = ObjectStatus.ToUpdate;
                    itemLiquiCoatta.EndEdit();
                }
            }
        }

        private void AddItem()
        {
            if ((itemLiquiCoatta != null) && (itemLiquiCoatta.Status < ObjectStatus.ToHide))
            {
                AutorizzazioneFDT item = new AutorizzazioneFDT();
                item.BeginEdit();
                item.IdLiquidazione = (item != null) ? itemLiquiCoatta.IdLiquidazioneCoatta : -1;
                item.IdAutorizzazione = -1;

                if (OpenForEdit(item) == DialogResult.OK)
                {
                    item.Status = ObjectStatus.ToInsert;
                    item.EndEdit();

                    SetStatusPadre();

                    gridViewAuthorizations.BeginDataUpdate();
                    itemLiquiCoatta.AddAutorizzazione(item);
                    this.bindingSourceAuthorizations.DataSource = itemLiquiCoatta.Autorizzazioni;
                    gridViewAuthorizations.EndDataUpdate();
                }
                else
                {
                    item.CancelEdit();
                }
            }
            else
            {
                ShowInformationMessage("Nessuna liquidazione coatta selezionata", "Per inserire una autorizzazione è necessario selezionare la relativa liquidazione coatta");
            }    
        }

        private void ModifyItem()
        {
            AutorizzazioneFDT item = GetCurrentItem();

            if (item != null)
            {
                 Boolean goOn = true;

                if (item.Status >= ObjectStatus.ToHide)
                {
                    goOn = false;
                }

                if ((itemLiquiCoatta != null) && (itemLiquiCoatta.Status >= ObjectStatus.ToHide))
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

                        item.EndEdit();

                        SetStatusPadre();
                    }
                    else
                    {
                        item.CancelEdit();
                    }
                    gridViewAuthorizations.RefreshData();
                }
            }   
        }

        private void DeleteItem()
        {
            AutorizzazioneFDT item = GetCurrentItem();
            if (item != null)
            {
                if (ShowConfirmMessage("GVC", "Confermi la cancellazione dell'elemento selezionato?", string.Empty) == DialogResult.Yes)
                {
                    if (item.Status == ObjectStatus.ToInsert)
                    {
                        itemLiquiCoatta.RemoveAutorizzazione(item);
                        this.bindingSourceAuthorizations.DataSource = itemLiquiCoatta.Autorizzazioni;
                    }
                    else
                    {
                        item.BeginEdit();
                        item.Status = ObjectStatus.ToCancel;
                        item.EndEdit();
                    }
                    SetStatusPadre();

                    SetVisibilityBarButton(item);
                    gridViewAuthorizations.RefreshData();
                }
            }
        }

        private AutorizzazioneFDT GetCurrentItem()
        {
            AutorizzazioneFDT toReturn = null;

            if (this.bindingSourceAuthorizations.Current != null)
            {
                toReturn = this.bindingSourceAuthorizations.Current as AutorizzazioneFDT;
            }

            return toReturn;
        }

        private DialogResult OpenForEdit(AutorizzazioneFDT item)
        {
            if (item != null)
            {
                AutorizzazioneEdit page = CreatePage<AutorizzazioneEdit>();
                if (page != null)
                {
                    page.NuovoProcedimento += new EventHandler(autorizzazioneEdit_NuovoProcedimento);

                    page.SetFormTitle("Gestione Autorizzazione");
                    page.SetBindableData(itemLiquiCoatta, item, listTipiAutorizzazione);

                    DialogResult dr = DialogResult.OK;
                    while (dr == DialogResult.OK)
                    {
                        page.ErrorProviderAuthorizations.ClearErrors();

                        dr = page.BaseForm.ShowDialog(this, this.ReadOnlyControls);

                        if (dr == DialogResult.OK)
                        {
                            if (!page.ErrorProviderAuthorizations.HasErrors)
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

        private void SetVisibilityBarButton(AutorizzazioneFDT item)
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

        #region EventHandler 

        private void gridControlAuthorizations_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifyItem();
        }
        
        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddItem();
        }

        private void barButtonItemModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ModifyItem();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteItem();
        }

        private void autorizzazioneEdit_NuovoProcedimento(object sender, EventArgs e)
        {
            EventHandler temp = NuovoProcedimento;
            if (temp != null)
                NuovoProcedimento(null, new EventArgs());
        }

        #endregion EventHandler

        private void gridViewAuthorizations_ShowGridMenu(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs e)
        {
            AutorizzazioneFDT item = GetCurrentItem();
            if (item != null)
            {
                GridView view = sender as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
                if (hitInfo.InRow)
                {
                    view.FocusedRowHandle = hitInfo.RowHandle;
                    popupMenuAutorizzazioneDetail.ShowPopup(BarManager,
                            gridControlAuthorizations.PointToScreen(e.Point));
                }
            }
        }

        private void bindingSourceAuthorizations_CurrentChanged(object sender, EventArgs e)
        {
            HandleCurrentItemChange();
        }

    }
}
