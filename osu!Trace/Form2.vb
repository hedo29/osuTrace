Public Class Form2
    Private but1 As System.Windows.Forms.Keys = Keys.Z
    Private but2 As System.Windows.Forms.Keys = Keys.X
    Private smk As System.Windows.Forms.Keys = Keys.C
    Private act As System.Windows.Forms.Keys = Keys.PageUp
    Private deAct As System.Windows.Forms.Keys = Keys.PageDown
    Private lngthUp As System.Windows.Forms.Keys = Keys.Oemplus
    Private lngthDn As System.Windows.Forms.Keys = Keys.OemMinus
    Private newKey As System.Windows.Forms.Keys
    Private newLabText As String
    Private cont As Boolean

    Private Sub b1Config_Click(sender As Object, e As EventArgs) Handles b1Config.Click
        deactAllBut()
        MsgBox("To use a mouse button, click in the BACKGROUND of the configuration page (not on any text or a button).", MsgBoxStyle.Information, "Need to use a Mouse Button?")
        cont = False
        keyCheckWait.Show()
        startGet.Start()
        While startGet.Enabled
            Dim tempOp As Integer = 0
            tempOp = tempOp + 1
            If tempOp = 777 Then
                Debug.Print("Jackpot")
            Else
                Debug.Print("Not a winner.")
            End If
            startGet.Enabled = False
            keyCheckWait.Hide()
        End While
        b1ConfigLab.Text = "Waiting..."
        newLabText = ""
        While cont = False
            b1Config.Text = "Press a Key."
            b1ConfigLab.Text = "....."
            b1Config.BackColor = Color.Yellow
            checkCont()
            Application.DoEvents()
        End While
        b1Config.Text = "Button 1"
        b1ConfigLab.Text = newLabText
        b1Config.BackColor = SystemColors.Control
        but1 = newKey
        actAllBut()
    End Sub

    Private Sub b2Config_Click(sender As Object, e As EventArgs) Handles b2Config.Click
        deactAllBut()
        MsgBox("To use a mouse button, click in the BACKGROUND of the configuration page (not on any text or a button).", MsgBoxStyle.Information, "Need to use a Mouse Button?")
        cont = False
        keyCheckWait.Show()
        startGet.Start()
        While startGet.Enabled
            Dim tempOp As Integer = 0
            tempOp = tempOp + 1
            If tempOp = 777 Then
                Debug.Print("Jackpot")
            Else
                Debug.Print("Not a winner.")
            End If
            startGet.Enabled = False
            keyCheckWait.Hide()
        End While
        b2ConfigLab.Text = "Waiting..."
        newLabText = ""
        getKey.Start()
        While cont = False
            b2Config.Text = "Press a Key."
            b2ConfigLab.Text = "....."
            b2Config.BackColor = Color.Yellow
            checkCont()
            Application.DoEvents()
        End While
        b2Config.Text = "Button 2"
        b2ConfigLab.Text = newLabText
        b2Config.BackColor = SystemColors.Control
        but2 = newKey
        actAllBut()
    End Sub

    Private Sub smkConfig_Click(sender As Object, e As EventArgs) Handles smkConfig.Click
        deactAllBut()
        MsgBox("To use a mouse button, click in the BACKGROUND of the configuration page (not on any text or a button).", MsgBoxStyle.Information, "Need to use a Mouse Button?")
        cont = False
        keyCheckWait.Show()
        startGet.Start()
        While startGet.Enabled
            Dim tempOp As Integer = 0
            tempOp = tempOp + 1
            If tempOp = 777 Then
                Debug.Print("Jackpot")
            Else
                Debug.Print("Not a winner.")
            End If
            startGet.Enabled = False
            keyCheckWait.Hide()
        End While
        smkConfigLab.Text = "Waiting..."
        newLabText = ""
        getKey.Start()
        While cont = False
            smkConfig.Text = "Press a Key."
            smkConfigLab.Text = "....."
            smkConfig.BackColor = Color.Yellow
            checkCont()
            Application.DoEvents()
        End While
        smkConfig.Text = "Smoke"
        smkConfigLab.Text = newLabText
        smkConfig.BackColor = SystemColors.Control
        smk = newKey
        actAllBut()
    End Sub

    Private Sub actConfig_Click(sender As Object, e As EventArgs) Handles actConfig.Click
        deactAllBut()
        MsgBox("To use a mouse button, click in the BACKGROUND of the configuration page (not on any text or a button).", MsgBoxStyle.Information, "Need to use a Mouse Button?")
        cont = False
        keyCheckWait.Show()
        startGet.Start()
        While startGet.Enabled
            Dim tempOp As Integer = 0
            tempOp = tempOp + 1
            If tempOp = 777 Then
                Debug.Print("Jackpot")
            Else
                Debug.Print("Not a winner.")
            End If
            startGet.Enabled = False
            keyCheckWait.Hide()
        End While
        actConfigLab.Text = "Waiting..."
        newLabText = ""
        getKey.Start()
        While cont = False
            actConfig.Text = "Press a Key."
            actConfigLab.Text = "....."
            actConfig.BackColor = Color.Yellow
            checkCont()
            Application.DoEvents()
        End While
        actConfig.Text = "Activate"
        actConfigLab.Text = newLabText
        actConfig.BackColor = SystemColors.Control
        act = newKey
        actAllBut()
    End Sub

    Private Sub deActConfig_Click(sender As Object, e As EventArgs) Handles deactConfig.Click
        deactAllBut()
        MsgBox("To use a mouse button, click in the BACKGROUND of the configuration page (not on any text or a button).", MsgBoxStyle.Information, "Need to use a Mouse Button?")
        cont = False
        keyCheckWait.Show()
        startGet.Start()
        While startGet.Enabled
            Dim tempOp As Integer = 0
            tempOp = tempOp + 1
            If tempOp = 777 Then
                Debug.Print("Jackpot")
            Else
                Debug.Print("Not a winner.")
            End If
            startGet.Enabled = False
            keyCheckWait.Hide()
        End While
        deactConfigLab.Text = "Waiting..."
        newLabText = ""
        getKey.Start()
        While cont = False
            deactConfig.Text = "Press a Key."
            deactConfigLab.Text = "....."
            deactConfig.BackColor = Color.Yellow
            checkCont()
            Application.DoEvents()
        End While
        deactConfig.Text = "Deactivate"
        deactConfigLab.Text = newLabText
        deactConfig.BackColor = SystemColors.Control
        deAct = newKey
        actAllBut()
    End Sub

    Private Sub lengthUpConfig_Click(sender As Object, e As EventArgs) Handles lengthUpConfig.Click
        deactAllBut()
        MsgBox("To use a mouse button, click in the BACKGROUND of the configuration page (not on any text or a button).", MsgBoxStyle.Information, "Need to use a Mouse Button?")
        cont = False
        keyCheckWait.Show()
        startGet.Start()
        While startGet.Enabled
            Dim tempOp As Integer = 0
            tempOp = tempOp + 1
            If tempOp = 777 Then
                Debug.Print("Jackpot")
            Else
                Debug.Print("Not a winner.")
            End If
            startGet.Enabled = False
            keyCheckWait.Hide()
        End While
        lengthUpConfigLab.Text = "Waiting..."
        newLabText = ""
        getKey.Start()
        While cont = False
            lengthUpConfig.Text = "Press a Key."
            lengthUpConfigLab.Text = "....."
            lengthUpConfig.BackColor = Color.Yellow
            checkCont()
            Application.DoEvents()
        End While
        lengthUpConfig.Text = "+ Length"
        lengthUpConfigLab.Text = newLabText
        lengthUpConfig.BackColor = SystemColors.Control
        lngthUp = newKey
        actAllBut()
    End Sub

    Private Sub lengthDnConfig_Click(sender As Object, e As EventArgs) Handles lengthDnConfig.Click
        deactAllBut()
        MsgBox("To use a mouse button, click in the BACKGROUND of the configuration page (not on any text or a button).", MsgBoxStyle.Information, "Need to use a Mouse Button?")
        cont = False
        keyCheckWait.Show()
        startGet.Start()
        While startGet.Enabled
            Dim tempOp As Integer = 0
            tempOp = tempOp + 1
            If tempOp = 777 Then
                Debug.Print("Jackpot")
            Else
                Debug.Print("Not a winner.")
            End If
            startGet.Enabled = False
            keyCheckWait.Hide()
        End While
        lengthDnConfigLab.Text = "Waiting..."
        newLabText = ""
        getKey.Start()
        While cont = False
            lengthDnConfig.Text = "Press a Key."
            lengthDnConfigLab.Text = "....."
            lengthDnConfig.BackColor = Color.Yellow
            checkCont()
            Application.DoEvents()
        End While
        lengthDnConfig.Text = "- Length"
        lengthDnConfigLab.Text = newLabText
        lengthDnConfig.BackColor = SystemColors.Control
        lngthDn = newKey
        actAllBut()
    End Sub

    Private Sub checkCont()
        If newLabText <> "" Then
            cont = True
        End If
    End Sub

    Private Sub startGet_Tick(sender As Object, e As EventArgs) Handles startGet.Tick
    End Sub



    Private Sub Form2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim escPress As System.Windows.Forms.Keys
        Dim f1Press As System.Windows.Forms.Keys
        Dim f2Press As System.Windows.Forms.Keys
        Dim f3Press As System.Windows.Forms.Keys
        Dim f4Press As System.Windows.Forms.Keys
        Dim f5Press As System.Windows.Forms.Keys
        Dim f6Press As System.Windows.Forms.Keys
        Dim f7Press As System.Windows.Forms.Keys
        Dim f8Press As System.Windows.Forms.Keys
        Dim f9Press As System.Windows.Forms.Keys
        Dim f10Press As System.Windows.Forms.Keys
        Dim f11Press As System.Windows.Forms.Keys
        Dim f12Press As System.Windows.Forms.Keys
        Dim delPress As System.Windows.Forms.Keys
        Dim homePress As System.Windows.Forms.Keys
        Dim endPress As System.Windows.Forms.Keys
        Dim pgUpPress As System.Windows.Forms.Keys
        Dim pgDnPress As System.Windows.Forms.Keys
        Dim bkTkPress As System.Windows.Forms.Keys
        Dim num1Press As System.Windows.Forms.Keys
        Dim num2Press As System.Windows.Forms.Keys
        Dim num3Press As System.Windows.Forms.Keys
        Dim num4Press As System.Windows.Forms.Keys
        Dim num5Press As System.Windows.Forms.Keys
        Dim num6Press As System.Windows.Forms.Keys
        Dim num7Press As System.Windows.Forms.Keys
        Dim num8Press As System.Windows.Forms.Keys
        Dim num9Press As System.Windows.Forms.Keys
        Dim num0Press As System.Windows.Forms.Keys
        Dim minusPress As System.Windows.Forms.Keys
        Dim plusPress As System.Windows.Forms.Keys
        Dim bkspcPress As System.Windows.Forms.Keys
        Dim tabPress As System.Windows.Forms.Keys
        Dim qPress As System.Windows.Forms.Keys
        Dim wPress As System.Windows.Forms.Keys
        Dim ePress As System.Windows.Forms.Keys
        Dim rPress As System.Windows.Forms.Keys
        Dim tPress As System.Windows.Forms.Keys
        Dim yPress As System.Windows.Forms.Keys
        Dim uPress As System.Windows.Forms.Keys
        Dim iPress As System.Windows.Forms.Keys
        Dim oPress As System.Windows.Forms.Keys
        Dim pPress As System.Windows.Forms.Keys
        Dim lBrkPress As System.Windows.Forms.Keys
        Dim rBrkPress As System.Windows.Forms.Keys
        Dim bkSlshPress As System.Windows.Forms.Keys
        Dim aPress As System.Windows.Forms.Keys
        Dim sPress As System.Windows.Forms.Keys
        Dim dPress As System.Windows.Forms.Keys
        Dim fPress As System.Windows.Forms.Keys
        Dim gPress As System.Windows.Forms.Keys
        Dim hPress As System.Windows.Forms.Keys
        Dim jPress As System.Windows.Forms.Keys
        Dim kPress As System.Windows.Forms.Keys
        Dim lPress As System.Windows.Forms.Keys
        Dim colPress As System.Windows.Forms.Keys
        Dim aposPress As System.Windows.Forms.Keys
        Dim enterPress As System.Windows.Forms.Keys
        Dim lShftPress As System.Windows.Forms.Keys
        Dim zPress As System.Windows.Forms.Keys
        Dim xPress As System.Windows.Forms.Keys
        Dim cPress As System.Windows.Forms.Keys
        Dim vPress As System.Windows.Forms.Keys
        Dim bPress As System.Windows.Forms.Keys
        Dim nPress As System.Windows.Forms.Keys
        Dim mPress As System.Windows.Forms.Keys
        Dim comPress As System.Windows.Forms.Keys
        Dim perPress As System.Windows.Forms.Keys
        Dim forSlshPress As System.Windows.Forms.Keys
        Dim rShiftPress As System.Windows.Forms.Keys
        Dim lCtrlPress As System.Windows.Forms.Keys
        Dim lAltPress As System.Windows.Forms.Keys
        Dim spacePress As System.Windows.Forms.Keys
        Dim rAltPress As System.Windows.Forms.Keys
        Dim rCtrlPress As System.Windows.Forms.Keys
        Dim lArrowPress As System.Windows.Forms.Keys
        Dim rArrowPress As System.Windows.Forms.Keys
        Dim uArrowPress As System.Windows.Forms.Keys
        Dim dArrowPress As System.Windows.Forms.Keys
        Dim pad0Press As System.Windows.Forms.Keys
        Dim pad1Press As System.Windows.Forms.Keys
        Dim pad2Press As System.Windows.Forms.Keys
        Dim pad3Press As System.Windows.Forms.Keys
        Dim pad4Press As System.Windows.Forms.Keys
        Dim pad5Press As System.Windows.Forms.Keys
        Dim pad6Press As System.Windows.Forms.Keys
        Dim pad7Press As System.Windows.Forms.Keys
        Dim pad8Press As System.Windows.Forms.Keys
        Dim pad9Press As System.Windows.Forms.Keys
        Dim padDecPress As System.Windows.Forms.Keys
        Dim pausePress As System.Windows.Forms.Keys
        Dim insertPress As System.Windows.Forms.Keys
        Dim lMouseBut As System.Windows.Forms.Keys
        Dim rMouseBut As System.Windows.Forms.Keys
        Dim mMouseBut As System.Windows.Forms.Keys
        escPress = (Keys.Escape)
        f1Press = (Keys.F1)
        f2Press = (Keys.F2)
        f3Press = (Keys.F3)
        f4Press = (Keys.F4)
        f5Press = (Keys.F5)
        f6Press = (Keys.F6)
        f7Press = (Keys.F7)
        f8Press = (Keys.F8)
        f9Press = (Keys.F9)
        f10Press = (Keys.F10)
        f11Press = (Keys.F11)
        f12Press = (Keys.F12)
        delPress = (Keys.Delete)
        homePress = (Keys.Home)
        endPress = (Keys.End)
        pgUpPress = (Keys.PageUp)
        pgDnPress = (Keys.PageDown)
        bkTkPress = (Keys.Oemtilde)
        num1Press = (Keys.D1)
        num2Press = (Keys.D2)
        num3Press = (Keys.D3)
        num4Press = (Keys.D4)
        num5Press = (Keys.D5)
        num6Press = (Keys.D6)
        num7Press = (Keys.D7)
        num8Press = (Keys.D8)
        num9Press = (Keys.D9)
        num0Press = (Keys.D0)
        minusPress = (Keys.OemMinus)
        plusPress = (Keys.Oemplus)
        bkspcPress = (Keys.Back)
        tabPress = (Keys.Tab)
        qPress = (Keys.Q)
        wPress = (Keys.W)
        ePress = (Keys.E)
        rPress = (Keys.R)
        tPress = (Keys.T)
        yPress = (Keys.Y)
        uPress = (Keys.U)
        iPress = (Keys.I)
        oPress = (Keys.O)
        pPress = (Keys.P)
        lBrkPress = (Keys.OemOpenBrackets)
        rBrkPress = (Keys.OemCloseBrackets)
        bkSlshPress = (Keys.OemPipe)
        aPress = (Keys.A)
        sPress = (Keys.S)
        dPress = (Keys.D)
        fPress = (Keys.F)
        gPress = (Keys.G)
        hPress = (Keys.H)
        jPress = (Keys.J)
        kPress = (Keys.K)
        lPress = (Keys.L)
        colPress = (Keys.OemSemicolon)
        aposPress = (Keys.OemQuotes)
        enterPress = (Keys.Enter)
        lShftPress = (Keys.LShiftKey)
        zPress = (Keys.Z)
        xPress = (Keys.X)
        cPress = (Keys.C)
        vPress = (Keys.V)
        bPress = (Keys.B)
        nPress = (Keys.N)
        mPress = (Keys.M)
        comPress = (Keys.Oemcomma)
        perPress = (Keys.OemPeriod)
        forSlshPress = (Keys.OemQuestion)
        rShiftPress = (Keys.RShiftKey)
        lCtrlPress = (Keys.LControlKey)
        lAltPress = (Keys.LMenu)
        spacePress = (Keys.Space)
        rAltPress = (Keys.RMenu)
        rCtrlPress = (Keys.RControlKey)
        lArrowPress = (Keys.Left)
        rArrowPress = (Keys.Right)
        uArrowPress = (Keys.Up)
        dArrowPress = (Keys.Down)
        pad0Press = (Keys.NumPad0)
        pad1Press = (Keys.NumPad1)
        pad2Press = (Keys.NumPad2)
        pad3Press = (Keys.NumPad3)
        pad4Press = (Keys.NumPad4)
        pad5Press = (Keys.NumPad5)
        pad6Press = (Keys.NumPad6)
        pad7Press = (Keys.NumPad7)
        pad8Press = (Keys.NumPad8)
        pad9Press = (Keys.NumPad9)
        padDecPress = (Keys.Decimal)
        pausePress = (Keys.Pause)
        insertPress = (Keys.Insert)
        lMouseBut = (Keys.LButton)
        rMouseBut = (Keys.RButton)
        mMouseBut = (Keys.MButton)
        If e.KeyCode = escPress Then
            newLabText = "Escape"
        ElseIf e.KeyCode = f1Press Then
            newLabText = "F1"
        ElseIf e.KeyCode = f2Press Then
            newLabText = "F2"
        ElseIf e.KeyCode = f3Press Then
            newLabText = "F3"
        ElseIf e.KeyCode = f4Press Then
            newLabText = "F4"
        ElseIf e.KeyCode = f5Press Then
            newLabText = "F5"
        ElseIf e.KeyCode = f6Press Then
            newLabText = "F6"
        ElseIf e.KeyCode = f7Press Then
            newLabText = "F7"
        ElseIf e.KeyCode = f8Press Then
            newLabText = "F8"
        ElseIf e.KeyCode = f9Press Then
            newLabText = "F9"
        ElseIf e.KeyCode = f10Press Then
            newLabText = "F10"
        ElseIf e.KeyCode = f11Press Then
            newLabText = "F11"
        ElseIf e.KeyCode = f12Press Then
            newLabText = "F12"
        ElseIf e.KeyCode = delPress Then
            newLabText = "Del"
        ElseIf e.KeyCode = homePress Then
            newLabText = "Home"
        ElseIf e.KeyCode = endPress Then
            newLabText = "End"
        ElseIf e.KeyCode = pgUpPress Then
            newLabText = "Page Up"
        ElseIf e.KeyCode = pgDnPress Then
            newLabText = "Page Down"
        ElseIf e.KeyCode = bkTkPress Then
            newLabText = "`"
        ElseIf e.KeyCode = num1Press Then
            newLabText = "1"
        ElseIf e.KeyCode = num2Press Then
            newLabText = "2"
        ElseIf e.KeyCode = num3Press Then
            newLabText = "3"
        ElseIf e.KeyCode = num4Press Then
            newLabText = "4"
        ElseIf e.KeyCode = num5Press Then
            newLabText = "5"
        ElseIf e.KeyCode = num6Press Then
            newLabText = "6"
        ElseIf e.KeyCode = num7Press Then
            newLabText = "7"
        ElseIf e.KeyCode = num8Press Then
            newLabText = "8"
        ElseIf e.KeyCode = num9Press Then
            newLabText = "9"
        ElseIf e.KeyCode = num0Press Then
            newLabText = "0"
        ElseIf e.KeyCode = minusPress Then
            newLabText = "-"
        ElseIf e.KeyCode = plusPress Then
            newLabText = "="
        ElseIf e.KeyCode = bkspcPress Then
            newLabText = "Backspace"
        ElseIf e.KeyCode = tabPress Then
            newLabText = "Tab"
        ElseIf e.KeyCode = qPress Then
            newLabText = "Q"
        ElseIf e.KeyCode = wPress Then
            newLabText = "W"
        ElseIf e.KeyCode = ePress Then
            newLabText = "E"
        ElseIf e.KeyCode = rPress Then
            newLabText = "R"
        ElseIf e.KeyCode = tPress Then
            newLabText = "T"
        ElseIf e.KeyCode = yPress Then
            newLabText = "Y"
        ElseIf e.KeyCode = uPress Then
            newLabText = "U"
        ElseIf e.KeyCode = iPress Then
            newLabText = "I"
        ElseIf e.KeyCode = oPress Then
            newLabText = "O"
        ElseIf e.KeyCode = pPress Then
            newLabText = "P"
        ElseIf e.KeyCode = lBrkPress Then
            newLabText = "["
        ElseIf e.KeyCode = rBrkPress Then
            newLabText = "]"
        ElseIf e.KeyCode = bkSlshPress Then
            newLabText = "\"
        ElseIf e.KeyCode = aPress Then
            newLabText = "A"
        ElseIf e.KeyCode = sPress Then
            newLabText = "S"
        ElseIf e.KeyCode = dPress Then
            newLabText = "D"
        ElseIf e.KeyCode = fPress Then
            newLabText = "F"
        ElseIf e.KeyCode = gPress Then
            newLabText = "G"
        ElseIf e.KeyCode = hPress Then
            newLabText = "H"
        ElseIf e.KeyCode = jPress Then
            newLabText = "J"
        ElseIf e.KeyCode = kPress Then
            newLabText = "K"
        ElseIf e.KeyCode = lPress Then
            newLabText = "L"
        ElseIf e.KeyCode = colPress Then
            newLabText = ";"
        ElseIf e.KeyCode = aposPress Then
            newLabText = "'"
        ElseIf e.KeyCode = enterPress Then
            newLabText = "Enter"
        ElseIf e.KeyCode = lShftPress Then
            newLabText = "Left Shift"
        ElseIf e.KeyCode = zPress Then
            newLabText = "Z"
        ElseIf e.KeyCode = xPress Then
            newLabText = "X"
        ElseIf e.KeyCode = cPress Then
            newLabText = "C"
        ElseIf e.KeyCode = vPress Then
            newLabText = "V"
        ElseIf e.KeyCode = bPress Then
            newLabText = "B"
        ElseIf e.KeyCode = nPress Then
            newLabText = "N"
        ElseIf e.KeyCode = mPress Then
            newLabText = "L"
        ElseIf e.KeyCode = comPress Then
            newLabText = ","
        ElseIf e.KeyCode = perPress Then
            newLabText = "."
        ElseIf e.KeyCode = forSlshPress Then
            newLabText = "/"
        ElseIf e.KeyCode = rShiftPress Then
            newLabText = "Right Shift"
        ElseIf e.KeyCode = lCtrlPress Then
            newLabText = "Left Ctrl"
        ElseIf e.KeyCode = lAltPress Then
            newLabText = "Left Alt"
        ElseIf e.KeyCode = spacePress Then
            newLabText = "Space"
        ElseIf e.KeyCode = rAltPress Then
            newLabText = "Right Alt"
        ElseIf e.KeyCode = rCtrlPress Then
            newLabText = "Right Ctrl"
        ElseIf e.KeyCode = lArrowPress Then
            newLabText = "Left Arrow"
        ElseIf e.KeyCode = rArrowPress Then
            newLabText = "Right Arrow"
        ElseIf e.KeyCode = uArrowPress Then
            newLabText = "Up Arrow"
        ElseIf e.KeyCode = dArrowPress Then
            newLabText = "Down Arrow"
        ElseIf e.KeyCode = pad0Press Then
            newLabText = "Numpad 0"
        ElseIf e.KeyCode = pad1Press Then
            newLabText = "Numpad 1"
        ElseIf e.KeyCode = pad2Press Then
            newLabText = "Numpad 2"
        ElseIf e.KeyCode = pad3Press Then
            newLabText = "Numpad 3"
        ElseIf e.KeyCode = pad4Press Then
            newLabText = "Numpad 4"
        ElseIf e.KeyCode = pad5Press Then
            newLabText = "Numpad 5"
        ElseIf e.KeyCode = pad6Press Then
            newLabText = "Numpad 6"
        ElseIf e.KeyCode = pad7Press Then
            newLabText = "Numpad 7"
        ElseIf e.KeyCode = pad8Press Then
            newLabText = "Numpad 8"
        ElseIf e.KeyCode = pad9Press Then
            newLabText = "Numpad 9"
        ElseIf e.KeyCode = padDecPress Then
            newLabText = "Numpad ."
        ElseIf e.KeyCode = pausePress Then
            newLabText = "Pause"
        ElseIf e.KeyCode = insertPress Then
            newLabText = "Insert"
        ElseIf e.KeyCode = lMouseBut Then
            newLabText = "Left Mouse Button"
        ElseIf e.KeyCode = rMouseBut Then
            newLabText = "Right Mouse Button"
        ElseIf e.KeyCode = mMouseBut Then
            newLabText = "Middle Mouse Button"
        Else
        End If
        newKey = e.KeyCode
    End Sub

    Private Sub deactAllBut()
        b1Config.Enabled = False
        b2Config.Enabled = False
        smkConfig.Enabled = False
        actConfig.Enabled = False
        deactConfig.Enabled = False
        lengthDnConfig.Enabled = False
        lengthUpConfig.Enabled = False
        backBut.Enabled = False
    End Sub

    Private Sub actAllBut()
        b1Config.Enabled = True
        b2Config.Enabled = True
        smkConfig.Enabled = True
        actConfig.Enabled = True
        deactConfig.Enabled = True
        lengthDnConfig.Enabled = True
        lengthUpConfig.Enabled = True
        backBut.Enabled = True
    End Sub

    Public Function getBut1() As System.Windows.Forms.Keys
        Return Me.but1
    End Function

    Public Function getBut2() As System.Windows.Forms.Keys
        Return Me.but2
    End Function

    Public Function getSmoke() As System.Windows.Forms.Keys
        Return Me.smk
    End Function

    Public Function getAct() As System.Windows.Forms.Keys
        Return Me.act
    End Function

    Public Function getDeAct() As System.Windows.Forms.Keys
        Return Me.deAct
    End Function

    Public Function getLenUp() As System.Windows.Forms.Keys
        Return Me.lngthUp
    End Function

    Public Function getLenDn() As System.Windows.Forms.Keys
        Return Me.lngthDn
    End Function

    Private Sub Form2_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            newLabText = "Right Mouse Button"
            newKey = Keys.RButton
        ElseIf e.Button = Windows.Forms.MouseButtons.Left Then
            newLabText = "Left Mouse Button"
            newKey = Keys.LButton
        ElseIf e.Button = Windows.Forms.MouseButtons.Middle Then
            newLabText = "Middle Mouse Button"
            newKey = Keys.MButton
        End If
    End Sub

    Private Sub backBut_Click(sender As Object, e As EventArgs) Handles backBut.Click
        My.Settings.Button1 = but1
        My.Settings.Button2 = but2
        My.Settings.Smoke = smk
        My.Settings.Activate = act
        My.Settings.Deactivate = deAct
        My.Settings.LengthUp = lngthUp
        My.Settings.LengthDown = lngthDn
        My.Settings.DotNum = mainFormTrace.dotPrint
        My.Settings.MsgDisable = msgDisable.Checked
        My.Settings.Save()
        Me.Hide()
    End Sub

    Public Sub loadSettings()
        but1 = My.Settings.Button1
        but2 = My.Settings.Button2
        smk = My.Settings.Smoke
        act = My.Settings.Activate
        deAct = My.Settings.Deactivate
        lngthUp = My.Settings.LengthUp
        lngthDn = My.Settings.LengthDown
        b1ConfigLab.Text = getNewText(but1)
        b2ConfigLab.Text = getNewText(but2)
        smkConfigLab.Text = getNewText(smk)
        actConfigLab.Text = getNewText(act)
        deactConfigLab.Text = getNewText(deAct)
        lengthUpConfigLab.Text = getNewText(lngthUp)
        lengthDnConfigLab.Text = getNewText(lngthDn)
        mainFormTrace.dotPrint = My.Settings.DotNum
        mainFormTrace.dotLab.Text = mainFormTrace.dotPrint.ToString()
        msgDisable.Checked = My.Settings.MsgDisable()
    End Sub

    Private Function getNewText(ByVal key As System.Windows.Forms.Keys) As String
        Dim escPress As System.Windows.Forms.Keys
        Dim f1Press As System.Windows.Forms.Keys
        Dim f2Press As System.Windows.Forms.Keys
        Dim f3Press As System.Windows.Forms.Keys
        Dim f4Press As System.Windows.Forms.Keys
        Dim f5Press As System.Windows.Forms.Keys
        Dim f6Press As System.Windows.Forms.Keys
        Dim f7Press As System.Windows.Forms.Keys
        Dim f8Press As System.Windows.Forms.Keys
        Dim f9Press As System.Windows.Forms.Keys
        Dim f10Press As System.Windows.Forms.Keys
        Dim f11Press As System.Windows.Forms.Keys
        Dim f12Press As System.Windows.Forms.Keys
        Dim delPress As System.Windows.Forms.Keys
        Dim homePress As System.Windows.Forms.Keys
        Dim endPress As System.Windows.Forms.Keys
        Dim pgUpPress As System.Windows.Forms.Keys
        Dim pgDnPress As System.Windows.Forms.Keys
        Dim bkTkPress As System.Windows.Forms.Keys
        Dim num1Press As System.Windows.Forms.Keys
        Dim num2Press As System.Windows.Forms.Keys
        Dim num3Press As System.Windows.Forms.Keys
        Dim num4Press As System.Windows.Forms.Keys
        Dim num5Press As System.Windows.Forms.Keys
        Dim num6Press As System.Windows.Forms.Keys
        Dim num7Press As System.Windows.Forms.Keys
        Dim num8Press As System.Windows.Forms.Keys
        Dim num9Press As System.Windows.Forms.Keys
        Dim num0Press As System.Windows.Forms.Keys
        Dim minusPress As System.Windows.Forms.Keys
        Dim plusPress As System.Windows.Forms.Keys
        Dim bkspcPress As System.Windows.Forms.Keys
        Dim tabPress As System.Windows.Forms.Keys
        Dim qPress As System.Windows.Forms.Keys
        Dim wPress As System.Windows.Forms.Keys
        Dim ePress As System.Windows.Forms.Keys
        Dim rPress As System.Windows.Forms.Keys
        Dim tPress As System.Windows.Forms.Keys
        Dim yPress As System.Windows.Forms.Keys
        Dim uPress As System.Windows.Forms.Keys
        Dim iPress As System.Windows.Forms.Keys
        Dim oPress As System.Windows.Forms.Keys
        Dim pPress As System.Windows.Forms.Keys
        Dim lBrkPress As System.Windows.Forms.Keys
        Dim rBrkPress As System.Windows.Forms.Keys
        Dim bkSlshPress As System.Windows.Forms.Keys
        Dim aPress As System.Windows.Forms.Keys
        Dim sPress As System.Windows.Forms.Keys
        Dim dPress As System.Windows.Forms.Keys
        Dim fPress As System.Windows.Forms.Keys
        Dim gPress As System.Windows.Forms.Keys
        Dim hPress As System.Windows.Forms.Keys
        Dim jPress As System.Windows.Forms.Keys
        Dim kPress As System.Windows.Forms.Keys
        Dim lPress As System.Windows.Forms.Keys
        Dim colPress As System.Windows.Forms.Keys
        Dim aposPress As System.Windows.Forms.Keys
        Dim enterPress As System.Windows.Forms.Keys
        Dim lShftPress As System.Windows.Forms.Keys
        Dim zPress As System.Windows.Forms.Keys
        Dim xPress As System.Windows.Forms.Keys
        Dim cPress As System.Windows.Forms.Keys
        Dim vPress As System.Windows.Forms.Keys
        Dim bPress As System.Windows.Forms.Keys
        Dim nPress As System.Windows.Forms.Keys
        Dim mPress As System.Windows.Forms.Keys
        Dim comPress As System.Windows.Forms.Keys
        Dim perPress As System.Windows.Forms.Keys
        Dim forSlshPress As System.Windows.Forms.Keys
        Dim rShiftPress As System.Windows.Forms.Keys
        Dim lCtrlPress As System.Windows.Forms.Keys
        Dim lAltPress As System.Windows.Forms.Keys
        Dim spacePress As System.Windows.Forms.Keys
        Dim rAltPress As System.Windows.Forms.Keys
        Dim rCtrlPress As System.Windows.Forms.Keys
        Dim lArrowPress As System.Windows.Forms.Keys
        Dim rArrowPress As System.Windows.Forms.Keys
        Dim uArrowPress As System.Windows.Forms.Keys
        Dim dArrowPress As System.Windows.Forms.Keys
        Dim pad0Press As System.Windows.Forms.Keys
        Dim pad1Press As System.Windows.Forms.Keys
        Dim pad2Press As System.Windows.Forms.Keys
        Dim pad3Press As System.Windows.Forms.Keys
        Dim pad4Press As System.Windows.Forms.Keys
        Dim pad5Press As System.Windows.Forms.Keys
        Dim pad6Press As System.Windows.Forms.Keys
        Dim pad7Press As System.Windows.Forms.Keys
        Dim pad8Press As System.Windows.Forms.Keys
        Dim pad9Press As System.Windows.Forms.Keys
        Dim padDecPress As System.Windows.Forms.Keys
        Dim pausePress As System.Windows.Forms.Keys
        Dim insertPress As System.Windows.Forms.Keys
        Dim lMouseBut As System.Windows.Forms.Keys
        Dim rMouseBut As System.Windows.Forms.Keys
        Dim mMouseBut As System.Windows.Forms.Keys
        Dim newText As String
        escPress = (Keys.Escape)
        f1Press = (Keys.F1)
        f2Press = (Keys.F2)
        f3Press = (Keys.F3)
        f4Press = (Keys.F4)
        f5Press = (Keys.F5)
        f6Press = (Keys.F6)
        f7Press = (Keys.F7)
        f8Press = (Keys.F8)
        f9Press = (Keys.F9)
        f10Press = (Keys.F10)
        f11Press = (Keys.F11)
        f12Press = (Keys.F12)
        delPress = (Keys.Delete)
        homePress = (Keys.Home)
        endPress = (Keys.End)
        pgUpPress = (Keys.PageUp)
        pgDnPress = (Keys.PageDown)
        bkTkPress = (Keys.Oemtilde)
        num1Press = (Keys.D1)
        num2Press = (Keys.D2)
        num3Press = (Keys.D3)
        num4Press = (Keys.D4)
        num5Press = (Keys.D5)
        num6Press = (Keys.D6)
        num7Press = (Keys.D7)
        num8Press = (Keys.D8)
        num9Press = (Keys.D9)
        num0Press = (Keys.D0)
        minusPress = (Keys.OemMinus)
        plusPress = (Keys.Oemplus)
        bkspcPress = (Keys.Back)
        tabPress = (Keys.Tab)
        qPress = (Keys.Q)
        wPress = (Keys.W)
        ePress = (Keys.E)
        rPress = (Keys.R)
        tPress = (Keys.T)
        yPress = (Keys.Y)
        uPress = (Keys.U)
        iPress = (Keys.I)
        oPress = (Keys.O)
        pPress = (Keys.P)
        lBrkPress = (Keys.OemOpenBrackets)
        rBrkPress = (Keys.OemCloseBrackets)
        bkSlshPress = (Keys.OemPipe)
        aPress = (Keys.A)
        sPress = (Keys.S)
        dPress = (Keys.D)
        fPress = (Keys.F)
        gPress = (Keys.G)
        hPress = (Keys.H)
        jPress = (Keys.J)
        kPress = (Keys.K)
        lPress = (Keys.L)
        colPress = (Keys.OemSemicolon)
        aposPress = (Keys.OemQuotes)
        enterPress = (Keys.Enter)
        lShftPress = (Keys.LShiftKey)
        zPress = (Keys.Z)
        xPress = (Keys.X)
        cPress = (Keys.C)
        vPress = (Keys.V)
        bPress = (Keys.B)
        nPress = (Keys.N)
        mPress = (Keys.M)
        comPress = (Keys.Oemcomma)
        perPress = (Keys.OemPeriod)
        forSlshPress = (Keys.OemQuestion)
        rShiftPress = (Keys.RShiftKey)
        lCtrlPress = (Keys.LControlKey)
        lAltPress = (Keys.LMenu)
        spacePress = (Keys.Space)
        rAltPress = (Keys.RMenu)
        rCtrlPress = (Keys.RControlKey)
        lArrowPress = (Keys.Left)
        rArrowPress = (Keys.Right)
        uArrowPress = (Keys.Up)
        dArrowPress = (Keys.Down)
        pad0Press = (Keys.NumPad0)
        pad1Press = (Keys.NumPad1)
        pad2Press = (Keys.NumPad2)
        pad3Press = (Keys.NumPad3)
        pad4Press = (Keys.NumPad4)
        pad5Press = (Keys.NumPad5)
        pad6Press = (Keys.NumPad6)
        pad7Press = (Keys.NumPad7)
        pad8Press = (Keys.NumPad8)
        pad9Press = (Keys.NumPad9)
        padDecPress = (Keys.Decimal)
        pausePress = (Keys.Pause)
        insertPress = (Keys.Insert)
        lMouseBut = (Keys.LButton)
        rMouseBut = (Keys.RButton)
        mMouseBut = (Keys.MButton)
        If key = escPress Then
            newText = "Escape"
        ElseIf key = f1Press Then
            newText = "F1"
        ElseIf key = f2Press Then
            newText = "F2"
        ElseIf key = f3Press Then
            newText = "F3"
        ElseIf key = f4Press Then
            newText = "F4"
        ElseIf key = f5Press Then
            newText = "F5"
        ElseIf key = f6Press Then
            newText = "F6"
        ElseIf key = f7Press Then
            newText = "F7"
        ElseIf key = f8Press Then
            newText = "F8"
        ElseIf key = f9Press Then
            newText = "F9"
        ElseIf key = f10Press Then
            newText = "F10"
        ElseIf key = f11Press Then
            newText = "F11"
        ElseIf key = f12Press Then
            newText = "F12"
        ElseIf key = delPress Then
            newText = "Del"
        ElseIf key = homePress Then
            newText = "Home"
        ElseIf key = endPress Then
            newText = "End"
        ElseIf key = pgUpPress Then
            newText = "Page Up"
        ElseIf key = pgDnPress Then
            newText = "Page Down"
        ElseIf key = bkTkPress Then
            newText = "`"
        ElseIf key = num1Press Then
            newText = "1"
        ElseIf key = num2Press Then
            newText = "2"
        ElseIf key = num3Press Then
            newText = "3"
        ElseIf key = num4Press Then
            newText = "4"
        ElseIf key = num5Press Then
            newText = "5"
        ElseIf key = num6Press Then
            newText = "6"
        ElseIf key = num7Press Then
            newText = "7"
        ElseIf key = num8Press Then
            newText = "8"
        ElseIf key = num9Press Then
            newText = "9"
        ElseIf key = num0Press Then
            newText = "0"
        ElseIf key = minusPress Then
            newText = "-"
        ElseIf key = plusPress Then
            newText = "="
        ElseIf key = bkspcPress Then
            newText = "Backspace"
        ElseIf key = tabPress Then
            newText = "Tab"
        ElseIf key = qPress Then
            newText = "Q"
        ElseIf key = wPress Then
            newText = "W"
        ElseIf key = ePress Then
            newText = "E"
        ElseIf key = rPress Then
            newText = "R"
        ElseIf key = tPress Then
            newText = "T"
        ElseIf key = yPress Then
            newText = "Y"
        ElseIf key = uPress Then
            newText = "U"
        ElseIf key = iPress Then
            newText = "I"
        ElseIf key = oPress Then
            newText = "O"
        ElseIf key = pPress Then
            newText = "P"
        ElseIf key = lBrkPress Then
            newText = "["
        ElseIf key = rBrkPress Then
            newText = "]"
        ElseIf key = bkSlshPress Then
            newText = "\"
        ElseIf key = aPress Then
            newText = "A"
        ElseIf key = sPress Then
            newText = "S"
        ElseIf key = dPress Then
            newText = "D"
        ElseIf key = fPress Then
            newText = "F"
        ElseIf key = gPress Then
            newText = "G"
        ElseIf key = hPress Then
            newText = "H"
        ElseIf key = jPress Then
            newText = "J"
        ElseIf key = kPress Then
            newText = "K"
        ElseIf key = lPress Then
            newText = "L"
        ElseIf key = colPress Then
            newText = ";"
        ElseIf key = aposPress Then
            newText = "'"
        ElseIf key = enterPress Then
            newText = "Enter"
        ElseIf key = lShftPress Then
            newText = "Left Shift"
        ElseIf key = zPress Then
            newText = "Z"
        ElseIf key = xPress Then
            newText = "X"
        ElseIf key = cPress Then
            newText = "C"
        ElseIf key = vPress Then
            newText = "V"
        ElseIf key = bPress Then
            newText = "B"
        ElseIf key = nPress Then
            newText = "N"
        ElseIf key = mPress Then
            newText = "L"
        ElseIf key = comPress Then
            newText = ","
        ElseIf key = perPress Then
            newText = "."
        ElseIf key = forSlshPress Then
            newText = "/"
        ElseIf key = rShiftPress Then
            newText = "Right Shift"
        ElseIf key = lCtrlPress Then
            newText = "Left Ctrl"
        ElseIf key = lAltPress Then
            newText = "Left Alt"
        ElseIf key = spacePress Then
            newText = "Space"
        ElseIf key = rAltPress Then
            newText = "Right Alt"
        ElseIf key = rCtrlPress Then
            newText = "Right Ctrl"
        ElseIf key = lArrowPress Then
            newText = "Left Arrow"
        ElseIf key = rArrowPress Then
            newText = "Right Arrow"
        ElseIf key = uArrowPress Then
            newText = "Up Arrow"
        ElseIf key = dArrowPress Then
            newText = "Down Arrow"
        ElseIf key = pad0Press Then
            newText = "Numpad 0"
        ElseIf key = pad1Press Then
            newText = "Numpad 1"
        ElseIf key = pad2Press Then
            newText = "Numpad 2"
        ElseIf key = pad3Press Then
            newText = "Numpad 3"
        ElseIf key = pad4Press Then
            newText = "Numpad 4"
        ElseIf key = pad5Press Then
            newText = "Numpad 5"
        ElseIf key = pad6Press Then
            newText = "Numpad 6"
        ElseIf key = pad7Press Then
            newText = "Numpad 7"
        ElseIf key = pad8Press Then
            newText = "Numpad 8"
        ElseIf key = pad9Press Then
            newText = "Numpad 9"
        ElseIf key = padDecPress Then
            newText = "Numpad ."
        ElseIf key = pausePress Then
            newText = "Pause"
        ElseIf key = insertPress Then
            newText = "Insert"
        ElseIf key = lMouseBut Then
            newText = "Left Mouse"
        ElseIf key = rMouseBut Then
            newText = "Right Mouse"
        ElseIf key = mMouseBut Then
            newText = "Middle Mouse"
        Else
            newText = "No Key Chosen"
        End If
        Return newText
    End Function
End Class