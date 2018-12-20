Imports System.ComponentModel
Imports System.Drawing.Design

Namespace dxPaintValue
    Public Class [MyClass]
        <Editor(GetType(MyPropertyEditor), GetType(UITypeEditor))> _
        Public Property Color() As String
    End Class
End Namespace
