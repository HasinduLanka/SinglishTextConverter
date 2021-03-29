<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Edit_Template
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LblFont = New System.Windows.Forms.Label()
        Me.RBAllLetters = New System.Windows.Forms.RadioButton()
        Me.RBGenarative = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnGenarate = New System.Windows.Forms.Button()
        Me.LstCons = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LstVowels = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TxtCVAdd = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(2, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(278, 37)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Change font"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LblFont
        '
        Me.LblFont.AutoSize = True
        Me.LblFont.Location = New System.Drawing.Point(12, 52)
        Me.LblFont.Name = "LblFont"
        Me.LblFont.Size = New System.Drawing.Size(39, 13)
        Me.LblFont.TabIndex = 1
        Me.LblFont.Text = "Label1"
        '
        'RBAllLetters
        '
        Me.RBAllLetters.AutoSize = True
        Me.RBAllLetters.Checked = True
        Me.RBAllLetters.Location = New System.Drawing.Point(24, 22)
        Me.RBAllLetters.Name = "RBAllLetters"
        Me.RBAllLetters.Size = New System.Drawing.Size(160, 17)
        Me.RBAllLetters.TabIndex = 4
        Me.RBAllLetters.TabStop = True
        Me.RBAllLetters.Text = "සියලු අකුරු ඇතුලත් කිරීම"
        Me.RBAllLetters.UseVisualStyleBackColor = True
        '
        'RBGenarative
        '
        Me.RBGenarative.AutoSize = True
        Me.RBGenarative.Location = New System.Drawing.Point(24, 51)
        Me.RBGenarative.Name = "RBGenarative"
        Me.RBGenarative.Size = New System.Drawing.Size(245, 30)
        Me.RBGenarative.TabIndex = 5
        Me.RBGenarative.Text = "ස්වර, පිල්ලම් රහිත ගතකුරු, පිල්ලම්" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " ඇතුලත් කිරීමෙන් ඉතිරි අකුරු සාදා ගැනීම"
        Me.RBGenarative.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.RBGenarative)
        Me.GroupBox1.Controls.Add(Me.RBAllLetters)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 129)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(278, 131)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Font map සාදන ක්‍රමය  වෙනස් කිරීම"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(118, 98)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(154, 27)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "නව Font Map සාදන්න"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnGenarate
        '
        Me.BtnGenarate.Enabled = False
        Me.BtnGenarate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenarate.Location = New System.Drawing.Point(2, 277)
        Me.BtnGenarate.Name = "BtnGenarate"
        Me.BtnGenarate.Size = New System.Drawing.Size(278, 32)
        Me.BtnGenarate.TabIndex = 7
        Me.BtnGenarate.Text = "ඉතිරි අකුරු  සාදන්න"
        Me.BtnGenarate.UseVisualStyleBackColor = True
        '
        'LstCons
        '
        Me.LstCons.FormattingEnabled = True
        Me.LstCons.Location = New System.Drawing.Point(2, 346)
        Me.LstCons.Name = "LstCons"
        Me.LstCons.Size = New System.Drawing.Size(64, 95)
        Me.LstCons.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-1, 330)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ගතකුරු"
        '
        'LstVowels
        '
        Me.LstVowels.FormattingEnabled = True
        Me.LstVowels.Location = New System.Drawing.Point(95, 346)
        Me.LstVowels.Name = "LstVowels"
        Me.LstVowels.Size = New System.Drawing.Size(64, 95)
        Me.LstVowels.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(92, 330)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ස්වර"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(2, 447)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(64, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Add"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(95, 447)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(64, 23)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Add"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TxtCVAdd
        '
        Me.TxtCVAdd.Location = New System.Drawing.Point(165, 346)
        Me.TxtCVAdd.Name = "TxtCVAdd"
        Me.TxtCVAdd.Size = New System.Drawing.Size(115, 20)
        Me.TxtCVAdd.TabIndex = 11
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(2, 476)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(64, 23)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(95, 476)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(64, 23)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "Delete"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Edit_Template
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(292, 506)
        Me.Controls.Add(Me.TxtCVAdd)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LstVowels)
        Me.Controls.Add(Me.LstCons)
        Me.Controls.Add(Me.BtnGenarate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblFont)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Edit_Template"
        Me.Text = "Edit_Template"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents LblFont As Label
    Friend WithEvents RBAllLetters As RadioButton
    Friend WithEvents RBGenarative As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnGenarate As Button
    Friend WithEvents LstCons As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LstVowels As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TxtCVAdd As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
