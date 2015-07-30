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
        Me.lstCommands = New System.Windows.Forms.ListBox()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtArgs = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnSet = New System.Windows.Forms.Button()
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
        Me.lstCommands.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
                        Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lstCommands.FormattingEnabled = true
        Me.lstCommands.HorizontalScrollbar = true
        Me.lstCommands.IntegralHeight = false
        Me.lstCommands.Location = New System.Drawing.Point(12, 12)
        Me.lstCommands.Name = "lstCommands"
        Me.lstCommands.Size = New System.Drawing.Size(369, 106)
        Me.lstCommands.TabIndex = 21
        '
        'btnEnd
        '
        Me.btnEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEnd.Location = New System.Drawing.Point(493, 96)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(100, 23)
        Me.btnEnd.TabIndex = 23
        Me.btnEnd.Text = "Exit"
        Me.btnEnd.UseVisualStyleBackColor = true
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAdd.Location = New System.Drawing.Point(387, 67)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 23)
        Me.btnAdd.TabIndex = 24
        Me.btnAdd.Text = "Add (Duplicate)"
        Me.btnAdd.UseVisualStyleBackColor = true
        '
        'txtArgs
        '
        Me.txtArgs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtArgs.Location = New System.Drawing.Point(387, 12)
        Me.txtArgs.Name = "txtArgs"
        Me.txtArgs.Size = New System.Drawing.Size(206, 20)
        Me.txtArgs.TabIndex = 25
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnBrowse.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBrowse.Location = New System.Drawing.Point(493, 38)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(100, 23)
        Me.btnBrowse.TabIndex = 26
        Me.btnBrowse.Text = "Browse..."
        Me.btnBrowse.UseVisualStyleBackColor = true
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnRemove.Location = New System.Drawing.Point(387, 95)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(100, 23)
        Me.btnRemove.TabIndex = 27
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = true
        '
        'btnSet
        '
        Me.btnSet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnSet.Location = New System.Drawing.Point(387, 38)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(100, 23)
        Me.btnSet.TabIndex = 28
        Me.btnSet.Text = "<<== Set"
        Me.btnSet.UseVisualStyleBackColor = true
        '
        'btnTest
        '
        Me.btnTest.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnTest.Location = New System.Drawing.Point(493, 67)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(100, 23)
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
        Me.ClientSize = New System.Drawing.Size(605, 130)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.btnSet)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtArgs)
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
        Me.PerformLayout
    End Sub
    Friend WithEvents openFileDialogBrowse As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lstCommands As System.Windows.Forms.ListBox
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtArgs As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnSet As System.Windows.Forms.Button
    Friend WithEvents btnTest As System.Windows.Forms.Button

End Class
