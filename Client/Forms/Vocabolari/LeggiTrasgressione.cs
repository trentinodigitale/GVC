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
    public partial class LeggiTrasgressione : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        List<LeggiTrasgressioneFDT> listDictionaries = new List<LeggiTrasgressioneFDT>();
        DizionarioFDT[] listaNature = null;

        public LeggiTrasgressione()
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
            LeggiTrasgressioneFDT[] listTmp = GVCSystemEngine.InvokeService<ICooperatives, LeggiTrasgressioneFDT[]>
                         (delegate() { return GVCSystemEngine.Cooperatives.GetLeggiSanzioni(); },
                         true);

            if (listTmp != null)
                listDictionaries.AddRange(listTmp);

            this.bindingSourceBaseDizionario.DataSource = listTmp;

            listaNature = GVCSystemEngine.GetDizionarioByType(DictionaryTypes.NATURA_TRASGRESSIONE);
            this.bindingSourceBaseNatura.DataSource = listaNature;
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
            LeggiTrasgressioneFDT item = new LeggiTrasgressioneFDT();

            if (OpenForEdit(item) == DialogResult.OK)
            {
                LeggiTrasgressioneFDT savedItem = Save(item);
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
            LeggiTrasgressioneFDT item = GetCurrentItem();

            if (OpenForEdit(item) == DialogResult.OK)
            {
                LeggiTrasgressioneFDT savedItem = Save(item);
                if (savedItem != null)
                {
                    item.EndEdit();
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
            LeggiTrasgressioneFDT item = GetCurrentItem();

            if (ShowConfirmMessage("Conferma operazione", "Confermi la cancellazione dell'elemento selezionato?", string.Empty) == DialogResult.Yes)
            {
                Boolean outcome =
                        GVCSystemEngine.InvokeService<ICooperatives, Boolean>
                        (delegate()
                        {
                            return GVCSystemEngine.Cooperatives.DeleteLeggi(item);
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

        private DialogResult OpenForEdit(LeggiTrasgressioneFDT item)
        {
            LeggiTrasgressioneEdit page = CreatePage<LeggiTrasgressioneEdit>();

            if (page != null)
            {
                page.SetBindableData(item, listaNature);
                page.SetFormTitle("Leggi trasgressione");

                DialogResult dr = DialogResult.OK;
                while (dr == DialogResult.OK)
                {
                    dr = page.BaseForm.ShowDialog();

                    if (dr == DialogResult.OK)
                    {
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
        }

        private LeggiTrasgressioneFDT GetCurrentItem()
        {
            LeggiTrasgressioneFDT toReturn = null;
            if (this.bindingSourceBaseDizionario.Current != null)
                toReturn = this.bindingSourceBaseDizionario.Current as LeggiTrasgressioneFDT;
            return toReturn;
        }

        public LeggiTrasgressioneFDT Save(LeggiTrasgressioneFDT item)
        {
            LeggiTrasgressioneFDT toReturn = GVCSystemEngine.InvokeService<ICooperatives, LeggiTrasgressioneFDT>
                        (delegate()
                        {
                            return GVCSystemEngine.Cooperatives.SaveLeggi(item);
                        },
                        true);

            return toReturn;
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Add();
        }

        private void barButtonItemModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modify();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Delete();
        }

        private void gridControlDizionario_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Modify();
        }


    }
}
