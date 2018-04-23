using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;

namespace dxPaintValue
{
    public class MyClass
    {
        private string s;

        [Editor(typeof(MyPropertyEditor), typeof(UITypeEditor))]
        public string S
        {
            get { return s; }
            set { s = value; }
        }
    }
}
