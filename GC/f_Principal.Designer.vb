<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class f_Principal
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btnClientConsulter = New System.Windows.Forms.Button()
        Me.btnClientGerer = New System.Windows.Forms.Button()
        Me.btnClient = New System.Windows.Forms.Button()
        Me.btnCommandeConsulter = New System.Windows.Forms.Button()
        Me.btnCommandeGerer = New System.Windows.Forms.Button()
        Me.btnCommande = New System.Windows.Forms.Button()
        Me.btnAccueil = New System.Windows.Forms.Button()
        Me.panNavLeft = New System.Windows.Forms.Panel()
        Me.btnProfil = New System.Windows.Forms.Button()
        Me.btnFermerMenu = New System.Windows.Forms.Button()
        Me.panNavLeft.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'btnClientConsulter
        '
        Me.btnClientConsulter.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnClientConsulter.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClientConsulter.FlatAppearance.BorderSize = 0
        Me.btnClientConsulter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientConsulter.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientConsulter.ForeColor = System.Drawing.Color.White
        Me.btnClientConsulter.Location = New System.Drawing.Point(0, 240)
        Me.btnClientConsulter.Name = "btnClientConsulter"
        Me.btnClientConsulter.Size = New System.Drawing.Size(800, 40)
        Me.btnClientConsulter.TabIndex = 6
        Me.btnClientConsulter.Text = "CONSULTER"
        Me.btnClientConsulter.UseVisualStyleBackColor = False
        Me.btnClientConsulter.Visible = False
        '
        'btnClientGerer
        '
        Me.btnClientGerer.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnClientGerer.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClientGerer.FlatAppearance.BorderSize = 0
        Me.btnClientGerer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientGerer.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientGerer.ForeColor = System.Drawing.Color.White
        Me.btnClientGerer.Location = New System.Drawing.Point(0, 200)
        Me.btnClientGerer.Name = "btnClientGerer"
        Me.btnClientGerer.Size = New System.Drawing.Size(800, 40)
        Me.btnClientGerer.TabIndex = 5
        Me.btnClientGerer.Text = "GERER"
        Me.btnClientGerer.UseVisualStyleBackColor = False
        Me.btnClientGerer.Visible = False
        '
        'btnClient
        '
        Me.btnClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnClient.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClient.FlatAppearance.BorderSize = 0
        Me.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClient.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClient.ForeColor = System.Drawing.Color.White
        Me.btnClient.Location = New System.Drawing.Point(0, 160)
        Me.btnClient.Name = "btnClient"
        Me.btnClient.Size = New System.Drawing.Size(800, 40)
        Me.btnClient.TabIndex = 4
        Me.btnClient.Text = "- CLIENT -"
        Me.btnClient.UseVisualStyleBackColor = False
        '
        'btnCommandeConsulter
        '
        Me.btnCommandeConsulter.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnCommandeConsulter.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCommandeConsulter.FlatAppearance.BorderSize = 0
        Me.btnCommandeConsulter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCommandeConsulter.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommandeConsulter.ForeColor = System.Drawing.Color.White
        Me.btnCommandeConsulter.Location = New System.Drawing.Point(0, 120)
        Me.btnCommandeConsulter.Name = "btnCommandeConsulter"
        Me.btnCommandeConsulter.Size = New System.Drawing.Size(800, 40)
        Me.btnCommandeConsulter.TabIndex = 3
        Me.btnCommandeConsulter.Text = "CONSULTER"
        Me.btnCommandeConsulter.UseVisualStyleBackColor = False
        Me.btnCommandeConsulter.Visible = False
        '
        'btnCommandeGerer
        '
        Me.btnCommandeGerer.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnCommandeGerer.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCommandeGerer.FlatAppearance.BorderSize = 0
        Me.btnCommandeGerer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCommandeGerer.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommandeGerer.ForeColor = System.Drawing.Color.White
        Me.btnCommandeGerer.Location = New System.Drawing.Point(0, 80)
        Me.btnCommandeGerer.Name = "btnCommandeGerer"
        Me.btnCommandeGerer.Size = New System.Drawing.Size(800, 40)
        Me.btnCommandeGerer.TabIndex = 2
        Me.btnCommandeGerer.Text = "GERER"
        Me.btnCommandeGerer.UseVisualStyleBackColor = False
        Me.btnCommandeGerer.Visible = False
        '
        'btnCommande
        '
        Me.btnCommande.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnCommande.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCommande.FlatAppearance.BorderSize = 0
        Me.btnCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCommande.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommande.ForeColor = System.Drawing.Color.White
        Me.btnCommande.Location = New System.Drawing.Point(0, 40)
        Me.btnCommande.Name = "btnCommande"
        Me.btnCommande.Size = New System.Drawing.Size(800, 40)
        Me.btnCommande.TabIndex = 1
        Me.btnCommande.Text = "- COMMANDE -"
        Me.btnCommande.UseVisualStyleBackColor = False
        '
        'btnAccueil
        '
        Me.btnAccueil.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnAccueil.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAccueil.FlatAppearance.BorderSize = 0
        Me.btnAccueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccueil.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccueil.ForeColor = System.Drawing.Color.White
        Me.btnAccueil.Location = New System.Drawing.Point(0, 0)
        Me.btnAccueil.Name = "btnAccueil"
        Me.btnAccueil.Size = New System.Drawing.Size(800, 40)
        Me.btnAccueil.TabIndex = 0
        Me.btnAccueil.Text = "- ACCUEIL -"
        Me.btnAccueil.UseVisualStyleBackColor = False
        '
        'panNavLeft
        '
        Me.panNavLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.panNavLeft.Controls.Add(Me.btnProfil)
        Me.panNavLeft.Controls.Add(Me.btnFermerMenu)
        Me.panNavLeft.Controls.Add(Me.btnClientConsulter)
        Me.panNavLeft.Controls.Add(Me.btnClientGerer)
        Me.panNavLeft.Controls.Add(Me.btnClient)
        Me.panNavLeft.Controls.Add(Me.btnCommandeConsulter)
        Me.panNavLeft.Controls.Add(Me.btnCommandeGerer)
        Me.panNavLeft.Controls.Add(Me.btnCommande)
        Me.panNavLeft.Controls.Add(Me.btnAccueil)
        Me.panNavLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panNavLeft.Location = New System.Drawing.Point(0, 0)
        Me.panNavLeft.Name = "panNavLeft"
        Me.panNavLeft.Size = New System.Drawing.Size(800, 450)
        Me.panNavLeft.TabIndex = 3
        Me.panNavLeft.Visible = False
        '
        'btnProfil
        '
        Me.btnProfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnProfil.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnProfil.FlatAppearance.BorderSize = 0
        Me.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfil.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfil.ForeColor = System.Drawing.Color.White
        Me.btnProfil.Location = New System.Drawing.Point(0, 370)
        Me.btnProfil.Name = "btnProfil"
        Me.btnProfil.Size = New System.Drawing.Size(800, 40)
        Me.btnProfil.TabIndex = 8
        Me.btnProfil.Text = "- PROFIL -"
        Me.btnProfil.UseVisualStyleBackColor = False
        '
        'btnFermerMenu
        '
        Me.btnFermerMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFermerMenu.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnFermerMenu.FlatAppearance.BorderSize = 0
        Me.btnFermerMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFermerMenu.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFermerMenu.ForeColor = System.Drawing.Color.White
        Me.btnFermerMenu.Location = New System.Drawing.Point(0, 410)
        Me.btnFermerMenu.Name = "btnFermerMenu"
        Me.btnFermerMenu.Size = New System.Drawing.Size(800, 40)
        Me.btnFermerMenu.TabIndex = 7
        Me.btnFermerMenu.Text = "• FERMER •"
        Me.btnFermerMenu.UseVisualStyleBackColor = False
        Me.btnFermerMenu.Visible = False
        '
        'f_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.panNavLeft)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "f_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GC - GestionClient"
        Me.panNavLeft.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnClientConsulter As Button
    Friend WithEvents btnClientGerer As Button
    Friend WithEvents btnClient As Button
    Friend WithEvents btnCommandeConsulter As Button
    Friend WithEvents btnCommandeGerer As Button
    Friend WithEvents btnCommande As Button
    Friend WithEvents btnAccueil As Button
    Friend WithEvents panNavLeft As Panel
    Friend WithEvents btnProfil As Button
    Friend WithEvents btnFermerMenu As Button
End Class
