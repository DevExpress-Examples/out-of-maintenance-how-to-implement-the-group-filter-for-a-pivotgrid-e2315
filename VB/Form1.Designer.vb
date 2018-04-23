Imports Microsoft.VisualBasic
Imports System
Namespace HierarchicalFilters
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim pivotGridGroup1 As New DevExpress.XtraPivotGrid.PivotGridGroup()
			Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldMonth = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldDay = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.fieldName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldPrice = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' fieldYear
			' 
			Me.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldYear.AreaIndex = 0
			Me.fieldYear.FieldName = "Year"
			Me.fieldYear.Name = "fieldYear"
			' 
			' fieldMonth
			' 
			Me.fieldMonth.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldMonth.AreaIndex = 1
			Me.fieldMonth.FieldName = "Month"
			Me.fieldMonth.Name = "fieldMonth"
			' 
			' fieldDay
			' 
			Me.fieldDay.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldDay.AreaIndex = 2
			Me.fieldDay.FieldName = "Day"
			Me.fieldDay.Name = "fieldDay"
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldName, Me.fieldPrice, Me.fieldYear, Me.fieldMonth, Me.fieldDay})
			pivotGridGroup1.Fields.Add(Me.fieldYear)
			pivotGridGroup1.Fields.Add(Me.fieldMonth)
			pivotGridGroup1.Fields.Add(Me.fieldDay)
			pivotGridGroup1.Hierarchy = Nothing
			Me.pivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() { pivotGridGroup1})
			Me.pivotGridControl1.Location = New System.Drawing.Point(12, 92)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.OptionsView.RowTotalsLocation = DevExpress.XtraPivotGrid.PivotRowTotalsLocation.Tree
			Me.pivotGridControl1.OptionsView.ShowTotalsForSingleValues = True
			Me.pivotGridControl1.Size = New System.Drawing.Size(719, 367)
			Me.pivotGridControl1.TabIndex = 0
'			Me.pivotGridControl1.FieldValueDisplayText += New DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventHandler(Me.pivotGridControl1_FieldValueDisplayText);
			' 
			' fieldName
			' 
			Me.fieldName.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldName.AreaIndex = 0
			Me.fieldName.FieldName = "Name"
			Me.fieldName.Name = "fieldName"
			' 
			' fieldPrice
			' 
			Me.fieldPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldPrice.AreaIndex = 0
			Me.fieldPrice.FieldName = "Price"
			Me.fieldPrice.Name = "fieldPrice"
			' 
			' radioGroup1
			' 
			Me.radioGroup1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radioGroup1.EditValue = 1
			Me.radioGroup1.Location = New System.Drawing.Point(12, 12)
			Me.radioGroup1.Name = "radioGroup1"
			Me.radioGroup1.Properties.Columns = 2
			Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Show all data"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Show December 2009 and January 2010 only"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Hide 2009 year"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Show first days of months only")})
			Me.radioGroup1.Size = New System.Drawing.Size(719, 74)
			Me.radioGroup1.TabIndex = 5
'			Me.radioGroup1.SelectedIndexChanged += New System.EventHandler(Me.radioGroup1_SelectedIndexChanged);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(743, 471)
			Me.Controls.Add(Me.radioGroup1)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Hierarchical Filters"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private WithEvents radioGroup1 As DevExpress.XtraEditors.RadioGroup
		Private fieldName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldPrice As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldYear As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldMonth As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldDay As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace

