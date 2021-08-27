<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128638559/13.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T124141)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
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


