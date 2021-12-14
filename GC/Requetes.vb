Imports GC.GestionBDD
Public Class Requetes
    Public Shared Function GetNbClients() As DataTable
        Return Executer_Requete_Select("select count(idClient) from Client")
    End Function

    Public Shared Function GetLesClientsPlusCommande() As DataTable
        Return Executer_Requete_Select("select distinct(Cl.idClient), Cl.NomClient, Cl.PrenomClient, Cl.AdRueClient, Cl.AdCpClient, Cl.AdVilleClient from client Cl, commande Co where (Cl.idClient = Co.idCli);")
    End Function

End Class
