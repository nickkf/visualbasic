Public Class pregunta_8
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nota As Integer

        nota = CInt(TextBox1.Text)

        Select Case nota
            Case 0 To 4
                MessageBox.Show("S   (suspendido)")
            Case 5, 6
                MessageBox.Show("A   (aprobado)")
            Case 7, 8
                MessageBox.Show("N   (notable)")
            Case 9
                MessageBox.Show("E   (excelente)")
            Case 10
                MessageBox.Show("M   (matricula)")
        End Select
    End Sub
End Class