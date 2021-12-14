<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_Profil
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labelDate = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.labelPoste = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.labelSalaire = New System.Windows.Forms.Label()
        Me.btnMenuNav = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(270, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 73)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PROFIL"
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Red
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(810, 30)
        Me.panel1.TabIndex = 1
        Me.panel1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(239, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DATE EMBAUCHE :"
        '
        'labelDate
        '
        Me.labelDate.AutoSize = True
        Me.labelDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDate.ForeColor = System.Drawing.Color.White
        Me.labelDate.Location = New System.Drawing.Point(465, 176)
        Me.labelDate.Name = "labelDate"
        Me.labelDate.Size = New System.Drawing.Size(72, 25)
        Me.labelDate.TabIndex = 3
        Me.labelDate.Text = "DATE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(357, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "POSTE :"
        '
        'labelPoste
        '
        Me.labelPoste.AutoSize = True
        Me.labelPoste.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPoste.ForeColor = System.Drawing.Color.White
        Me.labelPoste.Location = New System.Drawing.Point(465, 211)
        Me.labelPoste.Name = "labelPoste"
        Me.labelPoste.Size = New System.Drawing.Size(88, 25)
        Me.labelPoste.TabIndex = 5
        Me.labelPoste.Text = "POSTE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(338, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 25)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "SALAIRE :"
        '
        'labelSalaire
        '
        Me.labelSalaire.AutoSize = True
        Me.labelSalaire.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSalaire.ForeColor = System.Drawing.Color.White
        Me.labelSalaire.Location = New System.Drawing.Point(465, 246)
        Me.labelSalaire.Name = "labelSalaire"
        Me.labelSalaire.Size = New System.Drawing.Size(107, 25)
        Me.labelSalaire.TabIndex = 7
        Me.labelSalaire.Text = "SALAIRE"
        '
        'btnMenuNav
        '
        Me.btnMenuNav.BackgroundImage = Global.GC.My.Resources.Resources.img_527805_modified
        Me.btnMenuNav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMenuNav.FlatAppearance.BorderSize = 0
        Me.btnMenuNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuNav.Location = New System.Drawing.Point(12, 36)
        Me.btnMenuNav.Name = "btnMenuNav"
        Me.btnMenuNav.Size = New System.Drawing.Size(80, 80)
        Me.btnMenuNav.TabIndex = 9
        Me.btnMenuNav.UseVisualStyleBackColor = False
        '
        'f_Profil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(810, 492)
        Me.Controls.Add(Me.btnMenuNav)
        Me.Controls.Add(Me.labelSalaire)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.labelPoste)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.labelDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "f_Profil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profil"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents labelDate As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents labelPoste As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents labelSalaire As Label
    Friend WithEvents btnMenuNav As Button
End Class
