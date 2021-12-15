Public Class f_ModifierCommande
    Public id As Integer
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub f_ModifierCommande_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Rafraichir()
        GestionBDD.AlimenterComboBox(comboB_Client, Requetes.GetClientEtId(), "NomCompletClient", "idClient")
        GestionBDD.AlimenterComboBox(comboB_Produit, Requetes.GetProduitEtId(), "LibelleProduit", "idProduit")
        Dim dtp As DateTime = dgvIdCount.Rows(0).Cells(0).Value
        Dim idClient As Integer = dgvIdCount.Rows(0).Cells(1).Value
        Dim statut As Boolean = dgvIdCount.Rows(0).Cells(2).Value
        Dim reduc As Integer = dgvIdCount.Rows(0).Cells(4).Value
        DateTimePicker1.Value = dtp
        comboB_Client.SelectedValue = idClient
        If statut = True Then
            checkB_Paye.Checked = True
            checkB_NonPaye.Checked = False
        Else
            checkB_Paye.Checked = False
            checkB_NonPaye.Checked = True
        End If
        tb_Reduction.Text = reduc
    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        If checkB_Paye.Checked Then
            If tb_Reduction.Text = 0 Then
                Requetes.UpdateCommande(id, DateTimePicker1.Value.Date, comboB_Client.SelectedValue, 1, 0, tb_Reduction.Text)
            Else
                Requetes.UpdateCommande(id, DateTimePicker1.Value.Date, comboB_Client.SelectedValue, 1, 1, tb_Reduction.Text)
            End If
        End If

        If checkB_NonPaye.Checked Then
            If tb_Reduction.Text = 0 Then
                Requetes.UpdateCommande(id, DateTimePicker1.Value.Date, comboB_Client.SelectedValue, 0, 0, tb_Reduction.Text)
            Else
                Requetes.UpdateCommande(id, DateTimePicker1.Value.Date, comboB_Client.SelectedValue, 0, 1, tb_Reduction.Text)
            End If
        End If

    End Sub

    Private Sub btn_Ajout_Click(sender As Object, e As EventArgs) Handles btn_Ajout.Click
        Requetes.InsertNewLigneDeCommande(id, comboB_Produit.SelectedValue, tb_Qte.Text)
        dgvCommande.DataSource = Requetes.GetInfosCommande(id)
    End Sub

    Private Sub checkB_NonPaye_CheckedChanged(sender As Object, e As EventArgs) Handles checkB_NonPaye.CheckedChanged
        If checkB_NonPaye.Checked Then
            checkB_Paye.Checked = False
        End If
    End Sub

    Private Sub checkB_Paye_CheckedChanged(sender As Object, e As EventArgs) Handles checkB_Paye.CheckedChanged
        If checkB_Paye.Checked Then
            checkB_NonPaye.Checked = False
        End If
    End Sub

    Private Sub btn_Suppr_Click(sender As Object, e As EventArgs) Handles btn_Suppr.Click
        Dim idProduit As Integer = dgvCommande.SelectedRows.Item(0).Cells(0).Value
        Requetes.RemoveUnProduit(idProduit, id)
        Rafraichir()
    End Sub
    Private Function Rafraichir()
        dgvIdCount.DataSource = Requetes.GetInfoSurLaCommande(id)
        dgvCommande.DataSource = Requetes.GetInfosCommande(id)
    End Function

    Private Sub f_ModifierCommande_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        f_Principal.Show()
    End Sub

    Private Sub btn_SupprQte_Click(sender As Object, e As EventArgs) Handles btn_SupprQte.Click
        Dim nbrRow As Integer = dgvCommande.CurrentRow.Index
        Dim idProduit As Integer = dgvCommande.SelectedRows.Item(0).Cells(0).Value
        Try
            Dim qte As Integer = InputBox("Saisir une quantité à déduire du produit actuellement sélectionné :", "SUPRESSION D'UNE QUANTITÉ D'UN PRODUIT")

            Requetes.RemoveUnProduitQte(idProduit, id, qte)
            Rafraichir()
            If dgvCommande.Rows(nbrRow).Cells(2).Value = 0 Then
                Requetes.RemoveUnProduit(idProduit, id)
            End If
            Rafraichir()
        Catch ex As Exception

        End Try

    End Sub
End Class