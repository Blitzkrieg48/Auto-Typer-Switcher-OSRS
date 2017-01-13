<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AutoSwitcherForm
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
        Me.guthansRadioButton = New System.Windows.Forms.RadioButton()
        Me.customRadioButton = New System.Windows.Forms.RadioButton()
        Me.switchBackCountLabel = New System.Windows.Forms.Label()
        Me.switchBackNUD = New System.Windows.Forms.NumericUpDown()
        Me.enableButton = New System.Windows.Forms.Button()
        Me.switchToComboBox = New System.Windows.Forms.ComboBox()
        Me.switchToLabel = New System.Windows.Forms.Label()
        Me.switchBackLabel = New System.Windows.Forms.Label()
        Me.switchBackComboBox = New System.Windows.Forms.ComboBox()
        Me.infoLabel = New System.Windows.Forms.Label()
        Me.startRecoButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.disableButton = New System.Windows.Forms.Button()
        Me.hndlLabel = New System.Windows.Forms.Label()
        Me.intervalLabel = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        CType(Me.switchBackNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'guthansRadioButton
        '
        Me.guthansRadioButton.AutoSize = True
        Me.guthansRadioButton.Checked = True
        Me.guthansRadioButton.Location = New System.Drawing.Point(12, 13)
        Me.guthansRadioButton.Name = "guthansRadioButton"
        Me.guthansRadioButton.Size = New System.Drawing.Size(100, 17)
        Me.guthansRadioButton.TabIndex = 2
        Me.guthansRadioButton.TabStop = True
        Me.guthansRadioButton.Text = "Guthans Switch"
        Me.guthansRadioButton.UseVisualStyleBackColor = True
        '
        'customRadioButton
        '
        Me.customRadioButton.AutoSize = True
        Me.customRadioButton.Location = New System.Drawing.Point(12, 90)
        Me.customRadioButton.Name = "customRadioButton"
        Me.customRadioButton.Size = New System.Drawing.Size(95, 17)
        Me.customRadioButton.TabIndex = 4
        Me.customRadioButton.Text = "Custom Switch"
        Me.customRadioButton.UseVisualStyleBackColor = True
        '
        'switchBackCountLabel
        '
        Me.switchBackCountLabel.Location = New System.Drawing.Point(9, 43)
        Me.switchBackCountLabel.Name = "switchBackCountLabel"
        Me.switchBackCountLabel.Size = New System.Drawing.Size(70, 23)
        Me.switchBackCountLabel.TabIndex = 5
        Me.switchBackCountLabel.Text = "Switchback: "
        '
        'switchBackNUD
        '
        Me.switchBackNUD.Location = New System.Drawing.Point(85, 41)
        Me.switchBackNUD.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.switchBackNUD.Minimum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.switchBackNUD.Name = "switchBackNUD"
        Me.switchBackNUD.Size = New System.Drawing.Size(27, 20)
        Me.switchBackNUD.TabIndex = 6
        Me.switchBackNUD.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'enableButton
        '
        Me.enableButton.Location = New System.Drawing.Point(12, 250)
        Me.enableButton.Name = "enableButton"
        Me.enableButton.Size = New System.Drawing.Size(75, 23)
        Me.enableButton.TabIndex = 7
        Me.enableButton.Text = "Enable"
        Me.enableButton.UseVisualStyleBackColor = True
        '
        'switchToComboBox
        '
        Me.switchToComboBox.Enabled = False
        Me.switchToComboBox.FormattingEnabled = True
        Me.switchToComboBox.Items.AddRange(New Object() {"F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12"})
        Me.switchToComboBox.Location = New System.Drawing.Point(121, 168)
        Me.switchToComboBox.Name = "switchToComboBox"
        Me.switchToComboBox.Size = New System.Drawing.Size(60, 21)
        Me.switchToComboBox.TabIndex = 8
        '
        'switchToLabel
        '
        Me.switchToLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.switchToLabel.Location = New System.Drawing.Point(12, 170)
        Me.switchToLabel.Name = "switchToLabel"
        Me.switchToLabel.Size = New System.Drawing.Size(67, 23)
        Me.switchToLabel.TabIndex = 9
        Me.switchToLabel.Text = "Switch to: "
        '
        'switchBackLabel
        '
        Me.switchBackLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.switchBackLabel.Location = New System.Drawing.Point(12, 206)
        Me.switchBackLabel.Name = "switchBackLabel"
        Me.switchBackLabel.Size = New System.Drawing.Size(75, 23)
        Me.switchBackLabel.TabIndex = 10
        Me.switchBackLabel.Text = "Switch back: "
        '
        'switchBackComboBox
        '
        Me.switchBackComboBox.Enabled = False
        Me.switchBackComboBox.FormattingEnabled = True
        Me.switchBackComboBox.Items.AddRange(New Object() {"F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12"})
        Me.switchBackComboBox.Location = New System.Drawing.Point(121, 206)
        Me.switchBackComboBox.Name = "switchBackComboBox"
        Me.switchBackComboBox.Size = New System.Drawing.Size(60, 21)
        Me.switchBackComboBox.TabIndex = 11
        '
        'infoLabel
        '
        Me.infoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.infoLabel.Location = New System.Drawing.Point(187, 41)
        Me.infoLabel.Name = "infoLabel"
        Me.infoLabel.Size = New System.Drawing.Size(224, 232)
        Me.infoLabel.TabIndex = 12
        '
        'startRecoButton
        '
        Me.startRecoButton.Location = New System.Drawing.Point(12, 126)
        Me.startRecoButton.Name = "startRecoButton"
        Me.startRecoButton.Size = New System.Drawing.Size(75, 23)
        Me.startRecoButton.TabIndex = 13
        Me.startRecoButton.Text = "Start Record"
        Me.startRecoButton.UseVisualStyleBackColor = True
        Me.startRecoButton.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(86, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Alt + "
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(90, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Alt + "
        '
        'disableButton
        '
        Me.disableButton.Location = New System.Drawing.Point(106, 250)
        Me.disableButton.Name = "disableButton"
        Me.disableButton.Size = New System.Drawing.Size(75, 23)
        Me.disableButton.TabIndex = 17
        Me.disableButton.Text = "Disable"
        Me.disableButton.UseVisualStyleBackColor = True
        '
        'hndlLabel
        '
        Me.hndlLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.hndlLabel.Location = New System.Drawing.Point(187, 17)
        Me.hndlLabel.Name = "hndlLabel"
        Me.hndlLabel.Size = New System.Drawing.Size(224, 23)
        Me.hndlLabel.TabIndex = 18
        '
        'intervalLabel
        '
        Me.intervalLabel.Location = New System.Drawing.Point(126, 9)
        Me.intervalLabel.Name = "intervalLabel"
        Me.intervalLabel.Size = New System.Drawing.Size(51, 23)
        Me.intervalLabel.TabIndex = 19
        Me.intervalLabel.Text = "Interval:"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.DecimalPlaces = 2
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown1.Location = New System.Drawing.Point(118, 32)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(63, 20)
        Me.NumericUpDown1.TabIndex = 20
        Me.NumericUpDown1.Value = New Decimal(New Integer() {25, 0, 0, 131072})
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.DecimalPlaces = 2
        Me.NumericUpDown2.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown2.Location = New System.Drawing.Point(118, 58)
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(63, 20)
        Me.NumericUpDown2.TabIndex = 21
        Me.NumericUpDown2.Value = New Decimal(New Integer() {5, 0, 0, 65536})
        '
        'AutoSwitcherForm
        '
        Me.AcceptButton = Me.disableButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 285)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.intervalLabel)
        Me.Controls.Add(Me.hndlLabel)
        Me.Controls.Add(Me.disableButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.startRecoButton)
        Me.Controls.Add(Me.infoLabel)
        Me.Controls.Add(Me.switchBackComboBox)
        Me.Controls.Add(Me.switchBackLabel)
        Me.Controls.Add(Me.switchToLabel)
        Me.Controls.Add(Me.switchToComboBox)
        Me.Controls.Add(Me.enableButton)
        Me.Controls.Add(Me.switchBackNUD)
        Me.Controls.Add(Me.switchBackCountLabel)
        Me.Controls.Add(Me.customRadioButton)
        Me.Controls.Add(Me.guthansRadioButton)
        Me.Name = "AutoSwitcherForm"
        Me.Text = "AutoSwitcher VER 1.0"
        CType(Me.switchBackNUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents guthansRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents customRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents switchBackCountLabel As System.Windows.Forms.Label
    Friend WithEvents switchBackNUD As System.Windows.Forms.NumericUpDown
    Friend WithEvents enableButton As System.Windows.Forms.Button
    Friend WithEvents switchToComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents switchToLabel As System.Windows.Forms.Label
    Friend WithEvents switchBackLabel As System.Windows.Forms.Label
    Friend WithEvents infoLabel As System.Windows.Forms.Label
    Friend WithEvents startRecoButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents switchBackComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents disableButton As System.Windows.Forms.Button
    Friend WithEvents hndlLabel As System.Windows.Forms.Label
    Friend WithEvents intervalLabel As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
End Class
