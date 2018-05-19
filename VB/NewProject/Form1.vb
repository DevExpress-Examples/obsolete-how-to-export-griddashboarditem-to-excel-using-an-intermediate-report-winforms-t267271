Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports DevExpress.XtraEditors
Imports System.Collections.Generic
Imports DevExpress.DashboardCommon.ViewerData
Imports DevExpress.DashboardCommon
Imports System.Data
Imports System.Diagnostics
Namespace WinProject
	Partial Public Class Form1
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub dashboardViewer1_DataLoading(ByVal sender As Object, ByVal e As DataLoadingEventArgs) Handles dashboardViewer1.DataLoading
			Dim list As List(Of [MyClass]) = CreateDataSource()
			e.Data = list
		End Sub
		Private Shared Function CreateDataSource() As List(Of [MyClass])
			Dim list As New List(Of [MyClass])(10)
			Dim _r As New Random()
			For i As Integer = 0 To list.Capacity - 1
				list.Add(New [MyClass]() With {.ID = i, .Name = "Name" & i, .Sales =CSng(_r.NextDouble()), .Date = DateTime.Now.AddDays(i)})
			Next i
			Return list
		End Function

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Dim grid As GridDashboardItem = TryCast(dashboardViewer1.Dashboard.Items(0), GridDashboardItem)
			Dim path As String = grid.Name & ".xlsx"

			Dim table As DataTable = GridDashboardItemToDataTableHelper.CreateDataTableByGridDashboardItem(grid, dashboardViewer1)
			CType(New XtraReport1(table), XtraReport1).ExportToXlsx(path)
			Process.Start(path)
		End Sub
	End Class
End Namespace