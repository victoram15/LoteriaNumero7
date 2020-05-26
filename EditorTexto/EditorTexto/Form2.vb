''' <summary>
''' Esta clase es un formulario secundario que surge para solo aportar información sobre el programa.
''' </summary>
''' <remarks></remarks>

Public Class Form2

    ''' <summary>
    ''' Este método hará que salgamos del formulario al hacer click sobre el botón.
    ''' </summary>
    ''' <param name="sender">Es el objeto sobre el que se produce el evento.</param>
    ''' <param name="e">Son datos externos adicionales del objeto evento.</param>
    ''' <remarks></remarks>
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Close()

    End Sub
End Class