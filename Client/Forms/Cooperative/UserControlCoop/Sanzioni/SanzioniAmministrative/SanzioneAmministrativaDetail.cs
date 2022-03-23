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
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using it.dedagroup.GVC.Repository.Common.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Sanzioni.SanzioniAmministrative
{
    public partial class SanzioneAmministrativaDetail : it.dedagroup.GVC.Client.Forms.Common.UserControlSplitContainer
    {
        #region Instance Variables (4)

        private CooperativaFDT itemCoop = null;
        private DizionarioFDT[] listaGiudici = null;
        private DizionarioFDT[] listaNature = null;
        private LeggiTrasgressioneFDT[] listaLeggi = null;

        #endregion Instance Variables 

        #region Event Handlers

        private void barButtonItemAddPenalty_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddSanzione();
        }

        private void barButtonItemModifiy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ModifySanzione();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteSanzione();
        }

        private void gridControlPenalties_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifySanzione();
        }

        private void bindingSourceBaseSanzioni_CurrentChanged(object sender, EventArgs e)
        {
            HandleCurrentItemChange();
        }

        private void gridViewPenalties_ShowGridMenu(object sender, GridMenuEventArgs e)
        {
            SanzioneFDT item = GetCurrentItem();
            if (item != null)
            {
                GridView view = sender as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
                if (hitInfo.InRow)
                {
                    view.FocusedRowHandle = hitInfo.RowHandle;
                    popupMenuSanzione.ShowPopup(BarManager,
                            gridControlPenalties.PointToScreen(e.Point));
                }
            }
        }

        #endregion Event Handlers

        #region Constructors (1)
        
        public SanzioneAmministrativaDetail()
        {
            InitializeComponent();

            EnableControlAutoSize(new object[] { this }, xtraTabControl1, 350);

            SetImages();
        }

        #endregion Constructors

        #region Public Methods (1)

        public void SetBindableData(CooperativaFDT item, LeggiTrasgressioneFDT[] leggi)
        {
            itemCoop = item;

            if (itemCoop != null && item.RegistroCooperativa != null && itemCoop.RegistroCooperativa.Sanzioni != null)
            {
                this.bindingSourceBaseSanzioni.DataSource = itemCoop.RegistroCooperativa.Sanzioni;

                documentazioneFileSystemDetail1.SetBindableData(item, new int[] { 12 });
            }

            listaGiudici = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.GIUDICI);
            this.bindingSourceBaseGiudici.DataSource = listaGiudici;

            listaNature = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.NATURA_TRASGRESSIONE);
            this.bindingSourceBaseNatura.DataSource = listaNature;

            listaLeggi = leggi;            
        }

        #endregion Public Methods

        #region Private Methods

        private void SetImages()
        {
            this.barButtonItemAdd.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Document_Add_24x24);
            this.barButtonItemModifiy.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Edit_24x24);
            this.barButtonItemDelete.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
        }

        private DialogResult OpenForEdit(SanzioneFDT item)
        {
            SanzioneAmministrativaEdit page = CreatePage<SanzioneAmministrativaEdit>();

            if (page != null)
            {
                page.SetFormTitle("Sanzione");
                page.SetBindableData(item, listaGiudici, listaNature, listaLeggi);
                DialogResult dr = DialogResult.OK;
                while (dr == DialogResult.OK)
                {
                    page.ErrorProviderSanzione.ClearErrors();

                    dr = page.BaseForm.ShowDialog(this, this.ReadOnlyControls);

                    if (dr == DialogResult.OK)
                    {
                        if (!page.ErrorProviderSanzione.HasErrors)
                            break;
                    }
                }
                return dr;
            }
            else
                return DialogResult.None;
        }

        private void DeleteSanzione()
        {
            SanzioneFDT item = GetCurrentItem();

            if (item != null)
            {
                if (ShowConfirmMessage("Cancellazione", "Confermi la cancellazione dell'elemento selezionato?", string.Empty) == DialogResult.Yes)
                {
                    if (item.IdSanzione > 0)
                    {
                        item.Status = ObjectStatus.ToCancel;
                    }
                    else
                    {
                        SanzioneFDT[] listActual = this.bindingSourceBaseSanzioni.DataSource as SanzioneFDT[];

                        if (listActual != null)
                        {
                            List<SanzioneFDT> lTemp = new List<SanzioneFDT>();
                            foreach (SanzioneFDT ind in listActual)
                            {
                                if (ind != item)
                                {
                                    lTemp.Add(ind);
                                }
                            }
                            if (itemCoop != null && itemCoop.RegistroCooperativa != null)
                            {
                                itemCoop.RegistroCooperativa.Sanzioni = lTemp.ToArray();
                                this.bindingSourceBaseSanzioni.DataSource = itemCoop.RegistroCooperativa.Sanzioni;
                            }
                        }
                    }

                    gridViewPenalties.RefreshData();
                    SetVisibilityBarButton(item);
                }
            }
        }

        private void AddSanzione()
        {
            SanzioneFDT item = new SanzioneFDT();

            item.IdRegistro = (item != null) ? itemCoop.RegistroCooperativa.IdRegistro : -1;
            item.IdSanzione = -1;

            if (OpenForEdit(item) == DialogResult.OK)
            {
                //item = Save(item);
                item.Status = ObjectStatus.ToInsert;

                //if (item != null && item.IdAdesione > 0)
                //{
                gridViewPenalties.BeginDataUpdate();
                itemCoop.RegistroCooperativa.AddSanzione(item);
                this.bindingSourceBaseSanzioni.DataSource = itemCoop.RegistroCooperativa.Sanzioni;
                gridViewPenalties.EndDataUpdate();
                //}
                //else
                //{
                //    ShowProblemsMessage();
                //}
            }
        }

        private SanzioneFDT GetCurrentItem()
        {
            SanzioneFDT toReturn = null;

            if (this.bindingSourceBaseSanzioni.Current != null)
            {
                toReturn = this.bindingSourceBaseSanzioni.Current as SanzioneFDT;
            }
            return toReturn;
        }

        private void ModifySanzione()
        {
            SanzioneFDT item = GetCurrentItem();

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
                            this.bindingSourceBaseSanzioni.EndEdit();
                            gridViewPenalties.RefreshData();
                        }
                        else
                        {
                            this.bindingSourceBaseSanzioni.CancelEdit();
                            ShowProblemsMessage();
                        }
                    }
                    else
                    {
                        item.CancelEdit();
                        this.bindingSourceBaseSanzioni.CancelEdit();
                    }
                }
            }
        }

        private void HandleCurrentItemChange()
        {
            if (this.bindingSourceBaseSanzioni.Current != null)
            {
                SanzioneFDT sanzione = this.bindingSourceBaseSanzioni.Current as SanzioneFDT;
                if (sanzione != null)
                {
                    this.documentationDetail1.SetBindableData(sanzione);

                    SetVisibilityBarButton(sanzione);
                }
            }
        }

        private void SetVisibilityBarButton()
        {
            SanzioneFDT item = GetCurrentItem();
            SetVisibilityBarButton(item);
        }

        private void SetVisibilityBarButton(SanzioneFDT item)
        {
            if (!this.ReadOnlyControls)
            {
                this.barButtonItemDelete.Enabled = true;
                this.barButtonItemModifiy.Enabled = true;

                if (item != null)
                {
                    if (item.Status >= ObjectStatus.ToHide)
                    {
                        this.barButtonItemDelete.Enabled = false;
                        this.barButtonItemModifiy.Enabled = false;
                    }
                }
            }
        }

        #endregion Private Methods
    }
}
