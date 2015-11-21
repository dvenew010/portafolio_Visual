<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtt1 = New System.Windows.Forms.TextBox()
        Me.txt1 = New System.Windows.Forms.MaskedTextBox()
        Me.cb3 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt5 = New System.Windows.Forms.MaskedTextBox()
        Me.cb2 = New System.Windows.Forms.ComboBox()
        Me.cb1 = New System.Windows.Forms.ComboBox()
        Me.txt8 = New System.Windows.Forms.TextBox()
        Me.txt7 = New System.Windows.Forms.TextBox()
        Me.txt6 = New System.Windows.Forms.TextBox()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.bt_anu = New System.Windows.Forms.Button()
        Me.bt_vol = New System.Windows.Forms.Button()
        Me.bt_edit = New System.Windows.Forms.Button()
        Me.bt_elim = New System.Windows.Forms.Button()
        Me.bt_grabar = New System.Windows.Forms.Button()
        Me.tx_fe = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtt1)
        Me.Panel1.Controls.Add(Me.txt1)
        Me.Panel1.Controls.Add(Me.cb3)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txt5)
        Me.Panel1.Controls.Add(Me.cb2)
        Me.Panel1.Controls.Add(Me.cb1)
        Me.Panel1.Controls.Add(Me.txt8)
        Me.Panel1.Controls.Add(Me.txt7)
        Me.Panel1.Controls.Add(Me.txt6)
        Me.Panel1.Controls.Add(Me.txt4)
        Me.Panel1.Controls.Add(Me.txt3)
        Me.Panel1.Controls.Add(Me.txt2)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(56, 153)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 355)
        Me.Panel1.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(173, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(10, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "-"
        '
        'txtt1
        '
        Me.txtt1.Location = New System.Drawing.Point(183, 11)
        Me.txtt1.Name = "txtt1"
        Me.txtt1.Size = New System.Drawing.Size(16, 20)
        Me.txtt1.TabIndex = 22
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(106, 11)
        Me.txt1.Mask = "00,000,000"
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(66, 20)
        Me.txt1.TabIndex = 1
        '
        'cb3
        '
        Me.cb3.FormattingEnabled = True
        Me.cb3.Location = New System.Drawing.Point(106, 221)
        Me.cb3.Name = "cb3"
        Me.cb3.Size = New System.Drawing.Size(182, 21)
        Me.cb3.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(25, 229)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "REGION"
        '
        'txt5
        '
        Me.txt5.Location = New System.Drawing.Point(162, 131)
        Me.txt5.Mask = "00/00/0000"
        Me.txt5.Name = "txt5"
        Me.txt5.Size = New System.Drawing.Size(100, 20)
        Me.txt5.TabIndex = 19
        Me.txt5.ValidatingType = GetType(Date)
        '
        'cb2
        '
        Me.cb2.FormattingEnabled = True
        Me.cb2.Location = New System.Drawing.Point(106, 252)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(182, 21)
        Me.cb2.TabIndex = 18
        '
        'cb1
        '
        Me.cb1.DisplayMember = "F"
        Me.cb1.FormattingEnabled = True
        Me.cb1.Items.AddRange(New Object() {"F", "M"})
        Me.cb1.Location = New System.Drawing.Point(106, 160)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(53, 21)
        Me.cb1.TabIndex = 17
        '
        'txt8
        '
        Me.txt8.Location = New System.Drawing.Point(106, 313)
        Me.txt8.Name = "txt8"
        Me.txt8.Size = New System.Drawing.Size(94, 20)
        Me.txt8.TabIndex = 16
        '
        'txt7
        '
        Me.txt7.Location = New System.Drawing.Point(106, 283)
        Me.txt7.Name = "txt7"
        Me.txt7.Size = New System.Drawing.Size(182, 20)
        Me.txt7.TabIndex = 15
        '
        'txt6
        '
        Me.txt6.Location = New System.Drawing.Point(106, 191)
        Me.txt6.Name = "txt6"
        Me.txt6.Size = New System.Drawing.Size(182, 20)
        Me.txt6.TabIndex = 14
        '
        'txt4
        '
        Me.txt4.Location = New System.Drawing.Point(162, 101)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(175, 20)
        Me.txt4.TabIndex = 13
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(162, 71)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(175, 20)
        Me.txt3.TabIndex = 12
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(106, 41)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(182, 20)
        Me.txt2.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(25, 320)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "TELEFONO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(25, 290)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "DIRECCION"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "COMUNA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "CORREO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "SEXO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "FECHA NACIMIENTO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "APELLIDO MATERNO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "APELLIDO PATERNO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NOMBRE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RUT"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Location = New System.Drawing.Point(160, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(328, 70)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Location = New System.Drawing.Point(56, 90)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(553, 47)
        Me.Panel3.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(62, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(370, 29)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "MANTENEDOR DE CLIENTES"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.bt_anu)
        Me.Panel4.Controls.Add(Me.bt_vol)
        Me.Panel4.Controls.Add(Me.bt_edit)
        Me.Panel4.Controls.Add(Me.bt_elim)
        Me.Panel4.Controls.Add(Me.bt_grabar)
        Me.Panel4.Location = New System.Drawing.Point(488, 153)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(121, 316)
        Me.Panel4.TabIndex = 5
        '
        'bt_anu
        '
        Me.bt_anu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_anu.Location = New System.Drawing.Point(21, 185)
        Me.bt_anu.Name = "bt_anu"
        Me.bt_anu.Size = New System.Drawing.Size(81, 38)
        Me.bt_anu.TabIndex = 4
        Me.bt_anu.Text = "ANULAR"
        Me.bt_anu.UseVisualStyleBackColor = True
        '
        'bt_vol
        '
        Me.bt_vol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_vol.Location = New System.Drawing.Point(21, 259)
        Me.bt_vol.Name = "bt_vol"
        Me.bt_vol.Size = New System.Drawing.Size(81, 42)
        Me.bt_vol.TabIndex = 3
        Me.bt_vol.Text = "VOLVER"
        Me.bt_vol.UseVisualStyleBackColor = True
        '
        'bt_edit
        '
        Me.bt_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_edit.Location = New System.Drawing.Point(21, 131)
        Me.bt_edit.Name = "bt_edit"
        Me.bt_edit.Size = New System.Drawing.Size(81, 42)
        Me.bt_edit.TabIndex = 2
        Me.bt_edit.Text = "EDITAR"
        Me.bt_edit.UseVisualStyleBackColor = True
        '
        'bt_elim
        '
        Me.bt_elim.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_elim.Location = New System.Drawing.Point(21, 78)
        Me.bt_elim.Name = "bt_elim"
        Me.bt_elim.Size = New System.Drawing.Size(81, 42)
        Me.bt_elim.TabIndex = 1
        Me.bt_elim.Text = "ELIMINAR"
        Me.bt_elim.UseVisualStyleBackColor = True
        '
        'bt_grabar
        '
        Me.bt_grabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_grabar.Location = New System.Drawing.Point(21, 19)
        Me.bt_grabar.Name = "bt_grabar"
        Me.bt_grabar.Size = New System.Drawing.Size(81, 42)
        Me.bt_grabar.TabIndex = 0
        Me.bt_grabar.Text = "GRABAR"
        Me.bt_grabar.UseVisualStyleBackColor = True
        '
        'tx_fe
        '
        Me.tx_fe.BackColor = System.Drawing.SystemColors.MenuBar
        Me.tx_fe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tx_fe.Location = New System.Drawing.Point(488, 486)
        Me.tx_fe.Name = "tx_fe"
        Me.tx_fe.Size = New System.Drawing.Size(101, 13)
        Me.tx_fe.TabIndex = 6
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 520)
        Me.Controls.Add(Me.tx_fe)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(50, 100)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "CLIENTE"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt5 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cb2 As System.Windows.Forms.ComboBox
    Friend WithEvents cb1 As System.Windows.Forms.ComboBox
    Friend WithEvents txt8 As System.Windows.Forms.TextBox
    Friend WithEvents txt7 As System.Windows.Forms.TextBox
    Friend WithEvents txt6 As System.Windows.Forms.TextBox
    Friend WithEvents txt4 As System.Windows.Forms.TextBox
    Friend WithEvents txt3 As System.Windows.Forms.TextBox
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents bt_vol As System.Windows.Forms.Button
    Friend WithEvents bt_edit As System.Windows.Forms.Button
    Friend WithEvents bt_elim As System.Windows.Forms.Button
    Friend WithEvents bt_grabar As System.Windows.Forms.Button
    Friend WithEvents bt_anu As System.Windows.Forms.Button
    Friend WithEvents cb3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tx_fe As System.Windows.Forms.TextBox
    Friend WithEvents txt1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtt1 As System.Windows.Forms.TextBox
End Class
