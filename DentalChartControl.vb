Imports System.Drawing.Drawing2D

''' <summary>
''' Odontogram (adult, FDI numbering 11-18, 21-28, 31-38, 41-48) drawn with GDI+.
''' Click a tooth to select it; use SetCondition to colour/mark a tooth.
''' </summary>
Public Class DentalChartControl
    Inherits Control

    Public Event ToothClicked(tooth As Integer)

    Private ReadOnly _conditions As New Dictionary(Of Integer, String)
    Private ReadOnly _rects As New Dictionary(Of Integer, Rectangle)
    Private _selected As Integer = 0
    Private _hover As Integer = 0

    Private Shared ReadOnly UpperOrder() As Integer = {18, 17, 16, 15, 14, 13, 12, 11, 21, 22, 23, 24, 25, 26, 27, 28}
    Private Shared ReadOnly LowerOrder() As Integer = {48, 47, 46, 45, 44, 43, 42, 41, 31, 32, 33, 34, 35, 36, 37, 38}

    Public Sub New()
        ' Enable double buffering, user paint and resize redraw for smooth rendering
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint Or ControlStyles.Selectable, True)
        BackColor = Color.White
        ' Use a system font which scales with DPI rather than a hard-coded font size
        Font = SystemFonts.MessageBoxFont
        Cursor = Cursors.Hand
    End Sub

    ' Removed accidental shadowing SetStyle implementation that caused a NotImplementedException

#Region "Public API"

    Public Property SelectedTooth As Integer
        Get
            Return _selected
        End Get
        Set(value As Integer)
            If value <> 0 AndAlso Not IsValidTooth(value) Then value = 0
            If _selected <> value Then
                _selected = value
                Invalidate()
            End If
        End Set
    End Property

    Public Shared Function IsValidTooth(n As Integer) As Boolean
        Dim q As Integer = n \ 10
        Dim p As Integer = n Mod 10
        Return q >= 1 AndAlso q <= 4 AndAlso p >= 1 AndAlso p <= 8
    End Function

    Public Sub SetCondition(tooth As Integer, condition As String)
        If Not IsValidTooth(tooth) Then Return
        If String.IsNullOrWhiteSpace(condition) OrElse condition.Equals("Healthy", StringComparison.OrdinalIgnoreCase) Then
            _conditions.Remove(tooth)
        Else
            _conditions(tooth) = condition.Trim()
        End If
        Invalidate()
    End Sub

    Public Function GetCondition(tooth As Integer) As String
        Dim c As String = Nothing
        If _conditions.TryGetValue(tooth, c) Then Return c
        Return ""
    End Function

    Public Sub ClearConditions()
        _conditions.Clear()
        Invalidate()
    End Sub

#End Region

#Region "Mouse"

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        Dim t As Integer = HitTest(e.Location)
        If t <> _hover Then
            _hover = t
            Invalidate()
        End If
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        If _hover <> 0 Then
            _hover = 0
            Invalidate()
        End If
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        Dim t As Integer = HitTest(e.Location)
        If t <> 0 Then
            _selected = t
            Invalidate()
            RaiseEvent ToothClicked(t)
        End If
    End Sub

    Private Function HitTest(p As Point) As Integer
        For Each kv In _rects
            If kv.Value.Contains(p) Then Return kv.Key
        Next
        Return 0
    End Function

#End Region

