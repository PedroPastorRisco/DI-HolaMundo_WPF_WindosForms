Public Class HolaMundo
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Hola " + txtNombre.Text)

    End Sub

    Private Sub HolaMundo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
