Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        TEAM1.Visibility = Visibility.Visible
        TEAM2.Visibility = Visibility.Hidden
        TEAM3.Visibility = Visibility.Hidden
        TEAMLABEL.Content = "2 super bowl wins, in the AFC North, Made in 1996, and there GM is Eric DeCosta."
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        TEAM2.Visibility = Visibility.Visible
        TEAM1.Visibility = Visibility.Hidden
        TEAM3.Visibility = Visibility.Hidden
        TEAMLABEL.Content = "6 super bowl wins, in the AFC North, Made in 1933, and their GM is Omar Khan"
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        TEAM3.Visibility = Visibility.Visible
        TEAM2.Visibility = Visibility.Hidden
        TEAM1.Visibility = Visibility.Hidden
        TEAMLABEL.Content = "4 super bowl wins, in the AFC West, Made in 1963, and there GM is Brett Veach."
    End Sub
End Class
