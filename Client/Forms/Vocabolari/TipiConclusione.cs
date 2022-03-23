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

namespace it.dedagroup.GVC.Client.Forms.Vocabolari
{
    public partial class TipiConclusione : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {

        private string tipoDizionario = DictionaryTypes.TIPI_CONCLUSIONE;
        private string formTitle = "Gestione tipi conclusione";
        private string titoloDettaglio = "Tipo conclusione";
        private Boolean showCodice = false;
        private Boolean showAltroFlag = false; 
        private string titoloAltroFlag = string.Empty;
        List<DizionarioFDT> listDictionaries = new List<DizionarioFDT>();
        private int currentIndex = -1;

        public TipiConclusione()
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
            DizionarioFDT[] listTmp = GVCSystemEngine.GetDizionarioByType(tipoDizionario);
            if (listTmp != null)
                listDictionaries.AddRange(listTmp);

            this.bindingSourceBaseDizionario.DataSource = listDictionaries.ToArray();
        }

        private void Add()
        {
            DizionarioFDT item = new DizionarioFDT(-1, tipoDizionario);
            VocabolariHelp.ManageItem(item, VocabolariHelp.CurrentIndexUndefined,
                                        formTitle, titoloDettaglio, showCodice,
                                        showAltroFlag, titoloAltroFlag, gridViewDizionario,
                                        bindingSourceBaseDizionario, listDictionaries, CreatePage<DizionarioEdit>());
        }

        private void Modify()
        {
            DizionarioFDT item = GetCurrentItem();
            VocabolariHelp.ManageItem(item, currentIndex,
                                      formTitle, titoloDettaglio, showCodice,
                                      showAltroFlag, titoloAltroFlag, gridViewDizionario,
                                      bindingSourceBaseDizionario, listDictionaries, CreatePage<DizionarioEdit>());
        }

        private void Delete()
        {
            DizionarioFDT item = GetCurrentItem();
            VocabolariHelp.Delete(item, gridViewDizionario, listDictionaries, bindingSourceBaseDizionario);
        }

        private void HandleCurrentItemChanged()
        {
            //DizionarioFDT current = GetCurrentItem();
            //if (current != null)
            //{
            //}
        }

        private DizionarioFDT GetCurrentItem()
        {
            DizionarioFDT toReturn = null;
            if (this.bindingSourceBaseDizionario.Current != null)
                toReturn = this.bindingSourceBaseDizionario.Current as DizionarioFDT;

            if (toReturn != null)
            {
                currentIndex = listDictionaries.IndexOf(toReturn);
            }

            return toReturn;
        }

        #region Event

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

        #endregion Event
    }
}
