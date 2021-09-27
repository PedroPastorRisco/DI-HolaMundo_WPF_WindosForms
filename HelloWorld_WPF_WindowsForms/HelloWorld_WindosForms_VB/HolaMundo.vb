Imports MisClases
Public Class HolaMundo
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oPersona As clsPersona
        If (String.IsNullOrEmpty(txtNombre.Text)) Then
            MessageBox.Show("No dejes el campo en blanco que mi mami se enfada")
        Else
            oPersona = New clsPersona(txtNombre.Text)
            MessageBox.Show("Hola " + oPersona.Nombre)
        End If
    End Sub
End Class
