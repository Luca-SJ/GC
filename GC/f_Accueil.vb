Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient

Public Class f_Accueil
    Dim da1 As New MySqlDataAdapter("CALL `CATotalClient`();", GestionBDD.MaConnexion)
    Dim da2 = New MySqlDataAdapter("CALL `NbCommandesClients`();", GestionBDD.MaConnexion)
    Private Sub f_Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = f_Principal
        ComboBox1.SelectedIndex = 0
        LoadChart()
    End Sub

    Sub LoadChart()
        With Chart1
            .Series.Clear()
            .Series.Add("Series1")
        End With


        Dim ds As New DataSet
        da1.Fill(ds, "PrixHT")
        Chart1.DataSource = ds.Tables("PrixHT")
        Dim series1 As Series = Chart1.Series("Series1")
        series1.ChartType = SeriesChartType.Pie
        series1.Name = "Client"
        With Chart1
            .Series(series1.Name).XValueMember = "Client"
            .Series(series1.Name).YValueMembers = "PrixHT"
            .Series(0).LabelFormat = "{#,##0 €}"
            .Series(0).BorderWidth = 2
            .Series(0).BorderColor = Color.Black
            .Series(0).IsValueShownAsLabel = True
            .Series(0).LegendText = "#VALX (#PERCENT)"
            .Series(series1.Name).Font = New Font("Bahnschrift SemiLight", 10)
            .Series(series1.Name).LabelForeColor = Color.Black
            .Series(series1.Name).ShadowColor = Color.Black
            .Series(series1.Name).ShadowOffset = 5
            .BackColor = Color.FromArgb(40, 40, 40)
        End With
    End Sub
    Sub LoadChart2()
        With Chart1
            .Series.Clear()
            .Series.Add("Series1")
        End With


        Dim ds As New DataSet
        da2.Fill(ds, "NbCmd")
        Chart1.DataSource = ds.Tables("NbCmd")
        Dim series1 As Series = Chart1.Series("Series1")
        series1.ChartType = SeriesChartType.Pie
        series1.Name = "Client"
        With Chart1
            .Series(series1.Name).XValueMember = "Client"
            .Series(series1.Name).YValueMembers = "NbCmd"
            .Series(0).LabelFormat = "{#,##0}"
            .Series(0).BorderWidth = 2
            .Series(0).BorderColor = Color.Black
            .Series(0).IsValueShownAsLabel = True
            .Series(0).LegendText = "#VALX (#PERCENT)"
            .Series(series1.Name).Font = New Font("Bahnschrift SemiLight", 10)
            .Series(series1.Name).LabelForeColor = Color.Black
            .Series(series1.Name).ShadowColor = Color.Black
            .Series(series1.Name).ShadowOffset = 5
            .BackColor = Color.FromArgb(40, 40, 40)
        End With
    End Sub

    Private Sub btnMenuNav_Click(sender As Object, e As EventArgs) Handles btnMenuNav.Click
        'btnMenuNav.Visible = False
        f_Principal.panNavLeft.Visible = True
        Me.Close()
    End Sub

    Private Sub btnFermerMenu_Click(sender As Object, e As EventArgs)
        f_Principal.panNavLeft.Visible = False
        'btnMenuNav.Visible = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            LoadChart()
        ElseIf ComboBox1.SelectedIndex = 1 Then
            LoadChart2()
        End If
    End Sub
End Class