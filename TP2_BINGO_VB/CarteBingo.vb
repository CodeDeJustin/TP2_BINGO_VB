

Imports System.Net.NetworkInformation
Imports System.Net.Security
Imports TP2_BINGO_VB.Form1

Public Class CarteBingo

    Public Lbl_No(4, 4) As Label
    Public Hasard As New Random()

    'CRÉATION D'UNE LISTE POUR FAIRE LES CARTES BINGO DES JOUEURS
    Public Mot_B As New List(Of Integer)({1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15})
    Public Mot_I As New List(Of Integer)({16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30})
    Public Mot_N As New List(Of Integer)({31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45})
    Public Mot_G As New List(Of Integer)({46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60})
    Public Mot_O As New List(Of Integer)({61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75})

    'CONSTRUCTEUR QUI FERA LA CRÉATION DES LABELS POUR LES NO
    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        CreerCases()
        Generer_Aleatoire()

    End Sub
    ''' <summary>
    ''' MÉTHODE QUI CRÉE LES CARTES DES UTILISATEURS
    ''' </summary>
    Public Sub CreerCases()
        Dim L, C As Integer
        Try
            For L = 0 To Lbl_No.GetUpperBound(0)
                For C = 0 To Lbl_No.GetUpperBound(1)
                    Lbl_No(L, C) = New Label
                    'IL FAUT CONFIGURÉ SES PROPRIÉTÉS
                    With Lbl_No(L, C)

                        .Visible = True
                        .Width = 36
                        .Height = 30
                        .Left = C * 36
                        .Top = 60 + L * 30
                        .BorderStyle = BorderStyle.FixedSingle
                        .TextAlign = ContentAlignment.MiddleCenter
                    End With
                    'AJOUTER LE NOUVEAU LABEL AU CONTROL
                    Me.Controls.Add(Lbl_No(L, C))
                Next
            Next
            Lbl_No(2, 2).Text = "Fr"
            Lbl_No(2, 2).BackColor = Color.Orange

        Catch ex As Exception
            MessageBox.Show("Désolé. Nous avons eu une difficulté lors de la création des cartes joueurs.")
            MessageBox.Show("L'application va redémarrer")
            Application.Restart()
        End Try
    End Sub
    ''' <summary>
    ''' MÉTHODE QUI GÉNÈRE LES NOMBRES DE FAÇON ALÉATOIRE SUR LES CARTES
    ''' </summary>
    Public Sub Generer_Aleatoire()

        Dim L As Integer
        Dim C As Integer

        Try
            For L = 0 To Lbl_No.GetUpperBound(0)
                For C = 0 To Lbl_No.GetUpperBound(1)
                    Lbl_No(L, C).BackColor = Color.Empty
                    If L = 2 And C = 2 Then
                        Lbl_No(2, 2).Text = "Fr"
                        Lbl_No(2, 2).BackColor = Color.DarkGoldenrod
                    Else
                        If C = 0 Then
                            Lbl_No(L, C).Text = Tirer_Nombre_Liste(Mot_B).ToString()

                        ElseIf C = 1 Then
                            Lbl_No(L, C).Text = Tirer_Nombre_Liste(Mot_I).ToString()
                        ElseIf C = 2 Then
                            Lbl_No(L, C).Text = Tirer_Nombre_Liste(Mot_N).ToString()
                        ElseIf C = 3 Then
                            Lbl_No(L, C).Text = Tirer_Nombre_Liste(Mot_G).ToString
                        ElseIf C = 4 Then
                            Lbl_No(L, C).Text = Tirer_Nombre_Liste(Mot_O).ToString()
                        End If
                    End If
                Next
            Next
        Catch ex As Exception
            MessageBox.Show("Désolé. Nous avons eu une difficulté lors de la création des cartes joueurs.")
            MessageBox.Show("L'application va redémarrer")
            Application.Restart()
        End Try
    End Sub
    ''' <summary>
    ''' FONCTION QUI PERMET D'ALLER TIRER UN NOMBRE DANS LA LISTE POUR LA CRÉATION DES CARTE
    ''' </summary>
    ''' <param name="Liste_Boule"></param>
    ''' <returns>BOULE</returns>
    Public Function Tirer_Nombre_Liste(ByVal Liste_Boule As List(Of Integer)) As Integer

        Dim Nbr As Integer = Hasard.Next(Liste_Boule.Count)
        Dim Boule As Integer = Liste_Boule(Nbr)

        Liste_Boule.RemoveAt(Nbr)

        Return Boule
    End Function
    ''' <summary>
    ''' FONCTION QUI VÉRIFIE SI UN BINGO EST PRÉSENT POUR LES RANGÉS 
    ''' </summary>
    ''' <param name="n"></param>
    ''' <param name="couleur"></param>
    ''' <returns>BINGO: TRUE OR FALSE</returns>
    Public Function VerifierBingoStandardLigne(n As Integer, couleur As Color)
        Dim Bingo As Boolean
        Dim i As Integer

        If n = 1 Then ' rangé
            For i = 0 To 4
                If Lbl_No(i, 0).BackColor = couleur And
                   Lbl_No(i, 1).BackColor = couleur And
                   Lbl_No(i, 2).BackColor = couleur And
                   Lbl_No(i, 3).BackColor = couleur And
                   Lbl_No(i, 4).BackColor = couleur Then
                    Bingo = True
                End If
            Next
        End If
        Return Bingo
    End Function
    ''' <summary>
    ''' FONCTION QUI VÉRIFIE SI UN BINGO EST PRÉSENT POUR LES COLONNES
    ''' </summary>
    ''' <param name="n"></param>
    ''' <param name="couleur"></param>
    ''' <returns>BINGO: TRUE OR FALSE</returns>
    Public Function VerifierBingoStandardColonne(n As Integer, couleur As Color)
        Dim Bingo As Boolean
        If n = 1 Then ' colonne
            For i = 0 To 4
                If Lbl_No(0, i).BackColor = couleur And
                   Lbl_No(1, i).BackColor = couleur And
                   Lbl_No(2, i).BackColor = couleur And
                   Lbl_No(3, i).BackColor = couleur And
                   Lbl_No(4, i).BackColor = couleur Then
                    Bingo = True
                End If
            Next
        End If
        Return Bingo
    End Function
    ''' <summary>
    ''' FONCTION QUI VÉRIFIE SI UN BINGO EST PRÉSENT POUR LES DIAGONALES
    ''' </summary>
    ''' <param name="n"></param>
    ''' <param name="couleur"></param>
    ''' <returns>BINGO: TRUE OR FALSE</returns>
    Public Function VerifierBingoStandardDiagonale(n As Integer, couleur As Color)
        Dim Bingo As Boolean

        If n = 1 Then ' diagonale 1 
            If Lbl_No(0, 0).BackColor = couleur And
               Lbl_No(1, 1).BackColor = couleur And
               Lbl_No(2, 2).BackColor = couleur And
               Lbl_No(3, 3).BackColor = couleur And
               Lbl_No(4, 4).BackColor = couleur Then
                Bingo = True
            End If
        End If
        If n = 1 Then ' diagonale 2 
            If Lbl_No(0, 4).BackColor = couleur And
               Lbl_No(1, 3).BackColor = couleur And
               Lbl_No(2, 2).BackColor = couleur And
               Lbl_No(3, 1).BackColor = couleur And
               Lbl_No(4, 0).BackColor = couleur Then
                Bingo = True
            End If
        End If
        Return Bingo
    End Function
    ''' <summary>
    ''' FONCTION QUI VÉRIFIE SI UN BINGO EST PRÉSENT POUR LE QUATRE COINS
    ''' </summary>
    ''' <param name="n"></param>
    ''' <param name="couleur"></param>
    ''' <returns>BINGO: TRUE OR FALSE</returns>
    Public Function VerifierBingoQuatreCoin(n As Integer, couleur As Color)
        Dim Bingo As Boolean

        If n = 2 Then ' 4 coins

            If Lbl_No(0, 0).BackColor = couleur And
               Lbl_No(0, 4).BackColor = couleur And
               Lbl_No(4, 0).BackColor = couleur And
               Lbl_No(4, 4).BackColor = couleur Then
                Bingo = True
            End If
        End If
        Return Bingo
    End Function
    ''' <summary>
    ''' FONCTION QUI VÉRIFIE SI UN BINGO EST PRÉSENT POUR LES CARTES PLEINES
    ''' </summary>
    ''' <param name="n"></param>
    ''' <param name="couleur"></param>
    ''' <returns>BINGO: TRUE OR FALSE </returns>
    Public Function VerifierCartePleine(n As Integer, couleur As Color)
        Dim Bingo As Boolean = False
        Dim cpt As Integer

        If n = 3 Then ' carte pleine
            For L = 0 To Lbl_No.GetUpperBound(0)
                For C = 0 To Lbl_No.GetUpperBound(1)
                    If Lbl_No(L, C).BackColor <> couleur Then
                        Bingo = False
                    ElseIf Lbl_No(L, C).BackColor = couleur Then
                        cpt += 1
                        If cpt = 25 Then
                            Bingo = True
                        End If

                    End If
                Next
            Next
        End If
        Return Bingo
    End Function

    ''' <summary>
    ''' MÉTHODE QUI VÉRIFIE SI LE NUMERO SORTIE CORRESPOND À UN NOMBRE SUR LA CARTE ET CHANGE LA COULEUR
    ''' AU BESOIN 
    ''' </summary>
    ''' <param name="bouleSortie"></param>
    ''' <param name="couleur"></param>
    Public Sub VerifierBoule(bouleSortie As Integer, couleur As Color)
        Try
            For L = 0 To Lbl_No.GetUpperBound(0)
                For C = 0 To Lbl_No.GetUpperBound(1)
                    If L <> 2 Or C <> 2 Then
                        If Lbl_No(L, C).Text = bouleSortie Then
                            Lbl_No(L, C).BackColor = couleur
                        End If
                    End If
                Next
            Next
        Catch ex As Exception
            MessageBox.Show("Désolé nous éprouvons actuellement un problème.")
            MessageBox.Show("L'application va redémarrer")
            Application.Restart()

        End Try

    End Sub
    Public Property NoJoueur As String
        Get
            Return Lbl_Joueur.Text
        End Get
        Set(value As String)
            Lbl_Joueur.Text = value
        End Set
    End Property

End Class
