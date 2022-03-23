using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.Services;
using System.Reflection;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using it.dedagroup.GVC.Repository.Common.Configurations;

namespace it.dedagroup.GVC.Client.Forms.Aggiornamenti
{
    public partial class AggiornamentiMain : it.dedagroup.GVC.Client.Forms.Common.UserControlDialog
    {
        private CooperativaFDT dbCooperative;
        private CooperativaFDT updatedCooperative;
     

        public CooperativaFDT UpdatedCooperative
        {
            get { return updatedCooperative; }
            set { updatedCooperative = value; }
        }

        public CooperativaFDT DbCooperative
        {
            get { return dbCooperative; }
            set { dbCooperative = value; }
        }

        public AggiornamentiMain()
        {
            InitializeComponent();
            SegnalazioneFDT trickSeg = new SegnalazioneFDT();
            trickSeg.Descrizione = "Non applicabile";
            trickSeg.Apply = false;
            this.bindingSourceNotAppliable.DataSource = new SegnalazioneFDT[] { trickSeg };
        }

        public void SetAggiornamentiToCoop() 
        {
            if (dbCooperative.Segnalazioni == null) 
            {
                SegnalazioneFDT[] segnalazioni = GVCSystemEngine.InvokeService<ICooperatives, SegnalazioneFDT[]>(
                    delegate { return GVCSystemEngine.Cooperatives.GetListSegnalazioniByIdRegistro(dbCooperative.RegistroCooperativa.IdRegistro); },
                    true);
                if (segnalazioni != null && segnalazioni.Length > 0)
                {
                    dbCooperative.Segnalazioni = new List<SegnalazioneFDT>(segnalazioni);
                    
                    AggiornamentoFDT aggiornamento = GVCSystemEngine.InvokeService<it.dedagroup.GVC.Repository.Common.Services.ICooperatives, AggiornamentoFDT>(
                    delegate { return GVCSystemEngine.Cooperatives.GetAggiornamentoByNrRea(Convert.ToInt32(dbCooperative.RegistroCooperativa.NumeroREA)); },true);

                    if (aggiornamento != null)
                        dbCooperative.Aggiornamento = aggiornamento;
                    else 
                    {
                        ShowInformationMessage("Errore: Cooperativa aggiornata cancellata dalla base dati", "Impossibile visualizzare ed applicare gli aggiornamenti");
                        colApply.OptionsColumn.AllowEdit = false;
                        colDetail.OptionsColumn.AllowEdit = false;
                        colVisible.OptionsColumn.AllowEdit = false;
                    }

                }
            }
            this.bindingSourceSegnalazioni.DataSource = dbCooperative.Segnalazioni;
            
        }

        private object[] GetPropertyValues(int signalType, CooperativaFDT coop)    
        {
            Dictionary<int, String[]> properties = it.dedagroup.GVC.Repository.Common.Configurations.UpdatedAttributes.getUpdatedAttributes();
            String[] propertyNames = null;
            if (properties.ContainsKey(signalType))
                propertyNames = properties[signalType];
            else
                return null;

            object[] propertyValues = new object[propertyNames.Length];
            PropertyInfo property = null;
            Boolean registerProperty = false;
            

            for (int i = 0; i < propertyNames.Length; i++)
            {

                if (propertyNames[i].StartsWith("RegistroCooperativa."))
                {
                    property = typeof(RegistroCooperativaFDT).GetProperty(propertyNames[i].Replace("RegistroCooperativa.", ""));
                    registerProperty = true;
                }
                else
                {
                    property = typeof(CooperativaFDT).GetProperty(propertyNames[i]);
                    registerProperty = false;
                }

                if (property != null)
                {
                    if (!registerProperty)
                        propertyValues[i] = property.GetValue(coop, new object[] { });
                    else
                        propertyValues[i] = property.GetValue(coop.RegistroCooperativa, new object[] { });
                }
            }
            return propertyValues;
        }

        private void UpdateCooperativeProperty(int signalType, object[] propertyValues)
        {
            if (signalType == TipoSegnalazione.INDIRIZZO_SEDE)
                UpdateAddress(propertyValues);
            else
            {
                Dictionary<int, String[]> properties = it.dedagroup.GVC.Repository.Common.Configurations.UpdatedAttributes.getUpdatedAttributes();
                String[] propertyNames = null;
                if (properties.ContainsKey(signalType))
                    propertyNames = properties[signalType];
                else
                    return;

                PropertyInfo property = null;
                for (int i = 0; i < propertyNames.Length; i++)
                {
                    if (propertyNames[i].StartsWith("RegistroCooperativa."))
                    {
                        property = typeof(RegistroCooperativaFDT).GetProperty(propertyNames[i].Replace("RegistroCooperativa.", ""));
                        property.SetValue(updatedCooperative.RegistroCooperativa, propertyValues[i], new object[] { });
                    }
                    else
                    {
                        property = typeof(CooperativaFDT).GetProperty(propertyNames[i]);
                        property.SetValue(updatedCooperative, propertyValues[i], new object[] { });
                    }
                }
            }
        }

