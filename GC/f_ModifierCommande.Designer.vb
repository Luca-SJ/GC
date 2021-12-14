<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class f_ModifierCommande
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvIdCount = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.comboB_Client = New System.Windows.Forms.ComboBox()
        Me.tb_Reduction = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.checkB_NonPaye = New System.Windows.Forms.CheckBox()
        Me.checkB_Paye = New System.Windows.Forms.CheckBox()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.tb_Qte = New System.Windows.Forms.TextBox()
        Me.btn_Ajout = New System.Windows.Forms.Button()
        Me.comboB_Produit = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.dgvCommande = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvIdCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.dgvCommande, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Panel1.Controls.Add(Me.dgvIdCount)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(10, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(380, 380)
        Me.Panel1.TabIndex = 11
        '
        'dgvIdCount
        '
        Me.dgvIdCount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIdCount.Location = New System.Drawing.Point(187, 21)
        Me.dgvIdCount.Name = "dgvIdCount"
        Me.dgvIdCount.Size = New System.Drawing.Size(18, 19)
        Me.dgvIdCount.TabIndex = 14
        Me.dgvIdCount.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "REDUCTION"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(62, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 24)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "STATUT"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CLIENT"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DATE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.comboB_Client)
        Me.Panel2.Controls.Add(Me.tb_Reduction)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.checkB_NonPaye)
        Me.Panel2.Controls.Add(Me.checkB_Paye)
        Me.Panel2.Controls.Add(Me.btnAjouter)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(51, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(279, 255)
        Me.Panel2.TabIndex = 10
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(93, 61)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(174, 22)
        Me.DateTimePicker1.TabIndex = 17
        '
        'comboB_Client
        '
        Me.comboB_Client.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboB_Client.Enabled = False
        Me.comboB_Client.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboB_Client.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboB_Client.FormattingEnabled = True
        Me.comboB_Client.Location = New System.Drawing.Point(93, 87)
        Me.comboB_Client.Name = "comboB_Client"
        Me.comboB_Client.Size = New System.Drawing.Size(174, 24)
        Me.comboB_Client.TabIndex = 16
        '
        'tb_Reduction
        '
        Me.tb_Reduction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_Reduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Reduction.Location = New System.Drawing.Point(137, 145)
        Me.tb_Reduction.Name = "tb_Reduction"
        Me.tb_Reduction.Size = New System.Drawing.Size(130, 22)
        Me.tb_Reduction.TabIndex = 15
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(160, 115)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 24)
        Me.Panel3.TabIndex = 15
        '
        'checkB_NonPaye
        '
        Me.checkB_NonPaye.AutoSize = True
        Me.checkB_NonPaye.ForeColor = System.Drawing.Color.White
        Me.checkB_NonPaye.Location = New System.Drawing.Point(171, 122)
        Me.checkB_NonPaye.Name = "checkB_NonPaye"
        Me.checkB_NonPaye.Size = New System.Drawing.Size(73, 17)
        Me.checkB_NonPaye.TabIndex = 14
        Me.checkB_NonPaye.Text = "Non Payé"
        Me.checkB_NonPaye.UseVisualStyleBackColor = True
        '
        'checkB_Paye
        '
        Me.checkB_Paye.AutoSize = True
        Me.checkB_Paye.ForeColor = System.Drawing.Color.White
        Me.checkB_Paye.Location = New System.Drawing.Point(101, 122)
        Me.checkB_Paye.Name = "checkB_Paye"
        Me.checkB_Paye.Size = New System.Drawing.Size(50, 17)
        Me.checkB_Paye.TabIndex = 13
        Me.checkB_Paye.Text = "Payé"
        Me.checkB_Paye.UseVisualStyleBackColor = True
        '
        'btnAjouter
        '
        Me.btnAjouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnAjouter.FlatAppearance.BorderSize = 0
        Me.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjouter.ForeColor = System.Drawing.Color.White
        Me.btnAjouter.Location = New System.Drawing.Point(10, 201)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(257, 28)
        Me.btnAjouter.TabIndex = 12
        Me.btnAjouter.Text = "METTRE A JOUR"
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(26, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(226, 33)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "INFORMATIONS"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(396, 10)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(670, 380)
        Me.Panel4.TabIndex = 12
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.btnClose)
        Me.Panel5.Controls.Add(Me.dgvCommande)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(664, 374)
        Me.Panel5.TabIndex = 10
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.tb_Qte)
        Me.Panel6.Controls.Add(Me.btn_Ajout)
        Me.Panel6.Controls.Add(Me.comboB_Produit)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Location = New System.Drawing.Point(53, 321)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(559, 50)
        Me.Panel6.TabIndex = 21
        Me.Panel6.Visible = False
        '
        'tb_Qte
        '
        Me.tb_Qte.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_Qte.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Qte.Location = New System.Drawing.Point(386, 2)
        Me.tb_Qte.Name = "tb_Qte"
        Me.tb_Qte.Size = New System.Drawing.Size(88, 22)
        Me.tb_Qte.TabIndex = 18
        '
        'btn_Ajout
        '
        Me.btn_Ajout.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btn_Ajout.FlatAppearance.BorderSize = 0
        Me.btn_Ajout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Ajout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Ajout.ForeColor = System.Drawing.Color.White
        Me.btn_Ajout.Location = New System.Drawing.Point(480, 2)
        Me.btn_Ajout.Name = "btn_Ajout"
        Me.btn_Ajout.Size = New System.Drawing.Size(76, 22)
        Me.btn_Ajout.TabIndex = 18
        Me.btn_Ajout.Text = "AJOUT"
        Me.btn_Ajout.UseVisualStyleBackColor = False
        '
        'comboB_Produit
        '
        Me.comboB_Produit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboB_Produit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboB_Produit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboB_Produit.FormattingEnabled = True
        Me.comboB_Produit.Location = New System.Drawing.Point(94, 0)
        Me.comboB_Produit.Name = "comboB_Produit"
        Me.comboB_Produit.Size = New System.Drawing.Size(174, 24)
        Me.comboB_Produit.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(274, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 24)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "QUANTITÉ"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(-4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 24)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "PRODUIT"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(616, 9)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(36, 28)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'dgvCommande
        '
        Me.dgvCommande.AllowUserToAddRows = False
        Me.dgvCommande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCommande.BackgroundColor = System.Drawing.Color.White
        Me.dgvCommande.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCommande.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCommande.Location = New System.Drawing.Point(53, 60)
        Me.dgvCommande.Name = "dgvCommande"
        Me.dgvCommande.ReadOnly = True
        Me.dgvCommande.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvCommande.RowHeadersVisible = False
        Me.dgvCommande.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCommande.Size = New System.Drawing.Size(559, 255)
        Me.dgvCommande.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(253, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(158, 33)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "PRODUITS"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'f_ModifierCommande
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1078, 400)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "f_ModifierCommande"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "f_ModifierCommande"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvIdCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.dgvCommande, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvIdCount As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents comboB_Client As ComboBox
    Friend WithEvents tb_Reduction As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents checkB_NonPaye As CheckBox
    Friend WithEvents checkB_Paye As CheckBox
    Friend WithEvents btnAjouter As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents tb_Qte As TextBox
    Friend WithEvents btn_Ajout As Button
    Friend WithEvents comboB_Produit As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents dgvCommande As DataGridView
    Friend WithEvents Label10 As Label
End Class
