using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using OeF.Configurations;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Revisione
{
    public partial class IncaricoRevisioneDetail : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        #region Instance Variables (1)

        CooperativaFDT itemCoop = null;
        RevisioneFDT itemRev = null;
        DatiFDT dati = null;
        DizionarioFDT[] listaEsiti = null;
        DizionarioFDT dettCadenzaRev = null;

        public event EventHandler NuovoProcedimento;

        #endregion Instance Variables (1)

        #region Constructors (1)

        public IncaricoRevisioneDetail()
        {
            InitializeComponent();

            SetImages();

            EnableControlAutoSize(new object[] { this }, gridControlRevisionTask, 200);

        }

        #endregion Constructors (1)
        
        #region Event Handlers (3)

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddIncarico();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteIncarico();
        }

        private void gridControlRevisionTask_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifyIncarico();
        }

        private void barButtonItemModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ModifyIncarico();
        }

        private void incaricoRevisioneEdit_NuovoProcedimento(object sender, EventArgs e)
        {
            EventHandler temp = NuovoProcedimento;
            if (temp != null)
                NuovoProcedimento(null, new EventArgs());
        }

        #endregion Event Handlers (3)

        #region Public Methods (1)

        public void ResetBindings()
        {
            this.bindingSourceBaseIncarichi.ResetBindings(false);
        }

        public void SetBindableData(CooperativaFDT coop,
                                   RevisioneFDT revisione,
                                   DizionarioFDT[] listaEsitiRevisioni,
                                   DatiFDT d,
                                   DizionarioFDT dettCad)
        {
            itemCoop = coop;
            itemRev = revisione;

            if (itemRev != null && itemRev.RevisioniIncarichi != null)
            {
                this.bindingSourceBaseIncarichi.DataSource = itemRev.RevisioniIncarichi;
            }
            else
            {
                this.bindingSourceBaseIncarichi.DataSource = null;
            }

            listaEsiti = listaEsitiRevisioni;

            dettCadenzaRev = dettCad;
            dati = d;
        }

        #endregion Public Methods (1)

        #region Private Methods

        private void HandleCurrentItemChange()
        {
            if (this.bindingSourceBaseIncarichi.Current != null)
            {
                RevisioneIncaricoFDT inc = this.bindingSourceBaseIncarichi.Current as RevisioneIncaricoFDT;
                if (inc != null)
                {
                    SetVisibilityBarButton(inc);
                }
            }
        }

        private void SetImages()
        {
            this.barButtonItemAdd.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Document_Add_24x24);
            this.barButtonItemModify.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Edit_24x24);
            this.barButtonItemDelete.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
        }

        private DialogResult OpenForEdit(RevisioneIncaricoFDT item)
        {
            IncaricoRevisioneEdit page = CreatePage<IncaricoRevisioneEdit>();
            if (page != null)
            {
                page.NuovoProcedimento += new EventHandler(incaricoRevisioneEdit_NuovoProcedimento);

                page.SetFormTitle("Gestione dati dell'incarico");
                page.SetBindableData(itemRev, item, dati);

                DialogResult dr = DialogResult.OK;
                while (dr == DialogResult.OK)
                {
                    page.ErrorProviderIncarico.ClearErrors();

                    dr = page.BaseForm.ShowDialog(this, this.ReadOnlyControls);

                    if (dr == DialogResult.OK)
                    {
                        if (!page.ErrorProviderIncarico.HasErrors)
                            break;
                    }
                }
                return dr;
            }
            else
                return DialogResult.None;
        }

        private RevisioneIncaricoFDT GetCurrentItem()
        {
            RevisioneIncaricoFDT toReturn = null;

            if (this.bindingSourceBaseIncarichi.Current != null)
            {
                toReturn = this.bindingSourceBaseIncarichi.Current as RevisioneIncaricoFDT;
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
                            if (rev.DataConclusione.HasValue &&
                                rev.RevisioniIncarichi != null)
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

        private void CalcoloDateScadenza(RevisioneIncaricoFDT item)
        {
            if (itemCoop != null && itemCoop.RegistroCooperativa != null)
            {
                DateTime dataRif = DateTime.MinValue;

                if (itemCoop.RegistroCooperativa.Revisioni != null)
                {
                    if (itemCoop.RegistroCooperativa.Revisioni.Length == 1)
                    {
                        //1 revisione --> Prendere come riferimento la data di costituzione
                        if (itemCoop.RegistroCooperativa.DataCostituzione.HasValue)
                            dataRif = itemCoop.RegistroCooperativa.DataCostituzione.Value;
                    }
                    else
                    {
                        // + revisioni --> Prendere come riferimento la data di conclusione dell'ultima revisione
                        RevisioneFDT rev = ultimaRevisione(itemCoop.RegistroCooperativa.Revisioni);
                        if (rev != null)
                        {
                            if (rev.RevisioniIncarichi != null &&
                                rev.RevisioniIncarichi.Length > 0)
                            {
                                for (int i = 0; i <= rev.RevisioniIncarichi.Length-1; i++)
                                {
                                    if (rev.RevisioniIncarichi[i] != null)
                                    {
                                        if (rev.RevisioniIncarichi[i].DataScadenzaTeorica.HasValue)
                                        {
                                            dataRif = rev.RevisioniIncarichi[i].DataScadenzaTeorica.Value;
                                            break;
                                        }
                                    }
                                }
                            }
                        }                            
                    }

                    if (dataRif != DateTime.MinValue)
                    {
                        if (dettCadenzaRev != null)
                        {
                            if (dettCadenzaRev.Dettaglio.Tempi.HasValue)
                            {
                                //aggiungere intervallo cadenza revisione
                                item.DataScadenzaTeorica = dataRif.AddYears(dettCadenzaRev.Dettaglio.Tempi.Value);
                            }
                        }
                        else
                        {
                            item.DataScadenzaTeorica = dataRif;
                        }
                    }
                }
            }
        }

        private void AddIncarico()
        {
            if (itemRev != null && itemRev.Status < 100)
            {
                RevisioneIncaricoFDT item = new RevisioneIncaricoFDT();
                item.IdRevisione = itemRev.IdRevisione;
                item.IdRevisioneIncarico = -1;

                CalcoloDateScadenza(item);

                item.CompensoRevisore = new CompensoFDT();
                item.CompensoRevisore.PercentualeCNP = dati.PercentualeCNP;
                item.CompensoRevisore.PercentualeIVA = dati.PercentualeIVA;

                if (OpenForEdit(item) == DialogResult.OK)
                {
                    itemRev.Status = ObjectStatus.ToUpdate;
                    item.Status = ObjectStatus.ToInsert;

                    //if (item != null && item.IdIndirizzo > 0)
                    //{
                    gridViewRevisionTask.BeginDataUpdate();
                    itemRev.AddIncarico(item);
                    this.bindingSourceBaseIncarichi.DataSource = itemRev.RevisioniIncarichi;
                    gridViewRevisionTask.EndDataUpdate();
                    //}
                    //else
                    //{
                    //    ShowProblemsMessage();
                    //}
                    SetVisibilityBarButton(GetCurrentItem());
                }
            }
            else
            {
                ShowInformationMessage("Nessuna revisione selezionata", "Per inserire un incarico è necessario selezionare la relativa revisione");
            }
        }

        private void ModifyIncarico()
        {
            RevisioneIncaricoFDT item = GetCurrentItem();

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
                            item.Status = ObjectStatus.ToUpdate;
                            this.bindingSourceBaseIncarichi.EndEdit();
                            gridViewRevisionTask.RefreshData();
                        }
                        else
                        {
                            this.bindingSourceBaseIncarichi.CancelEdit();
                            ShowProblemsMessage();
                        }
                    }
                    else
                    {
                        item.CancelEdit();
                        this.bindingSourceBaseIncarichi.CancelEdit();
                    }
                }
            }
        }

        private void DeleteIncarico()
        {
            RevisioneIncaricoFDT item = GetCurrentItem();

            if (item != null)
            {
                if (ShowConfirmMessage("Cancellazione", "Confermi la cancellazione dell'elemento selezionato?", string.Empty) == DialogResult.Yes)
                {
                    //item.Status = ObjectStatus.ToCancel;
                    //this.bindingSourceBaseIncarichi.EndEdit();
                    //gridViewRevisionTask.RefreshData();
                    if (item.IdRevisioneIncarico > 0)
                    {
                        item.Status = ObjectStatus.ToCancel;
                    }
                    else
                    {
                        RevisioneIncaricoFDT[] listActual = this.bindingSourceBaseIncarichi.DataSource as RevisioneIncaricoFDT[];

                        if (listActual != null)
                        {
                            List<RevisioneIncaricoFDT> lTemp = new List<RevisioneIncaricoFDT>();
                            foreach (RevisioneIncaricoFDT ind in listActual)
                            {
                                if (ind != item)
                                {
                                    lTemp.Add(ind);
                                }
                            }
                            if (itemRev != null)
                            {
                                itemRev.RevisioniIncarichi = lTemp.ToArray();
                                this.bindingSourceBaseIncarichi.DataSource = itemRev.RevisioniIncarichi;
                            }
                        }
                    }

                    gridViewRevisionTask.RefreshData();
                    SetVisibilityBarButton(item);
                }
            }
        }

        private void SetVisibilityBarButton(RevisioneIncaricoFDT item)
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

        #endregion Private Methods (2)

        private void gridViewRevisionTask_ShowGridMenu(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs e)
        {
            RevisioneIncaricoFDT item = GetCurrentItem();
            if (item != null)
            {
                GridView view = sender as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
                if (hitInfo.InRow)
                {
                    view.FocusedRowHandle = hitInfo.RowHandle;
                    popupMenuIncarico.ShowPopup(BarManager,
                            gridControlRevisionTask.PointToScreen(e.Point));
                }
            }
        }

        private void bindingSourceBaseIncarichi_CurrentChanged(object sender, EventArgs e)
        {
            HandleCurrentItemChange();
        }
    }
}
