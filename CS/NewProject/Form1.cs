using System;
using System.Linq;
using DevExpress.XtraEditors;
using System.Collections.Generic;
using DevExpress.DashboardCommon.ViewerData;
using DevExpress.DashboardCommon;
using System.Data;
using System.Diagnostics;
using DevExpress.DataAccess;
namespace WinProject
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dashboardViewer1_DataLoading(object sender, DataLoadingEventArgs e)
        {
            List<MyClass> list = CreateDataSource();
            e.Data = list;
        }
        private static List<MyClass> CreateDataSource()
        {
            List<MyClass> list = new List<MyClass>(10);
            Random _r = new Random();
            for (int i = 0; i < list.Capacity; i++)
                list.Add(new MyClass() { ID = i, Name = "Name" + i, Sales =(float)_r.NextDouble(), Date = DateTime.Now.AddDays(i)});
            return list;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            GridDashboardItem grid = dashboardViewer1.Dashboard.Items[0] as GridDashboardItem;
            string path = grid.Name + ".xlsx";

            DataTable table = GridDashboardItemToDataTableHelper.CreateDataTableByGridDashboardItem(grid, dashboardViewer1);
            new XtraReport1(table).ExportToXlsx(path);
            Process.Start(path);
        }
    }
}