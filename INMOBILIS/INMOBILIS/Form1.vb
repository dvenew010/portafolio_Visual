Public Class Form1


    Private Sub CLIENTEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLIENTEToolStripMenuItem.Click
        cliente.Show()
        cliente.Focus()
        cliente.Size = New Size(650, 520)

    End Sub

    Private Sub PROPIEDADToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PROPIEDADToolStripMenuItem.Click
        propiedades.Show()
        propiedades.Focus()
        propiedades.Size = New Size(650, 520)

    End Sub

    Private Sub SALIRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALIRToolStripMenuItem.Click
        End
    End Sub

End Class
