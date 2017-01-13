Imports AutoClicker.Funcs
Imports AutoClicker.Structs

Public Class AutoSwitcherForm
    Private SwitchType As Integer 'guthans is 0, custom is 1
    Private hndl As IntPtr

    Private Sub AutoSwitcherForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        guthansRadioButton_CheckedChanged(sender, e)
        switchToComboBox.Text = "F10"
        switchBackComboBox.Text = "F11"

        For Each p As Process In Process.GetProcesses
            If Not p.MainWindowTitle = Nothing Then
                If p.MainWindowTitle.Contains("OSBuddy") Then
                    hndl = p.MainWindowHandle
                    hndlLabel.Text = p.MainWindowTitle & " {" & p.MainWindowHandle.ToString & "}"
                End If
            End If
        Next
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = VirtualKeys.WM_HOTKEY Then
            Dim id As IntPtr = m.WParam
            If id.ToString = "300" Then
                SwitchTo()
            ElseIf id.ToString = "400" Then
                SwitchFro()
            End If

        End If

        MyBase.WndProc(m)
    End Sub

    Private Sub customRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles customRadioButton.CheckedChanged
        If customRadioButton.Checked Then
            infoLabel.Text = "The Custom Switch radio button will record two switches, to and from, " & _
                "and then use hotkeys to perform the switches." & Environment.NewLine & Environment.NewLine & _
                "To record, use the 'Start Record button' and select the switch you would like to record." & _
                Environment.NewLine & Environment.NewLine & "At the moment, only F10 and F11 are supported switch hotkeys."
        End If
    End Sub

    Private Sub guthansRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles guthansRadioButton.CheckedChanged
        If guthansRadioButton.Checked Then
            infoLabel.Text = "The Guthan's Switch default radio button is a built-in default switch for " & _
                    "when you need a basic 4-way switch." & Environment.NewLine & Environment.NewLine & _
                    "You can change the number of items to use as a switch back by altering the number in the " & _
                    "switch back numeric-up-down, with a minimum of 4 and a maximum of 8." & Environment.NewLine & Environment.NewLine & _
                    "If you need a custom switch, switch to the Custom Switch Radio Button and follow those instructions."
        End If
    End Sub

    Private Sub enableButton_Click(sender As Object, e As EventArgs) Handles enableButton.Click
        If guthansRadioButton.Checked Then
            SwitchType = 0
        ElseIf customRadioButton.Checked Then
            SwitchType = 1
        Else
            MsgBox("massive fucking error bro")
            Exit Sub
        End If

        RegisterHotKey(Me.Handle, 300, VirtualKeys.ALT, Keys.F10)
        RegisterHotKey(Me.Handle, 400, VirtualKeys.ALT, Keys.F11)
        enableButton.Enabled = False
        disableButton.Enabled = True
    End Sub

    Private Sub disableButton_Click(sender As Object, e As EventArgs) Handles disableButton.Click
        'UnregisterHotKey(Me.Handle, 300)
        'UnregisterHotKey(Me.Handle, 400)
        'enableButton.Enabled = True
        'disableButton.Enabled = False

        Callibrate(hndl)
    End Sub

    Private Sub SwitchTo()
        If SwitchType = 0 Then
            Dim guth() As Point = {New Point(0, 0), New Point(0, 1), New Point(0, 2), New Point(0, 3)}

        ElseIf SwitchType = 1 Then

        End If
    End Sub

    Private Sub SwitchFro()

    End Sub
End Class