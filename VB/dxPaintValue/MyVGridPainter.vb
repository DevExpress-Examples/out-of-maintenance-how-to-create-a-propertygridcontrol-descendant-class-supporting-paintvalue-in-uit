Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraVerticalGrid.Painters
Imports DevExpress.XtraVerticalGrid.Events
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraVerticalGrid.ViewInfo
Imports System.Drawing.Design
Imports DevExpress.XtraVerticalGrid.Rows
Imports System.ComponentModel
Imports DevExpress.XtraVerticalGrid.Data

Namespace dxPaintValue
	Public Class MyVGridPainter
		Inherits VGridPainter
		Public Sub New(ByVal eventHelper As PaintEventHelper)
			MyBase.New(eventHelper)

		End Sub
		Protected Overrides Sub DrawRowValueCellCore(ByVal e As CustomDrawRowValueCellEventArgs, ByVal pb As BaseEditPainter, ByVal bvi As BaseEditViewInfo, ByVal vi As BaseViewInfo)
			MyBase.DrawRowValueCellCore(e, pb, bvi, vi)
			Dim propertyGridControl As MyPropertyGridControl = CType(vi.Grid, MyPropertyGridControl)
			Dim rowProperties As RowProperties = e.Row.GetRowProperties(e.CellIndex)
			Dim context As DescriptorContext = propertyGridControl.GetDescriptorContext(rowProperties)
			Dim editor As UITypeEditor = propertyGridControl.GetUITypeEditor(context)
			If editor IsNot Nothing AndAlso editor.GetPaintValueSupported() Then
				Dim args As New PaintValueEventArgs(CType(context, ITypeDescriptorContext), Nothing, e.Graphics, e.Bounds)
				editor.PaintValue(args)
			End If
		End Sub
	End Class
End Namespace
