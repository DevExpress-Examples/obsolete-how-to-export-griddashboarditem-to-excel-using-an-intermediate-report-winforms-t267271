Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Collections.Generic
Imports DevExpress.DashboardCommon.ViewerData
Imports DevExpress.DashboardCommon
Imports System.Data
Imports DevExpress.DashboardWin
Namespace WinProject
	Public NotInheritable Class GridDashboardItemToDataTableHelper
		Private Sub New()
		End Sub
		Public Shared Function CreateDataTableByGridDashboardItem(ByVal gridItem As GridDashboardItem, ByVal viewer As DashboardViewer) As DataTable
			Dim dataTable As DataTable = Nothing
			If gridItem IsNot Nothing Then
				Dim mData As MultiDimensionalData = viewer.GetItemData(gridItem.ComponentName)
				dataTable = New DataTable()

				CreateColumnsByGridDashboardItem(gridItem, dataTable)

				AddRowsByGridDashboardItem(gridItem, mData, dataTable)
			End If
			Return dataTable
		End Function
		Private Shared Sub AddRowsByGridDashboardItem(ByVal gridItem As GridDashboardItem, ByVal mData As MultiDimensionalData, ByVal dataTable As DataTable)
			Dim axis As IList(Of String) = mData.GetAxisNames()
			Dim rowCount As Integer = GetRowCount(mData, axis)
			For i As Integer = 0 To rowCount - 1
				Dim point As AxisPoint = mData.GetAxisPoints(axis(0))(i)
				Dim newRow As DataRow = dataTable.NewRow()
				For Each column As GridColumnBase In gridItem.Columns
					Dim mCol As GridMeasureColumn = TryCast(column, GridMeasureColumn)
					If mCol IsNot Nothing Then
						newRow(mCol.Measure.DataMember) = GetMesureValue(mData, point, mCol)
					End If

					Dim dCol As GridDimensionColumn = TryCast(column, GridDimensionColumn)
					If dCol IsNot Nothing Then
						newRow(dCol.Dimension.DataMember) = GetDimenstionValue(mData, axis, point, dCol)
					End If
				Next column
				dataTable.Rows.Add(newRow)
			Next i
		End Sub
		Private Shared Function GetRowCount(ByVal mData As MultiDimensionalData, ByVal axis As IList(Of String)) As Integer
			Return mData.GetAxisPoints(axis(0)).Count
		End Function
		Private Shared Function GetDimenstionValue(ByVal mData As MultiDimensionalData, ByVal axis As IList(Of String), ByVal point As AxisPoint, ByVal dCol As GridDimensionColumn) As Object
			Return point.GetDimensionValue(mData.GetDimensions(axis(0)).OfType(Of DimensionDescriptor)().First(Function(d) d.DataMember = dCol.Dimension.DataMember)).Value
		End Function
		Private Shared Function GetMesureValue(ByVal mData As MultiDimensionalData, ByVal point As AxisPoint, ByVal mCol As GridMeasureColumn) As Object
			Return mData.GetSlice(point).GetValue(mData.GetMeasures().OfType(Of MeasureDescriptor)().First(Function(d) d.DataMember = mCol.Measure.DataMember)).Value
		End Function
		Private Shared Sub CreateColumnsByGridDashboardItem(ByVal gridItem As GridDashboardItem, ByVal dataTable As DataTable)
			For Each column As GridColumnBase In gridItem.Columns
				Dim tableCol As New DataColumn()
				Dim mCol As GridMeasureColumn = TryCast(column, GridMeasureColumn)
				If mCol IsNot Nothing Then
					tableCol.ColumnName = mCol.Measure.DataMember
				End If

				Dim dCol As GridDimensionColumn = TryCast(column, GridDimensionColumn)
				If dCol IsNot Nothing Then
					tableCol.ColumnName = dCol.Dimension.DataMember
				End If
				dataTable.Columns.Add(tableCol)
			Next column
		End Sub
	End Class
End Namespace
