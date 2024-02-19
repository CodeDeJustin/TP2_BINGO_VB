''                     PROGRAMME BINGO
''
'' DESCRIPTION: Ce programme a été développé dans le cadre du cours de P34.
''              Ce programme simule une partie de Bingo.
''              L'utilisateur doit d'abord choisir le type de jeu qu'il souhaite 
''              entre : le bingo standard, le bingo quatre coins ou le bingo carte pleine.
''              L'utilisateur doit entrer le nombre de carte qu'il souhaite, ce qui corresond au nombre de joueur.
''              Une fois le nombre de carte sélectionnée, l'utilisateur peut entamer une partie, avec les
''              modalités choisies, en appuyant sur commencer partie.
''              Une fois la partie lancé, les cartes des joueurs apparaissent et le boulier se met en marche.
''              Au fût et à mesure que les numéros sortent sur le boulier, il y a un comparatif qui s'effectue
''              entre le boulier, le tableau d'affichage et les cartes des joueurs. 
''              Le boulier ne s'arrête que lorsqu'un joueur atteint le Bingo.
''              Le programme mentionne le numéro du joueur qui a le Bingo.
''              Par la suite il affiche le nombre de numéro qui sont sortie avant le Bingo.
''              Une nouvelle fenêtre demande à l'utilisateur si il souhaite poursuivre la partie.
''              À tout moment le joueur peut recommencer la partie ou peut se déconnecter.
'' 
'' FAIT PAR :   JUSTIN ALLARD & MARIE-EVE COUTURE
''
'' FAIT LE :    FÉVRIER 2023
'' RÉVISÉ LE : 


Imports System.Drawing.Imaging
Imports System.Net.Http.Headers
Imports System.Net.NetworkInformation
Imports System.Net.Security
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography.X509Certificates
Imports System.Text

