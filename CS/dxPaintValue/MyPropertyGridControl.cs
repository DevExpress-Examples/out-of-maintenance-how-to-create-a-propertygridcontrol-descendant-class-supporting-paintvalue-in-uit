using DevExpress.XtraVerticalGrid;
using DevExpress.XtraVerticalGrid.Data;
using DevExpress.XtraVerticalGrid.Rows;
using System.ComponentModel;
using System.Drawing.Design;

namespace dxPaintValue {
    [ToolboxItem(true)]
    public class MyPropertyGridControl : PropertyGridControl {
        protected override DevExpress.XtraVerticalGrid.Painters.VGridPainter CreatePainterCore(DevExpress.XtraVerticalGrid.Painters.PaintEventHelper eventHelper) {
            return new MyVGridPainter(eventHelper);
        }
        public UITypeEditor GetUITypeEditor(DescriptorContext context) {
            return context.PropertyDescriptor.GetEditor(typeof(UITypeEditor)) as UITypeEditor;
        }
        public DescriptorContext GetDescriptorContext(RowProperties properties) {
            return DataModeHelper.GetDescriptorContext(properties.FieldName);
        }
    }
}
