
''' <summary>
''' En esta clase es un formulario en el que se recogen todos los métodos que intervienen en el funcionamiento del programa.
''' Contiene todas las opciones que el usuario puede usar.
''' </summary>
''' <remarks></remarks>

Public Class Form1



    'Al abrir el editor, los botones Copiar y Pegar estarán deshabilitados hasta que se seleccione el texto

    ''' <summary>
    ''' Este método se encarga de que cuando se cargue el formulario, los botones copiar y pegar esten deshabilitados.
    ''' </summary>
    ''' <param name="sender">Es el objeto sobre el que se produce el evento.</param>
    ''' <param name="e">Son datos externos adicionales del objeto evento.</param>
    ''' <remarks></remarks>
    Private Sub cargarFormulario(sender As Object, e As EventArgs) Handles MyBase.Load
        CopiarToolStripMenuItem.Enabled = False
        PegarToolStripMenuItem.Enabled = False
    End Sub

    ''' <summary>
    ''' Este método se encarga de que cuando no haya nada escrito, los botones copiar y pegar estén deshanilitados.
    ''' En cambio, cuando se empiece a escribir, que estos botones se habiliten.
    ''' </summary>
    ''' <param name="sender">Es el objeto sobre el que se produce el evento.</param>
    ''' <param name="e">Son datos externos adicionales del ratón.</param>
    ''' <remarks></remarks>
    Private Sub rchTxtBox_MouseUp(sender As Object, e As MouseEventArgs) Handles rchTxtBox.MouseUp
        If (rchTxtBox.SelectedText <> "") Then
            CopiarToolStripMenuItem.Enabled = True
            PegarToolStripMenuItem.Enabled = True
        End If
    End Sub



    'MENU ARCHIVO

    'Guardar y Guardar como

    ''' <summary>
    ''' Este método nos permitirá guardar el archivo que hayamos escrito o editado.
    ''' </summary>
    ''' <param name="sender">Es el objeto sobre el que se produce el evento.</param>
    ''' <param name="e">Son datos externos adicionales del objeto evento.</param>
    ''' <remarks></remarks>
    Private Sub guardarMnu_Click(sender As Object, e As EventArgs) Handles guardarMnu.Click, GuardarComoMnu.Click

        Dim dlgGuardar As SaveFileDialog = New SaveFileDialog

        dlgGuardar.Filter = "Documento (*.doc) |*.doc|Texto (*.txt) |*.txt"
        dlgGuardar.ShowDialog()

        Dim swEscritor As IO.StreamWriter
        swEscritor = New IO.StreamWriter(dlgGuardar.FileName)
        swEscritor.Write(rchTxtBox.Text)

        swEscritor.Close()

        MessageBox.Show("Texto grabado en archivo")

    End Sub

    'Nuevo
    ''' <summary>
    ''' El método nuevoDocumento nos refrescará la caja de texto para empezar un nuevo documento.
    ''' </summary>
    ''' <param name="sender">Es el objeto sobre el que se produce el evento.</param>
    ''' <param name="e">Son datos externos adicionales del objeto evento.</param>
    ''' <remarks></remarks>
    Private Sub nuevoDocumento(sender As Object, e As EventArgs) Handles opcionNuevo.Click
        rchTxtBox.Clear()
    End Sub


    'Abrir archivo
    ''' <summary>
    ''' Este método nos permitirá abrir un archivo, abriendo una ventana para poder seleccionar el archivo.
    ''' </summary>
    ''' <param name="sender">Es el objeto sobre el que se produce el evento.</param>
    ''' <param name="e">Son datos externos adicionales del objeto evento.</param>
    ''' <remarks></remarks>
    Private Sub abrirArchivo(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click

        Dim dlgAbrir As OpenFileDialog = New OpenFileDialog

        dlgAbrir.ShowDialog()

        If dlgAbrir.FileNames.Length > 1 Then
            Dim sArchivo As String

            For Each sArchivo In dlgAbrir.FileNames
                MessageBox.Show("Archivo seleccionado: " & sArchivo)
            Next
        End If

        Dim srLector As IO.StreamReader = New IO.StreamReader(dlgAbrir.FileName)
        rchTxtBox.Text = srLector.ReadToEnd()

    End Sub



    'Salir
    ''' <summary>
    ''' Este método hace que se cierre el formulario.
    ''' </summary>
    ''' <param name="sender">Es el objeto sobre el que se produce el evento.</param>
    ''' <param name="e">Son datos externos adicionales del objeto evento.</param>
    ''' <remarks></remarks>
    Private Sub salir(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Close()
    End Sub

    'MENU EDICION
    ''' <summary>
    ''' Este método copia el texto seleccionado.
    ''' </summary>
    ''' <param name="sender">Es el objeto sobre el que se produce el evento.</param>
    ''' <param name="e">Son datos externos adicionales del objeto evento.</param>
    ''' <remarks></remarks>
    Private Sub copiar(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        rchTxtBox.Copy()

    End Sub

    ''' <summary>
    ''' Este método pega el texto copiado previamente.
    ''' </summary>
    ''' <param name="sender">Es el objeto sobre el que se produce el evento.</param>
    ''' <param name="e">Son datos externos adicionales del objeto evento.</param>
    ''' <remarks></remarks>
    Private Sub pegar(sender As Object, e As EventArgs) Handles PegarToolStripMenuItem.Click
        rchTxtBox.Paste()
    End Sub

    ''' <summary>
    ''' El método cortar nos cortará el texto que seleccionemos.
    ''' </summary>
    ''' <param name="sender">Es el objeto sobre el que se produce el evento.</param>
    ''' <param name="e">Son datos externos adicionales del objeto evento.</param>
    ''' <remarks></remarks>
    Private Sub cortar(sender As Object, e As EventArgs) Handles CortarToolStripMenuItem.Click
        rchTxtBox.Cut()
    End Sub


    'MENU ESTILO, el menú Tamaño no lo he incluido porque FontDialog ya contiene la opción de cambiar el tamaño de la fuente.

    'Tipo de fuente
    ''' <summary>
    ''' El método tipoFuente nos abrirá una ventana con los tipos de fuentes, y al seleccionar alguna, se asginará esa fuente.
    ''' </summary>
    ''' <param name="sender">Es el objeto sobre el que se produce el evento.</param>
    ''' <param name="e">Son datos externos adicionales del objeto evento.</param>
    ''' <remarks></remarks>
    Private Sub tipoFuente(sender As Object, e As EventArgs) Handles MnuFuente.Click

        Dim dlgFuente As FontDialog = New FontDialog

        dlgFuente.ShowDialog()
        rchTxtBox.Font = dlgFuente.Font

    End Sub

    'Color de la fuente
    ''' <summary>
    ''' Este método nos abrirá una ventana con colores a elegir para nuestra fuente.
    ''' </summary>
    ''' <param name="sender">Es el objeto sobre el que se produce el evento.</param>
    ''' <param name="e">Son datos externos adicionales del objeto evento.</param>
    ''' <remarks></remarks>
    Private Sub colorFuente(sender As Object, e As EventArgs) Handles ColorTextoToolStripMenuItem.Click

        Dim dlgColor As ColorDialog = New ColorDialog

        dlgColor.ShowDialog()
        rchTxtBox.ForeColor = dlgColor.Color

    End Sub

    'Color del fondo
    ''' <summary>
    ''' Este método nos abre una ventana con varios colores a elegir para asignárselo al fondo.
    ''' </summary>
    ''' <param name="sender">Es el objeto sobre el que se produce el evento.</param>
    ''' <param name="e">Son datos externos adicionales del objeto evento.</param>
    ''' <remarks></remarks>
    Private Sub colorFondo(sender As Object, e As EventArgs) Handles ColorFondoToolStripMenuItem.Click

        Dim dlgColorFondo As ColorDialog = New ColorDialog

        dlgColorFondo.ShowDialog()
        rchTxtBox.BackColor = dlgColorFondo.Color

    End Sub

    'Manejador del boton "Acerca de..." para abrir el Form2
    ''' <summary>
    ''' Este método nos llevará al siguiente formulario al hacer click.
    ''' </summary>
    ''' <param name="sender">Es el objeto sobre el que se produce el evento.</param>
    ''' <param name="e">Son datos externos adicionales del objeto evento.</param>
    ''' <remarks></remarks>
    Private Sub btnForm2(sender As Object, e As EventArgs) Handles btnAcercaDe.Click
        Form2.Show()
    End Sub










End Class
