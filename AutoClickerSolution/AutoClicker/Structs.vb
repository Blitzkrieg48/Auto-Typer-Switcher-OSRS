Public Class Structs
    Public Structure VirtualKeys
        Public Const ALT As Integer = &H1
        Public Const WM_HOTKEY As Integer = &H312
    End Structure

    Public Structure RECT
        Public topX As Integer
        Public topY As Integer
        Public bottomX As Integer
        Public bottomY As Integer
    End Structure

    Public Enum MouseEventFlags As UInteger
        MOUSEEVENTF_LEFTDOWN = &H2
        MOUSEEVENTF_LEFTUP = &H4
        MOUSEEVENTF_MOVE = &H1
        MOUSEEVENTF_ABSOLUTE = &H8000
    End Enum

    Public Structure Alch
        Public Const lxbook As Integer = 717
        Public Const lybook As Integer = 290
        Public Const hxbook As Integer = 717
        Public Const hybook As Integer = 362
        Public Const hxinve As Integer = 706
        Public Const hyinve As Integer = 372
        Public Const lxinve As Integer = 707
        Public Const lyinve As Integer = 299
        Public Const range As Integer = 2
    End Structure
End Class
