<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        lblPrecioVentaImporte = New Label()
        lblImporteCosto = New Label()
        lblPrecioDeVenta = New Label()
        lblCosto = New Label()
        lblCantidadDisponible = New Label()
        lblDescripcion = New Label()
        txtNumProducto = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        MenuStrip1 = New MenuStrip()
        BuscarProductoToolStripMenuItem = New ToolStripMenuItem()
        CalcularTotalesToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        GroupBox2 = New GroupBox()
        lblTotalInventarioPrecioVenta = New Label()
        lblTotalInventarioCosto = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label10 = New Label()
        ofdOpenFile = New OpenFileDialog()
        GroupBox1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Beige
        GroupBox1.Controls.Add(lblPrecioVentaImporte)
        GroupBox1.Controls.Add(lblImporteCosto)
        GroupBox1.Controls.Add(lblPrecioDeVenta)
        GroupBox1.Controls.Add(lblCosto)
        GroupBox1.Controls.Add(lblCantidadDisponible)
        GroupBox1.Controls.Add(lblDescripcion)
        GroupBox1.Controls.Add(txtNumProducto)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.ForeColor = Color.Black
        GroupBox1.Location = New Point(426, 52)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(342, 313)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Información producto ingresado"
        ' 
        ' lblPrecioVentaImporte
        ' 
        lblPrecioVentaImporte.BorderStyle = BorderStyle.Fixed3D
        lblPrecioVentaImporte.Location = New Point(223, 267)
        lblPrecioVentaImporte.Name = "lblPrecioVentaImporte"
        lblPrecioVentaImporte.Size = New Size(105, 25)
        lblPrecioVentaImporte.TabIndex = 13
        ' 
        ' lblImporteCosto
        ' 
        lblImporteCosto.BorderStyle = BorderStyle.Fixed3D
        lblImporteCosto.Location = New Point(223, 232)
        lblImporteCosto.Name = "lblImporteCosto"
        lblImporteCosto.Size = New Size(105, 25)
        lblImporteCosto.TabIndex = 12
        ' 
        ' lblPrecioDeVenta
        ' 
        lblPrecioDeVenta.BorderStyle = BorderStyle.Fixed3D
        lblPrecioDeVenta.Location = New Point(223, 194)
        lblPrecioDeVenta.Name = "lblPrecioDeVenta"
        lblPrecioDeVenta.Size = New Size(105, 25)
        lblPrecioDeVenta.TabIndex = 11
        ' 
        ' lblCosto
        ' 
        lblCosto.BorderStyle = BorderStyle.Fixed3D
        lblCosto.Location = New Point(223, 155)
        lblCosto.Name = "lblCosto"
        lblCosto.Size = New Size(105, 25)
        lblCosto.TabIndex = 10
        ' 
        ' lblCantidadDisponible
        ' 
        lblCantidadDisponible.BorderStyle = BorderStyle.Fixed3D
        lblCantidadDisponible.Location = New Point(223, 121)
        lblCantidadDisponible.Name = "lblCantidadDisponible"
        lblCantidadDisponible.Size = New Size(105, 25)
        lblCantidadDisponible.TabIndex = 9
        ' 
        ' lblDescripcion
        ' 
        lblDescripcion.BorderStyle = BorderStyle.Fixed3D
        lblDescripcion.Location = New Point(175, 80)
        lblDescripcion.Name = "lblDescripcion"
        lblDescripcion.Size = New Size(153, 25)
        lblDescripcion.TabIndex = 8
        ' 
        ' txtNumProducto
        ' 
        txtNumProducto.Location = New Point(230, 41)
        txtNumProducto.Name = "txtNumProducto"
        txtNumProducto.Size = New Size(98, 27)
        txtNumProducto.TabIndex = 7
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(25, 272)
        Label7.Name = "Label7"
        Label7.Size = New Size(181, 20)
        Label7.TabIndex = 6
        Label7.Text = "Importe (Precio de venta):"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(25, 232)
        Label6.Name = "Label6"
        Label6.Size = New Size(117, 20)
        Label6.TabIndex = 5
        Label6.Text = "Importe (Costo):"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(25, 194)
        Label5.Name = "Label5"
        Label5.Size = New Size(114, 20)
        Label5.TabIndex = 4
        Label5.Text = "Precio de venta:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(25, 160)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 20)
        Label4.TabIndex = 3
        Label4.Text = "Costo:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(25, 126)
        Label3.Name = "Label3"
        Label3.Size = New Size(146, 20)
        Label3.TabIndex = 2
        Label3.Text = "Cantidad disponible:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(25, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 20)
        Label2.TabIndex = 1
        Label2.Text = "Descripción:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(25, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(152, 20)
        Label1.TabIndex = 0
        Label1.Text = "Número de producto:"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {BuscarProductoToolStripMenuItem, CalcularTotalesToolStripMenuItem, SalirToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' BuscarProductoToolStripMenuItem
        ' 
        BuscarProductoToolStripMenuItem.Name = "BuscarProductoToolStripMenuItem"
        BuscarProductoToolStripMenuItem.Size = New Size(131, 24)
        BuscarProductoToolStripMenuItem.Text = "Buscar producto"
        ' 
        ' CalcularTotalesToolStripMenuItem
        ' 
        CalcularTotalesToolStripMenuItem.Name = "CalcularTotalesToolStripMenuItem"
        CalcularTotalesToolStripMenuItem.Size = New Size(125, 24)
        CalcularTotalesToolStripMenuItem.Text = "Calcular totales"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(52, 24)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Letter_K_Transparent_Background_PNG
        PictureBox1.Location = New Point(119, 96)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(169, 152)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(lblTotalInventarioPrecioVenta)
        GroupBox2.Controls.Add(lblTotalInventarioCosto)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Location = New Point(12, 274)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(395, 91)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Todo el inventario"
        ' 
        ' lblTotalInventarioPrecioVenta
        ' 
        lblTotalInventarioPrecioVenta.BorderStyle = BorderStyle.Fixed3D
        lblTotalInventarioPrecioVenta.Location = New Point(271, 54)
        lblTotalInventarioPrecioVenta.Name = "lblTotalInventarioPrecioVenta"
        lblTotalInventarioPrecioVenta.Size = New Size(105, 25)
        lblTotalInventarioPrecioVenta.TabIndex = 16
        ' 
        ' lblTotalInventarioCosto
        ' 
        lblTotalInventarioCosto.BorderStyle = BorderStyle.Fixed3D
        lblTotalInventarioCosto.Location = New Point(271, 18)
        lblTotalInventarioCosto.Name = "lblTotalInventarioCosto"
        lblTotalInventarioCosto.Size = New Size(105, 25)
        lblTotalInventarioCosto.TabIndex = 14
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(26, 59)
        Label9.Name = "Label9"
        Label9.Size = New Size(231, 20)
        Label9.TabIndex = 15
        Label9.Text = "Total Inventario (Precio de venta):"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(26, 23)
        Label8.Name = "Label8"
        Label8.Size = New Size(167, 20)
        Label8.TabIndex = 14
        Label8.Text = "Total Inventario (Costo):"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Script MT Bold", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(49, 45)
        Label10.Name = "Label10"
        Label10.Size = New Size(308, 48)
        Label10.TabIndex = 4
        Label10.Text = "Kiara Auto Parts"
        ' 
        ' ofdOpenFile
        ' 
        ofdOpenFile.FileName = "ProductDataSICI3255FinalProject"
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 395)
        Controls.Add(Label10)
        Controls.Add(GroupBox2)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "frmMain"
        Text = "Inventario"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumProducto As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblCantidadDisponible As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BuscarProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalcularTotalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblCosto As Label
    Friend WithEvents lblPrecioVentaImporte As Label
    Friend WithEvents lblImporteCosto As Label
    Friend WithEvents lblPrecioDeVenta As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTotalInventarioCosto As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblTotalInventarioPrecioVenta As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ofdOpenFile As OpenFileDialog
End Class
