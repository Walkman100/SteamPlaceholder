Imports System.Math
Imports System.IO
Imports System.Threading

Public Class SteamPlaceholder
    'Dim Total As Long, a As Long, b As Long, c As Long, i As Long, x As Long
    'Dim TempA As Long, TempB As Long, TempC As Long
    'Dim TextVar As String, TextVar2 As String

    Private Sub EulerSolutions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ProblemChooser.Value = My.Settings.CurrentProblem
        'lblProblemNumber.Text = My.Settings.CurrentProblem
        'ToolStripProblemNumber.Text = My.Settings.CurrentProblem
    End Sub
    
    Dim ProgArg As String = ""
    
    Private Sub LoadYTVL() Handles Me.Load
        'fill GUI elements
        txtCommand1.Text = My.Settings.Command1
        txtProgram1.Text = My.Settings.Program1
        
        'get CommandLineArgs, copy them to a variable or apply them
        For Each s As String In My.Application.CommandLineArgs
            If s = "hideGUI" Or s = "hidegui" Then
                WindowState = FormWindowState.Minimized
            ElseIf s <> "hideGUI"
                ProgArg = s
            End If
        Next
        If ProgArg <> "" Then
            If ProgArg.Contains(txtCommand1.Text) And txtCommand1.Text <> "" And txtProgram1.Text <> "" Then
                Process.Start(txtProgram1.Text)
            'ElseIf  ProgArg.Contains(txtCommand2.Text) And txtCommand2.Text <> "" And txtProgram2.Text <> "" Then
            '    Process.Start(txtProgram2.Text)
            'ElseIf  ProgArg.Contains(txtCommand3.Text) And txtCommand3.Text <> "" And txtProgram3.Text <> "" Then
            '    Process.Start(txtProgram3.Text)
            'ElseIf  ProgArg.Contains(txtCommand4.Text) And txtCommand4.Text <> "" And txtProgram4.Text <> "" Then
            '    Process.Start(txtProgram4.Text)
            End If
        End If
    End Sub
    
    Sub BtnBrowse1Click(sender As Object, e As EventArgs)
        openFileDialogBrowse.ShowDialog
        txtProgram1.Text = openFileDialogBrowse.FileName
    End Sub
    
    Sub BtnRun1Click(sender As Object, e As EventArgs)
        Process.Start(txtProgram1.Text)
    End Sub
    
    Sub BtnEndClick(sender As Object, e As EventArgs)
        End
    End Sub
    
    Sub BtnSaveClick(sender As Object, e As EventArgs)
        My.Settings.Command1 = txtCommand1.Text
        My.Settings.Program1 = txtProgram1.Text
        My.Settings.Save
        lblSaved.Visible = True
        timerSave.Start
    End Sub
    
    Sub TimerSaveTick(sender As Object, e As EventArgs)
        timerSave.Stop
        WindowState = FormWindowState.Minimized
        lblSaved.Visible = False
    End Sub
End Class
