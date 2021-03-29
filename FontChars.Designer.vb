<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FontCharsForm
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
        Me.LstEn = New System.Windows.Forms.ListBox()
        Me.LstFont = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'LstEn
        '
        Me.LstEn.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.LstEn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstEn.ForeColor = System.Drawing.Color.Snow
        Me.LstEn.FormattingEnabled = True
        Me.LstEn.ItemHeight = 24
        Me.LstEn.Items.AddRange(New Object() {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "~", "`", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+", "-", "=", "{", "}", "[", "]", ":", """", ";", "'", "<", ">", ",", ".", "?", "/", "|", "\", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", " "})
        Me.LstEn.Location = New System.Drawing.Point(1, 2)
        Me.LstEn.Name = "LstEn"
        Me.LstEn.Size = New System.Drawing.Size(50, 460)
        Me.LstEn.TabIndex = 0
        '
        'LstFont
        '
        Me.LstFont.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.LstFont.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstFont.ForeColor = System.Drawing.Color.Snow
        Me.LstFont.FormattingEnabled = True
        Me.LstFont.ItemHeight = 24
        Me.LstFont.Items.AddRange(New Object() {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "~", "`", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+", "-", "=", "{", "}", "[", "]", ":", """", ";", "'", "<", ">", ",", ".", "?", "/", "|", "\", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", " "})
        Me.LstFont.Location = New System.Drawing.Point(57, 2)
        Me.LstFont.Name = "LstFont"
        Me.LstFont.Size = New System.Drawing.Size(56, 460)
        Me.LstFont.TabIndex = 1
        '
        'FontCharsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(111, 463)
        Me.Controls.Add(Me.LstFont)
        Me.Controls.Add(Me.LstEn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FontCharsForm"
        Me.Text = "FontChars"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LstEn As ListBox
    Friend WithEvents LstFont As ListBox
End Class
