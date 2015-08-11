Public Class OptionsWindow2

    Private Sub BtoMain_Menu_Click(sender As Object, e As RoutedEventArgs) Handles BtoMain_Menu.Click
        Dim Frm As New StartMenu

        Frm.Show()

        Me.Close()
    End Sub
End Class
