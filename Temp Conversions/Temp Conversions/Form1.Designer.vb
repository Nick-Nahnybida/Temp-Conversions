<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt8AM = New System.Windows.Forms.TextBox()
        Me.txt5PM = New System.Windows.Forms.TextBox()
        Me.txt12PM = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lbl8AM = New System.Windows.Forms.Label()
        Me.lbl5PM = New System.Windows.Forms.Label()
        Me.lbl12PM = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fahrenheit to Celsius Converter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Put in Fahrenheit " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    temp below"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "8:00 am"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "12:00 pm"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "5:00 pm"
        '
        'txt8AM
        '
        Me.txt8AM.Location = New System.Drawing.Point(99, 98)
        Me.txt8AM.Name = "txt8AM"
        Me.txt8AM.Size = New System.Drawing.Size(100, 20)
        Me.txt8AM.TabIndex = 5
        '
        'txt5PM
        '
        Me.txt5PM.Location = New System.Drawing.Point(99, 172)
        Me.txt5PM.Name = "txt5PM"
        Me.txt5PM.Size = New System.Drawing.Size(100, 20)
        Me.txt5PM.TabIndex = 6
        '
        'txt12PM
        '
        Me.txt12PM.Location = New System.Drawing.Point(99, 134)
        Me.txt12PM.Name = "txt12PM"
        Me.txt12PM.Size = New System.Drawing.Size(100, 20)
        Me.txt12PM.TabIndex = 7
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(16, 241)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 8
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(124, 241)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(235, 241)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lbl8AM
        '
        Me.lbl8AM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl8AM.Location = New System.Drawing.Point(213, 97)
        Me.lbl8AM.Name = "lbl8AM"
        Me.lbl8AM.Size = New System.Drawing.Size(100, 21)
        Me.lbl8AM.TabIndex = 11
        '
        'lbl5PM
        '
        Me.lbl5PM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl5PM.Location = New System.Drawing.Point(213, 172)
        Me.lbl5PM.Name = "lbl5PM"
        Me.lbl5PM.Size = New System.Drawing.Size(100, 20)
        Me.lbl5PM.TabIndex = 12
        '
        'lbl12PM
        '
        Me.lbl12PM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl12PM.Location = New System.Drawing.Point(213, 133)
        Me.lbl12PM.Name = "lbl12PM"
        Me.lbl12PM.Size = New System.Drawing.Size(100, 21)
        Me.lbl12PM.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(210, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 30)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Celsius Temperature"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 354)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl12PM)
        Me.Controls.Add(Me.lbl5PM)
        Me.Controls.Add(Me.lbl8AM)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txt12PM)
        Me.Controls.Add(Me.txt5PM)
        Me.Controls.Add(Me.txt8AM)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt8AM As System.Windows.Forms.TextBox
    Friend WithEvents txt5PM As System.Windows.Forms.TextBox
    Friend WithEvents txt12PM As System.Windows.Forms.TextBox
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lbl8AM As System.Windows.Forms.Label
    Friend WithEvents lbl5PM As System.Windows.Forms.Label
    Friend WithEvents lbl12PM As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
