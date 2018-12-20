Imports System.Windows.Forms

Namespace dxPaintValue
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            Dim c As [MyClass] = New [MyClass]() With {.Color = "Orange"}
            propertyGrid1.SelectedObject = c
            myPropertyGridControl1.SelectedObject = c
        End Sub
    End Class
End Namespace
