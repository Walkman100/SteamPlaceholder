Imports System.Math
Imports System.IO
Imports System.Threading

Public Class SteamPlaceholder

    'Dim ProgArg As String = ""
    
    Private Sub LoadSteamPlaceHolder() Handles Me.Load
        ''fill GUI elements
        'txtCommand1.Text = My.Settings.Command1
        'txtProgram1.Text = My.Settings.Program1
        'txtCommand2.Text = My.Settings.Command2
        'txtProgram2.Text = My.Settings.Program2
        'txtCommand3.Text = My.Settings.Command3
        'txtProgram3.Text = My.Settings.Program3
        'txtCommand4.Text = My.Settings.Command4
        'txtProgram4.Text = My.Settings.Program4

        ''get CommandLineArgs, copy them to a variable or apply them
        'For Each s As String In My.Application.CommandLineArgs
        '    If s = "hideGUI" Or s = "hidegui" Then
        '        WindowState = FormWindowState.Minimized
        '    ElseIf s <> "hideGUI" Then
        '        ProgArg = s
        '    End If
        'Next

        ''check if an argument is in the GUI, and if so, launch the specified file
        'If ProgArg <> "" Then
        '    If ProgArg.Contains(txtCommand1.Text) And txtCommand1.Text <> "" And txtProgram1.Text <> "" Then
        '        Process.Start(txtProgram1.Text)
        '    ElseIf  ProgArg.Contains(txtCommand2.Text) And txtCommand2.Text <> "" And txtProgram2.Text <> "" Then
        '        Process.Start(txtProgram2.Text)
        '    ElseIf  ProgArg.Contains(txtCommand3.Text) And txtCommand3.Text <> "" And txtProgram3.Text <> "" Then
        '        Process.Start(txtProgram3.Text)
        '    ElseIf  ProgArg.Contains(txtCommand4.Text) And txtCommand4.Text <> "" And txtProgram4.Text <> "" Then
        '        Process.Start(txtProgram4.Text)
        '    End If
        'End If
    End Sub
    
    'Close Program
    Sub BtnEndClick(sender As Object, e As EventArgs) Handles btnEnd.Click
        Application.Exit()
    End Sub
    
    'Save settings
    Sub BtnSaveClick(sender As Object, e As EventArgs)
        'My.Settings.Command1 = txtCommand1.Text
        'My.Settings.Program1 = txtProgram1.Text
        'My.Settings.Command2 = txtCommand2.Text
        'My.Settings.Program2 = txtProgram2.Text
        'My.Settings.Command3 = txtCommand3.Text
        'My.Settings.Program3 = txtProgram3.Text
        'My.Settings.Command4 = txtCommand4.Text
        'My.Settings.Program4 = txtProgram4.Text
        'My.Settings.Save()
        'lblSaved.Visible = True
        'timerSave.Start()
    End Sub
    
    'Hide "Saved succesfully" text
    Sub TimerSaveTick(sender As Object, e As EventArgs) Handles timerSave.Tick
        timerSave.Stop()
    End Sub
    
    Sub BtnBrowseClick(sender As Object, e As EventArgs) Handles btnBrowse.Click
        openFileDialogBrowse.ShowDialog()
        If openFileDialogBrowse.FileName <> "" Then
            txtArgs.Text = openFileDialogBrowse.FileName
        End If
    End Sub

    Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        If lstCommands.SelectedIndex = -1 Then
            MsgBox("No item selected")
        Else
            If File.Exists(lstCommands.SelectedItem) Then
                Process.Start(lstCommands.SelectedItem)
            Else
                MsgBox("The program '" & lstCommands.SelectedItem & "' " & "could not be found!", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtArgs.Text = "" Then
            MsgBox("Nothing to add!")
        Else
            lstCommands.Items.Add(txtArgs.Text)
            txtArgs.Text = ""
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lstCommands.SelectedIndex = -1 Then
            MsgBox("No item selected")
        Else
            lstCommands.Items.RemoveAt(lstCommands.SelectedIndex)
        End If
    End Sub

    Private Sub btnRebuild_Click(sender As Object, e As EventArgs) Handles btnRebuild.Click
        lstCommands.Items.Clear()
        lstCommands.Items.Add("start")
    End Sub

    Private Sub lstCommands_Click(sender As Object, e As EventArgs) Handles lstCommands.Click
        If lstCommands.SelectedIndex = -1 Then
            txtArgs.Text = ""
        Else
            txtArgs.Text = lstCommands.SelectedItem
        End If
    End Sub
End Class
