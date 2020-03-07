<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.post = New System.Windows.Forms.Label()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.HealthBar = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.Gameing = New System.Windows.Forms.Timer(Me.components)
        Me.ComboLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LevleLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.post)
        Me.Panel1.Controls.Add(Me.StartButton)
        Me.Panel1.Location = New System.Drawing.Point(15, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(230, 255)
        Me.Panel1.TabIndex = 0
        '
        'post
        '
        Me.post.Location = New System.Drawing.Point(49, 88)
        Me.post.Name = "post"
        Me.post.Size = New System.Drawing.Size(137, 53)
        Me.post.TabIndex = 9
        Me.post.Text = "小叮嚀:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "請於開始前切換輸入法:D"
        Me.post.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(63, 144)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(108, 30)
        Me.StartButton.TabIndex = 8
        Me.StartButton.Text = "開始遊戲"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(104, 288)
        Me.TextBox1.MaxLength = 1
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(50, 22)
        Me.TextBox1.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'HealthBar
        '
        Me.HealthBar.Location = New System.Drawing.Point(12, 272)
        Me.HealthBar.Name = "HealthBar"
        Me.HealthBar.Size = New System.Drawing.Size(229, 10)
        Me.HealthBar.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("標楷體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 317)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "分數:"
        '
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ScoreLabel.Location = New System.Drawing.Point(63, 321)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(19, 13)
        Me.ScoreLabel.TabIndex = 4
        Me.ScoreLabel.Text = "---"
        '
        'Gameing
        '
        Me.Gameing.Interval = 10
        '
        'ComboLabel
        '
        Me.ComboLabel.AutoSize = True
        Me.ComboLabel.Font = New System.Drawing.Font("新細明體", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ComboLabel.ForeColor = System.Drawing.Color.DeepPink
        Me.ComboLabel.Location = New System.Drawing.Point(156, 325)
        Me.ComboLabel.Name = "ComboLabel"
        Me.ComboLabel.Size = New System.Drawing.Size(54, 21)
        Me.ComboLabel.TabIndex = 10
        Me.ComboLabel.Text = "連擊"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("標楷體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 340)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "關卡:"
        '
        'LevleLabel
        '
        Me.LevleLabel.AutoSize = True
        Me.LevleLabel.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LevleLabel.Location = New System.Drawing.Point(63, 343)
        Me.LevleLabel.Name = "LevleLabel"
        Me.LevleLabel.Size = New System.Drawing.Size(19, 13)
        Me.LevleLabel.TabIndex = 12
        Me.LevleLabel.Text = "---"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 368)
        Me.Controls.Add(Me.LevleLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboLabel)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HealthBar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "練習用打字遊戲"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents HealthBar As System.Windows.Forms.ProgressBar
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ScoreLabel As System.Windows.Forms.Label
    Friend WithEvents Gameing As System.Windows.Forms.Timer
    Friend WithEvents post As System.Windows.Forms.Label
    Friend WithEvents ComboLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LevleLabel As System.Windows.Forms.Label

End Class
