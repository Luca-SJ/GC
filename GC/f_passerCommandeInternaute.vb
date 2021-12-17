Public Class f_passerCommandeInternaute
    Private Sub f_passerCommandeInternaute_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = f_Principal
        GestionBDD.Machaine = "Data Source=sio2.btssio.net;Initial Catalog=mehraein1;User ID=" & "mehraein" & ";Password=" & "ixmfi" & ";"
        GestionBDD.SeConnecter()
        dgvPasserCommande.DataSource = Requetes.getLesProduits()
        'GestionBDD.SeDeconnecter()
    End Sub
End Class