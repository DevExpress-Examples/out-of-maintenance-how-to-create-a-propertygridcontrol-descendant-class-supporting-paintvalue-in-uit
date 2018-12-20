Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraVerticalGrid.Data
Imports DevExpress.XtraVerticalGrid.Events
Imports DevExpress.XtraVerticalGrid.Painters
Imports DevExpress.XtraVerticalGrid.Rows
Imports DevExpress.XtraVerticalGrid.ViewInfo
Imports System.Drawing
Imports System.Drawing.Design

Namespace dxPaintValue
    Public Class MyVGridPainter
        Inherits VGridPainter

        Public Sub New(ByVal eventHelper As PaintEventHelper)
            MyBase.New(eventHelper)
        End Sub

        Protected Overrides Sub DrawRowValueCellCore(ByVal e As CustomDrawRowValueCellEventArgs, ByVal pb As BaseEditPainter, ByVal bvi As BaseEditViewInfo, ByVal vi As BaseViewInfo)
            Dim grid As MyPropertyGridControl = CType(vi.Grid, MyPropertyGridControl)
            Dim properties As RowProperties = e.Row.GetRowProperties(e.CellIndex)
            Dim context As DescriptorContext = grid.GetDescriptorContext(properties)
            Dim editor As UITypeEditor = grid.GetUITypeEditor(context)
            If editor IsNot Nothing AndAlso editor.GetPaintValueSupported() Then
                Dim indent As Integer = 1
                Dim size As New Size(e.Bounds.Size.Height - 2 * indent, e.Bounds.Size.Height - 2 * indent)
                Dim bounds As New Rectangle(e.Bounds.X + indent, e.Bounds.Y + indent, size.Width, size.Height)
                Dim args As New PaintValueEventArgs(context, grid.GetCellValue(properties.Row, 0), e.Cache.Graphics, bounds)
                editor.PaintValue(args)
                e.Cache.DrawRectangle(Pens.DarkGray, bounds)
                Dim textBounds As New Rectangle(e.Bounds.X + bounds.Width + 2 * indent+ indent, e.Bounds.Y, e.Bounds.Width - bounds.Width + 2 * indent, e.Bounds.Height)
                grid.Appearance.RecordValue.DrawString(e.Cache, grid.GetCellDisplayText(properties.Row, 0), textBounds)
            Else
                MyBase.DrawRowValueCellCore(e, pb, bvi, vi)
            End If
        End Sub
    End Class
End Namespace
