Public Class propiedades
    Dim sw_val As Integer
    Dim fecha As Date
    Public database As Odbc.OdbcConnection

    Private Sub propiedades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'posicion de los paneles
        pbo.Left = 12
        pbo.Top = 430
        pbo.Visible = False

        pes.Left = 12
        pes.Top = 430
        pes.Visible = False

        pof.Left = 12
        pof.Top = 430
        pof.Visible = False

        pca.Left = 9
        pca.Top = 430
        pca.Visible = False

        ped.Left = 12
        ped.Top = 430
        ped.Visible = False

        pa_grilla.Left = 12
        pa_grilla.Top = 100
        pa_grilla.Visible = False

        'llenado de los combobox tipo propiedad
        cbp_tip.Items.Add("BODEGA")
        cbp_tip.Items.Add("ESTACIONAMIENTO")
        cbp_tip.Items.Add("OFICINA")
        cbp_tip.Items.Add("CASA")
        cbp_tip.Items.Add("DEPARTAMENTO")
        'llenado de los combobox operacion
        cbp_op.Items.Add("VENTA")
        cbp_op.Items.Add("ARRIENDO")
        'llenado de los combobox regiones
        cbp_reg.Items.Add("I ARICA Y PARINACOTA")
        cbp_reg.Items.Add("II TARAPACÁ")
        cbp_reg.Items.Add("III ANTOFAGASTA")
        cbp_reg.Items.Add("IV ATACAMA")
        cbp_reg.Items.Add("V COQUIMBO")
        cbp_reg.Items.Add("VI VALPARAÍSO")
        cbp_reg.Items.Add("VII LIBERTADOR BERNARDO O'HIGGINS")
        cbp_reg.Items.Add("VIII MAULE")
        cbp_reg.Items.Add("IX BIOBÍO")
        cbp_reg.Items.Add("X LA ARAUCANÍA")
        cbp_reg.Items.Add("XI LOS RÍOS")
        cbp_reg.Items.Add("XII LOS LAGOS")
        cbp_reg.Items.Add("XIII AISÉN")
        cbp_reg.Items.Add("XIV MAGALLANES")
        cbp_reg.Items.Add("XV METROPOLITANA")
    End Sub

    Private Sub txt1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt1.GotFocus
        txt1.BackColor = Color.White
        txt1.ForeColor = Color.Black

    End Sub
    Private Sub txt1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt1.LostFocus
        txt1.BackColor = Color.White
        txt1.ForeColor = Color.Black
    End Sub


    'enter
    Private Sub txt1_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If Not IsNumeric(txt1.Text) Then
                MsgBox("Debe Ingresar valor Numerico", MsgBoxStyle.Critical And MsgBoxStyle.OkOnly, "Error de valor")
                txt1.Text = ""
                txt1.Focus()
            Else
                cbp_reg.Focus()
            End If
        End If
    End Sub
    Private Sub cbp_reg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbp_reg.KeyPress
        regiones_comunas()
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If cbp_reg.Text = "I ARICA Y PARINACOTA" Or cbp_reg.Text = "II TARAPACÁ" Or cbp_reg.Text = "III ANTOFAGASTA" Or cbp_reg.Text = "IV ATACAMA" Or cbp_reg.Text = "V COQUIMBO" Or cbp_reg.Text = "VI VALPARAÍSO" Or cbp_reg.Text = "VII LIBERTADOR BERNARDO O'HIGGINS" Or cbp_reg.Text = "VIII MAULE" Or cbp_reg.Text = "IX BIOBÍO" Or cbp_reg.Text = "X LA ARAUCANÍA" Or cbp_reg.Text = "XI LOS RÍOS" Or cbp_reg.Text = "XII LOS LAGOS" Or cbp_reg.Text = "XIII AISÉN" Or cbp_reg.Text = "XIV MAGALLANES" Or cbp_reg.Text = "XV METROPOLITANA" Then
                cbp_com.Focus()
            Else
                MsgBox("Region no valido", 16, "Error de ingreso")
                cbp_reg.Text = ""
                cbp_reg.Focus()
            End If
        End If
    End Sub
    Private Sub cbp_com_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbp_com.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            txt2.Focus()
        End If
    End Sub
    Private Sub txt2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt2.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            txt3.Focus()
        End If
    End Sub
    Private Sub txt3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt3.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            txt5.Focus()
        End If
    End Sub
    Private Sub txt4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt4.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cbp_tip.Focus()
        End If
    End Sub
    Private Sub txt5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt5.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If Not IsNumeric(txt5.Text) Then
                MsgBox("Debe Ingresar valor Numerico", MsgBoxStyle.Critical And MsgBoxStyle.OkOnly, "Error de valor")
                txt5.Text = ""
                txt5.Focus()
            Else
                txt12.Focus()
            End If
        End If
    End Sub
    Private Sub txt12_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt12.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If Not IsNumeric(txt12.Text) Then
                MsgBox("Debe Ingresar valor Numerico", MsgBoxStyle.Critical And MsgBoxStyle.OkOnly, "Error de valor")
                txt12.Text = ""
                txt12.Focus()
            Else
                cbp_op.Focus()
            End If
        End If
    End Sub
    Private Sub cbp_op_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbp_op.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If UCase(cbp_op.Text) = "VENTA" Or UCase(cbp_op.Text) = "ARRIENDO" Then
                txt4.Focus()
            Else
                MsgBox("Operacion no valido", 16, "Error de ingreso")
                cbp_op.Text = ""
                cbp_op.Focus()
            End If
        End If
    End Sub
    Private Sub RadioButton1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RadioButton1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            txt4.Focus()
        End If
    End Sub
    Private Sub cbp_tip_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbp_tip.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If cbp_tip.Text = "BODEGA" Or cbp_tip.Text = "OFICINA" Or cbp_tip.Text = "CASA" Or cbp_tip.Text = "ESTACIONAMIENTO" Or cbp_tip.Text = "DEPARTAMENTO" Then
                Select Case cbp_tip.SelectedItem
                    Case "BODEGA"
                        pbo.Visible = True
                        pof.Visible = False
                        pes.Visible = False
                        pca.Visible = False
                        ped.Visible = False
                        txt9.Focus()

                    Case "OFICINA"
                        pof.Visible = True
                        pes.Visible = False
                        pca.Visible = False
                        ped.Visible = False
                        pbo.Visible = False
                        txt10.Focus()

                    Case "ESTACIONAMIENTO"
                        pes.Visible = True
                        pof.Visible = False
                        pca.Visible = False
                        ped.Visible = False
                        pbo.Visible = False
                        txt11.Focus()

                    Case "CASA"
                        pca.Visible = True
                        pes.Visible = False
                        pof.Visible = False
                        ped.Visible = False
                        pbo.Visible = False
                        txt6.Focus()

                    Case "DEPARTAMENTO"
                        ped.Visible = True
                        pes.Visible = False
                        pca.Visible = False
                        pof.Visible = False
                        pbo.Visible = False
                        txt13.Focus()
                End Select
            Else
                MsgBox("Tipo de propiedad no valido", 16, "Error de ingreso")
                cbp_tip.Text = ""
                cbp_tip.Focus()
            End If
        End If
    End Sub
    Private Sub txt9_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt9.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If Not IsNumeric(txt9.Text) Then
                MsgBox("Debe Ingresar valor Numerico", MsgBoxStyle.Critical And MsgBoxStyle.OkOnly, "Error de valor")
                txt9.Text = ""
                txt9.Focus()
            Else
                bt_grabar.Focus()
            End If
        End If
    End Sub
    Private Sub txt10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt10.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If Not IsNumeric(txt10.Text) Then
                MsgBox("Debe Ingresar valor Numerico", MsgBoxStyle.Critical And MsgBoxStyle.OkOnly, "Error de valor")
                txt10.Text = ""
                txt10.Focus()
            Else
                bt_grabar.Focus()
            End If
        End If
    End Sub
    Private Sub txt11_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt11.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If Not IsNumeric(txt11.Text) Then
                MsgBox("Debe Ingresar valor Numerico", MsgBoxStyle.Critical And MsgBoxStyle.OkOnly, "Error de valor")
                txt11.Text = ""
                txt11.Focus()
            Else
                bt_grabar.Focus()
            End If
        End If
    End Sub
    Private Sub txt6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt6.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            txt7.Focus()
        End If
    End Sub
    Private Sub txt7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt7.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If Not IsNumeric(txt7.Text) Then
                MsgBox("Debe Ingresar valor Numerico", MsgBoxStyle.Critical And MsgBoxStyle.OkOnly, "Error de valor")
                txt7.Text = ""
                txt7.Focus()
            Else
                txt8.Focus()
            End If
        End If
    End Sub
    Private Sub txt8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt8.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If Not IsNumeric(txt8.Text) Then
                MsgBox("Debe Ingresar valor Numerico", MsgBoxStyle.Critical And MsgBoxStyle.OkOnly, "Error de valor")
                txt8.Text = ""
                txt8.Focus()
            Else
                bt_grabar.Focus()
            End If
        End If
    End Sub

    Private Sub txt13_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt13.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            txt14.Focus()
        End If
    End Sub
    Private Sub txt14_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt14.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If Not IsNumeric(txt14.Text) Then
                MsgBox("Debe Ingresar valor Numerico", MsgBoxStyle.Critical And MsgBoxStyle.OkOnly, "Error de valor")
                txt14.Text = ""
                txt14.Focus()
            Else
                txt15.Focus()
            End If
        End If
    End Sub
    Private Sub txt15_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt15.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If Not IsNumeric(txt15.Text) Then
                MsgBox("Debe Ingresar valor Numerico", MsgBoxStyle.Critical And MsgBoxStyle.OkOnly, "Error de valor")
                txt15.Text = ""
                txt15.Focus()
            Else
                bt_grabar.Focus()
            End If
        End If
    End Sub
    ' funcion grilla 
    Private Sub grilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grillap.CellDoubleClick
        txt1.Text = grillap.Item(0, grillap.CurrentRow.Index).Value()
        cbp_reg.Text = grillap.Item(1, grillap.CurrentRow.Index).Value()
        cbp_com.Text = grillap.Item(2, grillap.CurrentRow.Index).Value()
        txt2.Text = grillap.Item(3, grillap.CurrentRow.Index).Value()
        txt3.Text = grillap.Item(4, grillap.CurrentRow.Index).Value()
        txt5.Text = grillap.Item(5, grillap.CurrentRow.Index).Value()
        txt12.Text = grillap.Item(6, grillap.CurrentRow.Index).Value()
        cbp_op.Text = grillap.Item(7, grillap.CurrentRow.Index).Value()
        cbp_tip.Text = grillap.Item(8, grillap.CurrentRow.Index).Value()
        RadioButton1.Checked = grillap.Item(9, grillap.CurrentRow.Index).Value()
        txt4.Text = grillap.Item(10, grillap.CurrentRow.Index).Value()

        pa_grilla.Visible = False
        txt1.Enabled = False


    End Sub





    'botones

    Private Sub bt_volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_volver.Click
        Me.Hide()
    End Sub
    Private Sub bt_anular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_anular.Click
        txt1.Enabled = True
        limpiar_ca()
    End Sub
    Private Sub bt_grabar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_grabar.Click
        Me.grillap.Refresh()
        replace()
        limpiar_ca()
    End Sub
    Private Sub bt_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminar.Click
        Me.grillap.Rows.RemoveAt(Me.grillap.CurrentRow.Index)
        limpiar_ca()
    End Sub
    Private Sub bt_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_editar.Click
        'If txt1.Text = "" Then
        '    MsgBox("ID Vacio no se puede encontrar la propiedad", 16, "Error de ingreso")
        'Else

        pa_grilla.Visible = True
        'End If

    End Sub
    'boton grilla
    Private Sub btg_vol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btg_vol.Click
        pa_grilla.Hide()
        txt1.Focus()
    End Sub

    'validaciones



    Private Sub limpiar_ca()
        txt1.Text = ""
        cbp_reg.Text = ""
        cbp_com.Text = ""
        txt2.Text = ""
        txt3.Text = ""
        txt4.Text = ""
        txt5.Text = ""
        cbp_op.Text = ""
        cbp_tip.Text = ""
        txt6.Text = ""
        txt7.Text = ""
        txt8.Text = ""
        txt9.Text = ""
        txt10.Text = ""
        txt11.Text = ""
        txt12.Text = ""
        txt13.Text = ""
        txt14.Text = ""
        txt15.Text = ""
        pbo.Visible = False
        pof.Visible = False
        pes.Visible = False
        pca.Visible = False
        ped.Visible = False
        RadioButton1.Checked = False



        txt1.Focus()

    End Sub

    Private Sub regiones_comunas()
        cbp_com.Items.Clear()
        Select Case cbp_reg.SelectedItem
            Case "I ARICA Y PARINACOTA"
                UCase(cbp_com.Items.Add("Arica"))
                UCase(cbp_com.Items.Add("Camarones"))
                UCase(cbp_com.Items.Add("General Lagos"))
                UCase(cbp_com.Items.Add("Putre"))

            Case "II TARAPACÁ"
                UCase(cbp_com.Items.Add("Alto Hospicio"))
                UCase(cbp_com.Items.Add("Camiña"))
                UCase(cbp_com.Items.Add("Colchane"))
                UCase(cbp_com.Items.Add("Huara"))
                UCase(cbp_com.Items.Add("Iquique"))
                UCase(cbp_com.Items.Add("Pica"))
                UCase(cbp_com.Items.Add("Pozo Almonte"))

            Case "III ANTOFAGASTA"
                UCase(cbp_com.Items.Add("Antofagasta"))
                UCase(cbp_com.Items.Add("Calama"))
                UCase(cbp_com.Items.Add("María Elena"))
                UCase(cbp_com.Items.Add("Mejillones"))
                UCase(cbp_com.Items.Add("Ollagüe"))
                UCase(cbp_com.Items.Add("San Pedro de Atacama"))
                UCase(cbp_com.Items.Add("Sierra Gorda"))
                UCase(cbp_com.Items.Add("Taltal"))
                UCase(cbp_com.Items.Add("Tocopilla"))

            Case "IV ATACAMA"
                UCase(cbp_com.Items.Add("Alto del Carmen"))
                UCase(cbp_com.Items.Add("Caldera"))
                UCase(cbp_com.Items.Add("Chañaral"))
                UCase(cbp_com.Items.Add("Copiapó"))
                UCase(cbp_com.Items.Add("Diego de Almagro"))
                UCase(cbp_com.Items.Add("Freirina"))
                UCase(cbp_com.Items.Add("Huasco"))
                UCase(cbp_com.Items.Add("Tierra Amarilla"))
                UCase(cbp_com.Items.Add("Vallenar"))

            Case "V COQUIMBO"
                UCase(cbp_com.Items.Add("Andacollo"))
                UCase(cbp_com.Items.Add("Canela"))
                UCase(cbp_com.Items.Add("Combarbalá"))
                UCase(cbp_com.Items.Add("Coquimbo"))
                UCase(cbp_com.Items.Add("Illapel"))
                UCase(cbp_com.Items.Add("La Higuera"))
                UCase(cbp_com.Items.Add("La Serena"))
                UCase(cbp_com.Items.Add("Los Vilos"))
                UCase(cbp_com.Items.Add("Monte Patria"))
                UCase(cbp_com.Items.Add("Ovalle"))
                UCase(cbp_com.Items.Add("Paiguano"))
                UCase(cbp_com.Items.Add("Punitaqui"))
                UCase(cbp_com.Items.Add("Río Hurtado"))
                UCase(cbp_com.Items.Add("Salamanca"))
                UCase(cbp_com.Items.Add("Vicuña"))

            Case "VI VALPARAÍSO"
                UCase(cbp_com.Items.Add("Algarrobo"))
                UCase(cbp_com.Items.Add("Cabildo"))
                UCase(cbp_com.Items.Add("Calera"))
                UCase(cbp_com.Items.Add("Calle Larga"))
                UCase(cbp_com.Items.Add("Cartagena"))
                UCase(cbp_com.Items.Add("Casablanca"))
                UCase(cbp_com.Items.Add("Catemu"))
                UCase(cbp_com.Items.Add("Concón"))
                UCase(cbp_com.Items.Add("El Quisco"))
                UCase(cbp_com.Items.Add("El Tabo"))
                UCase(cbp_com.Items.Add("Hijuelas"))
                UCase(cbp_com.Items.Add("Isla de Pascua"))
                UCase(cbp_com.Items.Add("Juan Fernández"))
                UCase(cbp_com.Items.Add("La Cruz"))
                UCase(cbp_com.Items.Add("La Ligua"))
                UCase(cbp_com.Items.Add("Limache"))
                UCase(cbp_com.Items.Add("Llaillay"))
                UCase(cbp_com.Items.Add("Los Andes"))
                UCase(cbp_com.Items.Add("Nogales"))
                UCase(cbp_com.Items.Add("Olmué"))
                UCase(cbp_com.Items.Add("Panquehue"))
                UCase(cbp_com.Items.Add("Papudo"))
                UCase(cbp_com.Items.Add("Petorca"))
                UCase(cbp_com.Items.Add("Puchuncaví"))
                UCase(cbp_com.Items.Add("Putaendo"))
                UCase(cbp_com.Items.Add("Quillota"))
                UCase(cbp_com.Items.Add("Quilpué"))
                UCase(cbp_com.Items.Add("Quintero"))
                UCase(cbp_com.Items.Add("Rinconada"))
                UCase(cbp_com.Items.Add("San Antonio"))
                UCase(cbp_com.Items.Add("San Esteban"))
                UCase(cbp_com.Items.Add("San Felipe"))
                UCase(cbp_com.Items.Add("Santa María"))
                UCase(cbp_com.Items.Add("Santo Domingo"))
                UCase(cbp_com.Items.Add("Valparaíso"))
                UCase(cbp_com.Items.Add("Villa Alemana"))
                UCase(cbp_com.Items.Add("Viña del Mar"))
                UCase(cbp_com.Items.Add("Zapallar"))

            Case "VII LIBERTADOR BERNARDO O'HIGGINS"
                UCase(cbp_com.Items.Add("Chépica"))
                UCase(cbp_com.Items.Add("Chimbarongo"))
                UCase(cbp_com.Items.Add("Codegua"))
                UCase(cbp_com.Items.Add("Coinco"))
                UCase(cbp_com.Items.Add("Coltauco"))
                UCase(cbp_com.Items.Add("Doñihue"))
                UCase(cbp_com.Items.Add("Graneros"))
                UCase(cbp_com.Items.Add("La Estrella"))
                UCase(cbp_com.Items.Add("Las Cabras"))
                UCase(cbp_com.Items.Add("Litueche"))
                UCase(cbp_com.Items.Add("Lolol"))
                UCase(cbp_com.Items.Add("Machalí"))
                UCase(cbp_com.Items.Add("Malloa"))
                UCase(cbp_com.Items.Add("Marchihue"))
                UCase(cbp_com.Items.Add("Mostazal"))
                UCase(cbp_com.Items.Add("Nancagua"))
                UCase(cbp_com.Items.Add("Navidad"))
                UCase(cbp_com.Items.Add("Olivar"))
                UCase(cbp_com.Items.Add("Palmilla"))
                UCase(cbp_com.Items.Add("Paredones"))
                UCase(cbp_com.Items.Add("Peralillo"))
                UCase(cbp_com.Items.Add("Peumo"))
                UCase(cbp_com.Items.Add("Pichidegua"))
                UCase(cbp_com.Items.Add("Pichilemu"))
                UCase(cbp_com.Items.Add("Placilla"))
                UCase(cbp_com.Items.Add("Pumanque"))
                UCase(cbp_com.Items.Add("Quinta de Tilcoco"))
                UCase(cbp_com.Items.Add("Rancagua"))
                UCase(cbp_com.Items.Add("Rengo"))
                UCase(cbp_com.Items.Add("Requínoa"))
                UCase(cbp_com.Items.Add("San Fernando"))
                UCase(cbp_com.Items.Add("San Vicente"))
                UCase(cbp_com.Items.Add("Santa Cruz"))

            Case "XVIII MAULE"
                UCase(cbp_com.Items.Add("Cauquenes"))
                UCase(cbp_com.Items.Add("Chanco"))
                UCase(cbp_com.Items.Add("Colbún"))
                UCase(cbp_com.Items.Add("Constitución"))
                UCase(cbp_com.Items.Add("Curepto"))
                UCase(cbp_com.Items.Add("Curicó"))
                UCase(cbp_com.Items.Add("Empedrado"))
                UCase(cbp_com.Items.Add("Hualañé"))
                UCase(cbp_com.Items.Add("Licantén"))
                UCase(cbp_com.Items.Add("Linares"))
                UCase(cbp_com.Items.Add("Longaví"))
                UCase(cbp_com.Items.Add("Maule"))
                UCase(cbp_com.Items.Add("Molina"))
                UCase(cbp_com.Items.Add("Parral"))
                UCase(cbp_com.Items.Add("Pelarco"))
                UCase(cbp_com.Items.Add("Pelluhue"))
                UCase(cbp_com.Items.Add("Pencahue"))
                UCase(cbp_com.Items.Add("Rauco"))
                UCase(cbp_com.Items.Add("Retiro"))
                UCase(cbp_com.Items.Add("Río Claro"))
                UCase(cbp_com.Items.Add("Romeral"))
                UCase(cbp_com.Items.Add("Sagrada Familia"))
                UCase(cbp_com.Items.Add("San Clemente"))
                UCase(cbp_com.Items.Add("San Javier"))
                UCase(cbp_com.Items.Add("San Rafael"))
                UCase(cbp_com.Items.Add("Talca"))
                UCase(cbp_com.Items.Add("Teno"))
                UCase(cbp_com.Items.Add("Vichuquén"))
                UCase(cbp_com.Items.Add("Villa Alegre"))
                UCase(cbp_com.Items.Add("Yerbas Buenas"))

            Case "IX BIOBÍO"
                UCase(cbp_com.Items.Add("Alto Biobío"))
                UCase(cbp_com.Items.Add("Antuco"))
                UCase(cbp_com.Items.Add("Arauco"))
                UCase(cbp_com.Items.Add("Bulnes"))
                UCase(cbp_com.Items.Add("Cabrero"))
                UCase(cbp_com.Items.Add("Cañete"))
                UCase(cbp_com.Items.Add("Chiguayante"))
                UCase(cbp_com.Items.Add("Chillán"))
                UCase(cbp_com.Items.Add("Chillán Viejo"))
                UCase(cbp_com.Items.Add("Cobquecura"))
                UCase(cbp_com.Items.Add("Coelemu"))
                UCase(cbp_com.Items.Add("Coihueco"))
                UCase(cbp_com.Items.Add("Concepción"))
                UCase(cbp_com.Items.Add("Contulmo"))
                UCase(cbp_com.Items.Add("Coronel"))
                UCase(cbp_com.Items.Add("Curanilahue"))
                UCase(cbp_com.Items.Add("El Carmen"))
                UCase(cbp_com.Items.Add("Florida"))
                UCase(cbp_com.Items.Add("Hualpén"))
                UCase(cbp_com.Items.Add("Hualqui"))
                UCase(cbp_com.Items.Add("Laja"))
                UCase(cbp_com.Items.Add("Lebu"))
                UCase(cbp_com.Items.Add("Los Alamos"))
                UCase(cbp_com.Items.Add("Los Angeles"))
                UCase(cbp_com.Items.Add("Lota"))
                UCase(cbp_com.Items.Add("Mulchén"))
                UCase(cbp_com.Items.Add("Nacimiento"))
                UCase(cbp_com.Items.Add("Negrete"))
                UCase(cbp_com.Items.Add("Ninhue"))
                UCase(cbp_com.Items.Add("Ñiquén"))
                UCase(cbp_com.Items.Add("Pemuco"))
                UCase(cbp_com.Items.Add("Penco"))
                UCase(cbp_com.Items.Add("Pinto"))
                UCase(cbp_com.Items.Add("Portezuelo"))
                UCase(cbp_com.Items.Add("Quilaco"))
                UCase(cbp_com.Items.Add("Quilleco"))
                UCase(cbp_com.Items.Add("Quillón"))
                UCase(cbp_com.Items.Add("Quirihue"))
                UCase(cbp_com.Items.Add("Ránquil"))
                UCase(cbp_com.Items.Add("San Carlos"))
                UCase(cbp_com.Items.Add("San Fabián"))
                UCase(cbp_com.Items.Add("San Ignacio"))
                UCase(cbp_com.Items.Add("San Nicolás"))
                UCase(cbp_com.Items.Add("San Pedro de la Paz"))
                UCase(cbp_com.Items.Add("San Rosendo"))
                UCase(cbp_com.Items.Add("Santa Bárbara"))
                UCase(cbp_com.Items.Add("Santa Juana"))
                UCase(cbp_com.Items.Add("Talcahuano"))
                UCase(cbp_com.Items.Add("Tirúa"))
                UCase(cbp_com.Items.Add("Tomé"))
                UCase(cbp_com.Items.Add("Treguaco"))
                UCase(cbp_com.Items.Add("Tucapel"))
                UCase(cbp_com.Items.Add("Yumbel"))
                UCase(cbp_com.Items.Add("Yungay"))

            Case "X LA ARAUCANÍA"
                UCase(cbp_com.Items.Add("Angol"))
                UCase(cbp_com.Items.Add("Carahue"))
                UCase(cbp_com.Items.Add("Cholchol"))
                UCase(cbp_com.Items.Add("Collipulli"))
                UCase(cbp_com.Items.Add("Cunco"))
                UCase(cbp_com.Items.Add("Curacautín"))
                UCase(cbp_com.Items.Add("Curarrehue"))
                UCase(cbp_com.Items.Add("Ercilla"))
                UCase(cbp_com.Items.Add("Freire"))
                UCase(cbp_com.Items.Add("Galvarino"))
                UCase(cbp_com.Items.Add("Gorbea"))
                UCase(cbp_com.Items.Add("Lautaro"))
                UCase(cbp_com.Items.Add("Loncoche"))
                UCase(cbp_com.Items.Add("Lonquimay"))
                UCase(cbp_com.Items.Add("Los Sauces"))
                UCase(cbp_com.Items.Add("Lumaco"))
                UCase(cbp_com.Items.Add("Melipeuco"))
                UCase(cbp_com.Items.Add("Nueva Imperial"))
                UCase(cbp_com.Items.Add("Padre Las Casas"))
                UCase(cbp_com.Items.Add("Perquenco"))
                UCase(cbp_com.Items.Add("Pitrufquén"))
                UCase(cbp_com.Items.Add("Pucón"))
                UCase(cbp_com.Items.Add("Purén"))
                UCase(cbp_com.Items.Add("Renaico"))
                UCase(cbp_com.Items.Add("Saavedra"))
                UCase(cbp_com.Items.Add("Temuco"))
                UCase(cbp_com.Items.Add("Teodoro Schmidt"))
                UCase(cbp_com.Items.Add("Toltén"))
                UCase(cbp_com.Items.Add("Traiguén"))
                UCase(cbp_com.Items.Add("Victoria"))
                UCase(cbp_com.Items.Add("Vilcún"))
                UCase(cbp_com.Items.Add("Villarrica"))

            Case "XI LOS RÍOS"
                UCase(cbp_com.Items.Add("Corral"))
                UCase(cbp_com.Items.Add("Futrono"))
                UCase(cbp_com.Items.Add("La Unión"))
                UCase(cbp_com.Items.Add("Lago Ranco"))
                UCase(cbp_com.Items.Add("Lanco"))
                UCase(cbp_com.Items.Add("Los Lagos"))
                UCase(cbp_com.Items.Add("Máfil"))
                UCase(cbp_com.Items.Add("Mariquina"))
                UCase(cbp_com.Items.Add("Paillaco"))
                UCase(cbp_com.Items.Add("Panguipulli"))
                UCase(cbp_com.Items.Add("Río Bueno"))
                UCase(cbp_com.Items.Add("Valdivia"))

            Case "XII LOS LAGOS"
                UCase(cbp_com.Items.Add("Ancud"))
                UCase(cbp_com.Items.Add("Calbuco"))
                UCase(cbp_com.Items.Add("Castro"))
                UCase(cbp_com.Items.Add("Chaitén"))
                UCase(cbp_com.Items.Add("Chonchi"))
                UCase(cbp_com.Items.Add("Cochamó"))
                UCase(cbp_com.Items.Add("Curaco de Vélez"))
                UCase(cbp_com.Items.Add("Dalcahue"))
                UCase(cbp_com.Items.Add("Fresia"))
                UCase(cbp_com.Items.Add("Frutillar"))
                UCase(cbp_com.Items.Add("Futaleufú"))
                UCase(cbp_com.Items.Add("Hualaihué"))
                UCase(cbp_com.Items.Add("Llanquihue"))
                UCase(cbp_com.Items.Add("Los Muermos"))
                UCase(cbp_com.Items.Add("Maullín"))
                UCase(cbp_com.Items.Add("Osorno"))
                UCase(cbp_com.Items.Add("Palena"))
                UCase(cbp_com.Items.Add("Puerto Montt"))
                UCase(cbp_com.Items.Add("Puerto Octay"))
                UCase(cbp_com.Items.Add("Puerto Varas"))
                UCase(cbp_com.Items.Add("Puqueldón"))
                UCase(cbp_com.Items.Add("Purranque"))
                UCase(cbp_com.Items.Add("Puyehue"))
                UCase(cbp_com.Items.Add("Queilén"))
                UCase(cbp_com.Items.Add("Quellón"))
                UCase(cbp_com.Items.Add("Quemchi"))
                UCase(cbp_com.Items.Add("Quinchao"))
                UCase(cbp_com.Items.Add("Río Negro"))
                UCase(cbp_com.Items.Add("San Juan de la Costa"))
                UCase(cbp_com.Items.Add("San Pablo"))

            Case "XIII AISÉN"
                UCase(cbp_com.Items.Add("Aisén"))
                UCase(cbp_com.Items.Add("Chile Chico"))
                UCase(cbp_com.Items.Add("Cisnes"))
                UCase(cbp_com.Items.Add("Cochrane"))
                UCase(cbp_com.Items.Add("Coihaique"))
                UCase(cbp_com.Items.Add("Guaitecas"))
                UCase(cbp_com.Items.Add("Lago Verde"))
                UCase(cbp_com.Items.Add("O'Higgins"))
                UCase(cbp_com.Items.Add("Río Ibáñez"))
                UCase(cbp_com.Items.Add("Tortel"))

            Case "XIV MAGALLANES"
                UCase(cbp_com.Items.Add("Antártica"))
                UCase(cbp_com.Items.Add("Cabo de Hornos (Ex-Navarino)"))
                UCase(cbp_com.Items.Add("Laguna Blanca"))
                UCase(cbp_com.Items.Add("Natales"))
                UCase(cbp_com.Items.Add("Porvenir"))
                UCase(cbp_com.Items.Add("Primavera"))
                UCase(cbp_com.Items.Add("Punta Arenas"))
                UCase(cbp_com.Items.Add("Río Verde"))
                UCase(cbp_com.Items.Add("San Gregorio"))
                UCase(cbp_com.Items.Add("Timaukel"))
                UCase(cbp_com.Items.Add("Torres del Paine"))

            Case "XV METROPOLITANA"
                UCase(cbp_com.Items.Add("Alhué"))
                UCase(cbp_com.Items.Add("Buin"))
                UCase(cbp_com.Items.Add("Calera de Tango"))
                UCase(cbp_com.Items.Add("Cerrillos"))
                UCase(cbp_com.Items.Add("Cerro Navia"))
                UCase(cbp_com.Items.Add("Colina"))
                UCase(cbp_com.Items.Add("Conchalí"))
                UCase(cbp_com.Items.Add("Curacaví"))
                UCase(cbp_com.Items.Add("El Bosque"))
                UCase(cbp_com.Items.Add("El Monte"))
                UCase(cbp_com.Items.Add("El Monte"))
                UCase(cbp_com.Items.Add("Estación Central"))
                UCase(cbp_com.Items.Add("Huechuraba"))
                UCase(cbp_com.Items.Add("Independencia"))
                UCase(cbp_com.Items.Add("Isla de Maipo"))
                UCase(cbp_com.Items.Add("La Cisterna"))
                UCase(cbp_com.Items.Add("La Florida"))
                UCase(cbp_com.Items.Add("La Granja"))
                UCase(cbp_com.Items.Add("La Pintana"))
                UCase(cbp_com.Items.Add("La Reina"))
                UCase(cbp_com.Items.Add("Lampa"))
                UCase(cbp_com.Items.Add("Las Condes"))
                UCase(cbp_com.Items.Add("Lo Barnechea"))
                UCase(cbp_com.Items.Add("Lo Espejo"))
                UCase(cbp_com.Items.Add("Lo Prado"))
                UCase(cbp_com.Items.Add("Macul"))
                UCase(cbp_com.Items.Add("Maipú"))
                UCase(cbp_com.Items.Add("María Pinto"))
                UCase(cbp_com.Items.Add("Melipilla"))
                UCase(cbp_com.Items.Add("Ñuñoa"))
                UCase(cbp_com.Items.Add("Padre Hurtado"))
                UCase(cbp_com.Items.Add("Paine"))
                UCase(cbp_com.Items.Add("Pedro Aguirre Cerda"))
                UCase(cbp_com.Items.Add("Peñaflor"))
                UCase(cbp_com.Items.Add("Peñalolén"))
                UCase(cbp_com.Items.Add("Pirque"))
                UCase(cbp_com.Items.Add("Providencia"))
                UCase(cbp_com.Items.Add("Pudahuel"))
                UCase(cbp_com.Items.Add("Puente Alto"))
                UCase(cbp_com.Items.Add("Quilicura"))
                UCase(cbp_com.Items.Add("Quinta Normal"))
                UCase(cbp_com.Items.Add("Recoleta"))
                UCase(cbp_com.Items.Add("Renca"))
                UCase(cbp_com.Items.Add("San Bernardo"))
                UCase(cbp_com.Items.Add("San Joaquín"))
                UCase(cbp_com.Items.Add("San José de Maipo"))
                UCase(cbp_com.Items.Add("San Miguel"))
                UCase(cbp_com.Items.Add("San Pedro"))
                UCase(cbp_com.Items.Add("San Ramón"))
                UCase(cbp_com.Items.Add("Santiago"))
                UCase(cbp_com.Items.Add("Talagante"))
                UCase(cbp_com.Items.Add("Tiltil"))
                UCase(cbp_com.Items.Add("Vitacura"))
        End Select
    End Sub

    Private Sub replace()
        Dim Codigo As String
        For Each row As DataGridViewRow In Me.grillap.Rows
            'obtenemos el valor de la columna en la variable declarada
            Codigo = row.Cells(0).Value 'donde (0) es la columna a recorrer            
            If Codigo = txt1.Text Then
                Me.grillap.Rows.RemoveAt(Me.grillap.CurrentRow.Index)
                row.Cells(0).Value = Codigo
                row.Cells(1).Value =
                row.Cells(2).Value = txt2.Text
                row.Cells(3).Value = txt3.Text
                row.Cells(4).Value = txt4.Text
                row.Cells(5).Value = txt5.Text
                row.Cells(6).Value =
                row.Cells(7).Value = txt6.Text
                row.Cells(8).Value = txt9.Text
                row.Cells(9).Value = cb3.Text
                row.Cells(10).Value = cb2.Text
                row.Cells(11).Value = txt7.Text
                row.Cells(12).Value = txt8.Text
            End If
        Next
        Me.grillap.Rows.Add(Me.txt1.Text, Me.cbp_reg.Text, Me.cbp_com.Text, Me.txt2.Text, Me.txt3.Text, Me.txt5.Text, Me.txt12.Text, Me.cbp_op.Text, Me.cbp_tip.Text, Me.RadioButton1.Checked, Me.txt4.Text)
    End Sub



    

End Class