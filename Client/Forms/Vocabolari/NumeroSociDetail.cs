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
    public partial class NumeroSociDetail : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {

        public override bool ReadOnlyControls
        {
            get
            {
                return base.ReadOnlyControls;
            }
            set
            {
                base.ReadOnlyControls = false;

                this.barButtonItemAdd.Enabled = 
                    this.barButtonItemDelete.Enabled = 
                    this.barButtonItemModify.Enabled = true;
            }
        }

        private Dictionary<int, List<ControlloNumeroSociFDT>> corrControlloSoci = null;
        List<ControlloNumeroSociFDT> listDictionaries = new List<ControlloNumeroSociFDT>();
        private int currentParameterId = -1;
        private int currentIndex = -1;
        private string currentDescription = string.Empty;
        private string formTitle = string.Empty;
        private int tipologia = -1;

        public NumeroSociDetail()
        {
            InitializeComponent();

            if (!this.DesignMode)
            {
                SetImages();
            }
        }

        private void SetImages()
        {
            this.barButtonItemAdd.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Document_Add_24x24);
            this.barButtonItemModify.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Edit_24x24);
            this.barButtonItemDelete.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
        }

        public void SetBindableData(int tipo)
        {
            corrControlloSoci = new Dictionary<int, List<ControlloNumeroSociFDT>>();

            switch (tipo)
            {
                case TipoControlloNumeroSoci.PER_CATEGORIA:
                    formTitle = "Relazione categoria / numero soci";
                    tipologia = TipoControlloNumeroSoci.PER_CATEGORIA;
                    break;
                case TipoControlloNumeroSoci.PER_FORMAGIURIDICA:
                    formTitle = "Relazione forma giuridica / numero soci";
                    tipologia = TipoControlloNumeroSoci.PER_FORMAGIURIDICA;
                    break;
                default:
                    break;
            }

            ControlloNumeroSociFDT[] listaControlli =
                    GVCSystemEngine.InvokeService<ICooperatives, ControlloNumeroSociFDT[]>
                        (delegate()
                        {
                            return GVCSystemEngine.Cooperatives.GetAllControlloSoci(tipo);
                        },
                        true);

            if (listaControlli != null)
            {
                List<ControlloNumeroSociFDT> tmpList = null;

                foreach (ControlloNumeroSociFDT item in listaControlli)
                {
                    if (corrControlloSoci.ContainsKey(item.IdParametro))
                    {
                        tmpList = corrControlloSoci[item.IdParametro];
                        if (tmpList != null)
                        {
                            corrControlloSoci.Remove(item.IdParametro);
                            tmpList.Add(item);
                            corrControlloSoci.Add(item.IdParametro, tmpList);
                        }
                    }
                    else
                    {
                        tmpList = new List<ControlloNumeroSociFDT>();
                        tmpList.Add(item);
                        corrControlloSoci.Add(item.IdParametro, tmpList);
                    }
                }
            }
        }

        public void UpdateBinding(int idParent, string description)
        {

            currentParameterId = -1;
            currentParameterId = idParent;
            listDictionaries.Clear();

            this.bindingSourceBaseNumeroSoci.DataSource = null;
            List<ControlloNumeroSociFDT> tmpList = null;
            if (corrControlloSoci != null)
            {
                corrControlloSoci.TryGetValue(idParent, out tmpList);
                if (tmpList != null)
                {
                    
                    listDictionaries.AddRange(tmpList);
                    this.bindingSourceBaseNumeroSoci.DataSource = tmpList.ToArray();
                }
            }
        }

        private void Add()
        {
            ControlloNumeroSociFDT item = new ControlloNumeroSociFDT();
            item.IdRelazione = -1;
            item.IdParametro = currentParameterId;
            item.Tipo = tipologia;

            VocabolariHelp.ManageNumeroSoci(item, VocabolariHelp.CurrentIndexUndefined,
                                        formTitle, 
                                        currentDescription, 
                                        //showCodice,
                                        //showAltroFlag, titoloAltroFlag, 
                                        gridViewNumeroSoci,
                                        bindingSourceBaseNumeroSoci, listDictionaries, CreatePage<NumeroSociEdit>());

            if (item.IdRelazione >= 0)
            {
                List<ControlloNumeroSociFDT> tmpList = null;
                if (corrControlloSoci != null)
                {
                    corrControlloSoci.TryGetValue(currentParameterId, out tmpList);
                    if (tmpList == null)
                        tmpList = new List<ControlloNumeroSociFDT>();
                    if (tmpList != null)
                    {
                        tmpList.Add(item);
                        listDictionaries.AddRange(tmpList);
                        corrControlloSoci.Remove(currentParameterId);
                        corrControlloSoci.Add(currentParameterId, tmpList);
                        this.bindingSourceBaseNumeroSoci.DataSource = tmpList.ToArray();
                    }
                }
            }
        }

        private void Modify()
        {
          
            ControlloNumeroSociFDT item = GetCurrentItem();
            VocabolariHelp.ManageNumeroSoci(item, currentIndex,
                                         formTitle,
                                         currentDescription,
                                        //showCodice,
                                        //showAltroFlag, titoloAltroFlag, 
                                         gridViewNumeroSoci,
                                         bindingSourceBaseNumeroSoci, listDictionaries, CreatePage<NumeroSociEdit>());
        }

        private void Delete()
        {
            ControlloNumeroSociFDT item = GetCurrentItem();
            if (VocabolariHelp.DeleteDetail(item, gridViewNumeroSoci, listDictionaries, bindingSourceBaseNumeroSoci))
            {
                if (corrControlloSoci != null)
                {
                    corrControlloSoci.Remove(currentParameterId);
                    corrControlloSoci.Add(currentParameterId, listDictionaries);
                    this.bindingSourceBaseNumeroSoci.DataSource = listDictionaries.ToArray();
                }
            }
        }

    

        private void HandleCurrentItemChanged()
        {
            //DizionarioFDT current = GetCurrentItem();
            //if (current != null)
            //{
            //}
        }

        private ControlloNumeroSociFDT GetCurrentItem()
        {
            ControlloNumeroSociFDT toReturn = null;
            if (this.bindingSourceBaseNumeroSoci.Current != null)
                toReturn = this.bindingSourceBaseNumeroSoci.Current as ControlloNumeroSociFDT;
            if (toReturn != null && listDictionaries != null)
            {
                currentIndex = listDictionaries.IndexOf(toReturn);
            }
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
    }
}
