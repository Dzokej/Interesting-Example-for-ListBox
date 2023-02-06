Public Class Form1
    Private Sub lstFlavors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFlavors.SelectedIndexChanged
        If lstFlavors.SelectedIndex = 0 Then
            Button1.Text = lstFlavors.SelectedItem.ToString
        ElseIf lstFlavors.SelectedIndex = 1 Then
            Button1.Text = lstFlavors.SelectedItem.ToString
        ElseIf lstFlavors.SelectedIndex = 2 Then
            Button1.Text = lstFlavors.SelectedItem.ToString
        End If
    End Sub
End Class
