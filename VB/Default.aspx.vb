Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraReports.UI
' ...

Namespace PassParameterToWebReport
	Partial Public Class _Default
		Inherits System.Web.UI.Page

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			ReportViewer1.Report = CreateReport()
		End Sub

		Private Function CreateReport() As XtraReport
			Dim report As New XtraReport1()
			report.catId.Value = GetSelectedValue(1)
			report.CreateDocument()
			Return report
		End Function

		Private Function GetSelectedValue(ByVal defaultValue As Integer) As Integer
			If ASPxComboBox1.SelectedItem IsNot Nothing Then
				Return Convert.ToInt32(ASPxComboBox1.SelectedItem.Value) + 1
			Else
				Return defaultValue
			End If
		End Function
	End Class
End Namespace
