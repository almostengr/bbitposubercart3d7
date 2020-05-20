<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updatePOSStoreData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(updatePOSStoreData))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.updateStorePictureBox = New System.Windows.Forms.PictureBox()
        Me.updateProductPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.updateCustomerPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.updateStorePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updateProductPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updateCustomerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Update Store Information"
        '
        'updateStorePictureBox
        '
        Me.updateStorePictureBox.Image = Global.BbitPosUbercart3D7.My.Resources.Resources.arrow
        Me.updateStorePictureBox.Location = New System.Drawing.Point(12, 12)
        Me.updateStorePictureBox.Name = "updateStorePictureBox"
        Me.updateStorePictureBox.Size = New System.Drawing.Size(46, 17)
        Me.updateStorePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.updateStorePictureBox.TabIndex = 4
        Me.updateStorePictureBox.TabStop = False
        Me.updateStorePictureBox.Visible = False
        '
        'updateProductPictureBox
        '
        Me.updateProductPictureBox.Image = Global.BbitPosUbercart3D7.My.Resources.Resources.arrow
        Me.updateProductPictureBox.Location = New System.Drawing.Point(12, 35)
        Me.updateProductPictureBox.Name = "updateProductPictureBox"
        Me.updateProductPictureBox.Size = New System.Drawing.Size(46, 17)
        Me.updateProductPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.updateProductPictureBox.TabIndex = 6
        Me.updateProductPictureBox.TabStop = False
        Me.updateProductPictureBox.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Update Product Database"
        '
        'updateCustomerPictureBox
        '
        Me.updateCustomerPictureBox.Image = Global.BbitPosUbercart3D7.My.Resources.Resources.arrow
        Me.updateCustomerPictureBox.Location = New System.Drawing.Point(12, 58)
        Me.updateCustomerPictureBox.Name = "updateCustomerPictureBox"
        Me.updateCustomerPictureBox.Size = New System.Drawing.Size(46, 17)
        Me.updateCustomerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.updateCustomerPictureBox.TabIndex = 8
        Me.updateCustomerPictureBox.TabStop = False
        Me.updateCustomerPictureBox.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Update Customer Database"
        '
        'updatePOSStoreData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 144)
        Me.Controls.Add(Me.updateCustomerPictureBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.updateProductPictureBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.updateStorePictureBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(351, 176)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(351, 176)
        Me.Name = "updatePOSStoreData"
        Me.ShowInTaskbar = False
        Me.Text = "Update BBIT POS Store Data"
        CType(Me.updateStorePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updateProductPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updateCustomerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents updateStorePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents updateProductPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents updateCustomerPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
