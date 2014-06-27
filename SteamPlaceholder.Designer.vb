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
        Me.txtCommand2 = New System.Windows.Forms.TextBox()
        Me.txtCommand3 = New System.Windows.Forms.TextBox()
        Me.txtCommand4 = New System.Windows.Forms.TextBox()
        Me.txtProgram2 = New System.Windows.Forms.TextBox()
        Me.txtProgram3 = New System.Windows.Forms.TextBox()
        Me.txtProgram4 = New System.Windows.Forms.TextBox()
        Me.btnBrowse2 = New System.Windows.Forms.Button()
        Me.btnBrowse3 = New System.Windows.Forms.Button()
        Me.btnBrowse4 = New System.Windows.Forms.Button()
        Me.btnRun2 = New System.Windows.Forms.Button()
        Me.btnRun3 = New System.Windows.Forms.Button()
        Me.btnRun4 = New System.Windows.Forms.Button()
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
        Me.btnEnd.Location = New System.Drawing.Point(339, 132)
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
        Me.btnSave.Location = New System.Drawing.Point(258, 132)
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
        Me.lblSaved.Location = New System.Drawing.Point(112, 135)
        Me.lblSaved.Name = "lblSaved"
        Me.lblSaved.Size = New System.Drawing.Size(140, 16)
        Me.lblSaved.TabIndex = 8
        Me.lblSaved.Text = "Saved Succesfully!"
        Me.lblSaved.Visible = false
        '
        'timerSave
        '
        Me.timerSave.Interval = 5000
        AddHandler Me.timerSave.Tick, AddressOf Me.TimerSaveTick
        '
        'txtCommand2
        '
        Me.txtCommand2.AllowDrop = true
        Me.txtCommand2.Location = New System.Drawing.Point(12, 51)
        Me.txtCommand2.Name = "txtCommand2"
        Me.txtCommand2.Size = New System.Drawing.Size(98, 20)
        Me.txtCommand2.TabIndex = 9
        '
        'txtCommand3
        '
        Me.txtCommand3.AllowDrop = true
        Me.txtCommand3.Location = New System.Drawing.Point(12, 77)
        Me.txtCommand3.Name = "txtCommand3"
        Me.txtCommand3.Size = New System.Drawing.Size(98, 20)
        Me.txtCommand3.TabIndex = 10
        '
        'txtCommand4
        '
        Me.txtCommand4.AllowDrop = true
        Me.txtCommand4.Location = New System.Drawing.Point(12, 103)
        Me.txtCommand4.Name = "txtCommand4"
        Me.txtCommand4.Size = New System.Drawing.Size(98, 20)
        Me.txtCommand4.TabIndex = 11
        '
        'txtProgram2
        '
        Me.txtProgram2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtProgram2.Location = New System.Drawing.Point(116, 51)
        Me.txtProgram2.Name = "txtProgram2"
        Me.txtProgram2.Size = New System.Drawing.Size(136, 20)
        Me.txtProgram2.TabIndex = 12
        '
        'txtProgram3
        '
        Me.txtProgram3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtProgram3.Location = New System.Drawing.Point(116, 77)
        Me.txtProgram3.Name = "txtProgram3"
        Me.txtProgram3.Size = New System.Drawing.Size(136, 20)
        Me.txtProgram3.TabIndex = 13
        '
        'txtProgram4
        '
        Me.txtProgram4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtProgram4.Location = New System.Drawing.Point(116, 103)
        Me.txtProgram4.Name = "txtProgram4"
        Me.txtProgram4.Size = New System.Drawing.Size(136, 20)
        Me.txtProgram4.TabIndex = 14
        '
        'btnBrowse2
        '
        Me.btnBrowse2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnBrowse2.Location = New System.Drawing.Point(258, 49)
        Me.btnBrowse2.Name = "btnBrowse2"
        Me.btnBrowse2.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse2.TabIndex = 15
        Me.btnBrowse2.Text = "Browse..."
        Me.btnBrowse2.UseVisualStyleBackColor = true
        AddHandler Me.btnBrowse2.Click, AddressOf Me.BtnBrowse2Click
        '
        'btnBrowse3
        '
        Me.btnBrowse3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnBrowse3.Location = New System.Drawing.Point(258, 75)
        Me.btnBrowse3.Name = "btnBrowse3"
        Me.btnBrowse3.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse3.TabIndex = 16
        Me.btnBrowse3.Text = "Browse..."
        Me.btnBrowse3.UseVisualStyleBackColor = true
        AddHandler Me.btnBrowse3.Click, AddressOf Me.BtnBrowse3Click
        '
        'btnBrowse4
        '
        Me.btnBrowse4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnBrowse4.Location = New System.Drawing.Point(258, 101)
        Me.btnBrowse4.Name = "btnBrowse4"
        Me.btnBrowse4.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse4.TabIndex = 17
        Me.btnBrowse4.Text = "Browse..."
        Me.btnBrowse4.UseVisualStyleBackColor = true
        AddHandler Me.btnBrowse4.Click, AddressOf Me.BtnBrowse4Click
        '
        'btnRun2
        '
        Me.btnRun2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnRun2.Location = New System.Drawing.Point(339, 49)
        Me.btnRun2.Name = "btnRun2"
        Me.btnRun2.Size = New System.Drawing.Size(75, 23)
        Me.btnRun2.TabIndex = 18
        Me.btnRun2.Text = "Test"
        Me.btnRun2.UseVisualStyleBackColor = true
        AddHandler Me.btnRun2.Click, AddressOf Me.BtnRun2Click
        '
        'btnRun3
        '
        Me.btnRun3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnRun3.Location = New System.Drawing.Point(339, 75)
        Me.btnRun3.Name = "btnRun3"
        Me.btnRun3.Size = New System.Drawing.Size(75, 23)
        Me.btnRun3.TabIndex = 19
        Me.btnRun3.Text = "Test"
        Me.btnRun3.UseVisualStyleBackColor = true
        AddHandler Me.btnRun3.Click, AddressOf Me.BtnRun3Click
        '
        'btnRun4
        '
        Me.btnRun4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnRun4.Location = New System.Drawing.Point(339, 101)
        Me.btnRun4.Name = "btnRun4"
        Me.btnRun4.Size = New System.Drawing.Size(75, 23)
        Me.btnRun4.TabIndex = 20
        Me.btnRun4.Text = "Test"
        Me.btnRun4.UseVisualStyleBackColor = true
        AddHandler Me.btnRun4.Click, AddressOf Me.BtnRun4Click
        '
        'SteamPlaceholder
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = true
        Me.CancelButton = Me.btnEnd
        Me.ClientSize = New System.Drawing.Size(426, 167)
        Me.Controls.Add(Me.btnRun4)
        Me.Controls.Add(Me.btnRun3)
        Me.Controls.Add(Me.btnRun2)
        Me.Controls.Add(Me.btnBrowse4)
        Me.Controls.Add(Me.btnBrowse3)
        Me.Controls.Add(Me.btnBrowse2)
        Me.Controls.Add(Me.txtProgram4)
        Me.Controls.Add(Me.txtProgram3)
        Me.Controls.Add(Me.txtProgram2)
        Me.Controls.Add(Me.txtCommand4)
        Me.Controls.Add(Me.txtCommand3)
        Me.Controls.Add(Me.txtCommand2)
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
    Private btnRun4 As System.Windows.Forms.Button
    Private btnRun3 As System.Windows.Forms.Button
    Private btnRun2 As System.Windows.Forms.Button
    Private btnBrowse4 As System.Windows.Forms.Button
    Private btnBrowse3 As System.Windows.Forms.Button
    Private btnBrowse2 As System.Windows.Forms.Button
    Private txtProgram4 As System.Windows.Forms.TextBox
    Private txtProgram3 As System.Windows.Forms.TextBox
    Private txtProgram2 As System.Windows.Forms.TextBox
    Private txtCommand4 As System.Windows.Forms.TextBox
    Private txtCommand3 As System.Windows.Forms.TextBox
    Private txtCommand2 As System.Windows.Forms.TextBox
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
