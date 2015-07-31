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
        Me.openFileDialogBrowse = New System.Windows.Forms.OpenFileDialog()
        Me.lstCommands = New System.Windows.Forms.ListView()
        Me.colheadPath = New System.Windows.Forms.ColumnHeader()
        Me.colheadProgramArgs = New System.Windows.Forms.ColumnHeader()
        Me.colheadExtArgs = New System.Windows.Forms.ColumnHeader()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'openFileDialogBrowse
        '
        Me.openFileDialogBrowse.AutoUpgradeEnabled = false
        Me.openFileDialogBrowse.DefaultExt = "exe"
        Me.openFileDialogBrowse.InitialDirectory = "%ProgramFiles%"
        Me.openFileDialogBrowse.ReadOnlyChecked = true
        Me.openFileDialogBrowse.ShowHelp = true
        '
        'lstCommands
        '
        Me.lstCommands.AllowColumnReorder = true
        Me.lstCommands.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
                        Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lstCommands.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colheadPath, Me.colheadProgramArgs, Me.colheadExtArgs})
        Me.lstCommands.FullRowSelect = true
        Me.lstCommands.GridLines = true
        Me.lstCommands.HideSelection = false
        Me.lstCommands.LabelEdit = true
        Me.lstCommands.Location = New System.Drawing.Point(12, 12)
        Me.lstCommands.MultiSelect = false
        Me.lstCommands.Name = "lstCommands"
        Me.lstCommands.Size = New System.Drawing.Size(514, 168)
        Me.lstCommands.TabIndex = 21
        Me.lstCommands.UseCompatibleStateImageBehavior = false
        Me.lstCommands.View = System.Windows.Forms.View.Details
        '
        'colheadPath
        '
        Me.colheadPath.Text = "Program/file path"
        Me.colheadPath.Width = 254
        '
        'colheadProgramArgs
        '
        Me.colheadProgramArgs.Text = "Program Arguments"
        Me.colheadProgramArgs.Width = 105
        '
        'colheadExtArgs
        '
        Me.colheadExtArgs.Text = "Argument to use to start entry"
        Me.colheadExtArgs.Width = 150
        '
        'btnEnd
        '
        Me.btnEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
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
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
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
        Me.btnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
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
        Me.btnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnRemove.Location = New System.Drawing.Point(532, 41)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(61, 23)
        Me.btnRemove.TabIndex = 27
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = true
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnEdit.Location = New System.Drawing.Point(532, 70)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(61, 23)
        Me.btnEdit.TabIndex = 33
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = true
        '
        'btnTest
        '
        Me.btnTest.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnTest.Location = New System.Drawing.Point(532, 128)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(61, 23)
        Me.btnTest.TabIndex = 29
        Me.btnTest.Text = "Run"
        Me.btnTest.UseVisualStyleBackColor = true
        '
        'SteamPlaceholder
        '
        Me.AcceptButton = Me.btnTest
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = true
        Me.CancelButton = Me.btnEnd
        Me.ClientSize = New System.Drawing.Size(605, 192)
        Me.Controls.Add(Me.btnTest)
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
        Me.ResumeLayout(false)
    End Sub
    Private colheadExtArgs As System.Windows.Forms.ColumnHeader
    Private colheadProgramArgs As System.Windows.Forms.ColumnHeader
    Private colheadPath As System.Windows.Forms.ColumnHeader
    Private openFileDialogBrowse As System.Windows.Forms.OpenFileDialog
    Private WithEvents lstCommands As System.Windows.Forms.ListView
    Private btnEnd As System.Windows.Forms.Button
    Private btnAdd As System.Windows.Forms.Button
    Private btnBrowse As System.Windows.Forms.Button
    Private btnRemove As System.Windows.Forms.Button
    Private btnEdit As System.Windows.Forms.Button
    Private btnTest As System.Windows.Forms.Button

End Class
