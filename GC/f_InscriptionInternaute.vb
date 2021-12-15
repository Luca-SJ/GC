Imports System.IO
Imports System.Security.Cryptography

Public Class f_InscriptionInternaute
    Private Sub btnSinscrire_Click(sender As Object, e As EventArgs) Handles btnSinscrire.Click
        Dim Bytes() As Byte = System.Text.Encoding.UTF8.GetBytes(tbPassword.Text)
        Dim HashofBytes() As Byte = New System.Security.Cryptography.SHA1Managed().ComputeHash(Bytes)
        Dim StrHash As String = Convert.ToBase64String(HashofBytes)

        'GestionBDD.Machaine = "Data Source=localhost;Initial Catalog=localgc;User ID=" & "root" & ";Password=" & "" & ";"
        GestionBDD.Machaine = "Data Source=sio2.btssio.net;Initial Catalog=mehraein1;User ID=" & "mehraein" & ";Password=" & "ixmfi" & ";"
        GestionBDD.SeConnecter()
        dgvIdCount.DataSource = Requetes.GetNbClients()
        Dim idCount = dgvIdCount.Rows(0).Cells(0).Value
        Try
            GestionBDD.Executer_Requete_Action("Insert into client VALUES (" & idCount + 1 & ", '" & tbNom.Text.ToUpper() & "', '" & Fonctions.ToUpperFirstLetter(tbPrenom.Text) & "', '" & tbAdresse.Text.Replace("'", "''") & "', '" & tbCodePostal.Text & "', '" & tbVille.Text.ToUpper() & "')")
            GestionBDD.Executer_Requete_Action("Insert into internautes VALUES (" & idCount + 1 & ", '" & tbIdentifiant.Text & "', '" & StrHash & "', '" & DateTime.Today.ToString("yyyy-MM-dd") & "')")
        Catch ex As Exception
            MessageBox.Show("Une erreur est survenu.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        GestionBDD.SeDeconnecter()
    End Sub

    Private Sub f_InscriptionInternaute_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = f_Principal
    End Sub


End Class