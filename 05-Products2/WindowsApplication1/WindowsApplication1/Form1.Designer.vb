<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProductId = New System.Windows.Forms.TextBox()
        Me.txtCurrentQuantity = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.cmboQuantityType = New System.Windows.Forms.ComboBox()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.txtDealerPrice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(387, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Product ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Current Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(286, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Product Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(286, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Unit Price"
        '
        'txtProductId
        '
        Me.txtProductId.Location = New System.Drawing.Point(144, 48)
        Me.txtProductId.Name = "txtProductId"
        Me.txtProductId.Size = New System.Drawing.Size(100, 22)
        Me.txtProductId.TabIndex = 5
        '
        'txtCurrentQuantity
        '
        Me.txtCurrentQuantity.Location = New System.Drawing.Point(144, 102)
        Me.txtCurrentQuantity.Name = "txtCurrentQuantity"
        Me.txtCurrentQuantity.Size = New System.Drawing.Size(100, 22)
        Me.txtCurrentQuantity.TabIndex = 6
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(390, 45)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(100, 22)
        Me.txtProductName.TabIndex = 7
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Location = New System.Drawing.Point(390, 105)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(100, 22)
        Me.txtUnitPrice.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(84, 164)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 43)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "New Product"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(222, 164)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 43)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Delete Product"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(366, 164)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 43)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "UpdateProduct"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(515, 164)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(198, 43)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "ViewProductDetails"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'cmboQuantityType
        '
        Me.cmboQuantityType.FormattingEnabled = True
        Me.cmboQuantityType.Location = New System.Drawing.Point(222, 245)
        Me.cmboQuantityType.Name = "cmboQuantityType"
        Me.cmboQuantityType.Size = New System.Drawing.Size(121, 24)
        Me.cmboQuantityType.TabIndex = 13
        '
        'dgvProducts
        '
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Location = New System.Drawing.Point(84, 342)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.RowTemplate.Height = 24
        Me.dgvProducts.Size = New System.Drawing.Size(629, 111)
        Me.dgvProducts.TabIndex = 14
        '
        'txtDealerPrice
        '
        Me.txtDealerPrice.Location = New System.Drawing.Point(613, 105)
        Me.txtDealerPrice.Name = "txtDealerPrice"
        Me.txtDealerPrice.Size = New System.Drawing.Size(100, 22)
        Me.txtDealerPrice.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(512, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Dealer Price"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(84, 235)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(109, 43)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Export/Import Quantity"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(366, 247)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 22)
        Me.txtQuantity.TabIndex = 18
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(515, 226)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(198, 43)
        Me.Button6.TabIndex = 19
        Me.Button6.Text = "Update and Save"
        Me.Button6.UseVisualStyleBackColor = True
        Me.Button6.Visible = False
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(307, 299)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(119, 29)
        Me.Button7.TabIndex = 20
        Me.Button7.Text = "Clear"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 528)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDealerPrice)
        Me.Controls.Add(Me.dgvProducts)
        Me.Controls.Add(Me.cmboQuantityType)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtUnitPrice)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.txtCurrentQuantity)
        Me.Controls.Add(Me.txtProductId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Product Details"
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtProductId As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrentQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents txtUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents cmboQuantityType As System.Windows.Forms.ComboBox
    Friend WithEvents dgvProducts As System.Windows.Forms.DataGridView
    Friend WithEvents txtDealerPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button

End Class
