Public Class f_ConsulterClient
    Private Sub f_ConsulterClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = f_Principal
        Try
            dgvClients.DataSource = GestionBDD.GetLesTuples("client")
            dgvClients.Columns(0).HeaderText = "id"
            dgvClients.Columns(1).HeaderText = "Nom"
            dgvClients.Columns(2).HeaderText = "Prénom"
            dgvClients.Columns(3).HeaderText = "Adresse"
            dgvClients.Columns(4).HeaderText = "Code Postal"
            dgvClients.Columns(5).HeaderText = "Ville"
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnMenuNav_Click(sender As Object, e As EventArgs) Handles btnMenuNav.Click
        f_Principal.panNavLeft.Visible = True
        Me.Close()
    End Sub

End Class