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
using it.dedagroup.GVC.Repository.Common.Services;

namespace it.dedagroup.GVC.Client.Forms.Search.GruppiParitetici
{
    public partial class GruppiParitetici : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        private GruppoPariteticoFDT itemLocal;

        public GruppiParitetici()
        {
            InitializeComponent();
            SetImages();
            //RenderOnNew();
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
                    this.barButtonModifica.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    this.barButtonItemElimina.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    this.barButtonSalva.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    this.barButtonAnnulla.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    this.barButtonChiudi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                }
                else
                {
                    this.barButtonModifica.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    this.barButtonItemElimina.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    this.barButtonSalva.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    this.barButtonAnnulla.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    this.barButtonChiudi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
                this.cooperativeGruppoParitetico1.ReadOnlyControls = value;
                this.gruppoPariteticoHeader1.ReadOnlyControls = value;
                base.ConfirmCancel = !value;
            }
        }

        private void SetImages()
        {
            this.barButtonModifica.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Edit_24x24);
            this.barButtonItemElimina.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
            this.barButtonSalva.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Disk_Blue_24x24);            
            this.barButtonAnnulla.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Undo_24x24);
            this.barButtonChiudi.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Exit_24x24);
        }

        private void GruppiParitetici_Load(object sender, EventArgs e)
        {
         //   this.SetFormTitle("Gruppi paritetici");
         //   this.ReadOnlyControls = true;
          //  OnNewGruppo();
        }

        private void barButtonModifica_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            itemLocal.BeginEdit();
            this.ReadOnlyControls = false;
        }

        private void barButtonSalva_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gruppoPariteticoHeader1.ChangeFocus();

            if (!this.gruppoPariteticoHeader1.ErrorProviderGruppoParitetico.HasErrors)
            {
                this.gruppoPariteticoHeader1.EndEdit();
                this.cooperativeGruppoParitetico1.EndEdit();

                itemLocal = GVCSystemEngine.InvokeService<ICooperatives, GruppoPariteticoFDT>
                       (delegate()
                       {
                           return GVCSystemEngine.Cooperatives.SaveGruppoParitetico(itemLocal);
                       },
                       true);
                this.ReadOnlyControls = true;

                this.SetBindableData(itemLocal);
            }
        }

        private void barButtonAnnulla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (itemLocal.IdGruppoParitetico > 0)
            {
                this.gruppoPariteticoHeader1.CancelEdit();
                this.cooperativeGruppoParitetico1.CancelEdit();
                this.cooperativeGruppoParitetico1.ResetBindibleData();

                this.ReadOnlyControls = true;
            }
            else
            {
                MyClose();
            }
        }

        private void barButtonChiudi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MyClose();
        }

        public void SetBindableData(GruppoPariteticoFDT item)
        {
            itemLocal = item;
            this.cooperativeGruppoParitetico1.SetBindableData(itemLocal);
            this.gruppoPariteticoHeader1.SetBindableData(itemLocal);
        }

        private void MyClose()
        {
            Form f = this.FindForm();
            if (f != null)
                f.Close();
        }

        public void OnNewGruppo() 
        {
            this.SetFormTitle("Nuovo gruppo paritetico");
            this.ReadOnlyControls = false;
            GruppoPariteticoFDT newGruppo = new GruppoPariteticoFDT();
            newGruppo.Cooperative = new CooperativaFDT[0];
            newGruppo.DataAtto = DateTime.Today;
            SetBindableData(newGruppo);
        }

        public void OnOpenGruppo(GruppoPariteticoFDT item) 
        {
            this.SetFormTitle("GP " + item.IdGruppoParitetico.ToString());
            this.ReadOnlyControls = true;
            SetBindableData(item);
        }

        private void barButtonItemElimina_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {             
             if (itemLocal != null)
             {
                 if (ShowConfirmMessage("GVC", "Confermi la cancellazione del gruppo paritetico aperto?", string.Empty) == DialogResult.Yes)
                 {
                     GVCSystemEngine.InvokeService<ICooperatives, Boolean>
                             (delegate()
                             {
                                 return GVCSystemEngine.Cooperatives.DeleteGruppoParitetico(itemLocal);
                             },
                             true);

                     MyClose();
                 }
             }
        }
    }

}

