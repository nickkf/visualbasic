Public Class pregunta_4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim position As Integer
        Dim letra As String

        letra = TextBox1.Text

        position = InStr("aeioubcdfghjklmnpqrstvwxyz", letra)

        If position < 5 And position > 0 Then
            MessageBox.Show("Vocal")
        ElseIf position > 5 Then
            MessageBox.Show("Consonante")
        Else
            MessageBox.Show("Error")
        End If

    End Sub
End Class