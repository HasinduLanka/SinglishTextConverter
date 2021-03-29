Imports System.ComponentModel

Public Class Edit_Template

    Public FM As FontMap
    Public FMaper As FontMaper
    Public F As Font


    Private Sub Edit_Template_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Initialize(FMap As FontMap, Fnt As Font, FMP As FontMaper)
        FM = FMap
        F = Fnt
        FMaper = FMP

        LblFont.Text = "Current font :- " + FM.F


        LstCons.Items.Clear()
        LstVowels.Items.Clear()

        Try
            LstCons.Items.AddRange(FM.Consonants)
            LstVowels.Items.AddRange(FM.Vowels)
        Catch ex As Exception

        End Try


        If FM.BuildingStyle = FontMap.GenaratingStyle.Genarative Then
            RBGenarative.Checked = True
            RBAllLetters.Checked = False


            If FM.Genarated Then
                BtnGenarate.Enabled = False
            Else
                BtnGenarate.Enabled = True
            End If


        Else
            RBGenarative.Checked = False
            RBAllLetters.Checked = True
            BtnGenarate.Enabled = False

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FDia As New FontDialog
        FDia.Font = F
        FDia.ShowDialog()

        F = FDia.Font
        FM.F = F.FontFamily.Name

        FMaper.FontChar.Font = FDia.Font
        FMaper.TxtFontChar.Font = FDia.Font

        FMaper.FM = FM
        FMaper.FFont = F


        LblFont.Text = "Current font :- " + FM.F

        FMaper.UpdateLists()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If RBAllLetters.Checked Then
            FM = FontMap.CreateNewMap(FontMap.GenaratingStyle.AllLetters, F)
            FMaper.FM = FM

            FMaper.UpdateLists()

        Else

            FM = FontMap.CreateNewMap(FontMap.GenaratingStyle.Genarative, F)
            FMaper.FM = FM

            FMaper.UpdateLists()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnGenarate.Click



        If Not FM.Genarated Then


            FMaper.FM.GenarateOtherChars()
            FM = FMaper.FM
            FMaper.UpdateLists()


            BtnGenarate.Enabled = False
            'BtnGenarate.Text = "සාදන ලද අකුරු ඉවත් කරන්න"

        End If
    End Sub

    Private Sub RBGenarative_CheckedChanged(sender As Object, e As EventArgs) Handles RBGenarative.CheckedChanged
        If RBGenarative.Checked Then
            BtnGenarate.Enabled = True
        Else
            BtnGenarate.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

        If TxtCVAdd.Text <> "" Then

            Dim LFMConsonants = FM.Consonants.ToList
            LFMConsonants.Add(TxtCVAdd.Text)
            FM.Consonants = LFMConsonants.ToArray

            LstCons.Items.Clear()
            LstVowels.Items.Clear()

            LstCons.Items.AddRange(FM.Consonants)
            LstVowels.Items.AddRange(FM.Vowels)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TxtCVAdd.Text <> "" Then

            Dim LFMVowels = FM.Vowels.ToList
            LFMVowels.Add(TxtCVAdd.Text)
            FM.Vowels = LFMVowels.ToArray

            LstCons.Items.Clear()
            LstVowels.Items.Clear()

            LstCons.Items.AddRange(FM.Consonants)
            LstVowels.Items.AddRange(FM.Vowels)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click




        LstCons.Items.RemoveAt(LstCons.SelectedIndex)

        FM.Consonants = LstCons.Items.Cast(Of String)

        LstCons.Items.Clear()
        LstVowels.Items.Clear()

        LstCons.Items.AddRange(FM.Consonants)
        LstVowels.Items.AddRange(FM.Vowels)


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        LstVowels.Items.RemoveAt(LstVowels.SelectedIndex)

        FM.Vowels = LstVowels.Items.Cast(Of String)

        LstCons.Items.Clear()
        LstVowels.Items.Clear()

        LstCons.Items.AddRange(FM.Consonants)
        LstVowels.Items.AddRange(FM.Vowels)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        FM.Consonants = CharSets.Consonants.ToArray
        FM.Vowels = CharSets.Vowels.ToArray

        LstCons.Items.Clear()
        LstVowels.Items.Clear()

        LstCons.Items.AddRange(FM.Consonants)
        LstVowels.Items.AddRange(FM.Vowels)

    End Sub

    Private Sub Edit_Template_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FMaper.FM = FM
        FMaper.FFont = F
        FMaper.UpdateLists()
    End Sub
End Class