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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BloodBankBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BloodbankFinalDataSet = New BloodBankProjectFinal.BloodbankFinalDataSet()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BloodgroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BlooodamountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DoneridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonarFirstDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonarLastDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhonenumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoOfDonersDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.BloodBankTableAdapter = New BloodBankProjectFinal.BloodbankFinalDataSetTableAdapters.BloodBankTableAdapter()
        CType(Me.BloodBankBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BloodbankFinalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(27, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Blood_group"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(27, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bloood_amount"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(27, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Doner_id"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(27, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Donar_First"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(27, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Donar_Last"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(27, 314)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Age"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(27, 376)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(27, 434)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Phone_number"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(27, 489)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Gender"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(24, 551)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "No of Doners"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloodBankBindingSource, "Blood_group", True))
        Me.TextBox1.Location = New System.Drawing.Point(181, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(162, 25)
        Me.TextBox1.TabIndex = 10
        '
        'BloodBankBindingSource
        '
        Me.BloodBankBindingSource.DataMember = "BloodBank"
        Me.BloodBankBindingSource.DataSource = Me.BloodbankFinalDataSet
        '
        'BloodbankFinalDataSet
        '
        Me.BloodbankFinalDataSet.DataSetName = "BloodbankFinalDataSet"
        Me.BloodbankFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloodBankBindingSource, "Bloood_amount", True))
        Me.TextBox2.Location = New System.Drawing.Point(181, 74)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(162, 25)
        Me.TextBox2.TabIndex = 11
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloodBankBindingSource, "Doner_id", True))
        Me.TextBox3.Location = New System.Drawing.Point(181, 132)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(162, 25)
        Me.TextBox3.TabIndex = 12
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloodBankBindingSource, "Donar_First", True))
        Me.TextBox4.Location = New System.Drawing.Point(181, 190)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(162, 25)
        Me.TextBox4.TabIndex = 13
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloodBankBindingSource, "Donar_Last", True))
        Me.TextBox5.Location = New System.Drawing.Point(181, 249)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(162, 25)
        Me.TextBox5.TabIndex = 14
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloodBankBindingSource, "Age", True))
        Me.TextBox6.Location = New System.Drawing.Point(181, 309)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(162, 25)
        Me.TextBox6.TabIndex = 15
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloodBankBindingSource, "Date", True))
        Me.TextBox7.Location = New System.Drawing.Point(181, 371)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(162, 25)
        Me.TextBox7.TabIndex = 16
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloodBankBindingSource, "Phone_number", True))
        Me.TextBox8.Location = New System.Drawing.Point(181, 434)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(162, 25)
        Me.TextBox8.TabIndex = 17
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloodBankBindingSource, "Gender", True))
        Me.TextBox9.Location = New System.Drawing.Point(181, 489)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(162, 25)
        Me.TextBox9.TabIndex = 18
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloodBankBindingSource, "No of Doners", True))
        Me.TextBox10.Location = New System.Drawing.Point(181, 551)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(162, 25)
        Me.TextBox10.TabIndex = 19
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BloodgroupDataGridViewTextBoxColumn, Me.BlooodamountDataGridViewTextBoxColumn, Me.DoneridDataGridViewTextBoxColumn, Me.DonarFirstDataGridViewTextBoxColumn, Me.DonarLastDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.PhonenumberDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.NoOfDonersDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BloodBankBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(407, 46)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(632, 506)
        Me.DataGridView1.TabIndex = 20
        '
        'BloodgroupDataGridViewTextBoxColumn
        '
        Me.BloodgroupDataGridViewTextBoxColumn.DataPropertyName = "Blood_group"
        Me.BloodgroupDataGridViewTextBoxColumn.HeaderText = "Blood_group"
        Me.BloodgroupDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BloodgroupDataGridViewTextBoxColumn.Name = "BloodgroupDataGridViewTextBoxColumn"
        Me.BloodgroupDataGridViewTextBoxColumn.ReadOnly = True
        Me.BloodgroupDataGridViewTextBoxColumn.Width = 125
        '
        'BlooodamountDataGridViewTextBoxColumn
        '
        Me.BlooodamountDataGridViewTextBoxColumn.DataPropertyName = "Bloood_amount"
        Me.BlooodamountDataGridViewTextBoxColumn.HeaderText = "Bloood_amount"
        Me.BlooodamountDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BlooodamountDataGridViewTextBoxColumn.Name = "BlooodamountDataGridViewTextBoxColumn"
        Me.BlooodamountDataGridViewTextBoxColumn.ReadOnly = True
        Me.BlooodamountDataGridViewTextBoxColumn.Width = 125
        '
        'DoneridDataGridViewTextBoxColumn
        '
        Me.DoneridDataGridViewTextBoxColumn.DataPropertyName = "Doner_id"
        Me.DoneridDataGridViewTextBoxColumn.HeaderText = "Doner_id"
        Me.DoneridDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DoneridDataGridViewTextBoxColumn.Name = "DoneridDataGridViewTextBoxColumn"
        Me.DoneridDataGridViewTextBoxColumn.ReadOnly = True
        Me.DoneridDataGridViewTextBoxColumn.Width = 125
        '
        'DonarFirstDataGridViewTextBoxColumn
        '
        Me.DonarFirstDataGridViewTextBoxColumn.DataPropertyName = "Donar_First"
        Me.DonarFirstDataGridViewTextBoxColumn.HeaderText = "Donar_First"
        Me.DonarFirstDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DonarFirstDataGridViewTextBoxColumn.Name = "DonarFirstDataGridViewTextBoxColumn"
        Me.DonarFirstDataGridViewTextBoxColumn.ReadOnly = True
        Me.DonarFirstDataGridViewTextBoxColumn.Width = 125
        '
        'DonarLastDataGridViewTextBoxColumn
        '
        Me.DonarLastDataGridViewTextBoxColumn.DataPropertyName = "Donar_Last"
        Me.DonarLastDataGridViewTextBoxColumn.HeaderText = "Donar_Last"
        Me.DonarLastDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DonarLastDataGridViewTextBoxColumn.Name = "DonarLastDataGridViewTextBoxColumn"
        Me.DonarLastDataGridViewTextBoxColumn.ReadOnly = True
        Me.DonarLastDataGridViewTextBoxColumn.Width = 125
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        Me.AgeDataGridViewTextBoxColumn.ReadOnly = True
        Me.AgeDataGridViewTextBoxColumn.Width = 125
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateDataGridViewTextBoxColumn.Width = 125
        '
        'PhonenumberDataGridViewTextBoxColumn
        '
        Me.PhonenumberDataGridViewTextBoxColumn.DataPropertyName = "Phone_number"
        Me.PhonenumberDataGridViewTextBoxColumn.HeaderText = "Phone_number"
        Me.PhonenumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PhonenumberDataGridViewTextBoxColumn.Name = "PhonenumberDataGridViewTextBoxColumn"
        Me.PhonenumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.PhonenumberDataGridViewTextBoxColumn.Width = 125
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.ReadOnly = True
        Me.GenderDataGridViewTextBoxColumn.Width = 125
        '
        'NoOfDonersDataGridViewTextBoxColumn
        '
        Me.NoOfDonersDataGridViewTextBoxColumn.DataPropertyName = "No of Doners"
        Me.NoOfDonersDataGridViewTextBoxColumn.HeaderText = "No of Doners"
        Me.NoOfDonersDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NoOfDonersDataGridViewTextBoxColumn.Name = "NoOfDonersDataGridViewTextBoxColumn"
        Me.NoOfDonersDataGridViewTextBoxColumn.ReadOnly = True
        Me.NoOfDonersDataGridViewTextBoxColumn.Width = 125
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(30, 601)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 35)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "AddNew"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(165, 601)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 35)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Count"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(306, 601)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 35)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(30, 664)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 35)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "Previous"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(165, 664)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(86, 35)
        Me.Button5.TabIndex = 25
        Me.Button5.Text = "Save"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(306, 664)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(86, 35)
        Me.Button6.TabIndex = 26
        Me.Button6.Text = "Next"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'BloodBankTableAdapter
        '
        Me.BloodBankTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(1067, 714)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.BloodBankBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BloodbankFinalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents BloodbankFinalDataSet As BloodbankFinalDataSet
    Friend WithEvents BloodBankBindingSource As BindingSource
    Friend WithEvents BloodBankTableAdapter As BloodbankFinalDataSetTableAdapters.BloodBankTableAdapter
    Friend WithEvents BloodgroupDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BlooodamountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DoneridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DonarFirstDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DonarLastDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhonenumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoOfDonersDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
