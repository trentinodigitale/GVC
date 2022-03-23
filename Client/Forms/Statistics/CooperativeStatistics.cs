using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.Services;
using DevExpress.XtraGrid.Columns;

namespace it.dedagroup.GVC.Client.Forms.Statistics
{
    public partial class CooperativeStatistics : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        private DateTime dDal;
        private DateTime dAl;
        private DateTime dFinoAl;

        public CooperativeStatistics()
        {
            InitializeComponent();

            //StatoCategoria.Left = GrbStatisticaCooperativeFinoAl.Left + GrbStatisticaCooperativeFinoAl.Width + 6;
           
            StatoCategoria.SelectedIndex = 1;
        }

        private void CooperativeStatistics_Load(object sender, EventArgs e)
        {
            SetFormTitle("Statistica cooperative");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataSet dsResult;
            bool soloAttive;

            dsResult = null;

            if (StatoCategoria.SelectedIndex == 0)
            {
                soloAttive = false;
            }
            else
            {
                soloAttive = true;
            }

            if (DataFinoAl.DateTime > DateTime.MinValue)
            {
                dsResult = GVCSystemEngine.InvokeService<ICooperatives, DataSet>
                       (delegate()
                       {
                           return GVCSystemEngine.Cooperatives.GetCooperativeStatistica(DataFinoAl.DateTime, DateTime.MinValue, soloAttive);
                       },
                       true);
            }

            dDal = DateTime.MinValue;
            dAl = DateTime.MinValue;
            dFinoAl = DateTime.MinValue;

            if (dsResult != null)
            {
                gridViewStatisticaCooperative.Columns.Clear();
                gridControlStatisticaCooperative.DataSource = dsResult.Tables[0];
                for (int i = 0; i < gridViewStatisticaCooperative.Columns.Count; i++)
                {
                    if (gridViewStatisticaCooperative.Columns[i].Caption == string.Empty)
                    {
                        gridViewStatisticaCooperative.Columns[i].Visible = false;
                    }

                    gridViewStatisticaCooperative.Columns[i].OptionsColumn.AllowEdit = false;
                    gridViewStatisticaCooperative.Columns[i].OptionsColumn.AllowFocus = false;
                    gridViewStatisticaCooperative.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                    gridViewStatisticaCooperative.Columns[i].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
                    gridViewStatisticaCooperative.Columns[i].OptionsColumn.AllowMove = false;
                    gridViewStatisticaCooperative.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                }
               
                dFinoAl = DataFinoAl.DateTime;
            }            
            else
            {
                ShowInformationMessage("Controllare le date!", string.Empty);
            }
        }

        private void barButtonItemStampa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            StringBuilder sbTitle;
            
            sbTitle = null;

            if (DataFinoAl.DateTime > DateTime.MinValue)
            {
                sbTitle = new StringBuilder();
                sbTitle.Append("Periodo di interrogazione fino al ");
                sbTitle.Append(dFinoAl.ToShortDateString());
            }

            if (sbTitle != null)
            {
                DevExpress.XtraPrinting.PrintingSystem ps = new DevExpress.XtraPrinting.PrintingSystem();
                DevExpress.XtraPrinting.PrintableComponentLink pcl = new DevExpress.XtraPrinting.PrintableComponentLink();

                ps.Links.Add(pcl);
                pcl.Component = gridControlStatisticaCooperative;

                ps.Links[0].Landscape = true;

                DevExpress.XtraPrinting.PageHeaderFooter phf = ps.Links[0].PageHeaderFooter as DevExpress.XtraPrinting.PageHeaderFooter;
                //phf.Header.Content.AddRange(new string[] { String.Concat("PARAMETRI DI RICERCA", Environment.NewLine, ""), null, String.Concat(Environment.NewLine, "Ricerca procedure coatte") });
                phf.Header.Content.AddRange(new string[] { null, null, String.Concat(Environment.NewLine, "Statistica cooperative", Environment.NewLine, sbTitle.ToString()) });

                pcl.ShowPreviewDialog();
            }
        }

        private void barButtonItemExportResults_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.gridControlStatisticaCooperative != null && this.gridControlStatisticaCooperative.MainView != null)
            {
                try
                {
                    System.IO.FileInfo fi = new System.IO.FileInfo(System.IO.Path.GetTempFileName().Replace(".tmp", ".xls"));
                    this.gridControlStatisticaCooperative.MainView.ExportToXls(fi.FullName);
                    System.Diagnostics.Process.Start(fi.FullName);
                }
                catch
                {

                }
            }
        }
    }
}
