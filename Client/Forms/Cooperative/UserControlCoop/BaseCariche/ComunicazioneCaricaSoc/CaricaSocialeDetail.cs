using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Client.Forms.Common;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.BaseCariche.ComunicazioneCaricaSoc;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors.DXErrorProvider;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.PositionAndBase.ComunicazioneCaricaSoc
{
    public partial class CaricaSocialeDetail : UserControlBase
    {
        #region Instance Variables (1)

        private CooperativaFDT itemCoop = null;
        private ComunicazioneCaricaSocialeFDT itemCom = null;
        private DizionarioFDT[] listaTipiCaricheSociali = null;

        #endregion Instance Variables 

        #region Constructors (1)
        
        public CaricaSocialeDetail()
        {
            InitializeComponent();

            EnableControlAutoSize(new object[] { this }, gridControlSocialPosition, 200);

            SetImages();
        }

        #endregion Constructors

        #region Event Handlers (4)

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddCarica();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteCarica();
        }

        private void gridControlSocialPosition_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifyCarica();
        }

        private void bindingSourceSocialPosition_CurrentChanged(object sender, EventArgs e)
        {
            HandleCurrentItemChange();
        }

        private void barButtonItemModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ModifyCarica();
        }

        private void barButtonItemPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.XtraPrinting.PrintingSystem ps = new DevExpress.XtraPrinting.PrintingSystem();
            DevExpress.XtraPrinting.PrintableComponentLink pcl = new DevExpress.XtraPrinting.PrintableComponentLink();

            ps.Links.Add(pcl);
            pcl.Component = gridControlSocialPosition;

            ps.Links[0].Landscape = true;

            DevExpress.XtraPrinting.PageHeaderFooter phf = ps.Links[0].PageHeaderFooter as DevExpress.XtraPrinting.PageHeaderFooter;

            if (itemCom != null)
            {
                String Data1 = String.Empty;
                String Data2 = String.Empty;
                String Data3 = String.Empty;

                if (itemCom.DataComunicazione.HasValue)
                    Data1 = itemCom.DataComunicazione.Value.Date.ToString(Strings.Formats.DATE);
                
                Data2 = itemCom.DataSituazione.ToString(Strings.Formats.DATE);

                if (itemCom.DataComunicazioneAntimafia.HasValue)
                    Data3 = itemCom.DataComunicazioneAntimafia.Value.Date.ToString(Strings.Formats.DATE);

                String CoopData = String.Empty;
                if (itemCoop.RegistroCooperativa != null)
                    CoopData = itemCoop.RegistroCooperativa.CodiceCooperativa.ToString();

                phf.Header.Content.AddRange(new string[] { String.Concat("Cooperativa codice ", CoopData, Environment.NewLine, "Comunicazione riferimento del: ", Data1, Environment.NewLine, "Situazione al: ", Data2, " - Comunicazione certificazione antimafia: ", Data3), null, String.Concat(Environment.NewLine, "Elenco Cariche sociali") });
            }
            else
                phf.Header.Content.AddRange(new string[] { null, null, String.Concat(Environment.NewLine, "Elenco Cariche sociali") });

            pcl.ShowPreviewDialog();
        }

        #endregion Event Handlers
        
        #region Public Methods (1)

        public override bool ReadOnlyControls
        {
            get
            {
                return base.ReadOnlyControls;
            }
            set
            {
                base.ReadOnlyControls = value;

                this.barButtonItemPDF.Enabled = true;
            }
        }

        public void ResetBindings()
        {
            this.bindingSourceCariche.ResetBindings(false);
        }

        public void SetBindableData(CooperativaFDT cooperativa, ComunicazioneCaricaSocialeFDT comunicazione, DizionarioFDT[] tipiCaricheSociali)
        {
            listaTipiCaricheSociali = tipiCaricheSociali;
            itemCoop = cooperativa;
            itemCom = comunicazione;

            if (itemCom != null)
            {
                this.bindingSourceCariche.DataSource = itemCom.Cariche;
            }
            else
            {
                this.bindingSourceCariche.DataSource = null;
            }

            this.bindingSourceTipiCarica.DataSource = listaTipiCaricheSociali;           
        }

        #endregion Public Methods 

        #region Private Methods

        private void HandleCurrentItemChange()
        {
            if (this.bindingSourceCariche.Current != null)
            {
                CaricaSocialeFDT carica = this.bindingSourceCariche.Current as CaricaSocialeFDT;
                if (carica != null)
                {
                    SetVisibilityBarButton(carica);
                }
            }
        }

        private DialogResult OpenForEdit(CaricaSocialeFDT carica)
        {
            CaricaSocialeEdit page = CreatePage<CaricaSocialeEdit>();
            if (page != null)
            {
                page.SetFormTitle("Gestione carica sociale");
                page.SetBindableData(itemCom, carica, listaTipiCaricheSociali);

                DialogResult dr = DialogResult.OK;
                while (dr == DialogResult.OK)
                {
                    page.ErrorProviderCarica.ClearErrors();

                    dr = page.BaseForm.ShowDialog(this, this.ReadOnlyControls);

                    if (dr == DialogResult.OK)
                    {
                        if (!page.ErrorProviderCarica.HasErrors)
                            break;
                    }
                }
                return dr;
            }
            else
                return DialogResult.None;
        }

        private CaricaSocialeFDT GetCurrentItem()
        {
            CaricaSocialeFDT toReturn = null;

            if (this.bindingSourceCariche.Current != null)
            {
                toReturn = this.bindingSourceCariche.Current as CaricaSocialeFDT;
            }
            return toReturn;
        }

        private void AddCarica()
        {
            if (itemCom != null && itemCom.Status < 100)
            {
                CaricaSocialeFDT item = new CaricaSocialeFDT();
                item.IdComunicazione = itemCom.IdComunicazioneCaricaSociale;
                item.IdCarica = -1;

                if (OpenForEdit(item) == DialogResult.OK)
                {
                    itemCom.Status = ObjectStatus.ToUpdate;
                    item.Status = ObjectStatus.ToInsert;

                    gridViewSocialPosition.BeginDataUpdate();
                    itemCom.AddCariche(item);
                    this.bindingSourceCariche.DataSource = itemCom.Cariche;
                    gridViewSocialPosition.EndDataUpdate();

                    SetVisibilityBarButton(GetCurrentItem());
                }
            }
            else
            {
                ShowInformationMessage("Nessuna comunicazione di carica sociale selezionata", "Per inserire una carica sociale è necessario selezionare la relativa comunicazione");
            }
        }

        private void ModifyCarica()
        {
            CaricaSocialeFDT item = GetCurrentItem();

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
                            this.bindingSourceCariche.EndEdit();
                            gridViewSocialPosition.RefreshData();
                        }
                        else
                        {
                            this.bindingSourceCariche.CancelEdit();
                            ShowProblemsMessage();
                        }
                    }
                    else
                    {
                        item.CancelEdit();
                        this.bindingSourceCariche.CancelEdit();
                    }
                }
            }
        }

        private void DeleteCarica()
        {
            CaricaSocialeFDT item = GetCurrentItem();

            if (item != null)
            {
                if (ShowConfirmMessage("Cancellazione", "Confermi la cancellazione dell'elemento selezionato?", string.Empty) == DialogResult.Yes)
                {
                    //item.Status = ObjectStatus.ToCancel;
                    //this.bindingSourceCariche.EndEdit();
                    //gridViewSocialPosition.RefreshData();
                    if (item.IdCarica > 0)
                    {
                        item.Status = ObjectStatus.ToCancel;
                    }
                    else
                    {
                        CaricaSocialeFDT[] listActual = this.bindingSourceCariche.DataSource as CaricaSocialeFDT[];

                        if (listActual != null)
                        {
                            List<CaricaSocialeFDT> lTemp = new List<CaricaSocialeFDT>();
                            foreach (CaricaSocialeFDT ind in listActual)
                            {
                                if (ind != item)
                                {
                                    lTemp.Add(ind);
                                }
                            }
                            if (itemCom != null)
                            {
                                itemCom.Cariche = lTemp.ToArray();
                                this.bindingSourceCariche.DataSource = itemCom.Cariche;
                            }
                        }
                    }

                    gridViewSocialPosition.RefreshData();
                    SetVisibilityBarButton(item);
                }
            }
        }

        private void SetVisibilityBarButton(CaricaSocialeFDT item)
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

        //private void HandleCurrentItemChange()
        //{
            //if (this.bindingSourceSocialPosition.Current != null)
            //{
            //    CaricaSocialeFDT item = this.bindingSourceSocialPosition.Current as ComunicazioneBaseSocialeFDT;
            //    if (item != null)
            //    {
            //        this.documentazioneDetail1.SetBindableData(item.Documentazioni);
            //    }
            //}
        //}

        private void SetImages()
        {
            this.barButtonItemAdd.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Document_Add_24x24);
            this.barButtonItemModify.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Edit_24x24);
            this.barButtonItemDelete.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
            this.barButtonItemPDF.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Printer_24x24);
        }

        #endregion Private Methods

        private void gridViewSocialPosition_ShowGridMenu(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs e)
        {
            CaricaSocialeFDT item = GetCurrentItem();
            if (item != null)
            {
                GridView view = sender as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
                if (hitInfo.InRow)
                {
                    view.FocusedRowHandle = hitInfo.RowHandle;
                    popupMenuCarica.ShowPopup(BarManager,
                            gridControlSocialPosition.PointToScreen(e.Point));
                }
            }
        }

        public string[] HasErrors()
        {
            List<string> toReturn = new List<string>();

            if (this.gridViewSocialPosition != null && this.gridViewSocialPosition.DataSource != null)
            {
                if (bindingSourceCariche != null && bindingSourceCariche.DataSource != null)
                {
                    foreach (object itemL in bindingSourceCariche.List)
                    {
                        IDXDataErrorInfo itemDataErrorInfo = itemL as IDXDataErrorInfo;
                        if (itemL != null)
                        {
                            DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info = new DevExpress.XtraEditors.DXErrorProvider.ErrorInfo();

                            for (int i = 0; i < gridViewSocialPosition.VisibleColumns.Count; i++)
                            {
                                itemDataErrorInfo.GetPropertyError(gridViewSocialPosition.VisibleColumns[i].FieldName, info);
                                if (info.ErrorType == ErrorType.Critical)
                                {
                                    toReturn.Add("Cariche sociali");
                                    return toReturn.ToArray();
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
