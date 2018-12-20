using System.Windows.Forms;

namespace dxPaintValue {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            MyClass c = new MyClass() { Color = "Orange" };
            propertyGrid1.SelectedObject = c;
            myPropertyGridControl1.SelectedObject = c;
        }
    }
}
