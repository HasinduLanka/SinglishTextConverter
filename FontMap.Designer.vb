<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FontMaper
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
        Me.components = New System.ComponentModel.Container()
        Me.EnChar = New System.Windows.Forms.ListBox()
        Me.FontChar = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtFontChar = New System.Windows.Forms.TextBox()
        Me.BtnNewMap = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SaveDia = New System.Windows.Forms.SaveFileDialog()
        Me.TxtEnChar = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Log = New System.Windows.Forms.TextBox()
        Me.BtnOpen = New System.Windows.Forms.Button()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.ODia = New System.Windows.Forms.OpenFileDialog()
        Me.ColorEffect = New System.Windows.Forms.Timer(Me.components)
        Me.LstType = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbType = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'EnChar
        '
        Me.EnChar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnChar.FormattingEnabled = True
        Me.EnChar.ItemHeight = 24
        Me.EnChar.Location = New System.Drawing.Point(6, 47)
        Me.EnChar.Name = "EnChar"
        Me.EnChar.Size = New System.Drawing.Size(147, 484)
        Me.EnChar.TabIndex = 0
        '
        'FontChar
        '
        Me.FontChar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FontChar.FormattingEnabled = True
        Me.FontChar.ItemHeight = 24
        Me.FontChar.Location = New System.Drawing.Point(159, 47)
        Me.FontChar.Name = "FontChar"
        Me.FontChar.Size = New System.Drawing.Size(147, 484)
        Me.FontChar.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "English Char"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(156, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sinhala font char"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(489, 89)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(265, 29)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Change Char set"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtFontChar
        '
        Me.TxtFontChar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFontChar.Location = New System.Drawing.Point(579, 51)
        Me.TxtFontChar.Name = "TxtFontChar"
        Me.TxtFontChar.Size = New System.Drawing.Size(91, 26)
        Me.TxtFontChar.TabIndex = 7
        '
        'BtnNewMap
        '
        Me.BtnNewMap.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnNewMap.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewMap.ForeColor = System.Drawing.Color.Gold
        Me.BtnNewMap.Location = New System.Drawing.Point(652, 442)
        Me.BtnNewMap.Name = "BtnNewMap"
        Me.BtnNewMap.Size = New System.Drawing.Size(102, 43)
        Me.BtnNewMap.TabIndex = 8
        Me.BtnNewMap.Text = "New Map"
        Me.BtnNewMap.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.DarkRed
        Me.Button3.Location = New System.Drawing.Point(575, 442)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(71, 43)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Save"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'SaveDia
        '
        Me.SaveDia.DefaultExt = "xml"
        Me.SaveDia.FileName = "FontMap.xml"
        Me.SaveDia.SupportMultiDottedExtensions = True
        '
        'TxtEnChar
        '
        Me.TxtEnChar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEnChar.Location = New System.Drawing.Point(489, 51)
        Me.TxtEnChar.Name = "TxtEnChar"
        Me.TxtEnChar.Size = New System.Drawing.Size(84, 26)
        Me.TxtEnChar.TabIndex = 10
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(489, 124)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(265, 26)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Add Char set"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Log
        '
        Me.Log.Location = New System.Drawing.Point(489, 192)
        Me.Log.Multiline = True
        Me.Log.Name = "Log"
        Me.Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Log.Size = New System.Drawing.Size(265, 158)
        Me.Log.TabIndex = 12
        '
        'BtnOpen
        '
        Me.BtnOpen.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOpen.ForeColor = System.Drawing.Color.Aqua
        Me.BtnOpen.Location = New System.Drawing.Point(489, 442)
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(85, 43)
        Me.BtnOpen.TabIndex = 13
        Me.BtnOpen.Text = "Open"
        Me.BtnOpen.UseVisualStyleBackColor = False
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Location = New System.Drawing.Point(497, 514)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(38, 13)
        Me.LblStatus.TabIndex = 14
        Me.LblStatus.Text = "Ready"
        '
        'ODia
        '
        Me.ODia.DefaultExt = "xml"
        Me.ODia.FileName = "FontMap.xml"
        Me.ODia.Filter = "Font Map XML files|*.xml|All files|*.*"
        Me.ODia.RestoreDirectory = True
        Me.ODia.Title = "Open Font Map"
        '
        'ColorEffect
        '
        Me.ColorEffect.Interval = 500
        '
        'LstType
        '
        Me.LstType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstType.FormattingEnabled = True
        Me.LstType.ItemHeight = 24
        Me.LstType.Location = New System.Drawing.Point(312, 47)
        Me.LstType.Name = "LstType"
        Me.LstType.Size = New System.Drawing.Size(147, 484)
        Me.LstType.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(309, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Char set type"
        '
        'CmbType
        '
        Me.CmbType.AutoCompleteCustomSource.AddRange(New String() {"හල්1", "හල්2", "ස්වර1", "ස්වර2", "ස්වර3", "ගතකුරු2", "ගතකුරු3", "ගතකුරු4", "ගතකුරු5", "පිල්ලම්1", "පිල්ලම්2", "පිල්ලම්3"})
        Me.CmbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbType.FormattingEnabled = True
        Me.CmbType.Items.AddRange(New Object() {"හල්1", "හල්2", "ස්වර1", "ස්වර2", "ස්වර3", "ගතකුරු2", "ගතකුරු3", "ගතකුරු4", "ගතකුරු5", "පිල්ලම්1", "පිල්ලම්2", "පිල්ලම්3"})
        Me.CmbType.Location = New System.Drawing.Point(676, 51)
        Me.CmbType.Name = "CmbType"
        Me.CmbType.Size = New System.Drawing.Size(78, 28)
        Me.CmbType.TabIndex = 15
        Me.CmbType.Text = "හල්1"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Lime
        Me.Button2.Location = New System.Drawing.Point(489, 393)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 43)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Edit Template"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Purple
        Me.Button5.Location = New System.Drawing.Point(617, 393)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(132, 43)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "View font chars"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(489, 156)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(265, 26)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "Delete Char set"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'FontMaper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(761, 536)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CmbType)
        Me.Controls.Add(Me.LblStatus)
        Me.Controls.Add(Me.BtnOpen)
        Me.Controls.Add(Me.Log)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TxtEnChar)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.BtnNewMap)
        Me.Controls.Add(Me.TxtFontChar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LstType)
        Me.Controls.Add(Me.FontChar)
        Me.Controls.Add(Me.EnChar)
        Me.Name = "FontMaper"
        Me.Text = "FontMap"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EnChar As ListBox
    Friend WithEvents FontChar As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtFontChar As TextBox
    Friend WithEvents BtnNewMap As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents SaveDia As SaveFileDialog
    Friend WithEvents TxtEnChar As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Log As TextBox
    Friend WithEvents BtnOpen As Button
    Friend WithEvents LblStatus As Label
    Friend WithEvents ODia As OpenFileDialog
    Friend WithEvents ColorEffect As Timer
    Friend WithEvents LstType As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CmbType As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
