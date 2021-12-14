Public Class f_Profil
    Private Sub f_Profil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = f_Principal
        labelDate.Text = ""
        labelPoste.Text = ""
        labelSalaire.Text = ""
    End Sub

    Private Sub btnMenuNav_Click(sender As Object, e As EventArgs) Handles btnMenuNav.Click
        f_Principal.panNavLeft.Visible = True
        Me.Close()
    End Sub
End Class