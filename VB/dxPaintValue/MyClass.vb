Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Linq

Namespace dxPaintValue
	Public Class [MyClass]
		Private s_Renamed As String

		<Editor(GetType(MyPropertyEditor), GetType(UITypeEditor))> _
		Public Property S() As String
			Get
				Return s_Renamed
			End Get
			Set(ByVal value As String)
				s_Renamed = value
			End Set
		End Property
	End Class
End Namespace
