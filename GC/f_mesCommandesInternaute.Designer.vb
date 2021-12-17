<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_mesCommandesInternaute
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
        Me.dgvMesCommandes = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btn_Retour = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvMesCommandes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMesCommandes
        '
        Me.dgvMesCommandes.AllowUserToAddRows = False
        Me.dgvMesCommandes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMesCommandes.BackgroundColor = System.Drawing.Color.White
        Me.dgvMesCommandes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMesCommandes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvMesCommandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMesCommandes.Location = New System.Drawing.Point(40, 91)
        Me.dgvMesCommandes.Name = "dgvMesCommandes"
        Me.dgvMesCommandes.ReadOnly = True
        Me.dgvMesCommandes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvMesCommandes.RowHeadersVisible = False
        Me.dgvMesCommandes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMesCommandes.Size = New System.Drawing.Size(720, 270)
        Me.dgvMesCommandes.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(171, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(459, 55)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "MES COMMANDES"
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Red
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(800, 30)
        Me.panel1.TabIndex = 17
        Me.panel1.Visible = False
        '
        'btn_Retour
        '
        Me.btn_Retour.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btn_Retour.FlatAppearance.BorderSize = 0
        Me.btn_Retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Retour.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Retour.ForeColor = System.Drawing.Color.White
        Me.btn_Retour.Location = New System.Drawing.Point(316, 401)
        Me.btn_Retour.Name = "btn_Retour"
        Me.btn_Retour.Size = New System.Drawing.Size(168, 28)
        Me.btn_Retour.TabIndex = 19
        Me.btn_Retour.Text = "RETOUR"
        Me.btn_Retour.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(210, 367)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(381, 28)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "CONSULTER DÉTAILS COMMANDE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'f_mesCommandesInternaute
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_Retour)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.dgvMesCommandes)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "f_mesCommandesInternaute"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "f_mesCommandesInternaute"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvMesCommandes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvMesCommandes As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents panel1 As Panel
    Friend WithEvents btn_Retour As Button
    Friend WithEvents Button1 As Button
End Class
