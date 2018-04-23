Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid

Namespace HierarchicalFilters
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.pivotGridControl1.DataSource = GetTimeTableView()
			fieldMonth.CollapseAll()
		End Sub
		Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
							Handles radioGroup1.SelectedIndexChanged
			If pivotGridControl1 Is Nothing Then
				Return
			End If
			Me.pivotGridControl1.BeginUpdate()
			Dim group As PivotGridGroup = Me.pivotGridControl1.Groups(0)
			group.FilterValues.Reset()
			group.FilterValues.BeginUpdate()
			Select Case radioGroup1.SelectedIndex
				Case 0
					group.FilterValues.FilterType = PivotFilterType.Excluded
				Case 1
					group.FilterValues.FilterType = PivotFilterType.Included
					group.FilterValues.Values.Add(2009).ChildValues.Add(12)
					group.FilterValues.Values.Add(2010).ChildValues.Add(1)
				Case 2
					group.FilterValues.FilterType = PivotFilterType.Excluded
					group.FilterValues.Values.Add(2009)
				Case 3
					group.FilterValues.FilterType = PivotFilterType.Included
					SelectFirstDays(group)
			End Select
			group.FilterValues.EndUpdate()
			Me.pivotGridControl1.EndUpdate()
			If radioGroup1.SelectedIndex = 3 Then
				fieldMonth.ExpandAll()
			Else
				fieldMonth.CollapseAll()
			End If
		End Sub
		Private Sub SelectFirstDays(ByVal group As PivotGridGroup)
			For Each year As Object In group.GetUniqueValues(Nothing)
				Dim value As PivotGroupFilterValue = group.FilterValues.Values.Add(year)
				For Each month As Object In group.GetUniqueValues(New Object() { year })
					value.ChildValues.Add(month).ChildValues.Add(1)
				Next month
			Next year
		End Sub
	End Class
End Namespace