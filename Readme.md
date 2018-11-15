<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/dxPaintValue/Form1.cs) (VB: [Form1.vb](./VB/dxPaintValue/Form1.vb))
* [MyClass.cs](./CS/dxPaintValue/MyClass.cs) (VB: [MyClass.vb](./VB/dxPaintValue/MyClass.vb))
* [MyPropertyEditor.cs](./CS/dxPaintValue/MyPropertyEditor.cs) (VB: [MyPropertyEditor.vb](./VB/dxPaintValue/MyPropertyEditor.vb))
* [MyPropertyGridControl.cs](./CS/dxPaintValue/MyPropertyGridControl.cs) (VB: [MyPropertyGridControl.vb](./VB/dxPaintValue/MyPropertyGridControl.vb))
* [MyVGridPainter.cs](./CS/dxPaintValue/MyVGridPainter.cs) (VB: [MyVGridPainter.vb](./VB/dxPaintValue/MyVGridPainter.vb))
<!-- default file list end -->
# How to create a PropertyGridControl descendant class supporting PaintValue in UITypeEditor


<p> </p>
<p>This example demonstrates how to create PropertyGridControl and VGridPainter descendant classes. To support PaintValue in UITypeEditor, it's necessary to add a method to get UITypeEditor in your PropertyGridControl class and override the DrawRowValueCellCore method in the VGridControl class.</p>

<br/>


