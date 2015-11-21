Public Class acceso


    Private Sub txt2_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt2.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            btn.Focus()
        End If
    End Sub

    Private Sub txt1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            txt2.Focus()
        End If
    End Sub

    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click
        If UCase(txt1.Text) = "ADMIN" And txt2.Text = "admin1" Then
            Form1.Show()
            Form1.Focus()
            Me.Hide()
        Else
            MsgBox("Usuario y/o Contraseña no Validos", MsgBoxStyle.Critical And MsgBoxStyle.OkOnly, "Error de Usuario")
            txt1.Focus()
        End If
    End Sub

    Private Sub bt_sal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_sal.Click
        End
    End Sub
End Class