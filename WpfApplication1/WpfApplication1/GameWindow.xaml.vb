Public Class GameWindow


    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

        Dim fileReader As String

        fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\william.james.lawson\Desktop\test.txt")
        TextScreen.Text = fileReader

    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

        Close()

    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Dim Frm As New OptionsWindow

        Frm.ShowDialog()

    End Sub

    Private Sub SkillsTab_Click(sender As Object, e As RoutedEventArgs) Handles SkillsTab.Click
        Dim Frm As New SkillTab

        Frm.ShowDialog()
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        Dim Frm As New LevelUp

        Frm.ShowDialog()
    End Sub

    Private Sub CharacterBtn_Click(sender As Object, e As RoutedEventArgs) Handles CharacterBtn.Click
        Dim Frm As New CharItemWindow

        Frm.ShowDialog()
    End Sub
End Class
