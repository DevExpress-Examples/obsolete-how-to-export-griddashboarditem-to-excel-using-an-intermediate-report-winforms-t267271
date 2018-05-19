# (OBSOLETE) How to export GridDashboardItem to Excel using an intermediate report (WinForms)


<p>Udpate: The Dashboard Suite version 15.2 supports the Export To Excel functionality out of the box: <a href="https://documentation.devexpress.com/Dashboard/CustomDocument15182.aspx">Printing and Exporting</a> <br>This example demonstrates how to fetch data from the <a href="https://documentation.devexpress.com/#Dashboard/clsDevExpressDashboardCommonGridDashboardItemtopic">GridDashboardItem</a> placed in the <a href="https://documentation.devexpress.com/#Dashboard/clsDevExpressDashboardWinDashboardViewertopic">DashboardViewer</a> class instance. To get data from the item, the <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardViewer_GetItemDatatopic">DashboardViewer.GetItemData</a> method is used. Please look at the static GridDashboardItemToDataTableHelper class. With a <a href="https://documentation.devexpress.com/#Dashboard/clsDevExpressDashboardCommonViewerDataMultiDimensionalDatatopic">MultiDimensionalData</a> class instance, it is possible to create columns (see the CreateColumnsByGridDashboardItem method) and fill a DataTable (see the AddRowsByGridDashboardItem method). This table will be further used in a report to perform the export. I used the report from the <a href="https://www.devexpress.com/Support/Center/p/T234458">How to export the GridDashboardItem item data to Excel from a web solution</a> example.</p>

<br/>


