Public Class pregunta_9
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mes As Integer
        Dim año As Integer
        Dim febrero As Integer

        mes = CInt(TextBox1.Text)
        año = CInt(TextBox2.Text)


        Select Case mes
            Case 1
                MessageBox.Show("31")
            Case 2
                If año Mod 4 = 0 And año Mod 100 <> 0 Then
                    MessageBox.Show("29")
                ElseIf año Mod 4 = 0 And año Mod 100 = 0 And año Mod 400 = 0 Then
                    MessageBox.Show("29")
                ElseIf año Mod 4 = 0 And año Mod 100 = 0 And año Mod 400 <> 0 Then
                    MessageBox.Show("28")
                End If
            Case 3
                MessageBox.Show("31")
            Case 4
                MessageBox.Show("30")
            Case 5
                MessageBox.Show("31")
            Case 6
                MessageBox.Show("30")
            Case 7
                MessageBox.Show("31")
            Case 8
                MessageBox.Show("31")
            Case 9
                MessageBox.Show("30")
            Case 10
                MessageBox.Show("31")
            Case 11
                MessageBox.Show("30")
            Case 12
                MessageBox.Show("31")
        End Select

    End Sub
End Class