Public Class f_mesCommandesInternaute
    Private Sub f_mesCommandesInternaute_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = f_Principal
        dgvMesCommandes.DataSource = Requetes.getCommandeByIdCli(f_passerCommandeInternaute.idClient)
    End Sub

    Private Sub btn_Retour_Click(sender As Object, e As EventArgs) Handles btn_Retour.Click
        f_passerCommandeInternaute.Show()
        Me.Close()
    End Sub
End Class