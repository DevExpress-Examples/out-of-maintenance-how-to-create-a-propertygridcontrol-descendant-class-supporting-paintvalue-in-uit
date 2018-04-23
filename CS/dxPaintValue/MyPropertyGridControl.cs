using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using DevExpress.XtraVerticalGrid;
using DevExpress.XtraVerticalGrid.Data;
using DevExpress.XtraVerticalGrid.Rows;

namespace dxPaintValue
{
    [ToolboxItem(true)]
    public class MyPropertyGridControl : PropertyGridControl
    {
        protected override DevExpress.XtraVerticalGrid.Painters.VGridPainter CreatePainterCore(DevExpress.XtraVerticalGrid.Painters.PaintEventHelper eventHelper)
        {  
            return new MyVGridPainter(eventHelper);
        }
        public UITypeEditor GetUITypeEditor(DescriptorContext context)
        {
            PropertyDescriptor propertyDescriptor = context.PropertyDescriptor;
            UITypeEditor customEditor;
            if (CustomUITypeEditors.TryGetValue(propertyDescriptor.Name, out customEditor))
                return customEditor;
            try
            {
                return propertyDescriptor.GetEditor(typeof(UITypeEditor)) as UITypeEditor;
            }
            catch
            {
                return null;
            }
        }
        public DescriptorContext GetDescriptorContext(RowProperties properties)
        {
            return DataModeHelper.GetDescriptorContext(properties.FieldName);
        }
    }
}
