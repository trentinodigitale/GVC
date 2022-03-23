using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Client.Forms.Cooperative;
using it.dedagroup.GVC.Repository.Common;

namespace it.dedagroup.GVC.Client.Forms.Search
{
    public partial class CooperativeSearch : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {

		#region Event Handlers (5) 

        private void BarButtonItemExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.gridControlCooperatives != null && this.gridControlCooperatives.MainView != null)
            {
                try
                {
                    System.IO.FileInfo fi = new System.IO.FileInfo(System.IO.Path.GetTempFileName().Replace(".tmp", ".xls"));
                    this.gridControlCooperatives.MainView.ExportToXls(fi.FullName);
                    System.Diagnostics.Process.Start(fi.FullName);
                }
                catch
                {

                }
            }
        }

        private void BarButtonItemPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.gridControlCooperatives != null)
            {
                try
                {
                    this.gridControlCooperatives.ShowPreview();
                }
                catch
                {

                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchCooperatives();
        }

        private void gridControlCooperatives_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //try
            //{
            //    CreatePage<CooperativeEdit>(PageActions.ShowMdiChild);
            //}
            //catch (Exception ex)
            //{
            //    System.Diagnostics.Debug.WriteLine(ex);
            //}
        }

        private void SearchCooperative_Load(object sender, EventArgs e)
        {
            SetFormTitle("Ricerca cooperative");
        }

		#endregion Event Handlers 

		#region Instance Variables (1) 

        List<CooperativaFDT> listCooperatives = new List<CooperativaFDT>();

		#endregion Instance Variables 

		#region Constructors (1) 

        public CooperativeSearch()
        {
            InitializeComponent();

            EnableControlAutoSize(new object[] { this }, gridControlCooperatives, 400);

            this.BarGridControl.Visible = true;
            this.BarButtonItemCollapse.Visibility =
                this.BarButtonItemExpand.Visibility =
                this.BarButtonItemRefresh.Visibility =
                this.BarButtonItemSearch.Visibility =
                this.BarEditItemSearch.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            SetImages();

            this.ConfirmCancel = false;
        }

		#endregion Constructors 

		#region Private Methods (2) 

        private void SearchCooperatives()
        {
            this.gridControlCooperatives.BeginUpdate();

            this.bindingSourceCooperatives.DataSource = null;
            this.listCooperatives.Clear();

            listCooperatives.Add(StaticClassTemp.GetCooperativeFDT());
            listCooperatives.Add(StaticClassTemp.GetCooperativeFDT());

            this.bindingSourceCooperatives.DataSource = listCooperatives;

            this.gridControlCooperatives.EndUpdate();
        }

        private void SetImages()
        {
            this.BarButtonItemExport.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Export_24x24);
            this.BarButtonItemPrint.Glyph = GVCResourcesUtility.Get_16x16(GVCResources.Printer_24x24);
        }

		#endregion Private Methods 

    }
}
