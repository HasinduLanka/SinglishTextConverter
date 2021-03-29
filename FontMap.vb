Imports System.ComponentModel

Public Class FontMaper
    Public FFont As Font
    Public FM As FontMap


    Public SelectedCSet As CharSet
    Public SelectedIndex As Integer = -1

    Private Sub EnChar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EnChar.SelectedIndexChanged
        Dim n = EnChar.SelectedIndex

        EnChar.SelectedIndex = n
        FontChar.SelectedIndex = n
        LstType.SelectedIndex = n

        SelectedCSet = FM.CSets(n)
        SelectedIndex = n

        TxtEnChar.Text = SelectedCSet.EnChar
        TxtFontChar.Text = SelectedCSet.FontChar
        CmbType.SelectedIndex = SelectedCSet.T


        TxtFontChar.Focus()

    End Sub

    Private Sub FontChar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FontChar.SelectedIndexChanged
        Dim n = FontChar.SelectedIndex

        EnChar.SelectedIndex = n
        FontChar.SelectedIndex = n
        LstType.SelectedIndex = n

        SelectedCSet = FM.CSets(n)
        SelectedIndex = n

        TxtEnChar.Text = SelectedCSet.EnChar
        TxtFontChar.Text = SelectedCSet.FontChar
        CmbType.SelectedIndex = SelectedCSet.T

        TxtEnChar.Focus()

    End Sub


    Private Sub LstType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstType.SelectedIndexChanged
        Dim n = LstType.SelectedIndex

        EnChar.SelectedIndex = n
        FontChar.SelectedIndex = n
        LstType.SelectedIndex = n

        SelectedCSet = FM.CSets(n)
        SelectedIndex = n

        TxtEnChar.Text = SelectedCSet.EnChar
        TxtFontChar.Text = SelectedCSet.FontChar
        CmbType.SelectedIndex = SelectedCSet.T

        TxtEnChar.Focus()

    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnNewMap.Click

        ColorEffect.Stop()
        BtnNewMap.BackColor = Color.DarkSlateGray
        BtnOpen.BackColor = Color.DarkSlateGray

        CreateNewMap()

        CheckErrors()

    End Sub


    Public Sub UpdateLists()
        EnChar.Items.Clear()
        FontChar.Items.Clear()
        LstType.Items.Clear()

        FontChar.Font = FFont


        Dim CS As CharSet

        For n = 0 To FM.CSets.Count - 1
            CS = FM.CSets(n)

            EnChar.Items.Add(CS.EnChar)
            FontChar.Items.Add(CS.FontChar)
            LstType.Items.Add(CharSets.Type.NameFromIndex(CS.T))


        Next


        'Dim name As String =
        '    System.Enum.GetName(GetType(DayOfWeek), 0)



        While EnChar.ItemHeight > FontChar.ItemHeight
            FontChar.Font = New Font(FontChar.Font.FontFamily, FontChar.Font.Size + 1)
        End While

        While EnChar.ItemHeight < FontChar.ItemHeight
            FontChar.Font = New Font(FontChar.Font.FontFamily, FontChar.Font.Size - 1)
        End While



        FFont = FontChar.Font
        TxtFontChar.Font = FFont

    End Sub

    Public ErrCSets1 As New List(Of CharSet)
    Public ErrCSets2 As New List(Of CharSet)
    Public Sub CheckErrors()
        ErrCSets1.Clear()
        ErrCSets2.Clear()
        Log.Clear()
        Log.BackColor = Color.LightBlue

        Dim c As String
        For n = 0 To FM.CSets.Count - 1
            c = EnChar.Items.Item(n)
            For m = 0 To FM.CSets.Count - 1
                If EnChar.Items.Item(m) = c Then
                    If n <> m Then
                        ErrCSets1.Add(FM.CSets(n))
                        ErrCSets2.Add(FM.CSets(m))
                    End If
                End If

            Next
        Next


        If ErrCSets1.Count > 0 Then
            Log.BackColor = Color.IndianRed

            Log.Text = "Duplicated English chars found." + vbNewLine + ">>> "

            For n = 0 To ErrCSets1.Count - 1 Step 2
                Dim CS = ErrCSets1(n)
                Dim CS2 = ErrCSets2(n)
                Log.AppendText(CS.EnChar + " - " + CS.FontChar + " and " + CS2.EnChar + " - " + CS2.FontChar + vbNewLine)
            Next

            Log.AppendText(vbNewLine + "Please correct them.")


        Else
            Log.BackColor = Color.LightBlue
            Log.Text = "No errors found."

        End If




    End Sub



    Private Sub FontMaper_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        'EmptyMap.xml

        'FM.CSets.Clear()




        'Dim reader As New System.Xml.Serialization.XmlSerializer(GetType(FontMap))
        'Dim File As New IO.StreamReader("EmptyMapAllChars.xml", System.Text.Encoding.Unicode)

        'EmptyMap = CType(reader.Deserialize(File), FontMap)

        'Microsoft Sans Serif


        If IsNothing(FM) Then
            'CreateNewMap()


            FM = FontMap.CreateNewMap(FontMap.GenaratingStyle.Genarative, EnChar.Font)
            FM.F = "FMAbhaya x"
            FFont = New Font(FM.F, 14)

            FontChar.Font = FFont
            TxtFontChar.Font = FFont


            ColorEffect.Start()


        End If



        UpdateLists()
        CheckErrors()


        EnChar.SelectedIndex = 0


    End Sub


    Private Sub TxtEnChar_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtEnChar.KeyDown
        If e.KeyCode = Keys.Enter Then
            AddButtonClick(New Object, New EventArgs)
        ElseIf e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Then
            FontChar.Focus()
        End If
    End Sub

    Private Sub TxtEnChar1_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFontChar.KeyDown
        If e.KeyCode = Keys.Enter Then
            AddButtonClick(New Object, New EventArgs)
        ElseIf e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Then
            EnChar.Focus()
        End If
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        SaveDia.ShowDialog()

        'Try
        If SaveDia.FileName <> "" Then

            FM.Save(SaveDia.OpenFile)
            LblStatus.Text = "Saved succesfuly"
        End If

        'Catch ex As Exception
        '    MsgBox("Saving failed." + vbNewLine + ex.Message)
        'End Try



    End Sub

    Private Sub AddButtonClick(sender As Object, e As EventArgs) Handles Button1.Click

        If CmbType.SelectedIndex = -1 Then
            MsgBox("Select vailed Type")
            Exit Sub
        ElseIf TxtEnChar.Text = "" Then
            MsgBox("English char cannot be empty")
            Exit Sub
        End If

        SelectedCSet.T = CmbType.SelectedIndex
        SelectedCSet.EnChar = TxtEnChar.Text
        SelectedCSet.FontChar = TxtFontChar.Text

        UpdateLists()


        EnChar.SelectedIndex = SelectedIndex

        CheckErrors()

        EnChar.SelectedIndex = SelectedIndex
        EnChar.Focus()


        LblStatus.Text = "Changed succesfully"

    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        FM.add(New CharSet(TxtEnChar.Text, TxtFontChar.Text))

        UpdateLists()

        EnChar.SelectedIndex = EnChar.Items.Count - 1

        CheckErrors()

        LblStatus.Text = "Added succesfully"
    End Sub


    Private Sub BtnOpen_Click(sender As Object, e As EventArgs) Handles BtnOpen.Click
        ColorEffect.Stop()
        BtnNewMap.BackColor = Color.DarkSlateGray
        BtnOpen.BackColor = Color.DarkSlateGray


        ODia.ShowDialog()




    End Sub



    Private Sub ODia_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ODia.FileOk
        OpenMap(ODia.OpenFile())
    End Sub

    'Public EmptyMap As FontMap
    Public Sub CreateNewMap()


        FM.CSets.AddRange(CharSets.හල්1CSets)
        FM.CSets.AddRange(CharSets.හල්2CSets)

        FM.CSets.AddRange(CharSets.ස්වර1CSets)
        FM.CSets.AddRange(CharSets.ස්වර2CSets)
        'FM.CSets.AddRange(CharSets.ස්වර3CSets)

        FM.CSets.AddRange(CharSets.ගතකුරු2CSets)
        FM.CSets.AddRange(CharSets.ගතකුරු3CSets)
        FM.CSets.AddRange(CharSets.ගතකුරු4CSets)
        'FM.CSets.AddRange(CharSets.ගතකුරු5CSets)

        FM.CSets.AddRange(CharSets.පිල්ලම්1CSets)
        FM.CSets.AddRange(CharSets.පිල්ලම්2CSets)





        Dim FDia As New FontDialog
        FDia.Font = FontChar.Font
        FDia.ShowDialog()

        FontChar.Font = FDia.Font
        TxtFontChar.Font = FDia.Font

        LblStatus.Text = "Created new Charactor map for Font " + FDia.Font.FontFamily.Name



        FFont = FDia.Font
        FM.F = FDia.Font.FontFamily.Name


        UpdateLists()
    End Sub





    Public Sub OpenMap(file As IO.Stream)


        Dim reader As New System.Xml.Serialization.XmlSerializer(GetType(FontMap))

        FM = CType(reader.Deserialize(file), FontMap)

        FFont = New Font(FM.F, FontChar.Font.Size)

        UpdateLists()

    End Sub


    Public Sub OpenMap(Map As FontMap)



        FM = Map

        FFont = New Font(FM.F, FontChar.Font.Size)

        UpdateLists()

    End Sub



    Private CETime = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles ColorEffect.Tick
        If BtnNewMap.BackColor = Color.Red Then
            BtnNewMap.BackColor = Color.DarkSlateGray
            BtnOpen.BackColor = Color.DarkSlateGray
        Else
            BtnNewMap.BackColor = Color.Red
            BtnOpen.BackColor = Color.Red
        End If

        CETime += 1

        If CETime > 11 Then
            ColorEffect.Stop()
        End If


    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ET = New Edit_Template
        ET.Initialize(FM, FFont, Me)
        ET.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim FC As New FontCharsForm

        FC.LstFont.Font = FFont

        FC.Show()



    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        FM.CSets.Remove(New CharSet(TxtEnChar.Text, TxtFontChar.Text))

        UpdateLists()

        EnChar.SelectedIndex = EnChar.Items.Count - 1

        CheckErrors()

        LblStatus.Text = "Deleted succesfully"
    End Sub

    Private Sub FontMaper_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Main.FM = FM

    End Sub

    'Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
    '    Dim SG1Str = "xa Xa Na na ma"
    '    Dim SG2Str = "'ga 'ja 'Da 'da 'ba"

    '    Dim SG1L As New List(Of String)
    '    SG1L.AddRange(SG1Str.Split(" "))

    '    Dim SG2L As New List(Of String)
    '    SG2L.AddRange(SG2Str.Split(" "))


    '    For Each s In SG1L
    '        FM.add(New CharSet(s, s, CharSets.ගතකුරු2))
    '    Next

    '    For Each s In SG2L
    '        FM.add(New CharSet(s, s, CharSets.ගතකුරු3))
    '    Next



    '    UpdateLists()
    'End Sub
End Class

