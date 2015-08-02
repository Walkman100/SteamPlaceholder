<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SteamPlaceholder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.openFileDialogBrowse = New System.Windows.Forms.OpenFileDialog()
        Me.lstCommands = New System.Windows.Forms.ListView()
        Me.colheadPath = New System.Windows.Forms.ColumnHeader()
        Me.colheadProgramArgs = New System.Windows.Forms.ColumnHeader()
        Me.colheadExtArgs = New System.Windows.Forms.ColumnHeader()
        Me.contextCommands = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.contextCommandsResizePathHeader = New System.Windows.Forms.ToolStripMenuItem()
        Me.contextCommandsResizePathContent = New System.Windows.Forms.ToolStripMenuItem()
        Me.contextCommandsSeperator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.contextCommandsResizeArgsHeader = New System.Windows.Forms.ToolStripMenuItem()
        Me.contextCommandsResizeArgsContent = New System.Windows.Forms.ToolStripMenuItem()
        Me.contextCommandsSeperator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.contextCommandsResizeArgHeader = New System.Windows.Forms.ToolStripMenuItem()
        Me.contextCommandsResizeArgContent = New System.Windows.Forms.ToolStripMenuItem()
        Me.contextCommandsSeperator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.contextCommandsResizeAllHeader = New System.Windows.Forms.ToolStripMenuItem()
        Me.contextCommandsResizeAllContent = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.contextCommands.SuspendLayout
        Me.SuspendLayout
        '
        'openFileDialogBrowse
        '
        Me.openFileDialogBrowse.DefaultExt = "exe"
        Me.openFileDialogBrowse.Filter = "Applications|*.exe; *.msi; *.bat; *.com|All files|*.*"
        Me.openFileDialogBrowse.InitialDirectory = "%ProgramFiles%"
        Me.openFileDialogBrowse.ReadOnlyChecked = true
        '
        'lstCommands
        '
        Me.lstCommands.AllowColumnReorder = true
        Me.lstCommands.AllowDrop = true
        Me.lstCommands.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
                        Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lstCommands.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colheadPath, Me.colheadProgramArgs, Me.colheadExtArgs})
        Me.lstCommands.ContextMenuStrip = Me.contextCommands
        Me.lstCommands.FullRowSelect = true
        Me.lstCommands.GridLines = true
        Me.lstCommands.HideSelection = false
        Me.lstCommands.LabelEdit = true
        Me.lstCommands.Location = New System.Drawing.Point(12, 12)
        Me.lstCommands.Name = "lstCommands"
        Me.lstCommands.Size = New System.Drawing.Size(514, 168)
        Me.lstCommands.TabIndex = 21
        Me.lstCommands.UseCompatibleStateImageBehavior = false
        Me.lstCommands.View = System.Windows.Forms.View.Details
        '
        'colheadPath
        '
        Me.colheadPath.Text = "Program/file path"
        Me.colheadPath.Width = 239
        '
        'colheadProgramArgs
        '
        Me.colheadProgramArgs.Text = "Program Arguments"
        Me.colheadProgramArgs.Width = 104
        '
        'colheadExtArgs
        '
        Me.colheadExtArgs.Text = "Argument to use to start entry"
        Me.colheadExtArgs.Width = 150
        '
        'contextCommands
        '
        Me.contextCommands.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.contextCommandsResizePathHeader, Me.contextCommandsResizePathContent, Me.contextCommandsSeperator1, Me.contextCommandsResizeArgsHeader, Me.contextCommandsResizeArgsContent, Me.contextCommandsSeperator2, Me.contextCommandsResizeArgHeader, Me.contextCommandsResizeArgContent, Me.contextCommandsSeperator3, Me.contextCommandsResizeAllHeader, Me.contextCommandsResizeAllContent})
        Me.contextCommands.Name = "contextMenuStripCommands"
        Me.contextCommands.Size = New System.Drawing.Size(254, 198)
        '
        'contextCommandsResizePathHeader
        '
        Me.contextCommandsResizePathHeader.AutoToolTip = true
        Me.contextCommandsResizePathHeader.Name = "contextCommandsResizePathHeader"
        Me.contextCommandsResizePathHeader.Size = New System.Drawing.Size(253, 22)
        Me.contextCommandsResizePathHeader.Tag = "0"
        Me.contextCommandsResizePathHeader.Text = "Resize Path column by Header"
        '
        'contextCommandsResizePathContent
        '
        Me.contextCommandsResizePathContent.AutoToolTip = true
        Me.contextCommandsResizePathContent.Name = "contextCommandsResizePathContent"
        Me.contextCommandsResizePathContent.Size = New System.Drawing.Size(253, 22)
        Me.contextCommandsResizePathContent.Tag = "0"
        Me.contextCommandsResizePathContent.Text = "Resize Path column by Content"
        '
        'contextCommandsSeperator1
        '
        Me.contextCommandsSeperator1.Name = "contextCommandsSeperator1"
        Me.contextCommandsSeperator1.Size = New System.Drawing.Size(250, 6)
        '
        'contextCommandsResizeArgsHeader
        '
        Me.contextCommandsResizeArgsHeader.AutoToolTip = true
        Me.contextCommandsResizeArgsHeader.Name = "contextCommandsResizeArgsHeader"
        Me.contextCommandsResizeArgsHeader.Size = New System.Drawing.Size(253, 22)
        Me.contextCommandsResizeArgsHeader.Tag = "1"
        Me.contextCommandsResizeArgsHeader.Text = "Resize Args column by Header"
        '
        'contextCommandsResizeArgsContent
        '
        Me.contextCommandsResizeArgsContent.AutoToolTip = true
        Me.contextCommandsResizeArgsContent.Name = "contextCommandsResizeArgsContent"
        Me.contextCommandsResizeArgsContent.Size = New System.Drawing.Size(253, 22)
        Me.contextCommandsResizeArgsContent.Tag = "1"
        Me.contextCommandsResizeArgsContent.Text = "Resize Args column by Content"
        '
        'contextCommandsSeperator2
        '
        Me.contextCommandsSeperator2.Name = "contextCommandsSeperator2"
        Me.contextCommandsSeperator2.Size = New System.Drawing.Size(250, 6)
        '
        'contextCommandsResizeArgHeader
        '
        Me.contextCommandsResizeArgHeader.AutoToolTip = true
        Me.contextCommandsResizeArgHeader.Name = "contextCommandsResizeArgHeader"
        Me.contextCommandsResizeArgHeader.Size = New System.Drawing.Size(253, 22)
        Me.contextCommandsResizeArgHeader.Tag = "2"
        Me.contextCommandsResizeArgHeader.Text = "Resize Arg column by Header"
        '
        'contextCommandsResizeArgContent
        '
        Me.contextCommandsResizeArgContent.AutoToolTip = true
        Me.contextCommandsResizeArgContent.Name = "contextCommandsResizeArgContent"
        Me.contextCommandsResizeArgContent.Size = New System.Drawing.Size(253, 22)
        Me.contextCommandsResizeArgContent.Tag = "2"
        Me.contextCommandsResizeArgContent.Text = "Resize Arg column by Content"
        '
        'contextCommandsSeperator3
        '
        Me.contextCommandsSeperator3.Name = "contextCommandsSeperator3"
        Me.contextCommandsSeperator3.Size = New System.Drawing.Size(250, 6)
        '
        'contextCommandsResizeAllHeader
        '
        Me.contextCommandsResizeAllHeader.AutoToolTip = true
        Me.contextCommandsResizeAllHeader.Name = "contextCommandsResizeAllHeader"
        Me.contextCommandsResizeAllHeader.Size = New System.Drawing.Size(253, 22)
        Me.contextCommandsResizeAllHeader.Text = "Resize all by Column Header"
        '
        'contextCommandsResizeAllContent
        '
        Me.contextCommandsResizeAllContent.AutoToolTip = true
        Me.contextCommandsResizeAllContent.Name = "contextCommandsResizeAllContent"
        Me.contextCommandsResizeAllContent.Size = New System.Drawing.Size(253, 22)
        Me.contextCommandsResizeAllContent.Text = "Resize all by Column Content"
        '
        'btnEnd
        '
        Me.btnEnd.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEnd.Location = New System.Drawing.Point(532, 157)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(61, 23)
        Me.btnEnd.TabIndex = 23
        Me.btnEnd.Text = "Exit"
        Me.btnEnd.UseVisualStyleBackColor = true
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAdd.Location = New System.Drawing.Point(532, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(61, 23)
        Me.btnAdd.TabIndex = 24
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = true
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnBrowse.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBrowse.Location = New System.Drawing.Point(532, 99)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(61, 23)
        Me.btnBrowse.TabIndex = 26
        Me.btnBrowse.Text = "Browse..."
        Me.btnBrowse.UseVisualStyleBackColor = true
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnRemove.Location = New System.Drawing.Point(532, 41)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(61, 23)
        Me.btnRemove.TabIndex = 27
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = true
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnEdit.Location = New System.Drawing.Point(532, 70)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(61, 23)
        Me.btnEdit.TabIndex = 33
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = true
        '
        'btnRun
        '
        Me.btnRun.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnRun.Location = New System.Drawing.Point(532, 128)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(61, 23)
        Me.btnRun.TabIndex = 29
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = true
        '
        'SteamPlaceholder
        '
        Me.AcceptButton = Me.btnRun
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = true
        Me.CancelButton = Me.btnEnd
        Me.ClientSize = New System.Drawing.Size(605, 192)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.lstCommands)
        Me.HelpButton = true
        Me.Icon = Global.SteamPlaceholder.My.Resources.Resources.steam
        Me.Name = "SteamPlaceholder"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Steam Placeholder"
        Me.contextCommands.ResumeLayout(false)
        Me.ResumeLayout(false)
    End Sub
    Private WithEvents contextCommandsResizePathHeader As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents contextCommandsResizePathContent As System.Windows.Forms.ToolStripMenuItem
    Private contextCommandsSeperator3 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents contextCommandsResizeArgContent As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents contextCommandsResizeArgHeader As System.Windows.Forms.ToolStripMenuItem
    Private contextCommandsSeperator2 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents contextCommandsResizeArgsContent As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents contextCommandsResizeArgsHeader As System.Windows.Forms.ToolStripMenuItem
    Private contextCommandsSeperator1 As System.Windows.Forms.ToolStripSeparator
    Private contextCommands As System.Windows.Forms.ContextMenuStrip
    Private WithEvents contextCommandsResizeAllHeader As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents contextCommandsResizeAllContent As System.Windows.Forms.ToolStripMenuItem
    Private colheadExtArgs As System.Windows.Forms.ColumnHeader
    Private colheadProgramArgs As System.Windows.Forms.ColumnHeader
    Private colheadPath As System.Windows.Forms.ColumnHeader
    Private openFileDialogBrowse As System.Windows.Forms.OpenFileDialog
    Private WithEvents lstCommands As System.Windows.Forms.ListView
    Private WithEvents btnEnd As System.Windows.Forms.Button
    Private WithEvents btnAdd As System.Windows.Forms.Button
    Private WithEvents btnBrowse As System.Windows.Forms.Button
    Private WithEvents btnRemove As System.Windows.Forms.Button
    Private WithEvents btnEdit As System.Windows.Forms.Button
    Private WithEvents btnRun As System.Windows.Forms.Button

End Class
