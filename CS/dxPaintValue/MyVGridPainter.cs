using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraVerticalGrid.Painters;
using DevExpress.XtraVerticalGrid.Events;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraVerticalGrid.ViewInfo;
using System.Drawing.Design;
using DevExpress.XtraVerticalGrid.Rows;
using System.ComponentModel;
using DevExpress.XtraVerticalGrid.Data;

namespace dxPaintValue
{
    public class MyVGridPainter : VGridPainter
    {
        public MyVGridPainter(PaintEventHelper eventHelper)
            : base(eventHelper)
        {
            
        }
        protected override void DrawRowValueCellCore(CustomDrawRowValueCellEventArgs e, BaseEditPainter pb, BaseEditViewInfo bvi, BaseViewInfo vi)
        {
            base.DrawRowValueCellCore(e, pb, bvi, vi);
            MyPropertyGridControl propertyGridControl = (MyPropertyGridControl)vi.Grid;
            RowProperties rowProperties = e.Row.GetRowProperties(e.CellIndex);
            DescriptorContext context = propertyGridControl.GetDescriptorContext(rowProperties);
            UITypeEditor editor = propertyGridControl.GetUITypeEditor(context);
            if (editor != null && editor.GetPaintValueSupported())
            {
                PaintValueEventArgs args = new PaintValueEventArgs((ITypeDescriptorContext)context, null, e.Graphics, e.Bounds);
                editor.PaintValue(args);
            }
        }
    }
}
