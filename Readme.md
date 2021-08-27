<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/134061810/15.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T267271)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[Form1.cs](./CS/NewProject/Form1.cs) (VB: [Form1.vb](./VB/NewProject/Form1.vb))**
* [GridDashboardItemToDataTableHelper.cs](./CS/NewProject/GridDashboardItemToDataTableHelper.cs) (VB: [GridDashboardItemToDataTableHelper.vb](./VB/NewProject/GridDashboardItemToDataTableHelper.vb))
* [XtraReport1.cs](./CS/NewProject/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/NewProject/XtraReport1.vb))
<!-- default file list end -->
# (OBSOLETE) How to export GridDashboardItem to Excel using an intermediate report (WinForms)
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t267271)**
<!-- run online end -->


<p>Udpate: The Dashboard Suite version 15.2 supports the Export To Excel functionality out of the box: <a href="https://documentation.devexpress.com/Dashboard/CustomDocument15182.aspx">Printing and Exporting</a> <br>This example demonstrates how to fetch data from the <a href="https://documentation.devexpress.com/#Dashboard/clsDevExpressDashboardCommonGridDashboardItemtopic">GridDashboardItem</a> placed in the <a href="https://documentation.devexpress.com/#Dashboard/clsDevExpressDashboardWinDashboardViewertopic">DashboardViewer</a> class instance. To get data from the item, the <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardViewer_GetItemDatatopic">DashboardViewer.GetItemData</a> method is used. Please look at the static GridDashboardItemToDataTableHelper class. With a <a href="https://documentation.devexpress.com/#Dashboard/clsDevExpressDashboardCommonViewerDataMultiDimensionalDatatopic">MultiDimensionalData</a> class instance, it is possible to create columns (see the CreateColumnsByGridDashboardItem method) and fill a DataTable (see the AddRowsByGridDashboardItem method). This table will be further used in a report to perform the export. I used the report from the <a href="https://www.devexpress.com/Support/Center/p/T234458">How to export the GridDashboardItem item data to Excel from a web solution</a> example.</p>

<br/>


