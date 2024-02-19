<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Grp_Selection_Bingo = New System.Windows.Forms.GroupBox()
        Me.RdBtn_CartePleine = New System.Windows.Forms.RadioButton()
        Me.Cmd_recommencerPartie = New System.Windows.Forms.Button()
        Me.CMD_Deconnexion = New System.Windows.Forms.Button()
        Me.Lbl_VitesseBoulier = New System.Windows.Forms.Label()
        Me.TkBr_VitesseBoulier = New System.Windows.Forms.TrackBar()
        Me.Num_NbrJoueurs = New System.Windows.Forms.NumericUpDown()
        Me.Lbl_NbrJoueur = New System.Windows.Forms.Label()
        Me.RdBtn_QuatreCoins = New System.Windows.Forms.RadioButton()
        Me.RdBtn_BingoStandard = New System.Windows.Forms.RadioButton()
        Me.Cmd_Pause = New System.Windows.Forms.Button()
        Me.Cmd_CommencerPartie = New System.Windows.Forms.Button()
        Me.Timer_Delai_Boulier = New System.Windows.Forms.Timer(Me.components)
        Me.Lbl_BouleSortie = New System.Windows.Forms.Label()
        Me.Grp_Selection_Bingo.SuspendLayout()
        CType(Me.TkBr_VitesseBoulier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num_NbrJoueurs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grp_Selection_Bingo
        '
        Me.Grp_Selection_Bingo.BackColor = System.Drawing.Color.CadetBlue
        Me.Grp_Selection_Bingo.Controls.Add(Me.RdBtn_CartePleine)
        Me.Grp_Selection_Bingo.Controls.Add(Me.Cmd_recommencerPartie)
        Me.Grp_Selection_Bingo.Controls.Add(Me.CMD_Deconnexion)
        Me.Grp_Selection_Bingo.Controls.Add(Me.Lbl_VitesseBoulier)
        Me.Grp_Selection_Bingo.Controls.Add(Me.TkBr_VitesseBoulier)
        Me.Grp_Selection_Bingo.Controls.Add(Me.Num_NbrJoueurs)
        Me.Grp_Selection_Bingo.Controls.Add(Me.Lbl_NbrJoueur)
        Me.Grp_Selection_Bingo.Controls.Add(Me.RdBtn_QuatreCoins)
        Me.Grp_Selection_Bingo.Controls.Add(Me.RdBtn_BingoStandard)
        Me.Grp_Selection_Bingo.Controls.Add(Me.Cmd_Pause)
        Me.Grp_Selection_Bingo.Controls.Add(Me.Cmd_CommencerPartie)
        Me.Grp_Selection_Bingo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp_Selection_Bingo.Location = New System.Drawing.Point(12, 312)
        Me.Grp_Selection_Bingo.Name = "Grp_Selection_Bingo"
        Me.Grp_Selection_Bingo.Size = New System.Drawing.Size(179, 498)
        Me.Grp_Selection_Bingo.TabIndex = 0
        Me.Grp_Selection_Bingo.TabStop = False
        Me.Grp_Selection_Bingo.Text = "Sélectionner"
        '
        'RdBtn_CartePleine
        '
        Me.RdBtn_CartePleine.Location = New System.Drawing.Point(9, 91)
        Me.RdBtn_CartePleine.Name = "RdBtn_CartePleine"
        Me.RdBtn_CartePleine.Size = New System.Drawing.Size(124, 22)
        Me.RdBtn_CartePleine.TabIndex = 11
        Me.RdBtn_CartePleine.TabStop = True
        Me.RdBtn_CartePleine.Text = "Carte Pleine"
        Me.RdBtn_CartePleine.UseVisualStyleBackColor = True
        '
        'Cmd_recommencerPartie
        '
        Me.Cmd_recommencerPartie.BackColor = System.Drawing.Color.Orange
        Me.Cmd_recommencerPartie.Location = New System.Drawing.Point(15, 369)
        Me.Cmd_recommencerPartie.Name = "Cmd_recommencerPartie"
        Me.Cmd_recommencerPartie.Size = New System.Drawing.Size(136, 51)
        Me.Cmd_recommencerPartie.TabIndex = 10
        Me.Cmd_recommencerPartie.Text = "Recommencer la partie"
        Me.Cmd_recommencerPartie.UseVisualStyleBackColor = False
        '
        'CMD_Deconnexion
        '
        Me.CMD_Deconnexion.BackColor = System.Drawing.Color.Orange
        Me.CMD_Deconnexion.Location = New System.Drawing.Point(15, 426)
        Me.CMD_Deconnexion.Name = "CMD_Deconnexion"
        Me.CMD_Deconnexion.Size = New System.Drawing.Size(136, 51)
        Me.CMD_Deconnexion.TabIndex = 9
        Me.CMD_Deconnexion.Text = "Déconnexion"
        Me.CMD_Deconnexion.UseVisualStyleBackColor = False
        '
        'Lbl_VitesseBoulier
        '
        Me.Lbl_VitesseBoulier.Location = New System.Drawing.Point(12, 314)
        Me.Lbl_VitesseBoulier.Name = "Lbl_VitesseBoulier"
        Me.Lbl_VitesseBoulier.Size = New System.Drawing.Size(160, 25)
        Me.Lbl_VitesseBoulier.TabIndex = 8
        Me.Lbl_VitesseBoulier.Text = "Vitesse du Boulier"
        Me.Lbl_VitesseBoulier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TkBr_VitesseBoulier
        '
        Me.TkBr_VitesseBoulier.AutoSize = False
        Me.TkBr_VitesseBoulier.LargeChange = 6
        Me.TkBr_VitesseBoulier.Location = New System.Drawing.Point(9, 342)
        Me.TkBr_VitesseBoulier.Name = "TkBr_VitesseBoulier"
        Me.TkBr_VitesseBoulier.Size = New System.Drawing.Size(157, 21)
        Me.TkBr_VitesseBoulier.TabIndex = 7
        Me.TkBr_VitesseBoulier.TickFrequency = 5
        Me.TkBr_VitesseBoulier.Value = 5
        '
        'Num_NbrJoueurs
        '
        Me.Num_NbrJoueurs.Location = New System.Drawing.Point(18, 162)
        Me.Num_NbrJoueurs.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.Num_NbrJoueurs.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Num_NbrJoueurs.Name = "Num_NbrJoueurs"
        Me.Num_NbrJoueurs.Size = New System.Drawing.Size(133, 26)
        Me.Num_NbrJoueurs.TabIndex = 5
        Me.Num_NbrJoueurs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Num_NbrJoueurs.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Lbl_NbrJoueur
        '
        Me.Lbl_NbrJoueur.Location = New System.Drawing.Point(6, 125)
        Me.Lbl_NbrJoueur.Name = "Lbl_NbrJoueur"
        Me.Lbl_NbrJoueur.Size = New System.Drawing.Size(148, 25)
        Me.Lbl_NbrJoueur.TabIndex = 4
        Me.Lbl_NbrJoueur.Text = "Nombre Joueurs"
        '
        'RdBtn_QuatreCoins
        '
        Me.RdBtn_QuatreCoins.Location = New System.Drawing.Point(6, 62)
        Me.RdBtn_QuatreCoins.Name = "RdBtn_QuatreCoins"
        Me.RdBtn_QuatreCoins.Size = New System.Drawing.Size(147, 22)
        Me.RdBtn_QuatreCoins.TabIndex = 3
        Me.RdBtn_QuatreCoins.Text = "Quatre Coins"
        Me.RdBtn_QuatreCoins.UseVisualStyleBackColor = True
        '
        'RdBtn_BingoStandard
        '
        Me.RdBtn_BingoStandard.Location = New System.Drawing.Point(6, 34)
        Me.RdBtn_BingoStandard.Name = "RdBtn_BingoStandard"
        Me.RdBtn_BingoStandard.Size = New System.Drawing.Size(153, 30)
        Me.RdBtn_BingoStandard.TabIndex = 2
        Me.RdBtn_BingoStandard.Text = "Standard"
        Me.RdBtn_BingoStandard.UseVisualStyleBackColor = True
        '
        'Cmd_Pause
        '
        Me.Cmd_Pause.BackColor = System.Drawing.Color.Orange
        Me.Cmd_Pause.Location = New System.Drawing.Point(15, 203)
        Me.Cmd_Pause.Name = "Cmd_Pause"
        Me.Cmd_Pause.Size = New System.Drawing.Size(136, 51)
        Me.Cmd_Pause.TabIndex = 1
        Me.Cmd_Pause.Text = "Pause"
        Me.Cmd_Pause.UseVisualStyleBackColor = False
        '
        'Cmd_CommencerPartie
        '
        Me.Cmd_CommencerPartie.BackColor = System.Drawing.Color.Orange
        Me.Cmd_CommencerPartie.Location = New System.Drawing.Point(15, 260)
        Me.Cmd_CommencerPartie.Name = "Cmd_CommencerPartie"
        Me.Cmd_CommencerPartie.Size = New System.Drawing.Size(136, 51)
        Me.Cmd_CommencerPartie.TabIndex = 0
        Me.Cmd_CommencerPartie.Text = "Commencer Partie"
        Me.Cmd_CommencerPartie.UseVisualStyleBackColor = False
        '
        'Timer_Delai_Boulier
        '
        Me.Timer_Delai_Boulier.Interval = 1000
        '
        'Lbl_BouleSortie
        '
        Me.Lbl_BouleSortie.BackColor = System.Drawing.Color.Orange
        Me.Lbl_BouleSortie.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_BouleSortie.Location = New System.Drawing.Point(1201, 84)
        Me.Lbl_BouleSortie.Name = "Lbl_BouleSortie"
        Me.Lbl_BouleSortie.Size = New System.Drawing.Size(216, 142)
        Me.Lbl_BouleSortie.TabIndex = 11
        Me.Lbl_BouleSortie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1429, 850)
        Me.Controls.Add(Me.Lbl_BouleSortie)
        Me.Controls.Add(Me.Grp_Selection_Bingo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Grp_Selection_Bingo.ResumeLayout(False)
        CType(Me.TkBr_VitesseBoulier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num_NbrJoueurs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Grp_Selection_Bingo As GroupBox
    Friend WithEvents Num_NbrJoueurs As NumericUpDown
    Friend WithEvents Lbl_NbrJoueur As Label
    Friend WithEvents RdBtn_QuatreCoins As RadioButton
    Friend WithEvents RdBtn_BingoStandard As RadioButton
    Friend WithEvents Cmd_Pause As Button
    Friend WithEvents Cmd_CommencerPartie As Button
    Friend WithEvents Lbl_VitesseBoulier As Label
    Friend WithEvents TkBr_VitesseBoulier As TrackBar
    Friend WithEvents CMD_Deconnexion As Button
    Friend WithEvents Cmd_recommencerPartie As Button
    Friend WithEvents Timer_Delai_Boulier As Timer
    Friend WithEvents Lbl_BouleSortie As Label
    Friend WithEvents RdBtn_CartePleine As RadioButton
End Class
