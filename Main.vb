Imports System.Text
Imports System.IO

Public Class Main
    Dim RichTextBoxSize As Integer = 712
    Dim chr As Integer = 0
    Dim Path As SaveFileDialog
    Dim DgResult As Windows.Forms.DialogResult

    Public C As Converter
    Public FMper As FontMaper
    Public Shared FM As FontMap

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CharSets.Initialize()

        FMper = New FontMaper
        C = New Converter


        RT1.Focus()
        'setting the size of the richtextbox
        'RichTextBox1.Size = New Point(RichTextBoxSize, RichTextBox1.Height)
        'centering the richtextbox in the middle of the form
        'RichTextBox1.Location = New Point((Me.Size.Width - RichTextBoxSize) / 2, RichTextBox1.Location.Y)
        'calling the below function to start the context ment (when the user right click the richtextbox
        InitializeMyContextMenu()






        Dim reader As New System.Xml.Serialization.XmlSerializer(GetType(FontMap))
        Dim File As New IO.StreamReader("GenFontMapForFMAbhaya.xml", System.Text.Encoding.Unicode)

        Dim Map = CType(reader.Deserialize(File), FontMap)

        FMper.OpenMap(Map)

        FM = FMper.FM

        C.FM = FM
        C.F = FMper.FFont

        C.Consonants = FM.Consonants
        C.Vowels = FM.Vowels




        RT2.Font = FMper.FFont


        RT1.Text = "mahinda raajapakSHa jaathika paasala hoomaagama"

    End Sub

    Private Sub InitializeMyContextMenu()
        ' Create the contextMenu and the MenuItem to add.
        Dim contextMenu1 As New ContextMenu()
        Dim menuItem1 As New MenuItem("C&ut")
        AddHandler menuItem1.Click, AddressOf CutButton_Click
        Dim menuItem2 As New MenuItem("&Copy")
        AddHandler menuItem2.Click, AddressOf CopyButton_Click
        Dim menuItem3 As New MenuItem("&Paste")
        AddHandler menuItem3.Click, AddressOf PasteButton_Click
        ' Use the MenuItems property to call the Add method
        ' to add the MenuItem to the MainMenu menu item collection. 
        contextMenu1.MenuItems.Add(menuItem1)
        contextMenu1.MenuItems.Add(menuItem2)
        contextMenu1.MenuItems.Add(menuItem3)
        ' Assign mainMenu1 to the rich text box.
        RT1.ContextMenu = contextMenu1
    End Sub

    'Private Sub Create_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
    '    If Me.Size.Width > RichTextBoxSize + 100 Then
    '        RichTextBox1.Width = RichTextBoxSize
    '        RichTextBox1.Anchor = AnchorStyles.None
    '        RichTextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
    '        RichTextBox1.Location = New Point((Me.Size.Width - RichTextBoxSize) / 2, RichTextBox1.Location.Y)
    '    End If
    '    If Me.Size.Width <= RichTextBoxSize + 100 Then
    '        If RichTextBox1.Location.X < 10 Then
    '            RichTextBox1.Location = New Point(10, RichTextBox1.Location.Y)
    '        End If
    '        If RichTextBox1.Width + 50 > Me.Size.Width Then
    '            RichTextBox1.Size = New Point(Me.Size.Width - 20 - RichTextBox1.Location.X, RichTextBox1.Size.Height)
    '        End If
    '        RichTextBox1.Anchor = AnchorStyles.None
    '        RichTextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
    '    End If
    'End Sub

    'Private Sub Create_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
    '    If Me.Size.Width > RichTextBoxSize + 100 Then
    '        RichTextBox1.Width = RichTextBoxSize
    '        RichTextBox1.Anchor = AnchorStyles.None
    '        RichTextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
    '        RichTextBox1.Location = New Point((Me.Size.Width - RichTextBoxSize) / 2, RichTextBox1.Location.Y)
    '    End If
    '    If Me.Size.Width <= RichTextBoxSize + 100 Then
    '        If RichTextBox1.Location.X < 10 Then
    '            RichTextBox1.Location = New Point(10, RichTextBox1.Location.Y)
    '        End If
    '        If RichTextBox1.Width + 50 > Me.Size.Width Then
    '            RichTextBox1.Size = New Point(Me.Size.Width - 20 - RichTextBox1.Location.X, RichTextBox1.Size.Height)
    '        End If
    '        RichTextBox1.Anchor = AnchorStyles.None
    '        RichTextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
    '    End If
    'End Sub


    Private Sub CopyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyButton.Click
        My.Computer.Clipboard.Clear()
        Try
            Clipboard.SetText(RT1.SelectedText)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub CutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutButton.Click
        My.Computer.Clipboard.Clear()
        Try
            Clipboard.SetText(RT1.SelectedText)
            RT1.SelectedText = ""
        Catch ex As Exception

        End Try

    End Sub

    Private Sub PasteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteButton.Click
        If My.Computer.Clipboard.ContainsText Then
            RT1.Paste()
        End If

    End Sub

    Private Sub UndoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoButton.Click
        RT1.Undo()
        RT1.Focus()

    End Sub

    Private Sub ReDoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReDoButton.Click
        RT1.Redo()
        RT1.Focus()

    End Sub

    Private Sub BoldButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoldButton.Click
        If RT1.SelectionFont.Bold = True Then
            If RT1.SelectionFont.Italic = True Then
                RT1.SelectionFont = New Font(Me.RT1.SelectionFont, FontStyle.Regular + FontStyle.Italic)
            Else
                RT1.SelectionFont = New Font(Me.RT1.SelectionFont, FontStyle.Regular)
            End If

        ElseIf RT1.SelectionFont.Bold = False Then
            If RT1.SelectionFont.Italic = True Then
                RT1.SelectionFont = New Font(Me.RT1.SelectionFont, FontStyle.Bold + FontStyle.Italic)
            Else
                RT1.SelectionFont = New Font(Me.RT1.SelectionFont, FontStyle.Bold)
            End If
        End If
        RT1.Focus()

    End Sub

    Private Sub ItalicButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItalicButton.Click
        If RT1.SelectionFont.Italic = True Then
            If RT1.SelectionFont.Bold = True Then
                RT1.SelectionFont = New Font(Me.RT1.SelectionFont, FontStyle.Regular + FontStyle.Bold)
            Else
                RT1.SelectionFont = New Font(Me.RT1.SelectionFont, FontStyle.Regular)
            End If

        ElseIf RT1.SelectionFont.Italic = False Then
            If RT1.SelectionFont.Bold = True Then
                RT1.SelectionFont = New Font(Me.RT1.SelectionFont, FontStyle.Italic + FontStyle.Bold)
            Else
                RT1.SelectionFont = New Font(Me.RT1.SelectionFont, FontStyle.Italic)
            End If
        End If
        RT1.Focus()

    End Sub

    Private Sub FontButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontButton.Click
        Dim fontDialod As New FontDialog
        fontDialod.Font = RT1.SelectionFont
        fontDialod.ShowDialog()
        RT1.SelectionFont = fontDialod.Font
        RT1.Focus()

    End Sub

    Private Sub SizeUpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SizeUpButton.Click
        Try
            RT1.Font = New Font(RT1.SelectionFont.FontFamily, Int(RT1.SelectionFont.SizeInPoints + 5))
            RT2.Font = New Font(RT2.SelectionFont.FontFamily, Int(RT2.SelectionFont.SizeInPoints + 5))

        Catch ex As Exception
        End Try
        RT1.Focus()

    End Sub

    Private Sub SizeDownButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SizeDownButton.Click
        Try
            RT1.Font = New Font(RT1.SelectionFont.FontFamily, Int(RT1.SelectionFont.SizeInPoints - 5))
        Catch ex As Exception
        End Try
        RT1.Focus()

    End Sub

    Private Sub ChangeFontColorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeFontColorButton.Click
        Dim colorDialog As New ColorDialog
        colorDialog.Color = RT1.SelectionColor
        colorDialog.ShowDialog()
        RT1.SelectionColor = colorDialog.Color
        RT1.Focus()

    End Sub

    Private Sub ChangeHighliterColorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeHighliterColorButton.Click
        Dim colorDialog As New ColorDialog
        colorDialog.Color = RT1.SelectionBackColor
        colorDialog.ShowDialog()
        RT1.SelectionBackColor = colorDialog.Color
        RT1.Focus()

    End Sub

    Private Sub ChangeBackgroundColorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeBackgroundColorButton.Click
        Dim colorDialog As New ColorDialog
        colorDialog.Color = RT1.BackColor
        colorDialog.ShowDialog()
        RT1.BackColor = colorDialog.Color
        RT1.Focus()

    End Sub

    Private Sub alignLeftButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles alignLeftButton.Click
        RT1.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub AlignCenterButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlignCenterButton.Click
        RT1.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub AlignRightButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlignRightButton.Click
        RT1.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub RichTextBox1_CursorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RT1.CursorChanged



    End Sub

    Private Sub RichTextBox1_ImeChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles RT1.ImeChange

    End Sub


    Public Obj As New Object
    Public evntArg As New EventArgs
    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RT1.TextChanged, RT1.CursorChanged, RT1.Click, RT1.Enter, RT1.KeyDown

        If RT1.Text = "" Then
            RT2.Clear()
            Exit Sub
        End If


        'TCV.Text = C.GenarateCVCode(RT1.Text)

        Dim CV = ""
        RT2.Text = C.Convert(RT1.Text, CV)
        TCV.Text = CV

    End Sub

    Private Sub ConvertClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        RT2.Clear()
        Dim ctr As Char() = RT1.Text.ToCharArray()
        For count = 0 To ctr.Length - 1
            If ctr(count) = "\r\n(\w+)" Then
                RT2.AppendText("\r\n(\w+)")
            ElseIf ctr(count) = "a" Then
                RT2.AppendText("අ")
            ElseIf ctr(count) = "u" Then
                RT2.AppendText("උ")
            ElseIf ctr(count) = "e" Then
                RT2.AppendText("එ")
            ElseIf ctr(count) = "i" Then
                RT2.AppendText("ඉ")
            ElseIf ctr(count) = "o" Then
                RT2.AppendText("ඔ")
            ElseIf ctr(count) = "k" Then
                RT2.AppendText("ක්")
            ElseIf ctr(count) = "K" Then
                RT2.AppendText("ඛ්")
            ElseIf ctr(count) = "g" Then
                RT2.AppendText("ග්")
            ElseIf ctr(count) = "G" Then
                RT2.AppendText("ඝ්")
            ElseIf ctr(count) = "n" Then
                RT2.AppendText("න්")
            ElseIf ctr(count) = "t" Then
                RT2.AppendText("ට්")
            ElseIf ctr(count) = "T" Then
                RT2.AppendText("ඨ්")
            ElseIf ctr(count) = "d" Then
                RT2.AppendText("ඩ්")
            ElseIf ctr(count) = "D" Then
                RT2.AppendText("ද්")
            ElseIf ctr(count) = "N" Then
                RT2.AppendText("ණ්")
            ElseIf ctr(count) = "s" Then
                RT2.AppendText("ස්")
            ElseIf ctr(count) = "S" Then
                RT2.AppendText("ෂ්")
            ElseIf ctr(count) = "H" Then
                RT2.AppendText("ශ්")
            ElseIf ctr(count) = "h" Then
                RT2.AppendText("හ්")
            ElseIf ctr(count) = "L" Then
                RT2.AppendText("ළ")
            ElseIf ctr(count) = "f" Then
                RT2.AppendText("ෆ්")
            ElseIf ctr(count) = "y" Then
                RT2.AppendText("ය්")
            ElseIf ctr(count) = "r" Then
                RT2.AppendText("ර්")
            ElseIf ctr(count) = "l" Then
                RT2.AppendText("ල්")
            ElseIf ctr(count) = "w" Then
                RT2.AppendText("ව්")
            ElseIf ctr(count) = "m" Then
                RT2.AppendText("ම්")
            ElseIf ctr(count) = "p" Then
                RT2.AppendText("ප්")
            ElseIf ctr(count) = "b" Then
                RT2.AppendText("බ්")
            ElseIf ctr(count) = "1" Then
                RT2.AppendText("1")
            ElseIf ctr(count) = "2" Then
                RT2.AppendText("2")
            ElseIf ctr(count) = "3" Then
                RT2.AppendText("3")
            ElseIf ctr(count) = "4" Then
                RT2.AppendText("4")
            ElseIf ctr(count) = "5" Then
                RT2.AppendText("5")
            ElseIf ctr(count) = "6" Then
                RT2.AppendText("6")
            ElseIf ctr(count) = "7" Then
                RT2.AppendText("7")
            ElseIf ctr(count) = "8" Then
                RT2.AppendText("8")
            ElseIf ctr(count) = "9" Then
                RT2.AppendText("9")
            ElseIf ctr(count) = "0" Then
                RT2.AppendText("0")
            ElseIf ctr(count) = " " Then
                RT2.AppendText(" ")

            End If

        Next
        RT1.Focus()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        RT1.Clear()
        RT2.Clear()

    End Sub

    Private Sub AboutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutButton.Click

        AbtUs.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        My.Computer.Clipboard.Clear()

        Try

            Clipboard.SetText(RT2.Text)

            MsgBox(Clipboard.GetText() & " Successfully Copied!")

        Catch ex As Exception

            MsgBox(ex.ToString())

        End Try

    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click


        Path = New SaveFileDialog()

        DgResult = Path.ShowDialog(Me)

        RT1.SaveFile(DgResult.ToString(), System.Windows.Forms.RichTextBoxStreamType.UnicodePlainText)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        FMper = New FontMaper

        FMper.OpenMap(FM)

        FMper.ShowDialog()

        RT2.Font = New Font(FM.F, RT2.Font.Size)

        C.FM = FM
        C.F = New Font(FM.F, RT2.Font.Size)

        C.Consonants = FM.Consonants
        C.Vowels = FM.Vowels

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        FMper = New FontMaper
        FMper.ShowDialog()

        RT2.Font = New Font(FM.F, RT2.Font.Size)

        C.F = New Font(FM.F, RT2.Font.Size)
        C.FM = FM

    End Sub




End Class
