Public Class pregunta_5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1 As Double
        Dim resultado As String

        n1 = TextBox1.Text

        If n1 < 5 Then
            resultado = MessageBox.Show("suspendido")
        ElseIf n1 > 5 And n1 < 6.5 Then
            resultado = MessageBox.Show("aprobado")
        ElseIf n1 > 6.5 And n1 < 8.5 Then
            resultado = MessageBox.Show("notable")
        ElseIf n1 > 8.5 And n1 < 9.75 Then
            resultado = MessageBox.Show("excelente")
        ElseIf n1 > 9.75 And n1 < 10 Then
            resultado = MessageBox.Show("matricula")
        End If

    End Sub
End Class