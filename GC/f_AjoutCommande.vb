Public Class f_AjoutCommande
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub f_AjoutCommande_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GestionBDD.AlimenterComboBox(comboB_Client, Requetes.GetClientEtId(), "NomCompletClient", "idClient")
        GestionBDD.AlimenterComboBox(comboB_Produit, Requetes.GetProduitEtId(), "LibelleProduit", "idProduit")
        dgvCommande.DataSource = Requetes.GetInfosCommande(Requetes.GetNbCommandes().Rows(0).Item(0))
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
                Requetes.UpdateCommande(id, DateTimePicker1.Value.Date, comboB_Client.ValueMember, 1, 1, tb_Reduction.Text)
            End If
        End If

        If checkB_NonPaye.Checked Then
            If tb_Reduction.Text = String.Empty Then
                Requetes.UpdateCommande(id, DateTimePicker1.Value.Date, comboB_Client.ValueMember, 0, 0, 0)
            Else
                Requetes.UpdateCommande(id, DateTimePicker1.Value.Date, comboB_Client.ValueMember, 0, 1, tb_Reduction.Text)
            End If
        End If
        Panel6.Visible = True
    End Sub

    Private Sub btn_Ajout_Click(sender As Object, e As EventArgs) Handles btn_Ajout.Click
        Requetes.InsertNewLigneDeCommande(Requetes.GetNbCommandes().Rows(0).Item(0), comboB_Produit.SelectedValue, tb_Qte.Text)
        dgvCommande.DataSource = Requetes.GetInfosCommande(Requetes.GetNbCommandes().Rows(0).Item(0))
    End Sub

    Private Sub f_AjoutCommande_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        f_GererCommande.Rafraichir()
    End Sub
End Class