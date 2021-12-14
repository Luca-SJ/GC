Public Class ChoixTypeClient
    Private Sub f_ChoixTypeClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = f_Principal
    End Sub

    Private Sub btn_Employe_Click(sender As Object, e As EventArgs) Handles btn_Employe.Click
        ConnexionEmploye.Show()
        Me.Close()
    End Sub

    Private Sub btn_Internaute_Click(sender As Object, e As EventArgs) Handles btn_Internaute.Click
        ConnexionInternaute.Show()
    End Sub
End Class