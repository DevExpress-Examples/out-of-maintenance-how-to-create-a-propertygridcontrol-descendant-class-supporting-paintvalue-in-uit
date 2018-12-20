Namespace dxPaintValue
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
            Me.myPropertyGridControl1 = New dxPaintValue.MyPropertyGridControl()
            CType(Me.myPropertyGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' propertyGrid1
            ' 
            Me.propertyGrid1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.propertyGrid1.Location = New System.Drawing.Point(12, 218)
            Me.propertyGrid1.Name = "propertyGrid1"
            Me.propertyGrid1.Size = New System.Drawing.Size(631, 196)
            Me.propertyGrid1.TabIndex = 0
            ' 
            ' myPropertyGridControl1
            ' 
            Me.myPropertyGridControl1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.myPropertyGridControl1.Location = New System.Drawing.Point(12, 12)
            Me.myPropertyGridControl1.Name = "myPropertyGridControl1"
            Me.myPropertyGridControl1.Size = New System.Drawing.Size(631, 200)
            Me.myPropertyGridControl1.TabIndex = 2
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(657, 426)
            Me.Controls.Add(Me.myPropertyGridControl1)
            Me.Controls.Add(Me.propertyGrid1)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "How to create a PropertyGridControl descendant class supporting PaintValue in UIT" & "ypeEditor"
            CType(Me.myPropertyGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private propertyGrid1 As System.Windows.Forms.PropertyGrid
        Private myPropertyGridControl1 As MyPropertyGridControl
    End Class
End Namespace

