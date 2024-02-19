'' NOUS RETROUVONS DEUX CLASSES 
'' LA CLASSE BOULIER
'' LA CLASSE TABLEAU AFFICHAGE


Imports System.Drawing.Imaging
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock
Imports Microsoft.VisualBasic.Logging

Public Class Boulier
    Public Lbl_NoSortie As Label
    'Public sortis As New List(Of Integer)
    'Public Rnd As New Random()
    Public nombreAleatoire As New Random()
    Public nombreBingo As New List(Of Integer)

    Public Sub New()
        'Cet appel est requis par le concepteur.
        InitializeComponent()
        InitialiserListeNombreBingo()


    End Sub
    ''' <summary>
    ''' MÉTHODE QUI PERMET D'INITIALISER LA DES NOMBRES BINGO
    ''' </summary>
    Public Sub InitialiserListeNombreBingo()
        For NB = 1 To 76
            nombreBingo.Add(NB)
        Next
    End Sub

    ''' <summary>
    ''' FONCTION QUI GÉNÈRE LES NOMBRES AU BOULIER
    ''' RETOURNE LE NUMÉRO SORTIE LA OU ELLE ÉTÉ APPELÉ DANS LE FORM1
    ''' </summary>
    Public Function GenererBouleSortieLabel()

        Dim longeur As Integer = nombreBingo.Count
        Dim numero As Integer
        Dim n As Integer

        Try
            For Each n In nombreBingo
                numero = nombreAleatoire.Next(1, nombreBingo.Count)
                nombreBingo.Remove(numero)
                longeur -= 1
                Return numero
            Next
        Catch ex As Exception
            MessageBox.Show("Désolé nous éprouvons actuellement un problème.")
            MessageBox.Show("L'application va redémarrer")
            Application.Restart()
        End Try
    End Function
    ''' <summary>
    ''' FONCTION QUI PERMET DE SÉLECTIONNER LA LETTRE CORREPONDANTE AU NUMÉRO SORTI
    ''' </summary>
    ''' <param name="numero"></param>
    ''' <returns>LA LETTRE CORRESPONDANTE</returns>
    Public Function SelectionnerLettreCorrespondante(numero)
        Dim lettre As String = ""

        Try
            Select Case numero
                Case numero = 1 To 15
                    lettre = "B"
                Case numero = 16 To 30
                    lettre = "I"
                Case numero = 31 To 45
                    lettre = "N"
                Case numero = 46 To 60
                    lettre = "G"
                Case numero = 61 To 75
                    lettre = "O"
            End Select

        Catch ex As Exception
            MessageBox.Show("Désolé nous éprouvons actuellement un problème.")
            MessageBox.Show("L'application va redémarrer")
            Application.Restart()
        End Try

        Return lettre
    End Function

End Class
Public Class TableauAffichage
    Inherits Boulier
    Public Lbl_NoTableau(4, 14) As Label
    Public Sub New()
        CreerBoulierTableau()
    End Sub
    ''' <summary>
    ''' MÉTHODE QUI CRÉE LE TABLEAU D'AFFICHAGE 
    ''' </summary>
    Public Sub CreerBoulierTableau()

        Dim L, C As Integer
        Dim chiffre As Integer = 1

        Try
            For L = 0 To Lbl_NoTableau.GetUpperBound(0)
                For C = 0 To Lbl_NoTableau.GetUpperBound(1)
                    Lbl_NoTableau(L, C) = New Label
                    With Lbl_NoTableau(L, C)
                        .Visible = True
                        .Width = 67
                        .Height = 47
                        .Left = 55 + (C * 55)
                        .Top = 3 + (L * 47)
                        .BorderStyle = BorderStyle.Fixed3D
                        .TextAlign = ContentAlignment.MiddleCenter
                    End With
                    ' Afficher les numéro dans le tableau
                    If chiffre < 76 Then
                        Lbl_NoTableau(L, C).Text = chiffre.ToString
                        chiffre += 1
                        Me.Controls.Add(Lbl_NoTableau(L, C))
                    End If
                Next
                If C = 4 Then
                    C = 0
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Désolé nous éprouvons actuellement un problème.")
            MessageBox.Show("L'application va redémarrer")
            Application.Restart()
        End Try
    End Sub
    ''' <summary>
    ''' MÉTHODE QUI FAIT AFFICHER LES NOMBRES SORTIES SUR LE TABLEAU
    ''' </summary>
    ''' <param name="nombreSortie"></param>
    ''' <param name="couleur"></param>
    Public Sub AfficherBouleSortie(nombreSortie, couleur)
        Dim L, C As Integer
        Dim LbL_nombreTab As Label
        LbL_nombreTab = Lbl_NoTableau(L, C)

        Try
            For L = 0 To Lbl_NoTableau.GetUpperBound(0)
                For C = 0 To Lbl_NoTableau.GetUpperBound(1)
                    If Lbl_NoTableau(L, C).Text = nombreSortie Then
                        Lbl_NoTableau(L, C).BackColor = couleur
                    End If
                Next
            Next

        Catch ex As Exception
            MessageBox.Show("Désolé nous éprouvons actuellement un problème.")
            MessageBox.Show("L'application va redémarrer")
            Application.Restart()
        End Try
    End Sub

End Class





