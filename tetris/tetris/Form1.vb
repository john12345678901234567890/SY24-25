Imports System.CodeDom.Compiler

Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        follow(ENEMY, Avatar, 100)
        follow(enemy2, Avatar, 10)
    End Sub
    Sub follow(E As PictureBox, a As PictureBox, s As Integer)
        If E.Location.Y > a.Location.Y Then
            move(E, 0, -s)
        Else
            move(E, 0, s)
        End If
        If E.Location.X > a.Location.X Then
            move(E, -s, 0)
        Else
            move(E, s, 0)
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.A Then
            move(Avatar, -5, 0)
        ElseIf e.KeyCode = Keys.Right Or e.KeyCode = Keys.D Then
            move(Avatar, 5, 0)
        ElseIf e.KeyCode = Keys.Down Or e.KeyCode = Keys.S Then
            move(Avatar, 0, 5)
        ElseIf e.KeyCode = Keys.Up Or e.KeyCode = Keys.W Then
            move(Avatar, 0, -5)
        End If
        If e.KeyCode = Keys.Space Then
            Avatar.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        End If
        Avatar.Refresh()

    End Sub
    Sub move(P As PictureBox, xdir As Integer, ydir As Integer)
        P.Location += New Point(xdir, ydir)

    End Sub
End Class


