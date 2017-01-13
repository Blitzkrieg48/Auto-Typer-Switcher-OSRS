<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AutoClickerForm
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
        Me.AutoClickerBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.maxClicksNUD = New System.Windows.Forms.NumericUpDown()
        Me.maxClickLabel = New System.Windows.Forms.Label()
        Me.processListBox = New System.Windows.Forms.ListBox()
        Me.startClickButton = New System.Windows.Forms.Button()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.lowAlchRadioButton = New System.Windows.Forms.RadioButton()
        Me.highAlchRadioButton = New System.Windows.Forms.RadioButton()
        Me.toLabel = New System.Windows.Forms.Label()
        Me.timeIntervalLabel = New System.Windows.Forms.Label()
        Me.highNUD = New System.Windows.Forms.NumericUpDown()
        Me.lowNUD = New System.Windows.Forms.NumericUpDown()
        Me.AutoClickerTabControl = New System.Windows.Forms.TabControl()
        Me.clickProgressLabel = New System.Windows.Forms.Label()
        Me.TabPage1.SuspendLayout()
        CType(Me.maxClicksNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.highNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lowNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AutoClickerTabControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'AutoClickerBackgroundWorker
        '
        Me.AutoClickerBackgroundWorker.WorkerReportsProgress = True
        Me.AutoClickerBackgroundWorker.WorkerSupportsCancellation = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.clickProgressLabel)
        Me.TabPage1.Controls.Add(Me.maxClicksNUD)
        Me.TabPage1.Controls.Add(Me.maxClickLabel)
        Me.TabPage1.Controls.Add(Me.processListBox)
        Me.TabPage1.Controls.Add(Me.startClickButton)
        Me.TabPage1.Controls.Add(Me.RadioButton4)
        Me.TabPage1.Controls.Add(Me.RadioButton3)
        Me.TabPage1.Controls.Add(Me.lowAlchRadioButton)
        Me.TabPage1.Controls.Add(Me.highAlchRadioButton)
        Me.TabPage1.Controls.Add(Me.toLabel)
        Me.TabPage1.Controls.Add(Me.timeIntervalLabel)
        Me.TabPage1.Controls.Add(Me.highNUD)
        Me.TabPage1.Controls.Add(Me.lowNUD)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(441, 211)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "AutoClicker Tool"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'maxClicksNUD
        '
        Me.maxClicksNUD.Location = New System.Drawing.Point(9, 156)
        Me.maxClicksNUD.Maximum = New Decimal(New Integer() {20000, 0, 0, 0})
        Me.maxClicksNUD.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.maxClicksNUD.Name = "maxClicksNUD"
        Me.maxClicksNUD.Size = New System.Drawing.Size(106, 20)
        Me.maxClicksNUD.TabIndex = 12
        Me.maxClicksNUD.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'maxClickLabel
        '
        Me.maxClickLabel.AutoSize = True
        Me.maxClickLabel.Location = New System.Drawing.Point(6, 140)
        Me.maxClickLabel.Name = "maxClickLabel"
        Me.maxClickLabel.Size = New System.Drawing.Size(61, 13)
        Me.maxClickLabel.TabIndex = 11
        Me.maxClickLabel.Text = "Max Clicks:"
        '
        'processListBox
        '
        Me.processListBox.FormattingEnabled = True
        Me.processListBox.Location = New System.Drawing.Point(121, 71)
        Me.processListBox.Name = "processListBox"
        Me.processListBox.Size = New System.Drawing.Size(314, 43)
        Me.processListBox.TabIndex = 9
        '
        'startClickButton
        '
        Me.startClickButton.Location = New System.Drawing.Point(6, 182)
        Me.startClickButton.Name = "startClickButton"
        Me.startClickButton.Size = New System.Drawing.Size(75, 23)
        Me.startClickButton.TabIndex = 8
        Me.startClickButton.Text = "Start"
        Me.startClickButton.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(311, 21)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton4.TabIndex = 7
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "RadioButton4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        Me.RadioButton4.Visible = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(203, 21)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton3.TabIndex = 6
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        Me.RadioButton3.Visible = False
        '
        'lowAlchRadioButton
        '
        Me.lowAlchRadioButton.AutoSize = True
        Me.lowAlchRadioButton.Location = New System.Drawing.Point(102, 21)
        Me.lowAlchRadioButton.Name = "lowAlchRadioButton"
        Me.lowAlchRadioButton.Size = New System.Drawing.Size(88, 17)
        Me.lowAlchRadioButton.TabIndex = 5
        Me.lowAlchRadioButton.TabStop = True
        Me.lowAlchRadioButton.Text = "Low Alchemy"
        Me.lowAlchRadioButton.UseVisualStyleBackColor = True
        '
        'highAlchRadioButton
        '
        Me.highAlchRadioButton.AutoSize = True
        Me.highAlchRadioButton.Checked = True
        Me.highAlchRadioButton.Location = New System.Drawing.Point(6, 21)
        Me.highAlchRadioButton.Name = "highAlchRadioButton"
        Me.highAlchRadioButton.Size = New System.Drawing.Size(90, 17)
        Me.highAlchRadioButton.TabIndex = 4
        Me.highAlchRadioButton.TabStop = True
        Me.highAlchRadioButton.Text = "High Alchemy"
        Me.highAlchRadioButton.UseVisualStyleBackColor = True
        '
        'toLabel
        '
        Me.toLabel.Location = New System.Drawing.Point(53, 98)
        Me.toLabel.Name = "toLabel"
        Me.toLabel.Size = New System.Drawing.Size(18, 18)
        Me.toLabel.TabIndex = 3
        Me.toLabel.Text = "to"
        '
        'timeIntervalLabel
        '
        Me.timeIntervalLabel.Location = New System.Drawing.Point(6, 71)
        Me.timeIntervalLabel.Name = "timeIntervalLabel"
        Me.timeIntervalLabel.Size = New System.Drawing.Size(118, 23)
        Me.timeIntervalLabel.TabIndex = 2
        Me.timeIntervalLabel.Text = "Time Interval:"
        '
        'highNUD
        '
        Me.highNUD.DecimalPlaces = 1
        Me.highNUD.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.highNUD.Location = New System.Drawing.Point(76, 96)
        Me.highNUD.Name = "highNUD"
        Me.highNUD.Size = New System.Drawing.Size(39, 20)
        Me.highNUD.TabIndex = 1
        Me.highNUD.Value = New Decimal(New Integer() {16, 0, 0, 65536})
        '
        'lowNUD
        '
        Me.lowNUD.DecimalPlaces = 1
        Me.lowNUD.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.lowNUD.Location = New System.Drawing.Point(6, 96)
        Me.lowNUD.Name = "lowNUD"
        Me.lowNUD.Size = New System.Drawing.Size(39, 20)
        Me.lowNUD.TabIndex = 0
        Me.lowNUD.Value = New Decimal(New Integer() {12, 0, 0, 65536})
        '
        'AutoClickerTabControl
        '
        Me.AutoClickerTabControl.Controls.Add(Me.TabPage1)
        Me.AutoClickerTabControl.Location = New System.Drawing.Point(12, 12)
        Me.AutoClickerTabControl.Name = "AutoClickerTabControl"
        Me.AutoClickerTabControl.SelectedIndex = 0
        Me.AutoClickerTabControl.Size = New System.Drawing.Size(449, 237)
        Me.AutoClickerTabControl.TabIndex = 2
        '
        'clickProgressLabel
        '
        Me.clickProgressLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clickProgressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clickProgressLabel.Location = New System.Drawing.Point(211, 140)
        Me.clickProgressLabel.Name = "clickProgressLabel"
        Me.clickProgressLabel.Size = New System.Drawing.Size(136, 52)
        Me.clickProgressLabel.TabIndex = 13
        Me.clickProgressLabel.Text = "0"
        Me.clickProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AutoClickerForm
        '
        Me.AcceptButton = Me.startClickButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 261)
        Me.Controls.Add(Me.AutoClickerTabControl)
        Me.Name = "AutoClickerForm"
        Me.Text = "AutoClicker VER 1.0"
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.maxClicksNUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.highNUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lowNUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AutoClickerTabControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AutoClickTimer As System.Windows.Forms.Timer
    Friend WithEvents AutoClickerBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents maxClicksNUD As System.Windows.Forms.NumericUpDown
    Friend WithEvents maxClickLabel As System.Windows.Forms.Label
    Friend WithEvents processListBox As System.Windows.Forms.ListBox
    Friend WithEvents startClickButton As System.Windows.Forms.Button
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents lowAlchRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents highAlchRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents toLabel As System.Windows.Forms.Label
    Friend WithEvents timeIntervalLabel As System.Windows.Forms.Label
    Friend WithEvents highNUD As System.Windows.Forms.NumericUpDown
    Friend WithEvents lowNUD As System.Windows.Forms.NumericUpDown
    Friend WithEvents AutoClickerTabControl As System.Windows.Forms.TabControl
    Friend WithEvents clickProgressLabel As System.Windows.Forms.Label

End Class
