Public Class ConnexionEmploye
    Private Sub f_Connexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = f_Principal
        tbIdentifiant.Focus()
    End Sub

    Private Sub btnConnexion_Click(sender As Object, e As EventArgs) Handles btnConnexion.Click
        'GestionBDD.Machaine = "Data Source=sio2.btssio.net;Initial Catalog=mehraein1;User ID=" & tbIdentifiant.Text & ";Password=" & tbMotDePasse.Text & ";"
        GestionBDD.Machaine = "Data Source=sio2.btssio.net;Initial Catalog=mehraein1;User ID=" & "mehraein" & ";Password=" & "ixmfi" & ";"
        'GestionBDD.Machaine = "Data Source=localhost;Initial Catalog=localgc;User ID=" & "root" & ";Password=" & "" & ";"
        GestionBDD.SeConnecter()
        f_Principal.TypeClient = "employe"
        f_Accueil.Show()
        f_Accueil.WindowState = WindowState.Maximized
        Me.Close()
    End Sub

    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        ChoixTypeClient.Show()
        ChoixTypeClient.WindowState = WindowState.Maximized
        Me.Close()
    End Sub

    Private Sub tbIdentifiant_KeyUp(sender As Object, e As KeyEventArgs) Handles tbIdentifiant.KeyUp
        If e.KeyCode = 13 Then
            tbMotDePasse.Focus()
        End If
    End Sub

    Private Sub tbMotDePasse_KeyUp(sender As Object, e As KeyEventArgs) Handles tbMotDePasse.KeyUp
        If e.KeyCode = 13 Then
            btnConnexion.PerformClick()
        End If
    End Sub
End Class