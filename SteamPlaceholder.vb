Imports System.Math
Imports System.IO
Imports System.Threading

Public Class SteamPlaceholder
    
    Private Sub LoadSteamPlaceHolder() Handles Me.Load
        ' fill gui: lstCommands.Items = My.Settings.Paths
        'For i = 0 To My.Settings.Paths.Count - 1
            'lstCommands.Items.Add(My.Settings.Paths.Item(i))
        'Next
        
        'get CommandLineArgs and apply/run them
        For Each s As String In My.Application.CommandLineArgs
            If s.ToLower = "hidegui" Then
                WindowState = FormWindowState.Minimized
            Else
                Try
                    'lstCommands.SelectedIndex = s
                    RunProgram()
                Catch ex As Exception
                    MsgBox("""" & s.ToString & """ is not a valid integer or doesn't exist in the list!" & vbNewLine & vbNewLine & _
                           "The error was:" & vbNewLine & ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
        Next
    End Sub
    
    Private Sub EndSPH() Handles btnEnd.Click
        Application.Exit()
    End Sub
    
    Private Sub CheckButtons() Handles lstCommands.Click, lstCommands.SelectedIndexChanged
        
    End Sub
    
    Private Sub Browse() Handles btnBrowse.Click
        If openFileDialogBrowse.ShowDialog() = DialogResult.OK Then
            lstCommands.FocusedItem.Text = openFileDialogBrowse.FileName
        End If
    End Sub
    
    Private Sub RunProgram() Handles btnTest.Click
        Try
            Process.Start(lstCommands.FocusedItem.Text)
        Catch ex As Exception
            MsgBox("There was an error running the program '" & lstCommands.FocusedItem.Text & "!", MsgBoxStyle.Critical)
        End Try
    End Sub
    
    Private Sub AddItem() Handles btnAdd.Click
        lstCommands.Items.Add("")
    End Sub
    
    Private Sub RemoveItem() Handles btnRemove.Click
        If IsNothing(lstCommands.FocusedItem) Then
            MsgBox("No item selected")
        Else
            lstCommands.FocusedItem.Remove
        End If
    End Sub
End Class
