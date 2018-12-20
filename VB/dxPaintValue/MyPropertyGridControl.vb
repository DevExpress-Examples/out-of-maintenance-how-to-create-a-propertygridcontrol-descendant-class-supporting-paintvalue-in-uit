Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.Data
Imports DevExpress.XtraVerticalGrid.Rows
Imports System.ComponentModel
Imports System.Drawing.Design

Namespace dxPaintValue
    <ToolboxItem(True)> _
    Public Class MyPropertyGridControl
        Inherits PropertyGridControl

        Protected Overrides Function CreatePainterCore(ByVal eventHelper As DevExpress.XtraVerticalGrid.Painters.PaintEventHelper) As DevExpress.XtraVerticalGrid.Painters.VGridPainter
            Return New MyVGridPainter(eventHelper)
        End Function
        Public Function GetUITypeEditor(ByVal context As DescriptorContext) As UITypeEditor
            Return TryCast(context.PropertyDescriptor.GetEditor(GetType(UITypeEditor)), UITypeEditor)
        End Function
        Public Function GetDescriptorContext(ByVal properties As RowProperties) As DescriptorContext
            Return DataModeHelper.GetDescriptorContext(properties.FieldName)
        End Function
    End Class
End Namespace
