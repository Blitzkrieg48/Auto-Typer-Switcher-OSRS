Imports System.Runtime.InteropServices
Imports System.Diagnostics
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Threading
Imports AutoClicker.Funcs
Imports AutoClicker.Structs

Public Class AutoClickerForm
    Private hndl As IntPtr
    Private title As String
    Private top_corner As Point
    Private initial_book As Point
    Private max_clicks As Integer
    Private low_interval As Integer
    Private high_interval As Integer

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim counter As Integer = 0

        For Each p As Process In Process.GetProcesses
            If Not p.MainWindowTitle = Nothing Then
                If p.MainWindowTitle.Contains("OSBuddy") Then
                    hndl = p.MainWindowHandle
                    title = p.MainWindowTitle

                    processListBox.Items.Add(p.MainWindowTitle & " {" & p.MainWindowHandle.ToString & "}")
                End If
            End If
        Next
    End Sub

    Private Sub startClickButton_Click(sender As Object, e As EventArgs) Handles startClickButton.Click
        low_interval = lowNUD.Value
        high_interval = highNUD.Value
        max_clicks = maxClicksNUD.Value


        clickProgressLabel.Text = "0"

        If low_interval >= high_interval Then
            MsgBox("Error: the low end of the interval cannot be higher or equal to the upper end.", MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        End If

        top_corner = GrabWindowCorner(hndl)

        If highAlchRadioButton.Checked Then
            initial_book.X = top_corner.X + Alch.hxbook
            initial_book.Y = top_corner.Y + Alch.hybook
        ElseIf lowAlchRadioButton.Checked Then
            initial_book.X = top_corner.X + Alch.lxbook
            initial_book.Y = top_corner.Y + Alch.lybook
        End If

        RegisterHotKey(Me.Handle, 200, VirtualKeys.ALT, Keys.F10)
        AutoClickerBackgroundWorker.RunWorkerAsync()
    End Sub

    Private Sub AutoClickerBackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles AutoClickerBackgroundWorker.DoWork
        Dim counter As Integer = 0
        Dim cPo As Point

        Dim progress As Integer = Math.Round(max_clicks / 100)

        While counter <= (max_clicks * 2)
            If AutoClickerBackgroundWorker.CancellationPending Then
                e.Cancel = True
                Exit While
            End If

            cPo = VaryClickPoint()

            ClickOnPoint(cPo)

            cPo = VaryClickPoint()

            ClickOnPoint(cPo)

            counter += 1

            If counter Mod 2 = 0 Then
                AutoClickerBackgroundWorker.ReportProgress(Math.Round(counter / 2))
            End If

            Thread.Sleep(GetRand(low_interval, high_interval, 3) * 1000)
        End While
    End Sub


    Private Function VaryClickPoint() As Point
        Static Dim vPo As Point

        vPo.X = initial_book.X + GetRand(0 - Alch.range, Alch.range, 0)
        vPo.Y = initial_book.Y + GetRand(0 - Alch.range, Alch.range, 0)

        Return vPo
    End Function

    Private Sub AutoClickerBackgroundWorker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles AutoClickerBackgroundWorker.ProgressChanged
        clickProgressLabel.Text = e.ProgressPercentage
    End Sub

    Private Sub AutoClickerBackgroundWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles AutoClickerBackgroundWorker.RunWorkerCompleted
        MsgBox("The AutoClicker has finished running.   Clicks completed: " & clickProgressLabel.Text, MsgBoxStyle.OkOnly, "Work Completed")

        UnregisterHotKey(Me.Handle, 200)
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = VirtualKeys.WM_HOTKEY Then
            Dim id As IntPtr = m.WParam
            If id.ToString = "200" Then
                AutoClickerBackgroundWorker.CancelAsync()
            End If
        End If

        MyBase.WndProc(m)
    End Sub
End Class
