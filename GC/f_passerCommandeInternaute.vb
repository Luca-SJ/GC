Public Class f_passerCommandeInternaute
    Public login As String
    Public idClient As Integer
    Private Sub f_passerCommandeInternaute_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = f_Principal
        GestionBDD.Machaine = "Data Source=sio2.btssio.net;Initial Catalog=mehraein1;User ID=" & "mehraein" & ";Password=" & "ixmfi" & ";"
        GestionBDD.SeConnecter()
        dgvPasserCommande.DataSource = Requetes.getLesProduits()
        idClient = Requetes.getIdInternaute(login).Rows(0).Item(0)
        'GestionBDD.SeDeconnecter()
        'MsgBox(idClient, idClient)
    End Sub

    Private Sub btn_MesCommandes_Click(sender As Object, e As EventArgs) Handles btn_MesCommandes.Click
        f_mesCommandesInternaute.Show()
    End Sub
End Class