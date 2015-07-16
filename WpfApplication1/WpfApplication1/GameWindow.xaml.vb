Public Class GameWindow


    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

        Dim fileReader As String

        fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\william.james.lawson\Desktop\test.txt")
        TextScreen.Text = fileReader

    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

        Close()

    End Sub
End Class
