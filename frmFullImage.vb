Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms

''' <summary>Full-screen viewer for one medical image (opened from the Action > View button of the Medical Imaging tab).</summary>
Public Class frmFullImage
    Public Property Logo As Image
    Private WithEvents pd As New PrintDocument()
    Public Property Patient As New PatientRecord()

    ' Set these from Form1 before ShowDialog
    Public Property ImageType As String = ""
    Public Property ImageDate As String = ""
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

    Private Sub frmFullImage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pd.DefaultPageSettings.PaperSize = New PaperSize("A4", 827, 1169)
        pd.DefaultPageSettings.Margins = New Margins(50, 50, 50, 50)
        pd.DefaultPageSettings.Landscape = False

        Me.Text = "DentalScape - Medical Imaging Viewer"
        Me.WindowState = FormWindowState.Maximized
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.Black

        picFullImage.Dock = DockStyle.Fill
        picFullImage.SizeMode = PictureBoxSizeMode.Zoom
        picFullImage.BackColor = Color.Black

        ' Docked picture box would otherwise hide the button
        msPrint.Anchor = AnchorStyles.Top Or AnchorStyles.Right

    End Sub

    Private Sub frmFullImage_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If picFullImage.Image IsNot Nothing Then
            Dim oldImage As Image = picFullImage.Image
            picFullImage.Image = Nothing
            oldImage.Dispose()
        End If
    End Sub

    Private Sub msPrint_Click(sender As Object, e As EventArgs) Handles msPrint.Click
        If picFullImage.Image Is Nothing Then
            MessageBox.Show("No image to print.")
            Return
        End If

        Using preview As New PrintPreviewDialog()
            preview.Document = pd
            preview.WindowState = FormWindowState.Maximized
            preview.ShowDialog()
        End Using
    End Sub
    ' =========================
    ' DRAW THE A4 PAGE
    ' =========================
    Private Sub pd_PrintPage(sender As Object, e As PrintPageEventArgs) Handles pd.PrintPage

        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        g.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit

        Dim img As Image = picFullImage.Image
        Dim p As PatientRecord = Patient

        Dim m As Rectangle = e.MarginBounds
        Dim x As Single = m.Left
        Dim w As Single = m.Width
        Dim y As Single = m.Top

        Dim navy As Color = Color.FromArgb(13, 49, 127)

        Using fTitle As New Font("Segoe UI", 20, FontStyle.Bold),
          fSub As New Font("Segoe UI", 9),
          fDoc As New Font("Segoe UI", 14, FontStyle.Bold),
          fSmall As New Font("Segoe UI", 8),
          penLine As New Pen(navy, 2),
          penThin As New Pen(Color.Gray, 1),
          brBlue As New SolidBrush(navy),
          center As New StringFormat() With {.Alignment = StringAlignment.Center}

            ' ================= HEADER (logo left, clinic text beside it) =================
            Dim headerTop As Single = y
            Dim logoW As Single = 0
            Dim logoH As Single = 0
            Dim sideW As Single = 0          ' space reserved on each side for the logo

            If Logo IsNot Nothing Then
                Dim r As Single = Math.Min(90.0F / Logo.Width, 70.0F / Logo.Height)
                logoW = Logo.Width * r
                logoH = Logo.Height * r
                sideW = logoW + 12           ' logo width + gap
            End If

            ' Text stays centered on the page, clear of the logo
            Dim textX As Single = x + sideW
            Dim textW As Single = w - 2 * sideW

            Dim nameH As Single = g.MeasureString(p.ClinicName, fTitle, CInt(textW)).Height
            Dim infoH As Single = g.MeasureString(p.ClinicInfo, fSub, CInt(textW)).Height
            Dim textH As Single = nameH + 2 + infoH

            ' Header row height = whichever is taller, logo or text
            Dim headerH As Single = Math.Max(logoH, textH)

            ' Logo: left edge, vertically centered in the header row
            If Logo IsNot Nothing Then
                g.DrawImage(Logo, x, headerTop + (headerH - logoH) / 2, logoW, logoH)
            End If

            ' Clinic name + info: vertically centered in the same row
            Dim ty As Single = headerTop + (headerH - textH) / 2
            g.DrawString(p.ClinicName, fTitle, brBlue, New RectangleF(textX, ty, textW, nameH), center)
            g.DrawString(p.ClinicInfo, fSub, Brushes.DimGray, New RectangleF(textX, ty + nameH + 2, textW, infoH), center)

            y = headerTop + headerH + 8

            ' Divider line
            g.DrawLine(penLine, x, y, x + w, y)
            y += 12

            ' Report title
            Dim docTitle As String = "DENTAL IMAGING REPORT"
            Dim titleH As Single = g.MeasureString(docTitle, fDoc).Height
            g.DrawString(docTitle, fDoc, Brushes.Black, New RectangleF(x, y, w, titleH), center)
            y += titleH + 14

            ' ================= PATIENT INFORMATION =================
            y = DrawSectionTitle(g, "PATIENT INFORMATION", x, y, w)

            Dim colW As Single = (w - 20) / 2
            Dim x2 As Single = x + colW + 20

            Dim yL As Single = y
            yL = DrawField(g, "Patient Name", p.PatientName, x, yL, colW)
            yL = DrawField(g, "Date of Birth", p.DateOfBirth, x, yL, colW)
            yL = DrawField(g, "Gender", p.Gender, x, yL, colW)
            yL = DrawField(g, "Contact No.", p.ContactNo, x, yL, colW)

            Dim yR As Single = y
            yR = DrawField(g, "Patient ID", p.PatientId, x2, yR, colW)
            yR = DrawField(g, "Age", p.Age, x2, yR, colW)
            yR = DrawField(g, "Visit Date", p.VisitDate, x2, yR, colW)

            y = Math.Max(yL, yR)
            y = DrawField(g, "Address", p.Address, x, y, w)
            y += 6

            ' ================= MEDICAL INFORMATION =================
            y = DrawSectionTitle(g, "MEDICAL INFORMATION", x, y, w)
            y = DrawField(g, "Allergies", p.Allergies, x, y, w)
            y = DrawField(g, "Diagnosis", p.Diagnosis, x, y, w)
            y = DrawField(g, "Medications / Prescription", p.Medications, x, y, w)
            y = DrawField(g, "Notes", p.Notes, x, y, w)
            y += 6

            ' ================= IMAGE =================
            Dim imgTitle As String = "ATTACHED IMAGE"
            If ImageType <> "" Then imgTitle &= " - " & ImageType
            If ImageDate <> "" Then imgTitle &= " (" & ImageDate & ")"
            y = DrawSectionTitle(g, imgTitle, x, y, w)

            Dim sigHeight As Single = 70
            Dim footerHeight As Single = 25
            Dim imgBoxBottom As Single = m.Bottom - sigHeight - footerHeight
            Dim imgBox As New RectangleF(x, y, w, Math.Max(50, imgBoxBottom - y))

            g.DrawRectangle(penThin, imgBox.X, imgBox.Y, imgBox.Width, imgBox.Height)

            If img IsNot Nothing Then
                Dim r As Single = Math.Min((imgBox.Width - 10) / img.Width,
                                       (imgBox.Height - 10) / img.Height)
                Dim iw As Single = img.Width * r
                Dim ih As Single = img.Height * r
                g.DrawImage(img,
                        imgBox.X + (imgBox.Width - iw) / 2,
                        imgBox.Y + (imgBox.Height - ih) / 2,
                        iw, ih)
            End If

            ' ================= SIGNATURES =================
            Dim ySig As Single = m.Bottom - footerHeight - 40
            Dim sigW As Single = 220
            g.DrawLine(penThin, x, ySig, x + sigW, ySig)
            g.DrawString("Patient Signature", fSmall, Brushes.DimGray, x, ySig + 3)
            g.DrawLine(penThin, x + w - sigW, ySig, x + w, ySig)
            g.DrawString("Dentist Signature", fSmall, Brushes.DimGray, x + w - sigW, ySig + 3)

            ' ================= FOOTER =================
            Dim yFoot As Single = m.Bottom - 15
            g.DrawLine(penThin, x, yFoot - 4, x + w, yFoot - 4)
            g.DrawString("Printed: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm"),
                     fSmall, Brushes.Gray, x, yFoot)

            Dim conf As String = "CONFIDENTIAL - Patient record"
            Dim cs As SizeF = g.MeasureString(conf, fSmall)
            g.DrawString(conf, fSmall, Brushes.Gray, x + w - cs.Width, yFoot)
        End Using

        e.HasMorePages = False
    End Sub

    ' =========================
    ' HELPERS
    ' =========================
    Private Function DrawSectionTitle(g As Graphics, title As String,
                                      x As Single, y As Single, w As Single) As Single
        Using f As New Font("Segoe UI", 10, FontStyle.Bold),
              bg As New SolidBrush(Color.FromArgb(13, 49, 127))
            g.FillRectangle(bg, x, y, w, 22)
            g.DrawString(title, f, Brushes.White, x + 6, y + 2)
        End Using
        Return y + 28
    End Function

    Private Function DrawField(g As Graphics, label As String, value As String,
                               x As Single, y As Single, w As Single) As Single
        If value Is Nothing Then value = ""
        Using fLabel As New Font("Segoe UI", 8, FontStyle.Bold),
              fValue As New Font("Segoe UI", 10)
            g.DrawString(label.ToUpper(), fLabel, Brushes.DimGray, x, y)
            y += 14
            Dim h As Single = g.MeasureString(value, fValue, CInt(w)).Height
            g.DrawString(value, fValue, Brushes.Black, New RectangleF(x, y, w, h))
            Return y + h + 8
        End Using
    End Function
    Public Class PatientRecord
        Public Property ClinicName As String = "DentalScape"
        Public Property ClinicInfo As String = "
Maclane Center San Antonio, San Pedro, Philippines  |  Cel: 0992 642 0150"
        Public Property PatientName As String = ""
        Public Property PatientId As String = ""
        Public Property DateOfBirth As String = ""
        Public Property Age As String = ""
        Public Property Gender As String = ""
        Public Property ContactNo As String = ""
        Public Property Address As String = ""
        Public Property VisitDate As String = DateTime.Now.ToString("yyyy-MM-dd")
        Public Property Physician As String = ""
        Public Property Allergies As String = ""
        Public Property Diagnosis As String = ""
        Public Property Medications As String = ""
        Public Property Notes As String = ""
    End Class
    ''' <summary>Opens the print preview straight away (used by the Print button in the image list).</summary>
    Public Sub PrintReport(owner As IWin32Window)
        Try
            If picFullImage.Image Is Nothing Then
                MessageBox.Show(owner, "No image to print.")
                Return
            End If

            pd.DefaultPageSettings.PaperSize = New PaperSize("A4", 827, 1169)
            pd.DefaultPageSettings.Margins = New Margins(50, 50, 50, 50)
            pd.DefaultPageSettings.Landscape = False

            Using preview As New PrintPreviewDialog()
                preview.Document = pd
                preview.WindowState = FormWindowState.Maximized
                preview.ShowDialog(owner)      ' closing it just returns to the caller
            End Using
        Finally
            If picFullImage.Image IsNot Nothing Then
                Dim old As Image = picFullImage.Image
                picFullImage.Image = Nothing
                old.Dispose()
            End If
        End Try
    End Sub
End Class
