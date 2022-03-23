using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using it.dedagroup.GVC.Repository.Common.RicercheWrapper;
using it.dedagroup.GVC.Repository.Common.Services;
using it.dedagroup.GVC.Repository.Common.FDT;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using it.dedagroup.GVC.Repository.Common.Configurations;
using System.Collections;

namespace it.dedagroup.GVC.Client.Forms.Search.ConfrontoParix
{
    public partial class ConfrontoParix : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        private bool active;
        private int selectedPage;
        private CooperativaRicercaFDT[] gvcActiveCoops;
        private CooperativaRicercaFDT[] parixActiveCoops;

        private CooperativaRicercaFDT[] gvcClosedCoops;
        private CooperativaRicercaFDT[] parixClosedCoops;

        private CooperativaRicercaFDT[] activeCorrisponding;
        private CooperativaRicercaFDT[] activeMissingGvc;
        private CooperativaRicercaFDT[] activeMissingParix;

        private CooperativaRicercaFDT[] closedCorrisponding;
        private CooperativaRicercaFDT[] closedMissingGvc;
        private CooperativaRicercaFDT[] closedMissingParix;
        

        public ConfrontoParix()
        {
            InitializeComponent();
        }

        private void ConfrontoParix_Load(object sender, EventArgs e)
        {
            SetFormTitle("Confronta con Parix");

            this.bindingSourceStatoCooperativa.DataSource = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.STATI_ISCRIZIONE);

