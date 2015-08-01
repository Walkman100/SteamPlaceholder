﻿Public Class SteamPlaceholder
    
    Dim configFolder As String = Environment.GetEnvironmentVariable("AppData") & "\WalkmanOSS"
    
    Private Sub LoadSteamPlaceHolder() Handles Me.Load
        openFileDialogBrowse.InitialDirectory = Environment.GetEnvironmentVariable("ProgramFiles")
        
        If Not IO.Directory.Exists(configFolder) Then
            IO.Directory.CreateDirectory(configFolder)
        End If
        If IO.File.Exists(configFolder & "\SteamPlaceholder.xml") Then
            ReadConfig(configFolder & "\SteamPlaceholder.xml")
        End If
        
        'get CommandLineArgs and apply/run them
        For Each s As String In My.Application.CommandLineArgs
            If s.ToLower = "hidegui" Then
                Me.WindowState = FormWindowState.Minimized
            Else
                For Each item As ListViewItem In lstCommands.Items
                    If item.SubItems.Item(2).Text = s Then
                        RunProgram(item)
                    End If
                Next
            End If
        Next
        CheckButtons
    End Sub
    
    Private Sub ReadConfig(path As String)
        Dim reader As XmlReader = XmlReader.Create(path)
        reader.Read()
        
        If reader.IsStartElement() AndAlso reader.Name = "SteamPlaceholder" Then
            If reader.Read AndAlso reader.IsStartElement() AndAlso reader.Name = "ProgramList" Then
                While reader.IsStartElement
                    If reader.Read AndAlso reader.IsStartElement() AndAlso reader.Name = "Program" Then
                        Dim tmpListViewItem As New System.Windows.Forms.ListViewItem(New String() {"notepad", "file", "openNotepadAtFile"})
                        
                        Dim attribute As String = reader("path")
                        If attribute IsNot Nothing Then
                            tmpListViewItem.Text = attribute
                        End If
                        
                        attribute = reader("args")
                        If attribute IsNot Nothing Then
                            tmpListViewItem.SubItems.Item(1).Text = attribute
                        End If
                        
                        attribute = reader("entryarg")
                        If attribute IsNot Nothing Then
                            tmpListViewItem.SubItems.Item(2).Text = attribute
                        End If
                        lstCommands.Items.Add(tmpListViewItem)
                    End If
                End While
            End If
        End If
        
        reader.Close
    End Sub
    
    Private Sub WriteConfig(path As String)
        Dim XMLwSettings As New XmlWriterSettings()
        XMLwSettings.Indent = True
        Dim writer As XmlWriter = XmlWriter.Create(path, XMLwSettings)
        
        writer.WriteStartDocument()
        writer.WriteStartElement("SteamPlaceholder")
        writer.WriteStartElement("ProgramList")
        
        For Each item In lstCommands.Items
            writer.WriteStartElement("Program")
            writer.WriteAttributeString("path", item.Text)
            writer.WriteAttributeString("args", item.SubItems.Item(1).Text)
            writer.WriteAttributeString("entryarg", item.SubItems.Item(2).Text)
            writer.WriteEndElement()
        Next

        writer.WriteEndElement()
        writer.WriteEndElement()
        writer.WriteEndDocument()
        
        writer.Close
    End Sub
    
    Private Sub AddItem() Handles btnAdd.Click
        Dim tmpListViewItem As New System.Windows.Forms.ListViewItem(New String() {"notepad", "file", "openNotepadAtFile"})
        lstCommands.FocusedItem = lstCommands.Items.Add(tmpListViewItem)
        CheckButtons
    End Sub
    
    Private Sub RemoveItem() Handles btnRemove.Click
        If IsNothing(lstCommands.FocusedItem) Then
            MsgBox("No item selected")
        Else
            lstCommands.FocusedItem.Remove
        End If
        CheckButtons
    End Sub
    
    Private Sub btnEdit_Click() Handles btnEdit.Click
        Dim inputBoxText As String
        inputBoxText = InputBox("Enter the arguments to start the program with:", "", lstCommands.FocusedItem.SubItems.Item(1).Text)
        If inputBoxText <> "" Then lstCommands.FocusedItem.SubItems.Item(1).Text = inputBoxText
        inputBoxText = InputBox("Enter the argument to use to start SteamPlaceholder and start this entry:", "", lstCommands.FocusedItem.SubItems.Item(2).Text)
        If inputBoxText <> "" Then lstCommands.FocusedItem.SubItems.Item(2).Text = inputBoxText
        WriteConfig(configFolder & "\SteamPlaceholder.xml")
    End Sub
    
    Private Sub Browse() Handles btnBrowse.Click
        If openFileDialogBrowse.ShowDialog() = DialogResult.OK Then
            lstCommands.FocusedItem.Text = openFileDialogBrowse.FileName
            WriteConfig(configFolder & "\SteamPlaceholder.xml")
        End If
    End Sub
    
    Private Sub RunSelectedEntry() Handles btnRun.Click
        RunProgram(lstCommands.FocusedItem)
    End Sub
    
    Private Sub RunProgram(entry As ListViewItem)
        Try
            Process.Start(entry.Text, entry.SubItems.Item(1).Text)
        Catch ex As Exception
            Try
                MsgBox("There was an error running the program """ & entry.Text & """ with """ & entry.SubItems.Item(1).Text & """ args!", MsgBoxStyle.Critical)
            Catch ex2 As Exception
                MsgBox("Error finding the data to run the program! Error was:" & vbNewLine & ex2.Message, MsgBoxStyle.Critical)
            End Try
        End Try
    End Sub
    
    Private Sub EndSPH() Handles btnEnd.Click
        WriteConfig(configFolder & "\SteamPlaceholder.xml")
        Application.Exit()
    End Sub
    
    Private Sub CheckButtons() Handles lstCommands.Click, lstCommands.SelectedIndexChanged
        If IsNothing(lstCommands.FocusedItem) Then
            btnRemove.Enabled = False
            btnEdit.Enabled = False
            btnBrowse.Enabled = False
            btnRun.Enabled = False
        Else
            btnRemove.Enabled = True
            btnEdit.Enabled = True
            btnBrowse.Enabled = True
            btnRun.Enabled = True
        End If
        WriteConfig(configFolder & "\SteamPlaceholder.xml")
    End Sub
End Class
