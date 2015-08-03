Public Class GameWindow


    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

        Dim fileReader As String

        fileReader = My.Computer.FileSystem.ReadAllText("Resources\1.1 - WelcomeScreen.txt")
        TextScreen.Text = fileReader

    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

        Close()

    End Sub

    Private Sub btnStart_Click(sender As Object, e As RoutedEventArgs)

        btnStart.Visibility = Windows.Visibility.Hidden
        btnNext.Visibility = Windows.Visibility.Visible

        Dim fileReader As String

        fileReader = My.Computer.FileSystem.ReadAllText("Resources\2.1 - Intro.txt")

        TextScreen.Text = fileReader

    End Sub

    Private Sub btnLore_Click(sender As Object, e As RoutedEventArgs)



        btnStart.Visibility = Windows.Visibility.Hidden
        btnNext.Visibility = Windows.Visibility.Visible
        btnLore.Visibility = Windows.Visibility.Hidden
        btnBlank1.Visibility = Windows.Visibility.Visible

        Dim fileReader As String

        fileReader = My.Computer.FileSystem.ReadAllText("Resources\1.2 - Lore.txt")
        TextScreen.Text = fileReader

    End Sub
End Class
