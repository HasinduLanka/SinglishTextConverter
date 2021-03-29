


<Serializable>
Public Class CharSet

    Public EnChar As String
    Public FontChar As String

    Public T As Integer

    'Public T As CharSets.Type

    Public Sub New()
    End Sub

    Public Sub New(EnglishChar As String, FontChar As String)

        EnChar = EnglishChar
        Me.FontChar = FontChar

    End Sub

    Public Sub New(EnglishChar As String, FontChar As String, Type As CharSets.Type)

        EnChar = EnglishChar
        Me.FontChar = FontChar
        T = Type.Index

    End Sub







End Class







Public Class CharSets


    Public Shared Sub Initialize()
        Dim HStr = "k ch t th p g j D d b K CH T TH P G J DH dh B x X N n m 'g 'j 'D 'd 'b y r l v SH sh s h L f"
        හල්String.AddRange(HStr.Split(" "))


        Dim Str1 = "k t p g j D d b K T P G J B x X N n m y r l v s h L f"
        හල්1String.AddRange(Str1.Split(" "))
        හල්1 = New Type With {.Length = 1, .name = "හල්1", .Index = Types.හල්1}
        හල්1.Strings.AddRange(Str1.Split(" "))

        For Each s In CharSets.හල්1String
            හල්1CSets.Add(New CharSet(s, s, හල්1))

        Next



        Dim Str2 = "ch th CH TH DH dh SH sh 'g 'j 'D 'd 'b"
        හල්2String.AddRange(Str2.Split(" "))
        හල්2 = New Type With {.Length = 2, .name = "හල්2", .Index = Types.හල්2}
        හල්2.Strings.AddRange(Str2.Split(" "))

        For Each s In CharSets.හල්2String
            හල්2CSets.Add(New CharSet(s, s, හල්2))
        Next



        Dim ස්වරStr = "a aa ae aee i ii u uu ~Iu ~IU `Iu `IU e ee AI o oo au"
        ස්වරString.AddRange(ස්වරStr.Split(" "))

        Dim sv1Str = "a i u e o"
        ස්වර1String.AddRange(sv1Str.Split(" "))
        ස්වර1 = New Type With {.Length = 1, .name = "ස්වර1", .Index = Types.ස්වර1}
        ස්වර1.Strings.AddRange(sv1Str.Split(" "))

        For Each s In CharSets.ස්වර1String
            ස්වර1CSets.Add(New CharSet(s, s, ස්වර1))
        Next

        '`u `U
        Dim sv2Str = "aa ae ii uu ee ai oo au aE `u `U"
        ස්වර2String.AddRange(sv2Str.Split(" "))
        ස්වර2 = New Type With {.Length = 2, .name = "ස්වර2", .Index = Types.ස්වර2}
        ස්වර2.Strings.AddRange(sv2Str.Split(" "))

        For Each s In CharSets.ස්වර2String
            ස්වර2CSets.Add(New CharSet(s, s, ස්වර2))
        Next


        'Dim sv3Str = "aE ~u ~U `u `U"
        'ස්වර3String.AddRange(sv3Str.Split(" "))
        'ස්වර3 = New Type With {.Length = 3, .name = "ස්වර3", .Index = Types.ස්වර3}
        'ස්වර3.Strings.AddRange(sv3Str.Split(" "))

        'For Each s In CharSets.ස්වර3String
        '    ස්වර3CSets.Add(New CharSet(s, s, ස්වර3))
        'Next


        'පිල්ලම්String.AddRange(ස්වරString)

        Dim PilStr = "ක් aaකා aeකැ aEකෑ iකි iiකී uකු uuකූ ~uකෘ ~Uකෲ eකෙ eeකේ aiකෛ oකො ooකෝ auකෞ"
        පිල්ලම්String.AddRange(PilStr.Split(" "))

        Dim Pil1Str = "ක් iකි uකු eකෙ oකො"
        පිල්ලම්1String.AddRange(Pil1Str.Split(" "))
        පිල්ලම්1 = New Type With {.Length = 1, .name = "පිල්ලම්1", .Index = Types.පිල්ලම්1}
        පිල්ලම්1.Strings.AddRange(Pil1Str.Split(" "))

        For Each s In CharSets.පිල්ලම්1String
            පිල්ලම්1CSets.Add(New CharSet(s, s, පිල්ලම්1))
        Next


        Dim Pil2Str = "aaකා aeකැ aEකෑ iiකී uuකූ ~uකෘ ~Uකෲ eeකේ aiකෛ ooකෝ auකෞ"
        පිල්ලම්2String.AddRange(Pil2Str.Split(" "))
        පිල්ලම්2 = New Type With {.Length = 2, .name = "පිල්ලම්2", .Index = Types.පිල්ලම්2}
        පිල්ලම්2.Strings.AddRange(Pil2Str.Split(" "))

        For Each s In CharSets.පිල්ලම්2String
            පිල්ලම්2CSets.Add(New CharSet(s, s, පිල්ලම්2))
        Next







        ගතකුරු2 = New Type With {.Length = 2, .name = "ගතකුරු2", .Index = Types.ගතකුරු2}
        'ka
        For Each h In හල්1String
            For Each s In ස්වර1String
                ගතකුරු2String.Add(h + s)
                ගතකුරු2.Strings.Add(h + s)
            Next
        Next


        For Each s In CharSets.ගතකුරු2String
            ගතකුරු2CSets.Add(New CharSet(s, s, ගතකුරු2))
        Next


        'kaa
        ගතකුරු3 = New Type With {.Length = 3, .name = "ගතකුරු3", .Index = Types.ගතකුරු3}
        For Each h In හල්1String
            For Each s In ස්වර2String
                ගතකුරු3String.Add(h + s)
                ගතකුරු3.Strings.Add(h + s)
            Next
        Next


        'kaee

        'For Each h In හල්1String
        '    For Each s In ස්වර3String
        '        ගතකුරු4String.Add(h + s)
        '        ගතකුරු4.Strings.Add(h + s)
        '    Next
        'Next


        'cha
        For Each h In හල්2String
            For Each s In ස්වර1String
                ගතකුරු3String.Add(h + s)
                ගතකුරු3.Strings.Add(h + s)
            Next
        Next


        For Each s In CharSets.ගතකුරු3String
            ගතකුරු3CSets.Add(New CharSet(s, s, ගතකුරු3))
        Next


        'chaa
        ගතකුරු4 = New Type With {.Length = 4, .name = "ගතකුරු4", .Index = Types.ගතකුරු4}
        For Each h In හල්2String
            For Each s In ස්වර2String
                ගතකුරු4String.Add(h + s)
                ගතකුරු4.Strings.Add(h + s)
            Next
        Next


        For Each s In CharSets.ගතකුරු4String
            ගතකුරු4CSets.Add(New CharSet(s, s, ගතකුරු4))
        Next

        ''chaee
        'ගතකුරු5 = New Type With {.Length = 5, .name = "ගතකුරු5", .Index = Types.ගතකුරු5}
        'For Each h In හල්2String
        '    For Each s In ස්වර3String
        '        ගතකුරු5String.Add(h + s)
        '        ගතකුරු5.Strings.Add(h + s)
        '    Next
        'Next



        'For Each s In CharSets.ගතකුරු5String
        '    ගතකුරු5CSets.Add(New CharSet(s, s, ගතකුරු5))
        'Next



        For Each h In හල්String
            For Each s In ස්වරString
                ගතකුරුString.Add(h + s)

            Next

            ශුද්ධගතකුරුString.Add(h + "a")

        Next

        For Each h In හල්1String
            Dim s = h + "a"
            ශුද්ධගතකුරු2String.Add(s)
            ශුද්ධගතකුරු2CSets.Add(New CharSet(s, s, ගතකුරු2))
        Next



        For Each h In හල්2String
            Dim s = h + "a"
            ශුද්ධගතකුරු3String.Add(s)
            ශුද්ධගතකුරු3CSets.Add(New CharSet(s, s, ගතකුරු3))
        Next



        Consonants.AddRange(හල්1String)
        Consonants.AddRange({"c", "C", "s", "S", "H", "'"})

        Vowels.AddRange({"a", "e", "i", "o", "u", "A", "E", "I", "O", "U", "`", "~"})


    End Sub

    Public Shared Vowels As New List(Of String)
    Public Shared Consonants As New List(Of String)

    Public Class Type

        Public Strings As New List(Of String)

        'Public CSets As New List(Of CharSet)



        Public Length As Integer = 1

        Public name As String = ""

        Public Index As Types


        Public Shared Function FromTypes(TP As Types) As Type
            Select Case TP
                Case Types.හල්1
                    Return හල්1
                Case Types.හල්2
                    Return හල්2

                Case Types.ස්වර1
                    Return ස්වර1
                Case Types.ස්වර2
                    Return ස්වර2
                Case Types.ස්වර3
                    Return ස්වර2

                Case Types.ගතකුරු2
                    Return ගතකුරු2
                Case Types.ගතකුරු3
                    Return ගතකුරු3
                Case Types.ගතකුරු4
                    Return ගතකුරු4
                Case Types.ගතකුරු5
                    Return ගතකුරු4
                Case Types.පිල්ලම්1
                    Return පිල්ලම්1
                Case Types.පිල්ලම්2
                    Return පිල්ලම්2
                Case Else
                    Return Nothing
            End Select
        End Function



        Public Shared Function FromIndex(i As Integer) As Type
            Select Case i
                Case Types.හල්1
                    Return හල්1
                Case Types.හල්2
                    Return හල්2

                Case Types.ස්වර1
                    Return ස්වර1
                Case Types.ස්වර2
                    Return ස්වර2
                Case Types.ස්වර3
                    Return ස්වර2

                Case Types.ගතකුරු2
                    Return ගතකුරු2
                Case Types.ගතකුරු3
                    Return ගතකුරු3
                Case Types.ගතකුරු4
                    Return ගතකුරු4
                Case Types.ගතකුරු5
                    Return ගතකුරු4

                Case Types.පිල්ලම්1
                    Return පිල්ලම්1
                Case Types.පිල්ලම්2
                    Return පිල්ලම්2
                Case Else
                    Return Nothing
            End Select
        End Function


        Public Shared Function NameFromIndex(i As Integer) As String
            Select Case i
                Case Types.හල්1
                    Return හල්1.name
                Case Types.හල්2
                    Return හල්2.name

                Case Types.ස්වර1
                    Return ස්වර1.name
                Case Types.ස්වර2
                    Return ස්වර2.name
                Case Types.ස්වර3
                    Return ස්වර2.name

                Case Types.ගතකුරු2
                    Return ගතකුරු2.name
                Case Types.ගතකුරු3
                    Return ගතකුරු3.name
                Case Types.ගතකුරු4
                    Return ගතකුරු4.name
                Case Types.ගතකුරු5
                    Return ගතකුරු4.name

                Case Types.පිල්ලම්1
                    Return පිල්ලම්1.name
                Case Types.පිල්ලම්2
                    Return පිල්ලම්2.name
                Case Else
                    Return Nothing
            End Select
        End Function


        Private Shared TypeOfTypes As System.Type = GetType(CharSets.Types)

        Public Shared Function NameFromIndexEnumed(i As Integer) As String

            Return System.Enum.GetName(TypeOfTypes, i)

        End Function

    End Class


    Public Enum Types
        හල්1
        හල්2
        ස්වර1
        ස්වර2
        ස්වර3
        ගතකුරු2
        ගතකුරු3
        ගතකුරු4
        ගතකුරු5
        පිල්ලම්1
        පිල්ලම්2
    End Enum


    Public Shared හල්String As New List(Of String) 'k ch t ...

    Public Shared හල්1String As New List(Of String) 'k t p ...
    Public Shared හල්2String As New List(Of String) 'ch th ...

    Public Shared හල්1CSets As New List(Of CharSet)
    Public Shared හල්2CSets As New List(Of CharSet)

    Public Shared හල්1 As Type
    Public Shared හල්2 As Type




    Public Shared ස්වරString As New List(Of String) 'a aa ae aee i ii ...

    Public Shared ස්වර1String As New List(Of String) 'a i u ...
    Public Shared ස්වර2String As New List(Of String) 'aa ii uu ...
    'Public Shared ස්වර3String As New List(Of String) 'aee `IU ...

    Public Shared ස්වර1CSets As New List(Of CharSet)
    Public Shared ස්වර2CSets As New List(Of CharSet)
    'Public Shared ස්වර3CSets As New List(Of CharSet)

    Public Shared ස්වර1 As Type
    Public Shared ස්වර2 As Type
    'Public Shared ස්වර3 As Type



    Public Shared ගතකුරුString As New List(Of String)
    Public Shared ශුද්ධගතකුරුString As New List(Of String) ' ka , cha , ta

    Public Shared ශුද්ධගතකුරු2String As New List(Of String) 'ka ta pa ga ....
    Public Shared ශුද්ධගතකුරු3String As New List(Of String) 'cha tha ...
    Public Shared ශුද්ධගතකුරු2CSets As New List(Of CharSet)
    Public Shared ශුද්ධගතකුරු3CSets As New List(Of CharSet)


    Public Shared ගතකුරු2String As New List(Of String) 'ka ki ku ke ...
    Public Shared ගතකුරු2 As Type
    Public Shared ගතකුරු2CSets As New List(Of CharSet)

    Public Shared ගතකුරු3String As New List(Of String) 'cha chi kae kaa...
    Public Shared ගතකුරු3 As Type
    Public Shared ගතකුරු3CSets As New List(Of CharSet)

    Public Shared ගතකුරු4String As New List(Of String) 'chaa chae thaa ...
    Public Shared ගතකුරු4 As Type
    Public Shared ගතකුරු4CSets As New List(Of CharSet)

    'Public Shared ගතකුරු5String As New List(Of String) 'chaee ch~IU ...
    'Public Shared ගතකුරු5 As Type
    'Public Shared ගතකුරු5CSets As New List(Of CharSet)




    Public Shared පිල්ලම්String As New List(Of String)

    Public Shared පිල්ලම්1String As New List(Of String)
    Public Shared පිල්ලම්2String As New List(Of String)


    Public Shared පිල්ලම්1CSets As New List(Of CharSet)
    Public Shared පිල්ලම්2CSets As New List(Of CharSet)

    Public Shared පිල්ලම්1 As Type
    Public Shared පිල්ලම්2 As Type

End Class

















<Serializable>
Public Class FontMap
    Public F As String
    Public CSets As New List(Of CharSet)

    Public BuildingStyle As GenaratingStyle = GenaratingStyle.AllLetters
    Public Genarated As Boolean = False


    Public Vowels() As String
    Public Consonants() As String


    Public Sub add(CSet As CharSet)
        CSets.Add(CSet)
        'CIndex += 1
    End Sub

    Public Function GetSetContainingEnChar(EnChar As String) As CharSet
        For n = 0 To CSets.Count - 1
            If CSets(n).EnChar = EnChar Then
                Return CSets(n)
                Exit Function
            End If
        Next

        Return Nothing
    End Function


    Public Function GetSetContainingFontChar(FontChar As String) As CharSet
        For n = 0 To CSets.Count - 1
            If CSets(n).FontChar = FontChar Then
                Return CSets(n)
                Exit Function
            End If
        Next

        Return Nothing
    End Function


    Public Sub Save(file As IO.Stream)
        'Path As String
        Dim writer As New System.Xml.Serialization.XmlSerializer(GetType(FontMap))

        'Dim file = My.Computer.FileSystem.OpenTextFileWriter(Path, False, System.Text.Encoding.Unicode)

        writer.Serialize(file, Me)
    End Sub




    Public Shared Function CreateNewMap(Style As GenaratingStyle, Fnt As Font) As FontMap
        Dim FM As New FontMap

        If Style = GenaratingStyle.AllLetters Then

            FM.CSets.AddRange(CharSets.හල්1CSets)
            FM.CSets.AddRange(CharSets.හල්2CSets)

            FM.CSets.AddRange(CharSets.ස්වර1CSets)
            FM.CSets.AddRange(CharSets.ස්වර2CSets)
            'FM.CSets.AddRange(CharSets.ස්වර3CSets)

            FM.CSets.AddRange(CharSets.ගතකුරු2CSets)
            FM.CSets.AddRange(CharSets.ගතකුරු3CSets)
            FM.CSets.AddRange(CharSets.ගතකුරු4CSets)
            'FM.CSets.AddRange(CharSets.ගතකුරු5CSets)

            FM.BuildingStyle = GenaratingStyle.AllLetters

        ElseIf Style = GenaratingStyle.Genarative Then

            FM.CSets.AddRange(CharSets.ස්වර1CSets)
            FM.CSets.AddRange(CharSets.ස්වර2CSets)
            'FM.CSets.AddRange(CharSets.ස්වර3CSets)

            FM.CSets.AddRange(CharSets.පිල්ලම්1CSets)
            FM.CSets.AddRange(CharSets.පිල්ලම්2CSets)

            FM.CSets.AddRange(CharSets.ශුද්ධගතකුරු2CSets)
            FM.CSets.AddRange(CharSets.ශුද්ධගතකුරු3CSets)

            FM.BuildingStyle = GenaratingStyle.Genarative

        End If


        FM.F = Fnt.FontFamily.Name

        Return FM

    End Function


    Public Sub GenarateOtherChars()

        '"0ක් 1iකි 2uකු 3eකෙ 4oකො"
        '"0aaකා 1aeකැ 2aEකෑ 3iiකී 4uuකූ 5~uකෘ 6~Uකෲ 7eeකේ 8aiකෛ 9ooකෝ 10auකෞ"

        'Me.add( new charSet(EnChar = k , [[GetSetContainingEnChar("ka").FontChar = ක]  + hChar]= ක් )  )
        Dim hChar = Me.GetSetContainingEnChar(CharSets.පිල්ලම්1CSets(0).EnChar).FontChar
        'k = ක්, ka = ක 
        For Each CS In CharSets.හල්1CSets
            Me.add(New CharSet(CS.EnChar, Me.GetSetContainingEnChar(CS.EnChar + "a").FontChar + hChar, CharSets.හල්1))
        Next

        For Each CS In CharSets.හල්2CSets
            Me.add(New CharSet(CS.EnChar, Me.GetSetContainingEnChar(CS.EnChar + "a").FontChar + hChar, CharSets.හල්2))
        Next


        '______________________________________________________________________________________________
        'ආ පිල්ල
        Dim LongChar = Me.GetSetContainingEnChar(CharSets.පිල්ලම්2CSets(0).EnChar).FontChar

        For Each CS In CharSets.හල්1CSets
            Me.add(New CharSet(CS.EnChar + "aa", Me.GetSetContainingEnChar(CS.EnChar + "a").FontChar + LongChar, CharSets.ගතකුරු3))
        Next
        For Each CS In CharSets.හල්2CSets
            Me.add(New CharSet(CS.EnChar + "aa", Me.GetSetContainingEnChar(CS.EnChar + "a").FontChar + LongChar, CharSets.ගතකුරු4))
        Next

        '______________________________________________________________________________________________
        'ඉස්පිල්ල
        Dim IChar = Me.GetSetContainingEnChar(CharSets.පිල්ලම්1CSets(1).EnChar).FontChar

        For Each CS In CharSets.හල්1CSets
            Me.add(New CharSet(CS.EnChar + "i", Me.GetSetContainingEnChar(CS.EnChar + "a").FontChar + IChar, CharSets.ගතකුරු2))
        Next
        For Each CS In CharSets.හල්2CSets
            Me.add(New CharSet(CS.EnChar + "i", Me.GetSetContainingEnChar(CS.EnChar + "a").FontChar + IChar, CharSets.ගතකුරු3))
        Next

        '______________________________________________________________________________________________
        'පාපිල්ල
        Dim UChar = Me.GetSetContainingEnChar(CharSets.පිල්ලම්1CSets(2).EnChar).FontChar

        For Each CS In CharSets.හල්1CSets
            Me.add(New CharSet(CS.EnChar + "u", Me.GetSetContainingEnChar(CS.EnChar + "a").FontChar + UChar, CharSets.ගතකුරු2))
        Next
        For Each CS In CharSets.හල්2CSets
            Me.add(New CharSet(CS.EnChar + "u", Me.GetSetContainingEnChar(CS.EnChar + "a").FontChar + UChar, CharSets.ගතකුරු3))
        Next


        '______________________________________________________________________________________________
        'කොම්බුව 
        Dim EChar = Me.GetSetContainingEnChar(CharSets.පිල්ලම්1CSets(3).EnChar).FontChar

        For Each CS In CharSets.හල්1CSets
            Me.add(New CharSet(CS.EnChar + "e", EChar + Me.GetSetContainingEnChar(CS.EnChar + "a").FontChar, CharSets.ගතකුරු2))
        Next
        For Each CS In CharSets.හල්2CSets
            Me.add(New CharSet(CS.EnChar + "e", EChar + Me.GetSetContainingEnChar(CS.EnChar + "a").FontChar, CharSets.ගතකුරු3))
        Next



        '______________________________________________________________________________________________
        'කොම්බුව + ඇලපිල්ල

        For Each CS In CharSets.හල්1CSets
            Me.add(New CharSet(CS.EnChar + "o", EChar + Me.GetSetContainingEnChar(CS.EnChar + "a").FontChar + LongChar, CharSets.ගතකුරු2))
        Next
        For Each CS In CharSets.හල්2CSets
            Me.add(New CharSet(CS.EnChar + "o", EChar + Me.GetSetContainingEnChar(CS.EnChar + "a").FontChar + LongChar, CharSets.ගතකුරු3))
        Next



        '______________________________________________________________________________________________
        'ඇ පිල්ල
        Dim aeChar = Me.GetSetContainingEnChar(CharSets.පිල්ලම්2CSets(1).EnChar).FontChar

        For Each CS In CharSets.හල්1CSets
            Me.add(New CharSet(CS.EnChar + "ae", Me.GetSetContainingEnChar(CS.EnChar + "a").FontChar + aeChar, CharSets.ගතකුරු3))
        Next
        For Each CS In CharSets.හල්2CSets
            Me.add(New CharSet(CS.EnChar + "ae", Me.GetSetContainingEnChar(CS.EnChar + "a").FontChar + aeChar, CharSets.ගතකුරු4))
        Next

        '______________________________________________________________________________________________
        'ඈ පිල්ල 
        Dim aEEChar = Me.GetSetContainingEnChar(CharSets.පිල්ලම්2CSets(2).EnChar).FontChar

        For Each CS In CharSets.හල්1CSets
            Me.add(New CharSet(CS.EnChar + "aE", Me.GetSetContainingEnChar(CS.EnChar + "a").FontChar + aEEChar, CharSets.ගතකුරු3))
        Next
        For Each CS In CharSets.හල්2CSets
            Me.add(New CharSet(CS.EnChar + "aE", Me.GetSetContainingEnChar(CS.EnChar + "a").FontChar + aEEChar, CharSets.ගතකුරු4))
        Next

        Genarated = True


        '______________________________________________________________________________________________
        'ඊ පිල්ල 
        Dim iiChar = Me.GetSetContainingEnChar(CharSets.පිල්ලම්2CSets(3).EnChar).FontChar

        For Each CS In CharSets.හල්1CSets
            Me.add(New CharSet(CS.EnChar + "ii", Me.GetSetContainingEnChar(CS.EnChar + "a").FontChar + iiChar, CharSets.ගතකුරු3))
        Next
        For Each CS In CharSets.හල්2CSets
            Me.add(New CharSet(CS.EnChar + "ii", Me.GetSetContainingEnChar(CS.EnChar + "a").FontChar + iiChar, CharSets.ගතකුරු4))
        Next

        Genarated = True


        '______________________________________________________________________________________________
        'දීර්ඝ පාපිල්ල 
        Dim uuChar = Me.GetSetContainingEnChar(CharSets.පිල්ලම්2CSets(4).EnChar).FontChar

        For Each CS In CharSets.හල්1CSets
            Me.add(New CharSet(CS.EnChar + "uu", Me.GetSetContainingEnChar(CS.EnChar + "a").FontChar + uuChar, CharSets.ගතකුරු3))
        Next
        For Each CS In CharSets.හල්2CSets
            Me.add(New CharSet(CS.EnChar + "uu", Me.GetSetContainingEnChar(CS.EnChar + "a").FontChar + uuChar, CharSets.ගතකුරු4))
        Next


        '______________________________________________________________________________________________
        'කෘ පිල්ල 
        Dim ruChar = Me.GetSetContainingEnChar(CharSets.පිල්ලම්2CSets(5).EnChar).FontChar

        For Each CS In CharSets.හල්1CSets
            Me.add(New CharSet(CS.EnChar + "~u", Me.GetSetContainingEnChar(CS.EnChar + "a").FontChar + ruChar, CharSets.ගතකුරු3))
        Next
        For Each CS In CharSets.හල්2CSets
            Me.add(New CharSet(CS.EnChar + "~u", Me.GetSetContainingEnChar(CS.EnChar + "a").FontChar + ruChar, CharSets.ගතකුරු4))
        Next


        '______________________________________________________________________________________________
        'කෲ පිල්ල 
        Dim rUUChar = Me.GetSetContainingEnChar(CharSets.පිල්ලම්2CSets(6).EnChar).FontChar

        For Each CS In CharSets.හල්1CSets
            Me.add(New CharSet(CS.EnChar + "~U", Me.GetSetContainingEnChar(CS.EnChar + "a").FontChar + rUUChar, CharSets.ගතකුරු3))
        Next
        For Each CS In CharSets.හල්2CSets
            Me.add(New CharSet(CS.EnChar + "~U", Me.GetSetContainingEnChar(CS.EnChar + "a").FontChar + rUUChar, CharSets.ගතකුරු4))
        Next

        '______________________________________________________________________________________________
        'eeකේ පිල්ල 

        For Each CS In CharSets.හල්1CSets
            Me.add(New CharSet(CS.EnChar + "ee", EChar + Me.GetSetContainingEnChar(CS.EnChar + "a").FontChar + hChar, CharSets.ගතකුරු3))
        Next
        For Each CS In CharSets.හල්2CSets
            Me.add(New CharSet(CS.EnChar + "ee", EChar + Me.GetSetContainingEnChar(CS.EnChar + "a").FontChar + hChar, CharSets.ගතකුරු4))
        Next


        '______________________________________________________________________________________________
        'aiකෛ පිල්ල 
        Dim aiChar = Me.GetSetContainingEnChar(CharSets.පිල්ලම්2CSets(8).EnChar).FontChar
        For Each CS In CharSets.හල්1CSets
            Me.add(New CharSet(CS.EnChar + "ai", aiChar + Me.GetSetContainingEnChar(CS.EnChar + "a").FontChar, CharSets.ගතකුරු3))
        Next
        For Each CS In CharSets.හල්2CSets
            Me.add(New CharSet(CS.EnChar + "ai", aiChar + Me.GetSetContainingEnChar(CS.EnChar + "a").FontChar, CharSets.ගතකුරු4))
        Next


        '______________________________________________________________________________________________
        'ooකෝ පිල්ල 
        Dim ooChar = Me.GetSetContainingEnChar(CharSets.පිල්ලම්2CSets(9).EnChar).FontChar
        For Each CS In CharSets.හල්1CSets
            Me.add(New CharSet(CS.EnChar + "oo", EChar + Me.GetSetContainingEnChar(CS.EnChar + "a").FontChar + ooChar, CharSets.ගතකුරු3))
        Next
        For Each CS In CharSets.හල්2CSets
            Me.add(New CharSet(CS.EnChar + "oo", EChar + Me.GetSetContainingEnChar(CS.EnChar + "a").FontChar + ooChar, CharSets.ගතකුරු4))
        Next

        '______________________________________________________________________________________________
        'ooකෞ පිල්ල 
        Dim auChar = Me.GetSetContainingEnChar(CharSets.පිල්ලම්2CSets(10).EnChar).FontChar
        For Each CS In CharSets.හල්1CSets
            Me.add(New CharSet(CS.EnChar + "au", EChar + Me.GetSetContainingEnChar(CS.EnChar + "a").FontChar + auChar, CharSets.ගතකුරු3))
        Next
        For Each CS In CharSets.හල්2CSets
            Me.add(New CharSet(CS.EnChar + "au", EChar + Me.GetSetContainingEnChar(CS.EnChar + "a").FontChar + auChar, CharSets.ගතකුරු4))
        Next



        Genarated = True

    End Sub


    Public Enum GenaratingStyle
        AllLetters
        Genarative
    End Enum


End Class




Public Class Converter
    Public FM As FontMap
    Public F As Font


    Public Function Convert(Str As String, ByRef CV As String) As String

        Dim Out = ""

        Dim Words = Str.Split(" ")


        For Each Word In Words

            Out += ConvertClause(0, Word.Length, Word, "") + " "
            Dim IsSingleWord = True

            CV += GenarateCVCode(Word, IsSingleWord) + " "


        Next
        Out.Substring(0, Out.Length - 1)



        Return Out
    End Function





    Public Function ConvertClause(Start As Integer, Length As Integer, Word As String, Out As String) As String

        '012.45


        Dim clause = Word.Substring(Start, Length)

        Dim IsSingleWord = True
        Dim CVCode = GenarateCVCode(clause, IsSingleWord)

        If Not IsSingleWord Then

            Dim n = 0
            For Each SC In CVCode.Split(" ")
                If SC <> "" Then
                    Out = ConvertClause(0, SC.Length, clause.Substring(n, SC.Length), Out)

                    If n + SC.Length < clause.Length Then
                        Out += clause.Chars(n + SC.Length)
                    End If


                End If

                n += SC.Length + 1
            Next

            Return Out
            Exit Function
        End If


        Dim T = FindTypeOfCVCode(CVCode)

        If IsNothing(T) Then
            'CV code error. Resume next
            If Length < 1 Then
                Return Out
            Else
                Out = ConvertClause(Start, Length - 1, Word, Out)
                Return Out
            End If

        Else
            If T.Strings.Contains(clause) Then

                Out += FM.GetSetContainingEnChar(clause).FontChar


                Start = Start + Length

                If Start = Word.Length Then
                    Return Out
                Else
                    Out = ConvertClause(Start, Word.Length - Start, Word, Out)
                    Return Out
                End If

            Else
                'CV code wrong. So type doesn't contain the clause. Resume next
                If Length < 1 Then
                    Return Out
                Else
                    Out = ConvertClause(Start, Length - 1, Word, Out)
                    Return Out
                End If
            End If
        End If


    End Function




    Public Vowels() As String
    Public Consonants() As String

    Public CCode As String = "c"
    Public VCode As String = "v"
    Public WrongCode As String = " "

    Public Function GenarateCVCode(S As String, ByRef SingleWord As Boolean) As String


        Dim O = ""

        Dim C As Char
        For n = 0 To S.Length - 1

            ' O += GetCV(S.ElementAt(n))

            C = S.ElementAt(n)

            If Vowels.Contains(C) Then
                O += VCode
            ElseIf Consonants.Contains(c) Then
                O += CCode
            Else
                O += WrongCode
                SingleWord = False
            End If

        Next


        Return O

    End Function


    Public Function GetCV(S As String) As String

        If Vowels.Contains(S) Then
            Return VCode
        ElseIf Consonants.Contains(S) Then
            Return CCode
        Else
            Return WrongCode
        End If

    End Function


    Public Function FindTypeOfCVCode(CV As String) As CharSets.Type

        Select Case CV

            Case "ccvv" 'chae
                Return CharSets.ගතකුරු4
            Case "cvvv" 'kaee
                Return CharSets.ගතකුරු4
            Case "cvv" 'kaa
                Return CharSets.ගතකුරු3
            Case "ccv" 'cha
                Return CharSets.ගතකුරු3
            Case "cv" 'ka
                Return CharSets.ගතකුරු2

            Case "vv" 'a
                Return CharSets.ස්වර2
            Case "cc" 'th
                Return CharSets.හල්2

            Case "c" 'k
                Return CharSets.හල්1

            Case "v" 'a
                Return CharSets.ස්වර1

            Case Else
                Return Nothing
        End Select


    End Function



End Class

