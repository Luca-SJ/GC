Imports GC.GestionBDD
Public Class Requetes
    Public Shared Function GetNbClients() As DataTable
        Return Executer_Requete_Select("select count(idClient) from Client")
    End Function
    Public Shared Function GetNbCommandes() As DataTable
        Return Executer_Requete_Select("select max(idCommande) from commande")
    End Function

    Public Shared Function GetLesClientsPlusCommande() As DataTable
        Return Executer_Requete_Select("select distinct(Cl.idClient), Cl.NomClient, Cl.PrenomClient, Cl.AdRueClient, Cl.AdCpClient, Cl.AdVilleClient from client Cl, commande Co where (Cl.idClient = Co.idCli);")
    End Function

    Public Shared Function GetClientEtId() As DataTable
        Return Executer_Requete_Select("select idClient, concat(NomClient, ' ', PrenomClient) as NomCompletClient from client;")
    End Function
    Public Shared Function GetProduitEtId() As DataTable
        Return Executer_Requete_Select("select idProduit, LibelleProduit from produit;")
    End Function
    Public Shared Function GetInfosCommande(idCommande As String) As DataTable
        Return Executer_Requete_Select("select P.LibelleProduit as Produit, LDC.QuantiteCom as Quantitée from produit P, lignedecommande LDC where (P.idProduit = LDC.idProduit) and LDC.idCommande = " & idCommande & ";")
    End Function

    Public Shared Function InsertNewCommande(idCommande As String) As DataTable
        Executer_Requete_Action("Insert into commande values (" & idCommande & ", NULL, NULL, 0, 0, NULL);")
    End Function

    Public Shared Function UpdateCommande(idCommande As String, dtp As DateTime, idCli As Integer, statut As Integer, possederReduction As Integer, taux As Integer) As DataTable
        Executer_Requete_Action("Update commande set DateCommande = '" & dtp.ToShortDateString() & "', idCli = " & idCli & ", payeCommande = " & statut & ", reductionCommande = " & possederReduction & ", tauxReduction = '" & taux & "' where idCommande = " & idCommande & ";")
    End Function

    Public Shared Function InsertNewLigneDeCommande(idCommande As String, idProduit As String, Qte As String) As DataTable
        Executer_Requete_Action("Insert into lignedecommande values (" & idCommande & ", " & idProduit & ", " & Qte & ");")
    End Function
    Public Shared Function DeleteCommande(idCommande As Integer) As DataTable
        Executer_Requete_Action("Delete from lignedecommande where idCommande = " & idCommande & ";")
        Executer_Requete_Action("Delete from commande where idCommande = " & idCommande & ";")
    End Function
End Class
