Imports System.IO
Public Class SteamPlaceholder
    
    Dim configFilePath As String = Environment.GetEnvironmentVariable("AppData") & "\WalkmanOSS\SteamPlaceholder.xml"
    
    Private Sub LoadSteamPlaceHolder() Handles Me.Load
        openFileDialogBrowse.InitialDirectory = Environment.GetEnvironmentVariable("ProgramFiles")
        
        If Not Directory.Exists(Environment.GetEnvironmentVariable("AppData") & "\WalkmanOSS") Then
            Directory.CreateDirectory(Environment.GetEnvironmentVariable("AppData") & "\WalkmanOSS")
        End If
        
        If File.Exists(Application.StartupPath & "\SteamPlaceholder.xml") Then
            configFilePath = Application.StartupPath & "\SteamPlaceholder.xml"
            ReadConfig(configFilePath)
        ElseIf File.Exists("SteamPlaceholder.xml") Then
            configFilePath = (New IO.FileInfo("SteamPlaceholder.xml")).DirectoryName & "\SteamPlaceholder.xml"
            ReadConfig(configFilePath)
        ElseIf File.Exists(configFilePath) Then
            ReadConfig(configFilePath)
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
    
    Private Sub AddItem() Handles btnAdd.Click
        Dim tmpListViewItem As New ListViewItem(New String() {"notepad", "file", "openNotepadAtFile"})
        lstCommands.FocusedItem = lstCommands.Items.Add(tmpListViewItem)
        CheckButtons
    End Sub
    
    Private Sub RemoveItem() Handles btnRemove.Click
        If lstCommands.SelectedItems.Count > 1 Then
            For Each item As ListViewItem In lstCommands.SelectedItems
                item.Remove
            Next
        Else
            lstCommands.FocusedItem.Remove
        End If
        CheckButtons
    End Sub
    
    Private Sub btnEdit_Click() Handles btnEdit.Click
        Dim inputBoxText As String
        If lstCommands.SelectedItems.Count > 1 Then
            For Each item As ListViewItem In lstCommands.SelectedItems
                inputBoxText = InputBox("Enter the arguments to start """ & item.Text & """ with:", "", item.SubItems.Item(1).Text)
                If inputBoxText <> "" Then item.SubItems.Item(1).Text = inputBoxText
                inputBoxText = InputBox("Enter the argument to use to start SteamPlaceholder and start """ & item.Text & """:", "", item.SubItems.Item(2).Text)
                If inputBoxText <> "" Then item.SubItems.Item(2).Text = inputBoxText
            Next
        Else
            inputBoxText = InputBox("Enter the arguments to start """ & lstCommands.FocusedItem.Text & """ with:", "", lstCommands.FocusedItem.SubItems.Item(1).Text)
            If inputBoxText <> "" Then lstCommands.FocusedItem.SubItems.Item(1).Text = inputBoxText
            inputBoxText = InputBox("Enter the argument to use to start SteamPlaceholder and start """ & lstCommands.FocusedItem.Text & """:", "", lstCommands.FocusedItem.SubItems.Item(2).Text)
            If inputBoxText <> "" Then lstCommands.FocusedItem.SubItems.Item(2).Text = inputBoxText
        End If
        WriteConfig(configFilePath)
    End Sub
    
    Private Sub Browse() Handles btnBrowse.Click
        If lstCommands.SelectedItems.Count > 1 Then
            For Each item As ListViewItem In lstCommands.SelectedItems
                openFileDialogBrowse.Title = "Select file to replace """ & item.Text & """ with:"
                If item.Text.Contains("\") Then
                    openFileDialogBrowse.InitialDirectory = item.Text.Remove(item.Text.LastIndexOf("\"))
                Else
                    openFileDialogBrowse.InitialDirectory = Environment.GetEnvironmentVariable("ProgramFiles")
                End If
                If openFileDialogBrowse.ShowDialog() = DialogResult.OK Then
                    item.Text = openFileDialogBrowse.FileName
                    WriteConfig(configFilePath)
                End If
            Next
        Else
            openFileDialogBrowse.Title = "Select file to replace """ & lstCommands.FocusedItem.Text & """ with:"
            If lstCommands.FocusedItem.Text.Contains("\") Then 
                openFileDialogBrowse.InitialDirectory = lstCommands.FocusedItem.Text.Remove(lstCommands.FocusedItem.Text.LastIndexOf("\"))
            Else
                openFileDialogBrowse.InitialDirectory = Environment.GetEnvironmentVariable("ProgramFiles")
            End If
            If openFileDialogBrowse.ShowDialog() = DialogResult.OK Then
                lstCommands.FocusedItem.Text = openFileDialogBrowse.FileName
                WriteConfig(configFilePath)
            End If
        End If
    End Sub
    
    Private Sub RunSelectedEntry() Handles btnRun.Click
        If lstCommands.SelectedItems.Count > 1 Then
            For Each item As ListViewItem In lstCommands.SelectedItems
                RunProgram(item)
            Next
        Else
            RunProgram(lstCommands.FocusedItem)
        End If
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
        WriteConfig(configFilePath)
        Application.Exit()
    End Sub
    
    Private Sub CheckButtons() Handles lstCommands.Click, lstCommands.SelectedIndexChanged, lstCommands.AfterLabelEdit, lstCommands.ColumnReordered
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
        WriteConfig(configFilePath)
    End Sub
    
    Sub lstCommands_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles LstCommands.ColumnClick
        lstCommands.Sorting = IIf(lstCommands.Sorting = SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending)
        lstCommands.Sort
        'lstCommands.Sort(e.Column)
    End Sub
    
    Sub ResizeByHeader(sender As Object, e As EventArgs) Handles contextCommandsResizePathHeader.Click, _
            contextCommandsResizeArgsHeader.Click, contextCommandsResizeArgHeader.Click
        lstCommands.AutoResizeColumn(sender.Tag, ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub
    
    Sub ResizeByContent(sender As Object, e As EventArgs) Handles contextCommandsResizePathContent.Click, _
            contextCommandsResizeArgsContent.Click, contextCommandsResizeArgContent.Click
        lstCommands.AutoResizeColumn(sender.Tag, ColumnHeaderAutoResizeStyle.ColumnContent)
    End Sub
    
    Sub ResizeAllByHeader() Handles contextCommandsResizeAllHeader.Click
        lstCommands.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub
    
    Sub ResizeAllByContent() Handles contextCommandsResizeAllContent.Click
        lstCommands.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
    End Sub
    
    Sub lstCommands_DragEnter(sender As Object, e As DragEventArgs) Handles lstCommands.DragEnter
        If e.Data.GetDataPresent(DataFormats.Text) Or e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    
    Sub lstCommands_DragDrop(sender As Object, e As DragEventArgs) Handles lstCommands.DragDrop
        If e.Data.GetDataPresent(DataFormats.Text) Then
            Dim tmpListViewItem As New ListViewItem(New String() {e.Data.GetData(DataFormats.Text).ToString, " ", "draggedFile"})
            lstCommands.FocusedItem = lstCommands.Items.Add(tmpListViewItem)
        ElseIf e.Data.GetDataPresent(DataFormats.FileDrop)
            For i = 0 To Integer.MaxValue
                If (e.Data.GetData(DataFormats.FileDrop)(i) <> Nothing) Then
                    Dim tmpListViewItem As New ListViewItem(New String() {e.Data.GetData(DataFormats.FileDrop)(i), " ", "draggedFile"})
                    lstCommands.FocusedItem = lstCommands.Items.Add(tmpListViewItem)
                Else
                    Exit For
                End If
            Next
        End If
    End Sub
    
    Private Sub ReadConfig(path As String)
        Dim reader As XmlReader = XmlReader.Create(path)
        Try
            reader.Read()
        Catch ex As XmlException
            reader.Close
            Exit Sub
        End Try
        
        If reader.IsStartElement() AndAlso reader.Name = "SteamPlaceholder" Then
            If reader.Read AndAlso reader.IsStartElement() AndAlso reader.Name = "ProgramList" Then
                While reader.IsStartElement
                    If reader.Read AndAlso reader.IsStartElement() AndAlso reader.Name = "Program" Then
                        Dim tmpListViewItem As New ListViewItem(New String() {"notepad", "file", "openNotepadAtFile"})
                        
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
            If reader.Read AndAlso reader.IsStartElement() AndAlso reader.Name = "Settings" Then
                If reader.Read AndAlso reader.IsStartElement() AndAlso reader.Name = "ColumnSettings" Then
                    Dim attribute As String
                    While reader.IsStartElement
                        If reader.Read AndAlso reader.IsStartElement() Then
                            If reader.Name = "PathColumn" Then
                                attribute = reader("index")
                                If attribute IsNot Nothing Then
                                    colheadPath.DisplayIndex = attribute
                                End If
                                
                                attribute = reader("width")
                                If attribute IsNot Nothing Then
                                    colheadPath.Width = attribute
                                End If
                            ElseIf reader.Name = "ArgColumn"
                                attribute = reader("index")
                                If attribute IsNot Nothing Then
                                    colheadProgramArgs.DisplayIndex = attribute
                                End If
                                
                                attribute = reader("width")
                                If attribute IsNot Nothing Then
                                    colheadProgramArgs.Width = attribute
                                End If
                            ElseIf reader.Name = "EntryArgColumn"
                                attribute = reader("index")
                                If attribute IsNot Nothing Then
                                    colheadExtArgs.DisplayIndex = attribute
                                End If
                                
                                attribute = reader("width")
                                If attribute IsNot Nothing Then
                                    colheadExtArgs.Width = attribute
                                End If
                            End If
                        End If
                    End While
                End If
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
        
        writer.WriteStartElement("Settings")
            writer.WriteStartElement("ColumnSettings")
                writer.WriteStartElement("PathColumn")
                    writer.WriteAttributeString("index", colheadPath.DisplayIndex)
                    writer.WriteAttributeString("width", colheadPath.Width)
                writer.WriteEndElement()
                writer.WriteStartElement("ArgColumn")
                    writer.WriteAttributeString("index", colheadProgramArgs.DisplayIndex)
                    writer.WriteAttributeString("width", colheadProgramArgs.Width)
                writer.WriteEndElement()
                writer.WriteStartElement("EntryArgColumn")
                    writer.WriteAttributeString("index", colheadExtArgs.DisplayIndex)
                    writer.WriteAttributeString("width", colheadExtArgs.Width)
                writer.WriteEndElement()
            writer.WriteEndElement()
        writer.WriteEndElement()
        
        writer.WriteEndElement()
        writer.WriteEndDocument()
        
        writer.Close
    End Sub
End Class
