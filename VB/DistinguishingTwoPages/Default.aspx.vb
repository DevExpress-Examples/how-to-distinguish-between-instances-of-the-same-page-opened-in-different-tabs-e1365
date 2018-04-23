Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Diagnostics

Namespace DistinguishingTwoPages
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
			If (Not IsPostBack) AndAlso (Not IsCallback) Then
				Dim newId As Guid = Guid.NewGuid()
				ASPxHiddenField1.Add("PageID", newId)
			End If
		End Sub
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			Dim pageID As Object = ASPxHiddenField1("PageID")
			ASPxLabel1.Text = String.Format("Page ID: {0}", pageID)

			If IsPostBack OrElse IsCallback Then
				Debug.WriteLine(String.Format("Page: {0}, Value: {1}", pageID, ASPxTextBox1.Text))
			End If
		End Sub
	End Class
End Namespace
