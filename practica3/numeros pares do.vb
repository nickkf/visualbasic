Public Class numeros_pares_do
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer = 0
        Dim salida As String = ""


        Do While num < 20
            num = num + 2
            salida = salida + num.ToString() + Environment.NewLine()
        Loop

        MessageBox.Show(salida)



    End Sub
End Class