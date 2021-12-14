Public Class f_SupprimerClient
    Private Sub f_SupprimerClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvClients.DataSource = GestionBDD.GetLesTuples("client")
        dgvClients.Columns(0).HeaderText = "id"
        dgvClients.Columns(1).HeaderText = "Nom"
        dgvClients.Columns(2).HeaderText = "Prénom"
        dgvClients.Columns(3).HeaderText = "Adresse"
        dgvClients.Columns(4).HeaderText = "Code Postal"
        dgvClients.Columns(5).HeaderText = "Ville"
    End Sub

    Private Sub btnRechercher_Click(sender As Object, e As EventArgs) Handles btnRechercher.Click
        dgvClients.DataSource = GestionBDD.Executer_Requete_Select("
        Select * from client where NomClient like '" & tbNom.Text & "%'
            and PrenomClient like '" & tbPrenom.Text & "%' 
            and AdRueClient like '" & tbAdresse.Text.Replace("'", "''") & "%' 
            and AdCpClient like '" & tbCodePostal.Text & "%' 
            and AdVilleClient like '" & tbVille.Text & "%'")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        Try
            Dim result As DialogResult = MessageBox.Show("Voulez vous supprimer le client " & tbNom.Text & " " & tbPrenom.Text & " ?", "CONFIRMER?", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            If result = DialogResult.Yes Then
                GestionBDD.Executer_Requete_Action("Delete from client where IdClient = " & dgvClients.CurrentRow.Cells(0).Value & "")
            End If
            dgvClients.DataSource = GestionBDD.GetLesTuples("client")
            f_GererClient.dgvClients.DataSource = GestionBDD.GetLesTuples("client")
        Catch ex As Exception
            MessageBox.Show("Une erreur est survenu." & Chr(10) & "Avez-vous sélectionné un client ?", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class