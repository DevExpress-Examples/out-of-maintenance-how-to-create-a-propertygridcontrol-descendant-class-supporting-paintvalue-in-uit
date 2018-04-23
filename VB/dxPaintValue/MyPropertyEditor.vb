Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Linq

Namespace dxPaintValue
	Public Class MyPropertyEditor
		Inherits UITypeEditor
		Public Overrides Overloads Function GetPaintValueSupported(ByVal context As ITypeDescriptorContext) As Boolean
			Return True
		End Function

		Public Overrides Overloads Sub PaintValue(ByVal e As PaintValueEventArgs)
		   e.Graphics.DrawString("JHGJHG", New Font("Verdana", 8.0f), Brushes.BlueViolet, New PointF(e.Bounds.X + 2, e.Bounds.Y + 2))
		End Sub
	End Class
End Namespace
