Public Class f_Principal
    Public TypeClient As String
    Private Sub f_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChoixTypeClient.Show()
        ChoixTypeClient.WindowState = WindowState.Maximized
        'Console.WriteLine(DateTime.Today.ToString("yyyy-dd-MM"))

    End Sub
    Private Sub btnCommande_Click(sender As Object, e As EventArgs) Handles btnCommande.Click
        If btnCommandeGerer.Visible = False Then
            btnCommandeGerer.Visible = True
            btnCommandeConsulter.Visible = True
            btnCommande.BackColor = Color.FromArgb(90, 90, 90)
        Else
            btnCommandeGerer.Visible = False
            btnCommandeConsulter.Visible = False
            btnCommande.BackColor = Color.FromArgb(80, 80, 80)
        End If

    End Sub

    Private Sub btnClient_Click(sender As Object, e As EventArgs) Handles btnClient.Click
        If btnClientGerer.Visible = False Then
            btnClientGerer.Visible = True
            btnClientConsulter.Visible = True
            btnClient.BackColor = Color.FromArgb(100, 100, 100)
        Else
            btnClientGerer.Visible = False
            btnClientConsulter.Visible = False
            btnClient.BackColor = Color.FromArgb(80, 80, 80)
        End If

    End Sub

    Private Sub btnFermerMenu_Click(sender As Object, e As EventArgs) Handles btnFermerMenu.Click
        panNavLeft.Visible = False
    End Sub

    Private Sub btnClientConsulter_Click(sender As Object, e As EventArgs) Handles btnClientConsulter.Click
        f_ConsulterClient.Show()
        panNavLeft.Visible = False
    End Sub

    Private Sub btnCommandeConsulter_Click(sender As Object, e As EventArgs) Handles btnCommandeConsulter.Click
        f_ConsulterCommande.Show()
        panNavLeft.Visible = False
    End Sub

    Private Sub btnCommandeGerer_Click(sender As Object, e As EventArgs) Handles btnCommandeGerer.Click
        f_GererCommande.Show()
        panNavLeft.Visible = False
    End Sub

    Private Sub btnAccueil_Click(sender As Object, e As EventArgs) Handles btnAccueil.Click
        panNavLeft.Visible = False
        f_Accueil.Show()
    End Sub

    Private Sub btnClientGerer_Click(sender As Object, e As EventArgs) Handles btnClientGerer.Click
        panNavLeft.Visible = False
        f_GererClient.Show()
    End Sub

    Private Sub btnProfil_Click(sender As Object, e As EventArgs) Handles btnProfil.Click
        panNavLeft.Visible = False
        f_Profil.Show()
    End Sub
End Class
