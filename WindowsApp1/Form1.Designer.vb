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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Table1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Supermarket_Data_2DataSet = New WindowsApp1.supermarket_Data_2DataSet()
        Me.Supermarket_Data_2DataSet1 = New WindowsApp1.supermarket_Data_2DataSet1()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Supermarket_DataDataSet = New WindowsApp1.supermarket_DataDataSet()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Table1TableAdapter = New WindowsApp1.supermarket_DataDataSetTableAdapters.Table1TableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtinput = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Table1TableAdapter1 = New WindowsApp1.supermarket_Data_2DataSetTableAdapters.Table1TableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NICNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobileNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Table1TableAdapter2 = New WindowsApp1.supermarket_Data_2DataSet1TableAdapters.Table1TableAdapter()
        Me.SupermarketData2DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Table1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Supermarket_Data_2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Supermarket_Data_2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Supermarket_DataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupermarketData2DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(197, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name :"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource1, "Customer name", True))
        Me.TextBox1.Location = New System.Drawing.Point(341, 170)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(165, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Table1BindingSource1
        '
        Me.Table1BindingSource1.DataMember = "Table1"
        Me.Table1BindingSource1.DataSource = Me.Supermarket_Data_2DataSet
        '
        'Supermarket_Data_2DataSet
        '
        Me.Supermarket_Data_2DataSet.DataSetName = "supermarket_Data_2DataSet"
        Me.Supermarket_Data_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Supermarket_Data_2DataSet1
        '
        Me.Supermarket_Data_2DataSet1.DataSetName = "supermarket_Data_2DataSet1"
        Me.Supermarket_Data_2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.Supermarket_DataDataSet
        '
        'Supermarket_DataDataSet
        '
        Me.Supermarket_DataDataSet.DataSetName = "supermarket_DataDataSet"
        Me.Supermarket_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource1, "NIC No", True))
        Me.TextBox2.Location = New System.Drawing.Point(341, 223)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(165, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(185, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NIC No :"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource1, "Mobile No", True))
        Me.TextBox3.Location = New System.Drawing.Point(341, 274)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(165, 20)
        Me.TextBox3.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(156, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Mobile No :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(818, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(257, 42)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Company Name"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(202, 328)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "<<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(283, 328)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = ">>"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(364, 328)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Add New"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(445, 328)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(283, 376)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Save"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(364, 376)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "Close"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(677, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'txtinput
        '
        Me.txtinput.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource1, "Customer ID", True))
        Me.txtinput.Location = New System.Drawing.Point(341, 119)
        Me.txtinput.Name = "txtinput"
        Me.txtinput.Size = New System.Drawing.Size(165, 20)
        Me.txtinput.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(135, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 25)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Customer ID :"
        '
        'Table1TableAdapter1
        '
        Me.Table1TableAdapter1.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDDataGridViewTextBoxColumn, Me.NICNoDataGridViewTextBoxColumn, Me.CustomerNameDataGridViewTextBoxColumn, Me.MobileNoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Table1BindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 428)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(640, 256)
        Me.DataGridView1.TabIndex = 17
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer ID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "Customer ID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        Me.CustomerIDDataGridViewTextBoxColumn.Width = 150
        '
        'NICNoDataGridViewTextBoxColumn
        '
        Me.NICNoDataGridViewTextBoxColumn.DataPropertyName = "NIC No"
        Me.NICNoDataGridViewTextBoxColumn.HeaderText = "NIC No"
        Me.NICNoDataGridViewTextBoxColumn.Name = "NICNoDataGridViewTextBoxColumn"
        Me.NICNoDataGridViewTextBoxColumn.Width = 150
        '
        'CustomerNameDataGridViewTextBoxColumn
        '
        Me.CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "Customer name"
        Me.CustomerNameDataGridViewTextBoxColumn.HeaderText = "Customer name"
        Me.CustomerNameDataGridViewTextBoxColumn.Name = "CustomerNameDataGridViewTextBoxColumn"
        Me.CustomerNameDataGridViewTextBoxColumn.Width = 150
        '
        'MobileNoDataGridViewTextBoxColumn
        '
        Me.MobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile No"
        Me.MobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile No"
        Me.MobileNoDataGridViewTextBoxColumn.Name = "MobileNoDataGridViewTextBoxColumn"
        Me.MobileNoDataGridViewTextBoxColumn.Width = 150
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(1087, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Digital Token"
        '
        'pic
        '
        Me.pic.Location = New System.Drawing.Point(891, 170)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(421, 422)
        Me.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pic.TabIndex = 19
        Me.pic.TabStop = False
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(923, 624)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(129, 23)
        Me.btnGenerate.TabIndex = 20
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(1188, 624)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 21
        Me.Button8.Text = "Print"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "Barcode"
        Me.SaveFileDialog1.Filter = "PNG Image | *.png"
        '
        'Table1TableAdapter2
        '
        Me.Table1TableAdapter2.ClearBeforeFill = True
        '
        'SupermarketData2DataSet1BindingSource
        '
        Me.SupermarketData2DataSet1BindingSource.DataSource = Me.Supermarket_Data_2DataSet1
        Me.SupermarketData2DataSet1BindingSource.Position = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(145, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 20)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Date Time"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1395, 696)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.pic)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtinput)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Company Application"
        CType(Me.Table1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Supermarket_Data_2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Supermarket_Data_2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Supermarket_DataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupermarketData2DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Supermarket_DataDataSet As supermarket_DataDataSet
    Friend WithEvents Table1BindingSource As BindingSource
    Friend WithEvents Table1TableAdapter As supermarket_DataDataSetTableAdapters.Table1TableAdapter
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtinput As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Supermarket_Data_2DataSet As supermarket_Data_2DataSet
    Friend WithEvents Table1BindingSource1 As BindingSource
    Friend WithEvents Table1TableAdapter1 As supermarket_Data_2DataSetTableAdapters.Table1TableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents pic As PictureBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Supermarket_Data_2DataSet1 As supermarket_Data_2DataSet1
    Friend WithEvents Table1TableAdapter2 As supermarket_Data_2DataSet1TableAdapters.Table1TableAdapter
    Friend WithEvents SupermarketData2DataSet1BindingSource As BindingSource
    Friend WithEvents Label7 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NICNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MobileNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
