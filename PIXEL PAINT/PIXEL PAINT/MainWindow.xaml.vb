Class MainWindow
    Private Sub fill1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles fill1.MouseDown, fill2.MouseDown, fill3.MouseDown, fill4.MouseDown, fill5.MouseDown, fill6.MouseDown, fill7.MouseDown, fill8.MouseDown
        brush1.Fill = sender.Fill
    End Sub
    Private Sub p00_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles p00.MouseDown, p01.MouseDown, p02.MouseDown, p03.MouseDown, p04.MouseDown, p05.MouseDown, p06.MouseDown,
        sender.fill = brush1.Fill
    End Sub
End Class

