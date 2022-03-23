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
using it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.BaseCariche.ComunicazioneCaricaSoc;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors.DXErrorProvider;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.PositionAndBase.ComunicazioneCaricaSoc
{
    public partial class ComunicazioneDetail : UserControlSplitContainer
    {
        #region Instance Variables (2)

        private DizionarioFDT[] tipiCaricheSociali;
        private CooperativaFDT itemCoop = null;

        #endregion Instance Variables

        #region Constructors (1)

        public ComunicazioneDetail()
        {
            InitializeComponent();

            EnableControlAutoSize(new object[] { this }, xtraTabControl1, 350);

            SetImages();
        }

        #endregion Constructors 

		#region Event Handlers (1)

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddComunicazione();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteComunicazione();
        }

        private void gridControlCommunications_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifyComunicazione();
        }

        private void bindingSourceCommunications_CurrentChanged(object sender, EventArgs e)
        {
            HandleCurrentChanged();
        }

        private void barButtonItemModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ModifyComunicazione();
        }

		#endregion Event Handlers 

		#region Public Methods (1) 

        public void SetBindableData(CooperativaFDT item)
        {
            itemCoop = item;

            if (itemCoop != null && itemCoop.RegistroCooperativa != null && itemCoop.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale != null)
            {
                this.bindingSourceCommunicazioni.DataSource = itemCoop.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale;

                this.documentazioneFileSystemDetail1.SetBindableData(item, new int[] { 5 });
            }
            this.tipiCaricheSociali = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_CARICA);
        }

		#endregion Public Methods 

		#region Private Methods (2) 

        private DialogResult OpenForEdit(ComunicazioneCaricaSocialeFDT comCS, Boolean createNew)
        {
            ComunicazioneEdit page = CreatePage<ComunicazioneEdit>();
            
            if (page != null)
            {
                page.SetFormTitle("Gestione comunicazione carica sociale");
                page.SetGetParixChagesVisiility(createNew);
                page.SetBindableData(comCS);
                return page.BaseForm.ShowDialog(this, this.ReadOnlyControls);
            }
            else
                return DialogResult.None;
        }

        private ComunicazioneCaricaSocialeFDT GetCurrentItem()
        {
            ComunicazioneCaricaSocialeFDT toReturn = null;

            if (this.bindingSourceCommunicazioni.Current != null)
            {
                toReturn = this.bindingSourceCommunicazioni.Current as ComunicazioneCaricaSocialeFDT;
            }
            return toReturn;
        }

        private ComunicazioneCaricaSocialeFDT GetLastComunicazione()
        {
            ComunicazioneCaricaSocialeFDT toReturn = null;

            if (itemCoop.RegistroCooperativa != null)
            {
                if (itemCoop.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale != null &&
                    itemCoop.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale.Length > 0)
                {
                    if (itemCoop.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale.Length == 1)
                    {
                        if (itemCoop.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale[0].Status != ObjectStatus.ToCancel)
                            toReturn = itemCoop.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale[0];
                    }
                    else
                    {
                        int contatore = 0;
                        DateTime dataRif = DateTime.MinValue;
                        int indice = -1;

                        foreach (ComunicazioneCaricaSocialeFDT itemCS in itemCoop.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale)
                        {
                            if (itemCS.Status != ObjectStatus.ToCancel &&
                                itemCS.DataSituazione > dataRif)
                            {
                                dataRif = itemCS.DataSituazione;
                                indice = contatore;
                            }

                            contatore++;
                        }

                        if (indice > -1)
                        {
                            toReturn = itemCoop.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale[indice];
                        }
                    }                
                }
            }

            return toReturn;
        }

        private void AssociaFlag(CaricaSocialeFDT[] arrayCariche)
        {
            //ricerco i flag dell'ultima comunicazione
            ComunicazioneCaricaSocialeFDT ultimaComunicazione = GetLastComunicazione();

            if (ultimaComunicazione != null)
            {
                if (ultimaComunicazione.Cariche != null &&
                    ultimaComunicazione.Cariche.Length > 0)
                {
                    foreach (CaricaSocialeFDT cs in arrayCariche)
                    {
                        foreach (CaricaSocialeFDT csLast in ultimaComunicazione.Cariche)
                        {
                            if ((csLast.PersonaFisica != null &&
                                cs.PersonaFisica != null &&
                                cs.PersonaFisica.CodiceFiscale == csLast.PersonaFisica.CodiceFiscale) ||
                                cs.DescrizioneSocio == csLast.DescrizioneGSC)
                            {
                                cs.RichiestaAntimafia = csLast.RichiestaAntimafia;
                                cs.RichiestaAntimafiaArrivata = csLast.RichiestaAntimafiaArrivata;
                                cs.RichiestaAntimafiaProdotta = csLast.RichiestaAntimafiaProdotta;
                            }
                        }
                    }
                }
            }
        }

        private void AddComunicazione()
        {
            ComunicazioneCaricaSocialeFDT item = new ComunicazioneCaricaSocialeFDT();
            item.IdRegistro = (item != null) ? itemCoop.RegistroCooperativa.IdRegistro : -1;
            item.IdComunicazioneCaricaSociale = -1;
            
            if (OpenForEdit(item, true) == DialogResult.OK)
            {
                item.Status = ObjectStatus.ToInsert;
                if (item.RetrieveCaricheFromParix)
                {
                    item.Cariche = GetCariche(itemCoop.RegistroCooperativa.NumeroREA, "TN");

                    if (item.Cariche != null &&
                        item.Cariche.Length > 0)
                    {
                        AssociaFlag(item.Cariche);
                    }
                }
                gridViewCommunications.BeginDataUpdate();
                itemCoop.RegistroCooperativa.AddComunicazioneCS(item);
                this.bindingSourceCommunicazioni.DataSource = itemCoop.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale;
                gridViewCommunications.EndDataUpdate();

                SetVisibilityBarButton(GetCurrentItem());
            }
        }

        private void ModifyComunicazione()
        {
            ComunicazioneCaricaSocialeFDT item = GetCurrentItem();

            if (item != null)
            {
                item.EndEdit();
                item.BeginEdit();
              
                if (OpenForEdit(item, false) == DialogResult.OK)
                {
                    item.EndEdit();

                    if (item != null)
                    {
                        if (item.Status != ObjectStatus.ToInsert)
                            item.Status = ObjectStatus.ToUpdate;
                        this.bindingSourceCommunicazioni.EndEdit();
                        gridViewCommunications.RefreshData();
                    }
                    else
                    {
                        this.bindingSourceCommunicazioni.CancelEdit();
                        ShowProblemsMessage();
                    }
                }
                else
                {
                    item.CancelEdit();
                    this.bindingSourceCommunicazioni.CancelEdit();
                }
            }
        }

        private void DeleteComunicazione()
        {
            ComunicazioneCaricaSocialeFDT item = GetCurrentItem();

            if (item != null)
            {
                if (ShowConfirmMessage("Cancellazione", "Confermi la cancellazione dell'elemento selezionato?", string.Empty) == DialogResult.Yes)
                {
                    if (item.IdComunicazioneCaricaSociale > 0)
                    {
                        item.Status = ObjectStatus.ToCancel;
                        if (item.Cariche != null &&
                            item.Cariche.Length > 0)
                        {
                            foreach (CaricaSocialeFDT carica in item.Cariche)
                            {
                                carica.Status = ObjectStatus.ToCancel;
                            }

                            this.CaricaSocialeDetail1.ResetBindings();
                        }
                    }
                    else
                    {
                        ComunicazioneCaricaSocialeFDT[] listActual = this.bindingSourceCommunicazioni.DataSource as ComunicazioneCaricaSocialeFDT[];

                        if (listActual != null)
                        {
                            List<ComunicazioneCaricaSocialeFDT> lTemp = new List<ComunicazioneCaricaSocialeFDT>();
                            foreach (ComunicazioneCaricaSocialeFDT ind in listActual)
                            {
                                if (ind != item)
                                {
                                    lTemp.Add(ind);
                                }
                            }
                            if (itemCoop != null && itemCoop.RegistroCooperativa != null)
                            {
                                itemCoop.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale = lTemp.ToArray();
                                this.bindingSourceCommunicazioni.DataSource = itemCoop.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale;
                            }
                        }
                    }

                    gridViewCommunications.RefreshData();
                    SetVisibilityBarButton(item);
                }
            }
        }

        private void SetVisibilityBarButton(ComunicazioneCaricaSocialeFDT item)
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

        private void HandleCurrentChanged()
        {
            ComunicazioneCaricaSocialeFDT item = this.bindingSourceCommunicazioni.Current as ComunicazioneCaricaSocialeFDT;
            SetVisibilityBarButton(item);
            if (item != null)
            {
                this.CaricaSocialeDetail1.SetBindableData(itemCoop, item, tipiCaricheSociali);
                this.documentationDetail1.SetBindableData(item);
            }
            else
            {
                this.CaricaSocialeDetail1.SetBindableData(itemCoop, null, tipiCaricheSociali);
                this.documentationDetail1.SetBindableData(null);
            }
        }

        private void SetImages()
        {
            this.barButtonItemAdd.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Document_Add_24x24);
            this.barButtonItemModify.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Edit_24x24);
            this.barButtonItemDelete.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
        }

		#endregion Private Methods

        private void gridViewCommunications_ShowGridMenu(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs e)
        {
            ComunicazioneCaricaSocialeFDT item = GetCurrentItem();
            if (item != null)
            {
                GridView view = sender as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
                if (hitInfo.InRow)
                {
                    view.FocusedRowHandle = hitInfo.RowHandle;
                    popupMenuComunicazioneCarica.ShowPopup(BarManager,
                            gridControlCommunications.PointToScreen(e.Point));
                }
            }
        }

        public string[] HasErrors()
        {
            List<string> toReturn = new List<string>();

            if (this.gridViewCommunications != null && this.gridViewCommunications.DataSource != null)
            {
                if (bindingSourceCommunicazioni != null && bindingSourceCommunicazioni.DataSource != null)
                {
                    foreach (object itemL in bindingSourceCommunicazioni.List)
                    {
                        IDXDataErrorInfo itemDataErrorInfo = itemL as IDXDataErrorInfo;
                        if (itemL != null)
                        {
                            DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info = new DevExpress.XtraEditors.DXErrorProvider.ErrorInfo();

                            for (int i = 0; i < gridViewCommunications.VisibleColumns.Count; i++)
                            {
                                itemDataErrorInfo.GetPropertyError(gridViewCommunications.VisibleColumns[i].FieldName, info);
                                if (info.ErrorType == ErrorType.Critical)
                                {
                                    toReturn.Add("Comunicazione cariche sociali");
                                    break;
                                }
                            }


                            ComunicazioneCaricaSocialeFDT itemCast = itemL as ComunicazioneCaricaSocialeFDT;
                            if (itemCast != null)
                            {
                                this.CaricaSocialeDetail1.SetBindableData(this.itemCoop, itemCast, tipiCaricheSociali);
                                string[] ss = this.CaricaSocialeDetail1.HasErrors();
                                if (ss != null && ss.Length > 0)
                                {
                                    toReturn.AddRange(ss);
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            return toReturn.ToArray();
        }

        private CaricaSocialeFDT[] GetCariche(String rea, String province)
        {
            Boolean exception = false;
            ComunicazioneCaricaSocialeFDT[] results = GVCSystemEngine.InvokeService<it.dedagroup.GVC.Repository.Common.Services.ICooperatives, ComunicazioneCaricaSocialeFDT[]>(
                delegate { return GVCSystemEngine.Cooperatives.GetCaricheSocialiFromParix(rea, province, out exception); },
                true);

           
            if (results != null)
            {
                return results[0].Cariche;     
            }
            if (exception)
                ShowInformationMessage("Impossibile recuperare le cariche sociali da Parix", "Impossibile raggiungere il servizio \nVerificare lo stato della conessione");
            return null;
        }
    }
}

