﻿Imports System.Math
Imports System.IO
Imports System.Threading

Public Class SteamPlaceholder

    Private Sub LoadSteamPlaceHolder() Handles Me.Load
        ' fill gui: lstCommands.Items = My.Settings.Paths
        For i = 0 To My.Settings.Paths.Count
            lstCommands.Items.Add(My.Settings.Paths.Item(i))
        Next
        lstCommands.SelectedIndex = 0

        'get CommandLineArgs and apply/run them
        For Each s As String In My.Application.CommandLineArgs
            If s.ToLower = "hidegui" Then
                WindowState = FormWindowState.Minimized
            Else
                If lstCommands.Items.Contains(s) Then
                    If File.Exists(lstCommands.Items.Item(s)) Then
                        ' Not sure if this is going to work.
                        Process.Start(lstCommands.Items.Item(s))
                    Else
                        MsgBox("The program '" & lstCommands.Items.Item(s) & "' " & "could not be found!", MsgBoxStyle.Critical)
                    End If
                End If
            End If
        Next
    End Sub
    
    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        Application.Exit()
    End Sub
    
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        openFileDialogBrowse.ShowDialog()
        If openFileDialogBrowse.FileName <> "" Then
            txtArgs.Text = openFileDialogBrowse.FileName
            txtArgs_KeyPress(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
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
            If 0 <> 0 Then
                ' Inserts at the end of list
                lstCommands.Items.Add(txtArgs.Text)
                lstCommands.SelectedIndex = lstCommands.Items.Count - 1
            Else
                ' Inserts just after selected item
                lstCommands.Items.Insert(lstCommands.SelectedIndex + 1, txtArgs.Text)
                lstCommands.SelectedIndex = lstCommands.SelectedIndex + 1
            End If
            btnRemove.Enabled = True
            btnTest.Enabled = True
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lstCommands.SelectedIndex = -1 Then
            MsgBox("No item selected")
        Else
            lstCommands.SelectedIndex = lstCommands.SelectedIndex - 1
            lstCommands.Items.RemoveAt(lstCommands.SelectedIndex + 1)
        End If
        If lstCommands.Items.Count = 0 Then
            btnRemove.Enabled = False
            btnTest.Enabled = False
        End If
    End Sub

    Private Sub btnRebuild_Click(sender As Object, e As EventArgs) Handles btnRebuild.Click
        lstCommands.Items.Clear()
        lstCommands.Items.Add("C:\Windows\notepad.exe")
        lstCommands.SelectedIndex = 0
        btnRemove.Enabled = True
        btnTest.Enabled = True
    End Sub

    Private Sub lstCommands_Changed(sender As Object, e As EventArgs) Handles lstCommands.Click, lstCommands.SelectedIndexChanged, lstCommands.SelectedValueChanged
        If lstCommands.SelectedIndex = -1 Then
            txtArgs.Text = ""
        Else
            txtArgs.Text = lstCommands.SelectedItem
        End If
        'My.Settings.Paths = lstCommands.Items
        My.Settings.Paths.Clear()
        For i = 0 To lstCommands.Items.Count - 1
            My.Settings.Paths.Add(lstCommands.Items.Item(i))
        Next
    End Sub

    Private Sub txtArgs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtArgs.KeyPress
        If Not lstCommands.SelectedIndex = -1 Then
            lstCommands.Items.Item(lstCommands.SelectedIndex) = txtArgs.Text
        End If
    End Sub
End Class
