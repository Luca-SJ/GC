<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChoixTypeClient
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
        Me.btn_Employe = New System.Windows.Forms.Button()
        Me.btn_Internaute = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.Label1.Location = New System.Drawing.Point(265, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Utilisateur"
        '
        'btn_Employe
        '
        Me.btn_Employe.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_Employe.FlatAppearance.BorderSize = 0
        Me.btn_Employe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Employe.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Employe.Location = New System.Drawing.Point(147, 179)
        Me.btn_Employe.Name = "btn_Employe"
        Me.btn_Employe.Size = New System.Drawing.Size(250, 100)
        Me.btn_Employe.TabIndex = 2
        Me.btn_Employe.Text = "Employé"
        Me.btn_Employe.UseVisualStyleBackColor = False
        '
        'btn_Internaute
        '
        Me.btn_Internaute.BackColor = System.Drawing.Color.Moccasin
        Me.btn_Internaute.FlatAppearance.BorderSize = 0
        Me.btn_Internaute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Internaute.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Internaute.Location = New System.Drawing.Point(403, 179)
        Me.btn_Internaute.Name = "btn_Internaute"
        Me.btn_Internaute.Size = New System.Drawing.Size(250, 100)
        Me.btn_Internaute.TabIndex = 3
        Me.btn_Internaute.Text = "Internaute"
        Me.btn_Internaute.UseVisualStyleBackColor = False
        '
        'ChoixTypeClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_Internaute)
        Me.Controls.Add(Me.btn_Employe)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ChoixTypeClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChoixTypeClient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Employe As Button
    Friend WithEvents btn_Internaute As Button
End Class
