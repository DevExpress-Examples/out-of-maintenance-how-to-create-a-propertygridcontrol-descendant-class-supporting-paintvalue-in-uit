using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;

namespace dxPaintValue {
    public class MyPropertyEditor : UITypeEditor {
        public override bool GetPaintValueSupported(ITypeDescriptorContext context) {
            return true;
        }

        public override void PaintValue(PaintValueEventArgs e) {
            if(e.Value == null)
                return;
            Color color = Color.FromName(e.Value as string);
            if(!color.IsEmpty)
                using(SolidBrush brush = new SolidBrush(color))
                    e.Graphics.FillRectangle(brush, e.Bounds);
        }
    }
}
