<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
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
        Me.searchbox = New System.Windows.Forms.TextBox()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.address = New System.Windows.Forms.TextBox()
        Me.cpno = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.record = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cono = New System.Windows.Forms.TextBox()
        Me.school = New System.Windows.Forms.TextBox()
        Me.suffix = New System.Windows.Forms.TextBox()
        Me.dor = New System.Windows.Forms.TextBox()
        Me.last_name = New System.Windows.Forms.TextBox()
        Me.first_name = New System.Windows.Forms.TextBox()
        Me.guestID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ref = New System.Windows.Forms.Button()
        Me.del = New System.Windows.Forms.Button()
        Me.Edit = New System.Windows.Forms.Button()
        Me.Add = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.column0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'searchbox
        '
        Me.searchbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchbox.Location = New System.Drawing.Point(206, 29)
        Me.searchbox.Multiline = True
        Me.searchbox.Name = "searchbox"
        Me.searchbox.Size = New System.Drawing.Size(500, 46)
        Me.searchbox.TabIndex = 25
        '
        'DataGridView5
        '
        Me.DataGridView5.AllowUserToDeleteRows = False
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.column0, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView5.Location = New System.Drawing.Point(32, 380)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.ReadOnly = True
        Me.DataGridView5.RowHeadersWidth = 51
        Me.DataGridView5.RowTemplate.Height = 24
        Me.DataGridView5.Size = New System.Drawing.Size(1168, 268)
        Me.DataGridView5.TabIndex = 45
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(510, 309)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 25)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "ADDRESS"
        '
        'address
        '
        Me.address.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.Location = New System.Drawing.Point(643, 300)
        Me.address.Multiline = True
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(513, 45)
        Me.address.TabIndex = 43
        '
        'cpno
        '
        Me.cpno.AutoSize = True
        Me.cpno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpno.Location = New System.Drawing.Point(464, 253)
        Me.cpno.Name = "cpno"
        Me.cpno.Size = New System.Drawing.Size(152, 25)
        Me.cpno.TabIndex = 42
        Me.cpno.Text = "CONTACT NO."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(520, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 25)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "SCHOOL"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.searchbox)
        Me.Panel1.Controls.Add(Me.record)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(-3, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1259, 109)
        Me.Panel1.TabIndex = 46
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(16, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 45)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "SEARCH"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'record
        '
        Me.record.BackColor = System.Drawing.Color.Transparent
        Me.record.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.record.Location = New System.Drawing.Point(774, 20)
        Me.record.Name = "record"
        Me.record.Size = New System.Drawing.Size(177, 62)
        Me.record.TabIndex = 7
        Me.record.Text = "RECORDS"
        Me.record.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(966, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(177, 62)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "BOOKS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.Black
        Me.back.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.ForeColor = System.Drawing.Color.White
        Me.back.Location = New System.Drawing.Point(1094, 195)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(115, 45)
        Me.back.TabIndex = 47
        Me.back.Text = "BACK"
        Me.back.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(450, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 20)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "DATE OF REGISTRY"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 25)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "SUFFIX"
        '
        'cono
        '
        Me.cono.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cono.Location = New System.Drawing.Point(643, 246)
        Me.cono.Multiline = True
        Me.cono.Name = "cono"
        Me.cono.Size = New System.Drawing.Size(265, 45)
        Me.cono.TabIndex = 31
        '
        'school
        '
        Me.school.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.school.Location = New System.Drawing.Point(643, 195)
        Me.school.Multiline = True
        Me.school.Name = "school"
        Me.school.Size = New System.Drawing.Size(265, 45)
        Me.school.TabIndex = 30
        '
        'suffix
        '
        Me.suffix.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.suffix.Location = New System.Drawing.Point(177, 300)
        Me.suffix.Multiline = True
        Me.suffix.Name = "suffix"
        Me.suffix.Size = New System.Drawing.Size(265, 45)
        Me.suffix.TabIndex = 29
        '
        'dor
        '
        Me.dor.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dor.Location = New System.Drawing.Point(643, 142)
        Me.dor.Multiline = True
        Me.dor.Name = "dor"
        Me.dor.Size = New System.Drawing.Size(265, 45)
        Me.dor.TabIndex = 28
        '
        'last_name
        '
        Me.last_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.last_name.Location = New System.Drawing.Point(177, 246)
        Me.last_name.Multiline = True
        Me.last_name.Name = "last_name"
        Me.last_name.Size = New System.Drawing.Size(265, 45)
        Me.last_name.TabIndex = 27
        '
        'first_name
        '
        Me.first_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.first_name.Location = New System.Drawing.Point(177, 191)
        Me.first_name.Multiline = True
        Me.first_name.Name = "first_name"
        Me.first_name.Size = New System.Drawing.Size(265, 45)
        Me.first_name.TabIndex = 26
        '
        'guestID
        '
        Me.guestID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guestID.Location = New System.Drawing.Point(177, 139)
        Me.guestID.Multiline = True
        Me.guestID.Name = "guestID"
        Me.guestID.Size = New System.Drawing.Size(265, 46)
        Me.guestID.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 25)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "FIRST NAME"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 25)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "GUEST ID."
        '
        'ref
        '
        Me.ref.BackColor = System.Drawing.Color.Black
        Me.ref.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ref.ForeColor = System.Drawing.Color.White
        Me.ref.Location = New System.Drawing.Point(1094, 144)
        Me.ref.Name = "ref"
        Me.ref.Size = New System.Drawing.Size(115, 45)
        Me.ref.TabIndex = 35
        Me.ref.Text = "REF"
        Me.ref.UseVisualStyleBackColor = False
        '
        'del
        '
        Me.del.BackColor = System.Drawing.Color.Black
        Me.del.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.del.ForeColor = System.Drawing.Color.White
        Me.del.Location = New System.Drawing.Point(973, 246)
        Me.del.Name = "del"
        Me.del.Size = New System.Drawing.Size(115, 45)
        Me.del.TabIndex = 34
        Me.del.Text = "DEL"
        Me.del.UseVisualStyleBackColor = False
        '
        'Edit
        '
        Me.Edit.BackColor = System.Drawing.Color.Black
        Me.Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit.ForeColor = System.Drawing.Color.White
        Me.Edit.Location = New System.Drawing.Point(973, 195)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(115, 45)
        Me.Edit.TabIndex = 33
        Me.Edit.Text = "EDIT"
        Me.Edit.UseVisualStyleBackColor = False
        '
        'Add
        '
        Me.Add.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Add.Location = New System.Drawing.Point(973, 144)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(115, 45)
        Me.Add.TabIndex = 32
        Me.Add.Text = "ADD"
        Me.Add.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 25)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "LAST NAME"
        '
        'column0
        '
        Me.column0.DataPropertyName = "GuestID"
        Me.column0.HeaderText = "guestID"
        Me.column0.MinimumWidth = 6
        Me.column0.Name = "column0"
        Me.column0.ReadOnly = True
        Me.column0.Width = 125
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "FirstName"
        Me.Column1.HeaderText = "First Name"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "LastName"
        Me.Column2.HeaderText = "Last Name"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Suffix"
        Me.Column3.HeaderText = "Suffix"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "dateOfRegistration"
        Me.Column4.HeaderText = "Date Of Registry"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "school"
        Me.Column5.HeaderText = "School"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "contactNo"
        Me.Column6.HeaderText = "ContactNo"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 125
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "Address"
        Me.Column7.HeaderText = "Address"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 125
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(1253, 654)
        Me.Controls.Add(Me.DataGridView5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.cpno)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cono)
        Me.Controls.Add(Me.school)
        Me.Controls.Add(Me.suffix)
        Me.Controls.Add(Me.dor)
        Me.Controls.Add(Me.last_name)
        Me.Controls.Add(Me.first_name)
        Me.Controls.Add(Me.guestID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ref)
        Me.Controls.Add(Me.del)
        Me.Controls.Add(Me.Edit)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Form11"
        Me.Text = "guest"
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents searchbox As TextBox
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents address As TextBox
    Friend WithEvents cpno As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents record As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents back As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cono As TextBox
    Friend WithEvents school As TextBox
    Friend WithEvents suffix As TextBox
    Friend WithEvents dor As TextBox
    Friend WithEvents last_name As TextBox
    Friend WithEvents first_name As TextBox
    Friend WithEvents guestID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ref As Button
    Friend WithEvents del As Button
    Friend WithEvents Edit As Button
    Friend WithEvents Add As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents column0 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
