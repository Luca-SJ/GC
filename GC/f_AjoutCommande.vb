Public Class f_AjoutCommande
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub f_AjoutCommande_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GestionBDD.AlimenterComboBox(comboB_Client, Requetes.GetClientEtId(), "NomCompletClient", "idClient")
        GestionBDD.AlimenterComboBox(comboB_Produit, Requetes.GetProduitEtId(), "LibelleProduit", "idProduit")
        dgvCommande.DataSource = Requetes.GetInfosCommande(Requetes.GetNbCommandes().Rows(0).Item(0))
        comboB_Client.SelectedIndex = -1
        checkB_NonPaye.Checked = True
    End Sub

    Private Sub checkB_Paye_CheckedChanged(sender As Object, e As EventArgs) Handles checkB_Paye.CheckedChanged
        If checkB_Paye.Checked Then
            checkB_NonPaye.Checked = False
        End If
    End Sub

    Private Sub checkB_NonPaye_CheckedChanged(sender As Object, e As EventArgs) Handles checkB_NonPaye.CheckedChanged
        If checkB_NonPaye.Checked Then
            checkB_Paye.Checked = False
        End If
    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        Dim id As Integer = Requetes.GetNbCommandes().Rows(0).Item(0)
        If checkB_Paye.Checked Then
            If tb_Reduction.Text = String.Empty Then
                Requetes.UpdateCommande(id, DateTimePicker1.Value.Date, comboB_Client.SelectedValue, 1, 0, 0)
            Else
                Requetes.UpdateCommande(id, DateTimePicker1.Value.Date, comboB_Client.SelectedValue, 1, 1, tb_Reduction.Text)
            End If
        End If

        If checkB_NonPaye.Checked Then
            If tb_Reduction.Text = String.Empty Then
                Requetes.UpdateCommande(id, DateTimePicker1.Value.Date, comboB_Client.SelectedValue, 0, 0, 0)
            Else
                Requetes.UpdateCommande(id, DateTimePicker1.Value.Date, comboB_Client.SelectedValue, 0, 1, tb_Reduction.Text)
            End If
        End If
        Panel6.Visible = True
        Panel8.Visible = True
    End Sub

    Private Sub btn_Ajout_Click(sender As Object, e As EventArgs) Handles btn_Ajout.Click
        Dim prixTotal As Decimal
        Requetes.InsertNewLigneDeCommande(Requetes.GetNbCommandes().Rows(0).Item(0), comboB_Produit.SelectedValue, tb_Qte.Text)
        dgvCommande.DataSource = Requetes.GetInfosCommande(Requetes.GetNbCommandes().Rows(0).Item(0))
        For Each ligne As DataGridViewRow In dgvCommande.Rows
            Dim idProduit = ligne.Cells(0).Value
            Dim qte = ligne.Cells(2).Value
            Dim lignePrix As Decimal = Requetes.GetPrixProdQte(idProduit, qte).Rows(0).Item(0)
            prixTotal = prixTotal + lignePrix
        Next
        tb_Total.Text = prixTotal
    End Sub

    Private Sub f_AjoutCommande_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim id As Integer = Requetes.GetNbCommandes().Rows(0).Item(0)
        Dim countNbrProduits As Integer = Requetes.GetNbProduitCommande(id).Rows(0).Item(0)
        If countNbrProduits = 0 Then
            Requetes.DeleteCommande(id)
        End If
        Panel6.Visible = False
        Panel8.Visible = False
        f_GererCommande.Rafraichir()
        tb_Qte.Text = ""
        tb_Total.Text = ""
        f_Principal.Show()
    End Sub

    Private Sub tb_Reduction_TextChanged(sender As Object, e As EventArgs) Handles tb_Reduction.TextChanged

    End Sub

    Private Sub comboB_Client_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboB_Client.SelectedIndexChanged

    End Sub

    Private Sub comboB_Client_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboB_Client.SelectedValueChanged

    End Sub

    Private Sub checkB_UseReduc_CheckedChanged(sender As Object, e As EventArgs) Handles checkB_UseReduc.CheckedChanged

    End Sub

    Private Sub comboB_Client_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles comboB_Client.SelectionChangeCommitted
        tb_Reduction.Text = Requetes.GetReductionClient(comboB_Client.SelectedValue).Rows(0).Item(0).ToString()
    End Sub
End Class