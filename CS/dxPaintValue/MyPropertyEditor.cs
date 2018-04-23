using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;

namespace dxPaintValue
{
    public class MyPropertyEditor : UITypeEditor
    {
        public override bool GetPaintValueSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override void PaintValue(PaintValueEventArgs e)
        {
           e.Graphics.DrawString("JHGJHG", new Font("Verdana", 8.0f), Brushes.BlueViolet, new PointF(e.Bounds.X + 2, e.Bounds.Y + 2));
        }
    }
}
