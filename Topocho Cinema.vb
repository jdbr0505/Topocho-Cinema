Public Class Form1 'Aqui creamos una nueva clase para manejar los eventos y la lógica de la pagina'
    Private Sub btnGenerarBoleto_Click(sender As Object, e As EventArgs) Handles btnGenerarBoleto.Click 'Aqui activamos el proceso que se hacer despues de hacer click del boton de "Generar Boleto en la pagina"
        Dim nombres As String = txtNombres.Text  'Obtener el texto del campo de los nombres'
        Dim apellidos As String = txtApellidos.Text
        Dim cedula As String = txtCedula.Text
        Dim sala As String = txtSala.Text
        Dim puesto As String = txtPuesto.Text
        Dim horaFuncion As String = txtHoraFuncion.Text
        Dim pelicula As String = txtPelicula.Text

        'Con esta condicional lo que hacemos es validar que todos los campos están llenos, sino habra otra un mensaje que diga que hubo un error'
        If String.IsNullOrWhiteSpace(nombres) OrElse
           String.IsNullOrWhiteSpace(apellidos) OrElse
           String.IsNullOrWhiteSpace(cedula) OrElse
           String.IsNullOrWhiteSpace(sala) OrElse
           String.IsNullOrWhiteSpace(puesto) OrElse
           String.IsNullOrWhiteSpace(horaFuncion) OrElse
           String.IsNullOrWhiteSpace(pelicula) Then

            'Aqui mostramos mensaje de error si algún campo está vacío'
            MessageBox.Show("Error al ingresar los datos requeridos. Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else



            rtbBoleto.Text = "Boleto de Cine" & Environment.NewLine &  'Generamos el texto del boleto de cine'
                          "----------------------------------" & Environment.NewLine &
                          "Nombres: " & nombres & Environment.NewLine &
                          "Apellidos: " & apellidos & Environment.NewLine &
                          "Número de Cédula: " & cedula & Environment.NewLine &
                          "Sala: " & sala & Environment.NewLine &
                          "Puesto: " & puesto & Environment.NewLine &
                          "Hora de la Función: " & horaFuncion & Environment.NewLine &
                          "Nombre de la Película: " & pelicula
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click  'Aqui aplicamos esto por el evento para manejar click'

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click 'Y lo hacemos con los textos tambien'

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class 'Y cerramos esta clase para hora asi tener listo el proceso de la boleteria'



