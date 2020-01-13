<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.b1Config = New System.Windows.Forms.Button()
        Me.b2Config = New System.Windows.Forms.Button()
        Me.smkConfig = New System.Windows.Forms.Button()
        Me.actConfig = New System.Windows.Forms.Button()
        Me.deactConfig = New System.Windows.Forms.Button()
        Me.lengthUpConfig = New System.Windows.Forms.Button()
        Me.lengthDnConfig = New System.Windows.Forms.Button()
        Me.b1ConfigLab = New System.Windows.Forms.Label()
        Me.b2ConfigLab = New System.Windows.Forms.Label()
        Me.smkConfigLab = New System.Windows.Forms.Label()
        Me.actConfigLab = New System.Windows.Forms.Label()
        Me.deactConfigLab = New System.Windows.Forms.Label()
        Me.lengthUpConfigLab = New System.Windows.Forms.Label()
        Me.lengthDnConfigLab = New System.Windows.Forms.Label()
        Me.backBut = New System.Windows.Forms.Button()
        Me.getKey = New System.Windows.Forms.Timer(Me.components)
        Me.startGet = New System.Windows.Forms.Timer(Me.components)
        Me.msgDisable = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'b1Config
        '
        Me.b1Config.Location = New System.Drawing.Point(13, 18)
        Me.b1Config.Name = "b1Config"
        Me.b1Config.Size = New System.Drawing.Size(75, 23)
        Me.b1Config.TabIndex = 0
        Me.b1Config.Text = "Button 1"
        Me.b1Config.UseVisualStyleBackColor = True
        '
        'b2Config
        '
        Me.b2Config.Location = New System.Drawing.Point(12, 47)
        Me.b2Config.Name = "b2Config"
        Me.b2Config.Size = New System.Drawing.Size(75, 23)
        Me.b2Config.TabIndex = 1
        Me.b2Config.Text = "Button 2"
        Me.b2Config.UseVisualStyleBackColor = True
        '
        'smkConfig
        '
        Me.smkConfig.Location = New System.Drawing.Point(13, 76)
        Me.smkConfig.Name = "smkConfig"
        Me.smkConfig.Size = New System.Drawing.Size(75, 23)
        Me.smkConfig.TabIndex = 2
        Me.smkConfig.Text = "Smoke"
        Me.smkConfig.UseVisualStyleBackColor = True
        '
        'actConfig
        '
        Me.actConfig.Location = New System.Drawing.Point(12, 105)
        Me.actConfig.Name = "actConfig"
        Me.actConfig.Size = New System.Drawing.Size(75, 23)
        Me.actConfig.TabIndex = 3
        Me.actConfig.Text = "Activate"
        Me.actConfig.UseVisualStyleBackColor = True
        '
        'deactConfig
        '
        Me.deactConfig.Location = New System.Drawing.Point(13, 134)
        Me.deactConfig.Name = "deactConfig"
        Me.deactConfig.Size = New System.Drawing.Size(75, 23)
        Me.deactConfig.TabIndex = 4
        Me.deactConfig.Text = "Deactivate"
        Me.deactConfig.UseVisualStyleBackColor = True
        '
        'lengthUpConfig
        '
        Me.lengthUpConfig.Location = New System.Drawing.Point(12, 163)
        Me.lengthUpConfig.Name = "lengthUpConfig"
        Me.lengthUpConfig.Size = New System.Drawing.Size(75, 23)
        Me.lengthUpConfig.TabIndex = 5
        Me.lengthUpConfig.Text = "+ Length"
        Me.lengthUpConfig.UseVisualStyleBackColor = True
        '
        'lengthDnConfig
        '
        Me.lengthDnConfig.Location = New System.Drawing.Point(13, 192)
        Me.lengthDnConfig.Name = "lengthDnConfig"
        Me.lengthDnConfig.Size = New System.Drawing.Size(75, 23)
        Me.lengthDnConfig.TabIndex = 6
        Me.lengthDnConfig.Text = "- Length"
        Me.lengthDnConfig.UseVisualStyleBackColor = True
        '
        'b1ConfigLab
        '
        Me.b1ConfigLab.AutoSize = True
        Me.b1ConfigLab.Location = New System.Drawing.Point(128, 28)
        Me.b1ConfigLab.Name = "b1ConfigLab"
        Me.b1ConfigLab.Size = New System.Drawing.Size(14, 13)
        Me.b1ConfigLab.TabIndex = 7
        Me.b1ConfigLab.Text = "Z"
        '
        'b2ConfigLab
        '
        Me.b2ConfigLab.AutoSize = True
        Me.b2ConfigLab.Location = New System.Drawing.Point(128, 57)
        Me.b2ConfigLab.Name = "b2ConfigLab"
        Me.b2ConfigLab.Size = New System.Drawing.Size(14, 13)
        Me.b2ConfigLab.TabIndex = 8
        Me.b2ConfigLab.Text = "X"
        '
        'smkConfigLab
        '
        Me.smkConfigLab.AutoSize = True
        Me.smkConfigLab.Location = New System.Drawing.Point(128, 86)
        Me.smkConfigLab.Name = "smkConfigLab"
        Me.smkConfigLab.Size = New System.Drawing.Size(14, 13)
        Me.smkConfigLab.TabIndex = 9
        Me.smkConfigLab.Text = "C"
        '
        'actConfigLab
        '
        Me.actConfigLab.AutoSize = True
        Me.actConfigLab.Location = New System.Drawing.Point(128, 115)
        Me.actConfigLab.Name = "actConfigLab"
        Me.actConfigLab.Size = New System.Drawing.Size(49, 13)
        Me.actConfigLab.TabIndex = 10
        Me.actConfigLab.Text = "Page Up"
        '
        'deactConfigLab
        '
        Me.deactConfigLab.AutoSize = True
        Me.deactConfigLab.Location = New System.Drawing.Point(128, 144)
        Me.deactConfigLab.Name = "deactConfigLab"
        Me.deactConfigLab.Size = New System.Drawing.Size(63, 13)
        Me.deactConfigLab.TabIndex = 11
        Me.deactConfigLab.Text = "Page Down"
        '
        'lengthUpConfigLab
        '
        Me.lengthUpConfigLab.AutoSize = True
        Me.lengthUpConfigLab.Location = New System.Drawing.Point(128, 173)
        Me.lengthUpConfigLab.Name = "lengthUpConfigLab"
        Me.lengthUpConfigLab.Size = New System.Drawing.Size(13, 13)
        Me.lengthUpConfigLab.TabIndex = 12
        Me.lengthUpConfigLab.Text = "="
        '
        'lengthDnConfigLab
        '
        Me.lengthDnConfigLab.AutoSize = True
        Me.lengthDnConfigLab.Location = New System.Drawing.Point(128, 202)
        Me.lengthDnConfigLab.Name = "lengthDnConfigLab"
        Me.lengthDnConfigLab.Size = New System.Drawing.Size(10, 13)
        Me.lengthDnConfigLab.TabIndex = 13
        Me.lengthDnConfigLab.Text = "-"
        '
        'backBut
        '
        Me.backBut.Location = New System.Drawing.Point(65, 253)
        Me.backBut.Name = "backBut"
        Me.backBut.Size = New System.Drawing.Size(112, 23)
        Me.backBut.TabIndex = 14
        Me.backBut.Text = "Return and Save"
        Me.backBut.UseVisualStyleBackColor = True
        '
        'getKey
        '
        Me.getKey.Interval = 1
        '
        'startGet
        '
        Me.startGet.Interval = 1000
        '
        'msgDisable
        '
        Me.msgDisable.AutoSize = True
        Me.msgDisable.Location = New System.Drawing.Point(13, 230)
        Me.msgDisable.Name = "msgDisable"
        Me.msgDisable.Size = New System.Drawing.Size(179, 17)
        Me.msgDisable.TabIndex = 15
        Me.msgDisable.Text = "Disable the messages on startup"
        Me.msgDisable.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(244, 288)
        Me.ControlBox = False
        Me.Controls.Add(Me.msgDisable)
        Me.Controls.Add(Me.backBut)
        Me.Controls.Add(Me.lengthDnConfigLab)
        Me.Controls.Add(Me.lengthUpConfigLab)
        Me.Controls.Add(Me.deactConfigLab)
        Me.Controls.Add(Me.actConfigLab)
        Me.Controls.Add(Me.smkConfigLab)
        Me.Controls.Add(Me.b2ConfigLab)
        Me.Controls.Add(Me.b1ConfigLab)
        Me.Controls.Add(Me.lengthDnConfig)
        Me.Controls.Add(Me.lengthUpConfig)
        Me.Controls.Add(Me.deactConfig)
        Me.Controls.Add(Me.actConfig)
        Me.Controls.Add(Me.smkConfig)
        Me.Controls.Add(Me.b2Config)
        Me.Controls.Add(Me.b1Config)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Form2"
        Me.Text = "Configuration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents b1Config As System.Windows.Forms.Button
    Friend WithEvents b2Config As System.Windows.Forms.Button
    Friend WithEvents smkConfig As System.Windows.Forms.Button
    Friend WithEvents actConfig As System.Windows.Forms.Button
    Friend WithEvents deactConfig As System.Windows.Forms.Button
    Friend WithEvents lengthUpConfig As System.Windows.Forms.Button
    Friend WithEvents lengthDnConfig As System.Windows.Forms.Button
    Friend WithEvents b1ConfigLab As System.Windows.Forms.Label
    Friend WithEvents b2ConfigLab As System.Windows.Forms.Label
    Friend WithEvents smkConfigLab As System.Windows.Forms.Label
    Friend WithEvents actConfigLab As System.Windows.Forms.Label
    Friend WithEvents deactConfigLab As System.Windows.Forms.Label
    Friend WithEvents lengthUpConfigLab As System.Windows.Forms.Label
    Friend WithEvents lengthDnConfigLab As System.Windows.Forms.Label
    Friend WithEvents backBut As System.Windows.Forms.Button
    Friend WithEvents getKey As System.Windows.Forms.Timer
    Friend WithEvents startGet As System.Windows.Forms.Timer
    Public WithEvents msgDisable As System.Windows.Forms.CheckBox
End Class
