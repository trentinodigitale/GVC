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
using OeF.Configurations;
using it.dedagroup.GVC.Repository.Common;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Revisione
{
    public partial class RevisioneDetail : UserControlSplitContainer
    {
        #region Instance Variables (4)

        private DizionarioFDT[] listaTipiDocumentazioni = null;
        private DizionarioFDT[] listaEsitiRevisioni = null;
        private CooperativaFDT itemCoop = null;
        private DatiFDT dati;
        DizionarioFDT dettCadenzaRev;

        public event EventHandler NuovoProcedimento;

        #endregion Instance Variables (4)

        #region Constructors (1)

        public RevisioneDetail()
        {
            InitializeComponent();

            SetImages();

            incaricoLiquidazioneDetail1.NuovoProcedimento += new EventHandler(incaricoLiquidazioneDetail1_NuovoProcedimento);
        }

        

        #endregion Constructors

        #region Event Handlers (3)
        
        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddRevisione();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteRevisione();
        }

        private void gridControlRevisions_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifyRevisione();
        }

        private void bindingSourceRevision_CurrentChanged(object sender, EventArgs e)
        {
            HandleCurrentItemChange();
        }

        private void barButtonItemModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ModifyRevisione();
        }

        void incaricoLiquidazioneDetail1_NuovoProcedimento(object sender, EventArgs e)
        {
            EventHandler temp = NuovoProcedimento;
            if (temp != null)
                NuovoProcedimento(null, new EventArgs());
        }

        #endregion Event Handlers (3)
        
        #region Public Methods (1)

        public void SetBindableData(CooperativaFDT item,
                                    DizionarioFDT[] tipiDocumentazione,
                                    DatiFDT d,
                                    DizionarioFDT dettCad)
        {
            this.listaTipiDocumentazioni = tipiDocumentazione;
            this.listaEsitiRevisioni = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.ESITI_REVISIONE);

            this.bindingSourceEsitiRevisione.DataSource = listaEsitiRevisioni;
            this.bindingSourceBaseTipiRevisione.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.TIPI_REVISIONE);

            dati = d;
            dettCadenzaRev = dettCad;

            if (item != null && item.RegistroCooperativa != null)
            {
                itemCoop = item;
                this.bindingSourceRevisioni.DataSource = item.RegistroCooperativa.Revisioni;

                this.documentazioneFileSystemDetail1.SetBindableData(item, new int[] { 3 });
            }
        }

        #endregion Public Methods

        #region Private Methods (7)

        private void HandleCurrentItemChange()
        {
            if (this.bindingSourceRevisioni.Current != null)
            {
                RevisioneFDT r = this.bindingSourceRevisioni.Current as RevisioneFDT;
                if (r != null)
                {
                    incaricoLiquidazioneDetail1.SetBindableData(itemCoop, r, listaEsitiRevisioni, dati, dettCadenzaRev);
                    documentazioneDetail1.SetBindableData(r);

                    SetVisibilityBarButton(r);
                }
                else
                {
                    incaricoLiquidazioneDetail1.SetBindableData(itemCoop, null, listaEsitiRevisioni, dati, dettCadenzaRev);
                    documentazioneDetail1.SetBindableData(null);
                }
            }
        }

        private void SetImages()
        {
            this.barButtonItemAdd.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Document_Add_24x24);
            this.barButtonItemModify.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Edit_24x24);
            this.barButtonItemDelete.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
        }

        private DialogResult OpenForEdit(RevisioneFDT revisione)
        {
            RevisioneEdit page = CreatePage<RevisioneEdit>();
            if (page != null)
            {
                page.SetFormTitle("Gestione della revisione");
                page.SetBindableData(revisione);

                DialogResult dr = DialogResult.OK;
                while (dr == DialogResult.OK)
                {
                    page.ErrorProviderRevisione.ClearErrors();

                    dr = page.BaseForm.ShowDialog(this, this.ReadOnlyControls);

                    if (dr == DialogResult.OK)
                    {
                        if (!page.ErrorProviderRevisione.HasErrors)
                            break;
                    }
                }
                return dr;
            }
            else
                return DialogResult.None;
        }

        private RevisioneFDT GetCurrentItem()
        {
            RevisioneFDT toReturn = null;

            if (this.bindingSourceRevisioni.Current != null)
            {
                toReturn = this.bindingSourceRevisioni.Current as RevisioneFDT;
            }
            return toReturn;
        }

        private RevisioneFDT ultimaRevisione(RevisioneFDT[] elencoRevisioni)
        {
            RevisioneFDT revisioneToReturn = null;

            if (elencoRevisioni != null)
            {
                if (elencoRevisioni.Length > 0)
                {
                    if (elencoRevisioni.Length == 1)
                    {
                        revisioneToReturn = elencoRevisioni[0];
                    }
                    else
                    {
                        int contatore = 0;
                        DateTime dataRif = DateTime.MinValue;
                        int indiceRev = -1;

                        foreach (RevisioneFDT rev in elencoRevisioni)
                        {
                            if (rev.DataConclusione.HasValue)
                            {
                                if (rev.DataConclusione.Value > dataRif)
                                {
                                    dataRif = rev.DataConclusione.Value;
                                    indiceRev = contatore;
                                }
                            }
                            contatore++;
                        }

                        if (indiceRev > -1)
                        {
                            revisioneToReturn = elencoRevisioni[indiceRev];
                        }
                    }
                }
            }

            return revisioneToReturn;
        }

        private void CalcolaAnnoRiferimento(RevisioneFDT item)
        {
            if (itemCoop != null && itemCoop.RegistroCooperativa != null)
            {
                int anniRif = 0;
                if (dettCadenzaRev != null)
                {
                    if (dettCadenzaRev.Dettaglio.Tempi.HasValue)
                    {
                        anniRif = dettCadenzaRev.Dettaglio.Tempi.Value;
                    }
                }

                if (itemCoop.RegistroCooperativa.Revisioni != null &&
                    itemCoop.RegistroCooperativa.Revisioni.Length > 0)
                {
                     // + revisioni --> Prendere come riferimento l'anno di revisione dell'ultima revisione
                     RevisioneFDT rev = ultimaRevisione(itemCoop.RegistroCooperativa.Revisioni);
                     if (rev != null)
                     {
                         item.AnnoRevisione = rev.AnnoRevisione + anniRif;
                     }
                }
                else
                {
                    //1 revisione --> Prendere come riferimento la data di costituzione
                    if (itemCoop.RegistroCooperativa.DataCostituzione.HasValue)
                        item.AnnoRevisione = itemCoop.RegistroCooperativa.DataCostituzione.Value.Year + anniRif;
                }
            }
        }

        private void AddRevisione()
        {
            RevisioneFDT item = new RevisioneFDT();
            item.IdRegistro = (item != null) ? itemCoop.RegistroCooperativa.IdRegistro : -1;
            CalcolaAnnoRiferimento(item);

            if (OpenForEdit(item) == DialogResult.OK)
            {
                item.Status = ObjectStatus.ToInsert;

                //if (item != null && item.IdRevisione > 0)
                //{
                    gridViewRevisions.BeginDataUpdate();
                    itemCoop.RegistroCooperativa.AddRevisione(item);
                    this.bindingSourceRevisioni.DataSource = itemCoop.RegistroCooperativa.Revisioni;
                    gridViewRevisions.EndDataUpdate();

                    SetVisibilityBarButton(GetCurrentItem());
                //}
                //else
                //{
                //    ShowProblemsMessage();
                //}
            }
        }

        private void ModifyRevisione()
        {
            RevisioneFDT item = GetCurrentItem();

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
                            this.bindingSourceRevisioni.EndEdit();
                            gridViewRevisions.RefreshData();
                        }
                        else
                        {
                            this.bindingSourceRevisioni.CancelEdit();
                            ShowProblemsMessage();
                        }
                    }
                    else
                    {
                        item.CancelEdit();
                        this.bindingSourceRevisioni.CancelEdit();
                    }
                }
            }
        }

        private void DeleteRevisione()
        {
            RevisioneFDT item = GetCurrentItem();

            if (item != null)
            {
                if (ShowConfirmMessage("Cancellazione", "Confermi la cancellazione dell'elemento selezionato?", string.Empty) == DialogResult.Yes)
                {
                    //item.Status = ObjectStatus.ToCancel;
                    //this.bindingSourceRevisioni.EndEdit();
                    //gridViewRevisions.RefreshData();
                    if (item.IdRevisione > 0)
                    {
                        item.Status = ObjectStatus.ToCancel;

                        if (item.RevisioniIncarichi != null &&
                            item.RevisioniIncarichi.Length > 0)
                        {
                            foreach (RevisioneIncaricoFDT incarico in item.RevisioniIncarichi)
                            {
                                incarico.Status = ObjectStatus.ToCancel;
                            }
                           
                        }

                        if (item.Liquidazioni != null &&
                           item.Liquidazioni.Length > 0)
                        {
                            foreach (CompensoLiquidazioneFDT liq in item.Liquidazioni)
                            {
                                liq.Status = ObjectStatus.ToCancel;
                            }

                        }

                        incaricoLiquidazioneDetail1.ResetBindings();
                    }
                    else
                    {
                        RevisioneFDT[] listActual = this.bindingSourceRevisioni.DataSource as RevisioneFDT[];

                        if (listActual != null)
                        {
                            List<RevisioneFDT> lTemp = new List<RevisioneFDT>();
                            foreach (RevisioneFDT ind in listActual)
                            {
                                if (ind != item)
                                {
                                    lTemp.Add(ind);
                                }
                            }
                            if (itemCoop != null && itemCoop.RegistroCooperativa != null)
                            {
                                itemCoop.RegistroCooperativa.Revisioni = lTemp.ToArray();
                                this.bindingSourceRevisioni.DataSource = itemCoop.RegistroCooperativa.Revisioni;
                            }
                        }
                    }

                    gridViewRevisions.RefreshData();
                    SetVisibilityBarButton(item);
                }
            }
        }

        private void SetVisibilityBarButton(RevisioneFDT item)
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

        private void gridViewRevisions_ShowGridMenu(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs e)
        {
            RevisioneFDT item = GetCurrentItem();
            if (item != null)
            {
                GridView view = sender as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
                if (hitInfo.InRow)
                {
                    view.FocusedRowHandle = hitInfo.RowHandle;
                    popupMenuRevisione.ShowPopup(BarManager,
                            gridControlRevisions.PointToScreen(e.Point));
                }
            }
        }
    }
}