#Region "Painting"

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim g As Graphics = e.Graphics
        g.Clear(BackColor)
        g.SmoothingMode = SmoothingMode.AntiAlias
        g.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        _rects.Clear()

        Dim legendH As Integer = 26
        Dim numH As Integer = 16
        Dim availW As Single = Width - 24
        Dim availH As Single = Height - legendH - 8
        Dim fixedH As Single = 2 * (numH + 6) + 12
        Dim sw As Single = Math.Min(60.0F, Math.Min(availW / 16.5F, (availH - fixedH) / 4.64F))
        If sw < 14 Then Return

        Dim sideH As Single = sw * 1.7F
        Dim occ As Single = sw * 0.62F
        Dim totalW As Single = sw * 16 + sw * 0.5F
        Dim x0 As Single = (Width - totalW) / 2.0F
        Dim y As Single = 4

        ' vertical bands
        Dim upSideTop As Single = y
        Dim upOccTop As Single = upSideTop + sideH + 3
        Dim upNumTop As Single = upOccTop + occ + 2
        Dim divY As Single = upNumTop + numH + 5
        Dim loNumTop As Single = divY + 5
        Dim loOccTop As Single = loNumTop + numH + 1
        Dim loSideTop As Single = loOccTop + occ + 3
        Dim bottom As Single = loSideTop + sideH

        Using pen As New Pen(Color.FromArgb(150, 150, 150), 1.0F)
            g.DrawLine(pen, x0, divY, x0 + totalW, divY)
            ' midline
            Dim mx As Single = x0 + sw * 8 + sw * 0.25F
            Using dash As New Pen(Color.FromArgb(200, 200, 200), 1.0F)
                dash.DashStyle = DashStyle.Dash
                g.DrawLine(dash, mx, upSideTop, mx, bottom)
            End Using
        End Using

        For i As Integer = 0 To 15
            Dim gap As Single = If(i >= 8, sw * 0.5F, 0.0F)
            Dim cx As Single = x0 + i * sw + gap

            DrawToothColumn(g, UpperOrder(i), True, cx, sw, upSideTop, sideH, upOccTop, occ, upNumTop, numH)
            DrawToothColumn(g, LowerOrder(i), False, cx, sw, loSideTop, sideH, loOccTop, occ, loNumTop, numH)

            _rects(UpperOrder(i)) = Rectangle.Round(New RectangleF(cx, upSideTop, sw, upNumTop + numH - upSideTop))
            _rects(LowerOrder(i)) = Rectangle.Round(New RectangleF(cx, loNumTop, sw, loSideTop + sideH - loNumTop))
        Next

        DrawLegend(g, Height - legendH + 4)
    End Sub

    Private Sub DrawToothColumn(g As Graphics, tooth As Integer, isUpper As Boolean, cx As Single, sw As Single,
                                sideTop As Single, sideH As Single, occTop As Single, occ As Single,
                                numTop As Single, numH As Single)
        Dim cond As String = GetCondition(tooth)
        Dim missing As Boolean = IsMissing(cond)
        Dim fillCol As Color = ConditionColor(cond)

        ' selection / hover background
        Dim colTop As Single = If(isUpper, sideTop, numTop)
        Dim colBot As Single = If(isUpper, numTop + numH, sideTop + sideH)
        Dim bg As New RectangleF(cx + 1, colTop - 1, sw - 2, colBot - colTop + 2)
        If tooth = _selected Then
            Using b As New SolidBrush(Color.FromArgb(40, 14, 124, 134))
                g.FillRectangle(b, bg)
            End Using
            Using p As New Pen(Color.FromArgb(14, 124, 134), 1.5F)
                g.DrawRectangle(p, bg.X, bg.Y, bg.Width, bg.Height)
            End Using
        ElseIf tooth = _hover Then
            Using b As New SolidBrush(Color.FromArgb(25, 0, 0, 0))
                g.FillRectangle(b, bg)
            End Using
        End If

        ' side view
        Dim sideRect As New RectangleF(cx + sw * 0.1F, sideTop, sw * 0.8F, sideH)
        Using path As GraphicsPath = BuildSidePath(tooth Mod 10, sideRect, isUpper)
            Using b As New SolidBrush(If(fillCol = Color.Empty, Color.White, Color.FromArgb(150, fillCol)))
                g.FillPath(b, path)
            End Using
            Using p As New Pen(Color.FromArgb(120, 120, 120), 1.0F)
                g.DrawPath(p, path)
            End Using
        End Using

        ' occlusal view
        Dim od As Single = Math.Min(occ, sw * 0.8F)
        Dim occRect As New RectangleF(cx + (sw - od) / 2, occTop, od, od)
        Using b As New SolidBrush(If(fillCol = Color.Empty, Color.White, fillCol))
            g.FillEllipse(b, occRect)
        End Using
        Using p As New Pen(Color.FromArgb(110, 110, 110), 1.0F)
            g.DrawEllipse(p, occRect)
            Dim pos As Integer = tooth Mod 10
            Dim mx As Single = occRect.X + od / 2
            Dim my As Single = occRect.Y + od / 2
            If pos >= 6 Then            ' molars: cross fissure
                g.DrawLine(p, occRect.X + od * 0.2F, my, occRect.Right - od * 0.2F, my)
                g.DrawLine(p, mx, occRect.Y + od * 0.2F, mx, occRect.Bottom - od * 0.2F)
            ElseIf pos >= 4 Then        ' premolars: single fissure
                g.DrawLine(p, occRect.X + od * 0.2F, my, occRect.Right - od * 0.2F, my)
            End If
        End Using

        ' missing / extracted: red cross over both views
        If missing Then
            Using p As New Pen(Color.FromArgb(200, 40, 40), 2.0F)
                g.DrawLine(p, sideRect.X, sideRect.Y, sideRect.Right, sideRect.Bottom)
                g.DrawLine(p, sideRect.Right, sideRect.Y, sideRect.X, sideRect.Bottom)
                g.DrawLine(p, occRect.X, occRect.Y, occRect.Right, occRect.Bottom)
                g.DrawLine(p, occRect.Right, occRect.Y, occRect.X, occRect.Bottom)
            End Using
        End If

        ' tooth number
        Using sf As New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
            Using br As New SolidBrush(If(tooth = _selected, Color.FromArgb(14, 124, 134), Color.FromArgb(60, 70, 75)))
                Using f As New Font(Font, If(tooth = _selected, FontStyle.Bold, FontStyle.Regular))
                    g.DrawString(tooth.ToString(), f, br, New RectangleF(cx, numTop, sw, numH), sf)
                End Using
            End Using
        End Using
    End Sub

    ''' <summary>Side-view outline. pos = 1..8 (incisor..molar). Upper: roots point up. Lower: flipped.</summary>
    Private Shared Function BuildSidePath(pos As Integer, r As RectangleF, isUpper As Boolean) As GraphicsPath
        Dim pts() As PointF
        Dim tension As Single = 0.3F
        Select Case pos
            Case 1, 2   ' incisors
                pts = {New PointF(0.15F, 0.98F), New PointF(0.2F, 0.6F), New PointF(0.38F, 0.5F), New PointF(0.47F, 0.05F),
                       New PointF(0.53F, 0.05F), New PointF(0.62F, 0.5F), New PointF(0.8F, 0.6F), New PointF(0.85F, 0.98F),
                       New PointF(0.5F, 1.0F)}
            Case 3      ' canine
                pts = {New PointF(0.15F, 0.85F), New PointF(0.2F, 0.6F), New PointF(0.38F, 0.5F), New PointF(0.47F, 0.0F),
                       New PointF(0.53F, 0.0F), New PointF(0.62F, 0.5F), New PointF(0.8F, 0.6F), New PointF(0.85F, 0.85F),
                       New PointF(0.5F, 1.0F)}
            Case 4, 5   ' premolars
                pts = {New PointF(0.12F, 0.97F), New PointF(0.15F, 0.6F), New PointF(0.38F, 0.5F), New PointF(0.46F, 0.05F),
                       New PointF(0.54F, 0.05F), New PointF(0.62F, 0.5F), New PointF(0.85F, 0.6F), New PointF(0.88F, 0.97F),
                       New PointF(0.7F, 1.0F), New PointF(0.5F, 0.9F), New PointF(0.3F, 1.0F)}
            Case Else   ' molars
                tension = 0.25F
                pts = {New PointF(0.05F, 0.95F), New PointF(0.07F, 0.62F), New PointF(0.17F, 0.5F), New PointF(0.22F, 0.02F),
                       New PointF(0.4F, 0.45F), New PointF(0.5F, 0.4F), New PointF(0.6F, 0.45F), New PointF(0.78F, 0.02F),
                       New PointF(0.83F, 0.5F), New PointF(0.93F, 0.62F), New PointF(0.95F, 0.95F), New PointF(0.5F, 1.0F)}
        End Select

        Dim mapped(pts.Length - 1) As PointF
        For i As Integer = 0 To pts.Length - 1
            Dim ny As Single = If(isUpper, pts(i).Y, 1.0F - pts(i).Y)
            mapped(i) = New PointF(r.X + pts(i).X * r.Width, r.Y + ny * r.Height)
        Next
        Dim gp As New GraphicsPath()
        gp.AddClosedCurve(mapped, tension)
        Return gp
    End Function

    Private Sub DrawLegend(g As Graphics, y As Single)
        Dim items() As String = {"Cavity", "Filled", "Crown", "Root canal", "Impacted", "Fractured", "Implant", "Missing"}
        Dim dot As Single = 11
        Dim spacing As Single = 18

        Using f As New Font("Segoe UI", 8.5!)
            Dim fmt As StringFormat = StringFormat.GenericTypographic
            Dim labels(items.Length - 1) As String
            Dim widths(items.Length - 1) As Single
            Dim total As Single = 0

            ' measure first so the whole legend can be centred
            For i As Integer = 0 To items.Length - 1
                labels(i) = If(items(i) = "Missing", "Missing / Extracted", items(i))
                widths(i) = dot + 5 + g.MeasureString(labels(i), f, 1000, fmt).Width
                total += widths(i)
            Next
            total += spacing * (items.Length - 1)

            Dim x As Single = Math.Max(8.0F, (Width - total) / 2.0F)
            Dim textY As Single = y + (dot - f.GetHeight(g)) / 2.0F + 1

            For i As Integer = 0 To items.Length - 1
                If items(i) = "Missing" Then
                    Using p As New Pen(Color.FromArgb(200, 40, 40), 2.0F)
                        g.DrawLine(p, x, y, x + dot, y + dot)
                        g.DrawLine(p, x + dot, y, x, y + dot)
                    End Using
                Else
                    Using b As New SolidBrush(ConditionColor(items(i)))
                        g.FillEllipse(b, x, y, dot, dot)
                    End Using
                    Using p As New Pen(Color.FromArgb(110, 110, 110), 1.0F)
                        g.DrawEllipse(p, x, y, dot, dot)
                    End Using
                End If
                g.DrawString(labels(i), f, Brushes.DimGray, x + dot + 5, textY, fmt)
                x += widths(i) + spacing
            Next
        End Using
    End Sub

#End Region

#Region "Helpers"

    Private Shared Function IsMissing(cond As String) As Boolean
        Return cond.Equals("Missing", StringComparison.OrdinalIgnoreCase) OrElse
               cond.Equals("Extracted", StringComparison.OrdinalIgnoreCase)
    End Function

    Private Shared Function ConditionColor(cond As String) As Color
        If String.IsNullOrEmpty(cond) Then Return Color.Empty
        Select Case cond.ToLowerInvariant()
            Case "cavity" : Return Color.FromArgb(214, 69, 65)
            Case "filled" : Return Color.FromArgb(52, 120, 200)
            Case "crown" : Return Color.FromArgb(230, 175, 40)
            Case "root canal" : Return Color.FromArgb(142, 84, 188)
            Case "impacted" : Return Color.FromArgb(130, 140, 145)
            Case "fractured" : Return Color.FromArgb(235, 130, 40)
            Case "implant" : Return Color.FromArgb(14, 150, 150)
            Case Else : Return Color.Empty
        End Select
    End Function

#End Region

End Class
