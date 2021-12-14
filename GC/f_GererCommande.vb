Public Class f_GererCommande
    Private Sub btnMenuNav_Click(sender As Object, e As EventArgs) Handles btnMenuNav.Click
        f_Principal.panNavLeft.Visible = True
        Me.Close()
    End Sub

    Private Sub f_GererCommande_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = f_Principal
        dgvCommandes.DataSource = GestionBDD.GetLesTuples("commande")
        dgvCommandes.Columns(0).HeaderText = "id"
        dgvCommandes.Columns(1).HeaderText = "Date"
        dgvCommandes.Columns(2).HeaderText = "Client"
        dgvCommandes.Columns(3).HeaderText = "Statut"
        dgvCommandes.Columns(4).HeaderText = "Reduction"
        dgvCommandes.Columns(5).HeaderText = "TauxReduction"
    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        f_AjoutCommande.ShowDialog()
    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        'f_SupprimerClient.ShowDialog()
    End Sub
End Class