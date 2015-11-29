<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class acceso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(acceso))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MANTENEDORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pacceso = New System.Windows.Forms.Panel()
        Me.bt_sal = New System.Windows.Forms.Button()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.btn = New System.Windows.Forms.Button()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.pacceso.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MANTENEDORToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(804, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MANTENEDORToolStripMenuItem
        '
        Me.MANTENEDORToolStripMenuItem.Name = "MANTENEDORToolStripMenuItem"
        Me.MANTENEDORToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.MANTENEDORToolStripMenuItem.Text = "MANTENEDOR "
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'pacceso
        '
        Me.pacceso.Controls.Add(Me.bt_sal)
        Me.pacceso.Controls.Add(Me.txt2)
        Me.pacceso.Controls.Add(Me.btn)
        Me.pacceso.Controls.Add(Me.txt1)
        Me.pacceso.Controls.Add(Me.Label3)
        Me.pacceso.Controls.Add(Me.Label2)
        Me.pacceso.Controls.Add(Me.Label1)
        Me.pacceso.Location = New System.Drawing.Point(107, 59)
        Me.pacceso.Name = "pacceso"
        Me.pacceso.Size = New System.Drawing.Size(591, 280)
        Me.pacceso.TabIndex = 2
        '
        'bt_sal
        '
        Me.bt_sal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_sal.Location = New System.Drawing.Point(339, 218)
        Me.bt_sal.Name = "bt_sal"
        Me.bt_sal.Size = New System.Drawing.Size(160, 35)
        Me.bt_sal.TabIndex = 4
        Me.bt_sal.Text = "ANULAR"
        Me.bt_sal.UseVisualStyleBackColor = True
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(263, 163)
        Me.txt2.Name = "txt2"
        Me.txt2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt2.Size = New System.Drawing.Size(181, 20)
        Me.txt2.TabIndex = 2
        '
        'btn
        '
        Me.btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn.Location = New System.Drawing.Point(143, 220)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(174, 34)
        Me.btn.TabIndex = 3
        Me.btn.Text = "ACCEDER"
        Me.btn.UseVisualStyleBackColor = True
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(262, 113)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(182, 20)
        Me.txt1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(165, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "VERIFICA ACCESO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(140, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PASSWORD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(140, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USUARIO"
        '
        'acceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(804, 399)
        Me.Controls.Add(Me.pacceso)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "acceso"
        Me.Text = "AUTENTIFICACION DE USUARIO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pacceso.ResumeLayout(False)
        Me.pacceso.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MANTENEDORToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pacceso As System.Windows.Forms.Panel
    Friend WithEvents btn As System.Windows.Forms.Button
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents bt_sal As System.Windows.Forms.Button
End Class
