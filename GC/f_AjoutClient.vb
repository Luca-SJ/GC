Public Class f_AjoutClient
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        dgvIdCount.DataSource = Requetes.GetNbClients()
        Dim idCount = dgvIdCount.Rows(0).Cells(0).Value
        Try
            GestionBDD.Executer_Requete_Action("Insert into client VALUES (" & idCount + 1 & ", '" & tbNom.Text.ToUpper() & "', '" & Fonctions.ToUpperFirstLetter(tbPrenom.Text) & "', '" & tbAdresse.Text.Replace("'", "''") & "', '" & tbCodePostal.Text & "', '" & tbVille.Text.ToUpper() & "')")
        Catch ex As Exception
            MessageBox.Show("Une erreur est survenu.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        MessageBox.Show("Client ajouté !", "SUCCES", MessageBoxButtons.OK)
        f_GererClient.dgvClients.DataSource = GestionBDD.GetLesTuples("client")
        Me.Close()
    End Sub
End Class