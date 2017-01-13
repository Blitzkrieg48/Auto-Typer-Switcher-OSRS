Public Class Pivot
    Private Sub clickerFormButton_Click(sender As Object, e As EventArgs) Handles clickerFormButton.Click
        Dim clickForm As New AutoClickerForm

        clickForm.Show()
    End Sub

    Private Sub switcherFormButton_Click(sender As Object, e As EventArgs) Handles switcherFormButton.Click
        Dim switchForm As New AutoSwitcherForm

        switchForm.Show()
    End Sub
End Class