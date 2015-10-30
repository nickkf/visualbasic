Public Class pregunta_6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dia As Integer


        dia = CInt(TextBox1.Text)

        Select Case dia
            Case 1
                MessageBox.Show("lunes")
            Case 2
                MessageBox.Show("martes")
            Case 3
                MessageBox.Show("miercoles")
            Case 4
                MessageBox.Show("jueves")
            Case 5
                MessageBox.Show("viernes")
            Case 6
                MessageBox.Show("sabado")
            Case 7
                MessageBox.Show("domingo")
        End Select

    End Sub
End Class