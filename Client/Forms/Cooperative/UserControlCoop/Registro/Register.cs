using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common;
using it.dedagroup.GVC.Client.Forms.Common;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.Services;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Registro
{
    public partial class Registro : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        #region override

        public override bool ReadOnlyControls
        {
            get
            {
                return base.ReadOnlyControls;
            }
            set
            {
                base.ReadOnlyControls = true;

                if (this.barButtonItemViewStorico != null)
                    this.barButtonItemViewStorico.Enabled = true;

                if (this.barButtonItemLegaliRappresentanti != null)
                    this.barButtonItemLegaliRappresentanti.Enabled = true;

                if (!value)
                {
                    if (this.ScrollableContent != null &&
                        this.ScrollableContent.Controls != null &&
                        this.ScrollableContent.Controls.Count > 0)
                    {

                        foreach (Control item in this.ScrollableContent.Controls)
                        {
                            if (item is OeF.Forms.Controls.PanelControl)
                            {
                                if (item.Controls != null &&
                                    item.Controls.Count > 0)
                                {
                                    foreach (Control item1 in item.Controls)
                                    {
                                        ToggleControls(item1);
                                    }
                                }
                            }
                            else
                                ToggleControls(item);
                        }
                    }
                }

                this.documentazioneDetail1.ReadOnlyControls = value;
            }
        }

        private void ToggleControls(Control item)
        {
            if (item is CambioPosizione)
            {
                CambioPosizione cp = item as CambioPosizione;
                if (cp != null)
                    cp.ToggleButtons(true);
            }
            else if (item is IscrizioneComeCambio)
            {
                IscrizioneComeCambio icc = item as IscrizioneComeCambio;
                if (icc != null)
                    icc.ToggleButtons(true);
            }
            else if (item is Cancellazione)
            {
                it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Registro.Cancellazione canc = item as it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Registro.Cancellazione;
                if (canc != null)
                    canc.ToggleButtons(true);
            }
        }

        #endregion override
  
        #region Fields (1)

        private CooperativaFDT itemLocal = null;
        private Cancellazione cancellazione = null;

        public event EventHandler Cancellazione;
        public event EventHandler Iscrizione;
        public event EventHandler NuovoProcedimento;

		#endregion Fields 

		#region Constructors (1) 

        public Registro()
        {
            InitializeComponent();

            SetImages();

            if (positionChange1 != null)
            {
                positionChange1.ModifyIscrizione += new EventHandler(positionChange1_ModifyIscrizione);
                positionChange1.DeleteIscrizione += new EventHandler(positionChange1_DeleteIscrizione);
                positionChange1.NuovoProcedimento += new EventHandler(positionChange1_NuovoProcedimento);

            }
        }

		#endregion Constructors 

		#region Methods (13) 

        #region Cambio Posizione

        private void AddCambioPosizione()
        {
            CambioPosizioneFDT item = new CambioPosizioneFDT();
            item.IdRegistro = (item != null) ? itemLocal.RegistroCooperativa.IdRegistro : -1;
            item.IdCambioPosizione = -1;
            item.CategoriaSociale = -1;
            item.IdSottoCategoria = -1;
            //int idCP = cp.IdCambioPosizione;

            if (OpenForEditCambioPosizione(item) == DialogResult.OK)
            {
                if (SaveCambioPosizione(ref item, false, false))
                {
                    //List<CambioPosizioneFDT> listCP = new List<CambioPosizioneFDT>();
                    if (itemLocal != null && itemLocal.RegistroCooperativa != null)
                    {
                        itemLocal.RegistroCooperativa.AddCambioPosizione(item);
                        AddUserControlsCambiPosizione();
                        SetVisibilityBarButton();

                        UpdatePosizioneAttuale();
                    }
                }
                else
                {
                    ShowProblemsMessage();
                }
            }
        }

        private void AddUserControlsCambiPosizione()
        {
            this.panelControlCambiPosizione.Controls.Clear();

            if (itemLocal != null &&
                itemLocal.RegistroCooperativa != null &&
                itemLocal.RegistroCooperativa.CambioPosizioni != null)
            {
                int indexRegistration = 0;
                Boolean regSet = false;
                int indexForName = 0;
                CambioPosizione cp = null;
                for (int i = 0; i < itemLocal.RegistroCooperativa.CambioPosizioni.Length; i++)
                {
                    if (itemLocal.RegistroCooperativa.CambioPosizioni[i].Status >= ObjectStatus.ToHide)
                    {
                        if (!regSet)
                            indexRegistration++;
                        continue;
                    }
                    if (i == indexRegistration)
                    {
                        regSet = true;
                        continue;
                    }

                    indexForName++;
                    cp = new CambioPosizione();

                    cp.Name = String.Concat("Cambio_posizione_", (i).ToString());

                    cp.SetGroupBoxTitle(string.Concat("Cambio posizione ", indexForName));
                    cp.SetBindableData(itemLocal.RegistroCooperativa.CambioPosizioni[i]);
                    cp.ModifyCambioPosizione += new EventHandler(cp_ModifyCambioPosizione);
                    cp.DeleteCambioPosizione += new EventHandler(cp_DeleteCambioPosizione);
                    cp.NuovoProcedimento += new EventHandler(positionChange1_NuovoProcedimento);

                    this.panelControlCambiPosizione.Controls.Add(cp);
                    cp.Dock = DockStyle.Top;
                    cp.BringToFront();
                }
            }
        }

        private void UpdatePosizioneAttuale()
        {
            this.registrationActual1.SetBindableData(itemLocal);
        }

        void cp_DeleteCambioPosizione(object sender, EventArgs e)
        {
            if (sender != null)
            {
                CambioPosizione cp = sender as CambioPosizione;
                if (cp != null)
                {
                    CambioPosizioneFDT cpf = cp.bindingSourceBaseCambioPosizione.DataSource as CambioPosizioneFDT;
                    if (cpf != null)
                    {
                        int idToDelete = -1;

                     
                            string[] sss = cp.Name.Split('_');
                            if (sss != null && sss.Length == 3)
                                idToDelete = Convert.ToInt32(sss[2]);
                       



                        if (idToDelete > 0)
                        {
                            if (DeleteCambioPosizione(cpf))
                            {
                                if (itemLocal.RegistroCooperativa.CambioPosizioni != null)
                                {
                                    List<CambioPosizioneFDT> listCPTmp = new List<CambioPosizioneFDT>();
                                    for (int i = 0; i < itemLocal.RegistroCooperativa.CambioPosizioni.Length; i++)
                                    {
                                        if (i == idToDelete)
                                        {
                                            if (cpf.IdCambioPosizione > 0)
                                                listCPTmp.Add(cpf);
                                        }
                                        else
                                        {
                                            listCPTmp.Add(itemLocal.RegistroCooperativa.CambioPosizioni[i]);
                                        }
                                    }
                                    itemLocal.RegistroCooperativa.CambioPosizioni = listCPTmp.ToArray();
                                    AddUserControlsCambiPosizione();

                                    UpdatePosizioneAttuale();
                                    SetVisibilityBarButton();
                                }
                            }
                            else
                            {
                                ShowProblemsMessage();
                            }
                        }
                    }
                }
            }
        }

        private Boolean DeleteCambioPosizione(CambioPosizioneFDT cpf)
        {
            Boolean toReturn = true;

            if (ShowConfirmMessage("Cancellazione", "Confermi la cancellazione del cambio di posizione?", string.Empty) == DialogResult.Yes)
            {
                if (cpf.IdCambioPosizione > 0)
                    cpf.Status = ObjectStatus.ToCancel;
            }

            return toReturn;
        }

        void cp_ModifyCambioPosizione(object sender, EventArgs e)
        {
            if (sender != null)
            {
                CambioPosizione cp = sender as CambioPosizione;
                if (cp != null)
                {
                    CambioPosizioneFDT cpf = cp.bindingSourceBaseCambioPosizione.DataSource as CambioPosizioneFDT;
                    if (cpf != null)
                    {
                        if (OpenForEditCambioPosizione(cpf) == DialogResult.OK)
                        {
                            if (SaveCambioPosizione(ref cpf, true, false))
                            {
                                if (itemLocal.RegistroCooperativa.CambioPosizioni != null)
                                {
                                    List<CambioPosizioneFDT> listCPTmp = new List<CambioPosizioneFDT>();

                                    string theModifiedCambioPosizione = cp.Name;
                                    string localName = string.Empty;
                                    for (int i = 0; i < itemLocal.RegistroCooperativa.CambioPosizioni.Length; i++)
                                    {
                                        localName = string.Concat("Cambio_posizione_", (i).ToString());
                                        if (!localName.Equals(theModifiedCambioPosizione))
                                        {
                                            listCPTmp.Add(itemLocal.RegistroCooperativa.CambioPosizioni[i]);
                                        }
                                        else
                                        {
                                            listCPTmp.Add(cpf);
                                        }
                                    }

                                    itemLocal.RegistroCooperativa.CambioPosizioni = listCPTmp.ToArray();
                                    AddUserControlsCambiPosizione();

                                    UpdatePosizioneAttuale();
                                }
                            }
                            else
                            {
                                ShowProblemsMessage();
                            }
                        }
                    }
                }
            }
        }

        #endregion Cambio Posizione

        #region Cancellazione Registro

        private void AddCancellazione()
        {
            this.panelControlCancellazione.Controls.Clear();

            if (itemLocal != null &&
                itemLocal.RegistroCooperativa != null &&
                itemLocal.RegistroCooperativa.Cancellazione != null &&
                itemLocal.RegistroCooperativa.Cancellazione.Status < ObjectStatus.ToHide)
            {
                cancellazione = new Cancellazione();
                cancellazione.SetBindableData(itemLocal.RegistroCooperativa.Cancellazione);

                cancellazione.ModifyCancellazione += new EventHandler(cancellazione_ModifyCancellazione);
                cancellazione.DeleteCancellazione += new EventHandler(cancellazione_DeleteCancellazione);
                cancellazione.NuovoProcedimento += new EventHandler(positionChange1_NuovoProcedimento);
                
                this.panelControlCancellazione.Controls.Add(cancellazione);
                cancellazione.Dock = DockStyle.Top;

                UpdatePosizioneAttuale();

                EventHandler temp = Cancellazione;
                if (temp != null)
                    Cancellazione(true, new EventArgs());
            }
            else
            {
                EventHandler temp = Cancellazione;
                if (temp != null)
                    Cancellazione(false, new EventArgs());
            }
        }

        void cancellazione_DeleteCancellazione(object sender, EventArgs e)
        {
            if (ShowConfirmMessage("Confermi operazione", "Confermi la cancellazione dei dati?", string.Empty) == DialogResult.Yes)
            {
                if (itemLocal != null &&
                    itemLocal.RegistroCooperativa != null &&
                    itemLocal.RegistroCooperativa.Cancellazione != null)
                {
                    if (itemLocal.RegistroCooperativa.Cancellazione.IdCancellazione > 0)
                    {
                        itemLocal.RegistroCooperativa.Cancellazione.Status = ObjectStatus.ToCancel;
                    }
                    else
                    {
                        itemLocal.RegistroCooperativa.Cancellazione = null;
                    }
                }

                AddCancellazione();
                SetVisibilityBarButton();
            }
        }

        void cancellazione_ModifyCancellazione(object sender, EventArgs e)
        {
            if (this.cancellazione != null)
            {
                CancellazioneFDT c = this.cancellazione.bindingSourceBaseCancellazione.DataSource as CancellazioneFDT;
                if (c != null)
                {
                    DeleteCooperative(c);
                }
            }
        }

        private void DeleteCooperative(CancellazioneFDT c)
        {
            if (OpenForEditCancellazione(c) == DialogResult.OK)
            {
                if (SaveCancellazione(ref c, false))
                {
                    if (itemLocal != null && itemLocal.RegistroCooperativa != null)
                        itemLocal.RegistroCooperativa.Cancellazione = c;

                    AddCancellazione();
                    SetVisibilityBarButton();
                }
                else
                {
                    ShowProblemsMessage();
                }
            }
        }

        #endregion Cancellazione Registro

        #region Iscrizione Registro

        private void DeleteIscrizione()
        {
            if (ShowConfirmMessage("Conferma operazione",
                            "Confermi la cancellazione dei dati dell'iscrizione?", string.Empty) == DialogResult.Yes)
            {
                CambioPosizioneFDT iscr = this.positionChange1.bindingSourceBaseCambioPosizione.DataSource as CambioPosizioneFDT;
                if (iscr != null)
                {
                    iscr.Status = ObjectStatus.ToCancel;
                }

                DefineUserControlStructure();
            }
        }

        private void ModifyIscrizione()
        {
            if (this.positionChange1 != null)
            {
                if (OpenForEditIscrizione(itemLocal) == DialogResult.OK)
                {
                    if (SaveIscrizione())
                    {
                        itemLocal.EndEdit();
                        //this.positionChange1.bindingSourceBaseCambioPosizione.ResetBindings(false);
                        if (itemLocal != null &&
                            itemLocal.RegistroCooperativa != null)
                        {
                            positionChange1.SetBindableData(itemLocal.RegistroCooperativa.Iscrizione);
                            this.positionChange1.bindingSourceBaseCambioPosizione.ResetBindings(false);
                        }

                        UpdatePosizioneAttuale();

                        SetVisibilityBarButton();

                        EventHandler temp = Iscrizione;
                        if (temp != null)
                            Iscrizione(null, new EventArgs());
                    }
                    else
                    {
                        itemLocal.CancelEdit();

                        ShowProblemsMessage();
                    }
                }
                else
                {
                    positionChange1.bindingSourceBaseCambioPosizione.CancelEdit();
                }
            }
        }

        #endregion Iscrizione Registro



        public void SetBindableData(CooperativaFDT item)
        {
            itemLocal = item;

            DefineUserControlStructure();

            if (item.RegistroCooperativa != null)
            {
                this.documentazioneDetail1.SetBindableData(item.RegistroCooperativa);
                
                this.documentazioneFileSystemDetail1.SetBindableData(item, new int[] { 1, 6 });
            }
        }

        private void DefineUserControlStructure()
        {
            if (positionChange1 != null)
            {
                if (itemLocal != null && itemLocal.RegistroCooperativa != null)
                {
                    if (itemLocal.RegistroCooperativa.CambioPosizioni == null ||
                    itemLocal.RegistroCooperativa.CambioPosizioni.Length == 0)
                    {
                        CambioPosizioneFDT cpTemp = new CambioPosizioneFDT();
                       // cpTemp.IdSottoCategoria = -1;
                        cpTemp.CategoriaSociale = -1;
                        itemLocal.RegistroCooperativa.CambioPosizioni = new CambioPosizioneFDT[] { cpTemp };
                    }

                    //if (itemLocal.RegistroCooperativa.Iscrizione != null)
                    {
                        positionChange1.SetBindableData(itemLocal.RegistroCooperativa.Iscrizione);
                    }
                    //Boolean updated = false;
                    //foreach (CambioPosizioneFDT item in itemLocal.RegistroCooperativa.CambioPosizioni)
                    //{
                    //    if (item.Status < ObjectStatus.ToHide)
                    //    {
                    //        positionChange1.SetBindableData(item);
                    //        updated = true;
                    //        break;
                    //    }
                    //}
                    //if (!updated)
                    //    positionChange1.SetBindableData(null);
                }
            }

            UpdatePosizioneAttuale();

            AddUserControlsCambiPosizione();

            AddCancellazione();

            SetVisibilityBarButton();
        }

        #region OpenForEdit

        private DialogResult OpenForEditCambioPosizione(CambioPosizioneFDT cambioPosizione)
        {
            CambioPosizione page = CreatePageDialog<CambioPosizione>();
            if (page != null)
            {
                page.NuovoProcedimento += new EventHandler(page_NuovoProcedimento);
                page.activeEvents = true;
                page.SetBindableData(cambioPosizione);
                page.HideButtons();
                page.SetFormTitle("Cambio posizione cooperativa");

                DialogResult dr = DialogResult.OK;
                while (dr == DialogResult.OK)
                {
                    page.ErrorProviderCambioPosizione.ClearErrors();

                    dr = page.BaseForm.ShowDialog(this, false);

                    if (dr == DialogResult.OK)
                    {
                        if (!page.ErrorProviderCambioPosizione.HasErrors)
                            break;
                    }
                }
                return dr;
            }
            else
                return DialogResult.None;
        }

        void page_NuovoProcedimento(object sender, EventArgs e)
        {
            EventHandler temp = NuovoProcedimento;
            if (temp != null)
                NuovoProcedimento(null, new EventArgs());
        }

        private DialogResult OpenForEditCancellazione(CancellazioneFDT cancellazione)
        {
           
            Cancellazione page = CreatePageDialog<Cancellazione>();

            if (page != null)
            {
                page.NuovoProcedimento +=new EventHandler(page_NuovoProcedimento);

                page.SetBindableData(cancellazione);
                page.HideButtons();
                page.SetFormTitle("Cancellazione cooperativa");

                return page.BaseForm.ShowDialog(this, false);
            }
            else
                return DialogResult.None;
        }

        private DialogResult OpenForEditIscrizione(CooperativaFDT itemLocal)
        {
            IscrizioneComeCambio iscr = CreatePageDialog<IscrizioneComeCambio>();
            if (iscr != null)
            {
                if (itemLocal != null && 
                    itemLocal.RegistroCooperativa != null &&
                    itemLocal.RegistroCooperativa.Iscrizione == null)
                {
                    CambioPosizioneFDT cpTemp = new CambioPosizioneFDT();
                    cpTemp.CategoriaSociale = -1;
                    cpTemp.IdSottoCategoria = -1;
                    itemLocal.RegistroCooperativa.CambioPosizioni = new CambioPosizioneFDT[]{cpTemp};
                }

                iscr.activeEvents = true;
                iscr.NuovoProcedimento += new EventHandler(page_NuovoProcedimento);
                iscr.SetBindableData(itemLocal.RegistroCooperativa.Iscrizione);
                iscr.SetFormTitle("Gestione dati iscrizione");
                iscr.HideButtons();

                DialogResult dr = DialogResult.OK;
                while (dr == DialogResult.OK)
                {
                    iscr.ErrorProviderCambioPosizione.ClearErrors();

                    dr = iscr.BaseForm.ShowDialog(this, false);

                    if (dr == DialogResult.OK)
                    {
                        iscr.bindingSourceBaseCambioPosizione.EndEdit();

                        if (!iscr.ErrorProviderCambioPosizione.HasErrors)
                            break;
                    }
                }
                return dr;
            }
            else
                return DialogResult.None;
        }

       

        #endregion OpenForEdit

        #region Save

        private Boolean SaveIscrizione()
        {
            Boolean toReturn = true;

            if (itemLocal != null)
                if (itemLocal.RegistroCooperativa != null)
                    if (itemLocal.RegistroCooperativa.CambioPosizioni != null)
                        if (itemLocal.RegistroCooperativa.CambioPosizioni.Length > 0)
                            itemLocal.RegistroCooperativa.CambioPosizioni[0].Status = ObjectStatus.ToUpdate;
            return toReturn;
        }

        private Boolean SaveCambioPosizione(ref CambioPosizioneFDT cp, Boolean isAnUpdate, Boolean onDB)
        {
            Boolean toReturn = true;

            if (onDB)
            {
                // in caso mettere metodo pubblico che punta ai servizi
            }
            else
            {
                if (isAnUpdate)
                    cp.Status = ObjectStatus.ToUpdate;
                else
                    cp.Status = ObjectStatus.ToInsert;
            }

            return toReturn;
        }

        private Boolean SaveCancellazione(ref CancellazioneFDT c, Boolean onDB)
        {
            Boolean toReturn = true;

            if (onDB)
            {
                // in caso mettere metodo pubblico che punta ai servizi
            }
            else
            {
                c.Status = ObjectStatus.ToInsert;
            }

            return toReturn;
        }

        #endregion Save

        #region Initialization

        private void SetImages()
        {
            this.barButtonItemAddNewCambioPosizione.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Paperclip_24x24);
            this.barButtonItemDeleteCambioPosizione.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);
            this.barButtonItemDeleteCooperative.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Delete_24x24);

            this.barButtonItemViewStorico.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Door_24x24);
            this.barButtonItemLegaliRappresentanti.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Auction_Hammer_24x24);
        }

        private void SetVisibilityBarButton()
        {
            if (itemLocal != null)
            {
                if (itemLocal.RegistroCooperativa != null)
                {
                    this.barButtonItemAddNewCambioPosizione.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    this.barButtonItemDeleteCooperative.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                    if (itemLocal.RegistroCooperativa.Iscrizione != null &&
                        itemLocal.RegistroCooperativa.Iscrizione.ContainsData)
                    {
                        this.barButtonItemAddNewCambioPosizione.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        //this.barButtonItemDeleteCooperative.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    }

                   
                    // cancellazione
                    if (itemLocal.RegistroCooperativa.Cancellazione != null)
                    {
                        this.barButtonItemAddNewCambioPosizione.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        this.barButtonItemDeleteCooperative.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    }
                }
                else
                {
                    this.barButtonItemAddNewCambioPosizione.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    this.barButtonItemDeleteCooperative.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
            }
            else
            {
                this.barButtonItemAddNewCambioPosizione.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                this.barButtonItemDeleteCooperative.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }

        }

        #endregion Initialization

        #endregion Methods

        #region Event Handlers

        private void barButtonItemDeleteCooperative_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteCooperative(new CancellazioneFDT());
        }

        void positionChange1_DeleteIscrizione(object sender, EventArgs e)
        {
            DeleteIscrizione();
        }


        void positionChange1_ModifyIscrizione(object sender, EventArgs e)
        {
            ModifyIscrizione();
        }

        void positionChange1_NuovoProcedimento(object sender, EventArgs e)
        {
            EventHandler temp = NuovoProcedimento;
            if (temp != null)
                NuovoProcedimento(null, new EventArgs());
        }

        private void barButtonItemAddNewCambioPosizione_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddCambioPosizione();
        }

        #endregion Event Handlers

        private void barButtonItemViewStorico_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadStorico();
        }

        private void LoadStorico()
        {
            if (itemLocal != null && itemLocal.RegistroCooperativa != null)
            {
                if (itemLocal.RegistroCooperativa.DatiStoriciRegistro == null)
                {
                    DatiStoriciFDT[] storico = 
                        GVCSystemEngine.InvokeService<ICooperatives, DatiStoriciFDT[]>
                            (delegate()
                            {
                                return GVCSystemEngine.Cooperatives.GetListDatiStoriciRegistro(itemLocal.RegistroCooperativa.IdRegistro);
                            },
                        true);

                    itemLocal.RegistroCooperativa.DatiStoriciRegistro = storico;
                }

                DatiStorici.DatiStoriciRegistro page = CreatePageDialog<DatiStorici.DatiStoriciRegistro>();
                if (page != null)
                {
                   page.SetBindableData(itemLocal);
                   page.SetFormTitle("Lista dati storici");
                   page.BaseForm.MinimizeBox = false;
                   page.BaseForm.MaximizeBox = false;
                   page.BaseForm.ShowDialog(this, true);
                }
            }
        }

        private void barButtonItemLegaliRappresentanti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadLegaliRappresentanti();
        }

        #region LEGALI RAPPRESENTANTI

        private void LoadLegaliRappresentanti()
        {
            List<SoggettoFDT> lPeople = new List<SoggettoFDT>();
            if (itemLocal != null && itemLocal.RegistroCooperativa != null)
            {
                switch (itemLocal.RegistroCooperativa.IdStatoIscrizione)
                {
                    case TipoStatoIscrizione.FALLIMENTO:
                        lPeople.AddRange(GetListCuratoriFallimentari());
                        break;
                    case TipoStatoIscrizione.LIQUIDAZIONE_COATTA:
                    case TipoStatoIscrizione.LIQUIDAZIONE_COATTA_AMM:
                        lPeople.AddRange(GetListCommissariLiquidatori());
                        break;
                    case TipoStatoIscrizione.SCIOGLIMENTO_VOLONTARIO:
                        lPeople.AddRange(GetListForScioglimento());
                        break;
                    default:
                        lPeople.AddRange(GetListGeneric());
                        break;
                }
            }

            if (lPeople.Count == 0)
            {
                string msg = "Non sono stati trovati dati riferiti ai legali rappresentanti per la cooperativa di riferimento";
                ShowInformationMessage(msg, string.Empty);
            }
            else
            {
                LegaliRappresentanti.LegaliRappresentanti page = CreatePageDialog<LegaliRappresentanti.LegaliRappresentanti>();
                if (page != null)
                {
                    page.SetFormTitle("Legali rappresentanti");
                    page.SetBindableData(lPeople.ToArray());
                    page.BaseForm.ShowDialog(this, true);
                }
            }
        }

        private PersonaFisicaFDT[] GetListCuratoriFallimentari()
        {
            List<PersonaFisicaFDT> toReturn = new List<PersonaFisicaFDT>();

            if (itemLocal.RegistroCooperativa.ProcedureFallimentari != null &&
                itemLocal.RegistroCooperativa.ProcedureFallimentari.Length > 0)
            {
                //itemLocal.RegistroCooperativa.ProcedureFallimentari[0].
            }

            return toReturn.ToArray();
        }

        private SoggettoFDT[] GetListCommissariLiquidatori()
        {
            List<SoggettoFDT> toReturn = new List<SoggettoFDT>();

            if (itemLocal.RegistroCooperativa.LiquidazioniCoatte != null &&
                itemLocal.RegistroCooperativa.LiquidazioniCoatte.Length > 0)
            {
                #region Prendo la liquidazione coatta più recente
                int indexToConsider = -1;
                DateTime dt = DateTime.MinValue;
                int count = 0;
                foreach (LiquidazioneCoattaFDT item in itemLocal.RegistroCooperativa.LiquidazioniCoatte)
                {
                    if (item != null)
                    {
                        if (count == 0)
                        {
                            indexToConsider = 0;
                        }
                        if (item.DataDeliberaCommissione.HasValue)
                        {
                            if (dt < item.DataDeliberaCommissione.Value)
                            {
                                dt = item.DataDeliberaCommissione.Value;
                                indexToConsider = count;
                            }
                        }
                    }

                    count++;
                }
                #endregion Prendo la liquidazione coatta più recente

                if (indexToConsider >= 0)
                {
                    if (itemLocal.RegistroCooperativa.LiquidazioniCoatte[indexToConsider] != null &&
                        itemLocal.RegistroCooperativa.LiquidazioniCoatte[indexToConsider].CompensiCommissari != null &&
                        itemLocal.RegistroCooperativa.LiquidazioniCoatte[indexToConsider].CompensiCommissari.Length > 0)
                    {
                        Dictionary<int, string> corrRevisor = new Dictionary<int, string>();
                        foreach (CompensoFDT compenso in itemLocal.RegistroCooperativa.LiquidazioniCoatte[indexToConsider].CompensiCommissari)
                        {
                            #region Aggiungo i commissari

                            if (compenso != null && compenso.IdRevisore > 0)
                            {
                                if (corrRevisor.ContainsKey(compenso.IdRevisore))
                                {
                                    continue;
                                }
                                else
                                {
                                    corrRevisor.Add(compenso.IdRevisore, string.Empty);
                                }

                                if (compenso.Revisore != null)
                                {
                                    toReturn.Add(compenso.Revisore);
                                }
                                else
                                {
                                    SoggettoFDT s = GetSoggettoById(compenso.IdRevisore);
                                    if (s != null)
                                        toReturn.Add(s);
                                }
                            }
                            #endregion Aggiungo i commissari
                        }
                    }
                }
            }

            return toReturn.ToArray();
        }

        private SoggettoFDT GetSoggettoById(int idSoggetto)
        {
            SoggettoFDT toReturn = null;

            toReturn = GVCSystemEngine.InvokeService<ICooperatives, SoggettoFDT>
                              (delegate()
                              {
                                  return
                                      GVCSystemEngine.Cooperatives.
                                          GetSoggettoById(idSoggetto);
                              },
                           true);

            return toReturn;
        }

        private SoggettoFDT[] GetListForScioglimento()
        {
            List<SoggettoFDT> toReturn = new List<SoggettoFDT>();

            int indexToConsider = -1;
            if (itemLocal.RegistroCooperativa.ProcedureCoatte != null &&
                itemLocal.RegistroCooperativa.ProcedureCoatte.Length > 0)
            {
                int count = 0;
                foreach (ProceduraCoattaFDT item in itemLocal.RegistroCooperativa.ProcedureCoatte)
                {
                    if (item != null)
                    {
                        if (item.IdTipoProceduraCoatta == 5 && !item.DataFineProcedura.HasValue)
                        {
                            indexToConsider = count;
                            break;
                        }
                    }
                    count++;
                }
            }

            if (indexToConsider >= 0)
            {
                if (itemLocal.RegistroCooperativa.ProcedureCoatte[indexToConsider] != null &&
                    itemLocal.RegistroCooperativa.ProcedureCoatte[indexToConsider].CompensiCommissari != null &&
                    itemLocal.RegistroCooperativa.ProcedureCoatte[indexToConsider].CompensiCommissari.Length > 0)
                {
                    Dictionary<int, string> corrRevisor = new Dictionary<int, string>();
                    foreach (CompensoFDT compenso in itemLocal.RegistroCooperativa.ProcedureCoatte[indexToConsider].CompensiCommissari)
                    {
                        #region Aggiungo i commissari

                        if (compenso != null && compenso.IdRevisore > 0)
                        {
                            if (corrRevisor.ContainsKey(compenso.IdRevisore))
                            {
                                continue;
                            }
                            else
                            {
                                corrRevisor.Add(compenso.IdRevisore, string.Empty);
                            }

                            if (compenso.Revisore != null)
                            {
                                toReturn.Add(compenso.Revisore);
                            }
                            else
                            {
                                SoggettoFDT s = GetSoggettoById(compenso.IdRevisore);
                                if (s != null)
                                    toReturn.Add(s);
                            }
                        }
                        #endregion Aggiungo i commissari
                    }
                }
            }
            else
            {
                toReturn.AddRange(GetFromCaricheSociali());
            }

            return toReturn.ToArray();
        }

        private SoggettoFDT[] GetListGeneric()
        {
            List<SoggettoFDT> toReturn = new List<SoggettoFDT>();

            int indexToConsider = -1;
            if (itemLocal.RegistroCooperativa.ProcedureCoatte != null &&
                itemLocal.RegistroCooperativa.ProcedureCoatte.Length > 0)
            {
                int count = 0;
                foreach (ProceduraCoattaFDT item in itemLocal.RegistroCooperativa.ProcedureCoatte)
                {
                    if (item != null)
                    {
                        if (item.IdTipoProceduraCoatta == 2 && !item.DataFineProcedura.HasValue)
                        {
                            indexToConsider = count;
                            break;
                        }
                    }
                    count++;
                }
            }

            if (indexToConsider >= 0)
            {
                if (itemLocal.RegistroCooperativa.ProcedureCoatte[indexToConsider] != null &&
                    itemLocal.RegistroCooperativa.ProcedureCoatte[indexToConsider].CompensiCommissari != null &&
                    itemLocal.RegistroCooperativa.ProcedureCoatte[indexToConsider].CompensiCommissari.Length > 0)
                {
                    Dictionary<int, string> corrRevisor = new Dictionary<int, string>();
                    foreach (CompensoFDT compenso in itemLocal.RegistroCooperativa.ProcedureCoatte[indexToConsider].CompensiCommissari)
                    {
                        #region Aggiungo i commissari

                        if (compenso != null && compenso.IdRevisore > 0)
                        {
                            if (corrRevisor.ContainsKey(compenso.IdRevisore))
                            {
                                continue;
                            }
                            else
                            {
                                corrRevisor.Add(compenso.IdRevisore, string.Empty);
                            }

                            if (compenso.Revisore != null)
                            {
                                toReturn.Add(compenso.Revisore);
                            }
                            else
                            {
                                SoggettoFDT s = GetSoggettoById(compenso.IdRevisore);
                                if (s != null)
                                    toReturn.Add(s);
                            }
                        }
                        #endregion Aggiungo i commissari
                    }
                }
            }
            else
            {
                toReturn.AddRange(GetFromCaricheSociali());
            }

            return toReturn.ToArray();
        }

        private SoggettoFDT[] GetFromCaricheSociali()
        {
            List<SoggettoFDT> toReturn = new List<SoggettoFDT>();

            if (itemLocal.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale != null &&
                    itemLocal.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale.Length > 0)
            {
                #region Prendo la comunicazione carica sociale più recente
                int indexToConsiderSub = -1;
                int count = 0;
                DateTime dt = DateTime.MinValue;
                foreach (ComunicazioneCaricaSocialeFDT item in itemLocal.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale)
                {
                    if (item != null)
                    {
                        if (count == 0)
                        {
                            indexToConsiderSub = 0;
                        }

                        if (dt < item.DataSituazione)
                        {
                            dt = item.DataSituazione;
                            indexToConsiderSub = count;
                        }
                    }

                    count++;
                }
                #endregion Prendo la comunicazione carica sociale più recente

                if (indexToConsiderSub >= 0)
                {
                    Dictionary<int, string> corrRevisor = new Dictionary<int, string>();
                    Dictionary<string, string> corrRevisorGSC = new Dictionary<string, string>();

                    foreach (CaricaSocialeFDT carica in itemLocal.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale[indexToConsiderSub].Cariche)
                    {
                        #region Aggiungo le cariche

                        if (carica != null && carica.LegaleRappresentante)
                        {
                            if (carica.IdSoggetto > 0)
                            {
                                if (corrRevisor.ContainsKey(carica.IdSoggetto))
                                {
                                    continue;
                                }
                                else
                                {
                                    corrRevisor.Add(carica.IdSoggetto, string.Empty);
                                }
                            }
                            else
                            {
                                if (corrRevisorGSC.ContainsKey(carica.DescrizioneGSC))
                                {
                                    continue;
                                }
                                else
                                {
                                    corrRevisorGSC.Add(carica.DescrizioneGSC, string.Empty);
                                }

                                if (!carica.DescrizioneGSC.Equals(string.Empty))
                                {
                                    if (carica.PersonaFisica == null)
                                    {
                                        carica.PersonaFisica = new PersonaFisicaFDT();
                                        carica.PersonaFisica.Nome = carica.DescrizioneGSC;
                                    }
                                }
                            }

                            if (carica.PersonaFisica != null)
                            {
                                toReturn.Add(carica.PersonaFisica);
                            }
                            else
                            {
                                SoggettoFDT s = GetSoggettoById(carica.IdSoggetto);
                                if (s != null)
                                    toReturn.Add(s);
                            }
                        }
                        #endregion Aggiungo le cariche
                    }
                }
            }

            return toReturn.ToArray();
        }

        #endregion LEGALI RAPPRESENTANTI
    }
}
