<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pivot
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
        Me.clickerFormButton = New System.Windows.Forms.Button()
        Me.switcherFormButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'clickerFormButton
        '
        Me.clickerFormButton.AutoSize = True
        Me.clickerFormButton.Location = New System.Drawing.Point(38, 40)
        Me.clickerFormButton.Name = "clickerFormButton"
        Me.clickerFormButton.Size = New System.Drawing.Size(98, 23)
        Me.clickerFormButton.TabIndex = 0
        Me.clickerFormButton.Text = "Auto-Clicker Tool"
        Me.clickerFormButton.UseVisualStyleBackColor = True
        '
        'switcherFormButton
        '
        Me.switcherFormButton.AutoSize = True
        Me.switcherFormButton.Location = New System.Drawing.Point(201, 40)
        Me.switcherFormButton.Name = "switcherFormButton"
        Me.switcherFormButton.Size = New System.Drawing.Size(107, 23)
        Me.switcherFormButton.TabIndex = 1
        Me.switcherFormButton.Text = "Auto-Switcher Tool"
        Me.switcherFormButton.UseVisualStyleBackColor = True
        '
        'Pivot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 104)
        Me.Controls.Add(Me.switcherFormButton)
        Me.Controls.Add(Me.clickerFormButton)
        Me.Name = "Pivot"
        Me.Text = "Krieger Auto'ing Suite VER 1.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents clickerFormButton As System.Windows.Forms.Button
    Friend WithEvents switcherFormButton As System.Windows.Forms.Button
End Class
