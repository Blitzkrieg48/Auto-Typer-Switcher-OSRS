Imports System.Runtime.InteropServices
Imports AutoClicker.Structs

Public Class Funcs
    <DllImport("user32.dll", SetLastError:=True)> _
    Public Shared Function ScreenToClient(ByVal hWnd As IntPtr, ByRef lpPoint As Point) As Boolean
    End Function

    <DllImport("user32.dll")> _
    Public Shared Function GetWindowRect(ByVal hWnd As IntPtr, ByRef lpRect As RECT) As Boolean
    End Function

    Public Declare Function IsWindowVisible Lib "user32.dll" (ByVal hwnd As IntPtr) As Boolean

    Public Declare Auto Function SetCursorPos Lib "user32.dll" (ByVal x As Integer, ByVal y As Integer) As Long

    <DllImport("user32.dll")> _
    Private Shared Sub mouse_event(ByVal dwFlags As UInteger, ByVal dx As UInteger, ByVal dy As UInteger, ByVal dwData As UInteger, ByVal dwExtraInfo As Integer)
    End Sub

    <DllImport("user32.dll")> _
    Public Shared Function RegisterHotKey(ByVal hwnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vk As Integer) As Integer
    End Function

    <DllImport("user32.dll")> _
    Public Shared Function UnregisterHotKey(ByVal hwnd As IntPtr, ByVal id As Integer) As Integer
    End Function

    Public Shared Function GetRand(min As Double, max As Double, dec As Integer) As Double
        Static rnd As New Random
        Return Math.Round(rnd.NextDouble() * (max - min) + min, dec)
    End Function

    Public Shared Function GrabWindowCorner(hndl As IntPtr) As Point
        Static Dim rct As New RECT
        Static Dim co As Point

        GetWindowRect(hndl, rct)

        co.X = rct.topX
        co.Y = rct.topY

        Return co
    End Function

    Public Shared Sub ClickOnPoint(cPo As Point)
        SetCursorPos(cPo.X, cPo.Y)

        mouse_event(MouseEventFlags.MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        mouse_event(MouseEventFlags.MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
    End Sub

    Public Shared Sub Callibrate(hndl As IntPtr)
        Dim po As Point = New Point(Control.MousePosition.X, Control.MousePosition.Y)
        MsgBox(po.X & " , " & po.Y)
        ScreenToClient(hndl, po)
        MsgBox(po.X & " , " & po.Y)
    End Sub
End Class
