using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.Services;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;

namespace it.dedagroup.GVC.Client.Forms.Vocabolari
{
    public partial class Dati : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        List<DatiFDT> listDictionaries = new List<DatiFDT>();

        public Dati()
        {
            InitializeComponent();

            if (!this.DesignMode)
            {
                SetImages();

                SetBindableData();
            }
        }

        private void SetImages()
        {
            this.barButtonItemAdd.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Document_Add_24x24);
            this.barButtonItemModify.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Edit_24x24);
            this.barButtonItemDelete.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
        }

        private void SetBindableData()
        {
            DatiFDT listTmp = GVCSystemEngine.InvokeService<ICooperatives, DatiFDT>
                         (delegate() { return GVCSystemEngine.Cooperatives.GetDati(); },
                         true);

            if (listTmp != null)
                listDictionaries.Add(listTmp);

            this.bindingSourceBaseDizionario.DataSource = listDictionaries.ToArray();

            
        }

        private void SetVisibilityBarButton()
        {
            if (listDictionaries != null)
            {
                if (listDictionaries.Count > 0)
                {
                    barButtonItemAdd.Enabled = false;

                    barButtonItemDelete.Enabled =
                     barButtonItemModify.Enabled = true;
                }
                else
                {
                    barButtonItemAdd.Enabled = true;

                    barButtonItemDelete.Enabled =
                        barButtonItemModify.Enabled = false;
                }
            }
        }

        private void Add()
        {
            DatiFDT item = new DatiFDT();

            if (OpenForEdit(item) == DialogResult.OK)
            {
                DatiFDT savedItem = Save(item);
                if (savedItem != null)
                {
                    this.gridViewDizionario.BeginDataUpdate();

                    listDictionaries.Add(savedItem);

                    this.gridViewDizionario.EndDataUpdate();
                    this.gridViewDizionario.PostEditor();

                    bindingSourceBaseDizionario.DataSource = listDictionaries.ToArray();
                }
                else
                {
                    ShowProblemsMessage();
                }
            }
        }

        private void Modify()
        {
            DatiFDT item = GetCurrentItem();

            if (OpenForEdit(item) == DialogResult.OK)
            {
                DatiFDT savedItem = Save(item);
                if (savedItem != null)
                {
                    item.EndEdit();
                    //this.gridViewDizionario.BeginDataUpdate();

                    //listDictionaries.Remove(item);
                    //listDictionaries.Add(savedItem);

                    //this.gridViewDizionario.EndDataUpdate();
                    //this.gridViewDizionario.PostEditor();
                }
                else
                {
                    ShowProblemsMessage();
                }
            }
            else
            {
                item.CancelEdit();
            }
        }

        private void Delete()
        {
            DatiFDT item = GetCurrentItem();

            if (ShowConfirmMessage("Conferma operazione", "Confermi la cancellazione dell'elemento selezionato?", string.Empty) == DialogResult.Yes)
            {
                Boolean outcome =
                        GVCSystemEngine.InvokeService<ICooperatives, Boolean>
                        (delegate()
                        {
                            return GVCSystemEngine.Cooperatives.DeleteDati(item);
                        },
                        true);

                if (outcome)
                {
                    ShowInformationMessage("Cancellazione avvenuta con successo", string.Empty);

                    gridViewDizionario.BeginDataUpdate();

                    listDictionaries.Remove(item);
                    bindingSourceBaseDizionario.DataSource = listDictionaries.ToArray();

                    gridViewDizionario.EndDataUpdate();
                    gridViewDizionario.PostEditor();
                }
            }
        }

        private DialogResult OpenForEdit(DatiFDT item)
        {
            DatiEdit page = CreatePage<DatiEdit>();

            if (page != null)
            {
                page.SetBindableData(item);
                page.SetFormTitle("Dati generali");

                DialogResult dr = DialogResult.OK;
                while (dr == DialogResult.OK)
                {
                    dr = page.BaseForm.ShowDialog();

                    if (dr == DialogResult.OK)
                    {
                        //if (!er.HasErrors)
                            break;
                    }
                }
                return dr;
            }
            else
                return DialogResult.None;
        }

        private void HandleCurrentItemChanged()
        {
            SetVisibilityBarButton();

            //DizionarioFDT current = GetCurrentItem();
            //if (current != null)
            //{
            //}
        }

        private DatiFDT GetCurrentItem()
        {
            DatiFDT toReturn = null;
            if (this.bindingSourceBaseDizionario.Current != null)
                toReturn = this.bindingSourceBaseDizionario.Current as DatiFDT;
            return toReturn;
        }

       

        private void barButtonItemModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modify();
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Add(); 
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Delete();
        }

        private void bindingSourceBaseCadenza_CurrentItemChanged(object sender, EventArgs e)
        {
            HandleCurrentItemChanged();
        }

        private void gridControlCadenza_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Modify();
        }



        public DatiFDT Save(DatiFDT item)
        {
            DatiFDT toReturn = GVCSystemEngine.InvokeService<ICooperatives, DatiFDT>
                        (delegate()
                        {
                            return GVCSystemEngine.Cooperatives.SaveDati(item);
                        },
                        true);

            return toReturn;
        }

      
       
    }
}
