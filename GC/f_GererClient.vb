Public Class f_GererClient
    Private Sub f_GererClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = f_Principal
        dgvClients.DataSource = GestionBDD.GetLesTuples("client")
        dgvClients.Columns(0).HeaderText = "id"
        dgvClients.Columns(1).HeaderText = "Nom"
        dgvClients.Columns(2).HeaderText = "Prénom"
        dgvClients.Columns(3).HeaderText = "Adresse"
        dgvClients.Columns(4).HeaderText = "Code Postal"
        dgvClients.Columns(5).HeaderText = "Ville"
    End Sub

    Private Sub btnMenuNav_Click(sender As Object, e As EventArgs) Handles btnMenuNav.Click
        f_Principal.panNavLeft.Visible = True
        Me.Close()
    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        f_AjoutClient.ShowDialog()
    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        f_SupprimerClient.ShowDialog()
    End Sub
End Class