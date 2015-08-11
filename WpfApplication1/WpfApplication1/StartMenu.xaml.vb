Class StartMenu

    Private Sub Start_Click(sender As Object, e As RoutedEventArgs) Handles Start.Click ''Goes to game window and closes the menu
        Dim Frm As New GameWindow

        Frm.Show()

        Me.Close()

    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim Frm As New OptionsWindow2


        Frm.Show()

        Me.Close()

    End Sub

    Private Sub QuitBtn_Click(sender As Object, e As RoutedEventArgs) Handles QuitBtn.Click
        Me.Close()
    End Sub
End Class
