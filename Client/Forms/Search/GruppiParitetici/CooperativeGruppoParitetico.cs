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
using DevExpress.XtraEditors.Repository;
using it.dedagroup.GVC.Repository.Common.Configurations;

namespace it.dedagroup.GVC.Client.Forms.Search.GruppiParitetici
{
    public partial class CooperativeGruppoParitetico : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        private GruppoPariteticoFDT itemLocal;
        private List<CooperativaFDT> lstTemp;
        private CooperativaFDT currentCoop;

        public CooperativeGruppoParitetico()
        {
            InitializeComponent();
            SetImages();
        }

        public override bool ReadOnlyControls
        {
            get
            {
                return base.ReadOnlyControls;
            }
            set
            {
                base.ReadOnlyControls = value;

                if (value)
                {
                    this.barButtonItemAggiungi.Enabled = false;
                    this.barButtonItemRimuovi.Enabled = false;
                    this.gridControl1.Enabled = false;
                }
                else
                {
                    this.barButtonItemAggiungi.Enabled = true;
                    this.barButtonItemRimuovi.Enabled = true;
                    this.gridControl1.Enabled = true;                }

                base.ConfirmCancel = !value;
            }
        }

        private void SetImages()
        {
            this.barButtonItemAggiungi.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Add_24x24);
            this.barButtonItemRimuovi.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
        }

        public void SetBindableData(GruppoPariteticoFDT item)
        {
            
            itemLocal = item;
            //itemLocal.WriteDirigente();
            CooperativaFDT itmCoop;
            lstTemp = new List<CooperativaFDT>();
            
            for (int i = 0; i < itemLocal.Cooperative.Length; i++)
            {
                itmCoop = new CooperativaFDT();
                itmCoop.IdTipoSoggetto = itemLocal.Cooperative[i].IdTipoSoggetto;
                itmCoop.IdSoggetto = itemLocal.Cooperative[i].IdSoggetto;
                itmCoop.Denominazione = itemLocal.Cooperative[i].Denominazione;
                itmCoop.RegistroCooperativa = new RegistroCooperativaFDT();
                itmCoop.RegistroCooperativa.IdRegistro = itemLocal.Cooperative[i].RegistroCooperativa.IdRegistro;
                itmCoop.RegistroCooperativa.Dirigente = itemLocal.Cooperative[i].RegistroCooperativa.Dirigente;
                lstTemp.Add(itmCoop);
            }

            this.bindingSourceCooperative.DataSource = itemLocal.Cooperative;
        }

        public void CancelEdit()
        {
            this.bindingSourceCooperative.CancelEdit();
            itemLocal.Cooperative = lstTemp.ToArray();
            this.bindingSourceCooperative.DataSource = itemLocal.Cooperative;
        }

        public void EndEdit()
        {
            this.bindingSourceCooperative.EndEdit();            
        }

        public void ResetBindibleData()
        {
            this.bindingSourceCooperative.ResetBindings(true);
            this.gridControl1.RefreshDataSource();
        }

        private void barButtonItemAggiungi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (SearchCooperative() && currentCoop != null)
            {
                if (itemLocal.Cooperative == null || itemLocal.Cooperative.Length == 0)
                    currentCoop.RegistroCooperativa.Dirigente = true;
                currentCoop.IdTipoSoggetto = 0;
                currentCoop.Status = ObjectStatus.ToInsert;
                itemLocal.AddCooperative(currentCoop);
                this.bindingSourceCooperative.DataSource = itemLocal.Cooperative;
            }
        }

        private void barButtonItemRimuovi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            currentCoop = bindingSourceCooperative.Current as CooperativaFDT;
            bool dirigenteRemoved = false;
            if (currentCoop != null) 
            {
                dirigenteRemoved = currentCoop.RegistroCooperativa.Dirigente;
//                itemLocal.RemoveCooperative(currentCoop);                
                currentCoop.Status = ObjectStatus.ToHide;
                
                this.bindingSourceCooperative.ResetBindings(false);
                this.gridView1.RefreshData();
            }
                        
            //if (this.bindingSourceCooperative.Current != null && dirigenteRemoved)
            //{
            //    (this.bindingSourceCooperative.Current as CooperativaFDT).RegistroCooperativa.Dirigente = true;
            //    (this.bindingSourceCooperative.Current as CooperativaFDT).Status = ObjectStatus.ToUpdate;
            //}
        }

        private Boolean SearchCooperative()
        {
            Boolean toReturn;

            CoopTemplateSearch page = CreatePageDialog<Search.CoopTemplateSearch>();

            toReturn = true;

            if (page != null)
            {
                page.BaseForm.StartPosition = FormStartPosition.CenterScreen;
                page.NotToOpen = true;
                DialogResult dr = DialogResult.OK;
                
                while (dr == DialogResult.OK)
                {
                    currentCoop = null;
                    dr = page.BaseForm.ShowDialog(null, false);
                    if (dr != DialogResult.OK)
                    {
                        toReturn = false;
                        break;
                    }

                    if (dr == DialogResult.OK)
                    {
                        toReturn = true;
                        currentCoop = page.SelectedItem;                        
                    }

                    if (toReturn && currentCoop != null && !itemLocal.IsCooperativeMember(currentCoop))
                    {
                        toReturn = true;
                        break;
                    }
                    else
                    {
                        toReturn = false;
                        ShowInformationMessage("Cooperativa fa già parte del gruppo", string.Empty);
                    }
                }
            }

            return toReturn;
        }

        private void repositoryItemCheckEdit2_CheckedChanged(object sender, EventArgs e)
        {
            int clickedRow = gridView1.GetSelectedRows()[0];
            CooperativaFDT selectedCoop = gridView1.GetRow(clickedRow) as CooperativaFDT;
            for (int i = 0; i < itemLocal.Cooperative.Length; i++) 
            {
                if (itemLocal.Cooperative[i].RegistroCooperativa.IdRegistro != selectedCoop.RegistroCooperativa.IdRegistro)
                    itemLocal.Cooperative[i].RegistroCooperativa.Dirigente = false;
                else
                    itemLocal.Cooperative[i].RegistroCooperativa.Dirigente = true;

                if ((itemLocal.Cooperative[i].Status != ObjectStatus.ToHide) && (itemLocal.Cooperative[i].Status != ObjectStatus.ToInsert))
                    itemLocal.Cooperative[i].Status = ObjectStatus.ToUpdate;
            }
            this.bindingSourceCooperative.ResetBindings(false);
        }
    }
}
