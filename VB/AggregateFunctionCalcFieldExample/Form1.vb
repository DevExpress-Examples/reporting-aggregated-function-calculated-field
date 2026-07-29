Imports System.ComponentModel
Imports System.Drawing

Namespace AggregateFunctionCalcFieldExample

    Public Partial Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
            reportDesigner1.OpenReport(New TestReport())
            reportDesigner1.ActiveDesignPanel.SelectedTabIndex = 1
        End Sub
    End Class
End Namespace
