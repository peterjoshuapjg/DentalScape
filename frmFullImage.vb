Imports System.Drawing
Imports System.Windows.Forms

''' <summary>Full-screen viewer for one medical image (opened from the Action > View button of the Medical Imaging tab).</summary>
Public Class frmFullImage

    Public Sub New()
        InitializeComponent()
    End Sub

    ''' <summary>Shows <paramref name="img"/>; this form owns the image and disposes it when it closes.</summary>
    Public Sub New(img As Image, caption As String)
        InitializeComponent()
        Me.Text = caption
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.WindowState = FormWindowState.Maximized
        Me.KeyPreview = True
        Me.BackColor = Color.Black
        picFullImage.BackColor = Color.Black
        picFullImage.SizeMode = PictureBoxSizeMode.Zoom
        picFullImage.Image = img
    End Sub

    ' Esc or a double-click closes the viewer.
    Private Sub frmFullImage_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub picFullImage_DoubleClick(sender As Object, e As EventArgs) Handles picFullImage.DoubleClick
        Me.Close()
    End Sub

    Private Sub frmFullImage_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If picFullImage.Image IsNot Nothing Then
            picFullImage.Image.Dispose()
            picFullImage.Image = Nothing
        End If
    End Sub

End Class
