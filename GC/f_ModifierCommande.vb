Public Class f_ModifierCommande
    Public id As Integer
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub f_ModifierCommande_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvIdCount.DataSource = Requetes.GetInfoSurLaCommande(id)
        dgvCommande.DataSource = Requetes.GetInfosCommande(id)
        GestionBDD.AlimenterComboBox(comboB_Client, Requetes.GetClientEtId(), "NomCompletClient", "idClient")
        GestionBDD.AlimenterComboBox(comboB_Produit, Requetes.GetProduitEtId(), "LibelleProduit", "idProduit")
        Dim dtp As DateTime = dgvIdCount.Rows(0).Cells(0).Value
        Dim idClient As Integer = dgvIdCount.Rows(0).Cells(1).Value
        Dim statut As Integer = dgvIdCount.Rows(0).Cells(2).Value
        Dim reduc As Integer = dgvIdCount.Rows(0).Cells(4).Value
        DateTimePicker1.Value = dtp
        comboB_Client.SelectedValue = idClient
        If statut = 1 Then
            checkB_Paye.Checked = True
        Else
            checkB_NonPaye.Checked = True
        End If
        tb_Reduction.Text = reduc
    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click

    End Sub

    Private Sub btn_Ajout_Click(sender As Object, e As EventArgs) Handles btn_Ajout.Click
        Requetes.InsertNewLigneDeCommande(id, comboB_Produit.SelectedValue, tb_Qte.Text)
        dgvCommande.DataSource = Requetes.GetInfosCommande(id)
    End Sub
End Class