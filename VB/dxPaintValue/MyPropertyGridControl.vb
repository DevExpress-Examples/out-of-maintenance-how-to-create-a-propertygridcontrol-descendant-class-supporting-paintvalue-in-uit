Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Linq
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.Data
Imports DevExpress.XtraVerticalGrid.Rows

Namespace dxPaintValue
	<ToolboxItem(True)> _
	Public Class MyPropertyGridControl
		Inherits PropertyGridControl
		Protected Overrides Function CreatePainterCore(ByVal eventHelper As DevExpress.XtraVerticalGrid.Painters.PaintEventHelper) As DevExpress.XtraVerticalGrid.Painters.VGridPainter
			Return New MyVGridPainter(eventHelper)
		End Function
		Public Function GetUITypeEditor(ByVal context As DescriptorContext) As UITypeEditor
			Dim propertyDescriptor As PropertyDescriptor = context.PropertyDescriptor
			Dim customEditor As UITypeEditor
			If CustomUITypeEditors.TryGetValue(propertyDescriptor.Name, customEditor) Then
				Return customEditor
			End If
			Try
				Return TryCast(propertyDescriptor.GetEditor(GetType(UITypeEditor)), UITypeEditor)
			Catch
				Return Nothing
			End Try
		End Function
		Public Function GetDescriptorContext(ByVal properties As RowProperties) As DescriptorContext
			Return DataModeHelper.GetDescriptorContext(properties.FieldName)
		End Function
	End Class
End Namespace
