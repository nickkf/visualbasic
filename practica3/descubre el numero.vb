Public Class Form2
    Const NUM As Integer = 7
    Const INTENTOSMAX As Integer = 3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim n As Integer
        Dim intentos As Integer = 0
        Dim acertado As Boolean = False


        Do
            n = InputBox("QUIERO JUGAR A UN JUEGO. ADIVINA EL NUMERO O MUERE, ¡BELLACO!")
            If (n = NUM) Then
                acertado = True
                Exit Do
            End If

            intentos = intentos + 1

        Loop Until (intentos = INTENTOSMAX)

        If (acertado) Then
            MessageBox.Show("¡¡¡QUE POTRA QUE HAS TENIDO!!!")
        Else
            MessageBox.Show("¡¡¡DIE POTATO!!!")
        End If

    End Sub
End Class