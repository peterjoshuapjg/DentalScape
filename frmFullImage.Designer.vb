<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFullImage
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
        Me.picFullImage = New System.Windows.Forms.PictureBox()
        CType(Me.picFullImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picFullImage
        '
        Me.picFullImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picFullImage.Location = New System.Drawing.Point(0, 0)
        Me.picFullImage.Name = "picFullImage"
        Me.picFullImage.Size = New System.Drawing.Size(1904, 1041)
        Me.picFullImage.TabIndex = 0
        Me.picFullImage.TabStop = False
        '
        'frmFullImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.picFullImage)
        Me.Name = "frmFullImage"
        Me.Text = "frmFullImage"
        CType(Me.picFullImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picFullImage As PictureBox
End Class
