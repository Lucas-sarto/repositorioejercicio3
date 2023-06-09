Public Class Form1

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMenor.Click

    End Sub

    Private Sub cmdEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEjecutar.Click
        Dim a As Integer
        Dim b As Integer
        Dim suma As Integer
        Dim mayor As Integer
        Dim menor As Integer
        a = InputBox("Ingresar un numero", "Ingrese a")
        Do
            suma = suma + b
            b = InputBox("Ingresar un numero", "Ingrese b")
            If mayor < b Then
                mayor = b
            Else
                If b <> -999 Then
                    If b < menor Then
                        menor = b

                    End If
                    b = b
                End If
            End If
        Loop Until b = -999
        lblMayor.Text = "El mayor es " & mayor
        lblMenor.Text = "El menor es " & menor
        lblSuma.Text = "La suma es " & suma
    End Sub
End Class
