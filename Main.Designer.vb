<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.UndoButton = New System.Windows.Forms.ToolStripButton()
        Me.ReDoButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveButton = New System.Windows.Forms.ToolStripButton()
        Me.BoldButton = New System.Windows.Forms.ToolStripButton()
        Me.ItalicButton = New System.Windows.Forms.ToolStripButton()
        Me.FontButton = New System.Windows.Forms.ToolStripButton()
        Me.SizeUpButton = New System.Windows.Forms.ToolStripButton()
        Me.SizeDownButton = New System.Windows.Forms.ToolStripButton()
        Me.ChangeFontColorButton = New System.Windows.Forms.ToolStripButton()
        Me.ChangeHighliterColorButton = New System.Windows.Forms.ToolStripButton()
        Me.ChangeBackgroundColorButton = New System.Windows.Forms.ToolStripButton()
        Me.alignLeftButton = New System.Windows.Forms.ToolStripButton()
        Me.AlignCenterButton = New System.Windows.Forms.ToolStripButton()
        Me.AlignRightButton = New System.Windows.Forms.ToolStripButton()
        Me.CopyButton = New System.Windows.Forms.ToolStripButton()
        Me.CutButton = New System.Windows.Forms.ToolStripButton()
        Me.PasteButton = New System.Windows.Forms.ToolStripButton()
        Me.AboutButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.RT1 = New System.Windows.Forms.RichTextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TTChar = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RT2 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TCV = New System.Windows.Forms.TextBox()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoButton, Me.ReDoButton, Me.SaveButton, Me.BoldButton, Me.ItalicButton, Me.FontButton, Me.SizeUpButton, Me.SizeDownButton, Me.ChangeFontColorButton, Me.ChangeHighliterColorButton, Me.ChangeBackgroundColorButton, Me.alignLeftButton, Me.AlignCenterButton, Me.AlignRightButton, Me.CopyButton, Me.CutButton, Me.PasteButton, Me.AboutButton, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1016, 32)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'UndoButton
        '
        Me.UndoButton.AutoSize = False
        Me.UndoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UndoButton.Image = CType(resources.GetObject("UndoButton.Image"), System.Drawing.Image)
        Me.UndoButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UndoButton.Name = "UndoButton"
        Me.UndoButton.Size = New System.Drawing.Size(32, 32)
        Me.UndoButton.Text = "Undo"
        '
        'ReDoButton
        '
        Me.ReDoButton.AutoSize = False
        Me.ReDoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ReDoButton.Image = CType(resources.GetObject("ReDoButton.Image"), System.Drawing.Image)
        Me.ReDoButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ReDoButton.Name = "ReDoButton"
        Me.ReDoButton.Size = New System.Drawing.Size(32, 32)
        Me.ReDoButton.Text = "ReDo"
        '
        'SaveButton
        '
        Me.SaveButton.AutoSize = False
        Me.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveButton.Image = CType(resources.GetObject("SaveButton.Image"), System.Drawing.Image)
        Me.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(32, 32)
        Me.SaveButton.Text = "Save"
        '
        'BoldButton
        '
        Me.BoldButton.AutoSize = False
        Me.BoldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BoldButton.Image = CType(resources.GetObject("BoldButton.Image"), System.Drawing.Image)
        Me.BoldButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BoldButton.Name = "BoldButton"
        Me.BoldButton.Size = New System.Drawing.Size(32, 32)
        Me.BoldButton.Text = "Bold"
        '
        'ItalicButton
        '
        Me.ItalicButton.AutoSize = False
        Me.ItalicButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ItalicButton.Image = CType(resources.GetObject("ItalicButton.Image"), System.Drawing.Image)
        Me.ItalicButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ItalicButton.Name = "ItalicButton"
        Me.ItalicButton.Size = New System.Drawing.Size(32, 32)
        Me.ItalicButton.Text = "Italic"
        '
        'FontButton
        '
        Me.FontButton.AutoSize = False
        Me.FontButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FontButton.Image = CType(resources.GetObject("FontButton.Image"), System.Drawing.Image)
        Me.FontButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FontButton.Name = "FontButton"
        Me.FontButton.Size = New System.Drawing.Size(32, 32)
        Me.FontButton.Text = "Font"
        '
        'SizeUpButton
        '
        Me.SizeUpButton.AutoSize = False
        Me.SizeUpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SizeUpButton.Image = CType(resources.GetObject("SizeUpButton.Image"), System.Drawing.Image)
        Me.SizeUpButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SizeUpButton.Name = "SizeUpButton"
        Me.SizeUpButton.Size = New System.Drawing.Size(32, 32)
        Me.SizeUpButton.Text = "Increase Font Size"
        '
        'SizeDownButton
        '
        Me.SizeDownButton.AutoSize = False
        Me.SizeDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SizeDownButton.Image = CType(resources.GetObject("SizeDownButton.Image"), System.Drawing.Image)
        Me.SizeDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SizeDownButton.Name = "SizeDownButton"
        Me.SizeDownButton.Size = New System.Drawing.Size(32, 32)
        Me.SizeDownButton.Text = "Decrease Font Size"
        '
        'ChangeFontColorButton
        '
        Me.ChangeFontColorButton.AutoSize = False
        Me.ChangeFontColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ChangeFontColorButton.Image = CType(resources.GetObject("ChangeFontColorButton.Image"), System.Drawing.Image)
        Me.ChangeFontColorButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ChangeFontColorButton.Name = "ChangeFontColorButton"
        Me.ChangeFontColorButton.Size = New System.Drawing.Size(32, 32)
        Me.ChangeFontColorButton.Text = "Font Color"
        '
        'ChangeHighliterColorButton
        '
        Me.ChangeHighliterColorButton.AutoSize = False
        Me.ChangeHighliterColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ChangeHighliterColorButton.Image = CType(resources.GetObject("ChangeHighliterColorButton.Image"), System.Drawing.Image)
        Me.ChangeHighliterColorButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ChangeHighliterColorButton.Name = "ChangeHighliterColorButton"
        Me.ChangeHighliterColorButton.Size = New System.Drawing.Size(32, 32)
        Me.ChangeHighliterColorButton.Text = "Highlight Color"
        '
        'ChangeBackgroundColorButton
        '
        Me.ChangeBackgroundColorButton.AutoSize = False
        Me.ChangeBackgroundColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ChangeBackgroundColorButton.Image = CType(resources.GetObject("ChangeBackgroundColorButton.Image"), System.Drawing.Image)
        Me.ChangeBackgroundColorButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ChangeBackgroundColorButton.Name = "ChangeBackgroundColorButton"
        Me.ChangeBackgroundColorButton.Size = New System.Drawing.Size(32, 32)
        Me.ChangeBackgroundColorButton.Text = "Background Color"
        '
        'alignLeftButton
        '
        Me.alignLeftButton.AutoSize = False
        Me.alignLeftButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.alignLeftButton.Image = CType(resources.GetObject("alignLeftButton.Image"), System.Drawing.Image)
        Me.alignLeftButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.alignLeftButton.Name = "alignLeftButton"
        Me.alignLeftButton.Size = New System.Drawing.Size(32, 32)
        Me.alignLeftButton.Text = "Align Left"
        '
        'AlignCenterButton
        '
        Me.AlignCenterButton.AutoSize = False
        Me.AlignCenterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AlignCenterButton.Image = CType(resources.GetObject("AlignCenterButton.Image"), System.Drawing.Image)
        Me.AlignCenterButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AlignCenterButton.Name = "AlignCenterButton"
        Me.AlignCenterButton.Size = New System.Drawing.Size(32, 32)
        Me.AlignCenterButton.Text = "Align Center"
        '
        'AlignRightButton
        '
        Me.AlignRightButton.AutoSize = False
        Me.AlignRightButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AlignRightButton.Image = CType(resources.GetObject("AlignRightButton.Image"), System.Drawing.Image)
        Me.AlignRightButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AlignRightButton.Name = "AlignRightButton"
        Me.AlignRightButton.Size = New System.Drawing.Size(32, 32)
        Me.AlignRightButton.Text = "Align Right"
        '
        'CopyButton
        '
        Me.CopyButton.AutoSize = False
        Me.CopyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyButton.Image = CType(resources.GetObject("CopyButton.Image"), System.Drawing.Image)
        Me.CopyButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(32, 32)
        Me.CopyButton.Text = "Copy"
        '
        'CutButton
        '
        Me.CutButton.AutoSize = False
        Me.CutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CutButton.Image = CType(resources.GetObject("CutButton.Image"), System.Drawing.Image)
        Me.CutButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutButton.Name = "CutButton"
        Me.CutButton.Size = New System.Drawing.Size(32, 32)
        Me.CutButton.Text = "Cut"
        '
        'PasteButton
        '
        Me.PasteButton.AutoSize = False
        Me.PasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteButton.Image = CType(resources.GetObject("PasteButton.Image"), System.Drawing.Image)
        Me.PasteButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteButton.Name = "PasteButton"
        Me.PasteButton.Size = New System.Drawing.Size(32, 32)
        Me.PasteButton.Text = "Paste"
        '
        'AboutButton
        '
        Me.AboutButton.AutoSize = False
        Me.AboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AboutButton.Image = CType(resources.GetObject("AboutButton.Image"), System.Drawing.Image)
        Me.AboutButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(32, 32)
        Me.AboutButton.Text = "About"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 29)
        Me.ToolStripButton1.Text = "Font Map"
        '
        'RT1
        '
        Me.RT1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RT1.Location = New System.Drawing.Point(12, 35)
        Me.RT1.Name = "RT1"
        Me.RT1.Size = New System.Drawing.Size(495, 450)
        Me.RT1.TabIndex = 1
        Me.RT1.Text = ""
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5, Me.TTChar, Me.ToolStripProgressBar1, Me.ToolStripStatusLabel6})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 527)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1016, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(33, 17)
        Me.ToolStripStatusLabel1.Text = "Row:"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(13, 17)
        Me.ToolStripStatusLabel2.Text = "0"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(28, 17)
        Me.ToolStripStatusLabel3.Text = "Col:"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(13, 17)
        Me.ToolStripStatusLabel4.Text = "0"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(724, 17)
        Me.ToolStripStatusLabel5.Text = resources.GetString("ToolStripStatusLabel5.Text")
        '
        'TTChar
        '
        Me.TTChar.Name = "TTChar"
        Me.TTChar.Size = New System.Drawing.Size(41, 17)
        Me.TTChar.Text = "Locale"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(120, 15)
        Me.ToolStripStatusLabel6.Text = "ToolStripStatusLabel6"
        '
        'RT2
        '
        Me.RT2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RT2.Location = New System.Drawing.Point(513, 35)
        Me.RT2.Name = "RT2"
        Me.RT2.Size = New System.Drawing.Size(495, 405)
        Me.RT2.TabIndex = 1
        Me.RT2.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(394, 491)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Convert"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(475, 491)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(556, 491)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Copy"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TCV
        '
        Me.TCV.Location = New System.Drawing.Point(513, 446)
        Me.TCV.Multiline = True
        Me.TCV.Name = "TCV"
        Me.TCV.Size = New System.Drawing.Size(495, 39)
        Me.TCV.TabIndex = 6
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 29)
        Me.ToolStripButton2.Text = "New font map"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1016, 549)
        Me.Controls.Add(Me.TCV)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.RT2)
        Me.Controls.Add(Me.RT1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "Unicode Text Editor"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents UndoButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ReDoButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents BoldButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ItalicButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents FontButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SizeUpButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SizeDownButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ChangeFontColorButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ChangeHighliterColorButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ChangeBackgroundColorButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents alignLeftButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents AlignCenterButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents AlignRightButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CopyButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CutButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PasteButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents RT1 As System.Windows.Forms.RichTextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TTChar As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents RT2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents AboutButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripStatusLabel6 As ToolStripStatusLabel
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents TCV As TextBox
    Friend WithEvents ToolStripButton2 As ToolStripButton
End Class