            dateEditClosedFrom.DateTime = new DateTime();
            dateEditClosedFrom.DateTime = dateEditClosedFrom.DateTime.AddYears(1899);
            active = true;
            selectedPage = 0;
            RetrieveGvcActiveCoops();
            RetrieveGvcClosedCoops();
        }

        private void btnActiveStartComp_Click(object sender, EventArgs e)
        {
            RetrieveParixActiveCoops();
            CompareCooperatives();
            SetActiveDataSources(); 
        }

        private void btnClosedStartComp_Click(object sender, EventArgs e)
        {
            RetrieveParixClosedCoops();
            CompareCooperatives();
            SetClosedDataSources();
        }

        private void RetrieveGvcActiveCoops() 
        {
            gvcActiveCoops = GVCSystemEngine.InvokeService<ICooperatives, CooperativaRicercaFDT[]>(
                      delegate { return GVCSystemEngine.Cooperatives.GetListActiveGvcCooperatives(); },
                      true);
        }

        private void RetrieveParixActiveCoops()
        {
            Boolean exception = false;
            parixActiveCoops = GVCSystemEngine.InvokeService<ICooperatives, CooperativaRicercaFDT[]>(
                      delegate { return GVCSystemEngine.Cooperatives.GetListActiveParixCooperatives(out exception); },
                      true);
            if (exception)
            {
                ShowInformationMessage("Impossibile recuperare i dati da Parix", "Impossibile raggiungere il servizio. Verificare lo stato della conessione");
                gvcActiveCoops = null;
                parixActiveCoops = null;
            }
        }


        private void RetrieveGvcClosedCoops()
        {
            gvcClosedCoops = GVCSystemEngine.InvokeService<ICooperatives, CooperativaRicercaFDT[]>(
                     delegate { return GVCSystemEngine.Cooperatives.GetListClosedGvcCooperatives(dateEditClosedFrom.DateTime); },
                     true);
        }

        private void RetrieveParixClosedCoops()
        {
            Boolean exception = false;
            parixClosedCoops = GVCSystemEngine.InvokeService<ICooperatives, CooperativaRicercaFDT[]>(
                      delegate { return GVCSystemEngine.Cooperatives.GetListClosedParixCooperatives(dateEditClosedFrom.DateTime, out exception); },
                      true);
            if (exception)
            {
                ShowInformationMessage("Impossibile recuperare i dati da Parix", "Impossibile raggiungere il servizio. Verificare lo stato della conessione");
                gvcClosedCoops = null;
                parixClosedCoops = null;
            }
        }

        private void SetActiveDataSources() 
        {
            this.bindingSourceActiveCorrisponding.DataSource = activeCorrisponding;
            this.bindingSourceActiveMissingGvc.DataSource = activeMissingGvc;
            this.bindingSourceActiveMissingPx.DataSource = activeMissingParix;
            SetResultActive(selectedPage);
        }

        private void SetClosedDataSources()
        {
            this.bindingSourceCloCorrisponding.DataSource = closedCorrisponding;
            this.bindingSourceCloMissingGvc.DataSource = closedMissingGvc;
            this.bindingSourceCloMissingPx.DataSource = closedMissingParix;
            SetResultActive(selectedPage);
        }

        private void CompareCooperatives() 
        {
            CooperativaRicercaFDT[] gvcCoops;
            CooperativaRicercaFDT[] parixCoops;

            if (active)
            {
                gvcCoops = gvcActiveCoops;
                parixCoops = parixActiveCoops;
            }
            else
            {
                gvcCoops = gvcClosedCoops;
                parixCoops = parixClosedCoops;
            }

            List<CooperativaRicercaFDT> corrispondingLst = new List<CooperativaRicercaFDT>();
            List<CooperativaRicercaFDT> missingGvcLst = new List<CooperativaRicercaFDT>();
            List<CooperativaRicercaFDT> missingParixLst = new List<CooperativaRicercaFDT>();

            int gi = 0;
            int pi = 0;
            CooperativaRicercaFDT g;
            CooperativaRicercaFDT p;

            if (gvcCoops == null && parixCoops == null)
                return;
            if (gvcCoops == null || gvcCoops.Length == 0)
            {
                if (active)
                    activeMissingGvc = parixCoops;
                else
                    closedMissingGvc = parixCoops;
                return;
            }
            if (parixCoops == null || parixCoops.Length == 0)
            {
                if (active)
                    activeMissingParix = gvcCoops;
                else
                    closedMissingParix = gvcCoops;
                return;
            }
            if (gvcCoops.Length == 0 && parixCoops.Length == 0)
                return;

            IEnumerable<CooperativaRicercaFDT> query = parixCoops.OrderBy(cooperativa => cooperativa.NumeroReaNumeric);
            parixCoops = query.ToArray();

           
            while (gi < gvcCoops.Length && pi < parixCoops.Length)
            {
                g = gvcCoops[gi];
                p = parixCoops[pi];

                if (g.NumeroReaNumeric > p.NumeroReaNumeric)
                {
                    if (active)
                    {
                        if (gvcClosedCoops.Contains(p, new CooperativaComparer()))
                            p.Cancellata = true;
                        else
                            p.Cancellata = false;
                    }
                    else {
                        if (gvcActiveCoops.Contains(p, new CooperativaComparer()))
                            p.Cancellata = true;
                        else
                            p.Cancellata = false;
                    
                    }
                    missingGvcLst.Add(p);
                    pi++;
                }
                else if (g.NumeroReaNumeric < p.NumeroReaNumeric)
                {
                    missingParixLst.Add(g);
                    gi++;
                }
                else
                {
                    if (!active) 
                    {
                        if (!ClosureDatesCoincide(g.DataCancellazioneRIRegistro, p.DataCancellazioneRIRegistro)) 
                        {
                            g.Segnalazioni = GetChanges(g, p);
                            g.DataCancellazioneRINazionale = p.DataCancellazioneRIRegistro;
                            corrispondingLst.Add(g); 
                        }
                    }else{
                        g.Segnalazioni = GetChanges(g, p);
                        corrispondingLst.Add(g);   
                    }
                    gi++;
                    pi++;
                }
            }

            for (int i = pi; i < parixCoops.Length; i++)
                missingGvcLst.Add(parixCoops[i]);

            for (int i = gi; i < gvcCoops.Length; i++)
                missingParixLst.Add(gvcCoops[i]);

            if (active)
            {
                activeCorrisponding = corrispondingLst.ToArray();
                activeMissingGvc = missingGvcLst.ToArray();
                activeMissingParix = missingParixLst.ToArray();
            }
            else {
                closedCorrisponding = corrispondingLst.ToArray();
                closedMissingGvc = missingGvcLst.ToArray();
                closedMissingParix = missingParixLst.ToArray();
            }
        }

        private List<SegnalazioneFDT> GetChanges(CooperativaRicercaFDT gvcCoop, CooperativaRicercaFDT parixCoop) 
        {
            List<SegnalazioneFDT> segs = new List<SegnalazioneFDT>();
            if (!gvcCoop.Denominazione.Trim().ToLower().Equals(parixCoop.Denominazione.Trim().ToLower()))
                segs.Add(new SegnalazioneFDT() { IdTipoSegnalazione = it.dedagroup.GVC.Repository.Common.Configurations.TipoSegnalazione.DENOMINAZIONE, Descrizione = parixCoop.Denominazione });
            if (!gvcCoop.CodiceFiscale.Trim().ToLower().Equals(parixCoop.CodiceFiscale.Trim().ToLower()))
                segs.Add(new SegnalazioneFDT() { IdTipoSegnalazione = it.dedagroup.GVC.Repository.Common.Configurations.TipoSegnalazione.CODICE_FISCALE, Descrizione = parixCoop.CodiceFiscale });
            
            if (segs.Count > 0)
                return segs;
            return null;
        }

       
        private void gridView1_CustomRowCellEdit_1(object sender, CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName != colCodiceFiscale.FieldName
               && e.Column.FieldName != colDenominazione.FieldName)
                return;
            GridView gv = (DevExpress.XtraGrid.Views.Grid.GridView)sender;
            CooperativaRicercaFDT coop = gv.GetRow(e.RowHandle) as CooperativaRicercaFDT;
            if (coop.Segnalazioni != null)
            {
                if (e.Column.FieldName.Equals(colDenominazione.FieldName))
                    foreach (SegnalazioneFDT seg in coop.Segnalazioni)
                        if (seg.IdTipoSegnalazione == it.dedagroup.GVC.Repository.Common.Configurations.TipoSegnalazione.DENOMINAZIONE)
                        {
                            e.RepositoryItem = repositoryItemButtonEdit1;
                            return;
                        }

                if (e.Column.FieldName.Equals(colCodiceFiscale.FieldName))
                    foreach (SegnalazioneFDT seg in coop.Segnalazioni)
                        if (seg.IdTipoSegnalazione == it.dedagroup.GVC.Repository.Common.Configurations.TipoSegnalazione.CODICE_FISCALE)
                        {
                            e.RepositoryItem = repositoryItemButtonEdit2;
                            return;
                        }
            }   
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            CooperativaRicercaFDT current = GetCurrentItem();
            it.dedagroup.GVC.Client.Forms.Aggiornamenti.StringComparer comp = this.CreatePage<Aggiornamenti.StringComparer>();
            String parixDen = "";
            foreach (SegnalazioneFDT seg in current.Segnalazioni)
            if (seg.IdTipoSegnalazione == it.dedagroup.GVC.Repository.Common.Configurations.TipoSegnalazione.DENOMINAZIONE)
            {
                parixDen = seg.Descrizione;
                break;
            }
            comp.SetComparables(new object[] { current.Denominazione }, new object[] { parixDen });
            comp.BaseForm.ShowDialog(this, true);
        }


        private CooperativaRicercaFDT GetCurrentItem()
        {
            CooperativaRicercaFDT toReturn = null;
            if (active)
                toReturn = this.bindingSourceActiveCorrisponding.Current as CooperativaRicercaFDT;
            else
                toReturn = this.bindingSourceCloCorrisponding.Current as CooperativaRicercaFDT;
            return toReturn;
        }

        private void repositoryItemButtonEdit2_Click(object sender, EventArgs e)
        {
            CooperativaRicercaFDT current = GetCurrentItem();
            it.dedagroup.GVC.Client.Forms.Aggiornamenti.StringComparer comp = this.CreatePage<Aggiornamenti.StringComparer>();
            String parixCod = "";
            foreach (SegnalazioneFDT seg in current.Segnalazioni)
                if (seg.IdTipoSegnalazione == it.dedagroup.GVC.Repository.Common.Configurations.TipoSegnalazione.CODICE_FISCALE)
                {
                    parixCod = seg.Descrizione;
                    break;
                }
            comp.SetComparables(new object[] { current.CodiceFiscale }, new object[] { parixCod });
            comp.BaseForm.ShowDialog(this, true);
        }

        private bool ClosureDatesCoincide(DateTime? dategvc, DateTime? dateparix) 
        {
            if (!dategvc.HasValue && !dateparix.HasValue)
                return true;
            if (!dategvc.HasValue && dateparix.HasValue)
                return false;
            if (dategvc.HasValue && !dateparix.HasValue)
                return false;
            if (dategvc == dateparix)
                return true;
            else
                return false;
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
           active = ((DevExpress.XtraTab.XtraTabControl)sender).SelectedTabPageIndex == 0 ? true : false;
           if (active)
               xtraTabControlClosed_SelectedPageChanged(xtraTabControlActive, e);
           else
               xtraTabControlClosed_SelectedPageChanged(xtraTabControlClosed, e);
            //SetResultActive(selectedPage);
        }

        private void SetResultActive(int selectedPage) 
        {
            if (active)
            {
               switch(selectedPage){
                   case 0:
                       if (activeCorrisponding != null)
                   lblResActive.Text = activeCorrisponding.Length.ToString();
                       break;
                   case 1:
                       if (activeMissingGvc != null)
                       lblResActive.Text = activeMissingGvc.Length.ToString();
                       break;
                   case 2:
                       if (activeMissingParix != null)
                       lblResActive.Text = activeMissingParix.Length.ToString();
                        break;
                }
            }
            else 
            {
                switch (selectedPage)
                {
                    case 0:
                        if (closedCorrisponding != null)
                        lblResCess.Text = closedCorrisponding.Length.ToString();
                        break;
                    case 1:
                        if (closedMissingGvc != null)
                        lblResCess.Text = closedMissingGvc.Length.ToString();
                        break;
                    case 2:
                        if (closedMissingParix != null)
                        lblResCess.Text = closedMissingParix.Length.ToString();
                        break;
                }
            }
        }

        private void xtraTabControlClosed_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            selectedPage = ((DevExpress.XtraTab.XtraTabControl)sender).SelectedTabPageIndex;
            SetResultActive(selectedPage);
        }

        private void gridView4_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            //if (e.Column.FieldName != gridColumnCancellata.FieldName)
            //    return;
            //GridView gv = (DevExpress.XtraGrid.Views.Grid.GridView)sender;
            //CooperativaRicercaFDT r = gv.GetRow(e.RowHandle) as CooperativaRicercaFDT;
            //if (!it.dedagroup.GVC.Repository.Common.Configurations.NotificationTypes.getApplicableTypes().Contains(r.IdTipoSegnalazione))
            //{
            //    e.RepositoryItem. = repositoryItemLookUpEdit1;
            //}
            //else
            //    e.RepositoryItem = repositoryItemCheckEdit1;
        }       
    }

    class CooperativaComparer : IEqualityComparer<CooperativaRicercaFDT>
    {

      
        #region IEqualityComparer<CooperativaRicercaFDT> Members

        bool  IEqualityComparer<CooperativaRicercaFDT>.Equals(CooperativaRicercaFDT x, CooperativaRicercaFDT y)
        {
            return x.NumeroReaNumeric == y.NumeroReaNumeric;
        }

        int  IEqualityComparer<CooperativaRicercaFDT>.GetHashCode(CooperativaRicercaFDT obj)
        {
            return -1;
        }

    #endregion
    }
}
