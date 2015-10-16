Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1 As Integer
        Dim n2 As Integer
        Dim n3 As Integer
        Dim result As String = ""




        n1 = CInt(TextBox1.Text())
        n2 = CInt(TextBox2.Text())
        n3 = CInt(TextBox3.Text())


        If n1 > n2 And n2 > n3 Then
            result = n1.ToString() + "-" + n2.ToString() + "-" + n3.ToString()
        ElseIf n1 > n3 And n3 > n2 Then
            result = n1.ToString() + "-" + n3.ToString() + "-" + n2.ToString()
        ElseIf n2 > n1 And n1 > n3 Then
            result = n2.ToString() + "-" + n1.ToString() + "-" + n3.ToString()
        ElseIf n2 > n3 And n3 > n1 Then
            result = n2.ToString() + "-" + n3.ToString() + "-" + n1.ToString()
        ElseIf n3 > n1 And n1 > n2 Then
            result = n3.ToString() + "-" + n1.ToString() + "-" + n2.ToString()
        ElseIf n3 > n2 And n2 > n1 Then
            result = n3.ToString() + "-" + n2.ToString() + "-" + n1.ToString()

        End If


        TextBox4.Text = result.ToString()
    End Sub
End Class
