Imports System.Drawing.Text
Imports System.IO
Imports System.Security.Cryptography
Imports System.Windows.Forms.ComponentModel.Com2Interop
Imports SICI3255PFCruzFranceschiK.frmMain

Public Class frmMain
    Public Structure sInventory 'Estructura que se va a utilizar para el file
        Public strProductNumber As String
        Public strProductDescription As String
        Public intProductQuantity As Integer
        Public dblProductCost As Double
        Public dblProductMarkup As Double
    End Structure

    Public Inventory() As sInventory
    'Inicializar arreglo


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim frmSplash As New frmSplash
        frmSplash.ShowDialog()
        frmSplash.Close()
        'Ejecutar el splash

        Dim inputFile As StreamReader
        'Inicializar la variable inputFile que se utilizará para leer el documento

        With ofdOpenFile    'Ejecutar OpenFileDialog
            .Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            .InitialDirectory = "C:\Data"
            .Title = "Select a File to Open"
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                inputFile = File.OpenText(.FileName)
            Else    'Mensaje si no selecciona ningún documento
                MessageBox.Show("No seleccionaste ningún documento.")
            End If
        End With

        SortInventory(inputFile)
        'Ejecutar procedimiento para poner inputfile en arreglo

    End Sub

    Private Sub SortInventory(inputFile As StreamReader)
        'Procedimiento para poner los datos en un arreglo

        Dim lstLines As New List(Of String)
        'Crear una lista nueva

        Do Until inputFile.EndOfStream
            Dim line As String = inputFile.ReadLine()
            lstLines.Add(line)
            'Leer las líneas y ponerlas en una lista hasta que termine
        Loop

        ReDim Inventory(lstLines.Count - 1)
        'Ajustar el tamaño de arreglo


        For i As Integer = 0 To lstLines.Count - 1
            'Es un loop que se utilizará para clasificar de acuerdo a la estructura

            Dim values() As String = lstLines(i).Split(","c)
            'Usar método split para dividir los datos en cada línea (con ",")

            Inventory(i).strProductNumber = values(0).Trim()
            Inventory(i).strProductDescription = values(1).Trim()
            Inventory(i).intProductQuantity = Integer.Parse(values(2).Trim())
            Inventory(i).dblProductCost = Double.Parse(values(3).Trim())
            Inventory(i).dblProductMarkup = Double.Parse(values(4).Trim())
            'Dividir todos los valores en sus categorías respectivas del arreglo

        Next

    End Sub

    Private Sub BuscarProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarProductoToolStripMenuItem.Click

        Dim strSelectedProductNumber As String = txtNumProducto.Text
        'Inicializar la variable de caja de texto


        FindIndex(strSelectedProductNumber)
        'Ejecutar procedimiento para buscar datos

    End Sub


    Private Sub FindIndex(ByVal strSelectedProductNumber As String)
        'Procedimiento que busca el producto y sus datos con caja de texto

        Dim intIndex As Integer
        Dim blnProductFound As Boolean = False
        'Inicializar variables necesarias

        Do Until intIndex = Inventory.Length
            If Inventory(intIndex).strProductNumber = strSelectedProductNumber Then
                blnProductFound = True
                'Si el dato en indice coincide con el número en el textbox, se encontró el producto
                Exit Do
            End If

            intIndex += 1
            'Se añade uno si no se encontró el ID correcto 
        Loop

        If blnProductFound Then
            'Es un If que sucede cuando el product number coincide con la caja de texto

            Dim dblPrecioDeVenta As Double
            Dim dblPrecioDeImporte As Double
            Dim dblPrecioVentaUnidad As Double
            Dim dblCostoProducto As Double = Inventory(intIndex).dblProductCost
            Dim intCantidadProducto As Integer = Inventory(intIndex).intProductQuantity
            Dim dblMarkUpProducto As Double = Inventory(intIndex).dblProductMarkup

            'Se inicializaron las variables para los cálculos

            dblPrecioDeImporte = dblCostoProducto * intCantidadProducto
            'Fórmula para calcular el precio de importe
            dblPrecioDeVenta = (dblCostoProducto * (1 + dblMarkUpProducto) * intCantidadProducto)
            'Fórmula para calcular el precio de venta total de ese producto
            dblPrecioVentaUnidad = (dblCostoProducto * (1 + dblMarkUpProducto))
            'Fórmula para calcular el precio de venta por cada unidad


            lblDescripcion.Text = Inventory(intIndex).strProductDescription
            lblCantidadDisponible.Text = Inventory(intIndex).intProductQuantity.ToString()
            lblCosto.Text = Inventory(intIndex).dblProductCost.ToString("c2")
            lblPrecioDeVenta.Text = dblPrecioVentaUnidad.ToString("c2")
            lblPrecioVentaImporte.Text = dblPrecioDeVenta.ToString("c2")
            lblImporteCosto.Text = dblPrecioDeImporte.ToString("c2")
            'Se colocaron en los etiquetas los resultados de los cálculos

        ElseIf Not IsNumeric(txtNumProducto.Text) Then
            'Si ningún product number no coincide con la caja de texto,
            'se verifica que sea númerico.

            MessageBox.Show("El número de producto debe ser un valor númerico.")
        Else
            'Si el product number es númerico pero no coincide, se determina
            'que no está registrado
            MessageBox.Show("El número de producto no se encuentra registrado.")
            lblDescripcion.Text = String.Empty
        End If
    End Sub


    Private Sub CalcularTotalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularTotalesToolStripMenuItem.Click
        Dim totalPrecioDeVenta As Double = 0
        Dim totalPrecioDeImporte As Double = 0

        'Se inicializaron las variables acumuladoras de los cálculos

        ' Recorre cada elemento del arreglo Inventory
        For i As Integer = 0 To Inventory.Length - 1

            Dim precioDeImporte As Double = Inventory(i).dblProductCost * Inventory(i).intProductQuantity
            Dim precioDeVenta As Double = (Inventory(i).dblProductCost * (1 + Inventory(i).dblProductMarkup)) * Inventory(i).intProductQuantity
            'Se hizo un loop para descubrir el precio total de todo el inventario


            totalPrecioDeImporte += precioDeImporte
            totalPrecioDeVenta += precioDeVenta
            'Se acumularon los totales

        Next

        lblTotalInventarioCosto.Text = totalPrecioDeImporte.ToString("c2")
        lblTotalInventarioPrecioVenta.Text = totalPrecioDeVenta.ToString("c2")
        'Se mostraron los totales en rtiquetas


    End Sub


    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close() 'Se cierra la aplicación
    End Sub

End Class
