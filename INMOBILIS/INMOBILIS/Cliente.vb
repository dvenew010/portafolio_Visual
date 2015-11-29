Public Class cliente
    Dim sw_val As Integer
    Dim fecha As Date





    '' VENTANA

    Private Sub cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Limpiar_campos()
        cb3.Items.Add("I ARICA Y PARINACOTA")
        cb3.Items.Add("II TARAPACÁ")
        cb3.Items.Add("III ANTOFAGASTA")
        cb3.Items.Add("IV ATACAMA")
        cb3.Items.Add("V COQUIMBO")
        cb3.Items.Add("VI VALPARAÍSO")
        cb3.Items.Add("VII LIBERTADOR BERNARDO O'HIGGINS")
        cb3.Items.Add("VIII MAULE")
        cb3.Items.Add("IX BIOBÍO")
        cb3.Items.Add("X LA ARAUCANÍA")
        cb3.Items.Add("XI LOS RÍOS")
        cb3.Items.Add("XII LOS LAGOS")
        cb3.Items.Add("XIII AISÉN")
        cb3.Items.Add("XIV MAGALLANES")
        cb3.Items.Add("XV METROPOLITANA")

        Me.grilla.Rows.Add("17415666", "2", "DANIEL", "VERDUGO", "GALLEGOS", "14/01/1990", "M", "DVENEW.010@GMAIL.COM", "JAJAJA", "XV METROPOLITANA", "LA FLORIDA", "LAS CLAVELINAS #2078", 77070720)

        pa_grilla.Left = 12
        pa_grilla.Top = 100
        pa_grilla.Visible = False

        fecha = Format(Now(), "short date")
        tx_fe.Text = fecha
        txt1.MaxLength() = 8
        txtt1.MaxLength() = 1

    End Sub

    '' CAJAS

    Private Sub txt1_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If Not IsNumeric(txt1.Text) Then
                MsgBox("Debe ingresar numeros", 16, "Error de ingreso")
                txt1.Text = ""
                txt1.Focus()
            Else
                If txt1.Text = "" Then
                    MsgBox("El campo esta vacio", 16, "Error de ingreso")
                    txt1.Focus()
                Else
                    txtt1.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub txtt1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtt1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtt1.Text = "k" Or txtt1.Text = "0" Or txtt1.Text = "1" Or txtt1.Text = "2" Or txtt1.Text = "3" Or txtt1.Text = "4" Or txtt1.Text = "5" Or txtt1.Text = "6" Or txtt1.Text = "7" Or txtt1.Text = "8" Or txtt1.Text = "9" Then
                valida_rut(txt1.Text, txtt1.Text)
                If sw_val = 1 Then
                    txtt1.Text = ""
                    txtt1.Focus()
                    Exit Sub
                End If
                txt2.Focus()
            Else
                MsgBox("Dato no valido", 16, "Error de ingreso")
                txtt1.Text = ""
                txtt1.Focus()
            End If
        End If
    End Sub
    Private Sub txt2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt2.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            txt3.Focus()
        End If
    End Sub
    Private Sub txt3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt3.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            txt4.Focus()
        End If
    End Sub
    Private Sub txt4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt4.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            txt5.Focus()
        End If
    End Sub
    Private Sub txt5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt5.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txt5.Text <> "00-00-0000" Then
                Valida_Fecha(txt5.Text)
                If sw_val = 1 Then
                    txt5.Text = ""
                    txt5.Focus()
                    Exit Sub
                End If
            Else
                txt5.Text = "00-00-0000"
            End If
            cb1.Focus()
        End If
    End Sub
    Private Sub cb1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cb1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If UCase(cb1.Text) = "F" Or UCase(cb1.Text) = "M" Then
                txt6.Focus()
            Else
                MsgBox("Sexo no valido", 16, "Error de ingreso")
                cb1.Text = ""
                cb1.Focus()
            End If
        End If
    End Sub
    Private Sub txt6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt6.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            txt9.Focus()
        End If
    End Sub
    Private Sub txt9_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt9.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cb3.Focus()
        End If
    End Sub
    Private Sub cb3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cb3.KeyPress
        regiones_comunas()
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cb2.Focus()
        End If
    End Sub
    Private Sub cb2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cb2.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            txt7.Focus()
        End If
    End Sub
    Private Sub txt7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt7.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            txt8.Focus()
        End If
    End Sub
    Private Sub txt8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt8.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If Not IsNumeric(txt8.Text) Then
                MsgBox("Debe Ingresar valor Numerico", MsgBoxStyle.Critical And MsgBoxStyle.OkOnly, "Error de valor")
                txt8.Text = ""
                txt8.Focus()
            Else
                bt_gra.Focus()
            End If
        End If
    End Sub






    '' BOTONES 
    
    Private Sub bt_gra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_gra.Click
        
        If txt1.Text = "" Then
            MsgBox("Rut no valido no se puede agregar", 16, "Error de ingreso")
            txt1.Focus()
        Else
            replacecli()
            Limpiar_campos()
        End If
    End Sub
    Private Sub bt_elim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_elim.Click
        'Me.grilla.Refresh()
        If txt1.Text = "" Then
            MsgBox("Rut no valido no se puede eliminar", 16, "Error de ingreso")
        Else
            deletecli()
        End If
        Limpiar_campos()
    End Sub
    Private Sub bt_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_edit.Click
        Me.grilla.Refresh()
        pa_grilla.Visible = True
        txt1.Focus()
    End Sub
    Private Sub bt_vol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_vol.Click
        Me.Hide()
        Form1.Enabled = True
    End Sub
    Private Sub bt_anu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_anu.Click
        Limpiar_campos()
    End Sub
    Private Sub btg_vol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btg_vol.Click
        pa_grilla.Hide()
        Limpiar_campos()
    End Sub




    '' VALIDACIONES
    Private Sub deletecli()
        Dim Codigo As String
        For Each row As DataGridViewRow In Me.grilla.Rows
            'obtenemos el valor de la columna en la variable declarada
            Codigo = row.Cells(0).Value 'donde (0) es la columna a recorrer            
            If Codigo = txt1.Text Then
                Me.grilla.Rows.RemoveAt(Me.grilla.CurrentRow.Index)
            End If
        Next
    End Sub

    Private Sub replacecli()
        Dim Codigo, mmm, mmm1 As String
        For Each row As DataGridViewRow In Me.grilla.Rows
            'obtenemos el valor de la columna en la variable declarada
            Codigo = row.Cells(0).Value 'donde (0) es la columna a recorrer
            mmm = row.Cells(1).Value
            mmm1 = row.Cells(6).Value
            If Codigo = txt1.Text Then
                Me.grilla.Rows.RemoveAt(Me.grilla.CurrentRow.Index)
                row.Cells(0).Value = Codigo
                row.Cells(1).Value = mmm
                row.Cells(2).Value = txt2.Text
                row.Cells(3).Value = txt3.Text
                row.Cells(4).Value = txt4.Text
                row.Cells(5).Value = txt5.Text
                row.Cells(6).Value = mmm1
                row.Cells(7).Value = txt6.Text
                row.Cells(8).Value = txt9.Text
                row.Cells(9).Value = cb3.Text
                row.Cells(10).Value = cb2.Text
                row.Cells(11).Value = txt7.Text
                row.Cells(12).Value = txt8.Text
            End If
        Next
        Me.grilla.Rows.Add(Me.txt1.Text, Me.txtt1.Text, Me.txt2.Text, Me.txt3.Text, Me.txt4.Text, Me.txt5.Text, Me.cb1.Text, Me.txt6.Text, Me.txt9.Text, Me.cb3.Text, Me.cb2.Text, Me.txt7.Text, Me.txt8.Text)
    End Sub

    Private Sub grilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grilla.CellDoubleClick
        txt1.Text = grilla.Item(0, grilla.CurrentRow.Index).Value()
        txtt1.Text = grilla.Item(1, grilla.CurrentRow.Index).Value()
        txt2.Text = grilla.Item(2, grilla.CurrentRow.Index).Value()
        txt3.Text = grilla.Item(3, grilla.CurrentRow.Index).Value()
        txt4.Text = grilla.Item(4, grilla.CurrentRow.Index).Value()
        txt5.Text = grilla.Item(5, grilla.CurrentRow.Index).Value()
        cb1.Text = grilla.Item(6, grilla.CurrentRow.Index).Value()
        txt6.Text = grilla.Item(7, grilla.CurrentRow.Index).Value()
        txt9.Text = grilla.Item(8, grilla.CurrentRow.Index).Value()
        cb3.Text = grilla.Item(9, grilla.CurrentRow.Index).Value()
        cb2.Text = grilla.Item(10, grilla.CurrentRow.Index).Value()
        txt7.Text = grilla.Item(11, grilla.CurrentRow.Index).Value()
        txt8.Text = grilla.Item(12, grilla.CurrentRow.Index).Value()
        txt1.Enabled = False
        txtt1.Enabled = False
        cb1.Enabled = False
        pa_grilla.Visible = False
    End Sub

    Private Sub Valida_datos()
        If txt1.Text = "" Or txtt1.Text = "" Or txt2.Text = "" Or txt3.Text = "" Or txt4.Text = "" Or txt5.Text = "" Or txt6.Text = "" Or txt7.Text = "" Or txt8.Text = "" Or cb1.Text = "" Or cb2.Text = "" Or cb3.Text = "" Then
            MsgBox("Cuadro Vacio", 16, "Error de ingreso")
            sw_val = 1
        End If
    End Sub

    Private Sub Limpiar_campos()
        txt1.Text = ""
        txtt1.Text = ""
        txt2.Text = ""
        txt3.Text = ""
        txt4.Text = ""
        txt5.Text = ""
        txt6.Text = ""
        txt7.Text = ""
        txt8.Text = ""
        cb1.Text = ""
        cb2.Text = ""
        cb3.Text = ""
        txt9.Text = ""
        txt1.Focus()
        txt1.Enabled = True
        txtt1.Enabled = True
        cb1.Enabled = True
    End Sub

    Private Sub Valida_Fecha(ByVal fecha As String)
        Dim vdia, vmes, vano As Integer

        vdia = Val(Mid(fecha, 1, 2))
        vmes = Val(Mid(fecha, 4, 2))
        vano = Val(Mid(fecha, 7, 4))
        sw_val = 0
        If fecha = "__-__-____" Then
            sw_val = 1
            Exit Sub
        End If
        If vdia > 31 Or vmes > 12 Or vano < 1900 Or vano > 1997 Or vdia < 1 Or vmes < 1 Then
            sw_val = 1
            MsgBox("La fecha no es válida", 16, "Error de ingreso")
        End If
        If sw_val = 0 Then
            If (vmes = 1 Or vmes = 3 Or vmes = 5 Or vmes = 7 Or vmes = 8 Or vmes = 10 Or vmes = 12) And vdia > 31 Then
                sw_val = 1
                MsgBox("La fecha no es válida", 16, "Error de ingreso")
            End If
            If (vmes = 4 Or vmes = 6 Or vmes = 9 Or vmes = 11) And vdia > 30 Then
                sw_val = 1
                MsgBox("La fecha no es válida", 16, "Error de ingreso")
            End If
            If vmes = 2 Then
                If vano \ 4 = vano / 4 Then
                    If vdia > 29 Then
                        sw_val = 1
                        MsgBox("La fecha no es válida", 16, "Error de ingreso")
                    End If
                Else
                    If vdia > 28 Then
                        sw_val = 1
                        MsgBox("La fecha no es válida", 16, "Error de ingreso")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub valida_rut(ByVal mmm As Integer, ByVal dv As String)
        Dim rut As Integer
        Dim digito As String
        Dim contarnumerodeauno As Integer
        Dim contar As Integer
        Dim acumulador As Integer
        Dim division As Integer
        Dim dig As Integer
        Dim dig2 As String

        contar = 2
        rut = txt1.Text
        digito = txtt1.Text
        Do While rut <> 0
            contarnumerodeauno = (rut Mod 10) * contar
            acumulador = acumulador + contarnumerodeauno
            rut = rut \ 10
            contar = contar + 1
            If contar = 8 Then
                contar = 2
            End If
        Loop
        division = acumulador Mod 11
        If division = 0 Then
            division = 11
        End If
        dig = 11 - division
        dig2 = CStr(dig)

        If dig2 = 10 Then
            dig2 = "k"
        End If

        If dig2 = digito Then
            sw_val = 0
        Else
            MsgBox(" Error: El Digito Verificador no es Correcto  ")
            sw_val = 1
        End If

    End Sub

    Private Sub regiones_comunas()
        cb2.Items.Clear()
        Select Case cb3.SelectedItem
            Case "I ARICA Y PARINACOTA"
                UCase(cb2.Items.Add("Arica"))
                UCase(cb2.Items.Add("Camarones"))
                UCase(cb2.Items.Add("General Lagos"))
                UCase(cb2.Items.Add("Putre"))

            Case "II TARAPACÁ"
                UCase(cb2.Items.Add("Alto Hospicio"))
                UCase(cb2.Items.Add("Camiña"))
                UCase(cb2.Items.Add("Colchane"))
                UCase(cb2.Items.Add("Huara"))
                UCase(cb2.Items.Add("Iquique"))
                UCase(cb2.Items.Add("Pica"))
                UCase(cb2.Items.Add("Pozo Almonte"))

            Case "III ANTOFAGASTA"
                UCase(cb2.Items.Add("Antofagasta"))
                UCase(cb2.Items.Add("Calama"))
                UCase(cb2.Items.Add("María Elena"))
                UCase(cb2.Items.Add("Mejillones"))
                UCase(cb2.Items.Add("Ollagüe"))
                UCase(cb2.Items.Add("San Pedro de Atacama"))
                UCase(cb2.Items.Add("Sierra Gorda"))
                UCase(cb2.Items.Add("Taltal"))
                UCase(cb2.Items.Add("Tocopilla"))

            Case "IV ATACAMA"
                UCase(cb2.Items.Add("Alto del Carmen"))
                UCase(cb2.Items.Add("Caldera"))
                UCase(cb2.Items.Add("Chañaral"))
                UCase(cb2.Items.Add("Copiapó"))
                UCase(cb2.Items.Add("Diego de Almagro"))
                UCase(cb2.Items.Add("Freirina"))
                UCase(cb2.Items.Add("Huasco"))
                UCase(cb2.Items.Add("Tierra Amarilla"))
                UCase(cb2.Items.Add("Vallenar"))

            Case "V COQUIMBO"
                UCase(cb2.Items.Add("Andacollo"))
                UCase(cb2.Items.Add("Canela"))
                UCase(cb2.Items.Add("Combarbalá"))
                UCase(cb2.Items.Add("Coquimbo"))
                UCase(cb2.Items.Add("Illapel"))
                UCase(cb2.Items.Add("La Higuera"))
                UCase(cb2.Items.Add("La Serena"))
                UCase(cb2.Items.Add("Los Vilos"))
                UCase(cb2.Items.Add("Monte Patria"))
                UCase(cb2.Items.Add("Ovalle"))
                UCase(cb2.Items.Add("Paiguano"))
                UCase(cb2.Items.Add("Punitaqui"))
                UCase(cb2.Items.Add("Río Hurtado"))
                UCase(cb2.Items.Add("Salamanca"))
                UCase(cb2.Items.Add("Vicuña"))

            Case "VI VALPARAÍSO"
                UCase(cb2.Items.Add("Algarrobo"))
                UCase(cb2.Items.Add("Cabildo"))
                UCase(cb2.Items.Add("Calera"))
                UCase(cb2.Items.Add("Calle Larga"))
                UCase(cb2.Items.Add("Cartagena"))
                UCase(cb2.Items.Add("Casablanca"))
                UCase(cb2.Items.Add("Catemu"))
                UCase(cb2.Items.Add("Concón"))
                UCase(cb2.Items.Add("El Quisco"))
                UCase(cb2.Items.Add("El Tabo"))
                UCase(cb2.Items.Add("Hijuelas"))
                UCase(cb2.Items.Add("Isla de Pascua"))
                UCase(cb2.Items.Add("Juan Fernández"))
                UCase(cb2.Items.Add("La Cruz"))
                UCase(cb2.Items.Add("La Ligua"))
                UCase(cb2.Items.Add("Limache"))
                UCase(cb2.Items.Add("Llaillay"))
                UCase(cb2.Items.Add("Los Andes"))
                UCase(cb2.Items.Add("Nogales"))
                UCase(cb2.Items.Add("Olmué"))
                UCase(cb2.Items.Add("Panquehue"))
                UCase(cb2.Items.Add("Papudo"))
                UCase(cb2.Items.Add("Petorca"))
                UCase(cb2.Items.Add("Puchuncaví"))
                UCase(cb2.Items.Add("Putaendo"))
                UCase(cb2.Items.Add("Quillota"))
                UCase(cb2.Items.Add("Quilpué"))
                UCase(cb2.Items.Add("Quintero"))
                UCase(cb2.Items.Add("Rinconada"))
                UCase(cb2.Items.Add("San Antonio"))
                UCase(cb2.Items.Add("San Esteban"))
                UCase(cb2.Items.Add("San Felipe"))
                UCase(cb2.Items.Add("Santa María"))
                UCase(cb2.Items.Add("Santo Domingo"))
                UCase(cb2.Items.Add("Valparaíso"))
                UCase(cb2.Items.Add("Villa Alemana"))
                UCase(cb2.Items.Add("Viña del Mar"))
                UCase(cb2.Items.Add("Zapallar"))

            Case "VII LIBERTADOR BERNARDO O'HIGGINS"
                UCase(cb2.Items.Add("Chépica"))
                UCase(cb2.Items.Add("Chimbarongo"))
                UCase(cb2.Items.Add("Codegua"))
                UCase(cb2.Items.Add("Coinco"))
                UCase(cb2.Items.Add("Coltauco"))
                UCase(cb2.Items.Add("Doñihue"))
                UCase(cb2.Items.Add("Graneros"))
                UCase(cb2.Items.Add("La Estrella"))
                UCase(cb2.Items.Add("Las Cabras"))
                UCase(cb2.Items.Add("Litueche"))
                UCase(cb2.Items.Add("Lolol"))
                UCase(cb2.Items.Add("Machalí"))
                UCase(cb2.Items.Add("Malloa"))
                UCase(cb2.Items.Add("Marchihue"))
                UCase(cb2.Items.Add("Mostazal"))
                UCase(cb2.Items.Add("Nancagua"))
                UCase(cb2.Items.Add("Navidad"))
                UCase(cb2.Items.Add("Olivar"))
                UCase(cb2.Items.Add("Palmilla"))
                UCase(cb2.Items.Add("Paredones"))
                UCase(cb2.Items.Add("Peralillo"))
                UCase(cb2.Items.Add("Peumo"))
                UCase(cb2.Items.Add("Pichidegua"))
                UCase(cb2.Items.Add("Pichilemu"))
                UCase(cb2.Items.Add("Placilla"))
                UCase(cb2.Items.Add("Pumanque"))
                UCase(cb2.Items.Add("Quinta de Tilcoco"))
                UCase(cb2.Items.Add("Rancagua"))
                UCase(cb2.Items.Add("Rengo"))
                UCase(cb2.Items.Add("Requínoa"))
                UCase(cb2.Items.Add("San Fernando"))
                UCase(cb2.Items.Add("San Vicente"))
                UCase(cb2.Items.Add("Santa Cruz"))

            Case "XVIII MAULE"
                UCase(cb2.Items.Add("Cauquenes"))
                UCase(cb2.Items.Add("Chanco"))
                UCase(cb2.Items.Add("Colbún"))
                UCase(cb2.Items.Add("Constitución"))
                UCase(cb2.Items.Add("Curepto"))
                UCase(cb2.Items.Add("Curicó"))
                UCase(cb2.Items.Add("Empedrado"))
                UCase(cb2.Items.Add("Hualañé"))
                UCase(cb2.Items.Add("Licantén"))
                UCase(cb2.Items.Add("Linares"))
                UCase(cb2.Items.Add("Longaví"))
                UCase(cb2.Items.Add("Maule"))
                UCase(cb2.Items.Add("Molina"))
                UCase(cb2.Items.Add("Parral"))
                UCase(cb2.Items.Add("Pelarco"))
                UCase(cb2.Items.Add("Pelluhue"))
                UCase(cb2.Items.Add("Pencahue"))
                UCase(cb2.Items.Add("Rauco"))
                UCase(cb2.Items.Add("Retiro"))
                UCase(cb2.Items.Add("Río Claro"))
                UCase(cb2.Items.Add("Romeral"))
                UCase(cb2.Items.Add("Sagrada Familia"))
                UCase(cb2.Items.Add("San Clemente"))
                UCase(cb2.Items.Add("San Javier"))
                UCase(cb2.Items.Add("San Rafael"))
                UCase(cb2.Items.Add("Talca"))
                UCase(cb2.Items.Add("Teno"))
                UCase(cb2.Items.Add("Vichuquén"))
                UCase(cb2.Items.Add("Villa Alegre"))
                UCase(cb2.Items.Add("Yerbas Buenas"))

            Case "IX BIOBÍO"
                UCase(cb2.Items.Add("Alto Biobío"))
                UCase(cb2.Items.Add("Antuco"))
                UCase(cb2.Items.Add("Arauco"))
                UCase(cb2.Items.Add("Bulnes"))
                UCase(cb2.Items.Add("Cabrero"))
                UCase(cb2.Items.Add("Cañete"))
                UCase(cb2.Items.Add("Chiguayante"))
                UCase(cb2.Items.Add("Chillán"))
                UCase(cb2.Items.Add("Chillán Viejo"))
                UCase(cb2.Items.Add("Cobquecura"))
                UCase(cb2.Items.Add("Coelemu"))
                UCase(cb2.Items.Add("Coihueco"))
                UCase(cb2.Items.Add("Concepción"))
                UCase(cb2.Items.Add("Contulmo"))
                UCase(cb2.Items.Add("Coronel"))
                UCase(cb2.Items.Add("Curanilahue"))
                UCase(cb2.Items.Add("El Carmen"))
                UCase(cb2.Items.Add("Florida"))
                UCase(cb2.Items.Add("Hualpén"))
                UCase(cb2.Items.Add("Hualqui"))
                UCase(cb2.Items.Add("Laja"))
                UCase(cb2.Items.Add("Lebu"))
                UCase(cb2.Items.Add("Los Alamos"))
                UCase(cb2.Items.Add("Los Angeles"))
                UCase(cb2.Items.Add("Lota"))
                UCase(cb2.Items.Add("Mulchén"))
                UCase(cb2.Items.Add("Nacimiento"))
                UCase(cb2.Items.Add("Negrete"))
                UCase(cb2.Items.Add("Ninhue"))
                UCase(cb2.Items.Add("Ñiquén"))
                UCase(cb2.Items.Add("Pemuco"))
                UCase(cb2.Items.Add("Penco"))
                UCase(cb2.Items.Add("Pinto"))
                UCase(cb2.Items.Add("Portezuelo"))
                UCase(cb2.Items.Add("Quilaco"))
                UCase(cb2.Items.Add("Quilleco"))
                UCase(cb2.Items.Add("Quillón"))
                UCase(cb2.Items.Add("Quirihue"))
                UCase(cb2.Items.Add("Ránquil"))
                UCase(cb2.Items.Add("San Carlos"))
                UCase(cb2.Items.Add("San Fabián"))
                UCase(cb2.Items.Add("San Ignacio"))
                UCase(cb2.Items.Add("San Nicolás"))
                UCase(cb2.Items.Add("San Pedro de la Paz"))
                UCase(cb2.Items.Add("San Rosendo"))
                UCase(cb2.Items.Add("Santa Bárbara"))
                UCase(cb2.Items.Add("Santa Juana"))
                UCase(cb2.Items.Add("Talcahuano"))
                UCase(cb2.Items.Add("Tirúa"))
                UCase(cb2.Items.Add("Tomé"))
                UCase(cb2.Items.Add("Treguaco"))
                UCase(cb2.Items.Add("Tucapel"))
                UCase(cb2.Items.Add("Yumbel"))
                UCase(cb2.Items.Add("Yungay"))

            Case "X LA ARAUCANÍA "
                UCase(cb2.Items.Add("Angol"))
                UCase(cb2.Items.Add("Carahue"))
                UCase(cb2.Items.Add("Cholchol"))
                UCase(cb2.Items.Add("Collipulli"))
                UCase(cb2.Items.Add("Cunco"))
                UCase(cb2.Items.Add("Curacautín"))
                UCase(cb2.Items.Add("Curarrehue"))
                UCase(cb2.Items.Add("Ercilla"))
                UCase(cb2.Items.Add("Freire"))
                UCase(cb2.Items.Add("Galvarino"))
                UCase(cb2.Items.Add("Gorbea"))
                UCase(cb2.Items.Add("Lautaro"))
                UCase(cb2.Items.Add("Loncoche"))
                UCase(cb2.Items.Add("Lonquimay"))
                UCase(cb2.Items.Add("Los Sauces"))
                UCase(cb2.Items.Add("Lumaco"))
                UCase(cb2.Items.Add("Melipeuco"))
                UCase(cb2.Items.Add("Nueva Imperial"))
                UCase(cb2.Items.Add("Padre Las Casas"))
                UCase(cb2.Items.Add("Perquenco"))
                UCase(cb2.Items.Add("Pitrufquén"))
                UCase(cb2.Items.Add("Pucón"))
                UCase(cb2.Items.Add("Purén"))
                UCase(cb2.Items.Add("Renaico"))
                UCase(cb2.Items.Add("Saavedra"))
                UCase(cb2.Items.Add("Temuco"))
                UCase(cb2.Items.Add("Teodoro Schmidt"))
                UCase(cb2.Items.Add("Toltén"))
                UCase(cb2.Items.Add("Traiguén"))
                UCase(cb2.Items.Add("Victoria"))
                UCase(cb2.Items.Add("Vilcún"))
                UCase(cb2.Items.Add("Villarrica"))

            Case "XI LOS RÍOS "
                UCase(cb2.Items.Add("Corral"))
                UCase(cb2.Items.Add("Futrono"))
                UCase(cb2.Items.Add("La Unión"))
                UCase(cb2.Items.Add("Lago Ranco"))
                UCase(cb2.Items.Add("Lanco"))
                UCase(cb2.Items.Add("Los Lagos"))
                UCase(cb2.Items.Add("Máfil"))
                UCase(cb2.Items.Add("Mariquina"))
                UCase(cb2.Items.Add("Paillaco"))
                UCase(cb2.Items.Add("Panguipulli"))
                UCase(cb2.Items.Add("Río Bueno"))
                UCase(cb2.Items.Add("Valdivia"))

            Case "XII LOS LAGOS"
                UCase(cb2.Items.Add("Ancud"))
                UCase(cb2.Items.Add("Calbuco"))
                UCase(cb2.Items.Add("Castro"))
                UCase(cb2.Items.Add("Chaitén"))
                UCase(cb2.Items.Add("Chonchi"))
                UCase(cb2.Items.Add("Cochamó"))
                UCase(cb2.Items.Add("Curaco de Vélez"))
                UCase(cb2.Items.Add("Dalcahue"))
                UCase(cb2.Items.Add("Fresia"))
                UCase(cb2.Items.Add("Frutillar"))
                UCase(cb2.Items.Add("Futaleufú"))
                UCase(cb2.Items.Add("Hualaihué"))
                UCase(cb2.Items.Add("Llanquihue"))
                UCase(cb2.Items.Add("Los Muermos"))
                UCase(cb2.Items.Add("Maullín"))
                UCase(cb2.Items.Add("Osorno"))
                UCase(cb2.Items.Add("Palena"))
                UCase(cb2.Items.Add("Puerto Montt"))
                UCase(cb2.Items.Add("Puerto Octay"))
                UCase(cb2.Items.Add("Puerto Varas"))
                UCase(cb2.Items.Add("Puqueldón"))
                UCase(cb2.Items.Add("Purranque"))
                UCase(cb2.Items.Add("Puyehue"))
                UCase(cb2.Items.Add("Queilén"))
                UCase(cb2.Items.Add("Quellón"))
                UCase(cb2.Items.Add("Quemchi"))
                UCase(cb2.Items.Add("Quinchao"))
                UCase(cb2.Items.Add("Río Negro"))
                UCase(cb2.Items.Add("San Juan de la Costa"))
                UCase(cb2.Items.Add("San Pablo"))

            Case "XIII AISÉN"
                UCase(cb2.Items.Add("Aisén"))
                UCase(cb2.Items.Add("Chile Chico"))
                UCase(cb2.Items.Add("Cisnes"))
                UCase(cb2.Items.Add("Cochrane"))
                UCase(cb2.Items.Add("Coihaique"))
                UCase(cb2.Items.Add("Guaitecas"))
                UCase(cb2.Items.Add("Lago Verde"))
                UCase(cb2.Items.Add("O'Higgins"))
                UCase(cb2.Items.Add("Río Ibáñez"))
                UCase(cb2.Items.Add("Tortel"))

            Case "XIV MAGALLANES"
                UCase(cb2.Items.Add("Antártica"))
                UCase(cb2.Items.Add("Cabo de Hornos (Ex-Navarino)"))
                UCase(cb2.Items.Add("Laguna Blanca"))
                UCase(cb2.Items.Add("Natales"))
                UCase(cb2.Items.Add("Porvenir"))
                UCase(cb2.Items.Add("Primavera"))
                UCase(cb2.Items.Add("Punta Arenas"))
                UCase(cb2.Items.Add("Río Verde"))
                UCase(cb2.Items.Add("San Gregorio"))
                UCase(cb2.Items.Add("Timaukel"))
                UCase(cb2.Items.Add("Torres del Paine"))

            Case "XV METROPOLITANA"
                UCase(cb2.Items.Add("Alhué"))
                UCase(cb2.Items.Add("Buin"))
                UCase(cb2.Items.Add("Calera de Tango"))
                UCase(cb2.Items.Add("Cerrillos"))
                UCase(cb2.Items.Add("Cerro Navia"))
                UCase(cb2.Items.Add("Colina"))
                UCase(cb2.Items.Add("Conchalí"))
                UCase(cb2.Items.Add("Curacaví"))
                UCase(cb2.Items.Add("El Bosque"))
                UCase(cb2.Items.Add("El Monte"))
                UCase(cb2.Items.Add("El Monte"))
                UCase(cb2.Items.Add("Estación Central"))
                UCase(cb2.Items.Add("Huechuraba"))
                UCase(cb2.Items.Add("Independencia"))
                UCase(cb2.Items.Add("Isla de Maipo"))
                UCase(cb2.Items.Add("La Cisterna"))
                UCase(cb2.Items.Add("La Florida"))
                UCase(cb2.Items.Add("La Granja"))
                UCase(cb2.Items.Add("La Pintana"))
                UCase(cb2.Items.Add("La Reina"))
                UCase(cb2.Items.Add("Lampa"))
                UCase(cb2.Items.Add("Las Condes"))
                UCase(cb2.Items.Add("Lo Barnechea"))
                UCase(cb2.Items.Add("Lo Espejo"))
                UCase(cb2.Items.Add("Lo Prado"))
                UCase(cb2.Items.Add("Macul"))
                UCase(cb2.Items.Add("Maipú"))
                UCase(cb2.Items.Add("María Pinto"))
                UCase(cb2.Items.Add("Melipilla"))
                UCase(cb2.Items.Add("Ñuñoa"))
                UCase(cb2.Items.Add("Padre Hurtado"))
                UCase(cb2.Items.Add("Paine"))
                UCase(cb2.Items.Add("Pedro Aguirre Cerda"))
                UCase(cb2.Items.Add("Peñaflor"))
                UCase(cb2.Items.Add("Peñalolén"))
                UCase(cb2.Items.Add("Pirque"))
                UCase(cb2.Items.Add("Providencia"))
                UCase(cb2.Items.Add("Pudahuel"))
                UCase(cb2.Items.Add("Puente Alto"))
                UCase(cb2.Items.Add("Quilicura"))
                UCase(cb2.Items.Add("Quinta Normal"))
                UCase(cb2.Items.Add("Recoleta"))
                UCase(cb2.Items.Add("Renca"))
                UCase(cb2.Items.Add("San Bernardo"))
                UCase(cb2.Items.Add("San Joaquín"))
                UCase(cb2.Items.Add("San José de Maipo"))
                UCase(cb2.Items.Add("San Miguel"))
                UCase(cb2.Items.Add("San Pedro"))
                UCase(cb2.Items.Add("San Ramón"))
                UCase(cb2.Items.Add("Santiago"))
                UCase(cb2.Items.Add("Talagante"))
                UCase(cb2.Items.Add("Tiltil"))
                UCase(cb2.Items.Add("Vitacura"))
        End Select
    End Sub

    
End Class