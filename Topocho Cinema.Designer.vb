<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Declaración de controles
    Private components As System.ComponentModel.IContainer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnGenerarBoleto As Button
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents txtSala As TextBox
    Friend WithEvents txtPuesto As TextBox
    Friend WithEvents txtHoraFuncion As TextBox
    Friend WithEvents txtPelicula As TextBox
    Friend WithEvents rtbBoleto As RichTextBox

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnGenerarBoleto = New System.Windows.Forms.Button()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.txtSala = New System.Windows.Forms.TextBox()
        Me.txtPuesto = New System.Windows.Forms.TextBox()
        Me.txtHoraFuncion = New System.Windows.Forms.TextBox()
        Me.txtPelicula = New System.Windows.Forms.TextBox()
        Me.rtbBoleto = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.IndianRed
        Me.Label1.Font = New System.Drawing.Font("Broadway", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Tan
        Me.Label1.Location = New System.Drawing.Point(41, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(624, 72)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Topocho Cinema"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nombres:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(86, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Sala:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(206, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Nombre de la Película:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(400, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Número de cédula:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(47, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Apellidos:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(390, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(179, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Hora de la Función:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(494, 218)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Puesto:"
        '
        'btnGenerarBoleto
        '
        Me.btnGenerarBoleto.Location = New System.Drawing.Point(365, 535)
        Me.btnGenerarBoleto.Name = "btnGenerarBoleto"
        Me.btnGenerarBoleto.Size = New System.Drawing.Size(106, 53)
        Me.btnGenerarBoleto.TabIndex = 25
        Me.btnGenerarBoleto.Text = "Generar Boleto"
        Me.btnGenerarBoleto.UseVisualStyleBackColor = True
        '
        'txtNombres
        '
        Me.txtNombres.BackColor = System.Drawing.Color.IndianRed
        Me.txtNombres.Location = New System.Drawing.Point(152, 126)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(200, 20)
        Me.txtNombres.TabIndex = 17
        '
        'txtApellidos
        '
        Me.txtApellidos.BackColor = System.Drawing.Color.IndianRed
        Me.txtApellidos.Location = New System.Drawing.Point(152, 175)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(200, 20)
        Me.txtApellidos.TabIndex = 18
        '
        'txtCedula
        '
        Me.txtCedula.BackColor = System.Drawing.Color.IndianRed
        Me.txtCedula.Location = New System.Drawing.Point(580, 126)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(200, 20)
        Me.txtCedula.TabIndex = 19
        '
        'txtSala
        '
        Me.txtSala.BackColor = System.Drawing.Color.IndianRed
        Me.txtSala.Location = New System.Drawing.Point(152, 218)
        Me.txtSala.Name = "txtSala"
        Me.txtSala.Size = New System.Drawing.Size(200, 20)
        Me.txtSala.TabIndex = 20
        '
        'txtPuesto
        '
        Me.txtPuesto.BackColor = System.Drawing.Color.IndianRed
        Me.txtPuesto.Location = New System.Drawing.Point(580, 215)
        Me.txtPuesto.Name = "txtPuesto"
        Me.txtPuesto.Size = New System.Drawing.Size(200, 20)
        Me.txtPuesto.TabIndex = 21
        '
        'txtHoraFuncion
        '
        Me.txtHoraFuncion.BackColor = System.Drawing.Color.IndianRed
        Me.txtHoraFuncion.Location = New System.Drawing.Point(580, 172)
        Me.txtHoraFuncion.Name = "txtHoraFuncion"
        Me.txtHoraFuncion.Size = New System.Drawing.Size(200, 20)
        Me.txtHoraFuncion.TabIndex = 22
        '
        'txtPelicula
        '
        Me.txtPelicula.BackColor = System.Drawing.Color.IndianRed
        Me.txtPelicula.Location = New System.Drawing.Point(262, 255)
        Me.txtPelicula.Name = "txtPelicula"
        Me.txtPelicula.Size = New System.Drawing.Size(200, 20)
        Me.txtPelicula.TabIndex = 23
        '
        'rtbBoleto
        '
        Me.rtbBoleto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.rtbBoleto.Location = New System.Drawing.Point(50, 295)
        Me.rtbBoleto.Name = "rtbBoleto"
        Me.rtbBoleto.Size = New System.Drawing.Size(700, 200)
        Me.rtbBoleto.TabIndex = 24
        Me.rtbBoleto.Text = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.boleteria_de_cine.My.Resources.Resources.istockphoto_1087878984_612x6122
        Me.PictureBox1.Location = New System.Drawing.Point(682, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(98, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Goldenrod
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(800, 600)
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Goldenrod
        Me.PictureBox3.Image = Global.boleteria_de_cine.My.Resources.Resources.png_clipart_clapperboard_film_director_clapper_board_angle_white_thumbnail
        Me.PictureBox3.Location = New System.Drawing.Point(327, 501)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(177, 87)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 29
        Me.PictureBox3.TabStop = False
        '
        'Form1
        '
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.btnGenerarBoleto)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.rtbBoleto)
        Me.Controls.Add(Me.txtPelicula)
        Me.Controls.Add(Me.txtHoraFuncion)
        Me.Controls.Add(Me.txtPuesto)
        Me.Controls.Add(Me.txtSala)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "Form1"
        Me.Text = "Boletería de Cine"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
