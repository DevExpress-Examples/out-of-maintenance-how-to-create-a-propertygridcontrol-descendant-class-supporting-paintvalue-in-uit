using System.ComponentModel;
using System.Drawing.Design;

namespace dxPaintValue {
    public class MyClass {
        [Editor(typeof(MyPropertyEditor), typeof(UITypeEditor))]
        public string Color { get; set; }
    }
}
