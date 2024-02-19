<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarteBingo
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.Lbl_Joueur = New System.Windows.Forms.Label()
        Me.LbL_B = New System.Windows.Forms.Label()
        Me.Lbl_I = New System.Windows.Forms.Label()
        Me.Lbl_N = New System.Windows.Forms.Label()
        Me.Lbl_G = New System.Windows.Forms.Label()
        Me.LbL_O = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lbl_Joueur
        '
        Me.Lbl_Joueur.BackColor = System.Drawing.Color.CadetBlue
        Me.Lbl_Joueur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_Joueur.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Joueur.ForeColor = System.Drawing.SystemColors.Info
        Me.Lbl_Joueur.Location = New System.Drawing.Point(-2, 0)
        Me.Lbl_Joueur.Name = "Lbl_Joueur"
        Me.Lbl_Joueur.Size = New System.Drawing.Size(182, 30)
        Me.Lbl_Joueur.TabIndex = 0
        Me.Lbl_Joueur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbL_B
        '
        Me.LbL_B.BackColor = System.Drawing.Color.CadetBlue
        Me.LbL_B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbL_B.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbL_B.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LbL_B.Location = New System.Drawing.Point(0, 29)
        Me.LbL_B.Name = "LbL_B"
        Me.LbL_B.Size = New System.Drawing.Size(36, 30)
        Me.LbL_B.TabIndex = 1
        Me.LbL_B.Text = "B"
        Me.LbL_B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_I
        '
        Me.Lbl_I.BackColor = System.Drawing.Color.CadetBlue
        Me.Lbl_I.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_I.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_I.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Lbl_I.Location = New System.Drawing.Point(36, 29)
        Me.Lbl_I.Name = "Lbl_I"
        Me.Lbl_I.Size = New System.Drawing.Size(36, 30)
        Me.Lbl_I.TabIndex = 2
        Me.Lbl_I.Text = "I"
        Me.Lbl_I.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_N
        '
        Me.Lbl_N.BackColor = System.Drawing.Color.CadetBlue
        Me.Lbl_N.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_N.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_N.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Lbl_N.Location = New System.Drawing.Point(72, 29)
        Me.Lbl_N.Name = "Lbl_N"
        Me.Lbl_N.Size = New System.Drawing.Size(36, 30)
        Me.Lbl_N.TabIndex = 3
        Me.Lbl_N.Text = "N"
        Me.Lbl_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_G
        '
        Me.Lbl_G.BackColor = System.Drawing.Color.CadetBlue
        Me.Lbl_G.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_G.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_G.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Lbl_G.Location = New System.Drawing.Point(108, 29)
        Me.Lbl_G.Name = "Lbl_G"
        Me.Lbl_G.Size = New System.Drawing.Size(36, 30)
        Me.Lbl_G.TabIndex = 4
        Me.Lbl_G.Text = "G"
        Me.Lbl_G.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbL_O
        '
        Me.LbL_O.BackColor = System.Drawing.Color.CadetBlue
        Me.LbL_O.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbL_O.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbL_O.ForeColor = System.Drawing.SystemColors.MenuText
        Me.LbL_O.Location = New System.Drawing.Point(144, 29)
        Me.LbL_O.Name = "LbL_O"
        Me.LbL_O.Size = New System.Drawing.Size(36, 30)
        Me.LbL_O.TabIndex = 5
        Me.LbL_O.Text = "O"
        Me.LbL_O.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CarteBingo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.Controls.Add(Me.LbL_O)
        Me.Controls.Add(Me.Lbl_G)
        Me.Controls.Add(Me.Lbl_N)
        Me.Controls.Add(Me.Lbl_I)
        Me.Controls.Add(Me.LbL_B)
        Me.Controls.Add(Me.Lbl_Joueur)
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.Name = "CarteBingo"
        Me.Size = New System.Drawing.Size(179, 210)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Lbl_Joueur As Label
    Friend WithEvents LbL_B As Label
    Friend WithEvents Lbl_I As Label
    Friend WithEvents Lbl_N As Label
    Friend WithEvents Lbl_G As Label
    Friend WithEvents LbL_O As Label
End Class
