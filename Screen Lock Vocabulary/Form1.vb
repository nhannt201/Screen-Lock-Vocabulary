Imports System.Net
Imports System.Text
Imports System.Speech.Synthesis
Imports Microsoft.Win32

Public Class lock
    Dim speed As String = 0
    Dim autosp As String = 0
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub lock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'add starup
        Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", Application.ProductName, Application.ExecutablePath, RegistryValueKind.String)
        '  cmx.Items.Add("Nam")
        ' cmx.Items.Add("Nữ")
        Dim wc As New WebClient()
        wc.Encoding = System.Text.Encoding.UTF8
        Dim wordint As String = New System.Net.WebClient().DownloadString("http://new-word.vietdap.com/get.php?new=true")
        Dim newword As String = wc.DownloadString("http://new-word.vietdap.com/get.php?key=" & wordint)
        word.Text = StrConv(SplitString(newword, "[w]", "[/w]"), 3)
        txt.Text = Trim(newword.Replace("[n]", vbNewLine).Replace("[vn]", "Nghĩa là: ").Replace("[.]", "- ").Replace("[w]", "").Replace("[/w]", "").Replace(StrConv(word.Text, 2), "").Replace("Related words", ""))
        txt.Text = txt.Text.Trim
        'remove starup
        'My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
        Timer1.Start()
    End Sub
    Public Function SplitString(ByVal mainString As String, ByVal BeginString As String, ByVal EndString As String) As String
        Dim i_s As Integer : i_s = InStr(mainString, BeginString)
        Dim i_e As Integer : i_e = InStr(mainString, EndString)
        On Error Resume Next
        If i_s <> -1 And i_e <> -1 Then
            Dim s As String

            s = Mid(mainString, i_s + Len(BeginString), i_e - i_s - Len(BeginString))
            SplitString = s

        Else
            SplitString = ""
        End If
    End Function

    Private Sub word_Click(sender As Object, e As EventArgs) Handles word.Click
        If speed = 0 Then
            Dim SAPI2 As New SpeechSynthesizer
            SAPI2.Rate = speed_v.Value
            SAPI2.SelectVoiceByHints(VoiceGender.Male)
            SAPI2.Speak(word.Text)
            speed = 1
        ElseIf speed = 1 Then
            Dim SAPI2 As New SpeechSynthesizer
            SAPI2.Rate = speed_v.Value
            SAPI2.SelectVoiceByHints(VoiceGender.Female)
            SAPI2.Speak(word.Text)
            speed = 0
        End If
    End Sub

    Private Sub cmx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmx.SelectedIndexChanged
        If cmx.Text = "Nam" Then
            speed = 0
        Else
            speed = 1
        End If
    End Sub

    Private Sub ketthuc_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub lock_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub lock_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub

    Private Sub lock_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim SAPI2 As New SpeechSynthesizer
        SAPI2.Rate = speed_v.Value
        SAPI2.SelectVoiceByHints(VoiceGender.Male)
        SAPI2.Speak(word.Text)
        autosp = 1
        auto_sp.ForeColor = Color.Orange
        at_sp.Start()
        at_spss.Start()
        Timer1.Stop()
    End Sub

    Private Sub auto_sp_Click(sender As Object, e As EventArgs) Handles auto_sp.Click
        autospeak()
    End Sub

    Sub autospeak()

        If autosp = 0 Then
            autosp = 1
            auto_sp.ForeColor = Color.Orange
            at_sp.Start()
        ElseIf autosp = 1 Then
            autosp = 0
            auto_sp.ForeColor = Color.White
            at_sp.Stop()
        End If
    End Sub

    Private Sub at_sp_Tick(sender As Object, e As EventArgs) Handles at_sp.Tick
        Dim rn As New Random
        Dim nextValue As Integer = rn.Next(-10, 10)
        speed_v.Value = nextValue
        If autosp = 0 Then
            auto_sp.ForeColor = Color.White
            at_sp.Stop()
        End If
        If speed = 0 Then
            Dim SAPI2 As New SpeechSynthesizer
            SAPI2.Rate = speed_v.Value
            SAPI2.SelectVoiceByHints(VoiceGender.Male)
            SAPI2.Speak(word.Text)
            speed = 1
        ElseIf speed = 1 Then
            Dim SAPI2 As New SpeechSynthesizer
            SAPI2.Rate = speed_v.Value
            SAPI2.SelectVoiceByHints(VoiceGender.Female)
            SAPI2.Speak(word.Text)
            speed = 0
        End If
    End Sub

    Private Sub at_spss_Tick(sender As Object, e As EventArgs) Handles at_spss.Tick
        at_sp.Stop()
        End
    End Sub
End Class
