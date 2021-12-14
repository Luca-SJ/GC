Imports System.Security
Imports System.Text

Public Class Fonctions
    Public Shared Function ToUpperFirstLetter(ByVal text As String) As String
        If String.IsNullOrEmpty(text) Then
            Return text
        End If

        Dim array() As Char = text.ToCharArray

        array(0) = Char.ToUpper(array(0))

        Return New String(array)
    End Function

End Class
