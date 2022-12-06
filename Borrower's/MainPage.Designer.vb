<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPage))
        Me.student = New System.Windows.Forms.Button()
        Me.guest = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'student
        '
        Me.student.BackColor = System.Drawing.Color.Transparent
        Me.student.BackgroundImage = CType(resources.GetObject("student.BackgroundImage"), System.Drawing.Image)
        Me.student.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.student.Font = New System.Drawing.Font("Nasalization", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.student.Location = New System.Drawing.Point(227, 129)
        Me.student.Name = "student"
        Me.student.Size = New System.Drawing.Size(359, 68)
        Me.student.TabIndex = 0
        Me.student.UseVisualStyleBackColor = False
        '
        'guest
        '
        Me.guest.BackgroundImage = CType(resources.GetObject("guest.BackgroundImage"), System.Drawing.Image)
        Me.guest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.guest.Font = New System.Drawing.Font("Nasalization", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guest.Location = New System.Drawing.Point(227, 203)
        Me.guest.Name = "guest"
        Me.guest.Size = New System.Drawing.Size(359, 76)
        Me.guest.TabIndex = 1
        Me.guest.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("November", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(246, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 35)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "BORROWER'S PROFILE"
        '
        'button1
        '
        Me.button1.BackgroundImage = CType(resources.GetObject("button1.BackgroundImage"), System.Drawing.Image)
        Me.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button1.Font = New System.Drawing.Font("Nasalization", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(342, 301)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(146, 44)
        Me.button1.TabIndex = 3
        Me.button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(786, 435)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.guest)
        Me.Controls.Add(Me.student)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents student As Button
    Friend WithEvents guest As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents button1 As Button
End Class
