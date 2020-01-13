Public Class mainFormTrace
    Private points As New List(Of Point)
    Public b1 As New List(Of Integer)
    Public smk As New List(Of Integer)
    Public b2 As New List(Of Integer)
    Private scaleHeight As Double
    Private scaleWidth As Double
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Long) As Integer
    Private pointIncrementer As Integer = 0
    Public dotPrint As Integer = 65
    Private Sub actBut_Click(sender As Object, e As EventArgs) Handles actBut.Click
        'Check if screen size is 5:4.
        scaleHeight = getScaleHeight()
        scaleWidth = getScaleWidth()
        'If screenH / screenW <> 0.8 Then
        '    If MsgBox("The screen ratio is not 5:4. Yes, I am a goofball who uses 1280x1024. I don't know how this will make the program react, so be warned. Would you like to quit now?", MsgBoxStyle.YesNo, "Non-Standard Resolution Detected.") = vbYes Then
        '        Application.Exit()
        '    End If
        'End If
        'Start the tracing timer.
        pointIncrementer = 0
        points.Clear()
        b2.Clear()
        smk.Clear()
        b1.Clear()
        tracTmr.Start()
        drawTmr.Start()
    End Sub

    Private Sub tracTmr_Tick(sender As Object, e As EventArgs) Handles tracTmr.Tick
        scaleHeight = getScaleHeight()
        scaleWidth = getScaleWidth()
        Dim but2 As Boolean = GetAsyncKeyState(Form2.getBut2)
        Dim smoke As Boolean = GetAsyncKeyState(Form2.getSmoke)
        Dim testBut As Boolean = GetAsyncKeyState(Keys.V)
        Dim but1 As Boolean = GetAsyncKeyState(Form2.getBut1)
        'If StandardStyle.Checked = True Then
        '    but1 = GetAsyncKeyState(Keys.Z)
        '    but2 = GetAsyncKeyState(Keys.X)
        'ElseIf HedonicStyle.Checked = True Then
        '    but1 = GetAsyncKeyState(Keys.LButton)
        '    but2 = GetAsyncKeyState(Keys.X)
        'ElseIf ZmanStyle.Checked = True Then
        '    but1 = GetAsyncKeyState(Keys.NumPad1)
        '    but2 = GetAsyncKeyState(Keys.NumPad2)
        'Else
        'End If
        'Get the cursor's location.ls
        Dim currentPoint As Point = System.Windows.Forms.Cursor.Position
        'Scale the point down to size.
        Dim scaledPoint As Point
        scaledPoint.X = currentPoint.X / scaleWidth
        scaledPoint.Y = currentPoint.Y / scaleHeight
        points.Add(scaledPoint)
        If but2 = True Then
            b2.Add(1)
        Else
            b2.Add(0)
        End If
        If smoke = True Then
            smk.Add(1)
        Else
            smk.Add(0)
        End If
        If but1 = True Then
            b1.Add(1)
        Else
            b1.Add(0)
        End If
            pointIncrementer += 1
    End Sub

    Private Sub deActBut_Click(sender As Object, e As EventArgs) Handles deActBut.Click
        tracTmr.Stop()
        drawTmr.Stop()
    End Sub

    Private Sub pictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles drawPan.Paint
        Dim radius As Integer = 4
        Dim bigRadius As Integer = 6
        Dim hugeRadius As Integer = 15
        Dim offset As Integer = bigRadius / 2
        Dim hugeOffset As Integer = hugeRadius / 2
        Dim lowerBound As Integer = pointIncrementer - dotPrint
        Dim basicPen As New Pen(Color.Green, 2)
        Dim smokePen As New Pen(Color.Red, bigRadius)
        Dim tapPen As New Pen(Color.Blue, bigRadius)
        Dim outlinePen As New Pen(Color.Black, 1)
        If clrBkChk.Checked = True Then
            basicPen = New Pen(Color.Lime, radius)
            tapPen = New Pen(Color.Yellow, bigRadius)
        ElseIf tnsparBkChk.Checked = True Then
            Dim cusColor As New Color()
            cusColor = Color.FromArgb(255, 0, 153, 255)
            basicPen = New Pen(cusColor, radius)
            Dim pinkCol As New Color()
            pinkCol = Color.FromArgb(255, 255, 51, 204)
            tapPen = New Pen(pinkCol, bigRadius)
        End If
        Dim pointBrush As New SolidBrush(tapPen.Color)
        Dim rtCorner As Point
        Dim rbCorner As Point
        Dim ltCorner As Point
        Dim lbCorner As Point
        rtCorner.X = drawPan.Width - 1
        rtCorner.Y = 0
        rbCorner.X = drawPan.Width - 1
        rbCorner.Y = drawPan.Height - 1
        ltCorner.X = 0
        ltCorner.Y = 0
        lbCorner.X = 0
        lbCorner.Y = drawPan.Height - 1
        Dim panelH As Integer = drawPan.Height
        Dim panelW As Integer = drawPan.Width
        If lowerBound < 0 Then
            lowerBound = 0
        End If
        e.Graphics.DrawLine(outlinePen, rtCorner, rbCorner)
        e.Graphics.DrawLine(outlinePen, ltCorner, rtCorner)
        e.Graphics.DrawLine(outlinePen, lbCorner, rbCorner)
        e.Graphics.DrawLine(outlinePen, ltCorner, lbCorner)
        For i = lowerBound To points.Count - 1
            If i = 0 Then
            ElseIf b2(i) = 1 Then
                If b2(i - 1) = 0 Then
                    e.Graphics.FillEllipse(Brushes.Orange, points(i).X - hugeOffset, points(i).Y - hugeOffset, hugeRadius, hugeRadius)
                Else
                    e.Graphics.FillEllipse(pointBrush, points(i).X - offset, points(i).Y - offset, bigRadius, bigRadius)
                    e.Graphics.DrawLine(tapPen, points(i - 1), points(i))
                End If
            ElseIf b1(i) = 1 Then
                If b1(i - 1) = 0 Then
                    e.Graphics.FillEllipse(Brushes.Orange, points(i).X - hugeOffset, points(i).Y - hugeOffset, hugeRadius, hugeRadius)
                Else
                    e.Graphics.FillEllipse(pointBrush, points(i).X - offset, points(i).Y - offset, bigRadius, bigRadius)
                    e.Graphics.DrawLine(tapPen, points(i - 1), points(i))
                End If
            ElseIf smk(i) = 1 Then
                e.Graphics.FillEllipse(Brushes.Red, points(i).X - offset, points(i).Y - offset, bigRadius, bigRadius)
                e.Graphics.DrawLine(smokePen, points(i - 1), points(i))
            Else
                e.Graphics.DrawLine(basicPen, points(i - 1), points(i))
            End If
        Next
    End Sub

    Private Sub drawTmr_Tick(sender As Object, e As EventArgs) Handles drawTmr.Tick
        drawPan.Refresh()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles chngLenBut.Click
        Dim tempString As String = (InputBox("Please enter a number greater than 0 to represent the number of dots on screen. As a point of reference, the default is 65. Lower numbers lead to trails that clear quicker.", "Enter Number of Dots", dotPrint.ToString, , ))
        If tempString.Equals("") Then
            tempString = dotPrint.ToString
        End If
        Dim tempInt As Integer
        Try
            tempInt = CInt(tempString)
        Catch ex As Exception
            MsgBox("Failed to convert input to a number. Please enter ONLY numbers when changing the number of dots. Defaulting # of dots to 65.")
            tempInt = 65
        End Try
        If tempInt < 1 Then
            tempInt = 1
        End If
        dotPrint = tempInt
        dotLab.Text = dotPrint.ToString
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles clrBkChk.CheckedChanged
        If clrBkChk.Checked = True Then
            tnsparBkChk.Checked = False
            Me.TransparencyKey = Nothing
            drawPan.BackColor = Color.Black
            drawPan.Refresh()
        Else
            Me.BackColor = SystemColors.Control
            drawPan.BackColor = SystemColors.Control
            drawPan.Refresh()
        End If
    End Sub

    Private Sub resizeBut_Click(sender As Object, e As EventArgs) Handles resizeBut.Click
        Dim tempH As String = InputBox("Please enter a number that is greater than 100 and less than 240. This will be the new height of the panel in pixels.", "Enter a new Height...", drawPan.Height.ToString)
        If tempH.Equals("") Then
            tempH = drawPan.Height.ToString
        End If
        Dim newH As Integer
        Try
            newH = CInt(tempH)
        Catch ex As Exception
            MsgBox("ERROR: Could not convert input to a number. Reverting change.")
            newH = drawPan.Height
        End Try
        If newH < 100 Then
            newH = 100
        ElseIf newH > 240 Then
            newH = 240
        End If
        Dim tempW As String = InputBox("Please enter a number that is greater than 100 and less than 400. This will be the new width of the panel in pixels.", "Enter a new Width...", drawPan.Width.ToString)
        If tempW.Equals("") Then
            tempW = drawPan.Width.ToString
        End If
        Dim newW As Integer
        Try
            newW = CInt(tempW)
        Catch ex As Exception
            MsgBox("ERROR: Could not convert input to a number. Reverting change.")
            newW = drawPan.Width
        End Try
        If newW < 100 Then
            newW = 100
        ElseIf newW > 400 Then
            newW = 400
        End If
        drawPan.Width = newW
        drawPan.Height = newH
        drawPan.Refresh()
    End Sub

    Public Function getScaleHeight() As Double
        Dim screenH As Integer = Screen.PrimaryScreen.Bounds.Height
        scaleHeight = screenH / drawPan.Height
        Return scaleHeight
    End Function

    Public Function getScaleWidth() As Double
        Dim screenW As Integer = Screen.PrimaryScreen.Bounds.Width
        scaleWidth = screenW / drawPan.Width
        Return scaleWidth
    End Function

    Private Sub resetBut_Click(sender As Object, e As EventArgs) Handles resetBut.Click
        drawPan.Width = 400
        drawPan.Height = 240
        points.Clear()
        b2.Clear()
        smk.Clear()
        b1.Clear()
        drawPan.Refresh()
        HedonicStyle.Checked = False
        ZmanStyle.Checked = False
        StandardStyle.Checked = True
        dotPrint = 65
        dotLab.Text = dotPrint.ToString
        clrBkChk.Checked = True
        clrBkChk.Checked = False
        deActBut.PerformClick()
        tnsparBkChk.Checked = False
        clrBkChk.Checked = False
        Me.BackgroundImage = Nothing
        Me.BackColor = SystemColors.Control
        Me.TransparencyKey = Nothing
    End Sub

    Private Sub mainFormTrace_Load(sender As Object, e As EventArgs) Handles Me.Load
        Threading.Thread.Sleep(4000)
        versionLab.Text = "v" + Application.ProductVersion
        drawPan.BackColor = Color.Transparent
        If My.Settings.MsgDisable = False Then
            MsgBox("Hiya! Thanks for using my program! I cannot push updates to you :'( because I don't own a server. BUT. Check back every now and then... I'll try to update at least once a week with new stuff, while this message box still exists. If you have any feedback, questions, comments, angry notes, love notes, or messages, feel free to email me at HedonicKnight@gmail.com. Let me know what you think!", , "Welcome!")
            MsgBox("You are currently on version v" + Application.ProductVersion + ". Please remember to check for updates on the Google Drive site! Sadly, as of now, until I can figure out how to share the file, I cannot push updates. There isn't a better way for this to work at the moment.", , "Remember to check for updates!")
        End If
        Form2.loadSettings()
    End Sub

    Private Sub actTmr_Tick(sender As Object, e As EventArgs) Handles actTmr.Tick
        Dim actK As Boolean = GetAsyncKeyState(Form2.getAct)
        Dim deActK As Boolean = GetAsyncKeyState(Form2.getDeAct)
        Dim lenUp As Boolean = GetAsyncKeyState(Form2.getLenUp)
        Dim lenDn As Boolean = GetAsyncKeyState(Form2.getLenDn)
        If actK = True Then
            If tracTmr.Enabled = False Then
                actBut.PerformClick()
            End If
        ElseIf deActK = True Then
            If tracTmr.Enabled = True Then
                deActBut.PerformClick()
            End If
        ElseIf lenUp = True Then
            dotPrint += 1
            dotLab.Text = dotPrint.ToString
        ElseIf lenDn = True Then
            If dotPrint >= 2 Then
                dotPrint -= 1
                dotLab.Text = dotPrint.ToString
            End If
        End If
            If tracTmr.Enabled = True Then
                actBut.Visible = False
                deActBut.Visible = True
            ElseIf tracTmr.Enabled = False Then
                deActBut.Visible = False
                actBut.Visible = True
            End If
    End Sub

    Private Sub keyHLPBUT_Click(sender As Object, e As EventArgs) Handles keyHLPBUT.Click
        Form2.Show()
        Application.DoEvents()
    End Sub

    Private Sub tnsparBkChk_CheckedChanged(sender As Object, e As EventArgs) Handles tnsparBkChk.CheckedChanged
        If tnsparBkChk.Checked = True Then
            clrBkChk.Checked = False
            Me.BackColor = SystemColors.Control
            drawPan.BackColor = Color.Transparent
            Me.TransparencyKey = Me.BackColor
        Else
            Me.BackColor = SystemColors.Control
            Me.TransparencyKey = Nothing
            drawPan.BackColor = SystemColors.Control
            drawPan.Refresh()
        End If
    End Sub
End Class