        private void UpdateAddress(object[] propertyValues) 
        {
            IndirizzoFDT actualHeadOffice = null;
            if(updatedCooperative.Indirizzi != null){
                for (int i = 0; i < updatedCooperative.Indirizzi.Length; i++) 
                {
                    if (updatedCooperative.Indirizzi[i].Sede)
                    {
                        actualHeadOffice = updatedCooperative.Indirizzi[i];
                        break;
                    }
                }
            }

            IndirizzoFDT updatedHeadOffice = null;
            IndirizzoFDT[] addressesUpdated = (IndirizzoFDT[])propertyValues[0];
            for (int i = 0; i < addressesUpdated.Length; i++)
            {
                if (addressesUpdated[i].Sede)
                {
                    updatedHeadOffice = addressesUpdated[i];
                    break;
                }
            }

            if (actualHeadOffice != null) 
            {
                actualHeadOffice.DataFine = DateTime.Today;
                actualHeadOffice.Sede = false;
            }

            updatedCooperative.AddIndirizzo(updatedHeadOffice);

        }

        private SegnalazioneFDT GetCurrentItem()
        {
            SegnalazioneFDT toReturn = null;
            if (this.bindingSourceSegnalazioni.Current != null)
                toReturn = this.bindingSourceSegnalazioni.Current as SegnalazioneFDT;
            return toReturn;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            SegnalazioneFDT eachNotification = null;
            updatedCooperative = dbCooperative;
            int nrOfApplied = 0;
            
            for (int i = 0; i < this.bindingSourceSegnalazioni.Count; i++)
            {
                eachNotification = this.bindingSourceSegnalazioni[i] as SegnalazioneFDT;
                if (eachNotification.Apply || !eachNotification.Visible)
                {
                    if (eachNotification.Apply)
                        UpdateCooperativeProperty(eachNotification.IdTipoSegnalazione, GetPropertyValues(eachNotification.IdTipoSegnalazione, dbCooperative.Aggiornamento.Cooperativa));

                    eachNotification.Visible = false;

                    if (updatedCooperative.SegnalazioniApplied == null)
                        updatedCooperative.SegnalazioniApplied = new List<SegnalazioneFDT>();
                    updatedCooperative.SegnalazioniApplied.Add(eachNotification);
                    nrOfApplied++;
                }
            }
            updatedCooperative.RemoveAppliedSeg();
            if (nrOfApplied == 0)
                updatedCooperative = null;
            this.ParentForm.DialogResult = DialogResult.OK;
        }

        private void repositoryItemButtonDetail_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SegnalazioneFDT segnalazione = GetCurrentItem();
            if (it.dedagroup.GVC.Repository.Common.Configurations.NotificationTypes.getComparableTypes().Contains(segnalazione.IdTipoSegnalazione))
            {
                ComparerPattern comparer = ComparerPattern.CreateComparer(segnalazione, this);
                if (comparer != null)
                {
                    comparer.SetComparables(GetPropertyValues(segnalazione.IdTipoSegnalazione, dbCooperative),
                                            GetPropertyValues(segnalazione.IdTipoSegnalazione, dbCooperative.Aggiornamento.Cooperativa));
                    comparer.BaseForm.ShowDialog(this, true);
                }
            }
            else
            {
                InfoDlg info = this.CreatePage<Aggiornamenti.InfoDlg>();
                String message = segnalazione.Descrizione;
                if (segnalazione.IdTipoSegnalazione == it.dedagroup.GVC.Repository.Common.Configurations.TipoSegnalazione.IMPRESA_ISCRITTA_CESSATA)
                   message += " il " + dbCooperative.Aggiornamento.Cooperativa.RegistroCooperativa.Cancellazione.DataCancRegistro.Value.ToShortDateString();
                 
                info.SetMessage(message);
                info.BaseForm.ShowDialog(this, true);
            }
        }

        private void gridView1_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName != colApply.FieldName)
                return;
            GridView gv = (DevExpress.XtraGrid.Views.Grid.GridView)sender;   
            SegnalazioneFDT r = gv.GetRow(e.RowHandle) as SegnalazioneFDT;
            if (!it.dedagroup.GVC.Repository.Common.Configurations.NotificationTypes.getApplicableTypes().Contains(r.IdTipoSegnalazione))
            {
                e.RepositoryItem = repositoryItemLookUpEdit1;
            }
            else
                e.RepositoryItem = repositoryItemCheckEdit1;
        }
    }
}
