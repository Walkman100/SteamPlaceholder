Imports System.Math
Imports System.IO
Imports System.Threading

Public Class SteamPlaceholder

    Private Sub LoadSteamPlaceHolder() Handles Me.Load
        ' fill gui: lstCommands.Items = My.Settings.Paths
        For i = 0 To My.Settings.Paths.Count - 1
            lstCommands.Items.Add(My.Settings.Paths.Item(i))
        Next
        lstCommands.SelectedIndex = 0

        Dim IsInteger As Boolean = True
        'get CommandLineArgs and apply/run them
        For Each s As String In My.Application.CommandLineArgs
            If s.ToLower = "hidegui" Then
                WindowState = FormWindowState.Minimized
            Else
                Try
                    s.Cast(Of Integer)()
                Catch ex As Exception
                    IsInteger = False
                End Try
                If IsInteger Then
                    RunProgram()
                End If
            End If
        Next
    End Sub

    Private Sub EndSPH() Handles btnEnd.Click
        Application.Exit()
    End Sub

    Private Sub lstCommands_Changed() Handles lstCommands.Click, lstCommands.SelectedIndexChanged, lstCommands.SelectedValueChanged
        txtArgs.Text = lstCommands.SelectedItem
    End Sub

    Private Sub SaveStrings()
        'My.Settings.Paths = lstCommands.Items
        My.Settings.Paths.Clear()
        For i = 0 To lstCommands.Items.Count - 1
            My.Settings.Paths.Add(lstCommands.Items.Item(i))
        Next
    End Sub

    Private Sub SetItem() Handles btnSet.Click
        lstCommands.Items.Item(lstCommands.SelectedIndex) = txtArgs.Text
        SaveStrings()
    End Sub

    Private Sub Browse() Handles btnBrowse.Click
        If openFileDialogBrowse.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtArgs.Text = openFileDialogBrowse.FileName
            SetItem()
        End If
    End Sub

    Private Sub RunProgram() Handles btnTest.Click
        Try
            Process.Start(lstCommands.SelectedItem)
        Catch ex As Exception
            MsgBox("There was an error running the program '" & lstCommands.SelectedItem & "!", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub AddItem() Handles btnAdd.Click
        If lstCommands.Items.Count = 1 Then
            btnRemove.Enabled = True
        End If
        lstCommands.Items.Insert(lstCommands.SelectedIndex + 1, txtArgs.Text)
        lstCommands.SelectedIndex = lstCommands.SelectedIndex + 1
    End Sub

    Private Sub RemoveItem() Handles btnRemove.Click
        If lstCommands.SelectedIndex = -1 Then
            MsgBox("No item selected")
        Else
            lstCommands.SelectedIndex = lstCommands.SelectedIndex - 1
            lstCommands.Items.RemoveAt(lstCommands.SelectedIndex + 1)
        End If
        If lstCommands.Items.Count = 1 Then
            btnRemove.Enabled = False
        End If
    End Sub
End Class
