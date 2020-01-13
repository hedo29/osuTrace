<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainFormTrace
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainFormTrace))
        Me.actBut = New System.Windows.Forms.Button()
        Me.tracTmr = New System.Windows.Forms.Timer(Me.components)
        Me.deActBut = New System.Windows.Forms.Button()
        Me.drawPan = New System.Windows.Forms.PictureBox()
        Me.drawTmr = New System.Windows.Forms.Timer(Me.components)
        Me.chngLenBut = New System.Windows.Forms.Button()
        Me.dotsStaticLab = New System.Windows.Forms.Label()
        Me.dotLab = New System.Windows.Forms.Label()
        Me.StandardStyle = New System.Windows.Forms.RadioButton()
        Me.ZmanStyle = New System.Windows.Forms.RadioButton()
        Me.HedonicStyle = New System.Windows.Forms.RadioButton()
        Me.resizeBut = New System.Windows.Forms.Button()
        Me.resetBut = New System.Windows.Forms.Button()
        Me.versionLab = New System.Windows.Forms.Label()
        Me.actTmr = New System.Windows.Forms.Timer(Me.components)
        Me.keyHLPBUT = New System.Windows.Forms.Button()
        Me.clrBkChk = New System.Windows.Forms.CheckBox()
        Me.tnsparBkChk = New System.Windows.Forms.CheckBox()
        CType(Me.drawPan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'actBut
        '
        Me.actBut.BackColor = System.Drawing.Color.Lime
        Me.actBut.Location = New System.Drawing.Point(12, 269)
        Me.actBut.Name = "actBut"
        Me.actBut.Size = New System.Drawing.Size(75, 23)
        Me.actBut.TabIndex = 0
        Me.actBut.Text = "Activate"
        Me.actBut.UseVisualStyleBackColor = False
        '
        'tracTmr
        '
        Me.tracTmr.Interval = 1
        '
        'deActBut
        '
        Me.deActBut.BackColor = System.Drawing.Color.Red
        Me.deActBut.Location = New System.Drawing.Point(93, 269)
        Me.deActBut.Name = "deActBut"
        Me.deActBut.Size = New System.Drawing.Size(75, 23)
        Me.deActBut.TabIndex = 1
        Me.deActBut.Text = "Deactivate"
        Me.deActBut.UseVisualStyleBackColor = False
        '
        'drawPan
        '
        Me.drawPan.BackColor = System.Drawing.SystemColors.Control
        Me.drawPan.BackgroundImage = Global.osu_Trace.My.Resources.Resources.Clear
        Me.drawPan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.drawPan.Location = New System.Drawing.Point(12, 12)
        Me.drawPan.Name = "drawPan"
        Me.drawPan.Size = New System.Drawing.Size(400, 240)
        Me.drawPan.TabIndex = 0
        Me.drawPan.TabStop = False
        '
        'drawTmr
        '
        Me.drawTmr.Interval = 10
        '
        'chngLenBut
        '
        Me.chngLenBut.Location = New System.Drawing.Point(174, 295)
        Me.chngLenBut.Name = "chngLenBut"
        Me.chngLenBut.Size = New System.Drawing.Size(101, 23)
        Me.chngLenBut.TabIndex = 2
        Me.chngLenBut.Text = "Change Length..."
        Me.chngLenBut.UseVisualStyleBackColor = True
        '
        'dotsStaticLab
        '
        Me.dotsStaticLab.AutoSize = True
        Me.dotsStaticLab.Location = New System.Drawing.Point(171, 323)
        Me.dotsStaticLab.Name = "dotsStaticLab"
        Me.dotsStaticLab.Size = New System.Drawing.Size(46, 13)
        Me.dotsStaticLab.TabIndex = 3
        Me.dotsStaticLab.Text = "Length: "
        '
        'dotLab
        '
        Me.dotLab.AutoSize = True
        Me.dotLab.Location = New System.Drawing.Point(256, 324)
        Me.dotLab.Name = "dotLab"
        Me.dotLab.Size = New System.Drawing.Size(19, 13)
        Me.dotLab.TabIndex = 4
        Me.dotLab.Text = "65"
        '
        'StandardStyle
        '
        Me.StandardStyle.AutoSize = True
        Me.StandardStyle.Checked = True
        Me.StandardStyle.Location = New System.Drawing.Point(303, 307)
        Me.StandardStyle.Name = "StandardStyle"
        Me.StandardStyle.Size = New System.Drawing.Size(93, 17)
        Me.StandardStyle.TabIndex = 6
        Me.StandardStyle.TabStop = True
        Me.StandardStyle.Text = "Standard(Z/X)"
        Me.StandardStyle.UseVisualStyleBackColor = True
        Me.StandardStyle.Visible = False
        '
        'ZmanStyle
        '
        Me.ZmanStyle.AutoSize = True
        Me.ZmanStyle.Location = New System.Drawing.Point(303, 275)
        Me.ZmanStyle.Name = "ZmanStyle"
        Me.ZmanStyle.Size = New System.Drawing.Size(96, 17)
        Me.ZmanStyle.TabIndex = 7
        Me.ZmanStyle.Text = "Zman840 Style"
        Me.ZmanStyle.UseVisualStyleBackColor = True
        Me.ZmanStyle.Visible = False
        '
        'HedonicStyle
        '
        Me.HedonicStyle.AutoSize = True
        Me.HedonicStyle.Location = New System.Drawing.Point(303, 291)
        Me.HedonicStyle.Name = "HedonicStyle"
        Me.HedonicStyle.Size = New System.Drawing.Size(121, 17)
        Me.HedonicStyle.TabIndex = 8
        Me.HedonicStyle.Text = "HedonicKnight Style"
        Me.HedonicStyle.UseVisualStyleBackColor = True
        Me.HedonicStyle.Visible = False
        '
        'resizeBut
        '
        Me.resizeBut.Location = New System.Drawing.Point(12, 295)
        Me.resizeBut.Name = "resizeBut"
        Me.resizeBut.Size = New System.Drawing.Size(75, 23)
        Me.resizeBut.TabIndex = 9
        Me.resizeBut.Text = "Resize"
        Me.resizeBut.UseVisualStyleBackColor = True
        '
        'resetBut
        '
        Me.resetBut.Location = New System.Drawing.Point(93, 295)
        Me.resetBut.Name = "resetBut"
        Me.resetBut.Size = New System.Drawing.Size(75, 23)
        Me.resetBut.TabIndex = 10
        Me.resetBut.Text = "Reset"
        Me.resetBut.UseVisualStyleBackColor = True
        '
        'versionLab
        '
        Me.versionLab.AutoSize = True
        Me.versionLab.Location = New System.Drawing.Point(373, 328)
        Me.versionLab.Name = "versionLab"
        Me.versionLab.Size = New System.Drawing.Size(39, 13)
        Me.versionLab.TabIndex = 11
        Me.versionLab.Text = "Label1"
        '
        'actTmr
        '
        Me.actTmr.Enabled = True
        Me.actTmr.Interval = 1
        '
        'keyHLPBUT
        '
        Me.keyHLPBUT.Location = New System.Drawing.Point(174, 269)
        Me.keyHLPBUT.Name = "keyHLPBUT"
        Me.keyHLPBUT.Size = New System.Drawing.Size(75, 23)
        Me.keyHLPBUT.TabIndex = 12
        Me.keyHLPBUT.Text = "Hotkeys..."
        Me.keyHLPBUT.UseVisualStyleBackColor = True
        '
        'clrBkChk
        '
        Me.clrBkChk.AutoSize = True
        Me.clrBkChk.Location = New System.Drawing.Point(12, 324)
        Me.clrBkChk.Name = "clrBkChk"
        Me.clrBkChk.Size = New System.Drawing.Size(53, 17)
        Me.clrBkChk.TabIndex = 5
        Me.clrBkChk.Text = "Black"
        Me.clrBkChk.UseVisualStyleBackColor = True
        '
        'tnsparBkChk
        '
        Me.tnsparBkChk.AutoSize = True
        Me.tnsparBkChk.Location = New System.Drawing.Point(68, 324)
        Me.tnsparBkChk.Name = "tnsparBkChk"
        Me.tnsparBkChk.Size = New System.Drawing.Size(83, 17)
        Me.tnsparBkChk.TabIndex = 13
        Me.tnsparBkChk.Text = "Transparent"
        Me.tnsparBkChk.UseVisualStyleBackColor = True
        '
        'mainFormTrace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 347)
        Me.Controls.Add(Me.tnsparBkChk)
        Me.Controls.Add(Me.keyHLPBUT)
        Me.Controls.Add(Me.versionLab)
        Me.Controls.Add(Me.resetBut)
        Me.Controls.Add(Me.resizeBut)
        Me.Controls.Add(Me.HedonicStyle)
        Me.Controls.Add(Me.ZmanStyle)
        Me.Controls.Add(Me.StandardStyle)
        Me.Controls.Add(Me.clrBkChk)
        Me.Controls.Add(Me.dotLab)
        Me.Controls.Add(Me.dotsStaticLab)
        Me.Controls.Add(Me.chngLenBut)
        Me.Controls.Add(Me.drawPan)
        Me.Controls.Add(Me.deActBut)
        Me.Controls.Add(Me.actBut)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "mainFormTrace"
        Me.Text = "osu!Trace"
        CType(Me.drawPan,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents actBut As System.Windows.Forms.Button
    Friend WithEvents tracTmr As System.Windows.Forms.Timer
    Friend WithEvents deActBut As System.Windows.Forms.Button
    Friend WithEvents drawPan As System.Windows.Forms.PictureBox
    Friend WithEvents drawTmr As System.Windows.Forms.Timer
    Friend WithEvents chngLenBut As System.Windows.Forms.Button
    Friend WithEvents dotsStaticLab As System.Windows.Forms.Label
    Friend WithEvents StandardStyle As System.Windows.Forms.RadioButton
    Friend WithEvents ZmanStyle As System.Windows.Forms.RadioButton
    Friend WithEvents HedonicStyle As System.Windows.Forms.RadioButton
    Friend WithEvents resizeBut As System.Windows.Forms.Button
    Friend WithEvents resetBut As System.Windows.Forms.Button
    Friend WithEvents versionLab As System.Windows.Forms.Label
    Friend WithEvents actTmr As System.Windows.Forms.Timer
    Friend WithEvents keyHLPBUT As System.Windows.Forms.Button
    Friend WithEvents clrBkChk As System.Windows.Forms.CheckBox
    Friend WithEvents tnsparBkChk As System.Windows.Forms.CheckBox
    Public WithEvents dotLab As System.Windows.Forms.Label

End Class
