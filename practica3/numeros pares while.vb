Public Class numeros_pares_while
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer = 0
        Dim salida As String = ""


        While num <= 20
            salida = salida + num.ToString() + Environment.NewLine()
            num = num + 2

        End While



        MessageBox.Show(salida)

    End Sub
End Class