Public Class Form1

    Public Rnd As New Random()
    Dim Carte(19) As CarteBingo
    Dim tableau(4, 14) As TableauAffichage
    Public boule As New Boulier

    Public lettre As Boulier
    Dim compteurNombreSortie As Integer
    Public nombreBingoSortie As New List(Of Integer)

    'OUVERTURE DU PROGRAMME
    Private Sub BINGO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Cmd_recommencerPartie.Enabled = False
        Cmd_Pause.Enabled = False
        Cmd_CommencerPartie.Enabled = False
        TkBr_VitesseBoulier.Enabled = False
        Montrer_Tableau_Affichage()
    End Sub

    'DÉBUT DE LA PARTIE DE BINGO

    Public Sub Cmd_CommencerPartie_Click(sender As Object, e As EventArgs) Handles Cmd_CommencerPartie.Click

        Try
            Montrer_Carte_Bingo()
            For i = 0 To Carte.GetUpperBound(0)
                If i <= Num_NbrJoueurs.Value - 1 Then
                    Carte(i).Visible = True
                Else
                    Carte(i).Visible = False
                    Carte(i).Enabled = False
                End If
            Next

            RdBtn_BingoStandard.Enabled = False
            RdBtn_CartePleine.Enabled = False
            RdBtn_QuatreCoins.Enabled = False
            Num_NbrJoueurs.Enabled = False
            Cmd_CommencerPartie.Enabled = False
            Cmd_recommencerPartie.Enabled = True
            Cmd_Pause.Enabled = True
            TkBr_VitesseBoulier.Enabled = True
            Timer_Delai_Boulier.Enabled = True

        Catch ex As Exception
            MessageBox.Show("Désolé nous éprouvons actuellement un problème.")
            MessageBox.Show("L'application va redémarrer")
            Application.Restart()
        End Try
    End Sub
    ''' <summary>
    ''' MÉTHODE QUI PERMET DE FAIRE AFFICHER LES CARTES BINGO AUX UTILISATEURS
    ''' </summary>
    Public Sub Montrer_Carte_Bingo()
        Try
            For i = 0 To Carte.GetUpperBound(0)
                Carte(i) = New CarteBingo
                With Carte(i)
                    .Visible = True
                    .Left = 200 + (i Mod 9) * 185
                    .Top = 325 + (i \ 9) * 220
                    .NoJoueur = "Joueur " & i + 1
                End With
                Me.Controls.Add(Carte(i))
            Next

        Catch ex As Exception
            MessageBox.Show("Désolé nous éprouvons actuellement un problème.")
            MessageBox.Show("L'application va redémarrer")
            Application.Restart()
        End Try

    End Sub
    ''' <summary>
    ''' MÉTHODE QUI PERMET DE FAIRE AFFICHER LE TABLEAU DES NUMEROS SORTIES AUX UTILISATEURS
    ''' </summary>
    Private Sub Montrer_Tableau_Affichage()
        Dim i As Integer
        Dim j As Integer

        Try
            For i = 0 To tableau.GetUpperBound(0)
                For j = 0 To tableau.GetUpperBound(1)
                    tableau(i, j) = New TableauAffichage
                    With tableau(i, j)
                        .Visible = True
                        .Left = 200 + (i Mod 15) * 55
                        .Top = 40 + (i \ 15) * 48
                    End With
                    Me.Controls.Add(tableau(i, j))

                Next
            Next
            MessageBox.Show("Bienvenue au bingo en Ligne", "Mot de Bienvenue")
            MessageBox.Show("Veuillez sélectionner le type ainsi que le nombre de carte Bingo que vous souhaitez, prendre note que le minimum est de 10 et le maximum de 20 ! Ensuite Appuyez sur Commencer la partie", "Instruction d'une partie")
            MessageBox.Show("Prenez note que vous pouvez toujours recommencer la partie, mettre sur pause ou encore vous déconnectez")

        Catch ex As Exception
            MessageBox.Show("Désolé nous éprouvons actuellement un problème.")
            MessageBox.Show("L'application va redémarrer")
            Application.Restart()
        End Try

    End Sub
    Private Sub CMD_Deconnexion_Click(sender As Object, e As EventArgs) Handles CMD_Deconnexion.Click
        Application.Exit()
    End Sub

    Private Sub Cmd_recommencerPartie_Click(sender As Object, e As EventArgs) Handles Cmd_recommencerPartie.Click
        Dim reponse As DialogResult
        RdBtn_BingoStandard.Enabled = True
        RdBtn_CartePleine.Enabled = True
        RdBtn_QuatreCoins.Enabled = True
        Num_NbrJoueurs.Enabled = True
        Cmd_CommencerPartie.Enabled = True
        Cmd_Pause.Enabled = False
        Cmd_recommencerPartie.Enabled = False
        TkBr_VitesseBoulier.Enabled = False
        Timer_Delai_Boulier.Enabled = False
        reponse = MessageBox.Show("Etes-vous sur de vouloir recommencer ? ", "Recommencer", MessageBoxButtons.YesNo)
        If reponse = DialogResult.Yes Then
            Application.Restart()
        ElseIf reponse = DialogResult.No Then
            Timer_Delai_Boulier.Enabled = True

        End If
    End Sub

    Public Sub Timer_Delai_Boulier_Tick(sender As Object, e As EventArgs) Handles Timer_Delai_Boulier.Tick
        Dim boule As New Boulier
        Dim typeJeu As Integer
        Dim couleur As Color = Color.DarkGoldenrod
        Dim i, j, k As Integer
        Dim lettre As New Boulier
        Dim numeroSortie As Integer
        Dim l As String = ""
        Dim BingoL, BingoC, BingoD, BingoQC, BingoCP As Boolean

        Dim cpt As Integer

        Try
            ' PERMET DE SAVOIR QUEL TYPE DE jEU : STANDARD/4 COINS/CARTE PLEINE
            typeJeu = QuelTypeJeu()

            ' VA CHERCHER LE NUMERO ALÉATOIRE DANS LA CLASSE BOULIER ET REVIENT AVEC LE NOMBRE
            numeroSortie = boule.GenererBouleSortieLabel()

            'VA CHERCHER LA LETTRE CORRESPONDANTE AU NUMERO SORTIE
            l = lettre.SelectionnerLettreCorrespondante(numeroSortie)

            ' CONDITION POUR QUE LE NUMERO ET LA LETTRE SOIT AFFICHER SUR LE LABEL
            If nombreBingoSortie.Contains(numeroSortie) Then
                Lbl_BouleSortie.BackColor = Color.Orange
                Lbl_BouleSortie.Text = ""

            Else
                ' PERMET D'AFFICHER LE NOMBRE SORTIE ET LA LETTRE SUR LE LABEL
                Lbl_BouleSortie.BackColor = Color.Orange
                Lbl_BouleSortie.Text = l & numeroSortie.ToString
                nombreBingoSortie.Add(numeroSortie)
                compteurNombreSortie = compteurNombreSortie + 1
            End If

            For i = 0 To Carte.GetUpperBound(0)
                'COMPARER LE NUMÉRO ET LE TABLEAU POUR CHANGER LA COULEUR DU TABLEAU
                tableau(j, k).AfficherBouleSortie(numeroSortie, couleur)

                'COMPARER LE NUMÉRO ET LES CARTES JOUEUR POOUR CHANGER LA COULEUR DES CARTES
                Carte(i).VerifierBoule(numeroSortie, couleur)

                'VÉRIFICATION DU NUMÉRO SORTIE SELON LE TYPE DE JEU SÉLECTIONNÉ
                If typeJeu = 1 Then
                    BingoL = Carte(i).VerifierBingoStandardLigne(typeJeu, couleur)
                    BingoC = Carte(i).VerifierBingoStandardColonne(typeJeu, couleur)
                    BingoD = Carte(i).VerifierBingoStandardDiagonale(typeJeu, couleur)
                ElseIf typeJeu = 2 Then
                    BingoQC = Carte(i).VerifierBingoQuatreCoin(typeJeu, couleur)
                ElseIf typeJeu = 3 Then
                    BingoCP = Carte(i).VerifierCartePleine(typeJeu, couleur)
                End If

                'PERMET DE GÉRER LES "FAUX GAGNANTS" 
                If Carte(i).Visible = False Or Carte(i).Enabled = False Then
                    BingoL = False
                    BingoC = False
                    BingoD = False
                    BingoQC = False
                    BingoCP = False
                End If
                'COMPTEUR DU NOMBRE DE NUMÉRO SORTI AVANT D'AVOIR UN GAGNANT
                cpt = cpt + 1

                'CONDITION POUR DÉCLARER OFFICIELLEMENT UN GAGNANT
                If BingoCP = True Or BingoL = True Or BingoC = True Or BingoD = True Or BingoQC = True Then
                    If Carte(i).Enabled = True And Carte(i).Visible = True Then
                        Carte(i).Enabled = False
                        Timer_Delai_Boulier.Enabled = False
                        Lbl_BouleSortie.Text = "BINGO ! "
                        MessageBox.Show(" Bingo pour le joueur :" & Carte(i).NoJoueur)
                        MessageBox.Show("Le nombre de numero sortie = " & compteurNombreSortie)
                        MessageUtilisateurGagnant()
                    End If
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Désolé nous éprouvons actuellement un problème.")
            MessageBox.Show("L'application va redémarrer")
            Application.Restart()
        End Try
    End Sub
    ''' <summary>
    ''' MÉTHODE QUI PERMET D'ENVOYER DES MESSAGES AUX UTILISATEURS APRÈS AVOIR EU UN BINGO
    ''' </summary>
    Public Sub MessageUtilisateurGagnant()
        Dim reponse As DialogResult
        Dim i, L, C As Integer

        Try
            reponse = MessageBox.Show("Désirez-vous poursuivre la partie ? ", "Poursuivre", MessageBoxButtons.YesNo)
            If reponse = DialogResult.Yes Then
                reponse = MessageBox.Show("Voulez-vous poursuivre avec les mêmes cartes ? ", "Poursuivre", MessageBoxButtons.YesNo)
                If reponse = DialogResult.Yes Then
                    Timer_Delai_Boulier.Enabled = True
                ElseIf reponse = DialogResult.No Then
                    Application.Restart()
                End If
            ElseIf reponse = DialogResult.No Then
                reponse = MessageBox.Show("Désirez-vous quittez l'application ? ", "Quittez", MessageBoxButtons.YesNo)
                If reponse = DialogResult.Yes Then
                    Application.Exit()
                ElseIf DialogResult.No Then
                    Application.Restart()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Désolé nous éprouvons actuellement un problème.")
            MessageBox.Show("L'application va redémarrer")
            Application.Restart()
        End Try
    End Sub
    Private Sub Cmd_Pause_Click(sender As Object, e As EventArgs) Handles Cmd_Pause.Click
        If Timer_Delai_Boulier.Enabled = True Then
            Timer_Delai_Boulier.Enabled = False
            Cmd_Pause.Text = "Démarrer"

        Else
            Timer_Delai_Boulier.Enabled = False
            Cmd_Pause.Text = "Pause"
            Timer_Delai_Boulier.Enabled = True
        End If
        Cmd_CommencerPartie.Enabled = False
    End Sub
    ''' <summary>
    ''' FONCTION QUI VALIDE LE TYPE DE JEU SÉLECTIONNÉ ET RETOURNE LE NOMBRE
    ''' </summary>
    ''' <returns>TJ</returns>
    Public Function QuelTypeJeu()
        Dim TJ As Integer
        If RdBtn_BingoStandard.Checked Then
            TJ = 1
        ElseIf RdBtn_QuatreCoins.Checked Then
            TJ = 2
        ElseIf RdBtn_CartePleine.Checked Then
            TJ = 3
        End If
        Return TJ
    End Function

    Private Sub RdBtn_BingoStandard_CheckedChanged(sender As Object, e As EventArgs) Handles RdBtn_BingoStandard.CheckedChanged
        Cmd_CommencerPartie.Enabled = True
    End Sub

    Private Sub RdBtn_QuatreCoins_CheckedChanged(sender As Object, e As EventArgs) Handles RdBtn_QuatreCoins.CheckedChanged
        Cmd_CommencerPartie.Enabled = True
    End Sub

    Private Sub RdBtn_CartePleine_CheckedChanged(sender As Object, e As EventArgs) Handles RdBtn_CartePleine.CheckedChanged
        Cmd_CommencerPartie.Enabled = True
    End Sub
End Class
