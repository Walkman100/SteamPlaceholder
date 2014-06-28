Imports System.Math
Imports System.IO
Imports System.Threading

Public Class SteamPlaceholder

    Dim ProgArg As String = ""
    
    Private Sub LoadSteamPlaceHolder() Handles Me.Load
        'fill GUI elements
        txtCommand1.Text = My.Settings.Command1
        txtProgram1.Text = My.Settings.Program1
        txtCommand2.Text = My.Settings.Command2
        txtProgram2.Text = My.Settings.Program2
        txtCommand3.Text = My.Settings.Command3
        txtProgram3.Text = My.Settings.Program3
        txtCommand4.Text = My.Settings.Command4
        txtProgram4.Text = My.Settings.Program4
        
        'get CommandLineArgs, copy them to a variable or apply them
        For Each s As String In My.Application.CommandLineArgs
            If s = "hideGUI" Or s = "hidegui" Then
                WindowState = FormWindowState.Minimized
            ElseIf s <> "hideGUI"
                ProgArg = s
            End If
        Next
        
        'check if an argument is in the GUI, and if so, launch the specified file
        If ProgArg <> "" Then
            If ProgArg.Contains(txtCommand1.Text) And txtCommand1.Text <> "" And txtProgram1.Text <> "" Then
                Process.Start(txtProgram1.Text)
            ElseIf  ProgArg.Contains(txtCommand2.Text) And txtCommand2.Text <> "" And txtProgram2.Text <> "" Then
                Process.Start(txtProgram2.Text)
            ElseIf  ProgArg.Contains(txtCommand3.Text) And txtCommand3.Text <> "" And txtProgram3.Text <> "" Then
                Process.Start(txtProgram3.Text)
            ElseIf  ProgArg.Contains(txtCommand4.Text) And txtCommand4.Text <> "" And txtProgram4.Text <> "" Then
                Process.Start(txtProgram4.Text)
            End If
        End If
    End Sub
    
    'Close Program
    Sub BtnEndClick(sender As Object, e As EventArgs)
        End
    End Sub
    
    'Save settings
    Sub BtnSaveClick(sender As Object, e As EventArgs)
        My.Settings.Command1 = txtCommand1.Text
        My.Settings.Program1 = txtProgram1.Text
        My.Settings.Command2 = txtCommand2.Text
        My.Settings.Program2 = txtProgram2.Text
        My.Settings.Command3 = txtCommand3.Text
        My.Settings.Program3 = txtProgram3.Text
        My.Settings.Command4 = txtCommand4.Text
        My.Settings.Program4 = txtProgram4.Text
        My.Settings.Save
        lblSaved.Visible = True
        timerSave.Start
    End Sub
    
    'Hide "Saved succesfully" text
    Sub TimerSaveTick(sender As Object, e As EventArgs)
        timerSave.Stop
        'WindowState = FormWindowState.Minimized
        lblSaved.Visible = False
    End Sub
    
    Sub BtnBrowse1Click(sender As Object, e As EventArgs)
        openFileDialogBrowse.ShowDialog
        If openFileDialogBrowse.FileName <> "" Then
            txtProgram1.Text = openFileDialogBrowse.FileName
        End If
    End Sub
    
    Sub BtnRun1Click(sender As Object, e As EventArgs)
        If File.Exists(txtProgram1.Text) Then
            Process.Start(txtProgram1.Text)
        Else
            MsgBox("The program '" & txtProgram1.Text & "'" & "could not be found!", MsgBoxStyle.Critical)
        End If
    End Sub
    
    Sub BtnBrowse2Click(sender As Object, e As EventArgs)
        openFileDialogBrowse.ShowDialog
        If openFileDialogBrowse.FileName <> "" Then
            txtProgram2.Text = openFileDialogBrowse.FileName
        End If
    End Sub
    
    Sub BtnRun2Click(sender As Object, e As EventArgs)
        If File.Exists(txtProgram2.Text) Then
            Process.Start(txtProgram2.Text)
        Else
            MsgBox("The program '" & txtProgram2.Text & "'" & "could not be found!", MsgBoxStyle.Critical)
        End If
    End Sub
    
    Sub BtnBrowse3Click(sender As Object, e As EventArgs)
        openFileDialogBrowse.ShowDialog
        If openFileDialogBrowse.FileName <> "" Then
            txtProgram3.Text = openFileDialogBrowse.FileName
        End If
    End Sub
    
    Sub BtnRun3Click(sender As Object, e As EventArgs)
        If File.Exists(txtProgram3.Text) Then
            Process.Start(txtProgram3.Text)
        Else
            MsgBox("The program '" & txtProgram3.Text & "'" & "could not be found!", MsgBoxStyle.Critical)
        End If
    End Sub
    
    Sub BtnBrowse4Click(sender As Object, e As EventArgs)
        openFileDialogBrowse.ShowDialog
        If openFileDialogBrowse.FileName <> "" Then
            txtProgram4.Text = openFileDialogBrowse.FileName
        End If
    End Sub
    
    Sub BtnRun4Click(sender As Object, e As EventArgs)
        If File.Exists(txtProgram4.Text) Then
            Process.Start(txtProgram4.Text)
        Else
            MsgBox("The program '" & txtProgram4.Text & "'" & "could not be found!", MsgBoxStyle.Critical)
        End If
    End Sub
End Class
