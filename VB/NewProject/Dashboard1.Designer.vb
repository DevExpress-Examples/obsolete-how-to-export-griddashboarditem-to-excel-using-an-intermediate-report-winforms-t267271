Imports Microsoft.VisualBasic
Imports System
Namespace WinProject
	Partial Public Class Dashboard1
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
        Dim Measure1 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
        Dim GridMeasureColumn1 As DevExpress.DashboardCommon.GridMeasureColumn = New DevExpress.DashboardCommon.GridMeasureColumn()
        Dim Dimension1 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
        Dim GridDimensionColumn1 As DevExpress.DashboardCommon.GridDimensionColumn = New DevExpress.DashboardCommon.GridDimensionColumn()
        Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
        Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
        Dim DashboardParameter1 As DevExpress.DashboardCommon.DashboardParameter = New DevExpress.DashboardCommon.DashboardParameter()
        Dim DashboardParameter2 As DevExpress.DashboardCommon.DashboardParameter = New DevExpress.DashboardCommon.DashboardParameter()
        Me.gridDashboardItem1 = New DevExpress.DashboardCommon.GridDashboardItem()
        Me.DashboardObjectDataSource1 = New DevExpress.DashboardCommon.DashboardObjectDataSource()
        CType(Me.gridDashboardItem1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Measure1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Dimension1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DashboardObjectDataSource1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'gridDashboardItem1
        '
        Measure1.DataMember = "ID"
        GridMeasureColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
        GridMeasureColumn1.AddDataItem("Measure", Measure1)
        Dimension1.DataMember = "Name"
        GridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
        GridDimensionColumn1.AddDataItem("Dimension", Dimension1)
        Me.gridDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.GridColumnBase() {GridMeasureColumn1, GridDimensionColumn1})
        Me.gridDashboardItem1.ComponentName = "gridDashboardItem1"
        Me.gridDashboardItem1.DataItemRepository.Clear
        Me.gridDashboardItem1.DataItemRepository.Add(Measure1, "DataItem0")
        Me.gridDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem1")
        Me.gridDashboardItem1.DataSource = Me.DashboardObjectDataSource1
        Me.gridDashboardItem1.FilterString = ""
        Me.gridDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false
        Me.gridDashboardItem1.Name = "Grid 1"
        Me.gridDashboardItem1.ShowCaption = true
        '
        'DashboardObjectDataSource1
        '
        Me.DashboardObjectDataSource1.ComponentName = "DashboardObjectDataSource1"
        Me.DashboardObjectDataSource1.DataSource = GetType(WinProject.[MyClass])
        Me.DashboardObjectDataSource1.Name = "Object Data Source 1"
        '
        'Dashboard1
        '
        Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() {Me.DashboardObjectDataSource1})
        Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.gridDashboardItem1})
        DashboardLayoutItem1.DashboardItem = Me.gridDashboardItem1
        DashboardLayoutItem1.Weight = 44.110275689223059R
        DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1})
        DashboardLayoutGroup1.DashboardItem = Nothing
        Me.LayoutRoot = DashboardLayoutGroup1
        DashboardParameter1.Name = "Parameter1"
        DashboardParameter1.Type = GetType(Integer)
        DashboardParameter1.Value = 0
        DashboardParameter2.Name = "Parameter2"
        DashboardParameter2.Type = GetType(String)
        DashboardParameter2.Value = "Name1"
        Me.Parameters.AddRange(New DevExpress.DashboardCommon.DashboardParameter() {DashboardParameter1, DashboardParameter2})
        Me.Title.Text = "Dashboard"
        CType(Measure1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Dimension1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.gridDashboardItem1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DashboardObjectDataSource1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub

		#End Region

		Private gridDashboardItem1 As DevExpress.DashboardCommon.GridDashboardItem
  Friend WithEvents DashboardObjectDataSource1 As DevExpress.DashboardCommon.DashboardObjectDataSource
	End Class
End Namespace
