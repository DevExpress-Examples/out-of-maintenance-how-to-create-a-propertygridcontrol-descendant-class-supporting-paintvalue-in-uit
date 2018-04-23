Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms

Namespace dxPaintValue
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			Dim c As New [MyClass]()
			propertyGrid1.SelectedObject = c
			myPropertyGridControl1.SelectedObject = c
		End Sub
	End Class
End Namespace
