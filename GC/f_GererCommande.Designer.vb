﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_GererCommande
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
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnMenuNav = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgwClients = New System.Windows.Forms.DataGridView()
        CType(Me.dgwClients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'btnMenuNav
        '
        Me.btnMenuNav.BackgroundImage = Global.GC.My.Resources.Resources.img_527805_modified
        Me.btnMenuNav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMenuNav.FlatAppearance.BorderSize = 0
        Me.btnMenuNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuNav.Location = New System.Drawing.Point(12, 36)
        Me.btnMenuNav.Name = "btnMenuNav"
        Me.btnMenuNav.Size = New System.Drawing.Size(80, 80)
        Me.btnMenuNav.TabIndex = 2
        Me.btnMenuNav.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(320, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 29)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "COMMANDES"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(286, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 55)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "GESTION"
        '
        'dgwClients
        '
        Me.dgwClients.AllowUserToAddRows = False
        Me.dgwClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwClients.BackgroundColor = System.Drawing.Color.White
        Me.dgwClients.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgwClients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgwClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwClients.Location = New System.Drawing.Point(25, 140)
        Me.dgwClients.Name = "dgwClients"
        Me.dgwClients.ReadOnly = True
        Me.dgwClients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgwClients.RowHeadersVisible = False
        Me.dgwClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwClients.Size = New System.Drawing.Size(763, 314)
        Me.dgwClients.TabIndex = 9
        '
        'f_GererCommande
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(810, 492)
        Me.Controls.Add(Me.dgwClients)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMenuNav)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "f_GererCommande"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GererCommande"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgwClients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panel1 As Panel
    Friend WithEvents btnMenuNav As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgwClients As DataGridView
End Class
