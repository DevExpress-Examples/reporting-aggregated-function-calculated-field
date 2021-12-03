Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace AggregateFunctionCalcFieldExample
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Public Sub New()
			InitializeComponent()
			Me.reportDesigner1.OpenReport(New TestReport())
			Me.reportDesigner1.ActiveDesignPanel.SelectedTabIndex = 1
		End Sub
	End Class
End Namespace
