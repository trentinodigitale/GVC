using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Client.Forms.Common;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Annotazione
{
    public partial class ScadenziarioDetail : UserControlBase
    {
        #region Instance Variables (2)

        private CooperativaFDT itemCoop = null;
        private DizionarioFDT[] listaTipiAnnotazioni = null;
        
        #endregion Instance Variables 

		#region Event Handlers (2) 

        private void barButtonItemAddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddAnnotazione();
        }
    
        private void barButtonItemModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ModifyAnnotazione();
        }

        private void barButtonItemRemove_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteAnnotazione();
        }

        private void gridControlRemarkExpirations_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifyAnnotazione();
        }

        private void bindingSourceAnnotazioni_CurrentChanged(object sender, EventArgs e)
        {
            HandleCurrentItemChange();
        }

        private void gridViewRemarkExpirations_ShowGridMenu(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs e)
        {
            ScadenziarioFDT item = GetCurrentItem();
            if (item != null)
            {
                GridView view = sender as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
                if (hitInfo.InRow)
                {
                    view.FocusedRowHandle = hitInfo.RowHandle;
                    popupMenuAnnotazioni.ShowPopup(BarManager,
                            gridControlRemarkExpirations.PointToScreen(e.Point));
                }
            }
        }

		#endregion Event Handlers 

		#region Constructors (1) 

        public ScadenziarioDetail()
        {
            InitializeComponent();

            if (!DesignMode)
            {
                EnableControlAutoSize(new object[] { this }, gridControlRemarkExpirations, 200);

                SetImages();
            }
        }

		#endregion Constructors 

		#region Public Methods (1) 

        public void SetBindableData(CooperativaFDT item)
        {
            itemCoop = item;

            if (itemCoop != null && item.RegistroCooperativa != null)
            {
                this.bindingSourceAnnotazioni.DataSource = item.RegistroCooperativa.ScadenzaAnnotazioni;
            }

            listaTipiAnnotazioni = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_ANNOTAZIONE);
            this.bindingSourceTipiAnnotazione.DataSource = listaTipiAnnotazioni;
        }

		#endregion Public Methods 

		#region Private Methods (2) 

        private ScadenziarioFDT GetCurrentItem()
        {
            ScadenziarioFDT toReturn = null;

            if (this.bindingSourceAnnotazioni.Current != null)
            {
                toReturn = this.bindingSourceAnnotazioni.Current as ScadenziarioFDT;
            }
            return toReturn;
        }

        private DialogResult OpenForEdit(ScadenziarioFDT Scad)
        {
            ScadenziarioEdit page = CreatePage<ScadenziarioEdit>();

            if (page != null)
            {
                page.SetFormTitle("Gestione annotazioni/scadenze");
                page.SetBindableData(Scad, listaTipiAnnotazioni);

                DialogResult dr = DialogResult.OK;
                while (dr == DialogResult.OK)
                {
                    page.ErrorProviderAnnotazioni.ClearErrors();

                    dr = page.BaseForm.ShowDialog(this, this.ReadOnlyControls);

                    if (dr == DialogResult.OK)
                    {
                        if (!page.ErrorProviderAnnotazioni.HasErrors)
                            break;
                    }
                }
                return dr;
            }
            else
                return DialogResult.None;
        }

        private void AddAnnotazione()
        {
            ScadenziarioFDT item = new ScadenziarioFDT();

            item.IdRegistro = (item != null) ? itemCoop.RegistroCooperativa.IdRegistro : -1;
            item.IdScadenziario = -1;

            if (OpenForEdit(item) == DialogResult.OK)
            {
                item.Status = ObjectStatus.ToInsert;

                gridViewRemarkExpirations.BeginDataUpdate();
                itemCoop.RegistroCooperativa.AddScadenziario(item);
                this.bindingSourceAnnotazioni.DataSource = itemCoop.RegistroCooperativa.ScadenzaAnnotazioni;
                gridViewRemarkExpirations.EndDataUpdate();
            }
        }

        private void ModifyAnnotazione()
        {
            ScadenziarioFDT item = GetCurrentItem();

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
                        
                        if (item != null)
                        {
                            if (item.Status != ObjectStatus.ToInsert)
                                item.Status = ObjectStatus.ToUpdate;
                            this.bindingSourceAnnotazioni.EndEdit();
                            gridViewRemarkExpirations.RefreshData();
                        }
                        else
                        {
                            this.bindingSourceAnnotazioni.CancelEdit();
                            ShowProblemsMessage();
                        }
                    }
                    else
                    {
                        item.CancelEdit();
                        this.bindingSourceAnnotazioni.CancelEdit();
                    }
                }
            }
        }

        private void DeleteAnnotazione()
        {
            ScadenziarioFDT item = GetCurrentItem();

            if (item != null)
            {
                if (ShowConfirmMessage("Cancellazione", "Confermi la cancellazione dell'elemento selezionato?", string.Empty) == DialogResult.Yes)
                {
                    if (item.IdScadenziario > 0)
                    {
                        item.Status = ObjectStatus.ToCancel;
                    }
                    else
                    {
                        ScadenziarioFDT[] listActual = this.bindingSourceAnnotazioni.DataSource as ScadenziarioFDT[];

                        if (listActual != null)
                        {
                            List<ScadenziarioFDT> lTemp = new List<ScadenziarioFDT>();
                            foreach (ScadenziarioFDT ind in listActual)
                            {
                                if (ind != item)
                                {
                                    lTemp.Add(ind);
                                }
                            }
                            if (itemCoop != null && itemCoop.RegistroCooperativa != null)
                            {
                                itemCoop.RegistroCooperativa.ScadenzaAnnotazioni = lTemp.ToArray();
                                this.bindingSourceAnnotazioni.DataSource = itemCoop.RegistroCooperativa.ScadenzaAnnotazioni;
                            }
                        }
                    }

                    gridViewRemarkExpirations.RefreshData();
                    SetVisibilityBarButton(item);
                }
            }
        }

        private void HandleCurrentItemChange()
        {
            if (this.bindingSourceAnnotazioni.Current != null)
            {
                ScadenziarioFDT scad = this.bindingSourceAnnotazioni.Current as ScadenziarioFDT;
                if (scad != null)
                {
                    SetVisibilityBarButton(scad);
                }
            }
        }

        private void SetImages()
        {
            this.barButtonItemAddNew.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Document_Add_24x24);
            this.barButtonItemModify.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Edit_24x24);
            this.barButtonItemRemove.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
        }

        private void SetVisibilityBarButton()
        {
            ScadenziarioFDT item = GetCurrentItem();
            SetVisibilityBarButton(item);
        }

        private void SetVisibilityBarButton(ScadenziarioFDT item)
        {
            if (!this.ReadOnlyControls)
            {
                this.barButtonItemRemove.Enabled = true;
                this.barButtonItemModify.Enabled = true;

                if (item != null)
                {
                    if (item.Status >= ObjectStatus.ToHide)
                    {
                        this.barButtonItemRemove.Enabled = false;
                        this.barButtonItemModify.Enabled = false;
                    }
                }
            }
        }

		#endregion Private Methods
     }
}
