Imports MySql.Data

Public Class ConnexionInternaute
    Private Sub f_Connexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = f_Principal
        tbIdentifiant.Focus()
    End Sub

    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        ChoixTypeClient.Show()
        Me.Close()
    End Sub

    Private Sub linkLabelInscription_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLabelInscription.LinkClicked
        f_InscriptionInternaute.Show()
        Me.Close()
    End Sub

    Private Sub btnConnexion_Click(sender As Object, e As EventArgs) Handles btnConnexion.Click
        Dim Bytes() As Byte = System.Text.Encoding.UTF8.GetBytes(tbPassword.Text)
        Dim HashofBytes() As Byte = New System.Security.Cryptography.SHA1Managed().ComputeHash(Bytes)
        Dim StrHash As String = Convert.ToBase64String(HashofBytes)

        'Voir le hash du mdp
        'Console.WriteLine(StrHash)

        'Using con As New MySqlClient.MySqlConnection("Data Source=localhost;Initial Catalog=localgc;User ID=" & "root" & ";Password=" & "" & ";")
        Using con As New MySqlClient.MySqlConnection("Data Source=sio2.btssio.net;Initial Catalog=mehraein1;User ID=" & "mehraein" & ";Password=" & "ixmfi" & ";")

                con.Open()

                Dim query As String = "SELECT COUNT(*) FROM internautes WHERE login=@login AND mdp=@mdp"
                Dim cmd As New MySqlClient.MySqlCommand(query, con)
                cmd.Parameters.Add(New MySqlClient.MySqlParameter("@login", tbIdentifiant.Text))
                cmd.Parameters.Add(New MySqlClient.MySqlParameter("@mdp", StrHash))

                Try

                If cmd.ExecuteScalar() = 1 Then
                    f_passerCommandeInternaute.login = tbIdentifiant.Text
                    f_passerCommandeInternaute.Show()
                    Me.Close()

                Else
                    MessageBox.Show("Identifiant ou mot de passe incorrect.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End If

                Catch ex As MySqlClient.MySqlException
                    MsgBox(ex.Message.ToString())
                End Try

            End Using

            tbPassword.Clear()
    End Sub

    Private Sub tbIdentifiant_KeyUp(sender As Object, e As KeyEventArgs) Handles tbIdentifiant.KeyUp
        If e.KeyCode = 13 Then
            tbPassword.Focus()
        End If

    End Sub

    Private Sub tbPassword_KeyUp(sender As Object, e As KeyEventArgs) Handles tbPassword.KeyUp
        If e.KeyCode = 13 Then
            btnConnexion.PerformClick()
        End If
    End Sub
End Class