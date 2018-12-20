using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraVerticalGrid.Data;
using DevExpress.XtraVerticalGrid.Events;
using DevExpress.XtraVerticalGrid.Painters;
using DevExpress.XtraVerticalGrid.Rows;
using DevExpress.XtraVerticalGrid.ViewInfo;
using System.Drawing;
using System.Drawing.Design;

namespace dxPaintValue {
    public class MyVGridPainter : VGridPainter {
        public MyVGridPainter(PaintEventHelper eventHelper) : base(eventHelper) { }

        protected override void DrawRowValueCellCore(CustomDrawRowValueCellEventArgs e, BaseEditPainter pb, BaseEditViewInfo bvi, BaseViewInfo vi) {
            MyPropertyGridControl grid = (MyPropertyGridControl)vi.Grid;
            RowProperties properties = e.Row.GetRowProperties(e.CellIndex);
            DescriptorContext context = grid.GetDescriptorContext(properties);
            UITypeEditor editor = grid.GetUITypeEditor(context);
            if(editor != null && editor.GetPaintValueSupported()) {
                int indent = 1;
                Size size = new Size(e.Bounds.Size.Height - 2 * indent, e.Bounds.Size.Height - 2 * indent);
                Rectangle bounds = new Rectangle(e.Bounds.X + indent, e.Bounds.Y + indent, size.Width, size.Height);
                PaintValueEventArgs args = new PaintValueEventArgs(context, grid.GetCellValue(properties.Row, 0), e.Cache.Graphics, bounds);
                editor.PaintValue(args);
                e.Cache.DrawRectangle(Pens.DarkGray, bounds);
                Rectangle textBounds = new Rectangle(e.Bounds.X + bounds.Width + 2 * indent+ indent, e.Bounds.Y, e.Bounds.Width - bounds.Width + 2 * indent, e.Bounds.Height);
                grid.Appearance.RecordValue.DrawString(e.Cache, grid.GetCellDisplayText(properties.Row, 0), textBounds);
            }
            else
                base.DrawRowValueCellCore(e, pb, bvi, vi);
        }
    }
}
