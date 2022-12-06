<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.clsbtn = New System.Windows.Forms.Button()
        Me.logbtn = New System.Windows.Forms.Button()
        Me.shwbtn = New System.Windows.Forms.CheckBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'clsbtn
        '
        Me.clsbtn.Location = New System.Drawing.Point(459, 445)
        Me.clsbtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.clsbtn.Name = "clsbtn"
        Me.clsbtn.Size = New System.Drawing.Size(118, 54)
        Me.clsbtn.TabIndex = 14
        Me.clsbtn.Text = "Close"
        Me.clsbtn.UseVisualStyleBackColor = True
        '
        'logbtn
        '
        Me.logbtn.Location = New System.Drawing.Point(310, 445)
        Me.logbtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.logbtn.Name = "logbtn"
        Me.logbtn.Size = New System.Drawing.Size(118, 54)
        Me.logbtn.TabIndex = 13
        Me.logbtn.Text = "Login"
        Me.logbtn.UseVisualStyleBackColor = True
        '
        'shwbtn
        '
        Me.shwbtn.AutoSize = True
        Me.shwbtn.BackColor = System.Drawing.Color.Transparent
        Me.shwbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shwbtn.Location = New System.Drawing.Point(310, 348)
        Me.shwbtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.shwbtn.Name = "shwbtn"
        Me.shwbtn.Size = New System.Drawing.Size(165, 26)
        Me.shwbtn.TabIndex = 12
        Me.shwbtn.Text = "Show Password"
        Me.shwbtn.UseVisualStyleBackColor = False
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(310, 245)
        Me.txtuser.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtuser.Multiline = True
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(303, 43)
        Me.txtuser.TabIndex = 11
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(310, 296)
        Me.txtpass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpass.Multiline = True
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(303, 43)
        Me.txtpass.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(173, 296)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 27)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(173, 245)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Username"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(827, 587)
        Me.Controls.Add(Me.clsbtn)
        Me.Controls.Add(Me.logbtn)
        Me.Controls.Add(Me.shwbtn)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents clsbtn As Button
    Friend WithEvents logbtn As Button
    Friend WithEvents shwbtn As CheckBox
    Friend WithEvents txtuser As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
