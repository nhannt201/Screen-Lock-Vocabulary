<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class lock
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lock))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.word = New System.Windows.Forms.Label()
        Me.speed_v = New System.Windows.Forms.HScrollBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmx = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.auto_sp = New System.Windows.Forms.Label()
        Me.at_sp = New System.Windows.Forms.Timer(Me.components)
        Me.at_spss = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(33, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New Word Today"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(36, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(583, 1)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'txt
        '
        Me.txt.BackColor = System.Drawing.Color.Black
        Me.txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt.ForeColor = System.Drawing.Color.White
        Me.txt.Location = New System.Drawing.Point(36, 87)
        Me.txt.Name = "txt"
        Me.txt.ReadOnly = True
        Me.txt.Size = New System.Drawing.Size(583, 228)
        Me.txt.TabIndex = 2
        Me.txt.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(33, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Vocabulary:"
        '
        'word
        '
        Me.word.AutoSize = True
        Me.word.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.word.ForeColor = System.Drawing.Color.White
        Me.word.Location = New System.Drawing.Point(130, 56)
        Me.word.Name = "word"
        Me.word.Size = New System.Drawing.Size(41, 16)
        Me.word.TabIndex = 4
        Me.word.Text = "word"
        '
        'speed_v
        '
        Me.speed_v.Location = New System.Drawing.Point(501, 56)
        Me.speed_v.Maximum = 10
        Me.speed_v.Minimum = -10
        Me.speed_v.Name = "speed_v"
        Me.speed_v.Size = New System.Drawing.Size(105, 17)
        Me.speed_v.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(430, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Speed:"
        '
        'cmx
        '
        Me.cmx.FormattingEnabled = True
        Me.cmx.Location = New System.Drawing.Point(275, 339)
        Me.cmx.Name = "cmx"
        Me.cmx.Size = New System.Drawing.Size(96, 21)
        Me.cmx.TabIndex = 7
        Me.cmx.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'auto_sp
        '
        Me.auto_sp.AutoSize = True
        Me.auto_sp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.auto_sp.ForeColor = System.Drawing.Color.White
        Me.auto_sp.Location = New System.Drawing.Point(299, 57)
        Me.auto_sp.Name = "auto_sp"
        Me.auto_sp.Size = New System.Drawing.Size(83, 16)
        Me.auto_sp.TabIndex = 8
        Me.auto_sp.Text = "Auto Speak"
        '
        'at_sp
        '
        Me.at_sp.Interval = 1500
        '
        'at_spss
        '
        Me.at_spss.Interval = 300000
        '
        'lock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(637, 339)
        Me.Controls.Add(Me.auto_sp)
        Me.Controls.Add(Me.cmx)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.speed_v)
        Me.Controls.Add(Me.word)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "lock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Screen Lock Vocabulary"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents word As Label
    Friend WithEvents speed_v As HScrollBar
    Friend WithEvents Label3 As Label
    Friend WithEvents cmx As ComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents auto_sp As Label
    Friend WithEvents at_sp As Timer
    Friend WithEvents at_spss As Timer
End Class
