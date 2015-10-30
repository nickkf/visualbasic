Public Class numeros_pares
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer
        Dim salida As String


        For num = 0 To 20 Step 2

            salida = salida + num.ToString + Environment.NewLine()

        Next

        MessageBox.Show(salida)


    End Sub
End Class