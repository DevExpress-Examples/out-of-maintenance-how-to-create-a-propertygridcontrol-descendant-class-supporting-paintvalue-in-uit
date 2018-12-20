Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design

Namespace dxPaintValue
    Public Class MyPropertyEditor
        Inherits UITypeEditor

        Public Overrides Function GetPaintValueSupported(ByVal context As ITypeDescriptorContext) As Boolean
            Return True
        End Function

        Public Overrides Sub PaintValue(ByVal e As PaintValueEventArgs)
            If e.Value Is Nothing Then
                Return
            End If
            Dim color As Color = System.Drawing.Color.FromName(TryCast(e.Value, String))
            If Not color.IsEmpty Then
                Using brush As New SolidBrush(color)
                    e.Graphics.FillRectangle(brush, e.Bounds)
                End Using
            End If
        End Sub
    End Class
End Namespace
