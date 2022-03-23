using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using it.dedagroup.GVC.Repository.Common;

namespace it.dedagroup.GVC.Client.Forms.Forms
{
    public partial class UnlockEntitiesManager : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        List<LockFDT> listLocks = new List<LockFDT>();

        public UnlockEntitiesManager()
        {
            InitializeComponent();

            if (!DesignMode)
            {
                SetImages();
            }
        }

        private void SetImages()
        {
            this.barButtonItemUnlock.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Magic_Wand_24x24);
            this.barButtonItemUpdate.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Refresh_24x24);
        }

        private void SetBindableData()
        {
            this.bindingSourceBaseLocks.DataSource = null;

            GetListLocks();

            this.bindingSourceBaseLocks.DataSource = listLocks.ToArray();
        }

        private void GetListLocks()
        {
            listLocks.Clear();

            LockFDT[] toReturn = GVCSystemEngine.InvokeService<ICooperatives, LockFDT[]>
                       (delegate()
                       {
                           return GVCSystemEngine.Cooperatives.GetListLocks();
                       },
                       true);

            if (toReturn != null && toReturn.Length > 0)
            {
                listLocks.AddRange(toReturn);
            }
        }

        private void UnlockEntitiesManager_Shown(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                SetBindableData();
            }
        }

        private void gridViewLocks_ShowGridMenu(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs e)
        {
            LockFDT item = GetCurrentItem();
            if (item != null)
            {
                GridView view = sender as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
                if (hitInfo.InRow)
                {
                    view.FocusedRowHandle = hitInfo.RowHandle;
                    popupMenuLock.ShowPopup(BarManager,
                            gridControlLocks.PointToScreen(e.Point));
                }
            }
        }

        private LockFDT GetCurrentItem()
        {
            LockFDT toReturn = null;
            if (this.bindingSourceBaseLocks.Current != null)
                toReturn = this.bindingSourceBaseLocks.Current as LockFDT;
            return toReturn;
        }

        private void barButtonItemUnlock_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Unlock();
        }

        private void Unlock()
        {
            LockFDT item = GetCurrentItem();
            if (item != null)
            {
                Boolean toReturn = GVCSystemEngine.InvokeService<ICooperatives, Boolean>
                      (delegate()
                      {
                          return GVCSystemEngine.Cooperatives.Unlock(item);
                      },
                      true);

                if (toReturn)
                {
                    ShowInformationMessage("Cooperativa sbloccata con successo", string.Empty);

                    SetBindableData();
                }
                else
                {
                    ShowProblemsMessage();
                }
            }
        }

        private void barButtonItemUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetBindableData();
        }

        private void UnlockEntitiesManager_Load(object sender, EventArgs e)
        {
            SetFormTitle("Gestione lock");
        }
    }
}
