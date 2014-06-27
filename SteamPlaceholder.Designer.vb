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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SteamPlaceholder))
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.txtCommand1 = New System.Windows.Forms.TextBox()
        Me.txtProgram1 = New System.Windows.Forms.TextBox()
        Me.btnBrowse1 = New System.Windows.Forms.Button()
        Me.btnRun1 = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.openFileDialogBrowse = New System.Windows.Forms.OpenFileDialog()
        Me.lblSaved = New System.Windows.Forms.Label()
        Me.timerSave = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout
        '
        'lbl1
        '
        Me.lbl1.AutoSize = true
        Me.lbl1.Location = New System.Drawing.Point(12, 9)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(98, 13)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "When Started with:"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = true
        Me.lbl2.Location = New System.Drawing.Point(116, 9)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(65, 13)
        Me.lbl2.TabIndex = 1
        Me.lbl2.Text = "Launch this:"
        '
        'txtCommand1
        '
        Me.txtCommand1.AllowDrop = true
        Me.txtCommand1.Location = New System.Drawing.Point(12, 25)
        Me.txtCommand1.Name = "txtCommand1"
        Me.txtCommand1.Size = New System.Drawing.Size(98, 20)
        Me.txtCommand1.TabIndex = 2
        '
        'txtProgram1
        '
        Me.txtProgram1.AllowDrop = true
        Me.txtProgram1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtProgram1.Location = New System.Drawing.Point(116, 25)
        Me.txtProgram1.Name = "txtProgram1"
        Me.txtProgram1.Size = New System.Drawing.Size(136, 20)
        Me.txtProgram1.TabIndex = 3
        '
        'btnBrowse1
        '
        Me.btnBrowse1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnBrowse1.Location = New System.Drawing.Point(258, 23)
        Me.btnBrowse1.Name = "btnBrowse1"
        Me.btnBrowse1.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse1.TabIndex = 4
        Me.btnBrowse1.Text = "Browse..."
        Me.btnBrowse1.UseVisualStyleBackColor = true
        AddHandler Me.btnBrowse1.Click, AddressOf Me.BtnBrowse1Click
        '
        'btnRun1
        '
        Me.btnRun1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnRun1.Location = New System.Drawing.Point(339, 23)
        Me.btnRun1.Name = "btnRun1"
        Me.btnRun1.Size = New System.Drawing.Size(75, 23)
        Me.btnRun1.TabIndex = 5
        Me.btnRun1.Text = "Test"
        Me.btnRun1.UseVisualStyleBackColor = true
        AddHandler Me.btnRun1.Click, AddressOf Me.BtnRun1Click
        '
        'btnEnd
        '
        Me.btnEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEnd.Location = New System.Drawing.Point(339, 210)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 6
        Me.btnEnd.Text = "Exit"
        Me.btnEnd.UseVisualStyleBackColor = true
        AddHandler Me.btnEnd.Click, AddressOf Me.BtnEndClick
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(258, 210)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = true
        AddHandler Me.btnSave.Click, AddressOf Me.BtnSaveClick
        '
        'openFileDialogBrowse
        '
        Me.openFileDialogBrowse.DefaultExt = "exe"
        Me.openFileDialogBrowse.InitialDirectory = "%ProgramFiles%"
        Me.openFileDialogBrowse.Multiselect = true
        Me.openFileDialogBrowse.ReadOnlyChecked = true
        Me.openFileDialogBrowse.ShowHelp = true
        Me.openFileDialogBrowse.ShowReadOnly = true
        '
        'lblSaved
        '
        Me.lblSaved.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblSaved.AutoSize = true
        Me.lblSaved.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblSaved.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblSaved.Location = New System.Drawing.Point(112, 213)
        Me.lblSaved.Name = "lblSaved"
        Me.lblSaved.Size = New System.Drawing.Size(140, 16)
        Me.lblSaved.TabIndex = 8
        Me.lblSaved.Text = "Saved Succesfully!"
        Me.lblSaved.Visible = false
        '
        'timerSave
        '
        Me.timerSave.Interval = 1000
        AddHandler Me.timerSave.Tick, AddressOf Me.TimerSaveTick
        '
        'SteamPlaceholder
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = true
        Me.CancelButton = Me.btnEnd
        Me.ClientSize = New System.Drawing.Size(426, 245)
        Me.Controls.Add(Me.lblSaved)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnRun1)
        Me.Controls.Add(Me.btnBrowse1)
        Me.Controls.Add(Me.txtProgram1)
        Me.Controls.Add(Me.txtCommand1)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.HelpButton = true
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "SteamPlaceholder"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Steam Placeholder"
        Me.ResumeLayout(false)
        Me.PerformLayout
    End Sub
    Private timerSave As System.Windows.Forms.Timer
    Private lblSaved As System.Windows.Forms.Label
    Private openFileDialogBrowse As System.Windows.Forms.OpenFileDialog
    Private btnSave As System.Windows.Forms.Button
    Private btnEnd As System.Windows.Forms.Button
    Private btnRun1 As System.Windows.Forms.Button
    Private btnBrowse1 As System.Windows.Forms.Button
    Private txtProgram1 As System.Windows.Forms.TextBox
    Private txtCommand1 As System.Windows.Forms.TextBox
    Private lbl2 As System.Windows.Forms.Label
    Private lbl1 As System.Windows.Forms.Label

End Class
