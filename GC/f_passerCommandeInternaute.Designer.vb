<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_passerCommandeInternaute
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
        Me.dgvPasserCommande = New System.Windows.Forms.DataGridView()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.dgvPasserCommande, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(228, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 55)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "COMMANDER"
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Red
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(800, 30)
        Me.panel1.TabIndex = 9
        Me.panel1.Visible = False
        '
        'dgvPasserCommande
        '
        Me.dgvPasserCommande.AllowUserToAddRows = False
        Me.dgvPasserCommande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPasserCommande.BackgroundColor = System.Drawing.Color.White
        Me.dgvPasserCommande.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPasserCommande.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvPasserCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPasserCommande.Location = New System.Drawing.Point(40, 91)
        Me.dgvPasserCommande.Name = "dgvPasserCommande"
        Me.dgvPasserCommande.ReadOnly = True
        Me.dgvPasserCommande.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvPasserCommande.RowHeadersVisible = False
        Me.dgvPasserCommande.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPasserCommande.Size = New System.Drawing.Size(720, 270)
        Me.dgvPasserCommande.TabIndex = 14
        '
        'btnAjouter
        '
        Me.btnAjouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnAjouter.FlatAppearance.BorderSize = 0
        Me.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjouter.ForeColor = System.Drawing.Color.White
        Me.btnAjouter.Location = New System.Drawing.Point(40, 367)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(257, 28)
        Me.btnAjouter.TabIndex = 15
        Me.btnAjouter.Text = "AJOUTER AU PANIER"
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(303, 367)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(257, 28)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "VOIR PANIER"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(566, 367)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(194, 28)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "PASSER COMMANDE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'f_passerCommandeInternaute
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.dgvPasserCommande)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "f_passerCommandeInternaute"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "f_passerCommandeInternaute"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvPasserCommande, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents panel1 As Panel
    Friend WithEvents dgvPasserCommande As DataGridView
    Friend WithEvents btnAjouter As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
