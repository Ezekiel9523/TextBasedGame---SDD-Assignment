Class StartMenu

    Private Sub Start_Click(sender As Object, e As RoutedEventArgs) Handles Start.Click ''Goes to game window and closes the menu
        Dim Frm As New GameWindow

        Frm.Show()

        Me.Close()

    End Sub
End Class
