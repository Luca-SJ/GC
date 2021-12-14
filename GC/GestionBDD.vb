Imports MySql.Data
Public Class GestionBDD
    Public Shared MaConnexion As New MySqlClient.MySqlConnection
    Public Shared MaCommande As New MySqlClient.MySqlCommand
    Public Shared MonAdapter As New MySqlClient.MySqlDataAdapter
    Public Shared MonJeuDeDonnees As New Data.DataSet
    Public Shared MaRequete As String
    'Public Shared Machaine As String = "Data Source=localhost;Initial Catalog=ppe_marchand_saintjore;User ID=root;Password="
    Public Shared Machaine As String

    Public Shared CptVue As Integer = 0
    Public Shared Sub SeConnecter()
        MaConnexion.ConnectionString = Machaine
        MaConnexion.Open()
        MonJeuDeDonnees = New Data.DataSet("IAPM")
        MonJeuDeDonnees.Clear()
        MaCommande.CommandType = CommandType.Text
        MaCommande.Connection = MaConnexion
    End Sub
    Public Shared Sub SeDeconnecter()
        MaConnexion.Close()
        MaConnexion.ConnectionString = ""
        MonJeuDeDonnees.Clear()
        MonJeuDeDonnees.Reset()
    End Sub
    Public Shared Function Executer_Requete_Select(ByVal marequeteselect As String) As Data.DataTable
        Dim result As New Data.DataTable
        'on crée une vue à chaque appel : penser à vider le dataset régulièrement pour ne
        'pas encombrer la mémoire - cptvue est un attribut statique à rajouter aux
        'attributs de votre classe GestionBDD
        Dim MaVue As String = "MaVue" & CptVue
        Try
            MaCommande.CommandText = marequeteselect
            MonAdapter.SelectCommand = MaCommande
            MonAdapter.Fill(MonJeuDeDonnees, MaVue)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        result = MonJeuDeDonnees.Tables(MaVue)
        CptVue = CptVue + 1
        Return result
    End Function
    Public Shared Sub Executer_Requete_Action(ByVal marequeteaction As String)
        Try
            MaCommande.CommandText = marequeteaction
            MaCommande.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erreur dans la tentative d'insert/update/delete",
           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Shared Function GetLesTuples(table As String)
        Return Executer_Requete_Select("call `GetAllFromTable`('" & table & "')")
    End Function

End Class
