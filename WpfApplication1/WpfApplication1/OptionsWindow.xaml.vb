Public Class OptionsWindow

    Private Sub Main_Menu_Click(sender As Object, e As RoutedEventArgs) Handles Main_Menu.Click
        Dim Frm As New StartMenu

        Frm.Show()

        Me.Close()
    End Sub

    Private Sub Back_To_Game_Click(sender As Object, e As RoutedEventArgs) Handles Back_To_Game.Click
        Me.Close()
    End Sub
End Class
