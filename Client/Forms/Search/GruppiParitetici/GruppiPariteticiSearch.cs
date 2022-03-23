using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Client.Forms.Common;
using OeF.Utility;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.Services;

namespace it.dedagroup.GVC.Client.Forms.Search.GruppiParitetici
{
    public partial class GruppiPariteticiSearch : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        
        private Expression query = null;

        public GruppiPariteticiSearch()
        {
            InitializeComponent();
        }

        private void GruppiPariteticiSearch_Load(object sender, EventArgs e)
        {
            this.SetFormTitle("Ricerca gruppi paritetici");
                                        
            SetImages();
        }

        private void barButtonNuovoGruppo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           OpenGruppo(true);
        }

        private void simpleButtonRicerca_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search() 
        {

            this.bindingSourceGruppiParitetici.DataSource = null;

            if (DefineParameters())
            {
                GruppoPariteticoFDT[] lTemp = GVCSystemEngine.InvokeService<ICooperatives, GruppoPariteticoFDT[]>
                    (delegate()
                    {
                        return GVCSystemEngine.Cooperatives.GetListGruppiPariteticiBySearch(query);
                    },
                    true);

                if (lTemp != null)
                {
                    //this.lblResults.Text = "Risultati: " + lTemp.Length.ToString();

                    this.bindingSourceGruppiParitetici.DataSource = lTemp;

                    ////if (!NotToOpen)
                    ////{
                    //if (lTemp.Length == 1)
                    //{
                    //    OpenGruppo(lTemp[0]);
                    //}
                    ////}
                }
            }                      
        }

        private bool DefineParameters()
        {
            query = null;

            if ((dateEditDataAtto.DateTime != null) && (dateEditDataAtto.DateTime > DateTime.MinValue))
            {
                query &= (FieldName)SearchParameters.GRUPPO_PARITETICO_DATA_ATTO >= dateEditDataAtto.DateTime;
            }

            if ((dateEditTill.DateTime != null) && (dateEditTill.DateTime > DateTime.MinValue))
            {
                query &= (FieldName)SearchParameters.GRUPPO_PARITETICO_DATA_FINO_AL <= dateEditTill.DateTime;
            }

            if (!string.IsNullOrEmpty(textEditNumeroAtto.Text))
            {
                query &= (FieldName)SearchParameters.GRUPPO_PARITETICO_NUMERO_ATTO == textEditNumeroAtto.Text;
            }

            if (!string.IsNullOrEmpty(memoEditNote.Text))
            {
                query &= (FieldName)SearchParameters.GRUPPO_PARITETICO_NOTE == memoEditNote.Text;
            }

            return true;
        }

        private GruppoPariteticoFDT[] DummySearch()
        {
            GruppoPariteticoFDT[] results = new GruppoPariteticoFDT[3];
            for (int i = 0; i < results.Length; i++)
            {
                results[i] = new GruppoPariteticoFDT();
                results[i].IdGruppoParitetico = i;
                results[i].Note = "note " + i;
                results[i].DataAtto = DateTime.Today;
                for (int j = 0; j < 3; j++)
                {
                    CooperativaFDT coop = new CooperativaFDT();
                    coop.Denominazione = "test cooperativa " + j;
                    coop.RegistroCooperativa = new RegistroCooperativaFDT();
                    coop.RegistroCooperativa.IdRegistro = j;
                    results[i].AddCooperative(coop);
                    if (j == i)
                        results[i].IdDirigente = coop.RegistroCooperativa.IdRegistro;
                }
            }
            return results;
        }

        private void SetImages() 
        {
            this.barButtonNuovoGruppo.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Document_Add_24x24);
        }

        private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenGruppo(false);
        }

        private void OpenGruppo(Boolean isNew)
        {
            GruppiParitetici page = null;
            BaseForm baseForm = null;
            if (isNew)
            {
                CreatePage<GruppiParitetici>(this, PageActions.ShowMdiChild, out page, out baseForm);
                if (page != null)
                {
                    page.OnNewGruppo();
                }
            }
            else
            {
                GruppoPariteticoFDT selectedGroup = this.bindingSourceGruppiParitetici.Current as GruppoPariteticoFDT;
                selectedGroup = GVCSystemEngine.InvokeService<ICooperatives, GruppoPariteticoFDT>
                (delegate()
                {
                    return GVCSystemEngine.Cooperatives.GetGruppoParitetico(selectedGroup.IdGruppoParitetico);
                },
                true);
                if ((selectedGroup != null) && (selectedGroup.IdGruppoParitetico > 0))
                {
                    CreatePage<GruppiParitetici>(this, PageActions.ShowMdiChild, out page, out baseForm);
                    page.OnOpenGruppo(selectedGroup);
                }
            }
        }
    }
}
