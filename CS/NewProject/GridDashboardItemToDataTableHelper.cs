using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.DashboardCommon.ViewerData;
using DevExpress.DashboardCommon;
using System.Data;
using DevExpress.DashboardWin;
namespace WinProject
{
    public static class GridDashboardItemToDataTableHelper
    {
        public static DataTable CreateDataTableByGridDashboardItem(GridDashboardItem gridItem, DashboardViewer viewer)
        {
            DataTable dataTable = null;
            if (gridItem != null)
            {
                MultiDimensionalData mData = viewer.GetItemData(gridItem.ComponentName);
                dataTable = new DataTable();

                CreateColumnsByGridDashboardItem(gridItem, dataTable);

                AddRowsByGridDashboardItem(gridItem, mData, dataTable);
            }
            return dataTable;
        }
        private static void AddRowsByGridDashboardItem(GridDashboardItem gridItem, MultiDimensionalData mData, DataTable dataTable)
        {
            IList<string> axis = mData.GetAxisNames();
            int rowCount = GetRowCount(mData, axis);
            for (int i = 0; i < rowCount; i++)
            {
                AxisPoint point = mData.GetAxisPoints(axis[0])[i];
                DataRow newRow = dataTable.NewRow();
                foreach (GridColumnBase column in gridItem.Columns)
                {
                    GridMeasureColumn mCol = column as GridMeasureColumn;
                    if (mCol != null)
                        newRow[mCol.Measure.DataMember] = GetMesureValue(mData, point, mCol);

                    GridDimensionColumn dCol = column as GridDimensionColumn;
                    if (dCol != null)
                        newRow[dCol.Dimension.DataMember] = GetDimenstionValue(mData, axis, point, dCol);
                }
                dataTable.Rows.Add(newRow);
            }
        }
        private static int GetRowCount(MultiDimensionalData mData, IList<string> axis)
        {
            return mData.GetAxisPoints(axis[0]).Count;
        }
        private static object GetDimenstionValue(MultiDimensionalData mData, IList<string> axis, AxisPoint point, GridDimensionColumn dCol)
        {
            return point.GetDimensionValue(mData.GetDimensions(axis[0]).OfType<DimensionDescriptor>().First(d => d.DataMember == dCol.Dimension.DataMember)).Value;
        }
        private static object GetMesureValue(MultiDimensionalData mData, AxisPoint point, GridMeasureColumn mCol)
        {
            return mData.GetSlice(point).GetValue(mData.GetMeasures().OfType<MeasureDescriptor>().First(d => d.DataMember == mCol.Measure.DataMember)).Value;
        }
        private static void CreateColumnsByGridDashboardItem(GridDashboardItem gridItem, DataTable dataTable)
        {
            foreach (GridColumnBase column in gridItem.Columns)
            {
                DataColumn tableCol = new DataColumn();
                GridMeasureColumn mCol = column as GridMeasureColumn;
                if (mCol != null)
                    tableCol.ColumnName = mCol.Measure.DataMember;

                GridDimensionColumn dCol = column as GridDimensionColumn;
                if (dCol != null)
                    tableCol.ColumnName = dCol.Dimension.DataMember;
                dataTable.Columns.Add(tableCol);
            }
        }
    }
}
