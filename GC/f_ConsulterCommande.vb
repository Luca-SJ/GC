Public Class f_ConsulterCommande
    Private Sub f_ConsulterCommande_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = f_Principal
        dgvCommandes.DataSource = GestionBDD.GetLesTuples("commande")
        dgvCommandes.Columns(0).HeaderText = "id"
        dgvCommandes.Columns(1).HeaderText = "Date"
        dgvCommandes.Columns(2).HeaderText = "Client"
        dgvCommandes.Columns(3).HeaderText = "Statut"
    End Sub

    Private Sub btnMenuNav_Click(sender As Object, e As EventArgs) Handles btnMenuNav.Click
        f_Principal.panNavLeft.Visible = True
        Me.Close()
    End Sub

End Class