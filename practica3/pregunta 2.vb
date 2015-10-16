Public Class pregunta_2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1 As Integer
        Dim n2 As Integer
        Dim resultado As String

        n1 = CInt(TextBox1.Text())
        n2 = CInt(TextBox2.Text())


        If n1 > n2 Then
            resultado = " es divisible "
        ElseIf n1 < n2 Then
            resultado = " no es divisible "

        End If
        MessageBox.Show(resultado)
    End Sub
End Class