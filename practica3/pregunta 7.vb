Public Class pregunta_7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dia As Integer

        dia = CInt(TextBox1.Text)

        If dia = 1 Then
            MessageBox.Show("lunes")
        ElseIf dia = 2 Then
            MessageBox.Show("martes")
        ElseIf dia = 3 Then
            MessageBox.Show("miercoles")
        ElseIf dia = 4 Then
            MessageBox.Show("jueves")
        ElseIf dia = 5 Then
            MessageBox.Show("viernes")
        ElseIf dia = 6 Then
            MessageBox.Show("sabado")
        ElseIf dia = 7 Then
            MessageBox.Show("domingo")
        End If
    End Sub
End Class